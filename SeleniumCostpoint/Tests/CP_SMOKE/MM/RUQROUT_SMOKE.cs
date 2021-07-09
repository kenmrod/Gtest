 
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
    public class RUQROUT_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Routings", "xpath","//div[@class='deptItem'][.='Routings']").Click();
new SeleniumControl(sDriver,"Routings Reports/Inquiries", "xpath","//div[@class='navItem'][.='Routings Reports/Inquiries']").Click();
new SeleniumControl(sDriver,"View Routings", "xpath","//div[@class='navItem'][.='View Routings']").Click();


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
				Function.CurrentComponent = "RUQROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUQROUT] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl RUQROUT_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,RUQROUT_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUQROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUQROUT] Performing VerifyExists on Part...", Logger.MessageType.INF);
				SeleniumControl RUQROUT_Part = new SeleniumControl( sDriver, "Part", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PART_ID']");
				Function.AssertEqual(true,RUQROUT_Part.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
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
				this.ScriptLogger.WriteLine("Select End Item Conf.");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUQROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUQROUT] Performing Click on SelectEndItemConfigurationLink...", Logger.MessageType.INF);
				SeleniumControl RUQROUT_SelectEndItemConfigurationLink = new SeleniumControl( sDriver, "SelectEndItemConfigurationLink", "ID", "lnk_4685_RUQROUT_HDR");
				Function.WaitControlDisplayed(RUQROUT_SelectEndItemConfigurationLink);
RUQROUT_SelectEndItemConfigurationLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUQROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUQROUT] Performing VerifyExists on SelectEndItemConfigurationForm...", Logger.MessageType.INF);
				SeleniumControl RUQROUT_SelectEndItemConfigurationForm = new SeleniumControl( sDriver, "SelectEndItemConfigurationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MM_ENDPARTCONFIG_LOAD_']/ancestor::form[1]");
				Function.AssertEqual(true,RUQROUT_SelectEndItemConfigurationForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUQROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUQROUT] Performing VerifyExist on SelectEndItemConfigurationFormTable...", Logger.MessageType.INF);
				SeleniumControl RUQROUT_SelectEndItemConfigurationFormTable = new SeleniumControl( sDriver, "SelectEndItemConfigurationFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__MM_ENDPARTCONFIG_LOAD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,RUQROUT_SelectEndItemConfigurationFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUQROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUQROUT] Performing Close on SelectEndItemConfigurationForm...", Logger.MessageType.INF);
				SeleniumControl RUQROUT_SelectEndItemConfigurationForm = new SeleniumControl( sDriver, "SelectEndItemConfigurationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MM_ENDPARTCONFIG_LOAD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(RUQROUT_SelectEndItemConfigurationForm);
IWebElement formBttn = RUQROUT_SelectEndItemConfigurationForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Routing Details");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUQROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUQROUT] Performing VerifyExists on RoutingDetailsForm...", Logger.MessageType.INF);
				SeleniumControl RUQROUT_RoutingDetailsForm = new SeleniumControl( sDriver, "RoutingDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__RUQROUT_ROUTINGHDR_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,RUQROUT_RoutingDetailsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUQROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUQROUT] Performing VerifyExist on RoutingDetailsFormTable...", Logger.MessageType.INF);
				SeleniumControl RUQROUT_RoutingDetailsFormTable = new SeleniumControl( sDriver, "RoutingDetailsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__RUQROUT_ROUTINGHDR_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,RUQROUT_RoutingDetailsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUQROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUQROUT] Performing ClickButton on RoutingDetailsForm...", Logger.MessageType.INF);
				SeleniumControl RUQROUT_RoutingDetailsForm = new SeleniumControl( sDriver, "RoutingDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__RUQROUT_ROUTINGHDR_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(RUQROUT_RoutingDetailsForm);
IWebElement formBttn = RUQROUT_RoutingDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? RUQROUT_RoutingDetailsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
RUQROUT_RoutingDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUQROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUQROUT] Performing VerifyExists on RoutingDetails_Company...", Logger.MessageType.INF);
				SeleniumControl RUQROUT_RoutingDetails_Company = new SeleniumControl( sDriver, "RoutingDetails_Company", "xpath", "//div[translate(@id,'0123456789','')='pr__RUQROUT_ROUTINGHDR_CTW_']/ancestor::form[1]/descendant::*[@id='COMPANY_ID']");
				Function.AssertEqual(true,RUQROUT_RoutingDetails_Company.Exists());

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
				Function.CurrentComponent = "RUQROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUQROUT] Performing Click on RoutingDetails_RoutingLinesLink...", Logger.MessageType.INF);
				SeleniumControl RUQROUT_RoutingDetails_RoutingLinesLink = new SeleniumControl( sDriver, "RoutingDetails_RoutingLinesLink", "ID", "lnk_4465_RUQROUT_ROUTINGHDR_CTW");
				Function.WaitControlDisplayed(RUQROUT_RoutingDetails_RoutingLinesLink);
