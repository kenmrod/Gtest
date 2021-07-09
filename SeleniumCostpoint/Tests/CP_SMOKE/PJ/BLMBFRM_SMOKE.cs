 
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
    public class BLMBFRM_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Billing Formats", "xpath","//div[@class='navItem'][.='Billing Formats']").Click();
new SeleniumControl(sDriver,"Manage Generic Billing Formats", "xpath","//div[@class='navItem'][.='Manage Generic Billing Formats']").Click();


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
				Function.CurrentComponent = "BLMBFRM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMBFRM] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl BLMBFRM_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(BLMBFRM_MainForm);
IWebElement formBttn = BLMBFRM_MainForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).Count <= 0 ? BLMBFRM_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Query')]")).FirstOrDefault() :
BLMBFRM_MainForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Query not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "Query";
								Function.WaitControlDisplayed(new SeleniumControl(sDriver,"QueryTitle", "ID", "qryHeaderLabel"));
Function.AssertEqual("Manage Generic Billing Formats", new SeleniumControl(sDriver,"QueryTitle", "ID", "qryHeaderLabel").GetValue().Trim());


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyTitle]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "Query";
								SeleniumControl ctl = new SeleniumControl(sDriver,"Target", "xpath_display", "//*[@id='basicQTbl']/tbody/tr/td/span[text()='Billing Format']");
Function.WaitControlDisplayed(ctl);
SeleniumControl RelationshipField = new SeleniumControl(sDriver,"Relationship", ctl.mElement.FindElement(By.XPath("../following-sibling::td[1]")));
SeleniumControl SearchField = new SeleniumControl(sDriver,"Relationship", ctl.mElement.FindElement(By.XPath("../following-sibling::td[2]")));
new SeleniumControl(sDriver, "RelDropdown", RelationshipField.mElement.FindElements(By.XPath("./descendant::*[@class='tCCBImg']")).FirstOrDefault()).Click();
new SeleniumControl(sDriver, "RelItem", "xpath", ".//descendant::div[text() = 'is equal to']").Click();
if (SearchField.mElement.GetAttribute("class").Equals("tCCB")) {
new SeleniumControl(sDriver, "SearchDropdown", SearchField.mElement.FindElements(By.XPath(".//descendant::*[@class='tCCBImg']")).FirstOrDefault()).Click();
new SeleniumControl(sDriver, "SearchItem", "xpath_display", ".//descendant::div[text()='1443']").Click();
} else { 
new SeleniumControl(sDriver, "SearchDropdown", SearchField.mElement.FindElements(By.XPath(".//descendant::*[@class='queryBasicFld']")).FirstOrDefault()).SendKeys("1443");}


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SetSearchCriterion]" , ex.Message));
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
				Function.CurrentComponent = "BLMBFRM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMBFRM] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl BLMBFRM_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,BLMBFRM_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMBFRM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMBFRM] Performing VerifyExists on BillingFormatCode...", Logger.MessageType.INF);
				SeleniumControl BLMBFRM_BillingFormatCode = new SeleniumControl( sDriver, "BillingFormatCode", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='BILL_FRMT_CD']");
				Function.AssertEqual(true,BLMBFRM_BillingFormatCode.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMBFRM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMBFRM] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl BLMBFRM_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(BLMBFRM_MainForm);
