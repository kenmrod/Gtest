 
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
    public class HAMCDATA_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Affirmative Action", "xpath","//div[@class='deptItem'][.='Affirmative Action']").Click();
new SeleniumControl(sDriver,"Affirmative Action Plan Information", "xpath","//div[@class='navItem'][.='Affirmative Action Plan Information']").Click();
new SeleniumControl(sDriver,"Manage Affirmative Action Census Data", "xpath","//div[@class='navItem'][.='Manage Affirmative Action Census Data']").Click();


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
				Function.CurrentComponent = "HAMCDATA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HAMCDATA] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl HAMCDATA_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,HAMCDATA_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HAMCDATA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HAMCDATA] Performing VerifyExists on CensusCode...", Logger.MessageType.INF);
				SeleniumControl HAMCDATA_CensusCode = new SeleniumControl( sDriver, "CensusCode", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='CENSUS_CO_ID']");
				Function.AssertEqual(true,HAMCDATA_CensusCode.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HAMCDATA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HAMCDATA] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl HAMCDATA_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(HAMCDATA_MainForm);
IWebElement formBttn = HAMCDATA_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? HAMCDATA_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
HAMCDATA_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HAMCDATA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HAMCDATA] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl HAMCDATA_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,HAMCDATA_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HAMCDATA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HAMCDATA] Performing VerifyExists on CensusDataDetailsLink...", Logger.MessageType.INF);
				SeleniumControl HAMCDATA_CensusDataDetailsLink = new SeleniumControl( sDriver, "CensusDataDetailsLink", "ID", "lnk_1000854_HAMCDATA_HAFFCENSUSHDR_HDR");
				Function.AssertEqual(true,HAMCDATA_CensusDataDetailsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HAMCDATA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HAMCDATA] Performing Click on CensusDataDetailsLink...", Logger.MessageType.INF);
				SeleniumControl HAMCDATA_CensusDataDetailsLink = new SeleniumControl( sDriver, "CensusDataDetailsLink", "ID", "lnk_1000854_HAMCDATA_HAFFCENSUSHDR_HDR");
				Function.WaitControlDisplayed(HAMCDATA_CensusDataDetailsLink);
HAMCDATA_CensusDataDetailsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HAMCDATA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HAMCDATA] Performing VerifyExist on CensusDataDetailsFormTable...", Logger.MessageType.INF);
				SeleniumControl HAMCDATA_CensusDataDetailsFormTable = new SeleniumControl( sDriver, "CensusDataDetailsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__HAMCDATA_HAFFCENSUSL_DET_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,HAMCDATA_CensusDataDetailsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HAMCDATA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HAMCDATA] Performing ClickButton on CensusDataDetailsForm...", Logger.MessageType.INF);
				SeleniumControl HAMCDATA_CensusDataDetailsForm = new SeleniumControl( sDriver, "CensusDataDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__HAMCDATA_HAFFCENSUSL_DET_']/ancestor::form[1]");
				Function.WaitControlDisplayed(HAMCDATA_CensusDataDetailsForm);
IWebElement formBttn = HAMCDATA_CensusDataDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? HAMCDATA_CensusDataDetailsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
HAMCDATA_CensusDataDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HAMCDATA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HAMCDATA] Performing VerifyExists on CensusDataDetailsForm...", Logger.MessageType.INF);
				SeleniumControl HAMCDATA_CensusDataDetailsForm = new SeleniumControl( sDriver, "CensusDataDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__HAMCDATA_HAFFCENSUSL_DET_']/ancestor::form[1]");
				Function.AssertEqual(true,HAMCDATA_CensusDataDetailsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HAMCDATA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HAMCDATA] Performing Select on CensusDataDetailsTab...", Logger.MessageType.INF);
				SeleniumControl HAMCDATA_CensusDataDetailsTab = new SeleniumControl( sDriver, "CensusDataDetailsTab", "xpath", "//div[translate(@id,'0123456789','')='pr__HAMCDATA_HAFFCENSUSL_DET_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(HAMCDATA_CensusDataDetailsTab);
IWebElement mTab = HAMCDATA_CensusDataDetailsTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Census Job Title").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HAMCDATA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HAMCDATA] Performing VerifyExists on CensusDataDetails_CensusJobTitle_CensusDetails_CensusJobTitle...", Logger.MessageType.INF);
				SeleniumControl HAMCDATA_CensusDataDetails_CensusJobTitle_CensusDetails_CensusJobTitle = new SeleniumControl( sDriver, "CensusDataDetails_CensusJobTitle_CensusDetails_CensusJobTitle", "xpath", "//div[translate(@id,'0123456789','')='pr__HAMCDATA_HAFFCENSUSL_DET_']/ancestor::form[1]/descendant::*[@id='CENSUS_JOB_CD']");
				Function.AssertEqual(true,HAMCDATA_CensusDataDetails_CensusJobTitle_CensusDetails_CensusJobTitle.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HAMCDATA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HAMCDATA] Performing Select on CensusDataDetailsTab...", Logger.MessageType.INF);
				SeleniumControl HAMCDATA_CensusDataDetailsTab = new SeleniumControl( sDriver, "CensusDataDetailsTab", "xpath", "//div[translate(@id,'0123456789','')='pr__HAMCDATA_HAFFCENSUSL_DET_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(HAMCDATA_CensusDataDetailsTab);
IWebElement mTab = HAMCDATA_CensusDataDetailsTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Census Job Percentage").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HAMCDATA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HAMCDATA] Performing VerifyExists on CensusDataDetails_CensusJobPercentage_Percentage_Female...", Logger.MessageType.INF);
				SeleniumControl HAMCDATA_CensusDataDetails_CensusJobPercentage_Percentage_Female = new SeleniumControl( sDriver, "CensusDataDetails_CensusJobPercentage_Percentage_Female", "xpath", "//div[translate(@id,'0123456789','')='pr__HAMCDATA_HAFFCENSUSL_DET_']/ancestor::form[1]/descendant::*[@id='FEMALE_PCT']");
				Function.AssertEqual(true,HAMCDATA_CensusDataDetails_CensusJobPercentage_Percentage_Female.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HAMCDATA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HAMCDATA] Performing Close on CensusDataDetailsForm...", Logger.MessageType.INF);
				SeleniumControl HAMCDATA_CensusDataDetailsForm = new SeleniumControl( sDriver, "CensusDataDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__HAMCDATA_HAFFCENSUSL_DET_']/ancestor::form[1]");
				Function.WaitControlDisplayed(HAMCDATA_CensusDataDetailsForm);
IWebElement formBttn = HAMCDATA_CensusDataDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
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
				Function.CurrentComponent = "HAMCDATA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HAMCDATA] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl HAMCDATA_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(HAMCDATA_MainForm);
IWebElement formBttn = HAMCDATA_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

