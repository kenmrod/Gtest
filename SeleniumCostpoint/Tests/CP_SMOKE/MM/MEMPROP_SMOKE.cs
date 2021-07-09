 
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
    public class MEMPROP_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Materials Estimating", "xpath","//div[@class='deptItem'][.='Materials Estimating']").Click();
new SeleniumControl(sDriver,"Proposals", "xpath","//div[@class='navItem'][.='Proposals']").Click();
new SeleniumControl(sDriver,"Manage Proposals", "xpath","//div[@class='navItem'][.='Manage Proposals']").Click();


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
				Function.CurrentComponent = "MEMPROP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPROP] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl MEMPROP_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,MEMPROP_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPROP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPROP] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl MEMPROP_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(MEMPROP_MainForm);
IWebElement formBttn = MEMPROP_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? MEMPROP_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
MEMPROP_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPROP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPROP] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl MEMPROP_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,MEMPROP_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPROP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPROP] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl MEMPROP_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(MEMPROP_MainForm);
IWebElement formBttn = MEMPROP_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? MEMPROP_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
MEMPROP_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPROP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPROP] Performing VerifyExists on ProposalID...", Logger.MessageType.INF);
				SeleniumControl MEMPROP_ProposalID = new SeleniumControl( sDriver, "ProposalID", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PROP_ID']");
				Function.AssertEqual(true,MEMPROP_ProposalID.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPROP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPROP] Performing Select on Tab...", Logger.MessageType.INF);
				SeleniumControl MEMPROP_Tab = new SeleniumControl( sDriver, "Tab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(MEMPROP_Tab);
IWebElement mTab = MEMPROP_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Details").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPROP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPROP] Performing VerifyExists on Details_Status...", Logger.MessageType.INF);
				SeleniumControl MEMPROP_Details_Status = new SeleniumControl( sDriver, "Details_Status", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='S_PROP_STATUS_CD']");
				Function.AssertEqual(true,MEMPROP_Details_Status.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPROP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPROP] Performing Select on Tab...", Logger.MessageType.INF);
				SeleniumControl MEMPROP_Tab = new SeleniumControl( sDriver, "Tab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(MEMPROP_Tab);
IWebElement mTab = MEMPROP_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Request for Quote Defaults").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPROP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPROP] Performing VerifyExists on RequestForQuoteDefaults_Buyer...", Logger.MessageType.INF);
				SeleniumControl MEMPROP_RequestForQuoteDefaults_Buyer = new SeleniumControl( sDriver, "RequestForQuoteDefaults_Buyer", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='DFLT_BUYER_ID']");
				Function.AssertEqual(true,MEMPROP_RequestForQuoteDefaults_Buyer.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPROP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPROP] Performing Select on Tab...", Logger.MessageType.INF);
				SeleniumControl MEMPROP_Tab = new SeleniumControl( sDriver, "Tab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(MEMPROP_Tab);
IWebElement mTab = MEMPROP_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Costing Parameters").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPROP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPROP] Performing VerifyExists on CostingParameters_IncludeOrderQuoteCostsIfPOQtyIsGreaterThanBreakQty...", Logger.MessageType.INF);
				SeleniumControl MEMPROP_CostingParameters_IncludeOrderQuoteCostsIfPOQtyIsGreaterThanBreakQty = new SeleniumControl( sDriver, "CostingParameters_IncludeOrderQuoteCostsIfPOQtyIsGreaterThanBreakQty", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='INCL_GREATER_FL']");
				Function.AssertEqual(true,MEMPROP_CostingParameters_IncludeOrderQuoteCostsIfPOQtyIsGreaterThanBreakQty.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPROP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPROP] Performing Select on Tab...", Logger.MessageType.INF);
				SeleniumControl MEMPROP_Tab = new SeleniumControl( sDriver, "Tab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(MEMPROP_Tab);
IWebElement mTab = MEMPROP_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Notes").FirstOrDefault();
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
				this.ScriptLogger.WriteLine("Proposal End Item");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPROP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPROP] Performing VerifyExists on ProposalEndItemForm...", Logger.MessageType.INF);
				SeleniumControl MEMPROP_ProposalEndItemForm = new SeleniumControl( sDriver, "ProposalEndItemForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MEMPROP_PROPLN_PROPDTL_']/ancestor::form[1]");
				Function.AssertEqual(true,MEMPROP_ProposalEndItemForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPROP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPROP] Performing VerifyExist on ProposalEndItemFormTable...", Logger.MessageType.INF);
				SeleniumControl MEMPROP_ProposalEndItemFormTable = new SeleniumControl( sDriver, "ProposalEndItemFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__MEMPROP_PROPLN_PROPDTL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,MEMPROP_ProposalEndItemFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPROP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPROP] Performing ClickButton on ProposalEndItemForm...", Logger.MessageType.INF);
				SeleniumControl MEMPROP_ProposalEndItemForm = new SeleniumControl( sDriver, "ProposalEndItemForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MEMPROP_PROPLN_PROPDTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MEMPROP_ProposalEndItemForm);
IWebElement formBttn = MEMPROP_ProposalEndItemForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? MEMPROP_ProposalEndItemForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
MEMPROP_ProposalEndItemForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPROP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPROP] Performing VerifyExists on ProposedEndItem_Line...", Logger.MessageType.INF);
				SeleniumControl MEMPROP_ProposedEndItem_Line = new SeleniumControl( sDriver, "ProposedEndItem_Line", "xpath", "//div[translate(@id,'0123456789','')='pr__MEMPROP_PROPLN_PROPDTL_']/ancestor::form[1]/descendant::*[@id='PROP_LN_NO']");
				Function.AssertEqual(true,MEMPROP_ProposedEndItem_Line.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Autoload Catalog");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPROP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPROP] Performing VerifyExists on ProposedEndItem_AutoloadCatalogLink...", Logger.MessageType.INF);
				SeleniumControl MEMPROP_ProposedEndItem_AutoloadCatalogLink = new SeleniumControl( sDriver, "ProposedEndItem_AutoloadCatalogLink", "ID", "lnk_1001603_MEMPROP_PROPLN_PROPDTL");
				Function.AssertEqual(true,MEMPROP_ProposedEndItem_AutoloadCatalogLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPROP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPROP] Performing Click on ProposedEndItem_AutoloadCatalogLink...", Logger.MessageType.INF);
				SeleniumControl MEMPROP_ProposedEndItem_AutoloadCatalogLink = new SeleniumControl( sDriver, "ProposedEndItem_AutoloadCatalogLink", "ID", "lnk_1001603_MEMPROP_PROPLN_PROPDTL");
				Function.WaitControlDisplayed(MEMPROP_ProposedEndItem_AutoloadCatalogLink);
MEMPROP_ProposedEndItem_AutoloadCatalogLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPROP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPROP] Performing VerifyExists on AutoloadCatalogForm...", Logger.MessageType.INF);
				SeleniumControl MEMPROP_AutoloadCatalogForm = new SeleniumControl( sDriver, "AutoloadCatalogForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MEMPROP_CATALOG_AUTOCATALOG_']/ancestor::form[1]");
				Function.AssertEqual(true,MEMPROP_AutoloadCatalogForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPROP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPROP] Performing VerifyExists on AutoloadCatalog_Catalog...", Logger.MessageType.INF);
				SeleniumControl MEMPROP_AutoloadCatalog_Catalog = new SeleniumControl( sDriver, "AutoloadCatalog_Catalog", "xpath", "//div[translate(@id,'0123456789','')='pr__MEMPROP_CATALOG_AUTOCATALOG_']/ancestor::form[1]/descendant::*[@id='CATALOG_ID']");
				Function.AssertEqual(true,MEMPROP_AutoloadCatalog_Catalog.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPROP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPROP] Performing Close on AutoloadCatalogForm...", Logger.MessageType.INF);
				SeleniumControl MEMPROP_AutoloadCatalogForm = new SeleniumControl( sDriver, "AutoloadCatalogForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MEMPROP_CATALOG_AUTOCATALOG_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MEMPROP_AutoloadCatalogForm);
IWebElement formBttn = MEMPROP_AutoloadCatalogForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Autoload CLIN");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPROP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPROP] Performing VerifyExists on ProposedEndItem_AutoloadCLINLink...", Logger.MessageType.INF);
				SeleniumControl MEMPROP_ProposedEndItem_AutoloadCLINLink = new SeleniumControl( sDriver, "ProposedEndItem_AutoloadCLINLink", "ID", "lnk_1001604_MEMPROP_PROPLN_PROPDTL");
				Function.AssertEqual(true,MEMPROP_ProposedEndItem_AutoloadCLINLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPROP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPROP] Performing Click on ProposedEndItem_AutoloadCLINLink...", Logger.MessageType.INF);
				SeleniumControl MEMPROP_ProposedEndItem_AutoloadCLINLink = new SeleniumControl( sDriver, "ProposedEndItem_AutoloadCLINLink", "ID", "lnk_1001604_MEMPROP_PROPLN_PROPDTL");
				Function.WaitControlDisplayed(MEMPROP_ProposedEndItem_AutoloadCLINLink);
