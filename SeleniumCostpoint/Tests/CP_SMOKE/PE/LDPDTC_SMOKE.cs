 
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
    public class LDPDTC_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Labor", "xpath","//div[@class='deptItem'][.='Labor']").Click();
new SeleniumControl(sDriver,"Timesheet Interface", "xpath","//div[@class='navItem'][.='Timesheet Interface']").Click();
new SeleniumControl(sDriver,"Export Data To Deltek Time and Expense", "xpath","//div[@class='navItem'][.='Export Data To Deltek Time and Expense']").Click();


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
				Function.CurrentComponent = "LDPDTC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDPDTC] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl LDPDTC_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,LDPDTC_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDPDTC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDPDTC] Performing VerifyExists on ParameterID...", Logger.MessageType.INF);
				SeleniumControl LDPDTC_ParameterID = new SeleniumControl( sDriver, "ParameterID", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PARM_ID']");
				Function.AssertEqual(true,LDPDTC_ParameterID.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDPDTC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDPDTC] Performing VerifyExists on MainFormSelectionRangesTab...", Logger.MessageType.INF);
				SeleniumControl LDPDTC_MainFormSelectionRangesTab = new SeleniumControl( sDriver, "MainFormSelectionRangesTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.AssertEqual(true,LDPDTC_MainFormSelectionRangesTab.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDPDTC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDPDTC] Performing Select on MainFormSelectionRangesTab...", Logger.MessageType.INF);
				SeleniumControl LDPDTC_MainFormSelectionRangesTab = new SeleniumControl( sDriver, "MainFormSelectionRangesTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(LDPDTC_MainFormSelectionRangesTab);
IWebElement mTab = LDPDTC_MainFormSelectionRangesTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Export Information").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDPDTC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDPDTC] Performing VerifyExists on SelectionRanges_ExportInformation_FileLocation...", Logger.MessageType.INF);
				SeleniumControl LDPDTC_SelectionRanges_ExportInformation_FileLocation = new SeleniumControl( sDriver, "SelectionRanges_ExportInformation_FileLocation", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='FILE_PATH']");
				Function.AssertEqual(true,LDPDTC_SelectionRanges_ExportInformation_FileLocation.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDPDTC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDPDTC] Performing Select on MainFormSelectionRangesTab...", Logger.MessageType.INF);
				SeleniumControl LDPDTC_MainFormSelectionRangesTab = new SeleniumControl( sDriver, "MainFormSelectionRangesTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(LDPDTC_MainFormSelectionRangesTab);
IWebElement mTab = LDPDTC_MainFormSelectionRangesTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Base/Link Tables").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDPDTC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDPDTC] Performing VerifyExists on SelectionRanges_BaseLinkTables_Options_ProjectName...", Logger.MessageType.INF);
				SeleniumControl LDPDTC_SelectionRanges_BaseLinkTables_Options_ProjectName = new SeleniumControl( sDriver, "SelectionRanges_BaseLinkTables_Options_ProjectName", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PROJ_NAME']");
				Function.AssertEqual(true,LDPDTC_SelectionRanges_BaseLinkTables_Options_ProjectName.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDPDTC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDPDTC] Performing Select on MainFormSelectionRangesTab...", Logger.MessageType.INF);
				SeleniumControl LDPDTC_MainFormSelectionRangesTab = new SeleniumControl( sDriver, "MainFormSelectionRangesTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(LDPDTC_MainFormSelectionRangesTab);
IWebElement mTab = LDPDTC_MainFormSelectionRangesTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Resource Information").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDPDTC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDPDTC] Performing VerifyExists on SelectionRanges_EMPLOYEEInformation_DeltekTimeAndExpenseEMPLOYEEMappings_UserDefinedCode1...", Logger.MessageType.INF);
				SeleniumControl LDPDTC_SelectionRanges_EMPLOYEEInformation_DeltekTimeAndExpenseEMPLOYEEMappings_UserDefinedCode1 = new SeleniumControl( sDriver, "SelectionRanges_EMPLOYEEInformation_DeltekTimeAndExpenseEMPLOYEEMappings_UserDefinedCode1", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='USER_DEF_1']");
				Function.AssertEqual(true,LDPDTC_SelectionRanges_EMPLOYEEInformation_DeltekTimeAndExpenseEMPLOYEEMappings_UserDefinedCode1.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDPDTC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDPDTC] Performing Select on MainFormSelectionRangesTab...", Logger.MessageType.INF);
				SeleniumControl LDPDTC_MainFormSelectionRangesTab = new SeleniumControl( sDriver, "MainFormSelectionRangesTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(LDPDTC_MainFormSelectionRangesTab);
IWebElement mTab = LDPDTC_MainFormSelectionRangesTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Charge Trees").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDPDTC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDPDTC] Performing VerifyExists on SelectionRanges_ChargeTrees_ChargeTrees_TreeCode...", Logger.MessageType.INF);
				SeleniumControl LDPDTC_SelectionRanges_ChargeTrees_ChargeTrees_TreeCode = new SeleniumControl( sDriver, "SelectionRanges_ChargeTrees_ChargeTrees_TreeCode", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='TREE_CD']");
				Function.AssertEqual(true,LDPDTC_SelectionRanges_ChargeTrees_ChargeTrees_TreeCode.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDPDTC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDPDTC] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl LDPDTC_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(LDPDTC_MainForm);
IWebElement formBttn = LDPDTC_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? LDPDTC_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
LDPDTC_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDPDTC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDPDTC] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl LDPDTC_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,LDPDTC_MainFormTable.Exists());

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
				Function.CurrentComponent = "LDPDTC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDPDTC] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl LDPDTC_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(LDPDTC_MainForm);
IWebElement formBttn = LDPDTC_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

