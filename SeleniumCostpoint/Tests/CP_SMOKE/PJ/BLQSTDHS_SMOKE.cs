 
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
    public class BLQSTDHS_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Billing Reports/Inquiries", "xpath","//div[@class='navItem'][.='Billing Reports/Inquiries']").Click();
new SeleniumControl(sDriver,"View Standard Billing History", "xpath","//div[@class='navItem'][.='View Standard Billing History']").Click();


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
				Function.CurrentComponent = "BLQSTDHS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLQSTDHS] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl BLQSTDHS_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,BLQSTDHS_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLQSTDHS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLQSTDHS] Performing VerifyExists on SelectionCriteria_FiscalYear...", Logger.MessageType.INF);
				SeleniumControl BLQSTDHS_SelectionCriteria_FiscalYear = new SeleniumControl( sDriver, "SelectionCriteria_FiscalYear", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='FY_CD']");
				Function.AssertEqual(true,BLQSTDHS_SelectionCriteria_FiscalYear.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Inquiry Details Form");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLQSTDHS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLQSTDHS] Performing ClickButton on ChildForm...", Logger.MessageType.INF);
				SeleniumControl BLQSTDHS_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BLQSTDHS_BILLINVCHDRHS_CHILD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BLQSTDHS_ChildForm);
IWebElement formBttn = BLQSTDHS_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).Count <= 0 ? BLQSTDHS_ChildForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Query')]")).FirstOrDefault() :
BLQSTDHS_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).FirstOrDefault();
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
				Function.CurrentComponent = "BLQSTDHS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLQSTDHS] Performing VerifyExist on ChildFormTable...", Logger.MessageType.INF);
				SeleniumControl BLQSTDHS_ChildFormTable = new SeleniumControl( sDriver, "ChildFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__BLQSTDHS_BILLINVCHDRHS_CHILD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BLQSTDHS_ChildFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLQSTDHS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLQSTDHS] Performing ClickButton on ChildForm...", Logger.MessageType.INF);
				SeleniumControl BLQSTDHS_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BLQSTDHS_BILLINVCHDRHS_CHILD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BLQSTDHS_ChildForm);
