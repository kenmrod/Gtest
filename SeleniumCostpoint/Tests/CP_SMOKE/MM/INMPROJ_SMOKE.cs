 
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
    public class INMPROJ_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Inventory Controls", "xpath","//div[@class='navItem'][.='Inventory Controls']").Click();
new SeleniumControl(sDriver,"Manage Inventory Projects", "xpath","//div[@class='navItem'][.='Manage Inventory Projects']").Click();


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
				Function.CurrentComponent = "INMPROJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPROJ] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl INMPROJ_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,INMPROJ_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPROJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPROJ] Performing VerifyExists on InventoryProjectID...", Logger.MessageType.INF);
				SeleniumControl INMPROJ_InventoryProjectID = new SeleniumControl( sDriver, "InventoryProjectID", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PROJ_ID']");
				Function.AssertEqual(true,INMPROJ_InventoryProjectID.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Query");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPROJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPROJ] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl INMPROJ_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(INMPROJ_MainForm);
IWebElement formBttn = INMPROJ_MainForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).Count <= 0 ? INMPROJ_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Query')]")).FirstOrDefault() :
INMPROJ_MainForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).FirstOrDefault();
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
				Function.CurrentComponent = "INMPROJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPROJ] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl INMPROJ_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,INMPROJ_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPROJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPROJ] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl INMPROJ_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(INMPROJ_MainForm);
IWebElement formBttn = INMPROJ_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? INMPROJ_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
INMPROJ_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("InventoryProjectTab");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPROJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPROJ] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl INMPROJ_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(INMPROJ_MainFormTab);
IWebElement mTab = INMPROJ_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Inventory / Material Planning").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPROJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPROJ] Performing VerifyExists on InventoryMaterialPlanning_InventoryOptions_IssueAdjustmentsControls_NoIssueAdjOutsideProjectAllowed...", Logger.MessageType.INF);
				SeleniumControl INMPROJ_InventoryMaterialPlanning_InventoryOptions_IssueAdjustmentsControls_NoIssueAdjOutsideProjectAllowed = new SeleniumControl( sDriver, "InventoryMaterialPlanning_InventoryOptions_IssueAdjustmentsControls_NoIssueAdjOutsideProjectAllowed", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='S_INTR_PROJ_ISS_CD' and @value='N']");
				Function.AssertEqual(true,INMPROJ_InventoryMaterialPlanning_InventoryOptions_IssueAdjustmentsControls_NoIssueAdjOutsideProjectAllowed.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPROJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPROJ] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl INMPROJ_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(INMPROJ_MainFormTab);
IWebElement mTab = INMPROJ_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Average Actual Accounts").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPROJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPROJ] Performing VerifyExists on AverageActualAccounts_AssetInventoryAbbreviations_RawMaterialAssetContra_Account...", Logger.MessageType.INF);
				SeleniumControl INMPROJ_AverageActualAccounts_AssetInventoryAbbreviations_RawMaterialAssetContra_Account = new SeleniumControl( sDriver, "AverageActualAccounts_AssetInventoryAbbreviations_RawMaterialAssetContra_Account", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='RM_CONTRA_ACCT_ID']");
				Function.AssertEqual(true,INMPROJ_AverageActualAccounts_AssetInventoryAbbreviations_RawMaterialAssetContra_Account.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPROJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPROJ] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl INMPROJ_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(INMPROJ_MainFormTab);
IWebElement mTab = INMPROJ_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Project Manufacturing").FirstOrDefault();
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
				this.ScriptLogger.WriteLine("InventoryAbbreviationsLink");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPROJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPROJ] Performing VerifyExists on InventoryAbbreviationsLink...", Logger.MessageType.INF);
				SeleniumControl INMPROJ_InventoryAbbreviationsLink = new SeleniumControl( sDriver, "InventoryAbbreviationsLink", "ID", "lnk_1001707_INMPROJ_INVTPROJ");
				Function.AssertEqual(true,INMPROJ_InventoryAbbreviationsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPROJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPROJ] Performing Click on InventoryAbbreviationsLink...", Logger.MessageType.INF);
				SeleniumControl INMPROJ_InventoryAbbreviationsLink = new SeleniumControl( sDriver, "InventoryAbbreviationsLink", "ID", "lnk_1001707_INMPROJ_INVTPROJ");
				Function.WaitControlDisplayed(INMPROJ_InventoryAbbreviationsLink);
INMPROJ_InventoryAbbreviationsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPROJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPROJ] Performing VerifyExist on InventoryAbbreviationTable...", Logger.MessageType.INF);
				SeleniumControl INMPROJ_InventoryAbbreviationTable = new SeleniumControl( sDriver, "InventoryAbbreviationTable", "xpath", "//div[translate(@id,'0123456789','')='pr__INMPROJ_INVTABBRVCD_INVENTPROJ_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,INMPROJ_InventoryAbbreviationTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPROJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPROJ] Performing VerifyExists on InventoryAbbreviationForm...", Logger.MessageType.INF);
				SeleniumControl INMPROJ_InventoryAbbreviationForm = new SeleniumControl( sDriver, "InventoryAbbreviationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__INMPROJ_INVTABBRVCD_INVENTPROJ_']/ancestor::form[1]");
				Function.AssertEqual(true,INMPROJ_InventoryAbbreviationForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPROJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPROJ] Performing ClickButtonIfExists on InventoryAbbreviationForm...", Logger.MessageType.INF);
				SeleniumControl INMPROJ_InventoryAbbreviationForm = new SeleniumControl( sDriver, "InventoryAbbreviationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__INMPROJ_INVTABBRVCD_INVENTPROJ_']/ancestor::form[1]");
				Function.WaitControlDisplayed(INMPROJ_InventoryAbbreviationForm);
