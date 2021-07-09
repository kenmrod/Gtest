 
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
    public class MEQPWU_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Materials Estimating", "xpath","//div[@class='deptItem'][.='Materials Estimating']").Click();
new SeleniumControl(sDriver,"Materials Estimating Reports/Inquiries", "xpath","//div[@class='navItem'][.='Materials Estimating Reports/Inquiries']").Click();
new SeleniumControl(sDriver,"View Proposal BOM Where-Used Information", "xpath","//div[@class='navItem'][.='View Proposal BOM Where-Used Information']").Click();


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
				Function.CurrentComponent = "MEQPWU";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEQPWU] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl MEQPWU_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,MEQPWU_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEQPWU";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEQPWU] Performing VerifyExists on MainForm_Component_CompPart...", Logger.MessageType.INF);
				SeleniumControl MEQPWU_MainForm_Component_CompPart = new SeleniumControl( sDriver, "MainForm_Component_CompPart", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='COMP_PART_ID']");
				Function.AssertEqual(true,MEQPWU_MainForm_Component_CompPart.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("SET DATA");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEQPWU";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEQPWU] Performing Set on MainForm_Component_CompPart...", Logger.MessageType.INF);
				SeleniumControl MEQPWU_MainForm_Component_CompPart = new SeleniumControl( sDriver, "MainForm_Component_CompPart", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='COMP_PART_ID']");
				MEQPWU_MainForm_Component_CompPart.Click();
MEQPWU_MainForm_Component_CompPart.SendKeys("(KVCC) W6", true);
Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));
MEQPWU_MainForm_Component_CompPart.SendKeys(OpenQA.Selenium.Keys.Shift + OpenQA.Selenium.Keys.Tab);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Set]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "CP7Main";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[CP7Main] Performing ClickToolbarButton on MainToolBar...", Logger.MessageType.INF);
				SeleniumControl CP7Main_MainToolBar = new SeleniumControl( sDriver, "MainToolBar", "ID", "tlbr");
				Function.WaitControlDisplayed(CP7Main_MainToolBar);
IWebElement tlbrBtn = CP7Main_MainToolBar.mElement.FindElements(By.XPath(".//*[@class='tbBtnContainer']//div[contains(@title,'Execute')]")).FirstOrDefault();
if (tlbrBtn==null) throw new Exception("Unable to find button Execute.");
tlbrBtn.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickToolbarButton]" , ex.Message));
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
				Function.CurrentComponent = "MEQPWU";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEQPWU] Performing VerifyExist on ChildFormTable...", Logger.MessageType.INF);
				SeleniumControl MEQPWU_ChildFormTable = new SeleniumControl( sDriver, "ChildFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__MEQPWU_ZMEQPWU_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,MEQPWU_ChildFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEQPWU";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEQPWU] Performing ClickButton on ChildForm...", Logger.MessageType.INF);
				SeleniumControl MEQPWU_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MEQPWU_ZMEQPWU_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MEQPWU_ChildForm);
