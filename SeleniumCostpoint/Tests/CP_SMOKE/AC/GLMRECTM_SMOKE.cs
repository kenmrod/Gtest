 
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
    public class GLMRECTM_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Manage Recurring Journal Entry Templates", "xpath","//div[@class='navItem'][.='Manage Recurring Journal Entry Templates']").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SelectMenu]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "Query";
								SeleniumControl ctl = new SeleniumControl(sDriver,"Target", "xpath_display", "//*[@id='basicQTbl']/tbody/tr/td/span[text()='Cycle']");
Function.WaitControlDisplayed(ctl);
SeleniumControl RelationshipField = new SeleniumControl(sDriver,"Relationship", ctl.mElement.FindElement(By.XPath("../following-sibling::td[1]")));
SeleniumControl SearchField = new SeleniumControl(sDriver,"Relationship", ctl.mElement.FindElement(By.XPath("../following-sibling::td[2]")));
new SeleniumControl(sDriver, "RelDropdown", RelationshipField.mElement.FindElements(By.XPath("./descendant::*[@class='tCCBImg']")).FirstOrDefault()).Click();
new SeleniumControl(sDriver, "RelItem", "xpath", ".//descendant::div[text() = 'is equal to']").Click();
if (SearchField.mElement.GetAttribute("class").Equals("tCCB")) {
new SeleniumControl(sDriver, "SearchDropdown", SearchField.mElement.FindElements(By.XPath(".//descendant::*[@class='tCCBImg']")).FirstOrDefault()).Click();
new SeleniumControl(sDriver, "SearchItem", "xpath_display", ".//descendant::div[text()='MONTHLY']").Click();
} else { 
new SeleniumControl(sDriver, "SearchDropdown", SearchField.mElement.FindElements(By.XPath(".//descendant::*[@class='queryBasicFld']")).FirstOrDefault()).SendKeys("MONTHLY");}


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
								try
				{
				this.ScriptLogger.WriteLine("MAIN TABLE");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMRECTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMRECTM] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl GLMRECTM_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(GLMRECTM_MainForm);
IWebElement formBttn = GLMRECTM_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? GLMRECTM_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
GLMRECTM_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMRECTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMRECTM] Performing VerifyExist on MainTable...", Logger.MessageType.INF);
				SeleniumControl GLMRECTM_MainTable = new SeleniumControl( sDriver, "MainTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,GLMRECTM_MainTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMRECTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMRECTM] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl GLMRECTM_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(GLMRECTM_MainForm);
IWebElement formBttn = GLMRECTM_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? GLMRECTM_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
GLMRECTM_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMRECTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMRECTM] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl GLMRECTM_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,GLMRECTM_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMRECTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMRECTM] Performing VerifyExists on Cycle...", Logger.MessageType.INF);
				SeleniumControl GLMRECTM_Cycle = new SeleniumControl( sDriver, "Cycle", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='CYCLE_DC']");
				Function.AssertEqual(true,GLMRECTM_Cycle.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMRECTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMRECTM] Performing VerifyExist on FiscalYearFormTable...", Logger.MessageType.INF);
				SeleniumControl GLMRECTM_FiscalYearFormTable = new SeleniumControl( sDriver, "FiscalYearFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__GLMRECTM_RECURJETMPLT_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,GLMRECTM_FiscalYearFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMRECTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMRECTM] Performing ClickButton on FiscalYearForm...", Logger.MessageType.INF);
				SeleniumControl GLMRECTM_FiscalYearForm = new SeleniumControl( sDriver, "FiscalYearForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLMRECTM_RECURJETMPLT_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(GLMRECTM_FiscalYearForm);
IWebElement formBttn = GLMRECTM_FiscalYearForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? GLMRECTM_FiscalYearForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
GLMRECTM_FiscalYearForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMRECTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMRECTM] Performing VerifyExists on FiscalYearForm...", Logger.MessageType.INF);
				SeleniumControl GLMRECTM_FiscalYearForm = new SeleniumControl( sDriver, "FiscalYearForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLMRECTM_RECURJETMPLT_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,GLMRECTM_FiscalYearForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMRECTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMRECTM] Performing VerifyExists on FiscalYear_JENumber...", Logger.MessageType.INF);
				SeleniumControl GLMRECTM_FiscalYear_JENumber = new SeleniumControl( sDriver, "FiscalYear_JENumber", "xpath", "//div[translate(@id,'0123456789','')='pr__GLMRECTM_RECURJETMPLT_CTW_']/ancestor::form[1]/descendant::*[@id='JE_NO']");
				Function.AssertEqual(true,GLMRECTM_FiscalYear_JENumber.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMRECTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMRECTM] Performing VerifyExists on FiscalYear_ShowTemplateLink...", Logger.MessageType.INF);
				SeleniumControl GLMRECTM_FiscalYear_ShowTemplateLink = new SeleniumControl( sDriver, "FiscalYear_ShowTemplateLink", "ID", "lnk_1001294_GLMRECTM_RECURJETMPLT_CTW");
				Function.AssertEqual(true,GLMRECTM_FiscalYear_ShowTemplateLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMRECTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMRECTM] Performing Click on FiscalYear_ShowTemplateLink...", Logger.MessageType.INF);
				SeleniumControl GLMRECTM_FiscalYear_ShowTemplateLink = new SeleniumControl( sDriver, "FiscalYear_ShowTemplateLink", "ID", "lnk_1001294_GLMRECTM_RECURJETMPLT_CTW");
				Function.WaitControlDisplayed(GLMRECTM_FiscalYear_ShowTemplateLink);
