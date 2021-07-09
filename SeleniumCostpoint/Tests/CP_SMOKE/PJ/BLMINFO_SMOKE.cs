 
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
    public class BLMINFO_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Billing Master", "xpath","//div[@class='navItem'][.='Billing Master']").Click();
new SeleniumControl(sDriver,"Manage Project Billing Information", "xpath","//div[@class='navItem'][.='Manage Project Billing Information']").Click();


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
				Function.CurrentComponent = "BLMINFO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMINFO] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl BLMINFO_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,BLMINFO_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMINFO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMINFO] Performing VerifyExists on Project...", Logger.MessageType.INF);
				SeleniumControl BLMINFO_Project = new SeleniumControl( sDriver, "Project", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='INVC_PROJ_ID']");
				Function.AssertEqual(true,BLMINFO_Project.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMINFO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMINFO] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl BLMINFO_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(BLMINFO_MainFormTab);
IWebElement mTab = BLMINFO_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Setup Information").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMINFO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMINFO] Performing VerifyExists on SetupInformation_BillingFormula_BillingFormulaDescription...", Logger.MessageType.INF);
				SeleniumControl BLMINFO_SetupInformation_BillingFormula_BillingFormulaDescription = new SeleniumControl( sDriver, "SetupInformation_BillingFormula_BillingFormulaDescription", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='BILL_FORMULA_DESC']");
				Function.AssertEqual(true,BLMINFO_SetupInformation_BillingFormula_BillingFormulaDescription.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMINFO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMINFO] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl BLMINFO_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(BLMINFO_MainFormTab);
IWebElement mTab = BLMINFO_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "1443 Info").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMINFO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMINFO] Performing VerifyExists on 1443InfoRates_Rates_ProgressPayment...", Logger.MessageType.INF);
				SeleniumControl BLMINFO_1443InfoRates_Rates_ProgressPayment = new SeleniumControl( sDriver, "1443InfoRates_Rates_ProgressPayment", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PROGRESS_PMT_RT']");
				Function.AssertEqual(true,BLMINFO_1443InfoRates_Rates_ProgressPayment.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMINFO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMINFO] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl BLMINFO_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(BLMINFO_MainFormTab);
IWebElement mTab = BLMINFO_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Other Info").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMINFO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMINFO] Performing VerifyExists on OtherInfo_LimitTransactionsToPeriod...", Logger.MessageType.INF);
				SeleniumControl BLMINFO_OtherInfo_LimitTransactionsToPeriod = new SeleniumControl( sDriver, "OtherInfo_LimitTransactionsToPeriod", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='POP_FL']");
				Function.AssertEqual(true,BLMINFO_OtherInfo_LimitTransactionsToPeriod.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMINFO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMINFO] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl BLMINFO_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(BLMINFO_MainFormTab);
IWebElement mTab = BLMINFO_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Global Withholding").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMINFO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMINFO] Performing VerifyExists on GlobalWithholding_SubjectToWithholding...", Logger.MessageType.INF);
				SeleniumControl BLMINFO_GlobalWithholding_SubjectToWithholding = new SeleniumControl( sDriver, "GlobalWithholding_SubjectToWithholding", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='SUBJ_BILL_WH_FL']");
				Function.AssertEqual(true,BLMINFO_GlobalWithholding_SubjectToWithholding.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Details Levels");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMINFO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMINFO] Performing VerifyExists on DetailLevelsLink...", Logger.MessageType.INF);
				SeleniumControl BLMINFO_DetailLevelsLink = new SeleniumControl( sDriver, "DetailLevelsLink", "ID", "lnk_1002237_PBM_PROJBILLINFO_HDR");
				Function.AssertEqual(true,BLMINFO_DetailLevelsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMINFO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMINFO] Performing Click on DetailLevelsLink...", Logger.MessageType.INF);
				SeleniumControl BLMINFO_DetailLevelsLink = new SeleniumControl( sDriver, "DetailLevelsLink", "ID", "lnk_1002237_PBM_PROJBILLINFO_HDR");
				Function.WaitControlDisplayed(BLMINFO_DetailLevelsLink);
