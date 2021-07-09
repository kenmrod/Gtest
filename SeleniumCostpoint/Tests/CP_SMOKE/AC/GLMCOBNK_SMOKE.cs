 
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
    public class GLMCOBNK_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Cash Management", "xpath","//div[@class='deptItem'][.='Cash Management']").Click();
new SeleniumControl(sDriver,"Bank Account Management", "xpath","//div[@class='navItem'][.='Bank Account Management']").Click();
new SeleniumControl(sDriver,"Manage Company Bank Accounts (US Banks)", "xpath","//div[@class='navItem'][.='Manage Company Bank Accounts (US Banks)']").Click();


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
				Function.CurrentComponent = "GLMCOBNK";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMCOBNK] Performing VerifyExists on BankAbbrev...", Logger.MessageType.INF);
				SeleniumControl GLMCOBNK_BankAbbrev = new SeleniumControl( sDriver, "BankAbbrev", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='BANK_ACCT_ABBRV']");
				Function.AssertEqual(true,GLMCOBNK_BankAbbrev.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMCOBNK";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMCOBNK] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl GLMCOBNK_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(GLMCOBNK_MainFormTab);
IWebElement mTab = GLMCOBNK_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Details").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMCOBNK";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMCOBNK] Performing VerifyExists on Details_BankInfo_USBankIDABA...", Logger.MessageType.INF);
				SeleniumControl GLMCOBNK_Details_BankInfo_USBankIDABA = new SeleniumControl( sDriver, "Details_BankInfo_USBankIDABA", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='BANK_ABA_NO']");
				Function.AssertEqual(true,GLMCOBNK_Details_BankInfo_USBankIDABA.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMCOBNK";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMCOBNK] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl GLMCOBNK_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(GLMCOBNK_MainFormTab);
IWebElement mTab = GLMCOBNK_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Upload Bank Settings").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMCOBNK";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMCOBNK] Performing VerifyExists on UploadBankSettings_FileLayoutHeadingInfo_Code_AccountNo...", Logger.MessageType.INF);
				SeleniumControl GLMCOBNK_UploadBankSettings_FileLayoutHeadingInfo_Code_AccountNo = new SeleniumControl( sDriver, "UploadBankSettings_FileLayoutHeadingInfo_Code_AccountNo", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='ACCT_CD']");
				Function.AssertEqual(true,GLMCOBNK_UploadBankSettings_FileLayoutHeadingInfo_Code_AccountNo.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Approved Internediary Banks");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMCOBNK";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMCOBNK] Performing Click on ApprovedIntermediaryBanksLink...", Logger.MessageType.INF);
				SeleniumControl GLMCOBNK_ApprovedIntermediaryBanksLink = new SeleniumControl( sDriver, "ApprovedIntermediaryBanksLink", "ID", "lnk_16612_CPMCOBNK_BANKACCT_HDR");
				Function.WaitControlDisplayed(GLMCOBNK_ApprovedIntermediaryBanksLink);
GLMCOBNK_ApprovedIntermediaryBanksLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMCOBNK";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMCOBNK] Performing VerifyExist on ApprovedIntermediaryBanksFormTable...", Logger.MessageType.INF);
				SeleniumControl GLMCOBNK_ApprovedIntermediaryBanksFormTable = new SeleniumControl( sDriver, "ApprovedIntermediaryBanksFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__CPMCOBNK_BANKACCTIBLINK_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,GLMCOBNK_ApprovedIntermediaryBanksFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMCOBNK";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMCOBNK] Performing Close on ApprovedIntermediaryBanksForm...", Logger.MessageType.INF);
				SeleniumControl GLMCOBNK_ApprovedIntermediaryBanksForm = new SeleniumControl( sDriver, "ApprovedIntermediaryBanksForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPMCOBNK_BANKACCTIBLINK_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(GLMCOBNK_ApprovedIntermediaryBanksForm);
IWebElement formBttn = GLMCOBNK_ApprovedIntermediaryBanksForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("EFT Bank Info");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMCOBNK";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMCOBNK] Performing Click on EFTBankInfoLink...", Logger.MessageType.INF);
				SeleniumControl GLMCOBNK_EFTBankInfoLink = new SeleniumControl( sDriver, "EFTBankInfoLink", "ID", "lnk_16613_CPMCOBNK_BANKACCT_HDR");
				Function.WaitControlDisplayed(GLMCOBNK_EFTBankInfoLink);
