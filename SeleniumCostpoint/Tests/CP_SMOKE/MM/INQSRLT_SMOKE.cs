 
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
    public class INQSRLT_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"View Serial/Lot Information", "xpath","//div[@class='navItem'][.='View Serial/Lot Information']").Click();


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
				Function.CurrentComponent = "INQSRLT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INQSRLT] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl INQSRLT_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,INQSRLT_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INQSRLT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INQSRLT] Performing VerifyExists on Part...", Logger.MessageType.INF);
				SeleniumControl INQSRLT_Part = new SeleniumControl( sDriver, "Part", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PART_ID']");
				Function.AssertEqual(true,INQSRLT_Part.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INQSRLT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INQSRLT] Performing Set on ManufacturerVendorInformation_SerialNumber...", Logger.MessageType.INF);
				SeleniumControl INQSRLT_ManufacturerVendorInformation_SerialNumber = new SeleniumControl( sDriver, "ManufacturerVendorInformation_SerialNumber", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='MAN_VEND_SERIAL_ID']");
				INQSRLT_ManufacturerVendorInformation_SerialNumber.Click();
INQSRLT_ManufacturerVendorInformation_SerialNumber.SendKeys("TOMS 90999", true);
Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));
INQSRLT_ManufacturerVendorInformation_SerialNumber.SendKeys(OpenQA.Selenium.Keys.Shift + OpenQA.Selenium.Keys.Tab);


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
								try
				{
				this.ScriptLogger.WriteLine("SERIAL/LOT INFORMATION");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INQSRLT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INQSRLT] Performing VerifyExist on SerialLotInformationFormFormTable...", Logger.MessageType.INF);
				SeleniumControl INQSRLT_SerialLotInformationFormFormTable = new SeleniumControl( sDriver, "SerialLotInformationFormFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__INM_SERIALLOT_SRLT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,INQSRLT_SerialLotInformationFormFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INQSRLT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INQSRLT] Performing ClickButton on SerialLotInformationForm...", Logger.MessageType.INF);
				SeleniumControl INQSRLT_SerialLotInformationForm = new SeleniumControl( sDriver, "SerialLotInformationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__INM_SERIALLOT_SRLT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(INQSRLT_SerialLotInformationForm);
IWebElement formBttn = INQSRLT_SerialLotInformationForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).Count <= 0 ? INQSRLT_SerialLotInformationForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Query')]")).FirstOrDefault() :
INQSRLT_SerialLotInformationForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Query not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "Query";
								new SeleniumControl(sDriver, "ConditionName", "id", "fieldList").Click();