MEMPROP_ProposedEndItem_AutoloadCLINLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPROP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPROP] Performing VerifyExists on AutoloadCLINForm...", Logger.MessageType.INF);
				SeleniumControl MEMPROP_AutoloadCLINForm = new SeleniumControl( sDriver, "AutoloadCLINForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MEMPROP_CLIN_AUTOLOAD_CLIN_']/ancestor::form[1]");
				Function.AssertEqual(true,MEMPROP_AutoloadCLINForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPROP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPROP] Performing VerifyExists on AutoloadCLIN_Project...", Logger.MessageType.INF);
				SeleniumControl MEMPROP_AutoloadCLIN_Project = new SeleniumControl( sDriver, "AutoloadCLIN_Project", "xpath", "//div[translate(@id,'0123456789','')='pr__MEMPROP_CLIN_AUTOLOAD_CLIN_']/ancestor::form[1]/descendant::*[@id='PROJ_ID']");
				Function.AssertEqual(true,MEMPROP_AutoloadCLIN_Project.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPROP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPROP] Performing Close on AutoloadCLINForm...", Logger.MessageType.INF);
				SeleniumControl MEMPROP_AutoloadCLINForm = new SeleniumControl( sDriver, "AutoloadCLINForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MEMPROP_CLIN_AUTOLOAD_CLIN_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MEMPROP_AutoloadCLINForm);
IWebElement formBttn = MEMPROP_AutoloadCLINForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Create Provisional Part");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPROP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPROP] Performing VerifyExists on ProposedEndItem_CreateProvisionalPartLink...", Logger.MessageType.INF);
				SeleniumControl MEMPROP_ProposedEndItem_CreateProvisionalPartLink = new SeleniumControl( sDriver, "ProposedEndItem_CreateProvisionalPartLink", "ID", "lnk_4965_MEMPROP_PROPLN_PROPDTL");
				Function.AssertEqual(true,MEMPROP_ProposedEndItem_CreateProvisionalPartLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPROP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPROP] Performing Click on ProposedEndItem_CreateProvisionalPartLink...", Logger.MessageType.INF);
				SeleniumControl MEMPROP_ProposedEndItem_CreateProvisionalPartLink = new SeleniumControl( sDriver, "ProposedEndItem_CreateProvisionalPartLink", "ID", "lnk_4965_MEMPROP_PROPLN_PROPDTL");
				Function.WaitControlDisplayed(MEMPROP_ProposedEndItem_CreateProvisionalPartLink);
