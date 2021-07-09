 
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
    public class PCMMOMNT_SMOKE : SeleniumTestScript
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
								try
				{
				this.ScriptLogger.WriteLine("Check main form ");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "CP7Main";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[CP7Main] Performing SelectMenu on NavMenu...", Logger.MessageType.INF);
				SeleniumControl CP7Main_NavMenu = new SeleniumControl( sDriver, "NavMenu", "ID", "navCont");
				if(!sDriver.Instance.FindElement(By.CssSelector("div[class='navCont']")).Displayed) new SeleniumControl(sDriver,"Browse", "css", "span[id = 'goToLbl']").Click();
new SeleniumControl(sDriver,"Materials", "xpath","//div[@class='busItem'][.='Materials']").Click();
new SeleniumControl(sDriver,"Production Control", "xpath","//div[@class='deptItem'][.='Production Control']").Click();
new SeleniumControl(sDriver,"Manufacturing Orders", "xpath","//div[@class='navItem'][.='Manufacturing Orders']").Click();
new SeleniumControl(sDriver,"Manage Manufacturing Orders", "xpath","//div[@class='navItem'][.='Manage Manufacturing Orders']").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SelectMenu]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,PCMMOMNT_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing ClickButtonIfExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PCMMOMNT_MainForm);
IWebElement formBttn = PCMMOMNT_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? PCMMOMNT_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
PCMMOMNT_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault();
if (formBttn!=null && formBttn.Displayed)
{ new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click();
this.ScriptLogger.WriteLine("Button [Table] found and clicked.", Logger.MessageType.INF);
}


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButtonIfExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PCMMOMNT_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing ClickButtonIfExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PCMMOMNT_MainForm);
IWebElement formBttn = PCMMOMNT_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PCMMOMNT_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PCMMOMNT_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault();
if (formBttn!=null && formBttn.Displayed)
{ new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click();
this.ScriptLogger.WriteLine("Button [Form] found and clicked.", Logger.MessageType.INF);
}


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButtonIfExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,PCMMOMNT_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing VerifyExists on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.AssertEqual(true,PCMMOMNT_MainFormTab.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing VerifyTabs on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PCMMOMNT_MainFormTab);
string[] strTabs = PCMMOMNT_MainFormTab.mElement.FindElements(By.CssSelector("span[class*='TabLbl']")).Where(x => x.Displayed).Select(x => new SeleniumControl( sDriver, "x", x).GetValue().Trim()).ToArray();
Function.AssertEqual(String.Join("~", strTabs), "Details~Additional Info~Notes~Project Manufacturing");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyTabs]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PCMMOMNT_MainFormTab);
IWebElement mTab = PCMMOMNT_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Details").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing VerifyExists on Details_Planner...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_Details_Planner = new SeleniumControl( sDriver, "Details_Planner", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PLANNER_ID']");
				Function.AssertEqual(true,PCMMOMNT_Details_Planner.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing VerifyExists on Details_PlannerName...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_Details_PlannerName = new SeleniumControl( sDriver, "Details_PlannerName", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PLANNER_NAME']");
				Function.AssertEqual(true,PCMMOMNT_Details_PlannerName.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PCMMOMNT_MainFormTab);
IWebElement mTab = PCMMOMNT_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Additional Info").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing VerifyExists on AdditionalInfo_Organization...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_AdditionalInfo_Organization = new SeleniumControl( sDriver, "AdditionalInfo_Organization", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='ORG_ID']");
				Function.AssertEqual(true,PCMMOMNT_AdditionalInfo_Organization.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing VerifyExists on AdditionalInfo_OrderReference...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_AdditionalInfo_OrderReference = new SeleniumControl( sDriver, "AdditionalInfo_OrderReference", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='ORDER_REF_ID']");
				Function.AssertEqual(true,PCMMOMNT_AdditionalInfo_OrderReference.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PCMMOMNT_MainFormTab);
IWebElement mTab = PCMMOMNT_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Notes").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing VerifyExists on Note_HeaderNotes_Text...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_Note_HeaderNotes_Text = new SeleniumControl( sDriver, "Note_HeaderNotes_Text", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='MO_NOTES']");
				Function.AssertEqual(true,PCMMOMNT_Note_HeaderNotes_Text.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing VerifyExists on Note_ExpediteNotes_Text...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_Note_ExpediteNotes_Text = new SeleniumControl( sDriver, "Note_ExpediteNotes_Text", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='MO_EXPDT_NOTES']");
				Function.AssertEqual(true,PCMMOMNT_Note_ExpediteNotes_Text.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PCMMOMNT_MainFormTab);
IWebElement mTab = PCMMOMNT_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Project Manufacturing").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing VerifyExists on ProjectManufacturing_MOOriginatedInManufacturingExecution...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_ProjectManufacturing_MOOriginatedInManufacturingExecution = new SeleniumControl( sDriver, "ProjectManufacturing_MOOriginatedInManufacturingExecution", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='FROM_MES_FL']");
				Function.AssertEqual(true,PCMMOMNT_ProjectManufacturing_MOOriginatedInManufacturingExecution.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing VerifyExists on ProjectManufacturing_ExportMOToManufacturingExecution...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_ProjectManufacturing_ExportMOToManufacturingExecution = new SeleniumControl( sDriver, "ProjectManufacturing_ExportMOToManufacturingExecution", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='MES_FL']");
				Function.AssertEqual(true,PCMMOMNT_ProjectManufacturing_ExportMOToManufacturingExecution.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing VerifyExists on ProjectManufacturing_ExportMOToShopFloorTime...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_ProjectManufacturing_ExportMOToShopFloorTime = new SeleniumControl( sDriver, "ProjectManufacturing_ExportMOToShopFloorTime", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='SFT_FL']");
				Function.AssertEqual(true,PCMMOMNT_ProjectManufacturing_ExportMOToShopFloorTime.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Check allocations");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing VerifyExists on AllocationLink...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_AllocationLink = new SeleniumControl( sDriver, "AllocationLink", "ID", "lnk_4294_PCMMOMNT_MOHDR_HDR");
				Function.AssertEqual(true,PCMMOMNT_AllocationLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing Click on AllocationLink...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_AllocationLink = new SeleniumControl( sDriver, "AllocationLink", "ID", "lnk_4294_PCMMOMNT_MOHDR_HDR");
				Function.WaitControlDisplayed(PCMMOMNT_AllocationLink);
PCMMOMNT_AllocationLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing VerifyExists on AllocationForm...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_AllocationForm = new SeleniumControl( sDriver, "AllocationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCM_MOALLOCATIONS_']/ancestor::form[1]");
				Function.AssertEqual(true,PCMMOMNT_AllocationForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing VerifyExist on AllocationTable...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_AllocationTable = new SeleniumControl( sDriver, "AllocationTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PCM_MOALLOCATIONS_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PCMMOMNT_AllocationTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing ClickButtonIfExists on AllocationForm...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_AllocationForm = new SeleniumControl( sDriver, "AllocationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCM_MOALLOCATIONS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCMMOMNT_AllocationForm);
IWebElement formBttn = PCMMOMNT_AllocationForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PCMMOMNT_AllocationForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PCMMOMNT_AllocationForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault();
if (formBttn!=null && formBttn.Displayed)
{ new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click();
this.ScriptLogger.WriteLine("Button [Form] found and clicked.", Logger.MessageType.INF);
}


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButtonIfExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing VerifyExists on Allocations_AllocationInvAbbrev...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_Allocations_AllocationInvAbbrev = new SeleniumControl( sDriver, "Allocations_AllocationInvAbbrev", "xpath", "//div[translate(@id,'0123456789','')='pr__PCM_MOALLOCATIONS_']/ancestor::form[1]/descendant::*[@id='BLD_INVT_ABBRV_CD']");
				Function.AssertEqual(true,PCMMOMNT_Allocations_AllocationInvAbbrev.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing ClickButtonIfExists on AllocationForm...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_AllocationForm = new SeleniumControl( sDriver, "AllocationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCM_MOALLOCATIONS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCMMOMNT_AllocationForm);
IWebElement formBttn = PCMMOMNT_AllocationForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? PCMMOMNT_AllocationForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
PCMMOMNT_AllocationForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault();
if (formBttn!=null && formBttn.Displayed)
{ new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click();
this.ScriptLogger.WriteLine("Button [Table] found and clicked.", Logger.MessageType.INF);
}


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButtonIfExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing VerifyExists on AllocationLink...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_AllocationLink = new SeleniumControl( sDriver, "AllocationLink", "ID", "lnk_4294_PCMMOMNT_MOHDR_HDR");
				Function.AssertEqual(true,PCMMOMNT_AllocationLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing Close on AllocationForm...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_AllocationForm = new SeleniumControl( sDriver, "AllocationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCM_MOALLOCATIONS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCMMOMNT_AllocationForm);
IWebElement formBttn = PCMMOMNT_AllocationForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Check requirements");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing VerifyExists on RequirementsLink...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_RequirementsLink = new SeleniumControl( sDriver, "RequirementsLink", "ID", "lnk_4295_PCMMOMNT_MOHDR_HDR");
				Function.AssertEqual(true,PCMMOMNT_RequirementsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing Click on RequirementsLink...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_RequirementsLink = new SeleniumControl( sDriver, "RequirementsLink", "ID", "lnk_4295_PCMMOMNT_MOHDR_HDR");
				Function.WaitControlDisplayed(PCMMOMNT_RequirementsLink);
PCMMOMNT_RequirementsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing VerifyExists on RequirementsForm...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_RequirementsForm = new SeleniumControl( sDriver, "RequirementsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCM_MOHDR_RQMTHDR_']/ancestor::form[1]");
				Function.AssertEqual(true,PCMMOMNT_RequirementsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing VerifyExists on Requirements_SubAssemblyInvAbbrev...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_Requirements_SubAssemblyInvAbbrev = new SeleniumControl( sDriver, "Requirements_SubAssemblyInvAbbrev", "xpath", "//div[translate(@id,'0123456789','')='pr__PCM_MOHDR_RQMTHDR_']/ancestor::form[1]/descendant::*[@id='SASY_INVT_ABBRV_CD']");
				Function.AssertEqual(true,PCMMOMNT_Requirements_SubAssemblyInvAbbrev.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing ClickButtonIfExists on RequirementsChildForm...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_RequirementsChildForm = new SeleniumControl( sDriver, "RequirementsChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCM_MORQMT_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCMMOMNT_RequirementsChildForm);
IWebElement formBttn = PCMMOMNT_RequirementsChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PCMMOMNT_RequirementsChildForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PCMMOMNT_RequirementsChildForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault();
if (formBttn!=null && formBttn.Displayed)
{ new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click();
this.ScriptLogger.WriteLine("Button [Form] found and clicked.", Logger.MessageType.INF);
}


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButtonIfExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing ClickButtonIfExists on RequirementsChildForm...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_RequirementsChildForm = new SeleniumControl( sDriver, "RequirementsChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCM_MORQMT_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCMMOMNT_RequirementsChildForm);
IWebElement formBttn = PCMMOMNT_RequirementsChildForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? PCMMOMNT_RequirementsChildForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
PCMMOMNT_RequirementsChildForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault();
if (formBttn!=null && formBttn.Displayed)
{ new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click();
this.ScriptLogger.WriteLine("Button [Table] found and clicked.", Logger.MessageType.INF);
}


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButtonIfExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing VerifyExist on RequirementsChildTable...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_RequirementsChildTable = new SeleniumControl( sDriver, "RequirementsChildTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PCM_MORQMT_DTL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PCMMOMNT_RequirementsChildTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing ClickButtonIfExists on RequirementsChildForm...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_RequirementsChildForm = new SeleniumControl( sDriver, "RequirementsChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCM_MORQMT_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCMMOMNT_RequirementsChildForm);
IWebElement formBttn = PCMMOMNT_RequirementsChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PCMMOMNT_RequirementsChildForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PCMMOMNT_RequirementsChildForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault();
if (formBttn!=null && formBttn.Displayed)
{ new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click();
this.ScriptLogger.WriteLine("Button [Form] found and clicked.", Logger.MessageType.INF);
}


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButtonIfExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("handle dialog which occurs twice on first run and once on succeeding without closing requirements dialog");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing VerifyExists on RequirementsChildForm_RequirementsDetails_InventoryAbbrevLabel...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_RequirementsChildForm_RequirementsDetails_InventoryAbbrevLabel = new SeleniumControl( sDriver, "RequirementsChildForm_RequirementsDetails_InventoryAbbrevLabel", "xpath", "//input[@id='COMP_LN_NO']/ancestor::form[1]/descendant::input[@id='INVT_ABBRV_CD']/preceding-sibling::span[@class='flbl'][1]");
				Function.AssertEqual(true,PCMMOMNT_RequirementsChildForm_RequirementsDetails_InventoryAbbrevLabel.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing ClickButtonIfExists on RequirementsChildForm...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_RequirementsChildForm = new SeleniumControl( sDriver, "RequirementsChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCM_MORQMT_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCMMOMNT_RequirementsChildForm);
IWebElement formBttn = PCMMOMNT_RequirementsChildForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? PCMMOMNT_RequirementsChildForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
PCMMOMNT_RequirementsChildForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault();
if (formBttn!=null && formBttn.Displayed)
{ new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click();
this.ScriptLogger.WriteLine("Button [Table] found and clicked.", Logger.MessageType.INF);
}


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButtonIfExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing VerifyExist on RequirementsChildTable...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_RequirementsChildTable = new SeleniumControl( sDriver, "RequirementsChildTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PCM_MORQMT_DTL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PCMMOMNT_RequirementsChildTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing Close on RequirementsForm...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_RequirementsForm = new SeleniumControl( sDriver, "RequirementsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCM_MOHDR_RQMTHDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCMMOMNT_RequirementsForm);
IWebElement formBttn = PCMMOMNT_RequirementsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Check Routings");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing VerifyExists on RoutingsLink...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_RoutingsLink = new SeleniumControl( sDriver, "RoutingsLink", "ID", "lnk_4297_PCMMOMNT_MOHDR_HDR");
				Function.AssertEqual(true,PCMMOMNT_RoutingsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing Click on RoutingsLink...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_RoutingsLink = new SeleniumControl( sDriver, "RoutingsLink", "ID", "lnk_4297_PCMMOMNT_MOHDR_HDR");
				Function.WaitControlDisplayed(PCMMOMNT_RoutingsLink);
PCMMOMNT_RoutingsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing VerifyExists on RoutingsForm...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_RoutingsForm = new SeleniumControl( sDriver, "RoutingsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCM_MOHDR_ROUTHDR_']/ancestor::form[1]");
				Function.AssertEqual(true,PCMMOMNT_RoutingsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing VerifyExists on Routings_RoutingNo...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_Routings_RoutingNo = new SeleniumControl( sDriver, "Routings_RoutingNo", "xpath", "//div[translate(@id,'0123456789','')='pr__PCM_MOHDR_ROUTHDR_']/ancestor::form[1]/descendant::*[@id='ROUT_NO']");
				Function.AssertEqual(true,PCMMOMNT_Routings_RoutingNo.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing VerifyExists on RoutingLinesForm...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_RoutingLinesForm = new SeleniumControl( sDriver, "RoutingLinesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCM_MOROUTING_DTL_']/ancestor::form[1]");
				Function.AssertEqual(true,PCMMOMNT_RoutingLinesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing VerifyExist on RoutingLinesTable...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_RoutingLinesTable = new SeleniumControl( sDriver, "RoutingLinesTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PCM_MOROUTING_DTL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PCMMOMNT_RoutingLinesTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing ClickButtonIfExists on RoutingLinesForm...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_RoutingLinesForm = new SeleniumControl( sDriver, "RoutingLinesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCM_MOROUTING_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCMMOMNT_RoutingLinesForm);
IWebElement formBttn = PCMMOMNT_RoutingLinesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PCMMOMNT_RoutingLinesForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PCMMOMNT_RoutingLinesForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault();
if (formBttn!=null && formBttn.Displayed)
{ new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click();
this.ScriptLogger.WriteLine("Button [Form] found and clicked.", Logger.MessageType.INF);
}


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButtonIfExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing VerifyExists on RoutingLines_Sequence...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_RoutingLines_Sequence = new SeleniumControl( sDriver, "RoutingLines_Sequence", "xpath", "//div[translate(@id,'0123456789','')='pr__PCM_MOROUTING_DTL_']/ancestor::form[1]/descendant::*[@id='MO_OPER_SEQ_NO']");
				Function.AssertEqual(true,PCMMOMNT_RoutingLines_Sequence.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing VerifyExists on RoutingLinesTab...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_RoutingLinesTab = new SeleniumControl( sDriver, "RoutingLinesTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PCM_MOROUTING_DTL_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.AssertEqual(true,PCMMOMNT_RoutingLinesTab.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing VerifyTabs on RoutingLinesTab...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_RoutingLinesTab = new SeleniumControl( sDriver, "RoutingLinesTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PCM_MOROUTING_DTL_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PCMMOMNT_RoutingLinesTab);
string[] strTabs = PCMMOMNT_RoutingLinesTab.mElement.FindElements(By.CssSelector("span[class*='TabLbl']")).Where(x => x.Displayed).Select(x => new SeleniumControl( sDriver, "x", x).GetValue().Trim()).ToArray();
Function.AssertEqual(String.Join("~", strTabs), "Operation~Routing Line Notes");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyTabs]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing ClickButtonIfExists on RoutingLinesForm...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_RoutingLinesForm = new SeleniumControl( sDriver, "RoutingLinesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCM_MOROUTING_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCMMOMNT_RoutingLinesForm);
IWebElement formBttn = PCMMOMNT_RoutingLinesForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? PCMMOMNT_RoutingLinesForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
PCMMOMNT_RoutingLinesForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault();
if (formBttn!=null && formBttn.Displayed)
{ new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click();
this.ScriptLogger.WriteLine("Button [Table] found and clicked.", Logger.MessageType.INF);
}


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButtonIfExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing VerifyExist on RoutingLinesTable...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_RoutingLinesTable = new SeleniumControl( sDriver, "RoutingLinesTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PCM_MOROUTING_DTL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PCMMOMNT_RoutingLinesTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing Close on RoutingsForm...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_RoutingsForm = new SeleniumControl( sDriver, "RoutingsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCM_MOHDR_ROUTHDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCMMOMNT_RoutingsForm);
IWebElement formBttn = PCMMOMNT_RoutingsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Check Text");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing VerifyExists on TextLink...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_TextLink = new SeleniumControl( sDriver, "TextLink", "ID", "lnk_4163_PCMMOMNT_MOHDR_HDR");
				Function.AssertEqual(true,PCMMOMNT_TextLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing Click on TextLink...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_TextLink = new SeleniumControl( sDriver, "TextLink", "ID", "lnk_4163_PCMMOMNT_MOHDR_HDR");
				Function.WaitControlDisplayed(PCMMOMNT_TextLink);
PCMMOMNT_TextLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing VerifyExists on TextForm...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_TextForm = new SeleniumControl( sDriver, "TextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMMOMNT_MOHDRTEXT_DTL_']/ancestor::form[1]");
				Function.AssertEqual(true,PCMMOMNT_TextForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing VerifyExist on TextTable...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_TextTable = new SeleniumControl( sDriver, "TextTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMMOMNT_MOHDRTEXT_DTL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PCMMOMNT_TextTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing ClickButtonIfExists on TextForm...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_TextForm = new SeleniumControl( sDriver, "TextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMMOMNT_MOHDRTEXT_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCMMOMNT_TextForm);
IWebElement formBttn = PCMMOMNT_TextForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PCMMOMNT_TextForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PCMMOMNT_TextForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault();
if (formBttn!=null && formBttn.Displayed)
{ new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click();
this.ScriptLogger.WriteLine("Button [Form] found and clicked.", Logger.MessageType.INF);
}


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButtonIfExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing VerifyExists on Text_Sequence...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_Text_Sequence = new SeleniumControl( sDriver, "Text_Sequence", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMMOMNT_MOHDRTEXT_DTL_']/ancestor::form[1]/descendant::*[@id='SEQ_NO']");
				Function.AssertEqual(true,PCMMOMNT_Text_Sequence.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing ClickButtonIfExists on TextForm...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_TextForm = new SeleniumControl( sDriver, "TextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMMOMNT_MOHDRTEXT_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCMMOMNT_TextForm);
IWebElement formBttn = PCMMOMNT_TextForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? PCMMOMNT_TextForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
PCMMOMNT_TextForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault();
if (formBttn!=null && formBttn.Displayed)
{ new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click();
this.ScriptLogger.WriteLine("Button [Table] found and clicked.", Logger.MessageType.INF);
}


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButtonIfExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing VerifyExist on TextTable...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_TextTable = new SeleniumControl( sDriver, "TextTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMMOMNT_MOHDRTEXT_DTL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PCMMOMNT_TextTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing Close on TextForm...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_TextForm = new SeleniumControl( sDriver, "TextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMMOMNT_MOHDRTEXT_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCMMOMNT_TextForm);
IWebElement formBttn = PCMMOMNT_TextForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Check Documents");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing VerifyExists on DocumentsLink...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_DocumentsLink = new SeleniumControl( sDriver, "DocumentsLink", "ID", "lnk_4778_PCMMOMNT_MOHDR_HDR");
				Function.AssertEqual(true,PCMMOMNT_DocumentsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing Click on DocumentsLink...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_DocumentsLink = new SeleniumControl( sDriver, "DocumentsLink", "ID", "lnk_4778_PCMMOMNT_MOHDR_HDR");
				Function.WaitControlDisplayed(PCMMOMNT_DocumentsLink);
PCMMOMNT_DocumentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing VerifyExists on DocumentsForm...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_DocumentsForm = new SeleniumControl( sDriver, "DocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PC_MODOCUMENT_']/ancestor::form[1]");
				Function.AssertEqual(true,PCMMOMNT_DocumentsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing VerifyExist on DocumentsTable...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_DocumentsTable = new SeleniumControl( sDriver, "DocumentsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PC_MODOCUMENT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PCMMOMNT_DocumentsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing ClickButtonIfExists on DocumentsForm...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_DocumentsForm = new SeleniumControl( sDriver, "DocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PC_MODOCUMENT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCMMOMNT_DocumentsForm);
IWebElement formBttn = PCMMOMNT_DocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PCMMOMNT_DocumentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PCMMOMNT_DocumentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault();
if (formBttn!=null && formBttn.Displayed)
{ new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click();
this.ScriptLogger.WriteLine("Button [Form] found and clicked.", Logger.MessageType.INF);
}


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButtonIfExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing VerifyExists on Documents_Document...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_Documents_Document = new SeleniumControl( sDriver, "Documents_Document", "xpath", "//div[translate(@id,'0123456789','')='pr__PC_MODOCUMENT_']/ancestor::form[1]/descendant::*[@id='DOCUMENT_ID']");
				Function.AssertEqual(true,PCMMOMNT_Documents_Document.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing ClickButtonIfExists on DocumentsForm...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_DocumentsForm = new SeleniumControl( sDriver, "DocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PC_MODOCUMENT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCMMOMNT_DocumentsForm);
IWebElement formBttn = PCMMOMNT_DocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? PCMMOMNT_DocumentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
PCMMOMNT_DocumentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault();
if (formBttn!=null && formBttn.Displayed)
{ new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click();
this.ScriptLogger.WriteLine("Button [Table] found and clicked.", Logger.MessageType.INF);
}


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButtonIfExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing VerifyExist on DocumentsTable...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_DocumentsTable = new SeleniumControl( sDriver, "DocumentsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PC_MODOCUMENT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PCMMOMNT_DocumentsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing Close on DocumentsForm...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_DocumentsForm = new SeleniumControl( sDriver, "DocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PC_MODOCUMENT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCMMOMNT_DocumentsForm);
IWebElement formBttn = PCMMOMNT_DocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Check serial lot");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing VerifyExists on SerialLotLink...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_SerialLotLink = new SeleniumControl( sDriver, "SerialLotLink", "ID", "lnk_4164_PCMMOMNT_MOHDR_HDR");
				Function.AssertEqual(true,PCMMOMNT_SerialLotLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing Click on SerialLotLink...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_SerialLotLink = new SeleniumControl( sDriver, "SerialLotLink", "ID", "lnk_4164_PCMMOMNT_MOHDR_HDR");
				Function.WaitControlDisplayed(PCMMOMNT_SerialLotLink);
PCMMOMNT_SerialLotLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing VerifyExists on SerialLotForm...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_SerialLotForm = new SeleniumControl( sDriver, "SerialLotForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMMOMNT_SERIALLOT_DTL_']/ancestor::form[1]");
				Function.AssertEqual(true,PCMMOMNT_SerialLotForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing VerifyExist on SerialLotTable...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_SerialLotTable = new SeleniumControl( sDriver, "SerialLotTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMMOMNT_SERIALLOT_DTL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PCMMOMNT_SerialLotTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing ClickButtonIfExists on SerialLotForm...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_SerialLotForm = new SeleniumControl( sDriver, "SerialLotForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMMOMNT_SERIALLOT_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCMMOMNT_SerialLotForm);
IWebElement formBttn = PCMMOMNT_SerialLotForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PCMMOMNT_SerialLotForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PCMMOMNT_SerialLotForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault();
if (formBttn!=null && formBttn.Displayed)
{ new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click();
this.ScriptLogger.WriteLine("Button [Form] found and clicked.", Logger.MessageType.INF);
}


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButtonIfExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing VerifyExists on SerialLot_BasicInformation_Serial...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_SerialLot_BasicInformation_Serial = new SeleniumControl( sDriver, "SerialLot_BasicInformation_Serial", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMMOMNT_SERIALLOT_DTL_']/ancestor::form[1]/descendant::*[@id='SERIAL_ID']");
				Function.AssertEqual(true,PCMMOMNT_SerialLot_BasicInformation_Serial.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing ClickButtonIfExists on SerialLotForm...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_SerialLotForm = new SeleniumControl( sDriver, "SerialLotForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMMOMNT_SERIALLOT_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCMMOMNT_SerialLotForm);
IWebElement formBttn = PCMMOMNT_SerialLotForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? PCMMOMNT_SerialLotForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
PCMMOMNT_SerialLotForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault();
if (formBttn!=null && formBttn.Displayed)
{ new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click();
this.ScriptLogger.WriteLine("Button [Table] found and clicked.", Logger.MessageType.INF);
}


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButtonIfExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing VerifyExist on SerialLotTable...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_SerialLotTable = new SeleniumControl( sDriver, "SerialLotTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMMOMNT_SERIALLOT_DTL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PCMMOMNT_SerialLotTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing Close on SerialLotForm...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_SerialLotForm = new SeleniumControl( sDriver, "SerialLotForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMMOMNT_SERIALLOT_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCMMOMNT_SerialLotForm);
IWebElement formBttn = PCMMOMNT_SerialLotForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Check part documents");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing VerifyExists on PartDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_PartDocumentsLink = new SeleniumControl( sDriver, "PartDocumentsLink", "ID", "lnk_4166_PCMMOMNT_MOHDR_HDR");
				Function.AssertEqual(true,PCMMOMNT_PartDocumentsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing Click on PartDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_PartDocumentsLink = new SeleniumControl( sDriver, "PartDocumentsLink", "ID", "lnk_4166_PCMMOMNT_MOHDR_HDR");
				Function.WaitControlDisplayed(PCMMOMNT_PartDocumentsLink);
PCMMOMNT_PartDocumentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing VerifyExists on PartDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_PartDocumentsForm = new SeleniumControl( sDriver, "PartDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]");
				Function.AssertEqual(true,PCMMOMNT_PartDocumentsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing VerifyExist on PartDocumentsTable...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_PartDocumentsTable = new SeleniumControl( sDriver, "PartDocumentsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PCMMOMNT_PartDocumentsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing ClickButtonIfExists on PartDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_PartDocumentsForm = new SeleniumControl( sDriver, "PartDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCMMOMNT_PartDocumentsForm);
IWebElement formBttn = PCMMOMNT_PartDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PCMMOMNT_PartDocumentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PCMMOMNT_PartDocumentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault();
if (formBttn!=null && formBttn.Displayed)
{ new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click();
this.ScriptLogger.WriteLine("Button [Form] found and clicked.", Logger.MessageType.INF);
}


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButtonIfExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing VerifyExists on PartDocuments_Type...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_PartDocuments_Type = new SeleniumControl( sDriver, "PartDocuments_Type", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]/descendant::*[@id='DOC_TYPE_CD']");
				Function.AssertEqual(true,PCMMOMNT_PartDocuments_Type.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing ClickButtonIfExists on PartDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_PartDocumentsForm = new SeleniumControl( sDriver, "PartDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCMMOMNT_PartDocumentsForm);
IWebElement formBttn = PCMMOMNT_PartDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? PCMMOMNT_PartDocumentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
PCMMOMNT_PartDocumentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault();
if (formBttn!=null && formBttn.Displayed)
{ new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click();
this.ScriptLogger.WriteLine("Button [Table] found and clicked.", Logger.MessageType.INF);
}


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButtonIfExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing VerifyExist on PartDocumentsTable...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_PartDocumentsTable = new SeleniumControl( sDriver, "PartDocumentsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PCMMOMNT_PartDocumentsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing Close on PartDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_PartDocumentsForm = new SeleniumControl( sDriver, "PartDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCMMOMNT_PartDocumentsForm);
IWebElement formBttn = PCMMOMNT_PartDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Check Costs");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing VerifyExists on CostLink...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_CostLink = new SeleniumControl( sDriver, "CostLink", "ID", "lnk_4292_PCMMOMNT_MOHDR_HDR");
				Function.AssertEqual(true,PCMMOMNT_CostLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing Click on CostLink...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_CostLink = new SeleniumControl( sDriver, "CostLink", "ID", "lnk_4292_PCMMOMNT_MOHDR_HDR");
				Function.WaitControlDisplayed(PCMMOMNT_CostLink);
PCMMOMNT_CostLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing VerifyExists on CostForm...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_CostForm = new SeleniumControl( sDriver, "CostForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCM_COSTINFO_']/ancestor::form[1]");
				Function.AssertEqual(true,PCMMOMNT_CostForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing VerifyExists on Cost_MOTotalCosts_Direct_Material...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_Cost_MOTotalCosts_Direct_Material = new SeleniumControl( sDriver, "Cost_MOTotalCosts_Direct_Material", "xpath", "//div[translate(@id,'0123456789','')='pr__PCM_COSTINFO_']/ancestor::form[1]/descendant::*[@id='TOT_MATL_CST']");
				Function.AssertEqual(true,PCMMOMNT_Cost_MOTotalCosts_Direct_Material.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing VerifyExists on Cost_MOTotalCosts_Direct_labor...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_Cost_MOTotalCosts_Direct_labor = new SeleniumControl( sDriver, "Cost_MOTotalCosts_Direct_labor", "xpath", "//div[translate(@id,'0123456789','')='pr__PCM_COSTINFO_']/ancestor::form[1]/descendant::*[@id='TOT_LAB_CST']");
				Function.AssertEqual(true,PCMMOMNT_Cost_MOTotalCosts_Direct_labor.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing VerifyExists on Cost_MOTotalCosts_Direct_Subcontract...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_Cost_MOTotalCosts_Direct_Subcontract = new SeleniumControl( sDriver, "Cost_MOTotalCosts_Direct_Subcontract", "xpath", "//div[translate(@id,'0123456789','')='pr__PCM_COSTINFO_']/ancestor::form[1]/descendant::*[@id='TOT_SUBCT_CST']");
				Function.AssertEqual(true,PCMMOMNT_Cost_MOTotalCosts_Direct_Subcontract.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing VerifyExists on Cost_MOTotalCosts_Direct_Misc1...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_Cost_MOTotalCosts_Direct_Misc1 = new SeleniumControl( sDriver, "Cost_MOTotalCosts_Direct_Misc1", "xpath", "//div[translate(@id,'0123456789','')='pr__PCM_COSTINFO_']/ancestor::form[1]/descendant::*[@id='TOT_MISC1_CST']");
				Function.AssertEqual(true,PCMMOMNT_Cost_MOTotalCosts_Direct_Misc1.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing VerifyExists on Cost_MOTotalCosts_Direct_Misc2...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_Cost_MOTotalCosts_Direct_Misc2 = new SeleniumControl( sDriver, "Cost_MOTotalCosts_Direct_Misc2", "xpath", "//div[translate(@id,'0123456789','')='pr__PCM_COSTINFO_']/ancestor::form[1]/descendant::*[@id='TOT_MISC2_CST']");
				Function.AssertEqual(true,PCMMOMNT_Cost_MOTotalCosts_Direct_Misc2.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing VerifyExists on Cost_MOTotalCosts_Direct_Total...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_Cost_MOTotalCosts_Direct_Total = new SeleniumControl( sDriver, "Cost_MOTotalCosts_Direct_Total", "xpath", "//div[translate(@id,'0123456789','')='pr__PCM_COSTINFO_']/ancestor::form[1]/descendant::*[@id='TOT_DIRECT_COST']");
				Function.AssertEqual(true,PCMMOMNT_Cost_MOTotalCosts_Direct_Total.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing VerifyExists on Cost_MOTotalCosts_Direct_Hours...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_Cost_MOTotalCosts_Direct_Hours = new SeleniumControl( sDriver, "Cost_MOTotalCosts_Direct_Hours", "xpath", "//div[translate(@id,'0123456789','')='pr__PCM_COSTINFO_']/ancestor::form[1]/descendant::*[@id='TOT_HOURS']");
				Function.AssertEqual(true,PCMMOMNT_Cost_MOTotalCosts_Direct_Hours.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing Close on CostForm...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_CostForm = new SeleniumControl( sDriver, "CostForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCM_COSTINFO_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCMMOMNT_CostForm);
IWebElement formBttn = PCMMOMNT_CostForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Check subcontractor reqs/pos");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing VerifyExists on SubcontractorReqPOsLink...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_SubcontractorReqPOsLink = new SeleniumControl( sDriver, "SubcontractorReqPOsLink", "ID", "lnk_4293_PCMMOMNT_MOHDR_HDR");
				Function.AssertEqual(true,PCMMOMNT_SubcontractorReqPOsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing Click on SubcontractorReqPOsLink...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_SubcontractorReqPOsLink = new SeleniumControl( sDriver, "SubcontractorReqPOsLink", "ID", "lnk_4293_PCMMOMNT_MOHDR_HDR");
				Function.WaitControlDisplayed(PCMMOMNT_SubcontractorReqPOsLink);
PCMMOMNT_SubcontractorReqPOsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing VerifyExists on SubcontractorReqPOsForm...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_SubcontractorReqPOsForm = new SeleniumControl( sDriver, "SubcontractorReqPOsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCM_SUBREQPOS_']/ancestor::form[1]");
				Function.AssertEqual(true,PCMMOMNT_SubcontractorReqPOsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing VerifyExist on SubcontractorReqPOsTable...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_SubcontractorReqPOsTable = new SeleniumControl( sDriver, "SubcontractorReqPOsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PCM_SUBREQPOS_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PCMMOMNT_SubcontractorReqPOsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing ClickButtonIfExists on SubcontractorReqPOsForm...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_SubcontractorReqPOsForm = new SeleniumControl( sDriver, "SubcontractorReqPOsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCM_SUBREQPOS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCMMOMNT_SubcontractorReqPOsForm);
IWebElement formBttn = PCMMOMNT_SubcontractorReqPOsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PCMMOMNT_SubcontractorReqPOsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PCMMOMNT_SubcontractorReqPOsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault();
if (formBttn!=null && formBttn.Displayed)
{ new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click();
this.ScriptLogger.WriteLine("Button [Form] found and clicked.", Logger.MessageType.INF);
}


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButtonIfExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing VerifyExists on SubcontractorReqsPOs_Operation_OperationSequence...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_SubcontractorReqsPOs_Operation_OperationSequence = new SeleniumControl( sDriver, "SubcontractorReqsPOs_Operation_OperationSequence", "xpath", "//div[translate(@id,'0123456789','')='pr__PCM_SUBREQPOS_']/ancestor::form[1]/descendant::*[@id='MO_OPER_SEQ_NO']");
				Function.AssertEqual(true,PCMMOMNT_SubcontractorReqsPOs_Operation_OperationSequence.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing ClickButtonIfExists on SubcontractorReqPOsForm...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_SubcontractorReqPOsForm = new SeleniumControl( sDriver, "SubcontractorReqPOsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCM_SUBREQPOS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCMMOMNT_SubcontractorReqPOsForm);
IWebElement formBttn = PCMMOMNT_SubcontractorReqPOsForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? PCMMOMNT_SubcontractorReqPOsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
PCMMOMNT_SubcontractorReqPOsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault();
if (formBttn!=null && formBttn.Displayed)
{ new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click();
this.ScriptLogger.WriteLine("Button [Table] found and clicked.", Logger.MessageType.INF);
}


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButtonIfExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing VerifyExist on SubcontractorReqPOsTable...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_SubcontractorReqPOsTable = new SeleniumControl( sDriver, "SubcontractorReqPOsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PCM_SUBREQPOS_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PCMMOMNT_SubcontractorReqPOsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing Close on SubcontractorReqPOsForm...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_SubcontractorReqPOsForm = new SeleniumControl( sDriver, "SubcontractorReqPOsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCM_SUBREQPOS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCMMOMNT_SubcontractorReqPOsForm);
IWebElement formBttn = PCMMOMNT_SubcontractorReqPOsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Check Select End Item Configuration");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing VerifyExists on SelectEndItemConfigurationLink...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_SelectEndItemConfigurationLink = new SeleniumControl( sDriver, "SelectEndItemConfigurationLink", "ID", "lnk_4428_PCMMOMNT_MOHDR_HDR");
				Function.AssertEqual(true,PCMMOMNT_SelectEndItemConfigurationLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing Click on SelectEndItemConfigurationLink...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_SelectEndItemConfigurationLink = new SeleniumControl( sDriver, "SelectEndItemConfigurationLink", "ID", "lnk_4428_PCMMOMNT_MOHDR_HDR");
				Function.WaitControlDisplayed(PCMMOMNT_SelectEndItemConfigurationLink);
PCMMOMNT_SelectEndItemConfigurationLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing VerifyExists on SelectEndItemConfigurationForm...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_SelectEndItemConfigurationForm = new SeleniumControl( sDriver, "SelectEndItemConfigurationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MM_ENDPARTCONFIG_LOAD_']/ancestor::form[1]");
				Function.AssertEqual(true,PCMMOMNT_SelectEndItemConfigurationForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing VerifyExist on SelectEndItemConfigurationTable...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_SelectEndItemConfigurationTable = new SeleniumControl( sDriver, "SelectEndItemConfigurationTable", "xpath", "//div[translate(@id,'0123456789','')='pr__MM_ENDPARTCONFIG_LOAD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PCMMOMNT_SelectEndItemConfigurationTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing Close on SelectEndItemConfigurationForm...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_SelectEndItemConfigurationForm = new SeleniumControl( sDriver, "SelectEndItemConfigurationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MM_ENDPARTCONFIG_LOAD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCMMOMNT_SelectEndItemConfigurationForm);
IWebElement formBttn = PCMMOMNT_SelectEndItemConfigurationForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOMNT] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl PCMMOMNT_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PCMMOMNT_MainForm);
IWebElement formBttn = PCMMOMNT_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
Function.ClickOkDialogWithMessage("You have unsaved changes. Select Cancel to go back and save changes or select OK to discard changes and close this application.");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickOkDialogWithMessage]" , ex.Message));
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

