 
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
    public class INMSRLT_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Inventory Utilities", "xpath","//div[@class='navItem'][.='Inventory Utilities']").Click();
new SeleniumControl(sDriver,"Manage Serial/Lot Information", "xpath","//div[@class='navItem'][.='Manage Serial/Lot Information']").Click();


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
				Function.CurrentComponent = "INMSRLT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMSRLT] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl INMSRLT_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,INMSRLT_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMSRLT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMSRLT] Performing VerifyExists on Part...", Logger.MessageType.INF);
				SeleniumControl INMSRLT_Part = new SeleniumControl( sDriver, "Part", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PART_ID']");
				Function.AssertEqual(true,INMSRLT_Part.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("SET DATA");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMSRLT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMSRLT] Performing Set on Part...", Logger.MessageType.INF);
				SeleniumControl INMSRLT_Part = new SeleniumControl( sDriver, "Part", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PART_ID']");
				INMSRLT_Part.Click();
INMSRLT_Part.SendKeys("047569071256", true);
Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));
INMSRLT_Part.SendKeys(OpenQA.Selenium.Keys.Shift + OpenQA.Selenium.Keys.Tab);


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
				this.ScriptLogger.WriteLine("CHILD FORM TABLE");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMSRLT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMSRLT] Performing VerifyExist on SerialLotMaintenanceDetailsTable...", Logger.MessageType.INF);
				SeleniumControl INMSRLT_SerialLotMaintenanceDetailsTable = new SeleniumControl( sDriver, "SerialLotMaintenanceDetailsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__INMSRLT_SERIALLOT_SERILOTMAINT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,INMSRLT_SerialLotMaintenanceDetailsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMSRLT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMSRLT] Performing ClickButton on SerialLotMaintenanceDetailsForm...", Logger.MessageType.INF);
				SeleniumControl INMSRLT_SerialLotMaintenanceDetailsForm = new SeleniumControl( sDriver, "SerialLotMaintenanceDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__INMSRLT_SERIALLOT_SERILOTMAINT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(INMSRLT_SerialLotMaintenanceDetailsForm);
IWebElement formBttn = INMSRLT_SerialLotMaintenanceDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? INMSRLT_SerialLotMaintenanceDetailsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
INMSRLT_SerialLotMaintenanceDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
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
				Function.CurrentComponent = "INMSRLT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMSRLT] Performing VerifyExists on SerialLotMaintenanceDetailsForm...", Logger.MessageType.INF);
				SeleniumControl INMSRLT_SerialLotMaintenanceDetailsForm = new SeleniumControl( sDriver, "SerialLotMaintenanceDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__INMSRLT_SERIALLOT_SERILOTMAINT_']/ancestor::form[1]");
				Function.AssertEqual(true,INMSRLT_SerialLotMaintenanceDetailsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("TAB");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMSRLT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMSRLT] Performing VerifyExists on SerialLotMaintenanceDetails_BasicInformation_SerialNumber...", Logger.MessageType.INF);
				SeleniumControl INMSRLT_SerialLotMaintenanceDetails_BasicInformation_SerialNumber = new SeleniumControl( sDriver, "SerialLotMaintenanceDetails_BasicInformation_SerialNumber", "xpath", "//div[translate(@id,'0123456789','')='pr__INMSRLT_SERIALLOT_SERILOTMAINT_']/ancestor::form[1]/descendant::*[@id='SERIAL_ID']");
				Function.AssertEqual(true,INMSRLT_SerialLotMaintenanceDetails_BasicInformation_SerialNumber.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMSRLT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMSRLT] Performing Select on SerialLotMaintenanceDetailsTab...", Logger.MessageType.INF);
				SeleniumControl INMSRLT_SerialLotMaintenanceDetailsTab = new SeleniumControl( sDriver, "SerialLotMaintenanceDetailsTab", "xpath", "//div[translate(@id,'0123456789','')='pr__INMSRLT_SERIALLOT_SERILOTMAINT_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(INMSRLT_SerialLotMaintenanceDetailsTab);
IWebElement mTab = INMSRLT_SerialLotMaintenanceDetailsTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Serial/Lot Origin").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMSRLT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMSRLT] Performing VerifyExists on SerialLotMaintenanceDetails_SerialLotOrigin_OriginalOrder...", Logger.MessageType.INF);
				SeleniumControl INMSRLT_SerialLotMaintenanceDetails_SerialLotOrigin_OriginalOrder = new SeleniumControl( sDriver, "SerialLotMaintenanceDetails_SerialLotOrigin_OriginalOrder", "xpath", "//div[translate(@id,'0123456789','')='pr__INMSRLT_SERIALLOT_SERILOTMAINT_']/ancestor::form[1]/descendant::*[@id='ORIG_ORD_ID']");
				Function.AssertEqual(true,INMSRLT_SerialLotMaintenanceDetails_SerialLotOrigin_OriginalOrder.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMSRLT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMSRLT] Performing Select on SerialLotMaintenanceDetailsTab...", Logger.MessageType.INF);
				SeleniumControl INMSRLT_SerialLotMaintenanceDetailsTab = new SeleniumControl( sDriver, "SerialLotMaintenanceDetailsTab", "xpath", "//div[translate(@id,'0123456789','')='pr__INMSRLT_SERIALLOT_SERILOTMAINT_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(INMSRLT_SerialLotMaintenanceDetailsTab);
IWebElement mTab = INMSRLT_SerialLotMaintenanceDetailsTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Manuf/Vend Information").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMSRLT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMSRLT] Performing VerifyExists on SerialLotMaintenanceDetails_ManufVendInformation_Manufacturer...", Logger.MessageType.INF);
				SeleniumControl INMSRLT_SerialLotMaintenanceDetails_ManufVendInformation_Manufacturer = new SeleniumControl( sDriver, "SerialLotMaintenanceDetails_ManufVendInformation_Manufacturer", "xpath", "//div[translate(@id,'0123456789','')='pr__INMSRLT_SERIALLOT_SERILOTMAINT_']/ancestor::form[1]/descendant::*[@id='MANUF_ID']");
				Function.AssertEqual(true,INMSRLT_SerialLotMaintenanceDetails_ManufVendInformation_Manufacturer.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMSRLT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMSRLT] Performing Select on SerialLotMaintenanceDetailsTab...", Logger.MessageType.INF);
				SeleniumControl INMSRLT_SerialLotMaintenanceDetailsTab = new SeleniumControl( sDriver, "SerialLotMaintenanceDetailsTab", "xpath", "//div[translate(@id,'0123456789','')='pr__INMSRLT_SERIALLOT_SERILOTMAINT_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(INMSRLT_SerialLotMaintenanceDetailsTab);
IWebElement mTab = INMSRLT_SerialLotMaintenanceDetailsTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Warranties").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMSRLT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMSRLT] Performing VerifyExists on SerialLotMaintenanceDetails_Warranties_VendorWarranty...", Logger.MessageType.INF);
				SeleniumControl INMSRLT_SerialLotMaintenanceDetails_Warranties_VendorWarranty = new SeleniumControl( sDriver, "SerialLotMaintenanceDetails_Warranties_VendorWarranty", "xpath", "//div[translate(@id,'0123456789','')='pr__INMSRLT_SERIALLOT_SERILOTMAINT_']/ancestor::form[1]/descendant::*[@id='VEND_WARR_CD']");
				Function.AssertEqual(true,INMSRLT_SerialLotMaintenanceDetails_Warranties_VendorWarranty.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMSRLT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMSRLT] Performing Select on SerialLotMaintenanceDetailsTab...", Logger.MessageType.INF);
				SeleniumControl INMSRLT_SerialLotMaintenanceDetailsTab = new SeleniumControl( sDriver, "SerialLotMaintenanceDetailsTab", "xpath", "//div[translate(@id,'0123456789','')='pr__INMSRLT_SERIALLOT_SERILOTMAINT_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(INMSRLT_SerialLotMaintenanceDetailsTab);
IWebElement mTab = INMSRLT_SerialLotMaintenanceDetailsTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "UID").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMSRLT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMSRLT] Performing VerifyExists on SerialLotMaintenanceDetails_UID_UIDDetails_UID...", Logger.MessageType.INF);
				SeleniumControl INMSRLT_SerialLotMaintenanceDetails_UID_UIDDetails_UID = new SeleniumControl( sDriver, "SerialLotMaintenanceDetails_UID_UIDDetails_UID", "xpath", "//div[translate(@id,'0123456789','')='pr__INMSRLT_SERIALLOT_SERILOTMAINT_']/ancestor::form[1]/descendant::*[@id='UID_CD']");
				Function.AssertEqual(true,INMSRLT_SerialLotMaintenanceDetails_UID_UIDDetails_UID.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMSRLT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMSRLT] Performing Select on SerialLotMaintenanceDetailsTab...", Logger.MessageType.INF);
				SeleniumControl INMSRLT_SerialLotMaintenanceDetailsTab = new SeleniumControl( sDriver, "SerialLotMaintenanceDetailsTab", "xpath", "//div[translate(@id,'0123456789','')='pr__INMSRLT_SERIALLOT_SERILOTMAINT_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(INMSRLT_SerialLotMaintenanceDetailsTab);
IWebElement mTab = INMSRLT_SerialLotMaintenanceDetailsTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Notes").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMSRLT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMSRLT] Performing VerifyExists on SerialLotMaintenanceDetails_Notes_Notes...", Logger.MessageType.INF);
				SeleniumControl INMSRLT_SerialLotMaintenanceDetails_Notes_Notes = new SeleniumControl( sDriver, "SerialLotMaintenanceDetails_Notes_Notes", "xpath", "//div[translate(@id,'0123456789','')='pr__INMSRLT_SERIALLOT_SERILOTMAINT_']/ancestor::form[1]/descendant::*[@id='NOTES_NT']");
				Function.AssertEqual(true,INMSRLT_SerialLotMaintenanceDetails_Notes_Notes.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMSRLT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMSRLT] Performing Select on SerialLotMaintenanceDetailsTab...", Logger.MessageType.INF);
				SeleniumControl INMSRLT_SerialLotMaintenanceDetailsTab = new SeleniumControl( sDriver, "SerialLotMaintenanceDetailsTab", "xpath", "//div[translate(@id,'0123456789','')='pr__INMSRLT_SERIALLOT_SERILOTMAINT_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(INMSRLT_SerialLotMaintenanceDetailsTab);
IWebElement mTab = INMSRLT_SerialLotMaintenanceDetailsTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Shelf Life").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMSRLT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMSRLT] Performing VerifyExists on SerialLotMaintenanceDetails_ShelfLife_ShelfLife_LastExtensionDate...", Logger.MessageType.INF);
				SeleniumControl INMSRLT_SerialLotMaintenanceDetails_ShelfLife_ShelfLife_LastExtensionDate = new SeleniumControl( sDriver, "SerialLotMaintenanceDetails_ShelfLife_ShelfLife_LastExtensionDate", "xpath", "//div[translate(@id,'0123456789','')='pr__INMSRLT_SERIALLOT_SERILOTMAINT_']/ancestor::form[1]/descendant::*[@id='LAST_EXT_DT']");
				Function.AssertEqual(true,INMSRLT_SerialLotMaintenanceDetails_ShelfLife_ShelfLife_LastExtensionDate.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
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
				Function.CurrentComponent = "INMSRLT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMSRLT] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl INMSRLT_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(INMSRLT_MainForm);
IWebElement formBttn = INMSRLT_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

