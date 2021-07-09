 
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
    public class RCMMSRC_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Receiving", "xpath","//div[@class='deptItem'][.='Receiving']").Click();
new SeleniumControl(sDriver,"Receiving", "xpath","//div[@class='navItem'][.='Receiving']").Click();
new SeleniumControl(sDriver,"Enter Miscellaneous Inventory Receipts", "xpath","//div[@class='navItem'][.='Enter Miscellaneous Inventory Receipts']").Click();


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
				Function.CurrentComponent = "RCMMSRC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMMSRC] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl RCMMSRC_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,RCMMSRC_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMMSRC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMMSRC] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl RCMMSRC_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(RCMMSRC_MainForm);
IWebElement formBttn = RCMMSRC_MainForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).Count <= 0 ? RCMMSRC_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Query')]")).FirstOrDefault() :
RCMMSRC_MainForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).FirstOrDefault();
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
Function.AssertEqual("Receive Miscellaneous Inventory", new SeleniumControl(sDriver,"QueryTitle", "ID", "qryHeaderLabel").GetValue().Trim());


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyTitle]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "Query";
								SeleniumControl ctl = new SeleniumControl(sDriver,"Target", "xpath_display", "//*[@id='basicQTbl']/tbody/tr/td/span[text()='Miscellaneous Receipt ID']");
Function.WaitControlDisplayed(ctl);
SeleniumControl RelationshipField = new SeleniumControl(sDriver,"Relationship", ctl.mElement.FindElement(By.XPath("../following-sibling::td[1]")));
SeleniumControl SearchField = new SeleniumControl(sDriver,"Relationship", ctl.mElement.FindElement(By.XPath("../following-sibling::td[2]")));
new SeleniumControl(sDriver, "RelDropdown", RelationshipField.mElement.FindElements(By.XPath("./descendant::*[@class='tCCBImg']")).FirstOrDefault()).Click();
new SeleniumControl(sDriver, "RelItem", "xpath", ".//descendant::div[text() = 'is equal to']").Click();
if (SearchField.mElement.GetAttribute("class").Equals("tCCB")) {
new SeleniumControl(sDriver, "SearchDropdown", SearchField.mElement.FindElements(By.XPath(".//descendant::*[@class='tCCBImg']")).FirstOrDefault()).Click();
new SeleniumControl(sDriver, "SearchItem", "xpath_display", ".//descendant::div[text()='MR-00002']").Click();
} else { 
new SeleniumControl(sDriver, "SearchDropdown", SearchField.mElement.FindElements(By.XPath(".//descendant::*[@class='queryBasicFld']")).FirstOrDefault()).SendKeys("MR-00002");}


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
				Function.CurrentComponent = "RCMMSRC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMMSRC] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl RCMMSRC_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(RCMMSRC_MainForm);
IWebElement formBttn = RCMMSRC_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? RCMMSRC_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
RCMMSRC_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMMSRC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMMSRC] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl RCMMSRC_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,RCMMSRC_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMMSRC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMMSRC] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl RCMMSRC_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(RCMMSRC_MainForm);
IWebElement formBttn = RCMMSRC_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? RCMMSRC_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
RCMMSRC_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMMSRC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMMSRC] Performing VerifyExists on Warehouse...", Logger.MessageType.INF);
				SeleniumControl RCMMSRC_Warehouse = new SeleniumControl( sDriver, "Warehouse", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='WHSE_ID']");
				Function.AssertEqual(true,RCMMSRC_Warehouse.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
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
				Function.CurrentComponent = "RCMMSRC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMMSRC] Performing VerifyExists on ChildForm...", Logger.MessageType.INF);
				SeleniumControl RCMMSRC_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__RCMMSRC_INVTTRNLN_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,RCMMSRC_ChildForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMMSRC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMMSRC] Performing VerifyExist on ChildFormTable...", Logger.MessageType.INF);
				SeleniumControl RCMMSRC_ChildFormTable = new SeleniumControl( sDriver, "ChildFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__RCMMSRC_INVTTRNLN_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,RCMMSRC_ChildFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMMSRC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMMSRC] Performing ClickButton on ChildForm...", Logger.MessageType.INF);
				SeleniumControl RCMMSRC_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__RCMMSRC_INVTTRNLN_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(RCMMSRC_ChildForm);
