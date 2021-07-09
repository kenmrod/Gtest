 
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
    public class BLMPROGP_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Projects", "xpath","//div[@class='busItem'][.='Projects']").Click();
new SeleniumControl(sDriver,"Billing", "xpath","//div[@class='deptItem'][.='Billing']").Click();
new SeleniumControl(sDriver,"Progress Payment Bills Processing", "xpath","//div[@class='navItem'][.='Progress Payment Bills Processing']").Click();
new SeleniumControl(sDriver,"Manage Progress Payment Bills", "xpath","//div[@class='navItem'][.='Manage Progress Payment Bills']").Click();


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
				Function.CurrentComponent = "Query";
								Function.WaitControlDisplayed(new SeleniumControl(sDriver,"QueryTitle", "ID", "qryHeaderLabel"));
Function.AssertEqual("Manage Progress Payment Bills", new SeleniumControl(sDriver,"QueryTitle", "ID", "qryHeaderLabel").GetValue().Trim());


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyTitle]" , ex.Message));
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
				Function.CurrentComponent = "BLMPROGP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPROGP] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl BLMPROGP_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(BLMPROGP_MainForm);
IWebElement formBttn = BLMPROGP_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? BLMPROGP_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
BLMPROGP_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPROGP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPROGP] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl BLMPROGP_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,BLMPROGP_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPROGP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPROGP] Performing VerifyExists on ProgressPaymentProject_Project...", Logger.MessageType.INF);
				SeleniumControl BLMPROGP_ProgressPaymentProject_Project = new SeleniumControl( sDriver, "ProgressPaymentProject_Project", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PROJ_ID']");
				Function.AssertEqual(true,BLMPROGP_ProgressPaymentProject_Project.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPROGP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPROGP] Performing Select on MainTab...", Logger.MessageType.INF);
				SeleniumControl BLMPROGP_MainTab = new SeleniumControl( sDriver, "MainTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(BLMPROGP_MainTab);
IWebElement mTab = BLMPROGP_MainTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Billing Details").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPROGP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPROGP] Performing VerifyExists on BillingDetails_Customer...", Logger.MessageType.INF);
				SeleniumControl BLMPROGP_BillingDetails_Customer = new SeleniumControl( sDriver, "BillingDetails_Customer", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='CUST_ID']");
				Function.AssertEqual(true,BLMPROGP_BillingDetails_Customer.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPROGP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPROGP] Performing Select on MainTab...", Logger.MessageType.INF);
				SeleniumControl BLMPROGP_MainTab = new SeleniumControl( sDriver, "MainTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(BLMPROGP_MainTab);
IWebElement mTab = BLMPROGP_MainTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Section 1; Box 1").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPROGP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPROGP] Performing VerifyExists on Section1Box1_ContractingOffice_Address...", Logger.MessageType.INF);
				SeleniumControl BLMPROGP_Section1Box1_ContractingOffice_Address = new SeleniumControl( sDriver, "Section1Box1_ContractingOffice_Address", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='BILL_ADDR_CD']");
				Function.AssertEqual(true,BLMPROGP_Section1Box1_ContractingOffice_Address.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPROGP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPROGP] Performing Select on MainTab...", Logger.MessageType.INF);
				SeleniumControl BLMPROGP_MainTab = new SeleniumControl( sDriver, "MainTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(BLMPROGP_MainTab);
IWebElement mTab = BLMPROGP_MainTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Section 1; Box 2").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPROGP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPROGP] Performing VerifyExists on Section1Box2_Contractor_Address...", Logger.MessageType.INF);
				SeleniumControl BLMPROGP_Section1Box2_Contractor_Address = new SeleniumControl( sDriver, "Section1Box2_Contractor_Address", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='BILL_RMT_ADDR_CD']");
				Function.AssertEqual(true,BLMPROGP_Section1Box2_Contractor_Address.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPROGP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPROGP] Performing Select on MainTab...", Logger.MessageType.INF);
				SeleniumControl BLMPROGP_MainTab = new SeleniumControl( sDriver, "MainTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(BLMPROGP_MainTab);
IWebElement mTab = BLMPROGP_MainTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Section 1; Box 3-8").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPROGP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPROGP] Performing VerifyExists on Section1Box38_ContractInformation_3SmallBus...", Logger.MessageType.INF);
				SeleniumControl BLMPROGP_Section1Box38_ContractInformation_3SmallBus = new SeleniumControl( sDriver, "Section1Box38_ContractInformation_3SmallBus", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='SMALL_BUS_FL']");
				Function.AssertEqual(true,BLMPROGP_Section1Box38_ContractInformation_3SmallBus.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPROGP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPROGP] Performing Select on MainTab...", Logger.MessageType.INF);
				SeleniumControl BLMPROGP_MainTab = new SeleniumControl( sDriver, "MainTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(BLMPROGP_MainTab);
IWebElement mTab = BLMPROGP_MainTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Line Info 9-19").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPROGP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPROGP] Performing VerifyExists on LineInfo919_Amount_Line9RESERVED...", Logger.MessageType.INF);
				SeleniumControl BLMPROGP_LineInfo919_Amount_Line9RESERVED = new SeleniumControl( sDriver, "LineInfo919_Amount_Line9RESERVED", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='LINE_9_AMT1']");
				Function.AssertEqual(true,BLMPROGP_LineInfo919_Amount_Line9RESERVED.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPROGP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPROGP] Performing Select on MainTab...", Logger.MessageType.INF);
				SeleniumControl BLMPROGP_MainTab = new SeleniumControl( sDriver, "MainTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(BLMPROGP_MainTab);
IWebElement mTab = BLMPROGP_MainTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Line Info 20-26").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPROGP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPROGP] Performing VerifyExists on LineInfo2026_Amount_Line20aCOSTSAPPLICABLETOITEMSDELIVEREDINVOICEDANDACCEPTED...", Logger.MessageType.INF);
				SeleniumControl BLMPROGP_LineInfo2026_Amount_Line20aCOSTSAPPLICABLETOITEMSDELIVEREDINVOICEDANDACCEPTED = new SeleniumControl( sDriver, "LineInfo2026_Amount_Line20aCOSTSAPPLICABLETOITEMSDELIVEREDINVOICEDANDACCEPTED", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='LINE_20A_AMT']");
				Function.AssertEqual(true,BLMPROGP_LineInfo2026_Amount_Line20aCOSTSAPPLICABLETOITEMSDELIVEREDINVOICEDANDACCEPTED.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPROGP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPROGP] Performing Select on MainTab...", Logger.MessageType.INF);
				SeleniumControl BLMPROGP_MainTab = new SeleniumControl( sDriver, "MainTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(BLMPROGP_MainTab);
IWebElement mTab = BLMPROGP_MainTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Line 13 Costs").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPROGP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPROGP] Performing VerifyExists on Line13Costs_EstimatedTotalCostsLine12aPlus12b...", Logger.MessageType.INF);
				SeleniumControl BLMPROGP_Line13Costs_EstimatedTotalCostsLine12aPlus12b = new SeleniumControl( sDriver, "Line13Costs_EstimatedTotalCostsLine12aPlus12b", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='DISPLAY_ETC_AMT']");
				Function.AssertEqual(true,BLMPROGP_Line13Costs_EstimatedTotalCostsLine12aPlus12b.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPROGP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPROGP] Performing Select on MainTab...", Logger.MessageType.INF);
				SeleniumControl BLMPROGP_MainTab = new SeleniumControl( sDriver, "MainTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(BLMPROGP_MainTab);
IWebElement mTab = BLMPROGP_MainTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Certification Info").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPROGP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPROGP] Performing VerifyExists on CertificationInfo_Certification_RepName...", Logger.MessageType.INF);
				SeleniumControl BLMPROGP_CertificationInfo_Certification_RepName = new SeleniumControl( sDriver, "CertificationInfo_Certification_RepName", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='CONTR_REP_NAME']");
				Function.AssertEqual(true,BLMPROGP_CertificationInfo_Certification_RepName.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("LINE 9 DETAIL");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPROGP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPROGP] Performing VerifyExists on Line9DetailLink...", Logger.MessageType.INF);
				SeleniumControl BLMPROGP_Line9DetailLink = new SeleniumControl( sDriver, "Line9DetailLink", "ID", "lnk_1003732_BLMPROGP_PRGPMTEDITHDR");
				Function.AssertEqual(true,BLMPROGP_Line9DetailLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPROGP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPROGP] Performing Click on Line9DetailLink...", Logger.MessageType.INF);
				SeleniumControl BLMPROGP_Line9DetailLink = new SeleniumControl( sDriver, "Line9DetailLink", "ID", "lnk_1003732_BLMPROGP_PRGPMTEDITHDR");
				Function.WaitControlDisplayed(BLMPROGP_Line9DetailLink);
BLMPROGP_Line9DetailLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPROGP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPROGP] Performing VerifyExists on Line9DetailForm...", Logger.MessageType.INF);
				SeleniumControl BLMPROGP_Line9DetailForm = new SeleniumControl( sDriver, "Line9DetailForm", "xpath", "//div[starts-with(@id,'pr__BLMPROGP_LINE9_LINECOSTS_')]/ancestor::form[1]");
				Function.AssertEqual(true,BLMPROGP_Line9DetailForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPROGP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPROGP] Performing VerifyExists on Line9Detail_BillableLineCosts_Current...", Logger.MessageType.INF);
				SeleniumControl BLMPROGP_Line9Detail_BillableLineCosts_Current = new SeleniumControl( sDriver, "Line9Detail_BillableLineCosts_Current", "xpath", "//div[starts-with(@id,'pr__BLMPROGP_LINE9_LINECOSTS_')]/ancestor::form[1]/descendant::*[@id='DISPLAY_CURR_AMT']");
				Function.AssertEqual(true,BLMPROGP_Line9Detail_BillableLineCosts_Current.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPROGP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPROGP] Performing VerifyExists on Line9Detail_Line9DetailForm...", Logger.MessageType.INF);
				SeleniumControl BLMPROGP_Line9Detail_Line9DetailForm = new SeleniumControl( sDriver, "Line9Detail_Line9DetailForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BLMPROGPDETAIL_PRGPMTEDITDETL_']/ancestor::form[1]");
				Function.AssertEqual(true,BLMPROGP_Line9Detail_Line9DetailForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPROGP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPROGP] Performing VerifyExists on Line9Detail_Line9Detail_Ok...", Logger.MessageType.INF);
				SeleniumControl BLMPROGP_Line9Detail_Line9Detail_Ok = new SeleniumControl( sDriver, "Line9Detail_Line9Detail_Ok", "xpath", "//div[@class='app']/div[@id='0']/following::span[@class='layerSpan' and contains(@style,'block')]/descendant::input[@id='bOk']");
				Function.AssertEqual(true,BLMPROGP_Line9Detail_Line9Detail_Ok.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPROGP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPROGP] Performing VerifyExist on Line9DetailLine9DetailFormTable...", Logger.MessageType.INF);
				SeleniumControl BLMPROGP_Line9DetailLine9DetailFormTable = new SeleniumControl( sDriver, "Line9DetailLine9DetailFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__BLMPROGPDETAIL_PRGPMTEDITDETL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BLMPROGP_Line9DetailLine9DetailFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPROGP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPROGP] Performing Close on Line9DetailForm...", Logger.MessageType.INF);
				SeleniumControl BLMPROGP_Line9DetailForm = new SeleniumControl( sDriver, "Line9DetailForm", "xpath", "//div[starts-with(@id,'pr__BLMPROGP_LINE9_LINECOSTS_')]/ancestor::form[1]");
				Function.WaitControlDisplayed(BLMPROGP_Line9DetailForm);
