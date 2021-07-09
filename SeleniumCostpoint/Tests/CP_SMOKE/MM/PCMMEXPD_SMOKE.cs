 
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
    public class PCMMEXPD_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Production Control", "xpath","//div[@class='deptItem'][.='Production Control']").Click();
new SeleniumControl(sDriver,"Manufacturing Orders", "xpath","//div[@class='navItem'][.='Manufacturing Orders']").Click();
new SeleniumControl(sDriver,"Expedite Manufacturing Orders", "xpath","//div[@class='navItem'][.='Expedite Manufacturing Orders']").Click();


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
				Function.CurrentComponent = "PCMMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMEXPD] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl PCMMEXPD_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,PCMMEXPD_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMEXPD] Performing VerifyExists on Planner...", Logger.MessageType.INF);
				SeleniumControl PCMMEXPD_Planner = new SeleniumControl( sDriver, "Planner", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PLANNER']");
				Function.AssertEqual(true,PCMMEXPD_Planner.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMEXPD] Performing Set on Warehouse...", Logger.MessageType.INF);
				SeleniumControl PCMMEXPD_Warehouse = new SeleniumControl( sDriver, "Warehouse", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='WHSE_ID']");
				PCMMEXPD_Warehouse.Click();
PCMMEXPD_Warehouse.SendKeys("", true);
Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));
PCMMEXPD_Warehouse.SendKeys(OpenQA.Selenium.Keys.Shift + OpenQA.Selenium.Keys.Tab);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Set]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMEXPD] Performing VerifyIfBlank on Warehouse...", Logger.MessageType.INF);
				SeleniumControl PCMMEXPD_Warehouse = new SeleniumControl( sDriver, "Warehouse", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='WHSE_ID']");
				Function.AssertEqual(true,String.IsNullOrEmpty(PCMMEXPD_Warehouse.GetAttributeValue("value")));


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyIfBlank]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMEXPD] Performing ClickButton on ManufacturingOrdersForm...", Logger.MessageType.INF);
				SeleniumControl PCMMEXPD_ManufacturingOrdersForm = new SeleniumControl( sDriver, "ManufacturingOrdersForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMMEXPD_MOHDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCMMEXPD_ManufacturingOrdersForm);
IWebElement formBttn = PCMMEXPD_ManufacturingOrdersForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).Count <= 0 ? PCMMEXPD_ManufacturingOrdersForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Query')]")).FirstOrDefault() :
PCMMEXPD_ManufacturingOrdersForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).FirstOrDefault();
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
								try
				{
				this.ScriptLogger.WriteLine("ChildForm");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMEXPD] Performing VerifyExist on ManufacturingOrdersTable...", Logger.MessageType.INF);
				SeleniumControl PCMMEXPD_ManufacturingOrdersTable = new SeleniumControl( sDriver, "ManufacturingOrdersTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMMEXPD_MOHDR_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PCMMEXPD_ManufacturingOrdersTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMEXPD] Performing VerifyExists on ManufacturingOrdersForm...", Logger.MessageType.INF);
				SeleniumControl PCMMEXPD_ManufacturingOrdersForm = new SeleniumControl( sDriver, "ManufacturingOrdersForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMMEXPD_MOHDR_']/ancestor::form[1]");
				Function.AssertEqual(true,PCMMEXPD_ManufacturingOrdersForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMEXPD] Performing ClickButton on ManufacturingOrdersForm...", Logger.MessageType.INF);
				SeleniumControl PCMMEXPD_ManufacturingOrdersForm = new SeleniumControl( sDriver, "ManufacturingOrdersForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMMEXPD_MOHDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCMMEXPD_ManufacturingOrdersForm);
IWebElement formBttn = PCMMEXPD_ManufacturingOrdersForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PCMMEXPD_ManufacturingOrdersForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PCMMEXPD_ManufacturingOrdersForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMEXPD] Performing VerifyExists on ManufacturingOrders_MO...", Logger.MessageType.INF);
				SeleniumControl PCMMEXPD_ManufacturingOrders_MO = new SeleniumControl( sDriver, "ManufacturingOrders_MO", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMMEXPD_MOHDR_']/ancestor::form[1]/descendant::*[@id='MO_ID']");
				Function.AssertEqual(true,PCMMEXPD_ManufacturingOrders_MO.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Manufacturing OrdersTab");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMEXPD] Performing Select on ManufacturingOrdersTab...", Logger.MessageType.INF);
				SeleniumControl PCMMEXPD_ManufacturingOrdersTab = new SeleniumControl( sDriver, "ManufacturingOrdersTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMMEXPD_MOHDR_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PCMMEXPD_ManufacturingOrdersTab);
IWebElement mTab = PCMMEXPD_ManufacturingOrdersTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Details").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMEXPD] Performing VerifyExists on ManufacturingOrders_Details_Planner...", Logger.MessageType.INF);
				SeleniumControl PCMMEXPD_ManufacturingOrders_Details_Planner = new SeleniumControl( sDriver, "ManufacturingOrders_Details_Planner", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMMEXPD_MOHDR_']/ancestor::form[1]/descendant::*[@id='PLANNER_ID']");
				Function.AssertEqual(true,PCMMEXPD_ManufacturingOrders_Details_Planner.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMEXPD] Performing Select on ManufacturingOrdersTab...", Logger.MessageType.INF);
				SeleniumControl PCMMEXPD_ManufacturingOrdersTab = new SeleniumControl( sDriver, "ManufacturingOrdersTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMMEXPD_MOHDR_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PCMMEXPD_ManufacturingOrdersTab);
IWebElement mTab = PCMMEXPD_ManufacturingOrdersTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Additional Info").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMEXPD] Performing VerifyExists on ManufacturingOrders_AdditionalInfo_Organization...", Logger.MessageType.INF);
				SeleniumControl PCMMEXPD_ManufacturingOrders_AdditionalInfo_Organization = new SeleniumControl( sDriver, "ManufacturingOrders_AdditionalInfo_Organization", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMMEXPD_MOHDR_']/ancestor::form[1]/descendant::*[@id='ORG_ID']");
				Function.AssertEqual(true,PCMMEXPD_ManufacturingOrders_AdditionalInfo_Organization.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMEXPD] Performing Select on ManufacturingOrdersTab...", Logger.MessageType.INF);
				SeleniumControl PCMMEXPD_ManufacturingOrdersTab = new SeleniumControl( sDriver, "ManufacturingOrdersTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMMEXPD_MOHDR_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PCMMEXPD_ManufacturingOrdersTab);
IWebElement mTab = PCMMEXPD_ManufacturingOrdersTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Notes").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMEXPD] Performing VerifyExists on ManufacturingOrders_Notes_HeaderNotes...", Logger.MessageType.INF);
				SeleniumControl PCMMEXPD_ManufacturingOrders_Notes_HeaderNotes = new SeleniumControl( sDriver, "ManufacturingOrders_Notes_HeaderNotes", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMMEXPD_MOHDR_']/ancestor::form[1]/descendant::*[@id='MO_NOTES']");
				Function.AssertEqual(true,PCMMEXPD_ManufacturingOrders_Notes_HeaderNotes.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Allocations");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMEXPD] Performing VerifyExists on ManufacturingOrders_AllocationsLink...", Logger.MessageType.INF);
				SeleniumControl PCMMEXPD_ManufacturingOrders_AllocationsLink = new SeleniumControl( sDriver, "ManufacturingOrders_AllocationsLink", "ID", "lnk_1004861_PCMMEXPD_MOHDR");
				Function.AssertEqual(true,PCMMEXPD_ManufacturingOrders_AllocationsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMEXPD] Performing Click on ManufacturingOrders_AllocationsLink...", Logger.MessageType.INF);
				SeleniumControl PCMMEXPD_ManufacturingOrders_AllocationsLink = new SeleniumControl( sDriver, "ManufacturingOrders_AllocationsLink", "ID", "lnk_1004861_PCMMEXPD_MOHDR");
				Function.WaitControlDisplayed(PCMMEXPD_ManufacturingOrders_AllocationsLink);
PCMMEXPD_ManufacturingOrders_AllocationsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMEXPD] Performing VerifyExist on ManufacturingOrders_AllocationsTable...", Logger.MessageType.INF);
				SeleniumControl PCMMEXPD_ManufacturingOrders_AllocationsTable = new SeleniumControl( sDriver, "ManufacturingOrders_AllocationsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PCM_MOALLOCATIONS_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PCMMEXPD_ManufacturingOrders_AllocationsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMEXPD] Performing VerifyExists on ManufacturingOrders_AllocationsForm...", Logger.MessageType.INF);
				SeleniumControl PCMMEXPD_ManufacturingOrders_AllocationsForm = new SeleniumControl( sDriver, "ManufacturingOrders_AllocationsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCM_MOALLOCATIONS_']/ancestor::form[1]");
				Function.AssertEqual(true,PCMMEXPD_ManufacturingOrders_AllocationsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMEXPD] Performing ClickButton on ManufacturingOrders_AllocationsForm...", Logger.MessageType.INF);
				SeleniumControl PCMMEXPD_ManufacturingOrders_AllocationsForm = new SeleniumControl( sDriver, "ManufacturingOrders_AllocationsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCM_MOALLOCATIONS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCMMEXPD_ManufacturingOrders_AllocationsForm);
IWebElement formBttn = PCMMEXPD_ManufacturingOrders_AllocationsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PCMMEXPD_ManufacturingOrders_AllocationsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PCMMEXPD_ManufacturingOrders_AllocationsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMEXPD] Performing VerifyExists on ManufacturingOrders_Allocations_AllocationInvAbbrev...", Logger.MessageType.INF);
				SeleniumControl PCMMEXPD_ManufacturingOrders_Allocations_AllocationInvAbbrev = new SeleniumControl( sDriver, "ManufacturingOrders_Allocations_AllocationInvAbbrev", "xpath", "//div[translate(@id,'0123456789','')='pr__PCM_MOALLOCATIONS_']/ancestor::form[1]/descendant::*[@id='BLD_INVT_ABBRV_CD']");
				Function.AssertEqual(true,PCMMEXPD_ManufacturingOrders_Allocations_AllocationInvAbbrev.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMEXPD] Performing Close on ManufacturingOrders_AllocationsForm...", Logger.MessageType.INF);
				SeleniumControl PCMMEXPD_ManufacturingOrders_AllocationsForm = new SeleniumControl( sDriver, "ManufacturingOrders_AllocationsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCM_MOALLOCATIONS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCMMEXPD_ManufacturingOrders_AllocationsForm);
IWebElement formBttn = PCMMEXPD_ManufacturingOrders_AllocationsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Part Documents");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMEXPD] Performing VerifyExists on ManufacturingOrders_PartDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl PCMMEXPD_ManufacturingOrders_PartDocumentsLink = new SeleniumControl( sDriver, "ManufacturingOrders_PartDocumentsLink", "ID", "lnk_1004648_PCMMEXPD_MOHDR");
				Function.AssertEqual(true,PCMMEXPD_ManufacturingOrders_PartDocumentsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMEXPD] Performing Click on ManufacturingOrders_PartDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl PCMMEXPD_ManufacturingOrders_PartDocumentsLink = new SeleniumControl( sDriver, "ManufacturingOrders_PartDocumentsLink", "ID", "lnk_1004648_PCMMEXPD_MOHDR");
				Function.WaitControlDisplayed(PCMMEXPD_ManufacturingOrders_PartDocumentsLink);
PCMMEXPD_ManufacturingOrders_PartDocumentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMEXPD] Performing VerifyExist on ManufacturingOrders_PartDocumentsTable...", Logger.MessageType.INF);
				SeleniumControl PCMMEXPD_ManufacturingOrders_PartDocumentsTable = new SeleniumControl( sDriver, "ManufacturingOrders_PartDocumentsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PCMMEXPD_ManufacturingOrders_PartDocumentsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMEXPD] Performing VerifyExists on ManufacturingOrders_PartDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl PCMMEXPD_ManufacturingOrders_PartDocumentsForm = new SeleniumControl( sDriver, "ManufacturingOrders_PartDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]");
				Function.AssertEqual(true,PCMMEXPD_ManufacturingOrders_PartDocumentsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMEXPD] Performing ClickButton on ManufacturingOrders_PartDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl PCMMEXPD_ManufacturingOrders_PartDocumentsForm = new SeleniumControl( sDriver, "ManufacturingOrders_PartDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCMMEXPD_ManufacturingOrders_PartDocumentsForm);
IWebElement formBttn = PCMMEXPD_ManufacturingOrders_PartDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PCMMEXPD_ManufacturingOrders_PartDocumentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PCMMEXPD_ManufacturingOrders_PartDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMEXPD] Performing VerifyExists on ManufacturingOrders_PartDocuments_Type...", Logger.MessageType.INF);
				SeleniumControl PCMMEXPD_ManufacturingOrders_PartDocuments_Type = new SeleniumControl( sDriver, "ManufacturingOrders_PartDocuments_Type", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]/descendant::*[@id='DOC_TYPE_CD']");
				Function.AssertEqual(true,PCMMEXPD_ManufacturingOrders_PartDocuments_Type.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMEXPD] Performing Close on ManufacturingOrders_PartDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl PCMMEXPD_ManufacturingOrders_PartDocumentsForm = new SeleniumControl( sDriver, "ManufacturingOrders_PartDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCMMEXPD_ManufacturingOrders_PartDocumentsForm);
IWebElement formBttn = PCMMEXPD_ManufacturingOrders_PartDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Requirements-SKIP MUNA TO!!!!!!!!!!!!!");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Routings");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMEXPD] Performing VerifyExists on ManufacturingOrders_RoutingsLink...", Logger.MessageType.INF);
				SeleniumControl PCMMEXPD_ManufacturingOrders_RoutingsLink = new SeleniumControl( sDriver, "ManufacturingOrders_RoutingsLink", "ID", "lnk_4328_PCMMEXPD_MOHDR");
				Function.AssertEqual(true,PCMMEXPD_ManufacturingOrders_RoutingsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMEXPD] Performing Click on ManufacturingOrders_RoutingsLink...", Logger.MessageType.INF);
				SeleniumControl PCMMEXPD_ManufacturingOrders_RoutingsLink = new SeleniumControl( sDriver, "ManufacturingOrders_RoutingsLink", "ID", "lnk_4328_PCMMEXPD_MOHDR");
				Function.WaitControlDisplayed(PCMMEXPD_ManufacturingOrders_RoutingsLink);
PCMMEXPD_ManufacturingOrders_RoutingsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMEXPD] Performing VerifyExists on ManufacturingOrders_RoutingsForm...", Logger.MessageType.INF);
				SeleniumControl PCMMEXPD_ManufacturingOrders_RoutingsForm = new SeleniumControl( sDriver, "ManufacturingOrders_RoutingsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCM_MOHDR_ROUTHDR_']/ancestor::form[1]");
				Function.AssertEqual(true,PCMMEXPD_ManufacturingOrders_RoutingsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMEXPD] Performing VerifyExists on ManufacturingOrders_Routings_RoutingNo...", Logger.MessageType.INF);
				SeleniumControl PCMMEXPD_ManufacturingOrders_Routings_RoutingNo = new SeleniumControl( sDriver, "ManufacturingOrders_Routings_RoutingNo", "xpath", "//div[translate(@id,'0123456789','')='pr__PCM_MOHDR_ROUTHDR_']/ancestor::form[1]/descendant::*[@id='ROUT_NO']");
				Function.AssertEqual(true,PCMMEXPD_ManufacturingOrders_Routings_RoutingNo.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Routing Lines");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMEXPD] Performing VerifyExist on ManufacturingOrders_Routings_RoutingLinesTable...", Logger.MessageType.INF);
				SeleniumControl PCMMEXPD_ManufacturingOrders_Routings_RoutingLinesTable = new SeleniumControl( sDriver, "ManufacturingOrders_Routings_RoutingLinesTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PCM_MOROUTING_DTL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PCMMEXPD_ManufacturingOrders_Routings_RoutingLinesTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMEXPD] Performing VerifyExists on ManufacturingOrders_Routings_RoutingLinesForm...", Logger.MessageType.INF);
				SeleniumControl PCMMEXPD_ManufacturingOrders_Routings_RoutingLinesForm = new SeleniumControl( sDriver, "ManufacturingOrders_Routings_RoutingLinesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCM_MOROUTING_DTL_']/ancestor::form[1]");
				Function.AssertEqual(true,PCMMEXPD_ManufacturingOrders_Routings_RoutingLinesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMEXPD] Performing ClickButton on ManufacturingOrders_Routings_RoutingLinesForm...", Logger.MessageType.INF);
				SeleniumControl PCMMEXPD_ManufacturingOrders_Routings_RoutingLinesForm = new SeleniumControl( sDriver, "ManufacturingOrders_Routings_RoutingLinesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCM_MOROUTING_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCMMEXPD_ManufacturingOrders_Routings_RoutingLinesForm);
IWebElement formBttn = PCMMEXPD_ManufacturingOrders_Routings_RoutingLinesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PCMMEXPD_ManufacturingOrders_Routings_RoutingLinesForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PCMMEXPD_ManufacturingOrders_Routings_RoutingLinesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMEXPD] Performing VerifyExists on ManufacturingOrders_Routings_RoutingLines_Sequence...", Logger.MessageType.INF);
				SeleniumControl PCMMEXPD_ManufacturingOrders_Routings_RoutingLines_Sequence = new SeleniumControl( sDriver, "ManufacturingOrders_Routings_RoutingLines_Sequence", "xpath", "//div[translate(@id,'0123456789','')='pr__PCM_MOROUTING_DTL_']/ancestor::form[1]/descendant::*[@id='MO_OPER_SEQ_NO']");
				Function.AssertEqual(true,PCMMEXPD_ManufacturingOrders_Routings_RoutingLines_Sequence.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Routing Lines Tab");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMEXPD] Performing Select on ManufacturingOrders_Routings_RoutingLinesTab...", Logger.MessageType.INF);
				SeleniumControl PCMMEXPD_ManufacturingOrders_Routings_RoutingLinesTab = new SeleniumControl( sDriver, "ManufacturingOrders_Routings_RoutingLinesTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PCM_MOROUTING_DTL_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PCMMEXPD_ManufacturingOrders_Routings_RoutingLinesTab);
IWebElement mTab = PCMMEXPD_ManufacturingOrders_Routings_RoutingLinesTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Operation").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMEXPD] Performing VerifyExists on ManufacturingOrders_Routings_RoutingLines_Operation_OperationDetails_RunType...", Logger.MessageType.INF);
				SeleniumControl PCMMEXPD_ManufacturingOrders_Routings_RoutingLines_Operation_OperationDetails_RunType = new SeleniumControl( sDriver, "ManufacturingOrders_Routings_RoutingLines_Operation_OperationDetails_RunType", "xpath", "//div[translate(@id,'0123456789','')='pr__PCM_MOROUTING_DTL_']/ancestor::form[1]/descendant::*[@id='S_RUN_TYPE']");
				Function.AssertEqual(true,PCMMEXPD_ManufacturingOrders_Routings_RoutingLines_Operation_OperationDetails_RunType.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMEXPD] Performing Select on ManufacturingOrders_Routings_RoutingLinesTab...", Logger.MessageType.INF);
				SeleniumControl PCMMEXPD_ManufacturingOrders_Routings_RoutingLinesTab = new SeleniumControl( sDriver, "ManufacturingOrders_Routings_RoutingLinesTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PCM_MOROUTING_DTL_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PCMMEXPD_ManufacturingOrders_Routings_RoutingLinesTab);
IWebElement mTab = PCMMEXPD_ManufacturingOrders_Routings_RoutingLinesTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Routing Line Notes").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMEXPD] Performing VerifyExists on ManufacturingOrders_Routings_RoutingLines_RoutingLineNotes_RoutingLineNotes...", Logger.MessageType.INF);
				SeleniumControl PCMMEXPD_ManufacturingOrders_Routings_RoutingLines_RoutingLineNotes_RoutingLineNotes = new SeleniumControl( sDriver, "ManufacturingOrders_Routings_RoutingLines_RoutingLineNotes_RoutingLineNotes", "xpath", "//div[translate(@id,'0123456789','')='pr__PCM_MOROUTING_DTL_']/ancestor::form[1]/descendant::*[@id='MO_ROUT_LN_NOTES']");
				Function.AssertEqual(true,PCMMEXPD_ManufacturingOrders_Routings_RoutingLines_RoutingLineNotes_RoutingLineNotes.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMEXPD] Performing Close on ManufacturingOrders_RoutingsForm...", Logger.MessageType.INF);
				SeleniumControl PCMMEXPD_ManufacturingOrders_RoutingsForm = new SeleniumControl( sDriver, "ManufacturingOrders_RoutingsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCM_MOHDR_ROUTHDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCMMEXPD_ManufacturingOrders_RoutingsForm);
IWebElement formBttn = PCMMEXPD_ManufacturingOrders_RoutingsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Requisitions");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMEXPD] Performing VerifyExists on ManufacturingOrders_RequisitionsLink...", Logger.MessageType.INF);
				SeleniumControl PCMMEXPD_ManufacturingOrders_RequisitionsLink = new SeleniumControl( sDriver, "ManufacturingOrders_RequisitionsLink", "ID", "lnk_1004001_PCMMEXPD_MOHDR");
				Function.AssertEqual(true,PCMMEXPD_ManufacturingOrders_RequisitionsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMEXPD] Performing Click on ManufacturingOrders_RequisitionsLink...", Logger.MessageType.INF);
				SeleniumControl PCMMEXPD_ManufacturingOrders_RequisitionsLink = new SeleniumControl( sDriver, "ManufacturingOrders_RequisitionsLink", "ID", "lnk_1004001_PCMMEXPD_MOHDR");
				Function.WaitControlDisplayed(PCMMEXPD_ManufacturingOrders_RequisitionsLink);
PCMMEXPD_ManufacturingOrders_RequisitionsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMEXPD] Performing VerifyExists on ManufacturingOrders_RequisitionsForm...", Logger.MessageType.INF);
				SeleniumControl PCMMEXPD_ManufacturingOrders_RequisitionsForm = new SeleniumControl( sDriver, "ManufacturingOrders_RequisitionsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMMEXPD_REQUISITIONS_FILTER_']/ancestor::form[1]");
				Function.AssertEqual(true,PCMMEXPD_ManufacturingOrders_RequisitionsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMEXPD] Performing VerifyExists on ManufacturingOrders_Requisitions_Project...", Logger.MessageType.INF);
				SeleniumControl PCMMEXPD_ManufacturingOrders_Requisitions_Project = new SeleniumControl( sDriver, "ManufacturingOrders_Requisitions_Project", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMMEXPD_REQUISITIONS_FILTER_']/ancestor::form[1]/descendant::*[@id='PROJ_ID']");
				Function.AssertEqual(true,PCMMEXPD_ManufacturingOrders_Requisitions_Project.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Requirement Requisition");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMEXPD] Performing VerifyExist on ManufacturingOrders_Requisitions_RequirementRequisitionsTable...", Logger.MessageType.INF);
				SeleniumControl PCMMEXPD_ManufacturingOrders_Requisitions_RequirementRequisitionsTable = new SeleniumControl( sDriver, "ManufacturingOrders_Requisitions_RequirementRequisitionsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMMEXPD_RQLN_REQUISITIONS_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PCMMEXPD_ManufacturingOrders_Requisitions_RequirementRequisitionsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMEXPD] Performing VerifyExists on ManufacturingOrders_Requisitions_RequirementRequisitionsForm...", Logger.MessageType.INF);
				SeleniumControl PCMMEXPD_ManufacturingOrders_Requisitions_RequirementRequisitionsForm = new SeleniumControl( sDriver, "ManufacturingOrders_Requisitions_RequirementRequisitionsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMMEXPD_RQLN_REQUISITIONS_']/ancestor::form[1]");
				Function.AssertEqual(true,PCMMEXPD_ManufacturingOrders_Requisitions_RequirementRequisitionsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMEXPD] Performing ClickButton on ManufacturingOrders_Requisitions_RequirementRequisitionsForm...", Logger.MessageType.INF);
				SeleniumControl PCMMEXPD_ManufacturingOrders_Requisitions_RequirementRequisitionsForm = new SeleniumControl( sDriver, "ManufacturingOrders_Requisitions_RequirementRequisitionsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMMEXPD_RQLN_REQUISITIONS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCMMEXPD_ManufacturingOrders_Requisitions_RequirementRequisitionsForm);
IWebElement formBttn = PCMMEXPD_ManufacturingOrders_Requisitions_RequirementRequisitionsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PCMMEXPD_ManufacturingOrders_Requisitions_RequirementRequisitionsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PCMMEXPD_ManufacturingOrders_Requisitions_RequirementRequisitionsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMEXPD] Performing VerifyExists on ManufacturingOrders_Requisitions_RequirementRequisitions_RequirementInformation_LineNo...", Logger.MessageType.INF);
				SeleniumControl PCMMEXPD_ManufacturingOrders_Requisitions_RequirementRequisitions_RequirementInformation_LineNo = new SeleniumControl( sDriver, "ManufacturingOrders_Requisitions_RequirementRequisitions_RequirementInformation_LineNo", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMMEXPD_RQLN_REQUISITIONS_']/ancestor::form[1]/descendant::*[@id='COMP_LN_NO']");
				Function.AssertEqual(true,PCMMEXPD_ManufacturingOrders_Requisitions_RequirementRequisitions_RequirementInformation_LineNo.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMEXPD] Performing Close on ManufacturingOrders_RequisitionsForm...", Logger.MessageType.INF);
				SeleniumControl PCMMEXPD_ManufacturingOrders_RequisitionsForm = new SeleniumControl( sDriver, "ManufacturingOrders_RequisitionsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMMEXPD_REQUISITIONS_FILTER_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCMMEXPD_ManufacturingOrders_RequisitionsForm);
IWebElement formBttn = PCMMEXPD_ManufacturingOrders_RequisitionsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Pos");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMEXPD] Performing VerifyExists on ManufacturingOrders_POsLink...", Logger.MessageType.INF);
				SeleniumControl PCMMEXPD_ManufacturingOrders_POsLink = new SeleniumControl( sDriver, "ManufacturingOrders_POsLink", "ID", "lnk_1003999_PCMMEXPD_MOHDR");
				Function.AssertEqual(true,PCMMEXPD_ManufacturingOrders_POsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMEXPD] Performing Click on ManufacturingOrders_POsLink...", Logger.MessageType.INF);
				SeleniumControl PCMMEXPD_ManufacturingOrders_POsLink = new SeleniumControl( sDriver, "ManufacturingOrders_POsLink", "ID", "lnk_1003999_PCMMEXPD_MOHDR");
				Function.WaitControlDisplayed(PCMMEXPD_ManufacturingOrders_POsLink);
PCMMEXPD_ManufacturingOrders_POsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Requirement Purchase Orders");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMEXPD] Performing VerifyExist on ManufacturingOrders_POs_RequirementPurchaseOrdersTable...", Logger.MessageType.INF);
				SeleniumControl PCMMEXPD_ManufacturingOrders_POs_RequirementPurchaseOrdersTable = new SeleniumControl( sDriver, "ManufacturingOrders_POs_RequirementPurchaseOrdersTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMMEXPD_POLN_PO_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PCMMEXPD_ManufacturingOrders_POs_RequirementPurchaseOrdersTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMEXPD] Performing VerifyExists on ManufacturingOrders_POs_RequirementPurchaseOrdersForm...", Logger.MessageType.INF);
				SeleniumControl PCMMEXPD_ManufacturingOrders_POs_RequirementPurchaseOrdersForm = new SeleniumControl( sDriver, "ManufacturingOrders_POs_RequirementPurchaseOrdersForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMMEXPD_POLN_PO_']/ancestor::form[1]");
				Function.AssertEqual(true,PCMMEXPD_ManufacturingOrders_POs_RequirementPurchaseOrdersForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMEXPD] Performing ClickButton on ManufacturingOrders_POs_RequirementPurchaseOrdersForm...", Logger.MessageType.INF);
				SeleniumControl PCMMEXPD_ManufacturingOrders_POs_RequirementPurchaseOrdersForm = new SeleniumControl( sDriver, "ManufacturingOrders_POs_RequirementPurchaseOrdersForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMMEXPD_POLN_PO_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCMMEXPD_ManufacturingOrders_POs_RequirementPurchaseOrdersForm);
IWebElement formBttn = PCMMEXPD_ManufacturingOrders_POs_RequirementPurchaseOrdersForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PCMMEXPD_ManufacturingOrders_POs_RequirementPurchaseOrdersForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PCMMEXPD_ManufacturingOrders_POs_RequirementPurchaseOrdersForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMEXPD] Performing VerifyExists on ManufacturingOrders_POs_RequirementPurchaseOrders_Line...", Logger.MessageType.INF);
				SeleniumControl PCMMEXPD_ManufacturingOrders_POs_RequirementPurchaseOrders_Line = new SeleniumControl( sDriver, "ManufacturingOrders_POs_RequirementPurchaseOrders_Line", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMMEXPD_POLN_PO_']/ancestor::form[1]/descendant::*[@id='COMP_LN_NO']");
				Function.AssertEqual(true,PCMMEXPD_ManufacturingOrders_POs_RequirementPurchaseOrders_Line.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Requirement Purchase Orders Tab");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMEXPD] Performing Close on ManufacturingOrders_POsForm...", Logger.MessageType.INF);
				SeleniumControl PCMMEXPD_ManufacturingOrders_POsForm = new SeleniumControl( sDriver, "ManufacturingOrders_POsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMMEXPD_PO_FILTER_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCMMEXPD_ManufacturingOrders_POsForm);
IWebElement formBttn = PCMMEXPD_ManufacturingOrders_POsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Subcontractor Reqs/Pos");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Costs");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMEXPD] Performing VerifyExists on ManufacturingOrders_CostsLink...", Logger.MessageType.INF);
				SeleniumControl PCMMEXPD_ManufacturingOrders_CostsLink = new SeleniumControl( sDriver, "ManufacturingOrders_CostsLink", "ID", "lnk_1004871_PCMMEXPD_MOHDR");
				Function.AssertEqual(true,PCMMEXPD_ManufacturingOrders_CostsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMEXPD] Performing Click on ManufacturingOrders_CostsLink...", Logger.MessageType.INF);
				SeleniumControl PCMMEXPD_ManufacturingOrders_CostsLink = new SeleniumControl( sDriver, "ManufacturingOrders_CostsLink", "ID", "lnk_1004871_PCMMEXPD_MOHDR");
				Function.WaitControlDisplayed(PCMMEXPD_ManufacturingOrders_CostsLink);
PCMMEXPD_ManufacturingOrders_CostsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMEXPD] Performing VerifyExists on ManufacturingOrders_CostsForm...", Logger.MessageType.INF);
				SeleniumControl PCMMEXPD_ManufacturingOrders_CostsForm = new SeleniumControl( sDriver, "ManufacturingOrders_CostsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCM_COSTINFO_']/ancestor::form[1]");
				Function.AssertEqual(true,PCMMEXPD_ManufacturingOrders_CostsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMEXPD] Performing VerifyExists on ManufacturingOrders_Costs_MOTotalCosts_Direct_Material...", Logger.MessageType.INF);
				SeleniumControl PCMMEXPD_ManufacturingOrders_Costs_MOTotalCosts_Direct_Material = new SeleniumControl( sDriver, "ManufacturingOrders_Costs_MOTotalCosts_Direct_Material", "xpath", "//div[translate(@id,'0123456789','')='pr__PCM_COSTINFO_']/ancestor::form[1]/descendant::*[@id='TOT_MATL_CST']");
				Function.AssertEqual(true,PCMMEXPD_ManufacturingOrders_Costs_MOTotalCosts_Direct_Material.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMEXPD] Performing Close on ManufacturingOrders_CostsForm...", Logger.MessageType.INF);
				SeleniumControl PCMMEXPD_ManufacturingOrders_CostsForm = new SeleniumControl( sDriver, "ManufacturingOrders_CostsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCM_COSTINFO_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCMMEXPD_ManufacturingOrders_CostsForm);
IWebElement formBttn = PCMMEXPD_ManufacturingOrders_CostsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Assy Part Demand");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMEXPD] Performing VerifyExists on ManufacturingOrders_AssyPartDemandLink...", Logger.MessageType.INF);
				SeleniumControl PCMMEXPD_ManufacturingOrders_AssyPartDemandLink = new SeleniumControl( sDriver, "ManufacturingOrders_AssyPartDemandLink", "ID", "lnk_4247_PCMMEXPD_MOHDR");
				Function.AssertEqual(true,PCMMEXPD_ManufacturingOrders_AssyPartDemandLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMEXPD] Performing Click on ManufacturingOrders_AssyPartDemandLink...", Logger.MessageType.INF);
				SeleniumControl PCMMEXPD_ManufacturingOrders_AssyPartDemandLink = new SeleniumControl( sDriver, "ManufacturingOrders_AssyPartDemandLink", "ID", "lnk_4247_PCMMEXPD_MOHDR");
				Function.WaitControlDisplayed(PCMMEXPD_ManufacturingOrders_AssyPartDemandLink);
