 
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
    public class FAMASSET_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Manage Asset Master Information", "xpath","//div[@class='navItem'][.='Manage Asset Master Information']").Click();


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
				Function.CurrentComponent = "FAMASSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAMASSET] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl FAMASSET_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,FAMASSET_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAMASSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAMASSET] Performing VerifyExists on Identification_AssetNo...", Logger.MessageType.INF);
				SeleniumControl FAMASSET_Identification_AssetNo = new SeleniumControl( sDriver, "Identification_AssetNo", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='ASSET_ID']");
				Function.AssertEqual(true,FAMASSET_Identification_AssetNo.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAMASSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAMASSET] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl FAMASSET_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(FAMASSET_MainForm);
IWebElement formBttn = FAMASSET_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? FAMASSET_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
FAMASSET_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAMASSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAMASSET] Performing VerifyExist on MainForm_Table...", Logger.MessageType.INF);
				SeleniumControl FAMASSET_MainForm_Table = new SeleniumControl( sDriver, "MainForm_Table", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,FAMASSET_MainForm_Table.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAMASSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAMASSET] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl FAMASSET_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(FAMASSET_MainForm);
IWebElement formBttn = FAMASSET_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? FAMASSET_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
FAMASSET_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAMASSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAMASSET] Performing Select on MainForm_Tab...", Logger.MessageType.INF);
				SeleniumControl FAMASSET_MainForm_Tab = new SeleniumControl( sDriver, "MainForm_Tab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(FAMASSET_MainForm_Tab);
IWebElement mTab = FAMASSET_MainForm_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Desc Info").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAMASSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAMASSET] Performing VerifyExists on Identification_DescInfo_Template_TemplateNo...", Logger.MessageType.INF);
				SeleniumControl FAMASSET_Identification_DescInfo_Template_TemplateNo = new SeleniumControl( sDriver, "Identification_DescInfo_Template_TemplateNo", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='FA_TMPLT_ID']");
				Function.AssertEqual(true,FAMASSET_Identification_DescInfo_Template_TemplateNo.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAMASSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAMASSET] Performing Select on MainForm_Tab...", Logger.MessageType.INF);
				SeleniumControl FAMASSET_MainForm_Tab = new SeleniumControl( sDriver, "MainForm_Tab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(FAMASSET_MainForm_Tab);
IWebElement mTab = FAMASSET_MainForm_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Purch Info").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAMASSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAMASSET] Performing VerifyExists on Identification_PurchInfo_PurchaseOrder_PODate...", Logger.MessageType.INF);
				SeleniumControl FAMASSET_Identification_PurchInfo_PurchaseOrder_PODate = new SeleniumControl( sDriver, "Identification_PurchInfo_PurchaseOrder_PODate", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PO_DT']");
				Function.AssertEqual(true,FAMASSET_Identification_PurchInfo_PurchaseOrder_PODate.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAMASSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAMASSET] Performing Select on MainForm_Tab...", Logger.MessageType.INF);
				SeleniumControl FAMASSET_MainForm_Tab = new SeleniumControl( sDriver, "MainForm_Tab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(FAMASSET_MainForm_Tab);
IWebElement mTab = FAMASSET_MainForm_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Cost Info").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAMASSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAMASSET] Performing VerifyExists on Identification_CostInfo_Units_Quantity...", Logger.MessageType.INF);
				SeleniumControl FAMASSET_Identification_CostInfo_Units_Quantity = new SeleniumControl( sDriver, "Identification_CostInfo_Units_Quantity", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='UNITS_QTY_NO']");
				Function.AssertEqual(true,FAMASSET_Identification_CostInfo_Units_Quantity.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAMASSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAMASSET] Performing Select on MainForm_Tab...", Logger.MessageType.INF);
				SeleniumControl FAMASSET_MainForm_Tab = new SeleniumControl( sDriver, "MainForm_Tab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(FAMASSET_MainForm_Tab);
IWebElement mTab = FAMASSET_MainForm_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Loc Info").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAMASSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAMASSET] Performing VerifyExists on Identification_LocInfo_LocationGroupInfo_LocationGroup...", Logger.MessageType.INF);
				SeleniumControl FAMASSET_Identification_LocInfo_LocationGroupInfo_LocationGroup = new SeleniumControl( sDriver, "Identification_LocInfo_LocationGroupInfo_LocationGroup", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='FA_LOC_GRP_CD']");
				Function.AssertEqual(true,FAMASSET_Identification_LocInfo_LocationGroupInfo_LocationGroup.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAMASSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAMASSET] Performing Select on MainForm_Tab...", Logger.MessageType.INF);
				SeleniumControl FAMASSET_MainForm_Tab = new SeleniumControl( sDriver, "MainForm_Tab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(FAMASSET_MainForm_Tab);
IWebElement mTab = FAMASSET_MainForm_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Acct Info").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAMASSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAMASSET] Performing VerifyExists on Identification_AcctInfo_AssetAccount_AssetAccount...", Logger.MessageType.INF);
				SeleniumControl FAMASSET_Identification_AcctInfo_AssetAccount_AssetAccount = new SeleniumControl( sDriver, "Identification_AcctInfo_AssetAccount_AssetAccount", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='ACCT_ID']");
				Function.AssertEqual(true,FAMASSET_Identification_AcctInfo_AssetAccount_AssetAccount.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAMASSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAMASSET] Performing Select on MainForm_Tab...", Logger.MessageType.INF);
				SeleniumControl FAMASSET_MainForm_Tab = new SeleniumControl( sDriver, "MainForm_Tab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(FAMASSET_MainForm_Tab);
IWebElement mTab = FAMASSET_MainForm_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "G/L Book Info").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAMASSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAMASSET] Performing VerifyExists on Identification_GLBookInfo_DepreciationInformation_DeprMethodCode...", Logger.MessageType.INF);
				SeleniumControl FAMASSET_Identification_GLBookInfo_DepreciationInformation_DeprMethodCode = new SeleniumControl( sDriver, "Identification_GLBookInfo_DepreciationInformation_DeprMethodCode", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='B1_DEPR_MTHD_CD']");
				Function.AssertEqual(true,FAMASSET_Identification_GLBookInfo_DepreciationInformation_DeprMethodCode.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAMASSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAMASSET] Performing Select on MainForm_Tab...", Logger.MessageType.INF);
				SeleniumControl FAMASSET_MainForm_Tab = new SeleniumControl( sDriver, "MainForm_Tab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(FAMASSET_MainForm_Tab);
IWebElement mTab = FAMASSET_MainForm_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Govt Info").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAMASSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAMASSET] Performing VerifyExists on Identification_GovtInfo_NatStockNo...", Logger.MessageType.INF);
				SeleniumControl FAMASSET_Identification_GovtInfo_NatStockNo = new SeleniumControl( sDriver, "Identification_GovtInfo_NatStockNo", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='NSN_ID']");
				Function.AssertEqual(true,FAMASSET_Identification_GovtInfo_NatStockNo.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAMASSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAMASSET] Performing Select on MainForm_Tab...", Logger.MessageType.INF);
				SeleniumControl FAMASSET_MainForm_Tab = new SeleniumControl( sDriver, "MainForm_Tab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(FAMASSET_MainForm_Tab);
IWebElement mTab = FAMASSET_MainForm_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Disp Info").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAMASSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAMASSET] Performing VerifyExists on Identification_DispInfo_DisposalInfo_Date...", Logger.MessageType.INF);
				SeleniumControl FAMASSET_Identification_DispInfo_DisposalInfo_Date = new SeleniumControl( sDriver, "Identification_DispInfo_DisposalInfo_Date", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='DISP_DT']");
				Function.AssertEqual(true,FAMASSET_Identification_DispInfo_DisposalInfo_Date.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAMASSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAMASSET] Performing Select on MainForm_Tab...", Logger.MessageType.INF);
				SeleniumControl FAMASSET_MainForm_Tab = new SeleniumControl( sDriver, "MainForm_Tab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(FAMASSET_MainForm_Tab);
IWebElement mTab = FAMASSET_MainForm_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Notes").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAMASSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAMASSET] Performing VerifyExists on Identification_Notes_Notes...", Logger.MessageType.INF);
				SeleniumControl FAMASSET_Identification_Notes_Notes = new SeleniumControl( sDriver, "Identification_Notes_Notes", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='NOTES']");
				Function.AssertEqual(true,FAMASSET_Identification_Notes_Notes.Exists());

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
				Function.CurrentComponent = "FAMASSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAMASSET] Performing VerifyExists on Identification_OtherBooksInfoLink...", Logger.MessageType.INF);
				SeleniumControl FAMASSET_Identification_OtherBooksInfoLink = new SeleniumControl( sDriver, "Identification_OtherBooksInfoLink", "ID", "lnk_1004505_FAMASSET_ASSET_HDR");
				Function.AssertEqual(true,FAMASSET_Identification_OtherBooksInfoLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAMASSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAMASSET] Performing Click on Identification_OtherBooksInfoLink...", Logger.MessageType.INF);
				SeleniumControl FAMASSET_Identification_OtherBooksInfoLink = new SeleniumControl( sDriver, "Identification_OtherBooksInfoLink", "ID", "lnk_1004505_FAMASSET_ASSET_HDR");
				Function.WaitControlDisplayed(FAMASSET_Identification_OtherBooksInfoLink);
