 
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
    public class INMSCADJ_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Inventory", "xpath","//div[@class='deptItem'][.='Inventory']").Click();
new SeleniumControl(sDriver,"Adjustments", "xpath","//div[@class='navItem'][.='Adjustments']").Click();
new SeleniumControl(sDriver,"Enter Scrap Adjustments", "xpath","//div[@class='navItem'][.='Enter Scrap Adjustments']").Click();


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
				Function.CurrentComponent = "INMSCADJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMSCADJ] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl INMSCADJ_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,INMSCADJ_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMSCADJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMSCADJ] Performing VerifyExists on MainForm_Identification_ScrapAdjustmentID...", Logger.MessageType.INF);
				SeleniumControl INMSCADJ_MainForm_Identification_ScrapAdjustmentID = new SeleniumControl( sDriver, "MainForm_Identification_ScrapAdjustmentID", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='INVT_TRN_ID_LNK']");
				Function.AssertEqual(true,INMSCADJ_MainForm_Identification_ScrapAdjustmentID.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMSCADJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMSCADJ] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl INMSCADJ_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(INMSCADJ_MainForm);
IWebElement formBttn = INMSCADJ_MainForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).Count <= 0 ? INMSCADJ_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Query')]")).FirstOrDefault() :
INMSCADJ_MainForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Query not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
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
				Function.CurrentComponent = "INMSCADJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMSCADJ] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl INMSCADJ_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,INMSCADJ_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
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
				Function.CurrentComponent = "INMSCADJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMSCADJ] Performing Click on MainForm_AccountingPeriodLink...", Logger.MessageType.INF);
				SeleniumControl INMSCADJ_MainForm_AccountingPeriodLink = new SeleniumControl( sDriver, "MainForm_AccountingPeriodLink", "ID", "lnk_1007971_INMSCADJ_INVTTRN_HDR");
				Function.WaitControlDisplayed(INMSCADJ_MainForm_AccountingPeriodLink);