IWebElement formBttn = BLMPROGP_Line9DetailForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("LINE 10 DETAIL");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPROGP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPROGP] Performing VerifyExists on Line10DetailLink...", Logger.MessageType.INF);
				SeleniumControl BLMPROGP_Line10DetailLink = new SeleniumControl( sDriver, "Line10DetailLink", "ID", "lnk_1003729_BLMPROGP_PRGPMTEDITHDR");
				Function.AssertEqual(true,BLMPROGP_Line10DetailLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPROGP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPROGP] Performing Click on Line10DetailLink...", Logger.MessageType.INF);
				SeleniumControl BLMPROGP_Line10DetailLink = new SeleniumControl( sDriver, "Line10DetailLink", "ID", "lnk_1003729_BLMPROGP_PRGPMTEDITHDR");
				Function.WaitControlDisplayed(BLMPROGP_Line10DetailLink);
BLMPROGP_Line10DetailLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPROGP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPROGP] Performing VerifyExists on Line10DetailForm...", Logger.MessageType.INF);
				SeleniumControl BLMPROGP_Line10DetailForm = new SeleniumControl( sDriver, "Line10DetailForm", "xpath", "//div[starts-with(@id,'pr__BLMPROGP_LINE10_LINECOSTS_')]/ancestor::form[1]");
				Function.AssertEqual(true,BLMPROGP_Line10DetailForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPROGP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPROGP] Performing VerifyExists on Line10Detail_BillableLineCosts_Current...", Logger.MessageType.INF);
				SeleniumControl BLMPROGP_Line10Detail_BillableLineCosts_Current = new SeleniumControl( sDriver, "Line10Detail_BillableLineCosts_Current", "xpath", "//div[starts-with(@id,'pr__BLMPROGP_LINE10_LINECOSTS_')]/ancestor::form[1]/descendant::*[@id='DISPLAY_CURR_AMT']");
				Function.AssertEqual(true,BLMPROGP_Line10Detail_BillableLineCosts_Current.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPROGP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPROGP] Performing VerifyExists on Line10Detail_Line10DetailForm...", Logger.MessageType.INF);
				SeleniumControl BLMPROGP_Line10Detail_Line10DetailForm = new SeleniumControl( sDriver, "Line10Detail_Line10DetailForm", "xpath", "//div[starts-with(@id,'pr__BLMPROGPDETAIL_PRGPMTEDITDETL1_')]/ancestor::form[1]");
				Function.AssertEqual(true,BLMPROGP_Line10Detail_Line10DetailForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPROGP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPROGP] Performing VerifyExists on Line10Detail_Line10Detail_Ok...", Logger.MessageType.INF);
				SeleniumControl BLMPROGP_Line10Detail_Line10Detail_Ok = new SeleniumControl( sDriver, "Line10Detail_Line10Detail_Ok", "xpath", "//div[@class='app']/div[@id='0']/following::span[@class='layerSpan' and contains(@style,'block')]/descendant::input[@id='bOk']");
				Function.AssertEqual(true,BLMPROGP_Line10Detail_Line10Detail_Ok.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPROGP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPROGP] Performing VerifyExist on Line10Detail_Line10DetailFormTable...", Logger.MessageType.INF);
				SeleniumControl BLMPROGP_Line10Detail_Line10DetailFormTable = new SeleniumControl( sDriver, "Line10Detail_Line10DetailFormTable", "xpath", "//div[starts-with(@id,'pr__BLMPROGPDETAIL_PRGPMTEDITDETL1_')]/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BLMPROGP_Line10Detail_Line10DetailFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPROGP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPROGP] Performing Close on Line10DetailForm...", Logger.MessageType.INF);
				SeleniumControl BLMPROGP_Line10DetailForm = new SeleniumControl( sDriver, "Line10DetailForm", "xpath", "//div[starts-with(@id,'pr__BLMPROGP_LINE10_LINECOSTS_')]/ancestor::form[1]");
				Function.WaitControlDisplayed(BLMPROGP_Line10DetailForm);
