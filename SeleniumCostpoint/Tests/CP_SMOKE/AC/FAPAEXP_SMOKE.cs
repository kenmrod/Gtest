 
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
    public class FAPAEXP_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Fixed Assets Interfaces", "xpath","//div[@class='navItem'][.='Fixed Assets Interfaces']").Click();
new SeleniumControl(sDriver,"Export Asset Records", "xpath","//div[@class='navItem'][.='Export Asset Records']").Click();


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
				Function.CurrentComponent = "FAPAEXP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAPAEXP] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl FAPAEXP_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,FAPAEXP_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAPAEXP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAPAEXP] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl FAPAEXP_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(FAPAEXP_MainForm);
IWebElement formBttn = FAPAEXP_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? FAPAEXP_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
FAPAEXP_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAPAEXP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAPAEXP] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl FAPAEXP_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,FAPAEXP_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAPAEXP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAPAEXP] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl FAPAEXP_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(FAPAEXP_MainForm);
IWebElement formBttn = FAPAEXP_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? FAPAEXP_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
FAPAEXP_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAPAEXP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAPAEXP] Performing VerifyExists on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl FAPAEXP_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.AssertEqual(true,FAPAEXP_MainFormTab.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAPAEXP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAPAEXP] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl FAPAEXP_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(FAPAEXP_MainFormTab);
IWebElement mTab = FAPAEXP_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Asset Selection").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAPAEXP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAPAEXP] Performing VerifyExists on AssetSelection_AssetSelection_IncludeAssetChangesFor_Additions...", Logger.MessageType.INF);
				SeleniumControl FAPAEXP_AssetSelection_AssetSelection_IncludeAssetChangesFor_Additions = new SeleniumControl( sDriver, "AssetSelection_AssetSelection_IncludeAssetChangesFor_Additions", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='INCL_ASSET_ADD_FL']");
				Function.AssertEqual(true,FAPAEXP_AssetSelection_AssetSelection_IncludeAssetChangesFor_Additions.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAPAEXP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAPAEXP] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl FAPAEXP_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(FAPAEXP_MainFormTab);
IWebElement mTab = FAPAEXP_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Export File Details").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAPAEXP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAPAEXP] Performing VerifyExists on ExportFileDetails_Generate_GenerateDisposalRecords_GenerateDisposalRecords...", Logger.MessageType.INF);
				SeleniumControl FAPAEXP_ExportFileDetails_Generate_GenerateDisposalRecords_GenerateDisposalRecords = new SeleniumControl( sDriver, "ExportFileDetails_Generate_GenerateDisposalRecords_GenerateDisposalRecords", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='GEN_DISP_FL']");
				Function.AssertEqual(true,FAPAEXP_ExportFileDetails_Generate_GenerateDisposalRecords_GenerateDisposalRecords.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAPAEXP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAPAEXP] Performing VerifyExists on AssetSelection_SelectedAssetMasterFieldsLink...", Logger.MessageType.INF);
				SeleniumControl FAPAEXP_AssetSelection_SelectedAssetMasterFieldsLink = new SeleniumControl( sDriver, "AssetSelection_SelectedAssetMasterFieldsLink", "ID", "lnk_15115_FAPAEXP_PARAM");
				Function.AssertEqual(true,FAPAEXP_AssetSelection_SelectedAssetMasterFieldsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAPAEXP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAPAEXP] Performing VerifyExists on AssetSelection_NonContiguousAssetListLink...", Logger.MessageType.INF);
				SeleniumControl FAPAEXP_AssetSelection_NonContiguousAssetListLink = new SeleniumControl( sDriver, "AssetSelection_NonContiguousAssetListLink", "ID", "lnk_15075_FAPAEXP_PARAM");
				Function.AssertEqual(true,FAPAEXP_AssetSelection_NonContiguousAssetListLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAPAEXP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAPAEXP] Performing VerifyExists on AssetSelection_AssetMasterAndDisposalDataRecordsLink...", Logger.MessageType.INF);
				SeleniumControl FAPAEXP_AssetSelection_AssetMasterAndDisposalDataRecordsLink = new SeleniumControl( sDriver, "AssetSelection_AssetMasterAndDisposalDataRecordsLink", "ID", "lnk_15073_FAPAEXP_PARAM");
				Function.AssertEqual(true,FAPAEXP_AssetSelection_AssetMasterAndDisposalDataRecordsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Selected Asset Master Fields");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAPAEXP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAPAEXP] Performing Click on AssetSelection_SelectedAssetMasterFieldsLink...", Logger.MessageType.INF);
				SeleniumControl FAPAEXP_AssetSelection_SelectedAssetMasterFieldsLink = new SeleniumControl( sDriver, "AssetSelection_SelectedAssetMasterFieldsLink", "ID", "lnk_15115_FAPAEXP_PARAM");
				Function.WaitControlDisplayed(FAPAEXP_AssetSelection_SelectedAssetMasterFieldsLink);