INMSCADJ_MainForm_AccountingPeriodLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMSCADJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMSCADJ] Performing VerifyExists on AccountingPeriodForm...", Logger.MessageType.INF);
				SeleniumControl INMSCADJ_AccountingPeriodForm = new SeleniumControl( sDriver, "AccountingPeriodForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMACCPD_HDR_']/ancestor::form[1]");
				Function.AssertEqual(true,INMSCADJ_AccountingPeriodForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMSCADJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMSCADJ] Performing VerifyExists on AccountingPeriod_FiscalYear...", Logger.MessageType.INF);
				SeleniumControl INMSCADJ_AccountingPeriod_FiscalYear = new SeleniumControl( sDriver, "AccountingPeriod_FiscalYear", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMACCPD_HDR_']/ancestor::form[1]/descendant::*[@id='DFS_FYCD_ST']");
				Function.AssertEqual(true,INMSCADJ_AccountingPeriod_FiscalYear.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMSCADJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMSCADJ] Performing ClickButton on AccountingPeriodForm...", Logger.MessageType.INF);
				SeleniumControl INMSCADJ_AccountingPeriodForm = new SeleniumControl( sDriver, "AccountingPeriodForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMACCPD_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(INMSCADJ_AccountingPeriodForm);
IWebElement formBttn = INMSCADJ_AccountingPeriodForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? INMSCADJ_AccountingPeriodForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
INMSCADJ_AccountingPeriodForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMSCADJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMSCADJ] Performing VerifyExist on AccountingPeriodFormTable...", Logger.MessageType.INF);
				SeleniumControl INMSCADJ_AccountingPeriodFormTable = new SeleniumControl( sDriver, "AccountingPeriodFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMACCPD_HDR_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,INMSCADJ_AccountingPeriodFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMSCADJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMSCADJ] Performing Close on AccountingPeriodForm...", Logger.MessageType.INF);
				SeleniumControl INMSCADJ_AccountingPeriodForm = new SeleniumControl( sDriver, "AccountingPeriodForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMACCPD_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(INMSCADJ_AccountingPeriodForm);
IWebElement formBttn = INMSCADJ_AccountingPeriodForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("ChildForm");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMSCADJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMSCADJ] Performing VerifyExists on ChildForm...", Logger.MessageType.INF);
				SeleniumControl INMSCADJ_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__INMSCADJ_INVTTRNLN_CHILD_']/ancestor::form[1]");
				Function.AssertEqual(true,INMSCADJ_ChildForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMSCADJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMSCADJ] Performing VerifyExist on ChildFormTable...", Logger.MessageType.INF);
				SeleniumControl INMSCADJ_ChildFormTable = new SeleniumControl( sDriver, "ChildFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__INMSCADJ_INVTTRNLN_CHILD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,INMSCADJ_ChildFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMSCADJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMSCADJ] Performing ClickButton on ChildForm...", Logger.MessageType.INF);
				SeleniumControl INMSCADJ_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__INMSCADJ_INVTTRNLN_CHILD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(INMSCADJ_ChildForm);
IWebElement formBttn = INMSCADJ_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? INMSCADJ_ChildForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
INMSCADJ_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMSCADJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMSCADJ] Performing VerifyExists on ChildForm_Line...", Logger.MessageType.INF);
				SeleniumControl INMSCADJ_ChildForm_Line = new SeleniumControl( sDriver, "ChildForm_Line", "xpath", "//div[translate(@id,'0123456789','')='pr__INMSCADJ_INVTTRNLN_CHILD_']/ancestor::form[1]/descendant::*[@id='INVT_TRN_LN_NO']");
				Function.AssertEqual(true,INMSCADJ_ChildForm_Line.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMSCADJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMSCADJ] Performing VerifyExists on ChildForm_LineDetails_Adjustment_FromLocation...", Logger.MessageType.INF);
				SeleniumControl INMSCADJ_ChildForm_LineDetails_Adjustment_FromLocation = new SeleniumControl( sDriver, "ChildForm_LineDetails_Adjustment_FromLocation", "xpath", "//div[translate(@id,'0123456789','')='pr__INMSCADJ_INVTTRNLN_CHILD_']/ancestor::form[1]/descendant::*[@id='INVT_LOC_ID_FR']");
				Function.AssertEqual(true,INMSCADJ_ChildForm_LineDetails_Adjustment_FromLocation.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMSCADJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMSCADJ] Performing Select on ChildForm_Tab...", Logger.MessageType.INF);
				SeleniumControl INMSCADJ_ChildForm_Tab = new SeleniumControl( sDriver, "ChildForm_Tab", "xpath", "//div[translate(@id,'0123456789','')='pr__INMSCADJ_INVTTRNLN_CHILD_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(INMSCADJ_ChildForm_Tab);
IWebElement mTab = INMSCADJ_ChildForm_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Cost Elements").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMSCADJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMSCADJ] Performing VerifyExists on ChildForm_CostElements_DirectCostElements_Material...", Logger.MessageType.INF);
				SeleniumControl INMSCADJ_ChildForm_CostElements_DirectCostElements_Material = new SeleniumControl( sDriver, "ChildForm_CostElements_DirectCostElements_Material", "xpath", "//div[translate(@id,'0123456789','')='pr__INMSCADJ_INVTTRNLN_CHILD_']/ancestor::form[1]/descendant::*[@id='MATL_CST_AMT']");
				Function.AssertEqual(true,INMSCADJ_ChildForm_CostElements_DirectCostElements_Material.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMSCADJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMSCADJ] Performing Select on ChildForm_Tab...", Logger.MessageType.INF);
				SeleniumControl INMSCADJ_ChildForm_Tab = new SeleniumControl( sDriver, "ChildForm_Tab", "xpath", "//div[translate(@id,'0123456789','')='pr__INMSCADJ_INVTTRNLN_CHILD_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(INMSCADJ_ChildForm_Tab);
IWebElement mTab = INMSCADJ_ChildForm_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Other Info").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMSCADJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMSCADJ] Performing VerifyExists on ChildForm_OtherInfo_Costs_UnitCost...", Logger.MessageType.INF);
				SeleniumControl INMSCADJ_ChildForm_OtherInfo_Costs_UnitCost = new SeleniumControl( sDriver, "ChildForm_OtherInfo_Costs_UnitCost", "xpath", "//div[translate(@id,'0123456789','')='pr__INMSCADJ_INVTTRNLN_CHILD_']/ancestor::form[1]/descendant::*[@id='UNIT_CST_AMT']");
				Function.AssertEqual(true,INMSCADJ_ChildForm_OtherInfo_Costs_UnitCost.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Serial Lot Info");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMSCADJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMSCADJ] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl INMSCADJ_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(INMSCADJ_MainForm);
IWebElement formBttn = INMSCADJ_MainForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).Count <= 0 ? INMSCADJ_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Query')]")).FirstOrDefault() :
INMSCADJ_MainForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Query not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "Query";
								SeleniumControl ctl = new SeleniumControl(sDriver,"Target", "xpath_display", "//*[@id='basicQTbl']/tbody/tr/td/span[text()='Warehouse']");