new SeleniumControl(sDriver, "ConditionItem", "xpath_display", ".//descendant::div[text() = 'Lot Number'][@class='tCCV']").Click();
new SeleniumControl(sDriver, "Relationship", "id", "relationList").Click();
new SeleniumControl(sDriver, "RelationItem", "xpath_display", ".//descendant::div[text() = 'is not blank']").Click();
new SeleniumControl(sDriver, "AddButton", "id", "AddBtn").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [AddQueryCondition]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "Query";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[Query] Performing Click on Query...", Logger.MessageType.INF);
				SeleniumControl Query_Query = new SeleniumControl( sDriver, "Query", "ID", "submitQ");
				Function.WaitControlDisplayed(Query_Query);
                Query_Query.Click();

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INQSRLT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INQSRLT] Performing ClickButton on SerialLotInformationForm...", Logger.MessageType.INF);
				SeleniumControl INQSRLT_SerialLotInformationForm = new SeleniumControl( sDriver, "SerialLotInformationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__INM_SERIALLOT_SRLT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(INQSRLT_SerialLotInformationForm);
IWebElement formBttn = INQSRLT_SerialLotInformationForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? INQSRLT_SerialLotInformationForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
INQSRLT_SerialLotInformationForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INQSRLT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INQSRLT] Performing VerifyExists on SerialLotInformationForm...", Logger.MessageType.INF);
				SeleniumControl INQSRLT_SerialLotInformationForm = new SeleniumControl( sDriver, "SerialLotInformationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__INM_SERIALLOT_SRLT_']/ancestor::form[1]");
				Function.AssertEqual(true,INQSRLT_SerialLotInformationForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INQSRLT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INQSRLT] Performing VerifyExists on SerialLotInformation_SerialNumber...", Logger.MessageType.INF);
				SeleniumControl INQSRLT_SerialLotInformation_SerialNumber = new SeleniumControl( sDriver, "SerialLotInformation_SerialNumber", "xpath", "//div[translate(@id,'0123456789','')='pr__INM_SERIALLOT_SRLT_']/ancestor::form[1]/descendant::*[@id='SERIAL_ID']");
				Function.AssertEqual(true,INQSRLT_SerialLotInformation_SerialNumber.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INQSRLT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INQSRLT] Performing Select on SerialLotInformation_SerialLotInformationTab...", Logger.MessageType.INF);
				SeleniumControl INQSRLT_SerialLotInformation_SerialLotInformationTab = new SeleniumControl( sDriver, "SerialLotInformation_SerialLotInformationTab", "xpath", "//div[translate(@id,'0123456789','')='pr__INM_SERIALLOT_SRLT_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(INQSRLT_SerialLotInformation_SerialLotInformationTab);
IWebElement mTab = INQSRLT_SerialLotInformation_SerialLotInformationTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Serial/Lot Details").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INQSRLT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INQSRLT] Performing VerifyExists on SerialLotInformation_SerialLotDetails_OriginalQuantity...", Logger.MessageType.INF);
				SeleniumControl INQSRLT_SerialLotInformation_SerialLotDetails_OriginalQuantity = new SeleniumControl( sDriver, "SerialLotInformation_SerialLotDetails_OriginalQuantity", "xpath", "//div[translate(@id,'0123456789','')='pr__INM_SERIALLOT_SRLT_']/ancestor::form[1]/descendant::*[@id='TOTAL_QTY']");
				Function.AssertEqual(true,INQSRLT_SerialLotInformation_SerialLotDetails_OriginalQuantity.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INQSRLT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INQSRLT] Performing Select on SerialLotInformation_SerialLotInformationTab...", Logger.MessageType.INF);
				SeleniumControl INQSRLT_SerialLotInformation_SerialLotInformationTab = new SeleniumControl( sDriver, "SerialLotInformation_SerialLotInformationTab", "xpath", "//div[translate(@id,'0123456789','')='pr__INM_SERIALLOT_SRLT_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(INQSRLT_SerialLotInformation_SerialLotInformationTab);
IWebElement mTab = INQSRLT_SerialLotInformation_SerialLotInformationTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Manufacturer/Vendor Information").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INQSRLT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INQSRLT] Performing VerifyExists on SerialLotInformation_ManufacturerVendorInformation_ManufacturerVendorLotNumber...", Logger.MessageType.INF);
				SeleniumControl INQSRLT_SerialLotInformation_ManufacturerVendorInformation_ManufacturerVendorLotNumber = new SeleniumControl( sDriver, "SerialLotInformation_ManufacturerVendorInformation_ManufacturerVendorLotNumber", "xpath", "//div[translate(@id,'0123456789','')='pr__INM_SERIALLOT_SRLT_']/ancestor::form[1]/descendant::*[@id='MAN_VEND_LOT_ID']");
				Function.AssertEqual(true,INQSRLT_SerialLotInformation_ManufacturerVendorInformation_ManufacturerVendorLotNumber.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INQSRLT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INQSRLT] Performing Select on SerialLotInformation_SerialLotInformationTab...", Logger.MessageType.INF);
				SeleniumControl INQSRLT_SerialLotInformation_SerialLotInformationTab = new SeleniumControl( sDriver, "SerialLotInformation_SerialLotInformationTab", "xpath", "//div[translate(@id,'0123456789','')='pr__INM_SERIALLOT_SRLT_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(INQSRLT_SerialLotInformation_SerialLotInformationTab);
IWebElement mTab = INQSRLT_SerialLotInformation_SerialLotInformationTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Maintenance/Warranty Information").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INQSRLT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INQSRLT] Performing VerifyExists on SerialLotInformation_MaintenanceWarrantyInformation_Maintenance_SalesOrder...", Logger.MessageType.INF);
				SeleniumControl INQSRLT_SerialLotInformation_MaintenanceWarrantyInformation_Maintenance_SalesOrder = new SeleniumControl( sDriver, "SerialLotInformation_MaintenanceWarrantyInformation_Maintenance_SalesOrder", "xpath", "//div[translate(@id,'0123456789','')='pr__INM_SERIALLOT_SRLT_']/ancestor::form[1]/descendant::*[@id='MAINT_SO_ID']");
				Function.AssertEqual(true,INQSRLT_SerialLotInformation_MaintenanceWarrantyInformation_Maintenance_SalesOrder.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INQSRLT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INQSRLT] Performing Select on SerialLotInformation_SerialLotInformationTab...", Logger.MessageType.INF);
				SeleniumControl INQSRLT_SerialLotInformation_SerialLotInformationTab = new SeleniumControl( sDriver, "SerialLotInformation_SerialLotInformationTab", "xpath", "//div[translate(@id,'0123456789','')='pr__INM_SERIALLOT_SRLT_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(INQSRLT_SerialLotInformation_SerialLotInformationTab);
IWebElement mTab = INQSRLT_SerialLotInformation_SerialLotInformationTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Notes").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INQSRLT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INQSRLT] Performing VerifyExists on SerialLotInformation_Notes_Notes...", Logger.MessageType.INF);
				SeleniumControl INQSRLT_SerialLotInformation_Notes_Notes = new SeleniumControl( sDriver, "SerialLotInformation_Notes_Notes", "xpath", "//div[translate(@id,'0123456789','')='pr__INM_SERIALLOT_SRLT_']/ancestor::form[1]/descendant::*[@id='NOTES_NT']");
				Function.AssertEqual(true,INQSRLT_SerialLotInformation_Notes_Notes.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INQSRLT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INQSRLT] Performing Select on SerialLotInformation_SerialLotInformationTab...", Logger.MessageType.INF);
				SeleniumControl INQSRLT_SerialLotInformation_SerialLotInformationTab = new SeleniumControl( sDriver, "SerialLotInformation_SerialLotInformationTab", "xpath", "//div[translate(@id,'0123456789','')='pr__INM_SERIALLOT_SRLT_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(INQSRLT_SerialLotInformation_SerialLotInformationTab);
IWebElement mTab = INQSRLT_SerialLotInformation_SerialLotInformationTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "User Defined Information").FirstOrDefault();
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
				this.ScriptLogger.WriteLine("INVENTORY LOCATIONS LINK");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INQSRLT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INQSRLT] Performing VerifyExists on SerialLotInformation_InventoryLocationsLink...", Logger.MessageType.INF);
				SeleniumControl INQSRLT_SerialLotInformation_InventoryLocationsLink = new SeleniumControl( sDriver, "SerialLotInformation_InventoryLocationsLink", "ID", "lnk_1007566_INM_SERIALLOT_SRLT");
				Function.AssertEqual(true,INQSRLT_SerialLotInformation_InventoryLocationsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INQSRLT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INQSRLT] Performing Click on SerialLotInformation_InventoryLocationsLink...", Logger.MessageType.INF);
				SeleniumControl INQSRLT_SerialLotInformation_InventoryLocationsLink = new SeleniumControl( sDriver, "SerialLotInformation_InventoryLocationsLink", "ID", "lnk_1007566_INM_SERIALLOT_SRLT");
				Function.WaitControlDisplayed(INQSRLT_SerialLotInformation_InventoryLocationsLink);
