 
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
    public class LDPBRET_SMOKE : SeleniumTestScript
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
								try
				{
				this.ScriptLogger.WriteLine("START");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "CP7Main";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[CP7Main] Performing SelectMenu on NavMenu...", Logger.MessageType.INF);
				SeleniumControl CP7Main_NavMenu = new SeleniumControl( sDriver, "NavMenu", "ID", "navCont");
				if(!sDriver.Instance.FindElement(By.CssSelector("div[class='navCont']")).Displayed) new SeleniumControl(sDriver,"Browse", "css", "span[id = 'goToLbl']").Click();
new SeleniumControl(sDriver,"People", "xpath","//div[@class='busItem'][.='People']").Click();
new SeleniumControl(sDriver,"Labor", "xpath","//div[@class='deptItem'][.='Labor']").Click();
new SeleniumControl(sDriver,"Timesheet Entry/Creation", "xpath","//div[@class='navItem'][.='Timesheet Entry/Creation']").Click();
new SeleniumControl(sDriver,"Delete Retroactive Timesheet Adjustments", "xpath","//div[@class='navItem'][.='Delete Retroactive Timesheet Adjustments']").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SelectMenu]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDPBRET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDPBRET] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl LDPBRET_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,LDPBRET_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDPBRET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDPBRET] Performing VerifyExists on ParameterID...", Logger.MessageType.INF);
				SeleniumControl LDPBRET_ParameterID = new SeleniumControl( sDriver, "ParameterID", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PARM_ID']");
				Function.AssertEqual(true,LDPBRET_ParameterID.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDPBRET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDPBRET] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl LDPBRET_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(LDPBRET_MainForm);
IWebElement formBttn = LDPBRET_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? LDPBRET_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
LDPBRET_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDPBRET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDPBRET] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl LDPBRET_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,LDPBRET_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDPBRET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDPBRET] Performing Click on NonContiguousRangeSelectionsLink...", Logger.MessageType.INF);
				SeleniumControl LDPBRET_NonContiguousRangeSelectionsLink = new SeleniumControl( sDriver, "NonContiguousRangeSelectionsLink", "ID", "lnk_2365_LDPBRET_PROCESS");
				Function.WaitControlDisplayed(LDPBRET_NonContiguousRangeSelectionsLink);
LDPBRET_NonContiguousRangeSelectionsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDPBRET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDPBRET] Performing VerifyExists on EmployeeNonContiguousRangesForm...", Logger.MessageType.INF);
				SeleniumControl LDPBRET_EmployeeNonContiguousRangesForm = new SeleniumControl( sDriver, "EmployeeNonContiguousRangesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__LDPBRET_NON_CONTIG_RANGE_']/ancestor::form[1]");
				Function.AssertEqual(true,LDPBRET_EmployeeNonContiguousRangesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDPBRET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDPBRET] Performing VerifyExist on EmployeeNonContiguousRangesFormTable...", Logger.MessageType.INF);
				SeleniumControl LDPBRET_EmployeeNonContiguousRangesFormTable = new SeleniumControl( sDriver, "EmployeeNonContiguousRangesFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__LDPBRET_NON_CONTIG_RANGE_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,LDPBRET_EmployeeNonContiguousRangesFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDPBRET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDPBRET] Performing ClickButton on EmployeeNonContiguousRangesForm...", Logger.MessageType.INF);
				SeleniumControl LDPBRET_EmployeeNonContiguousRangesForm = new SeleniumControl( sDriver, "EmployeeNonContiguousRangesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__LDPBRET_NON_CONTIG_RANGE_']/ancestor::form[1]");
				Function.WaitControlDisplayed(LDPBRET_EmployeeNonContiguousRangesForm);
IWebElement formBttn = LDPBRET_EmployeeNonContiguousRangesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? LDPBRET_EmployeeNonContiguousRangesForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
LDPBRET_EmployeeNonContiguousRangesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDPBRET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDPBRET] Performing VerifyExists on EmployeeNonContiguousRanges_Start...", Logger.MessageType.INF);
				SeleniumControl LDPBRET_EmployeeNonContiguousRanges_Start = new SeleniumControl( sDriver, "EmployeeNonContiguousRanges_Start", "xpath", "//div[translate(@id,'0123456789','')='pr__LDPBRET_NON_CONTIG_RANGE_']/ancestor::form[1]/descendant::*[@id='EMPL_ID_FROM']");
				Function.AssertEqual(true,LDPBRET_EmployeeNonContiguousRanges_Start.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDPBRET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDPBRET] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl LDPBRET_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(LDPBRET_MainForm);
IWebElement formBttn = LDPBRET_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

