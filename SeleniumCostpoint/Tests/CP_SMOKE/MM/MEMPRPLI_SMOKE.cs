 
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
    public class MEMPRPLI_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Materials Estimating", "xpath","//div[@class='deptItem'][.='Materials Estimating']").Click();
new SeleniumControl(sDriver,"Proposal Item Costing", "xpath","//div[@class='navItem'][.='Proposal Item Costing']").Click();
new SeleniumControl(sDriver,"Manage Proposal BOM Cost Estimates - Indented", "xpath","//div[@class='navItem'][.='Manage Proposal BOM Cost Estimates - Indented']").Click();


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
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,MEMPRPLI_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing VerifyExists on MainForm_Identification_Proposal...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_MainForm_Identification_Proposal = new SeleniumControl( sDriver, "MainForm_Identification_Proposal", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PROP_ID']");
				Function.AssertEqual(true,MEMPRPLI_MainForm_Identification_Proposal.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing Set on MainForm_Identification_Proposal...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_MainForm_Identification_Proposal = new SeleniumControl( sDriver, "MainForm_Identification_Proposal", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PROP_ID']");
				MEMPRPLI_MainForm_Identification_Proposal.Click();
MEMPRPLI_MainForm_Identification_Proposal.SendKeys("NW-TESTINGPROP12345Z", true);
Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));
MEMPRPLI_MainForm_Identification_Proposal.SendKeys(OpenQA.Selenium.Keys.Shift + OpenQA.Selenium.Keys.Tab);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Set]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing Set on MainForm_Identification_Assembly...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_MainForm_Identification_Assembly = new SeleniumControl( sDriver, "MainForm_Identification_Assembly", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='ASY_PART_ID']");
				MEMPRPLI_MainForm_Identification_Assembly.Click();
MEMPRPLI_MainForm_Identification_Assembly.SendKeys("NW-MRPBOM-MAKE1", true);
Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));
MEMPRPLI_MainForm_Identification_Assembly.SendKeys(OpenQA.Selenium.Keys.Shift + OpenQA.Selenium.Keys.Tab);


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
				this.ScriptLogger.WriteLine("Proposal Cost Details Form");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing VerifyExists on ProposalCostDetailsForm...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_ProposalCostDetailsForm = new SeleniumControl( sDriver, "ProposalCostDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MEMPRPLI_ZMEMPRPLIEXPL_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,MEMPRPLI_ProposalCostDetailsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing ClickButton on ProposalCostDetailsForm...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_ProposalCostDetailsForm = new SeleniumControl( sDriver, "ProposalCostDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MEMPRPLI_ZMEMPRPLIEXPL_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MEMPRPLI_ProposalCostDetailsForm);
