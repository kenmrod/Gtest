 
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
    public class GLMJEA_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"General Ledger", "xpath","//div[@class='deptItem'][.='General Ledger']").Click();
new SeleniumControl(sDriver,"Journal Entry Processing", "xpath","//div[@class='navItem'][.='Journal Entry Processing']").Click();
new SeleniumControl(sDriver,"Approve Journal Entries", "xpath","//div[@class='navItem'][.='Approve Journal Entries']").Click();


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
				Function.CurrentComponent = "GLMJEA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMJEA] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl GLMJEA_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,GLMJEA_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMJEA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMJEA] Performing VerifyExists on Approver...", Logger.MessageType.INF);
				SeleniumControl GLMJEA_Approver = new SeleniumControl( sDriver, "Approver", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='USER_ID']");
				Function.AssertEqual(true,GLMJEA_Approver.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMJEA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMJEA] Performing VerifyExists on ChildForm...", Logger.MessageType.INF);
				SeleniumControl GLMJEA_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLMJEA_JEHDR_CHILD_']/ancestor::form[1]");
				Function.AssertEqual(true,GLMJEA_ChildForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMJEA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMJEA] Performing VerifyExist on ChildFormTable...", Logger.MessageType.INF);
				SeleniumControl GLMJEA_ChildFormTable = new SeleniumControl( sDriver, "ChildFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__GLMJEA_JEHDR_CHILD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,GLMJEA_ChildFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMJEA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMJEA] Performing ClickButton on ChildForm...", Logger.MessageType.INF);
				SeleniumControl GLMJEA_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLMJEA_JEHDR_CHILD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(GLMJEA_ChildForm);
IWebElement formBttn = GLMJEA_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? GLMJEA_ChildForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
GLMJEA_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMJEA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMJEA] Performing VerifyExists on ChildForm_ApproveJEDetails_JENo...", Logger.MessageType.INF);
				SeleniumControl GLMJEA_ChildForm_ApproveJEDetails_JENo = new SeleniumControl( sDriver, "ChildForm_ApproveJEDetails_JENo", "xpath", "//div[translate(@id,'0123456789','')='pr__GLMJEA_JEHDR_CHILD_']/ancestor::form[1]/descendant::*[@id='JE_NO']");
				Function.AssertEqual(true,GLMJEA_ChildForm_ApproveJEDetails_JENo.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("JE Det");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMJEA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMJEA] Performing VerifyExists on JEDetailsLink...", Logger.MessageType.INF);
				SeleniumControl GLMJEA_JEDetailsLink = new SeleniumControl( sDriver, "JEDetailsLink", "ID", "lnk_3541_GLMJEA_JEHDR_CHILD");
				Function.AssertEqual(true,GLMJEA_JEDetailsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMJEA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMJEA] Performing Click on JEDetailsLink...", Logger.MessageType.INF);
				SeleniumControl GLMJEA_JEDetailsLink = new SeleniumControl( sDriver, "JEDetailsLink", "ID", "lnk_3541_GLMJEA_JEHDR_CHILD");
				Function.WaitControlDisplayed(GLMJEA_JEDetailsLink);