Function.WaitControlDisplayed(ctl);
SeleniumControl RelationshipField = new SeleniumControl(sDriver,"Relationship", ctl.mElement.FindElement(By.XPath("../following-sibling::td[1]")));
SeleniumControl SearchField = new SeleniumControl(sDriver,"Relationship", ctl.mElement.FindElement(By.XPath("../following-sibling::td[2]")));
new SeleniumControl(sDriver, "RelDropdown", RelationshipField.mElement.FindElements(By.XPath("./descendant::*[@class='tCCBImg']")).FirstOrDefault()).Click();
new SeleniumControl(sDriver, "RelItem", "xpath_display", ".//descendant::div[text() = 'begins with']").Click();
if (SearchField.mElement.GetAttribute("class").Equals("tCCB")) {
new SeleniumControl(sDriver, "SearchDropdown", SearchField.mElement.FindElements(By.XPath(".//descendant::*[@class='tCCBImg']")).FirstOrDefault()).Click();
new SeleniumControl(sDriver, "SearchItem", "xpath_display", ".//descendant::div[text()='WHSE1']").Click();
} else { 
new SeleniumControl(sDriver, "SearchDropdown", SearchField.mElement.FindElements(By.XPath(".//descendant::*[@class='queryBasicFld']")).FirstOrDefault()).SendKeys("WHSE1");}


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SetSearchCriterion]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "Query";
								SeleniumControl ctl = new SeleniumControl(sDriver,"Target", "xpath_display", "//*[@id='basicQTbl']/tbody/tr/td/span[text()='Scrap Adjustment ID']");
