 
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
    public class PCMSCRQ_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Create MO Subcontractor Requisitions", "xpath","//div[@class='navItem'][.='Create MO Subcontractor Requisitions']").Click();


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
				Function.CurrentComponent = "PCMSCRQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMSCRQ] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl PCMSCRQ_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,PCMSCRQ_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMSCRQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMSCRQ] Performing VerifyExists on Planner...", Logger.MessageType.INF);
				SeleniumControl PCMSCRQ_Planner = new SeleniumControl( sDriver, "Planner", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PLANNER_ID']");
				Function.AssertEqual(true,PCMSCRQ_Planner.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMSCRQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMSCRQ] Performing Set on Planner...", Logger.MessageType.INF);
				SeleniumControl PCMSCRQ_Planner = new SeleniumControl( sDriver, "Planner", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PLANNER_ID']");
				PCMSCRQ_Planner.Click();
PCMSCRQ_Planner.SendKeys("BCOMPHER", true);
Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));
PCMSCRQ_Planner.SendKeys(OpenQA.Selenium.Keys.Shift + OpenQA.Selenium.Keys.Tab);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Set]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMSCRQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMSCRQ] Performing Set on Warehouse...", Logger.MessageType.INF);
				SeleniumControl PCMSCRQ_Warehouse = new SeleniumControl( sDriver, "Warehouse", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='WHSE_ID']");
				PCMSCRQ_Warehouse.Click();
PCMSCRQ_Warehouse.SendKeys("1000", true);
Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));
PCMSCRQ_Warehouse.SendKeys(OpenQA.Selenium.Keys.Shift + OpenQA.Selenium.Keys.Tab);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Set]" , ex.Message));
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
				this.ScriptLogger.WriteLine("Child Form");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMSCRQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMSCRQ] Performing VerifyExist on ManufacturingOrdersTable...", Logger.MessageType.INF);
				SeleniumControl PCMSCRQ_ManufacturingOrdersTable = new SeleniumControl( sDriver, "ManufacturingOrdersTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMSCRQ_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PCMSCRQ_ManufacturingOrdersTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMSCRQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMSCRQ] Performing ClickButton on ManufacturingOrdersForm...", Logger.MessageType.INF);
				SeleniumControl PCMSCRQ_ManufacturingOrdersForm = new SeleniumControl( sDriver, "ManufacturingOrdersForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMSCRQ_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCMSCRQ_ManufacturingOrdersForm);
IWebElement formBttn = PCMSCRQ_ManufacturingOrdersForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PCMSCRQ_ManufacturingOrdersForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PCMSCRQ_ManufacturingOrdersForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMSCRQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMSCRQ] Performing VerifyExists on ManufacturingOrdersForm...", Logger.MessageType.INF);
				SeleniumControl PCMSCRQ_ManufacturingOrdersForm = new SeleniumControl( sDriver, "ManufacturingOrdersForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMSCRQ_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,PCMSCRQ_ManufacturingOrdersForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMSCRQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMSCRQ] Performing VerifyExists on ManufacturingOrders_MO...", Logger.MessageType.INF);
				SeleniumControl PCMSCRQ_ManufacturingOrders_MO = new SeleniumControl( sDriver, "ManufacturingOrders_MO", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMSCRQ_CTW_']/ancestor::form[1]/descendant::*[@id='MO_ID']");
				Function.AssertEqual(true,PCMSCRQ_ManufacturingOrders_MO.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMSCRQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMSCRQ] Performing ClickButton on ManufacturingOrdersForm...", Logger.MessageType.INF);
				SeleniumControl PCMSCRQ_ManufacturingOrdersForm = new SeleniumControl( sDriver, "ManufacturingOrdersForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMSCRQ_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCMSCRQ_ManufacturingOrdersForm);
IWebElement formBttn = PCMSCRQ_ManufacturingOrdersForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).Count <= 0 ? PCMSCRQ_ManufacturingOrdersForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Query')]")).FirstOrDefault() :
PCMSCRQ_ManufacturingOrdersForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).FirstOrDefault();
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
				this.ScriptLogger.WriteLine("Requisition Info");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMSCRQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMSCRQ] Performing VerifyExists on ManufacturingOrders_RequisitionInfoLink...", Logger.MessageType.INF);
				SeleniumControl PCMSCRQ_ManufacturingOrders_RequisitionInfoLink = new SeleniumControl( sDriver, "ManufacturingOrders_RequisitionInfoLink", "ID", "lnk_4261_PCMSCRQ_CTW");
				Function.AssertEqual(true,PCMSCRQ_ManufacturingOrders_RequisitionInfoLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMSCRQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMSCRQ] Performing Click on ManufacturingOrders_RequisitionInfoLink...", Logger.MessageType.INF);
				SeleniumControl PCMSCRQ_ManufacturingOrders_RequisitionInfoLink = new SeleniumControl( sDriver, "ManufacturingOrders_RequisitionInfoLink", "ID", "lnk_4261_PCMSCRQ_CTW");
				Function.WaitControlDisplayed(PCMSCRQ_ManufacturingOrders_RequisitionInfoLink);
