 
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
    public class PJQPROJL_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Project Inquiry and Reporting", "xpath","//div[@class='deptItem'][.='Project Inquiry and Reporting']").Click();
new SeleniumControl(sDriver,"Project Reports/Inquiries", "xpath","//div[@class='navItem'][.='Project Reports/Inquiries']").Click();
new SeleniumControl(sDriver,"View Project Ledger Activity", "xpath","//div[@class='navItem'][.='View Project Ledger Activity']").Click();


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
				Function.CurrentComponent = "PJQPROJL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJL] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl PJQPROJL_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,PJQPROJL_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJL] Performing VerifyExists on FiscalYear...", Logger.MessageType.INF);
				SeleniumControl PJQPROJL_FiscalYear = new SeleniumControl( sDriver, "FiscalYear", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='FY_CD']");
				Function.AssertEqual(true,PJQPROJL_FiscalYear.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Inquiry Summaries");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJL] Performing VerifyExists on InquirySummariesForm...", Logger.MessageType.INF);
				SeleniumControl PJQPROJL_InquirySummariesForm = new SeleniumControl( sDriver, "InquirySummariesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQPROJL_PROJSUM_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,PJQPROJL_InquirySummariesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJL] Performing VerifyExist on InquirySummariesFormTable...", Logger.MessageType.INF);
				SeleniumControl PJQPROJL_InquirySummariesFormTable = new SeleniumControl( sDriver, "InquirySummariesFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQPROJL_PROJSUM_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJQPROJL_InquirySummariesFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJL] Performing ClickButton on InquirySummariesForm...", Logger.MessageType.INF);
				SeleniumControl PJQPROJL_InquirySummariesForm = new SeleniumControl( sDriver, "InquirySummariesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQPROJL_PROJSUM_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJQPROJL_InquirySummariesForm);
IWebElement formBttn = PJQPROJL_InquirySummariesForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).Count <= 0 ? PJQPROJL_InquirySummariesForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Query')]")).FirstOrDefault() :
PJQPROJL_InquirySummariesForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).FirstOrDefault();
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
				Function.CurrentComponent = "PJQPROJL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJL] Performing ClickButton on InquirySummariesForm...", Logger.MessageType.INF);
				SeleniumControl PJQPROJL_InquirySummariesForm = new SeleniumControl( sDriver, "InquirySummariesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQPROJL_PROJSUM_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJQPROJL_InquirySummariesForm);
IWebElement formBttn = PJQPROJL_InquirySummariesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PJQPROJL_InquirySummariesForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PJQPROJL_InquirySummariesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJL] Performing Select on InquirySummariesTab...", Logger.MessageType.INF);
				SeleniumControl PJQPROJL_InquirySummariesTab = new SeleniumControl( sDriver, "InquirySummariesTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQPROJL_PROJSUM_CTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PJQPROJL_InquirySummariesTab);
IWebElement mTab = PJQPROJL_InquirySummariesTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "POA").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJL] Performing VerifyExists on InquirySummaries_POA_PROJ_ID...", Logger.MessageType.INF);
				SeleniumControl PJQPROJL_InquirySummaries_POA_PROJ_ID = new SeleniumControl( sDriver, "InquirySummaries_POA_PROJ_ID", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQPROJL_PROJSUM_CTW_']/ancestor::form[1]/descendant::*[@id='PROJ_ID']");
				Function.AssertEqual(true,PJQPROJL_InquirySummaries_POA_PROJ_ID.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJL] Performing Select on InquirySummariesTab...", Logger.MessageType.INF);
				SeleniumControl PJQPROJL_InquirySummariesTab = new SeleniumControl( sDriver, "InquirySummariesTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQPROJL_PROJSUM_CTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PJQPROJL_InquirySummariesTab);
IWebElement mTab = PJQPROJL_InquirySummariesTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Other Summary").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJL] Performing VerifyExists on InquirySummaries_OtherSummary_FeeSummary_FEE_BURD_ACT_AMT...", Logger.MessageType.INF);
				SeleniumControl PJQPROJL_InquirySummaries_OtherSummary_FeeSummary_FEE_BURD_ACT_AMT = new SeleniumControl( sDriver, "InquirySummaries_OtherSummary_FeeSummary_FEE_BURD_ACT_AMT", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQPROJL_PROJSUM_CTW_']/ancestor::form[1]/descendant::*[@id='FEE_BURD_ACT_AMT']");
				Function.AssertEqual(true,PJQPROJL_InquirySummaries_OtherSummary_FeeSummary_FEE_BURD_ACT_AMT.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJL] Performing Select on InquirySummariesTab...", Logger.MessageType.INF);
				SeleniumControl PJQPROJL_InquirySummariesTab = new SeleniumControl( sDriver, "InquirySummariesTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQPROJL_PROJSUM_CTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PJQPROJL_InquirySummariesTab);
IWebElement mTab = PJQPROJL_InquirySummariesTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "YTD Summary").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJL] Performing VerifyExists on InquirySummaries_YTDSummary_YTD_DIR_AMT...", Logger.MessageType.INF);
				SeleniumControl PJQPROJL_InquirySummaries_YTDSummary_YTD_DIR_AMT = new SeleniumControl( sDriver, "InquirySummaries_YTDSummary_YTD_DIR_AMT", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQPROJL_PROJSUM_CTW_']/ancestor::form[1]/descendant::*[@id='YTD_DIR_AMT']");
				Function.AssertEqual(true,PJQPROJL_InquirySummaries_YTDSummary_YTD_DIR_AMT.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJL] Performing Select on InquirySummariesTab...", Logger.MessageType.INF);
				SeleniumControl PJQPROJL_InquirySummariesTab = new SeleniumControl( sDriver, "InquirySummariesTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQPROJL_PROJSUM_CTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PJQPROJL_InquirySummariesTab);
IWebElement mTab = PJQPROJL_InquirySummariesTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "PTD Summary").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJL] Performing VerifyExists on InquirySummaries_PTDSummary_PTD_DIR_AMT...", Logger.MessageType.INF);
				SeleniumControl PJQPROJL_InquirySummaries_PTDSummary_PTD_DIR_AMT = new SeleniumControl( sDriver, "InquirySummaries_PTDSummary_PTD_DIR_AMT", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQPROJL_PROJSUM_CTW_']/ancestor::form[1]/descendant::*[@id='PTD_DIR_AMT']");
				Function.AssertEqual(true,PJQPROJL_InquirySummaries_PTDSummary_PTD_DIR_AMT.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJL] Performing Select on InquirySummariesTab...", Logger.MessageType.INF);
				SeleniumControl PJQPROJL_InquirySummariesTab = new SeleniumControl( sDriver, "InquirySummariesTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQPROJL_PROJSUM_CTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PJQPROJL_InquirySummariesTab);
IWebElement mTab = PJQPROJL_InquirySummariesTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Subperiod Summary").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJL] Performing VerifyExists on InquirySummaries_SubperiodSummary_SUB_DIR_AMT...", Logger.MessageType.INF);
				SeleniumControl PJQPROJL_InquirySummaries_SubperiodSummary_SUB_DIR_AMT = new SeleniumControl( sDriver, "InquirySummaries_SubperiodSummary_SUB_DIR_AMT", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQPROJL_PROJSUM_CTW_']/ancestor::form[1]/descendant::*[@id='SUB_DIR_AMT']");
				Function.AssertEqual(true,PJQPROJL_InquirySummaries_SubperiodSummary_SUB_DIR_AMT.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJL] Performing Select on InquirySummariesTab...", Logger.MessageType.INF);
				SeleniumControl PJQPROJL_InquirySummariesTab = new SeleniumControl( sDriver, "InquirySummariesTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQPROJL_PROJSUM_CTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PJQPROJL_InquirySummariesTab);
IWebElement mTab = PJQPROJL_InquirySummariesTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Award Fee Summary").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJL] Performing VerifyExists on InquirySummaries_AwardFeeSummary_AWARD_FEE_ACT_AMT...", Logger.MessageType.INF);
				SeleniumControl PJQPROJL_InquirySummaries_AwardFeeSummary_AWARD_FEE_ACT_AMT = new SeleniumControl( sDriver, "InquirySummaries_AwardFeeSummary_AWARD_FEE_ACT_AMT", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQPROJL_PROJSUM_CTW_']/ancestor::form[1]/descendant::*[@id='AWARD_FEE_ACT_AMT']");
				Function.AssertEqual(true,PJQPROJL_InquirySummaries_AwardFeeSummary_AWARD_FEE_ACT_AMT.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJL] Performing Select on InquirySummariesTab...", Logger.MessageType.INF);
				SeleniumControl PJQPROJL_InquirySummariesTab = new SeleniumControl( sDriver, "InquirySummariesTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQPROJL_PROJSUM_CTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PJQPROJL_InquirySummariesTab);
IWebElement mTab = PJQPROJL_InquirySummariesTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Totals").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJL] Performing VerifyExists on InquirySummaries_Totals_TOT_ACT_AL_EXP_AMT...", Logger.MessageType.INF);
				SeleniumControl PJQPROJL_InquirySummaries_Totals_TOT_ACT_AL_EXP_AMT = new SeleniumControl( sDriver, "InquirySummaries_Totals_TOT_ACT_AL_EXP_AMT", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQPROJL_PROJSUM_CTW_']/ancestor::form[1]/descendant::*[@id='TOT_ACT_AL_EXP_AMT']");
				Function.AssertEqual(true,PJQPROJL_InquirySummaries_Totals_TOT_ACT_AL_EXP_AMT.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJL] Performing VerifyExists on InquirySummaries_DetailLink...", Logger.MessageType.INF);
				SeleniumControl PJQPROJL_InquirySummaries_DetailLink = new SeleniumControl( sDriver, "InquirySummaries_DetailLink", "ID", "lnk_1004998_PJQPROJL_PROJSUM_CTW");
				Function.AssertEqual(true,PJQPROJL_InquirySummaries_DetailLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJL] Performing Click on InquirySummaries_DetailLink...", Logger.MessageType.INF);
				SeleniumControl PJQPROJL_InquirySummaries_DetailLink = new SeleniumControl( sDriver, "InquirySummaries_DetailLink", "ID", "lnk_1004998_PJQPROJL_PROJSUM_CTW");
				Function.WaitControlDisplayed(PJQPROJL_InquirySummaries_DetailLink);
PJQPROJL_InquirySummaries_DetailLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Detail");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJL] Performing VerifyExists on InquirySummaries_DetailForm...", Logger.MessageType.INF);
				SeleniumControl PJQPROJL_InquirySummaries_DetailForm = new SeleniumControl( sDriver, "InquirySummaries_DetailForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQPROJL_PROJSUM_']/ancestor::form[1]");
				Function.AssertEqual(true,PJQPROJL_InquirySummaries_DetailForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJL] Performing VerifyExist on InquirySummaries_DetailFormTable...", Logger.MessageType.INF);
				SeleniumControl PJQPROJL_InquirySummaries_DetailFormTable = new SeleniumControl( sDriver, "InquirySummaries_DetailFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQPROJL_PROJSUM_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJQPROJL_InquirySummaries_DetailFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJL] Performing ClickButton on InquirySummaries_DetailForm...", Logger.MessageType.INF);
				SeleniumControl PJQPROJL_InquirySummaries_DetailForm = new SeleniumControl( sDriver, "InquirySummaries_DetailForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQPROJL_PROJSUM_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJQPROJL_InquirySummaries_DetailForm);
IWebElement formBttn = PJQPROJL_InquirySummaries_DetailForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PJQPROJL_InquirySummaries_DetailForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PJQPROJL_InquirySummaries_DetailForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJL] Performing Select on InquirySummaries_DetailTab...", Logger.MessageType.INF);
				SeleniumControl PJQPROJL_InquirySummaries_DetailTab = new SeleniumControl( sDriver, "InquirySummaries_DetailTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQPROJL_PROJSUM_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PJQPROJL_InquirySummaries_DetailTab);
IWebElement mTab = PJQPROJL_InquirySummaries_DetailTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "POA Details").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJL] Performing VerifyExists on InquirySummaries_Detail_POADetails_Totals_PROJ_ID...", Logger.MessageType.INF);
				SeleniumControl PJQPROJL_InquirySummaries_Detail_POADetails_Totals_PROJ_ID = new SeleniumControl( sDriver, "InquirySummaries_Detail_POADetails_Totals_PROJ_ID", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQPROJL_PROJSUM_']/ancestor::form[1]/descendant::*[@id='PROJ_ID']");
				Function.AssertEqual(true,PJQPROJL_InquirySummaries_Detail_POADetails_Totals_PROJ_ID.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJL] Performing Select on InquirySummaries_DetailTab...", Logger.MessageType.INF);
				SeleniumControl PJQPROJL_InquirySummaries_DetailTab = new SeleniumControl( sDriver, "InquirySummaries_DetailTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQPROJL_PROJSUM_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PJQPROJL_InquirySummaries_DetailTab);
IWebElement mTab = PJQPROJL_InquirySummaries_DetailTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Other Details").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJL] Performing VerifyExists on InquirySummaries_Detail_OtherDetails_FeeDetails_FEE_BURD_ACT_AMT...", Logger.MessageType.INF);
				SeleniumControl PJQPROJL_InquirySummaries_Detail_OtherDetails_FeeDetails_FEE_BURD_ACT_AMT = new SeleniumControl( sDriver, "InquirySummaries_Detail_OtherDetails_FeeDetails_FEE_BURD_ACT_AMT", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQPROJL_PROJSUM_']/ancestor::form[1]/descendant::*[@id='FEE_BURD_ACT_AMT']");
				Function.AssertEqual(true,PJQPROJL_InquirySummaries_Detail_OtherDetails_FeeDetails_FEE_BURD_ACT_AMT.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJL] Performing Select on InquirySummaries_DetailTab...", Logger.MessageType.INF);
				SeleniumControl PJQPROJL_InquirySummaries_DetailTab = new SeleniumControl( sDriver, "InquirySummaries_DetailTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQPROJL_PROJSUM_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PJQPROJL_InquirySummaries_DetailTab);
IWebElement mTab = PJQPROJL_InquirySummaries_DetailTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "YTD Details").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJL] Performing VerifyExists on InquirySummaries_Detail_YTDDetails_YTD_DIR_AMT...", Logger.MessageType.INF);
				SeleniumControl PJQPROJL_InquirySummaries_Detail_YTDDetails_YTD_DIR_AMT = new SeleniumControl( sDriver, "InquirySummaries_Detail_YTDDetails_YTD_DIR_AMT", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQPROJL_PROJSUM_']/ancestor::form[1]/descendant::*[@id='YTD_DIR_AMT']");
				Function.AssertEqual(true,PJQPROJL_InquirySummaries_Detail_YTDDetails_YTD_DIR_AMT.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJL] Performing Select on InquirySummaries_DetailTab...", Logger.MessageType.INF);
				SeleniumControl PJQPROJL_InquirySummaries_DetailTab = new SeleniumControl( sDriver, "InquirySummaries_DetailTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQPROJL_PROJSUM_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PJQPROJL_InquirySummaries_DetailTab);
IWebElement mTab = PJQPROJL_InquirySummaries_DetailTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "PTD Details").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJL] Performing VerifyExists on InquirySummaries_Detail_PTDDetails_PTD_DIR_AMT...", Logger.MessageType.INF);
				SeleniumControl PJQPROJL_InquirySummaries_Detail_PTDDetails_PTD_DIR_AMT = new SeleniumControl( sDriver, "InquirySummaries_Detail_PTDDetails_PTD_DIR_AMT", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQPROJL_PROJSUM_']/ancestor::form[1]/descendant::*[@id='PTD_DIR_AMT']");
				Function.AssertEqual(true,PJQPROJL_InquirySummaries_Detail_PTDDetails_PTD_DIR_AMT.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJL] Performing Select on InquirySummaries_DetailTab...", Logger.MessageType.INF);
				SeleniumControl PJQPROJL_InquirySummaries_DetailTab = new SeleniumControl( sDriver, "InquirySummaries_DetailTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQPROJL_PROJSUM_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PJQPROJL_InquirySummaries_DetailTab);
IWebElement mTab = PJQPROJL_InquirySummaries_DetailTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Subperiod Details").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJL] Performing VerifyExists on InquirySummaries_Detail_SubperiodDetails_SUB_DIR_AMT...", Logger.MessageType.INF);
				SeleniumControl PJQPROJL_InquirySummaries_Detail_SubperiodDetails_SUB_DIR_AMT = new SeleniumControl( sDriver, "InquirySummaries_Detail_SubperiodDetails_SUB_DIR_AMT", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQPROJL_PROJSUM_']/ancestor::form[1]/descendant::*[@id='SUB_DIR_AMT']");
				Function.AssertEqual(true,PJQPROJL_InquirySummaries_Detail_SubperiodDetails_SUB_DIR_AMT.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJL] Performing Select on InquirySummaries_DetailTab...", Logger.MessageType.INF);
				SeleniumControl PJQPROJL_InquirySummaries_DetailTab = new SeleniumControl( sDriver, "InquirySummaries_DetailTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQPROJL_PROJSUM_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PJQPROJL_InquirySummaries_DetailTab);
IWebElement mTab = PJQPROJL_InquirySummaries_DetailTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Totals").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJL] Performing VerifyExists on InquirySummaries_Detail_Totals_TOT_ACT_AL_EXP_AMTLabel...", Logger.MessageType.INF);
				SeleniumControl PJQPROJL_InquirySummaries_Detail_Totals_TOT_ACT_AL_EXP_AMTLabel = new SeleniumControl( sDriver, "InquirySummaries_Detail_Totals_TOT_ACT_AL_EXP_AMTLabel", "xpath", "//input[@id='POST_SEQ_NO']/ancestor::form[1]/descendant::*[@id='TOT_ACT_AL_EXP_AMT']/preceding-sibling::span[1]");
				Function.AssertEqual(true,PJQPROJL_InquirySummaries_Detail_Totals_TOT_ACT_AL_EXP_AMTLabel.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Close Main Form");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJL] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl PJQPROJL_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PJQPROJL_MainForm);
IWebElement formBttn = PJQPROJL_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

