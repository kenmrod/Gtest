 
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
    public class OEMISSU2_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Sales Order Material Processing", "xpath","//div[@class='navItem'][.='Sales Order Material Processing']").Click();
new SeleniumControl(sDriver,"Manage Sales Order Non-Inventory Issues", "xpath","//div[@class='navItem'][.='Manage Sales Order Non-Inventory Issues']").Click();


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
				Function.CurrentComponent = "OEMISSU2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMISSU2] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl OEMISSU2_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,OEMISSU2_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMISSU2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMISSU2] Performing VerifyExists on Identification_IssueID...", Logger.MessageType.INF);
				SeleniumControl OEMISSU2_Identification_IssueID = new SeleniumControl( sDriver, "Identification_IssueID", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='SO_ISSUE_ID']");
				Function.AssertEqual(true,OEMISSU2_Identification_IssueID.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMISSU2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMISSU2] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl OEMISSU2_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(OEMISSU2_MainForm);
IWebElement formBttn = OEMISSU2_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? OEMISSU2_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
OEMISSU2_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMISSU2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMISSU2] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl OEMISSU2_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,OEMISSU2_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMISSU2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMISSU2] Performing VerifyExists on AutoloadTable...", Logger.MessageType.INF);
				SeleniumControl OEMISSU2_AutoloadTable = new SeleniumControl( sDriver, "AutoloadTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PB_AUTOLOADISSUE___T']");
				Function.AssertEqual(true,OEMISSU2_AutoloadTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Accounting Period Form");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMISSU2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMISSU2] Performing VerifyExists on AccountingPeriodLink...", Logger.MessageType.INF);
				SeleniumControl OEMISSU2_AccountingPeriodLink = new SeleniumControl( sDriver, "AccountingPeriodLink", "ID", "lnk_3243_OEMISSU_SOISSUEHDR_SALESISSUE");
				Function.AssertEqual(true,OEMISSU2_AccountingPeriodLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMISSU2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMISSU2] Performing Click on AccountingPeriodLink...", Logger.MessageType.INF);
				SeleniumControl OEMISSU2_AccountingPeriodLink = new SeleniumControl( sDriver, "AccountingPeriodLink", "ID", "lnk_3243_OEMISSU_SOISSUEHDR_SALESISSUE");
				Function.WaitControlDisplayed(OEMISSU2_AccountingPeriodLink);