IWebElement formBttn = RCMMSRC_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? RCMMSRC_ChildForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
RCMMSRC_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMMSRC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMMSRC] Performing VerifyExists on ChildForm_Line...", Logger.MessageType.INF);
				SeleniumControl RCMMSRC_ChildForm_Line = new SeleniumControl( sDriver, "ChildForm_Line", "xpath", "//div[translate(@id,'0123456789','')='pr__RCMMSRC_INVTTRNLN_CTW_']/ancestor::form[1]/descendant::*[@id='INVT_TRN_LN_NO']");
				Function.AssertEqual(true,RCMMSRC_ChildForm_Line.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMMSRC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMMSRC] Performing Select on ChildFormTab...", Logger.MessageType.INF);
				SeleniumControl RCMMSRC_ChildFormTab = new SeleniumControl( sDriver, "ChildFormTab", "xpath", "//div[translate(@id,'0123456789','')='pr__RCMMSRC_INVTTRNLN_CTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(RCMMSRC_ChildFormTab);
IWebElement mTab = RCMMSRC_ChildFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Line Details").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMMSRC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMMSRC] Performing VerifyExists on ChildForm_LineDetails_Receipt_InvAbbrev...", Logger.MessageType.INF);
				SeleniumControl RCMMSRC_ChildForm_LineDetails_Receipt_InvAbbrev = new SeleniumControl( sDriver, "ChildForm_LineDetails_Receipt_InvAbbrev", "xpath", "//div[translate(@id,'0123456789','')='pr__RCMMSRC_INVTTRNLN_CTW_']/ancestor::form[1]/descendant::*[@id='INVT_ABBRV_CD']");
				Function.AssertEqual(true,RCMMSRC_ChildForm_LineDetails_Receipt_InvAbbrev.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMMSRC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMMSRC] Performing Select on ChildFormTab...", Logger.MessageType.INF);
				SeleniumControl RCMMSRC_ChildFormTab = new SeleniumControl( sDriver, "ChildFormTab", "xpath", "//div[translate(@id,'0123456789','')='pr__RCMMSRC_INVTTRNLN_CTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(RCMMSRC_ChildFormTab);
IWebElement mTab = RCMMSRC_ChildFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Cost Elements").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMMSRC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMMSRC] Performing VerifyExists on ChildForm_CostElements_DirectCostElements_Material...", Logger.MessageType.INF);
				SeleniumControl RCMMSRC_ChildForm_CostElements_DirectCostElements_Material = new SeleniumControl( sDriver, "ChildForm_CostElements_DirectCostElements_Material", "xpath", "//div[translate(@id,'0123456789','')='pr__RCMMSRC_INVTTRNLN_CTW_']/ancestor::form[1]/descendant::*[@id='MATL_CST_AMT']");
				Function.AssertEqual(true,RCMMSRC_ChildForm_CostElements_DirectCostElements_Material.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMMSRC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMMSRC] Performing Select on ChildFormTab...", Logger.MessageType.INF);
				SeleniumControl RCMMSRC_ChildFormTab = new SeleniumControl( sDriver, "ChildFormTab", "xpath", "//div[translate(@id,'0123456789','')='pr__RCMMSRC_INVTTRNLN_CTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(RCMMSRC_ChildFormTab);
IWebElement mTab = RCMMSRC_ChildFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Other Info").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMMSRC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMMSRC] Performing VerifyExists on ChildForm_OtherInfo_Costs_UnitCost...", Logger.MessageType.INF);
				SeleniumControl RCMMSRC_ChildForm_OtherInfo_Costs_UnitCost = new SeleniumControl( sDriver, "ChildForm_OtherInfo_Costs_UnitCost", "xpath", "//div[translate(@id,'0123456789','')='pr__RCMMSRC_INVTTRNLN_CTW_']/ancestor::form[1]/descendant::*[@id='UNIT_CST_AMT']");
				Function.AssertEqual(true,RCMMSRC_ChildForm_OtherInfo_Costs_UnitCost.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("ChildForm_SerialLotInfoForm");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMMSRC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMMSRC] Performing Click on ChildForm_SerialLotInfoLink...", Logger.MessageType.INF);
				SeleniumControl RCMMSRC_ChildForm_SerialLotInfoLink = new SeleniumControl( sDriver, "ChildForm_SerialLotInfoLink", "ID", "lnk_1007575_RCMMSRC_INVTTRNLN_CTW");
				Function.WaitControlDisplayed(RCMMSRC_ChildForm_SerialLotInfoLink);