GLMCOBNK_EFTBankInfoLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMCOBNK";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMCOBNK] Performing VerifyExists on EFTBankInfoForm...", Logger.MessageType.INF);
				SeleniumControl GLMCOBNK_EFTBankInfoForm = new SeleniumControl( sDriver, "EFTBankInfoForm", "xpath", "//div[starts-with(@id,'pr__CPMCOBNK_EFTINFO_CTW2_')]/ancestor::form[1]");
				Function.AssertEqual(true,GLMCOBNK_EFTBankInfoForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMCOBNK";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMCOBNK] Performing Select on EFTBankInfo_EFTBankInfoTab...", Logger.MessageType.INF);
				SeleniumControl GLMCOBNK_EFTBankInfo_EFTBankInfoTab = new SeleniumControl( sDriver, "EFTBankInfo_EFTBankInfoTab", "xpath", "//div[starts-with(@id,'pr__CPMCOBNK_EFTINFO_CTW2_')]/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(GLMCOBNK_EFTBankInfo_EFTBankInfoTab);
IWebElement mTab = GLMCOBNK_EFTBankInfo_EFTBankInfoTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Bank Info").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMCOBNK";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMCOBNK] Performing Select on EFTBankInfo_EFTBankInfoTab...", Logger.MessageType.INF);
				SeleniumControl GLMCOBNK_EFTBankInfo_EFTBankInfoTab = new SeleniumControl( sDriver, "EFTBankInfo_EFTBankInfoTab", "xpath", "//div[starts-with(@id,'pr__CPMCOBNK_EFTINFO_CTW2_')]/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(GLMCOBNK_EFTBankInfo_EFTBankInfoTab);
IWebElement mTab = GLMCOBNK_EFTBankInfo_EFTBankInfoTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "ACH Info").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMCOBNK";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMCOBNK] Performing VerifyExists on EFTBankInfo_ACHInfo_AddtionalHeaderRecords_AdditionalHeaderRecords1...", Logger.MessageType.INF);
				SeleniumControl GLMCOBNK_EFTBankInfo_ACHInfo_AddtionalHeaderRecords_AdditionalHeaderRecords1 = new SeleniumControl( sDriver, "EFTBankInfo_ACHInfo_AddtionalHeaderRecords_AdditionalHeaderRecords1", "xpath", "//div[starts-with(@id,'pr__CPMCOBNK_EFTINFO_CTW2_')]/ancestor::form[1]/descendant::*[@id='HDR_REC1_S']");
				Function.AssertEqual(true,GLMCOBNK_EFTBankInfo_ACHInfo_AddtionalHeaderRecords_AdditionalHeaderRecords1.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMCOBNK";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMCOBNK] Performing Select on EFTBankInfo_EFTBankInfoTab...", Logger.MessageType.INF);
				SeleniumControl GLMCOBNK_EFTBankInfo_EFTBankInfoTab = new SeleniumControl( sDriver, "EFTBankInfo_EFTBankInfoTab", "xpath", "//div[starts-with(@id,'pr__CPMCOBNK_EFTINFO_CTW2_')]/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(GLMCOBNK_EFTBankInfo_EFTBankInfoTab);
IWebElement mTab = GLMCOBNK_EFTBankInfo_EFTBankInfoTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "EDI Addenda/820 Info").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMCOBNK";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMCOBNK] Performing VerifyExists on EFTBankInfo_EDIAddenda820Info_EDIAddenda820Info_EDISenderID...", Logger.MessageType.INF);
				SeleniumControl GLMCOBNK_EFTBankInfo_EDIAddenda820Info_EDIAddenda820Info_EDISenderID = new SeleniumControl( sDriver, "EFTBankInfo_EDIAddenda820Info_EDIAddenda820Info_EDISenderID", "xpath", "//div[starts-with(@id,'pr__CPMCOBNK_EFTINFO_CTW2_')]/ancestor::form[1]/descendant::*[@id='EDI_ISA06_ID']");
				Function.AssertEqual(true,GLMCOBNK_EFTBankInfo_EDIAddenda820Info_EDIAddenda820Info_EDISenderID.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMCOBNK";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMCOBNK] Performing Close on EFTBankInfoForm...", Logger.MessageType.INF);
				SeleniumControl GLMCOBNK_EFTBankInfoForm = new SeleniumControl( sDriver, "EFTBankInfoForm", "xpath", "//div[starts-with(@id,'pr__CPMCOBNK_EFTINFO_CTW2_')]/ancestor::form[1]");
				Function.WaitControlDisplayed(GLMCOBNK_EFTBankInfoForm);