IWebElement formBttn = BLMBFRM_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? BLMBFRM_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
BLMBFRM_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMBFRM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMBFRM] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl BLMBFRM_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BLMBFRM_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMBFRM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMBFRM] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl BLMBFRM_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(BLMBFRM_MainForm);
IWebElement formBttn = BLMBFRM_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? BLMBFRM_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
BLMBFRM_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMBFRM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMBFRM] Performing Select on MainTab...", Logger.MessageType.INF);
				SeleniumControl BLMBFRM_MainTab = new SeleniumControl( sDriver, "MainTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(BLMBFRM_MainTab);
IWebElement mTab = BLMBFRM_MainTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Header").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMBFRM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMBFRM] Performing VerifyExists on Header_ContractValue_ShowContractValue...", Logger.MessageType.INF);
				SeleniumControl BLMBFRM_Header_ContractValue_ShowContractValue = new SeleniumControl( sDriver, "Header_ContractValue_ShowContractValue", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='S_HD_CV_CD' and @value='C']");
				Function.AssertEqual(true,BLMBFRM_Header_ContractValue_ShowContractValue.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMBFRM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMBFRM] Performing Select on MainTab...", Logger.MessageType.INF);
				SeleniumControl BLMBFRM_MainTab = new SeleniumControl( sDriver, "MainTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(BLMBFRM_MainTab);
IWebElement mTab = BLMBFRM_MainTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Hours").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMBFRM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMBFRM] Performing VerifyExists on Hours_DetailInformation_ShowLaborCategory...", Logger.MessageType.INF);
				SeleniumControl BLMBFRM_Hours_DetailInformation_ShowLaborCategory = new SeleniumControl( sDriver, "Hours_DetailInformation_ShowLaborCategory", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='HR_LC_CD_FL']");
				Function.AssertEqual(true,BLMBFRM_Hours_DetailInformation_ShowLaborCategory.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMBFRM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMBFRM] Performing Select on MainTab...", Logger.MessageType.INF);
				SeleniumControl BLMBFRM_MainTab = new SeleniumControl( sDriver, "MainTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(BLMBFRM_MainTab);
IWebElement mTab = BLMBFRM_MainTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Display Options").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMBFRM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMBFRM] Performing VerifyExists on DisplayOptions_Unit_ShowCumulativeUnitsBilled...", Logger.MessageType.INF);
				SeleniumControl BLMBFRM_DisplayOptions_Unit_ShowCumulativeUnitsBilled = new SeleniumControl( sDriver, "DisplayOptions_Unit_ShowCumulativeUnitsBilled", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='UN_PB_FL']");
				Function.AssertEqual(true,BLMBFRM_DisplayOptions_Unit_ShowCumulativeUnitsBilled.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMBFRM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMBFRM] Performing Select on MainTab...", Logger.MessageType.INF);
				SeleniumControl BLMBFRM_MainTab = new SeleniumControl( sDriver, "MainTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(BLMBFRM_MainTab);
IWebElement mTab = BLMBFRM_MainTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Footer").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMBFRM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMBFRM] Performing VerifyExists on Footer_StandardText...", Logger.MessageType.INF);
				SeleniumControl BLMBFRM_Footer_StandardText = new SeleniumControl( sDriver, "Footer_StandardText", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='BILL_STD_TEXT_CD']");
				Function.AssertEqual(true,BLMBFRM_Footer_StandardText.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Child Form");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMBFRM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMBFRM] Performing VerifyExist on ChildFormTable...", Logger.MessageType.INF);
				SeleniumControl BLMBFRM_ChildFormTable = new SeleniumControl( sDriver, "ChildFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__BLMBFRM_BILLFRMTLN_CHLD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BLMBFRM_ChildFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Accounts");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMBFRM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMBFRM] Performing VerifyExists on ChildForm_AccountsLink...", Logger.MessageType.INF);
				SeleniumControl BLMBFRM_ChildForm_AccountsLink = new SeleniumControl( sDriver, "ChildForm_AccountsLink", "ID", "lnk_1002151_BLMBFRM_BILLFRMTLN_CHLD");
				Function.AssertEqual(true,BLMBFRM_ChildForm_AccountsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMBFRM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMBFRM] Performing Click on ChildForm_AccountsLink...", Logger.MessageType.INF);
				SeleniumControl BLMBFRM_ChildForm_AccountsLink = new SeleniumControl( sDriver, "ChildForm_AccountsLink", "ID", "lnk_1002151_BLMBFRM_BILLFRMTLN_CHLD");
				Function.WaitControlDisplayed(BLMBFRM_ChildForm_AccountsLink);
BLMBFRM_ChildForm_AccountsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMBFRM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMBFRM] Performing VerifyExist on ChildFormTable...", Logger.MessageType.INF);
				SeleniumControl BLMBFRM_ChildFormTable = new SeleniumControl( sDriver, "ChildFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__BLMBFRM_BILLFRMTLN_CHLD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BLMBFRM_ChildFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMBFRM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMBFRM] Performing VerifyExists on ChildForm_AccountsForm...", Logger.MessageType.INF);
				SeleniumControl BLMBFRM_ChildForm_AccountsForm = new SeleniumControl( sDriver, "ChildForm_AccountsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BLMBFRM_BILLFRMTLNACCT_CHLD_']/ancestor::form[1]");
				Function.AssertEqual(true,BLMBFRM_ChildForm_AccountsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMBFRM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMBFRM] Performing VerifyExists on ChildForm_Accounts_Ok...", Logger.MessageType.INF);
				SeleniumControl BLMBFRM_ChildForm_Accounts_Ok = new SeleniumControl( sDriver, "ChildForm_Accounts_Ok", "xpath", "//div[translate(@id,'0123456789','')='pr__BLMBFRM_BILLFRMTLNACCT_CHLD_']/ancestor::form[1]/following-sibling::div[1]/descendant::*[@id='bOk']");
				Function.AssertEqual(true,BLMBFRM_ChildForm_Accounts_Ok.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Close");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMBFRM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMBFRM] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl BLMBFRM_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(BLMBFRM_MainForm);
IWebElement formBttn = BLMBFRM_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