FAMASSET_Identification_OtherBooksInfoLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAMASSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAMASSET] Performing VerifyExists on OtherBooksInfoForm...", Logger.MessageType.INF);
				SeleniumControl FAMASSET_OtherBooksInfoForm = new SeleniumControl( sDriver, "OtherBooksInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__FAMASSET_ASSETOTHBKDEPR_']/ancestor::form[1]");
				Function.AssertEqual(true,FAMASSET_OtherBooksInfoForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAMASSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAMASSET] Performing Close on OtherBooksInfoForm...", Logger.MessageType.INF);
				SeleniumControl FAMASSET_OtherBooksInfoForm = new SeleniumControl( sDriver, "OtherBooksInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__FAMASSET_ASSETOTHBKDEPR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(FAMASSET_OtherBooksInfoForm);
IWebElement formBttn = FAMASSET_OtherBooksInfoForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAMASSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAMASSET] Performing VerifyExists on Identification_UserDefinedInfoLink...", Logger.MessageType.INF);
				SeleniumControl FAMASSET_Identification_UserDefinedInfoLink = new SeleniumControl( sDriver, "Identification_UserDefinedInfoLink", "ID", "lnk_1007547_FAMASSET_ASSET_HDR");
				Function.AssertEqual(true,FAMASSET_Identification_UserDefinedInfoLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAMASSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAMASSET] Performing Click on Identification_UserDefinedInfoLink...", Logger.MessageType.INF);
				SeleniumControl FAMASSET_Identification_UserDefinedInfoLink = new SeleniumControl( sDriver, "Identification_UserDefinedInfoLink", "ID", "lnk_1007547_FAMASSET_ASSET_HDR");
				Function.WaitControlDisplayed(FAMASSET_Identification_UserDefinedInfoLink);
