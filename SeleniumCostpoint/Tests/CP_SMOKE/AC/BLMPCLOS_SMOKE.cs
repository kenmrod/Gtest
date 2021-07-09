 
using System;
using System.Threading.Tasks;
using SeleniumCostpoint.Common;
using System.Collections.Generic;
using Core.Sys;
using Core.Sys.Selenium;
using System.Threading;
using System.Linq;
using OpenQA.Selenium;

namespace SeleniumCostpoint.Tests.CP_SMOKE.AC
{
    public class BLMPCLOS_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Billing History", "xpath","//div[@class='navItem'][.='Billing History']").Click();
new SeleniumControl(sDriver,"Manage Closed Progress Billing Detail", "xpath","//div[@class='navItem'][.='Manage Closed Progress Billing Detail']").Click();


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
				Function.CurrentComponent = "BLMPCLOS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPCLOS] Performing VerifyExists on Project...", Logger.MessageType.INF);
				SeleniumControl BLMPCLOS_Project = new SeleniumControl( sDriver, "Project", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PROJ_ID']");
				Function.AssertEqual(true,BLMPCLOS_Project.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPCLOS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPCLOS] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl BLMPCLOS_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(BLMPCLOS_MainFormTab);
IWebElement mTab = BLMPCLOS_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Billing Details").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPCLOS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPCLOS] Performing VerifyExists on BillingDetails_Customer...", Logger.MessageType.INF);
				SeleniumControl BLMPCLOS_BillingDetails_Customer = new SeleniumControl( sDriver, "BillingDetails_Customer", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='CUST_ID']");
				Function.AssertEqual(true,BLMPCLOS_BillingDetails_Customer.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPCLOS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPCLOS] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl BLMPCLOS_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(BLMPCLOS_MainFormTab);
IWebElement mTab = BLMPCLOS_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Addresses").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPCLOS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPCLOS] Performing VerifyExists on Adresses_ContractingOffice_Address...", Logger.MessageType.INF);
				SeleniumControl BLMPCLOS_Adresses_ContractingOffice_Address = new SeleniumControl( sDriver, "Adresses_ContractingOffice_Address", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='BILL_ADDR_CD']");
				Function.AssertEqual(true,BLMPCLOS_Adresses_ContractingOffice_Address.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPCLOS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPCLOS] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl BLMPCLOS_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(BLMPCLOS_MainFormTab);
IWebElement mTab = BLMPCLOS_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Remit To").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPCLOS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPCLOS] Performing VerifyExists on RemitTo_ContractingOffice_Address...", Logger.MessageType.INF);
				SeleniumControl BLMPCLOS_RemitTo_ContractingOffice_Address = new SeleniumControl( sDriver, "RemitTo_ContractingOffice_Address", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='BILL_RMT_ADDR_CD']");
				Function.AssertEqual(true,BLMPCLOS_RemitTo_ContractingOffice_Address.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPCLOS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPCLOS] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl BLMPCLOS_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(BLMPCLOS_MainFormTab);
IWebElement mTab = BLMPCLOS_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Section 1").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPCLOS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPCLOS] Performing VerifyExists on Section1_ContractInformation_3SmallBus...", Logger.MessageType.INF);
				SeleniumControl BLMPCLOS_Section1_ContractInformation_3SmallBus = new SeleniumControl( sDriver, "Section1_ContractInformation_3SmallBus", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='DISPLAY_SM_BUS']");
				Function.AssertEqual(true,BLMPCLOS_Section1_ContractInformation_3SmallBus.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPCLOS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPCLOS] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl BLMPCLOS_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(BLMPCLOS_MainFormTab);
IWebElement mTab = BLMPCLOS_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Line Info 9-19").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPCLOS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPCLOS] Performing VerifyExists on LineInfo919_Line9PAIDCOSTSELIGIBLEUNDERPROGRESSPAYMENTCLAUSE...", Logger.MessageType.INF);
				SeleniumControl BLMPCLOS_LineInfo919_Line9PAIDCOSTSELIGIBLEUNDERPROGRESSPAYMENTCLAUSE = new SeleniumControl( sDriver, "LineInfo919_Line9PAIDCOSTSELIGIBLEUNDERPROGRESSPAYMENTCLAUSE", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='LINE_9_AMT']");
				Function.AssertEqual(true,BLMPCLOS_LineInfo919_Line9PAIDCOSTSELIGIBLEUNDERPROGRESSPAYMENTCLAUSE.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPCLOS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPCLOS] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl BLMPCLOS_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(BLMPCLOS_MainFormTab);