FAPAEXP_AssetSelection_SelectedAssetMasterFieldsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAPAEXP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAPAEXP] Performing VerifyExists on SelectedAssetMasterFields_AssetMasterFieldsForm...", Logger.MessageType.INF);
				SeleniumControl FAPAEXP_SelectedAssetMasterFields_AssetMasterFieldsForm = new SeleniumControl( sDriver, "SelectedAssetMasterFields_AssetMasterFieldsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__FAPAEXP_SFADBCOLDEF_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,FAPAEXP_SelectedAssetMasterFields_AssetMasterFieldsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAPAEXP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAPAEXP] Performing VerifyExist on SelectedAssetMasterFields_AssetMasterFieldsFormTable...", Logger.MessageType.INF);
				SeleniumControl FAPAEXP_SelectedAssetMasterFields_AssetMasterFieldsFormTable = new SeleniumControl( sDriver, "SelectedAssetMasterFields_AssetMasterFieldsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__FAPAEXP_SFADBCOLDEF_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,FAPAEXP_SelectedAssetMasterFields_AssetMasterFieldsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAPAEXP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAPAEXP] Performing VerifyExists on SelectedAssetMasterFields_SelectedAssetMasterFieldsForm...", Logger.MessageType.INF);
				SeleniumControl FAPAEXP_SelectedAssetMasterFields_SelectedAssetMasterFieldsForm = new SeleniumControl( sDriver, "SelectedAssetMasterFields_SelectedAssetMasterFieldsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__FAPAEXP_XZFAPAEXPPARM_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,FAPAEXP_SelectedAssetMasterFields_SelectedAssetMasterFieldsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAPAEXP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAPAEXP] Performing VerifyExist on SelectedAssetMasterFields_SelectedAssetMasterFieldsFormTable...", Logger.MessageType.INF);
				SeleniumControl FAPAEXP_SelectedAssetMasterFields_SelectedAssetMasterFieldsFormTable = new SeleniumControl( sDriver, "SelectedAssetMasterFields_SelectedAssetMasterFieldsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__FAPAEXP_XZFAPAEXPPARM_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,FAPAEXP_SelectedAssetMasterFields_SelectedAssetMasterFieldsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAPAEXP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAPAEXP] Performing Close on SelectedAssetMasterFields_SelectedAssetMasterFieldsForm...", Logger.MessageType.INF);
				SeleniumControl FAPAEXP_SelectedAssetMasterFields_SelectedAssetMasterFieldsForm = new SeleniumControl( sDriver, "SelectedAssetMasterFields_SelectedAssetMasterFieldsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__FAPAEXP_XZFAPAEXPPARM_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(FAPAEXP_SelectedAssetMasterFields_SelectedAssetMasterFieldsForm);
IWebElement formBttn = FAPAEXP_SelectedAssetMasterFields_SelectedAssetMasterFieldsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Non-Contiguous Asset List");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAPAEXP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAPAEXP] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl FAPAEXP_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(FAPAEXP_MainFormTab);
IWebElement mTab = FAPAEXP_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Asset Selection").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAPAEXP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAPAEXP] Performing Click on AssetSelection_NonContiguousAssetListLink...", Logger.MessageType.INF);
				SeleniumControl FAPAEXP_AssetSelection_NonContiguousAssetListLink = new SeleniumControl( sDriver, "AssetSelection_NonContiguousAssetListLink", "ID", "lnk_15075_FAPAEXP_PARAM");
				Function.WaitControlDisplayed(FAPAEXP_AssetSelection_NonContiguousAssetListLink);
