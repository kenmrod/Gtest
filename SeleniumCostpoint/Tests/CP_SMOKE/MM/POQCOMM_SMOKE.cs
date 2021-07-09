 
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
    public class POQCOMM_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Materials", "xpath","//div[@class='busItem'][.='Materials']").Click();
new SeleniumControl(sDriver,"Purchasing", "xpath","//div[@class='deptItem'][.='Purchasing']").Click();
new SeleniumControl(sDriver,"Purchasing Reports/Inquiries", "xpath","//div[@class='navItem'][.='Purchasing Reports/Inquiries']").Click();
new SeleniumControl(sDriver,"View Purchase Order Commitments Summary", "xpath","//div[@class='navItem'][.='View Purchase Order Commitments Summary']").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SelectMenu]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("MainForm");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQCOMM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQCOMM] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl POQCOMM_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,POQCOMM_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQCOMM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQCOMM] Performing VerifyExists on AccountingPeriod_FiscalYear...", Logger.MessageType.INF);
				SeleniumControl POQCOMM_AccountingPeriod_FiscalYear = new SeleniumControl( sDriver, "AccountingPeriod_FiscalYear", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='FY_CD']");
				Function.AssertEqual(true,POQCOMM_AccountingPeriod_FiscalYear.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("ChildForm");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQCOMM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQCOMM] Performing VerifyExist on ChildFormTable...", Logger.MessageType.INF);
				SeleniumControl POQCOMM_ChildFormTable = new SeleniumControl( sDriver, "ChildFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__POQCOMM_POCOMMITSUM_DTL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,POQCOMM_ChildFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQCOMM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQCOMM] Performing ClickButton on ChildForm...", Logger.MessageType.INF);
				SeleniumControl POQCOMM_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POQCOMM_POCOMMITSUM_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POQCOMM_ChildForm);
IWebElement formBttn = POQCOMM_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? POQCOMM_ChildForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
POQCOMM_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQCOMM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQCOMM] Performing VerifyExists on ChildForm...", Logger.MessageType.INF);
				SeleniumControl POQCOMM_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POQCOMM_POCOMMITSUM_DTL_']/ancestor::form[1]");
				Function.AssertEqual(true,POQCOMM_ChildForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQCOMM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQCOMM] Performing VerifyExists on ChildForm_Project...", Logger.MessageType.INF);
				SeleniumControl POQCOMM_ChildForm_Project = new SeleniumControl( sDriver, "ChildForm_Project", "xpath", "//div[translate(@id,'0123456789','')='pr__POQCOMM_POCOMMITSUM_DTL_']/ancestor::form[1]/descendant::*[@id='PROJ_ID']");
				Function.AssertEqual(true,POQCOMM_ChildForm_Project.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("MainForm Close");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQCOMM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQCOMM] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl POQCOMM_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(POQCOMM_MainForm);
IWebElement formBttn = POQCOMM_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

