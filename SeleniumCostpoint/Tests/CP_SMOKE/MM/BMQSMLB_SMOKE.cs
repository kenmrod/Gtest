 
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
    public class BMQSMLB_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Bills of Material", "xpath","//div[@class='deptItem'][.='Bills of Material']").Click();
new SeleniumControl(sDriver,"Bills of Material Reports/Inquiries", "xpath","//div[@class='navItem'][.='Bills of Material Reports/Inquiries']").Click();
new SeleniumControl(sDriver,"View Bills of Material", "xpath","//div[@class='navItem'][.='View Bills of Material']").Click();


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
				Function.CurrentComponent = "BMQSMLB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQSMLB] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl BMQSMLB_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,BMQSMLB_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMQSMLB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQSMLB] Performing VerifyExists on Assembly_Part...", Logger.MessageType.INF);
				SeleniumControl BMQSMLB_Assembly_Part = new SeleniumControl( sDriver, "Assembly_Part", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PART_ID']");
				Function.AssertEqual(true,BMQSMLB_Assembly_Part.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("SelectEndItemConfiguration");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMQSMLB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQSMLB] Performing VerifyExists on SelectEndItemConfigurationLink...", Logger.MessageType.INF);
				SeleniumControl BMQSMLB_SelectEndItemConfigurationLink = new SeleniumControl( sDriver, "SelectEndItemConfigurationLink", "ID", "lnk_4674_BMQSMLB_HDR");
				Function.AssertEqual(true,BMQSMLB_SelectEndItemConfigurationLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMQSMLB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQSMLB] Performing Click on SelectEndItemConfigurationLink...", Logger.MessageType.INF);
				SeleniumControl BMQSMLB_SelectEndItemConfigurationLink = new SeleniumControl( sDriver, "SelectEndItemConfigurationLink", "ID", "lnk_4674_BMQSMLB_HDR");
				Function.WaitControlDisplayed(BMQSMLB_SelectEndItemConfigurationLink);
BMQSMLB_SelectEndItemConfigurationLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMQSMLB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQSMLB] Performing VerifyExist on SelectEndItemConfigurationFormTable...", Logger.MessageType.INF);
				SeleniumControl BMQSMLB_SelectEndItemConfigurationFormTable = new SeleniumControl( sDriver, "SelectEndItemConfigurationFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__MM_ENDPARTCONFIG_LOAD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BMQSMLB_SelectEndItemConfigurationFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMQSMLB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQSMLB] Performing VerifyExists on SelectEndItemConfigurationForm...", Logger.MessageType.INF);
				SeleniumControl BMQSMLB_SelectEndItemConfigurationForm = new SeleniumControl( sDriver, "SelectEndItemConfigurationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MM_ENDPARTCONFIG_LOAD_']/ancestor::form[1]");
				Function.AssertEqual(true,BMQSMLB_SelectEndItemConfigurationForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMQSMLB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQSMLB] Performing Close on SelectEndItemConfigurationForm...", Logger.MessageType.INF);
				SeleniumControl BMQSMLB_SelectEndItemConfigurationForm = new SeleniumControl( sDriver, "SelectEndItemConfigurationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MM_ENDPARTCONFIG_LOAD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BMQSMLB_SelectEndItemConfigurationForm);
IWebElement formBttn = BMQSMLB_SelectEndItemConfigurationForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Execute");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMQSMLB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQSMLB] Performing Set on Assembly_Part...", Logger.MessageType.INF);
				SeleniumControl BMQSMLB_Assembly_Part = new SeleniumControl( sDriver, "Assembly_Part", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PART_ID']");
				BMQSMLB_Assembly_Part.Click();
BMQSMLB_Assembly_Part.SendKeys("SOC1-MAKEWMBOM002", true);
Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));
BMQSMLB_Assembly_Part.SendKeys(OpenQA.Selenium.Keys.Shift + OpenQA.Selenium.Keys.Tab);


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
				this.ScriptLogger.WriteLine("ComponentLines");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMQSMLB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQSMLB] Performing VerifyExist on ComponentLinesFormTable...", Logger.MessageType.INF);
				SeleniumControl BMQSMLB_ComponentLinesFormTable = new SeleniumControl( sDriver, "ComponentLinesFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__BMQSMLB_ZBMQSMLBEXPL_DTL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BMQSMLB_ComponentLinesFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMQSMLB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQSMLB] Performing ClickButton on ComponentLinesForm...", Logger.MessageType.INF);
				SeleniumControl BMQSMLB_ComponentLinesForm = new SeleniumControl( sDriver, "ComponentLinesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BMQSMLB_ZBMQSMLBEXPL_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BMQSMLB_ComponentLinesForm);
IWebElement formBttn = BMQSMLB_ComponentLinesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? BMQSMLB_ComponentLinesForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
BMQSMLB_ComponentLinesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMQSMLB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQSMLB] Performing VerifyExists on ComponentLinesForm...", Logger.MessageType.INF);
				SeleniumControl BMQSMLB_ComponentLinesForm = new SeleniumControl( sDriver, "ComponentLinesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BMQSMLB_ZBMQSMLBEXPL_DTL_']/ancestor::form[1]");
				Function.AssertEqual(true,BMQSMLB_ComponentLinesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMQSMLB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQSMLB] Performing VerifyExists on ComponentLines_Level...", Logger.MessageType.INF);
				SeleniumControl BMQSMLB_ComponentLines_Level = new SeleniumControl( sDriver, "ComponentLines_Level", "xpath", "//div[translate(@id,'0123456789','')='pr__BMQSMLB_ZBMQSMLBEXPL_DTL_']/ancestor::form[1]/descendant::*[@id='INDENTED_LVL']");
				Function.AssertEqual(true,BMQSMLB_ComponentLines_Level.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("ComponentLinesTab");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMQSMLB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQSMLB] Performing Select on ComponentLinesTab...", Logger.MessageType.INF);
				SeleniumControl BMQSMLB_ComponentLinesTab = new SeleniumControl( sDriver, "ComponentLinesTab", "xpath", "//div[translate(@id,'0123456789','')='pr__BMQSMLB_ZBMQSMLBEXPL_DTL_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(BMQSMLB_ComponentLinesTab);
IWebElement mTab = BMQSMLB_ComponentLinesTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Component Information").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMQSMLB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQSMLB] Performing VerifyExists on ComponentLines_ComponentInformation_Component_PartStatus...", Logger.MessageType.INF);
				SeleniumControl BMQSMLB_ComponentLines_ComponentInformation_Component_PartStatus = new SeleniumControl( sDriver, "ComponentLines_ComponentInformation_Component_PartStatus", "xpath", "//div[translate(@id,'0123456789','')='pr__BMQSMLB_ZBMQSMLBEXPL_DTL_']/ancestor::form[1]/descendant::*[@id='S_STATUS_DESC']");
				Function.AssertEqual(true,BMQSMLB_ComponentLines_ComponentInformation_Component_PartStatus.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMQSMLB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQSMLB] Performing Select on ComponentLinesTab...", Logger.MessageType.INF);
				SeleniumControl BMQSMLB_ComponentLinesTab = new SeleniumControl( sDriver, "ComponentLinesTab", "xpath", "//div[translate(@id,'0123456789','')='pr__BMQSMLB_ZBMQSMLBEXPL_DTL_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(BMQSMLB_ComponentLinesTab);
IWebElement mTab = BMQSMLB_ComponentLinesTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Planning Details").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMQSMLB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQSMLB] Performing VerifyExists on ComponentLines_PlanningDetails_Backflush_Warehouse...", Logger.MessageType.INF);
				SeleniumControl BMQSMLB_ComponentLines_PlanningDetails_Backflush_Warehouse = new SeleniumControl( sDriver, "ComponentLines_PlanningDetails_Backflush_Warehouse", "xpath", "//div[translate(@id,'0123456789','')='pr__BMQSMLB_ZBMQSMLBEXPL_DTL_']/ancestor::form[1]/descendant::*[@id='BKFLSH_WHSE_ID']");
				Function.AssertEqual(true,BMQSMLB_ComponentLines_PlanningDetails_Backflush_Warehouse.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMQSMLB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQSMLB] Performing Select on ComponentLinesTab...", Logger.MessageType.INF);
				SeleniumControl BMQSMLB_ComponentLinesTab = new SeleniumControl( sDriver, "ComponentLinesTab", "xpath", "//div[translate(@id,'0123456789','')='pr__BMQSMLB_ZBMQSMLBEXPL_DTL_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(BMQSMLB_ComponentLinesTab);
IWebElement mTab = BMQSMLB_ComponentLinesTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Notes").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMQSMLB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQSMLB] Performing VerifyExists on ComponentLines_Notes_ReferenceDesignator...", Logger.MessageType.INF);
				SeleniumControl BMQSMLB_ComponentLines_Notes_ReferenceDesignator = new SeleniumControl( sDriver, "ComponentLines_Notes_ReferenceDesignator", "xpath", "//div[translate(@id,'0123456789','')='pr__BMQSMLB_ZBMQSMLBEXPL_DTL_']/ancestor::form[1]/descendant::*[@id='REF_DESIGNATOR_NT']");
				Function.AssertEqual(true,BMQSMLB_ComponentLines_Notes_ReferenceDesignator.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Assembly Information Link");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMQSMLB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQSMLB] Performing VerifyExists on ComponentLines_AssemblyInformationLink...", Logger.MessageType.INF);
				SeleniumControl BMQSMLB_ComponentLines_AssemblyInformationLink = new SeleniumControl( sDriver, "ComponentLines_AssemblyInformationLink", "ID", "lnk_3958_BMQSMLB_ZBMQSMLBEXPL_DTL");
				Function.AssertEqual(true,BMQSMLB_ComponentLines_AssemblyInformationLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMQSMLB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQSMLB] Performing Click on ComponentLines_AssemblyInformationLink...", Logger.MessageType.INF);
				SeleniumControl BMQSMLB_ComponentLines_AssemblyInformationLink = new SeleniumControl( sDriver, "ComponentLines_AssemblyInformationLink", "ID", "lnk_3958_BMQSMLB_ZBMQSMLBEXPL_DTL");
				Function.WaitControlDisplayed(BMQSMLB_ComponentLines_AssemblyInformationLink);