FAPAEXP_AssetSelection_NonContiguousAssetListLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAPAEXP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAPAEXP] Performing VerifyExists on NonContiguousAssetList_NonContiguousAssetListForm...", Logger.MessageType.INF);
				SeleniumControl FAPAEXP_NonContiguousAssetList_NonContiguousAssetListForm = new SeleniumControl( sDriver, "NonContiguousAssetList_NonContiguousAssetListForm", "xpath", "//div[translate(@id,'0123456789','')='pr__FAPAEXP_NCR_ASSETID_ITEMNO_']/ancestor::form[1]");
				Function.AssertEqual(true,FAPAEXP_NonContiguousAssetList_NonContiguousAssetListForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAPAEXP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAPAEXP] Performing VerifyExist on NonContiguousAssetList_NonContiguousAssetListFormTable...", Logger.MessageType.INF);
				SeleniumControl FAPAEXP_NonContiguousAssetList_NonContiguousAssetListFormTable = new SeleniumControl( sDriver, "NonContiguousAssetList_NonContiguousAssetListFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__FAPAEXP_NCR_ASSETID_ITEMNO_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,FAPAEXP_NonContiguousAssetList_NonContiguousAssetListFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAPAEXP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAPAEXP] Performing Close on NonContiguousAssetList_NonContiguousAssetListForm...", Logger.MessageType.INF);
				SeleniumControl FAPAEXP_NonContiguousAssetList_NonContiguousAssetListForm = new SeleniumControl( sDriver, "NonContiguousAssetList_NonContiguousAssetListForm", "xpath", "//div[translate(@id,'0123456789','')='pr__FAPAEXP_NCR_ASSETID_ITEMNO_']/ancestor::form[1]");
				Function.WaitControlDisplayed(FAPAEXP_NonContiguousAssetList_NonContiguousAssetListForm);
IWebElement formBttn = FAPAEXP_NonContiguousAssetList_NonContiguousAssetListForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Asset Master and Disposal Data Records");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAPAEXP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAPAEXP] Performing Click on AssetSelection_AssetMasterAndDisposalDataRecordsLink...", Logger.MessageType.INF);
				SeleniumControl FAPAEXP_AssetSelection_AssetMasterAndDisposalDataRecordsLink = new SeleniumControl( sDriver, "AssetSelection_AssetMasterAndDisposalDataRecordsLink", "ID", "lnk_15073_FAPAEXP_PARAM");
				Function.WaitControlDisplayed(FAPAEXP_AssetSelection_AssetMasterAndDisposalDataRecordsLink);
