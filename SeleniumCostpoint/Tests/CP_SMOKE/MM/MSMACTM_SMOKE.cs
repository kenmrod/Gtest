 
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
    public class MSMACTM_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Manage Master Production Schedule Action Messages", "xpath","//div[@class='navItem'][.='Manage Master Production Schedule Action Messages']").Click();


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
				Function.CurrentComponent = "MSMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMACTM] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl MSMACTM_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,MSMACTM_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMACTM] Performing VerifyExists on MPSPlan...", Logger.MessageType.INF);
				SeleniumControl MSMACTM_MPSPlan = new SeleniumControl( sDriver, "MPSPlan", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='MPS_PLAN_CD']");
				Function.AssertEqual(true,MSMACTM_MPSPlan.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMACTM] Performing Set on Warehouse...", Logger.MessageType.INF);
				SeleniumControl MSMACTM_Warehouse = new SeleniumControl( sDriver, "Warehouse", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='WHSE_ID']");
				MSMACTM_Warehouse.Click();
MSMACTM_Warehouse.SendKeys("WHSE1", true);
Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));
MSMACTM_Warehouse.SendKeys(OpenQA.Selenium.Keys.Shift + OpenQA.Selenium.Keys.Tab);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Set]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMACTM] Performing Set on MPSPlan...", Logger.MessageType.INF);
				SeleniumControl MSMACTM_MPSPlan = new SeleniumControl( sDriver, "MPSPlan", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='MPS_PLAN_CD']");
				MSMACTM_MPSPlan.Click();