GLMJEA_JEDetailsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMJEA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMJEA] Performing VerifyExists on JEDetailsForm...", Logger.MessageType.INF);
				SeleniumControl GLMJEA_JEDetailsForm = new SeleniumControl( sDriver, "JEDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLMJEA_JEHDR_JEDETAIL_HDR_']/ancestor::form[1]");
				Function.AssertEqual(true,GLMJEA_JEDetailsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMJEA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMJEA] Performing VerifyExists on JEDetails_JEID_Type...", Logger.MessageType.INF);
				SeleniumControl GLMJEA_JEDetails_JEID_Type = new SeleniumControl( sDriver, "JEDetails_JEID_Type", "xpath", "//div[translate(@id,'0123456789','')='pr__GLMJEA_JEHDR_JEDETAIL_HDR_']/ancestor::form[1]/descendant::*[@id='S_JNL_CD']");
				Function.AssertEqual(true,GLMJEA_JEDetails_JEID_Type.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMJEA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMJEA] Performing ClickButton on JEDetailsForm...", Logger.MessageType.INF);
				SeleniumControl GLMJEA_JEDetailsForm = new SeleniumControl( sDriver, "JEDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLMJEA_JEHDR_JEDETAIL_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(GLMJEA_JEDetailsForm);
IWebElement formBttn = GLMJEA_JEDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? GLMJEA_JEDetailsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
GLMJEA_JEDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMJEA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMJEA] Performing VerifyExist on JEDetailsTable...", Logger.MessageType.INF);
				SeleniumControl GLMJEA_JEDetailsTable = new SeleniumControl( sDriver, "JEDetailsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__GLMJEA_JEHDR_JEDETAIL_HDR_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,GLMJEA_JEDetailsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMJEA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMJEA] Performing VerifyExists on JEDetail_DetailForm...", Logger.MessageType.INF);
				SeleniumControl GLMJEA_JEDetail_DetailForm = new SeleniumControl( sDriver, "JEDetail_DetailForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLMJEA_JEHDR_JEDETAIL_CHILD_']/ancestor::form[1]");
				Function.AssertEqual(true,GLMJEA_JEDetail_DetailForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMJEA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMJEA] Performing VerifyExist on JEDetail_DetailTable...", Logger.MessageType.INF);
				SeleniumControl GLMJEA_JEDetail_DetailTable = new SeleniumControl( sDriver, "JEDetail_DetailTable", "xpath", "//div[translate(@id,'0123456789','')='pr__GLMJEA_JEHDR_JEDETAIL_CHILD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,GLMJEA_JEDetail_DetailTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMJEA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMJEA] Performing ClickButton on JEDetail_DetailForm...", Logger.MessageType.INF);
				SeleniumControl GLMJEA_JEDetail_DetailForm = new SeleniumControl( sDriver, "JEDetail_DetailForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLMJEA_JEHDR_JEDETAIL_CHILD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(GLMJEA_JEDetail_DetailForm);
IWebElement formBttn = GLMJEA_JEDetail_DetailForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? GLMJEA_JEDetail_DetailForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
GLMJEA_JEDetail_DetailForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMJEA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMJEA] Performing VerifyExists on JEDetail_Detail_Line...", Logger.MessageType.INF);
				SeleniumControl GLMJEA_JEDetail_Detail_Line = new SeleniumControl( sDriver, "JEDetail_Detail_Line", "xpath", "//div[translate(@id,'0123456789','')='pr__GLMJEA_JEHDR_JEDETAIL_CHILD_']/ancestor::form[1]/descendant::*[@id='JE_LN_NO']");
				Function.AssertEqual(true,GLMJEA_JEDetail_Detail_Line.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMJEA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMJEA] Performing Close on JEDetailsForm...", Logger.MessageType.INF);
				SeleniumControl GLMJEA_JEDetailsForm = new SeleniumControl( sDriver, "JEDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLMJEA_JEHDR_JEDETAIL_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(GLMJEA_JEDetailsForm);
IWebElement formBttn = GLMJEA_JEDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("ExchangeRate");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMJEA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMJEA] Performing VerifyExists on ExchangeRateLink...", Logger.MessageType.INF);
				SeleniumControl GLMJEA_ExchangeRateLink = new SeleniumControl( sDriver, "ExchangeRateLink", "ID", "lnk_3540_GLMJEA_JEHDR_CHILD");
				Function.AssertEqual(true,GLMJEA_ExchangeRateLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMJEA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMJEA] Performing Click on ExchangeRateLink...", Logger.MessageType.INF);
				SeleniumControl GLMJEA_ExchangeRateLink = new SeleniumControl( sDriver, "ExchangeRateLink", "ID", "lnk_3540_GLMJEA_JEHDR_CHILD");
				Function.WaitControlDisplayed(GLMJEA_ExchangeRateLink);
GLMJEA_ExchangeRateLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMJEA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMJEA] Performing VerifyExists on ExchangeRateForm...", Logger.MessageType.INF);
				SeleniumControl GLMJEA_ExchangeRateForm = new SeleniumControl( sDriver, "ExchangeRateForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPM_SEXR_']/ancestor::form[1]");
				Function.AssertEqual(true,GLMJEA_ExchangeRateForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMJEA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMJEA] Performing VerifyExists on ExchangeRate_TransCurrency...", Logger.MessageType.INF);
				SeleniumControl GLMJEA_ExchangeRate_TransCurrency = new SeleniumControl( sDriver, "ExchangeRate_TransCurrency", "xpath", "//div[translate(@id,'0123456789','')='pr__CPM_SEXR_']/ancestor::form[1]/descendant::*[@id='TRN_CRNCY_CD']");
				Function.AssertEqual(true,GLMJEA_ExchangeRate_TransCurrency.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMJEA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMJEA] Performing Close on ExchangeRateForm...", Logger.MessageType.INF);
				SeleniumControl GLMJEA_ExchangeRateForm = new SeleniumControl( sDriver, "ExchangeRateForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPM_SEXR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(GLMJEA_ExchangeRateForm);
IWebElement formBttn = GLMJEA_ExchangeRateForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Close App");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMJEA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMJEA] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl GLMJEA_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(GLMJEA_MainForm);
IWebElement formBttn = GLMJEA_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