IWebElement formBttn = MEMPRPLI_ProposalCostDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? MEMPRPLI_ProposalCostDetailsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
MEMPRPLI_ProposalCostDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing Select on ProposalCostDetails_Tab...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_ProposalCostDetails_Tab = new SeleniumControl( sDriver, "ProposalCostDetails_Tab", "xpath", "//div[translate(@id,'0123456789','')='pr__MEMPRPLI_ZMEMPRPLIEXPL_CTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(MEMPRPLI_ProposalCostDetails_Tab);
IWebElement mTab = MEMPRPLI_ProposalCostDetails_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Costs").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing VerifyExists on ProposalCostDetails_Costs_ProposalCostAmounts_DirectUnit...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_ProposalCostDetails_Costs_ProposalCostAmounts_DirectUnit = new SeleniumControl( sDriver, "ProposalCostDetails_Costs_ProposalCostAmounts_DirectUnit", "xpath", "//div[translate(@id,'0123456789','')='pr__MEMPRPLI_ZMEMPRPLIEXPL_CTW_']/ancestor::form[1]/descendant::*[@id='DIRECT_UNIT_CST_AMT']");
				Function.AssertEqual(true,MEMPRPLI_ProposalCostDetails_Costs_ProposalCostAmounts_DirectUnit.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing Select on ProposalCostDetails_Tab...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_ProposalCostDetails_Tab = new SeleniumControl( sDriver, "ProposalCostDetails_Tab", "xpath", "//div[translate(@id,'0123456789','')='pr__MEMPRPLI_ZMEMPRPLIEXPL_CTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(MEMPRPLI_ProposalCostDetails_Tab);
IWebElement mTab = MEMPRPLI_ProposalCostDetails_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Proposal Quantity Breakpoints").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing VerifyExists on ProposalCostDetails_AvailableInventoryQty...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_ProposalCostDetails_AvailableInventoryQty = new SeleniumControl( sDriver, "ProposalCostDetails_AvailableInventoryQty", "xpath", "//div[translate(@id,'0123456789','')='pr__MEMPRPLI_ZMEMPRPLIEXPL_CTW_']/ancestor::form[1]/descendant::*[@id='AVAIL_INVT_QTY']");
				Function.AssertEqual(true,MEMPRPLI_ProposalCostDetails_AvailableInventoryQty.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing Select on ProposalCostDetails_Tab...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_ProposalCostDetails_Tab = new SeleniumControl( sDriver, "ProposalCostDetails_Tab", "xpath", "//div[translate(@id,'0123456789','')='pr__MEMPRPLI_ZMEMPRPLIEXPL_CTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(MEMPRPLI_ProposalCostDetails_Tab);
IWebElement mTab = MEMPRPLI_ProposalCostDetails_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Component Part Details").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing VerifyExists on ProposalCostDetails_ComponentPartDetails_PartStatus...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_ProposalCostDetails_ComponentPartDetails_PartStatus = new SeleniumControl( sDriver, "ProposalCostDetails_ComponentPartDetails_PartStatus", "xpath", "//div[translate(@id,'0123456789','')='pr__MEMPRPLI_ZMEMPRPLIEXPL_CTW_']/ancestor::form[1]/descendant::*[@id='S_STATUS_DESC']");
				Function.AssertEqual(true,MEMPRPLI_ProposalCostDetails_ComponentPartDetails_PartStatus.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing Select on ProposalCostDetails_Tab...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_ProposalCostDetails_Tab = new SeleniumControl( sDriver, "ProposalCostDetails_Tab", "xpath", "//div[translate(@id,'0123456789','')='pr__MEMPRPLI_ZMEMPRPLIEXPL_CTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(MEMPRPLI_ProposalCostDetails_Tab);
IWebElement mTab = MEMPRPLI_ProposalCostDetails_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Notes").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing ClickButton on ProposalCostDetailsForm...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_ProposalCostDetailsForm = new SeleniumControl( sDriver, "ProposalCostDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MEMPRPLI_ZMEMPRPLIEXPL_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MEMPRPLI_ProposalCostDetailsForm);
IWebElement formBttn = MEMPRPLI_ProposalCostDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? MEMPRPLI_ProposalCostDetailsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
MEMPRPLI_ProposalCostDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Proposal Cost Items Link");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing ClickButton on ProposalCostDetailsForm...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_ProposalCostDetailsForm = new SeleniumControl( sDriver, "ProposalCostDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MEMPRPLI_ZMEMPRPLIEXPL_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MEMPRPLI_ProposalCostDetailsForm);
IWebElement formBttn = MEMPRPLI_ProposalCostDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).Count <= 0 ? MEMPRPLI_ProposalCostDetailsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Query')]")).FirstOrDefault() :
MEMPRPLI_ProposalCostDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).FirstOrDefault();
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
Function.AssertEqual("Maintain PBOM Cost Estimates", new SeleniumControl(sDriver,"QueryTitle", "ID", "qryHeaderLabel").GetValue().Trim());


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyTitle]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "Query";
								SeleniumControl ctl = new SeleniumControl(sDriver,"Target", "xpath_display", "//*[@id='basicQTbl']/tbody/tr/td/span[text()='Part']");
Function.WaitControlDisplayed(ctl);
SeleniumControl RelationshipField = new SeleniumControl(sDriver,"Relationship", ctl.mElement.FindElement(By.XPath("../following-sibling::td[1]")));
SeleniumControl SearchField = new SeleniumControl(sDriver,"Relationship", ctl.mElement.FindElement(By.XPath("../following-sibling::td[2]")));
new SeleniumControl(sDriver, "RelDropdown", RelationshipField.mElement.FindElements(By.XPath("./descendant::*[@class='tCCBImg']")).FirstOrDefault()).Click();
new SeleniumControl(sDriver, "RelItem", "xpath_display", ".//descendant::div[text() = 'is equal to']").Click();
if (SearchField.mElement.GetAttribute("class").Equals("tCCB")) {
new SeleniumControl(sDriver, "SearchDropdown", SearchField.mElement.FindElements(By.XPath(".//descendant::*[@class='tCCBImg']")).FirstOrDefault()).Click();
new SeleniumControl(sDriver, "SearchItem", "xpath_display", ".//descendant::div[text()='NW-MRPBOM-MAKE1']").Click();
} else {
                        IWebElement elem = SearchField.mElement.FindElements(By.XPath(".//descendant::*[@class='queryBasicFld']")).FirstOrDefault(); elem.Clear(); elem.Click();
                        new SeleniumControl(sDriver, "SearchDropdown", SearchField.mElement.FindElements(By.XPath(".//descendant::*[@class='queryBasicFld']")).FirstOrDefault()).SendKeys("NW-MRPBOM-MAKE1");}


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
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing Click on ProposalCostDetails_ProposalItemCostsLink...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_ProposalCostDetails_ProposalItemCostsLink = new SeleniumControl( sDriver, "ProposalCostDetails_ProposalItemCostsLink", "ID", "lnk_5295_MEMPRPLI_ZMEMPRPLIEXPL_CTW");
				Function.WaitControlDisplayed(MEMPRPLI_ProposalCostDetails_ProposalItemCostsLink);
MEMPRPLI_ProposalCostDetails_ProposalItemCostsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing VerifyExists on ProposalItemCostForm...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_ProposalItemCostForm = new SeleniumControl( sDriver, "ProposalItemCostForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_PROPITEMCST_HDR_']/ancestor::form[1]");
				Function.AssertEqual(true,MEMPRPLI_ProposalItemCostForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing VerifyExists on ProposalItemCosts_Proposal...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_ProposalItemCosts_Proposal = new SeleniumControl( sDriver, "ProposalItemCosts_Proposal", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_PROPITEMCST_HDR_']/ancestor::form[1]/descendant::*[@id='PROP_ID']");
				Function.AssertEqual(true,MEMPRPLI_ProposalItemCosts_Proposal.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing VerifyExists on ProposalItemCost_CostRecordsForm...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_ProposalItemCost_CostRecordsForm = new SeleniumControl( sDriver, "ProposalItemCost_CostRecordsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_PROPOSITEMCST_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,MEMPRPLI_ProposalItemCost_CostRecordsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing VerifyExist on ProposalItemCost_CostRecordsFormTable...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_ProposalItemCost_CostRecordsFormTable = new SeleniumControl( sDriver, "ProposalItemCost_CostRecordsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_PROPOSITEMCST_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,MEMPRPLI_ProposalItemCost_CostRecordsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing ClickButton on ProposalItemCost_CostRecordsForm...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_ProposalItemCost_CostRecordsForm = new SeleniumControl( sDriver, "ProposalItemCost_CostRecordsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_PROPOSITEMCST_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MEMPRPLI_ProposalItemCost_CostRecordsForm);
IWebElement formBttn = MEMPRPLI_ProposalItemCost_CostRecordsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? MEMPRPLI_ProposalItemCost_CostRecordsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
MEMPRPLI_ProposalItemCost_CostRecordsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing VerifyExists on ProposalItemCosts_CostRecords_MinimumQuantity...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_ProposalItemCosts_CostRecords_MinimumQuantity = new SeleniumControl( sDriver, "ProposalItemCosts_CostRecords_MinimumQuantity", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_PROPOSITEMCST_CTW_']/ancestor::form[1]/descendant::*[@id='MIN_QTY']");
				Function.AssertEqual(true,MEMPRPLI_ProposalItemCosts_CostRecords_MinimumQuantity.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing Select on CostRecords_Tab...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_CostRecords_Tab = new SeleniumControl( sDriver, "CostRecords_Tab", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_PROPOSITEMCST_CTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(MEMPRPLI_CostRecords_Tab);
IWebElement mTab = MEMPRPLI_CostRecords_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Incremental Costs").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing VerifyExists on ProposalItemCosts_CostRecords_IncrementalCosts_ThisLevelTotalUnitCost...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_ProposalItemCosts_CostRecords_IncrementalCosts_ThisLevelTotalUnitCost = new SeleniumControl( sDriver, "ProposalItemCosts_CostRecords_IncrementalCosts_ThisLevelTotalUnitCost", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_PROPOSITEMCST_CTW_']/ancestor::form[1]/descendant::*[@id='TL_TOT_UNIT_CST']");
				Function.AssertEqual(true,MEMPRPLI_ProposalItemCosts_CostRecords_IncrementalCosts_ThisLevelTotalUnitCost.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing Select on CostRecords_Tab...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_CostRecords_Tab = new SeleniumControl( sDriver, "CostRecords_Tab", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_PROPOSITEMCST_CTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(MEMPRPLI_CostRecords_Tab);
IWebElement mTab = MEMPRPLI_CostRecords_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Cost Source Details").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing VerifyExists on ProposalItemCosts_CostRecords_CostSourceDetails_Vendor...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_ProposalItemCosts_CostRecords_CostSourceDetails_Vendor = new SeleniumControl( sDriver, "ProposalItemCosts_CostRecords_CostSourceDetails_Vendor", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_PROPOSITEMCST_CTW_']/ancestor::form[1]/descendant::*[@id='VEND_ID']");
				Function.AssertEqual(true,MEMPRPLI_ProposalItemCosts_CostRecords_CostSourceDetails_Vendor.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing Select on CostRecords_Tab...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_CostRecords_Tab = new SeleniumControl( sDriver, "CostRecords_Tab", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_PROPOSITEMCST_CTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(MEMPRPLI_CostRecords_Tab);
IWebElement mTab = MEMPRPLI_CostRecords_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Notes").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing Close on ProposalItemCostForm...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_ProposalItemCostForm = new SeleniumControl( sDriver, "ProposalItemCostForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_PROPITEMCST_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MEMPRPLI_ProposalItemCostForm);
IWebElement formBttn = MEMPRPLI_ProposalItemCostForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Matl Cost Link");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing ClickButton on ProposalCostDetailsForm...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_ProposalCostDetailsForm = new SeleniumControl( sDriver, "ProposalCostDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MEMPRPLI_ZMEMPRPLIEXPL_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MEMPRPLI_ProposalCostDetailsForm);
IWebElement formBttn = MEMPRPLI_ProposalCostDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).Count <= 0 ? MEMPRPLI_ProposalCostDetailsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Query')]")).FirstOrDefault() :
MEMPRPLI_ProposalCostDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).FirstOrDefault();
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
Function.AssertEqual("Maintain PBOM Cost Estimates", new SeleniumControl(sDriver,"QueryTitle", "ID", "qryHeaderLabel").GetValue().Trim());


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyTitle]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "Query";
								SeleniumControl ctl = new SeleniumControl(sDriver,"Target", "xpath_display", "//*[@id='basicQTbl']/tbody/tr/td/span[text()='Part']");
Function.WaitControlDisplayed(ctl);
SeleniumControl RelationshipField = new SeleniumControl(sDriver,"Relationship", ctl.mElement.FindElement(By.XPath("../following-sibling::td[1]")));
SeleniumControl SearchField = new SeleniumControl(sDriver,"Relationship", ctl.mElement.FindElement(By.XPath("../following-sibling::td[2]")));
new SeleniumControl(sDriver, "RelDropdown", RelationshipField.mElement.FindElements(By.XPath("./descendant::*[@class='tCCBImg']")).FirstOrDefault()).Click();
new SeleniumControl(sDriver, "RelItem", "xpath_display", ".//descendant::div[text() = 'is equal to']").Click();
if (SearchField.mElement.GetAttribute("class").Equals("tCCB")) {
new SeleniumControl(sDriver, "SearchDropdown", SearchField.mElement.FindElements(By.XPath(".//descendant::*[@class='tCCBImg']")).FirstOrDefault()).Click();
new SeleniumControl(sDriver, "SearchItem", "xpath_display", ".//descendant::div[text()='SOC1-TOOL']").Click();
} else {
                        IWebElement elem = SearchField.mElement.FindElements(By.XPath(".//descendant::*[@class='queryBasicFld']")).FirstOrDefault(); elem.Clear(); elem.Click();
                        new SeleniumControl(sDriver, "SearchDropdown", SearchField.mElement.FindElements(By.XPath(".//descendant::*[@class='queryBasicFld']")).FirstOrDefault()).SendKeys("SOC1-TOOL");}


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
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing Click on ProposalCostDetails_MatlCostsWSLink...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_ProposalCostDetails_MatlCostsWSLink = new SeleniumControl( sDriver, "ProposalCostDetails_MatlCostsWSLink", "ID", "lnk_5300_MEMPRPLI_ZMEMPRPLIEXPL_CTW");
				Function.WaitControlDisplayed(MEMPRPLI_ProposalCostDetails_MatlCostsWSLink);
MEMPRPLI_ProposalCostDetails_MatlCostsWSLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing VerifyExists on MatlCostsWSForm...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_MatlCostsWSForm = new SeleniumControl( sDriver, "MatlCostsWSForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_MATLCST_SUBTASK_HDR_']/ancestor::form[1]");
				Function.AssertEqual(true,MEMPRPLI_MatlCostsWSForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing VerifyExists on MatlCostsWS_Proposal...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_MatlCostsWS_Proposal = new SeleniumControl( sDriver, "MatlCostsWS_Proposal", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_MATLCST_SUBTASK_HDR_']/ancestor::form[1]/descendant::*[@id='PROP_ID']");
				Function.AssertEqual(true,MEMPRPLI_MatlCostsWS_Proposal.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing VerifyExists on MatlCostsWS_MaterialCostsWSForm...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_MatlCostsWS_MaterialCostsWSForm = new SeleniumControl( sDriver, "MatlCostsWS_MaterialCostsWSForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_MEMATLCST_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,MEMPRPLI_MatlCostsWS_MaterialCostsWSForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing VerifyExist on MatlCostsWS_MaterialCostsWSFormFormTable...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_MatlCostsWS_MaterialCostsWSFormFormTable = new SeleniumControl( sDriver, "MatlCostsWS_MaterialCostsWSFormFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_MEMATLCST_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,MEMPRPLI_MatlCostsWS_MaterialCostsWSFormFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing ClickButton on MatlCostsWS_MaterialCostsWSForm...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_MatlCostsWS_MaterialCostsWSForm = new SeleniumControl( sDriver, "MatlCostsWS_MaterialCostsWSForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_MEMATLCST_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MEMPRPLI_MatlCostsWS_MaterialCostsWSForm);
IWebElement formBttn = MEMPRPLI_MatlCostsWS_MaterialCostsWSForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? MEMPRPLI_MatlCostsWS_MaterialCostsWSForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
MEMPRPLI_MatlCostsWS_MaterialCostsWSForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing VerifyExists on MatlCostsWS_MaterialCostsWS_MinimumQuantity...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_MatlCostsWS_MaterialCostsWS_MinimumQuantity = new SeleniumControl( sDriver, "MatlCostsWS_MaterialCostsWS_MinimumQuantity", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_MEMATLCST_CTW_']/ancestor::form[1]/descendant::*[@id='MIN_QT']");
				Function.AssertEqual(true,MEMPRPLI_MatlCostsWS_MaterialCostsWS_MinimumQuantity.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing VerifyExists on MatlCostsWS_MaterialCostsWS_CostInformation_OrderQuoteGrossUnitCost...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_MatlCostsWS_MaterialCostsWS_CostInformation_OrderQuoteGrossUnitCost = new SeleniumControl( sDriver, "MatlCostsWS_MaterialCostsWS_CostInformation_OrderQuoteGrossUnitCost", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_MEMATLCST_CTW_']/ancestor::form[1]/descendant::*[@id='GROSS_UNIT_CST_AMT']");
				Function.AssertEqual(true,MEMPRPLI_MatlCostsWS_MaterialCostsWS_CostInformation_OrderQuoteGrossUnitCost.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing Close on MatlCostsWSForm...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_MatlCostsWSForm = new SeleniumControl( sDriver, "MatlCostsWSForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_MATLCST_SUBTASK_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MEMPRPLI_MatlCostsWSForm);
IWebElement formBttn = MEMPRPLI_MatlCostsWSForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("RFQs Link");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing ClickButton on ProposalCostDetailsForm...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_ProposalCostDetailsForm = new SeleniumControl( sDriver, "ProposalCostDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MEMPRPLI_ZMEMPRPLIEXPL_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MEMPRPLI_ProposalCostDetailsForm);
IWebElement formBttn = MEMPRPLI_ProposalCostDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).Count <= 0 ? MEMPRPLI_ProposalCostDetailsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Query')]")).FirstOrDefault() :
MEMPRPLI_ProposalCostDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).FirstOrDefault();
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
Function.AssertEqual("Maintain PBOM Cost Estimates", new SeleniumControl(sDriver,"QueryTitle", "ID", "qryHeaderLabel").GetValue().Trim());


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyTitle]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "Query";
								SeleniumControl ctl = new SeleniumControl(sDriver,"Target", "xpath_display", "//*[@id='basicQTbl']/tbody/tr/td/span[text()='Part']");
Function.WaitControlDisplayed(ctl);
SeleniumControl RelationshipField = new SeleniumControl(sDriver,"Relationship", ctl.mElement.FindElement(By.XPath("../following-sibling::td[1]")));
SeleniumControl SearchField = new SeleniumControl(sDriver,"Relationship", ctl.mElement.FindElement(By.XPath("../following-sibling::td[2]")));
new SeleniumControl(sDriver, "RelDropdown", RelationshipField.mElement.FindElements(By.XPath("./descendant::*[@class='tCCBImg']")).FirstOrDefault()).Click();
new SeleniumControl(sDriver, "RelItem", "xpath_display", ".//descendant::div[text() = 'is equal to']").Click();
if (SearchField.mElement.GetAttribute("class").Equals("tCCB")) {
new SeleniumControl(sDriver, "SearchDropdown", SearchField.mElement.FindElements(By.XPath(".//descendant::*[@class='tCCBImg']")).FirstOrDefault()).Click();
new SeleniumControl(sDriver, "SearchItem", "xpath_display", ".//descendant::div[text()='0212PC500']").Click();
} else {
                        IWebElement elem = SearchField.mElement.FindElements(By.XPath(".//descendant::*[@class='queryBasicFld']")).FirstOrDefault(); elem.Clear(); elem.Click();
                        new SeleniumControl(sDriver, "SearchDropdown", SearchField.mElement.FindElements(By.XPath(".//descendant::*[@class='queryBasicFld']")).FirstOrDefault()).SendKeys("0212PC500");}


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
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing Click on ProposalCostDetails_RFQsLink...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_ProposalCostDetails_RFQsLink = new SeleniumControl( sDriver, "ProposalCostDetails_RFQsLink", "ID", "lnk_5267_MEMPRPLI_ZMEMPRPLIEXPL_CTW");
				Function.WaitControlDisplayed(MEMPRPLI_ProposalCostDetails_RFQsLink);
MEMPRPLI_ProposalCostDetails_RFQsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing VerifyExists on RFQsForm...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_RFQsForm = new SeleniumControl( sDriver, "RFQsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_RFQ_SUBTASK_HDR_']/ancestor::form[1]");
				Function.AssertEqual(true,MEMPRPLI_RFQsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing VerifyExists on RFQs_Proposal...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_RFQs_Proposal = new SeleniumControl( sDriver, "RFQs_Proposal", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_RFQ_SUBTASK_HDR_']/ancestor::form[1]/descendant::*[@id='PROP_ID']");
				Function.AssertEqual(true,MEMPRPLI_RFQs_Proposal.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing VerifyExists on RFQs_RequestForQuotesForm...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_RFQs_RequestForQuotesForm = new SeleniumControl( sDriver, "RFQs_RequestForQuotesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_MERFQS_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,MEMPRPLI_RFQs_RequestForQuotesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing VerifyExist on RFQs_RequestForQuotesFormTable...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_RFQs_RequestForQuotesFormTable = new SeleniumControl( sDriver, "RFQs_RequestForQuotesFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_MERFQS_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,MEMPRPLI_RFQs_RequestForQuotesFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing ClickButton on RFQs_RequestForQuotesForm...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_RFQs_RequestForQuotesForm = new SeleniumControl( sDriver, "RFQs_RequestForQuotesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_MERFQS_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MEMPRPLI_RFQs_RequestForQuotesForm);
IWebElement formBttn = MEMPRPLI_RFQs_RequestForQuotesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? MEMPRPLI_RFQs_RequestForQuotesForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
MEMPRPLI_RFQs_RequestForQuotesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing VerifyExists on RFQs_RequestForQuotes_Vendor...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_RFQs_RequestForQuotes_Vendor = new SeleniumControl( sDriver, "RFQs_RequestForQuotes_Vendor", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_MERFQS_CTW_']/ancestor::form[1]/descendant::*[@id='VEND_ID']");
				Function.AssertEqual(true,MEMPRPLI_RFQs_RequestForQuotes_Vendor.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing Select on RequestForQuotes_Tab...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_RequestForQuotes_Tab = new SeleniumControl( sDriver, "RequestForQuotes_Tab", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_MERFQS_CTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(MEMPRPLI_RequestForQuotes_Tab);
IWebElement mTab = MEMPRPLI_RequestForQuotes_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Details").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing VerifyExists on RFQs_RequestForQuotes_Details_RFQCreated...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_RFQs_RequestForQuotes_Details_RFQCreated = new SeleniumControl( sDriver, "RFQs_RequestForQuotes_Details_RFQCreated", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_MERFQS_CTW_']/ancestor::form[1]/descendant::*[@id='RFQ_FL']");
				Function.AssertEqual(true,MEMPRPLI_RFQs_RequestForQuotes_Details_RFQCreated.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing Select on RequestForQuotes_Tab...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_RequestForQuotes_Tab = new SeleniumControl( sDriver, "RequestForQuotes_Tab", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_MERFQS_CTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(MEMPRPLI_RequestForQuotes_Tab);
IWebElement mTab = MEMPRPLI_RequestForQuotes_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "RFQ Line Notes").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing Close on RFQsForm...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_RFQsForm = new SeleniumControl( sDriver, "RFQsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_RFQ_SUBTASK_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MEMPRPLI_RFQsForm);
IWebElement formBttn = MEMPRPLI_RFQsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Inventory Link");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing Click on ProposalCostDetails_InventoryLink...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_ProposalCostDetails_InventoryLink = new SeleniumControl( sDriver, "ProposalCostDetails_InventoryLink", "ID", "lnk_5274_MEMPRPLI_ZMEMPRPLIEXPL_CTW");
				Function.WaitControlDisplayed(MEMPRPLI_ProposalCostDetails_InventoryLink);
MEMPRPLI_ProposalCostDetails_InventoryLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing VerifyExists on InventoryForm...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_InventoryForm = new SeleniumControl( sDriver, "InventoryForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_INVT_SUBTASK_HDR_']/ancestor::form[1]");
				Function.AssertEqual(true,MEMPRPLI_InventoryForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing VerifyExists on Inventory_Proposal...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_Inventory_Proposal = new SeleniumControl( sDriver, "Inventory_Proposal", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_INVT_SUBTASK_HDR_']/ancestor::form[1]/descendant::*[@id='PROP_ID']");
				Function.AssertEqual(true,MEMPRPLI_Inventory_Proposal.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing VerifyExists on Inventory_InventoryDetailsForm...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_Inventory_InventoryDetailsForm = new SeleniumControl( sDriver, "Inventory_InventoryDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_INVT_MEINVT_']/ancestor::form[1]");
				Function.AssertEqual(true,MEMPRPLI_Inventory_InventoryDetailsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing VerifyExist on Inventory_InventoryDetailsFormTable...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_Inventory_InventoryDetailsFormTable = new SeleniumControl( sDriver, "Inventory_InventoryDetailsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_INVT_MEINVT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,MEMPRPLI_Inventory_InventoryDetailsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing ClickButton on Inventory_InventoryDetailsForm...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_Inventory_InventoryDetailsForm = new SeleniumControl( sDriver, "Inventory_InventoryDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_INVT_MEINVT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MEMPRPLI_Inventory_InventoryDetailsForm);
IWebElement formBttn = MEMPRPLI_Inventory_InventoryDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? MEMPRPLI_Inventory_InventoryDetailsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
MEMPRPLI_Inventory_InventoryDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing VerifyExists on Inventory_InventoryDetails_Project...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_Inventory_InventoryDetails_Project = new SeleniumControl( sDriver, "Inventory_InventoryDetails_Project", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_INVT_MEINVT_']/ancestor::form[1]/descendant::*[@id='PROJ_ID']");
				Function.AssertEqual(true,MEMPRPLI_Inventory_InventoryDetails_Project.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing Select on InventoryDetails_Tab...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_InventoryDetails_Tab = new SeleniumControl( sDriver, "InventoryDetails_Tab", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_INVT_MEINVT_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(MEMPRPLI_InventoryDetails_Tab);
IWebElement mTab = MEMPRPLI_InventoryDetails_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Inventory Quantities").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing VerifyExists on Inventory_InventoryDetails_InventoryQuantities_NetAvailable...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_Inventory_InventoryDetails_InventoryQuantities_NetAvailable = new SeleniumControl( sDriver, "Inventory_InventoryDetails_InventoryQuantities_NetAvailable", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_INVT_MEINVT_']/ancestor::form[1]/descendant::*[@id='NET_AVAIL_QTY']");
				Function.AssertEqual(true,MEMPRPLI_Inventory_InventoryDetails_InventoryQuantities_NetAvailable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing Select on InventoryDetails_Tab...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_InventoryDetails_Tab = new SeleniumControl( sDriver, "InventoryDetails_Tab", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_INVT_MEINVT_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(MEMPRPLI_InventoryDetails_Tab);
IWebElement mTab = MEMPRPLI_InventoryDetails_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Unit Cost").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing VerifyExists on Inventory_InventoryDetails_UnitCost_DirectMaterial...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_Inventory_InventoryDetails_UnitCost_DirectMaterial = new SeleniumControl( sDriver, "Inventory_InventoryDetails_UnitCost_DirectMaterial", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_INVT_MEINVT_']/ancestor::form[1]/descendant::*[@id='MATL_CST_AMT']");
				Function.AssertEqual(true,MEMPRPLI_Inventory_InventoryDetails_UnitCost_DirectMaterial.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing Select on InventoryDetails_Tab...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_InventoryDetails_Tab = new SeleniumControl( sDriver, "InventoryDetails_Tab", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_INVT_MEINVT_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(MEMPRPLI_InventoryDetails_Tab);
IWebElement mTab = MEMPRPLI_InventoryDetails_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Expediting Notes").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing Close on InventoryForm...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_InventoryForm = new SeleniumControl( sDriver, "InventoryForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_INVT_SUBTASK_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MEMPRPLI_InventoryForm);
IWebElement formBttn = MEMPRPLI_InventoryForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Alternate Parts Link");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing Click on ProposalCostDetails_AlternatePartsLink...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_ProposalCostDetails_AlternatePartsLink = new SeleniumControl( sDriver, "ProposalCostDetails_AlternatePartsLink", "ID", "lnk_5272_MEMPRPLI_ZMEMPRPLIEXPL_CTW");
				Function.WaitControlDisplayed(MEMPRPLI_ProposalCostDetails_AlternatePartsLink);
MEMPRPLI_ProposalCostDetails_AlternatePartsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing VerifyExists on AlternatePartsForm...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_AlternatePartsForm = new SeleniumControl( sDriver, "AlternatePartsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_ALTPART_SUBTASK_HDR_']/ancestor::form[1]");
				Function.AssertEqual(true,MEMPRPLI_AlternatePartsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing VerifyExists on AlternateParts_Proposal...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_AlternateParts_Proposal = new SeleniumControl( sDriver, "AlternateParts_Proposal", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_ALTPART_SUBTASK_HDR_']/ancestor::form[1]/descendant::*[@id='PROP_ID']");
				Function.AssertEqual(true,MEMPRPLI_AlternateParts_Proposal.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing VerifyExists on AlternateParts_AlternatePartsForm...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_AlternateParts_AlternatePartsForm = new SeleniumControl( sDriver, "AlternateParts_AlternatePartsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_ALTPART_CHILD_']/ancestor::form[1]");
				Function.AssertEqual(true,MEMPRPLI_AlternateParts_AlternatePartsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing VerifyExist on AlternateParts_AlternatePartsFormTable...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_AlternateParts_AlternatePartsFormTable = new SeleniumControl( sDriver, "AlternateParts_AlternatePartsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_ALTPART_CHILD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,MEMPRPLI_AlternateParts_AlternatePartsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing ClickButton on AlternateParts_AlternatePartsForm...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_AlternateParts_AlternatePartsForm = new SeleniumControl( sDriver, "AlternateParts_AlternatePartsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_ALTPART_CHILD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MEMPRPLI_AlternateParts_AlternatePartsForm);
IWebElement formBttn = MEMPRPLI_AlternateParts_AlternatePartsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? MEMPRPLI_AlternateParts_AlternatePartsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
MEMPRPLI_AlternateParts_AlternatePartsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing VerifyExists on AlternateParts_AlternateParts_Sequence...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_AlternateParts_AlternateParts_Sequence = new SeleniumControl( sDriver, "AlternateParts_AlternateParts_Sequence", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_ALTPART_CHILD_']/ancestor::form[1]/descendant::*[@id='SEQ_NO']");
				Function.AssertEqual(true,MEMPRPLI_AlternateParts_AlternateParts_Sequence.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing Close on AlternatePartsForm...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_AlternatePartsForm = new SeleniumControl( sDriver, "AlternatePartsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_ALTPART_SUBTASK_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MEMPRPLI_AlternatePartsForm);
IWebElement formBttn = MEMPRPLI_AlternatePartsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Vendor Link");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing Click on ProposalCostDetails_VendorLink...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_ProposalCostDetails_VendorLink = new SeleniumControl( sDriver, "ProposalCostDetails_VendorLink", "ID", "lnk_5246_MEMPRPLI_ZMEMPRPLIEXPL_CTW");
				Function.WaitControlDisplayed(MEMPRPLI_ProposalCostDetails_VendorLink);
MEMPRPLI_ProposalCostDetails_VendorLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing VerifyExists on VendorForm...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_VendorForm = new SeleniumControl( sDriver, "VendorForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_ITEMVEND_SUBTASK_HDR_']/ancestor::form[1]");
				Function.AssertEqual(true,MEMPRPLI_VendorForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing VerifyExists on Vendor_Proposal...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_Vendor_Proposal = new SeleniumControl( sDriver, "Vendor_Proposal", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_ITEMVEND_SUBTASK_HDR_']/ancestor::form[1]/descendant::*[@id='PROP_ID']");
				Function.AssertEqual(true,MEMPRPLI_Vendor_Proposal.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing VerifyExists on Vendor_VendorsForm...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_Vendor_VendorsForm = new SeleniumControl( sDriver, "Vendor_VendorsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_ITEMVEND_SUBTASK_']/ancestor::form[1]");
				Function.AssertEqual(true,MEMPRPLI_Vendor_VendorsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing VerifyExist on Vendor_VendorsFormTable...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_Vendor_VendorsFormTable = new SeleniumControl( sDriver, "Vendor_VendorsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_ITEMVEND_SUBTASK_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,MEMPRPLI_Vendor_VendorsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing ClickButton on Vendor_VendorsForm...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_Vendor_VendorsForm = new SeleniumControl( sDriver, "Vendor_VendorsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_ITEMVEND_SUBTASK_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MEMPRPLI_Vendor_VendorsForm);
IWebElement formBttn = MEMPRPLI_Vendor_VendorsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? MEMPRPLI_Vendor_VendorsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
MEMPRPLI_Vendor_VendorsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing VerifyExists on Vendor_Vendors_Vendor...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_Vendor_Vendors_Vendor = new SeleniumControl( sDriver, "Vendor_Vendors_Vendor", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_ITEMVEND_SUBTASK_']/ancestor::form[1]/descendant::*[@id='VEND_ID']");
				Function.AssertEqual(true,MEMPRPLI_Vendor_Vendors_Vendor.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing Close on VendorForm...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_VendorForm = new SeleniumControl( sDriver, "VendorForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_ITEMVEND_SUBTASK_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MEMPRPLI_VendorForm);
IWebElement formBttn = MEMPRPLI_VendorForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Other Cost WS Link");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing Click on ProposalCostDetails_OtherCostWSLink...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_ProposalCostDetails_OtherCostWSLink = new SeleniumControl( sDriver, "ProposalCostDetails_OtherCostWSLink", "ID", "lnk_5248_MEMPRPLI_ZMEMPRPLIEXPL_CTW");
				Function.WaitControlDisplayed(MEMPRPLI_ProposalCostDetails_OtherCostWSLink);
MEMPRPLI_ProposalCostDetails_OtherCostWSLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing VerifyExists on OtherCostWSForm...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_OtherCostWSForm = new SeleniumControl( sDriver, "OtherCostWSForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_OTHERCST_SUBTASK_HDR_']/ancestor::form[1]");
				Function.AssertEqual(true,MEMPRPLI_OtherCostWSForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing VerifyExists on OtherCostWS_Proposal...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_OtherCostWS_Proposal = new SeleniumControl( sDriver, "OtherCostWS_Proposal", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_OTHERCST_SUBTASK_HDR_']/ancestor::form[1]/descendant::*[@id='PROP_ID']");
				Function.AssertEqual(true,MEMPRPLI_OtherCostWS_Proposal.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing VerifyExists on OtherCostWS_OtherCostsWSForm...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_OtherCostWS_OtherCostsWSForm = new SeleniumControl( sDriver, "OtherCostWS_OtherCostsWSForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_MEOTHERCST_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,MEMPRPLI_OtherCostWS_OtherCostsWSForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing VerifyExist on OtherCostWS_OtherCostsWSFormTable...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_OtherCostWS_OtherCostsWSFormTable = new SeleniumControl( sDriver, "OtherCostWS_OtherCostsWSFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_MEOTHERCST_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,MEMPRPLI_OtherCostWS_OtherCostsWSFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing ClickButton on OtherCostWS_OtherCostsWSForm...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_OtherCostWS_OtherCostsWSForm = new SeleniumControl( sDriver, "OtherCostWS_OtherCostsWSForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_MEOTHERCST_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MEMPRPLI_OtherCostWS_OtherCostsWSForm);
IWebElement formBttn = MEMPRPLI_OtherCostWS_OtherCostsWSForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? MEMPRPLI_OtherCostWS_OtherCostsWSForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
MEMPRPLI_OtherCostWS_OtherCostsWSForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing VerifyExists on OtherCostWS_OtherCostsWS_MinimumQuantity...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_OtherCostWS_OtherCostsWS_MinimumQuantity = new SeleniumControl( sDriver, "OtherCostWS_OtherCostsWS_MinimumQuantity", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_MEOTHERCST_CTW_']/ancestor::form[1]/descendant::*[@id='MIN_QTY']");
				Function.AssertEqual(true,MEMPRPLI_OtherCostWS_OtherCostsWS_MinimumQuantity.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing Close on OtherCostWSForm...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_OtherCostWSForm = new SeleniumControl( sDriver, "OtherCostWSForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_OTHERCST_SUBTASK_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MEMPRPLI_OtherCostWSForm);
IWebElement formBttn = MEMPRPLI_OtherCostWSForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Add Quotes Link");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing Click on ProposalCostDetails_AddQuotesLink...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_ProposalCostDetails_AddQuotesLink = new SeleniumControl( sDriver, "ProposalCostDetails_AddQuotesLink", "ID", "lnk_5278_MEMPRPLI_ZMEMPRPLIEXPL_CTW");
				Function.WaitControlDisplayed(MEMPRPLI_ProposalCostDetails_AddQuotesLink);
MEMPRPLI_ProposalCostDetails_AddQuotesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing VerifyExists on AddQuotesForm...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_AddQuotesForm = new SeleniumControl( sDriver, "AddQuotesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_VENDQT_SUBTASK_HDR_']/ancestor::form[1]");
				Function.AssertEqual(true,MEMPRPLI_AddQuotesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing VerifyExists on AddQuotes_Proposal...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_AddQuotes_Proposal = new SeleniumControl( sDriver, "AddQuotes_Proposal", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_VENDQT_SUBTASK_HDR_']/ancestor::form[1]/descendant::*[@id='PROP_ID']");
				Function.AssertEqual(true,MEMPRPLI_AddQuotes_Proposal.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing VerifyExists on AddQuotes_VendorQuotesForm...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_AddQuotes_VendorQuotesForm = new SeleniumControl( sDriver, "AddQuotes_VendorQuotesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_ADDVENDQT_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,MEMPRPLI_AddQuotes_VendorQuotesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing VerifyExist on AddQuotes_VendorQuotesFormTable...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_AddQuotes_VendorQuotesFormTable = new SeleniumControl( sDriver, "AddQuotes_VendorQuotesFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_ADDVENDQT_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,MEMPRPLI_AddQuotes_VendorQuotesFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing ClickButton on AddQuotes_VendorQuotesForm...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_AddQuotes_VendorQuotesForm = new SeleniumControl( sDriver, "AddQuotes_VendorQuotesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_ADDVENDQT_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MEMPRPLI_AddQuotes_VendorQuotesForm);
IWebElement formBttn = MEMPRPLI_AddQuotes_VendorQuotesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? MEMPRPLI_AddQuotes_VendorQuotesForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
MEMPRPLI_AddQuotes_VendorQuotesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing VerifyExists on AddQuotes_VendorQuotes_Details_Vendor...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_AddQuotes_VendorQuotes_Details_Vendor = new SeleniumControl( sDriver, "AddQuotes_VendorQuotes_Details_Vendor", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_ADDVENDQT_CTW_']/ancestor::form[1]/descendant::*[@id='VEND_ID']");
				Function.AssertEqual(true,MEMPRPLI_AddQuotes_VendorQuotes_Details_Vendor.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing Select on VendorQuotes_Tab...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_VendorQuotes_Tab = new SeleniumControl( sDriver, "VendorQuotes_Tab", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_ADDVENDQT_CTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(MEMPRPLI_VendorQuotes_Tab);
IWebElement mTab = MEMPRPLI_VendorQuotes_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Details").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing VerifyExists on AddQuotes_VendorQuotes_Details_Vendor...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_AddQuotes_VendorQuotes_Details_Vendor = new SeleniumControl( sDriver, "AddQuotes_VendorQuotes_Details_Vendor", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_ADDVENDQT_CTW_']/ancestor::form[1]/descendant::*[@id='VEND_ID']");
				Function.AssertEqual(true,MEMPRPLI_AddQuotes_VendorQuotes_Details_Vendor.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing Select on VendorQuotes_Tab...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_VendorQuotes_Tab = new SeleniumControl( sDriver, "VendorQuotes_Tab", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_ADDVENDQT_CTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(MEMPRPLI_VendorQuotes_Tab);
IWebElement mTab = MEMPRPLI_VendorQuotes_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Alternate Part Numbers").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing VerifyExists on AddQuotes_VendorQuotes_AlternatePartNumbers_Manufacturer...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_AddQuotes_VendorQuotes_AlternatePartNumbers_Manufacturer = new SeleniumControl( sDriver, "AddQuotes_VendorQuotes_AlternatePartNumbers_Manufacturer", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_ADDVENDQT_CTW_']/ancestor::form[1]/descendant::*[@id='MANUF_ID']");
				Function.AssertEqual(true,MEMPRPLI_AddQuotes_VendorQuotes_AlternatePartNumbers_Manufacturer.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing Select on VendorQuotes_Tab...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_VendorQuotes_Tab = new SeleniumControl( sDriver, "VendorQuotes_Tab", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_ADDVENDQT_CTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(MEMPRPLI_VendorQuotes_Tab);
IWebElement mTab = MEMPRPLI_VendorQuotes_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Quote Line Notes").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing Close on AddQuotesForm...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_AddQuotesForm = new SeleniumControl( sDriver, "AddQuotesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_VENDQT_SUBTASK_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MEMPRPLI_AddQuotesForm);
IWebElement formBttn = MEMPRPLI_AddQuotesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Routings Link");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing Click on ProposalCostDetails_RoutingsLink...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_ProposalCostDetails_RoutingsLink = new SeleniumControl( sDriver, "ProposalCostDetails_RoutingsLink", "ID", "lnk_5276_MEMPRPLI_ZMEMPRPLIEXPL_CTW");
				Function.WaitControlDisplayed(MEMPRPLI_ProposalCostDetails_RoutingsLink);
MEMPRPLI_ProposalCostDetails_RoutingsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing VerifyExists on RoutingsForm...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_RoutingsForm = new SeleniumControl( sDriver, "RoutingsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_ROUTING_HDR_']/ancestor::form[1]");
				Function.AssertEqual(true,MEMPRPLI_RoutingsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing VerifyExists on Routings_Proposal...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_Routings_Proposal = new SeleniumControl( sDriver, "Routings_Proposal", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_ROUTING_HDR_']/ancestor::form[1]/descendant::*[@id='PROP_ID']");
				Function.AssertEqual(true,MEMPRPLI_Routings_Proposal.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing VerifyExists on Routings_RoutingDetailsForm...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_Routings_RoutingDetailsForm = new SeleniumControl( sDriver, "Routings_RoutingDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_ROUTINGLN_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,MEMPRPLI_Routings_RoutingDetailsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing VerifyExist on Routings_RoutingDetailsFormTable...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_Routings_RoutingDetailsFormTable = new SeleniumControl( sDriver, "Routings_RoutingDetailsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_ROUTINGLN_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,MEMPRPLI_Routings_RoutingDetailsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing ClickButton on Routings_RoutingDetailsForm...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_Routings_RoutingDetailsForm = new SeleniumControl( sDriver, "Routings_RoutingDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_ROUTINGLN_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MEMPRPLI_Routings_RoutingDetailsForm);
IWebElement formBttn = MEMPRPLI_Routings_RoutingDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? MEMPRPLI_Routings_RoutingDetailsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
MEMPRPLI_Routings_RoutingDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing VerifyExists on Routings_RoutingDetails_OperationSequence...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_Routings_RoutingDetails_OperationSequence = new SeleniumControl( sDriver, "Routings_RoutingDetails_OperationSequence", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_ROUTINGLN_CTW_']/ancestor::form[1]/descendant::*[@id='ROUT_OPER_SEQ_NO']");
				Function.AssertEqual(true,MEMPRPLI_Routings_RoutingDetails_OperationSequence.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing Close on RoutingsForm...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_RoutingsForm = new SeleniumControl( sDriver, "RoutingsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_ROUTING_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MEMPRPLI_RoutingsForm);
IWebElement formBttn = MEMPRPLI_RoutingsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("End Item/Assy Link");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing Click on ProposalCostDetails_EndItemAssyLink...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_ProposalCostDetails_EndItemAssyLink = new SeleniumControl( sDriver, "ProposalCostDetails_EndItemAssyLink", "ID", "lnk_5437_MEMPRPLI_ZMEMPRPLIEXPL_CTW");
				Function.WaitControlDisplayed(MEMPRPLI_ProposalCostDetails_EndItemAssyLink);
MEMPRPLI_ProposalCostDetails_EndItemAssyLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing VerifyExists on EndItemAssyForm...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_EndItemAssyForm = new SeleniumControl( sDriver, "EndItemAssyForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MEMPRPLI_ASYPART_SUBTASK_']/ancestor::form[1]");
				Function.AssertEqual(true,MEMPRPLI_EndItemAssyForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing VerifyExists on EndItemAssy_Proposal...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_EndItemAssy_Proposal = new SeleniumControl( sDriver, "EndItemAssy_Proposal", "xpath", "//div[translate(@id,'0123456789','')='pr__MEMPRPLI_ASYPART_SUBTASK_']/ancestor::form[1]/descendant::*[@id='PROP_ID']");
				Function.AssertEqual(true,MEMPRPLI_EndItemAssy_Proposal.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing Close on EndItemAssyForm...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_EndItemAssyForm = new SeleniumControl( sDriver, "EndItemAssyForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MEMPRPLI_ASYPART_SUBTASK_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MEMPRPLI_EndItemAssyForm);
IWebElement formBttn = MEMPRPLI_EndItemAssyForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Substitute Parts Link");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing Click on ProposalCostDetails_SubstitutePartsLink...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_ProposalCostDetails_SubstitutePartsLink = new SeleniumControl( sDriver, "ProposalCostDetails_SubstitutePartsLink", "ID", "lnk_5293_MEMPRPLI_ZMEMPRPLIEXPL_CTW");
				Function.WaitControlDisplayed(MEMPRPLI_ProposalCostDetails_SubstitutePartsLink);
MEMPRPLI_ProposalCostDetails_SubstitutePartsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing VerifyExists on SubstitutePartsForm...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_SubstitutePartsForm = new SeleniumControl( sDriver, "SubstitutePartsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_SUBTPART_SUBTASK_HDR_']/ancestor::form[1]");
				Function.AssertEqual(true,MEMPRPLI_SubstitutePartsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing VerifyExists on SubstituteParts_Proposal...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_SubstituteParts_Proposal = new SeleniumControl( sDriver, "SubstituteParts_Proposal", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_SUBTPART_SUBTASK_HDR_']/ancestor::form[1]/descendant::*[@id='PROP_ID']");
				Function.AssertEqual(true,MEMPRPLI_SubstituteParts_Proposal.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing VerifyExists on SubstituteParts_SubstitutePartsForm...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_SubstituteParts_SubstitutePartsForm = new SeleniumControl( sDriver, "SubstituteParts_SubstitutePartsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_SUBSTPART_SUBTASK_']/ancestor::form[1]");
				Function.AssertEqual(true,MEMPRPLI_SubstituteParts_SubstitutePartsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing VerifyExist on SubstituteParts_SubstitutePartsFormTable...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_SubstituteParts_SubstitutePartsFormTable = new SeleniumControl( sDriver, "SubstituteParts_SubstitutePartsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_SUBSTPART_SUBTASK_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,MEMPRPLI_SubstituteParts_SubstitutePartsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing ClickButton on SubstituteParts_SubstitutePartsForm...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_SubstituteParts_SubstitutePartsForm = new SeleniumControl( sDriver, "SubstituteParts_SubstitutePartsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_SUBSTPART_SUBTASK_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MEMPRPLI_SubstituteParts_SubstitutePartsForm);
IWebElement formBttn = MEMPRPLI_SubstituteParts_SubstitutePartsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? MEMPRPLI_SubstituteParts_SubstitutePartsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
MEMPRPLI_SubstituteParts_SubstitutePartsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing VerifyExists on SubstituteParts_SubstituteParts_Sequence...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_SubstituteParts_SubstituteParts_Sequence = new SeleniumControl( sDriver, "SubstituteParts_SubstituteParts_Sequence", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_SUBSTPART_SUBTASK_']/ancestor::form[1]/descendant::*[@id='USAGE_SEQ_NO']");
				Function.AssertEqual(true,MEMPRPLI_SubstituteParts_SubstituteParts_Sequence.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing Close on SubstitutePartsForm...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_SubstitutePartsForm = new SeleniumControl( sDriver, "SubstitutePartsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_SUBTPART_SUBTASK_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MEMPRPLI_SubstitutePartsForm);
IWebElement formBttn = MEMPRPLI_SubstitutePartsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Part Documents Link");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing Click on ProposalCostDetails_PartDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_ProposalCostDetails_PartDocumentsLink = new SeleniumControl( sDriver, "ProposalCostDetails_PartDocumentsLink", "ID", "lnk_5291_MEMPRPLI_ZMEMPRPLIEXPL_CTW");
				Function.WaitControlDisplayed(MEMPRPLI_ProposalCostDetails_PartDocumentsLink);
MEMPRPLI_ProposalCostDetails_PartDocumentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing VerifyExists on PartDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_PartDocumentsForm = new SeleniumControl( sDriver, "PartDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]");
				Function.AssertEqual(true,MEMPRPLI_PartDocumentsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing VerifyExist on PartDocumentsFormTable...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_PartDocumentsFormTable = new SeleniumControl( sDriver, "PartDocumentsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,MEMPRPLI_PartDocumentsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing ClickButton on PartDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_PartDocumentsForm = new SeleniumControl( sDriver, "PartDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MEMPRPLI_PartDocumentsForm);
IWebElement formBttn = MEMPRPLI_PartDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? MEMPRPLI_PartDocumentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
MEMPRPLI_PartDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing VerifyExists on PartDocuments_Type...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_PartDocuments_Type = new SeleniumControl( sDriver, "PartDocuments_Type", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]/descendant::*[@id='DOC_TYPE_CD']");
				Function.AssertEqual(true,MEMPRPLI_PartDocuments_Type.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing Close on PartDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_PartDocumentsForm = new SeleniumControl( sDriver, "PartDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MEMPRPLI_PartDocumentsForm);
IWebElement formBttn = MEMPRPLI_PartDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "MEMPRPLI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLI] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLI_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(MEMPRPLI_MainForm);
IWebElement formBttn = MEMPRPLI_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