FAPAEXP_AssetSelection_AssetMasterAndDisposalDataRecordsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAPAEXP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAPAEXP] Performing VerifyExists on AssetMasterAndDisposalDataRecordsForm...", Logger.MessageType.INF);
				SeleniumControl FAPAEXP_AssetMasterAndDisposalDataRecordsForm = new SeleniumControl( sDriver, "AssetMasterAndDisposalDataRecordsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__FAPAEXP_LN_']/ancestor::form[1]");
				Function.AssertEqual(true,FAPAEXP_AssetMasterAndDisposalDataRecordsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAPAEXP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAPAEXP] Performing VerifyExists on AssetMasterAndDisposalDataRecords_BatchID...", Logger.MessageType.INF);
				SeleniumControl FAPAEXP_AssetMasterAndDisposalDataRecords_BatchID = new SeleniumControl( sDriver, "AssetMasterAndDisposalDataRecords_BatchID", "xpath", "//div[translate(@id,'0123456789','')='pr__FAPAEXP_LN_']/ancestor::form[1]/descendant::*[@id='BATCH_ID']");
				Function.AssertEqual(true,FAPAEXP_AssetMasterAndDisposalDataRecords_BatchID.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAPAEXP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAPAEXP] Performing Click on AssetMasterAndDisposalDataRecords_ModifyViewDataForExport...", Logger.MessageType.INF);
				SeleniumControl FAPAEXP_AssetMasterAndDisposalDataRecords_ModifyViewDataForExport = new SeleniumControl( sDriver, "AssetMasterAndDisposalDataRecords_ModifyViewDataForExport", "xpath", "//div[translate(@id,'0123456789','')='pr__FAPAEXP_LN_']/ancestor::form[1]/descendant::*[contains(@id,'AB_MODIFY') and contains(@style,'visible')]");
				Function.WaitControlDisplayed(FAPAEXP_AssetMasterAndDisposalDataRecords_ModifyViewDataForExport);
if (FAPAEXP_AssetMasterAndDisposalDataRecords_ModifyViewDataForExport.mElement.GetAttribute("class") == "popupBtn" && sDriver.BrowserType == "ie")
FAPAEXP_AssetMasterAndDisposalDataRecords_ModifyViewDataForExport.Click(5,5);
else FAPAEXP_AssetMasterAndDisposalDataRecords_ModifyViewDataForExport.Click(4.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAPAEXP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAPAEXP] Performing VerifyExists on AssetMasterAndDisposalDataRecords_AssetMasterDataForm...", Logger.MessageType.INF);
				SeleniumControl FAPAEXP_AssetMasterAndDisposalDataRecords_AssetMasterDataForm = new SeleniumControl( sDriver, "AssetMasterAndDisposalDataRecords_AssetMasterDataForm", "xpath", "//div[starts-with(@id,'pr__FAPAEXP_XZFAPAEXPWRK1_CTW_')]/ancestor::form[1]");
				Function.AssertEqual(true,FAPAEXP_AssetMasterAndDisposalDataRecords_AssetMasterDataForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAPAEXP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAPAEXP] Performing VerifyExist on AssetMasterAndDisposalDataRecords_AssetMasterDataFormTable...", Logger.MessageType.INF);
				SeleniumControl FAPAEXP_AssetMasterAndDisposalDataRecords_AssetMasterDataFormTable = new SeleniumControl( sDriver, "AssetMasterAndDisposalDataRecords_AssetMasterDataFormTable", "xpath", "//div[starts-with(@id,'pr__FAPAEXP_XZFAPAEXPWRK1_CTW_')]/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,FAPAEXP_AssetMasterAndDisposalDataRecords_AssetMasterDataFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAPAEXP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAPAEXP] Performing ClickButton on AssetMasterAndDisposalDataRecords_AssetMasterDataForm...", Logger.MessageType.INF);
				SeleniumControl FAPAEXP_AssetMasterAndDisposalDataRecords_AssetMasterDataForm = new SeleniumControl( sDriver, "AssetMasterAndDisposalDataRecords_AssetMasterDataForm", "xpath", "//div[starts-with(@id,'pr__FAPAEXP_XZFAPAEXPWRK1_CTW_')]/ancestor::form[1]");
				Function.WaitControlDisplayed(FAPAEXP_AssetMasterAndDisposalDataRecords_AssetMasterDataForm);