BMQSMLB_ComponentLines_AssemblyInformationLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMQSMLB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQSMLB] Performing VerifyExists on ComponentLines_AssemblyInformationForm...", Logger.MessageType.INF);
				SeleniumControl BMQSMLB_ComponentLines_AssemblyInformationForm = new SeleniumControl( sDriver, "ComponentLines_AssemblyInformationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BMQSMLB_ASSEMBLY_HDR_']/ancestor::form[1]");
				Function.AssertEqual(true,BMQSMLB_ComponentLines_AssemblyInformationForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMQSMLB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQSMLB] Performing VerifyExists on ComponentLines_AssemblyInformation_Assembly_Part...", Logger.MessageType.INF);
				SeleniumControl BMQSMLB_ComponentLines_AssemblyInformation_Assembly_Part = new SeleniumControl( sDriver, "ComponentLines_AssemblyInformation_Assembly_Part", "xpath", "//div[translate(@id,'0123456789','')='pr__BMQSMLB_ASSEMBLY_HDR_']/ancestor::form[1]/descendant::*[@id='ASY_PART_ID']");
				Function.AssertEqual(true,BMQSMLB_ComponentLines_AssemblyInformation_Assembly_Part.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMQSMLB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQSMLB] Performing Close on ComponentLines_AssemblyInformationForm...", Logger.MessageType.INF);
				SeleniumControl BMQSMLB_ComponentLines_AssemblyInformationForm = new SeleniumControl( sDriver, "ComponentLines_AssemblyInformationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BMQSMLB_ASSEMBLY_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BMQSMLB_ComponentLines_AssemblyInformationForm);
IWebElement formBttn = BMQSMLB_ComponentLines_AssemblyInformationForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Assembly Documents Link");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMQSMLB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQSMLB] Performing VerifyExists on ComponentLines_AssemblyDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl BMQSMLB_ComponentLines_AssemblyDocumentsLink = new SeleniumControl( sDriver, "ComponentLines_AssemblyDocumentsLink", "ID", "lnk_3970_BMQSMLB_ZBMQSMLBEXPL_DTL");
				Function.AssertEqual(true,BMQSMLB_ComponentLines_AssemblyDocumentsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMQSMLB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQSMLB] Performing Click on ComponentLines_AssemblyDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl BMQSMLB_ComponentLines_AssemblyDocumentsLink = new SeleniumControl( sDriver, "ComponentLines_AssemblyDocumentsLink", "ID", "lnk_3970_BMQSMLB_ZBMQSMLBEXPL_DTL");
				Function.WaitControlDisplayed(BMQSMLB_ComponentLines_AssemblyDocumentsLink);
BMQSMLB_ComponentLines_AssemblyDocumentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMQSMLB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQSMLB] Performing VerifyExist on ComponentLines_AssemblyDocumentsFormTable...", Logger.MessageType.INF);
				SeleniumControl BMQSMLB_ComponentLines_AssemblyDocumentsFormTable = new SeleniumControl( sDriver, "ComponentLines_AssemblyDocumentsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__BMQSMLB_ASSEMBLY_PARTDOCUMENT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BMQSMLB_ComponentLines_AssemblyDocumentsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMQSMLB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQSMLB] Performing ClickButton on ComponentLines_AssemblyDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl BMQSMLB_ComponentLines_AssemblyDocumentsForm = new SeleniumControl( sDriver, "ComponentLines_AssemblyDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BMQSMLB_ASSEMBLY_PARTDOCUMENT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BMQSMLB_ComponentLines_AssemblyDocumentsForm);
