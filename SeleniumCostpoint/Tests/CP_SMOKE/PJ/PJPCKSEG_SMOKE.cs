 
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
    public class PJPCKSEG_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Project Setup", "xpath","//div[@class='deptItem'][.='Project Setup']").Click();
new SeleniumControl(sDriver,"Administrative Utilities", "xpath","//div[@class='navItem'][.='Administrative Utilities']").Click();
new SeleniumControl(sDriver,"Check and/or Rebuild Project Segment IDs", "xpath","//div[@class='navItem'][.='Check and/or Rebuild Project Segment IDs']").Click();


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
				Function.CurrentComponent = "PJPCKSEG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJPCKSEG] Performing VerifyExists on CheckTheProjectIDAndLineProjectSegmentIDsForm...", Logger.MessageType.INF);
				SeleniumControl PJPCKSEG_CheckTheProjectIDAndLineProjectSegmentIDsForm = new SeleniumControl( sDriver, "CheckTheProjectIDAndLineProjectSegmentIDsForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,PJPCKSEG_CheckTheProjectIDAndLineProjectSegmentIDsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJPCKSEG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJPCKSEG] Performing VerifyExists on CheckTheProjectIDAndLineProjectSegmentIDs_Check...", Logger.MessageType.INF);
				SeleniumControl PJPCKSEG_CheckTheProjectIDAndLineProjectSegmentIDs_Check = new SeleniumControl( sDriver, "CheckTheProjectIDAndLineProjectSegmentIDs_Check", "xpath", "//div[@id='0']/form[1]/descendant::*[contains(@id,'EXECUTE') and contains(@style,'visible')]");
				Function.AssertEqual(true,PJPCKSEG_CheckTheProjectIDAndLineProjectSegmentIDs_Check.Exists());

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
				Function.CurrentComponent = "PJPCKSEG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJPCKSEG] Performing VerifyExists on CheckTheProjectIDAndLineProjectSegmentIDs_ChildForm...", Logger.MessageType.INF);
				SeleniumControl PJPCKSEG_CheckTheProjectIDAndLineProjectSegmentIDs_ChildForm = new SeleniumControl( sDriver, "CheckTheProjectIDAndLineProjectSegmentIDs_ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJPCKSEG_ZPJPTOOLPRJERRS_CHLD_']/ancestor::form[1]");
				Function.AssertEqual(true,PJPCKSEG_CheckTheProjectIDAndLineProjectSegmentIDs_ChildForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJPCKSEG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJPCKSEG] Performing VerifyExist on CheckTheProjectIDAndLineProjectSegmentIDs_ChildFormTable...", Logger.MessageType.INF);
				SeleniumControl PJPCKSEG_CheckTheProjectIDAndLineProjectSegmentIDs_ChildFormTable = new SeleniumControl( sDriver, "CheckTheProjectIDAndLineProjectSegmentIDs_ChildFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PJPCKSEG_ZPJPTOOLPRJERRS_CHLD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJPCKSEG_CheckTheProjectIDAndLineProjectSegmentIDs_ChildFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Rebuild the Line Project Segments");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJPCKSEG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJPCKSEG] Performing VerifyExists on CheckTheProjectIDAndLineProjectSegmentIDs_ChildForm_RebuildTheLineProjectSegmentIDsForm...", Logger.MessageType.INF);
				SeleniumControl PJPCKSEG_CheckTheProjectIDAndLineProjectSegmentIDs_ChildForm_RebuildTheLineProjectSegmentIDsForm = new SeleniumControl( sDriver, "CheckTheProjectIDAndLineProjectSegmentIDs_ChildForm_RebuildTheLineProjectSegmentIDsForm", "xpath", "//div[starts-with(@id,'pr__PJPCKSEG_ZPJPTOOLLVLWRK1_')]/ancestor::form[1]");
				Function.AssertEqual(true,PJPCKSEG_CheckTheProjectIDAndLineProjectSegmentIDs_ChildForm_RebuildTheLineProjectSegmentIDsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJPCKSEG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJPCKSEG] Performing VerifyExists on CheckTheProjectIDAndLineProjectSegmentIDs_ChildForm_RebuildTheLineProjectSegmentIDs_ProjectRange...", Logger.MessageType.INF);
				SeleniumControl PJPCKSEG_CheckTheProjectIDAndLineProjectSegmentIDs_ChildForm_RebuildTheLineProjectSegmentIDs_ProjectRange = new SeleniumControl( sDriver, "CheckTheProjectIDAndLineProjectSegmentIDs_ChildForm_RebuildTheLineProjectSegmentIDs_ProjectRange", "xpath", "//div[starts-with(@id,'pr__PJPCKSEG_ZPJPTOOLLVLWRK1_')]/ancestor::form[1]/descendant::*[@id='PROJ_RANGE']");
				Function.AssertEqual(true,PJPCKSEG_CheckTheProjectIDAndLineProjectSegmentIDs_ChildForm_RebuildTheLineProjectSegmentIDs_ProjectRange.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
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
				Function.CurrentComponent = "PJPCKSEG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJPCKSEG] Performing Close on CheckTheProjectIDAndLineProjectSegmentIDsForm...", Logger.MessageType.INF);
				SeleniumControl PJPCKSEG_CheckTheProjectIDAndLineProjectSegmentIDsForm = new SeleniumControl( sDriver, "CheckTheProjectIDAndLineProjectSegmentIDsForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PJPCKSEG_CheckTheProjectIDAndLineProjectSegmentIDsForm);
IWebElement formBttn = PJPCKSEG_CheckTheProjectIDAndLineProjectSegmentIDsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