IWebElement formBttn = BLQSTDHS_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? BLQSTDHS_ChildForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
BLQSTDHS_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLQSTDHS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLQSTDHS] Performing VerifyExists on ChildForm...", Logger.MessageType.INF);
				SeleniumControl BLQSTDHS_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BLQSTDHS_BILLINVCHDRHS_CHILD_']/ancestor::form[1]");
				Function.AssertEqual(true,BLQSTDHS_ChildForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLQSTDHS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLQSTDHS] Performing VerifyExists on InquiryDetails_Customer...", Logger.MessageType.INF);
				SeleniumControl BLQSTDHS_InquiryDetails_Customer = new SeleniumControl( sDriver, "InquiryDetails_Customer", "xpath", "//div[translate(@id,'0123456789','')='pr__BLQSTDHS_BILLINVCHDRHS_CHILD_']/ancestor::form[1]/descendant::*[@id='CUST_ID']");
				Function.AssertEqual(true,BLQSTDHS_InquiryDetails_Customer.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLQSTDHS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLQSTDHS] Performing Select on InquiryDetails_ChildFormTab...", Logger.MessageType.INF);
				SeleniumControl BLQSTDHS_InquiryDetails_ChildFormTab = new SeleniumControl( sDriver, "InquiryDetails_ChildFormTab", "xpath", "//div[translate(@id,'0123456789','')='pr__BLQSTDHS_BILLINVCHDRHS_CHILD_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(BLQSTDHS_InquiryDetails_ChildFormTab);
IWebElement mTab = BLQSTDHS_InquiryDetails_ChildFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Billing History").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLQSTDHS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLQSTDHS] Performing VerifyExists on InquiryDetails_BillingHistory_FiscalYearLabel...", Logger.MessageType.INF);
				SeleniumControl BLQSTDHS_InquiryDetails_BillingHistory_FiscalYearLabel = new SeleniumControl( sDriver, "InquiryDetails_BillingHistory_FiscalYearLabel", "xpath", "//input[@id='ITD_BILLED_AMT']/ancestor::form[1]/descendant::*[@id='FY_CD']/preceding-sibling::span[1]");
				Function.AssertEqual(true,BLQSTDHS_InquiryDetails_BillingHistory_FiscalYearLabel.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLQSTDHS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLQSTDHS] Performing Select on InquiryDetails_ChildFormTab...", Logger.MessageType.INF);
				SeleniumControl BLQSTDHS_InquiryDetails_ChildFormTab = new SeleniumControl( sDriver, "InquiryDetails_ChildFormTab", "xpath", "//div[translate(@id,'0123456789','')='pr__BLQSTDHS_BILLINVCHDRHS_CHILD_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(BLQSTDHS_InquiryDetails_ChildFormTab);
IWebElement mTab = BLQSTDHS_InquiryDetails_ChildFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Totals").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLQSTDHS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLQSTDHS] Performing VerifyExists on InquiryDetails_Totals_OtherCharges_Code...", Logger.MessageType.INF);
				SeleniumControl BLQSTDHS_InquiryDetails_Totals_OtherCharges_Code = new SeleniumControl( sDriver, "InquiryDetails_Totals_OtherCharges_Code", "xpath", "//div[translate(@id,'0123456789','')='pr__BLQSTDHS_BILLINVCHDRHS_CHILD_']/ancestor::form[1]/descendant::*[@id='OTH_CHG_CD1']");
				Function.AssertEqual(true,BLQSTDHS_InquiryDetails_Totals_OtherCharges_Code.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLQSTDHS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLQSTDHS] Performing Select on InquiryDetails_ChildFormTab...", Logger.MessageType.INF);
				SeleniumControl BLQSTDHS_InquiryDetails_ChildFormTab = new SeleniumControl( sDriver, "InquiryDetails_ChildFormTab", "xpath", "//div[translate(@id,'0123456789','')='pr__BLQSTDHS_BILLINVCHDRHS_CHILD_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(BLQSTDHS_InquiryDetails_ChildFormTab);
IWebElement mTab = BLQSTDHS_InquiryDetails_ChildFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Header").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLQSTDHS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLQSTDHS] Performing VerifyExists on InquiryDetails_Header_ReceivableAccountInformation_Account...", Logger.MessageType.INF);
				SeleniumControl BLQSTDHS_InquiryDetails_Header_ReceivableAccountInformation_Account = new SeleniumControl( sDriver, "InquiryDetails_Header_ReceivableAccountInformation_Account", "xpath", "//div[translate(@id,'0123456789','')='pr__BLQSTDHS_BILLINVCHDRHS_CHILD_']/ancestor::form[1]/descendant::*[@id='AR_ACCT_ID']");
				Function.AssertEqual(true,BLQSTDHS_InquiryDetails_Header_ReceivableAccountInformation_Account.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLQSTDHS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLQSTDHS] Performing Select on InquiryDetails_ChildFormTab...", Logger.MessageType.INF);
				SeleniumControl BLQSTDHS_InquiryDetails_ChildFormTab = new SeleniumControl( sDriver, "InquiryDetails_ChildFormTab", "xpath", "//div[translate(@id,'0123456789','')='pr__BLQSTDHS_BILLINVCHDRHS_CHILD_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(BLQSTDHS_InquiryDetails_ChildFormTab);
IWebElement mTab = BLQSTDHS_InquiryDetails_ChildFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Address").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLQSTDHS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLQSTDHS] Performing VerifyExists on InquiryDetails_Address_BillTo_Address...", Logger.MessageType.INF);
				SeleniumControl BLQSTDHS_InquiryDetails_Address_BillTo_Address = new SeleniumControl( sDriver, "InquiryDetails_Address_BillTo_Address", "xpath", "//div[translate(@id,'0123456789','')='pr__BLQSTDHS_BILLINVCHDRHS_CHILD_']/ancestor::form[1]/descendant::*[@id='CUST_ADDR_DC']");
				Function.AssertEqual(true,BLQSTDHS_InquiryDetails_Address_BillTo_Address.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Detail Form");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLQSTDHS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLQSTDHS] Performing VerifyExists on InquiryDetails_DetailLink...", Logger.MessageType.INF);
				SeleniumControl BLQSTDHS_InquiryDetails_DetailLink = new SeleniumControl( sDriver, "InquiryDetails_DetailLink", "ID", "lnk_1007424_BLQSTDHS_BILLINVCHDRHS_CHILD");
				Function.AssertEqual(true,BLQSTDHS_InquiryDetails_DetailLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLQSTDHS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLQSTDHS] Performing Click on InquiryDetails_DetailLink...", Logger.MessageType.INF);
				SeleniumControl BLQSTDHS_InquiryDetails_DetailLink = new SeleniumControl( sDriver, "InquiryDetails_DetailLink", "ID", "lnk_1007424_BLQSTDHS_BILLINVCHDRHS_CHILD");
				Function.WaitControlDisplayed(BLQSTDHS_InquiryDetails_DetailLink);