FAMASSET_Identification_UserDefinedInfoLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAMASSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAMASSET] Performing VerifyExists on UserDefinedInfoForm...", Logger.MessageType.INF);
				SeleniumControl FAMASSET_UserDefinedInfoForm = new SeleniumControl( sDriver, "UserDefinedInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPMUDINF_UDEFLBL_CHLD_']/ancestor::form[1]");
				Function.AssertEqual(true,FAMASSET_UserDefinedInfoForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAMASSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAMASSET] Performing Close on UserDefinedInfoForm...", Logger.MessageType.INF);
				SeleniumControl FAMASSET_UserDefinedInfoForm = new SeleniumControl( sDriver, "UserDefinedInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPMUDINF_UDEFLBL_CHLD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(FAMASSET_UserDefinedInfoForm);
IWebElement formBttn = FAMASSET_UserDefinedInfoForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAMASSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAMASSET] Performing VerifyExists on Identification_DisposalDetailsByBookLink...", Logger.MessageType.INF);
				SeleniumControl FAMASSET_Identification_DisposalDetailsByBookLink = new SeleniumControl( sDriver, "Identification_DisposalDetailsByBookLink", "ID", "lnk_1003781_FAMASSET_ASSET_HDR");
				Function.AssertEqual(true,FAMASSET_Identification_DisposalDetailsByBookLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAMASSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAMASSET] Performing Click on Identification_DisposalDetailsByBookLink...", Logger.MessageType.INF);
				SeleniumControl FAMASSET_Identification_DisposalDetailsByBookLink = new SeleniumControl( sDriver, "Identification_DisposalDetailsByBookLink", "ID", "lnk_1003781_FAMASSET_ASSET_HDR");
				Function.WaitControlDisplayed(FAMASSET_Identification_DisposalDetailsByBookLink);
