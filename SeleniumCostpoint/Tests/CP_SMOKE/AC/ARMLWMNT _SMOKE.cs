 
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
    public class ARMLWMNT__SMOKE : SeleniumTestScript
    {
        public override bool TestExecute(out string ErrorMessage, string TestEnvironment, IDriver Driver)
        {
			bool ret = true;
			ErrorMessage = string.Empty;
			SeleniumDriver sDriver = Driver as SeleniumDriver;
			Functions Function = new Functions(sDriver, this);
            int Row = 0;
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
new SeleniumControl(sDriver,"Accounts Receivable", "xpath","//div[@class='deptItem'][.='Accounts Receivable']").Click();
new SeleniumControl(sDriver,"Lien Waiver Controls", "xpath","//div[@class='navItem'][.='Lien Waiver Controls']").Click();
new SeleniumControl(sDriver,"Manage A/R Lien Waiver Information", "xpath","//div[@class='navItem'][.='Manage A/R Lien Waiver Information']").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SelectMenu]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMLWMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMLWMNT] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl ARMLWMNT_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(ARMLWMNT_MainForm);
IWebElement formBttn = ARMLWMNT_MainForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).Count <= 0 ? ARMLWMNT_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Query')]")).FirstOrDefault() :
ARMLWMNT_MainForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).FirstOrDefault();
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
								try
				{
				this.ScriptLogger.WriteLine("MAIN FORM");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMLWMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMLWMNT] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl ARMLWMNT_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,ARMLWMNT_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMLWMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMLWMNT] Performing GetTableRowWithColumnValue on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl ARMLWMNT_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Table mTable = new Table(sDriver,ARMLWMNT_MainFormTable, this);