IWebElement formBttn = BMQSMLB_ComponentLines_AssemblyDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? BMQSMLB_ComponentLines_AssemblyDocumentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
BMQSMLB_ComponentLines_AssemblyDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMQSMLB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQSMLB] Performing VerifyExists on ComponentLines_AssemblyDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl BMQSMLB_ComponentLines_AssemblyDocumentsForm = new SeleniumControl( sDriver, "ComponentLines_AssemblyDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BMQSMLB_ASSEMBLY_PARTDOCUMENT_']/ancestor::form[1]");
				Function.AssertEqual(true,BMQSMLB_ComponentLines_AssemblyDocumentsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMQSMLB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQSMLB] Performing VerifyExists on ComponentLines_AssemblyDocuments_AssyPart...", Logger.MessageType.INF);
				SeleniumControl BMQSMLB_ComponentLines_AssemblyDocuments_AssyPart = new SeleniumControl( sDriver, "ComponentLines_AssemblyDocuments_AssyPart", "xpath", "//div[translate(@id,'0123456789','')='pr__BMQSMLB_ASSEMBLY_PARTDOCUMENT_']/ancestor::form[1]/descendant::*[@id='ASM_PART_ID']");
				Function.AssertEqual(true,BMQSMLB_ComponentLines_AssemblyDocuments_AssyPart.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMQSMLB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQSMLB] Performing Close on ComponentLines_AssemblyDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl BMQSMLB_ComponentLines_AssemblyDocumentsForm = new SeleniumControl( sDriver, "ComponentLines_AssemblyDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BMQSMLB_ASSEMBLY_PARTDOCUMENT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BMQSMLB_ComponentLines_AssemblyDocumentsForm);
IWebElement formBttn = BMQSMLB_ComponentLines_AssemblyDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("component Documents Link");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMQSMLB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQSMLB] Performing VerifyExists on ComponentLines_ComponentDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl BMQSMLB_ComponentLines_ComponentDocumentsLink = new SeleniumControl( sDriver, "ComponentLines_ComponentDocumentsLink", "ID", "lnk_3971_BMQSMLB_ZBMQSMLBEXPL_DTL");
				Function.AssertEqual(true,BMQSMLB_ComponentLines_ComponentDocumentsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMQSMLB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQSMLB] Performing Click on ComponentLines_ComponentDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl BMQSMLB_ComponentLines_ComponentDocumentsLink = new SeleniumControl( sDriver, "ComponentLines_ComponentDocumentsLink", "ID", "lnk_3971_BMQSMLB_ZBMQSMLBEXPL_DTL");
				Function.WaitControlDisplayed(BMQSMLB_ComponentLines_ComponentDocumentsLink);