MEMPROP_ProposedEndItem_CreateProvisionalPartLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPROP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPROP] Performing VerifyExists on CreateProvisionalPartForm...", Logger.MessageType.INF);
				SeleniumControl MEMPROP_CreateProvisionalPartForm = new SeleniumControl( sDriver, "CreateProvisionalPartForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMEBOM_CREATE_PROVPART_']/ancestor::form[1]");
				Function.AssertEqual(true,MEMPROP_CreateProvisionalPartForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPROP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPROP] Performing VerifyExists on CreateProvisionalPart_PartID...", Logger.MessageType.INF);
				SeleniumControl MEMPROP_CreateProvisionalPart_PartID = new SeleniumControl( sDriver, "CreateProvisionalPart_PartID", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMEBOM_CREATE_PROVPART_']/ancestor::form[1]/descendant::*[@id='PROV_PART_ID']");
				Function.AssertEqual(true,MEMPROP_CreateProvisionalPart_PartID.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPROP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPROP] Performing Close on CreateProvisionalPartForm...", Logger.MessageType.INF);
				SeleniumControl MEMPROP_CreateProvisionalPartForm = new SeleniumControl( sDriver, "CreateProvisionalPartForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMEBOM_CREATE_PROVPART_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MEMPROP_CreateProvisionalPartForm);
IWebElement formBttn = MEMPROP_CreateProvisionalPartForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Closing Main");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPROP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPROP] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl MEMPROP_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(MEMPROP_MainForm);
IWebElement formBttn = MEMPROP_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "Dialog";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));
Function.ClickOkDialogWithMessage("You have unsaved changes. Select Cancel to go back and save changes or select OK to discard changes and close this application.");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickOkDialogWithMessage]" , ex.Message));
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

