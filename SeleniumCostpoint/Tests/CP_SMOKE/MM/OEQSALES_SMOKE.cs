 
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
    public class OEQSALES_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Sales Order Entry", "xpath","//div[@class='deptItem'][.='Sales Order Entry']").Click();
new SeleniumControl(sDriver,"Sales Order Entry Reports/Inquiries", "xpath","//div[@class='navItem'][.='Sales Order Entry Reports/Inquiries']").Click();
new SeleniumControl(sDriver,"View Sales Analysis Information", "xpath","//div[@class='navItem'][.='View Sales Analysis Information']").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SelectMenu]" , ex.Message));
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
				this.ScriptLogger.WriteLine("MAIN FORM");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEQSALES";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEQSALES] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl OEQSALES_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,OEQSALES_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEQSALES";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEQSALES] Performing VerifyExists on Project...", Logger.MessageType.INF);
				SeleniumControl OEQSALES_Project = new SeleniumControl( sDriver, "Project", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PROJ_ID']");
				Function.AssertEqual(true,OEQSALES_Project.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
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
				Function.CurrentComponent = "OEQSALES";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEQSALES] Performing VerifyExist on ChildFormTable...", Logger.MessageType.INF);
				SeleniumControl OEQSALES_ChildFormTable = new SeleniumControl( sDriver, "ChildFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__OEQSALES_SOHDR_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,OEQSALES_ChildFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEQSALES";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEQSALES] Performing ClickButton on ChildForm...", Logger.MessageType.INF);
				SeleniumControl OEQSALES_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEQSALES_SOHDR_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEQSALES_ChildForm);
IWebElement formBttn = OEQSALES_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? OEQSALES_ChildForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
OEQSALES_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEQSALES";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEQSALES] Performing VerifyExists on ChildForm_SalesOrder...", Logger.MessageType.INF);
				SeleniumControl OEQSALES_ChildForm_SalesOrder = new SeleniumControl( sDriver, "ChildForm_SalesOrder", "xpath", "//div[translate(@id,'0123456789','')='pr__OEQSALES_SOHDR_CTW_']/ancestor::form[1]/descendant::*[@id='SO_ID']");
				Function.AssertEqual(true,OEQSALES_ChildForm_SalesOrder.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("SALES ANALYSIS");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEQSALES";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEQSALES] Performing VerifyExists on ChildForm_SalesAnalysisLink...", Logger.MessageType.INF);
				SeleniumControl OEQSALES_ChildForm_SalesAnalysisLink = new SeleniumControl( sDriver, "ChildForm_SalesAnalysisLink", "ID", "lnk_1005236_OEQSALES_SOHDR_CTW");
				Function.AssertEqual(true,OEQSALES_ChildForm_SalesAnalysisLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEQSALES";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEQSALES] Performing Click on ChildForm_SalesAnalysisLink...", Logger.MessageType.INF);
				SeleniumControl OEQSALES_ChildForm_SalesAnalysisLink = new SeleniumControl( sDriver, "ChildForm_SalesAnalysisLink", "ID", "lnk_1005236_OEQSALES_SOHDR_CTW");
				Function.WaitControlDisplayed(OEQSALES_ChildForm_SalesAnalysisLink);
