 
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
    public class COMLNKLC_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Consolidations", "xpath","//div[@class='deptItem'][.='Consolidations']").Click();
new SeleniumControl(sDriver,"Consolidations Controls", "xpath","//div[@class='navItem'][.='Consolidations Controls']").Click();
new SeleniumControl(sDriver,"Link Consolidation Locations", "xpath","//div[@class='navItem'][.='Link Consolidation Locations']").Click();


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
				Function.CurrentComponent = "COMLNKLC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[COMLNKLC] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl COMLNKLC_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,COMLNKLC_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Customer Non Contiguous Ranges");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "COMLNKLC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[COMLNKLC] Performing Click on ConsolidationPercentageLink...", Logger.MessageType.INF);
				SeleniumControl COMLNKLC_ConsolidationPercentageLink = new SeleniumControl( sDriver, "ConsolidationPercentageLink", "ID", "lnk_3717_COMLNKLC_CONSLINKLOCMAP_HDR");
				Function.WaitControlDisplayed(COMLNKLC_ConsolidationPercentageLink);
COMLNKLC_ConsolidationPercentageLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "COMLNKLC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[COMLNKLC] Performing VerifyExist on ConsolidationPercentageFormTable...", Logger.MessageType.INF);
				SeleniumControl COMLNKLC_ConsolidationPercentageFormTable = new SeleniumControl( sDriver, "ConsolidationPercentageFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__COMLNKLC_CONSLNKLOCPCT_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,COMLNKLC_ConsolidationPercentageFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "COMLNKLC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[COMLNKLC] Performing Close on ConsolidationPercentageForm...", Logger.MessageType.INF);
				SeleniumControl COMLNKLC_ConsolidationPercentageForm = new SeleniumControl( sDriver, "ConsolidationPercentageForm", "xpath", "//div[translate(@id,'0123456789','')='pr__COMLNKLC_CONSLNKLOCPCT_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(COMLNKLC_ConsolidationPercentageForm);
IWebElement formBttn = COMLNKLC_ConsolidationPercentageForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "COMLNKLC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[COMLNKLC] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl COMLNKLC_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(COMLNKLC_MainForm);
IWebElement formBttn = COMLNKLC_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