MSMACTM_MPSPlan.SendKeys("P", true);
Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));
MSMACTM_MPSPlan.SendKeys(OpenQA.Selenium.Keys.Shift + OpenQA.Selenium.Keys.Tab);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Set]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMACTM] Performing Select on ProjectOption...", Logger.MessageType.INF);
				SeleniumControl MSMACTM_ProjectOption = new SeleniumControl( sDriver, "ProjectOption", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PROJ_OPTION']");
				Function.WaitControlDisplayed(MSMACTM_ProjectOption);
MSMACTM_ProjectOption.ScrollIntoViewUsingJavaScript();
MSMACTM_ProjectOption.Click();
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
				this.ScriptLogger.WriteLine("CHILDFORM");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMACTM] Performing VerifyExist on ActionMessagesFormTable...", Logger.MessageType.INF);
				SeleniumControl MSMACTM_ActionMessagesFormTable = new SeleniumControl( sDriver, "ActionMessagesFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__MSMACTM_ZMSMACTMWRK_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,MSMACTM_ActionMessagesFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMACTM] Performing ClickButton on ActionMessagesForm...", Logger.MessageType.INF);
				SeleniumControl MSMACTM_ActionMessagesForm = new SeleniumControl( sDriver, "ActionMessagesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MSMACTM_ZMSMACTMWRK_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MSMACTM_ActionMessagesForm);
IWebElement formBttn = MSMACTM_ActionMessagesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? MSMACTM_ActionMessagesForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
MSMACTM_ActionMessagesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMACTM] Performing VerifyExists on ActionMessagesForm...", Logger.MessageType.INF);
				SeleniumControl MSMACTM_ActionMessagesForm = new SeleniumControl( sDriver, "ActionMessagesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MSMACTM_ZMSMACTMWRK_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,MSMACTM_ActionMessagesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMACTM] Performing VerifyExists on Part...", Logger.MessageType.INF);
				SeleniumControl MSMACTM_Part = new SeleniumControl( sDriver, "Part", "xpath", "//div[translate(@id,'0123456789','')='pr__MSMACTM_ZMSMACTMWRK_CTW_']/ancestor::form[1]/descendant::*[@id='PART_ID']");
				Function.AssertEqual(true,MSMACTM_Part.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("PARTDETAIL");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMACTM] Performing VerifyExists on ActionMessages_PartDetailLink...", Logger.MessageType.INF);
				SeleniumControl MSMACTM_ActionMessages_PartDetailLink = new SeleniumControl( sDriver, "ActionMessages_PartDetailLink", "ID", "lnk_5556_MSMACTM_ZMSMACTMWRK_CTW");
				Function.AssertEqual(true,MSMACTM_ActionMessages_PartDetailLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("PROJECTS");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMACTM] Performing VerifyExists on ActionMessages_ProjectsLink...", Logger.MessageType.INF);
				SeleniumControl MSMACTM_ActionMessages_ProjectsLink = new SeleniumControl( sDriver, "ActionMessages_ProjectsLink", "ID", "lnk_5516_MSMACTM_ZMSMACTMWRK_CTW");
				Function.AssertEqual(true,MSMACTM_ActionMessages_ProjectsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("WAREHOUSEINVENTORY");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMACTM] Performing VerifyExists on ActionMessages_WarehouseInventoryLink...", Logger.MessageType.INF);
				SeleniumControl MSMACTM_ActionMessages_WarehouseInventoryLink = new SeleniumControl( sDriver, "ActionMessages_WarehouseInventoryLink", "ID", "lnk_5518_MSMACTM_ZMSMACTMWRK_CTW");
				Function.AssertEqual(true,MSMACTM_ActionMessages_WarehouseInventoryLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("INVENTORYDETAILS");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMACTM] Performing VerifyExists on ActionMessages_InventoryDetailsLink...", Logger.MessageType.INF);
				SeleniumControl MSMACTM_ActionMessages_InventoryDetailsLink = new SeleniumControl( sDriver, "ActionMessages_InventoryDetailsLink", "ID", "lnk_5520_MSMACTM_ZMSMACTMWRK_CTW");
				Function.AssertEqual(true,MSMACTM_ActionMessages_InventoryDetailsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("ORDERS");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMACTM] Performing VerifyExists on ActionMessages_OrdersLink...", Logger.MessageType.INF);
				SeleniumControl MSMACTM_ActionMessages_OrdersLink = new SeleniumControl( sDriver, "ActionMessages_OrdersLink", "ID", "lnk_5522_MSMACTM_ZMSMACTMWRK_CTW");
				Function.AssertEqual(true,MSMACTM_ActionMessages_OrdersLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("PO");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMACTM] Performing VerifyExists on ActionMessages_POLink...", Logger.MessageType.INF);
				SeleniumControl MSMACTM_ActionMessages_POLink = new SeleniumControl( sDriver, "ActionMessages_POLink", "ID", "lnk_5524_MSMACTM_ZMSMACTMWRK_CTW");
				Function.AssertEqual(true,MSMACTM_ActionMessages_POLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("MO");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMACTM] Performing VerifyExists on ActionMessages_MOLink...", Logger.MessageType.INF);
				SeleniumControl MSMACTM_ActionMessages_MOLink = new SeleniumControl( sDriver, "ActionMessages_MOLink", "ID", "lnk_5525_MSMACTM_ZMSMACTMWRK_CTW");
				Function.AssertEqual(true,MSMACTM_ActionMessages_MOLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("PLANNEDORDER");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMACTM] Performing VerifyExists on ActionMessages_PlannedOrderLink...", Logger.MessageType.INF);
				SeleniumControl MSMACTM_ActionMessages_PlannedOrderLink = new SeleniumControl( sDriver, "ActionMessages_PlannedOrderLink", "ID", "lnk_5526_MSMACTM_ZMSMACTMWRK_CTW");
				Function.AssertEqual(true,MSMACTM_ActionMessages_PlannedOrderLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("RESERVATION");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMACTM] Performing VerifyExists on ActionMessages_ReservationLink...", Logger.MessageType.INF);
				SeleniumControl MSMACTM_ActionMessages_ReservationLink = new SeleniumControl( sDriver, "ActionMessages_ReservationLink", "ID", "lnk_5527_MSMACTM_ZMSMACTMWRK_CTW");
				Function.AssertEqual(true,MSMACTM_ActionMessages_ReservationLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("REQUISITION");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMACTM] Performing VerifyExists on ActionMessages_RequisitionLink...", Logger.MessageType.INF);
				SeleniumControl MSMACTM_ActionMessages_RequisitionLink = new SeleniumControl( sDriver, "ActionMessages_RequisitionLink", "ID", "lnk_5528_MSMACTM_ZMSMACTMWRK_CTW");
				Function.AssertEqual(true,MSMACTM_ActionMessages_RequisitionLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("WEEKLYDETAILS");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMACTM] Performing VerifyExists on ActionMessages_WeeklyDetailsLink...", Logger.MessageType.INF);
				SeleniumControl MSMACTM_ActionMessages_WeeklyDetailsLink = new SeleniumControl( sDriver, "ActionMessages_WeeklyDetailsLink", "ID", "lnk_5551_MSMACTM_ZMSMACTMWRK_CTW");
				Function.AssertEqual(true,MSMACTM_ActionMessages_WeeklyDetailsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("REGMTS");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMACTM] Performing VerifyExists on ActionMessages_ReqmtsLink...", Logger.MessageType.INF);
				SeleniumControl MSMACTM_ActionMessages_ReqmtsLink = new SeleniumControl( sDriver, "ActionMessages_ReqmtsLink", "ID", "lnk_5558_MSMACTM_ZMSMACTMWRK_CTW");
				Function.AssertEqual(true,MSMACTM_ActionMessages_ReqmtsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("FULLREGMTS");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMACTM] Performing VerifyExists on ActionMessages_FullReqmtsLink...", Logger.MessageType.INF);
				SeleniumControl MSMACTM_ActionMessages_FullReqmtsLink = new SeleniumControl( sDriver, "ActionMessages_FullReqmtsLink", "ID", "lnk_5532_MSMACTM_ZMSMACTMWRK_CTW");
				Function.AssertEqual(true,MSMACTM_ActionMessages_FullReqmtsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("SUBSTITUTES");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMACTM] Performing VerifyExists on ActionMessages_SubstitutesLink...", Logger.MessageType.INF);
				SeleniumControl MSMACTM_ActionMessages_SubstitutesLink = new SeleniumControl( sDriver, "ActionMessages_SubstitutesLink", "ID", "lnk_5534_MSMACTM_ZMSMACTMWRK_CTW");
				Function.AssertEqual(true,MSMACTM_ActionMessages_SubstitutesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
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
				Function.CurrentComponent = "MSMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMACTM] Performing VerifyExists on ActionMessages_ECNsLink...", Logger.MessageType.INF);
				SeleniumControl MSMACTM_ActionMessages_ECNsLink = new SeleniumControl( sDriver, "ActionMessages_ECNsLink", "ID", "lnk_5536_MSMACTM_ZMSMACTMWRK_CTW");
				Function.AssertEqual(true,MSMACTM_ActionMessages_ECNsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMACTM] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl MSMACTM_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(MSMACTM_MainForm);
IWebElement formBttn = MSMACTM_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

