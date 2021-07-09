 
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
    public class FAMSOTBK_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Accounting", "xpath","//div[@class='busItem'][.='Accounting']").Click();
new SeleniumControl(sDriver,"Fixed Assets", "xpath","//div[@class='deptItem'][.='Fixed Assets']").Click();
new SeleniumControl(sDriver,"Asset Master Records", "xpath","//div[@class='navItem'][.='Asset Master Records']").Click();
new SeleniumControl(sDriver,"Manage Asset Other Books Information", "xpath","//div[@class='navItem'][.='Manage Asset Other Books Information']").Click();


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
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[Query] Performing Click on Find...", Logger.MessageType.INF);
				SeleniumControl Query_Find = new SeleniumControl( sDriver, "Find", "ID", "submitQ");
				Function.WaitControlDisplayed(Query_Find);
if (Query_Find.mElement.GetAttribute("class") == "popupBtn" && sDriver.BrowserType == "ie")
Query_Find.Click(5,5);
else Query_Find.Click(4.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAMSOTBK";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAMSOTBK] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl FAMSOTBK_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,FAMSOTBK_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAMSOTBK";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAMSOTBK] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl FAMSOTBK_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,FAMSOTBK_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAMSOTBK";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAMSOTBK] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl FAMSOTBK_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(FAMSOTBK_MainForm);
IWebElement formBttn = FAMSOTBK_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? FAMSOTBK_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
FAMSOTBK_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAMSOTBK";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAMSOTBK] Performing VerifyExists on AssetNo...", Logger.MessageType.INF);
				SeleniumControl FAMSOTBK_AssetNo = new SeleniumControl( sDriver, "AssetNo", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='ASSET_ID']");
				Function.AssertEqual(true,FAMSOTBK_AssetNo.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAMSOTBK";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAMSOTBK] Performing VerifyExists on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl FAMSOTBK_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.AssertEqual(true,FAMSOTBK_MainFormTab.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAMSOTBK";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAMSOTBK] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl FAMSOTBK_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(FAMSOTBK_MainFormTab);
IWebElement mTab = FAMSOTBK_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Tax").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAMSOTBK";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAMSOTBK] Performing VerifyExists on Tax_Salvage_SalvagePercent...", Logger.MessageType.INF);
				SeleniumControl FAMSOTBK_Tax_Salvage_SalvagePercent = new SeleniumControl( sDriver, "Tax_Salvage_SalvagePercent", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='B2_SLVGE_RT']");
				Function.AssertEqual(true,FAMSOTBK_Tax_Salvage_SalvagePercent.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAMSOTBK";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAMSOTBK] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl FAMSOTBK_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(FAMSOTBK_MainFormTab);
IWebElement mTab = FAMSOTBK_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Government").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAMSOTBK";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAMSOTBK] Performing VerifyExists on Government_Salvage_SalvagePercent...", Logger.MessageType.INF);
				SeleniumControl FAMSOTBK_Government_Salvage_SalvagePercent = new SeleniumControl( sDriver, "Government_Salvage_SalvagePercent", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='B3_SLVGE_RT']");
				Function.AssertEqual(true,FAMSOTBK_Government_Salvage_SalvagePercent.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAMSOTBK";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAMSOTBK] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl FAMSOTBK_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(FAMSOTBK_MainFormTab);
IWebElement mTab = FAMSOTBK_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "State").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAMSOTBK";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAMSOTBK] Performing VerifyExists on State_Salvage_SalvagePercent...", Logger.MessageType.INF);
				SeleniumControl FAMSOTBK_State_Salvage_SalvagePercent = new SeleniumControl( sDriver, "State_Salvage_SalvagePercent", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='B4_SLVGE_RT']");
				Function.AssertEqual(true,FAMSOTBK_State_Salvage_SalvagePercent.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAMSOTBK";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAMSOTBK] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl FAMSOTBK_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(FAMSOTBK_MainFormTab);
IWebElement mTab = FAMSOTBK_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "County").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAMSOTBK";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAMSOTBK] Performing VerifyExists on County_Salvage_SalvagePercent...", Logger.MessageType.INF);
				SeleniumControl FAMSOTBK_County_Salvage_SalvagePercent = new SeleniumControl( sDriver, "County_Salvage_SalvagePercent", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='B5_SLVGE_RT']");
				Function.AssertEqual(true,FAMSOTBK_County_Salvage_SalvagePercent.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAMSOTBK";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAMSOTBK] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl FAMSOTBK_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(FAMSOTBK_MainFormTab);
IWebElement mTab = FAMSOTBK_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "City").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAMSOTBK";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAMSOTBK] Performing VerifyExists on City_Salvage_SalvagePercent...", Logger.MessageType.INF);
				SeleniumControl FAMSOTBK_City_Salvage_SalvagePercent = new SeleniumControl( sDriver, "City_Salvage_SalvagePercent", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='B6_SLVGE_RT']");
				Function.AssertEqual(true,FAMSOTBK_City_Salvage_SalvagePercent.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAMSOTBK";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAMSOTBK] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl FAMSOTBK_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(FAMSOTBK_MainFormTab);
IWebElement mTab = FAMSOTBK_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Md State").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAMSOTBK";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAMSOTBK] Performing VerifyExists on MdState_Salvage_SalvagePercent...", Logger.MessageType.INF);
				SeleniumControl FAMSOTBK_MdState_Salvage_SalvagePercent = new SeleniumControl( sDriver, "MdState_Salvage_SalvagePercent", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='B7_SLVGE_RT']");
				Function.AssertEqual(true,FAMSOTBK_MdState_Salvage_SalvagePercent.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAMSOTBK";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAMSOTBK] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl FAMSOTBK_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(FAMSOTBK_MainFormTab);
IWebElement mTab = FAMSOTBK_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Internal").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAMSOTBK";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAMSOTBK] Performing VerifyExists on Internal_Salvage_SalvagePercent...", Logger.MessageType.INF);
				SeleniumControl FAMSOTBK_Internal_Salvage_SalvagePercent = new SeleniumControl( sDriver, "Internal_Salvage_SalvagePercent", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='B8_SLVGE_RT']");
				Function.AssertEqual(true,FAMSOTBK_Internal_Salvage_SalvagePercent.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAMSOTBK";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAMSOTBK] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl FAMSOTBK_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(FAMSOTBK_MainFormTab);
IWebElement mTab = FAMSOTBK_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue().Contains("Cali")).FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAMSOTBK";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAMSOTBK] Performing VerifyExists on California_Salvage_SalvagePercent...", Logger.MessageType.INF);
				SeleniumControl FAMSOTBK_California_Salvage_SalvagePercent = new SeleniumControl( sDriver, "California_Salvage_SalvagePercent", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='B9_SLVGE_RT']");
				Function.AssertEqual(true,FAMSOTBK_California_Salvage_SalvagePercent.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAMSOTBK";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAMSOTBK] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl FAMSOTBK_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(FAMSOTBK_MainFormTab);
IWebElement mTab = FAMSOTBK_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "New York").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAMSOTBK";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAMSOTBK] Performing VerifyExists on NewYork_Salvage_SalvagePercent...", Logger.MessageType.INF);
				SeleniumControl FAMSOTBK_NewYork_Salvage_SalvagePercent = new SeleniumControl( sDriver, "NewYork_Salvage_SalvagePercent", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='B10_SLVGE_RT']");
				Function.AssertEqual(true,FAMSOTBK_NewYork_Salvage_SalvagePercent.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAMSOTBK";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAMSOTBK] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl FAMSOTBK_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(FAMSOTBK_MainForm);
IWebElement formBttn = FAMSOTBK_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

