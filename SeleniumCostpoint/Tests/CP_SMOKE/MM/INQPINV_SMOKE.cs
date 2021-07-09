 
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
    public class INQPINV_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Inventory Reports/Inquiries", "xpath","//div[@class='navItem'][.='Inventory Reports/Inquiries']").Click();
new SeleniumControl(sDriver,"View Part Inventory", "xpath","//div[@class='navItem'][.='View Part Inventory']").Click();


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
				Function.CurrentComponent = "INQPINV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INQPINV] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl INQPINV_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,INQPINV_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INQPINV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INQPINV] Performing VerifyExists on Part...", Logger.MessageType.INF);
				SeleniumControl INQPINV_Part = new SeleniumControl( sDriver, "Part", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='ITEM_ID']");
				Function.AssertEqual(true,INQPINV_Part.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INQPINV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INQPINV] Performing Set on Part...", Logger.MessageType.INF);
				SeleniumControl INQPINV_Part = new SeleniumControl( sDriver, "Part", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='ITEM_ID']");
				INQPINV_Part.Click();
INQPINV_Part.SendKeys("#3", true);
Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));
INQPINV_Part.SendKeys(OpenQA.Selenium.Keys.Shift + OpenQA.Selenium.Keys.Tab);


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
				this.ScriptLogger.WriteLine("PART INVENTORY FORM");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("PART DOCUMENTS");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INQPINV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INQPINV] Performing VerifyExists on PartInventory_PartDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl INQPINV_PartInventory_PartDocumentsLink = new SeleniumControl( sDriver, "PartInventory_PartDocumentsLink", "ID", "lnk_1006735_INQPINV_PART_CTW");
				Function.AssertEqual(true,INQPINV_PartInventory_PartDocumentsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INQPINV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INQPINV] Performing Click on PartInventory_PartDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl INQPINV_PartInventory_PartDocumentsLink = new SeleniumControl( sDriver, "PartInventory_PartDocumentsLink", "ID", "lnk_1006735_INQPINV_PART_CTW");
				Function.WaitControlDisplayed(INQPINV_PartInventory_PartDocumentsLink);
INQPINV_PartInventory_PartDocumentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INQPINV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INQPINV] Performing VerifyExist on PartInventory_PartDocumentsFormTable...", Logger.MessageType.INF);
				SeleniumControl INQPINV_PartInventory_PartDocumentsFormTable = new SeleniumControl( sDriver, "PartInventory_PartDocumentsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,INQPINV_PartInventory_PartDocumentsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INQPINV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INQPINV] Performing ClickButton on PartInventory_PartDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl INQPINV_PartInventory_PartDocumentsForm = new SeleniumControl( sDriver, "PartInventory_PartDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(INQPINV_PartInventory_PartDocumentsForm);
IWebElement formBttn = INQPINV_PartInventory_PartDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? INQPINV_PartInventory_PartDocumentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
INQPINV_PartInventory_PartDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INQPINV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INQPINV] Performing VerifyExists on PartInventory_PartDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl INQPINV_PartInventory_PartDocumentsForm = new SeleniumControl( sDriver, "PartInventory_PartDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]");
				Function.AssertEqual(true,INQPINV_PartInventory_PartDocumentsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INQPINV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INQPINV] Performing VerifyExists on PartInventory_PartDocuments_Type...", Logger.MessageType.INF);
				SeleniumControl INQPINV_PartInventory_PartDocuments_Type = new SeleniumControl( sDriver, "PartInventory_PartDocuments_Type", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]/descendant::*[@id='DOC_TYPE_CD']");
				Function.AssertEqual(true,INQPINV_PartInventory_PartDocuments_Type.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INQPINV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INQPINV] Performing Close on PartInventory_PartDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl INQPINV_PartInventory_PartDocumentsForm = new SeleniumControl( sDriver, "PartInventory_PartDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(INQPINV_PartInventory_PartDocumentsForm);
IWebElement formBttn = INQPINV_PartInventory_PartDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("MOS");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INQPINV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INQPINV] Performing Set on Part...", Logger.MessageType.INF);
				SeleniumControl INQPINV_Part = new SeleniumControl( sDriver, "Part", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='ITEM_ID']");
				INQPINV_Part.Click();
