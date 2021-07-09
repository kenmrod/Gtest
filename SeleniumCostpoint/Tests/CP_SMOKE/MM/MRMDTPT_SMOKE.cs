 
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
    public class MRMDTPT_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Material Requirements Planning", "xpath","//div[@class='navItem'][.='Material Requirements Planning']").Click();
new SeleniumControl(sDriver,"Manage Detailed Part Schedule", "xpath","//div[@class='navItem'][.='Manage Detailed Part Schedule']").Click();


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
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,MRMDTPT_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing VerifyExists on Part...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_Part = new SeleniumControl( sDriver, "Part", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PART_ID']");
				Function.AssertEqual(true,MRMDTPT_Part.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing Set on Part...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_Part = new SeleniumControl( sDriver, "Part", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PART_ID']");
				MRMDTPT_Part.Click();
MRMDTPT_Part.SendKeys("100", true);
Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));
MRMDTPT_Part.SendKeys(OpenQA.Selenium.Keys.Shift + OpenQA.Selenium.Keys.Tab);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Set]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing Select on InventoryProjectSelection_Option...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_InventoryProjectSelection_Option = new SeleniumControl( sDriver, "InventoryProjectSelection_Option", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PROJ_OPTION']");
				Function.WaitControlDisplayed(MRMDTPT_InventoryProjectSelection_Option);
MRMDTPT_InventoryProjectSelection_Option.ScrollIntoViewUsingJavaScript();
MRMDTPT_InventoryProjectSelection_Option.Click();
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
				this.ScriptLogger.WriteLine("PARTDETAIL");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing VerifyExist on PartScheduleFormTable...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_PartScheduleFormTable = new SeleniumControl( sDriver, "PartScheduleFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__MRMDTPT_ZMRMDTPTWRK_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,MRMDTPT_PartScheduleFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing VerifyExists on PartScheduleForm...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_PartScheduleForm = new SeleniumControl( sDriver, "PartScheduleForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MRMDTPT_ZMRMDTPTWRK_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,MRMDTPT_PartScheduleForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing Click on PartDetailLink...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_PartDetailLink = new SeleniumControl( sDriver, "PartDetailLink", "ID", "lnk_5194_MRMDTPT_HDR");
				Function.WaitControlDisplayed(MRMDTPT_PartDetailLink);
MRMDTPT_PartDetailLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing VerifyExists on PartDetailForm...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_PartDetailForm = new SeleniumControl( sDriver, "PartDetailForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_PARTPROJ_HDR_']/ancestor::form[1]");
				Function.AssertEqual(true,MRMDTPT_PartDetailForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing VerifyExists on PlanningType...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_PlanningType = new SeleniumControl( sDriver, "PlanningType", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_PARTPROJ_HDR_']/ancestor::form[1]/descendant::*[@id='S_PLAN_DESC']");
				Function.AssertEqual(true,MRMDTPT_PlanningType.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing VerifyExist on PartDetail_PartProjectInformationFormTable...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_PartDetail_PartProjectInformationFormTable = new SeleniumControl( sDriver, "PartDetail_PartProjectInformationFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_PARTPROJ_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,MRMDTPT_PartDetail_PartProjectInformationFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing ClickButton on PartDetail_PartProjectInformationForm...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_PartDetail_PartProjectInformationForm = new SeleniumControl( sDriver, "PartDetail_PartProjectInformationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_PARTPROJ_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MRMDTPT_PartDetail_PartProjectInformationForm);
IWebElement formBttn = MRMDTPT_PartDetail_PartProjectInformationForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? MRMDTPT_PartDetail_PartProjectInformationForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
MRMDTPT_PartDetail_PartProjectInformationForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing VerifyExists on PartDetail_PartProjectInformationForm...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_PartDetail_PartProjectInformationForm = new SeleniumControl( sDriver, "PartDetail_PartProjectInformationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_PARTPROJ_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,MRMDTPT_PartDetail_PartProjectInformationForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing VerifyExists on PartDetail_PartProjectInformation_Project...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_PartDetail_PartProjectInformation_Project = new SeleniumControl( sDriver, "PartDetail_PartProjectInformation_Project", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_PARTPROJ_CTW_']/ancestor::form[1]/descendant::*[@id='PROJ_ID']");
				Function.AssertEqual(true,MRMDTPT_PartDetail_PartProjectInformation_Project.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing Close on PartDetailForm...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_PartDetailForm = new SeleniumControl( sDriver, "PartDetailForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_PARTPROJ_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MRMDTPT_PartDetailForm);
IWebElement formBttn = MRMDTPT_PartDetailForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
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
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing Click on ProjectsLink...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_ProjectsLink = new SeleniumControl( sDriver, "ProjectsLink", "ID", "lnk_5192_MRMDTPT_HDR");
				Function.WaitControlDisplayed(MRMDTPT_ProjectsLink);
MRMDTPT_ProjectsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing VerifyExists on ProjectsForm...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_ProjectsForm = new SeleniumControl( sDriver, "ProjectsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_INVTPROJ_HDR_']/ancestor::form[1]");
				Function.AssertEqual(true,MRMDTPT_ProjectsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing VerifyExists on Projects_Option...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_Projects_Option = new SeleniumControl( sDriver, "Projects_Option", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_INVTPROJ_HDR_']/ancestor::form[1]/descendant::*[@id='PROJ_OPTION']");
				Function.AssertEqual(true,MRMDTPT_Projects_Option.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing VerifyExist on Projects_InvetoryAbbreviationsFormTable...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_Projects_InvetoryAbbreviationsFormTable = new SeleniumControl( sDriver, "Projects_InvetoryAbbreviationsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_INVTPROJ_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,MRMDTPT_Projects_InvetoryAbbreviationsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing ClickButton on Projects_InvetoryAbbreviationsForm...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_Projects_InvetoryAbbreviationsForm = new SeleniumControl( sDriver, "Projects_InvetoryAbbreviationsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_INVTPROJ_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MRMDTPT_Projects_InvetoryAbbreviationsForm);
IWebElement formBttn = MRMDTPT_Projects_InvetoryAbbreviationsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? MRMDTPT_Projects_InvetoryAbbreviationsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
MRMDTPT_Projects_InvetoryAbbreviationsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing VerifyExists on Projects_InvetoryAbbreviationsForm...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_Projects_InvetoryAbbreviationsForm = new SeleniumControl( sDriver, "Projects_InvetoryAbbreviationsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_INVTPROJ_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,MRMDTPT_Projects_InvetoryAbbreviationsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing VerifyExists on Projects_InvetoryAbbreviations_InventoryAbbreviation...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_Projects_InvetoryAbbreviations_InventoryAbbreviation = new SeleniumControl( sDriver, "Projects_InvetoryAbbreviations_InventoryAbbreviation", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_INVTPROJ_CTW_']/ancestor::form[1]/descendant::*[@id='INVT_ABBRV_CD']");
				Function.AssertEqual(true,MRMDTPT_Projects_InvetoryAbbreviations_InventoryAbbreviation.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing Close on ProjectsForm...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_ProjectsForm = new SeleniumControl( sDriver, "ProjectsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_INVTPROJ_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MRMDTPT_ProjectsForm);
IWebElement formBttn = MRMDTPT_ProjectsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
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
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing VerifyExists on WarehouseInventoryLink...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_WarehouseInventoryLink = new SeleniumControl( sDriver, "WarehouseInventoryLink", "ID", "lnk_5308_MRMDTPT_HDR");
				Function.AssertEqual(true,MRMDTPT_WarehouseInventoryLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing Click on WarehouseInventoryLink...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_WarehouseInventoryLink = new SeleniumControl( sDriver, "WarehouseInventoryLink", "ID", "lnk_5308_MRMDTPT_HDR");
				Function.WaitControlDisplayed(MRMDTPT_WarehouseInventoryLink);
MRMDTPT_WarehouseInventoryLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing VerifyExists on WarehouseInventoryForm...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_WarehouseInventoryForm = new SeleniumControl( sDriver, "WarehouseInventoryForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MRMDTPT_INVTWHSELOC_HDR_']/ancestor::form[1]");
				Function.AssertEqual(true,MRMDTPT_WarehouseInventoryForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing VerifyExists on WarehouseInventory_Option...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_WarehouseInventory_Option = new SeleniumControl( sDriver, "WarehouseInventory_Option", "xpath", "//div[translate(@id,'0123456789','')='pr__MRMDTPT_INVTWHSELOC_HDR_']/ancestor::form[1]/descendant::*[@id='PROJ_OPTION']");
				Function.AssertEqual(true,MRMDTPT_WarehouseInventory_Option.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing VerifyExist on WarehouseInventory_WarehouseInventoryDetailFormTable...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_WarehouseInventory_WarehouseInventoryDetailFormTable = new SeleniumControl( sDriver, "WarehouseInventory_WarehouseInventoryDetailFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_INVTWHSELOC_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,MRMDTPT_WarehouseInventory_WarehouseInventoryDetailFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing ClickButton on WarehouseInventory_WarehouseInventoryDetailForm...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_WarehouseInventory_WarehouseInventoryDetailForm = new SeleniumControl( sDriver, "WarehouseInventory_WarehouseInventoryDetailForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_INVTWHSELOC_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MRMDTPT_WarehouseInventory_WarehouseInventoryDetailForm);
IWebElement formBttn = MRMDTPT_WarehouseInventory_WarehouseInventoryDetailForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? MRMDTPT_WarehouseInventory_WarehouseInventoryDetailForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
MRMDTPT_WarehouseInventory_WarehouseInventoryDetailForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing VerifyExists on WarehouseInventory_WarehouseInventoryDetailForm...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_WarehouseInventory_WarehouseInventoryDetailForm = new SeleniumControl( sDriver, "WarehouseInventory_WarehouseInventoryDetailForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_INVTWHSELOC_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,MRMDTPT_WarehouseInventory_WarehouseInventoryDetailForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing VerifyExists on WarehouseInventory_WarehouseInventoryDetail_Warehouse...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_WarehouseInventory_WarehouseInventoryDetail_Warehouse = new SeleniumControl( sDriver, "WarehouseInventory_WarehouseInventoryDetail_Warehouse", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_INVTWHSELOC_CTW_']/ancestor::form[1]/descendant::*[@id='WHSE_ID']");
				Function.AssertEqual(true,MRMDTPT_WarehouseInventory_WarehouseInventoryDetail_Warehouse.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing Close on WarehouseInventoryForm...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_WarehouseInventoryForm = new SeleniumControl( sDriver, "WarehouseInventoryForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MRMDTPT_INVTWHSELOC_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MRMDTPT_WarehouseInventoryForm);
IWebElement formBttn = MRMDTPT_WarehouseInventoryForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("INVENTORYDETAIL");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing Click on InventoryDetailLink...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_InventoryDetailLink = new SeleniumControl( sDriver, "InventoryDetailLink", "ID", "lnk_5310_MRMDTPT_HDR");
				Function.WaitControlDisplayed(MRMDTPT_InventoryDetailLink);
MRMDTPT_InventoryDetailLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing VerifyExists on InventoryDetailForm...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_InventoryDetailForm = new SeleniumControl( sDriver, "InventoryDetailForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MRMDTPT_INVT_HDR_']/ancestor::form[1]");
				Function.AssertEqual(true,MRMDTPT_InventoryDetailForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing VerifyExists on InventoryDetail_Option...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_InventoryDetail_Option = new SeleniumControl( sDriver, "InventoryDetail_Option", "xpath", "//div[translate(@id,'0123456789','')='pr__MRMDTPT_INVT_HDR_']/ancestor::form[1]/descendant::*[@id='PROJ_OPTION']");
				Function.AssertEqual(true,MRMDTPT_InventoryDetail_Option.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing VerifyExist on InventoryDetail_InventoryQuantitiesFormTable...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_InventoryDetail_InventoryQuantitiesFormTable = new SeleniumControl( sDriver, "InventoryDetail_InventoryQuantitiesFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_INVT_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,MRMDTPT_InventoryDetail_InventoryQuantitiesFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing ClickButton on InventoryDetail_InventoryQuantitiesForm...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_InventoryDetail_InventoryQuantitiesForm = new SeleniumControl( sDriver, "InventoryDetail_InventoryQuantitiesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_INVT_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MRMDTPT_InventoryDetail_InventoryQuantitiesForm);
IWebElement formBttn = MRMDTPT_InventoryDetail_InventoryQuantitiesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? MRMDTPT_InventoryDetail_InventoryQuantitiesForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
MRMDTPT_InventoryDetail_InventoryQuantitiesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing VerifyExists on InventoryDetail_InventoryQuantitiesForm...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_InventoryDetail_InventoryQuantitiesForm = new SeleniumControl( sDriver, "InventoryDetail_InventoryQuantitiesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_INVT_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,MRMDTPT_InventoryDetail_InventoryQuantitiesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing VerifyExists on InventoryDetail_InventoryQuantities_InventoryAbbrev...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_InventoryDetail_InventoryQuantities_InventoryAbbrev = new SeleniumControl( sDriver, "InventoryDetail_InventoryQuantities_InventoryAbbrev", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_INVT_CTW_']/ancestor::form[1]/descendant::*[@id='INVT_ABBRV_CD']");
				Function.AssertEqual(true,MRMDTPT_InventoryDetail_InventoryQuantities_InventoryAbbrev.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing Close on InventoryDetailForm...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_InventoryDetailForm = new SeleniumControl( sDriver, "InventoryDetailForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MRMDTPT_INVT_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MRMDTPT_InventoryDetailForm);
IWebElement formBttn = MRMDTPT_InventoryDetailForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("ACTIONMESSAGES");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing Click on ActionMessagesLink...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_ActionMessagesLink = new SeleniumControl( sDriver, "ActionMessagesLink", "ID", "lnk_5197_MRMDTPT_HDR");
				Function.WaitControlDisplayed(MRMDTPT_ActionMessagesLink);
MRMDTPT_ActionMessagesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing VerifyExist on ActionMessagesFormTable...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_ActionMessagesFormTable = new SeleniumControl( sDriver, "ActionMessagesFormTable", "xpath", "//div[starts-with(@id,'pr__MRMDTPT_ZMRMDTPTWRK1_CTW_')]/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,MRMDTPT_ActionMessagesFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing ClickButton on ActionMessagesForm...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_ActionMessagesForm = new SeleniumControl( sDriver, "ActionMessagesForm", "xpath", "//div[starts-with(@id,'pr__MRMDTPT_ZMRMDTPTWRK1_CTW_')]/ancestor::form[1]");
				Function.WaitControlDisplayed(MRMDTPT_ActionMessagesForm);
IWebElement formBttn = MRMDTPT_ActionMessagesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? MRMDTPT_ActionMessagesForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
MRMDTPT_ActionMessagesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing VerifyExists on ActionMessagesForm...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_ActionMessagesForm = new SeleniumControl( sDriver, "ActionMessagesForm", "xpath", "//div[starts-with(@id,'pr__MRMDTPT_ZMRMDTPTWRK1_CTW_')]/ancestor::form[1]");
				Function.AssertEqual(true,MRMDTPT_ActionMessagesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing VerifyExists on ActionMessages_MessageType...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_ActionMessages_MessageType = new SeleniumControl( sDriver, "ActionMessages_MessageType", "xpath", "//div[starts-with(@id,'pr__MRMDTPT_ZMRMDTPTWRK1_CTW_')]/ancestor::form[1]/descendant::*[@id='S_MRP_MSG_TYPE_CD']");
				Function.AssertEqual(true,MRMDTPT_ActionMessages_MessageType.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing Close on ActionMessagesForm...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_ActionMessagesForm = new SeleniumControl( sDriver, "ActionMessagesForm", "xpath", "//div[starts-with(@id,'pr__MRMDTPT_ZMRMDTPTWRK1_CTW_')]/ancestor::form[1]");
				Function.WaitControlDisplayed(MRMDTPT_ActionMessagesForm);
IWebElement formBttn = MRMDTPT_ActionMessagesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("ECNS");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing Click on ECNsLink...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_ECNsLink = new SeleniumControl( sDriver, "ECNsLink", "ID", "lnk_5184_MRMDTPT_HDR");
				Function.WaitControlDisplayed(MRMDTPT_ECNsLink);
MRMDTPT_ECNsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing VerifyExist on ECNsFormTable...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_ECNsFormTable = new SeleniumControl( sDriver, "ECNsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_ECNPART_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,MRMDTPT_ECNsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing ClickButton on ECNsForm...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_ECNsForm = new SeleniumControl( sDriver, "ECNsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_ECNPART_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MRMDTPT_ECNsForm);
IWebElement formBttn = MRMDTPT_ECNsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? MRMDTPT_ECNsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
MRMDTPT_ECNsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing VerifyExists on ECNsForm...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_ECNsForm = new SeleniumControl( sDriver, "ECNsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_ECNPART_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,MRMDTPT_ECNsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing VerifyExists on ECNs_EngineeringChangeNotice...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_ECNs_EngineeringChangeNotice = new SeleniumControl( sDriver, "ECNs_EngineeringChangeNotice", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_ECNPART_CTW_']/ancestor::form[1]/descendant::*[@id='ECN_ID']");
				Function.AssertEqual(true,MRMDTPT_ECNs_EngineeringChangeNotice.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing Select on ECNs_Tab...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_ECNs_Tab = new SeleniumControl( sDriver, "ECNs_Tab", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_ECNPART_CTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(MRMDTPT_ECNs_Tab);
IWebElement mTab = MRMDTPT_ECNs_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "ECN Details").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing VerifyExists on ECNs_ECNDetails_Status...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_ECNs_ECNDetails_Status = new SeleniumControl( sDriver, "ECNs_ECNDetails_Status", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_ECNPART_CTW_']/ancestor::form[1]/descendant::*[@id='S_ECN_STATUS_CD']");
				Function.AssertEqual(true,MRMDTPT_ECNs_ECNDetails_Status.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing Select on ECNs_Tab...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_ECNs_Tab = new SeleniumControl( sDriver, "ECNs_Tab", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_ECNPART_CTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(MRMDTPT_ECNs_Tab);
IWebElement mTab = MRMDTPT_ECNs_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Part Information").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing VerifyExists on ECNs_PartInformation_ActionCode...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_ECNs_PartInformation_ActionCode = new SeleniumControl( sDriver, "ECNs_PartInformation_ActionCode", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_ECNPART_CTW_']/ancestor::form[1]/descendant::*[@id='S_ECN_ACTION_CD']");
				Function.AssertEqual(true,MRMDTPT_ECNs_PartInformation_ActionCode.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing Close on ECNsForm...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_ECNsForm = new SeleniumControl( sDriver, "ECNsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_ECNPART_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MRMDTPT_ECNsForm);
IWebElement formBttn = MRMDTPT_ECNsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
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
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing Click on SubstitutesLink...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_SubstitutesLink = new SeleniumControl( sDriver, "SubstitutesLink", "ID", "lnk_5312_MRMDTPT_HDR");
				Function.WaitControlDisplayed(MRMDTPT_SubstitutesLink);
MRMDTPT_SubstitutesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing VerifyExists on SubstitutesForm...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_SubstitutesForm = new SeleniumControl( sDriver, "SubstitutesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MRMDTPT_ZMRMACTMSUBST_HDR_']/ancestor::form[1]");
				Function.AssertEqual(true,MRMDTPT_SubstitutesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing VerifyExists on Substitutes_Project...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_Substitutes_Project = new SeleniumControl( sDriver, "Substitutes_Project", "xpath", "//div[translate(@id,'0123456789','')='pr__MRMDTPT_ZMRMACTMSUBST_HDR_']/ancestor::form[1]/descendant::*[@id='INVT_PROJ_ID']");
				Function.AssertEqual(true,MRMDTPT_Substitutes_Project.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing VerifyExist on Substitutes_SubstitutePartInventoryFormTable...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_Substitutes_SubstitutePartInventoryFormTable = new SeleniumControl( sDriver, "Substitutes_SubstitutePartInventoryFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_ZMRMACTMSUBST_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,MRMDTPT_Substitutes_SubstitutePartInventoryFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing VerifyExists on Substitutes_SubstitutePartInventoryForm...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_Substitutes_SubstitutePartInventoryForm = new SeleniumControl( sDriver, "Substitutes_SubstitutePartInventoryForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_ZMRMACTMSUBST_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,MRMDTPT_Substitutes_SubstitutePartInventoryForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing ClickButton on Substitutes_SubstitutePartInventoryForm...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_Substitutes_SubstitutePartInventoryForm = new SeleniumControl( sDriver, "Substitutes_SubstitutePartInventoryForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_ZMRMACTMSUBST_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MRMDTPT_Substitutes_SubstitutePartInventoryForm);
IWebElement formBttn = MRMDTPT_Substitutes_SubstitutePartInventoryForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? MRMDTPT_Substitutes_SubstitutePartInventoryForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
MRMDTPT_Substitutes_SubstitutePartInventoryForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing VerifyExists on Substitutes_SubstitutePartInventory_SubstitutePart...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_Substitutes_SubstitutePartInventory_SubstitutePart = new SeleniumControl( sDriver, "Substitutes_SubstitutePartInventory_SubstitutePart", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_ZMRMACTMSUBST_CTW_']/ancestor::form[1]/descendant::*[@id='PART_ID']");
				Function.AssertEqual(true,MRMDTPT_Substitutes_SubstitutePartInventory_SubstitutePart.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing Select on Substitutes_SubstitutePartInventory_Tab...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_Substitutes_SubstitutePartInventory_Tab = new SeleniumControl( sDriver, "Substitutes_SubstitutePartInventory_Tab", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_ZMRMACTMSUBST_CTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(MRMDTPT_Substitutes_SubstitutePartInventory_Tab);
IWebElement mTab = MRMDTPT_Substitutes_SubstitutePartInventory_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Quantities").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing VerifyExists on Substitutes_SubstitutePartInventory_Quantities_NetAvailable...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_Substitutes_SubstitutePartInventory_Quantities_NetAvailable = new SeleniumControl( sDriver, "Substitutes_SubstitutePartInventory_Quantities_NetAvailable", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_ZMRMACTMSUBST_CTW_']/ancestor::form[1]/descendant::*[@id='NET_AVAIL_QTY']");
				Function.AssertEqual(true,MRMDTPT_Substitutes_SubstitutePartInventory_Quantities_NetAvailable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing Close on SubstitutesForm...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_SubstitutesForm = new SeleniumControl( sDriver, "SubstitutesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MRMDTPT_ZMRMACTMSUBST_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MRMDTPT_SubstitutesForm);
IWebElement formBttn = MRMDTPT_SubstitutesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("PARTSCHEDULE");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing Set on Part...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_Part = new SeleniumControl( sDriver, "Part", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PART_ID']");
				MRMDTPT_Part.Click();
MRMDTPT_Part.SendKeys("CRP-PART", true);
Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));
MRMDTPT_Part.SendKeys(OpenQA.Selenium.Keys.Shift + OpenQA.Selenium.Keys.Tab);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Set]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing Set on Warehouse...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_Warehouse = new SeleniumControl( sDriver, "Warehouse", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='WHSE_ID']");
				MRMDTPT_Warehouse.Click();
MRMDTPT_Warehouse.SendKeys("CRP-W1", true);
Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));
MRMDTPT_Warehouse.SendKeys(OpenQA.Selenium.Keys.Shift + OpenQA.Selenium.Keys.Tab);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Set]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing VerifyExist on PartScheduleFormTable...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_PartScheduleFormTable = new SeleniumControl( sDriver, "PartScheduleFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__MRMDTPT_ZMRMDTPTWRK_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,MRMDTPT_PartScheduleFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing ClickButton on PartScheduleForm...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_PartScheduleForm = new SeleniumControl( sDriver, "PartScheduleForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MRMDTPT_ZMRMDTPTWRK_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MRMDTPT_PartScheduleForm);
IWebElement formBttn = MRMDTPT_PartScheduleForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).Count <= 0 ? MRMDTPT_PartScheduleForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Query')]")).FirstOrDefault() :
MRMDTPT_PartScheduleForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).FirstOrDefault();
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
                    Query_Find.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing ClickButton on PartScheduleForm...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_PartScheduleForm = new SeleniumControl( sDriver, "PartScheduleForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MRMDTPT_ZMRMDTPTWRK_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MRMDTPT_PartScheduleForm);
IWebElement formBttn = MRMDTPT_PartScheduleForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? MRMDTPT_PartScheduleForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
MRMDTPT_PartScheduleForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing VerifyExists on PartScheduleForm...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_PartScheduleForm = new SeleniumControl( sDriver, "PartScheduleForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MRMDTPT_ZMRMDTPTWRK_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,MRMDTPT_PartScheduleForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing VerifyExists on PartSchedule_OrderType...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_PartSchedule_OrderType = new SeleniumControl( sDriver, "PartSchedule_OrderType", "xpath", "//div[translate(@id,'0123456789','')='pr__MRMDTPT_ZMRMDTPTWRK_CTW_']/ancestor::form[1]/descendant::*[@id='S_SRCE_TYPE_DESC1']");
				Function.AssertEqual(true,MRMDTPT_PartSchedule_OrderType.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("PLANNERORDERSUPPLY");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing Click on PartSchedule_PlannedOrderSupplyLink...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_PartSchedule_PlannedOrderSupplyLink = new SeleniumControl( sDriver, "PartSchedule_PlannedOrderSupplyLink", "ID", "lnk_5226_MRMDTPT_ZMRMDTPTWRK_CTW");
				Function.WaitControlDisplayed(MRMDTPT_PartSchedule_PlannedOrderSupplyLink);
MRMDTPT_PartSchedule_PlannedOrderSupplyLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing VerifyExists on PlannedOrderSupplyForm...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_PlannedOrderSupplyForm = new SeleniumControl( sDriver, "PlannedOrderSupplyForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MRMDTPT_ZMRMDTPTWRK_DTL_']/ancestor::form[1]");
				Function.AssertEqual(true,MRMDTPT_PlannedOrderSupplyForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing VerifyExists on PlannedOrderSupply_OrderRequisition...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_PlannedOrderSupply_OrderRequisition = new SeleniumControl( sDriver, "PlannedOrderSupply_OrderRequisition", "xpath", "//div[translate(@id,'0123456789','')='pr__MRMDTPT_ZMRMDTPTWRK_DTL_']/ancestor::form[1]/descendant::*[@id='ORD_ID']");
				Function.AssertEqual(true,MRMDTPT_PlannedOrderSupply_OrderRequisition.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing Close on PlannedOrderSupplyForm...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_PlannedOrderSupplyForm = new SeleniumControl( sDriver, "PlannedOrderSupplyForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MRMDTPT_ZMRMDTPTWRK_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MRMDTPT_PlannedOrderSupplyForm);
IWebElement formBttn = MRMDTPT_PlannedOrderSupplyForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("REQUISITIONSUPPLY");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing Click on PartSchedule_RequisitionSupplyLink...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_PartSchedule_RequisitionSupplyLink = new SeleniumControl( sDriver, "PartSchedule_RequisitionSupplyLink", "ID", "lnk_5214_MRMDTPT_ZMRMDTPTWRK_CTW");
				Function.WaitControlDisplayed(MRMDTPT_PartSchedule_RequisitionSupplyLink);
MRMDTPT_PartSchedule_RequisitionSupplyLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing VerifyExists on RequisitionSupplyForm...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_RequisitionSupplyForm = new SeleniumControl( sDriver, "RequisitionSupplyForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MRM_RQLN_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,MRMDTPT_RequisitionSupplyForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing VerifyExists on RequisitionSupply_Requisition...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_RequisitionSupply_Requisition = new SeleniumControl( sDriver, "RequisitionSupply_Requisition", "xpath", "//div[translate(@id,'0123456789','')='pr__MRM_RQLN_CTW_']/ancestor::form[1]/descendant::*[@id='RQ_ID']");
				Function.AssertEqual(true,MRMDTPT_RequisitionSupply_Requisition.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing Close on RequisitionSupplyForm...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_RequisitionSupplyForm = new SeleniumControl( sDriver, "RequisitionSupplyForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MRM_RQLN_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MRMDTPT_RequisitionSupplyForm);
IWebElement formBttn = MRMDTPT_RequisitionSupplyForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("PURCHASEORDERSUPPLY");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing Click on PartSchedule_PurchaseOrderSupplyLink...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_PartSchedule_PurchaseOrderSupplyLink = new SeleniumControl( sDriver, "PartSchedule_PurchaseOrderSupplyLink", "ID", "lnk_5215_MRMDTPT_ZMRMDTPTWRK_CTW");
				Function.WaitControlDisplayed(MRMDTPT_PartSchedule_PurchaseOrderSupplyLink);
MRMDTPT_PartSchedule_PurchaseOrderSupplyLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing VerifyExists on PurchaseOrderSupplyForm...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_PurchaseOrderSupplyForm = new SeleniumControl( sDriver, "PurchaseOrderSupplyForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MRM_POHDR_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,MRMDTPT_PurchaseOrderSupplyForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing VerifyExists on PurchaseOrderSupply_PurchaseOrder...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_PurchaseOrderSupply_PurchaseOrder = new SeleniumControl( sDriver, "PurchaseOrderSupply_PurchaseOrder", "xpath", "//div[translate(@id,'0123456789','')='pr__MRM_POHDR_CTW_']/ancestor::form[1]/descendant::*[@id='PO_ID']");
				Function.AssertEqual(true,MRMDTPT_PurchaseOrderSupply_PurchaseOrder.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing Close on PurchaseOrderSupplyForm...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_PurchaseOrderSupplyForm = new SeleniumControl( sDriver, "PurchaseOrderSupplyForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MRM_POHDR_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MRMDTPT_PurchaseOrderSupplyForm);
IWebElement formBttn = MRMDTPT_PurchaseOrderSupplyForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("MANUFACTURINGORDERSUPPLY");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing Click on PartSchedule_ManufacturingOrderSupplyLink...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_PartSchedule_ManufacturingOrderSupplyLink = new SeleniumControl( sDriver, "PartSchedule_ManufacturingOrderSupplyLink", "ID", "lnk_5216_MRMDTPT_ZMRMDTPTWRK_CTW");
				Function.WaitControlDisplayed(MRMDTPT_PartSchedule_ManufacturingOrderSupplyLink);
MRMDTPT_PartSchedule_ManufacturingOrderSupplyLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing VerifyExists on ManufacturingOrderSupplyForm...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_ManufacturingOrderSupplyForm = new SeleniumControl( sDriver, "ManufacturingOrderSupplyForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MRM_MOHDR_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,MRMDTPT_ManufacturingOrderSupplyForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing VerifyExists on ManufacturingOrderSupply_MO...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_ManufacturingOrderSupply_MO = new SeleniumControl( sDriver, "ManufacturingOrderSupply_MO", "xpath", "//div[translate(@id,'0123456789','')='pr__MRM_MOHDR_CTW_']/ancestor::form[1]/descendant::*[@id='MO_ID']");
				Function.AssertEqual(true,MRMDTPT_ManufacturingOrderSupply_MO.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing VerifyExist on MoRequirementsFormTable...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_MoRequirementsFormTable = new SeleniumControl( sDriver, "MoRequirementsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__MRM_MORQMT_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,MRMDTPT_MoRequirementsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing VerifyExists on MoRequirementsForm...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_MoRequirementsForm = new SeleniumControl( sDriver, "MoRequirementsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MRM_MORQMT_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,MRMDTPT_MoRequirementsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing ClickButton on MoRequirementsForm...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_MoRequirementsForm = new SeleniumControl( sDriver, "MoRequirementsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MRM_MORQMT_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MRMDTPT_MoRequirementsForm);
IWebElement formBttn = MRMDTPT_MoRequirementsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? MRMDTPT_MoRequirementsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
MRMDTPT_MoRequirementsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing VerifyExists on MoRequirements_ComponentPart...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_MoRequirements_ComponentPart = new SeleniumControl( sDriver, "MoRequirements_ComponentPart", "xpath", "//div[translate(@id,'0123456789','')='pr__MRM_MORQMT_CTW_']/ancestor::form[1]/descendant::*[@id='COMP_PART_ID']");
				Function.AssertEqual(true,MRMDTPT_MoRequirements_ComponentPart.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing Select on MoRequirements_TabMenu...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_MoRequirements_TabMenu = new SeleniumControl( sDriver, "MoRequirements_TabMenu", "xpath", "//div[translate(@id,'0123456789','')='pr__MRM_MORQMT_CTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(MRMDTPT_MoRequirements_TabMenu);
IWebElement mTab = MRMDTPT_MoRequirements_TabMenu.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Details").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing VerifyExists on Details_ComponentType...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_Details_ComponentType = new SeleniumControl( sDriver, "Details_ComponentType", "xpath", "//div[translate(@id,'0123456789','')='pr__MRM_MORQMT_CTW_']/ancestor::form[1]/descendant::*[@id='S_COMP_TYP_CD']");
				Function.AssertEqual(true,MRMDTPT_Details_ComponentType.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing VerifyExists on MoRequirements_InventoryLink...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_MoRequirements_InventoryLink = new SeleniumControl( sDriver, "MoRequirements_InventoryLink", "ID", "lnk_5399_MRM_MORQMT_CTW");
				Function.AssertEqual(true,MRMDTPT_MoRequirements_InventoryLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing VerifyExists on MoRequirements_ManufacturingOrdersLink...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_MoRequirements_ManufacturingOrdersLink = new SeleniumControl( sDriver, "MoRequirements_ManufacturingOrdersLink", "ID", "lnk_5403_MRM_MORQMT_CTW");
				Function.AssertEqual(true,MRMDTPT_MoRequirements_ManufacturingOrdersLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing VerifyExists on MoRequirements_PurchaseOrdersLink...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_MoRequirements_PurchaseOrdersLink = new SeleniumControl( sDriver, "MoRequirements_PurchaseOrdersLink", "ID", "lnk_5405_MRM_MORQMT_CTW");
				Function.AssertEqual(true,MRMDTPT_MoRequirements_PurchaseOrdersLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing VerifyExists on MoRequirements_RequisitionsLink...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_MoRequirements_RequisitionsLink = new SeleniumControl( sDriver, "MoRequirements_RequisitionsLink", "ID", "lnk_5401_MRM_MORQMT_CTW");
				Function.AssertEqual(true,MRMDTPT_MoRequirements_RequisitionsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing Close on ManufacturingOrderSupplyForm...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_ManufacturingOrderSupplyForm = new SeleniumControl( sDriver, "ManufacturingOrderSupplyForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MRM_MOHDR_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MRMDTPT_ManufacturingOrderSupplyForm);
IWebElement formBttn = MRMDTPT_ManufacturingOrderSupplyForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("RESERVATIONSUPPLY");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing Click on PartSchedule_ReservationSupplyLink...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_PartSchedule_ReservationSupplyLink = new SeleniumControl( sDriver, "PartSchedule_ReservationSupplyLink", "ID", "lnk_5218_MRMDTPT_ZMRMDTPTWRK_CTW");
				Function.WaitControlDisplayed(MRMDTPT_PartSchedule_ReservationSupplyLink);
MRMDTPT_PartSchedule_ReservationSupplyLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing VerifyExists on ReservationSupplyForm...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_ReservationSupplyForm = new SeleniumControl( sDriver, "ReservationSupplyForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MRM_RESHDR_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,MRMDTPT_ReservationSupplyForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing VerifyExists on ReservationSuppy_Reservation...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_ReservationSuppy_Reservation = new SeleniumControl( sDriver, "ReservationSuppy_Reservation", "xpath", "//div[translate(@id,'0123456789','')='pr__MRM_RESHDR_CTW_']/ancestor::form[1]/descendant::*[@id='RES_ID']");
				Function.AssertEqual(true,MRMDTPT_ReservationSuppy_Reservation.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing Close on ReservationSupplyForm...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_ReservationSupplyForm = new SeleniumControl( sDriver, "ReservationSupplyForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MRM_RESHDR_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MRMDTPT_ReservationSupplyForm);
IWebElement formBttn = MRMDTPT_ReservationSupplyForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("PLANNEDORDERDEMAND");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing Click on PartSchedule_PlannedOrderDemandLink...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_PartSchedule_PlannedOrderDemandLink = new SeleniumControl( sDriver, "PartSchedule_PlannedOrderDemandLink", "ID", "lnk_5222_MRMDTPT_ZMRMDTPTWRK_CTW");
				Function.WaitControlDisplayed(MRMDTPT_PartSchedule_PlannedOrderDemandLink);
MRMDTPT_PartSchedule_PlannedOrderDemandLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing VerifyExists on PlannedOrderDemandForm...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_PlannedOrderDemandForm = new SeleniumControl( sDriver, "PlannedOrderDemandForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MRM_ZMRQSPAWRKPART_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,MRMDTPT_PlannedOrderDemandForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing VerifyExists on PlannedOrderDemand_AssemblyPart...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_PlannedOrderDemand_AssemblyPart = new SeleniumControl( sDriver, "PlannedOrderDemand_AssemblyPart", "xpath", "//div[translate(@id,'0123456789','')='pr__MRM_ZMRQSPAWRKPART_CTW_']/ancestor::form[1]/descendant::*[@id='ASY_PART_ID']");
				Function.AssertEqual(true,MRMDTPT_PlannedOrderDemand_AssemblyPart.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing Close on PlannedOrderDemandForm...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_PlannedOrderDemandForm = new SeleniumControl( sDriver, "PlannedOrderDemandForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MRM_ZMRQSPAWRKPART_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MRMDTPT_PlannedOrderDemandForm);
IWebElement formBttn = MRMDTPT_PlannedOrderDemandForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("RESERVATIONDEMAND");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing Click on PartSchedule_ReservationDemandLink...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_PartSchedule_ReservationDemandLink = new SeleniumControl( sDriver, "PartSchedule_ReservationDemandLink", "ID", "lnk_5219_MRMDTPT_ZMRMDTPTWRK_CTW");
				Function.WaitControlDisplayed(MRMDTPT_PartSchedule_ReservationDemandLink);
MRMDTPT_PartSchedule_ReservationDemandLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing VerifyExists on ReservationDemandForm...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_ReservationDemandForm = new SeleniumControl( sDriver, "ReservationDemandForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MRM_RESLN_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,MRMDTPT_ReservationDemandForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing VerifyExists on ReservationDemand_Reservation...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_ReservationDemand_Reservation = new SeleniumControl( sDriver, "ReservationDemand_Reservation", "xpath", "//div[translate(@id,'0123456789','')='pr__MRM_RESLN_CTW_']/ancestor::form[1]/descendant::*[@id='RES_ID']");
				Function.AssertEqual(true,MRMDTPT_ReservationDemand_Reservation.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing Close on ReservationDemandForm...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_ReservationDemandForm = new SeleniumControl( sDriver, "ReservationDemandForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MRM_RESLN_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MRMDTPT_ReservationDemandForm);
IWebElement formBttn = MRMDTPT_ReservationDemandForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("MANUFACTURINGORDERDEMAND");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing Click on PartSchedule_ManufacturingOrderDemandLink...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_PartSchedule_ManufacturingOrderDemandLink = new SeleniumControl( sDriver, "PartSchedule_ManufacturingOrderDemandLink", "ID", "lnk_5286_MRMDTPT_ZMRMDTPTWRK_CTW");
				Function.WaitControlDisplayed(MRMDTPT_PartSchedule_ManufacturingOrderDemandLink);
MRMDTPT_PartSchedule_ManufacturingOrderDemandLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing VerifyExists on ManufacturingOrderDemandForm...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_ManufacturingOrderDemandForm = new SeleniumControl( sDriver, "ManufacturingOrderDemandForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MRM_MOHDRITEM_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,MRMDTPT_ManufacturingOrderDemandForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing VerifyExists on ManufacturingOrderDemand_ManufacturingOrder...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_ManufacturingOrderDemand_ManufacturingOrder = new SeleniumControl( sDriver, "ManufacturingOrderDemand_ManufacturingOrder", "xpath", "//div[translate(@id,'0123456789','')='pr__MRM_MOHDRITEM_CTW_']/ancestor::form[1]/descendant::*[@id='MO_ID']");
				Function.AssertEqual(true,MRMDTPT_ManufacturingOrderDemand_ManufacturingOrder.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing Close on ManufacturingOrderDemandForm...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_ManufacturingOrderDemandForm = new SeleniumControl( sDriver, "ManufacturingOrderDemandForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MRM_MOHDRITEM_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MRMDTPT_ManufacturingOrderDemandForm);
IWebElement formBttn = MRMDTPT_ManufacturingOrderDemandForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("SALESORDERDEMAND");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing Click on PartSchedule_SalesOrderDemandLink...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_PartSchedule_SalesOrderDemandLink = new SeleniumControl( sDriver, "PartSchedule_SalesOrderDemandLink", "ID", "lnk_5221_MRMDTPT_ZMRMDTPTWRK_CTW");
				Function.WaitControlDisplayed(MRMDTPT_PartSchedule_SalesOrderDemandLink);
MRMDTPT_PartSchedule_SalesOrderDemandLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing VerifyExists on SalesOrderDemandForm...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_SalesOrderDemandForm = new SeleniumControl( sDriver, "SalesOrderDemandForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MRM_SOLN_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,MRMDTPT_SalesOrderDemandForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing VerifyExists on SalesOrderDemand_SalesOrder...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_SalesOrderDemand_SalesOrder = new SeleniumControl( sDriver, "SalesOrderDemand_SalesOrder", "xpath", "//div[translate(@id,'0123456789','')='pr__MRM_SOLN_CTW_']/ancestor::form[1]/descendant::*[@id='SO_ID']");
				Function.AssertEqual(true,MRMDTPT_SalesOrderDemand_SalesOrder.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing Close on SalesOrderDemandForm...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_SalesOrderDemandForm = new SeleniumControl( sDriver, "SalesOrderDemandForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MRM_SOLN_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MRMDTPT_SalesOrderDemandForm);
IWebElement formBttn = MRMDTPT_SalesOrderDemandForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("FORECASTDEMAND");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing Click on PartSchedule_ForecastDemandLink...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_PartSchedule_ForecastDemandLink = new SeleniumControl( sDriver, "PartSchedule_ForecastDemandLink", "ID", "lnk_5223_MRMDTPT_ZMRMDTPTWRK_CTW");
				Function.WaitControlDisplayed(MRMDTPT_PartSchedule_ForecastDemandLink);
MRMDTPT_PartSchedule_ForecastDemandLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing VerifyExists on ForecastDemandForm...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_ForecastDemandForm = new SeleniumControl( sDriver, "ForecastDemandForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MRMDTPT_MPSFORECASTRQMT_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,MRMDTPT_ForecastDemandForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing VerifyExists on ForecastDemand_NeedDate...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_ForecastDemand_NeedDate = new SeleniumControl( sDriver, "ForecastDemand_NeedDate", "xpath", "//div[translate(@id,'0123456789','')='pr__MRMDTPT_MPSFORECASTRQMT_CTW_']/ancestor::form[1]/descendant::*[@id='MPS_DT']");
				Function.AssertEqual(true,MRMDTPT_ForecastDemand_NeedDate.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing Close on ForecastDemandForm...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_ForecastDemandForm = new SeleniumControl( sDriver, "ForecastDemandForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MRMDTPT_MPSFORECASTRQMT_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MRMDTPT_ForecastDemandForm);
IWebElement formBttn = MRMDTPT_ForecastDemandForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMDTPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMDTPT] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl MRMDTPT_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(MRMDTPT_MainForm);
IWebElement formBttn = MRMDTPT_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