INQSRLT_SerialLotInformation_InventoryLocationsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INQSRLT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INQSRLT] Performing VerifyExist on SerialLotInformation_InventoryLocationsFormTable...", Logger.MessageType.INF);
				SeleniumControl INQSRLT_SerialLotInformation_InventoryLocationsFormTable = new SeleniumControl( sDriver, "SerialLotInformation_InventoryLocationsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__INQSRLT_INVTWHSLOCSRLT_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,INQSRLT_SerialLotInformation_InventoryLocationsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INQSRLT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INQSRLT] Performing ClickButton on SerialLotInformation_InventoryLocationsForm...", Logger.MessageType.INF);
				SeleniumControl INQSRLT_SerialLotInformation_InventoryLocationsForm = new SeleniumControl( sDriver, "SerialLotInformation_InventoryLocationsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__INQSRLT_INVTWHSLOCSRLT_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(INQSRLT_SerialLotInformation_InventoryLocationsForm);
IWebElement formBttn = INQSRLT_SerialLotInformation_InventoryLocationsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? INQSRLT_SerialLotInformation_InventoryLocationsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
INQSRLT_SerialLotInformation_InventoryLocationsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INQSRLT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INQSRLT] Performing VerifyExists on SerialLotInformation_InventoryLocationsForm...", Logger.MessageType.INF);
				SeleniumControl INQSRLT_SerialLotInformation_InventoryLocationsForm = new SeleniumControl( sDriver, "SerialLotInformation_InventoryLocationsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__INQSRLT_INVTWHSLOCSRLT_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,INQSRLT_SerialLotInformation_InventoryLocationsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INQSRLT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INQSRLT] Performing VerifyExists on SerialLotInformation_InventoryLocations_Warehouse...", Logger.MessageType.INF);
				SeleniumControl INQSRLT_SerialLotInformation_InventoryLocations_Warehouse = new SeleniumControl( sDriver, "SerialLotInformation_InventoryLocations_Warehouse", "xpath", "//div[translate(@id,'0123456789','')='pr__INQSRLT_INVTWHSLOCSRLT_CTW_']/ancestor::form[1]/descendant::*[@id='WHSE_ID']");
				Function.AssertEqual(true,INQSRLT_SerialLotInformation_InventoryLocations_Warehouse.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INQSRLT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INQSRLT] Performing Close on SerialLotInformation_InventoryLocationsForm...", Logger.MessageType.INF);
				SeleniumControl INQSRLT_SerialLotInformation_InventoryLocationsForm = new SeleniumControl( sDriver, "SerialLotInformation_InventoryLocationsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__INQSRLT_INVTWHSLOCSRLT_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(INQSRLT_SerialLotInformation_InventoryLocationsForm);
IWebElement formBttn = INQSRLT_SerialLotInformation_InventoryLocationsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("TRANSACTION HISTORY LINK");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INQSRLT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INQSRLT] Performing VerifyExists on SerialLotInformation_TransactionHistoryLink...", Logger.MessageType.INF);
				SeleniumControl INQSRLT_SerialLotInformation_TransactionHistoryLink = new SeleniumControl( sDriver, "SerialLotInformation_TransactionHistoryLink", "ID", "lnk_1007567_INM_SERIALLOT_SRLT");
				Function.AssertEqual(true,INQSRLT_SerialLotInformation_TransactionHistoryLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INQSRLT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INQSRLT] Performing Click on SerialLotInformation_TransactionHistoryLink...", Logger.MessageType.INF);
				SeleniumControl INQSRLT_SerialLotInformation_TransactionHistoryLink = new SeleniumControl( sDriver, "SerialLotInformation_TransactionHistoryLink", "ID", "lnk_1007567_INM_SERIALLOT_SRLT");
				Function.WaitControlDisplayed(INQSRLT_SerialLotInformation_TransactionHistoryLink);