OEQSALES_ChildForm_SalesAnalysisLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEQSALES";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEQSALES] Performing VerifyExists on ChildForm_SalesAnalysis_RevenueCostFuncCurrency_Cost_Material...", Logger.MessageType.INF);
				SeleniumControl OEQSALES_ChildForm_SalesAnalysis_RevenueCostFuncCurrency_Cost_Material = new SeleniumControl( sDriver, "ChildForm_SalesAnalysis_RevenueCostFuncCurrency_Cost_Material", "xpath", "//div[translate(@id,'0123456789','')='pr__OEQSALES_SOINVCLN_']/ancestor::form[1]/descendant::*[@id='EXT_CST_AMT']");
				Function.AssertEqual(true,OEQSALES_ChildForm_SalesAnalysis_RevenueCostFuncCurrency_Cost_Material.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEQSALES";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEQSALES] Performing Close on ChildForm_SalesAnalysisForm...", Logger.MessageType.INF);
				SeleniumControl OEQSALES_ChildForm_SalesAnalysisForm = new SeleniumControl( sDriver, "ChildForm_SalesAnalysisForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEQSALES_SOINVCLN_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEQSALES_ChildForm_SalesAnalysisForm);
IWebElement formBttn = OEQSALES_ChildForm_SalesAnalysisForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("SALES ORDER LINES");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEQSALES";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEQSALES] Performing VerifyExists on ChildForm_SalesOrderLinesLink...", Logger.MessageType.INF);
				SeleniumControl OEQSALES_ChildForm_SalesOrderLinesLink = new SeleniumControl( sDriver, "ChildForm_SalesOrderLinesLink", "ID", "lnk_1005235_OEQSALES_SOHDR_CTW");
				Function.AssertEqual(true,OEQSALES_ChildForm_SalesOrderLinesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEQSALES";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEQSALES] Performing Click on ChildForm_SalesOrderLinesLink...", Logger.MessageType.INF);
				SeleniumControl OEQSALES_ChildForm_SalesOrderLinesLink = new SeleniumControl( sDriver, "ChildForm_SalesOrderLinesLink", "ID", "lnk_1005235_OEQSALES_SOHDR_CTW");
				Function.WaitControlDisplayed(OEQSALES_ChildForm_SalesOrderLinesLink);
OEQSALES_ChildForm_SalesOrderLinesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEQSALES";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEQSALES] Performing VerifyExist on ChildForm_SalesOrderLinesFormTable...", Logger.MessageType.INF);
				SeleniumControl OEQSALES_ChildForm_SalesOrderLinesFormTable = new SeleniumControl( sDriver, "ChildForm_SalesOrderLinesFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__OEQSALES_SOLN_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,OEQSALES_ChildForm_SalesOrderLinesFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEQSALES";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEQSALES] Performing ClickButton on ChildForm_SalesOrderLinesForm...", Logger.MessageType.INF);
				SeleniumControl OEQSALES_ChildForm_SalesOrderLinesForm = new SeleniumControl( sDriver, "ChildForm_SalesOrderLinesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEQSALES_SOLN_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEQSALES_ChildForm_SalesOrderLinesForm);
IWebElement formBttn = OEQSALES_ChildForm_SalesOrderLinesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? OEQSALES_ChildForm_SalesOrderLinesForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
OEQSALES_ChildForm_SalesOrderLinesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEQSALES";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEQSALES] Performing VerifyExists on ChildForm_SalesOrderLinesForm...", Logger.MessageType.INF);
				SeleniumControl OEQSALES_ChildForm_SalesOrderLinesForm = new SeleniumControl( sDriver, "ChildForm_SalesOrderLinesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEQSALES_SOLN_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,OEQSALES_ChildForm_SalesOrderLinesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEQSALES";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEQSALES] Performing VerifyExists on ChildForm_SalesOrderLines_LineDetails_SOLine...", Logger.MessageType.INF);
				SeleniumControl OEQSALES_ChildForm_SalesOrderLines_LineDetails_SOLine = new SeleniumControl( sDriver, "ChildForm_SalesOrderLines_LineDetails_SOLine", "xpath", "//div[translate(@id,'0123456789','')='pr__OEQSALES_SOLN_CTW_']/ancestor::form[1]/descendant::*[@id='SO_LN_NO']");
				Function.AssertEqual(true,OEQSALES_ChildForm_SalesOrderLines_LineDetails_SOLine.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEQSALES";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEQSALES] Performing Select on ChildForm_SalesOrderLines_SalesOrderLinesTab...", Logger.MessageType.INF);
				SeleniumControl OEQSALES_ChildForm_SalesOrderLines_SalesOrderLinesTab = new SeleniumControl( sDriver, "ChildForm_SalesOrderLines_SalesOrderLinesTab", "xpath", "//div[translate(@id,'0123456789','')='pr__OEQSALES_SOLN_CTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(OEQSALES_ChildForm_SalesOrderLines_SalesOrderLinesTab);
IWebElement mTab = OEQSALES_ChildForm_SalesOrderLines_SalesOrderLinesTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Order Status").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEQSALES";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEQSALES] Performing VerifyExists on ChildForm_SalesOrderLines_OrderStatus_QuantitySalesUM_Issued...", Logger.MessageType.INF);
				SeleniumControl OEQSALES_ChildForm_SalesOrderLines_OrderStatus_QuantitySalesUM_Issued = new SeleniumControl( sDriver, "ChildForm_SalesOrderLines_OrderStatus_QuantitySalesUM_Issued", "xpath", "//div[translate(@id,'0123456789','')='pr__OEQSALES_SOLN_CTW_']/ancestor::form[1]/descendant::*[@id='ISSUE_QTY']");
				Function.AssertEqual(true,OEQSALES_ChildForm_SalesOrderLines_OrderStatus_QuantitySalesUM_Issued.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEQSALES";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEQSALES] Performing Close on ChildForm_SalesOrderLinesForm...", Logger.MessageType.INF);
				SeleniumControl OEQSALES_ChildForm_SalesOrderLinesForm = new SeleniumControl( sDriver, "ChildForm_SalesOrderLinesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEQSALES_SOLN_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEQSALES_ChildForm_SalesOrderLinesForm);
IWebElement formBttn = OEQSALES_ChildForm_SalesOrderLinesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("EXCHANGE RATES");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEQSALES";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEQSALES] Performing VerifyExists on ChildForm_ExchangeRatesLink...", Logger.MessageType.INF);
				SeleniumControl OEQSALES_ChildForm_ExchangeRatesLink = new SeleniumControl( sDriver, "ChildForm_ExchangeRatesLink", "ID", "lnk_1005237_OEQSALES_SOHDR_CTW");
				Function.AssertEqual(true,OEQSALES_ChildForm_ExchangeRatesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEQSALES";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEQSALES] Performing Click on ChildForm_ExchangeRatesLink...", Logger.MessageType.INF);
				SeleniumControl OEQSALES_ChildForm_ExchangeRatesLink = new SeleniumControl( sDriver, "ChildForm_ExchangeRatesLink", "ID", "lnk_1005237_OEQSALES_SOHDR_CTW");
				Function.WaitControlDisplayed(OEQSALES_ChildForm_ExchangeRatesLink);
