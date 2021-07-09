 
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
    public class INQHSTPR_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"View Inventory Transaction History", "xpath","//div[@class='navItem'][.='View Inventory Transaction History']").Click();


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
				Function.CurrentComponent = "INQHSTPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INQHSTPR] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl INQHSTPR_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,INQHSTPR_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INQHSTPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INQHSTPR] Performing VerifyExists on MainForm_Part...", Logger.MessageType.INF);
				SeleniumControl INQHSTPR_MainForm_Part = new SeleniumControl( sDriver, "MainForm_Part", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PART_ID']");
				Function.AssertEqual(true,INQHSTPR_MainForm_Part.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INQHSTPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INQHSTPR] Performing Set on MainForm_Part...", Logger.MessageType.INF);
				SeleniumControl INQHSTPR_MainForm_Part = new SeleniumControl( sDriver, "MainForm_Part", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PART_ID']");
				INQHSTPR_MainForm_Part.Click();
INQHSTPR_MainForm_Part.SendKeys("1260", true);
Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));
INQHSTPR_MainForm_Part.SendKeys(OpenQA.Selenium.Keys.Shift + OpenQA.Selenium.Keys.Tab);


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
				this.ScriptLogger.WriteLine("Child Form");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INQHSTPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INQHSTPR] Performing VerifyExist on ChildFormTable...", Logger.MessageType.INF);
				SeleniumControl INQHSTPR_ChildFormTable = new SeleniumControl( sDriver, "ChildFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__INQHSTPR_INVTTRANLN_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,INQHSTPR_ChildFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INQHSTPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INQHSTPR] Performing ClickButton on ChildForm...", Logger.MessageType.INF);
				SeleniumControl INQHSTPR_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__INQHSTPR_INVTTRANLN_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(INQHSTPR_ChildForm);
IWebElement formBttn = INQHSTPR_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? INQHSTPR_ChildForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
INQHSTPR_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INQHSTPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INQHSTPR] Performing VerifyExists on ChildForm...", Logger.MessageType.INF);
				SeleniumControl INQHSTPR_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__INQHSTPR_INVTTRANLN_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,INQHSTPR_ChildForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INQHSTPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INQHSTPR] Performing Select on ChildForm_ChildFormTab...", Logger.MessageType.INF);
				SeleniumControl INQHSTPR_ChildForm_ChildFormTab = new SeleniumControl( sDriver, "ChildForm_ChildFormTab", "xpath", "//div[translate(@id,'0123456789','')='pr__INQHSTPR_INVTTRANLN_CTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(INQHSTPR_ChildForm_ChildFormTab);
IWebElement mTab = INQHSTPR_ChildForm_ChildFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Transaction Detail").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INQHSTPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INQHSTPR] Performing VerifyExists on ChildForm_TransactionDetail_Transaction...", Logger.MessageType.INF);
				SeleniumControl INQHSTPR_ChildForm_TransactionDetail_Transaction = new SeleniumControl( sDriver, "ChildForm_TransactionDetail_Transaction", "xpath", "//div[translate(@id,'0123456789','')='pr__INQHSTPR_INVTTRANLN_CTW_']/ancestor::form[1]/descendant::*[@id='INVT_TRN_ID']");
				Function.AssertEqual(true,INQHSTPR_ChildForm_TransactionDetail_Transaction.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INQHSTPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INQHSTPR] Performing Select on ChildForm_ChildFormTab...", Logger.MessageType.INF);
				SeleniumControl INQHSTPR_ChildForm_ChildFormTab = new SeleniumControl( sDriver, "ChildForm_ChildFormTab", "xpath", "//div[translate(@id,'0123456789','')='pr__INQHSTPR_INVTTRANLN_CTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(INQHSTPR_ChildForm_ChildFormTab);
IWebElement mTab = INQHSTPR_ChildForm_ChildFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Cost Elements").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INQHSTPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INQHSTPR] Performing VerifyExists on ChildForm_CostElements_DirectCostElements_Material...", Logger.MessageType.INF);
				SeleniumControl INQHSTPR_ChildForm_CostElements_DirectCostElements_Material = new SeleniumControl( sDriver, "ChildForm_CostElements_DirectCostElements_Material", "xpath", "//div[translate(@id,'0123456789','')='pr__INQHSTPR_INVTTRANLN_CTW_']/ancestor::form[1]/descendant::*[@id='MATL_CST_AMT']");
				Function.AssertEqual(true,INQHSTPR_ChildForm_CostElements_DirectCostElements_Material.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INQHSTPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INQHSTPR] Performing Select on ChildForm_ChildFormTab...", Logger.MessageType.INF);
				SeleniumControl INQHSTPR_ChildForm_ChildFormTab = new SeleniumControl( sDriver, "ChildForm_ChildFormTab", "xpath", "//div[translate(@id,'0123456789','')='pr__INQHSTPR_INVTTRANLN_CTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(INQHSTPR_ChildForm_ChildFormTab);
IWebElement mTab = INQHSTPR_ChildForm_ChildFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Usage Summary").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INQHSTPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INQHSTPR] Performing VerifyExists on ChildForm_UsageSummary_YearToDateUsageQty...", Logger.MessageType.INF);
				SeleniumControl INQHSTPR_ChildForm_UsageSummary_YearToDateUsageQty = new SeleniumControl( sDriver, "ChildForm_UsageSummary_YearToDateUsageQty", "xpath", "//div[translate(@id,'0123456789','')='pr__INQHSTPR_INVTTRANLN_CTW_']/ancestor::form[1]/descendant::*[@id='USG_SMRY_QTY']");
				Function.AssertEqual(true,INQHSTPR_ChildForm_UsageSummary_YearToDateUsageQty.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INQHSTPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INQHSTPR] Performing Select on ChildForm_ChildFormTab...", Logger.MessageType.INF);
				SeleniumControl INQHSTPR_ChildForm_ChildFormTab = new SeleniumControl( sDriver, "ChildForm_ChildFormTab", "xpath", "//div[translate(@id,'0123456789','')='pr__INQHSTPR_INVTTRANLN_CTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(INQHSTPR_ChildForm_ChildFormTab);
IWebElement mTab = INQHSTPR_ChildForm_ChildFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Notes").FirstOrDefault();
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
				this.ScriptLogger.WriteLine("Serial Lot Info");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INQHSTPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INQHSTPR] Performing VerifyExists on ChildForm_SerialLotInformationLink...", Logger.MessageType.INF);
				SeleniumControl INQHSTPR_ChildForm_SerialLotInformationLink = new SeleniumControl( sDriver, "ChildForm_SerialLotInformationLink", "ID", "lnk_1007369_INQHSTPR_INVTTRANLN_CTW");
				Function.AssertEqual(true,INQHSTPR_ChildForm_SerialLotInformationLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INQHSTPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INQHSTPR] Performing Click on ChildForm_SerialLotInformationLink...", Logger.MessageType.INF);
				SeleniumControl INQHSTPR_ChildForm_SerialLotInformationLink = new SeleniumControl( sDriver, "ChildForm_SerialLotInformationLink", "ID", "lnk_1007369_INQHSTPR_INVTTRANLN_CTW");
				Function.WaitControlDisplayed(INQHSTPR_ChildForm_SerialLotInformationLink);