IWebElement formBttn = MEQPWU_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? MEQPWU_ChildForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
MEQPWU_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("TAB");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEQPWU";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEQPWU] Performing VerifyExists on ChildForm_BasicInfo_Line...", Logger.MessageType.INF);
				SeleniumControl MEQPWU_ChildForm_BasicInfo_Line = new SeleniumControl( sDriver, "ChildForm_BasicInfo_Line", "xpath", "//div[translate(@id,'0123456789','')='pr__MEQPWU_ZMEQPWU_CTW_']/ancestor::form[1]/descendant::*[@id='COMP_LN_NO']");
				Function.AssertEqual(true,MEQPWU_ChildForm_BasicInfo_Line.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEQPWU";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEQPWU] Performing Select on ChildForm_ChildFormTab...", Logger.MessageType.INF);
				SeleniumControl MEQPWU_ChildForm_ChildFormTab = new SeleniumControl( sDriver, "ChildForm_ChildFormTab", "xpath", "//div[translate(@id,'0123456789','')='pr__MEQPWU_ZMEQPWU_CTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(MEQPWU_ChildForm_ChildFormTab);
IWebElement mTab = MEQPWU_ChildForm_ChildFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Component Detail").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEQPWU";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEQPWU] Performing VerifyExists on ChildForm_ComponentDetail_BreakpointQuantitiesAndCosts_Quantity_1...", Logger.MessageType.INF);
				SeleniumControl MEQPWU_ChildForm_ComponentDetail_BreakpointQuantitiesAndCosts_Quantity_1 = new SeleniumControl( sDriver, "ChildForm_ComponentDetail_BreakpointQuantitiesAndCosts_Quantity_1", "xpath", "//div[translate(@id,'0123456789','')='pr__MEQPWU_ZMEQPWU_CTW_']/ancestor::form[1]/descendant::*[@id='COM_BRK_1_QTY']");
				Function.AssertEqual(true,MEQPWU_ChildForm_ComponentDetail_BreakpointQuantitiesAndCosts_Quantity_1.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEQPWU";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEQPWU] Performing Select on ChildForm_ChildFormTab...", Logger.MessageType.INF);
				SeleniumControl MEQPWU_ChildForm_ChildFormTab = new SeleniumControl( sDriver, "ChildForm_ChildFormTab", "xpath", "//div[translate(@id,'0123456789','')='pr__MEQPWU_ZMEQPWU_CTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(MEQPWU_ChildForm_ChildFormTab);
IWebElement mTab = MEQPWU_ChildForm_ChildFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Assembly Detail").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEQPWU";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEQPWU] Performing VerifyExists on ChildForm_AssemblyDetail_BreakpointQuantitiesAndCosts_Quantity_1...", Logger.MessageType.INF);
				SeleniumControl MEQPWU_ChildForm_AssemblyDetail_BreakpointQuantitiesAndCosts_Quantity_1 = new SeleniumControl( sDriver, "ChildForm_AssemblyDetail_BreakpointQuantitiesAndCosts_Quantity_1", "xpath", "//div[translate(@id,'0123456789','')='pr__MEQPWU_ZMEQPWU_CTW_']/ancestor::form[1]/descendant::*[@id='ASY_BRK1_QTY']");
				Function.AssertEqual(true,MEQPWU_ChildForm_AssemblyDetail_BreakpointQuantitiesAndCosts_Quantity_1.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEQPWU";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEQPWU] Performing Select on ChildForm_ChildFormTab...", Logger.MessageType.INF);
				SeleniumControl MEQPWU_ChildForm_ChildFormTab = new SeleniumControl( sDriver, "ChildForm_ChildFormTab", "xpath", "//div[translate(@id,'0123456789','')='pr__MEQPWU_ZMEQPWU_CTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(MEQPWU_ChildForm_ChildFormTab);
IWebElement mTab = MEQPWU_ChildForm_ChildFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Other Info").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEQPWU";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEQPWU] Performing VerifyExists on ChildForm_OtherInfo_ProposalManager...", Logger.MessageType.INF);
				SeleniumControl MEQPWU_ChildForm_OtherInfo_ProposalManager = new SeleniumControl( sDriver, "ChildForm_OtherInfo_ProposalManager", "xpath", "//div[translate(@id,'0123456789','')='pr__MEQPWU_ZMEQPWU_CTW_']/ancestor::form[1]/descendant::*[@id='EMPL_ID']");
				Function.AssertEqual(true,MEQPWU_ChildForm_OtherInfo_ProposalManager.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEQPWU";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEQPWU] Performing Select on ChildForm_ChildFormTab...", Logger.MessageType.INF);
				SeleniumControl MEQPWU_ChildForm_ChildFormTab = new SeleniumControl( sDriver, "ChildForm_ChildFormTab", "xpath", "//div[translate(@id,'0123456789','')='pr__MEQPWU_ZMEQPWU_CTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(MEQPWU_ChildForm_ChildFormTab);
IWebElement mTab = MEQPWU_ChildForm_ChildFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Notes").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEQPWU";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEQPWU] Performing VerifyExists on ChildForm_Notes_AssemblyNotes_AssemblyNotes...", Logger.MessageType.INF);
				SeleniumControl MEQPWU_ChildForm_Notes_AssemblyNotes_AssemblyNotes = new SeleniumControl( sDriver, "ChildForm_Notes_AssemblyNotes_AssemblyNotes", "xpath", "//div[translate(@id,'0123456789','')='pr__MEQPWU_ZMEQPWU_CTW_']/ancestor::form[1]/descendant::*[@id='ASY_NOTES']");
				Function.AssertEqual(true,MEQPWU_ChildForm_Notes_AssemblyNotes_AssemblyNotes.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
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
				Function.CurrentComponent = "MEQPWU";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEQPWU] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl MEQPWU_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(MEQPWU_MainForm);
IWebElement formBttn = MEQPWU_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

