 
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
    public class PCMPLNR_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Production Control Controls", "xpath","//div[@class='navItem'][.='Production Control Controls']").Click();
new SeleniumControl(sDriver,"Manage Planners", "xpath","//div[@class='navItem'][.='Manage Planners']").Click();


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
				Function.CurrentComponent = "PCMPLNR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMPLNR] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl PCMPLNR_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PCMPLNR_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMPLNR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMPLNR] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl PCMPLNR_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PCMPLNR_MainForm);
IWebElement formBttn = PCMPLNR_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PCMPLNR_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PCMPLNR_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMPLNR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMPLNR] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl PCMPLNR_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,PCMPLNR_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMPLNR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMPLNR] Performing VerifyExists on PlannerID...", Logger.MessageType.INF);
				SeleniumControl PCMPLNR_PlannerID = new SeleniumControl( sDriver, "PlannerID", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PLANNER_ID']");
				Function.AssertEqual(true,PCMPLNR_PlannerID.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Selected Inventory");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMPLNR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMPLNR] Performing VerifyExists on SelectedInventoryProjectsLink...", Logger.MessageType.INF);
				SeleniumControl PCMPLNR_SelectedInventoryProjectsLink = new SeleniumControl( sDriver, "SelectedInventoryProjectsLink", "ID", "lnk_1002195_PCMPLNR_PLANNER");
				Function.AssertEqual(true,PCMPLNR_SelectedInventoryProjectsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMPLNR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMPLNR] Performing Click on SelectedInventoryProjectsLink...", Logger.MessageType.INF);
				SeleniumControl PCMPLNR_SelectedInventoryProjectsLink = new SeleniumControl( sDriver, "SelectedInventoryProjectsLink", "ID", "lnk_1002195_PCMPLNR_PLANNER");
				Function.WaitControlDisplayed(PCMPLNR_SelectedInventoryProjectsLink);
PCMPLNR_SelectedInventoryProjectsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMPLNR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMPLNR] Performing VerifyExist on InventoryProjectsTable...", Logger.MessageType.INF);
				SeleniumControl PCMPLNR_InventoryProjectsTable = new SeleniumControl( sDriver, "InventoryProjectsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMPLNR_INVPROJECTS_FROM_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PCMPLNR_InventoryProjectsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMPLNR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMPLNR] Performing VerifyExist on SelectedInventoryProjectsTable...", Logger.MessageType.INF);
				SeleniumControl PCMPLNR_SelectedInventoryProjectsTable = new SeleniumControl( sDriver, "SelectedInventoryProjectsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMPLNR_INVPROJECTS_TO_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PCMPLNR_SelectedInventoryProjectsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMPLNR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMPLNR] Performing Close on SelectedInventoryProjectsForm...", Logger.MessageType.INF);
				SeleniumControl PCMPLNR_SelectedInventoryProjectsForm = new SeleniumControl( sDriver, "SelectedInventoryProjectsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMPLNR_INVPROJECTS_TO_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCMPLNR_SelectedInventoryProjectsForm);
IWebElement formBttn = PCMPLNR_SelectedInventoryProjectsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Selected Netting");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMPLNR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMPLNR] Performing VerifyExists on SelectedNettingGroupsLink...", Logger.MessageType.INF);
				SeleniumControl PCMPLNR_SelectedNettingGroupsLink = new SeleniumControl( sDriver, "SelectedNettingGroupsLink", "ID", "lnk_1002217_PCMPLNR_PLANNER");
				Function.AssertEqual(true,PCMPLNR_SelectedNettingGroupsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMPLNR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMPLNR] Performing Click on SelectedNettingGroupsLink...", Logger.MessageType.INF);
				SeleniumControl PCMPLNR_SelectedNettingGroupsLink = new SeleniumControl( sDriver, "SelectedNettingGroupsLink", "ID", "lnk_1002217_PCMPLNR_PLANNER");
				Function.WaitControlDisplayed(PCMPLNR_SelectedNettingGroupsLink);
PCMPLNR_SelectedNettingGroupsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMPLNR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMPLNR] Performing VerifyExist on NettingGroupTable...", Logger.MessageType.INF);
				SeleniumControl PCMPLNR_NettingGroupTable = new SeleniumControl( sDriver, "NettingGroupTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMPLNR_NETGRPS_FROM_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PCMPLNR_NettingGroupTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMPLNR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMPLNR] Performing VerifyExist on SelectedNettingGroupTable...", Logger.MessageType.INF);
				SeleniumControl PCMPLNR_SelectedNettingGroupTable = new SeleniumControl( sDriver, "SelectedNettingGroupTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMPLNR_NETGRPS_TO_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PCMPLNR_SelectedNettingGroupTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMPLNR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMPLNR] Performing Close on SelectedNettingGroupForm...", Logger.MessageType.INF);
				SeleniumControl PCMPLNR_SelectedNettingGroupForm = new SeleniumControl( sDriver, "SelectedNettingGroupForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMPLNR_NETGRPS_TO_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCMPLNR_SelectedNettingGroupForm);
IWebElement formBttn = PCMPLNR_SelectedNettingGroupForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Selected Commodities");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMPLNR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMPLNR] Performing VerifyExists on SelectedCommoditiesLink...", Logger.MessageType.INF);
				SeleniumControl PCMPLNR_SelectedCommoditiesLink = new SeleniumControl( sDriver, "SelectedCommoditiesLink", "ID", "lnk_1002219_PCMPLNR_PLANNER");
				Function.AssertEqual(true,PCMPLNR_SelectedCommoditiesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMPLNR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMPLNR] Performing Click on SelectedCommoditiesLink...", Logger.MessageType.INF);
				SeleniumControl PCMPLNR_SelectedCommoditiesLink = new SeleniumControl( sDriver, "SelectedCommoditiesLink", "ID", "lnk_1002219_PCMPLNR_PLANNER");
				Function.WaitControlDisplayed(PCMPLNR_SelectedCommoditiesLink);
PCMPLNR_SelectedCommoditiesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMPLNR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMPLNR] Performing VerifyExist on CommoditiesTable...", Logger.MessageType.INF);
				SeleniumControl PCMPLNR_CommoditiesTable = new SeleniumControl( sDriver, "CommoditiesTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMPLNR_COMM_FROM_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PCMPLNR_CommoditiesTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMPLNR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMPLNR] Performing VerifyExist on SelectedCommoditiesTable...", Logger.MessageType.INF);
				SeleniumControl PCMPLNR_SelectedCommoditiesTable = new SeleniumControl( sDriver, "SelectedCommoditiesTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMPLNR_COMM_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PCMPLNR_SelectedCommoditiesTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMPLNR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMPLNR] Performing Close on SelectedCommoditiesForm...", Logger.MessageType.INF);
				SeleniumControl PCMPLNR_SelectedCommoditiesForm = new SeleniumControl( sDriver, "SelectedCommoditiesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMPLNR_COMM_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCMPLNR_SelectedCommoditiesForm);
IWebElement formBttn = PCMPLNR_SelectedCommoditiesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "PCMPLNR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMPLNR] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl PCMPLNR_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PCMPLNR_MainForm);
IWebElement formBttn = PCMPLNR_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