IWebElement formBttn = BLMPROGP_Line10DetailForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("LINE 14a DETAIL");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPROGP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPROGP] Performing VerifyExists on Line14aDetailLink...", Logger.MessageType.INF);
				SeleniumControl BLMPROGP_Line14aDetailLink = new SeleniumControl( sDriver, "Line14aDetailLink", "ID", "lnk_1003734_BLMPROGP_PRGPMTEDITHDR");
				Function.AssertEqual(true,BLMPROGP_Line14aDetailLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPROGP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPROGP] Performing Click on Line14aDetailLink...", Logger.MessageType.INF);
				SeleniumControl BLMPROGP_Line14aDetailLink = new SeleniumControl( sDriver, "Line14aDetailLink", "ID", "lnk_1003734_BLMPROGP_PRGPMTEDITHDR");
				Function.WaitControlDisplayed(BLMPROGP_Line14aDetailLink);
BLMPROGP_Line14aDetailLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPROGP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPROGP] Performing VerifyExists on Line14aDetailForm...", Logger.MessageType.INF);
				SeleniumControl BLMPROGP_Line14aDetailForm = new SeleniumControl( sDriver, "Line14aDetailForm", "xpath", "//div[starts-with(@id,'pr__BLMPROGP_LINE14A_TOTAL_')]/ancestor::form[1]");
				Function.AssertEqual(true,BLMPROGP_Line14aDetailForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPROGP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPROGP] Performing VerifyExists on Line14aDetail_LineTotal...", Logger.MessageType.INF);
				SeleniumControl BLMPROGP_Line14aDetail_LineTotal = new SeleniumControl( sDriver, "Line14aDetail_LineTotal", "xpath", "//div[starts-with(@id,'pr__BLMPROGP_LINE14A_TOTAL_')]/ancestor::form[1]/descendant::*[@id='DISPLAY_CURR_AMT']");
				Function.AssertEqual(true,BLMPROGP_Line14aDetail_LineTotal.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPROGP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPROGP] Performing VerifyExists on Line14aDetail_Line14aDetailForm...", Logger.MessageType.INF);
				SeleniumControl BLMPROGP_Line14aDetail_Line14aDetailForm = new SeleniumControl( sDriver, "Line14aDetail_Line14aDetailForm", "xpath", "//div[starts-with(@id,'pr__BLMPROGP_PRGPMTSUBCDETL_14A_')]/ancestor::form[1]");
				Function.AssertEqual(true,BLMPROGP_Line14aDetail_Line14aDetailForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPROGP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPROGP] Performing VerifyExists on Line14aDetail_Line14aDetail_Ok...", Logger.MessageType.INF);
				SeleniumControl BLMPROGP_Line14aDetail_Line14aDetail_Ok = new SeleniumControl( sDriver, "Line14aDetail_Line14aDetail_Ok", "xpath", "//div[@class='app']/div[@id='0']/following::span[@class='layerSpan' and contains(@style,'block')]/descendant::input[@id='bOk']");
				Function.AssertEqual(true,BLMPROGP_Line14aDetail_Line14aDetail_Ok.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPROGP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPROGP] Performing VerifyExist on Line14aDetail_Line14aDetailFormTable...", Logger.MessageType.INF);
				SeleniumControl BLMPROGP_Line14aDetail_Line14aDetailFormTable = new SeleniumControl( sDriver, "Line14aDetail_Line14aDetailFormTable", "xpath", "//div[starts-with(@id,'pr__BLMPROGP_PRGPMTSUBCDETL_14A_')]/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BLMPROGP_Line14aDetail_Line14aDetailFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPROGP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPROGP] Performing Close on Line14aDetailForm...", Logger.MessageType.INF);
				SeleniumControl BLMPROGP_Line14aDetailForm = new SeleniumControl( sDriver, "Line14aDetailForm", "xpath", "//div[starts-with(@id,'pr__BLMPROGP_LINE14A_TOTAL_')]/ancestor::form[1]");
				Function.WaitControlDisplayed(BLMPROGP_Line14aDetailForm);