RUQROUT_RoutingDetails_RoutingLinesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUQROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUQROUT] Performing VerifyExists on RoutingDetails_RoutingLinesForm...", Logger.MessageType.INF);
				SeleniumControl RUQROUT_RoutingDetails_RoutingLinesForm = new SeleniumControl( sDriver, "RoutingDetails_RoutingLinesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__RUQROUT_ROUTINGLN_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,RUQROUT_RoutingDetails_RoutingLinesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUQROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUQROUT] Performing VerifyExist on RoutingDetails_RoutingLinesFormTable...", Logger.MessageType.INF);
				SeleniumControl RUQROUT_RoutingDetails_RoutingLinesFormTable = new SeleniumControl( sDriver, "RoutingDetails_RoutingLinesFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__RUQROUT_ROUTINGLN_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,RUQROUT_RoutingDetails_RoutingLinesFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUQROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUQROUT] Performing ClickButton on RoutingDetails_RoutingLinesForm...", Logger.MessageType.INF);
				SeleniumControl RUQROUT_RoutingDetails_RoutingLinesForm = new SeleniumControl( sDriver, "RoutingDetails_RoutingLinesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__RUQROUT_ROUTINGLN_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(RUQROUT_RoutingDetails_RoutingLinesForm);
IWebElement formBttn = RUQROUT_RoutingDetails_RoutingLinesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? RUQROUT_RoutingDetails_RoutingLinesForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
RUQROUT_RoutingDetails_RoutingLinesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUQROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUQROUT] Performing VerifyExists on RoutingDetails_RoutingLines_OperationSequence...", Logger.MessageType.INF);
				SeleniumControl RUQROUT_RoutingDetails_RoutingLines_OperationSequence = new SeleniumControl( sDriver, "RoutingDetails_RoutingLines_OperationSequence", "xpath", "//div[translate(@id,'0123456789','')='pr__RUQROUT_ROUTINGLN_CTW_']/ancestor::form[1]/descendant::*[@id='ROUT_OPER_SEQ_NO']");
				Function.AssertEqual(true,RUQROUT_RoutingDetails_RoutingLines_OperationSequence.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUQROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUQROUT] Performing VerifyExists on RoutingDetails_RoutingLines_Operation_RunType...", Logger.MessageType.INF);
				SeleniumControl RUQROUT_RoutingDetails_RoutingLines_Operation_RunType = new SeleniumControl( sDriver, "RoutingDetails_RoutingLines_Operation_RunType", "xpath", "//div[translate(@id,'0123456789','')='pr__RUQROUT_ROUTINGLN_CTW_']/ancestor::form[1]/descendant::*[@id='S_RUN_TYPE']");
				Function.AssertEqual(true,RUQROUT_RoutingDetails_RoutingLines_Operation_RunType.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUQROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUQROUT] Performing Select on RoutingDetails_RoutingLinesTab...", Logger.MessageType.INF);
				SeleniumControl RUQROUT_RoutingDetails_RoutingLinesTab = new SeleniumControl( sDriver, "RoutingDetails_RoutingLinesTab", "xpath", "//div[translate(@id,'0123456789','')='pr__RUQROUT_ROUTINGLN_CTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(RUQROUT_RoutingDetails_RoutingLinesTab);
IWebElement mTab = RUQROUT_RoutingDetails_RoutingLinesTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Lead Time/Capacity").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUQROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUQROUT] Performing VerifyExists on RoutingDetails_RoutingLines_LeadTimeCapacity_KeyResource_FixedUsage...", Logger.MessageType.INF);
				SeleniumControl RUQROUT_RoutingDetails_RoutingLines_LeadTimeCapacity_KeyResource_FixedUsage = new SeleniumControl( sDriver, "RoutingDetails_RoutingLines_LeadTimeCapacity_KeyResource_FixedUsage", "xpath", "//div[translate(@id,'0123456789','')='pr__RUQROUT_ROUTINGLN_CTW_']/ancestor::form[1]/descendant::*[@id='KEY_RSRCE_FIXD_QTY']");
				Function.AssertEqual(true,RUQROUT_RoutingDetails_RoutingLines_LeadTimeCapacity_KeyResource_FixedUsage.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUQROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUQROUT] Performing Select on RoutingDetails_RoutingLinesTab...", Logger.MessageType.INF);
				SeleniumControl RUQROUT_RoutingDetails_RoutingLinesTab = new SeleniumControl( sDriver, "RoutingDetails_RoutingLinesTab", "xpath", "//div[translate(@id,'0123456789','')='pr__RUQROUT_ROUTINGLN_CTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(RUQROUT_RoutingDetails_RoutingLinesTab);
IWebElement mTab = RUQROUT_RoutingDetails_RoutingLinesTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Cost").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUQROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUQROUT] Performing VerifyExists on RoutingDetails_RoutingLines_Cost_CostsRates_CurrentOperation_BurdenRate...", Logger.MessageType.INF);
				SeleniumControl RUQROUT_RoutingDetails_RoutingLines_Cost_CostsRates_CurrentOperation_BurdenRate = new SeleniumControl( sDriver, "RoutingDetails_RoutingLines_Cost_CostsRates_CurrentOperation_BurdenRate", "xpath", "//div[translate(@id,'0123456789','')='pr__RUQROUT_ROUTINGLN_CTW_']/ancestor::form[1]/descendant::*[@id='OP_BURDEN_RT']");
				Function.AssertEqual(true,RUQROUT_RoutingDetails_RoutingLines_Cost_CostsRates_CurrentOperation_BurdenRate.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUQROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUQROUT] Performing Select on RoutingDetails_RoutingLinesTab...", Logger.MessageType.INF);
				SeleniumControl RUQROUT_RoutingDetails_RoutingLinesTab = new SeleniumControl( sDriver, "RoutingDetails_RoutingLinesTab", "xpath", "//div[translate(@id,'0123456789','')='pr__RUQROUT_ROUTINGLN_CTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(RUQROUT_RoutingDetails_RoutingLinesTab);
IWebElement mTab = RUQROUT_RoutingDetails_RoutingLinesTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Additional Information").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUQROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUQROUT] Performing VerifyExists on RoutingDetails_RoutingLines_AdditionalInformation_Organization...", Logger.MessageType.INF);
				SeleniumControl RUQROUT_RoutingDetails_RoutingLines_AdditionalInformation_Organization = new SeleniumControl( sDriver, "RoutingDetails_RoutingLines_AdditionalInformation_Organization", "xpath", "//div[translate(@id,'0123456789','')='pr__RUQROUT_ROUTINGLN_CTW_']/ancestor::form[1]/descendant::*[@id='ORG_ID']");
				Function.AssertEqual(true,RUQROUT_RoutingDetails_RoutingLines_AdditionalInformation_Organization.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Links");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUQROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUQROUT] Performing VerifyExists on RoutingDetails_RoutingLines_LineNotesLink...", Logger.MessageType.INF);
				SeleniumControl RUQROUT_RoutingDetails_RoutingLines_LineNotesLink = new SeleniumControl( sDriver, "RoutingDetails_RoutingLines_LineNotesLink", "ID", "lnk_4556_RUQROUT_ROUTINGLN_CTW");
				Function.AssertEqual(true,RUQROUT_RoutingDetails_RoutingLines_LineNotesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUQROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUQROUT] Performing VerifyExists on RoutingDetails_RoutingLines_KeyResourcesLink...", Logger.MessageType.INF);
				SeleniumControl RUQROUT_RoutingDetails_RoutingLines_KeyResourcesLink = new SeleniumControl( sDriver, "RoutingDetails_RoutingLines_KeyResourcesLink", "ID", "lnk_4576_RUQROUT_ROUTINGLN_CTW");
				Function.AssertEqual(true,RUQROUT_RoutingDetails_RoutingLines_KeyResourcesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUQROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUQROUT] Performing VerifyExists on RoutingDetails_RoutingLines_LaborOperationRatesLink...", Logger.MessageType.INF);
				SeleniumControl RUQROUT_RoutingDetails_RoutingLines_LaborOperationRatesLink = new SeleniumControl( sDriver, "RoutingDetails_RoutingLines_LaborOperationRatesLink", "ID", "lnk_4525_RUQROUT_ROUTINGLN_CTW");
				Function.AssertEqual(true,RUQROUT_RoutingDetails_RoutingLines_LaborOperationRatesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUQROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUQROUT] Performing VerifyExists on RoutingDetails_RoutingLines_SubcontractorOperationsLink...", Logger.MessageType.INF);
				SeleniumControl RUQROUT_RoutingDetails_RoutingLines_SubcontractorOperationsLink = new SeleniumControl( sDriver, "RoutingDetails_RoutingLines_SubcontractorOperationsLink", "ID", "lnk_4526_RUQROUT_ROUTINGLN_CTW");
				Function.AssertEqual(true,RUQROUT_RoutingDetails_RoutingLines_SubcontractorOperationsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUQROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUQROUT] Performing VerifyExists on RoutingDetails_RoutingLines_StandardTextLink...", Logger.MessageType.INF);
				SeleniumControl RUQROUT_RoutingDetails_RoutingLines_StandardTextLink = new SeleniumControl( sDriver, "RoutingDetails_RoutingLines_StandardTextLink", "ID", "lnk_4481_RUQROUT_ROUTINGLN_CTW");
				Function.AssertEqual(true,RUQROUT_RoutingDetails_RoutingLines_StandardTextLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUQROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUQROUT] Performing VerifyExists on RoutingDetails_RoutingLines_WorkCentersLink...", Logger.MessageType.INF);
				SeleniumControl RUQROUT_RoutingDetails_RoutingLines_WorkCentersLink = new SeleniumControl( sDriver, "RoutingDetails_RoutingLines_WorkCentersLink", "ID", "lnk_4473_RUQROUT_ROUTINGLN_CTW");
				Function.AssertEqual(true,RUQROUT_RoutingDetails_RoutingLines_WorkCentersLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUQROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUQROUT] Performing VerifyExists on RoutingDetails_RoutingLines_LaborClassificationsLink...", Logger.MessageType.INF);
				SeleniumControl RUQROUT_RoutingDetails_RoutingLines_LaborClassificationsLink = new SeleniumControl( sDriver, "RoutingDetails_RoutingLines_LaborClassificationsLink", "ID", "lnk_4557_RUQROUT_ROUTINGLN_CTW");
				Function.AssertEqual(true,RUQROUT_RoutingDetails_RoutingLines_LaborClassificationsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUQROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUQROUT] Performing VerifyExists on RoutingDetails_RoutingLines_EquipmentLink...", Logger.MessageType.INF);
				SeleniumControl RUQROUT_RoutingDetails_RoutingLines_EquipmentLink = new SeleniumControl( sDriver, "RoutingDetails_RoutingLines_EquipmentLink", "ID", "lnk_4530_RUQROUT_ROUTINGLN_CTW");
				Function.AssertEqual(true,RUQROUT_RoutingDetails_RoutingLines_EquipmentLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUQROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUQROUT] Performing VerifyExists on RoutingDetails_RoutingLines_RoutingDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl RUQROUT_RoutingDetails_RoutingLines_RoutingDocumentsLink = new SeleniumControl( sDriver, "RoutingDetails_RoutingLines_RoutingDocumentsLink", "ID", "lnk_4811_RUQROUT_ROUTINGLN_CTW");
				Function.AssertEqual(true,RUQROUT_RoutingDetails_RoutingLines_RoutingDocumentsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUQROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUQROUT] Performing VerifyExists on RoutingDetails_RoutingLines_UserDefinedFieldsLink...", Logger.MessageType.INF);
				SeleniumControl RUQROUT_RoutingDetails_RoutingLines_UserDefinedFieldsLink = new SeleniumControl( sDriver, "RoutingDetails_RoutingLines_UserDefinedFieldsLink", "ID", "lnk_5049_RUQROUT_ROUTINGLN_CTW");
				Function.AssertEqual(true,RUQROUT_RoutingDetails_RoutingLines_UserDefinedFieldsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUQROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUQROUT] Performing Close on RoutingDetails_RoutingLinesForm...", Logger.MessageType.INF);
				SeleniumControl RUQROUT_RoutingDetails_RoutingLinesForm = new SeleniumControl( sDriver, "RoutingDetails_RoutingLinesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__RUQROUT_ROUTINGLN_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(RUQROUT_RoutingDetails_RoutingLinesForm);
IWebElement formBttn = RUQROUT_RoutingDetails_RoutingLinesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Configurations");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUQROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUQROUT] Performing Click on RoutingDetails_ConfigurationsLink...", Logger.MessageType.INF);
				SeleniumControl RUQROUT_RoutingDetails_ConfigurationsLink = new SeleniumControl( sDriver, "RoutingDetails_ConfigurationsLink", "ID", "lnk_4489_RUQROUT_ROUTINGHDR_CTW");
				Function.WaitControlDisplayed(RUQROUT_RoutingDetails_ConfigurationsLink);
