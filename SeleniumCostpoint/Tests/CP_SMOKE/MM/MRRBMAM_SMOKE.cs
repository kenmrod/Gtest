 
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
    public class MRRBMAM_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Material Requirements Planning", "xpath","//div[@class='deptItem'][.='Material Requirements Planning']").Click();
new SeleniumControl(sDriver,"MRP Reports/Inquiries", "xpath","//div[@class='navItem'][.='MRP Reports/Inquiries']").Click();
new SeleniumControl(sDriver,"Print Bills of Material MRP Action Message Report", "xpath","//div[@class='navItem'][.='Print Bills of Material MRP Action Message Report']").Click();


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
				Function.CurrentComponent = "MRRBMAM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRRBMAM] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl MRRBMAM_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,MRRBMAM_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRRBMAM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRRBMAM] Performing VerifyExists on MainForm_ParameterID...", Logger.MessageType.INF);
				SeleniumControl MRRBMAM_MainForm_ParameterID = new SeleniumControl( sDriver, "MainForm_ParameterID", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PARM_ID']");
				Function.AssertEqual(true,MRRBMAM_MainForm_ParameterID.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("ASSEMBLY PART/REV NON CONTIGUOUS RANGES LINK");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRRBMAM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRRBMAM] Performing VerifyExists on MainForm_SelectionRanges_AssemblyPartRevNonContiguousRangesLink...", Logger.MessageType.INF);
				SeleniumControl MRRBMAM_MainForm_SelectionRanges_AssemblyPartRevNonContiguousRangesLink = new SeleniumControl( sDriver, "MainForm_SelectionRanges_AssemblyPartRevNonContiguousRangesLink", "ID", "lnk_15105_MRRBMAM_PARAM");
				Function.AssertEqual(true,MRRBMAM_MainForm_SelectionRanges_AssemblyPartRevNonContiguousRangesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRRBMAM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRRBMAM] Performing Click on MainForm_SelectionRanges_AssemblyPartRevNonContiguousRangesLink...", Logger.MessageType.INF);
				SeleniumControl MRRBMAM_MainForm_SelectionRanges_AssemblyPartRevNonContiguousRangesLink = new SeleniumControl( sDriver, "MainForm_SelectionRanges_AssemblyPartRevNonContiguousRangesLink", "ID", "lnk_15105_MRRBMAM_PARAM");
				Function.WaitControlDisplayed(MRRBMAM_MainForm_SelectionRanges_AssemblyPartRevNonContiguousRangesLink);
MRRBMAM_MainForm_SelectionRanges_AssemblyPartRevNonContiguousRangesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRRBMAM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRRBMAM] Performing VerifyExist on AssemblyPartRevContiguousRangesFormTable...", Logger.MessageType.INF);
				SeleniumControl MRRBMAM_AssemblyPartRevContiguousRangesFormTable = new SeleniumControl( sDriver, "AssemblyPartRevContiguousRangesFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__MRRBMAM_NCR_ASYPART_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,MRRBMAM_AssemblyPartRevContiguousRangesFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRRBMAM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRRBMAM] Performing Close on AssemblyPartRevContiguousRangesForm...", Logger.MessageType.INF);
				SeleniumControl MRRBMAM_AssemblyPartRevContiguousRangesForm = new SeleniumControl( sDriver, "AssemblyPartRevContiguousRangesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MRRBMAM_NCR_ASYPART_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MRRBMAM_AssemblyPartRevContiguousRangesForm);
IWebElement formBttn = MRRBMAM_AssemblyPartRevContiguousRangesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("MAIN FORM TABLE");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRRBMAM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRRBMAM] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl MRRBMAM_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(MRRBMAM_MainForm);
IWebElement formBttn = MRRBMAM_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? MRRBMAM_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
MRRBMAM_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRRBMAM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRRBMAM] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl MRRBMAM_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,MRRBMAM_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
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
				Function.CurrentComponent = "MRRBMAM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRRBMAM] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl MRRBMAM_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(MRRBMAM_MainForm);
IWebElement formBttn = MRRBMAM_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