INQSRLT_SerialLotInformation_TransactionHistoryLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INQSRLT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INQSRLT] Performing VerifyExist on SerialLotInformation_TransactionHistoryFormTable...", Logger.MessageType.INF);
				SeleniumControl INQSRLT_SerialLotInformation_TransactionHistoryFormTable = new SeleniumControl( sDriver, "SerialLotInformation_TransactionHistoryFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__INQSRLT_INVTTRNLNSRLT_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,INQSRLT_SerialLotInformation_TransactionHistoryFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INQSRLT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INQSRLT] Performing ClickButton on SerialLotInformation_TransactionHistoryForm...", Logger.MessageType.INF);
				SeleniumControl INQSRLT_SerialLotInformation_TransactionHistoryForm = new SeleniumControl( sDriver, "SerialLotInformation_TransactionHistoryForm", "xpath", "//div[translate(@id,'0123456789','')='pr__INQSRLT_INVTTRNLNSRLT_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(INQSRLT_SerialLotInformation_TransactionHistoryForm);
IWebElement formBttn = INQSRLT_SerialLotInformation_TransactionHistoryForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? INQSRLT_SerialLotInformation_TransactionHistoryForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
INQSRLT_SerialLotInformation_TransactionHistoryForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INQSRLT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INQSRLT] Performing VerifyExists on SerialLotInformation_TransactionHistoryForm...", Logger.MessageType.INF);
				SeleniumControl INQSRLT_SerialLotInformation_TransactionHistoryForm = new SeleniumControl( sDriver, "SerialLotInformation_TransactionHistoryForm", "xpath", "//div[translate(@id,'0123456789','')='pr__INQSRLT_INVTTRNLNSRLT_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,INQSRLT_SerialLotInformation_TransactionHistoryForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INQSRLT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INQSRLT] Performing VerifyExists on SerialLotInformation_TransactionHistory_TransactionType...", Logger.MessageType.INF);
				SeleniumControl INQSRLT_SerialLotInformation_TransactionHistory_TransactionType = new SeleniumControl( sDriver, "SerialLotInformation_TransactionHistory_TransactionType", "xpath", "//div[translate(@id,'0123456789','')='pr__INQSRLT_INVTTRNLNSRLT_CTW_']/ancestor::form[1]/descendant::*[@id='S_INVT_TRN_DESC']");
				Function.AssertEqual(true,INQSRLT_SerialLotInformation_TransactionHistory_TransactionType.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INQSRLT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INQSRLT] Performing Close on SerialLotInformation_TransactionHistoryForm...", Logger.MessageType.INF);
				SeleniumControl INQSRLT_SerialLotInformation_TransactionHistoryForm = new SeleniumControl( sDriver, "SerialLotInformation_TransactionHistoryForm", "xpath", "//div[translate(@id,'0123456789','')='pr__INQSRLT_INVTTRNLNSRLT_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(INQSRLT_SerialLotInformation_TransactionHistoryForm);
IWebElement formBttn = INQSRLT_SerialLotInformation_TransactionHistoryForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("SALES ORDER ISSUES");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INQSRLT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INQSRLT] Performing VerifyExists on SerialLotInformation_SalesOrderIssuesLink...", Logger.MessageType.INF);
				SeleniumControl INQSRLT_SerialLotInformation_SalesOrderIssuesLink = new SeleniumControl( sDriver, "SerialLotInformation_SalesOrderIssuesLink", "ID", "lnk_1007568_INM_SERIALLOT_SRLT");
				Function.AssertEqual(true,INQSRLT_SerialLotInformation_SalesOrderIssuesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INQSRLT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INQSRLT] Performing Click on SerialLotInformation_SalesOrderIssuesLink...", Logger.MessageType.INF);
				SeleniumControl INQSRLT_SerialLotInformation_SalesOrderIssuesLink = new SeleniumControl( sDriver, "SerialLotInformation_SalesOrderIssuesLink", "ID", "lnk_1007568_INM_SERIALLOT_SRLT");
				Function.WaitControlDisplayed(INQSRLT_SerialLotInformation_SalesOrderIssuesLink);
