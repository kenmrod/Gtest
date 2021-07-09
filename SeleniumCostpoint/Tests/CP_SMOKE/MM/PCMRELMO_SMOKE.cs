 
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
    public class PCMRELMO_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Manufacturing Orders", "xpath","//div[@class='navItem'][.='Manufacturing Orders']").Click();
new SeleniumControl(sDriver,"Enter Manufacturing Order Reliefs", "xpath","//div[@class='navItem'][.='Enter Manufacturing Order Reliefs']").Click();


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
				Function.CurrentComponent = "PCMRELMO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMRELMO] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl PCMRELMO_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,PCMRELMO_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMRELMO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMRELMO] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl PCMRELMO_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PCMRELMO_MainForm);
IWebElement formBttn = PCMRELMO_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? PCMRELMO_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
PCMRELMO_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMRELMO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMRELMO] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl PCMRELMO_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PCMRELMO_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMRELMO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMRELMO] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl PCMRELMO_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PCMRELMO_MainForm);
IWebElement formBttn = PCMRELMO_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PCMRELMO_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PCMRELMO_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMRELMO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMRELMO] Performing VerifyExists on Identification_Warehouse...", Logger.MessageType.INF);
				SeleniumControl PCMRELMO_Identification_Warehouse = new SeleniumControl( sDriver, "Identification_Warehouse", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='WHSE_ID']");
				Function.AssertEqual(true,PCMRELMO_Identification_Warehouse.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMRELMO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMRELMO] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl PCMRELMO_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PCMRELMO_MainFormTab);
IWebElement mTab = PCMRELMO_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "MO Details").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMRELMO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMRELMO] Performing VerifyExists on MODetails_BuildPart...", Logger.MessageType.INF);
				SeleniumControl PCMRELMO_MODetails_BuildPart = new SeleniumControl( sDriver, "MODetails_BuildPart", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='BUILD_PART_ID']");
				Function.AssertEqual(true,PCMRELMO_MODetails_BuildPart.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMRELMO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMRELMO] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl PCMRELMO_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PCMRELMO_MainFormTab);
IWebElement mTab = PCMRELMO_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Partial Relief").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMRELMO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMRELMO] Performing VerifyExists on PartialRelief_ETCPercent...", Logger.MessageType.INF);
				SeleniumControl PCMRELMO_PartialRelief_ETCPercent = new SeleniumControl( sDriver, "PartialRelief_ETCPercent", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='ETC_PCT_RT']");
				Function.AssertEqual(true,PCMRELMO_PartialRelief_ETCPercent.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMRELMO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMRELMO] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl PCMRELMO_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PCMRELMO_MainFormTab);
IWebElement mTab = PCMRELMO_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Notes").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMRELMO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMRELMO] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl PCMRELMO_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PCMRELMO_MainFormTab);
IWebElement mTab = PCMRELMO_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Allow Charges").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMRELMO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMRELMO] Performing VerifyExists on AllowCharges_Timesheets...", Logger.MessageType.INF);
				SeleniumControl PCMRELMO_AllowCharges_Timesheets = new SeleniumControl( sDriver, "AllowCharges_Timesheets", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='ALLOW_TIMESHEET_FL']");
				Function.AssertEqual(true,PCMRELMO_AllowCharges_Timesheets.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMRELMO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMRELMO] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl PCMRELMO_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PCMRELMO_MainForm);
IWebElement formBttn = PCMRELMO_MainForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).Count <= 0 ? PCMRELMO_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Query')]")).FirstOrDefault() :
PCMRELMO_MainForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Query not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "Query";
								SeleniumControl ctl = new SeleniumControl(sDriver,"Target", "xpath_display", "//*[@id='basicQTbl']/tbody/tr/td/span[text()='Relief ID']");
