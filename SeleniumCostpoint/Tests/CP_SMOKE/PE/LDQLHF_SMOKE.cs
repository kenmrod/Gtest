 
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
    public class LDQLHF_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"People", "xpath","//div[@class='busItem'][.='People']").Click();
new SeleniumControl(sDriver,"Leave", "xpath","//div[@class='deptItem'][.='Leave']").Click();
new SeleniumControl(sDriver,"Leave Inquiries", "xpath","//div[@class='navItem'][.='Leave Inquiries']").Click();
new SeleniumControl(sDriver,"View Leave History", "xpath","//div[@class='navItem'][.='View Leave History']").Click();


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
				Function.CurrentComponent = "LDQLHF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDQLHF] Performing ClickButtonIfExists on SelectionCriteriaForm...", Logger.MessageType.INF);
				SeleniumControl LDQLHF_SelectionCriteriaForm = new SeleniumControl( sDriver, "SelectionCriteriaForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(LDQLHF_SelectionCriteriaForm);
IWebElement formBttn = LDQLHF_SelectionCriteriaForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? LDQLHF_SelectionCriteriaForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
LDQLHF_SelectionCriteriaForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault();
if (formBttn!=null && formBttn.Displayed)
{ new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click();
this.ScriptLogger.WriteLine("Button [Form] found and clicked.", Logger.MessageType.INF);
}


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButtonIfExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDQLHF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDQLHF] Performing VerifyExists on SelectionCriteriaForm...", Logger.MessageType.INF);
				SeleniumControl LDQLHF_SelectionCriteriaForm = new SeleniumControl( sDriver, "SelectionCriteriaForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,LDQLHF_SelectionCriteriaForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDQLHF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDQLHF] Performing VerifyExists on SelectionCriteria_Employee...", Logger.MessageType.INF);
				SeleniumControl LDQLHF_SelectionCriteria_Employee = new SeleniumControl( sDriver, "SelectionCriteria_Employee", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='EMPL_ID']");
				Function.AssertEqual(true,LDQLHF_SelectionCriteria_Employee.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDQLHF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDQLHF] Performing VerifyExists on InquiryDetailsForm...", Logger.MessageType.INF);
				SeleniumControl LDQLHF_InquiryDetailsForm = new SeleniumControl( sDriver, "InquiryDetailsForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,LDQLHF_InquiryDetailsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDQLHF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDQLHF] Performing ClickButtonIfExists on InquiryDetailsForm...", Logger.MessageType.INF);
				SeleniumControl LDQLHF_InquiryDetailsForm = new SeleniumControl( sDriver, "InquiryDetailsForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(LDQLHF_InquiryDetailsForm);
IWebElement formBttn = LDQLHF_InquiryDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? LDQLHF_InquiryDetailsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
LDQLHF_InquiryDetailsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault();
if (formBttn!=null && formBttn.Displayed)
{ new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click();
this.ScriptLogger.WriteLine("Button [Table] found and clicked.", Logger.MessageType.INF);
}


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButtonIfExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDQLHF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDQLHF] Performing VerifyExist on InquiryDetailsFormTable...", Logger.MessageType.INF);
				SeleniumControl LDQLHF_InquiryDetailsFormTable = new SeleniumControl( sDriver, "InquiryDetailsFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,LDQLHF_InquiryDetailsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDQLHF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDQLHF] Performing ClickButton on InquiryDetailsForm...", Logger.MessageType.INF);
				SeleniumControl LDQLHF_InquiryDetailsForm = new SeleniumControl( sDriver, "InquiryDetailsForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(LDQLHF_InquiryDetailsForm);
IWebElement formBttn = LDQLHF_InquiryDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? LDQLHF_InquiryDetailsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
LDQLHF_InquiryDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDQLHF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDQLHF] Performing VerifyExists on InquiryDetails_Leave_LeaveType...", Logger.MessageType.INF);
				SeleniumControl LDQLHF_InquiryDetails_Leave_LeaveType = new SeleniumControl( sDriver, "InquiryDetails_Leave_LeaveType", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='LV_TYPE_CD']");
				Function.AssertEqual(true,LDQLHF_InquiryDetails_Leave_LeaveType.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDQLHF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDQLHF] Performing Close on InquiryDetailsForm...", Logger.MessageType.INF);
				SeleniumControl LDQLHF_InquiryDetailsForm = new SeleniumControl( sDriver, "InquiryDetailsForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(LDQLHF_InquiryDetailsForm);
IWebElement formBttn = LDQLHF_InquiryDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