BLMINFO_DetailLevelsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMINFO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMINFO] Performing VerifyExist on DetailLevelsTable...", Logger.MessageType.INF);
				SeleniumControl BLMINFO_DetailLevelsTable = new SeleniumControl( sDriver, "DetailLevelsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PBM_PROJBILLINFOSCH_CHILD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BLMINFO_DetailLevelsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMINFO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMINFO] Performing Close on DetailLevelsForm...", Logger.MessageType.INF);
				SeleniumControl BLMINFO_DetailLevelsForm = new SeleniumControl( sDriver, "DetailLevelsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PBM_PROJBILLINFOSCH_CHILD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BLMINFO_DetailLevelsForm);
IWebElement formBttn = BLMINFO_DetailLevelsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Cash Basis");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMINFO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMINFO] Performing VerifyExists on CashBasisLink...", Logger.MessageType.INF);
				SeleniumControl BLMINFO_CashBasisLink = new SeleniumControl( sDriver, "CashBasisLink", "ID", "lnk_1002238_PBM_PROJBILLINFO_HDR");
				Function.AssertEqual(true,BLMINFO_CashBasisLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMINFO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMINFO] Performing Click on CashBasisLink...", Logger.MessageType.INF);
				SeleniumControl BLMINFO_CashBasisLink = new SeleniumControl( sDriver, "CashBasisLink", "ID", "lnk_1002238_PBM_PROJBILLINFO_HDR");
				Function.WaitControlDisplayed(BLMINFO_CashBasisLink);
BLMINFO_CashBasisLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMINFO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMINFO] Performing VerifyExist on CashBasisTable...", Logger.MessageType.INF);
				SeleniumControl BLMINFO_CashBasisTable = new SeleniumControl( sDriver, "CashBasisTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PBM_PROJCASHBASIS_CHILD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BLMINFO_CashBasisTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMINFO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMINFO] Performing Close on CashBasisForm...", Logger.MessageType.INF);
				SeleniumControl BLMINFO_CashBasisForm = new SeleniumControl( sDriver, "CashBasisForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PBM_PROJCASHBASIS_CHILD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BLMINFO_CashBasisForm);
IWebElement formBttn = BLMINFO_CashBasisForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Schedule");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMINFO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMINFO] Performing VerifyExists on ScheduleLink...", Logger.MessageType.INF);
				SeleniumControl BLMINFO_ScheduleLink = new SeleniumControl( sDriver, "ScheduleLink", "ID", "lnk_1002240_PBM_PROJBILLINFO_HDR");
				Function.AssertEqual(true,BLMINFO_ScheduleLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMINFO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMINFO] Performing Click on ScheduleLink...", Logger.MessageType.INF);
				SeleniumControl BLMINFO_ScheduleLink = new SeleniumControl( sDriver, "ScheduleLink", "ID", "lnk_1002240_PBM_PROJBILLINFO_HDR");
				Function.WaitControlDisplayed(BLMINFO_ScheduleLink);
BLMINFO_ScheduleLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMINFO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMINFO] Performing VerifyExist on ScheduleTable...", Logger.MessageType.INF);
				SeleniumControl BLMINFO_ScheduleTable = new SeleniumControl( sDriver, "ScheduleTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PBM_BILLSCHEDULE_CHILD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BLMINFO_ScheduleTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMINFO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMINFO] Performing ClickButton on ScheduleForm...", Logger.MessageType.INF);
				SeleniumControl BLMINFO_ScheduleForm = new SeleniumControl( sDriver, "ScheduleForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PBM_BILLSCHEDULE_CHILD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BLMINFO_ScheduleForm);
IWebElement formBttn = BLMINFO_ScheduleForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? BLMINFO_ScheduleForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
BLMINFO_ScheduleForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMINFO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMINFO] Performing VerifyExists on ScheduleForm...", Logger.MessageType.INF);
				SeleniumControl BLMINFO_ScheduleForm = new SeleniumControl( sDriver, "ScheduleForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PBM_BILLSCHEDULE_CHILD_']/ancestor::form[1]");
				Function.AssertEqual(true,BLMINFO_ScheduleForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMINFO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMINFO] Performing VerifyExists on Schedule_DateToBill...", Logger.MessageType.INF);
				SeleniumControl BLMINFO_Schedule_DateToBill = new SeleniumControl( sDriver, "Schedule_DateToBill", "xpath", "//div[translate(@id,'0123456789','')='pr__PBM_BILLSCHEDULE_CHILD_']/ancestor::form[1]/descendant::*[@id='BILL_SCHED_DT']");
				Function.AssertEqual(true,BLMINFO_Schedule_DateToBill.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMINFO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMINFO] Performing Close on ScheduleForm...", Logger.MessageType.INF);
				SeleniumControl BLMINFO_ScheduleForm = new SeleniumControl( sDriver, "ScheduleForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PBM_BILLSCHEDULE_CHILD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BLMINFO_ScheduleForm);
IWebElement formBttn = BLMINFO_ScheduleForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "BLMINFO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMINFO] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl BLMINFO_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(BLMINFO_MainForm);
IWebElement formBttn = BLMINFO_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

