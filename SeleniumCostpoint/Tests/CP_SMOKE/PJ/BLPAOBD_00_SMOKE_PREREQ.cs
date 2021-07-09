 
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
    public class BLPAOBD_00_SMOKE_PREREQ : SeleniumTestScript
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
new SeleniumControl(sDriver,"Projects", "xpath","//div[@class='busItem'][.='Projects']").Click();
new SeleniumControl(sDriver,"Billing", "xpath","//div[@class='deptItem'][.='Billing']").Click();
new SeleniumControl(sDriver,"Billing Controls", "xpath","//div[@class='navItem'][.='Billing Controls']").Click();
new SeleniumControl(sDriver,"Configure Billing Settings", "xpath","//div[@class='navItem'][.='Configure Billing Settings']").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SelectMenu]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMSETNG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMSETNG] Performing Set on Settings_Options_AssignBillsToUserGroups...", Logger.MessageType.INF);
				SeleniumControl BLMSETNG_Settings_Options_AssignBillsToUserGroups = new SeleniumControl( sDriver, "Settings_Options_AssignBillsToUserGroups", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='BILL_USER_GRP_FL']");
				Function.WaitControlDisplayed(BLMSETNG_Settings_Options_AssignBillsToUserGroups);
BLMSETNG_Settings_Options_AssignBillsToUserGroups.ScrollIntoViewUsingJavaScript();
if (Convert.ToBoolean(BLMSETNG_Settings_Options_AssignBillsToUserGroups.GetAttributeValue("checked")) != true) BLMSETNG_Settings_Options_AssignBillsToUserGroups.Click(4.3);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Set]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMSETNG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMSETNG] Performing Set on Settings_Options_AssignBillsToUserGroups...", Logger.MessageType.INF);
				SeleniumControl BLMSETNG_Settings_Options_AssignBillsToUserGroups = new SeleniumControl( sDriver, "Settings_Options_AssignBillsToUserGroups", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='BILL_USER_GRP_FL']");
				Function.WaitControlDisplayed(BLMSETNG_Settings_Options_AssignBillsToUserGroups);
BLMSETNG_Settings_Options_AssignBillsToUserGroups.ScrollIntoViewUsingJavaScript();
if (Convert.ToBoolean(BLMSETNG_Settings_Options_AssignBillsToUserGroups.GetAttributeValue("checked")) != false) BLMSETNG_Settings_Options_AssignBillsToUserGroups.Click(4.3);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Set]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMSETNG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMSETNG] Performing Set on Settings_Options_AssignBillsToUserGroups...", Logger.MessageType.INF);
				SeleniumControl BLMSETNG_Settings_Options_AssignBillsToUserGroups = new SeleniumControl( sDriver, "Settings_Options_AssignBillsToUserGroups", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='BILL_USER_GRP_FL']");
				Function.WaitControlDisplayed(BLMSETNG_Settings_Options_AssignBillsToUserGroups);
BLMSETNG_Settings_Options_AssignBillsToUserGroups.ScrollIntoViewUsingJavaScript();
if (Convert.ToBoolean(BLMSETNG_Settings_Options_AssignBillsToUserGroups.GetAttributeValue("checked")) != true) BLMSETNG_Settings_Options_AssignBillsToUserGroups.Click(4.3);


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
IWebElement tlbrBtn = CP7Main_MainToolBar.mElement.FindElements(By.XPath(".//*[@class='tbBtnContainer']//div[contains(@title,'Save')]")).FirstOrDefault();
if (tlbrBtn==null) throw new Exception("Unable to find button Save.");
tlbrBtn.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickToolbarButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "CP7Main";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[CP7Main] Performing SelectMenu on NavMenu...", Logger.MessageType.INF);
				SeleniumControl CP7Main_NavMenu = new SeleniumControl( sDriver, "NavMenu", "ID", "navCont");
				if(!sDriver.Instance.FindElement(By.CssSelector("div[class='navCont']")).Displayed) new SeleniumControl(sDriver,"Browse", "css", "span[id = 'goToLbl']").Click();
new SeleniumControl(sDriver,"Projects", "xpath","//div[@class='busItem'][.='Projects']").Click();
new SeleniumControl(sDriver,"Billing", "xpath","//div[@class='deptItem'][.='Billing']").Click();
new SeleniumControl(sDriver,"Billing Master", "xpath","//div[@class='navItem'][.='Billing Master']").Click();
new SeleniumControl(sDriver,"Manage Project Billing Information", "xpath","//div[@class='navItem'][.='Manage Project Billing Information']").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SelectMenu]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("MAINFORM");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMINFO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMINFO] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl BLMINFO_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,BLMINFO_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Query an existing record");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMINFO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMINFO] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl BLMINFO_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(BLMINFO_MainForm);
IWebElement formBttn = BLMINFO_MainForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).Count <= 0 ? BLMINFO_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Query')]")).FirstOrDefault() :
BLMINFO_MainForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Query not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "Query";
								Function.WaitControlDisplayed(new SeleniumControl(sDriver,"QueryTitle", "ID", "qryHeaderLabel"));
Function.AssertEqual("Proj Bill Info", new SeleniumControl(sDriver,"QueryTitle", "ID", "qryHeaderLabel").GetValue().Trim());


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyTitle]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "Query";
								SeleniumControl ctl = new SeleniumControl(sDriver,"Target", "xpath_display", "//*[@id='basicQTbl']/tbody/tr/td/span[text()='Project']");
