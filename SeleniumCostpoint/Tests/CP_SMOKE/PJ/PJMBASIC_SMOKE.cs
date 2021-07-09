 
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
    public class PJMBASIC_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Project Setup", "xpath","//div[@class='deptItem'][.='Project Setup']").Click();
new SeleniumControl(sDriver,"Project Master", "xpath","//div[@class='navItem'][.='Project Master']").Click();
new SeleniumControl(sDriver,"Manage Project User Flow", "xpath","//div[@class='navItem'][.='Manage Project User Flow']").Click();


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
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,PJMBASIC_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing VerifyExists on Project...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_Project = new SeleniumControl( sDriver, "Project", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PROJ_ID']");
				Function.AssertEqual(true,PJMBASIC_Project.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PJMBASIC_MainFormTab);
IWebElement mTab = PJMBASIC_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Basic Info").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing VerifyExists on BasicInfo_ProjectClassification...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_BasicInfo_ProjectClassification = new SeleniumControl( sDriver, "BasicInfo_ProjectClassification", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='S_PROJ_RPT_DC']");
				Function.AssertEqual(true,PJMBASIC_BasicInfo_ProjectClassification.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PJMBASIC_MainFormTab);
IWebElement mTab = PJMBASIC_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Details").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing VerifyExists on Details_ContractDetails_PrimeContractNo...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_Details_ContractDetails_PrimeContractNo = new SeleniumControl( sDriver, "Details_ContractDetails_PrimeContractNo", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PRIME_CONTR_ID']");
				Function.AssertEqual(true,PJMBASIC_Details_ContractDetails_PrimeContractNo.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PJMBASIC_MainForm);