IWebElement formBttn = FAPAEXP_AssetMasterAndDisposalDataRecords_AssetMasterDataForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? FAPAEXP_AssetMasterAndDisposalDataRecords_AssetMasterDataForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
FAPAEXP_AssetMasterAndDisposalDataRecords_AssetMasterDataForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAPAEXP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAPAEXP] Performing VerifyExists on AssetMasterAndDisposalDataRecords_AssetMasterData...", Logger.MessageType.INF);
				SeleniumControl FAPAEXP_AssetMasterAndDisposalDataRecords_AssetMasterData = new SeleniumControl( sDriver, "AssetMasterAndDisposalDataRecords_AssetMasterData", "xpath", "//div[starts-with(@id,'pr__FAPAEXP_XZFAPAEXPWRK1_CTW_')]/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.AssertEqual(true,FAPAEXP_AssetMasterAndDisposalDataRecords_AssetMasterData.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAPAEXP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAPAEXP] Performing Select on AssetMasterAndDisposalDataRecords_AssetMasterData...", Logger.MessageType.INF);
				SeleniumControl FAPAEXP_AssetMasterAndDisposalDataRecords_AssetMasterData = new SeleniumControl( sDriver, "AssetMasterAndDisposalDataRecords_AssetMasterData", "xpath", "//div[starts-with(@id,'pr__FAPAEXP_XZFAPAEXPWRK1_CTW_')]/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(FAPAEXP_AssetMasterAndDisposalDataRecords_AssetMasterData);
IWebElement mTab = FAPAEXP_AssetMasterAndDisposalDataRecords_AssetMasterData.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Asset Info").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAPAEXP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAPAEXP] Performing VerifyExists on AssetMasterAndDisposalDataRecords_AssetMasterData_AssetInfo_AssetNo...", Logger.MessageType.INF);
				SeleniumControl FAPAEXP_AssetMasterAndDisposalDataRecords_AssetMasterData_AssetInfo_AssetNo = new SeleniumControl( sDriver, "AssetMasterAndDisposalDataRecords_AssetMasterData_AssetInfo_AssetNo", "xpath", "//div[starts-with(@id,'pr__FAPAEXP_XZFAPAEXPWRK1_CTW_')]/ancestor::form[1]/descendant::*[@id='ASSET_ID']");
				Function.AssertEqual(true,FAPAEXP_AssetMasterAndDisposalDataRecords_AssetMasterData_AssetInfo_AssetNo.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAPAEXP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAPAEXP] Performing Select on AssetMasterAndDisposalDataRecords_AssetMasterData...", Logger.MessageType.INF);
				SeleniumControl FAPAEXP_AssetMasterAndDisposalDataRecords_AssetMasterData = new SeleniumControl( sDriver, "AssetMasterAndDisposalDataRecords_AssetMasterData", "xpath", "//div[starts-with(@id,'pr__FAPAEXP_XZFAPAEXPWRK1_CTW_')]/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(FAPAEXP_AssetMasterAndDisposalDataRecords_AssetMasterData);
IWebElement mTab = FAPAEXP_AssetMasterAndDisposalDataRecords_AssetMasterData.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "G/L Book Info").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAPAEXP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAPAEXP] Performing Select on AssetMasterAndDisposalDataRecords_AssetMasterData...", Logger.MessageType.INF);
				SeleniumControl FAPAEXP_AssetMasterAndDisposalDataRecords_AssetMasterData = new SeleniumControl( sDriver, "AssetMasterAndDisposalDataRecords_AssetMasterData", "xpath", "//div[starts-with(@id,'pr__FAPAEXP_XZFAPAEXPWRK1_CTW_')]/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(FAPAEXP_AssetMasterAndDisposalDataRecords_AssetMasterData);
IWebElement mTab = FAPAEXP_AssetMasterAndDisposalDataRecords_AssetMasterData.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Govt Info").FirstOrDefault();
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
				this.ScriptLogger.WriteLine("Disposal Data");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAPAEXP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAPAEXP] Performing VerifyExists on AssetMasterAndDisposalDataRecords_AssetMasterData_DisposalDataForm...", Logger.MessageType.INF);
				SeleniumControl FAPAEXP_AssetMasterAndDisposalDataRecords_AssetMasterData_DisposalDataForm = new SeleniumControl( sDriver, "AssetMasterAndDisposalDataRecords_AssetMasterData_DisposalDataForm", "xpath", "//div[starts-with(@id,'pr__FAPAEXP_XZFAPAEXPWRK2_CTW_')]/ancestor::form[1]");
				Function.AssertEqual(true,FAPAEXP_AssetMasterAndDisposalDataRecords_AssetMasterData_DisposalDataForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAPAEXP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAPAEXP] Performing VerifyExist on AssetMasterAndDisposalDataRecords_AssetMasterData_DisposalDataFormTable...", Logger.MessageType.INF);
				SeleniumControl FAPAEXP_AssetMasterAndDisposalDataRecords_AssetMasterData_DisposalDataFormTable = new SeleniumControl( sDriver, "AssetMasterAndDisposalDataRecords_AssetMasterData_DisposalDataFormTable", "xpath", "//div[starts-with(@id,'pr__FAPAEXP_XZFAPAEXPWRK2_CTW_')]/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,FAPAEXP_AssetMasterAndDisposalDataRecords_AssetMasterData_DisposalDataFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAPAEXP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAPAEXP] Performing ClickButton on AssetMasterAndDisposalDataRecords_AssetMasterData_DisposalDataForm...", Logger.MessageType.INF);
				SeleniumControl FAPAEXP_AssetMasterAndDisposalDataRecords_AssetMasterData_DisposalDataForm = new SeleniumControl( sDriver, "AssetMasterAndDisposalDataRecords_AssetMasterData_DisposalDataForm", "xpath", "//div[starts-with(@id,'pr__FAPAEXP_XZFAPAEXPWRK2_CTW_')]/ancestor::form[1]");
				Function.WaitControlDisplayed(FAPAEXP_AssetMasterAndDisposalDataRecords_AssetMasterData_DisposalDataForm);