Function.WaitControlDisplayed(ctl);
SeleniumControl RelationshipField = new SeleniumControl(sDriver,"Relationship", ctl.mElement.FindElement(By.XPath("../following-sibling::td[1]")));
SeleniumControl SearchField = new SeleniumControl(sDriver,"Relationship", ctl.mElement.FindElement(By.XPath("../following-sibling::td[2]")));
new SeleniumControl(sDriver, "RelDropdown", RelationshipField.mElement.FindElements(By.XPath("./descendant::*[@class='tCCBImg']")).FirstOrDefault()).Click();
new SeleniumControl(sDriver, "RelItem", "xpath_display", ".//descendant::div[text() = 'begins with']").Click();
if (SearchField.mElement.GetAttribute("class").Equals("tCCB")) {
new SeleniumControl(sDriver, "SearchDropdown", SearchField.mElement.FindElements(By.XPath(".//descendant::*[@class='tCCBImg']")).FirstOrDefault()).Click();
new SeleniumControl(sDriver, "SearchItem", "xpath_display", ".//descendant::div[text()='SAD-100006']").Click();
} else { 
new SeleniumControl(sDriver, "SearchDropdown", SearchField.mElement.FindElements(By.XPath(".//descendant::*[@class='queryBasicFld']")).FirstOrDefault()).SendKeys("SAD-100006");}


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
				Function.CurrentComponent = "INMSCADJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMSCADJ] Performing Click on ChildForm_SerialLotInfoLink...", Logger.MessageType.INF);
				SeleniumControl INMSCADJ_ChildForm_SerialLotInfoLink = new SeleniumControl( sDriver, "ChildForm_SerialLotInfoLink", "ID", "lnk_1007962_INMSCADJ_INVTTRNLN_CHILD");
				Function.WaitControlDisplayed(INMSCADJ_ChildForm_SerialLotInfoLink);
