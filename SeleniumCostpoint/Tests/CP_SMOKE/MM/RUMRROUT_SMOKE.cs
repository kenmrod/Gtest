 
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
    public class RUMRROUT_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Routings", "xpath","//div[@class='navItem'][.='Routings']").Click();
new SeleniumControl(sDriver,"Release Routings", "xpath","//div[@class='navItem'][.='Release Routings']").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SelectMenu]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("MAIN FORM");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMRROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMRROUT] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl RUMRROUT_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,RUMRROUT_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMRROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMRROUT] Performing VerifyExists on Part...", Logger.MessageType.INF);
				SeleniumControl RUMRROUT_Part = new SeleniumControl( sDriver, "Part", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PART_ID']");
				Function.AssertEqual(true,RUMRROUT_Part.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMRROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMRROUT] Performing ClickButtonIfExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl RUMRROUT_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(RUMRROUT_MainForm);
IWebElement formBttn = RUMRROUT_MainForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).Count <= 0 ? RUMRROUT_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Query')]")).FirstOrDefault() :
RUMRROUT_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Query')]")).FirstOrDefault();
if (formBttn!=null && formBttn.Displayed)
{ new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click();
this.ScriptLogger.WriteLine("Button [Query] found and clicked.", Logger.MessageType.INF);
}


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButtonIfExists]" , ex.Message));
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
								try {
				Function.CurrentComponent = "RUMRROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMRROUT] Performing ClickButtonIfExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl RUMRROUT_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(RUMRROUT_MainForm);
IWebElement formBttn = RUMRROUT_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? RUMRROUT_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
RUMRROUT_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault();
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
				Function.CurrentComponent = "RUMRROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMRROUT] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl RUMRROUT_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(RUMRROUT_MainForm);
IWebElement formBttn = RUMRROUT_MainForm.mElement.FindElements(By.CssSelector("*[title*='Next']")).Count <= 0 ? RUMRROUT_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Next')]")).FirstOrDefault() :
RUMRROUT_MainForm.mElement.FindElements(By.CssSelector("*[title*='Next']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Next not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("MAIN FORM LINKS");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMRROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMRROUT] Performing VerifyExists on RoutingLineFilterLink...", Logger.MessageType.INF);
				SeleniumControl RUMRROUT_RoutingLineFilterLink = new SeleniumControl( sDriver, "RoutingLineFilterLink", "ID", "lnk_4700_RUMROUT_HEADER");
				Function.AssertEqual(true,RUMRROUT_RoutingLineFilterLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMRROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMRROUT] Performing Click on RoutingLineFilterLink...", Logger.MessageType.INF);
				SeleniumControl RUMRROUT_RoutingLineFilterLink = new SeleniumControl( sDriver, "RoutingLineFilterLink", "ID", "lnk_4700_RUMROUT_HEADER");
				Function.WaitControlDisplayed(RUMRROUT_RoutingLineFilterLink);
RUMRROUT_RoutingLineFilterLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMRROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMRROUT] Performing VerifyExists on RoutingLineFilterForm...", Logger.MessageType.INF);
				SeleniumControl RUMRROUT_RoutingLineFilterForm = new SeleniumControl( sDriver, "RoutingLineFilterForm", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMROUT_FILTER_ROUTLINE_']/ancestor::form[1]");
				Function.AssertEqual(true,RUMRROUT_RoutingLineFilterForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMRROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMRROUT] Performing VerifyExists on RoutingLineFilter_AsofDate...", Logger.MessageType.INF);
				SeleniumControl RUMRROUT_RoutingLineFilter_AsofDate = new SeleniumControl( sDriver, "RoutingLineFilter_AsofDate", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMROUT_FILTER_ROUTLINE_']/ancestor::form[1]/descendant::*[@id='EFFECT_DT']");
				Function.AssertEqual(true,RUMRROUT_RoutingLineFilter_AsofDate.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMRROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMRROUT] Performing Close on RoutingLineFilterForm...", Logger.MessageType.INF);
				SeleniumControl RUMRROUT_RoutingLineFilterForm = new SeleniumControl( sDriver, "RoutingLineFilterForm", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMROUT_FILTER_ROUTLINE_']/ancestor::form[1]");
				Function.WaitControlDisplayed(RUMRROUT_RoutingLineFilterForm);
IWebElement formBttn = RUMRROUT_RoutingLineFilterForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMRROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMRROUT] Performing VerifyExists on LinkConfigurationsLink...", Logger.MessageType.INF);
				SeleniumControl RUMRROUT_LinkConfigurationsLink = new SeleniumControl( sDriver, "LinkConfigurationsLink", "ID", "lnk_1006462_RUMROUT_HEADER");
				Function.AssertEqual(true,RUMRROUT_LinkConfigurationsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMRROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMRROUT] Performing Click on LinkConfigurationsLink...", Logger.MessageType.INF);
				SeleniumControl RUMRROUT_LinkConfigurationsLink = new SeleniumControl( sDriver, "LinkConfigurationsLink", "ID", "lnk_1006462_RUMROUT_HEADER");
				Function.WaitControlDisplayed(RUMRROUT_LinkConfigurationsLink);
RUMRROUT_LinkConfigurationsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMRROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMRROUT] Performing VerifyExist on LinkConfigurationTable...", Logger.MessageType.INF);
				SeleniumControl RUMRROUT_LinkConfigurationTable = new SeleniumControl( sDriver, "LinkConfigurationTable", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMROUT_ROUTINGCONFIG_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,RUMRROUT_LinkConfigurationTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMRROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMRROUT] Performing Click on LinkConfiguration_Ok...", Logger.MessageType.INF);
				SeleniumControl RUMRROUT_LinkConfiguration_Ok = new SeleniumControl( sDriver, "LinkConfiguration_Ok", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMROUT_ROUTINGCONFIG_CTW_']/ancestor::form[1]/following-sibling::div[1]/descendant::*[@id='bOk']");
				Function.WaitControlDisplayed(RUMRROUT_LinkConfiguration_Ok);
if (RUMRROUT_LinkConfiguration_Ok.mElement.GetAttribute("class") == "popupBtn" && sDriver.BrowserType == "ie")
RUMRROUT_LinkConfiguration_Ok.Click(5,5);
else RUMRROUT_LinkConfiguration_Ok.Click(4.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("CHILD FORM");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMRROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMRROUT] Performing VerifyExist on ChildFormTable...", Logger.MessageType.INF);
				SeleniumControl RUMRROUT_ChildFormTable = new SeleniumControl( sDriver, "ChildFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMROUT_ROUTINGLN_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,RUMRROUT_ChildFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMRROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMRROUT] Performing ClickButtonIfExists on ChildForm...", Logger.MessageType.INF);
				SeleniumControl RUMRROUT_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMROUT_ROUTINGLN_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(RUMRROUT_ChildForm);
IWebElement formBttn = RUMRROUT_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? RUMRROUT_ChildForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
RUMRROUT_ChildForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault();
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
				Function.CurrentComponent = "RUMRROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMRROUT] Performing VerifyExists on ChildForm_OperationSequence...", Logger.MessageType.INF);
				SeleniumControl RUMRROUT_ChildForm_OperationSequence = new SeleniumControl( sDriver, "ChildForm_OperationSequence", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMROUT_ROUTINGLN_CTW_']/ancestor::form[1]/descendant::*[@id='ROUT_OPER_SEQ_NO']");
				Function.AssertEqual(true,RUMRROUT_ChildForm_OperationSequence.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("CHILD FORM TAB");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMRROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMRROUT] Performing VerifyExists on ChildForm_Operation_OperationType...", Logger.MessageType.INF);
				SeleniumControl RUMRROUT_ChildForm_Operation_OperationType = new SeleniumControl( sDriver, "ChildForm_Operation_OperationType", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMROUT_ROUTINGLN_CTW_']/ancestor::form[1]/descendant::*[@id='OP_TYPE_CD']");
				Function.AssertEqual(true,RUMRROUT_ChildForm_Operation_OperationType.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMRROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMRROUT] Performing Select on ChildForm_Tab...", Logger.MessageType.INF);
				SeleniumControl RUMRROUT_ChildForm_Tab = new SeleniumControl( sDriver, "ChildForm_Tab", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMROUT_ROUTINGLN_CTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(RUMRROUT_ChildForm_Tab);
IWebElement mTab = RUMRROUT_ChildForm_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Lead Time/Capacity").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMRROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMRROUT] Performing VerifyExists on ChildForm_LeadTimeCapacity_LeadTimeCapacity_FixedRunHours...", Logger.MessageType.INF);
				SeleniumControl RUMRROUT_ChildForm_LeadTimeCapacity_LeadTimeCapacity_FixedRunHours = new SeleniumControl( sDriver, "ChildForm_LeadTimeCapacity_LeadTimeCapacity_FixedRunHours", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMROUT_ROUTINGLN_CTW_']/ancestor::form[1]/descendant::*[@id='UNIT_RUN_HOURS']");
				Function.AssertEqual(true,RUMRROUT_ChildForm_LeadTimeCapacity_LeadTimeCapacity_FixedRunHours.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMRROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMRROUT] Performing Select on ChildForm_Tab...", Logger.MessageType.INF);
				SeleniumControl RUMRROUT_ChildForm_Tab = new SeleniumControl( sDriver, "ChildForm_Tab", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMROUT_ROUTINGLN_CTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(RUMRROUT_ChildForm_Tab);
IWebElement mTab = RUMRROUT_ChildForm_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Cost").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMRROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMRROUT] Performing VerifyExists on ChildForm_Cost_Currency...", Logger.MessageType.INF);
				SeleniumControl RUMRROUT_ChildForm_Cost_Currency = new SeleniumControl( sDriver, "ChildForm_Cost_Currency", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMROUT_ROUTINGLN_CTW_']/ancestor::form[1]/descendant::*[@id='CURRENCY']");
				Function.AssertEqual(true,RUMRROUT_ChildForm_Cost_Currency.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMRROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMRROUT] Performing Select on ChildForm_Tab...", Logger.MessageType.INF);
				SeleniumControl RUMRROUT_ChildForm_Tab = new SeleniumControl( sDriver, "ChildForm_Tab", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMROUT_ROUTINGLN_CTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(RUMRROUT_ChildForm_Tab);
IWebElement mTab = RUMRROUT_ChildForm_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Additional Information").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMRROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMRROUT] Performing VerifyExists on ChildForm_AdditionalInformation_Organization...", Logger.MessageType.INF);
				SeleniumControl RUMRROUT_ChildForm_AdditionalInformation_Organization = new SeleniumControl( sDriver, "ChildForm_AdditionalInformation_Organization", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMROUT_ROUTINGLN_CTW_']/ancestor::form[1]/descendant::*[@id='ORG_ID']");
				Function.AssertEqual(true,RUMRROUT_ChildForm_AdditionalInformation_Organization.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMRROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMRROUT] Performing Select on ChildForm_Tab...", Logger.MessageType.INF);
				SeleniumControl RUMRROUT_ChildForm_Tab = new SeleniumControl( sDriver, "ChildForm_Tab", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMROUT_ROUTINGLN_CTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(RUMRROUT_ChildForm_Tab);
IWebElement mTab = RUMRROUT_ChildForm_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "User-Defined Fields").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMRROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMRROUT] Performing VerifyExists on ChildForm_UserDefinedFields_Supervisor...", Logger.MessageType.INF);
				SeleniumControl RUMRROUT_ChildForm_UserDefinedFields_Supervisor = new SeleniumControl( sDriver, "ChildForm_UserDefinedFields_Supervisor", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMROUT_ROUTINGLN_CTW_']/ancestor::form[1]/descendant::*[@id='UDEF_DESC_1']");
				Function.AssertEqual(true,RUMRROUT_ChildForm_UserDefinedFields_Supervisor.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMRROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMRROUT] Performing Select on ChildForm_Tab...", Logger.MessageType.INF);
				SeleniumControl RUMRROUT_ChildForm_Tab = new SeleniumControl( sDriver, "ChildForm_Tab", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMROUT_ROUTINGLN_CTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(RUMRROUT_ChildForm_Tab);
IWebElement mTab = RUMRROUT_ChildForm_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Line Notes").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMRROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMRROUT] Performing VerifyExists on ChildForm_LineNotes_LineNotes...", Logger.MessageType.INF);
				SeleniumControl RUMRROUT_ChildForm_LineNotes_LineNotes = new SeleniumControl( sDriver, "ChildForm_LineNotes_LineNotes", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMROUT_ROUTINGLN_CTW_']/ancestor::form[1]/descendant::*[@id='ROUT_LN_TX']");
				Function.AssertEqual(true,RUMRROUT_ChildForm_LineNotes_LineNotes.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("CHILD FORM LINK");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMRROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMRROUT] Performing VerifyExists on ChildForm_RoutingLineComponentsLink...", Logger.MessageType.INF);
				SeleniumControl RUMRROUT_ChildForm_RoutingLineComponentsLink = new SeleniumControl( sDriver, "ChildForm_RoutingLineComponentsLink", "ID", "lnk_16004_RUMROUT_ROUTINGLN_CTW");
				Function.AssertEqual(true,RUMRROUT_ChildForm_RoutingLineComponentsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMRROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMRROUT] Performing Click on ChildForm_RoutingLineComponentsLink...", Logger.MessageType.INF);
				SeleniumControl RUMRROUT_ChildForm_RoutingLineComponentsLink = new SeleniumControl( sDriver, "ChildForm_RoutingLineComponentsLink", "ID", "lnk_16004_RUMROUT_ROUTINGLN_CTW");
				Function.WaitControlDisplayed(RUMRROUT_ChildForm_RoutingLineComponentsLink);
RUMRROUT_ChildForm_RoutingLineComponentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMRROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMRROUT] Performing VerifyExist on ChildForm_RoutingLineComponentsFormTable...", Logger.MessageType.INF);
				SeleniumControl RUMRROUT_ChildForm_RoutingLineComponentsFormTable = new SeleniumControl( sDriver, "ChildForm_RoutingLineComponentsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMROUT_ROUTINGLNCOMP_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,RUMRROUT_ChildForm_RoutingLineComponentsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMRROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMRROUT] Performing ClickButton on ChildForm_RoutingLineComponentsForm...", Logger.MessageType.INF);
				SeleniumControl RUMRROUT_ChildForm_RoutingLineComponentsForm = new SeleniumControl( sDriver, "ChildForm_RoutingLineComponentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMROUT_ROUTINGLNCOMP_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(RUMRROUT_ChildForm_RoutingLineComponentsForm);
IWebElement formBttn = RUMRROUT_ChildForm_RoutingLineComponentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? RUMRROUT_ChildForm_RoutingLineComponentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
RUMRROUT_ChildForm_RoutingLineComponentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMRROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMRROUT] Performing VerifyExists on ChildForm_RoutingLineComponentsForm...", Logger.MessageType.INF);
				SeleniumControl RUMRROUT_ChildForm_RoutingLineComponentsForm = new SeleniumControl( sDriver, "ChildForm_RoutingLineComponentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMROUT_ROUTINGLNCOMP_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,RUMRROUT_ChildForm_RoutingLineComponentsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMRROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMRROUT] Performing VerifyExists on ChildForm_RoutingLineComponents_ComponentPart...", Logger.MessageType.INF);
				SeleniumControl RUMRROUT_ChildForm_RoutingLineComponents_ComponentPart = new SeleniumControl( sDriver, "ChildForm_RoutingLineComponents_ComponentPart", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMROUT_ROUTINGLNCOMP_CTW_']/ancestor::form[1]/descendant::*[@id='COMP_PART_ID']");
				Function.AssertEqual(true,RUMRROUT_ChildForm_RoutingLineComponents_ComponentPart.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMRROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMRROUT] Performing Close on ChildForm_RoutingLineComponentsForm...", Logger.MessageType.INF);
				SeleniumControl RUMRROUT_ChildForm_RoutingLineComponentsForm = new SeleniumControl( sDriver, "ChildForm_RoutingLineComponentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMROUT_ROUTINGLNCOMP_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(RUMRROUT_ChildForm_RoutingLineComponentsForm);
IWebElement formBttn = RUMRROUT_ChildForm_RoutingLineComponentsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMRROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMRROUT] Performing VerifyExists on ChildForm_StandardTextLink...", Logger.MessageType.INF);
				SeleniumControl RUMRROUT_ChildForm_StandardTextLink = new SeleniumControl( sDriver, "ChildForm_StandardTextLink", "ID", "lnk_1006466_RUMROUT_ROUTINGLN_CTW");
				Function.AssertEqual(true,RUMRROUT_ChildForm_StandardTextLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMRROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMRROUT] Performing Click on ChildForm_StandardTextLink...", Logger.MessageType.INF);
				SeleniumControl RUMRROUT_ChildForm_StandardTextLink = new SeleniumControl( sDriver, "ChildForm_StandardTextLink", "ID", "lnk_1006466_RUMROUT_ROUTINGLN_CTW");
				Function.WaitControlDisplayed(RUMRROUT_ChildForm_StandardTextLink);
RUMRROUT_ChildForm_StandardTextLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMRROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMRROUT] Performing VerifyExist on ChildForm_StandardTextFormFormTable...", Logger.MessageType.INF);
				SeleniumControl RUMRROUT_ChildForm_StandardTextFormFormTable = new SeleniumControl( sDriver, "ChildForm_StandardTextFormFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMROUT_ROUTINGLNTEXT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,RUMRROUT_ChildForm_StandardTextFormFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMRROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMRROUT] Performing ClickButton on ChildForm_StandardTextForm...", Logger.MessageType.INF);
				SeleniumControl RUMRROUT_ChildForm_StandardTextForm = new SeleniumControl( sDriver, "ChildForm_StandardTextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMROUT_ROUTINGLNTEXT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(RUMRROUT_ChildForm_StandardTextForm);
IWebElement formBttn = RUMRROUT_ChildForm_StandardTextForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? RUMRROUT_ChildForm_StandardTextForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
RUMRROUT_ChildForm_StandardTextForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMRROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMRROUT] Performing VerifyExists on ChildForm_StandardTextForm...", Logger.MessageType.INF);
				SeleniumControl RUMRROUT_ChildForm_StandardTextForm = new SeleniumControl( sDriver, "ChildForm_StandardTextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMROUT_ROUTINGLNTEXT_']/ancestor::form[1]");
				Function.AssertEqual(true,RUMRROUT_ChildForm_StandardTextForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMRROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMRROUT] Performing VerifyExists on ChildForm_StandardText_Sequence...", Logger.MessageType.INF);
				SeleniumControl RUMRROUT_ChildForm_StandardText_Sequence = new SeleniumControl( sDriver, "ChildForm_StandardText_Sequence", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMROUT_ROUTINGLNTEXT_']/ancestor::form[1]/descendant::*[@id='SEQ_NO']");
				Function.AssertEqual(true,RUMRROUT_ChildForm_StandardText_Sequence.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMRROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMRROUT] Performing Close on ChildForm_StandardTextForm...", Logger.MessageType.INF);
				SeleniumControl RUMRROUT_ChildForm_StandardTextForm = new SeleniumControl( sDriver, "ChildForm_StandardTextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMROUT_ROUTINGLNTEXT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(RUMRROUT_ChildForm_StandardTextForm);
IWebElement formBttn = RUMRROUT_ChildForm_StandardTextForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMRROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMRROUT] Performing VerifyExists on ChildForm_DocumentsLink...", Logger.MessageType.INF);
				SeleniumControl RUMRROUT_ChildForm_DocumentsLink = new SeleniumControl( sDriver, "ChildForm_DocumentsLink", "ID", "lnk_1006467_RUMROUT_ROUTINGLN_CTW");
				Function.AssertEqual(true,RUMRROUT_ChildForm_DocumentsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMRROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMRROUT] Performing Click on ChildForm_DocumentsLink...", Logger.MessageType.INF);
				SeleniumControl RUMRROUT_ChildForm_DocumentsLink = new SeleniumControl( sDriver, "ChildForm_DocumentsLink", "ID", "lnk_1006467_RUMROUT_ROUTINGLN_CTW");
				Function.WaitControlDisplayed(RUMRROUT_ChildForm_DocumentsLink);
RUMRROUT_ChildForm_DocumentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMRROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMRROUT] Performing VerifyExist on ChildForm_DocumentsFormTable...", Logger.MessageType.INF);
				SeleniumControl RUMRROUT_ChildForm_DocumentsFormTable = new SeleniumControl( sDriver, "ChildForm_DocumentsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMROUT_ROUTINGLNDOC_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,RUMRROUT_ChildForm_DocumentsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMRROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMRROUT] Performing ClickButton on ChildForm_DocumentsForm...", Logger.MessageType.INF);
				SeleniumControl RUMRROUT_ChildForm_DocumentsForm = new SeleniumControl( sDriver, "ChildForm_DocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMROUT_ROUTINGLNDOC_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(RUMRROUT_ChildForm_DocumentsForm);
IWebElement formBttn = RUMRROUT_ChildForm_DocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? RUMRROUT_ChildForm_DocumentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
RUMRROUT_ChildForm_DocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMRROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMRROUT] Performing VerifyExists on ChildForm_DocumentsForm...", Logger.MessageType.INF);
				SeleniumControl RUMRROUT_ChildForm_DocumentsForm = new SeleniumControl( sDriver, "ChildForm_DocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMROUT_ROUTINGLNDOC_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,RUMRROUT_ChildForm_DocumentsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMRROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMRROUT] Performing VerifyExists on ChildForm_Documents_Document...", Logger.MessageType.INF);
				SeleniumControl RUMRROUT_ChildForm_Documents_Document = new SeleniumControl( sDriver, "ChildForm_Documents_Document", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMROUT_ROUTINGLNDOC_CTW_']/ancestor::form[1]/descendant::*[@id='DOCUMENT_ID']");
				Function.AssertEqual(true,RUMRROUT_ChildForm_Documents_Document.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMRROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMRROUT] Performing Close on ChildForm_DocumentsForm...", Logger.MessageType.INF);
				SeleniumControl RUMRROUT_ChildForm_DocumentsForm = new SeleniumControl( sDriver, "ChildForm_DocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMROUT_ROUTINGLNDOC_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(RUMRROUT_ChildForm_DocumentsForm);
IWebElement formBttn = RUMRROUT_ChildForm_DocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMRROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMRROUT] Performing VerifyExists on ChildForm_EquipmentLink...", Logger.MessageType.INF);
				SeleniumControl RUMRROUT_ChildForm_EquipmentLink = new SeleniumControl( sDriver, "ChildForm_EquipmentLink", "ID", "lnk_15787_RUMROUT_ROUTINGLN_CTW");
				Function.AssertEqual(true,RUMRROUT_ChildForm_EquipmentLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMRROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMRROUT] Performing Click on ChildForm_EquipmentLink...", Logger.MessageType.INF);
				SeleniumControl RUMRROUT_ChildForm_EquipmentLink = new SeleniumControl( sDriver, "ChildForm_EquipmentLink", "ID", "lnk_15787_RUMROUT_ROUTINGLN_CTW");
				Function.WaitControlDisplayed(RUMRROUT_ChildForm_EquipmentLink);
RUMRROUT_ChildForm_EquipmentLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMRROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMRROUT] Performing VerifyExist on ChildForm_EquipmentFormTable...", Logger.MessageType.INF);
				SeleniumControl RUMRROUT_ChildForm_EquipmentFormTable = new SeleniumControl( sDriver, "ChildForm_EquipmentFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMROUT_ROUTINGLNEQUIP_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,RUMRROUT_ChildForm_EquipmentFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMRROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMRROUT] Performing ClickButton on ChildForm_EquipmentForm...", Logger.MessageType.INF);
				SeleniumControl RUMRROUT_ChildForm_EquipmentForm = new SeleniumControl( sDriver, "ChildForm_EquipmentForm", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMROUT_ROUTINGLNEQUIP_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(RUMRROUT_ChildForm_EquipmentForm);
IWebElement formBttn = RUMRROUT_ChildForm_EquipmentForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? RUMRROUT_ChildForm_EquipmentForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
RUMRROUT_ChildForm_EquipmentForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMRROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMRROUT] Performing VerifyExists on ChildForm_EquipmentForm...", Logger.MessageType.INF);
				SeleniumControl RUMRROUT_ChildForm_EquipmentForm = new SeleniumControl( sDriver, "ChildForm_EquipmentForm", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMROUT_ROUTINGLNEQUIP_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,RUMRROUT_ChildForm_EquipmentForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMRROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMRROUT] Performing VerifyExists on ChildForm_Equipment_Equipment...", Logger.MessageType.INF);
				SeleniumControl RUMRROUT_ChildForm_Equipment_Equipment = new SeleniumControl( sDriver, "ChildForm_Equipment_Equipment", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMROUT_ROUTINGLNEQUIP_CTW_']/ancestor::form[1]/descendant::*[@id='EQUIP_ID']");
				Function.AssertEqual(true,RUMRROUT_ChildForm_Equipment_Equipment.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMRROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMRROUT] Performing Close on ChildForm_EquipmentForm...", Logger.MessageType.INF);
				SeleniumControl RUMRROUT_ChildForm_EquipmentForm = new SeleniumControl( sDriver, "ChildForm_EquipmentForm", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMROUT_ROUTINGLNEQUIP_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(RUMRROUT_ChildForm_EquipmentForm);
IWebElement formBttn = RUMRROUT_ChildForm_EquipmentForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMRROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMRROUT] Performing VerifyExists on ChildForm_LaborClassificationsLink...", Logger.MessageType.INF);
				SeleniumControl RUMRROUT_ChildForm_LaborClassificationsLink = new SeleniumControl( sDriver, "ChildForm_LaborClassificationsLink", "ID", "lnk_15788_RUMROUT_ROUTINGLN_CTW");
				Function.AssertEqual(true,RUMRROUT_ChildForm_LaborClassificationsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMRROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMRROUT] Performing Click on ChildForm_LaborClassificationsLink...", Logger.MessageType.INF);
				SeleniumControl RUMRROUT_ChildForm_LaborClassificationsLink = new SeleniumControl( sDriver, "ChildForm_LaborClassificationsLink", "ID", "lnk_15788_RUMROUT_ROUTINGLN_CTW");
				Function.WaitControlDisplayed(RUMRROUT_ChildForm_LaborClassificationsLink);
RUMRROUT_ChildForm_LaborClassificationsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMRROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMRROUT] Performing VerifyExist on ChildForm_LaborClassificationsFormTable...", Logger.MessageType.INF);
				SeleniumControl RUMRROUT_ChildForm_LaborClassificationsFormTable = new SeleniumControl( sDriver, "ChildForm_LaborClassificationsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMROUT_ROUTINGLNLAB_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,RUMRROUT_ChildForm_LaborClassificationsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMRROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMRROUT] Performing ClickButton on ChildForm_LaborClassificationsForm...", Logger.MessageType.INF);
				SeleniumControl RUMRROUT_ChildForm_LaborClassificationsForm = new SeleniumControl( sDriver, "ChildForm_LaborClassificationsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMROUT_ROUTINGLNLAB_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(RUMRROUT_ChildForm_LaborClassificationsForm);
IWebElement formBttn = RUMRROUT_ChildForm_LaborClassificationsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? RUMRROUT_ChildForm_LaborClassificationsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
RUMRROUT_ChildForm_LaborClassificationsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMRROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMRROUT] Performing VerifyExists on ChildForm_LaborClassificationsForm...", Logger.MessageType.INF);
				SeleniumControl RUMRROUT_ChildForm_LaborClassificationsForm = new SeleniumControl( sDriver, "ChildForm_LaborClassificationsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMROUT_ROUTINGLNLAB_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,RUMRROUT_ChildForm_LaborClassificationsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMRROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMRROUT] Performing VerifyExists on ChildForm_LaborClassifications_LaborClassification...", Logger.MessageType.INF);
				SeleniumControl RUMRROUT_ChildForm_LaborClassifications_LaborClassification = new SeleniumControl( sDriver, "ChildForm_LaborClassifications_LaborClassification", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMROUT_ROUTINGLNLAB_CTW_']/ancestor::form[1]/descendant::*[@id='RU_LAB_CLASS_CD']");
				Function.AssertEqual(true,RUMRROUT_ChildForm_LaborClassifications_LaborClassification.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMRROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMRROUT] Performing Close on ChildForm_LaborClassificationsForm...", Logger.MessageType.INF);
				SeleniumControl RUMRROUT_ChildForm_LaborClassificationsForm = new SeleniumControl( sDriver, "ChildForm_LaborClassificationsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMROUT_ROUTINGLNLAB_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(RUMRROUT_ChildForm_LaborClassificationsForm);
IWebElement formBttn = RUMRROUT_ChildForm_LaborClassificationsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMRROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMRROUT] Performing VerifyExists on ChildForm_AlternateWorkCenterLink...", Logger.MessageType.INF);
				SeleniumControl RUMRROUT_ChildForm_AlternateWorkCenterLink = new SeleniumControl( sDriver, "ChildForm_AlternateWorkCenterLink", "ID", "lnk_4586_RUMROUT_ROUTINGLN_CTW");
				Function.AssertEqual(true,RUMRROUT_ChildForm_AlternateWorkCenterLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMRROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMRROUT] Performing Click on ChildForm_AlternateWorkCenterLink...", Logger.MessageType.INF);
				SeleniumControl RUMRROUT_ChildForm_AlternateWorkCenterLink = new SeleniumControl( sDriver, "ChildForm_AlternateWorkCenterLink", "ID", "lnk_4586_RUMROUT_ROUTINGLN_CTW");
				Function.WaitControlDisplayed(RUMRROUT_ChildForm_AlternateWorkCenterLink);
RUMRROUT_ChildForm_AlternateWorkCenterLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMRROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMRROUT] Performing VerifyExist on ChildForm_AlternateWorkCenterTable...", Logger.MessageType.INF);
				SeleniumControl RUMRROUT_ChildForm_AlternateWorkCenterTable = new SeleniumControl( sDriver, "ChildForm_AlternateWorkCenterTable", "xpath", "//div[translate(@id,'0123456789','')='pr__MM_ALTWORKCENTER_HDR_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,RUMRROUT_ChildForm_AlternateWorkCenterTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMRROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMRROUT] Performing Close on ChildForm_AlternateWorkCenterForm...", Logger.MessageType.INF);
				SeleniumControl RUMRROUT_ChildForm_AlternateWorkCenterForm = new SeleniumControl( sDriver, "ChildForm_AlternateWorkCenterForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MM_ALTWORKCENTER_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(RUMRROUT_ChildForm_AlternateWorkCenterForm);
IWebElement formBttn = RUMRROUT_ChildForm_AlternateWorkCenterForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("CLOSE");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMRROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMRROUT] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl RUMRROUT_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(RUMRROUT_MainForm);
IWebElement formBttn = RUMRROUT_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
Function.ClickOkDialogIfExists("You have unsaved changes. Select Cancel to go back and save changes or select OK to discard changes and close this application.");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickOkDialogIfExists]" , ex.Message));
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

