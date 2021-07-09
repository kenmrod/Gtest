 
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
    public class FAMACTED_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Accounting", "xpath","//div[@class='busItem'][.='Accounting']").Click();
new SeleniumControl(sDriver,"Fixed Assets", "xpath","//div[@class='deptItem'][.='Fixed Assets']").Click();
new SeleniumControl(sDriver,"Asset Master Records", "xpath","//div[@class='navItem'][.='Asset Master Records']").Click();
new SeleniumControl(sDriver,"Manage Autocreation Transactions", "xpath","//div[@class='navItem'][.='Manage Autocreation Transactions']").Click();


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
				Function.CurrentComponent = "FAMACTED";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAMACTED] Performing VerifyExist on MainForm_Table...", Logger.MessageType.INF);
				SeleniumControl FAMACTED_MainForm_Table = new SeleniumControl( sDriver, "MainForm_Table", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,FAMACTED_MainForm_Table.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAMACTED";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAMACTED] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl FAMACTED_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(FAMACTED_MainForm);
IWebElement formBttn = FAMACTED_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? FAMACTED_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
FAMACTED_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAMACTED";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAMACTED] Performing VerifyExists on Identification_TemporaryAssetNo...", Logger.MessageType.INF);
				SeleniumControl FAMACTED_Identification_TemporaryAssetNo = new SeleniumControl( sDriver, "Identification_TemporaryAssetNo", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='TEMP_ASSET_ID']");
				Function.AssertEqual(true,FAMACTED_Identification_TemporaryAssetNo.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAMACTED";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAMACTED] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl FAMACTED_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,FAMACTED_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAMACTED";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAMACTED] Performing Select on MainForm_Tab...", Logger.MessageType.INF);
				SeleniumControl FAMACTED_MainForm_Tab = new SeleniumControl( sDriver, "MainForm_Tab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(FAMACTED_MainForm_Tab);
IWebElement mTab = FAMACTED_MainForm_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Desc Info").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAMACTED";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAMACTED] Performing VerifyExists on MainForm_DescInfo_RecordStatus_RecordStatus...", Logger.MessageType.INF);
				SeleniumControl FAMACTED_MainForm_DescInfo_RecordStatus_RecordStatus = new SeleniumControl( sDriver, "MainForm_DescInfo_RecordStatus_RecordStatus", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='S_STATUS_CD']");
				Function.AssertEqual(true,FAMACTED_MainForm_DescInfo_RecordStatus_RecordStatus.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAMACTED";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAMACTED] Performing Select on MainForm_Tab...", Logger.MessageType.INF);
				SeleniumControl FAMACTED_MainForm_Tab = new SeleniumControl( sDriver, "MainForm_Tab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(FAMACTED_MainForm_Tab);
IWebElement mTab = FAMACTED_MainForm_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Purch Info").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAMACTED";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAMACTED] Performing VerifyExists on MainForm_PurchInfo_PurchaseOrder_PODate...", Logger.MessageType.INF);
				SeleniumControl FAMACTED_MainForm_PurchInfo_PurchaseOrder_PODate = new SeleniumControl( sDriver, "MainForm_PurchInfo_PurchaseOrder_PODate", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PO_DT']");
				Function.AssertEqual(true,FAMACTED_MainForm_PurchInfo_PurchaseOrder_PODate.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAMACTED";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAMACTED] Performing Select on MainForm_Tab...", Logger.MessageType.INF);
				SeleniumControl FAMACTED_MainForm_Tab = new SeleniumControl( sDriver, "MainForm_Tab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(FAMACTED_MainForm_Tab);
IWebElement mTab = FAMACTED_MainForm_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Loc Info").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAMACTED";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAMACTED] Performing VerifyExists on MainForm_LocInfo_GeneralLocationInfo_City...", Logger.MessageType.INF);
				SeleniumControl FAMACTED_MainForm_LocInfo_GeneralLocationInfo_City = new SeleniumControl( sDriver, "MainForm_LocInfo_GeneralLocationInfo_City", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='CITY_NAME']");
				Function.AssertEqual(true,FAMACTED_MainForm_LocInfo_GeneralLocationInfo_City.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAMACTED";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAMACTED] Performing Select on MainForm_Tab...", Logger.MessageType.INF);
				SeleniumControl FAMACTED_MainForm_Tab = new SeleniumControl( sDriver, "MainForm_Tab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(FAMACTED_MainForm_Tab);
IWebElement mTab = FAMACTED_MainForm_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Cost Info").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAMACTED";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAMACTED] Performing VerifyExists on MainForm_CostInfo_Units_Quantity...", Logger.MessageType.INF);
				SeleniumControl FAMACTED_MainForm_CostInfo_Units_Quantity = new SeleniumControl( sDriver, "MainForm_CostInfo_Units_Quantity", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='UNITS_QTY_NO']");
				Function.AssertEqual(true,FAMACTED_MainForm_CostInfo_Units_Quantity.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAMACTED";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAMACTED] Performing Select on MainForm_Tab...", Logger.MessageType.INF);
				SeleniumControl FAMACTED_MainForm_Tab = new SeleniumControl( sDriver, "MainForm_Tab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(FAMACTED_MainForm_Tab);
IWebElement mTab = FAMACTED_MainForm_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Acct Info").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAMACTED";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAMACTED] Performing VerifyExists on MainForm_AcctInfo_AssetAccount_AssetAccount...", Logger.MessageType.INF);
				SeleniumControl FAMACTED_MainForm_AcctInfo_AssetAccount_AssetAccount = new SeleniumControl( sDriver, "MainForm_AcctInfo_AssetAccount_AssetAccount", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='ACCT_ID']");
				Function.AssertEqual(true,FAMACTED_MainForm_AcctInfo_AssetAccount_AssetAccount.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAMACTED";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAMACTED] Performing Select on MainForm_Tab...", Logger.MessageType.INF);
				SeleniumControl FAMACTED_MainForm_Tab = new SeleniumControl( sDriver, "MainForm_Tab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(FAMACTED_MainForm_Tab);
IWebElement mTab = FAMACTED_MainForm_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "G/L Book Info").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAMACTED";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAMACTED] Performing VerifyExists on MainForm_GLBookInfo_DepreciationInfo_DeprMethodCode...", Logger.MessageType.INF);
				SeleniumControl FAMACTED_MainForm_GLBookInfo_DepreciationInfo_DeprMethodCode = new SeleniumControl( sDriver, "MainForm_GLBookInfo_DepreciationInfo_DeprMethodCode", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='B1_DEPR_MTHD_CD']");
				Function.AssertEqual(true,FAMACTED_MainForm_GLBookInfo_DepreciationInfo_DeprMethodCode.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAMACTED";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAMACTED] Performing Select on MainForm_Tab...", Logger.MessageType.INF);
				SeleniumControl FAMACTED_MainForm_Tab = new SeleniumControl( sDriver, "MainForm_Tab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(FAMACTED_MainForm_Tab);
IWebElement mTab = FAMACTED_MainForm_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Other Books Info").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAMACTED";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAMACTED] Performing VerifyExists on MainForm_OtherBooksInfo_Tax_DeprMethodCode...", Logger.MessageType.INF);
				SeleniumControl FAMACTED_MainForm_OtherBooksInfo_Tax_DeprMethodCode = new SeleniumControl( sDriver, "MainForm_OtherBooksInfo_Tax_DeprMethodCode", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='B2_DEPR_MTHD_CD']");
				Function.AssertEqual(true,FAMACTED_MainForm_OtherBooksInfo_Tax_DeprMethodCode.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAMACTED";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAMACTED] Performing Select on MainForm_Tab...", Logger.MessageType.INF);
				SeleniumControl FAMACTED_MainForm_Tab = new SeleniumControl( sDriver, "MainForm_Tab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(FAMACTED_MainForm_Tab);
IWebElement mTab = FAMACTED_MainForm_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Govt Info").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAMACTED";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAMACTED] Performing VerifyExists on MainForm_GovtInfo_NatStockNo...", Logger.MessageType.INF);
				SeleniumControl FAMACTED_MainForm_GovtInfo_NatStockNo = new SeleniumControl( sDriver, "MainForm_GovtInfo_NatStockNo", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='NSN_ID']");
				Function.AssertEqual(true,FAMACTED_MainForm_GovtInfo_NatStockNo.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Link");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAMACTED";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAMACTED] Performing VerifyExists on MainForm_TemplateImportParametersLink...", Logger.MessageType.INF);
				SeleniumControl FAMACTED_MainForm_TemplateImportParametersLink = new SeleniumControl( sDriver, "MainForm_TemplateImportParametersLink", "ID", "lnk_1003373_FAMACTED_AUTOCRASSETEDIT_HDR");
				Function.AssertEqual(true,FAMACTED_MainForm_TemplateImportParametersLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAMACTED";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAMACTED] Performing Click on MainForm_TemplateImportParametersLink...", Logger.MessageType.INF);
				SeleniumControl FAMACTED_MainForm_TemplateImportParametersLink = new SeleniumControl( sDriver, "MainForm_TemplateImportParametersLink", "ID", "lnk_1003373_FAMACTED_AUTOCRASSETEDIT_HDR");
				Function.WaitControlDisplayed(FAMACTED_MainForm_TemplateImportParametersLink);
FAMACTED_MainForm_TemplateImportParametersLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAMACTED";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAMACTED] Performing VerifyExists on TemplateImportParametersForm...", Logger.MessageType.INF);
				SeleniumControl FAMACTED_TemplateImportParametersForm = new SeleniumControl( sDriver, "TemplateImportParametersForm", "xpath", "//div[translate(@id,'0123456789','')='pr__FAMACTED_TEMPLATEIMPORT_']/ancestor::form[1]");
				Function.AssertEqual(true,FAMACTED_TemplateImportParametersForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAMACTED";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAMACTED] Performing Close on TemplateImportParametersForm...", Logger.MessageType.INF);
				SeleniumControl FAMACTED_TemplateImportParametersForm = new SeleniumControl( sDriver, "TemplateImportParametersForm", "xpath", "//div[translate(@id,'0123456789','')='pr__FAMACTED_TEMPLATEIMPORT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(FAMACTED_TemplateImportParametersForm);
IWebElement formBttn = FAMACTED_TemplateImportParametersForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
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
				Function.CurrentComponent = "FAMACTED";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAMACTED] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl FAMACTED_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(FAMACTED_MainForm);
IWebElement formBttn = FAMACTED_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