IWebElement mTab = BLMPCLOS_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Line Info 20-26").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPCLOS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPCLOS] Performing VerifyExists on LineInfo2026_Line20aCOSTSAPPLICABLETOITEMSDELIVEREDINVOICEDANDACCEPTED...", Logger.MessageType.INF);
				SeleniumControl BLMPCLOS_LineInfo2026_Line20aCOSTSAPPLICABLETOITEMSDELIVEREDINVOICEDANDACCEPTED = new SeleniumControl( sDriver, "LineInfo2026_Line20aCOSTSAPPLICABLETOITEMSDELIVEREDINVOICEDANDACCEPTED", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='LINE_20A_AMT']");
				Function.AssertEqual(true,BLMPCLOS_LineInfo2026_Line20aCOSTSAPPLICABLETOITEMSDELIVEREDINVOICEDANDACCEPTED.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPCLOS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPCLOS] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl BLMPCLOS_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(BLMPCLOS_MainFormTab);
IWebElement mTab = BLMPCLOS_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Line 13 Costs").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPCLOS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPCLOS] Performing VerifyExists on Line13Costs_EstimatedTotalCostsLine12aPlus12b...", Logger.MessageType.INF);
				SeleniumControl BLMPCLOS_Line13Costs_EstimatedTotalCostsLine12aPlus12b = new SeleniumControl( sDriver, "Line13Costs_EstimatedTotalCostsLine12aPlus12b", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='DISPLAY_ETC_AMT']");
				Function.AssertEqual(true,BLMPCLOS_Line13Costs_EstimatedTotalCostsLine12aPlus12b.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Line 9 Detail");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPCLOS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPCLOS] Performing Click on Line9DetailLink...", Logger.MessageType.INF);
				SeleniumControl BLMPCLOS_Line9DetailLink = new SeleniumControl( sDriver, "Line9DetailLink", "ID", "lnk_3504_BLMPCLOS_PRGPMTHDRHS_HDR");
				Function.WaitControlDisplayed(BLMPCLOS_Line9DetailLink);
BLMPCLOS_Line9DetailLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPCLOS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPCLOS] Performing VerifyExist on Line9DetailFormTable...", Logger.MessageType.INF);
				SeleniumControl BLMPCLOS_Line9DetailFormTable = new SeleniumControl( sDriver, "Line9DetailFormTable", "xpath", "//div[starts-with(@id,'pr__BLMPCLOS_PRGPMTDETLHS_LNDET09_')]/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BLMPCLOS_Line9DetailFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPCLOS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPCLOS] Performing Close on Line9DetailForm...", Logger.MessageType.INF);
				SeleniumControl BLMPCLOS_Line9DetailForm = new SeleniumControl( sDriver, "Line9DetailForm", "xpath", "//div[starts-with(@id,'pr__BLMPCLOS_PRGPMTDETLHS_LNDET09_')]/ancestor::form[1]");
				Function.WaitControlDisplayed(BLMPCLOS_Line9DetailForm);
IWebElement formBttn = BLMPCLOS_Line9DetailForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Line 10 Detail");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPCLOS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPCLOS] Performing Click on Line10DetailLink...", Logger.MessageType.INF);
				SeleniumControl BLMPCLOS_Line10DetailLink = new SeleniumControl( sDriver, "Line10DetailLink", "ID", "lnk_3505_BLMPCLOS_PRGPMTHDRHS_HDR");
				Function.WaitControlDisplayed(BLMPCLOS_Line10DetailLink);
BLMPCLOS_Line10DetailLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPCLOS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPCLOS] Performing VerifyExist on Line10DetailFormTable1...", Logger.MessageType.INF);
				SeleniumControl BLMPCLOS_Line10DetailFormTable1 = new SeleniumControl( sDriver, "Line10DetailFormTable1", "xpath", "//div[starts-with(@id,'pr__BLMPCLOS_PRGPMTDETLHS_LNDET10_')]/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BLMPCLOS_Line10DetailFormTable1.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPCLOS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPCLOS] Performing Close on Line10DetailForm...", Logger.MessageType.INF);
				SeleniumControl BLMPCLOS_Line10DetailForm = new SeleniumControl( sDriver, "Line10DetailForm", "xpath", "//div[starts-with(@id,'pr__BLMPCLOS_PRGPMTDETLHS_LNDET10_')]/ancestor::form[1]");
				Function.WaitControlDisplayed(BLMPCLOS_Line10DetailForm);
IWebElement formBttn = BLMPCLOS_Line10DetailForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "BLMPCLOS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPCLOS] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl BLMPCLOS_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(BLMPCLOS_MainForm);
IWebElement formBttn = BLMPCLOS_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

