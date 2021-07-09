 
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
    public class BLMEUBRC_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Unbilled Receivables", "xpath","//div[@class='navItem'][.='Unbilled Receivables']").Click();
new SeleniumControl(sDriver,"Edit Unbilled Reason Codes", "xpath","//div[@class='navItem'][.='Edit Unbilled Reason Codes']").Click();


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
								Function.WaitControlDisplayed(new SeleniumControl(sDriver,"QueryTitle", "ID", "qryHeaderLabel"));
Function.AssertEqual("Edit Unbilled Reason Codes", new SeleniumControl(sDriver,"QueryTitle", "ID", "qryHeaderLabel").GetValue().Trim());


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyTitle]" , ex.Message));
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
				Function.CurrentComponent = "BLMEUBRC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMEUBRC] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl BLMEUBRC_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BLMEUBRC_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMEUBRC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMEUBRC] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl BLMEUBRC_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(BLMEUBRC_MainForm);
IWebElement formBttn = BLMEUBRC_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? BLMEUBRC_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
BLMEUBRC_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMEUBRC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMEUBRC] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl BLMEUBRC_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,BLMEUBRC_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMEUBRC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMEUBRC] Performing VerifyExists on Project...", Logger.MessageType.INF);
				SeleniumControl BLMEUBRC_Project = new SeleniumControl( sDriver, "Project", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PROJ_ID']");
				Function.AssertEqual(true,BLMEUBRC_Project.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("UNBILLED AMOUNT");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMEUBRC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMEUBRC] Performing VerifyExist on UnbilledAmountFormTable...", Logger.MessageType.INF);
				SeleniumControl BLMEUBRC_UnbilledAmountFormTable = new SeleniumControl( sDriver, "UnbilledAmountFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__BLMEUBRC_RPTUNBILLEDRSN_CHLD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BLMEUBRC_UnbilledAmountFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMEUBRC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMEUBRC] Performing ClickButton on UnbilledAmountForm...", Logger.MessageType.INF);
				SeleniumControl BLMEUBRC_UnbilledAmountForm = new SeleniumControl( sDriver, "UnbilledAmountForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BLMEUBRC_RPTUNBILLEDRSN_CHLD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BLMEUBRC_UnbilledAmountForm);
IWebElement formBttn = BLMEUBRC_UnbilledAmountForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? BLMEUBRC_UnbilledAmountForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
BLMEUBRC_UnbilledAmountForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMEUBRC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMEUBRC] Performing VerifyExists on UnbilledAmountForm...", Logger.MessageType.INF);
				SeleniumControl BLMEUBRC_UnbilledAmountForm = new SeleniumControl( sDriver, "UnbilledAmountForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BLMEUBRC_RPTUNBILLEDRSN_CHLD_']/ancestor::form[1]");
				Function.AssertEqual(true,BLMEUBRC_UnbilledAmountForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMEUBRC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMEUBRC] Performing VerifyExists on UnbilledAmount_Project...", Logger.MessageType.INF);
				SeleniumControl BLMEUBRC_UnbilledAmount_Project = new SeleniumControl( sDriver, "UnbilledAmount_Project", "xpath", "//div[translate(@id,'0123456789','')='pr__BLMEUBRC_RPTUNBILLEDRSN_CHLD_']/ancestor::form[1]/descendant::*[@id='PROJ_ID']");
				Function.AssertEqual(true,BLMEUBRC_UnbilledAmount_Project.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("CLOSE APP");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMEUBRC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMEUBRC] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl BLMEUBRC_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(BLMEUBRC_MainForm);
IWebElement formBttn = BLMEUBRC_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