IWebElement formBttn = BLMPROGP_Line14aDetailForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("LINE 14b DETAIL");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPROGP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPROGP] Performing VerifyExists on Line14bDetailLink...", Logger.MessageType.INF);
				SeleniumControl BLMPROGP_Line14bDetailLink = new SeleniumControl( sDriver, "Line14bDetailLink", "ID", "lnk_1003736_BLMPROGP_PRGPMTEDITHDR");
				Function.AssertEqual(true,BLMPROGP_Line14bDetailLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPROGP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPROGP] Performing Click on Line14bDetailLink...", Logger.MessageType.INF);
				SeleniumControl BLMPROGP_Line14bDetailLink = new SeleniumControl( sDriver, "Line14bDetailLink", "ID", "lnk_1003736_BLMPROGP_PRGPMTEDITHDR");
				Function.WaitControlDisplayed(BLMPROGP_Line14bDetailLink);
BLMPROGP_Line14bDetailLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPROGP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPROGP] Performing VerifyExists on Line14bDetailForm...", Logger.MessageType.INF);
				SeleniumControl BLMPROGP_Line14bDetailForm = new SeleniumControl( sDriver, "Line14bDetailForm", "xpath", "//div[starts-with(@id,'pr__BLMPROGP_LINE14B_TOTAL_')]/ancestor::form[1]");
				Function.AssertEqual(true,BLMPROGP_Line14bDetailForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPROGP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPROGP] Performing VerifyExists on Line14bDetail_LineTotal...", Logger.MessageType.INF);
				SeleniumControl BLMPROGP_Line14bDetail_LineTotal = new SeleniumControl( sDriver, "Line14bDetail_LineTotal", "xpath", "//div[starts-with(@id,'pr__BLMPROGP_LINE14B_TOTAL_')]/ancestor::form[1]/descendant::*[@id='DISPLAY_CURR_AMT']");
				Function.AssertEqual(true,BLMPROGP_Line14bDetail_LineTotal.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPROGP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPROGP] Performing VerifyExists on Line14bDetail_Line14bDetailForm...", Logger.MessageType.INF);
				SeleniumControl BLMPROGP_Line14bDetail_Line14bDetailForm = new SeleniumControl( sDriver, "Line14bDetail_Line14bDetailForm", "xpath", "//div[starts-with(@id,'pr__BLMPROGP_PRGPMTSUBCDETL_14B_')]/ancestor::form[1]");
				Function.AssertEqual(true,BLMPROGP_Line14bDetail_Line14bDetailForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPROGP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPROGP] Performing VerifyExists on Line14bDetail_Line14bDetail_Ok...", Logger.MessageType.INF);
				SeleniumControl BLMPROGP_Line14bDetail_Line14bDetail_Ok = new SeleniumControl( sDriver, "Line14bDetail_Line14bDetail_Ok", "xpath", "//div[@class='app']/div[@id='0']/following::span[@class='layerSpan' and contains(@style,'block')]/descendant::input[@id='bOk']");
				Function.AssertEqual(true,BLMPROGP_Line14bDetail_Line14bDetail_Ok.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPROGP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPROGP] Performing VerifyExist on Line14bDetail_Line14bDetailFormTable...", Logger.MessageType.INF);
				SeleniumControl BLMPROGP_Line14bDetail_Line14bDetailFormTable = new SeleniumControl( sDriver, "Line14bDetail_Line14bDetailFormTable", "xpath", "//div[starts-with(@id,'pr__BLMPROGP_PRGPMTSUBCDETL_14B_')]/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BLMPROGP_Line14bDetail_Line14bDetailFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPROGP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPROGP] Performing Close on Line14bDetailForm...", Logger.MessageType.INF);
				SeleniumControl BLMPROGP_Line14bDetailForm = new SeleniumControl( sDriver, "Line14bDetailForm", "xpath", "//div[starts-with(@id,'pr__BLMPROGP_LINE14B_TOTAL_')]/ancestor::form[1]");
				Function.WaitControlDisplayed(BLMPROGP_Line14bDetailForm);