INMSCADJ_ChildForm_SerialLotInfoLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMSCADJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMSCADJ] Performing VerifyExist on SerialLotInfoFormTable...", Logger.MessageType.INF);
				SeleniumControl INMSCADJ_SerialLotInfoFormTable = new SeleniumControl( sDriver, "SerialLotInfoFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSRLT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,INMSCADJ_SerialLotInfoFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMSCADJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMSCADJ] Performing ClickButton on SerialLotInfoForm...", Logger.MessageType.INF);
				SeleniumControl INMSCADJ_SerialLotInfoForm = new SeleniumControl( sDriver, "SerialLotInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSRLT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(INMSCADJ_SerialLotInfoForm);
IWebElement formBttn = INMSCADJ_SerialLotInfoForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? INMSCADJ_SerialLotInfoForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
INMSCADJ_SerialLotInfoForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMSCADJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMSCADJ] Performing VerifyExists on SerialLotInfo_BasicInformation_Origin_Order...", Logger.MessageType.INF);
				SeleniumControl INMSCADJ_SerialLotInfo_BasicInformation_Origin_Order = new SeleniumControl( sDriver, "SerialLotInfo_BasicInformation_Origin_Order", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSRLT_']/ancestor::form[1]/descendant::*[@id='ORIG_ORD_ID']");
				Function.AssertEqual(true,INMSCADJ_SerialLotInfo_BasicInformation_Origin_Order.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMSCADJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMSCADJ] Performing Select on SerialLotInfo_tab1...", Logger.MessageType.INF);
				SeleniumControl INMSCADJ_SerialLotInfo_tab1 = new SeleniumControl( sDriver, "SerialLotInfo_tab1", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSRLT_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(INMSCADJ_SerialLotInfo_tab1);
IWebElement mTab = INMSCADJ_SerialLotInfo_tab1.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Manufacturer/Vendor Information").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMSCADJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMSCADJ] Performing VerifyExists on SerialLotInfo_ManufacturerVendorInformation_Vendor_VendorPart...", Logger.MessageType.INF);
				SeleniumControl INMSCADJ_SerialLotInfo_ManufacturerVendorInformation_Vendor_VendorPart = new SeleniumControl( sDriver, "SerialLotInfo_ManufacturerVendorInformation_Vendor_VendorPart", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSRLT_']/ancestor::form[1]/descendant::*[@id='VEND_PART_ID']");
				Function.AssertEqual(true,INMSCADJ_SerialLotInfo_ManufacturerVendorInformation_Vendor_VendorPart.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMSCADJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMSCADJ] Performing Select on SerialLotInfo_tab1...", Logger.MessageType.INF);
				SeleniumControl INMSCADJ_SerialLotInfo_tab1 = new SeleniumControl( sDriver, "SerialLotInfo_tab1", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSRLT_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(INMSCADJ_SerialLotInfo_tab1);
IWebElement mTab = INMSCADJ_SerialLotInfo_tab1.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Sales Order/Warranty Information").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMSCADJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMSCADJ] Performing VerifyExists on SerialLotInfo_SalesOrderWarrantyInformation_Maintenance_VendorWarranty...", Logger.MessageType.INF);
				SeleniumControl INMSCADJ_SerialLotInfo_SalesOrderWarrantyInformation_Maintenance_VendorWarranty = new SeleniumControl( sDriver, "SerialLotInfo_SalesOrderWarrantyInformation_Maintenance_VendorWarranty", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSRLT_']/ancestor::form[1]/descendant::*[@id='VEND_WARR_CD']");
				Function.AssertEqual(true,INMSCADJ_SerialLotInfo_SalesOrderWarrantyInformation_Maintenance_VendorWarranty.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMSCADJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMSCADJ] Performing Select on SerialLotInfo_tab1...", Logger.MessageType.INF);
				SeleniumControl INMSCADJ_SerialLotInfo_tab1 = new SeleniumControl( sDriver, "SerialLotInfo_tab1", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSRLT_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(INMSCADJ_SerialLotInfo_tab1);
IWebElement mTab = INMSCADJ_SerialLotInfo_tab1.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "User-Defined Info").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMSCADJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMSCADJ] Performing Select on SerialLotInfo_tab1...", Logger.MessageType.INF);
				SeleniumControl INMSCADJ_SerialLotInfo_tab1 = new SeleniumControl( sDriver, "SerialLotInfo_tab1", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSRLT_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(INMSCADJ_SerialLotInfo_tab1);
IWebElement mTab = INMSCADJ_SerialLotInfo_tab1.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Notes").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMSCADJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMSCADJ] Performing VerifyExists on SerialLotInfo_Notes_NotesTextarea...", Logger.MessageType.INF);
				SeleniumControl INMSCADJ_SerialLotInfo_Notes_NotesTextarea = new SeleniumControl( sDriver, "SerialLotInfo_Notes_NotesTextarea", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSRLT_']/ancestor::form[1]/descendant::*[@id='NOTES_NT']");
				Function.AssertEqual(true,INMSCADJ_SerialLotInfo_Notes_NotesTextarea.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMSCADJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMSCADJ] Performing Select on SerialLotInfo_tab1...", Logger.MessageType.INF);
				SeleniumControl INMSCADJ_SerialLotInfo_tab1 = new SeleniumControl( sDriver, "SerialLotInfo_tab1", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSRLT_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(INMSCADJ_SerialLotInfo_tab1);
IWebElement mTab = INMSCADJ_SerialLotInfo_tab1.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Shelf Life").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMSCADJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMSCADJ] Performing VerifyExists on ChildForm_SerialLotInfo_ShelfLife_ShelfLife_ShelfLifeType...", Logger.MessageType.INF);
				SeleniumControl INMSCADJ_ChildForm_SerialLotInfo_ShelfLife_ShelfLife_ShelfLifeType = new SeleniumControl( sDriver, "ChildForm_SerialLotInfo_ShelfLife_ShelfLife_ShelfLifeType", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSRLT_']/ancestor::form[1]/descendant::*[@id='S_SHELF_LIFE_TYPE']");
				Function.AssertEqual(true,INMSCADJ_ChildForm_SerialLotInfo_ShelfLife_ShelfLife_ShelfLifeType.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMSCADJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMSCADJ] Performing Close on SerialLotInfoForm...", Logger.MessageType.INF);
				SeleniumControl INMSCADJ_SerialLotInfoForm = new SeleniumControl( sDriver, "SerialLotInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSRLT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(INMSCADJ_SerialLotInfoForm);
IWebElement formBttn = INMSCADJ_SerialLotInfoForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "INMSCADJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMSCADJ] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl INMSCADJ_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(INMSCADJ_MainForm);
IWebElement formBttn = INMSCADJ_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