BMQSMLB_ComponentLines_ComponentDocumentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMQSMLB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQSMLB] Performing VerifyExist on ComponentLines_ComponentDocumentsFormTable...", Logger.MessageType.INF);
				SeleniumControl BMQSMLB_ComponentLines_ComponentDocumentsFormTable = new SeleniumControl( sDriver, "ComponentLines_ComponentDocumentsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__BMQSMLB_COMPONENT_PARTDOCUMENT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BMQSMLB_ComponentLines_ComponentDocumentsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMQSMLB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQSMLB] Performing ClickButton on ComponentLines_ComponentDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl BMQSMLB_ComponentLines_ComponentDocumentsForm = new SeleniumControl( sDriver, "ComponentLines_ComponentDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BMQSMLB_COMPONENT_PARTDOCUMENT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BMQSMLB_ComponentLines_ComponentDocumentsForm);
IWebElement formBttn = BMQSMLB_ComponentLines_ComponentDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? BMQSMLB_ComponentLines_ComponentDocumentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
BMQSMLB_ComponentLines_ComponentDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMQSMLB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQSMLB] Performing VerifyExists on ComponentLines_ComponentDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl BMQSMLB_ComponentLines_ComponentDocumentsForm = new SeleniumControl( sDriver, "ComponentLines_ComponentDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BMQSMLB_COMPONENT_PARTDOCUMENT_']/ancestor::form[1]");
				Function.AssertEqual(true,BMQSMLB_ComponentLines_ComponentDocumentsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMQSMLB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQSMLB] Performing VerifyExists on ComponentLines_ComponentDocuments_Type...", Logger.MessageType.INF);
				SeleniumControl BMQSMLB_ComponentLines_ComponentDocuments_Type = new SeleniumControl( sDriver, "ComponentLines_ComponentDocuments_Type", "xpath", "//div[translate(@id,'0123456789','')='pr__BMQSMLB_COMPONENT_PARTDOCUMENT_']/ancestor::form[1]/descendant::*[@id='DOC_TYPE_CD']");
				Function.AssertEqual(true,BMQSMLB_ComponentLines_ComponentDocuments_Type.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMQSMLB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQSMLB] Performing Close on ComponentLines_ComponentDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl BMQSMLB_ComponentLines_ComponentDocumentsForm = new SeleniumControl( sDriver, "ComponentLines_ComponentDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BMQSMLB_COMPONENT_PARTDOCUMENT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BMQSMLB_ComponentLines_ComponentDocumentsForm);
IWebElement formBttn = BMQSMLB_ComponentLines_ComponentDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Line Text Link");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMQSMLB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQSMLB] Performing ClickButton on ComponentLinesForm...", Logger.MessageType.INF);
				SeleniumControl BMQSMLB_ComponentLinesForm = new SeleniumControl( sDriver, "ComponentLinesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BMQSMLB_ZBMQSMLBEXPL_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BMQSMLB_ComponentLinesForm);
IWebElement formBttn = BMQSMLB_ComponentLinesForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? BMQSMLB_ComponentLinesForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
BMQSMLB_ComponentLinesForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMQSMLB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQSMLB] Performing VerifyExists on ComponentLines_LineTextLink...", Logger.MessageType.INF);
				SeleniumControl BMQSMLB_ComponentLines_LineTextLink = new SeleniumControl( sDriver, "ComponentLines_LineTextLink", "ID", "lnk_3972_BMQSMLB_ZBMQSMLBEXPL_DTL");
				Function.AssertEqual(true,BMQSMLB_ComponentLines_LineTextLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMQSMLB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQSMLB] Performing Click on ComponentLines_LineTextLink...", Logger.MessageType.INF);
				SeleniumControl BMQSMLB_ComponentLines_LineTextLink = new SeleniumControl( sDriver, "ComponentLines_LineTextLink", "ID", "lnk_3972_BMQSMLB_ZBMQSMLBEXPL_DTL");
				Function.WaitControlDisplayed(BMQSMLB_ComponentLines_LineTextLink);