Function.WaitControlDisplayed(ctl);
SeleniumControl RelationshipField = new SeleniumControl(sDriver,"Relationship", ctl.mElement.FindElement(By.XPath("../following-sibling::td[1]")));
SeleniumControl SearchField = new SeleniumControl(sDriver,"Relationship", ctl.mElement.FindElement(By.XPath("../following-sibling::td[2]")));
new SeleniumControl(sDriver, "RelDropdown", RelationshipField.mElement.FindElements(By.XPath("./descendant::*[@class='tCCBImg']")).FirstOrDefault()).Click();
new SeleniumControl(sDriver, "RelItem", "xpath", ".//descendant::div[text() = 'is equal to']").Click();
if (SearchField.mElement.GetAttribute("class").Equals("tCCB")) {
new SeleniumControl(sDriver, "SearchDropdown", SearchField.mElement.FindElements(By.XPath(".//descendant::*[@class='tCCBImg']")).FirstOrDefault()).Click();
new SeleniumControl(sDriver, "SearchItem", "xpath_display", ".//descendant::div[text()='1003']").Click();
} else { 
new SeleniumControl(sDriver, "SearchDropdown", SearchField.mElement.FindElements(By.XPath(".//descendant::*[@class='queryBasicFld']")).FirstOrDefault()).SendKeys("1003");}


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
								try
				{
				this.ScriptLogger.WriteLine("Verify correct record retrieved");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMINFO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMINFO] Performing VerifyText on Project...", Logger.MessageType.INF);
				SeleniumControl BLMINFO_Project = new SeleniumControl( sDriver, "Project", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='INVC_PROJ_ID']");
				Function.AssertEqual("1003",BLMINFO_Project.GetAttributeValue("value"));


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyText]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("required fields");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMINFO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMINFO] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl BLMINFO_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(BLMINFO_MainFormTab);
IWebElement mTab = BLMINFO_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Setup Information").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMINFO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMINFO] Performing VerifyExists on SetupInformation_Controls_BillingCycle...", Logger.MessageType.INF);
				SeleniumControl BLMINFO_SetupInformation_Controls_BillingCycle = new SeleniumControl( sDriver, "SetupInformation_Controls_BillingCycle", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='BILL_CYCLE_CD']");
				Function.AssertEqual(true,BLMINFO_SetupInformation_Controls_BillingCycle.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMINFO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMINFO] Performing Set on SetupInformation_Controls_BillingCycle...", Logger.MessageType.INF);
				SeleniumControl BLMINFO_SetupInformation_Controls_BillingCycle = new SeleniumControl( sDriver, "SetupInformation_Controls_BillingCycle", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='BILL_CYCLE_CD']");
				BLMINFO_SetupInformation_Controls_BillingCycle.Click();
BLMINFO_SetupInformation_Controls_BillingCycle.SendKeys("COMP2", true);
Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));
BLMINFO_SetupInformation_Controls_BillingCycle.SendKeys(OpenQA.Selenium.Keys.Shift + OpenQA.Selenium.Keys.Tab);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Set]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMINFO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMINFO] Performing VerifyExists on SetupInformation_Controls_BillingUserGroup...", Logger.MessageType.INF);
				SeleniumControl BLMINFO_SetupInformation_Controls_BillingUserGroup = new SeleniumControl( sDriver, "SetupInformation_Controls_BillingUserGroup", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='BILL_GRP_CD']");
				Function.AssertEqual(true,BLMINFO_SetupInformation_Controls_BillingUserGroup.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMINFO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMINFO] Performing Set on SetupInformation_Controls_BillingUserGroup...", Logger.MessageType.INF);
				SeleniumControl BLMINFO_SetupInformation_Controls_BillingUserGroup = new SeleniumControl( sDriver, "SetupInformation_Controls_BillingUserGroup", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='BILL_GRP_CD']");
				BLMINFO_SetupInformation_Controls_BillingUserGroup.Click();
BLMINFO_SetupInformation_Controls_BillingUserGroup.SendKeys("123456", true);
Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));
BLMINFO_SetupInformation_Controls_BillingUserGroup.SendKeys(OpenQA.Selenium.Keys.Shift + OpenQA.Selenium.Keys.Tab);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Set]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Save record and close application");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "CP7Main";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[CP7Main] Performing ClickToolbarButton on MainToolBar...", Logger.MessageType.INF);
				SeleniumControl CP7Main_MainToolBar = new SeleniumControl( sDriver, "MainToolBar", "ID", "tlbr");
				Function.WaitControlDisplayed(CP7Main_MainToolBar);
IWebElement tlbrBtn = CP7Main_MainToolBar.mElement.FindElements(By.XPath(".//*[@class='tbBtnContainer']//div[contains(@title,'Save')]")).FirstOrDefault();
if (tlbrBtn==null) throw new Exception("Unable to find button Save.");
tlbrBtn.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickToolbarButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "CP7Main";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(true));

				this.ScriptLogger.WriteLine("[CP7Main] Performing VerifyMessageExists on MessagesArea...", Logger.MessageType.INF);
				SeleniumControl CP7Main_MessagesArea = new SeleniumControl( sDriver, "MessagesArea", "XPATH", "//div[contains(@class,'msg') and contains(@style,'visible')]");
				Function.WaitControlDisplayed(CP7Main_MessagesArea);
IList<IWebElement> msgElements = sDriver.Instance.FindElements(By.XPath("//span[contains(@class,'msgTextHdr')]/following-sibling::span[not(contains(@class,'msgTextHdr'))]"));
Function.AssertEqual(true, msgElements.ToList().Select(x => new SeleniumControl( sDriver, "x", x).GetValue().Trim()).Any(x => x == "Record modifications successfully completed."));


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyMessageExists]" , ex.Message));
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