PCMMEXPD_ManufacturingOrders_AssyPartDemandLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMEXPD] Performing VerifyExist on ManufacturingOrders_AssyPartDemandTable...", Logger.MessageType.INF);
				SeleniumControl PCMMEXPD_ManufacturingOrders_AssyPartDemandTable = new SeleniumControl( sDriver, "ManufacturingOrders_AssyPartDemandTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMMEXPD_GROSSRQMT_SUBTASK_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PCMMEXPD_ManufacturingOrders_AssyPartDemandTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMEXPD] Performing VerifyExists on ManufacturingOrders_AssyPartDemandForm...", Logger.MessageType.INF);
				SeleniumControl PCMMEXPD_ManufacturingOrders_AssyPartDemandForm = new SeleniumControl( sDriver, "ManufacturingOrders_AssyPartDemandForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMMEXPD_GROSSRQMT_SUBTASK_']/ancestor::form[1]");
				Function.AssertEqual(true,PCMMEXPD_ManufacturingOrders_AssyPartDemandForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMEXPD] Performing ClickButton on ManufacturingOrders_AssyPartDemandForm...", Logger.MessageType.INF);
				SeleniumControl PCMMEXPD_ManufacturingOrders_AssyPartDemandForm = new SeleniumControl( sDriver, "ManufacturingOrders_AssyPartDemandForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMMEXPD_GROSSRQMT_SUBTASK_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCMMEXPD_ManufacturingOrders_AssyPartDemandForm);
IWebElement formBttn = PCMMEXPD_ManufacturingOrders_AssyPartDemandForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PCMMEXPD_ManufacturingOrders_AssyPartDemandForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PCMMEXPD_ManufacturingOrders_AssyPartDemandForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMEXPD] Performing VerifyExists on ManufacturingOrders_AssyPartDemand_NeedDate...", Logger.MessageType.INF);
				SeleniumControl PCMMEXPD_ManufacturingOrders_AssyPartDemand_NeedDate = new SeleniumControl( sDriver, "ManufacturingOrders_AssyPartDemand_NeedDate", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMMEXPD_GROSSRQMT_SUBTASK_']/ancestor::form[1]/descendant::*[@id='NEED_DT']");
				Function.AssertEqual(true,PCMMEXPD_ManufacturingOrders_AssyPartDemand_NeedDate.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMEXPD] Performing Close on ManufacturingOrders_AssyPartDemandForm...", Logger.MessageType.INF);
				SeleniumControl PCMMEXPD_ManufacturingOrders_AssyPartDemandForm = new SeleniumControl( sDriver, "ManufacturingOrders_AssyPartDemandForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMMEXPD_GROSSRQMT_SUBTASK_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCMMEXPD_ManufacturingOrders_AssyPartDemandForm);
IWebElement formBttn = PCMMEXPD_ManufacturingOrders_AssyPartDemandForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Documents");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMEXPD] Performing VerifyExists on ManufacturingOrders_DocumentsLink...", Logger.MessageType.INF);
				SeleniumControl PCMMEXPD_ManufacturingOrders_DocumentsLink = new SeleniumControl( sDriver, "ManufacturingOrders_DocumentsLink", "ID", "lnk_4857_PCMMEXPD_MOHDR");
				Function.AssertEqual(true,PCMMEXPD_ManufacturingOrders_DocumentsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMEXPD] Performing Click on ManufacturingOrders_DocumentsLink...", Logger.MessageType.INF);
				SeleniumControl PCMMEXPD_ManufacturingOrders_DocumentsLink = new SeleniumControl( sDriver, "ManufacturingOrders_DocumentsLink", "ID", "lnk_4857_PCMMEXPD_MOHDR");
				Function.WaitControlDisplayed(PCMMEXPD_ManufacturingOrders_DocumentsLink);
PCMMEXPD_ManufacturingOrders_DocumentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMEXPD] Performing VerifyExist on ManufacturingOrders_DocumentsTable...", Logger.MessageType.INF);
				SeleniumControl PCMMEXPD_ManufacturingOrders_DocumentsTable = new SeleniumControl( sDriver, "ManufacturingOrders_DocumentsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PC_MODOCUMENT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PCMMEXPD_ManufacturingOrders_DocumentsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMEXPD] Performing VerifyExists on ManufacturingOrders_DocumentsForm...", Logger.MessageType.INF);
				SeleniumControl PCMMEXPD_ManufacturingOrders_DocumentsForm = new SeleniumControl( sDriver, "ManufacturingOrders_DocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PC_MODOCUMENT_']/ancestor::form[1]");
				Function.AssertEqual(true,PCMMEXPD_ManufacturingOrders_DocumentsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMEXPD] Performing ClickButton on ManufacturingOrders_DocumentsForm...", Logger.MessageType.INF);
				SeleniumControl PCMMEXPD_ManufacturingOrders_DocumentsForm = new SeleniumControl( sDriver, "ManufacturingOrders_DocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PC_MODOCUMENT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCMMEXPD_ManufacturingOrders_DocumentsForm);
IWebElement formBttn = PCMMEXPD_ManufacturingOrders_DocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PCMMEXPD_ManufacturingOrders_DocumentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PCMMEXPD_ManufacturingOrders_DocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMEXPD] Performing VerifyExists on ManufacturingOrders_Documents_ReferenceDocument...", Logger.MessageType.INF);
				SeleniumControl PCMMEXPD_ManufacturingOrders_Documents_ReferenceDocument = new SeleniumControl( sDriver, "ManufacturingOrders_Documents_ReferenceDocument", "xpath", "//div[translate(@id,'0123456789','')='pr__PC_MODOCUMENT_']/ancestor::form[1]/descendant::*[@id='REF_DOC_FL']");
				Function.AssertEqual(true,PCMMEXPD_ManufacturingOrders_Documents_ReferenceDocument.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMEXPD] Performing Close on ManufacturingOrders_DocumentsForm...", Logger.MessageType.INF);
				SeleniumControl PCMMEXPD_ManufacturingOrders_DocumentsForm = new SeleniumControl( sDriver, "ManufacturingOrders_DocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PC_MODOCUMENT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCMMEXPD_ManufacturingOrders_DocumentsForm);
IWebElement formBttn = PCMMEXPD_ManufacturingOrders_DocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Close the application");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMEXPD] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl PCMMEXPD_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PCMMEXPD_MainForm);
IWebElement formBttn = PCMMEXPD_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