RCMMSRC_ChildForm_SerialLotInfoLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMMSRC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMMSRC] Performing VerifyExists on ChildForm_SerialLotInfoForm...", Logger.MessageType.INF);
				SeleniumControl RCMMSRC_ChildForm_SerialLotInfoForm = new SeleniumControl( sDriver, "ChildForm_SerialLotInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSRLT_']/ancestor::form[1]");
				Function.AssertEqual(true,RCMMSRC_ChildForm_SerialLotInfoForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMMSRC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMMSRC] Performing VerifyExist on ChildForm_SerialLotInfoFormTable...", Logger.MessageType.INF);
				SeleniumControl RCMMSRC_ChildForm_SerialLotInfoFormTable = new SeleniumControl( sDriver, "ChildForm_SerialLotInfoFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSRLT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,RCMMSRC_ChildForm_SerialLotInfoFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMMSRC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMMSRC] Performing ClickButton on ChildForm_SerialLotInfoForm...", Logger.MessageType.INF);
				SeleniumControl RCMMSRC_ChildForm_SerialLotInfoForm = new SeleniumControl( sDriver, "ChildForm_SerialLotInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSRLT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(RCMMSRC_ChildForm_SerialLotInfoForm);
IWebElement formBttn = RCMMSRC_ChildForm_SerialLotInfoForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? RCMMSRC_ChildForm_SerialLotInfoForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
RCMMSRC_ChildForm_SerialLotInfoForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMMSRC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMMSRC] Performing VerifyExists on ChildForm_SerialLotInfo_SerialNumber...", Logger.MessageType.INF);
				SeleniumControl RCMMSRC_ChildForm_SerialLotInfo_SerialNumber = new SeleniumControl( sDriver, "ChildForm_SerialLotInfo_SerialNumber", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSRLT_']/ancestor::form[1]/descendant::*[@id='SERIAL_ID']");
				Function.AssertEqual(true,RCMMSRC_ChildForm_SerialLotInfo_SerialNumber.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMMSRC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMMSRC] Performing Select on ChildForm_SerialLotInfoTab...", Logger.MessageType.INF);
				SeleniumControl RCMMSRC_ChildForm_SerialLotInfoTab = new SeleniumControl( sDriver, "ChildForm_SerialLotInfoTab", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSRLT_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(RCMMSRC_ChildForm_SerialLotInfoTab);
IWebElement mTab = RCMMSRC_ChildForm_SerialLotInfoTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Basic Information").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMMSRC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMMSRC] Performing VerifyExists on ChildForm_SerialLotInfo_BasicInformation_Quantity...", Logger.MessageType.INF);
				SeleniumControl RCMMSRC_ChildForm_SerialLotInfo_BasicInformation_Quantity = new SeleniumControl( sDriver, "ChildForm_SerialLotInfo_BasicInformation_Quantity", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSRLT_']/ancestor::form[1]/descendant::*[@id='TRN_QTY']");
				Function.AssertEqual(true,RCMMSRC_ChildForm_SerialLotInfo_BasicInformation_Quantity.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMMSRC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMMSRC] Performing Select on ChildForm_SerialLotInfoTab...", Logger.MessageType.INF);
				SeleniumControl RCMMSRC_ChildForm_SerialLotInfoTab = new SeleniumControl( sDriver, "ChildForm_SerialLotInfoTab", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSRLT_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(RCMMSRC_ChildForm_SerialLotInfoTab);
IWebElement mTab = RCMMSRC_ChildForm_SerialLotInfoTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Manufacturer/Vendor Information").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMMSRC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMMSRC] Performing VerifyExists on ChildForm_SerialLotInfo_ManufacturerVendorInformation_Manufacturer_Manufacturer...", Logger.MessageType.INF);
				SeleniumControl RCMMSRC_ChildForm_SerialLotInfo_ManufacturerVendorInformation_Manufacturer_Manufacturer = new SeleniumControl( sDriver, "ChildForm_SerialLotInfo_ManufacturerVendorInformation_Manufacturer_Manufacturer", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSRLT_']/ancestor::form[1]/descendant::*[@id='MANUF_ID']");
				Function.AssertEqual(true,RCMMSRC_ChildForm_SerialLotInfo_ManufacturerVendorInformation_Manufacturer_Manufacturer.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMMSRC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMMSRC] Performing Select on ChildForm_SerialLotInfoTab...", Logger.MessageType.INF);
				SeleniumControl RCMMSRC_ChildForm_SerialLotInfoTab = new SeleniumControl( sDriver, "ChildForm_SerialLotInfoTab", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSRLT_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(RCMMSRC_ChildForm_SerialLotInfoTab);
IWebElement mTab = RCMMSRC_ChildForm_SerialLotInfoTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Sales Order/Warranty Information").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMMSRC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMMSRC] Performing VerifyExists on ChildForm_SerialLotInfo_SalesOrderWarrantyInformation_SalesOrderInformation_SalesOrder...", Logger.MessageType.INF);
				SeleniumControl RCMMSRC_ChildForm_SerialLotInfo_SalesOrderWarrantyInformation_SalesOrderInformation_SalesOrder = new SeleniumControl( sDriver, "ChildForm_SerialLotInfo_SalesOrderWarrantyInformation_SalesOrderInformation_SalesOrder", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSRLT_']/ancestor::form[1]/descendant::*[@id='MAINT_SO_ID']");
				Function.AssertEqual(true,RCMMSRC_ChildForm_SerialLotInfo_SalesOrderWarrantyInformation_SalesOrderInformation_SalesOrder.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMMSRC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMMSRC] Performing Select on ChildForm_SerialLotInfoTab...", Logger.MessageType.INF);
				SeleniumControl RCMMSRC_ChildForm_SerialLotInfoTab = new SeleniumControl( sDriver, "ChildForm_SerialLotInfoTab", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSRLT_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(RCMMSRC_ChildForm_SerialLotInfoTab);
IWebElement mTab = RCMMSRC_ChildForm_SerialLotInfoTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "User-Defined Info").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMMSRC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMMSRC] Performing Select on ChildForm_SerialLotInfoTab...", Logger.MessageType.INF);
				SeleniumControl RCMMSRC_ChildForm_SerialLotInfoTab = new SeleniumControl( sDriver, "ChildForm_SerialLotInfoTab", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSRLT_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(RCMMSRC_ChildForm_SerialLotInfoTab);
IWebElement mTab = RCMMSRC_ChildForm_SerialLotInfoTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Notes").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMMSRC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMMSRC] Performing VerifyExists on ChildForm_SerialLotInfo_Notes_Notes...", Logger.MessageType.INF);
				SeleniumControl RCMMSRC_ChildForm_SerialLotInfo_Notes_Notes = new SeleniumControl( sDriver, "ChildForm_SerialLotInfo_Notes_Notes", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSRLT_']/ancestor::form[1]/descendant::*[@id='NOTES_NT']");
				Function.AssertEqual(true,RCMMSRC_ChildForm_SerialLotInfo_Notes_Notes.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMMSRC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMMSRC] Performing Select on ChildForm_SerialLotInfoTab...", Logger.MessageType.INF);
				SeleniumControl RCMMSRC_ChildForm_SerialLotInfoTab = new SeleniumControl( sDriver, "ChildForm_SerialLotInfoTab", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSRLT_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(RCMMSRC_ChildForm_SerialLotInfoTab);
IWebElement mTab = RCMMSRC_ChildForm_SerialLotInfoTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Shelf Life").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMMSRC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMMSRC] Performing VerifyExists on ChildForm_SerialLotInfo_ShelfLife_ShelfLife_ShelfLifeType...", Logger.MessageType.INF);
				SeleniumControl RCMMSRC_ChildForm_SerialLotInfo_ShelfLife_ShelfLife_ShelfLifeType = new SeleniumControl( sDriver, "ChildForm_SerialLotInfo_ShelfLife_ShelfLife_ShelfLifeType", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSRLT_']/ancestor::form[1]/descendant::*[@id='S_SHELF_LIFE_TYPE']");
				Function.AssertEqual(true,RCMMSRC_ChildForm_SerialLotInfo_ShelfLife_ShelfLife_ShelfLifeType.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMMSRC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMMSRC] Performing Close on ChildForm_SerialLotInfoForm...", Logger.MessageType.INF);
				SeleniumControl RCMMSRC_ChildForm_SerialLotInfoForm = new SeleniumControl( sDriver, "ChildForm_SerialLotInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSRLT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(RCMMSRC_ChildForm_SerialLotInfoForm);
IWebElement formBttn = RCMMSRC_ChildForm_SerialLotInfoForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("ChildForm_BackOrdersForm");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMMSRC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMMSRC] Performing Click on ChildForm_BackOrdersLink...", Logger.MessageType.INF);
				SeleniumControl RCMMSRC_ChildForm_BackOrdersLink = new SeleniumControl( sDriver, "ChildForm_BackOrdersLink", "ID", "lnk_1007553_RCMMSRC_INVTTRNLN_CTW");
				Function.WaitControlDisplayed(RCMMSRC_ChildForm_BackOrdersLink);
RCMMSRC_ChildForm_BackOrdersLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMMSRC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMMSRC] Performing VerifyExists on ChildForm_BackOrdersForm...", Logger.MessageType.INF);
				SeleniumControl RCMMSRC_ChildForm_BackOrdersForm = new SeleniumControl( sDriver, "ChildForm_BackOrdersForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGBKORD_RESLN_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,RCMMSRC_ChildForm_BackOrdersForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMMSRC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMMSRC] Performing VerifyExist on ChildForm_BackOrdersFormTable...", Logger.MessageType.INF);
				SeleniumControl RCMMSRC_ChildForm_BackOrdersFormTable = new SeleniumControl( sDriver, "ChildForm_BackOrdersFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGBKORD_RESLN_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,RCMMSRC_ChildForm_BackOrdersFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMMSRC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMMSRC] Performing ClickButton on ChildForm_BackOrdersForm...", Logger.MessageType.INF);
				SeleniumControl RCMMSRC_ChildForm_BackOrdersForm = new SeleniumControl( sDriver, "ChildForm_BackOrdersForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGBKORD_RESLN_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(RCMMSRC_ChildForm_BackOrdersForm);
IWebElement formBttn = RCMMSRC_ChildForm_BackOrdersForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? RCMMSRC_ChildForm_BackOrdersForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
RCMMSRC_ChildForm_BackOrdersForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMMSRC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMMSRC] Performing VerifyExists on ChildForm_BackOrders_NeedDate...", Logger.MessageType.INF);
				SeleniumControl RCMMSRC_ChildForm_BackOrders_NeedDate = new SeleniumControl( sDriver, "ChildForm_BackOrders_NeedDate", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGBKORD_RESLN_CTW_']/ancestor::form[1]/descendant::*[@id='NEED_DT']");
				Function.AssertEqual(true,RCMMSRC_ChildForm_BackOrders_NeedDate.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMMSRC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMMSRC] Performing Close on ChildForm_BackOrdersForm...", Logger.MessageType.INF);
				SeleniumControl RCMMSRC_ChildForm_BackOrdersForm = new SeleniumControl( sDriver, "ChildForm_BackOrdersForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGBKORD_RESLN_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(RCMMSRC_ChildForm_BackOrdersForm);
IWebElement formBttn = RCMMSRC_ChildForm_BackOrdersForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "RCMMSRC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMMSRC] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl RCMMSRC_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(RCMMSRC_MainForm);
IWebElement formBttn = RCMMSRC_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