INQSRLT_SerialLotInformation_SalesOrderIssuesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INQSRLT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INQSRLT] Performing VerifyExist on SerialLotInformation_SalesOrderIssuesFormTable...", Logger.MessageType.INF);
				SeleniumControl INQSRLT_SerialLotInformation_SalesOrderIssuesFormTable = new SeleniumControl( sDriver, "SerialLotInformation_SalesOrderIssuesFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__INQSRLT_SOISSSERIALLOT_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,INQSRLT_SerialLotInformation_SalesOrderIssuesFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INQSRLT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INQSRLT] Performing ClickButton on SerialLotInformation_SalesOrderIssuesForm...", Logger.MessageType.INF);
				SeleniumControl INQSRLT_SerialLotInformation_SalesOrderIssuesForm = new SeleniumControl( sDriver, "SerialLotInformation_SalesOrderIssuesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__INQSRLT_SOISSSERIALLOT_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(INQSRLT_SerialLotInformation_SalesOrderIssuesForm);
IWebElement formBttn = INQSRLT_SerialLotInformation_SalesOrderIssuesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? INQSRLT_SerialLotInformation_SalesOrderIssuesForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
INQSRLT_SerialLotInformation_SalesOrderIssuesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INQSRLT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INQSRLT] Performing VerifyExists on SerialLotInformation_SalesOrderIssuesForm...", Logger.MessageType.INF);
				SeleniumControl INQSRLT_SerialLotInformation_SalesOrderIssuesForm = new SeleniumControl( sDriver, "SerialLotInformation_SalesOrderIssuesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__INQSRLT_SOISSSERIALLOT_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,INQSRLT_SerialLotInformation_SalesOrderIssuesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INQSRLT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INQSRLT] Performing VerifyExists on SerialLotInformation_SalesOrderIssues_SalesOrder...", Logger.MessageType.INF);
				SeleniumControl INQSRLT_SerialLotInformation_SalesOrderIssues_SalesOrder = new SeleniumControl( sDriver, "SerialLotInformation_SalesOrderIssues_SalesOrder", "xpath", "//div[translate(@id,'0123456789','')='pr__INQSRLT_SOISSSERIALLOT_CTW_']/ancestor::form[1]/descendant::*[@id='SO_ID']");
				Function.AssertEqual(true,INQSRLT_SerialLotInformation_SalesOrderIssues_SalesOrder.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INQSRLT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INQSRLT] Performing Close on SerialLotInformation_SalesOrderIssuesForm...", Logger.MessageType.INF);
				SeleniumControl INQSRLT_SerialLotInformation_SalesOrderIssuesForm = new SeleniumControl( sDriver, "SerialLotInformation_SalesOrderIssuesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__INQSRLT_SOISSSERIALLOT_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(INQSRLT_SerialLotInformation_SalesOrderIssuesForm);
IWebElement formBttn = INQSRLT_SerialLotInformation_SalesOrderIssuesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("CLOSE APPLICATION");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INQSRLT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INQSRLT] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl INQSRLT_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(INQSRLT_MainForm);
IWebElement formBttn = INQSRLT_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