GLMRECTM_FiscalYear_ShowTemplateLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMRECTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMRECTM] Performing VerifyExists on ShowTemplate_PostedJETemplate_JEDetails_Type...", Logger.MessageType.INF);
				SeleniumControl GLMRECTM_ShowTemplate_PostedJETemplate_JEDetails_Type = new SeleniumControl( sDriver, "ShowTemplate_PostedJETemplate_JEDetails_Type", "xpath", "//div[translate(@id,'0123456789','')='pr__GLMRECTM_JEHDRHS_']/ancestor::form[1]/descendant::*[@id='S_JNL_CD']");
				Function.AssertEqual(true,GLMRECTM_ShowTemplate_PostedJETemplate_JEDetails_Type.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMRECTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMRECTM] Performing ClickButton on ShowTemplateForm...", Logger.MessageType.INF);
				SeleniumControl GLMRECTM_ShowTemplateForm = new SeleniumControl( sDriver, "ShowTemplateForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLMRECTM_JEHDRHS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(GLMRECTM_ShowTemplateForm);
IWebElement formBttn = GLMRECTM_ShowTemplateForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? GLMRECTM_ShowTemplateForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
GLMRECTM_ShowTemplateForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMRECTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMRECTM] Performing VerifyExist on ShowTemplateFormTable...", Logger.MessageType.INF);
				SeleniumControl GLMRECTM_ShowTemplateFormTable = new SeleniumControl( sDriver, "ShowTemplateFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__GLMRECTM_JEHDRHS_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,GLMRECTM_ShowTemplateFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMRECTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMRECTM] Performing VerifyExist on ShowTemplateChildFormTable...", Logger.MessageType.INF);
				SeleniumControl GLMRECTM_ShowTemplateChildFormTable = new SeleniumControl( sDriver, "ShowTemplateChildFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__GLMRECTM_JETRNHS_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,GLMRECTM_ShowTemplateChildFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMRECTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMRECTM] Performing VerifyExists on ShowTemplateChildForm...", Logger.MessageType.INF);
				SeleniumControl GLMRECTM_ShowTemplateChildForm = new SeleniumControl( sDriver, "ShowTemplateChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLMRECTM_JETRNHS_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,GLMRECTM_ShowTemplateChildForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMRECTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMRECTM] Performing VerifyExists on ShowTemplateChildForm...", Logger.MessageType.INF);
				SeleniumControl GLMRECTM_ShowTemplateChildForm = new SeleniumControl( sDriver, "ShowTemplateChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLMRECTM_JETRNHS_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,GLMRECTM_ShowTemplateChildForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMRECTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMRECTM] Performing Close on ShowTemplateForm...", Logger.MessageType.INF);
				SeleniumControl GLMRECTM_ShowTemplateForm = new SeleniumControl( sDriver, "ShowTemplateForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLMRECTM_JEHDRHS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(GLMRECTM_ShowTemplateForm);
IWebElement formBttn = GLMRECTM_ShowTemplateForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "GLMRECTM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMRECTM] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl GLMRECTM_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(GLMRECTM_MainForm);
IWebElement formBttn = GLMRECTM_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