OEMISSU2_AccountingPeriodLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMISSU2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMISSU2] Performing VerifyExists on AccountingPeriodForm...", Logger.MessageType.INF);
				SeleniumControl OEMISSU2_AccountingPeriodForm = new SeleniumControl( sDriver, "AccountingPeriodForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMACCPD_HDR_']/ancestor::form[1]");
				Function.AssertEqual(true,OEMISSU2_AccountingPeriodForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMISSU2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMISSU2] Performing VerifyExists on AccountingPeriod_FiscalYear...", Logger.MessageType.INF);
				SeleniumControl OEMISSU2_AccountingPeriod_FiscalYear = new SeleniumControl( sDriver, "AccountingPeriod_FiscalYear", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMACCPD_HDR_']/ancestor::form[1]/descendant::*[@id='DFS_FYCD_ST']");
				Function.AssertEqual(true,OEMISSU2_AccountingPeriod_FiscalYear.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMISSU2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMISSU2] Performing ClickButton on AccountingPeriodForm...", Logger.MessageType.INF);
				SeleniumControl OEMISSU2_AccountingPeriodForm = new SeleniumControl( sDriver, "AccountingPeriodForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMACCPD_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMISSU2_AccountingPeriodForm);
IWebElement formBttn = OEMISSU2_AccountingPeriodForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? OEMISSU2_AccountingPeriodForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
OEMISSU2_AccountingPeriodForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMISSU2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMISSU2] Performing VerifyExist on AccountingPeriodFormTable...", Logger.MessageType.INF);
				SeleniumControl OEMISSU2_AccountingPeriodFormTable = new SeleniumControl( sDriver, "AccountingPeriodFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMACCPD_HDR_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,OEMISSU2_AccountingPeriodFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMISSU2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMISSU2] Performing Close on AccountingPeriodForm...", Logger.MessageType.INF);
				SeleniumControl OEMISSU2_AccountingPeriodForm = new SeleniumControl( sDriver, "AccountingPeriodForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMACCPD_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMISSU2_AccountingPeriodForm);
IWebElement formBttn = OEMISSU2_AccountingPeriodForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Header Documents Form");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMISSU2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMISSU2] Performing VerifyExists on HeaderDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl OEMISSU2_HeaderDocumentsLink = new SeleniumControl( sDriver, "HeaderDocumentsLink", "ID", "lnk_1007711_OEMISSU_SOISSUEHDR_SALESISSUE");
				Function.AssertEqual(true,OEMISSU2_HeaderDocumentsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMISSU2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMISSU2] Performing Click on HeaderDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl OEMISSU2_HeaderDocumentsLink = new SeleniumControl( sDriver, "HeaderDocumentsLink", "ID", "lnk_1007711_OEMISSU_SOISSUEHDR_SALESISSUE");
				Function.WaitControlDisplayed(OEMISSU2_HeaderDocumentsLink);
OEMISSU2_HeaderDocumentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMISSU2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMISSU2] Performing VerifyExist on HeaderDocumentsFormTable...", Logger.MessageType.INF);
				SeleniumControl OEMISSU2_HeaderDocumentsFormTable = new SeleniumControl( sDriver, "HeaderDocumentsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMISSU_DOCUMENTS_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,OEMISSU2_HeaderDocumentsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMISSU2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMISSU2] Performing ClickButton on HeaderDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl OEMISSU2_HeaderDocumentsForm = new SeleniumControl( sDriver, "HeaderDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMISSU_DOCUMENTS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMISSU2_HeaderDocumentsForm);
IWebElement formBttn = OEMISSU2_HeaderDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? OEMISSU2_HeaderDocumentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
OEMISSU2_HeaderDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMISSU2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMISSU2] Performing VerifyExists on HeaderDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl OEMISSU2_HeaderDocumentsForm = new SeleniumControl( sDriver, "HeaderDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMISSU_DOCUMENTS_']/ancestor::form[1]");
				Function.AssertEqual(true,OEMISSU2_HeaderDocumentsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMISSU2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMISSU2] Performing VerifyExists on HeaderDocuments_Document...", Logger.MessageType.INF);
				SeleniumControl OEMISSU2_HeaderDocuments_Document = new SeleniumControl( sDriver, "HeaderDocuments_Document", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMISSU_DOCUMENTS_']/ancestor::form[1]/descendant::*[@id='DOCUMENT_ID']");
				Function.AssertEqual(true,OEMISSU2_HeaderDocuments_Document.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMISSU2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMISSU2] Performing Close on HeaderDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl OEMISSU2_HeaderDocumentsForm = new SeleniumControl( sDriver, "HeaderDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMISSU_DOCUMENTS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMISSU2_HeaderDocumentsForm);
IWebElement formBttn = OEMISSU2_HeaderDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("SO Issue Lines");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMISSU2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMISSU2] Performing VerifyExist on ChildFormTable...", Logger.MessageType.INF);
				SeleniumControl OEMISSU2_ChildFormTable = new SeleniumControl( sDriver, "ChildFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMISSU_WORKTABLE_TEMP_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,OEMISSU2_ChildFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMISSU2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMISSU2] Performing ClickButton on ChildForm...", Logger.MessageType.INF);
				SeleniumControl OEMISSU2_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMISSU_WORKTABLE_TEMP_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMISSU2_ChildForm);