IWebElement formBttn = INMPROJ_InventoryAbbreviationForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? INMPROJ_InventoryAbbreviationForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
INMPROJ_InventoryAbbreviationForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault();
if (formBttn!=null && formBttn.Displayed)
{ new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click();
this.ScriptLogger.WriteLine("Button [Form] found and clicked.", Logger.MessageType.INF);
}


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButtonIfExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPROJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPROJ] Performing VerifyExists on InventoryAbbreviation_InventoryAbbreviationCode...", Logger.MessageType.INF);
				SeleniumControl INMPROJ_InventoryAbbreviation_InventoryAbbreviationCode = new SeleniumControl( sDriver, "InventoryAbbreviation_InventoryAbbreviationCode", "xpath", "//div[translate(@id,'0123456789','')='pr__INMPROJ_INVTABBRVCD_INVENTPROJ_']/ancestor::form[1]/descendant::*[@id='INVT_ABBRV_CD']");
				Function.AssertEqual(true,INMPROJ_InventoryAbbreviation_InventoryAbbreviationCode.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("InventoryAbbreviationsTab");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPROJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPROJ] Performing Select on InventoryAbbreviation_InventoryAbbreviationTab...", Logger.MessageType.INF);
				SeleniumControl INMPROJ_InventoryAbbreviation_InventoryAbbreviationTab = new SeleniumControl( sDriver, "InventoryAbbreviation_InventoryAbbreviationTab", "xpath", "//div[translate(@id,'0123456789','')='pr__INMPROJ_INVTABBRVCD_INVENTPROJ_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(INMPROJ_InventoryAbbreviation_InventoryAbbreviationTab);
IWebElement mTab = INMPROJ_InventoryAbbreviation_InventoryAbbreviationTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Inventory Abbreviation").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPROJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPROJ] Performing VerifyExists on InventoryAbbreviation_InventoryAbbreviation_AccountType...", Logger.MessageType.INF);
				SeleniumControl INMPROJ_InventoryAbbreviation_InventoryAbbreviation_AccountType = new SeleniumControl( sDriver, "InventoryAbbreviation_InventoryAbbreviation_AccountType", "xpath", "//div[translate(@id,'0123456789','')='pr__INMPROJ_INVTABBRVCD_INVENTPROJ_']/ancestor::form[1]/descendant::*[@id='S_INVT_ACCT_TYPE']");
				Function.AssertEqual(true,INMPROJ_InventoryAbbreviation_InventoryAbbreviation_AccountType.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPROJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPROJ] Performing Select on InventoryAbbreviation_InventoryAbbreviationTab...", Logger.MessageType.INF);
				SeleniumControl INMPROJ_InventoryAbbreviation_InventoryAbbreviationTab = new SeleniumControl( sDriver, "InventoryAbbreviation_InventoryAbbreviationTab", "xpath", "//div[translate(@id,'0123456789','')='pr__INMPROJ_INVTABBRVCD_INVENTPROJ_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(INMPROJ_InventoryAbbreviation_InventoryAbbreviationTab);
IWebElement mTab = INMPROJ_InventoryAbbreviation_InventoryAbbreviationTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Accounts/Organizations").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPROJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPROJ] Performing VerifyExists on InventoryAbbreviation_AccountsOrganizations_Standard_Account_Material...", Logger.MessageType.INF);
				SeleniumControl INMPROJ_InventoryAbbreviation_AccountsOrganizations_Standard_Account_Material = new SeleniumControl( sDriver, "InventoryAbbreviation_AccountsOrganizations_Standard_Account_Material", "xpath", "//div[translate(@id,'0123456789','')='pr__INMPROJ_INVTABBRVCD_INVENTPROJ_']/ancestor::form[1]/descendant::*[@id='MATL_ACCT_ID']");
				Function.AssertEqual(true,INMPROJ_InventoryAbbreviation_AccountsOrganizations_Standard_Account_Material.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPROJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPROJ] Performing Close on InventoryAbbreviationForm...", Logger.MessageType.INF);
				SeleniumControl INMPROJ_InventoryAbbreviationForm = new SeleniumControl( sDriver, "InventoryAbbreviationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__INMPROJ_INVTABBRVCD_INVENTPROJ_']/ancestor::form[1]");
				Function.WaitControlDisplayed(INMPROJ_InventoryAbbreviationForm);
IWebElement formBttn = INMPROJ_InventoryAbbreviationForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "INMPROJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPROJ] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl INMPROJ_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(INMPROJ_MainForm);
IWebElement formBttn = INMPROJ_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