Function.WaitControlDisplayed(ctl);
SeleniumControl RelationshipField = new SeleniumControl(sDriver,"Relationship", ctl.mElement.FindElement(By.XPath("../following-sibling::td[1]")));
SeleniumControl SearchField = new SeleniumControl(sDriver,"Relationship", ctl.mElement.FindElement(By.XPath("../following-sibling::td[2]")));
new SeleniumControl(sDriver, "RelDropdown", RelationshipField.mElement.FindElements(By.XPath("./descendant::*[@class='tCCBImg']")).FirstOrDefault()).Click();
new SeleniumControl(sDriver, "RelItem", "xpath_display", ".//descendant::div[text() = 'begins with']").Click();
if (SearchField.mElement.GetAttribute("class").Equals("tCCB")) {
new SeleniumControl(sDriver, "SearchDropdown", SearchField.mElement.FindElements(By.XPath(".//descendant::*[@class='tCCBImg']")).FirstOrDefault()).Click();
new SeleniumControl(sDriver, "SearchItem", "xpath_display", ".//descendant::div[text()='']").Click();
} else { 
new SeleniumControl(sDriver, "SearchDropdown", SearchField.mElement.FindElements(By.XPath(".//descendant::*[@class='queryBasicFld']")).FirstOrDefault()).SendKeys("");}


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
				this.ScriptLogger.WriteLine("Child Form");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMRELMO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMRELMO] Performing VerifyExists on ChildForm...", Logger.MessageType.INF);
				SeleniumControl PCMRELMO_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMRELMO_INVTTRANSLINES_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,PCMRELMO_ChildForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMRELMO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMRELMO] Performing ClickButton on ChildForm...", Logger.MessageType.INF);
				SeleniumControl PCMRELMO_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMRELMO_INVTTRANSLINES_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCMRELMO_ChildForm);
IWebElement formBttn = PCMRELMO_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? PCMRELMO_ChildForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
PCMRELMO_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMRELMO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMRELMO] Performing VerifyExist on ChildFormTable...", Logger.MessageType.INF);
				SeleniumControl PCMRELMO_ChildFormTable = new SeleniumControl( sDriver, "ChildFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMRELMO_INVTTRANSLINES_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PCMRELMO_ChildFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMRELMO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMRELMO] Performing ClickButton on ChildForm...", Logger.MessageType.INF);
				SeleniumControl PCMRELMO_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMRELMO_INVTTRANSLINES_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCMRELMO_ChildForm);