BMQSMLB_ComponentLines_LineTextLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMQSMLB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQSMLB] Performing VerifyExist on ComponentLines_LineTextFormTable...", Logger.MessageType.INF);
				SeleniumControl BMQSMLB_ComponentLines_LineTextFormTable = new SeleniumControl( sDriver, "ComponentLines_LineTextFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__BMQSMLB_COMPTEXTCODES_HDR_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BMQSMLB_ComponentLines_LineTextFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMQSMLB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQSMLB] Performing ClickButtonIfExists on ComponentLines_LineTextForm...", Logger.MessageType.INF);
				SeleniumControl BMQSMLB_ComponentLines_LineTextForm = new SeleniumControl( sDriver, "ComponentLines_LineTextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BMQSMLB_COMPTEXTCODES_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BMQSMLB_ComponentLines_LineTextForm);
IWebElement formBttn = BMQSMLB_ComponentLines_LineTextForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? BMQSMLB_ComponentLines_LineTextForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
BMQSMLB_ComponentLines_LineTextForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault();
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
				Function.CurrentComponent = "BMQSMLB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQSMLB] Performing VerifyExists on ComponentLines_LineTextForm...", Logger.MessageType.INF);
				SeleniumControl BMQSMLB_ComponentLines_LineTextForm = new SeleniumControl( sDriver, "ComponentLines_LineTextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BMQSMLB_COMPTEXTCODES_HDR_']/ancestor::form[1]");
				Function.AssertEqual(true,BMQSMLB_ComponentLines_LineTextForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMQSMLB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQSMLB] Performing VerifyExists on ComponentLines_LineText_Sequence...", Logger.MessageType.INF);
				SeleniumControl BMQSMLB_ComponentLines_LineText_Sequence = new SeleniumControl( sDriver, "ComponentLines_LineText_Sequence", "xpath", "//div[translate(@id,'0123456789','')='pr__BMQSMLB_COMPTEXTCODES_HDR_']/ancestor::form[1]/descendant::*[@id='SEQ_NO']");
				Function.AssertEqual(true,BMQSMLB_ComponentLines_LineText_Sequence.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMQSMLB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQSMLB] Performing Close on ComponentLines_LineTextForm...", Logger.MessageType.INF);
				SeleniumControl BMQSMLB_ComponentLines_LineTextForm = new SeleniumControl( sDriver, "ComponentLines_LineTextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BMQSMLB_COMPTEXTCODES_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BMQSMLB_ComponentLines_LineTextForm);
IWebElement formBttn = BMQSMLB_ComponentLines_LineTextForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Component Alternate Parts Link");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMQSMLB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQSMLB] Performing VerifyExists on ComponentLines_ComponentAlternatePartsLink...", Logger.MessageType.INF);
				SeleniumControl BMQSMLB_ComponentLines_ComponentAlternatePartsLink = new SeleniumControl( sDriver, "ComponentLines_ComponentAlternatePartsLink", "ID", "lnk_3973_BMQSMLB_ZBMQSMLBEXPL_DTL");
				Function.AssertEqual(true,BMQSMLB_ComponentLines_ComponentAlternatePartsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMQSMLB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQSMLB] Performing Click on ComponentLines_ComponentAlternatePartsLink...", Logger.MessageType.INF);
				SeleniumControl BMQSMLB_ComponentLines_ComponentAlternatePartsLink = new SeleniumControl( sDriver, "ComponentLines_ComponentAlternatePartsLink", "ID", "lnk_3973_BMQSMLB_ZBMQSMLBEXPL_DTL");
				Function.WaitControlDisplayed(BMQSMLB_ComponentLines_ComponentAlternatePartsLink);