IWebElement formBttn = PJMBASIC_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? PJMBASIC_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
PJMBASIC_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJMBASIC_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("MODS");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing VerifyExists on ModsLink...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_ModsLink = new SeleniumControl( sDriver, "ModsLink", "ID", "lnk_1005753_PJMBASIC_PROJ");
				Function.AssertEqual(true,PJMBASIC_ModsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing Click on ModsLink...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_ModsLink = new SeleniumControl( sDriver, "ModsLink", "ID", "lnk_1005753_PJMBASIC_PROJ");
				Function.WaitControlDisplayed(PJMBASIC_ModsLink);
PJMBASIC_ModsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing VerifyExist on ModsTable...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_ModsTable = new SeleniumControl( sDriver, "ModsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PJM_PROJMOD_HDR_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJMBASIC_ModsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing ClickButton on ModsForm...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_ModsForm = new SeleniumControl( sDriver, "ModsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJM_PROJMOD_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJMBASIC_ModsForm);
IWebElement formBttn = PJMBASIC_ModsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PJMBASIC_ModsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PJMBASIC_ModsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing VerifyExists on ModsForm...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_ModsForm = new SeleniumControl( sDriver, "ModsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJM_PROJMOD_HDR_']/ancestor::form[1]");
				Function.AssertEqual(true,PJMBASIC_ModsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing VerifyExists on Mods_ModificationID...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_Mods_ModificationID = new SeleniumControl( sDriver, "Mods_ModificationID", "xpath", "//div[translate(@id,'0123456789','')='pr__PJM_PROJMOD_HDR_']/ancestor::form[1]/descendant::*[@id='PROJ_MOD_ID']");
				Function.AssertEqual(true,PJMBASIC_Mods_ModificationID.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing Close on ModsForm...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_ModsForm = new SeleniumControl( sDriver, "ModsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJM_PROJMOD_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJMBASIC_ModsForm);
IWebElement formBttn = PJMBASIC_ModsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("REV INFO");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing VerifyExists on RevInfoLink...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_RevInfoLink = new SeleniumControl( sDriver, "RevInfoLink", "ID", "lnk_1005776_PJMBASIC_PROJ");
				Function.AssertEqual(true,PJMBASIC_RevInfoLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing Click on RevInfoLink...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_RevInfoLink = new SeleniumControl( sDriver, "RevInfoLink", "ID", "lnk_1005776_PJMBASIC_PROJ");
				Function.WaitControlDisplayed(PJMBASIC_RevInfoLink);
PJMBASIC_RevInfoLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing VerifyExists on RevInfoForm...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_RevInfoForm = new SeleniumControl( sDriver, "RevInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJM_PROJREVSETUP_HDR_']/ancestor::form[1]");
				Function.AssertEqual(true,PJMBASIC_RevInfoForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing VerifyExists on RevInfo_RevenueFormula...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_RevInfo_RevenueFormula = new SeleniumControl( sDriver, "RevInfo_RevenueFormula", "xpath", "//div[translate(@id,'0123456789','')='pr__PJM_PROJREVSETUP_HDR_']/ancestor::form[1]/descendant::*[@id='S_REV_FORMULA_CD']");
				Function.AssertEqual(true,PJMBASIC_RevInfo_RevenueFormula.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing ClickButton on RevInfoForm...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_RevInfoForm = new SeleniumControl( sDriver, "RevInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJM_PROJREVSETUP_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJMBASIC_RevInfoForm);
IWebElement formBttn = PJMBASIC_RevInfoForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? PJMBASIC_RevInfoForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
PJMBASIC_RevInfoForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing VerifyExist on RevInfoTable...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_RevInfoTable = new SeleniumControl( sDriver, "RevInfoTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PJM_PROJREVSETUP_HDR_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJMBASIC_RevInfoTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing Close on RevInfoForm...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_RevInfoForm = new SeleniumControl( sDriver, "RevInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJM_PROJREVSETUP_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJMBASIC_RevInfoForm);
IWebElement formBttn = PJMBASIC_RevInfoForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("PROJ BILLING INFO");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing VerifyExists on ProjBillInfoLink...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_ProjBillInfoLink = new SeleniumControl( sDriver, "ProjBillInfoLink", "ID", "lnk_1005891_PJMBASIC_PROJ");
				Function.AssertEqual(true,PJMBASIC_ProjBillInfoLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing Click on ProjBillInfoLink...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_ProjBillInfoLink = new SeleniumControl( sDriver, "ProjBillInfoLink", "ID", "lnk_1005891_PJMBASIC_PROJ");
				Function.WaitControlDisplayed(PJMBASIC_ProjBillInfoLink);
PJMBASIC_ProjBillInfoLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing ClickButton on ProjBillInfoForm...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_ProjBillInfoForm = new SeleniumControl( sDriver, "ProjBillInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PBM_PROJBILLINFO_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJMBASIC_ProjBillInfoForm);
IWebElement formBttn = PJMBASIC_ProjBillInfoForm.mElement.FindElements(By.CssSelector("*[title*='New']")).Count <= 0 ? PJMBASIC_ProjBillInfoForm.mElement.FindElements(By.XPath(".//*[contains(text(),'New')]")).FirstOrDefault() :
PJMBASIC_ProjBillInfoForm.mElement.FindElements(By.CssSelector("*[title*='New']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" New not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing VerifyExists on ProjBillInfoForm...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_ProjBillInfoForm = new SeleniumControl( sDriver, "ProjBillInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PBM_PROJBILLINFO_HDR_']/ancestor::form[1]");
				Function.AssertEqual(true,PJMBASIC_ProjBillInfoForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing Select on ProjBillInfoTab...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_ProjBillInfoTab = new SeleniumControl( sDriver, "ProjBillInfoTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PBM_PROJBILLINFO_HDR_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PJMBASIC_ProjBillInfoTab);
IWebElement mTab = PJMBASIC_ProjBillInfoTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Setup Information").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing VerifyExists on ProjBillInfo_SetupInformation_BillingParameter1...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_ProjBillInfo_SetupInformation_BillingParameter1 = new SeleniumControl( sDriver, "ProjBillInfo_SetupInformation_BillingParameter1", "xpath", "//div[translate(@id,'0123456789','')='pr__PBM_PROJBILLINFO_HDR_']/ancestor::form[1]/descendant::*[@id='BILL_CALC_AMT_LBL']");
				Function.AssertEqual(true,PJMBASIC_ProjBillInfo_SetupInformation_BillingParameter1.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing Select on ProjBillInfoTab...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_ProjBillInfoTab = new SeleniumControl( sDriver, "ProjBillInfoTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PBM_PROJBILLINFO_HDR_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PJMBASIC_ProjBillInfoTab);
IWebElement mTab = PJMBASIC_ProjBillInfoTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "1443 Info").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing VerifyExists on ProjBillInfo_1443Info_ProgressPayment...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_ProjBillInfo_1443Info_ProgressPayment = new SeleniumControl( sDriver, "ProjBillInfo_1443Info_ProgressPayment", "xpath", "//div[translate(@id,'0123456789','')='pr__PBM_PROJBILLINFO_HDR_']/ancestor::form[1]/descendant::*[@id='PROGRESS_PMT_RT']");
				Function.AssertEqual(true,PJMBASIC_ProjBillInfo_1443Info_ProgressPayment.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing Select on ProjBillInfoTab...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_ProjBillInfoTab = new SeleniumControl( sDriver, "ProjBillInfoTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PBM_PROJBILLINFO_HDR_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PJMBASIC_ProjBillInfoTab);
IWebElement mTab = PJMBASIC_ProjBillInfoTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Other Info").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing VerifyExists on ProjBillInfo_OtherInfo_LimitTransactionsToPeriodOfPerformance...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_ProjBillInfo_OtherInfo_LimitTransactionsToPeriodOfPerformance = new SeleniumControl( sDriver, "ProjBillInfo_OtherInfo_LimitTransactionsToPeriodOfPerformance", "xpath", "//div[translate(@id,'0123456789','')='pr__PBM_PROJBILLINFO_HDR_']/ancestor::form[1]/descendant::*[@id='POP_FL']");
				Function.AssertEqual(true,PJMBASIC_ProjBillInfo_OtherInfo_LimitTransactionsToPeriodOfPerformance.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing Select on ProjBillInfoTab...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_ProjBillInfoTab = new SeleniumControl( sDriver, "ProjBillInfoTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PBM_PROJBILLINFO_HDR_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PJMBASIC_ProjBillInfoTab);
IWebElement mTab = PJMBASIC_ProjBillInfoTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Global Withholding").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing VerifyExists on GlobalWithholding_WithholdingCode...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_GlobalWithholding_WithholdingCode = new SeleniumControl( sDriver, "GlobalWithholding_WithholdingCode", "xpath", "//div[translate(@id,'0123456789','')='pr__PBM_PROJBILLINFO_HDR_']/ancestor::form[1]/descendant::*[@id='BILL_WH_CD']");
				Function.AssertEqual(true,PJMBASIC_GlobalWithholding_WithholdingCode.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing Select on ProjBillInfoTab...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_ProjBillInfoTab = new SeleniumControl( sDriver, "ProjBillInfoTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PBM_PROJBILLINFO_HDR_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PJMBASIC_ProjBillInfoTab);
IWebElement mTab = PJMBASIC_ProjBillInfoTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Billing Currency Contract Values").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing VerifyExists on ProjBillInfo_BillingCurrencyContractValues_FundingInfo_CostAmount...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_ProjBillInfo_BillingCurrencyContractValues_FundingInfo_CostAmount = new SeleniumControl( sDriver, "ProjBillInfo_BillingCurrencyContractValues_FundingInfo_CostAmount", "xpath", "//div[translate(@id,'0123456789','')='pr__PBM_PROJBILLINFO_HDR_']/ancestor::form[1]/descendant::*[@id='PROJ_F_CST_AMT']");
				Function.AssertEqual(true,PJMBASIC_ProjBillInfo_BillingCurrencyContractValues_FundingInfo_CostAmount.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing ClickButton on ProjBillInfoForm...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_ProjBillInfoForm = new SeleniumControl( sDriver, "ProjBillInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PBM_PROJBILLINFO_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJMBASIC_ProjBillInfoForm);
IWebElement formBttn = PJMBASIC_ProjBillInfoForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? PJMBASIC_ProjBillInfoForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
PJMBASIC_ProjBillInfoForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing VerifyExist on ProjBillInfoTable...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_ProjBillInfoTable = new SeleniumControl( sDriver, "ProjBillInfoTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PBM_PROJBILLINFO_HDR_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJMBASIC_ProjBillInfoTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing Close on ProjBillInfoForm...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_ProjBillInfoForm = new SeleniumControl( sDriver, "ProjBillInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PBM_PROJBILLINFO_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJMBASIC_ProjBillInfoForm);
IWebElement formBttn = PJMBASIC_ProjBillInfoForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("DEF RATE SEQ");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing VerifyExists on DefRateSeqLink...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_DefRateSeqLink = new SeleniumControl( sDriver, "DefRateSeqLink", "ID", "lnk_1007429_PJMBASIC_PROJ");
				Function.AssertEqual(true,PJMBASIC_DefRateSeqLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing Click on DefRateSeqLink...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_DefRateSeqLink = new SeleniumControl( sDriver, "DefRateSeqLink", "ID", "lnk_1007429_PJMBASIC_PROJ");
				Function.WaitControlDisplayed(PJMBASIC_DefRateSeqLink);
PJMBASIC_DefRateSeqLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing VerifyExist on DefRateSeqTable...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_DefRateSeqTable = new SeleniumControl( sDriver, "DefRateSeqTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PJM_TMRTORDER_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJMBASIC_DefRateSeqTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing ClickButton on DefRateSeqForm...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_DefRateSeqForm = new SeleniumControl( sDriver, "DefRateSeqForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJM_TMRTORDER_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJMBASIC_DefRateSeqForm);
IWebElement formBttn = PJMBASIC_DefRateSeqForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PJMBASIC_DefRateSeqForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PJMBASIC_DefRateSeqForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing VerifyExists on DefRateSeqForm...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_DefRateSeqForm = new SeleniumControl( sDriver, "DefRateSeqForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJM_TMRTORDER_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,PJMBASIC_DefRateSeqForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing VerifyExists on DefRateSeq_Sequence...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_DefRateSeq_Sequence = new SeleniumControl( sDriver, "DefRateSeq_Sequence", "xpath", "//div[translate(@id,'0123456789','')='pr__PJM_TMRTORDER_CTW_']/ancestor::form[1]/descendant::*[@id='SEQ_NO']");
				Function.AssertEqual(true,PJMBASIC_DefRateSeq_Sequence.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing Close on DefRateSeqForm...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_DefRateSeqForm = new SeleniumControl( sDriver, "DefRateSeqForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJM_TMRTORDER_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJMBASIC_DefRateSeqForm);
IWebElement formBttn = PJMBASIC_DefRateSeqForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("COGS");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing VerifyExists on COGSLink...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_COGSLink = new SeleniumControl( sDriver, "COGSLink", "ID", "lnk_1005883_PJMBASIC_PROJ");
				Function.AssertEqual(true,PJMBASIC_COGSLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing Click on COGSLink...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_COGSLink = new SeleniumControl( sDriver, "COGSLink", "ID", "lnk_1005883_PJMBASIC_PROJ");
				Function.WaitControlDisplayed(PJMBASIC_COGSLink);
PJMBASIC_COGSLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing VerifyExists on COGSForm...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_COGSForm = new SeleniumControl( sDriver, "COGSForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJM_PROJCOGS_']/ancestor::form[1]");
				Function.AssertEqual(true,PJMBASIC_COGSForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing VerifyExists on COGS_CalculationMethod...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_COGS_CalculationMethod = new SeleniumControl( sDriver, "COGS_CalculationMethod", "xpath", "//div[translate(@id,'0123456789','')='pr__PJM_PROJCOGS_']/ancestor::form[1]/descendant::*[@id='S_BASIS_CD']");
				Function.AssertEqual(true,PJMBASIC_COGS_CalculationMethod.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing ClickButton on COGSForm...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_COGSForm = new SeleniumControl( sDriver, "COGSForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJM_PROJCOGS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJMBASIC_COGSForm);
IWebElement formBttn = PJMBASIC_COGSForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? PJMBASIC_COGSForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
PJMBASIC_COGSForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing VerifyExist on COGSTable...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_COGSTable = new SeleniumControl( sDriver, "COGSTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PJM_PROJCOGS_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJMBASIC_COGSTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing Close on COGSForm...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_COGSForm = new SeleniumControl( sDriver, "COGSForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJM_PROJCOGS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJMBASIC_COGSForm);
IWebElement formBttn = PJMBASIC_COGSForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("TOTAL CEIL");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing VerifyExists on TotalCeilLink...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_TotalCeilLink = new SeleniumControl( sDriver, "TotalCeilLink", "ID", "lnk_1005789_PJMBASIC_PROJ");
				Function.AssertEqual(true,PJMBASIC_TotalCeilLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing Click on TotalCeilLink...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_TotalCeilLink = new SeleniumControl( sDriver, "TotalCeilLink", "ID", "lnk_1005789_PJMBASIC_PROJ");
				Function.WaitControlDisplayed(PJMBASIC_TotalCeilLink);
PJMBASIC_TotalCeilLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing VerifyExists on TotalCeilForm...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_TotalCeilForm = new SeleniumControl( sDriver, "TotalCeilForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBASIC_PROJ_TCEIL_']/ancestor::form[1]");
				Function.AssertEqual(true,PJMBASIC_TotalCeilForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing VerifyExists on TotalCeil_FundingInfo_TotalCode...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_TotalCeil_FundingInfo_TotalCode = new SeleniumControl( sDriver, "TotalCeil_FundingInfo_TotalCode", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBASIC_PROJ_TCEIL_']/ancestor::form[1]/descendant::*[@id='CEIL_F_TOT_RBA_CD']");
				Function.AssertEqual(true,PJMBASIC_TotalCeil_FundingInfo_TotalCode.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing Close on TotalCeilForm...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_TotalCeilForm = new SeleniumControl( sDriver, "TotalCeilForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBASIC_PROJ_TCEIL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJMBASIC_TotalCeilForm);
IWebElement formBttn = PJMBASIC_TotalCeilForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("DIR COST CEIL");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing VerifyExists on DirCostCeilLink...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_DirCostCeilLink = new SeleniumControl( sDriver, "DirCostCeilLink", "ID", "lnk_1005882_PJMBASIC_PROJ");
				Function.AssertEqual(true,PJMBASIC_DirCostCeilLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing Click on DirCostCeilLink...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_DirCostCeilLink = new SeleniumControl( sDriver, "DirCostCeilLink", "ID", "lnk_1005882_PJMBASIC_PROJ");
				Function.WaitControlDisplayed(PJMBASIC_DirCostCeilLink);
PJMBASIC_DirCostCeilLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing VerifyExists on DirCostCeilForm...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_DirCostCeilForm = new SeleniumControl( sDriver, "DirCostCeilForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBASIC_CEILDIRCST_CHILD_']/ancestor::form[1]");
				Function.AssertEqual(true,PJMBASIC_DirCostCeilForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing VerifyExist on DirCostCeilTable...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_DirCostCeilTable = new SeleniumControl( sDriver, "DirCostCeilTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBASIC_CEILDIRCST_CHILD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJMBASIC_DirCostCeilTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing Close on DirCostCeilForm...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_DirCostCeilForm = new SeleniumControl( sDriver, "DirCostCeilForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBASIC_CEILDIRCST_CHILD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJMBASIC_DirCostCeilForm);
IWebElement formBttn = PJMBASIC_DirCostCeilForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("BURD COST CEIL");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing VerifyExists on BurdCostCeilLink...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_BurdCostCeilLink = new SeleniumControl( sDriver, "BurdCostCeilLink", "ID", "lnk_1005884_PJMBASIC_PROJ");
				Function.AssertEqual(true,PJMBASIC_BurdCostCeilLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing Click on BurdCostCeilLink...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_BurdCostCeilLink = new SeleniumControl( sDriver, "BurdCostCeilLink", "ID", "lnk_1005884_PJMBASIC_PROJ");
				Function.WaitControlDisplayed(PJMBASIC_BurdCostCeilLink);
PJMBASIC_BurdCostCeilLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing VerifyExists on BurdCostCeilForm...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_BurdCostCeilForm = new SeleniumControl( sDriver, "BurdCostCeilForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBASIC_CEILBURDENCST_HDR_']/ancestor::form[1]");
				Function.AssertEqual(true,PJMBASIC_BurdCostCeilForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing VerifyExists on BurdCostCeil_FiscalYear...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_BurdCostCeil_FiscalYear = new SeleniumControl( sDriver, "BurdCostCeil_FiscalYear", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBASIC_CEILBURDENCST_HDR_']/ancestor::form[1]/descendant::*[@id='FY_CD']");
				Function.AssertEqual(true,PJMBASIC_BurdCostCeil_FiscalYear.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing ClickButton on BurdCostCeilForm...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_BurdCostCeilForm = new SeleniumControl( sDriver, "BurdCostCeilForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBASIC_CEILBURDENCST_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJMBASIC_BurdCostCeilForm);
IWebElement formBttn = PJMBASIC_BurdCostCeilForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? PJMBASIC_BurdCostCeilForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
PJMBASIC_BurdCostCeilForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing VerifyExist on BurdCostCeilTable...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_BurdCostCeilTable = new SeleniumControl( sDriver, "BurdCostCeilTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBASIC_CEILBURDENCST_HDR_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJMBASIC_BurdCostCeilTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing VerifyExist on BurdCostCeilDetailsTable...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_BurdCostCeilDetailsTable = new SeleniumControl( sDriver, "BurdCostCeilDetailsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBASIC_CEILBURDENCST_CHILD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJMBASIC_BurdCostCeilDetailsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing ClickButton on BurdCostCeilDetailsForm...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_BurdCostCeilDetailsForm = new SeleniumControl( sDriver, "BurdCostCeilDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBASIC_CEILBURDENCST_CHILD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJMBASIC_BurdCostCeilDetailsForm);
IWebElement formBttn = PJMBASIC_BurdCostCeilDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PJMBASIC_BurdCostCeilDetailsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PJMBASIC_BurdCostCeilDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing VerifyExists on BurdCostCeilDetailsForm...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_BurdCostCeilDetailsForm = new SeleniumControl( sDriver, "BurdCostCeilDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBASIC_CEILBURDENCST_CHILD_']/ancestor::form[1]");
				Function.AssertEqual(true,PJMBASIC_BurdCostCeilDetailsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing VerifyExists on BurdCostCeil_Accounts...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_BurdCostCeil_Accounts = new SeleniumControl( sDriver, "BurdCostCeil_Accounts", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBASIC_CEILBURDENCST_CHILD_']/ancestor::form[1]/descendant::*[@id='ACCT_ID']");
				Function.AssertEqual(true,PJMBASIC_BurdCostCeil_Accounts.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing Close on BurdCostCeilForm...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_BurdCostCeilForm = new SeleniumControl( sDriver, "BurdCostCeilForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBASIC_CEILBURDENCST_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJMBASIC_BurdCostCeilForm);
IWebElement formBttn = PJMBASIC_BurdCostCeilForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("DIR HRS CEIL");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing VerifyExists on DirCostCeilLink...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_DirCostCeilLink = new SeleniumControl( sDriver, "DirCostCeilLink", "ID", "lnk_1005882_PJMBASIC_PROJ");
				Function.AssertEqual(true,PJMBASIC_DirCostCeilLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing Click on DirCostCeilLink...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_DirCostCeilLink = new SeleniumControl( sDriver, "DirCostCeilLink", "ID", "lnk_1005882_PJMBASIC_PROJ");
				Function.WaitControlDisplayed(PJMBASIC_DirCostCeilLink);
PJMBASIC_DirCostCeilLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing VerifyExists on DirCostCeilForm...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_DirCostCeilForm = new SeleniumControl( sDriver, "DirCostCeilForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBASIC_CEILDIRCST_CHILD_']/ancestor::form[1]");
				Function.AssertEqual(true,PJMBASIC_DirCostCeilForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing VerifyExist on DirCostCeilTable...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_DirCostCeilTable = new SeleniumControl( sDriver, "DirCostCeilTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBASIC_CEILDIRCST_CHILD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJMBASIC_DirCostCeilTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing VerifyExists on DirCostCeil_OKButton...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_DirCostCeil_OKButton = new SeleniumControl( sDriver, "DirCostCeil_OKButton", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBASIC_CEILDIRCST_CHILD_']/ancestor::form[1]/following-sibling::div[1]/descendant::*[@id='bOk']");
				Function.AssertEqual(true,PJMBASIC_DirCostCeil_OKButton.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing Close on DirCostCeilForm...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_DirCostCeilForm = new SeleniumControl( sDriver, "DirCostCeilForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBASIC_CEILDIRCST_CHILD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJMBASIC_DirCostCeilForm);
IWebElement formBttn = PJMBASIC_DirCostCeilForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("EMPL HRS CEIL");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing VerifyExists on EmplHrsCeilLink...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_EmplHrsCeilLink = new SeleniumControl( sDriver, "EmplHrsCeilLink", "ID", "lnk_1005791_PJMBASIC_PROJ");
				Function.AssertEqual(true,PJMBASIC_EmplHrsCeilLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing Click on EmplHrsCeilLink...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_EmplHrsCeilLink = new SeleniumControl( sDriver, "EmplHrsCeilLink", "ID", "lnk_1005791_PJMBASIC_PROJ");
				Function.WaitControlDisplayed(PJMBASIC_EmplHrsCeilLink);
PJMBASIC_EmplHrsCeilLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing VerifyExists on EmplHrsCeilForm...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_EmplHrsCeilForm = new SeleniumControl( sDriver, "EmplHrsCeilForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBASIC_EMPLCEIL_CHLD_']/ancestor::form[1]");
				Function.AssertEqual(true,PJMBASIC_EmplHrsCeilForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing VerifyExist on EmplHrsCeilTable...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_EmplHrsCeilTable = new SeleniumControl( sDriver, "EmplHrsCeilTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBASIC_EMPLCEIL_CHLD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJMBASIC_EmplHrsCeilTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing VerifyExists on EmplHrsCeil_OKButton...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_EmplHrsCeil_OKButton = new SeleniumControl( sDriver, "EmplHrsCeil_OKButton", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBASIC_EMPLCEIL_CHLD_']/ancestor::form[1]/following-sibling::div[1]/descendant::*[@id='bOk']");
				Function.AssertEqual(true,PJMBASIC_EmplHrsCeil_OKButton.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing Close on EmplHrsCeilForm...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_EmplHrsCeilForm = new SeleniumControl( sDriver, "EmplHrsCeilForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBASIC_EMPLCEIL_CHLD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJMBASIC_EmplHrsCeilForm);
IWebElement formBttn = PJMBASIC_EmplHrsCeilForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("VEND HRS CEIL");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing VerifyExists on VendHrsCeilLink...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_VendHrsCeilLink = new SeleniumControl( sDriver, "VendHrsCeilLink", "ID", "lnk_1005792_PJMBASIC_PROJ");
				Function.AssertEqual(true,PJMBASIC_VendHrsCeilLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing Click on VendHrsCeilLink...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_VendHrsCeilLink = new SeleniumControl( sDriver, "VendHrsCeilLink", "ID", "lnk_1005792_PJMBASIC_PROJ");
				Function.WaitControlDisplayed(PJMBASIC_VendHrsCeilLink);
PJMBASIC_VendHrsCeilLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing VerifyExists on VendHrsCeilForm...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_VendHrsCeilForm = new SeleniumControl( sDriver, "VendHrsCeilForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBASIC_VENDCEIL_VCEILCHLD_']/ancestor::form[1]");
				Function.AssertEqual(true,PJMBASIC_VendHrsCeilForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing VerifyExist on VendHrsCeilTable...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_VendHrsCeilTable = new SeleniumControl( sDriver, "VendHrsCeilTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBASIC_VENDCEIL_VCEILCHLD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJMBASIC_VendHrsCeilTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing VerifyExists on VendHrsCeil_OKButton...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_VendHrsCeil_OKButton = new SeleniumControl( sDriver, "VendHrsCeil_OKButton", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBASIC_VENDCEIL_VCEILCHLD_']/ancestor::form[1]/following-sibling::div[1]/descendant::*[@id='bOk']");
				Function.AssertEqual(true,PJMBASIC_VendHrsCeil_OKButton.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing Close on VendHrsCeilForm...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_VendHrsCeilForm = new SeleniumControl( sDriver, "VendHrsCeilForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBASIC_VENDCEIL_VCEILCHLD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJMBASIC_VendHrsCeilForm);
IWebElement formBttn = PJMBASIC_VendHrsCeilForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("COST FEE OVRD");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing VerifyExists on CostFeeOvrdLink...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_CostFeeOvrdLink = new SeleniumControl( sDriver, "CostFeeOvrdLink", "ID", "lnk_1005786_PJMBASIC_PROJ");
				Function.AssertEqual(true,PJMBASIC_CostFeeOvrdLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing Click on CostFeeOvrdLink...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_CostFeeOvrdLink = new SeleniumControl( sDriver, "CostFeeOvrdLink", "ID", "lnk_1005786_PJMBASIC_PROJ");
				Function.WaitControlDisplayed(PJMBASIC_CostFeeOvrdLink);
PJMBASIC_CostFeeOvrdLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing VerifyExists on CostFeeOvrdForm...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_CostFeeOvrdForm = new SeleniumControl( sDriver, "CostFeeOvrdForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBASIC_OVRIDEFEEONDIR_TBL_']/ancestor::form[1]");
				Function.AssertEqual(true,PJMBASIC_CostFeeOvrdForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing VerifyExist on CostFeeOvrdTable...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_CostFeeOvrdTable = new SeleniumControl( sDriver, "CostFeeOvrdTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBASIC_OVRIDEFEEONDIR_TBL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJMBASIC_CostFeeOvrdTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing VerifyExists on CostFeeOvrd_OKButton...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_CostFeeOvrd_OKButton = new SeleniumControl( sDriver, "CostFeeOvrd_OKButton", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBASIC_OVRIDEFEEONDIR_TBL_']/ancestor::form[1]/following-sibling::div[1]/descendant::*[@id='bOk']");
				Function.AssertEqual(true,PJMBASIC_CostFeeOvrd_OKButton.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing Close on CostFeeOvrdForm...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_CostFeeOvrdForm = new SeleniumControl( sDriver, "CostFeeOvrdForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBASIC_OVRIDEFEEONDIR_TBL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJMBASIC_CostFeeOvrdForm);
IWebElement formBttn = PJMBASIC_CostFeeOvrdForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("BURD FEE OVRD");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing VerifyExists on BurdFeeOvrdLink...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_BurdFeeOvrdLink = new SeleniumControl( sDriver, "BurdFeeOvrdLink", "ID", "lnk_1005787_PJMBASIC_PROJ");
				Function.AssertEqual(true,PJMBASIC_BurdFeeOvrdLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing Click on BurdFeeOvrdLink...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_BurdFeeOvrdLink = new SeleniumControl( sDriver, "BurdFeeOvrdLink", "ID", "lnk_1005787_PJMBASIC_PROJ");
				Function.WaitControlDisplayed(PJMBASIC_BurdFeeOvrdLink);
PJMBASIC_BurdFeeOvrdLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing VerifyExists on BurdFeeOvrdForm...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_BurdFeeOvrdForm = new SeleniumControl( sDriver, "BurdFeeOvrdForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBASIC_OVRIDEFEEONBURD_CHLD_']/ancestor::form[1]");
				Function.AssertEqual(true,PJMBASIC_BurdFeeOvrdForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing VerifyExist on BurdFeeOvrdTable...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_BurdFeeOvrdTable = new SeleniumControl( sDriver, "BurdFeeOvrdTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBASIC_OVRIDEFEEONBURD_CHLD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJMBASIC_BurdFeeOvrdTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing VerifyExists on BurdFeeOvrd_OKButton...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_BurdFeeOvrd_OKButton = new SeleniumControl( sDriver, "BurdFeeOvrd_OKButton", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBASIC_OVRIDEFEEONBURD_CHLD_']/ancestor::form[1]/following-sibling::div[1]/descendant::*[@id='bOk']");
				Function.AssertEqual(true,PJMBASIC_BurdFeeOvrd_OKButton.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing Close on BurdFeeOvrdForm...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_BurdFeeOvrdForm = new SeleniumControl( sDriver, "BurdFeeOvrdForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBASIC_OVRIDEFEEONBURD_CHLD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJMBASIC_BurdFeeOvrdForm);
IWebElement formBttn = PJMBASIC_BurdFeeOvrdForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("MULT OVRD");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing VerifyExists on MultOvrdLink...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_MultOvrdLink = new SeleniumControl( sDriver, "MultOvrdLink", "ID", "lnk_1005788_PJMBASIC_PROJ");
				Function.AssertEqual(true,PJMBASIC_MultOvrdLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing Click on MultOvrdLink...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_MultOvrdLink = new SeleniumControl( sDriver, "MultOvrdLink", "ID", "lnk_1005788_PJMBASIC_PROJ");
				Function.WaitControlDisplayed(PJMBASIC_MultOvrdLink);
PJMBASIC_MultOvrdLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing VerifyExists on MultOvrdForm...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_MultOvrdForm = new SeleniumControl( sDriver, "MultOvrdForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBASIC_OVRIDEMLTONDIR_']/ancestor::form[1]");
				Function.AssertEqual(true,PJMBASIC_MultOvrdForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing VerifyExist on MultOvrdTable...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_MultOvrdTable = new SeleniumControl( sDriver, "MultOvrdTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBASIC_OVRIDEMLTONDIR_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJMBASIC_MultOvrdTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing VerifyExists on MultOvrd_OKButton...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_MultOvrd_OKButton = new SeleniumControl( sDriver, "MultOvrd_OKButton", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBASIC_OVRIDEMLTONDIR_']/ancestor::form[1]/following-sibling::div[1]/descendant::*[@id='bOk']");
				Function.AssertEqual(true,PJMBASIC_MultOvrd_OKButton.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing Close on MultOvrdForm...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_MultOvrdForm = new SeleniumControl( sDriver, "MultOvrdForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBASIC_OVRIDEMLTONDIR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJMBASIC_MultOvrdForm);
IWebElement formBttn = PJMBASIC_MultOvrdForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("GOV'T CONTRACT");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing VerifyExists on GovtContractLink...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_GovtContractLink = new SeleniumControl( sDriver, "GovtContractLink", "ID", "lnk_1006883_PJMBASIC_PROJ");
				Function.AssertEqual(true,PJMBASIC_GovtContractLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing Click on GovtContractLink...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_GovtContractLink = new SeleniumControl( sDriver, "GovtContractLink", "ID", "lnk_1006883_PJMBASIC_PROJ");
				Function.WaitControlDisplayed(PJMBASIC_GovtContractLink);
PJMBASIC_GovtContractLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing VerifyExists on GovtContractForm...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_GovtContractForm = new SeleniumControl( sDriver, "GovtContractForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBASIC_PROJGOVTCONTR_HDR_']/ancestor::form[1]");
				Function.AssertEqual(true,PJMBASIC_GovtContractForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing Select on GovtContractTab...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_GovtContractTab = new SeleniumControl( sDriver, "GovtContractTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBASIC_PROJGOVTCONTR_HDR_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PJMBASIC_GovtContractTab);
IWebElement mTab = PJMBASIC_GovtContractTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Contract Details").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing VerifyExists on GovtContract_ContractDetails_ContractOfficer...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_GovtContract_ContractDetails_ContractOfficer = new SeleniumControl( sDriver, "GovtContract_ContractDetails_ContractOfficer", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBASIC_PROJGOVTCONTR_HDR_']/ancestor::form[1]/descendant::*[@id='COTR_NAME']");
				Function.AssertEqual(true,PJMBASIC_GovtContract_ContractDetails_ContractOfficer.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing Select on GovtContractTab...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_GovtContractTab = new SeleniumControl( sDriver, "GovtContractTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBASIC_PROJGOVTCONTR_HDR_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PJMBASIC_GovtContractTab);
IWebElement mTab = PJMBASIC_GovtContractTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Telephone Numbers").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing VerifyExists on GovtContract_TelephoneNumbers_AdministrativeContractingOfficer_Phone...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_GovtContract_TelephoneNumbers_AdministrativeContractingOfficer_Phone = new SeleniumControl( sDriver, "GovtContract_TelephoneNumbers_AdministrativeContractingOfficer_Phone", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBASIC_PROJGOVTCONTR_HDR_']/ancestor::form[1]/descendant::*[@id='ACO_PHONE_ID']");
				Function.AssertEqual(true,PJMBASIC_GovtContract_TelephoneNumbers_AdministrativeContractingOfficer_Phone.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing Select on GovtContractTab...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_GovtContractTab = new SeleniumControl( sDriver, "GovtContractTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBASIC_PROJGOVTCONTR_HDR_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PJMBASIC_GovtContractTab);
IWebElement mTab = PJMBASIC_GovtContractTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Statement of Work").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing VerifyExists on GovtContract_StatementOfWork...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_GovtContract_StatementOfWork = new SeleniumControl( sDriver, "GovtContract_StatementOfWork", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBASIC_PROJGOVTCONTR_HDR_']/ancestor::form[1]/descendant::*[@id='STMT_OF_WORK_TX']");
				Function.AssertEqual(true,PJMBASIC_GovtContract_StatementOfWork.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing Close on GovtContractForm...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_GovtContractForm = new SeleniumControl( sDriver, "GovtContractForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBASIC_PROJGOVTCONTR_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJMBASIC_GovtContractForm);
IWebElement formBttn = PJMBASIC_GovtContractForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("DELIVERABLES");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing VerifyExists on DeliverablesLink...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_DeliverablesLink = new SeleniumControl( sDriver, "DeliverablesLink", "ID", "lnk_1005819_PJMBASIC_PROJ");
				Function.AssertEqual(true,PJMBASIC_DeliverablesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing Click on DeliverablesLink...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_DeliverablesLink = new SeleniumControl( sDriver, "DeliverablesLink", "ID", "lnk_1005819_PJMBASIC_PROJ");
				Function.WaitControlDisplayed(PJMBASIC_DeliverablesLink);
PJMBASIC_DeliverablesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing VerifyExists on DeliverablesForm...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_DeliverablesForm = new SeleniumControl( sDriver, "DeliverablesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJM_PROJDELIV_']/ancestor::form[1]");
				Function.AssertEqual(true,PJMBASIC_DeliverablesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing VerifyExists on Deliverables_Deliverable_Number...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_Deliverables_Deliverable_Number = new SeleniumControl( sDriver, "Deliverables_Deliverable_Number", "xpath", "//div[translate(@id,'0123456789','')='pr__PJM_PROJDELIV_']/ancestor::form[1]/descendant::*[@id='SEQ_NO']");
				Function.AssertEqual(true,PJMBASIC_Deliverables_Deliverable_Number.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing ClickButton on DeliverablesForm...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_DeliverablesForm = new SeleniumControl( sDriver, "DeliverablesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJM_PROJDELIV_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJMBASIC_DeliverablesForm);
IWebElement formBttn = PJMBASIC_DeliverablesForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? PJMBASIC_DeliverablesForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
PJMBASIC_DeliverablesForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing VerifyExist on DeliverablesTable...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_DeliverablesTable = new SeleniumControl( sDriver, "DeliverablesTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PJM_PROJDELIV_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJMBASIC_DeliverablesTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing Close on DeliverablesForm...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_DeliverablesForm = new SeleniumControl( sDriver, "DeliverablesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJM_PROJDELIV_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJMBASIC_DeliverablesForm);
IWebElement formBttn = PJMBASIC_DeliverablesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("USER-DEFINED INFO");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing VerifyExists on UserDefinedInfoLink...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_UserDefinedInfoLink = new SeleniumControl( sDriver, "UserDefinedInfoLink", "ID", "lnk_1007367_PJMBASIC_PROJ");
				Function.AssertEqual(true,PJMBASIC_UserDefinedInfoLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing Click on UserDefinedInfoLink...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_UserDefinedInfoLink = new SeleniumControl( sDriver, "UserDefinedInfoLink", "ID", "lnk_1007367_PJMBASIC_PROJ");
				Function.WaitControlDisplayed(PJMBASIC_UserDefinedInfoLink);
PJMBASIC_UserDefinedInfoLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing VerifyExist on UserDefinedInfoTable...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_UserDefinedInfoTable = new SeleniumControl( sDriver, "UserDefinedInfoTable", "xpath", "//div[translate(@id,'0123456789','')='pr__CPMUDINF_UDEFLBL_CHLD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJMBASIC_UserDefinedInfoTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing ClickButton on UserDefinedInfoForm...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_UserDefinedInfoForm = new SeleniumControl( sDriver, "UserDefinedInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPMUDINF_UDEFLBL_CHLD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJMBASIC_UserDefinedInfoForm);
IWebElement formBttn = PJMBASIC_UserDefinedInfoForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PJMBASIC_UserDefinedInfoForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PJMBASIC_UserDefinedInfoForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing VerifyExists on UserDefinedInfoForm...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_UserDefinedInfoForm = new SeleniumControl( sDriver, "UserDefinedInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPMUDINF_UDEFLBL_CHLD_']/ancestor::form[1]");
				Function.AssertEqual(true,PJMBASIC_UserDefinedInfoForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing VerifyExists on UserDefinedInfo_DataType...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_UserDefinedInfo_DataType = new SeleniumControl( sDriver, "UserDefinedInfo_DataType", "xpath", "//div[translate(@id,'0123456789','')='pr__CPMUDINF_UDEFLBL_CHLD_']/ancestor::form[1]/descendant::*[@id='S_DATA_TYPE']");
				Function.AssertEqual(true,PJMBASIC_UserDefinedInfo_DataType.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing Close on UserDefinedInfoForm...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_UserDefinedInfoForm = new SeleniumControl( sDriver, "UserDefinedInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPMUDINF_UDEFLBL_CHLD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJMBASIC_UserDefinedInfoForm);
IWebElement formBttn = PJMBASIC_UserDefinedInfoForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("PROJ LEVELS");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing VerifyExists on ProjLevelsLink...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_ProjLevelsLink = new SeleniumControl( sDriver, "ProjLevelsLink", "ID", "lnk_1004892_PJMBASIC_PROJ");
				Function.AssertEqual(true,PJMBASIC_ProjLevelsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing Click on ProjLevelsLink...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_ProjLevelsLink = new SeleniumControl( sDriver, "ProjLevelsLink", "ID", "lnk_1004892_PJMBASIC_PROJ");
				Function.WaitControlDisplayed(PJMBASIC_ProjLevelsLink);
PJMBASIC_ProjLevelsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing VerifyExists on ProjLevelsForm...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_ProjLevelsForm = new SeleniumControl( sDriver, "ProjLevelsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBASIC_PROJLVL_']/ancestor::form[1]");
				Function.AssertEqual(true,PJMBASIC_ProjLevelsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing VerifyExist on ProjLevelsTable...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_ProjLevelsTable = new SeleniumControl( sDriver, "ProjLevelsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBASIC_PROJLVL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJMBASIC_ProjLevelsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing Close on ProjLevelsForm...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_ProjLevelsForm = new SeleniumControl( sDriver, "ProjLevelsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBASIC_PROJLVL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJMBASIC_ProjLevelsForm);
IWebElement formBttn = PJMBASIC_ProjLevelsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("ORG HISTORY");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing VerifyExists on OrgHistoryLink...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_OrgHistoryLink = new SeleniumControl( sDriver, "OrgHistoryLink", "ID", "lnk_1004893_PJMBASIC_PROJ");
				Function.AssertEqual(true,PJMBASIC_OrgHistoryLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing Click on OrgHistoryLink...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_OrgHistoryLink = new SeleniumControl( sDriver, "OrgHistoryLink", "ID", "lnk_1004893_PJMBASIC_PROJ");
				Function.WaitControlDisplayed(PJMBASIC_OrgHistoryLink);
PJMBASIC_OrgHistoryLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing VerifyExist on OrgHistoryTable...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_OrgHistoryTable = new SeleniumControl( sDriver, "OrgHistoryTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBASIC_ORGHIST_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJMBASIC_OrgHistoryTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing ClickButton on OrgHistoryForm...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_OrgHistoryForm = new SeleniumControl( sDriver, "OrgHistoryForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBASIC_ORGHIST_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJMBASIC_OrgHistoryForm);
IWebElement formBttn = PJMBASIC_OrgHistoryForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PJMBASIC_OrgHistoryForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PJMBASIC_OrgHistoryForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing VerifyExists on OrgHistoryForm...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_OrgHistoryForm = new SeleniumControl( sDriver, "OrgHistoryForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBASIC_ORGHIST_']/ancestor::form[1]");
				Function.AssertEqual(true,PJMBASIC_OrgHistoryForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing VerifyExists on OrgHistory_PreviousOwningOrg...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_OrgHistory_PreviousOwningOrg = new SeleniumControl( sDriver, "OrgHistory_PreviousOwningOrg", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBASIC_ORGHIST_']/ancestor::form[1]/descendant::*[@id='OLD_ORG_ID']");
				Function.AssertEqual(true,PJMBASIC_OrgHistory_PreviousOwningOrg.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing Close on OrgHistoryForm...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_OrgHistoryForm = new SeleniumControl( sDriver, "OrgHistoryForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBASIC_ORGHIST_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJMBASIC_OrgHistoryForm);
IWebElement formBttn = PJMBASIC_OrgHistoryForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("NOTES");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing VerifyExists on NotesLink...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_NotesLink = new SeleniumControl( sDriver, "NotesLink", "ID", "lnk_1004894_PJMBASIC_PROJ");
				Function.AssertEqual(true,PJMBASIC_NotesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing Click on NotesLink...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_NotesLink = new SeleniumControl( sDriver, "NotesLink", "ID", "lnk_1004894_PJMBASIC_PROJ");
				Function.WaitControlDisplayed(PJMBASIC_NotesLink);
PJMBASIC_NotesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing VerifyExists on NotesForm...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_NotesForm = new SeleniumControl( sDriver, "NotesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBASIC_PROJ_NOTES_']/ancestor::form[1]");
				Function.AssertEqual(true,PJMBASIC_NotesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing VerifyExists on Notes_Text...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_Notes_Text = new SeleniumControl( sDriver, "Notes_Text", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBASIC_PROJ_NOTES_']/ancestor::form[1]/descendant::*[@id='NOTES']");
				Function.AssertEqual(true,PJMBASIC_Notes_Text.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing Close on NotesForm...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_NotesForm = new SeleniumControl( sDriver, "NotesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBASIC_PROJ_NOTES_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJMBASIC_NotesForm);
IWebElement formBttn = PJMBASIC_NotesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("PROJ LOCATION");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing VerifyExists on ProjLocationLink...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_ProjLocationLink = new SeleniumControl( sDriver, "ProjLocationLink", "ID", "lnk_1005042_PJMBASIC_PROJ");
				Function.AssertEqual(true,PJMBASIC_ProjLocationLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing Click on ProjLocationLink...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_ProjLocationLink = new SeleniumControl( sDriver, "ProjLocationLink", "ID", "lnk_1005042_PJMBASIC_PROJ");
				Function.WaitControlDisplayed(PJMBASIC_ProjLocationLink);
PJMBASIC_ProjLocationLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing VerifyExists on ProjLocationForm...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_ProjLocationForm = new SeleniumControl( sDriver, "ProjLocationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBASIC_PROJ_LOCATION_']/ancestor::form[1]");
				Function.AssertEqual(true,PJMBASIC_ProjLocationForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing VerifyExists on ProjLocation_AddressLine1...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_ProjLocation_AddressLine1 = new SeleniumControl( sDriver, "ProjLocation_AddressLine1", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBASIC_PROJ_LOCATION_']/ancestor::form[1]/descendant::*[@id='PROJ_LN_1_ADR']");
				Function.AssertEqual(true,PJMBASIC_ProjLocation_AddressLine1.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing ClickButton on ProjLocationForm...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_ProjLocationForm = new SeleniumControl( sDriver, "ProjLocationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBASIC_PROJ_LOCATION_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJMBASIC_ProjLocationForm);
IWebElement formBttn = PJMBASIC_ProjLocationForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? PJMBASIC_ProjLocationForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
PJMBASIC_ProjLocationForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing VerifyExist on ProjLocationTable...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_ProjLocationTable = new SeleniumControl( sDriver, "ProjLocationTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBASIC_PROJ_LOCATION_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJMBASIC_ProjLocationTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing Close on ProjLocationForm...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_ProjLocationForm = new SeleniumControl( sDriver, "ProjLocationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBASIC_PROJ_LOCATION_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJMBASIC_ProjLocationForm);
IWebElement formBttn = PJMBASIC_ProjLocationForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("ACCT ORG LINKS");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing VerifyExists on ACCTOrgLinksLink...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_ACCTOrgLinksLink = new SeleniumControl( sDriver, "ACCTOrgLinksLink", "ID", "lnk_1005744_PJMBASIC_PROJ");
				Function.AssertEqual(true,PJMBASIC_ACCTOrgLinksLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing Click on ACCTOrgLinksLink...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_ACCTOrgLinksLink = new SeleniumControl( sDriver, "ACCTOrgLinksLink", "ID", "lnk_1005744_PJMBASIC_PROJ");
				Function.WaitControlDisplayed(PJMBASIC_ACCTOrgLinksLink);
PJMBASIC_ACCTOrgLinksLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing VerifyExists on AcctOrgLinksForm...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_AcctOrgLinksForm = new SeleniumControl( sDriver, "AcctOrgLinksForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBASIC_ASGNACCTS_']/ancestor::form[1]");
				Function.AssertEqual(true,PJMBASIC_AcctOrgLinksForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing VerifyExists on AcctOrgLinks_Accounts...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_AcctOrgLinks_Accounts = new SeleniumControl( sDriver, "AcctOrgLinks_Accounts", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBASIC_ASGNACCTS_']/ancestor::form[1]/descendant::*[@id='ACCT_ID']");
				Function.AssertEqual(true,PJMBASIC_AcctOrgLinks_Accounts.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing Close on AcctOrgLinksForm...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_AcctOrgLinksForm = new SeleniumControl( sDriver, "AcctOrgLinksForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBASIC_ASGNACCTS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJMBASIC_AcctOrgLinksForm);
IWebElement formBttn = PJMBASIC_AcctOrgLinksForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("ACRN");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing VerifyExists on ACRNLink...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_ACRNLink = new SeleniumControl( sDriver, "ACRNLink", "ID", "lnk_16553_PJMBASIC_PROJ");
				Function.AssertEqual(true,PJMBASIC_ACRNLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing Click on ACRNLink...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_ACRNLink = new SeleniumControl( sDriver, "ACRNLink", "ID", "lnk_16553_PJMBASIC_PROJ");
				Function.WaitControlDisplayed(PJMBASIC_ACRNLink);
PJMBASIC_ACRNLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing VerifyExists on ACRNForm...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_ACRNForm = new SeleniumControl( sDriver, "ACRNForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PBM_ACRNBILL_PROJBILLACRN_HDR_']/ancestor::form[1]");
				Function.AssertEqual(true,PJMBASIC_ACRNForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing VerifyExists on ACRN_ACRNCalculations_ACRNProjectTotals_TotalProjectFunding...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_ACRN_ACRNCalculations_ACRNProjectTotals_TotalProjectFunding = new SeleniumControl( sDriver, "ACRN_ACRNCalculations_ACRNProjectTotals_TotalProjectFunding", "xpath", "//div[translate(@id,'0123456789','')='pr__PBM_ACRNBILL_PROJBILLACRN_HDR_']/ancestor::form[1]/descendant::*[@id='PROJ_F_TOT_AMT']");
				Function.AssertEqual(true,PJMBASIC_ACRN_ACRNCalculations_ACRNProjectTotals_TotalProjectFunding.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing ClickButton on ACRNForm...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_ACRNForm = new SeleniumControl( sDriver, "ACRNForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PBM_ACRNBILL_PROJBILLACRN_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJMBASIC_ACRNForm);
IWebElement formBttn = PJMBASIC_ACRNForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? PJMBASIC_ACRNForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
PJMBASIC_ACRNForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing VerifyExists on ACRNFormTable...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_ACRNFormTable = new SeleniumControl( sDriver, "ACRNFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PBM_ACRNBILL_PROJBILLACRN_HDR_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJMBASIC_ACRNFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing VerifyExist on ACRNDetailsTable...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_ACRNDetailsTable = new SeleniumControl( sDriver, "ACRNDetailsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PBM_ACRNBILL_PROJACRNDETL_CHLD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJMBASIC_ACRNDetailsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing ClickButton on ACRNDetailsForm...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_ACRNDetailsForm = new SeleniumControl( sDriver, "ACRNDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PBM_ACRNBILL_PROJACRNDETL_CHLD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJMBASIC_ACRNDetailsForm);
IWebElement formBttn = PJMBASIC_ACRNDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PJMBASIC_ACRNDetailsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PJMBASIC_ACRNDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing VerifyExists on ACRNDetailsForm...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_ACRNDetailsForm = new SeleniumControl( sDriver, "ACRNDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PBM_ACRNBILL_PROJACRNDETL_CHLD_']/ancestor::form[1]");
				Function.AssertEqual(true,PJMBASIC_ACRNDetailsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing VerifyExists on ACRNDetails_ACRN...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_ACRNDetails_ACRN = new SeleniumControl( sDriver, "ACRNDetails_ACRN", "xpath", "//div[translate(@id,'0123456789','')='pr__PBM_ACRNBILL_PROJACRNDETL_CHLD_']/ancestor::form[1]/descendant::*[@id='ACRN_ID']");
				Function.AssertEqual(true,PJMBASIC_ACRNDetails_ACRN.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing Close on ACRNForm...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_ACRNForm = new SeleniumControl( sDriver, "ACRNForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PBM_ACRNBILL_PROJBILLACRN_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJMBASIC_ACRNForm);
IWebElement formBttn = PJMBASIC_ACRNForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "PJMBASIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBASIC] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl PJMBASIC_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PJMBASIC_MainForm);
IWebElement formBttn = PJMBASIC_MainForm.mElement.FindElements(By.CssSelector("*[title*='Delete']")).Count <= 0 ? PJMBASIC_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Delete')]")).FirstOrDefault() :
PJMBASIC_MainForm.mElement.FindElements(By.CssSelector("*[title*='Delete']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Delete not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "CP7Main";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[CP7Main] Performing ClickToolbarButton on MainToolBar...", Logger.MessageType.INF);
				SeleniumControl CP7Main_MainToolBar = new SeleniumControl( sDriver, "MainToolBar", "ID", "tlbr");
				Function.WaitControlDisplayed(CP7Main_MainToolBar);
IWebElement tlbrBtn = CP7Main_MainToolBar.mElement.FindElements(By.XPath(".//*[@class='tbBtnContainer']//div[contains(@title,'Save')]")).FirstOrDefault();
if (tlbrBtn==null) throw new Exception("Unable to find button Save.");
tlbrBtn.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickToolbarButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "CP7Main";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[CP7Main] Performing SelectMenu on MainMenu...", Logger.MessageType.INF);
				SeleniumControl CP7Main_MainMenu = new SeleniumControl( sDriver, "MainMenu", "ID", "wMnuBar");
				new SeleniumControl(sDriver,"File", "xpath","//span[@class='wMnuHead'][.='FILE']").Click();
new SeleniumControl(sDriver,"Close Application", "xpath","//*[@class='wMnuPickLbl'][.='Close Application']").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SelectMenu]" , ex.Message));
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

