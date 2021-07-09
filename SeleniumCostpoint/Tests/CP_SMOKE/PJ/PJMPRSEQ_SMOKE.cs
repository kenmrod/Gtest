 
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
    public class PJMPRSEQ_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Cost and Revenue Processing", "xpath","//div[@class='deptItem'][.='Cost and Revenue Processing']").Click();
new SeleniumControl(sDriver,"Cost Pool Controls", "xpath","//div[@class='navItem'][.='Cost Pool Controls']").Click();
new SeleniumControl(sDriver,"Manage Pool Processing Sequence Numbers", "xpath","//div[@class='navItem'][.='Manage Pool Processing Sequence Numbers']").Click();


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
Function.AssertEqual("Manage Pool Processing Sequence Numbers", new SeleniumControl(sDriver,"QueryTitle", "ID", "qryHeaderLabel").GetValue().Trim());


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyTitle]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "Query";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[Query] Performing Click on Close...", Logger.MessageType.INF);
				SeleniumControl Query_Close = new SeleniumControl( sDriver, "Close", "ID", "closeQ");
				Function.WaitControlDisplayed(Query_Close);
if (Query_Close.mElement.GetAttribute("class") == "popupBtn" && sDriver.BrowserType == "ie")
Query_Close.Click(5,5);
else Query_Close.Click(4.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPRSEQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPRSEQ] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl PJMPRSEQ_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,PJMPRSEQ_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPRSEQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPRSEQ] Performing VerifyExists on AllocationGroupNumber...", Logger.MessageType.INF);
				SeleniumControl PJMPRSEQ_AllocationGroupNumber = new SeleniumControl( sDriver, "AllocationGroupNumber", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='ALLOC_GRP_NO']");
				Function.AssertEqual(true,PJMPRSEQ_AllocationGroupNumber.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPRSEQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPRSEQ] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl PJMPRSEQ_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PJMPRSEQ_MainForm);
IWebElement formBttn = PJMPRSEQ_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? PJMPRSEQ_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
PJMPRSEQ_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPRSEQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPRSEQ] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl PJMPRSEQ_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJMPRSEQ_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("CHILD FORM");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPRSEQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPRSEQ] Performing VerifyExist on SequenceInfoFormTable...", Logger.MessageType.INF);
				SeleniumControl PJMPRSEQ_SequenceInfoFormTable = new SeleniumControl( sDriver, "SequenceInfoFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMPRSEQ_POOLALLOC_CHLD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJMPRSEQ_SequenceInfoFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPRSEQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPRSEQ] Performing ClickButton on SequenceInfoForm...", Logger.MessageType.INF);
				SeleniumControl PJMPRSEQ_SequenceInfoForm = new SeleniumControl( sDriver, "SequenceInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMPRSEQ_POOLALLOC_CHLD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJMPRSEQ_SequenceInfoForm);
IWebElement formBttn = PJMPRSEQ_SequenceInfoForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PJMPRSEQ_SequenceInfoForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PJMPRSEQ_SequenceInfoForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPRSEQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPRSEQ] Performing VerifyExists on SequenceInfoForm...", Logger.MessageType.INF);
				SeleniumControl PJMPRSEQ_SequenceInfoForm = new SeleniumControl( sDriver, "SequenceInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMPRSEQ_POOLALLOC_CHLD_']/ancestor::form[1]");
				Function.AssertEqual(true,PJMPRSEQ_SequenceInfoForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPRSEQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPRSEQ] Performing VerifyExists on SequenceInfo_SequenceNumber...", Logger.MessageType.INF);
				SeleniumControl PJMPRSEQ_SequenceInfo_SequenceNumber = new SeleniumControl( sDriver, "SequenceInfo_SequenceNumber", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMPRSEQ_POOLALLOC_CHLD_']/ancestor::form[1]/descendant::*[@id='PROC_SEQ_NO']");
				Function.AssertEqual(true,PJMPRSEQ_SequenceInfo_SequenceNumber.Exists());

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
				Function.CurrentComponent = "PJMPRSEQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPRSEQ] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl PJMPRSEQ_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PJMPRSEQ_MainForm);
IWebElement formBttn = PJMPRSEQ_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