Row = mTable.GetTableRowWithColumnValue("Project*","AMAR");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [GetTableRowWithColumnValue]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMLWMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMLWMNT] Performing VerifyTableCellValue on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl ARMLWMNT_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Table mTable = new Table(sDriver,ARMLWMNT_MainFormTable, this);
Function.AssertEqual("lien document", mTable.GetTableCellValue(Row,"Project Name"));


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyTableCellValue]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMLWMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMLWMNT] Performing ClickTableCellByRowColumn on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl ARMLWMNT_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Table mTable = new Table(sDriver,ARMLWMNT_MainFormTable, this);
mTable.ClickTableCellByRowColumn(Row,"Project*");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickTableCellByRowColumn]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMLWMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMLWMNT] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl ARMLWMNT_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(ARMLWMNT_MainForm);
IWebElement formBttn = ARMLWMNT_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? ARMLWMNT_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
ARMLWMNT_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMLWMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMLWMNT] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl ARMLWMNT_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,ARMLWMNT_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMLWMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMLWMNT] Performing VerifyExists on Project...", Logger.MessageType.INF);
				SeleniumControl ARMLWMNT_Project = new SeleniumControl( sDriver, "Project", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PROJ_ID']");
				Function.AssertEqual(true,ARMLWMNT_Project.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMLWMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMLWMNT] Performing VerifyExist on LienWaiverDetailsFormTable...", Logger.MessageType.INF);
				SeleniumControl ARMLWMNT_LienWaiverDetailsFormTable = new SeleniumControl( sDriver, "LienWaiverDetailsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__ARMLWMNT_LIENWAIVERHDR_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,ARMLWMNT_LienWaiverDetailsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMLWMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMLWMNT] Performing ClickButton on LienWaiverDetailsForm...", Logger.MessageType.INF);
				SeleniumControl ARMLWMNT_LienWaiverDetailsForm = new SeleniumControl( sDriver, "LienWaiverDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ARMLWMNT_LIENWAIVERHDR_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ARMLWMNT_LienWaiverDetailsForm);
IWebElement formBttn = ARMLWMNT_LienWaiverDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? ARMLWMNT_LienWaiverDetailsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
ARMLWMNT_LienWaiverDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMLWMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMLWMNT] Performing VerifyExists on LienWaiverDetailsForm...", Logger.MessageType.INF);
				SeleniumControl ARMLWMNT_LienWaiverDetailsForm = new SeleniumControl( sDriver, "LienWaiverDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ARMLWMNT_LIENWAIVERHDR_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,ARMLWMNT_LienWaiverDetailsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMLWMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMLWMNT] Performing VerifyExists on LienWaiverDetails_LienNumber...", Logger.MessageType.INF);
				SeleniumControl ARMLWMNT_LienWaiverDetails_LienNumber = new SeleniumControl( sDriver, "LienWaiverDetails_LienNumber", "xpath", "//div[translate(@id,'0123456789','')='pr__ARMLWMNT_LIENWAIVERHDR_CTW_']/ancestor::form[1]/descendant::*[@id='LIEN_NO']");
				Function.AssertEqual(true,ARMLWMNT_LienWaiverDetails_LienNumber.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMLWMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMLWMNT] Performing VerifyExists on LienWaiverDetails_LienWaiverDetailLink...", Logger.MessageType.INF);
				SeleniumControl ARMLWMNT_LienWaiverDetails_LienWaiverDetailLink = new SeleniumControl( sDriver, "LienWaiverDetails_LienWaiverDetailLink", "ID", "lnk_1002191_ARMLWMNT_LIENWAIVERHDR_CTW");
				Function.AssertEqual(true,ARMLWMNT_LienWaiverDetails_LienWaiverDetailLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMLWMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMLWMNT] Performing Click on LienWaiverDetails_LienWaiverDetailLink...", Logger.MessageType.INF);
				SeleniumControl ARMLWMNT_LienWaiverDetails_LienWaiverDetailLink = new SeleniumControl( sDriver, "LienWaiverDetails_LienWaiverDetailLink", "ID", "lnk_1002191_ARMLWMNT_LIENWAIVERHDR_CTW");
				Function.WaitControlDisplayed(ARMLWMNT_LienWaiverDetails_LienWaiverDetailLink);
ARMLWMNT_LienWaiverDetails_LienWaiverDetailLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMLWMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMLWMNT] Performing VerifyExist on LienWaiverDetails_LienWaiverDetail_LienWaiverDetailTable...", Logger.MessageType.INF);
				SeleniumControl ARMLWMNT_LienWaiverDetails_LienWaiverDetail_LienWaiverDetailTable = new SeleniumControl( sDriver, "LienWaiverDetails_LienWaiverDetail_LienWaiverDetailTable", "xpath", "//div[translate(@id,'0123456789','')='pr__ARMLWMNT_LIENWVRARDETL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,ARMLWMNT_LienWaiverDetails_LienWaiverDetail_LienWaiverDetailTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMLWMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMLWMNT] Performing ClickButton on LienWaiverDetails_LienWaiverDetailForm...", Logger.MessageType.INF);
				SeleniumControl ARMLWMNT_LienWaiverDetails_LienWaiverDetailForm = new SeleniumControl( sDriver, "LienWaiverDetails_LienWaiverDetailForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ARMLWMNT_LIENWVRARDETL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ARMLWMNT_LienWaiverDetails_LienWaiverDetailForm);
IWebElement formBttn = ARMLWMNT_LienWaiverDetails_LienWaiverDetailForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? ARMLWMNT_LienWaiverDetails_LienWaiverDetailForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
ARMLWMNT_LienWaiverDetails_LienWaiverDetailForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMLWMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMLWMNT] Performing VerifyExists on LienWaiverDetails_LienWaiverDetail_InvoiceNo...", Logger.MessageType.INF);
				SeleniumControl ARMLWMNT_LienWaiverDetails_LienWaiverDetail_InvoiceNo = new SeleniumControl( sDriver, "LienWaiverDetails_LienWaiverDetail_InvoiceNo", "xpath", "//div[translate(@id,'0123456789','')='pr__ARMLWMNT_LIENWVRARDETL_']/ancestor::form[1]/descendant::*[@id='INVC_ID']");
				Function.AssertEqual(true,ARMLWMNT_LienWaiverDetails_LienWaiverDetail_InvoiceNo.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMLWMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMLWMNT] Performing Close on LienWaiverDetails_LienWaiverDetailForm...", Logger.MessageType.INF);
				SeleniumControl ARMLWMNT_LienWaiverDetails_LienWaiverDetailForm = new SeleniumControl( sDriver, "LienWaiverDetails_LienWaiverDetailForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ARMLWMNT_LIENWVRARDETL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ARMLWMNT_LienWaiverDetails_LienWaiverDetailForm);
IWebElement formBttn = ARMLWMNT_LienWaiverDetails_LienWaiverDetailForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
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
				Function.CurrentComponent = "ARMLWMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMLWMNT] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl ARMLWMNT_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(ARMLWMNT_MainForm);
IWebElement formBttn = ARMLWMNT_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

