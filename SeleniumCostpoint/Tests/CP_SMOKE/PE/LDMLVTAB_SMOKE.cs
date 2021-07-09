 
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
    public class LDMLVTAB_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Leave Controls", "xpath","//div[@class='navItem'][.='Leave Controls']").Click();
new SeleniumControl(sDriver,"Manage Leave Codes", "xpath","//div[@class='navItem'][.='Manage Leave Codes']").Click();


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
				Function.CurrentComponent = "LDMLVTAB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMLVTAB] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl LDMLVTAB_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,LDMLVTAB_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMLVTAB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMLVTAB] Performing VerifyExists on LeaveCode...", Logger.MessageType.INF);
				SeleniumControl LDMLVTAB_LeaveCode = new SeleniumControl( sDriver, "LeaveCode", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='LV_CD']");
				Function.AssertEqual(true,LDMLVTAB_LeaveCode.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMLVTAB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMLVTAB] Performing VerifyExists on LeaveTableDetailsLink...", Logger.MessageType.INF);
				SeleniumControl LDMLVTAB_LeaveTableDetailsLink = new SeleniumControl( sDriver, "LeaveTableDetailsLink", "ID", "lnk_1001487_LDMLVTAB_LVTABLE_HDR");
				Function.AssertEqual(true,LDMLVTAB_LeaveTableDetailsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMLVTAB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMLVTAB] Performing VerifyExists on LeaveTableDetails...", Logger.MessageType.INF);
				SeleniumControl LDMLVTAB_LeaveTableDetails = new SeleniumControl( sDriver, "LeaveTableDetails", "xpath", "//div[translate(@id,'0123456789','')='pr__LDMLVTAB_LVTABLESCH_DTL_']/ancestor::form[1]");
				Function.AssertEqual(true,LDMLVTAB_LeaveTableDetails.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMLVTAB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMLVTAB] Performing VerifyExist on LeaveTableDetailsTable...", Logger.MessageType.INF);
				SeleniumControl LDMLVTAB_LeaveTableDetailsTable = new SeleniumControl( sDriver, "LeaveTableDetailsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__LDMLVTAB_LVTABLESCH_DTL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,LDMLVTAB_LeaveTableDetailsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMLVTAB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMLVTAB] Performing ClickButton on LeaveTableDetails...", Logger.MessageType.INF);
				SeleniumControl LDMLVTAB_LeaveTableDetails = new SeleniumControl( sDriver, "LeaveTableDetails", "xpath", "//div[translate(@id,'0123456789','')='pr__LDMLVTAB_LVTABLESCH_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(LDMLVTAB_LeaveTableDetails);
IWebElement formBttn = LDMLVTAB_LeaveTableDetails.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? LDMLVTAB_LeaveTableDetails.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
LDMLVTAB_LeaveTableDetails.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMLVTAB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMLVTAB] Performing VerifyExists on LeaveTableDetails_MonthsOfService...", Logger.MessageType.INF);
				SeleniumControl LDMLVTAB_LeaveTableDetails_MonthsOfService = new SeleniumControl( sDriver, "LeaveTableDetails_MonthsOfService", "xpath", "//div[translate(@id,'0123456789','')='pr__LDMLVTAB_LVTABLESCH_DTL_']/ancestor::form[1]/descendant::*[@id='MO_SERV_NO']");
				Function.AssertEqual(true,LDMLVTAB_LeaveTableDetails_MonthsOfService.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMLVTAB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMLVTAB] Performing Close on LeaveTableDetails...", Logger.MessageType.INF);
				SeleniumControl LDMLVTAB_LeaveTableDetails = new SeleniumControl( sDriver, "LeaveTableDetails", "xpath", "//div[translate(@id,'0123456789','')='pr__LDMLVTAB_LVTABLESCH_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(LDMLVTAB_LeaveTableDetails);
IWebElement formBttn = LDMLVTAB_LeaveTableDetails.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMLVTAB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMLVTAB] Performing VerifyExists on EligibleLaborLocationsLink...", Logger.MessageType.INF);
				SeleniumControl LDMLVTAB_EligibleLaborLocationsLink = new SeleniumControl( sDriver, "EligibleLaborLocationsLink", "ID", "lnk_5618_LDMLVTAB_LVTABLE_HDR");
				Function.AssertEqual(true,LDMLVTAB_EligibleLaborLocationsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMLVTAB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMLVTAB] Performing Click on EligibleLaborLocationsLink...", Logger.MessageType.INF);
				SeleniumControl LDMLVTAB_EligibleLaborLocationsLink = new SeleniumControl( sDriver, "EligibleLaborLocationsLink", "ID", "lnk_5618_LDMLVTAB_LVTABLE_HDR");
				Function.WaitControlDisplayed(LDMLVTAB_EligibleLaborLocationsLink);