IWebElement formBttn = BLMPROGP_Line14bDetailForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("LINE 14d DETAIL");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPROGP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPROGP] Performing VerifyExists on Line14dDetailLink...", Logger.MessageType.INF);
				SeleniumControl BLMPROGP_Line14dDetailLink = new SeleniumControl( sDriver, "Line14dDetailLink", "ID", "lnk_1003738_BLMPROGP_PRGPMTEDITHDR");
				Function.AssertEqual(true,BLMPROGP_Line14dDetailLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPROGP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPROGP] Performing Click on Line14dDetailLink...", Logger.MessageType.INF);
				SeleniumControl BLMPROGP_Line14dDetailLink = new SeleniumControl( sDriver, "Line14dDetailLink", "ID", "lnk_1003738_BLMPROGP_PRGPMTEDITHDR");
				Function.WaitControlDisplayed(BLMPROGP_Line14dDetailLink);
BLMPROGP_Line14dDetailLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPROGP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPROGP] Performing VerifyExists on Line14dDetailForm...", Logger.MessageType.INF);
				SeleniumControl BLMPROGP_Line14dDetailForm = new SeleniumControl( sDriver, "Line14dDetailForm", "xpath", "//div[starts-with(@id,'pr__BLMPROGP_LINE14D_TOTAL_')]/ancestor::form[1]");
				Function.AssertEqual(true,BLMPROGP_Line14dDetailForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPROGP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPROGP] Performing VerifyExists on Line14dDetail_LineTotal...", Logger.MessageType.INF);
				SeleniumControl BLMPROGP_Line14dDetail_LineTotal = new SeleniumControl( sDriver, "Line14dDetail_LineTotal", "xpath", "//div[starts-with(@id,'pr__BLMPROGP_LINE14D_TOTAL_')]/ancestor::form[1]/descendant::*[@id='DISPLAY_CURR_AMT']");
				Function.AssertEqual(true,BLMPROGP_Line14dDetail_LineTotal.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPROGP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPROGP] Performing VerifyExists on Line14dDetail_Line14dDetailForm...", Logger.MessageType.INF);
				SeleniumControl BLMPROGP_Line14dDetail_Line14dDetailForm = new SeleniumControl( sDriver, "Line14dDetail_Line14dDetailForm", "xpath", "//div[starts-with(@id,'pr__BLMPROGP_PRGPMTSUBCDETL_14D_')]/ancestor::form[1]");
				Function.AssertEqual(true,BLMPROGP_Line14dDetail_Line14dDetailForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPROGP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPROGP] Performing VerifyExists on Line14dDetail_Line14dDetail_Ok...", Logger.MessageType.INF);
				SeleniumControl BLMPROGP_Line14dDetail_Line14dDetail_Ok = new SeleniumControl( sDriver, "Line14dDetail_Line14dDetail_Ok", "xpath", "//div[@class='app']/div[@id='0']/following::span[@class='layerSpan' and contains(@style,'block')]/descendant::input[@id='bOk']");
				Function.AssertEqual(true,BLMPROGP_Line14dDetail_Line14dDetail_Ok.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPROGP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPROGP] Performing VerifyExist on Line14dDetail_Line14dDetailFormTable...", Logger.MessageType.INF);
				SeleniumControl BLMPROGP_Line14dDetail_Line14dDetailFormTable = new SeleniumControl( sDriver, "Line14dDetail_Line14dDetailFormTable", "xpath", "//div[starts-with(@id,'pr__BLMPROGP_PRGPMTSUBCDETL_14D_')]/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BLMPROGP_Line14dDetail_Line14dDetailFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPROGP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPROGP] Performing Close on Line14dDetailForm...", Logger.MessageType.INF);
				SeleniumControl BLMPROGP_Line14dDetailForm = new SeleniumControl( sDriver, "Line14dDetailForm", "xpath", "//div[starts-with(@id,'pr__BLMPROGP_LINE14D_TOTAL_')]/ancestor::form[1]");
				Function.WaitControlDisplayed(BLMPROGP_Line14dDetailForm);
IWebElement formBttn = BLMPROGP_Line14dDetailForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "BLMPROGP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPROGP] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl BLMPROGP_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(BLMPROGP_MainForm);
IWebElement formBttn = BLMPROGP_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