OEQSALES_ChildForm_ExchangeRatesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEQSALES";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEQSALES] Performing VerifyExists on ChildForm_ExchangeRatesForm...", Logger.MessageType.INF);
				SeleniumControl OEQSALES_ChildForm_ExchangeRatesForm = new SeleniumControl( sDriver, "ChildForm_ExchangeRatesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPM_SEXR_']/ancestor::form[1]");
				Function.AssertEqual(true,OEQSALES_ChildForm_ExchangeRatesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEQSALES";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEQSALES] Performing VerifyExists on ChildForm_ExchangeRates_TransactionCurrency...", Logger.MessageType.INF);
				SeleniumControl OEQSALES_ChildForm_ExchangeRates_TransactionCurrency = new SeleniumControl( sDriver, "ChildForm_ExchangeRates_TransactionCurrency", "xpath", "//div[translate(@id,'0123456789','')='pr__CPM_SEXR_']/ancestor::form[1]/descendant::*[@id='TRN_CRNCY_CD']");
				Function.AssertEqual(true,OEQSALES_ChildForm_ExchangeRates_TransactionCurrency.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEQSALES";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEQSALES] Performing Close on ChildForm_ExchangeRatesForm...", Logger.MessageType.INF);
				SeleniumControl OEQSALES_ChildForm_ExchangeRatesForm = new SeleniumControl( sDriver, "ChildForm_ExchangeRatesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPM_SEXR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEQSALES_ChildForm_ExchangeRatesForm);
IWebElement formBttn = OEQSALES_ChildForm_ExchangeRatesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("USER DEFINED INFO");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEQSALES";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEQSALES] Performing VerifyExists on ChildForm_UserDefinedInfoLink...", Logger.MessageType.INF);
				SeleniumControl OEQSALES_ChildForm_UserDefinedInfoLink = new SeleniumControl( sDriver, "ChildForm_UserDefinedInfoLink", "ID", "lnk_1007514_OEQSALES_SOHDR_CTW");
				Function.AssertEqual(true,OEQSALES_ChildForm_UserDefinedInfoLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEQSALES";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEQSALES] Performing Click on ChildForm_UserDefinedInfoLink...", Logger.MessageType.INF);
				SeleniumControl OEQSALES_ChildForm_UserDefinedInfoLink = new SeleniumControl( sDriver, "ChildForm_UserDefinedInfoLink", "ID", "lnk_1007514_OEQSALES_SOHDR_CTW");
				Function.WaitControlDisplayed(OEQSALES_ChildForm_UserDefinedInfoLink);