IWebElement formBttn = OEMISSU2_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? OEMISSU2_ChildForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
OEMISSU2_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMISSU2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMISSU2] Performing VerifyExists on ChildForm...", Logger.MessageType.INF);
				SeleniumControl OEMISSU2_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMISSU_WORKTABLE_TEMP_']/ancestor::form[1]");
				Function.AssertEqual(true,OEMISSU2_ChildForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMISSU2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMISSU2] Performing VerifyExists on ChildForm_SOLine...", Logger.MessageType.INF);
				SeleniumControl OEMISSU2_ChildForm_SOLine = new SeleniumControl( sDriver, "ChildForm_SOLine", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMISSU_WORKTABLE_TEMP_']/ancestor::form[1]/descendant::*[@id='SO_LN_NO']");
				Function.AssertEqual(true,OEMISSU2_ChildForm_SOLine.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMISSU2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMISSU2] Performing Select on ChildFormTab...", Logger.MessageType.INF);
				SeleniumControl OEMISSU2_ChildFormTab = new SeleniumControl( sDriver, "ChildFormTab", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMISSU_WORKTABLE_TEMP_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(OEMISSU2_ChildFormTab);
IWebElement mTab = OEMISSU2_ChildFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Issue Details").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMISSU2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMISSU2] Performing VerifyExists on ChildForm_IssueDetails_Item...", Logger.MessageType.INF);
				SeleniumControl OEMISSU2_ChildForm_IssueDetails_Item = new SeleniumControl( sDriver, "ChildForm_IssueDetails_Item", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMISSU_WORKTABLE_TEMP_']/ancestor::form[1]/descendant::*[@id='ITEM_ID']");
				Function.AssertEqual(true,OEMISSU2_ChildForm_IssueDetails_Item.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMISSU2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMISSU2] Performing Select on ChildFormTab...", Logger.MessageType.INF);
				SeleniumControl OEMISSU2_ChildFormTab = new SeleniumControl( sDriver, "ChildFormTab", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMISSU_WORKTABLE_TEMP_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(OEMISSU2_ChildFormTab);
IWebElement mTab = OEMISSU2_ChildFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "SO Line Details").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMISSU2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMISSU2] Performing VerifyExists on ChildForm_SOLineDetails_SOUM...", Logger.MessageType.INF);
				SeleniumControl OEMISSU2_ChildForm_SOLineDetails_SOUM = new SeleniumControl( sDriver, "ChildForm_SOLineDetails_SOUM", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMISSU_WORKTABLE_TEMP_']/ancestor::form[1]/descendant::*[@id='UM_CD']");
				Function.AssertEqual(true,OEMISSU2_ChildForm_SOLineDetails_SOUM.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMISSU2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMISSU2] Performing Select on ChildFormTab...", Logger.MessageType.INF);
				SeleniumControl OEMISSU2_ChildFormTab = new SeleniumControl( sDriver, "ChildFormTab", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMISSU_WORKTABLE_TEMP_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(OEMISSU2_ChildFormTab);
IWebElement mTab = OEMISSU2_ChildFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Notes").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMISSU2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMISSU2] Performing VerifyExists on ChildForm_Notes_Notes...", Logger.MessageType.INF);
				SeleniumControl OEMISSU2_ChildForm_Notes_Notes = new SeleniumControl( sDriver, "ChildForm_Notes_Notes", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMISSU_WORKTABLE_TEMP_']/ancestor::form[1]/descendant::*[@id='SO_ISSUE_LN_NOTES']");
				Function.AssertEqual(true,OEMISSU2_ChildForm_Notes_Notes.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Serial/Lot Info Form");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMISSU2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMISSU2] Performing VerifyExists on ChildForm_SerialLotInfoLink...", Logger.MessageType.INF);
				SeleniumControl OEMISSU2_ChildForm_SerialLotInfoLink = new SeleniumControl( sDriver, "ChildForm_SerialLotInfoLink", "ID", "lnk_1007510_OEMISSU_WORKTABLE_TEMP");
				Function.AssertEqual(true,OEMISSU2_ChildForm_SerialLotInfoLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMISSU2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMISSU2] Performing Click on ChildForm_SerialLotInfoLink...", Logger.MessageType.INF);
				SeleniumControl OEMISSU2_ChildForm_SerialLotInfoLink = new SeleniumControl( sDriver, "ChildForm_SerialLotInfoLink", "ID", "lnk_1007510_OEMISSU_WORKTABLE_TEMP");
				Function.WaitControlDisplayed(OEMISSU2_ChildForm_SerialLotInfoLink);
OEMISSU2_ChildForm_SerialLotInfoLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMISSU2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMISSU2] Performing VerifyExist on ChildForm_SerialLotInfoFormTable...", Logger.MessageType.INF);
				SeleniumControl OEMISSU2_ChildForm_SerialLotInfoFormTable = new SeleniumControl( sDriver, "ChildForm_SerialLotInfoFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMISSU_INVTTRNLNSRLT_CHILD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,OEMISSU2_ChildForm_SerialLotInfoFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMISSU2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMISSU2] Performing VerifyExists on ChildForm_SerialLotInfo_GenerateUIDsTable...", Logger.MessageType.INF);
				SeleniumControl OEMISSU2_ChildForm_SerialLotInfo_GenerateUIDsTable = new SeleniumControl( sDriver, "ChildForm_SerialLotInfo_GenerateUIDsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMISSU_INVTTRNLNSRLT_CHILD_']/ancestor::form[1]/descendant::*[@id='GENERATE_UID___T']");
				Function.AssertEqual(true,OEMISSU2_ChildForm_SerialLotInfo_GenerateUIDsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMISSU2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMISSU2] Performing ClickButton on ChildForm_SerialLotInfoForm...", Logger.MessageType.INF);
				SeleniumControl OEMISSU2_ChildForm_SerialLotInfoForm = new SeleniumControl( sDriver, "ChildForm_SerialLotInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMISSU_INVTTRNLNSRLT_CHILD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMISSU2_ChildForm_SerialLotInfoForm);
IWebElement formBttn = OEMISSU2_ChildForm_SerialLotInfoForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? OEMISSU2_ChildForm_SerialLotInfoForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
OEMISSU2_ChildForm_SerialLotInfoForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMISSU2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMISSU2] Performing VerifyExists on ChildForm_SerialLotInfoForm...", Logger.MessageType.INF);
				SeleniumControl OEMISSU2_ChildForm_SerialLotInfoForm = new SeleniumControl( sDriver, "ChildForm_SerialLotInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMISSU_INVTTRNLNSRLT_CHILD_']/ancestor::form[1]");
				Function.AssertEqual(true,OEMISSU2_ChildForm_SerialLotInfoForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMISSU2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMISSU2] Performing VerifyExists on ChildForm_SerialLotInfo_SerialNumber...", Logger.MessageType.INF);
				SeleniumControl OEMISSU2_ChildForm_SerialLotInfo_SerialNumber = new SeleniumControl( sDriver, "ChildForm_SerialLotInfo_SerialNumber", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMISSU_INVTTRNLNSRLT_CHILD_']/ancestor::form[1]/descendant::*[@id='SERIAL_ID']");
				Function.AssertEqual(true,OEMISSU2_ChildForm_SerialLotInfo_SerialNumber.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMISSU2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMISSU2] Performing Select on ChildForm_SerialLotInfo_SerialLotInfoTab...", Logger.MessageType.INF);
				SeleniumControl OEMISSU2_ChildForm_SerialLotInfo_SerialLotInfoTab = new SeleniumControl( sDriver, "ChildForm_SerialLotInfo_SerialLotInfoTab", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMISSU_INVTTRNLNSRLT_CHILD_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(OEMISSU2_ChildForm_SerialLotInfo_SerialLotInfoTab);
IWebElement mTab = OEMISSU2_ChildForm_SerialLotInfo_SerialLotInfoTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Basic Information").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMISSU2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMISSU2] Performing VerifyExists on ChildForm_SerialLotInfo_BasicInformation_AvailableQuantity...", Logger.MessageType.INF);
				SeleniumControl OEMISSU2_ChildForm_SerialLotInfo_BasicInformation_AvailableQuantity = new SeleniumControl( sDriver, "ChildForm_SerialLotInfo_BasicInformation_AvailableQuantity", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMISSU_INVTTRNLNSRLT_CHILD_']/ancestor::form[1]/descendant::*[@id='TOT_IWL_QTY']");
				Function.AssertEqual(true,OEMISSU2_ChildForm_SerialLotInfo_BasicInformation_AvailableQuantity.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMISSU2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMISSU2] Performing Select on ChildForm_SerialLotInfo_SerialLotInfoTab...", Logger.MessageType.INF);
				SeleniumControl OEMISSU2_ChildForm_SerialLotInfo_SerialLotInfoTab = new SeleniumControl( sDriver, "ChildForm_SerialLotInfo_SerialLotInfoTab", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMISSU_INVTTRNLNSRLT_CHILD_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(OEMISSU2_ChildForm_SerialLotInfo_SerialLotInfoTab);
IWebElement mTab = OEMISSU2_ChildForm_SerialLotInfo_SerialLotInfoTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Manufacturer/Vendor Information").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMISSU2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMISSU2] Performing VerifyExists on ChildForm_SerialLotInfo_ManufacturerVendorInformation_Manufacturer_Manufacturer...", Logger.MessageType.INF);
				SeleniumControl OEMISSU2_ChildForm_SerialLotInfo_ManufacturerVendorInformation_Manufacturer_Manufacturer = new SeleniumControl( sDriver, "ChildForm_SerialLotInfo_ManufacturerVendorInformation_Manufacturer_Manufacturer", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMISSU_INVTTRNLNSRLT_CHILD_']/ancestor::form[1]/descendant::*[@id='MANUF_ID']");
				Function.AssertEqual(true,OEMISSU2_ChildForm_SerialLotInfo_ManufacturerVendorInformation_Manufacturer_Manufacturer.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMISSU2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMISSU2] Performing Select on ChildForm_SerialLotInfo_SerialLotInfoTab...", Logger.MessageType.INF);
				SeleniumControl OEMISSU2_ChildForm_SerialLotInfo_SerialLotInfoTab = new SeleniumControl( sDriver, "ChildForm_SerialLotInfo_SerialLotInfoTab", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMISSU_INVTTRNLNSRLT_CHILD_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(OEMISSU2_ChildForm_SerialLotInfo_SerialLotInfoTab);
IWebElement mTab = OEMISSU2_ChildForm_SerialLotInfo_SerialLotInfoTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Sales Order/Warranty Information").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMISSU2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMISSU2] Performing VerifyExists on ChildForm_SerialLotInfo_SalesOrderWarrantyInformation_SalesOrderInformation_SalesOrder...", Logger.MessageType.INF);
				SeleniumControl OEMISSU2_ChildForm_SerialLotInfo_SalesOrderWarrantyInformation_SalesOrderInformation_SalesOrder = new SeleniumControl( sDriver, "ChildForm_SerialLotInfo_SalesOrderWarrantyInformation_SalesOrderInformation_SalesOrder", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMISSU_INVTTRNLNSRLT_CHILD_']/ancestor::form[1]/descendant::*[@id='MAINT_SO_ID']");
				Function.AssertEqual(true,OEMISSU2_ChildForm_SerialLotInfo_SalesOrderWarrantyInformation_SalesOrderInformation_SalesOrder.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMISSU2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMISSU2] Performing Select on ChildForm_SerialLotInfo_SerialLotInfoTab...", Logger.MessageType.INF);
				SeleniumControl OEMISSU2_ChildForm_SerialLotInfo_SerialLotInfoTab = new SeleniumControl( sDriver, "ChildForm_SerialLotInfo_SerialLotInfoTab", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMISSU_INVTTRNLNSRLT_CHILD_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(OEMISSU2_ChildForm_SerialLotInfo_SerialLotInfoTab);
IWebElement mTab = OEMISSU2_ChildForm_SerialLotInfo_SerialLotInfoTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Notes").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMISSU2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMISSU2] Performing VerifyExists on ChildForm_SerialLotInfo_Notes_Notes...", Logger.MessageType.INF);
				SeleniumControl OEMISSU2_ChildForm_SerialLotInfo_Notes_Notes = new SeleniumControl( sDriver, "ChildForm_SerialLotInfo_Notes_Notes", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMISSU_INVTTRNLNSRLT_CHILD_']/ancestor::form[1]/descendant::*[@id='NOTES_NT']");
				Function.AssertEqual(true,OEMISSU2_ChildForm_SerialLotInfo_Notes_Notes.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMISSU2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMISSU2] Performing Select on ChildForm_SerialLotInfo_SerialLotInfoTab...", Logger.MessageType.INF);
				SeleniumControl OEMISSU2_ChildForm_SerialLotInfo_SerialLotInfoTab = new SeleniumControl( sDriver, "ChildForm_SerialLotInfo_SerialLotInfoTab", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMISSU_INVTTRNLNSRLT_CHILD_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(OEMISSU2_ChildForm_SerialLotInfo_SerialLotInfoTab);
IWebElement mTab = OEMISSU2_ChildForm_SerialLotInfo_SerialLotInfoTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Shelf Life").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMISSU2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMISSU2] Performing VerifyExists on ChildForm_SerialLotInfo_ShelfLife_ShelfLife_ShelfLifeType...", Logger.MessageType.INF);
				SeleniumControl OEMISSU2_ChildForm_SerialLotInfo_ShelfLife_ShelfLife_ShelfLifeType = new SeleniumControl( sDriver, "ChildForm_SerialLotInfo_ShelfLife_ShelfLife_ShelfLifeType", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMISSU_INVTTRNLNSRLT_CHILD_']/ancestor::form[1]/descendant::*[@id='S_SHELF_LIFE_TYPE']");
				Function.AssertEqual(true,OEMISSU2_ChildForm_SerialLotInfo_ShelfLife_ShelfLife_ShelfLifeType.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMISSU2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMISSU2] Performing Close on ChildForm_SerialLotInfoForm...", Logger.MessageType.INF);
				SeleniumControl OEMISSU2_ChildForm_SerialLotInfoForm = new SeleniumControl( sDriver, "ChildForm_SerialLotInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMISSU_INVTTRNLNSRLT_CHILD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMISSU2_ChildForm_SerialLotInfoForm);
IWebElement formBttn = OEMISSU2_ChildForm_SerialLotInfoForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Line Documents");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMISSU2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMISSU2] Performing VerifyExists on ChildForm_LineDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl OEMISSU2_ChildForm_LineDocumentsLink = new SeleniumControl( sDriver, "ChildForm_LineDocumentsLink", "ID", "lnk_1007712_OEMISSU_WORKTABLE_TEMP");
				Function.AssertEqual(true,OEMISSU2_ChildForm_LineDocumentsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMISSU2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMISSU2] Performing Click on ChildForm_LineDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl OEMISSU2_ChildForm_LineDocumentsLink = new SeleniumControl( sDriver, "ChildForm_LineDocumentsLink", "ID", "lnk_1007712_OEMISSU_WORKTABLE_TEMP");
				Function.WaitControlDisplayed(OEMISSU2_ChildForm_LineDocumentsLink);
OEMISSU2_ChildForm_LineDocumentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMISSU2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMISSU2] Performing VerifyExist on ChildForm_LineDocumentsFormTable...", Logger.MessageType.INF);
				SeleniumControl OEMISSU2_ChildForm_LineDocumentsFormTable = new SeleniumControl( sDriver, "ChildForm_LineDocumentsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__OEM_SOLN_DOCUMENTS_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,OEMISSU2_ChildForm_LineDocumentsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMISSU2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMISSU2] Performing ClickButton on ChildForm_LineDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl OEMISSU2_ChildForm_LineDocumentsForm = new SeleniumControl( sDriver, "ChildForm_LineDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEM_SOLN_DOCUMENTS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMISSU2_ChildForm_LineDocumentsForm);
IWebElement formBttn = OEMISSU2_ChildForm_LineDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? OEMISSU2_ChildForm_LineDocumentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
OEMISSU2_ChildForm_LineDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMISSU2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMISSU2] Performing VerifyExists on ChildForm_LineDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl OEMISSU2_ChildForm_LineDocumentsForm = new SeleniumControl( sDriver, "ChildForm_LineDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEM_SOLN_DOCUMENTS_']/ancestor::form[1]");
				Function.AssertEqual(true,OEMISSU2_ChildForm_LineDocumentsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMISSU2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMISSU2] Performing VerifyExists on ChildForm_LineDocuments_Document...", Logger.MessageType.INF);
				SeleniumControl OEMISSU2_ChildForm_LineDocuments_Document = new SeleniumControl( sDriver, "ChildForm_LineDocuments_Document", "xpath", "//div[translate(@id,'0123456789','')='pr__OEM_SOLN_DOCUMENTS_']/ancestor::form[1]/descendant::*[@id='DOCUMENT_ID']");
				Function.AssertEqual(true,OEMISSU2_ChildForm_LineDocuments_Document.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMISSU2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMISSU2] Performing Close on ChildForm_LineDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl OEMISSU2_ChildForm_LineDocumentsForm = new SeleniumControl( sDriver, "ChildForm_LineDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEM_SOLN_DOCUMENTS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMISSU2_ChildForm_LineDocumentsForm);
IWebElement formBttn = OEMISSU2_ChildForm_LineDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "OEMISSU2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMISSU2] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl OEMISSU2_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(OEMISSU2_MainForm);
IWebElement formBttn = OEMISSU2_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