IWebElement formBttn = GLMCOBNK_EFTBankInfoForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("View Cash Accounts");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMCOBNK";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMCOBNK] Performing Click on ViewCashAccountsLink...", Logger.MessageType.INF);
				SeleniumControl GLMCOBNK_ViewCashAccountsLink = new SeleniumControl( sDriver, "ViewCashAccountsLink", "ID", "lnk_16614_CPMCOBNK_BANKACCT_HDR");
				Function.WaitControlDisplayed(GLMCOBNK_ViewCashAccountsLink);
GLMCOBNK_ViewCashAccountsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMCOBNK";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMCOBNK] Performing VerifyExist on ViewCashAccountsFormTable...", Logger.MessageType.INF);
				SeleniumControl GLMCOBNK_ViewCashAccountsFormTable = new SeleniumControl( sDriver, "ViewCashAccountsFormTable", "xpath", "//div[starts-with(@id,'pr__CPMCOBNK_ACCTS_CTW1_')]/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,GLMCOBNK_ViewCashAccountsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMCOBNK";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMCOBNK] Performing ClickButton on ViewCashAccountsForm...", Logger.MessageType.INF);
				SeleniumControl GLMCOBNK_ViewCashAccountsForm = new SeleniumControl( sDriver, "ViewCashAccountsForm", "xpath", "//div[starts-with(@id,'pr__CPMCOBNK_ACCTS_CTW1_')]/ancestor::form[1]");
				Function.WaitControlDisplayed(GLMCOBNK_ViewCashAccountsForm);
IWebElement formBttn = GLMCOBNK_ViewCashAccountsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? GLMCOBNK_ViewCashAccountsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
GLMCOBNK_ViewCashAccountsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMCOBNK";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMCOBNK] Performing VerifyExists on ViewCashAccounts_AP...", Logger.MessageType.INF);
				SeleniumControl GLMCOBNK_ViewCashAccounts_AP = new SeleniumControl( sDriver, "ViewCashAccounts_AP", "xpath", "//div[starts-with(@id,'pr__CPMCOBNK_ACCTS_CTW1_')]/ancestor::form[1]/descendant::*[@id='AP_SRCE_FL']");
				Function.AssertEqual(true,GLMCOBNK_ViewCashAccounts_AP.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMCOBNK";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMCOBNK] Performing Close on ViewCashAccountsForm...", Logger.MessageType.INF);
				SeleniumControl GLMCOBNK_ViewCashAccountsForm = new SeleniumControl( sDriver, "ViewCashAccountsForm", "xpath", "//div[starts-with(@id,'pr__CPMCOBNK_ACCTS_CTW1_')]/ancestor::form[1]");
				Function.WaitControlDisplayed(GLMCOBNK_ViewCashAccountsForm);
IWebElement formBttn = GLMCOBNK_ViewCashAccountsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "GLMCOBNK";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMCOBNK] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl GLMCOBNK_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(GLMCOBNK_MainForm);
IWebElement formBttn = GLMCOBNK_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