OEQSALES_ChildForm_UserDefinedInfoLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEQSALES";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEQSALES] Performing Close on ChildForm_UserDefinedInfoForm...", Logger.MessageType.INF);
				SeleniumControl OEQSALES_ChildForm_UserDefinedInfoForm = new SeleniumControl( sDriver, "ChildForm_UserDefinedInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEQSALES_USERDEFINEDINFO_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEQSALES_ChildForm_UserDefinedInfoForm);
IWebElement formBttn = OEQSALES_ChildForm_UserDefinedInfoForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("SO HEADER DOCUMENT");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEQSALES";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEQSALES] Performing VerifyExists on ChildForm_SOHeaderDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl OEQSALES_ChildForm_SOHeaderDocumentsLink = new SeleniumControl( sDriver, "ChildForm_SOHeaderDocumentsLink", "ID", "lnk_1007511_OEQSALES_SOHDR_CTW");
				Function.AssertEqual(true,OEQSALES_ChildForm_SOHeaderDocumentsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEQSALES";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEQSALES] Performing Click on ChildForm_SOHeaderDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl OEQSALES_ChildForm_SOHeaderDocumentsLink = new SeleniumControl( sDriver, "ChildForm_SOHeaderDocumentsLink", "ID", "lnk_1007511_OEQSALES_SOHDR_CTW");
				Function.WaitControlDisplayed(OEQSALES_ChildForm_SOHeaderDocumentsLink);
OEQSALES_ChildForm_SOHeaderDocumentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEQSALES";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEQSALES] Performing VerifyExist on ChildForm_SOHeaderDocumentsFormTable...", Logger.MessageType.INF);
				SeleniumControl OEQSALES_ChildForm_SOHeaderDocumentsFormTable = new SeleniumControl( sDriver, "ChildForm_SOHeaderDocumentsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__OEQSALES_DOCUMENTS_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,OEQSALES_ChildForm_SOHeaderDocumentsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEQSALES";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEQSALES] Performing ClickButton on ChildForm_SOHeaderDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl OEQSALES_ChildForm_SOHeaderDocumentsForm = new SeleniumControl( sDriver, "ChildForm_SOHeaderDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEQSALES_DOCUMENTS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEQSALES_ChildForm_SOHeaderDocumentsForm);
IWebElement formBttn = OEQSALES_ChildForm_SOHeaderDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? OEQSALES_ChildForm_SOHeaderDocumentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
OEQSALES_ChildForm_SOHeaderDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEQSALES";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEQSALES] Performing VerifyExists on ChildForm_SOHeaderDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl OEQSALES_ChildForm_SOHeaderDocumentsForm = new SeleniumControl( sDriver, "ChildForm_SOHeaderDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEQSALES_DOCUMENTS_']/ancestor::form[1]");
				Function.AssertEqual(true,OEQSALES_ChildForm_SOHeaderDocumentsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEQSALES";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEQSALES] Performing VerifyExists on ChildForm_SOHeaderDocument_Document...", Logger.MessageType.INF);
				SeleniumControl OEQSALES_ChildForm_SOHeaderDocument_Document = new SeleniumControl( sDriver, "ChildForm_SOHeaderDocument_Document", "xpath", "//div[translate(@id,'0123456789','')='pr__OEQSALES_DOCUMENTS_']/ancestor::form[1]/descendant::*[@id='DOCUMENT_ID']");
				Function.AssertEqual(true,OEQSALES_ChildForm_SOHeaderDocument_Document.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEQSALES";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEQSALES] Performing Close on ChildForm_SOHeaderDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl OEQSALES_ChildForm_SOHeaderDocumentsForm = new SeleniumControl( sDriver, "ChildForm_SOHeaderDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEQSALES_DOCUMENTS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEQSALES_ChildForm_SOHeaderDocumentsForm);
IWebElement formBttn = OEQSALES_ChildForm_SOHeaderDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
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
				Function.CurrentComponent = "OEQSALES";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEQSALES] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl OEQSALES_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(OEQSALES_MainForm);
IWebElement formBttn = OEQSALES_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