IWebElement formBttn = PCMRELMO_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PCMRELMO_ChildForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PCMRELMO_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMRELMO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMRELMO] Performing Select on ChildFormTab...", Logger.MessageType.INF);
				SeleniumControl PCMRELMO_ChildFormTab = new SeleniumControl( sDriver, "ChildFormTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMRELMO_INVTTRANSLINES_CTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PCMRELMO_ChildFormTab);
IWebElement mTab = PCMRELMO_ChildFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Relief info").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMRELMO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMRELMO] Performing VerifyExists on ChildForm_ReliefInfo_RelieveToInvAbbrev...", Logger.MessageType.INF);
				SeleniumControl PCMRELMO_ChildForm_ReliefInfo_RelieveToInvAbbrev = new SeleniumControl( sDriver, "ChildForm_ReliefInfo_RelieveToInvAbbrev", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMRELMO_INVTTRANSLINES_CTW_']/ancestor::form[1]/descendant::*[@id='INVT_ABBRV_CD_TO']");
				Function.AssertEqual(true,PCMRELMO_ChildForm_ReliefInfo_RelieveToInvAbbrev.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMRELMO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMRELMO] Performing Select on ChildFormTab...", Logger.MessageType.INF);
				SeleniumControl PCMRELMO_ChildFormTab = new SeleniumControl( sDriver, "ChildFormTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMRELMO_INVTTRANSLINES_CTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PCMRELMO_ChildFormTab);
IWebElement mTab = PCMRELMO_ChildFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Other info").FirstOrDefault();
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
				this.ScriptLogger.WriteLine("Accounting Period");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMRELMO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMRELMO] Performing VerifyExists on AccountingPeriodLink...", Logger.MessageType.INF);
				SeleniumControl PCMRELMO_AccountingPeriodLink = new SeleniumControl( sDriver, "AccountingPeriodLink", "ID", "lnk_4218_PCMRELMO_INVTTRN_HDR1");
				Function.AssertEqual(true,PCMRELMO_AccountingPeriodLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMRELMO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMRELMO] Performing Click on AccountingPeriodLink...", Logger.MessageType.INF);
				SeleniumControl PCMRELMO_AccountingPeriodLink = new SeleniumControl( sDriver, "AccountingPeriodLink", "ID", "lnk_4218_PCMRELMO_INVTTRN_HDR1");
				Function.WaitControlDisplayed(PCMRELMO_AccountingPeriodLink);
PCMRELMO_AccountingPeriodLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMRELMO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMRELMO] Performing VerifyExists on AccountingPeriodForm...", Logger.MessageType.INF);
				SeleniumControl PCMRELMO_AccountingPeriodForm = new SeleniumControl( sDriver, "AccountingPeriodForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMACCPD_HDR_']/ancestor::form[1]");
				Function.AssertEqual(true,PCMRELMO_AccountingPeriodForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMRELMO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMRELMO] Performing VerifyExists on AccountingPeriod_Period...", Logger.MessageType.INF);
				SeleniumControl PCMRELMO_AccountingPeriod_Period = new SeleniumControl( sDriver, "AccountingPeriod_Period", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMACCPD_HDR_']/ancestor::form[1]/descendant::*[@id='DFN_PDNO_ST']");
				Function.AssertEqual(true,PCMRELMO_AccountingPeriod_Period.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMRELMO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMRELMO] Performing ClickButton on AccountingPeriodForm...", Logger.MessageType.INF);
				SeleniumControl PCMRELMO_AccountingPeriodForm = new SeleniumControl( sDriver, "AccountingPeriodForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMACCPD_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCMRELMO_AccountingPeriodForm);
IWebElement formBttn = PCMRELMO_AccountingPeriodForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? PCMRELMO_AccountingPeriodForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
PCMRELMO_AccountingPeriodForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMRELMO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMRELMO] Performing VerifyExist on AccountingPeriodTable...", Logger.MessageType.INF);
				SeleniumControl PCMRELMO_AccountingPeriodTable = new SeleniumControl( sDriver, "AccountingPeriodTable", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMACCPD_HDR_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PCMRELMO_AccountingPeriodTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMRELMO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMRELMO] Performing Close on AccountingPeriodForm...", Logger.MessageType.INF);
				SeleniumControl PCMRELMO_AccountingPeriodForm = new SeleniumControl( sDriver, "AccountingPeriodForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMACCPD_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCMRELMO_AccountingPeriodForm);
IWebElement formBttn = PCMRELMO_AccountingPeriodForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("MO Documents");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMRELMO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMRELMO] Performing VerifyExists on MODocumentsLink...", Logger.MessageType.INF);
				SeleniumControl PCMRELMO_MODocumentsLink = new SeleniumControl( sDriver, "MODocumentsLink", "ID", "lnk_4408_PCMRELMO_INVTTRN_HDR1");
				Function.AssertEqual(true,PCMRELMO_MODocumentsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMRELMO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMRELMO] Performing Click on MODocumentsLink...", Logger.MessageType.INF);
				SeleniumControl PCMRELMO_MODocumentsLink = new SeleniumControl( sDriver, "MODocumentsLink", "ID", "lnk_4408_PCMRELMO_INVTTRN_HDR1");
				Function.WaitControlDisplayed(PCMRELMO_MODocumentsLink);
PCMRELMO_MODocumentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMRELMO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMRELMO] Performing VerifyExists on MODocumentsForm...", Logger.MessageType.INF);
				SeleniumControl PCMRELMO_MODocumentsForm = new SeleniumControl( sDriver, "MODocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMRELMO_MODOCUMENT_']/ancestor::form[1]");
				Function.AssertEqual(true,PCMRELMO_MODocumentsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMRELMO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMRELMO] Performing VerifyExist on MODocumentsTable...", Logger.MessageType.INF);
				SeleniumControl PCMRELMO_MODocumentsTable = new SeleniumControl( sDriver, "MODocumentsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMRELMO_MODOCUMENT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PCMRELMO_MODocumentsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMRELMO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMRELMO] Performing ClickButton on MODocumentsForm...", Logger.MessageType.INF);
				SeleniumControl PCMRELMO_MODocumentsForm = new SeleniumControl( sDriver, "MODocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMRELMO_MODOCUMENT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCMRELMO_MODocumentsForm);
IWebElement formBttn = PCMRELMO_MODocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PCMRELMO_MODocumentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PCMRELMO_MODocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMRELMO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMRELMO] Performing VerifyExists on MODocuments_Document...", Logger.MessageType.INF);
				SeleniumControl PCMRELMO_MODocuments_Document = new SeleniumControl( sDriver, "MODocuments_Document", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMRELMO_MODOCUMENT_']/ancestor::form[1]/descendant::*[@id='DOCUMENT_ID']");
				Function.AssertEqual(true,PCMRELMO_MODocuments_Document.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMRELMO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMRELMO] Performing Close on MODocumentsForm...", Logger.MessageType.INF);
				SeleniumControl PCMRELMO_MODocumentsForm = new SeleniumControl( sDriver, "MODocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMRELMO_MODOCUMENT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCMRELMO_MODocumentsForm);
IWebElement formBttn = PCMRELMO_MODocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "PCMRELMO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMRELMO] Performing VerifyExists on PartDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl PCMRELMO_PartDocumentsLink = new SeleniumControl( sDriver, "PartDocumentsLink", "ID", "lnk_4340_PCMRELMO_INVTTRN_HDR1");
				Function.AssertEqual(true,PCMRELMO_PartDocumentsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMRELMO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMRELMO] Performing Click on PartDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl PCMRELMO_PartDocumentsLink = new SeleniumControl( sDriver, "PartDocumentsLink", "ID", "lnk_4340_PCMRELMO_INVTTRN_HDR1");
				Function.WaitControlDisplayed(PCMRELMO_PartDocumentsLink);
PCMRELMO_PartDocumentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMRELMO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMRELMO] Performing VerifyExists on PartDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl PCMRELMO_PartDocumentsForm = new SeleniumControl( sDriver, "PartDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]");
				Function.AssertEqual(true,PCMRELMO_PartDocumentsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMRELMO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMRELMO] Performing VerifyExist on PartDocumentsTable...", Logger.MessageType.INF);
				SeleniumControl PCMRELMO_PartDocumentsTable = new SeleniumControl( sDriver, "PartDocumentsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PCMRELMO_PartDocumentsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMRELMO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMRELMO] Performing ClickButton on PartDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl PCMRELMO_PartDocumentsForm = new SeleniumControl( sDriver, "PartDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCMRELMO_PartDocumentsForm);
IWebElement formBttn = PCMRELMO_PartDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PCMRELMO_PartDocumentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PCMRELMO_PartDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMRELMO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMRELMO] Performing VerifyExists on PartDocuments_Rev...", Logger.MessageType.INF);
				SeleniumControl PCMRELMO_PartDocuments_Rev = new SeleniumControl( sDriver, "PartDocuments_Rev", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]/descendant::*[@id='DOCUMENT_RVSN_ID']");
				Function.AssertEqual(true,PCMRELMO_PartDocuments_Rev.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMRELMO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMRELMO] Performing Close on PartDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl PCMRELMO_PartDocumentsForm = new SeleniumControl( sDriver, "PartDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCMRELMO_PartDocumentsForm);
IWebElement formBttn = PCMRELMO_PartDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Cost");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMRELMO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMRELMO] Performing VerifyExists on CostLink...", Logger.MessageType.INF);
				SeleniumControl PCMRELMO_CostLink = new SeleniumControl( sDriver, "CostLink", "ID", "lnk_4712_PCMRELMO_INVTTRN_HDR1");
				Function.AssertEqual(true,PCMRELMO_CostLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMRELMO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMRELMO] Performing Click on CostLink...", Logger.MessageType.INF);
				SeleniumControl PCMRELMO_CostLink = new SeleniumControl( sDriver, "CostLink", "ID", "lnk_4712_PCMRELMO_INVTTRN_HDR1");
				Function.WaitControlDisplayed(PCMRELMO_CostLink);
