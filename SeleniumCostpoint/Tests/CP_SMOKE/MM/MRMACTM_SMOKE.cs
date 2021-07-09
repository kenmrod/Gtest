 
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
    public class MRMACTM_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Manage MRP Action Messages", "xpath","//div[@class='navItem'][.='Manage MRP Action Messages']").Click();


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
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,MRMACTM_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing Select on InventoryProjectSelection_ProjectOption...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_InventoryProjectSelection_ProjectOption = new SeleniumControl( sDriver, "InventoryProjectSelection_ProjectOption", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PROJ_OPTION']");
				Function.WaitControlDisplayed(MRMACTM_InventoryProjectSelection_ProjectOption);
MRMACTM_InventoryProjectSelection_ProjectOption.ScrollIntoViewUsingJavaScript();
MRMACTM_InventoryProjectSelection_ProjectOption.Click();
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
								try {
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing VerifyExists on MPSPlan...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_MPSPlan = new SeleniumControl( sDriver, "MPSPlan", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='MPS_PLAN_CD']");
				Function.AssertEqual(true,MRMACTM_MPSPlan.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing VerifyExist on ActionMessagesFormTable...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessagesFormTable = new SeleniumControl( sDriver, "ActionMessagesFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__MRMACTM_ZMRMACTMWRK_MSGCTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,MRMACTM_ActionMessagesFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing ClickButton on ActionMessagesForm...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessagesForm = new SeleniumControl( sDriver, "ActionMessagesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MRMACTM_ZMRMACTMWRK_MSGCTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MRMACTM_ActionMessagesForm);
IWebElement formBttn = MRMACTM_ActionMessagesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? MRMACTM_ActionMessagesForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
MRMACTM_ActionMessagesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing VerifyExists on ActionMessagesForm...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessagesForm = new SeleniumControl( sDriver, "ActionMessagesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MRMACTM_ZMRMACTMWRK_MSGCTW_']/ancestor::form[1]");
				Function.AssertEqual(true,MRMACTM_ActionMessagesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing VerifyExists on ActionMessages_MessageType...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_MessageType = new SeleniumControl( sDriver, "ActionMessages_MessageType", "xpath", "//div[translate(@id,'0123456789','')='pr__MRMACTM_ZMRMACTMWRK_MSGCTW_']/ancestor::form[1]/descendant::*[@id='S_MRP_MSG_TYPE_CD']");
				Function.AssertEqual(true,MRMACTM_ActionMessages_MessageType.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing Select on ActionMessages_ActionMessagesTab...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_ActionMessagesTab = new SeleniumControl( sDriver, "ActionMessages_ActionMessagesTab", "xpath", "//div[translate(@id,'0123456789','')='pr__MRMACTM_ZMRMACTMWRK_MSGCTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(MRMACTM_ActionMessages_ActionMessagesTab);
IWebElement mTab = MRMACTM_ActionMessages_ActionMessagesTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Message Details").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing VerifyExists on ActionMessages_MessageDetails_Order_SupplyType...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_MessageDetails_Order_SupplyType = new SeleniumControl( sDriver, "ActionMessages_MessageDetails_Order_SupplyType", "xpath", "//div[translate(@id,'0123456789','')='pr__MRMACTM_ZMRMACTMWRK_MSGCTW_']/ancestor::form[1]/descendant::*[@id='S_RECPT_TYPE_CD']");
				Function.AssertEqual(true,MRMACTM_ActionMessages_MessageDetails_Order_SupplyType.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing Select on ActionMessages_ActionMessagesTab...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_ActionMessagesTab = new SeleniumControl( sDriver, "ActionMessages_ActionMessagesTab", "xpath", "//div[translate(@id,'0123456789','')='pr__MRMACTM_ZMRMACTMWRK_MSGCTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(MRMACTM_ActionMessages_ActionMessagesTab);
IWebElement mTab = MRMACTM_ActionMessages_ActionMessagesTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Other Info").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing VerifyExists on ActionMessages_OtherInfo_PartDetails_UM...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_OtherInfo_PartDetails_UM = new SeleniumControl( sDriver, "ActionMessages_OtherInfo_PartDetails_UM", "xpath", "//div[translate(@id,'0123456789','')='pr__MRMACTM_ZMRMACTMWRK_MSGCTW_']/ancestor::form[1]/descendant::*[@id='DFLT_UM_CD']");
				Function.AssertEqual(true,MRMACTM_ActionMessages_OtherInfo_PartDetails_UM.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
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
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing VerifyExists on ActionMessages_PartDetailLink...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_PartDetailLink = new SeleniumControl( sDriver, "ActionMessages_PartDetailLink", "ID", "lnk_4717_MRMACTM_ZMRMACTMWRK_MSGCTW");
				Function.AssertEqual(true,MRMACTM_ActionMessages_PartDetailLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing Click on ActionMessages_PartDetailLink...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_PartDetailLink = new SeleniumControl( sDriver, "ActionMessages_PartDetailLink", "ID", "lnk_4717_MRMACTM_ZMRMACTMWRK_MSGCTW");
				Function.WaitControlDisplayed(MRMACTM_ActionMessages_PartDetailLink);
MRMACTM_ActionMessages_PartDetailLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing VerifyExist on ActionMessages_PartDetail_PartProjectInformationFormTable...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_PartDetail_PartProjectInformationFormTable = new SeleniumControl( sDriver, "ActionMessages_PartDetail_PartProjectInformationFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_PARTPROJ_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,MRMACTM_ActionMessages_PartDetail_PartProjectInformationFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing VerifyExists on ActionMessages_PartDetailForm...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_PartDetailForm = new SeleniumControl( sDriver, "ActionMessages_PartDetailForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_PARTPROJ_HDR_']/ancestor::form[1]");
				Function.AssertEqual(true,MRMACTM_ActionMessages_PartDetailForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing VerifyExists on ActionMessages_PartDetail_PartPlanningDetail_PlanningType...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_PartDetail_PartPlanningDetail_PlanningType = new SeleniumControl( sDriver, "ActionMessages_PartDetail_PartPlanningDetail_PlanningType", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_PARTPROJ_HDR_']/ancestor::form[1]/descendant::*[@id='S_PLAN_DESC']");
				Function.AssertEqual(true,MRMACTM_ActionMessages_PartDetail_PartPlanningDetail_PlanningType.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing ClickButton on ActionMessages_PartDetail_PartProjectInformationForm...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_PartDetail_PartProjectInformationForm = new SeleniumControl( sDriver, "ActionMessages_PartDetail_PartProjectInformationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_PARTPROJ_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MRMACTM_ActionMessages_PartDetail_PartProjectInformationForm);
IWebElement formBttn = MRMACTM_ActionMessages_PartDetail_PartProjectInformationForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? MRMACTM_ActionMessages_PartDetail_PartProjectInformationForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
MRMACTM_ActionMessages_PartDetail_PartProjectInformationForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing VerifyExists on ActionMessages_PartDetail_PartProjectInformationForm...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_PartDetail_PartProjectInformationForm = new SeleniumControl( sDriver, "ActionMessages_PartDetail_PartProjectInformationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_PARTPROJ_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,MRMACTM_ActionMessages_PartDetail_PartProjectInformationForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing VerifyExists on ActionMessages_PartDetail_PartProjectInformation_Project...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_PartDetail_PartProjectInformation_Project = new SeleniumControl( sDriver, "ActionMessages_PartDetail_PartProjectInformation_Project", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_PARTPROJ_CTW_']/ancestor::form[1]/descendant::*[@id='PROJ_ID']");
				Function.AssertEqual(true,MRMACTM_ActionMessages_PartDetail_PartProjectInformation_Project.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing Close on ActionMessages_PartDetailForm...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_PartDetailForm = new SeleniumControl( sDriver, "ActionMessages_PartDetailForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_PARTPROJ_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MRMACTM_ActionMessages_PartDetailForm);
IWebElement formBttn = MRMACTM_ActionMessages_PartDetailForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
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
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing VerifyExists on ActionMessages_ProjectsLink...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_ProjectsLink = new SeleniumControl( sDriver, "ActionMessages_ProjectsLink", "ID", "lnk_4804_MRMACTM_ZMRMACTMWRK_MSGCTW");
				Function.AssertEqual(true,MRMACTM_ActionMessages_ProjectsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing Click on ActionMessages_ProjectsLink...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_ProjectsLink = new SeleniumControl( sDriver, "ActionMessages_ProjectsLink", "ID", "lnk_4804_MRMACTM_ZMRMACTMWRK_MSGCTW");
				Function.WaitControlDisplayed(MRMACTM_ActionMessages_ProjectsLink);
MRMACTM_ActionMessages_ProjectsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing VerifyExists on ActionMessages_ProjectsForm...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_ProjectsForm = new SeleniumControl( sDriver, "ActionMessages_ProjectsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_INVTPROJ_HDR_']/ancestor::form[1]");
				Function.AssertEqual(true,MRMACTM_ActionMessages_ProjectsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing VerifyExists on ActionMessages_Projects_SelectionCriteria_Option...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_Projects_SelectionCriteria_Option = new SeleniumControl( sDriver, "ActionMessages_Projects_SelectionCriteria_Option", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_INVTPROJ_HDR_']/ancestor::form[1]/descendant::*[@id='PROJ_OPTION']");
				Function.AssertEqual(true,MRMACTM_ActionMessages_Projects_SelectionCriteria_Option.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing VerifyExist on ActionMessages_Projects_InventoryAbbrevationsFormTable...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_Projects_InventoryAbbrevationsFormTable = new SeleniumControl( sDriver, "ActionMessages_Projects_InventoryAbbrevationsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_INVTPROJ_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,MRMACTM_ActionMessages_Projects_InventoryAbbrevationsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing ClickButton on ActionMessages_Projects_InventoryAbbrevationsForm...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_Projects_InventoryAbbrevationsForm = new SeleniumControl( sDriver, "ActionMessages_Projects_InventoryAbbrevationsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_INVTPROJ_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MRMACTM_ActionMessages_Projects_InventoryAbbrevationsForm);
IWebElement formBttn = MRMACTM_ActionMessages_Projects_InventoryAbbrevationsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? MRMACTM_ActionMessages_Projects_InventoryAbbrevationsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
MRMACTM_ActionMessages_Projects_InventoryAbbrevationsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing VerifyExists on ActionMessages_Projects_InventoryAbbrevationsForm...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_Projects_InventoryAbbrevationsForm = new SeleniumControl( sDriver, "ActionMessages_Projects_InventoryAbbrevationsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_INVTPROJ_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,MRMACTM_ActionMessages_Projects_InventoryAbbrevationsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing VerifyExists on ActionMessages_Projects_InventoryAbbrevations_InventoryAbbreviation...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_Projects_InventoryAbbrevations_InventoryAbbreviation = new SeleniumControl( sDriver, "ActionMessages_Projects_InventoryAbbrevations_InventoryAbbreviation", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_INVTPROJ_CTW_']/ancestor::form[1]/descendant::*[@id='INVT_ABBRV_CD']");
				Function.AssertEqual(true,MRMACTM_ActionMessages_Projects_InventoryAbbrevations_InventoryAbbreviation.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing Close on ActionMessages_ProjectsForm...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_ProjectsForm = new SeleniumControl( sDriver, "ActionMessages_ProjectsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_INVTPROJ_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MRMACTM_ActionMessages_ProjectsForm);
IWebElement formBttn = MRMACTM_ActionMessages_ProjectsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing VerifyExists on ActionMessages_WarehouseInventoryLink...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_WarehouseInventoryLink = new SeleniumControl( sDriver, "ActionMessages_WarehouseInventoryLink", "ID", "lnk_4659_MRMACTM_ZMRMACTMWRK_MSGCTW");
				Function.AssertEqual(true,MRMACTM_ActionMessages_WarehouseInventoryLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing Click on ActionMessages_WarehouseInventoryLink...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_WarehouseInventoryLink = new SeleniumControl( sDriver, "ActionMessages_WarehouseInventoryLink", "ID", "lnk_4659_MRMACTM_ZMRMACTMWRK_MSGCTW");
				Function.WaitControlDisplayed(MRMACTM_ActionMessages_WarehouseInventoryLink);
MRMACTM_ActionMessages_WarehouseInventoryLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing VerifyExists on ActionMessages_WarehouseInventoryForm...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_WarehouseInventoryForm = new SeleniumControl( sDriver, "ActionMessages_WarehouseInventoryForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_INVTWHSELOC_HDR_']/ancestor::form[1]");
				Function.AssertEqual(true,MRMACTM_ActionMessages_WarehouseInventoryForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing VerifyExists on ActionMessages_WarehouseInventory_SelectionCriteria_Option...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_WarehouseInventory_SelectionCriteria_Option = new SeleniumControl( sDriver, "ActionMessages_WarehouseInventory_SelectionCriteria_Option", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_INVTWHSELOC_HDR_']/ancestor::form[1]/descendant::*[@id='PROJ_OPTION']");
				Function.AssertEqual(true,MRMACTM_ActionMessages_WarehouseInventory_SelectionCriteria_Option.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing VerifyExist on ActionMessages_WarehouseInventory_WarehouseInventoryDetailFormTable...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_WarehouseInventory_WarehouseInventoryDetailFormTable = new SeleniumControl( sDriver, "ActionMessages_WarehouseInventory_WarehouseInventoryDetailFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_INVTWHSELOC_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,MRMACTM_ActionMessages_WarehouseInventory_WarehouseInventoryDetailFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing ClickButton on ActionMessages_WarehouseInventory_WarehouseInventoryDetailForm...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_WarehouseInventory_WarehouseInventoryDetailForm = new SeleniumControl( sDriver, "ActionMessages_WarehouseInventory_WarehouseInventoryDetailForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_INVTWHSELOC_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MRMACTM_ActionMessages_WarehouseInventory_WarehouseInventoryDetailForm);
IWebElement formBttn = MRMACTM_ActionMessages_WarehouseInventory_WarehouseInventoryDetailForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? MRMACTM_ActionMessages_WarehouseInventory_WarehouseInventoryDetailForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
MRMACTM_ActionMessages_WarehouseInventory_WarehouseInventoryDetailForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing VerifyExists on ActionMessages_WarehouseInventory_WarehouseInventoryDetailForm...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_WarehouseInventory_WarehouseInventoryDetailForm = new SeleniumControl( sDriver, "ActionMessages_WarehouseInventory_WarehouseInventoryDetailForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_INVTWHSELOC_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,MRMACTM_ActionMessages_WarehouseInventory_WarehouseInventoryDetailForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing Close on ActionMessages_WarehouseInventoryForm...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_WarehouseInventoryForm = new SeleniumControl( sDriver, "ActionMessages_WarehouseInventoryForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_INVTWHSELOC_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MRMACTM_ActionMessages_WarehouseInventoryForm);
IWebElement formBttn = MRMACTM_ActionMessages_WarehouseInventoryForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
								try {
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing VerifyExists on ActionMessages_InventoryDetailsLink...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_InventoryDetailsLink = new SeleniumControl( sDriver, "ActionMessages_InventoryDetailsLink", "ID", "lnk_4655_MRMACTM_ZMRMACTMWRK_MSGCTW");
				Function.AssertEqual(true,MRMACTM_ActionMessages_InventoryDetailsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing Click on ActionMessages_InventoryDetailsLink...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_InventoryDetailsLink = new SeleniumControl( sDriver, "ActionMessages_InventoryDetailsLink", "ID", "lnk_4655_MRMACTM_ZMRMACTMWRK_MSGCTW");
				Function.WaitControlDisplayed(MRMACTM_ActionMessages_InventoryDetailsLink);
MRMACTM_ActionMessages_InventoryDetailsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing VerifyExists on ActionMessages_InventoryDetailsForm...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_InventoryDetailsForm = new SeleniumControl( sDriver, "ActionMessages_InventoryDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_INVT_HDR_']/ancestor::form[1]");
				Function.AssertEqual(true,MRMACTM_ActionMessages_InventoryDetailsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing VerifyExists on ActionMessages_InventoryDetails_SelectionCriteria_Option...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_InventoryDetails_SelectionCriteria_Option = new SeleniumControl( sDriver, "ActionMessages_InventoryDetails_SelectionCriteria_Option", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_INVT_HDR_']/ancestor::form[1]/descendant::*[@id='PROJ_OPTION']");
				Function.AssertEqual(true,MRMACTM_ActionMessages_InventoryDetails_SelectionCriteria_Option.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing VerifyExist on ActionMessages_InventoryDetails_InventoryQuantitiesFormTable...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_InventoryDetails_InventoryQuantitiesFormTable = new SeleniumControl( sDriver, "ActionMessages_InventoryDetails_InventoryQuantitiesFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_INVT_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,MRMACTM_ActionMessages_InventoryDetails_InventoryQuantitiesFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing ClickButton on ActionMessages_InventoryDetails_InventoryQuantitiesForm...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_InventoryDetails_InventoryQuantitiesForm = new SeleniumControl( sDriver, "ActionMessages_InventoryDetails_InventoryQuantitiesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_INVT_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MRMACTM_ActionMessages_InventoryDetails_InventoryQuantitiesForm);
IWebElement formBttn = MRMACTM_ActionMessages_InventoryDetails_InventoryQuantitiesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? MRMACTM_ActionMessages_InventoryDetails_InventoryQuantitiesForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
MRMACTM_ActionMessages_InventoryDetails_InventoryQuantitiesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing VerifyExists on ActionMessages_InventoryDetails_InventoryQuantitiesForm...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_InventoryDetails_InventoryQuantitiesForm = new SeleniumControl( sDriver, "ActionMessages_InventoryDetails_InventoryQuantitiesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_INVT_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,MRMACTM_ActionMessages_InventoryDetails_InventoryQuantitiesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing VerifyExists on ActionMessages_InventoryDetails_InventoryQuantities_InventoryAbbrev...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_InventoryDetails_InventoryQuantities_InventoryAbbrev = new SeleniumControl( sDriver, "ActionMessages_InventoryDetails_InventoryQuantities_InventoryAbbrev", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_INVT_CTW_']/ancestor::form[1]/descendant::*[@id='INVT_ABBRV_CD']");
				Function.AssertEqual(true,MRMACTM_ActionMessages_InventoryDetails_InventoryQuantities_InventoryAbbrev.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing Select on ActionMessages_InventoryDetails_InventoryQuantities_InventoryQuantitiesTab...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_InventoryDetails_InventoryQuantities_InventoryQuantitiesTab = new SeleniumControl( sDriver, "ActionMessages_InventoryDetails_InventoryQuantities_InventoryQuantitiesTab", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_INVT_CTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(MRMACTM_ActionMessages_InventoryDetails_InventoryQuantities_InventoryQuantitiesTab);
IWebElement mTab = MRMACTM_ActionMessages_InventoryDetails_InventoryQuantities_InventoryQuantitiesTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Quantities").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing VerifyExists on ActionMessages_InventoryDetails_InventoryQuantities_Quantities_Quantities_NetAvailable...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_InventoryDetails_InventoryQuantities_Quantities_Quantities_NetAvailable = new SeleniumControl( sDriver, "ActionMessages_InventoryDetails_InventoryQuantities_Quantities_Quantities_NetAvailable", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_INVT_CTW_']/ancestor::form[1]/descendant::*[@id='NET_AVAIL_QTY']");
				Function.AssertEqual(true,MRMACTM_ActionMessages_InventoryDetails_InventoryQuantities_Quantities_Quantities_NetAvailable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing Close on ActionMessages_InventoryDetailsForm...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_InventoryDetailsForm = new SeleniumControl( sDriver, "ActionMessages_InventoryDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_INVT_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MRMACTM_ActionMessages_InventoryDetailsForm);
IWebElement formBttn = MRMACTM_ActionMessages_InventoryDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Orders");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing VerifyExists on ActionMessages_OrdersLink...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_OrdersLink = new SeleniumControl( sDriver, "ActionMessages_OrdersLink", "ID", "lnk_4627_MRMACTM_ZMRMACTMWRK_MSGCTW");
				Function.AssertEqual(true,MRMACTM_ActionMessages_OrdersLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing Click on ActionMessages_OrdersLink...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_OrdersLink = new SeleniumControl( sDriver, "ActionMessages_OrdersLink", "ID", "lnk_4627_MRMACTM_ZMRMACTMWRK_MSGCTW");
				Function.WaitControlDisplayed(MRMACTM_ActionMessages_OrdersLink);
MRMACTM_ActionMessages_OrdersLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing VerifyExists on ActionMessages_OrdersForm...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_OrdersForm = new SeleniumControl( sDriver, "ActionMessages_OrdersForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMSSUB_ZMRMACTMORDER_HDR_']/ancestor::form[1]");
				Function.AssertEqual(true,MRMACTM_ActionMessages_OrdersForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing VerifyExists on ActionMessages_Orders_InvAbbrev...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_Orders_InvAbbrev = new SeleniumControl( sDriver, "ActionMessages_Orders_InvAbbrev", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMSSUB_ZMRMACTMORDER_HDR_']/ancestor::form[1]/descendant::*[@id='INVT_ABBRV_CD']");
				Function.AssertEqual(true,MRMACTM_ActionMessages_Orders_InvAbbrev.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing VerifyExist on ActionMessages_Orders_OrderDetailsFormTable...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_Orders_OrderDetailsFormTable = new SeleniumControl( sDriver, "ActionMessages_Orders_OrderDetailsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMSSUB_ZMRMACTMORDER_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,MRMACTM_ActionMessages_Orders_OrderDetailsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing ClickButton on ActionMessages_Orders_OrderDetailsForm...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_Orders_OrderDetailsForm = new SeleniumControl( sDriver, "ActionMessages_Orders_OrderDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMSSUB_ZMRMACTMORDER_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MRMACTM_ActionMessages_Orders_OrderDetailsForm);
IWebElement formBttn = MRMACTM_ActionMessages_Orders_OrderDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? MRMACTM_ActionMessages_Orders_OrderDetailsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
MRMACTM_ActionMessages_Orders_OrderDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing VerifyExists on ActionMessages_Orders_OrderDetailsForm...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_Orders_OrderDetailsForm = new SeleniumControl( sDriver, "ActionMessages_Orders_OrderDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMSSUB_ZMRMACTMORDER_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,MRMACTM_ActionMessages_Orders_OrderDetailsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing VerifyExists on ActionMessages_Orders_OrderDetails_OrderType...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_Orders_OrderDetails_OrderType = new SeleniumControl( sDriver, "ActionMessages_Orders_OrderDetails_OrderType", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMSSUB_ZMRMACTMORDER_CTW_']/ancestor::form[1]/descendant::*[@id='ORD_TYPE_DESC']");
				Function.AssertEqual(true,MRMACTM_ActionMessages_Orders_OrderDetails_OrderType.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing Close on ActionMessages_OrdersForm...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_OrdersForm = new SeleniumControl( sDriver, "ActionMessages_OrdersForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMSSUB_ZMRMACTMORDER_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MRMACTM_ActionMessages_OrdersForm);
IWebElement formBttn = MRMACTM_ActionMessages_OrdersForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
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
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing VerifyExists on ActionMessages_POLink...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_POLink = new SeleniumControl( sDriver, "ActionMessages_POLink", "ID", "lnk_4632_MRMACTM_ZMRMACTMWRK_MSGCTW");
				Function.AssertEqual(true,MRMACTM_ActionMessages_POLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing Click on ActionMessages_POLink...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_POLink = new SeleniumControl( sDriver, "ActionMessages_POLink", "ID", "lnk_4632_MRMACTM_ZMRMACTMWRK_MSGCTW");
				Function.WaitControlDisplayed(MRMACTM_ActionMessages_POLink);
MRMACTM_ActionMessages_POLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing VerifyExists on ActionMessages_POForm...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_POForm = new SeleniumControl( sDriver, "ActionMessages_POForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMSSUB_POHDR_MSGDTL_']/ancestor::form[1]");
				Function.AssertEqual(true,MRMACTM_ActionMessages_POForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing VerifyExists on ActionMessages_PO_Message...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_PO_Message = new SeleniumControl( sDriver, "ActionMessages_PO_Message", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMSSUB_POHDR_MSGDTL_']/ancestor::form[1]/descendant::*[@id='S_MRP_MSG_TYPE_CD_DESC']");
				Function.AssertEqual(true,MRMACTM_ActionMessages_PO_Message.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing Close on ActionMessages_POForm...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_POForm = new SeleniumControl( sDriver, "ActionMessages_POForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMSSUB_POHDR_MSGDTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MRMACTM_ActionMessages_POForm);
IWebElement formBttn = MRMACTM_ActionMessages_POForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
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
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing VerifyExists on ActionMessages_MOLink...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_MOLink = new SeleniumControl( sDriver, "ActionMessages_MOLink", "ID", "lnk_4631_MRMACTM_ZMRMACTMWRK_MSGCTW");
				Function.AssertEqual(true,MRMACTM_ActionMessages_MOLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing Click on ActionMessages_MOLink...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_MOLink = new SeleniumControl( sDriver, "ActionMessages_MOLink", "ID", "lnk_4631_MRMACTM_ZMRMACTMWRK_MSGCTW");
				Function.WaitControlDisplayed(MRMACTM_ActionMessages_MOLink);
MRMACTM_ActionMessages_MOLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing VerifyExists on ActionMessages_MOForm...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_MOForm = new SeleniumControl( sDriver, "ActionMessages_MOForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMSSUB_MOHDR_MSGDTL_']/ancestor::form[1]");
				Function.AssertEqual(true,MRMACTM_ActionMessages_MOForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing VerifyExists on ActionMessages_MO_Message...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_MO_Message = new SeleniumControl( sDriver, "ActionMessages_MO_Message", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMSSUB_MOHDR_MSGDTL_']/ancestor::form[1]/descendant::*[@id='S_MRP_MSG_TYPE_CD_DESC']");
				Function.AssertEqual(true,MRMACTM_ActionMessages_MO_Message.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing Close on ActionMessages_MOForm...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_MOForm = new SeleniumControl( sDriver, "ActionMessages_MOForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMSSUB_MOHDR_MSGDTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MRMACTM_ActionMessages_MOForm);
IWebElement formBttn = MRMACTM_ActionMessages_MOForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Planned Order");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing VerifyExists on ActionMessages_PlannedOrderLink...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_PlannedOrderLink = new SeleniumControl( sDriver, "ActionMessages_PlannedOrderLink", "ID", "lnk_4636_MRMACTM_ZMRMACTMWRK_MSGCTW");
				Function.AssertEqual(true,MRMACTM_ActionMessages_PlannedOrderLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing Click on ActionMessages_PlannedOrderLink...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_PlannedOrderLink = new SeleniumControl( sDriver, "ActionMessages_PlannedOrderLink", "ID", "lnk_4636_MRMACTM_ZMRMACTMWRK_MSGCTW");
				Function.WaitControlDisplayed(MRMACTM_ActionMessages_PlannedOrderLink);
MRMACTM_ActionMessages_PlannedOrderLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing VerifyExists on ActionMessages_PlannedOrderForm...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_PlannedOrderForm = new SeleniumControl( sDriver, "ActionMessages_PlannedOrderForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMSSUB_SCHEDRECPT_MSGDTL_']/ancestor::form[1]");
				Function.AssertEqual(true,MRMACTM_ActionMessages_PlannedOrderForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing VerifyExists on ActionMessages_PlannedOrder_Message...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_PlannedOrder_Message = new SeleniumControl( sDriver, "ActionMessages_PlannedOrder_Message", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMSSUB_SCHEDRECPT_MSGDTL_']/ancestor::form[1]/descendant::*[@id='S_MRP_MSG_TYPE_CD_DESC']");
				Function.AssertEqual(true,MRMACTM_ActionMessages_PlannedOrder_Message.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing Close on ActionMessages_PlannedOrderForm...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_PlannedOrderForm = new SeleniumControl( sDriver, "ActionMessages_PlannedOrderForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMSSUB_SCHEDRECPT_MSGDTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MRMACTM_ActionMessages_PlannedOrderForm);
IWebElement formBttn = MRMACTM_ActionMessages_PlannedOrderForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Reservation");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing VerifyExists on ActionMessages_ReservationLink...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_ReservationLink = new SeleniumControl( sDriver, "ActionMessages_ReservationLink", "ID", "lnk_4633_MRMACTM_ZMRMACTMWRK_MSGCTW");
				Function.AssertEqual(true,MRMACTM_ActionMessages_ReservationLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing Click on ActionMessages_ReservationLink...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_ReservationLink = new SeleniumControl( sDriver, "ActionMessages_ReservationLink", "ID", "lnk_4633_MRMACTM_ZMRMACTMWRK_MSGCTW");
				Function.WaitControlDisplayed(MRMACTM_ActionMessages_ReservationLink);
MRMACTM_ActionMessages_ReservationLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing VerifyExists on ActionMessages_ReservationForm...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_ReservationForm = new SeleniumControl( sDriver, "ActionMessages_ReservationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMSSUB_RESLN_MSGDTL_']/ancestor::form[1]");
				Function.AssertEqual(true,MRMACTM_ActionMessages_ReservationForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing VerifyExists on ActionMessages_Reservation_Message...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_Reservation_Message = new SeleniumControl( sDriver, "ActionMessages_Reservation_Message", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMSSUB_RESLN_MSGDTL_']/ancestor::form[1]/descendant::*[@id='S_MRP_MSG_TYPE_CD_DESC']");
				Function.AssertEqual(true,MRMACTM_ActionMessages_Reservation_Message.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing Close on ActionMessages_ReservationForm...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_ReservationForm = new SeleniumControl( sDriver, "ActionMessages_ReservationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMSSUB_RESLN_MSGDTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MRMACTM_ActionMessages_ReservationForm);
IWebElement formBttn = MRMACTM_ActionMessages_ReservationForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Requisition");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing VerifyExists on ActionMessages_RequisitionLink...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_RequisitionLink = new SeleniumControl( sDriver, "ActionMessages_RequisitionLink", "ID", "lnk_4634_MRMACTM_ZMRMACTMWRK_MSGCTW");
				Function.AssertEqual(true,MRMACTM_ActionMessages_RequisitionLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing Click on ActionMessages_RequisitionLink...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_RequisitionLink = new SeleniumControl( sDriver, "ActionMessages_RequisitionLink", "ID", "lnk_4634_MRMACTM_ZMRMACTMWRK_MSGCTW");
				Function.WaitControlDisplayed(MRMACTM_ActionMessages_RequisitionLink);
MRMACTM_ActionMessages_RequisitionLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing VerifyExists on ActionMessages_RequisitionForm...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_RequisitionForm = new SeleniumControl( sDriver, "ActionMessages_RequisitionForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMSSUB_RQLN_MSGDTL_']/ancestor::form[1]");
				Function.AssertEqual(true,MRMACTM_ActionMessages_RequisitionForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing VerifyExists on ActionMessages_Requisition_Message...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_Requisition_Message = new SeleniumControl( sDriver, "ActionMessages_Requisition_Message", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMSSUB_RQLN_MSGDTL_']/ancestor::form[1]/descendant::*[@id='S_MRP_MSG_TYPE_CD_DESC']");
				Function.AssertEqual(true,MRMACTM_ActionMessages_Requisition_Message.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing VerifyExist on ActionMessages_Requisition_AssignPOInformationFormTable...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_Requisition_AssignPOInformationFormTable = new SeleniumControl( sDriver, "ActionMessages_Requisition_AssignPOInformationFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMSSUB_RQLNPO_MSGDTL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,MRMACTM_ActionMessages_Requisition_AssignPOInformationFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing ClickButton on ActionMessages_Requisition_AssignPOInformationForm...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_Requisition_AssignPOInformationForm = new SeleniumControl( sDriver, "ActionMessages_Requisition_AssignPOInformationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMSSUB_RQLNPO_MSGDTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MRMACTM_ActionMessages_Requisition_AssignPOInformationForm);
IWebElement formBttn = MRMACTM_ActionMessages_Requisition_AssignPOInformationForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? MRMACTM_ActionMessages_Requisition_AssignPOInformationForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
MRMACTM_ActionMessages_Requisition_AssignPOInformationForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing VerifyExists on ActionMessages_Requisition_AssignPOInformationForm...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_Requisition_AssignPOInformationForm = new SeleniumControl( sDriver, "ActionMessages_Requisition_AssignPOInformationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMSSUB_RQLNPO_MSGDTL_']/ancestor::form[1]");
				Function.AssertEqual(true,MRMACTM_ActionMessages_Requisition_AssignPOInformationForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing VerifyExists on ActionMessages_Requisition_AssignPOInformation_PO...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_Requisition_AssignPOInformation_PO = new SeleniumControl( sDriver, "ActionMessages_Requisition_AssignPOInformation_PO", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMSSUB_RQLNPO_MSGDTL_']/ancestor::form[1]/descendant::*[@id='PO_ID']");
				Function.AssertEqual(true,MRMACTM_ActionMessages_Requisition_AssignPOInformation_PO.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing Close on ActionMessages_RequisitionForm...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_RequisitionForm = new SeleniumControl( sDriver, "ActionMessages_RequisitionForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMSSUB_RQLN_MSGDTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MRMACTM_ActionMessages_RequisitionForm);
IWebElement formBttn = MRMACTM_ActionMessages_RequisitionForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Requirements");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing VerifyExists on ActionMessages_RequirementsLink...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_RequirementsLink = new SeleniumControl( sDriver, "ActionMessages_RequirementsLink", "ID", "lnk_4625_MRMACTM_ZMRMACTMWRK_MSGCTW");
				Function.AssertEqual(true,MRMACTM_ActionMessages_RequirementsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing Click on ActionMessages_RequirementsLink...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_RequirementsLink = new SeleniumControl( sDriver, "ActionMessages_RequirementsLink", "ID", "lnk_4625_MRMACTM_ZMRMACTMWRK_MSGCTW");
				Function.WaitControlDisplayed(MRMACTM_ActionMessages_RequirementsLink);
MRMACTM_ActionMessages_RequirementsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing VerifyExists on ActionMessages_RequirementsForm...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_RequirementsForm = new SeleniumControl( sDriver, "ActionMessages_RequirementsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMSSUB_GROSSRQMT_HDR_']/ancestor::form[1]");
				Function.AssertEqual(true,MRMACTM_ActionMessages_RequirementsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing VerifyExists on ActionMessages_Requirements_InvAbbrev...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_Requirements_InvAbbrev = new SeleniumControl( sDriver, "ActionMessages_Requirements_InvAbbrev", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMSSUB_GROSSRQMT_HDR_']/ancestor::form[1]/descendant::*[@id='INVT_ABBRV_CD']");
				Function.AssertEqual(true,MRMACTM_ActionMessages_Requirements_InvAbbrev.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing VerifyExist on ActionMessages_Requirements_RequirementDetailsFormTable...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_Requirements_RequirementDetailsFormTable = new SeleniumControl( sDriver, "ActionMessages_Requirements_RequirementDetailsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMSSUB_GROSSRQMT_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,MRMACTM_ActionMessages_Requirements_RequirementDetailsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing ClickButton on ActionMessages_Requirements_RequirementDetailsForm...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_Requirements_RequirementDetailsForm = new SeleniumControl( sDriver, "ActionMessages_Requirements_RequirementDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMSSUB_GROSSRQMT_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MRMACTM_ActionMessages_Requirements_RequirementDetailsForm);
IWebElement formBttn = MRMACTM_ActionMessages_Requirements_RequirementDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? MRMACTM_ActionMessages_Requirements_RequirementDetailsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
MRMACTM_ActionMessages_Requirements_RequirementDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing VerifyExists on ActionMessages_Requirements_RequirementDetailsForm...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_Requirements_RequirementDetailsForm = new SeleniumControl( sDriver, "ActionMessages_Requirements_RequirementDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMSSUB_GROSSRQMT_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,MRMACTM_ActionMessages_Requirements_RequirementDetailsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing VerifyExists on ActionMessages_Requirements_RequirementDetails_AssemblyPart...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_Requirements_RequirementDetails_AssemblyPart = new SeleniumControl( sDriver, "ActionMessages_Requirements_RequirementDetails_AssemblyPart", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMSSUB_GROSSRQMT_CTW_']/ancestor::form[1]/descendant::*[@id='ASY_PART_ID_DISP']");
				Function.AssertEqual(true,MRMACTM_ActionMessages_Requirements_RequirementDetails_AssemblyPart.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing Close on ActionMessages_RequirementsForm...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_RequirementsForm = new SeleniumControl( sDriver, "ActionMessages_RequirementsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMSSUB_GROSSRQMT_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MRMACTM_ActionMessages_RequirementsForm);
IWebElement formBttn = MRMACTM_ActionMessages_RequirementsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Full Reqmts");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing VerifyExists on ActionMessages_FullReqmtsLink...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_FullReqmtsLink = new SeleniumControl( sDriver, "ActionMessages_FullReqmtsLink", "ID", "lnk_4629_MRMACTM_ZMRMACTMWRK_MSGCTW");
				Function.AssertEqual(true,MRMACTM_ActionMessages_FullReqmtsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing Click on ActionMessages_FullReqmtsLink...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_FullReqmtsLink = new SeleniumControl( sDriver, "ActionMessages_FullReqmtsLink", "ID", "lnk_4629_MRMACTM_ZMRMACTMWRK_MSGCTW");
				Function.WaitControlDisplayed(MRMACTM_ActionMessages_FullReqmtsLink);
MRMACTM_ActionMessages_FullReqmtsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing VerifyExists on ActionMessages_FullReqmtsForm...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_FullReqmtsForm = new SeleniumControl( sDriver, "ActionMessages_FullReqmtsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMSSUB_ZMRMACTMFULLRQ_HDR_']/ancestor::form[1]");
				Function.AssertEqual(true,MRMACTM_ActionMessages_FullReqmtsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing VerifyExists on ActionMessages_FullReqmts_InvAbbrev...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_FullReqmts_InvAbbrev = new SeleniumControl( sDriver, "ActionMessages_FullReqmts_InvAbbrev", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMSSUB_ZMRMACTMFULLRQ_HDR_']/ancestor::form[1]/descendant::*[@id='INVT_ABBRV_CD']");
				Function.AssertEqual(true,MRMACTM_ActionMessages_FullReqmts_InvAbbrev.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing VerifyExist on ActionMessages_FullReqmts_FullRequirementDetailsFormTable...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_FullReqmts_FullRequirementDetailsFormTable = new SeleniumControl( sDriver, "ActionMessages_FullReqmts_FullRequirementDetailsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMSSUB_ZMRMACTMFULLRQ_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,MRMACTM_ActionMessages_FullReqmts_FullRequirementDetailsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing ClickButton on ActionMessages_FullReqmts_FullRequirementDetailsForm...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_FullReqmts_FullRequirementDetailsForm = new SeleniumControl( sDriver, "ActionMessages_FullReqmts_FullRequirementDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMSSUB_ZMRMACTMFULLRQ_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MRMACTM_ActionMessages_FullReqmts_FullRequirementDetailsForm);
IWebElement formBttn = MRMACTM_ActionMessages_FullReqmts_FullRequirementDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? MRMACTM_ActionMessages_FullReqmts_FullRequirementDetailsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
MRMACTM_ActionMessages_FullReqmts_FullRequirementDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing VerifyExists on ActionMessages_FullReqmts_FullRequirementDetailsForm...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_FullReqmts_FullRequirementDetailsForm = new SeleniumControl( sDriver, "ActionMessages_FullReqmts_FullRequirementDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMSSUB_ZMRMACTMFULLRQ_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,MRMACTM_ActionMessages_FullReqmts_FullRequirementDetailsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing VerifyExists on ActionMessages_FullReqmts_FullRequirementDetails_AssemblyPart...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_FullReqmts_FullRequirementDetails_AssemblyPart = new SeleniumControl( sDriver, "ActionMessages_FullReqmts_FullRequirementDetails_AssemblyPart", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMSSUB_ZMRMACTMFULLRQ_CTW_']/ancestor::form[1]/descendant::*[@id='ASY_PART_ID_DISP']");
				Function.AssertEqual(true,MRMACTM_ActionMessages_FullReqmts_FullRequirementDetails_AssemblyPart.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing Close on ActionMessages_FullReqmtsForm...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_FullReqmtsForm = new SeleniumControl( sDriver, "ActionMessages_FullReqmtsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMSSUB_ZMRMACTMFULLRQ_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MRMACTM_ActionMessages_FullReqmtsForm);
IWebElement formBttn = MRMACTM_ActionMessages_FullReqmtsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing VerifyExists on ActionMessages_SubstitutesLink...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_SubstitutesLink = new SeleniumControl( sDriver, "ActionMessages_SubstitutesLink", "ID", "lnk_4644_MRMACTM_ZMRMACTMWRK_MSGCTW");
				Function.AssertEqual(true,MRMACTM_ActionMessages_SubstitutesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing Click on ActionMessages_SubstitutesLink...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_SubstitutesLink = new SeleniumControl( sDriver, "ActionMessages_SubstitutesLink", "ID", "lnk_4644_MRMACTM_ZMRMACTMWRK_MSGCTW");
				Function.WaitControlDisplayed(MRMACTM_ActionMessages_SubstitutesLink);
MRMACTM_ActionMessages_SubstitutesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing VerifyExists on ActionMessages_SubstitutesForm...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_SubstitutesForm = new SeleniumControl( sDriver, "ActionMessages_SubstitutesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_ZMRMACTMSUBST_HDR_']/ancestor::form[1]");
				Function.AssertEqual(true,MRMACTM_ActionMessages_SubstitutesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing VerifyExists on ActionMessages_Substitutes_Project...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_Substitutes_Project = new SeleniumControl( sDriver, "ActionMessages_Substitutes_Project", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_ZMRMACTMSUBST_HDR_']/ancestor::form[1]/descendant::*[@id='INVT_PROJ_ID']");
				Function.AssertEqual(true,MRMACTM_ActionMessages_Substitutes_Project.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing VerifyExist on ActionMessages_Substitutes_SubstitutePartInventoryFormTable...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_Substitutes_SubstitutePartInventoryFormTable = new SeleniumControl( sDriver, "ActionMessages_Substitutes_SubstitutePartInventoryFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_ZMRMACTMSUBST_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,MRMACTM_ActionMessages_Substitutes_SubstitutePartInventoryFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing ClickButton on ActionMessages_Substitutes_SubstitutePartInventoryForm...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_Substitutes_SubstitutePartInventoryForm = new SeleniumControl( sDriver, "ActionMessages_Substitutes_SubstitutePartInventoryForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_ZMRMACTMSUBST_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MRMACTM_ActionMessages_Substitutes_SubstitutePartInventoryForm);
IWebElement formBttn = MRMACTM_ActionMessages_Substitutes_SubstitutePartInventoryForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? MRMACTM_ActionMessages_Substitutes_SubstitutePartInventoryForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
MRMACTM_ActionMessages_Substitutes_SubstitutePartInventoryForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing VerifyExists on ActionMessages_Substitutes_SubstitutePartInventoryForm...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_Substitutes_SubstitutePartInventoryForm = new SeleniumControl( sDriver, "ActionMessages_Substitutes_SubstitutePartInventoryForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_ZMRMACTMSUBST_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,MRMACTM_ActionMessages_Substitutes_SubstitutePartInventoryForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing VerifyExists on ActionMessages_Substitutes_SubstitutePartInventory_SubstitutePart...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_Substitutes_SubstitutePartInventory_SubstitutePart = new SeleniumControl( sDriver, "ActionMessages_Substitutes_SubstitutePartInventory_SubstitutePart", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_ZMRMACTMSUBST_CTW_']/ancestor::form[1]/descendant::*[@id='PART_ID']");
				Function.AssertEqual(true,MRMACTM_ActionMessages_Substitutes_SubstitutePartInventory_SubstitutePart.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing Select on ActionMessages_Substitutes_SubstitutePartInventory_SubstitutePartInventoryTab...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_Substitutes_SubstitutePartInventory_SubstitutePartInventoryTab = new SeleniumControl( sDriver, "ActionMessages_Substitutes_SubstitutePartInventory_SubstitutePartInventoryTab", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_ZMRMACTMSUBST_CTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(MRMACTM_ActionMessages_Substitutes_SubstitutePartInventory_SubstitutePartInventoryTab);
IWebElement mTab = MRMACTM_ActionMessages_Substitutes_SubstitutePartInventory_SubstitutePartInventoryTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Quantities").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing VerifyExists on ActionMessages_Substitutes_SubstitutePartInventory_Quantities_Quantities_NetAvailable...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_Substitutes_SubstitutePartInventory_Quantities_Quantities_NetAvailable = new SeleniumControl( sDriver, "ActionMessages_Substitutes_SubstitutePartInventory_Quantities_Quantities_NetAvailable", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_ZMRMACTMSUBST_CTW_']/ancestor::form[1]/descendant::*[@id='NET_AVAIL_QTY']");
				Function.AssertEqual(true,MRMACTM_ActionMessages_Substitutes_SubstitutePartInventory_Quantities_Quantities_NetAvailable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing Close on ActionMessages_SubstitutesForm...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_SubstitutesForm = new SeleniumControl( sDriver, "ActionMessages_SubstitutesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_ZMRMACTMSUBST_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MRMACTM_ActionMessages_SubstitutesForm);
IWebElement formBttn = MRMACTM_ActionMessages_SubstitutesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing VerifyExists on ActionMessages_ECNsLink...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_ECNsLink = new SeleniumControl( sDriver, "ActionMessages_ECNsLink", "ID", "lnk_4642_MRMACTM_ZMRMACTMWRK_MSGCTW");
				Function.AssertEqual(true,MRMACTM_ActionMessages_ECNsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing Click on ActionMessages_ECNsLink...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_ECNsLink = new SeleniumControl( sDriver, "ActionMessages_ECNsLink", "ID", "lnk_4642_MRMACTM_ZMRMACTMWRK_MSGCTW");
				Function.WaitControlDisplayed(MRMACTM_ActionMessages_ECNsLink);
MRMACTM_ActionMessages_ECNsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing VerifyExist on ActionMessages_ECNsFormTable...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_ECNsFormTable = new SeleniumControl( sDriver, "ActionMessages_ECNsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_ECNPART_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,MRMACTM_ActionMessages_ECNsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing ClickButton on ActionMessages_ECNsForm...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_ECNsForm = new SeleniumControl( sDriver, "ActionMessages_ECNsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_ECNPART_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MRMACTM_ActionMessages_ECNsForm);
IWebElement formBttn = MRMACTM_ActionMessages_ECNsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? MRMACTM_ActionMessages_ECNsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
MRMACTM_ActionMessages_ECNsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing VerifyExists on ActionMessages_ECNs_EngineeringChangeNotice...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_ECNs_EngineeringChangeNotice = new SeleniumControl( sDriver, "ActionMessages_ECNs_EngineeringChangeNotice", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_ECNPART_CTW_']/ancestor::form[1]/descendant::*[@id='ECN_ID']");
				Function.AssertEqual(true,MRMACTM_ActionMessages_ECNs_EngineeringChangeNotice.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing Select on ActionMessages_ECNs_ECNsTab...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_ECNs_ECNsTab = new SeleniumControl( sDriver, "ActionMessages_ECNs_ECNsTab", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_ECNPART_CTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(MRMACTM_ActionMessages_ECNs_ECNsTab);
IWebElement mTab = MRMACTM_ActionMessages_ECNs_ECNsTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "ECN Details").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing VerifyExists on ActionMessages_ECNs_ECNDetails_Status...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_ECNs_ECNDetails_Status = new SeleniumControl( sDriver, "ActionMessages_ECNs_ECNDetails_Status", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_ECNPART_CTW_']/ancestor::form[1]/descendant::*[@id='S_ECN_STATUS_CD']");
				Function.AssertEqual(true,MRMACTM_ActionMessages_ECNs_ECNDetails_Status.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing Close on ActionMessages_ECNsForm...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_ActionMessages_ECNsForm = new SeleniumControl( sDriver, "ActionMessages_ECNsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_ECNPART_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MRMACTM_ActionMessages_ECNsForm);
IWebElement formBttn = MRMACTM_ActionMessages_ECNsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "MRMACTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMACTM] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl MRMACTM_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(MRMACTM_MainForm);
IWebElement formBttn = MRMACTM_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

