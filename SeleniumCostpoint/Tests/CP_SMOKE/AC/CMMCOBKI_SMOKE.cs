 
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
    public class CMMCOBKI_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Manage Company Bank Accounts (Non-US Banks)", "xpath","//div[@class='navItem'][.='Manage Company Bank Accounts (Non-US Banks)']").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SelectMenu]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("MAINFORM");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "CMMCOBKI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[CMMCOBKI] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl CMMCOBKI_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,CMMCOBKI_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "CMMCOBKI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[CMMCOBKI] Performing VerifyExists on BankAbbrev...", Logger.MessageType.INF);
				SeleniumControl CMMCOBKI_BankAbbrev = new SeleniumControl( sDriver, "BankAbbrev", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='BANK_ACCT_ABBRV']");
				Function.AssertEqual(true,CMMCOBKI_BankAbbrev.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "CMMCOBKI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[CMMCOBKI] Performing VerifyExists on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl CMMCOBKI_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.AssertEqual(true,CMMCOBKI_MainFormTab.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "CMMCOBKI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[CMMCOBKI] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl CMMCOBKI_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(CMMCOBKI_MainFormTab);
IWebElement mTab = CMMCOBKI_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Details").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "CMMCOBKI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[CMMCOBKI] Performing VerifyExists on Details_BankInfo_NonUSBankID...", Logger.MessageType.INF);
				SeleniumControl CMMCOBKI_Details_BankInfo_NonUSBankID = new SeleniumControl( sDriver, "Details_BankInfo_NonUSBankID", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='NON_US_BANK_ID']");
				Function.AssertEqual(true,CMMCOBKI_Details_BankInfo_NonUSBankID.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "CMMCOBKI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[CMMCOBKI] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl CMMCOBKI_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(CMMCOBKI_MainFormTab);
IWebElement mTab = CMMCOBKI_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Upload Bank Settings").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "CMMCOBKI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[CMMCOBKI] Performing VerifyExists on UploadBankSettings_FileLayoutHeadingInfo_FieldNo_Code...", Logger.MessageType.INF);
				SeleniumControl CMMCOBKI_UploadBankSettings_FileLayoutHeadingInfo_FieldNo_Code = new SeleniumControl( sDriver, "UploadBankSettings_FileLayoutHeadingInfo_FieldNo_Code", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='CODE_FLD_NO']");
				Function.AssertEqual(true,CMMCOBKI_UploadBankSettings_FileLayoutHeadingInfo_FieldNo_Code.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "CMMCOBKI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[CMMCOBKI] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl CMMCOBKI_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(CMMCOBKI_MainForm);
IWebElement formBttn = CMMCOBKI_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? CMMCOBKI_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
CMMCOBKI_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "CMMCOBKI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[CMMCOBKI] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl CMMCOBKI_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,CMMCOBKI_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "CMMCOBKI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[CMMCOBKI] Performing VerifyExists on ApprovedIntermediaryBanksLink...", Logger.MessageType.INF);
				SeleniumControl CMMCOBKI_ApprovedIntermediaryBanksLink = new SeleniumControl( sDriver, "ApprovedIntermediaryBanksLink", "ID", "lnk_16630_CMMCOBKI_BANKACCT_HDR");
				Function.AssertEqual(true,CMMCOBKI_ApprovedIntermediaryBanksLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "CMMCOBKI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[CMMCOBKI] Performing Click on ApprovedIntermediaryBanksLink...", Logger.MessageType.INF);
				SeleniumControl CMMCOBKI_ApprovedIntermediaryBanksLink = new SeleniumControl( sDriver, "ApprovedIntermediaryBanksLink", "ID", "lnk_16630_CMMCOBKI_BANKACCT_HDR");
				Function.WaitControlDisplayed(CMMCOBKI_ApprovedIntermediaryBanksLink);
CMMCOBKI_ApprovedIntermediaryBanksLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "CMMCOBKI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[CMMCOBKI] Performing VerifyExists on ApprovedIntermediaryBanksForm...", Logger.MessageType.INF);
				SeleniumControl CMMCOBKI_ApprovedIntermediaryBanksForm = new SeleniumControl( sDriver, "ApprovedIntermediaryBanksForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPMCOBNK_BANKACCTIBLINK_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,CMMCOBKI_ApprovedIntermediaryBanksForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "CMMCOBKI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[CMMCOBKI] Performing VerifyExist on ApprovedIntermediaryBanksFormTable...", Logger.MessageType.INF);
				SeleniumControl CMMCOBKI_ApprovedIntermediaryBanksFormTable = new SeleniumControl( sDriver, "ApprovedIntermediaryBanksFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__CPMCOBNK_BANKACCTIBLINK_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,CMMCOBKI_ApprovedIntermediaryBanksFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "CMMCOBKI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[CMMCOBKI] Performing Close on ApprovedIntermediaryBanksForm...", Logger.MessageType.INF);
				SeleniumControl CMMCOBKI_ApprovedIntermediaryBanksForm = new SeleniumControl( sDriver, "ApprovedIntermediaryBanksForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPMCOBNK_BANKACCTIBLINK_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(CMMCOBKI_ApprovedIntermediaryBanksForm);
IWebElement formBttn = CMMCOBKI_ApprovedIntermediaryBanksForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "CMMCOBKI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[CMMCOBKI] Performing VerifyExists on EFTBankInfoLink...", Logger.MessageType.INF);
				SeleniumControl CMMCOBKI_EFTBankInfoLink = new SeleniumControl( sDriver, "EFTBankInfoLink", "ID", "lnk_16631_CMMCOBKI_BANKACCT_HDR");
				Function.AssertEqual(true,CMMCOBKI_EFTBankInfoLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "CMMCOBKI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[CMMCOBKI] Performing Click on EFTBankInfoLink...", Logger.MessageType.INF);
				SeleniumControl CMMCOBKI_EFTBankInfoLink = new SeleniumControl( sDriver, "EFTBankInfoLink", "ID", "lnk_16631_CMMCOBKI_BANKACCT_HDR");
				Function.WaitControlDisplayed(CMMCOBKI_EFTBankInfoLink);
CMMCOBKI_EFTBankInfoLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "CMMCOBKI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[CMMCOBKI] Performing VerifyExists on EFTBankInfoForm...", Logger.MessageType.INF);
				SeleniumControl CMMCOBKI_EFTBankInfoForm = new SeleniumControl( sDriver, "EFTBankInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPMCOBNK_NONUS_EFTINFO_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,CMMCOBKI_EFTBankInfoForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "CMMCOBKI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[CMMCOBKI] Performing VerifyExists on EFTBankInfo_BankInfo_NonUSDebitBankID...", Logger.MessageType.INF);
				SeleniumControl CMMCOBKI_EFTBankInfo_BankInfo_NonUSDebitBankID = new SeleniumControl( sDriver, "EFTBankInfo_BankInfo_NonUSDebitBankID", "xpath", "//div[translate(@id,'0123456789','')='pr__CPMCOBNK_NONUS_EFTINFO_CTW_']/ancestor::form[1]/descendant::*[@id='NON_US_DBT_BANK_ID']");
				Function.AssertEqual(true,CMMCOBKI_EFTBankInfo_BankInfo_NonUSDebitBankID.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "CMMCOBKI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[CMMCOBKI] Performing ClickButton on EFTBankInfoForm...", Logger.MessageType.INF);
				SeleniumControl CMMCOBKI_EFTBankInfoForm = new SeleniumControl( sDriver, "EFTBankInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPMCOBNK_NONUS_EFTINFO_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(CMMCOBKI_EFTBankInfoForm);
IWebElement formBttn = CMMCOBKI_EFTBankInfoForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? CMMCOBKI_EFTBankInfoForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
CMMCOBKI_EFTBankInfoForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "CMMCOBKI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[CMMCOBKI] Performing VerifyExist on EFTBankInfoFormTable...", Logger.MessageType.INF);
				SeleniumControl CMMCOBKI_EFTBankInfoFormTable = new SeleniumControl( sDriver, "EFTBankInfoFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__CPMCOBNK_NONUS_EFTINFO_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,CMMCOBKI_EFTBankInfoFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "CMMCOBKI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[CMMCOBKI] Performing Close on EFTBankInfoForm...", Logger.MessageType.INF);
				SeleniumControl CMMCOBKI_EFTBankInfoForm = new SeleniumControl( sDriver, "EFTBankInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPMCOBNK_NONUS_EFTINFO_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(CMMCOBKI_EFTBankInfoForm);
IWebElement formBttn = CMMCOBKI_EFTBankInfoForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "CMMCOBKI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[CMMCOBKI] Performing VerifyExists on ViewCashAccountsLink...", Logger.MessageType.INF);
				SeleniumControl CMMCOBKI_ViewCashAccountsLink = new SeleniumControl( sDriver, "ViewCashAccountsLink", "ID", "lnk_16633_CMMCOBKI_BANKACCT_HDR");
				Function.AssertEqual(true,CMMCOBKI_ViewCashAccountsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "CMMCOBKI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[CMMCOBKI] Performing Click on ViewCashAccountsLink...", Logger.MessageType.INF);
				SeleniumControl CMMCOBKI_ViewCashAccountsLink = new SeleniumControl( sDriver, "ViewCashAccountsLink", "ID", "lnk_16633_CMMCOBKI_BANKACCT_HDR");
				Function.WaitControlDisplayed(CMMCOBKI_ViewCashAccountsLink);
CMMCOBKI_ViewCashAccountsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "CMMCOBKI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[CMMCOBKI] Performing VerifyExists on ViewCashAccountsForm...", Logger.MessageType.INF);
				SeleniumControl CMMCOBKI_ViewCashAccountsForm = new SeleniumControl( sDriver, "ViewCashAccountsForm", "xpath", "//div[starts-with(@id,'pr__CPMCOBNK_ACCTS_CTW1_')]/ancestor::form[1]");
				Function.AssertEqual(true,CMMCOBKI_ViewCashAccountsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "CMMCOBKI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[CMMCOBKI] Performing VerifyExist on ViewCashAccountsFormTable...", Logger.MessageType.INF);
				SeleniumControl CMMCOBKI_ViewCashAccountsFormTable = new SeleniumControl( sDriver, "ViewCashAccountsFormTable", "xpath", "//div[starts-with(@id,'pr__CPMCOBNK_ACCTS_CTW1_')]/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,CMMCOBKI_ViewCashAccountsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "CMMCOBKI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[CMMCOBKI] Performing ClickButton on ViewCashAccountsForm...", Logger.MessageType.INF);
				SeleniumControl CMMCOBKI_ViewCashAccountsForm = new SeleniumControl( sDriver, "ViewCashAccountsForm", "xpath", "//div[starts-with(@id,'pr__CPMCOBNK_ACCTS_CTW1_')]/ancestor::form[1]");
				Function.WaitControlDisplayed(CMMCOBKI_ViewCashAccountsForm);
IWebElement formBttn = CMMCOBKI_ViewCashAccountsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? CMMCOBKI_ViewCashAccountsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
CMMCOBKI_ViewCashAccountsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "CMMCOBKI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[CMMCOBKI] Performing VerifyExists on ViewCashAccounts_Account...", Logger.MessageType.INF);
				SeleniumControl CMMCOBKI_ViewCashAccounts_Account = new SeleniumControl( sDriver, "ViewCashAccounts_Account", "xpath", "//div[starts-with(@id,'pr__CPMCOBNK_ACCTS_CTW1_')]/ancestor::form[1]/descendant::*[@id='CASH_ACCT_ID']");
				Function.AssertEqual(true,CMMCOBKI_ViewCashAccounts_Account.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "CMMCOBKI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[CMMCOBKI] Performing Close on ViewCashAccountsForm...", Logger.MessageType.INF);
				SeleniumControl CMMCOBKI_ViewCashAccountsForm = new SeleniumControl( sDriver, "ViewCashAccountsForm", "xpath", "//div[starts-with(@id,'pr__CPMCOBNK_ACCTS_CTW1_')]/ancestor::form[1]");
				Function.WaitControlDisplayed(CMMCOBKI_ViewCashAccountsForm);
IWebElement formBttn = CMMCOBKI_ViewCashAccountsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "CMMCOBKI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[CMMCOBKI] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl CMMCOBKI_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(CMMCOBKI_MainForm);
IWebElement formBttn = CMMCOBKI_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