INQPINV_Part.SendKeys("GM30", true);
Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));
INQPINV_Part.SendKeys(OpenQA.Selenium.Keys.Shift + OpenQA.Selenium.Keys.Tab);


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
IWebElement tlbrBtn = CP7Main_MainToolBar.mElement.FindElements(By.XPath(".//*[@class='tbBtnContainer']//div[contains(@title,'Execute (F3)')]")).FirstOrDefault();
if (tlbrBtn==null) throw new Exception("Unable to find button Execute (F3).");
tlbrBtn.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickToolbarButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INQPINV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INQPINV] Performing ClickButton on PartInventoryForm...", Logger.MessageType.INF);
				SeleniumControl INQPINV_PartInventoryForm = new SeleniumControl( sDriver, "PartInventoryForm", "xpath", "//div[translate(@id,'0123456789','')='pr__INQPINV_PART_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(INQPINV_PartInventoryForm);
IWebElement formBttn = INQPINV_PartInventoryForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? INQPINV_PartInventoryForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
INQPINV_PartInventoryForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INQPINV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INQPINV] Performing ClickButton on PartInventoryForm...", Logger.MessageType.INF);
				SeleniumControl INQPINV_PartInventoryForm = new SeleniumControl( sDriver, "PartInventoryForm", "xpath", "//div[translate(@id,'0123456789','')='pr__INQPINV_PART_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(INQPINV_PartInventoryForm);
IWebElement formBttn = INQPINV_PartInventoryForm.mElement.FindElements(By.CssSelector("*[title*='Next']")).Count <= 0 ? INQPINV_PartInventoryForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Next')]")).FirstOrDefault() :
INQPINV_PartInventoryForm.mElement.FindElements(By.CssSelector("*[title*='Next']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Next not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INQPINV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INQPINV] Performing ClickButton on PartInventoryForm...", Logger.MessageType.INF);
				SeleniumControl INQPINV_PartInventoryForm = new SeleniumControl( sDriver, "PartInventoryForm", "xpath", "//div[translate(@id,'0123456789','')='pr__INQPINV_PART_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(INQPINV_PartInventoryForm);
IWebElement formBttn = INQPINV_PartInventoryForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).Count <= 0 ? INQPINV_PartInventoryForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Query')]")).FirstOrDefault() :
INQPINV_PartInventoryForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).FirstOrDefault();
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
				Function.CurrentComponent = "INQPINV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INQPINV] Performing VerifyExists on PartInventory_MOsLink...", Logger.MessageType.INF);
				SeleniumControl INQPINV_PartInventory_MOsLink = new SeleniumControl( sDriver, "PartInventory_MOsLink", "ID", "lnk_1006731_INQPINV_PART_CTW");
				Function.AssertEqual(true,INQPINV_PartInventory_MOsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INQPINV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INQPINV] Performing Click on PartInventory_MOsLink...", Logger.MessageType.INF);
				SeleniumControl INQPINV_PartInventory_MOsLink = new SeleniumControl( sDriver, "PartInventory_MOsLink", "ID", "lnk_1006731_INQPINV_PART_CTW");
				Function.WaitControlDisplayed(INQPINV_PartInventory_MOsLink);