INQHSTPR_ChildForm_SerialLotInformationLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INQHSTPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INQHSTPR] Performing VerifyExist on SerialLotInfoFormTable...", Logger.MessageType.INF);
				SeleniumControl INQHSTPR_SerialLotInfoFormTable = new SeleniumControl( sDriver, "SerialLotInfoFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__INM_SERIALLOT_SRLT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,INQHSTPR_SerialLotInfoFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INQHSTPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INQHSTPR] Performing ClickButton on SerialLotInfoForm...", Logger.MessageType.INF);
				SeleniumControl INQHSTPR_SerialLotInfoForm = new SeleniumControl( sDriver, "SerialLotInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__INM_SERIALLOT_SRLT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(INQHSTPR_SerialLotInfoForm);
IWebElement formBttn = INQHSTPR_SerialLotInfoForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? INQHSTPR_SerialLotInfoForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
INQHSTPR_SerialLotInfoForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INQHSTPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INQHSTPR] Performing VerifyExists on SerialLotInfoForm...", Logger.MessageType.INF);
				SeleniumControl INQHSTPR_SerialLotInfoForm = new SeleniumControl( sDriver, "SerialLotInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__INM_SERIALLOT_SRLT_']/ancestor::form[1]");
				Function.AssertEqual(true,INQHSTPR_SerialLotInfoForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INQHSTPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INQHSTPR] Performing VerifyExists on SerialLotInformation_SerialNumber...", Logger.MessageType.INF);
				SeleniumControl INQHSTPR_SerialLotInformation_SerialNumber = new SeleniumControl( sDriver, "SerialLotInformation_SerialNumber", "xpath", "//div[translate(@id,'0123456789','')='pr__INM_SERIALLOT_SRLT_']/ancestor::form[1]/descendant::*[@id='SERIAL_ID']");
				Function.AssertEqual(true,INQHSTPR_SerialLotInformation_SerialNumber.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INQHSTPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INQHSTPR] Performing Select on SerialLotInformation_SerialLotInformationTab...", Logger.MessageType.INF);
				SeleniumControl INQHSTPR_SerialLotInformation_SerialLotInformationTab = new SeleniumControl( sDriver, "SerialLotInformation_SerialLotInformationTab", "xpath", "//div[translate(@id,'0123456789','')='pr__INM_SERIALLOT_SRLT_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(INQHSTPR_SerialLotInformation_SerialLotInformationTab);
IWebElement mTab = INQHSTPR_SerialLotInformation_SerialLotInformationTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Serial/Lot Details").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INQHSTPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INQHSTPR] Performing VerifyExists on SerialLotInformation_SerialLotDetails_Quantity...", Logger.MessageType.INF);
				SeleniumControl INQHSTPR_SerialLotInformation_SerialLotDetails_Quantity = new SeleniumControl( sDriver, "SerialLotInformation_SerialLotDetails_Quantity", "xpath", "//div[translate(@id,'0123456789','')='pr__INM_SERIALLOT_SRLT_']/ancestor::form[1]/descendant::*[@id='TOTAL_QTY']");
				Function.AssertEqual(true,INQHSTPR_SerialLotInformation_SerialLotDetails_Quantity.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INQHSTPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INQHSTPR] Performing Select on SerialLotInformation_SerialLotInformationTab...", Logger.MessageType.INF);
				SeleniumControl INQHSTPR_SerialLotInformation_SerialLotInformationTab = new SeleniumControl( sDriver, "SerialLotInformation_SerialLotInformationTab", "xpath", "//div[translate(@id,'0123456789','')='pr__INM_SERIALLOT_SRLT_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(INQHSTPR_SerialLotInformation_SerialLotInformationTab);
IWebElement mTab = INQHSTPR_SerialLotInformation_SerialLotInformationTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Manufacturer/Vendor Information").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INQHSTPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INQHSTPR] Performing VerifyExists on SerialLotInformation_ManufacturerVendorInformation_ManufacturerVendorSerialNumber...", Logger.MessageType.INF);
				SeleniumControl INQHSTPR_SerialLotInformation_ManufacturerVendorInformation_ManufacturerVendorSerialNumber = new SeleniumControl( sDriver, "SerialLotInformation_ManufacturerVendorInformation_ManufacturerVendorSerialNumber", "xpath", "//div[translate(@id,'0123456789','')='pr__INM_SERIALLOT_SRLT_']/ancestor::form[1]/descendant::*[@id='MAN_VEND_SERIAL_ID']");
				Function.AssertEqual(true,INQHSTPR_SerialLotInformation_ManufacturerVendorInformation_ManufacturerVendorSerialNumber.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INQHSTPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INQHSTPR] Performing Select on SerialLotInformation_SerialLotInformationTab...", Logger.MessageType.INF);
				SeleniumControl INQHSTPR_SerialLotInformation_SerialLotInformationTab = new SeleniumControl( sDriver, "SerialLotInformation_SerialLotInformationTab", "xpath", "//div[translate(@id,'0123456789','')='pr__INM_SERIALLOT_SRLT_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(INQHSTPR_SerialLotInformation_SerialLotInformationTab);
IWebElement mTab = INQHSTPR_SerialLotInformation_SerialLotInformationTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Maintenance/Warranty Information").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INQHSTPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INQHSTPR] Performing VerifyExists on SerialLotInformation_MaintenanceWarrantyInformation_Maintenance_SalesOrder...", Logger.MessageType.INF);
				SeleniumControl INQHSTPR_SerialLotInformation_MaintenanceWarrantyInformation_Maintenance_SalesOrder = new SeleniumControl( sDriver, "SerialLotInformation_MaintenanceWarrantyInformation_Maintenance_SalesOrder", "xpath", "//div[translate(@id,'0123456789','')='pr__INM_SERIALLOT_SRLT_']/ancestor::form[1]/descendant::*[@id='MAINT_SO_ID']");
				Function.AssertEqual(true,INQHSTPR_SerialLotInformation_MaintenanceWarrantyInformation_Maintenance_SalesOrder.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INQHSTPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INQHSTPR] Performing Select on SerialLotInformation_SerialLotInformationTab...", Logger.MessageType.INF);
				SeleniumControl INQHSTPR_SerialLotInformation_SerialLotInformationTab = new SeleniumControl( sDriver, "SerialLotInformation_SerialLotInformationTab", "xpath", "//div[translate(@id,'0123456789','')='pr__INM_SERIALLOT_SRLT_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(INQHSTPR_SerialLotInformation_SerialLotInformationTab);
IWebElement mTab = INQHSTPR_SerialLotInformation_SerialLotInformationTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Notes").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INQHSTPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INQHSTPR] Performing VerifyExists on SerialLotInformation_Notes_Notes...", Logger.MessageType.INF);
				SeleniumControl INQHSTPR_SerialLotInformation_Notes_Notes = new SeleniumControl( sDriver, "SerialLotInformation_Notes_Notes", "xpath", "//div[translate(@id,'0123456789','')='pr__INM_SERIALLOT_SRLT_']/ancestor::form[1]/descendant::*[@id='NOTES_NT']");
				Function.AssertEqual(true,INQHSTPR_SerialLotInformation_Notes_Notes.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INQHSTPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INQHSTPR] Performing Close on SerialLotInfoForm...", Logger.MessageType.INF);
				SeleniumControl INQHSTPR_SerialLotInfoForm = new SeleniumControl( sDriver, "SerialLotInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__INM_SERIALLOT_SRLT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(INQHSTPR_SerialLotInfoForm);
IWebElement formBttn = INQHSTPR_SerialLotInfoForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Closing App");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INQHSTPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INQHSTPR] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl INQHSTPR_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(INQHSTPR_MainForm);
IWebElement formBttn = INQHSTPR_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