PCMSCRQ_ManufacturingOrders_RequisitionInfoLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMSCRQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMSCRQ] Performing VerifyExists on ManufacturingOrders_RequisitionInfoForm...", Logger.MessageType.INF);
				SeleniumControl PCMSCRQ_ManufacturingOrders_RequisitionInfoForm = new SeleniumControl( sDriver, "ManufacturingOrders_RequisitionInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMSCRQ_REQUISITION_DETAIL_']/ancestor::form[1]");
				Function.AssertEqual(true,PCMSCRQ_ManufacturingOrders_RequisitionInfoForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMSCRQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMSCRQ] Performing Select on ManufacturingOrders_RequisitionInfoTab...", Logger.MessageType.INF);
				SeleniumControl PCMSCRQ_ManufacturingOrders_RequisitionInfoTab = new SeleniumControl( sDriver, "ManufacturingOrders_RequisitionInfoTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMSCRQ_REQUISITION_DETAIL_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PCMSCRQ_ManufacturingOrders_RequisitionInfoTab);
IWebElement mTab = PCMSCRQ_ManufacturingOrders_RequisitionInfoTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Header").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMSCRQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMSCRQ] Performing VerifyExists on ManufacturingOrders_RequisitionInfo_Header_Status...", Logger.MessageType.INF);
				SeleniumControl PCMSCRQ_ManufacturingOrders_RequisitionInfo_Header_Status = new SeleniumControl( sDriver, "ManufacturingOrders_RequisitionInfo_Header_Status", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMSCRQ_REQUISITION_DETAIL_']/ancestor::form[1]/descendant::*[@id='S_STATUS_CD']");
				Function.AssertEqual(true,PCMSCRQ_ManufacturingOrders_RequisitionInfo_Header_Status.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMSCRQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMSCRQ] Performing Select on ManufacturingOrders_RequisitionInfoTab...", Logger.MessageType.INF);
				SeleniumControl PCMSCRQ_ManufacturingOrders_RequisitionInfoTab = new SeleniumControl( sDriver, "ManufacturingOrders_RequisitionInfoTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMSCRQ_REQUISITION_DETAIL_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PCMSCRQ_ManufacturingOrders_RequisitionInfoTab);
IWebElement mTab = PCMSCRQ_ManufacturingOrders_RequisitionInfoTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Line").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMSCRQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMSCRQ] Performing VerifyExists on ManufacturingOrders_RequisitionInfo_Line_Item...", Logger.MessageType.INF);
				SeleniumControl PCMSCRQ_ManufacturingOrders_RequisitionInfo_Line_Item = new SeleniumControl( sDriver, "ManufacturingOrders_RequisitionInfo_Line_Item", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMSCRQ_REQUISITION_DETAIL_']/ancestor::form[1]/descendant::*[@id='ITEM_ID']");
				Function.AssertEqual(true,PCMSCRQ_ManufacturingOrders_RequisitionInfo_Line_Item.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMSCRQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMSCRQ] Performing Close on ManufacturingOrders_RequisitionInfoForm...", Logger.MessageType.INF);
				SeleniumControl PCMSCRQ_ManufacturingOrders_RequisitionInfoForm = new SeleniumControl( sDriver, "ManufacturingOrders_RequisitionInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMSCRQ_REQUISITION_DETAIL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCMSCRQ_ManufacturingOrders_RequisitionInfoForm);
IWebElement formBttn = PCMSCRQ_ManufacturingOrders_RequisitionInfoForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("SubContractor Reqs/Pos");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMSCRQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMSCRQ] Performing VerifyExists on ManufacturingOrders_SubcontractorReqsPOsLink...", Logger.MessageType.INF);
				SeleniumControl PCMSCRQ_ManufacturingOrders_SubcontractorReqsPOsLink = new SeleniumControl( sDriver, "ManufacturingOrders_SubcontractorReqsPOsLink", "ID", "lnk_4269_PCMSCRQ_CTW");
				Function.AssertEqual(true,PCMSCRQ_ManufacturingOrders_SubcontractorReqsPOsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMSCRQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMSCRQ] Performing Click on ManufacturingOrders_SubcontractorReqsPOsLink...", Logger.MessageType.INF);
				SeleniumControl PCMSCRQ_ManufacturingOrders_SubcontractorReqsPOsLink = new SeleniumControl( sDriver, "ManufacturingOrders_SubcontractorReqsPOsLink", "ID", "lnk_4269_PCMSCRQ_CTW");
				Function.WaitControlDisplayed(PCMSCRQ_ManufacturingOrders_SubcontractorReqsPOsLink);
PCMSCRQ_ManufacturingOrders_SubcontractorReqsPOsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMSCRQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMSCRQ] Performing VerifyExist on ManufacturingOrders_SubcontractorReqsPOsTable...", Logger.MessageType.INF);
				SeleniumControl PCMSCRQ_ManufacturingOrders_SubcontractorReqsPOsTable = new SeleniumControl( sDriver, "ManufacturingOrders_SubcontractorReqsPOsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PCM_SUBREQPOS_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PCMSCRQ_ManufacturingOrders_SubcontractorReqsPOsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMSCRQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMSCRQ] Performing ClickButton on ManufacturingOrders_SubcontractorReqsPOsForm...", Logger.MessageType.INF);
				SeleniumControl PCMSCRQ_ManufacturingOrders_SubcontractorReqsPOsForm = new SeleniumControl( sDriver, "ManufacturingOrders_SubcontractorReqsPOsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCM_SUBREQPOS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCMSCRQ_ManufacturingOrders_SubcontractorReqsPOsForm);
IWebElement formBttn = PCMSCRQ_ManufacturingOrders_SubcontractorReqsPOsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PCMSCRQ_ManufacturingOrders_SubcontractorReqsPOsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PCMSCRQ_ManufacturingOrders_SubcontractorReqsPOsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMSCRQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMSCRQ] Performing VerifyExists on ManufacturingOrders_SubcontractorReqsPOsForm...", Logger.MessageType.INF);
				SeleniumControl PCMSCRQ_ManufacturingOrders_SubcontractorReqsPOsForm = new SeleniumControl( sDriver, "ManufacturingOrders_SubcontractorReqsPOsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCM_SUBREQPOS_']/ancestor::form[1]");
				Function.AssertEqual(true,PCMSCRQ_ManufacturingOrders_SubcontractorReqsPOsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMSCRQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMSCRQ] Performing VerifyExists on ManufacturingOrders_SubcontractorReqsPOs_Requisition_Requisition...", Logger.MessageType.INF);
				SeleniumControl PCMSCRQ_ManufacturingOrders_SubcontractorReqsPOs_Requisition_Requisition = new SeleniumControl( sDriver, "ManufacturingOrders_SubcontractorReqsPOs_Requisition_Requisition", "xpath", "//div[translate(@id,'0123456789','')='pr__PCM_SUBREQPOS_']/ancestor::form[1]/descendant::*[@id='RQ_ID']");
				Function.AssertEqual(true,PCMSCRQ_ManufacturingOrders_SubcontractorReqsPOs_Requisition_Requisition.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMSCRQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMSCRQ] Performing Close on ManufacturingOrders_SubcontractorReqsPOsForm...", Logger.MessageType.INF);
				SeleniumControl PCMSCRQ_ManufacturingOrders_SubcontractorReqsPOsForm = new SeleniumControl( sDriver, "ManufacturingOrders_SubcontractorReqsPOsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCM_SUBREQPOS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCMSCRQ_ManufacturingOrders_SubcontractorReqsPOsForm);
IWebElement formBttn = PCMSCRQ_ManufacturingOrders_SubcontractorReqsPOsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "PCMSCRQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMSCRQ] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl PCMSCRQ_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PCMSCRQ_MainForm);
IWebElement formBttn = PCMSCRQ_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

