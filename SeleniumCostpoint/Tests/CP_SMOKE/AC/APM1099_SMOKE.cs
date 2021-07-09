 
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
    public class APM1099_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Accounts Payable", "xpath","//div[@class='deptItem'][.='Accounts Payable']").Click();
new SeleniumControl(sDriver,"Year-End Processing", "xpath","//div[@class='navItem'][.='Year-End Processing']").Click();
new SeleniumControl(sDriver,"Edit 1099 Information", "xpath","//div[@class='navItem'][.='Edit 1099 Information']").Click();


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
				Function.CurrentComponent = "Query";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[Query] Performing Click on Query...", Logger.MessageType.INF);
				SeleniumControl Query_Query = new SeleniumControl( sDriver, "Query", "ID", "submitQ");
				Function.WaitControlDisplayed(Query_Query);
if (Query_Query.mElement.GetAttribute("class") == "popupBtn" && sDriver.BrowserType == "ie")
Query_Query.Click(5,5);
else Query_Query.Click(4.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APM1099";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APM1099] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl APM1099_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,APM1099_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APM1099";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APM1099] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl APM1099_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(APM1099_MainForm);
IWebElement formBttn = APM1099_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? APM1099_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
APM1099_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APM1099";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APM1099] Performing VerifyExists on TaxableEntity...", Logger.MessageType.INF);
				SeleniumControl APM1099_TaxableEntity = new SeleniumControl( sDriver, "TaxableEntity", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='TAXBLE_ENTITY_ID']");
				Function.AssertEqual(true,APM1099_TaxableEntity.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APM1099";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APM1099] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl APM1099_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,APM1099_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Pay Vendor Summary Information");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APM1099";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APM1099] Performing VerifyExist on PayVendorSummaryInformationFormTable...", Logger.MessageType.INF);
				SeleniumControl APM1099_PayVendorSummaryInformationFormTable = new SeleniumControl( sDriver, "PayVendorSummaryInformationFormTable", "xpath", "//div[starts-with(@id,'pr__APM1099_VEND1099_DTL_')]/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,APM1099_PayVendorSummaryInformationFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APM1099";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APM1099] Performing VerifyExists on PayVendorSummaryInformationForm...", Logger.MessageType.INF);
				SeleniumControl APM1099_PayVendorSummaryInformationForm = new SeleniumControl( sDriver, "PayVendorSummaryInformationForm", "xpath", "//div[starts-with(@id,'pr__APM1099_VEND1099_DTL_')]/ancestor::form[1]");
				Function.AssertEqual(true,APM1099_PayVendorSummaryInformationForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APM1099";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APM1099] Performing ClickButton on PayVendorSummaryInformationForm...", Logger.MessageType.INF);
				SeleniumControl APM1099_PayVendorSummaryInformationForm = new SeleniumControl( sDriver, "PayVendorSummaryInformationForm", "xpath", "//div[starts-with(@id,'pr__APM1099_VEND1099_DTL_')]/ancestor::form[1]");
				Function.WaitControlDisplayed(APM1099_PayVendorSummaryInformationForm);
IWebElement formBttn = APM1099_PayVendorSummaryInformationForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? APM1099_PayVendorSummaryInformationForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
APM1099_PayVendorSummaryInformationForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APM1099";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APM1099] Performing VerifyExists on PayVendorSummaryInformation_PayVendor...", Logger.MessageType.INF);
				SeleniumControl APM1099_PayVendorSummaryInformation_PayVendor = new SeleniumControl( sDriver, "PayVendorSummaryInformation_PayVendor", "xpath", "//div[starts-with(@id,'pr__APM1099_VEND1099_DTL_')]/ancestor::form[1]/descendant::*[@id='PAY_VEND_ID']");
				Function.AssertEqual(true,APM1099_PayVendorSummaryInformation_PayVendor.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Check Detail");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APM1099";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APM1099] Performing VerifyExists on PayVendorSummaryInformation_CheckDetailLink...", Logger.MessageType.INF);
				SeleniumControl APM1099_PayVendorSummaryInformation_CheckDetailLink = new SeleniumControl( sDriver, "PayVendorSummaryInformation_CheckDetailLink", "ID", "lnk_1002654_APM1099_VEND1099_DTL");
				Function.AssertEqual(true,APM1099_PayVendorSummaryInformation_CheckDetailLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APM1099";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APM1099] Performing Click on PayVendorSummaryInformation_CheckDetailLink...", Logger.MessageType.INF);
				SeleniumControl APM1099_PayVendorSummaryInformation_CheckDetailLink = new SeleniumControl( sDriver, "PayVendorSummaryInformation_CheckDetailLink", "ID", "lnk_1002654_APM1099_VEND1099_DTL");
				Function.WaitControlDisplayed(APM1099_PayVendorSummaryInformation_CheckDetailLink);
APM1099_PayVendorSummaryInformation_CheckDetailLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APM1099";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APM1099] Performing VerifyExists on PayVendorSummaryInformation_CheckDetailForm...", Logger.MessageType.INF);
				SeleniumControl APM1099_PayVendorSummaryInformation_CheckDetailForm = new SeleniumControl( sDriver, "PayVendorSummaryInformation_CheckDetailForm", "xpath", "//div[starts-with(@id,'pr__APM1099_VENDCHK_CHKHDR_')]/ancestor::form[1]");
				Function.AssertEqual(true,APM1099_PayVendorSummaryInformation_CheckDetailForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APM1099";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APM1099] Performing VerifyExists on PayVendorSummaryInformation_CheckDetail_TotalPaidAmount...", Logger.MessageType.INF);
				SeleniumControl APM1099_PayVendorSummaryInformation_CheckDetail_TotalPaidAmount = new SeleniumControl( sDriver, "PayVendorSummaryInformation_CheckDetail_TotalPaidAmount", "xpath", "//div[starts-with(@id,'pr__APM1099_VENDCHK_CHKHDR_')]/ancestor::form[1]/descendant::*[@id='TOTALPAIDAMT']");
				Function.AssertEqual(true,APM1099_PayVendorSummaryInformation_CheckDetail_TotalPaidAmount.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APM1099";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APM1099] Performing VerifyExist on PayVendorSummaryInformation_CheckDetail_ChildFormTable...", Logger.MessageType.INF);
				SeleniumControl APM1099_PayVendorSummaryInformation_CheckDetail_ChildFormTable = new SeleniumControl( sDriver, "PayVendorSummaryInformation_CheckDetail_ChildFormTable", "xpath", "//div[starts-with(@id,'pr__APM1099_VENDCHK_CHKDETAIL_')]/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,APM1099_PayVendorSummaryInformation_CheckDetail_ChildFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APM1099";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APM1099] Performing Close on PayVendorSummaryInformation_CheckDetailForm...", Logger.MessageType.INF);
				SeleniumControl APM1099_PayVendorSummaryInformation_CheckDetailForm = new SeleniumControl( sDriver, "PayVendorSummaryInformation_CheckDetailForm", "xpath", "//div[starts-with(@id,'pr__APM1099_VENDCHK_CHKHDR_')]/ancestor::form[1]");
				Function.WaitControlDisplayed(APM1099_PayVendorSummaryInformation_CheckDetailForm);
IWebElement formBttn = APM1099_PayVendorSummaryInformation_CheckDetailForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "APM1099";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APM1099] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl APM1099_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(APM1099_MainForm);
IWebElement formBttn = APM1099_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