IWebElement formBttn = FAPAEXP_AssetMasterAndDisposalDataRecords_AssetMasterData_DisposalDataForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? FAPAEXP_AssetMasterAndDisposalDataRecords_AssetMasterData_DisposalDataForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
FAPAEXP_AssetMasterAndDisposalDataRecords_AssetMasterData_DisposalDataForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAPAEXP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAPAEXP] Performing VerifyExists on AssetMasterAndDisposalDataRecords_AssetMasterData_DisposalData_AssetNo...", Logger.MessageType.INF);
				SeleniumControl FAPAEXP_AssetMasterAndDisposalDataRecords_AssetMasterData_DisposalData_AssetNo = new SeleniumControl( sDriver, "AssetMasterAndDisposalDataRecords_AssetMasterData_DisposalData_AssetNo", "xpath", "//div[starts-with(@id,'pr__FAPAEXP_XZFAPAEXPWRK2_CTW_')]/ancestor::form[1]/descendant::*[@id='ASSET_ID']");
				Function.AssertEqual(true,FAPAEXP_AssetMasterAndDisposalDataRecords_AssetMasterData_DisposalData_AssetNo.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAPAEXP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAPAEXP] Performing Close on AssetMasterAndDisposalDataRecordsForm...", Logger.MessageType.INF);
				SeleniumControl FAPAEXP_AssetMasterAndDisposalDataRecordsForm = new SeleniumControl( sDriver, "AssetMasterAndDisposalDataRecordsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__FAPAEXP_LN_']/ancestor::form[1]");
				Function.WaitControlDisplayed(FAPAEXP_AssetMasterAndDisposalDataRecordsForm);
IWebElement formBttn = FAPAEXP_AssetMasterAndDisposalDataRecordsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAPAEXP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAPAEXP] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl FAPAEXP_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(FAPAEXP_MainForm);
IWebElement formBttn = FAPAEXP_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