BLQSTDHS_InquiryDetails_DetailLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLQSTDHS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLQSTDHS] Performing VerifyExists on DetailForm...", Logger.MessageType.INF);
				SeleniumControl BLQSTDHS_DetailForm = new SeleniumControl( sDriver, "DetailForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BLQSTDHS_TOTAL_']/ancestor::form[1]");
				Function.AssertEqual(true,BLQSTDHS_DetailForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLQSTDHS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLQSTDHS] Performing VerifyExists on Detail_TotalAmount...", Logger.MessageType.INF);
				SeleniumControl BLQSTDHS_Detail_TotalAmount = new SeleniumControl( sDriver, "Detail_TotalAmount", "xpath", "//div[translate(@id,'0123456789','')='pr__BLQSTDHS_TOTAL_']/ancestor::form[1]/descendant::*[@id='TOTAL_AMOUNT']");
				Function.AssertEqual(true,BLQSTDHS_Detail_TotalAmount.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Billing Inquiry Detail");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLQSTDHS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLQSTDHS] Performing VerifyExist on BillingInquiryDetailTable...", Logger.MessageType.INF);
				SeleniumControl BLQSTDHS_BillingInquiryDetailTable = new SeleniumControl( sDriver, "BillingInquiryDetailTable", "xpath", "//div[translate(@id,'0123456789','')='pr__BLQSTDHS_DETAIL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BLQSTDHS_BillingInquiryDetailTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLQSTDHS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLQSTDHS] Performing ClickButton on BillingInquiryDetailForm...", Logger.MessageType.INF);
				SeleniumControl BLQSTDHS_BillingInquiryDetailForm = new SeleniumControl( sDriver, "BillingInquiryDetailForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BLQSTDHS_DETAIL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BLQSTDHS_BillingInquiryDetailForm);
IWebElement formBttn = BLQSTDHS_BillingInquiryDetailForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? BLQSTDHS_BillingInquiryDetailForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
BLQSTDHS_BillingInquiryDetailForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLQSTDHS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLQSTDHS] Performing VerifyExists on BillingInquiryDetailForm...", Logger.MessageType.INF);
				SeleniumControl BLQSTDHS_BillingInquiryDetailForm = new SeleniumControl( sDriver, "BillingInquiryDetailForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BLQSTDHS_DETAIL_']/ancestor::form[1]");
				Function.AssertEqual(true,BLQSTDHS_BillingInquiryDetailForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLQSTDHS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLQSTDHS] Performing VerifyExists on BillingInquiryDetail_GroupDescription...", Logger.MessageType.INF);
				SeleniumControl BLQSTDHS_BillingInquiryDetail_GroupDescription = new SeleniumControl( sDriver, "BillingInquiryDetail_GroupDescription", "xpath", "//div[translate(@id,'0123456789','')='pr__BLQSTDHS_DETAIL_']/ancestor::form[1]/descendant::*[@id='BILL_FM_GRP_LBL']");
				Function.AssertEqual(true,BLQSTDHS_BillingInquiryDetail_GroupDescription.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
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
				Function.CurrentComponent = "BLQSTDHS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLQSTDHS] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl BLQSTDHS_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(BLQSTDHS_MainForm);
IWebElement formBttn = BLQSTDHS_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