INQPINV_PartInventory_MOsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INQPINV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INQPINV] Performing VerifyExist on PartInventory_MOsFormTable...", Logger.MessageType.INF);
				SeleniumControl INQPINV_PartInventory_MOsFormTable = new SeleniumControl( sDriver, "PartInventory_MOsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__INQPINV_MOHDR_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,INQPINV_PartInventory_MOsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INQPINV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INQPINV] Performing ClickButton on PartInventory_MOsForm...", Logger.MessageType.INF);
				SeleniumControl INQPINV_PartInventory_MOsForm = new SeleniumControl( sDriver, "PartInventory_MOsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__INQPINV_MOHDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(INQPINV_PartInventory_MOsForm);
IWebElement formBttn = INQPINV_PartInventory_MOsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? INQPINV_PartInventory_MOsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
INQPINV_PartInventory_MOsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INQPINV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INQPINV] Performing VerifyExists on PartInventory_MOsForm...", Logger.MessageType.INF);
				SeleniumControl INQPINV_PartInventory_MOsForm = new SeleniumControl( sDriver, "PartInventory_MOsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__INQPINV_MOHDR_']/ancestor::form[1]");
				Function.AssertEqual(true,INQPINV_PartInventory_MOsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INQPINV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INQPINV] Performing VerifyExists on PartInventory_MOs_ManufacturingOrder...", Logger.MessageType.INF);
				SeleniumControl INQPINV_PartInventory_MOs_ManufacturingOrder = new SeleniumControl( sDriver, "PartInventory_MOs_ManufacturingOrder", "xpath", "//div[translate(@id,'0123456789','')='pr__INQPINV_MOHDR_']/ancestor::form[1]/descendant::*[@id='MO_ID']");
				Function.AssertEqual(true,INQPINV_PartInventory_MOs_ManufacturingOrder.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INQPINV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INQPINV] Performing Select on PartInventory_MOsTab...", Logger.MessageType.INF);
				SeleniumControl INQPINV_PartInventory_MOsTab = new SeleniumControl( sDriver, "PartInventory_MOsTab", "xpath", "//div[translate(@id,'0123456789','')='pr__INQPINV_MOHDR_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(INQPINV_PartInventory_MOsTab);
IWebElement mTab = INQPINV_PartInventory_MOsTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Details").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INQPINV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INQPINV] Performing VerifyExists on PartInventory_MOs_Details_PartEffectivity_Configuration...", Logger.MessageType.INF);
				SeleniumControl INQPINV_PartInventory_MOs_Details_PartEffectivity_Configuration = new SeleniumControl( sDriver, "PartInventory_MOs_Details_PartEffectivity_Configuration", "xpath", "//div[translate(@id,'0123456789','')='pr__INQPINV_MOHDR_']/ancestor::form[1]/descendant::*[@id='BOM_CONFIG_ID']");
				Function.AssertEqual(true,INQPINV_PartInventory_MOs_Details_PartEffectivity_Configuration.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INQPINV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INQPINV] Performing Select on PartInventory_MOsTab...", Logger.MessageType.INF);
				SeleniumControl INQPINV_PartInventory_MOsTab = new SeleniumControl( sDriver, "PartInventory_MOsTab", "xpath", "//div[translate(@id,'0123456789','')='pr__INQPINV_MOHDR_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(INQPINV_PartInventory_MOsTab);
IWebElement mTab = INQPINV_PartInventory_MOsTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Additional Info").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INQPINV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INQPINV] Performing VerifyExists on PartInventory_MOs_AdditionalInfo_Organization...", Logger.MessageType.INF);
				SeleniumControl INQPINV_PartInventory_MOs_AdditionalInfo_Organization = new SeleniumControl( sDriver, "PartInventory_MOs_AdditionalInfo_Organization", "xpath", "//div[translate(@id,'0123456789','')='pr__INQPINV_MOHDR_']/ancestor::form[1]/descendant::*[@id='ORG_ID']");
				Function.AssertEqual(true,INQPINV_PartInventory_MOs_AdditionalInfo_Organization.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INQPINV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INQPINV] Performing Select on PartInventory_MOsTab...", Logger.MessageType.INF);
				SeleniumControl INQPINV_PartInventory_MOsTab = new SeleniumControl( sDriver, "PartInventory_MOsTab", "xpath", "//div[translate(@id,'0123456789','')='pr__INQPINV_MOHDR_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(INQPINV_PartInventory_MOsTab);
IWebElement mTab = INQPINV_PartInventory_MOsTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Notes").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INQPINV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INQPINV] Performing VerifyExists on PartInventory_MOs_Notes_MOHeaderNotes...", Logger.MessageType.INF);
				SeleniumControl INQPINV_PartInventory_MOs_Notes_MOHeaderNotes = new SeleniumControl( sDriver, "PartInventory_MOs_Notes_MOHeaderNotes", "xpath", "//div[translate(@id,'0123456789','')='pr__INQPINV_MOHDR_']/ancestor::form[1]/descendant::*[@id='MO_NOTES']");
				Function.AssertEqual(true,INQPINV_PartInventory_MOs_Notes_MOHeaderNotes.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INQPINV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INQPINV] Performing Close on PartInventory_MOsForm...", Logger.MessageType.INF);
				SeleniumControl INQPINV_PartInventory_MOsForm = new SeleniumControl( sDriver, "PartInventory_MOsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__INQPINV_MOHDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(INQPINV_PartInventory_MOsForm);
IWebElement formBttn = INQPINV_PartInventory_MOsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("QUERY ECNS");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INQPINV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INQPINV] Performing Set on Part...", Logger.MessageType.INF);
				SeleniumControl INQPINV_Part = new SeleniumControl( sDriver, "Part", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='ITEM_ID']");
				INQPINV_Part.Click();