BMQSMLB_ComponentLines_ComponentAlternatePartsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMQSMLB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQSMLB] Performing VerifyExist on ComponentLines_ComponentAlternatePartsFormTable...", Logger.MessageType.INF);
				SeleniumControl BMQSMLB_ComponentLines_ComponentAlternatePartsFormTable = new SeleniumControl( sDriver, "ComponentLines_ComponentAlternatePartsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__BMQSMLB_ALTERNATEPARTS_DTL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BMQSMLB_ComponentLines_ComponentAlternatePartsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMQSMLB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQSMLB] Performing ClickButton on ComponentLines_ComponentAlternatePartsForm...", Logger.MessageType.INF);
				SeleniumControl BMQSMLB_ComponentLines_ComponentAlternatePartsForm = new SeleniumControl( sDriver, "ComponentLines_ComponentAlternatePartsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BMQSMLB_ALTERNATEPARTS_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BMQSMLB_ComponentLines_ComponentAlternatePartsForm);
IWebElement formBttn = BMQSMLB_ComponentLines_ComponentAlternatePartsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? BMQSMLB_ComponentLines_ComponentAlternatePartsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
BMQSMLB_ComponentLines_ComponentAlternatePartsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMQSMLB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQSMLB] Performing VerifyExists on ComponentLines_ComponentAlternatePartsForm...", Logger.MessageType.INF);
				SeleniumControl BMQSMLB_ComponentLines_ComponentAlternatePartsForm = new SeleniumControl( sDriver, "ComponentLines_ComponentAlternatePartsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BMQSMLB_ALTERNATEPARTS_DTL_']/ancestor::form[1]");
				Function.AssertEqual(true,BMQSMLB_ComponentLines_ComponentAlternatePartsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMQSMLB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQSMLB] Performing VerifyExists on ComponentLines_ComponentAlternateParts_Sequence...", Logger.MessageType.INF);
				SeleniumControl BMQSMLB_ComponentLines_ComponentAlternateParts_Sequence = new SeleniumControl( sDriver, "ComponentLines_ComponentAlternateParts_Sequence", "xpath", "//div[translate(@id,'0123456789','')='pr__BMQSMLB_ALTERNATEPARTS_DTL_']/ancestor::form[1]/descendant::*[@id='SEQ_NO']");
				Function.AssertEqual(true,BMQSMLB_ComponentLines_ComponentAlternateParts_Sequence.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMQSMLB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQSMLB] Performing Close on ComponentLines_ComponentAlternatePartsForm...", Logger.MessageType.INF);
				SeleniumControl BMQSMLB_ComponentLines_ComponentAlternatePartsForm = new SeleniumControl( sDriver, "ComponentLines_ComponentAlternatePartsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BMQSMLB_ALTERNATEPARTS_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BMQSMLB_ComponentLines_ComponentAlternatePartsForm);
IWebElement formBttn = BMQSMLB_ComponentLines_ComponentAlternatePartsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Component Substitute Parts Link");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMQSMLB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQSMLB] Performing VerifyExists on ComponentLines_ComponentSubstitutePartsLink...", Logger.MessageType.INF);
				SeleniumControl BMQSMLB_ComponentLines_ComponentSubstitutePartsLink = new SeleniumControl( sDriver, "ComponentLines_ComponentSubstitutePartsLink", "ID", "lnk_3974_BMQSMLB_ZBMQSMLBEXPL_DTL");
				Function.AssertEqual(true,BMQSMLB_ComponentLines_ComponentSubstitutePartsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMQSMLB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQSMLB] Performing Click on ComponentLines_ComponentSubstitutePartsLink...", Logger.MessageType.INF);
				SeleniumControl BMQSMLB_ComponentLines_ComponentSubstitutePartsLink = new SeleniumControl( sDriver, "ComponentLines_ComponentSubstitutePartsLink", "ID", "lnk_3974_BMQSMLB_ZBMQSMLBEXPL_DTL");
				Function.WaitControlDisplayed(BMQSMLB_ComponentLines_ComponentSubstitutePartsLink);