FAMASSET_Identification_DisposalDetailsByBookLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAMASSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAMASSET] Performing VerifyExists on DisposalDetailsByBookForm...", Logger.MessageType.INF);
				SeleniumControl FAMASSET_DisposalDetailsByBookForm = new SeleniumControl( sDriver, "DisposalDetailsByBookForm", "xpath", "//div[translate(@id,'0123456789','')='pr__FAMASSET_ASSETBOOKSDISP_OTBK_']/ancestor::form[1]");
				Function.AssertEqual(true,FAMASSET_DisposalDetailsByBookForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAMASSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAMASSET] Performing Close on DisposalDetailsByBookForm...", Logger.MessageType.INF);
				SeleniumControl FAMASSET_DisposalDetailsByBookForm = new SeleniumControl( sDriver, "DisposalDetailsByBookForm", "xpath", "//div[translate(@id,'0123456789','')='pr__FAMASSET_ASSETBOOKSDISP_OTBK_']/ancestor::form[1]");
				Function.WaitControlDisplayed(FAMASSET_DisposalDetailsByBookForm);
IWebElement formBttn = FAMASSET_DisposalDetailsByBookForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAMASSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAMASSET] Performing VerifyExists on Identification_TemplateImportParametersLink...", Logger.MessageType.INF);
				SeleniumControl FAMASSET_Identification_TemplateImportParametersLink = new SeleniumControl( sDriver, "Identification_TemplateImportParametersLink", "ID", "lnk_1003774_FAMASSET_ASSET_HDR");
				Function.AssertEqual(true,FAMASSET_Identification_TemplateImportParametersLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAMASSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAMASSET] Performing Click on Identification_TemplateImportParametersLink...", Logger.MessageType.INF);
				SeleniumControl FAMASSET_Identification_TemplateImportParametersLink = new SeleniumControl( sDriver, "Identification_TemplateImportParametersLink", "ID", "lnk_1003774_FAMASSET_ASSET_HDR");
				Function.WaitControlDisplayed(FAMASSET_Identification_TemplateImportParametersLink);
FAMASSET_Identification_TemplateImportParametersLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAMASSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAMASSET] Performing VerifyExists on TemplateImportParametersForm...", Logger.MessageType.INF);
				SeleniumControl FAMASSET_TemplateImportParametersForm = new SeleniumControl( sDriver, "TemplateImportParametersForm", "xpath", "//div[translate(@id,'0123456789','')='pr__FAMASSET_TEMPTINFO_']/ancestor::form[1]");
				Function.AssertEqual(true,FAMASSET_TemplateImportParametersForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAMASSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAMASSET] Performing Close on TemplateImportParametersForm...", Logger.MessageType.INF);
				SeleniumControl FAMASSET_TemplateImportParametersForm = new SeleniumControl( sDriver, "TemplateImportParametersForm", "xpath", "//div[translate(@id,'0123456789','')='pr__FAMASSET_TEMPTINFO_']/ancestor::form[1]");
				Function.WaitControlDisplayed(FAMASSET_TemplateImportParametersForm);
IWebElement formBttn = FAMASSET_TemplateImportParametersForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "FAMASSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAMASSET] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl FAMASSET_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(FAMASSET_MainForm);
IWebElement formBttn = FAMASSET_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