LDMLVTAB_EligibleLaborLocationsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMLVTAB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMLVTAB] Performing VerifyExists on EligibleLaborLocations1Form...", Logger.MessageType.INF);
				SeleniumControl LDMLVTAB_EligibleLaborLocations1Form = new SeleniumControl( sDriver, "EligibleLaborLocations1Form", "xpath", "//div[translate(@id,'0123456789','')='pr__LDMLVTAB_LABLOC_CHILD_']/ancestor::form[1]");
				Function.AssertEqual(true,LDMLVTAB_EligibleLaborLocations1Form.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMLVTAB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMLVTAB] Performing VerifyExists on EligibleLaborLocations2Form...", Logger.MessageType.INF);
				SeleniumControl LDMLVTAB_EligibleLaborLocations2Form = new SeleniumControl( sDriver, "EligibleLaborLocations2Form", "xpath", "//div[translate(@id,'0123456789','')='pr__LDMLVTAB_ELIGLABLOC_CHILD_']/ancestor::form[1]");
				Function.AssertEqual(true,LDMLVTAB_EligibleLaborLocations2Form.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMLVTAB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMLVTAB] Performing VerifyExist on EligibleLaborLocations1Table...", Logger.MessageType.INF);
				SeleniumControl LDMLVTAB_EligibleLaborLocations1Table = new SeleniumControl( sDriver, "EligibleLaborLocations1Table", "xpath", "//div[translate(@id,'0123456789','')='pr__LDMLVTAB_LABLOC_CHILD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,LDMLVTAB_EligibleLaborLocations1Table.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMLVTAB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMLVTAB] Performing VerifyExist on EligibleLaborLocations2Table...", Logger.MessageType.INF);
				SeleniumControl LDMLVTAB_EligibleLaborLocations2Table = new SeleniumControl( sDriver, "EligibleLaborLocations2Table", "xpath", "//div[translate(@id,'0123456789','')='pr__LDMLVTAB_ELIGLABLOC_CHILD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,LDMLVTAB_EligibleLaborLocations2Table.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMLVTAB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMLVTAB] Performing Close on EligibleLaborLocations2Form...", Logger.MessageType.INF);
				SeleniumControl LDMLVTAB_EligibleLaborLocations2Form = new SeleniumControl( sDriver, "EligibleLaborLocations2Form", "xpath", "//div[translate(@id,'0123456789','')='pr__LDMLVTAB_ELIGLABLOC_CHILD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(LDMLVTAB_EligibleLaborLocations2Form);
IWebElement formBttn = LDMLVTAB_EligibleLaborLocations2Form.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMLVTAB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMLVTAB] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl LDMLVTAB_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(LDMLVTAB_MainForm);
IWebElement formBttn = LDMLVTAB_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? LDMLVTAB_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
LDMLVTAB_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMLVTAB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMLVTAB] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl LDMLVTAB_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,LDMLVTAB_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Close App");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMLVTAB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMLVTAB] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl LDMLVTAB_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(LDMLVTAB_MainForm);
IWebElement formBttn = LDMLVTAB_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