RUQROUT_RoutingDetails_ConfigurationsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUQROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUQROUT] Performing VerifyExists on RoutingDetails_ConfigurationsForm...", Logger.MessageType.INF);
				SeleniumControl RUQROUT_RoutingDetails_ConfigurationsForm = new SeleniumControl( sDriver, "RoutingDetails_ConfigurationsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__RUQROUT_ROUTINGCONFIG_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,RUQROUT_RoutingDetails_ConfigurationsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUQROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUQROUT] Performing VerifyExist on RoutingDetails_ConfigurationsFormTable...", Logger.MessageType.INF);
				SeleniumControl RUQROUT_RoutingDetails_ConfigurationsFormTable = new SeleniumControl( sDriver, "RoutingDetails_ConfigurationsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__RUQROUT_ROUTINGCONFIG_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,RUQROUT_RoutingDetails_ConfigurationsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUQROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUQROUT] Performing Close on RoutingDetails_ConfigurationsForm...", Logger.MessageType.INF);
				SeleniumControl RUQROUT_RoutingDetails_ConfigurationsForm = new SeleniumControl( sDriver, "RoutingDetails_ConfigurationsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__RUQROUT_ROUTINGCONFIG_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(RUQROUT_RoutingDetails_ConfigurationsForm);
IWebElement formBttn = RUQROUT_RoutingDetails_ConfigurationsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "RUQROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUQROUT] Performing Click on RoutingDetails_PartDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl RUQROUT_RoutingDetails_PartDocumentsLink = new SeleniumControl( sDriver, "RoutingDetails_PartDocumentsLink", "ID", "lnk_1006243_RUQROUT_ROUTINGHDR_CTW");
				Function.WaitControlDisplayed(RUQROUT_RoutingDetails_PartDocumentsLink);
RUQROUT_RoutingDetails_PartDocumentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUQROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUQROUT] Performing VerifyExists on RoutingDetails_PartDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl RUQROUT_RoutingDetails_PartDocumentsForm = new SeleniumControl( sDriver, "RoutingDetails_PartDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]");
				Function.AssertEqual(true,RUQROUT_RoutingDetails_PartDocumentsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUQROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUQROUT] Performing VerifyExist on RoutingDetails_PartDocumentsFormTable...", Logger.MessageType.INF);
				SeleniumControl RUQROUT_RoutingDetails_PartDocumentsFormTable = new SeleniumControl( sDriver, "RoutingDetails_PartDocumentsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,RUQROUT_RoutingDetails_PartDocumentsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUQROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUQROUT] Performing ClickButton on RoutingDetails_PartDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl RUQROUT_RoutingDetails_PartDocumentsForm = new SeleniumControl( sDriver, "RoutingDetails_PartDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(RUQROUT_RoutingDetails_PartDocumentsForm);
IWebElement formBttn = RUQROUT_RoutingDetails_PartDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? RUQROUT_RoutingDetails_PartDocumentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
RUQROUT_RoutingDetails_PartDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUQROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUQROUT] Performing VerifyExists on RoutingDetails_PartDocuments_Type...", Logger.MessageType.INF);
				SeleniumControl RUQROUT_RoutingDetails_PartDocuments_Type = new SeleniumControl( sDriver, "RoutingDetails_PartDocuments_Type", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]/descendant::*[@id='DOC_TYPE_CD']");
				Function.AssertEqual(true,RUQROUT_RoutingDetails_PartDocuments_Type.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUQROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUQROUT] Performing Close on RoutingDetails_PartDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl RUQROUT_RoutingDetails_PartDocumentsForm = new SeleniumControl( sDriver, "RoutingDetails_PartDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(RUQROUT_RoutingDetails_PartDocumentsForm);
IWebElement formBttn = RUQROUT_RoutingDetails_PartDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "RUQROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUQROUT] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl RUQROUT_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(RUQROUT_MainForm);
IWebElement formBttn = RUQROUT_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

