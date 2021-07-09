 
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
    public class RUMEQUIP_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Routings Controls", "xpath","//div[@class='navItem'][.='Routings Controls']").Click();
new SeleniumControl(sDriver,"Manage Equipment", "xpath","//div[@class='navItem'][.='Manage Equipment']").Click();


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
				Function.CurrentComponent = "RUMEQUIP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMEQUIP] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl RUMEQUIP_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,RUMEQUIP_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMEQUIP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMEQUIP] Performing VerifyExists on EquipmentID...", Logger.MessageType.INF);
				SeleniumControl RUMEQUIP_EquipmentID = new SeleniumControl( sDriver, "EquipmentID", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='EQUIP_ID']");
				Function.AssertEqual(true,RUMEQUIP_EquipmentID.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMEQUIP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMEQUIP] Performing Select on MainTab...", Logger.MessageType.INF);
				SeleniumControl RUMEQUIP_MainTab = new SeleniumControl( sDriver, "MainTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(RUMEQUIP_MainTab);
IWebElement mTab = RUMEQUIP_MainTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Equipment Detail").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMEQUIP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMEQUIP] Performing VerifyExists on EquipmentDetail_EquipmentType...", Logger.MessageType.INF);
				SeleniumControl RUMEQUIP_EquipmentDetail_EquipmentType = new SeleniumControl( sDriver, "EquipmentDetail_EquipmentType", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='S_EQUIP_TYPE_CD']");
				Function.AssertEqual(true,RUMEQUIP_EquipmentDetail_EquipmentType.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMEQUIP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMEQUIP] Performing Select on MainTab...", Logger.MessageType.INF);
				SeleniumControl RUMEQUIP_MainTab = new SeleniumControl( sDriver, "MainTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(RUMEQUIP_MainTab);
IWebElement mTab = RUMEQUIP_MainTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Source Info").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMEQUIP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMEQUIP] Performing VerifyExists on SourceInfo_Source_Manufacturer...", Logger.MessageType.INF);
				SeleniumControl RUMEQUIP_SourceInfo_Source_Manufacturer = new SeleniumControl( sDriver, "SourceInfo_Source_Manufacturer", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='MANUF_ID']");
				Function.AssertEqual(true,RUMEQUIP_SourceInfo_Source_Manufacturer.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMEQUIP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMEQUIP] Performing Select on MainTab...", Logger.MessageType.INF);
				SeleniumControl RUMEQUIP_MainTab = new SeleniumControl( sDriver, "MainTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(RUMEQUIP_MainTab);
IWebElement mTab = RUMEQUIP_MainTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Notes").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMEQUIP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMEQUIP] Performing VerifyExists on Notes_Notes...", Logger.MessageType.INF);
				SeleniumControl RUMEQUIP_Notes_Notes = new SeleniumControl( sDriver, "Notes_Notes", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='NOTES']");
				Function.AssertEqual(true,RUMEQUIP_Notes_Notes.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMEQUIP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMEQUIP] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl RUMEQUIP_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(RUMEQUIP_MainForm);
IWebElement formBttn = RUMEQUIP_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? RUMEQUIP_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
RUMEQUIP_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMEQUIP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMEQUIP] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl RUMEQUIP_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,RUMEQUIP_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMEQUIP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMEQUIP] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl RUMEQUIP_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(RUMEQUIP_MainForm);
IWebElement formBttn = RUMEQUIP_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? RUMEQUIP_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
RUMEQUIP_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMEQUIP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMEQUIP] Performing Click on MaintenanceLink...", Logger.MessageType.INF);
				SeleniumControl RUMEQUIP_MaintenanceLink = new SeleniumControl( sDriver, "MaintenanceLink", "ID", "lnk_1721_RUMEQUIP_EQUIP");
				Function.WaitControlDisplayed(RUMEQUIP_MaintenanceLink);
RUMEQUIP_MaintenanceLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("MaintenanceForm");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMEQUIP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMEQUIP] Performing VerifyExists on MaintenanceForm...", Logger.MessageType.INF);
				SeleniumControl RUMEQUIP_MaintenanceForm = new SeleniumControl( sDriver, "MaintenanceForm", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMEQUIP_EQUIP_MAINT_']/ancestor::form[1]");
				Function.AssertEqual(true,RUMEQUIP_MaintenanceForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMEQUIP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMEQUIP] Performing VerifyExist on MaintenanceFormTable...", Logger.MessageType.INF);
				SeleniumControl RUMEQUIP_MaintenanceFormTable = new SeleniumControl( sDriver, "MaintenanceFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMEQUIP_EQUIP_MAINT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,RUMEQUIP_MaintenanceFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMEQUIP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMEQUIP] Performing ClickButton on MaintenanceForm...", Logger.MessageType.INF);
				SeleniumControl RUMEQUIP_MaintenanceForm = new SeleniumControl( sDriver, "MaintenanceForm", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMEQUIP_EQUIP_MAINT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(RUMEQUIP_MaintenanceForm);
IWebElement formBttn = RUMEQUIP_MaintenanceForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? RUMEQUIP_MaintenanceForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
RUMEQUIP_MaintenanceForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMEQUIP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMEQUIP] Performing VerifyExists on Maintenance_MaintenanceType...", Logger.MessageType.INF);
				SeleniumControl RUMEQUIP_Maintenance_MaintenanceType = new SeleniumControl( sDriver, "Maintenance_MaintenanceType", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMEQUIP_EQUIP_MAINT_']/ancestor::form[1]/descendant::*[@id='MAINT_TYPE_CD']");
				Function.AssertEqual(true,RUMEQUIP_Maintenance_MaintenanceType.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMEQUIP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMEQUIP] Performing Close on MaintenanceForm...", Logger.MessageType.INF);
				SeleniumControl RUMEQUIP_MaintenanceForm = new SeleniumControl( sDriver, "MaintenanceForm", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMEQUIP_EQUIP_MAINT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(RUMEQUIP_MaintenanceForm);
IWebElement formBttn = RUMEQUIP_MaintenanceForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "RUMEQUIP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMEQUIP] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl RUMEQUIP_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(RUMEQUIP_MainForm);
IWebElement formBttn = RUMEQUIP_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