INQPINV_Part.SendKeys("#3", true);
Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));
INQPINV_Part.SendKeys(OpenQA.Selenium.Keys.Shift + OpenQA.Selenium.Keys.Tab);


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
				this.ScriptLogger.WriteLine("ECNs");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INQPINV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INQPINV] Performing VerifyExists on PartInventory_ECNsLink...", Logger.MessageType.INF);
				SeleniumControl INQPINV_PartInventory_ECNsLink = new SeleniumControl( sDriver, "PartInventory_ECNsLink", "ID", "lnk_1006742_INQPINV_PART_CTW");
				Function.AssertEqual(true,INQPINV_PartInventory_ECNsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INQPINV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INQPINV] Performing Click on PartInventory_ECNsLink...", Logger.MessageType.INF);
				SeleniumControl INQPINV_PartInventory_ECNsLink = new SeleniumControl( sDriver, "PartInventory_ECNsLink", "ID", "lnk_1006742_INQPINV_PART_CTW");
				Function.WaitControlDisplayed(INQPINV_PartInventory_ECNsLink);
INQPINV_PartInventory_ECNsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INQPINV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INQPINV] Performing VerifyExist on PartInventory_ECNsFormTable...", Logger.MessageType.INF);
				SeleniumControl INQPINV_PartInventory_ECNsFormTable = new SeleniumControl( sDriver, "PartInventory_ECNsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__MRGMRSUB_ECNPART_ECN_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,INQPINV_PartInventory_ECNsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INQPINV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INQPINV] Performing ClickButton on PartInventory_ECNsForm...", Logger.MessageType.INF);
				SeleniumControl INQPINV_PartInventory_ECNsForm = new SeleniumControl( sDriver, "PartInventory_ECNsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MRGMRSUB_ECNPART_ECN_']/ancestor::form[1]");
				Function.WaitControlDisplayed(INQPINV_PartInventory_ECNsForm);
IWebElement formBttn = INQPINV_PartInventory_ECNsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? INQPINV_PartInventory_ECNsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
INQPINV_PartInventory_ECNsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INQPINV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INQPINV] Performing VerifyExists on PartInventory_ECNsForm...", Logger.MessageType.INF);
				SeleniumControl INQPINV_PartInventory_ECNsForm = new SeleniumControl( sDriver, "PartInventory_ECNsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MRGMRSUB_ECNPART_ECN_']/ancestor::form[1]");
				Function.AssertEqual(true,INQPINV_PartInventory_ECNsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INQPINV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INQPINV] Performing VerifyExists on PartInventory_ECNs_ECN...", Logger.MessageType.INF);
				SeleniumControl INQPINV_PartInventory_ECNs_ECN = new SeleniumControl( sDriver, "PartInventory_ECNs_ECN", "xpath", "//div[translate(@id,'0123456789','')='pr__MRGMRSUB_ECNPART_ECN_']/ancestor::form[1]/descendant::*[@id='ECN_ID']");
				Function.AssertEqual(true,INQPINV_PartInventory_ECNs_ECN.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INQPINV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INQPINV] Performing Select on PartInventory_ECNsTab...", Logger.MessageType.INF);
				SeleniumControl INQPINV_PartInventory_ECNsTab = new SeleniumControl( sDriver, "PartInventory_ECNsTab", "xpath", "//div[translate(@id,'0123456789','')='pr__MRGMRSUB_ECNPART_ECN_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(INQPINV_PartInventory_ECNsTab);
IWebElement mTab = INQPINV_PartInventory_ECNsTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "ECN Details").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INQPINV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INQPINV] Performing VerifyExists on PartInventory_ECNs_ECNDetails_Type...", Logger.MessageType.INF);
				SeleniumControl INQPINV_PartInventory_ECNs_ECNDetails_Type = new SeleniumControl( sDriver, "PartInventory_ECNs_ECNDetails_Type", "xpath", "//div[translate(@id,'0123456789','')='pr__MRGMRSUB_ECNPART_ECN_']/ancestor::form[1]/descendant::*[@id='EC_TYPE_CD']");
				Function.AssertEqual(true,INQPINV_PartInventory_ECNs_ECNDetails_Type.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INQPINV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INQPINV] Performing Select on PartInventory_ECNsTab...", Logger.MessageType.INF);
				SeleniumControl INQPINV_PartInventory_ECNsTab = new SeleniumControl( sDriver, "PartInventory_ECNsTab", "xpath", "//div[translate(@id,'0123456789','')='pr__MRGMRSUB_ECNPART_ECN_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(INQPINV_PartInventory_ECNsTab);
IWebElement mTab = INQPINV_PartInventory_ECNsTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Part Information").FirstOrDefault();
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
				this.ScriptLogger.WriteLine("CLOSE APP");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEQSTAT] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl OEQSTAT_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(OEQSTAT_MainForm);
IWebElement formBttn = OEQSTAT_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