PCMRELMO_CostLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMRELMO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMRELMO] Performing VerifyExists on CostForm...", Logger.MessageType.INF);
				SeleniumControl PCMRELMO_CostForm = new SeleniumControl( sDriver, "CostForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMRELMO_COSTINFO_']/ancestor::form[1]");
				Function.AssertEqual(true,PCMRELMO_CostForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMRELMO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMRELMO] Performing VerifyExists on Cost_CostType...", Logger.MessageType.INF);
				SeleniumControl PCMRELMO_Cost_CostType = new SeleniumControl( sDriver, "Cost_CostType", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMRELMO_COSTINFO_']/ancestor::form[1]/descendant::*[@id='COST_TYPE']");
				Function.AssertEqual(true,PCMRELMO_Cost_CostType.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMRELMO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMRELMO] Performing Close on CostForm...", Logger.MessageType.INF);
				SeleniumControl PCMRELMO_CostForm = new SeleniumControl( sDriver, "CostForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMRELMO_COSTINFO_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCMRELMO_CostForm);
IWebElement formBttn = PCMRELMO_CostForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Autoload to fill up MO-Serial/Lot Info");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMRELMO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMRELMO] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl PCMRELMO_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,PCMRELMO_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMRELMO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMRELMO] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl PCMRELMO_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PCMRELMO_MainForm);
IWebElement formBttn = PCMRELMO_MainForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).Count <= 0 ? PCMRELMO_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Query')]")).FirstOrDefault() :
PCMRELMO_MainForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Query not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "Query";
								SeleniumControl ctl = new SeleniumControl(sDriver,"Target", "xpath_display", "//*[@id='basicQTbl']/tbody/tr/td/span[text()='Relief ID']");
Function.WaitControlDisplayed(ctl);
SeleniumControl RelationshipField = new SeleniumControl(sDriver,"Relationship", ctl.mElement.FindElement(By.XPath("../following-sibling::td[1]")));
SeleniumControl SearchField = new SeleniumControl(sDriver,"Relationship", ctl.mElement.FindElement(By.XPath("../following-sibling::td[2]")));
new SeleniumControl(sDriver, "RelDropdown", RelationshipField.mElement.FindElements(By.XPath("./descendant::*[@class='tCCBImg']")).FirstOrDefault()).Click();
new SeleniumControl(sDriver, "RelItem", "xpath_display", ".//descendant::div[text() = 'is equal to']").Click();
if (SearchField.mElement.GetAttribute("class").Equals("tCCB")) {
new SeleniumControl(sDriver, "SearchDropdown", SearchField.mElement.FindElements(By.XPath(".//descendant::*[@class='tCCBImg']")).FirstOrDefault()).Click();
new SeleniumControl(sDriver, "SearchItem", "xpath_display", ".//descendant::div[text()='PL31-00004']").Click();
} else { 
new SeleniumControl(sDriver, "SearchDropdown", SearchField.mElement.FindElements(By.XPath(".//descendant::*[@class='queryBasicFld']")).FirstOrDefault()).SendKeys("PL31-00004");}


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
				this.ScriptLogger.WriteLine("MO-Serial/Lot Info");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMRELMO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMRELMO] Performing VerifyExists on ChildForm_MOSerialLotInfoLink...", Logger.MessageType.INF);
				SeleniumControl PCMRELMO_ChildForm_MOSerialLotInfoLink = new SeleniumControl( sDriver, "ChildForm_MOSerialLotInfoLink", "ID", "lnk_4696_PCMRELMO_INVTTRANSLINES_CTW");
				Function.AssertEqual(true,PCMRELMO_ChildForm_MOSerialLotInfoLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMRELMO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMRELMO] Performing Click on ChildForm_MOSerialLotInfoLink...", Logger.MessageType.INF);
				SeleniumControl PCMRELMO_ChildForm_MOSerialLotInfoLink = new SeleniumControl( sDriver, "ChildForm_MOSerialLotInfoLink", "ID", "lnk_4696_PCMRELMO_INVTTRANSLINES_CTW");
				Function.WaitControlDisplayed(PCMRELMO_ChildForm_MOSerialLotInfoLink);