BMQSMLB_ComponentLines_ComponentSubstitutePartsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMQSMLB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQSMLB] Performing VerifyExist on ComponentLines_ComponentSubstitutePartsFormTable...", Logger.MessageType.INF);
				SeleniumControl BMQSMLB_ComponentLines_ComponentSubstitutePartsFormTable = new SeleniumControl( sDriver, "ComponentLines_ComponentSubstitutePartsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__BMQSMLB_SUBSTITUTEPART_DTL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BMQSMLB_ComponentLines_ComponentSubstitutePartsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMQSMLB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQSMLB] Performing ClickButton on ComponentLines_ComponentSubstitutePartsForm...", Logger.MessageType.INF);
				SeleniumControl BMQSMLB_ComponentLines_ComponentSubstitutePartsForm = new SeleniumControl( sDriver, "ComponentLines_ComponentSubstitutePartsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BMQSMLB_SUBSTITUTEPART_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BMQSMLB_ComponentLines_ComponentSubstitutePartsForm);
IWebElement formBttn = BMQSMLB_ComponentLines_ComponentSubstitutePartsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? BMQSMLB_ComponentLines_ComponentSubstitutePartsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
BMQSMLB_ComponentLines_ComponentSubstitutePartsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMQSMLB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQSMLB] Performing VerifyExists on ComponentLines_ComponentSubstitutePartsForm...", Logger.MessageType.INF);
				SeleniumControl BMQSMLB_ComponentLines_ComponentSubstitutePartsForm = new SeleniumControl( sDriver, "ComponentLines_ComponentSubstitutePartsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BMQSMLB_SUBSTITUTEPART_DTL_']/ancestor::form[1]");
				Function.AssertEqual(true,BMQSMLB_ComponentLines_ComponentSubstitutePartsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMQSMLB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQSMLB] Performing VerifyExists on ComponentLines_ComponentSubstituteParts_Sequence...", Logger.MessageType.INF);
				SeleniumControl BMQSMLB_ComponentLines_ComponentSubstituteParts_Sequence = new SeleniumControl( sDriver, "ComponentLines_ComponentSubstituteParts_Sequence", "xpath", "//div[translate(@id,'0123456789','')='pr__BMQSMLB_SUBSTITUTEPART_DTL_']/ancestor::form[1]/descendant::*[@id='USAGE_SEQ_NO']");
				Function.AssertEqual(true,BMQSMLB_ComponentLines_ComponentSubstituteParts_Sequence.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMQSMLB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQSMLB] Performing Close on ComponentLines_ComponentSubstitutePartsForm...", Logger.MessageType.INF);
				SeleniumControl BMQSMLB_ComponentLines_ComponentSubstitutePartsForm = new SeleniumControl( sDriver, "ComponentLines_ComponentSubstitutePartsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BMQSMLB_SUBSTITUTEPART_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BMQSMLB_ComponentLines_ComponentSubstitutePartsForm);
IWebElement formBttn = BMQSMLB_ComponentLines_ComponentSubstitutePartsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "BMQSMLB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQSMLB] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl BMQSMLB_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(BMQSMLB_MainForm);
IWebElement formBttn = BMQSMLB_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

