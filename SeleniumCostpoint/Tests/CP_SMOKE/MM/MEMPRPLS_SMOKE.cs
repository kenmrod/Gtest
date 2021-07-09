 
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
    public class MEMPRPLS_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Manage Proposal BOM Cost Estimates - Summarized", "xpath","//div[@class='navItem'][.='Manage Proposal BOM Cost Estimates - Summarized']").Click();


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
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,MEMPRPLS_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing VerifyExists on Proposal...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_Proposal = new SeleniumControl( sDriver, "Proposal", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PROP_ID']");
				Function.AssertEqual(true,MEMPRPLS_Proposal.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing Set on Proposal...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_Proposal = new SeleniumControl( sDriver, "Proposal", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PROP_ID']");
				MEMPRPLS_Proposal.Click();
MEMPRPLS_Proposal.SendKeys("NW-TESTINGPROP12345Z", true);
Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));
MEMPRPLS_Proposal.SendKeys(OpenQA.Selenium.Keys.Shift + OpenQA.Selenium.Keys.Tab);


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
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing VerifyExist on ProposalCostDetailsFormTable...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetailsFormTable = new SeleniumControl( sDriver, "ProposalCostDetailsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__MEMPRPLS_PROPITEMDTL_DTL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,MEMPRPLS_ProposalCostDetailsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing ClickButton on ProposalCostDetailsForm...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetailsForm = new SeleniumControl( sDriver, "ProposalCostDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MEMPRPLS_PROPITEMDTL_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MEMPRPLS_ProposalCostDetailsForm);
IWebElement formBttn = MEMPRPLS_ProposalCostDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? MEMPRPLS_ProposalCostDetailsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
MEMPRPLS_ProposalCostDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing VerifyExists on ProposalCostDetailsForm...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetailsForm = new SeleniumControl( sDriver, "ProposalCostDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MEMPRPLS_PROPITEMDTL_DTL_']/ancestor::form[1]");
				Function.AssertEqual(true,MEMPRPLS_ProposalCostDetailsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing VerifyExists on ProposalCostDetails_Item...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_Item = new SeleniumControl( sDriver, "ProposalCostDetails_Item", "xpath", "//div[translate(@id,'0123456789','')='pr__MEMPRPLS_PROPITEMDTL_DTL_']/ancestor::form[1]/descendant::*[@id='PROP_ITEM_ID']");
				Function.AssertEqual(true,MEMPRPLS_ProposalCostDetails_Item.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Proposal Cost Details Tab");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing Select on ProposalCostDetailsTab...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetailsTab = new SeleniumControl( sDriver, "ProposalCostDetailsTab", "xpath", "//div[translate(@id,'0123456789','')='pr__MEMPRPLS_PROPITEMDTL_DTL_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(MEMPRPLS_ProposalCostDetailsTab);
IWebElement mTab = MEMPRPLS_ProposalCostDetailsTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Costs").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing VerifyExists on ProposalCostDetails_Costs_ProposalCostAmounts_DirectUnit...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_Costs_ProposalCostAmounts_DirectUnit = new SeleniumControl( sDriver, "ProposalCostDetails_Costs_ProposalCostAmounts_DirectUnit", "xpath", "//div[translate(@id,'0123456789','')='pr__MEMPRPLS_PROPITEMDTL_DTL_']/ancestor::form[1]/descendant::*[@id='COLNDIRECTUNITCSTAMT']");
				Function.AssertEqual(true,MEMPRPLS_ProposalCostDetails_Costs_ProposalCostAmounts_DirectUnit.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing Select on ProposalCostDetailsTab...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetailsTab = new SeleniumControl( sDriver, "ProposalCostDetailsTab", "xpath", "//div[translate(@id,'0123456789','')='pr__MEMPRPLS_PROPITEMDTL_DTL_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(MEMPRPLS_ProposalCostDetailsTab);
IWebElement mTab = MEMPRPLS_ProposalCostDetailsTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Proposal Quantity Breakpoints").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing VerifyExists on ProposalCostDetails_ProposalQuantityBreakpoints_Breakpoint1...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_ProposalQuantityBreakpoints_Breakpoint1 = new SeleniumControl( sDriver, "ProposalCostDetails_ProposalQuantityBreakpoints_Breakpoint1", "xpath", "//div[translate(@id,'0123456789','')='pr__MEMPRPLS_PROPITEMDTL_DTL_']/ancestor::form[1]/descendant::*[@id='BRK_1_QTY']");
				Function.AssertEqual(true,MEMPRPLS_ProposalCostDetails_ProposalQuantityBreakpoints_Breakpoint1.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing Select on ProposalCostDetailsTab...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetailsTab = new SeleniumControl( sDriver, "ProposalCostDetailsTab", "xpath", "//div[translate(@id,'0123456789','')='pr__MEMPRPLS_PROPITEMDTL_DTL_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(MEMPRPLS_ProposalCostDetailsTab);
IWebElement mTab = MEMPRPLS_ProposalCostDetailsTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Item Details").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing VerifyExists on ProposalCostDetails_ItemDetails_MakeBuy...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_ItemDetails_MakeBuy = new SeleniumControl( sDriver, "ProposalCostDetails_ItemDetails_MakeBuy", "xpath", "//div[translate(@id,'0123456789','')='pr__MEMPRPLS_PROPITEMDTL_DTL_']/ancestor::form[1]/descendant::*[@id='S_MAKE_BUY_CD']");
				Function.AssertEqual(true,MEMPRPLS_ProposalCostDetails_ItemDetails_MakeBuy.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing Select on ProposalCostDetailsTab...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetailsTab = new SeleniumControl( sDriver, "ProposalCostDetailsTab", "xpath", "//div[translate(@id,'0123456789','')='pr__MEMPRPLS_PROPITEMDTL_DTL_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(MEMPRPLS_ProposalCostDetailsTab);
IWebElement mTab = MEMPRPLS_ProposalCostDetailsTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Proposal Item Notes").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing VerifyExists on ProposalCostDetails_ProposalItemNotes_ProposalItemNotes...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_ProposalItemNotes_ProposalItemNotes = new SeleniumControl( sDriver, "ProposalCostDetails_ProposalItemNotes_ProposalItemNotes", "xpath", "//div[translate(@id,'0123456789','')='pr__MEMPRPLS_PROPITEMDTL_DTL_']/ancestor::form[1]/descendant::*[@id='PROP_ITEM_NT']");
				Function.AssertEqual(true,MEMPRPLS_ProposalCostDetails_ProposalItemNotes_ProposalItemNotes.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Proposal Item Costs Link");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing VerifyExists on ProposalCostDetails_ProposalItemCostsLink...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_ProposalItemCostsLink = new SeleniumControl( sDriver, "ProposalCostDetails_ProposalItemCostsLink", "ID", "lnk_5474_MEMPRPLS_PROPITEMDTL_DTL");
				Function.AssertEqual(true,MEMPRPLS_ProposalCostDetails_ProposalItemCostsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing Click on ProposalCostDetails_ProposalItemCostsLink...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_ProposalItemCostsLink = new SeleniumControl( sDriver, "ProposalCostDetails_ProposalItemCostsLink", "ID", "lnk_5474_MEMPRPLS_PROPITEMDTL_DTL");
				Function.WaitControlDisplayed(MEMPRPLS_ProposalCostDetails_ProposalItemCostsLink);
MEMPRPLS_ProposalCostDetails_ProposalItemCostsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing VerifyExists on ProposalCostDetails_ProposalItemCostsForm...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_ProposalItemCostsForm = new SeleniumControl( sDriver, "ProposalCostDetails_ProposalItemCostsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_PROPITEMCST_HDR_']/ancestor::form[1]");
				Function.AssertEqual(true,MEMPRPLS_ProposalCostDetails_ProposalItemCostsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing VerifyExists on ProposalCostDetails_ProposalItemCosts_Proposal...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_ProposalItemCosts_Proposal = new SeleniumControl( sDriver, "ProposalCostDetails_ProposalItemCosts_Proposal", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_PROPITEMCST_HDR_']/ancestor::form[1]/descendant::*[@id='PROP_ID']");
				Function.AssertEqual(true,MEMPRPLS_ProposalCostDetails_ProposalItemCosts_Proposal.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing VerifyExist on ProposalCostDetails_ProposalItemCosts_CostRecordsFormTable...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_ProposalItemCosts_CostRecordsFormTable = new SeleniumControl( sDriver, "ProposalCostDetails_ProposalItemCosts_CostRecordsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_PROPOSITEMCST_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,MEMPRPLS_ProposalCostDetails_ProposalItemCosts_CostRecordsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing ClickButton on ProposalCostDetails_ProposalItemCosts_CostRecordsForm...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_ProposalItemCosts_CostRecordsForm = new SeleniumControl( sDriver, "ProposalCostDetails_ProposalItemCosts_CostRecordsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_PROPOSITEMCST_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MEMPRPLS_ProposalCostDetails_ProposalItemCosts_CostRecordsForm);
IWebElement formBttn = MEMPRPLS_ProposalCostDetails_ProposalItemCosts_CostRecordsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? MEMPRPLS_ProposalCostDetails_ProposalItemCosts_CostRecordsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
MEMPRPLS_ProposalCostDetails_ProposalItemCosts_CostRecordsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing VerifyExists on ProposalCostDetails_ProposalItemCosts_CostRecordsForm...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_ProposalItemCosts_CostRecordsForm = new SeleniumControl( sDriver, "ProposalCostDetails_ProposalItemCosts_CostRecordsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_PROPOSITEMCST_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,MEMPRPLS_ProposalCostDetails_ProposalItemCosts_CostRecordsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing VerifyExists on ProposalCostDetails_ProposalItemCosts_CostRecords_MinimumQuantity...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_ProposalItemCosts_CostRecords_MinimumQuantity = new SeleniumControl( sDriver, "ProposalCostDetails_ProposalItemCosts_CostRecords_MinimumQuantity", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_PROPOSITEMCST_CTW_']/ancestor::form[1]/descendant::*[@id='MIN_QTY']");
				Function.AssertEqual(true,MEMPRPLS_ProposalCostDetails_ProposalItemCosts_CostRecords_MinimumQuantity.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Cost Records Tab");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing Select on ProposalCostDetails_ProposalItemCosts_CostRecordsTab...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_ProposalItemCosts_CostRecordsTab = new SeleniumControl( sDriver, "ProposalCostDetails_ProposalItemCosts_CostRecordsTab", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_PROPOSITEMCST_CTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(MEMPRPLS_ProposalCostDetails_ProposalItemCosts_CostRecordsTab);
IWebElement mTab = MEMPRPLS_ProposalCostDetails_ProposalItemCosts_CostRecordsTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Incremental Costs").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing VerifyExists on ProposalCostDetails_ProposalItemCosts_CostRecords_IncrementalCosts_ThisLevelDirectUnitCost...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_ProposalItemCosts_CostRecords_IncrementalCosts_ThisLevelDirectUnitCost = new SeleniumControl( sDriver, "ProposalCostDetails_ProposalItemCosts_CostRecords_IncrementalCosts_ThisLevelDirectUnitCost", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_PROPOSITEMCST_CTW_']/ancestor::form[1]/descendant::*[@id='TL_DIR_UNIT_CST']");
				Function.AssertEqual(true,MEMPRPLS_ProposalCostDetails_ProposalItemCosts_CostRecords_IncrementalCosts_ThisLevelDirectUnitCost.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing Select on ProposalCostDetails_ProposalItemCosts_CostRecordsTab...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_ProposalItemCosts_CostRecordsTab = new SeleniumControl( sDriver, "ProposalCostDetails_ProposalItemCosts_CostRecordsTab", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_PROPOSITEMCST_CTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(MEMPRPLS_ProposalCostDetails_ProposalItemCosts_CostRecordsTab);
IWebElement mTab = MEMPRPLS_ProposalCostDetails_ProposalItemCosts_CostRecordsTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Cost Source Details").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing VerifyExists on ProposalCostDetails_ProposalItemCosts_CostRecords_CostSourceDetails_Vendor...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_ProposalItemCosts_CostRecords_CostSourceDetails_Vendor = new SeleniumControl( sDriver, "ProposalCostDetails_ProposalItemCosts_CostRecords_CostSourceDetails_Vendor", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_PROPOSITEMCST_CTW_']/ancestor::form[1]/descendant::*[@id='VEND_ID']");
				Function.AssertEqual(true,MEMPRPLS_ProposalCostDetails_ProposalItemCosts_CostRecords_CostSourceDetails_Vendor.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing Select on ProposalCostDetails_ProposalItemCosts_CostRecordsTab...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_ProposalItemCosts_CostRecordsTab = new SeleniumControl( sDriver, "ProposalCostDetails_ProposalItemCosts_CostRecordsTab", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_PROPOSITEMCST_CTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(MEMPRPLS_ProposalCostDetails_ProposalItemCosts_CostRecordsTab);
IWebElement mTab = MEMPRPLS_ProposalCostDetails_ProposalItemCosts_CostRecordsTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Notes").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing VerifyExists on ProposalCostDetails_ProposalItemCosts_CostRecords_Notes_Notes...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_ProposalItemCosts_CostRecords_Notes_Notes = new SeleniumControl( sDriver, "ProposalCostDetails_ProposalItemCosts_CostRecords_Notes_Notes", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_PROPOSITEMCST_CTW_']/ancestor::form[1]/descendant::*[@id='ITEM_CST_NT']");
				Function.AssertEqual(true,MEMPRPLS_ProposalCostDetails_ProposalItemCosts_CostRecords_Notes_Notes.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing Close on ProposalCostDetails_ProposalItemCostsForm...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_ProposalItemCostsForm = new SeleniumControl( sDriver, "ProposalCostDetails_ProposalItemCostsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_PROPITEMCST_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MEMPRPLS_ProposalCostDetails_ProposalItemCostsForm);
IWebElement formBttn = MEMPRPLS_ProposalCostDetails_ProposalItemCostsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Matl Costs WS Link");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing VerifyExists on ProposalCostDetails_MatlCostsWSLink...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_MatlCostsWSLink = new SeleniumControl( sDriver, "ProposalCostDetails_MatlCostsWSLink", "ID", "lnk_5476_MEMPRPLS_PROPITEMDTL_DTL");
				Function.AssertEqual(true,MEMPRPLS_ProposalCostDetails_MatlCostsWSLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing Click on ProposalCostDetails_MatlCostsWSLink...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_MatlCostsWSLink = new SeleniumControl( sDriver, "ProposalCostDetails_MatlCostsWSLink", "ID", "lnk_5476_MEMPRPLS_PROPITEMDTL_DTL");
				Function.WaitControlDisplayed(MEMPRPLS_ProposalCostDetails_MatlCostsWSLink);
MEMPRPLS_ProposalCostDetails_MatlCostsWSLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing VerifyExists on ProposalCostDetails_MatlCostsWSForm...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_MatlCostsWSForm = new SeleniumControl( sDriver, "ProposalCostDetails_MatlCostsWSForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_MATLCST_SUBTASK_HDR_']/ancestor::form[1]");
				Function.AssertEqual(true,MEMPRPLS_ProposalCostDetails_MatlCostsWSForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing VerifyExists on ProposalCostDetails_MatlCostsWS_Proposal...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_MatlCostsWS_Proposal = new SeleniumControl( sDriver, "ProposalCostDetails_MatlCostsWS_Proposal", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_MATLCST_SUBTASK_HDR_']/ancestor::form[1]/descendant::*[@id='PROP_ID']");
				Function.AssertEqual(true,MEMPRPLS_ProposalCostDetails_MatlCostsWS_Proposal.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing VerifyExist on ProposalCostDetails_MatlCostsWS_MaterialCostsWSFormTable...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_MatlCostsWS_MaterialCostsWSFormTable = new SeleniumControl( sDriver, "ProposalCostDetails_MatlCostsWS_MaterialCostsWSFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_MEMATLCST_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,MEMPRPLS_ProposalCostDetails_MatlCostsWS_MaterialCostsWSFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing ClickButton on ProposalCostDetails_MatlCostsWS_MaterialCostsWSForm...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_MatlCostsWS_MaterialCostsWSForm = new SeleniumControl( sDriver, "ProposalCostDetails_MatlCostsWS_MaterialCostsWSForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_MEMATLCST_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MEMPRPLS_ProposalCostDetails_MatlCostsWS_MaterialCostsWSForm);
IWebElement formBttn = MEMPRPLS_ProposalCostDetails_MatlCostsWS_MaterialCostsWSForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? MEMPRPLS_ProposalCostDetails_MatlCostsWS_MaterialCostsWSForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
MEMPRPLS_ProposalCostDetails_MatlCostsWS_MaterialCostsWSForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing VerifyExists on ProposalCostDetails_MatlCostsWS_MaterialCostsWSForm...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_MatlCostsWS_MaterialCostsWSForm = new SeleniumControl( sDriver, "ProposalCostDetails_MatlCostsWS_MaterialCostsWSForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_MEMATLCST_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,MEMPRPLS_ProposalCostDetails_MatlCostsWS_MaterialCostsWSForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing VerifyExists on ProposalCostDetails_MatlCostsWS_MaterialCostsWS_MinimumQuantity...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_MatlCostsWS_MaterialCostsWS_MinimumQuantity = new SeleniumControl( sDriver, "ProposalCostDetails_MatlCostsWS_MaterialCostsWS_MinimumQuantity", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_MEMATLCST_CTW_']/ancestor::form[1]/descendant::*[@id='MIN_QT']");
				Function.AssertEqual(true,MEMPRPLS_ProposalCostDetails_MatlCostsWS_MaterialCostsWS_MinimumQuantity.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Material Costs WS Tab");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing Select on ProposalCostDetails_MatlCostsWS_MaterialCostsWSTab...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_MatlCostsWS_MaterialCostsWSTab = new SeleniumControl( sDriver, "ProposalCostDetails_MatlCostsWS_MaterialCostsWSTab", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_MEMATLCST_CTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(MEMPRPLS_ProposalCostDetails_MatlCostsWS_MaterialCostsWSTab);
IWebElement mTab = MEMPRPLS_ProposalCostDetails_MatlCostsWS_MaterialCostsWSTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Cost Information").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing VerifyExists on ProposalCostDetails_MatlCostsWS_MaterialCostsWS_CostInformation_OrderQuoteGrossUnitCost...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_MatlCostsWS_MaterialCostsWS_CostInformation_OrderQuoteGrossUnitCost = new SeleniumControl( sDriver, "ProposalCostDetails_MatlCostsWS_MaterialCostsWS_CostInformation_OrderQuoteGrossUnitCost", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_MEMATLCST_CTW_']/ancestor::form[1]/descendant::*[@id='GROSS_UNIT_CST_AMT']");
				Function.AssertEqual(true,MEMPRPLS_ProposalCostDetails_MatlCostsWS_MaterialCostsWS_CostInformation_OrderQuoteGrossUnitCost.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing Select on ProposalCostDetails_MatlCostsWS_MaterialCostsWSTab...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_MatlCostsWS_MaterialCostsWSTab = new SeleniumControl( sDriver, "ProposalCostDetails_MatlCostsWS_MaterialCostsWSTab", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_MEMATLCST_CTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(MEMPRPLS_ProposalCostDetails_MatlCostsWS_MaterialCostsWSTab);
IWebElement mTab = MEMPRPLS_ProposalCostDetails_MatlCostsWS_MaterialCostsWSTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Cost Source Details").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing VerifyExists on ProposalCostDetails_MatlCostsWS_MaterialCostsWS_CostSourceDetails_VendorDetails_Vendor...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_MatlCostsWS_MaterialCostsWS_CostSourceDetails_VendorDetails_Vendor = new SeleniumControl( sDriver, "ProposalCostDetails_MatlCostsWS_MaterialCostsWS_CostSourceDetails_VendorDetails_Vendor", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_MEMATLCST_CTW_']/ancestor::form[1]/descendant::*[@id='VEND_ID']");
				Function.AssertEqual(true,MEMPRPLS_ProposalCostDetails_MatlCostsWS_MaterialCostsWS_CostSourceDetails_VendorDetails_Vendor.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing Select on ProposalCostDetails_MatlCostsWS_MaterialCostsWSTab...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_MatlCostsWS_MaterialCostsWSTab = new SeleniumControl( sDriver, "ProposalCostDetails_MatlCostsWS_MaterialCostsWSTab", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_MEMATLCST_CTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(MEMPRPLS_ProposalCostDetails_MatlCostsWS_MaterialCostsWSTab);
IWebElement mTab = MEMPRPLS_ProposalCostDetails_MatlCostsWS_MaterialCostsWSTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Notes").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing VerifyExists on ProposalCostDetails_MatlCostsWS_MaterialCostsWS_Notes_Notes...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_MatlCostsWS_MaterialCostsWS_Notes_Notes = new SeleniumControl( sDriver, "ProposalCostDetails_MatlCostsWS_MaterialCostsWS_Notes_Notes", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_MEMATLCST_CTW_']/ancestor::form[1]/descendant::*[@id='NOTES_DISP']");
				Function.AssertEqual(true,MEMPRPLS_ProposalCostDetails_MatlCostsWS_MaterialCostsWS_Notes_Notes.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing Close on ProposalCostDetails_MatlCostsWSForm...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_MatlCostsWSForm = new SeleniumControl( sDriver, "ProposalCostDetails_MatlCostsWSForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_MATLCST_SUBTASK_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MEMPRPLS_ProposalCostDetails_MatlCostsWSForm);
IWebElement formBttn = MEMPRPLS_ProposalCostDetails_MatlCostsWSForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing VerifyExists on ProposalCostDetails_RFQsLink...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_RFQsLink = new SeleniumControl( sDriver, "ProposalCostDetails_RFQsLink", "ID", "lnk_5479_MEMPRPLS_PROPITEMDTL_DTL");
				Function.AssertEqual(true,MEMPRPLS_ProposalCostDetails_RFQsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing Click on ProposalCostDetails_RFQsLink...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_RFQsLink = new SeleniumControl( sDriver, "ProposalCostDetails_RFQsLink", "ID", "lnk_5479_MEMPRPLS_PROPITEMDTL_DTL");
				Function.WaitControlDisplayed(MEMPRPLS_ProposalCostDetails_RFQsLink);
MEMPRPLS_ProposalCostDetails_RFQsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing VerifyExists on ProposalCostDetails_RFQsForm...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_RFQsForm = new SeleniumControl( sDriver, "ProposalCostDetails_RFQsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_RFQ_SUBTASK_HDR_']/ancestor::form[1]");
				Function.AssertEqual(true,MEMPRPLS_ProposalCostDetails_RFQsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing VerifyExists on ProposalCostDetails_RFQs_Proposal...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_RFQs_Proposal = new SeleniumControl( sDriver, "ProposalCostDetails_RFQs_Proposal", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_RFQ_SUBTASK_HDR_']/ancestor::form[1]/descendant::*[@id='PROP_ID']");
				Function.AssertEqual(true,MEMPRPLS_ProposalCostDetails_RFQs_Proposal.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing VerifyExist on ProposalCostDetails_RFQs_RequestForQuotesFormTable...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_RFQs_RequestForQuotesFormTable = new SeleniumControl( sDriver, "ProposalCostDetails_RFQs_RequestForQuotesFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_MERFQS_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,MEMPRPLS_ProposalCostDetails_RFQs_RequestForQuotesFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing ClickButton on ProposalCostDetails_RFQs_RequestForQuotesForm...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_RFQs_RequestForQuotesForm = new SeleniumControl( sDriver, "ProposalCostDetails_RFQs_RequestForQuotesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_MERFQS_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MEMPRPLS_ProposalCostDetails_RFQs_RequestForQuotesForm);
IWebElement formBttn = MEMPRPLS_ProposalCostDetails_RFQs_RequestForQuotesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? MEMPRPLS_ProposalCostDetails_RFQs_RequestForQuotesForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
MEMPRPLS_ProposalCostDetails_RFQs_RequestForQuotesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing VerifyExists on ProposalCostDetails_RFQs_RequestForQuotesForm...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_RFQs_RequestForQuotesForm = new SeleniumControl( sDriver, "ProposalCostDetails_RFQs_RequestForQuotesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_MERFQS_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,MEMPRPLS_ProposalCostDetails_RFQs_RequestForQuotesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing VerifyExists on ProposalCostDetails_RFQs_RequestForQuotes_Vendor...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_RFQs_RequestForQuotes_Vendor = new SeleniumControl( sDriver, "ProposalCostDetails_RFQs_RequestForQuotes_Vendor", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_MERFQS_CTW_']/ancestor::form[1]/descendant::*[@id='VEND_ID']");
				Function.AssertEqual(true,MEMPRPLS_ProposalCostDetails_RFQs_RequestForQuotes_Vendor.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Request For Quotes Tab");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing Select on ProposalCostDetails_RFQs_RequestForQuotesTab...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_RFQs_RequestForQuotesTab = new SeleniumControl( sDriver, "ProposalCostDetails_RFQs_RequestForQuotesTab", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_MERFQS_CTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(MEMPRPLS_ProposalCostDetails_RFQs_RequestForQuotesTab);
IWebElement mTab = MEMPRPLS_ProposalCostDetails_RFQs_RequestForQuotesTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Details").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing VerifyExists on ProposalCostDetails_RFQs_RequestForQuotes_Details_RFQCreated...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_RFQs_RequestForQuotes_Details_RFQCreated = new SeleniumControl( sDriver, "ProposalCostDetails_RFQs_RequestForQuotes_Details_RFQCreated", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_MERFQS_CTW_']/ancestor::form[1]/descendant::*[@id='RFQ_FL']");
				Function.AssertEqual(true,MEMPRPLS_ProposalCostDetails_RFQs_RequestForQuotes_Details_RFQCreated.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing Select on ProposalCostDetails_RFQs_RequestForQuotesTab...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_RFQs_RequestForQuotesTab = new SeleniumControl( sDriver, "ProposalCostDetails_RFQs_RequestForQuotesTab", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_MERFQS_CTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(MEMPRPLS_ProposalCostDetails_RFQs_RequestForQuotesTab);
IWebElement mTab = MEMPRPLS_ProposalCostDetails_RFQs_RequestForQuotesTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "RFQ Line Notes").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing VerifyExists on ProposalCostDetails_RFQs_RequestForQuotes_RFQLineNotes_RFQLineNotes...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_RFQs_RequestForQuotes_RFQLineNotes_RFQLineNotes = new SeleniumControl( sDriver, "ProposalCostDetails_RFQs_RequestForQuotes_RFQLineNotes_RFQLineNotes", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_MERFQS_CTW_']/ancestor::form[1]/descendant::*[@id='RFQ_LN_NOTES']");
				Function.AssertEqual(true,MEMPRPLS_ProposalCostDetails_RFQs_RequestForQuotes_RFQLineNotes_RFQLineNotes.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing Close on ProposalCostDetails_RFQsForm...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_RFQsForm = new SeleniumControl( sDriver, "ProposalCostDetails_RFQsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_RFQ_SUBTASK_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MEMPRPLS_ProposalCostDetails_RFQsForm);
IWebElement formBttn = MEMPRPLS_ProposalCostDetails_RFQsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing VerifyExists on ProposalCostDetails_InventoryLink...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_InventoryLink = new SeleniumControl( sDriver, "ProposalCostDetails_InventoryLink", "ID", "lnk_5482_MEMPRPLS_PROPITEMDTL_DTL");
				Function.AssertEqual(true,MEMPRPLS_ProposalCostDetails_InventoryLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing Click on ProposalCostDetails_InventoryLink...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_InventoryLink = new SeleniumControl( sDriver, "ProposalCostDetails_InventoryLink", "ID", "lnk_5482_MEMPRPLS_PROPITEMDTL_DTL");
				Function.WaitControlDisplayed(MEMPRPLS_ProposalCostDetails_InventoryLink);
MEMPRPLS_ProposalCostDetails_InventoryLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing VerifyExists on ProposalCostDetails_InventoryForm...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_InventoryForm = new SeleniumControl( sDriver, "ProposalCostDetails_InventoryForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_INVT_SUBTASK_HDR_']/ancestor::form[1]");
				Function.AssertEqual(true,MEMPRPLS_ProposalCostDetails_InventoryForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing VerifyExists on ProposalCostDetails_Inventory_Proposal...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_Inventory_Proposal = new SeleniumControl( sDriver, "ProposalCostDetails_Inventory_Proposal", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_INVT_SUBTASK_HDR_']/ancestor::form[1]/descendant::*[@id='PROP_ID']");
				Function.AssertEqual(true,MEMPRPLS_ProposalCostDetails_Inventory_Proposal.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing VerifyExist on ProposalCostDetails_Inventory_InventoryDetailsFormTable...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_Inventory_InventoryDetailsFormTable = new SeleniumControl( sDriver, "ProposalCostDetails_Inventory_InventoryDetailsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_INVT_MEINVT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,MEMPRPLS_ProposalCostDetails_Inventory_InventoryDetailsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing ClickButton on ProposalCostDetails_Inventory_InventoryDetailsForm...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_Inventory_InventoryDetailsForm = new SeleniumControl( sDriver, "ProposalCostDetails_Inventory_InventoryDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_INVT_MEINVT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MEMPRPLS_ProposalCostDetails_Inventory_InventoryDetailsForm);
IWebElement formBttn = MEMPRPLS_ProposalCostDetails_Inventory_InventoryDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? MEMPRPLS_ProposalCostDetails_Inventory_InventoryDetailsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
MEMPRPLS_ProposalCostDetails_Inventory_InventoryDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing VerifyExists on ProposalCostDetails_Inventory_InventoryDetailsForm...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_Inventory_InventoryDetailsForm = new SeleniumControl( sDriver, "ProposalCostDetails_Inventory_InventoryDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_INVT_MEINVT_']/ancestor::form[1]");
				Function.AssertEqual(true,MEMPRPLS_ProposalCostDetails_Inventory_InventoryDetailsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing VerifyExists on ProposalCostDetails_Inventory_InventoryDetails_Project...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_Inventory_InventoryDetails_Project = new SeleniumControl( sDriver, "ProposalCostDetails_Inventory_InventoryDetails_Project", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_INVT_MEINVT_']/ancestor::form[1]/descendant::*[@id='PROJ_ID']");
				Function.AssertEqual(true,MEMPRPLS_ProposalCostDetails_Inventory_InventoryDetails_Project.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Inventory Details Tab");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing Select on ProposalCostDetails_Inventory_InventoryDetailsTab...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_Inventory_InventoryDetailsTab = new SeleniumControl( sDriver, "ProposalCostDetails_Inventory_InventoryDetailsTab", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_INVT_MEINVT_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(MEMPRPLS_ProposalCostDetails_Inventory_InventoryDetailsTab);
IWebElement mTab = MEMPRPLS_ProposalCostDetails_Inventory_InventoryDetailsTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Inventory Quantities").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing VerifyExists on ProposalCostDetails_Inventory_InventoryDetails_InventoryQuantities_Quantities_NetAvailable...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_Inventory_InventoryDetails_InventoryQuantities_Quantities_NetAvailable = new SeleniumControl( sDriver, "ProposalCostDetails_Inventory_InventoryDetails_InventoryQuantities_Quantities_NetAvailable", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_INVT_MEINVT_']/ancestor::form[1]/descendant::*[@id='NET_AVAIL_QTY']");
				Function.AssertEqual(true,MEMPRPLS_ProposalCostDetails_Inventory_InventoryDetails_InventoryQuantities_Quantities_NetAvailable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing Select on ProposalCostDetails_Inventory_InventoryDetailsTab...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_Inventory_InventoryDetailsTab = new SeleniumControl( sDriver, "ProposalCostDetails_Inventory_InventoryDetailsTab", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_INVT_MEINVT_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(MEMPRPLS_ProposalCostDetails_Inventory_InventoryDetailsTab);
IWebElement mTab = MEMPRPLS_ProposalCostDetails_Inventory_InventoryDetailsTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Unit Cost").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing VerifyExists on ProposalCostDetails_Inventory_InventoryDetails_UnitCost_UnitCosts_DirectMaterial...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_Inventory_InventoryDetails_UnitCost_UnitCosts_DirectMaterial = new SeleniumControl( sDriver, "ProposalCostDetails_Inventory_InventoryDetails_UnitCost_UnitCosts_DirectMaterial", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_INVT_MEINVT_']/ancestor::form[1]/descendant::*[@id='MATL_CST_AMT']");
				Function.AssertEqual(true,MEMPRPLS_ProposalCostDetails_Inventory_InventoryDetails_UnitCost_UnitCosts_DirectMaterial.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing Select on ProposalCostDetails_Inventory_InventoryDetailsTab...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_Inventory_InventoryDetailsTab = new SeleniumControl( sDriver, "ProposalCostDetails_Inventory_InventoryDetailsTab", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_INVT_MEINVT_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(MEMPRPLS_ProposalCostDetails_Inventory_InventoryDetailsTab);
IWebElement mTab = MEMPRPLS_ProposalCostDetails_Inventory_InventoryDetailsTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Expediting Notes").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing VerifyExists on ProposalCostDetails_Inventory_InventoryDetails_ExpeditingNotes_ExpeditingNotes...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_Inventory_InventoryDetails_ExpeditingNotes_ExpeditingNotes = new SeleniumControl( sDriver, "ProposalCostDetails_Inventory_InventoryDetails_ExpeditingNotes_ExpeditingNotes", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_INVT_MEINVT_']/ancestor::form[1]/descendant::*[@id='EXPDT_TX']");
				Function.AssertEqual(true,MEMPRPLS_ProposalCostDetails_Inventory_InventoryDetails_ExpeditingNotes_ExpeditingNotes.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing Close on ProposalCostDetails_InventoryForm...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_InventoryForm = new SeleniumControl( sDriver, "ProposalCostDetails_InventoryForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_INVT_SUBTASK_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MEMPRPLS_ProposalCostDetails_InventoryForm);
IWebElement formBttn = MEMPRPLS_ProposalCostDetails_InventoryForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing VerifyExists on ProposalCostDetails_AlternatePartsLink...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_AlternatePartsLink = new SeleniumControl( sDriver, "ProposalCostDetails_AlternatePartsLink", "ID", "lnk_5485_MEMPRPLS_PROPITEMDTL_DTL");
				Function.AssertEqual(true,MEMPRPLS_ProposalCostDetails_AlternatePartsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing Click on ProposalCostDetails_AlternatePartsLink...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_AlternatePartsLink = new SeleniumControl( sDriver, "ProposalCostDetails_AlternatePartsLink", "ID", "lnk_5485_MEMPRPLS_PROPITEMDTL_DTL");
				Function.WaitControlDisplayed(MEMPRPLS_ProposalCostDetails_AlternatePartsLink);
MEMPRPLS_ProposalCostDetails_AlternatePartsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing VerifyExists on ProposalCostDetails_AlternatePartsForm...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_AlternatePartsForm = new SeleniumControl( sDriver, "ProposalCostDetails_AlternatePartsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_ALTPART_SUBTASK_HDR_']/ancestor::form[1]");
				Function.AssertEqual(true,MEMPRPLS_ProposalCostDetails_AlternatePartsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing VerifyExists on ProposalCostDetails_AlternateParts_Proposal...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_AlternateParts_Proposal = new SeleniumControl( sDriver, "ProposalCostDetails_AlternateParts_Proposal", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_ALTPART_SUBTASK_HDR_']/ancestor::form[1]/descendant::*[@id='PROP_ID']");
				Function.AssertEqual(true,MEMPRPLS_ProposalCostDetails_AlternateParts_Proposal.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing VerifyExist on ProposalCostDetails_AlternateParts_AlternatePartsFormTable...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_AlternateParts_AlternatePartsFormTable = new SeleniumControl( sDriver, "ProposalCostDetails_AlternateParts_AlternatePartsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_ALTPART_CHILD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,MEMPRPLS_ProposalCostDetails_AlternateParts_AlternatePartsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing ClickButton on ProposalCostDetails_AlternateParts_AlternatePartsForm...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_AlternateParts_AlternatePartsForm = new SeleniumControl( sDriver, "ProposalCostDetails_AlternateParts_AlternatePartsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_ALTPART_CHILD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MEMPRPLS_ProposalCostDetails_AlternateParts_AlternatePartsForm);
IWebElement formBttn = MEMPRPLS_ProposalCostDetails_AlternateParts_AlternatePartsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? MEMPRPLS_ProposalCostDetails_AlternateParts_AlternatePartsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
MEMPRPLS_ProposalCostDetails_AlternateParts_AlternatePartsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing VerifyExists on ProposalCostDetails_AlternateParts_AlternatePartsForm...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_AlternateParts_AlternatePartsForm = new SeleniumControl( sDriver, "ProposalCostDetails_AlternateParts_AlternatePartsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_ALTPART_CHILD_']/ancestor::form[1]");
				Function.AssertEqual(true,MEMPRPLS_ProposalCostDetails_AlternateParts_AlternatePartsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing VerifyExists on ProposalCostDetails_AlternateParts_AlternateParts_Sequence...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_AlternateParts_AlternateParts_Sequence = new SeleniumControl( sDriver, "ProposalCostDetails_AlternateParts_AlternateParts_Sequence", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_ALTPART_CHILD_']/ancestor::form[1]/descendant::*[@id='SEQ_NO']");
				Function.AssertEqual(true,MEMPRPLS_ProposalCostDetails_AlternateParts_AlternateParts_Sequence.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing Close on ProposalCostDetails_AlternatePartsForm...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_AlternatePartsForm = new SeleniumControl( sDriver, "ProposalCostDetails_AlternatePartsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_ALTPART_SUBTASK_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MEMPRPLS_ProposalCostDetails_AlternatePartsForm);
IWebElement formBttn = MEMPRPLS_ProposalCostDetails_AlternatePartsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("PBOM Detail Link");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing VerifyExists on ProposalCostDetails_PBOMDetailLink...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_PBOMDetailLink = new SeleniumControl( sDriver, "ProposalCostDetails_PBOMDetailLink", "ID", "lnk_5461_MEMPRPLS_PROPITEMDTL_DTL");
				Function.AssertEqual(true,MEMPRPLS_ProposalCostDetails_PBOMDetailLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing Click on ProposalCostDetails_PBOMDetailLink...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_PBOMDetailLink = new SeleniumControl( sDriver, "ProposalCostDetails_PBOMDetailLink", "ID", "lnk_5461_MEMPRPLS_PROPITEMDTL_DTL");
				Function.WaitControlDisplayed(MEMPRPLS_ProposalCostDetails_PBOMDetailLink);
MEMPRPLS_ProposalCostDetails_PBOMDetailLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing VerifyExists on ProposalCostDetails_PBOMDetailForm...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_PBOMDetailForm = new SeleniumControl( sDriver, "ProposalCostDetails_PBOMDetailForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MEMPRPLS_PBOMDTL_SUBTASK_HDR_']/ancestor::form[1]");
				Function.AssertEqual(true,MEMPRPLS_ProposalCostDetails_PBOMDetailForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing VerifyExists on ProposalCostDetails_PBOMDetail_Proposal...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_PBOMDetail_Proposal = new SeleniumControl( sDriver, "ProposalCostDetails_PBOMDetail_Proposal", "xpath", "//div[translate(@id,'0123456789','')='pr__MEMPRPLS_PBOMDTL_SUBTASK_HDR_']/ancestor::form[1]/descendant::*[@id='PROP_ID']");
				Function.AssertEqual(true,MEMPRPLS_ProposalCostDetails_PBOMDetail_Proposal.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing VerifyExist on ProposalCostDetails_PBOMDetail_PBOMAssembliesFormTable...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_PBOMDetail_PBOMAssembliesFormTable = new SeleniumControl( sDriver, "ProposalCostDetails_PBOMDetail_PBOMAssembliesFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__MEMPRPLS_PBOMLN_DTL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,MEMPRPLS_ProposalCostDetails_PBOMDetail_PBOMAssembliesFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing ClickButton on ProposalCostDetails_PBOMDetail_PBOMAssembliesForm...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_PBOMDetail_PBOMAssembliesForm = new SeleniumControl( sDriver, "ProposalCostDetails_PBOMDetail_PBOMAssembliesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MEMPRPLS_PBOMLN_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MEMPRPLS_ProposalCostDetails_PBOMDetail_PBOMAssembliesForm);
IWebElement formBttn = MEMPRPLS_ProposalCostDetails_PBOMDetail_PBOMAssembliesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? MEMPRPLS_ProposalCostDetails_PBOMDetail_PBOMAssembliesForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
MEMPRPLS_ProposalCostDetails_PBOMDetail_PBOMAssembliesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing VerifyExists on ProposalCostDetails_PBOMDetail_PBOMAssembliesForm...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_PBOMDetail_PBOMAssembliesForm = new SeleniumControl( sDriver, "ProposalCostDetails_PBOMDetail_PBOMAssembliesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MEMPRPLS_PBOMLN_DTL_']/ancestor::form[1]");
				Function.AssertEqual(true,MEMPRPLS_ProposalCostDetails_PBOMDetail_PBOMAssembliesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing VerifyExists on ProposalCostDetails_PBOMDetail_PBOMAssemblies_Line...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_PBOMDetail_PBOMAssemblies_Line = new SeleniumControl( sDriver, "ProposalCostDetails_PBOMDetail_PBOMAssemblies_Line", "xpath", "//div[translate(@id,'0123456789','')='pr__MEMPRPLS_PBOMLN_DTL_']/ancestor::form[1]/descendant::*[@id='COMP_LN_NO']");
				Function.AssertEqual(true,MEMPRPLS_ProposalCostDetails_PBOMDetail_PBOMAssemblies_Line.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing Close on ProposalCostDetails_PBOMDetailForm...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_PBOMDetailForm = new SeleniumControl( sDriver, "ProposalCostDetails_PBOMDetailForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MEMPRPLS_PBOMDTL_SUBTASK_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MEMPRPLS_ProposalCostDetails_PBOMDetailForm);
IWebElement formBttn = MEMPRPLS_ProposalCostDetails_PBOMDetailForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing VerifyExists on ProposalCostDetails_OtherCostWSLink...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_OtherCostWSLink = new SeleniumControl( sDriver, "ProposalCostDetails_OtherCostWSLink", "ID", "lnk_5489_MEMPRPLS_PROPITEMDTL_DTL");
				Function.AssertEqual(true,MEMPRPLS_ProposalCostDetails_OtherCostWSLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing Click on ProposalCostDetails_OtherCostWSLink...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_OtherCostWSLink = new SeleniumControl( sDriver, "ProposalCostDetails_OtherCostWSLink", "ID", "lnk_5489_MEMPRPLS_PROPITEMDTL_DTL");
				Function.WaitControlDisplayed(MEMPRPLS_ProposalCostDetails_OtherCostWSLink);
MEMPRPLS_ProposalCostDetails_OtherCostWSLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing VerifyExists on ProposalCostDetails_OtherCostWSForm...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_OtherCostWSForm = new SeleniumControl( sDriver, "ProposalCostDetails_OtherCostWSForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_OTHERCST_SUBTASK_HDR_']/ancestor::form[1]");
				Function.AssertEqual(true,MEMPRPLS_ProposalCostDetails_OtherCostWSForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing VerifyExists on ProposalCostDetails_OtherCostWS_Proposal...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_OtherCostWS_Proposal = new SeleniumControl( sDriver, "ProposalCostDetails_OtherCostWS_Proposal", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_OTHERCST_SUBTASK_HDR_']/ancestor::form[1]/descendant::*[@id='PROP_ID']");
				Function.AssertEqual(true,MEMPRPLS_ProposalCostDetails_OtherCostWS_Proposal.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing VerifyExist on ProposalCostDetails_OtherCostWS_OtherCostsWSFormTable...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_OtherCostWS_OtherCostsWSFormTable = new SeleniumControl( sDriver, "ProposalCostDetails_OtherCostWS_OtherCostsWSFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_MEOTHERCST_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,MEMPRPLS_ProposalCostDetails_OtherCostWS_OtherCostsWSFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing ClickButton on ProposalCostDetails_OtherCostWS_OtherCostsWSForm...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_OtherCostWS_OtherCostsWSForm = new SeleniumControl( sDriver, "ProposalCostDetails_OtherCostWS_OtherCostsWSForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_MEOTHERCST_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MEMPRPLS_ProposalCostDetails_OtherCostWS_OtherCostsWSForm);
IWebElement formBttn = MEMPRPLS_ProposalCostDetails_OtherCostWS_OtherCostsWSForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? MEMPRPLS_ProposalCostDetails_OtherCostWS_OtherCostsWSForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
MEMPRPLS_ProposalCostDetails_OtherCostWS_OtherCostsWSForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing VerifyExists on ProposalCostDetails_OtherCostWS_OtherCostsWSForm...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_OtherCostWS_OtherCostsWSForm = new SeleniumControl( sDriver, "ProposalCostDetails_OtherCostWS_OtherCostsWSForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_MEOTHERCST_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,MEMPRPLS_ProposalCostDetails_OtherCostWS_OtherCostsWSForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing VerifyExists on ProposalCostDetails_OtherCostWS_OtherCostsWS_MinimumQuantity...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_OtherCostWS_OtherCostsWS_MinimumQuantity = new SeleniumControl( sDriver, "ProposalCostDetails_OtherCostWS_OtherCostsWS_MinimumQuantity", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_MEOTHERCST_CTW_']/ancestor::form[1]/descendant::*[@id='MIN_QTY']");
				Function.AssertEqual(true,MEMPRPLS_ProposalCostDetails_OtherCostWS_OtherCostsWS_MinimumQuantity.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing Close on ProposalCostDetails_OtherCostWSForm...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_OtherCostWSForm = new SeleniumControl( sDriver, "ProposalCostDetails_OtherCostWSForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_OTHERCST_SUBTASK_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MEMPRPLS_ProposalCostDetails_OtherCostWSForm);
IWebElement formBttn = MEMPRPLS_ProposalCostDetails_OtherCostWSForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing VerifyExists on ProposalCostDetails_AddQuotesLink...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_AddQuotesLink = new SeleniumControl( sDriver, "ProposalCostDetails_AddQuotesLink", "ID", "lnk_5491_MEMPRPLS_PROPITEMDTL_DTL");
				Function.AssertEqual(true,MEMPRPLS_ProposalCostDetails_AddQuotesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing Click on ProposalCostDetails_AddQuotesLink...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_AddQuotesLink = new SeleniumControl( sDriver, "ProposalCostDetails_AddQuotesLink", "ID", "lnk_5491_MEMPRPLS_PROPITEMDTL_DTL");
				Function.WaitControlDisplayed(MEMPRPLS_ProposalCostDetails_AddQuotesLink);
MEMPRPLS_ProposalCostDetails_AddQuotesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing VerifyExists on ProposalCostDetails_AddQuotesForm...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_AddQuotesForm = new SeleniumControl( sDriver, "ProposalCostDetails_AddQuotesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_VENDQT_SUBTASK_HDR_']/ancestor::form[1]");
				Function.AssertEqual(true,MEMPRPLS_ProposalCostDetails_AddQuotesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing VerifyExists on ProposalCostDetails_AddQuotes_Proposal...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_AddQuotes_Proposal = new SeleniumControl( sDriver, "ProposalCostDetails_AddQuotes_Proposal", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_VENDQT_SUBTASK_HDR_']/ancestor::form[1]/descendant::*[@id='PROP_ID']");
				Function.AssertEqual(true,MEMPRPLS_ProposalCostDetails_AddQuotes_Proposal.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing VerifyExist on ProposalCostDetails_AddQuotes_VendorQuotesFormTable...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_AddQuotes_VendorQuotesFormTable = new SeleniumControl( sDriver, "ProposalCostDetails_AddQuotes_VendorQuotesFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_ADDVENDQT_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,MEMPRPLS_ProposalCostDetails_AddQuotes_VendorQuotesFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing ClickButton on ProposalCostDetails_AddQuotes_VendorQuotesForm...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_AddQuotes_VendorQuotesForm = new SeleniumControl( sDriver, "ProposalCostDetails_AddQuotes_VendorQuotesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_ADDVENDQT_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MEMPRPLS_ProposalCostDetails_AddQuotes_VendorQuotesForm);
IWebElement formBttn = MEMPRPLS_ProposalCostDetails_AddQuotes_VendorQuotesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? MEMPRPLS_ProposalCostDetails_AddQuotes_VendorQuotesForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
MEMPRPLS_ProposalCostDetails_AddQuotes_VendorQuotesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing VerifyExists on ProposalCostDetails_AddQuotes_VendorQuotesForm...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_AddQuotes_VendorQuotesForm = new SeleniumControl( sDriver, "ProposalCostDetails_AddQuotes_VendorQuotesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_ADDVENDQT_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,MEMPRPLS_ProposalCostDetails_AddQuotes_VendorQuotesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing VerifyExists on ProposalCostDetails_AddQuotes_VendorQuotes_Vendor...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_AddQuotes_VendorQuotes_Vendor = new SeleniumControl( sDriver, "ProposalCostDetails_AddQuotes_VendorQuotes_Vendor", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_ADDVENDQT_CTW_']/ancestor::form[1]/descendant::*[@id='VEND_ID']");
				Function.AssertEqual(true,MEMPRPLS_ProposalCostDetails_AddQuotes_VendorQuotes_Vendor.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Vendor Quotes Tab");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing Select on ProposalCostDetails_AddQuotes_VendorQuotesTab...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_AddQuotes_VendorQuotesTab = new SeleniumControl( sDriver, "ProposalCostDetails_AddQuotes_VendorQuotesTab", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_ADDVENDQT_CTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(MEMPRPLS_ProposalCostDetails_AddQuotes_VendorQuotesTab);
IWebElement mTab = MEMPRPLS_ProposalCostDetails_AddQuotes_VendorQuotesTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Details").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing VerifyExists on ProposalCostDetails_AddQuotes_VendorQuotes_Details_QuoteType...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_AddQuotes_VendorQuotes_Details_QuoteType = new SeleniumControl( sDriver, "ProposalCostDetails_AddQuotes_VendorQuotes_Details_QuoteType", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_ADDVENDQT_CTW_']/ancestor::form[1]/descendant::*[@id='QT_TYPE_CD']");
				Function.AssertEqual(true,MEMPRPLS_ProposalCostDetails_AddQuotes_VendorQuotes_Details_QuoteType.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing Select on ProposalCostDetails_AddQuotes_VendorQuotesTab...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_AddQuotes_VendorQuotesTab = new SeleniumControl( sDriver, "ProposalCostDetails_AddQuotes_VendorQuotesTab", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_ADDVENDQT_CTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(MEMPRPLS_ProposalCostDetails_AddQuotes_VendorQuotesTab);
IWebElement mTab = MEMPRPLS_ProposalCostDetails_AddQuotes_VendorQuotesTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Alternate Part Numbers").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing VerifyExists on ProposalCostDetails_AddQuotes_VendorQuotes_AlternatePartNumbers_ManufacturerPart_Manufacturer...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_AddQuotes_VendorQuotes_AlternatePartNumbers_ManufacturerPart_Manufacturer = new SeleniumControl( sDriver, "ProposalCostDetails_AddQuotes_VendorQuotes_AlternatePartNumbers_ManufacturerPart_Manufacturer", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_ADDVENDQT_CTW_']/ancestor::form[1]/descendant::*[@id='MANUF_ID']");
				Function.AssertEqual(true,MEMPRPLS_ProposalCostDetails_AddQuotes_VendorQuotes_AlternatePartNumbers_ManufacturerPart_Manufacturer.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing Select on ProposalCostDetails_AddQuotes_VendorQuotesTab...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_AddQuotes_VendorQuotesTab = new SeleniumControl( sDriver, "ProposalCostDetails_AddQuotes_VendorQuotesTab", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_ADDVENDQT_CTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(MEMPRPLS_ProposalCostDetails_AddQuotes_VendorQuotesTab);
IWebElement mTab = MEMPRPLS_ProposalCostDetails_AddQuotes_VendorQuotesTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Quote Line Notes").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing VerifyExists on ProposalCostDetails_AddQuotes_VendorQuotes_QuoteLineNotes_QuoteLineNotes...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_AddQuotes_VendorQuotes_QuoteLineNotes_QuoteLineNotes = new SeleniumControl( sDriver, "ProposalCostDetails_AddQuotes_VendorQuotes_QuoteLineNotes_QuoteLineNotes", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_ADDVENDQT_CTW_']/ancestor::form[1]/descendant::*[@id='QTLNNOTES']");
				Function.AssertEqual(true,MEMPRPLS_ProposalCostDetails_AddQuotes_VendorQuotes_QuoteLineNotes_QuoteLineNotes.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing Close on ProposalCostDetails_AddQuotesForm...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_AddQuotesForm = new SeleniumControl( sDriver, "ProposalCostDetails_AddQuotesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_VENDQT_SUBTASK_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MEMPRPLS_ProposalCostDetails_AddQuotesForm);
IWebElement formBttn = MEMPRPLS_ProposalCostDetails_AddQuotesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing VerifyExists on ProposalCostDetails_RoutingsLink...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_RoutingsLink = new SeleniumControl( sDriver, "ProposalCostDetails_RoutingsLink", "ID", "lnk_5493_MEMPRPLS_PROPITEMDTL_DTL");
				Function.AssertEqual(true,MEMPRPLS_ProposalCostDetails_RoutingsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing Click on ProposalCostDetails_RoutingsLink...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_RoutingsLink = new SeleniumControl( sDriver, "ProposalCostDetails_RoutingsLink", "ID", "lnk_5493_MEMPRPLS_PROPITEMDTL_DTL");
				Function.WaitControlDisplayed(MEMPRPLS_ProposalCostDetails_RoutingsLink);
MEMPRPLS_ProposalCostDetails_RoutingsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing VerifyExists on ProposalCostDetails_RoutingsForm...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_RoutingsForm = new SeleniumControl( sDriver, "ProposalCostDetails_RoutingsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_ROUTING_HDR_']/ancestor::form[1]");
				Function.AssertEqual(true,MEMPRPLS_ProposalCostDetails_RoutingsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing VerifyExists on ProposalCostDetails_Routings_Proposal...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_Routings_Proposal = new SeleniumControl( sDriver, "ProposalCostDetails_Routings_Proposal", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_ROUTING_HDR_']/ancestor::form[1]/descendant::*[@id='PROP_ID']");
				Function.AssertEqual(true,MEMPRPLS_ProposalCostDetails_Routings_Proposal.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing VerifyExist on ProposalCostDetails_Routings_RoutingDetailsFormTable...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_Routings_RoutingDetailsFormTable = new SeleniumControl( sDriver, "ProposalCostDetails_Routings_RoutingDetailsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_ROUTINGLN_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,MEMPRPLS_ProposalCostDetails_Routings_RoutingDetailsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing ClickButton on ProposalCostDetails_Routings_RoutingDetailsForm...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_Routings_RoutingDetailsForm = new SeleniumControl( sDriver, "ProposalCostDetails_Routings_RoutingDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_ROUTINGLN_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MEMPRPLS_ProposalCostDetails_Routings_RoutingDetailsForm);
IWebElement formBttn = MEMPRPLS_ProposalCostDetails_Routings_RoutingDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? MEMPRPLS_ProposalCostDetails_Routings_RoutingDetailsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
MEMPRPLS_ProposalCostDetails_Routings_RoutingDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing VerifyExists on ProposalCostDetails_Routings_RoutingDetailsForm...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_Routings_RoutingDetailsForm = new SeleniumControl( sDriver, "ProposalCostDetails_Routings_RoutingDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_ROUTINGLN_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,MEMPRPLS_ProposalCostDetails_Routings_RoutingDetailsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing VerifyExists on ProposalCostDetails_Routings_RoutingDetails_OperationSequence...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_Routings_RoutingDetails_OperationSequence = new SeleniumControl( sDriver, "ProposalCostDetails_Routings_RoutingDetails_OperationSequence", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_ROUTINGLN_CTW_']/ancestor::form[1]/descendant::*[@id='ROUT_OPER_SEQ_NO']");
				Function.AssertEqual(true,MEMPRPLS_ProposalCostDetails_Routings_RoutingDetails_OperationSequence.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing Close on ProposalCostDetails_RoutingsForm...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_RoutingsForm = new SeleniumControl( sDriver, "ProposalCostDetails_RoutingsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_ROUTING_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MEMPRPLS_ProposalCostDetails_RoutingsForm);
IWebElement formBttn = MEMPRPLS_ProposalCostDetails_RoutingsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing VerifyExists on ProposalCostDetails_SubstitutePartsLink...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_SubstitutePartsLink = new SeleniumControl( sDriver, "ProposalCostDetails_SubstitutePartsLink", "ID", "lnk_5495_MEMPRPLS_PROPITEMDTL_DTL");
				Function.AssertEqual(true,MEMPRPLS_ProposalCostDetails_SubstitutePartsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing Click on ProposalCostDetails_SubstitutePartsLink...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_SubstitutePartsLink = new SeleniumControl( sDriver, "ProposalCostDetails_SubstitutePartsLink", "ID", "lnk_5495_MEMPRPLS_PROPITEMDTL_DTL");
				Function.WaitControlDisplayed(MEMPRPLS_ProposalCostDetails_SubstitutePartsLink);
MEMPRPLS_ProposalCostDetails_SubstitutePartsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing VerifyExists on ProposalCostDetails_SubstitutePartsForm...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_SubstitutePartsForm = new SeleniumControl( sDriver, "ProposalCostDetails_SubstitutePartsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_SUBTPART_SUBTASK_HDR_']/ancestor::form[1]");
				Function.AssertEqual(true,MEMPRPLS_ProposalCostDetails_SubstitutePartsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing VerifyExists on ProposalCostDetails_SubstituteParts_Proposal...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_SubstituteParts_Proposal = new SeleniumControl( sDriver, "ProposalCostDetails_SubstituteParts_Proposal", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_SUBTPART_SUBTASK_HDR_']/ancestor::form[1]/descendant::*[@id='PROP_ID']");
				Function.AssertEqual(true,MEMPRPLS_ProposalCostDetails_SubstituteParts_Proposal.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing VerifyExist on ProposalCostDetails_SubstituteParts_SubstitutePartsFormTable...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_SubstituteParts_SubstitutePartsFormTable = new SeleniumControl( sDriver, "ProposalCostDetails_SubstituteParts_SubstitutePartsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_SUBSTPART_SUBTASK_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,MEMPRPLS_ProposalCostDetails_SubstituteParts_SubstitutePartsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing ClickButton on ProposalCostDetails_SubstituteParts_SubstitutePartsForm...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_SubstituteParts_SubstitutePartsForm = new SeleniumControl( sDriver, "ProposalCostDetails_SubstituteParts_SubstitutePartsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_SUBSTPART_SUBTASK_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MEMPRPLS_ProposalCostDetails_SubstituteParts_SubstitutePartsForm);
IWebElement formBttn = MEMPRPLS_ProposalCostDetails_SubstituteParts_SubstitutePartsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? MEMPRPLS_ProposalCostDetails_SubstituteParts_SubstitutePartsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
MEMPRPLS_ProposalCostDetails_SubstituteParts_SubstitutePartsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing VerifyExists on ProposalCostDetails_SubstituteParts_SubstitutePartsForm...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_SubstituteParts_SubstitutePartsForm = new SeleniumControl( sDriver, "ProposalCostDetails_SubstituteParts_SubstitutePartsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_SUBSTPART_SUBTASK_']/ancestor::form[1]");
				Function.AssertEqual(true,MEMPRPLS_ProposalCostDetails_SubstituteParts_SubstitutePartsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing VerifyExists on ProposalCostDetails_SubstituteParts_SubstituteParts_Sequence...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_SubstituteParts_SubstituteParts_Sequence = new SeleniumControl( sDriver, "ProposalCostDetails_SubstituteParts_SubstituteParts_Sequence", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_SUBSTPART_SUBTASK_']/ancestor::form[1]/descendant::*[@id='USAGE_SEQ_NO']");
				Function.AssertEqual(true,MEMPRPLS_ProposalCostDetails_SubstituteParts_SubstituteParts_Sequence.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing Close on ProposalCostDetails_SubstitutePartsForm...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_SubstitutePartsForm = new SeleniumControl( sDriver, "ProposalCostDetails_SubstitutePartsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMESUB_SUBTPART_SUBTASK_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MEMPRPLS_ProposalCostDetails_SubstitutePartsForm);
IWebElement formBttn = MEMPRPLS_ProposalCostDetails_SubstitutePartsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing VerifyExists on ProposalCostDetails_PartDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_PartDocumentsLink = new SeleniumControl( sDriver, "ProposalCostDetails_PartDocumentsLink", "ID", "lnk_5497_MEMPRPLS_PROPITEMDTL_DTL");
				Function.AssertEqual(true,MEMPRPLS_ProposalCostDetails_PartDocumentsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing Click on ProposalCostDetails_PartDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_PartDocumentsLink = new SeleniumControl( sDriver, "ProposalCostDetails_PartDocumentsLink", "ID", "lnk_5497_MEMPRPLS_PROPITEMDTL_DTL");
				Function.WaitControlDisplayed(MEMPRPLS_ProposalCostDetails_PartDocumentsLink);
MEMPRPLS_ProposalCostDetails_PartDocumentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing VerifyExist on ProposalCostDetails_PartDocumentsFormTable...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_PartDocumentsFormTable = new SeleniumControl( sDriver, "ProposalCostDetails_PartDocumentsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,MEMPRPLS_ProposalCostDetails_PartDocumentsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing ClickButton on ProposalCostDetails_PartDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_PartDocumentsForm = new SeleniumControl( sDriver, "ProposalCostDetails_PartDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MEMPRPLS_ProposalCostDetails_PartDocumentsForm);
IWebElement formBttn = MEMPRPLS_ProposalCostDetails_PartDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? MEMPRPLS_ProposalCostDetails_PartDocumentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
MEMPRPLS_ProposalCostDetails_PartDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing VerifyExists on ProposalCostDetails_PartDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_PartDocumentsForm = new SeleniumControl( sDriver, "ProposalCostDetails_PartDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]");
				Function.AssertEqual(true,MEMPRPLS_ProposalCostDetails_PartDocumentsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing VerifyExists on ProposalCostDetails_PartDocuments_Type...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_PartDocuments_Type = new SeleniumControl( sDriver, "ProposalCostDetails_PartDocuments_Type", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]/descendant::*[@id='DOC_TYPE_CD']");
				Function.AssertEqual(true,MEMPRPLS_ProposalCostDetails_PartDocuments_Type.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing Close on ProposalCostDetails_PartDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_ProposalCostDetails_PartDocumentsForm = new SeleniumControl( sDriver, "ProposalCostDetails_PartDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MEMPRPLS_ProposalCostDetails_PartDocumentsForm);
IWebElement formBttn = MEMPRPLS_ProposalCostDetails_PartDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "MEMPRPLS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPRPLS] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl MEMPRPLS_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(MEMPRPLS_MainForm);
IWebElement formBttn = MEMPRPLS_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