PCMRELMO_ChildForm_MOSerialLotInfoLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMRELMO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMRELMO] Performing VerifyExists on MOSerialLotInfoForm...", Logger.MessageType.INF);
				SeleniumControl PCMRELMO_MOSerialLotInfoForm = new SeleniumControl( sDriver, "MOSerialLotInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMRELMO_MMMSRLT_']/ancestor::form[1]");
				Function.AssertEqual(true,PCMRELMO_MOSerialLotInfoForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMRELMO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMRELMO] Performing VerifyExist on MOSerialLotInfoTable...", Logger.MessageType.INF);
				SeleniumControl PCMRELMO_MOSerialLotInfoTable = new SeleniumControl( sDriver, "MOSerialLotInfoTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMRELMO_MMMSRLT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PCMRELMO_MOSerialLotInfoTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMRELMO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMRELMO] Performing ClickButton on MOSerialLotInfoForm...", Logger.MessageType.INF);
				SeleniumControl PCMRELMO_MOSerialLotInfoForm = new SeleniumControl( sDriver, "MOSerialLotInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMRELMO_MMMSRLT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCMRELMO_MOSerialLotInfoForm);
IWebElement formBttn = PCMRELMO_MOSerialLotInfoForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PCMRELMO_MOSerialLotInfoForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PCMRELMO_MOSerialLotInfoForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMRELMO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMRELMO] Performing VerifyExists on MOSerialLotInfoTab...", Logger.MessageType.INF);
				SeleniumControl PCMRELMO_MOSerialLotInfoTab = new SeleniumControl( sDriver, "MOSerialLotInfoTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMRELMO_MMMSRLT_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.AssertEqual(true,PCMRELMO_MOSerialLotInfoTab.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMRELMO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMRELMO] Performing Select on MOSerialLotInfoTab...", Logger.MessageType.INF);
				SeleniumControl PCMRELMO_MOSerialLotInfoTab = new SeleniumControl( sDriver, "MOSerialLotInfoTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMRELMO_MMMSRLT_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PCMRELMO_MOSerialLotInfoTab);
IWebElement mTab = PCMRELMO_MOSerialLotInfoTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Basic Information").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMRELMO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMRELMO] Performing VerifyExists on MOSerialLotInfo_BasicInformation_Quantity...", Logger.MessageType.INF);
				SeleniumControl PCMRELMO_MOSerialLotInfo_BasicInformation_Quantity = new SeleniumControl( sDriver, "MOSerialLotInfo_BasicInformation_Quantity", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMRELMO_MMMSRLT_']/ancestor::form[1]/descendant::*[@id='TRN_QTY']");
				Function.AssertEqual(true,PCMRELMO_MOSerialLotInfo_BasicInformation_Quantity.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMRELMO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMRELMO] Performing Select on MOSerialLotInfoTab...", Logger.MessageType.INF);
				SeleniumControl PCMRELMO_MOSerialLotInfoTab = new SeleniumControl( sDriver, "MOSerialLotInfoTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMRELMO_MMMSRLT_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PCMRELMO_MOSerialLotInfoTab);
IWebElement mTab = PCMRELMO_MOSerialLotInfoTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Manufacturer/Vendor Information").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMRELMO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMRELMO] Performing VerifyExists on MOSerialLotInfo_ManufacturerVendorInformation_Manufacturer_Manufacturer...", Logger.MessageType.INF);
				SeleniumControl PCMRELMO_MOSerialLotInfo_ManufacturerVendorInformation_Manufacturer_Manufacturer = new SeleniumControl( sDriver, "MOSerialLotInfo_ManufacturerVendorInformation_Manufacturer_Manufacturer", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMRELMO_MMMSRLT_']/ancestor::form[1]/descendant::*[@id='MANUF_ID']");
				Function.AssertEqual(true,PCMRELMO_MOSerialLotInfo_ManufacturerVendorInformation_Manufacturer_Manufacturer.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMRELMO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMRELMO] Performing Select on MOSerialLotInfoTab...", Logger.MessageType.INF);
				SeleniumControl PCMRELMO_MOSerialLotInfoTab = new SeleniumControl( sDriver, "MOSerialLotInfoTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMRELMO_MMMSRLT_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PCMRELMO_MOSerialLotInfoTab);
IWebElement mTab = PCMRELMO_MOSerialLotInfoTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Sales Order/Warranty Information").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMRELMO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMRELMO] Performing VerifyExists on MOSerialLotInfo_SalesOrderWarrantyInformation_SalesOrderInformation_SalesOrder...", Logger.MessageType.INF);
				SeleniumControl PCMRELMO_MOSerialLotInfo_SalesOrderWarrantyInformation_SalesOrderInformation_SalesOrder = new SeleniumControl( sDriver, "MOSerialLotInfo_SalesOrderWarrantyInformation_SalesOrderInformation_SalesOrder", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMRELMO_MMMSRLT_']/ancestor::form[1]/descendant::*[@id='MAINT_SO_ID']");
				Function.AssertEqual(true,PCMRELMO_MOSerialLotInfo_SalesOrderWarrantyInformation_SalesOrderInformation_SalesOrder.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMRELMO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMRELMO] Performing Select on MOSerialLotInfoTab...", Logger.MessageType.INF);
				SeleniumControl PCMRELMO_MOSerialLotInfoTab = new SeleniumControl( sDriver, "MOSerialLotInfoTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMRELMO_MMMSRLT_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PCMRELMO_MOSerialLotInfoTab);
IWebElement mTab = PCMRELMO_MOSerialLotInfoTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "User-Defined Info").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMRELMO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMRELMO] Performing Select on MOSerialLotInfoTab...", Logger.MessageType.INF);
				SeleniumControl PCMRELMO_MOSerialLotInfoTab = new SeleniumControl( sDriver, "MOSerialLotInfoTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMRELMO_MMMSRLT_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PCMRELMO_MOSerialLotInfoTab);
IWebElement mTab = PCMRELMO_MOSerialLotInfoTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Notes").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMRELMO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMRELMO] Performing Select on MOSerialLotInfoTab...", Logger.MessageType.INF);
				SeleniumControl PCMRELMO_MOSerialLotInfoTab = new SeleniumControl( sDriver, "MOSerialLotInfoTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMRELMO_MMMSRLT_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PCMRELMO_MOSerialLotInfoTab);
IWebElement mTab = PCMRELMO_MOSerialLotInfoTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Shelf Life").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMRELMO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMRELMO] Performing VerifyExists on ChildForm_MOSerialLotInfo_ShelfLife_ShelfLife_ShelfLifeExpirationDate...", Logger.MessageType.INF);
				SeleniumControl PCMRELMO_ChildForm_MOSerialLotInfo_ShelfLife_ShelfLife_ShelfLifeExpirationDate = new SeleniumControl( sDriver, "ChildForm_MOSerialLotInfo_ShelfLife_ShelfLife_ShelfLifeExpirationDate", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMRELMO_MMMSRLT_']/ancestor::form[1]/descendant::*[@id='SHELF_LIFE_EXP_DT']");
				Function.AssertEqual(true,PCMRELMO_ChildForm_MOSerialLotInfo_ShelfLife_ShelfLife_ShelfLifeExpirationDate.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMRELMO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMRELMO] Performing Close on MOSerialLotInfoForm...", Logger.MessageType.INF);
				SeleniumControl PCMRELMO_MOSerialLotInfoForm = new SeleniumControl( sDriver, "MOSerialLotInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMRELMO_MMMSRLT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCMRELMO_MOSerialLotInfoForm);
IWebElement formBttn = PCMRELMO_MOSerialLotInfoForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Closing Main Form");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMRELMO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMRELMO] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl PCMRELMO_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PCMRELMO_MainForm);
IWebElement formBttn = PCMRELMO_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

