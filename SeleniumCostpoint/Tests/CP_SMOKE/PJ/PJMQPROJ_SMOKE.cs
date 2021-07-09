 
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
    public class PJMQPROJ_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Project Master", "xpath","//div[@class='navItem'][.='Project Master']").Click();
new SeleniumControl(sDriver,"Manage Project Master Data from Templates", "xpath","//div[@class='navItem'][.='Manage Project Master Data from Templates']").Click();


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
				Function.CurrentComponent = "PJMQPROJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMQPROJ] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl PJMQPROJ_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,PJMQPROJ_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMQPROJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMQPROJ] Performing VerifyExists on TemplateID...", Logger.MessageType.INF);
				SeleniumControl PJMQPROJ_TemplateID = new SeleniumControl( sDriver, "TemplateID", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='TEMPLATE_ID']");
				Function.AssertEqual(true,PJMQPROJ_TemplateID.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMQPROJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMQPROJ] Performing ClickButtonIfExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl PJMQPROJ_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PJMQPROJ_MainForm);
IWebElement formBttn = PJMQPROJ_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? PJMQPROJ_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
PJMQPROJ_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault();
if (formBttn!=null && formBttn.Displayed)
{ new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click();
this.ScriptLogger.WriteLine("Button [Table] found and clicked.", Logger.MessageType.INF);
}


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButtonIfExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMQPROJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMQPROJ] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl PJMQPROJ_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJMQPROJ_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMQPROJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMQPROJ] Performing ClickButtonIfExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl PJMQPROJ_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PJMQPROJ_MainForm);
IWebElement formBttn = PJMQPROJ_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PJMQPROJ_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PJMQPROJ_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault();
if (formBttn!=null && formBttn.Displayed)
{ new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click();
this.ScriptLogger.WriteLine("Button [Form] found and clicked.", Logger.MessageType.INF);
}


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButtonIfExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMQPROJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMQPROJ] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl PJMQPROJ_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PJMQPROJ_MainFormTab);
IWebElement mTab = PJMQPROJ_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Basic Info").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMQPROJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMQPROJ] Performing VerifyExists on BasicInfo_ProjectManager...", Logger.MessageType.INF);
				SeleniumControl PJMQPROJ_BasicInfo_ProjectManager = new SeleniumControl( sDriver, "BasicInfo_ProjectManager", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='EMPL_ID']");
				Function.AssertEqual(true,PJMQPROJ_BasicInfo_ProjectManager.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMQPROJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMQPROJ] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl PJMQPROJ_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PJMQPROJ_MainFormTab);
IWebElement mTab = PJMQPROJ_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Revenue Info").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMQPROJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMQPROJ] Performing VerifyExists on RevenueInfo_RevenueFormula...", Logger.MessageType.INF);
				SeleniumControl PJMQPROJ_RevenueInfo_RevenueFormula = new SeleniumControl( sDriver, "RevenueInfo_RevenueFormula", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='S_REV_FORMULA_CD']");
				Function.AssertEqual(true,PJMQPROJ_RevenueInfo_RevenueFormula.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMQPROJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMQPROJ] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl PJMQPROJ_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PJMQPROJ_MainFormTab);
IWebElement mTab = PJMQPROJ_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Billing Info").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMQPROJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMQPROJ] Performing VerifyExists on BillingInfo_GenericBillingFormat...", Logger.MessageType.INF);
				SeleniumControl PJMQPROJ_BillingInfo_GenericBillingFormat = new SeleniumControl( sDriver, "BillingInfo_GenericBillingFormat", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='BILL_FRMT_CD']");
				Function.AssertEqual(true,PJMQPROJ_BillingInfo_GenericBillingFormat.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMQPROJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMQPROJ] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl PJMQPROJ_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PJMQPROJ_MainFormTab);
IWebElement mTab = PJMQPROJ_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Modifications").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMQPROJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMQPROJ] Performing VerifyExists on Modifications_ModificationID...", Logger.MessageType.INF);
				SeleniumControl PJMQPROJ_Modifications_ModificationID = new SeleniumControl( sDriver, "Modifications_ModificationID", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PROJ_MOD_ID']");
				Function.AssertEqual(true,PJMQPROJ_Modifications_ModificationID.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMQPROJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMQPROJ] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl PJMQPROJ_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PJMQPROJ_MainFormTab);
IWebElement mTab = PJMQPROJ_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Notes").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMQPROJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMQPROJ] Performing VerifyExists on Notes_Notes...", Logger.MessageType.INF);
				SeleniumControl PJMQPROJ_Notes_Notes = new SeleniumControl( sDriver, "Notes_Notes", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='NOTES']");
				Function.AssertEqual(true,PJMQPROJ_Notes_Notes.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMQPROJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMQPROJ] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl PJMQPROJ_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PJMQPROJ_MainForm);
IWebElement formBttn = PJMQPROJ_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

