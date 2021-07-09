 
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
    public class RUMROUT_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Manage Routings", "xpath","//div[@class='navItem'][.='Manage Routings']").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SelectMenu]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMROUT] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl RUMROUT_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,RUMROUT_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMROUT] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl RUMROUT_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(RUMROUT_MainForm);
IWebElement formBttn = RUMROUT_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? RUMROUT_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
RUMROUT_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMROUT] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl RUMROUT_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,RUMROUT_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMROUT] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl RUMROUT_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(RUMROUT_MainForm);
IWebElement formBttn = RUMROUT_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? RUMROUT_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
RUMROUT_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMROUT] Performing VerifyExists on Part...", Logger.MessageType.INF);
				SeleniumControl RUMROUT_Part = new SeleniumControl( sDriver, "Part", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PART_ID']");
				Function.AssertEqual(true,RUMROUT_Part.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("ROUTINGLINEFILTER");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMROUT] Performing Click on RoutingLineFilterLink...", Logger.MessageType.INF);
				SeleniumControl RUMROUT_RoutingLineFilterLink = new SeleniumControl( sDriver, "RoutingLineFilterLink", "ID", "lnk_4700_RUMROUT_HEADER");
				Function.WaitControlDisplayed(RUMROUT_RoutingLineFilterLink);
RUMROUT_RoutingLineFilterLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMROUT] Performing VerifyExists on RoutingLineFilterForm...", Logger.MessageType.INF);
				SeleniumControl RUMROUT_RoutingLineFilterForm = new SeleniumControl( sDriver, "RoutingLineFilterForm", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMROUT_FILTER_ROUTLINE_']/ancestor::form[1]");
				Function.AssertEqual(true,RUMROUT_RoutingLineFilterForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMROUT] Performing VerifyExists on RoutingLineFilter_AsofDate...", Logger.MessageType.INF);
				SeleniumControl RUMROUT_RoutingLineFilter_AsofDate = new SeleniumControl( sDriver, "RoutingLineFilter_AsofDate", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMROUT_FILTER_ROUTLINE_']/ancestor::form[1]/descendant::*[@id='EFFECT_DT']");
				Function.AssertEqual(true,RUMROUT_RoutingLineFilter_AsofDate.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMROUT] Performing Close on RoutingLineFilterForm...", Logger.MessageType.INF);
				SeleniumControl RUMROUT_RoutingLineFilterForm = new SeleniumControl( sDriver, "RoutingLineFilterForm", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMROUT_FILTER_ROUTLINE_']/ancestor::form[1]");
				Function.WaitControlDisplayed(RUMROUT_RoutingLineFilterForm);
IWebElement formBttn = RUMROUT_RoutingLineFilterForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("LINKCONFIGURATIONS");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try
				{
				Function.Wait(30);


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Wait]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMROUT] Performing Click on LinkConfigurationsLink...", Logger.MessageType.INF);
				SeleniumControl RUMROUT_LinkConfigurationsLink = new SeleniumControl( sDriver, "LinkConfigurationsLink", "ID", "lnk_1006462_RUMROUT_HEADER");
				Function.WaitControlDisplayed(RUMROUT_LinkConfigurationsLink);
RUMROUT_LinkConfigurationsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMROUT] Performing VerifyExist on LinkConfigurationFormTable...", Logger.MessageType.INF);
				SeleniumControl RUMROUT_LinkConfigurationFormTable = new SeleniumControl( sDriver, "LinkConfigurationFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMROUT_ROUTINGCONFIG_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,RUMROUT_LinkConfigurationFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMROUT] Performing VerifyExists on LinkConfigurationForm...", Logger.MessageType.INF);
				SeleniumControl RUMROUT_LinkConfigurationForm = new SeleniumControl( sDriver, "LinkConfigurationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMROUT_ROUTINGCONFIG_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,RUMROUT_LinkConfigurationForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMROUT] Performing Close on LinkConfigurationForm...", Logger.MessageType.INF);
				SeleniumControl RUMROUT_LinkConfigurationForm = new SeleniumControl( sDriver, "LinkConfigurationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMROUT_ROUTINGCONFIG_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(RUMROUT_LinkConfigurationForm);
IWebElement formBttn = RUMROUT_LinkConfigurationForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("FOR THE 6 SUBTASKS");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMROUT] Performing VerifyExist on ChildFormTable...", Logger.MessageType.INF);
				SeleniumControl RUMROUT_ChildFormTable = new SeleniumControl( sDriver, "ChildFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMROUT_ROUTINGLN_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,RUMROUT_ChildFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMROUT] Performing ClickButton on ChildForm...", Logger.MessageType.INF);
				SeleniumControl RUMROUT_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMROUT_ROUTINGLN_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(RUMROUT_ChildForm);
IWebElement formBttn = RUMROUT_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? RUMROUT_ChildForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
RUMROUT_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMROUT] Performing VerifyExists on ChildForm_OperationSequence...", Logger.MessageType.INF);
				SeleniumControl RUMROUT_ChildForm_OperationSequence = new SeleniumControl( sDriver, "ChildForm_OperationSequence", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMROUT_ROUTINGLN_CTW_']/ancestor::form[1]/descendant::*[@id='ROUT_OPER_SEQ_NO']");
				Function.AssertEqual(true,RUMROUT_ChildForm_OperationSequence.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMROUT] Performing Select on ChildForm_Tab...", Logger.MessageType.INF);
				SeleniumControl RUMROUT_ChildForm_Tab = new SeleniumControl( sDriver, "ChildForm_Tab", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMROUT_ROUTINGLN_CTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(RUMROUT_ChildForm_Tab);
IWebElement mTab = RUMROUT_ChildForm_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Operation").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMROUT] Performing VerifyExists on ChildForm_Operation_OperationType...", Logger.MessageType.INF);
				SeleniumControl RUMROUT_ChildForm_Operation_OperationType = new SeleniumControl( sDriver, "ChildForm_Operation_OperationType", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMROUT_ROUTINGLN_CTW_']/ancestor::form[1]/descendant::*[@id='OP_TYPE_CD']");
				Function.AssertEqual(true,RUMROUT_ChildForm_Operation_OperationType.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMROUT] Performing Select on ChildForm_Tab...", Logger.MessageType.INF);
				SeleniumControl RUMROUT_ChildForm_Tab = new SeleniumControl( sDriver, "ChildForm_Tab", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMROUT_ROUTINGLN_CTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(RUMROUT_ChildForm_Tab);
IWebElement mTab = RUMROUT_ChildForm_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Lead Time/Capacity").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMROUT] Performing VerifyExists on ChildForm_LeadTimeCapacity_LeadTimeCapacity_Cumulative_FixedRunHours...", Logger.MessageType.INF);
				SeleniumControl RUMROUT_ChildForm_LeadTimeCapacity_LeadTimeCapacity_Cumulative_FixedRunHours = new SeleniumControl( sDriver, "ChildForm_LeadTimeCapacity_LeadTimeCapacity_Cumulative_FixedRunHours", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMROUT_ROUTINGLN_CTW_']/ancestor::form[1]/descendant::*[@id='UNIT_RUN_HRS_CUM']");
				Function.AssertEqual(true,RUMROUT_ChildForm_LeadTimeCapacity_LeadTimeCapacity_Cumulative_FixedRunHours.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMROUT] Performing Select on ChildForm_Tab...", Logger.MessageType.INF);
				SeleniumControl RUMROUT_ChildForm_Tab = new SeleniumControl( sDriver, "ChildForm_Tab", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMROUT_ROUTINGLN_CTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(RUMROUT_ChildForm_Tab);
IWebElement mTab = RUMROUT_ChildForm_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Cost").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMROUT] Performing VerifyExists on ChildForm_Cost_CostsRates_CurrentOperation_RunRate...", Logger.MessageType.INF);
				SeleniumControl RUMROUT_ChildForm_Cost_CostsRates_CurrentOperation_RunRate = new SeleniumControl( sDriver, "ChildForm_Cost_CostsRates_CurrentOperation_RunRate", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMROUT_ROUTINGLN_CTW_']/ancestor::form[1]/descendant::*[@id='OP_RUN_HRLY_AMT']");
				Function.AssertEqual(true,RUMROUT_ChildForm_Cost_CostsRates_CurrentOperation_RunRate.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMROUT] Performing Select on ChildForm_Tab...", Logger.MessageType.INF);
				SeleniumControl RUMROUT_ChildForm_Tab = new SeleniumControl( sDriver, "ChildForm_Tab", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMROUT_ROUTINGLN_CTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(RUMROUT_ChildForm_Tab);
IWebElement mTab = RUMROUT_ChildForm_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Additional Information").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMROUT] Performing VerifyExists on ChildForm_AdditionalInformation_Organization...", Logger.MessageType.INF);
				SeleniumControl RUMROUT_ChildForm_AdditionalInformation_Organization = new SeleniumControl( sDriver, "ChildForm_AdditionalInformation_Organization", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMROUT_ROUTINGLN_CTW_']/ancestor::form[1]/descendant::*[@id='ORG_ID']");
				Function.AssertEqual(true,RUMROUT_ChildForm_AdditionalInformation_Organization.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMROUT] Performing Select on ChildForm_Tab...", Logger.MessageType.INF);
				SeleniumControl RUMROUT_ChildForm_Tab = new SeleniumControl( sDriver, "ChildForm_Tab", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMROUT_ROUTINGLN_CTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(RUMROUT_ChildForm_Tab);
IWebElement mTab = RUMROUT_ChildForm_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "User-Defined Fields").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMROUT] Performing Select on ChildForm_Tab...", Logger.MessageType.INF);
				SeleniumControl RUMROUT_ChildForm_Tab = new SeleniumControl( sDriver, "ChildForm_Tab", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMROUT_ROUTINGLN_CTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(RUMROUT_ChildForm_Tab);
IWebElement mTab = RUMROUT_ChildForm_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Line Notes").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("ROUTINGLINECOMPONENTS");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMROUT] Performing Click on ChildForm_RoutingLineComponentsLink...", Logger.MessageType.INF);
				SeleniumControl RUMROUT_ChildForm_RoutingLineComponentsLink = new SeleniumControl( sDriver, "ChildForm_RoutingLineComponentsLink", "ID", "lnk_16004_RUMROUT_ROUTINGLN_CTW");
				Function.WaitControlDisplayed(RUMROUT_ChildForm_RoutingLineComponentsLink);
RUMROUT_ChildForm_RoutingLineComponentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMROUT] Performing VerifyExist on RoutingLineComponentsTable...", Logger.MessageType.INF);
				SeleniumControl RUMROUT_RoutingLineComponentsTable = new SeleniumControl( sDriver, "RoutingLineComponentsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMROUT_ROUTINGLNCOMP_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,RUMROUT_RoutingLineComponentsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMROUT] Performing VerifyExists on RoutingLineComponentsForm...", Logger.MessageType.INF);
				SeleniumControl RUMROUT_RoutingLineComponentsForm = new SeleniumControl( sDriver, "RoutingLineComponentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMROUT_ROUTINGLNCOMP_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,RUMROUT_RoutingLineComponentsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMROUT] Performing ClickButton on RoutingLineComponentsForm...", Logger.MessageType.INF);
				SeleniumControl RUMROUT_RoutingLineComponentsForm = new SeleniumControl( sDriver, "RoutingLineComponentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMROUT_ROUTINGLNCOMP_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(RUMROUT_RoutingLineComponentsForm);
IWebElement formBttn = RUMROUT_RoutingLineComponentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? RUMROUT_RoutingLineComponentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
RUMROUT_RoutingLineComponentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMROUT] Performing VerifyExists on RoutingLineComponents_ComponentPart...", Logger.MessageType.INF);
				SeleniumControl RUMROUT_RoutingLineComponents_ComponentPart = new SeleniumControl( sDriver, "RoutingLineComponents_ComponentPart", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMROUT_ROUTINGLNCOMP_CTW_']/ancestor::form[1]/descendant::*[@id='COMP_PART_ID']");
				Function.AssertEqual(true,RUMROUT_RoutingLineComponents_ComponentPart.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMROUT] Performing Close on RoutingLineComponentsForm...", Logger.MessageType.INF);
				SeleniumControl RUMROUT_RoutingLineComponentsForm = new SeleniumControl( sDriver, "RoutingLineComponentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMROUT_ROUTINGLNCOMP_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(RUMROUT_RoutingLineComponentsForm);
IWebElement formBttn = RUMROUT_RoutingLineComponentsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("STANDARDTEXTLINK");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMROUT] Performing Click on ChildForm_StandardTextLink...", Logger.MessageType.INF);
				SeleniumControl RUMROUT_ChildForm_StandardTextLink = new SeleniumControl( sDriver, "ChildForm_StandardTextLink", "ID", "lnk_1006466_RUMROUT_ROUTINGLN_CTW");
				Function.WaitControlDisplayed(RUMROUT_ChildForm_StandardTextLink);
RUMROUT_ChildForm_StandardTextLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMROUT] Performing VerifyExist on StandardTextFormTable...", Logger.MessageType.INF);
				SeleniumControl RUMROUT_StandardTextFormTable = new SeleniumControl( sDriver, "StandardTextFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMROUT_ROUTINGLNTEXT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,RUMROUT_StandardTextFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMROUT] Performing VerifyExists on StandardTextForm...", Logger.MessageType.INF);
				SeleniumControl RUMROUT_StandardTextForm = new SeleniumControl( sDriver, "StandardTextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMROUT_ROUTINGLNTEXT_']/ancestor::form[1]");
				Function.AssertEqual(true,RUMROUT_StandardTextForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMROUT] Performing ClickButton on StandardTextForm...", Logger.MessageType.INF);
				SeleniumControl RUMROUT_StandardTextForm = new SeleniumControl( sDriver, "StandardTextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMROUT_ROUTINGLNTEXT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(RUMROUT_StandardTextForm);
IWebElement formBttn = RUMROUT_StandardTextForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? RUMROUT_StandardTextForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
RUMROUT_StandardTextForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMROUT] Performing VerifyExists on StandardText_Sequence...", Logger.MessageType.INF);
				SeleniumControl RUMROUT_StandardText_Sequence = new SeleniumControl( sDriver, "StandardText_Sequence", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMROUT_ROUTINGLNTEXT_']/ancestor::form[1]/descendant::*[@id='SEQ_NO']");
				Function.AssertEqual(true,RUMROUT_StandardText_Sequence.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMROUT] Performing Close on StandardTextForm...", Logger.MessageType.INF);
				SeleniumControl RUMROUT_StandardTextForm = new SeleniumControl( sDriver, "StandardTextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMROUT_ROUTINGLNTEXT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(RUMROUT_StandardTextForm);
IWebElement formBttn = RUMROUT_StandardTextForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("DOCUMENTS");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMROUT] Performing Click on ChildForm_DocumentsLink...", Logger.MessageType.INF);
				SeleniumControl RUMROUT_ChildForm_DocumentsLink = new SeleniumControl( sDriver, "ChildForm_DocumentsLink", "ID", "lnk_1006467_RUMROUT_ROUTINGLN_CTW");
				Function.WaitControlDisplayed(RUMROUT_ChildForm_DocumentsLink);
RUMROUT_ChildForm_DocumentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMROUT] Performing VerifyExist on DocumentsFormTable...", Logger.MessageType.INF);
				SeleniumControl RUMROUT_DocumentsFormTable = new SeleniumControl( sDriver, "DocumentsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMROUT_ROUTINGLNDOC_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,RUMROUT_DocumentsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMROUT] Performing VerifyExists on DocumentsForm...", Logger.MessageType.INF);
				SeleniumControl RUMROUT_DocumentsForm = new SeleniumControl( sDriver, "DocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMROUT_ROUTINGLNDOC_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,RUMROUT_DocumentsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMROUT] Performing ClickButton on DocumentsForm...", Logger.MessageType.INF);
				SeleniumControl RUMROUT_DocumentsForm = new SeleniumControl( sDriver, "DocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMROUT_ROUTINGLNDOC_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(RUMROUT_DocumentsForm);
IWebElement formBttn = RUMROUT_DocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? RUMROUT_DocumentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
RUMROUT_DocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMROUT] Performing VerifyExists on Documents_Document...", Logger.MessageType.INF);
				SeleniumControl RUMROUT_Documents_Document = new SeleniumControl( sDriver, "Documents_Document", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMROUT_ROUTINGLNDOC_CTW_']/ancestor::form[1]/descendant::*[@id='DOCUMENT_ID']");
				Function.AssertEqual(true,RUMROUT_Documents_Document.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMROUT] Performing Close on DocumentsForm...", Logger.MessageType.INF);
				SeleniumControl RUMROUT_DocumentsForm = new SeleniumControl( sDriver, "DocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMROUT_ROUTINGLNDOC_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(RUMROUT_DocumentsForm);
IWebElement formBttn = RUMROUT_DocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("EQUIPMENT");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMROUT] Performing Click on ChildForm_EquipmentLink...", Logger.MessageType.INF);
				SeleniumControl RUMROUT_ChildForm_EquipmentLink = new SeleniumControl( sDriver, "ChildForm_EquipmentLink", "ID", "lnk_15787_RUMROUT_ROUTINGLN_CTW");
				Function.WaitControlDisplayed(RUMROUT_ChildForm_EquipmentLink);
RUMROUT_ChildForm_EquipmentLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMROUT] Performing VerifyExist on EquipmentFormTable...", Logger.MessageType.INF);
				SeleniumControl RUMROUT_EquipmentFormTable = new SeleniumControl( sDriver, "EquipmentFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMROUT_ROUTINGLNEQUIP_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,RUMROUT_EquipmentFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMROUT] Performing VerifyExists on EquipmentForm...", Logger.MessageType.INF);
				SeleniumControl RUMROUT_EquipmentForm = new SeleniumControl( sDriver, "EquipmentForm", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMROUT_ROUTINGLNEQUIP_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,RUMROUT_EquipmentForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMROUT] Performing ClickButton on EquipmentForm...", Logger.MessageType.INF);
				SeleniumControl RUMROUT_EquipmentForm = new SeleniumControl( sDriver, "EquipmentForm", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMROUT_ROUTINGLNEQUIP_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(RUMROUT_EquipmentForm);
IWebElement formBttn = RUMROUT_EquipmentForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? RUMROUT_EquipmentForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
RUMROUT_EquipmentForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMROUT] Performing VerifyExists on Equipment_Equipment...", Logger.MessageType.INF);
				SeleniumControl RUMROUT_Equipment_Equipment = new SeleniumControl( sDriver, "Equipment_Equipment", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMROUT_ROUTINGLNEQUIP_CTW_']/ancestor::form[1]/descendant::*[@id='EQUIP_ID']");
				Function.AssertEqual(true,RUMROUT_Equipment_Equipment.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMROUT] Performing Close on EquipmentForm...", Logger.MessageType.INF);
				SeleniumControl RUMROUT_EquipmentForm = new SeleniumControl( sDriver, "EquipmentForm", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMROUT_ROUTINGLNEQUIP_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(RUMROUT_EquipmentForm);
IWebElement formBttn = RUMROUT_EquipmentForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("LABORCLASSIFICATION");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMROUT] Performing Click on ChildForm_LaborClassificationsLink...", Logger.MessageType.INF);
				SeleniumControl RUMROUT_ChildForm_LaborClassificationsLink = new SeleniumControl( sDriver, "ChildForm_LaborClassificationsLink", "ID", "lnk_15788_RUMROUT_ROUTINGLN_CTW");
				Function.WaitControlDisplayed(RUMROUT_ChildForm_LaborClassificationsLink);
RUMROUT_ChildForm_LaborClassificationsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMROUT] Performing VerifyExist on LaborClassificationsFormTable...", Logger.MessageType.INF);
				SeleniumControl RUMROUT_LaborClassificationsFormTable = new SeleniumControl( sDriver, "LaborClassificationsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMROUT_ROUTINGLNLAB_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,RUMROUT_LaborClassificationsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMROUT] Performing ClickButton on LaborClassificationsForm...", Logger.MessageType.INF);
				SeleniumControl RUMROUT_LaborClassificationsForm = new SeleniumControl( sDriver, "LaborClassificationsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMROUT_ROUTINGLNLAB_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(RUMROUT_LaborClassificationsForm);
IWebElement formBttn = RUMROUT_LaborClassificationsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? RUMROUT_LaborClassificationsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
RUMROUT_LaborClassificationsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMROUT] Performing VerifyExists on LaborClassificationsForm...", Logger.MessageType.INF);
				SeleniumControl RUMROUT_LaborClassificationsForm = new SeleniumControl( sDriver, "LaborClassificationsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMROUT_ROUTINGLNLAB_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,RUMROUT_LaborClassificationsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMROUT] Performing VerifyExists on LaborClassifications_LaborClassification...", Logger.MessageType.INF);
				SeleniumControl RUMROUT_LaborClassifications_LaborClassification = new SeleniumControl( sDriver, "LaborClassifications_LaborClassification", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMROUT_ROUTINGLNLAB_CTW_']/ancestor::form[1]/descendant::*[@id='RU_LAB_CLASS_CD']");
				Function.AssertEqual(true,RUMROUT_LaborClassifications_LaborClassification.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMROUT] Performing Close on LaborClassificationsForm...", Logger.MessageType.INF);
				SeleniumControl RUMROUT_LaborClassificationsForm = new SeleniumControl( sDriver, "LaborClassificationsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMROUT_ROUTINGLNLAB_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(RUMROUT_LaborClassificationsForm);
IWebElement formBttn = RUMROUT_LaborClassificationsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("ALTERNATEWORKCENTER");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMROUT] Performing Click on ChildForm_AlternateWorkCenterLink...", Logger.MessageType.INF);
				SeleniumControl RUMROUT_ChildForm_AlternateWorkCenterLink = new SeleniumControl( sDriver, "ChildForm_AlternateWorkCenterLink", "ID", "lnk_4586_RUMROUT_ROUTINGLN_CTW");
				Function.WaitControlDisplayed(RUMROUT_ChildForm_AlternateWorkCenterLink);
RUMROUT_ChildForm_AlternateWorkCenterLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMROUT] Performing VerifyExist on AlternateWorkCenterFormTable...", Logger.MessageType.INF);
				SeleniumControl RUMROUT_AlternateWorkCenterFormTable = new SeleniumControl( sDriver, "AlternateWorkCenterFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__MM_ALTWORKCENTER_HDR_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,RUMROUT_AlternateWorkCenterFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMROUT] Performing Close on AlternateWorkCenterForm...", Logger.MessageType.INF);
				SeleniumControl RUMROUT_AlternateWorkCenterForm = new SeleniumControl( sDriver, "AlternateWorkCenterForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MM_ALTWORKCENTER_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(RUMROUT_AlternateWorkCenterForm);
IWebElement formBttn = RUMROUT_AlternateWorkCenterForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMROUT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMROUT] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl RUMROUT_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(RUMROUT_MainForm);
IWebElement formBttn = RUMROUT_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

