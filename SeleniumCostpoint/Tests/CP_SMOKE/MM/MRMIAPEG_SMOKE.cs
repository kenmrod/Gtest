 
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
    public class MRMIAPEG_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Production Control", "xpath","//div[@class='deptItem'][.='Production Control']").Click();
new SeleniumControl(sDriver,"Production Control Controls", "xpath","//div[@class='navItem'][.='Production Control Controls']").Click();
new SeleniumControl(sDriver,"Manage Inventory Abbreviation Peggings", "xpath","//div[@class='navItem'][.='Manage Inventory Abbreviation Peggings']").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SelectMenu]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("MAINFORM");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMIAPEG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMIAPEG] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl MRMIAPEG_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,MRMIAPEG_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMIAPEG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMIAPEG] Performing VerifyExists on Part...", Logger.MessageType.INF);
				SeleniumControl MRMIAPEG_Part = new SeleniumControl( sDriver, "Part", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='ASY_PART_ID']");
				Function.AssertEqual(true,MRMIAPEG_Part.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMIAPEG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMIAPEG] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl MRMIAPEG_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(MRMIAPEG_MainForm);
IWebElement formBttn = MRMIAPEG_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? MRMIAPEG_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
MRMIAPEG_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMIAPEG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMIAPEG] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl MRMIAPEG_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,MRMIAPEG_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMIAPEG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMIAPEG] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl MRMIAPEG_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(MRMIAPEG_MainForm);
IWebElement formBttn = MRMIAPEG_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? MRMIAPEG_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
MRMIAPEG_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("SELECT END ITEM CONFIGURATION");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMIAPEG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMIAPEG] Performing VerifyExists on SelectEndItemConfigurationLink...", Logger.MessageType.INF);
				SeleniumControl MRMIAPEG_SelectEndItemConfigurationLink = new SeleniumControl( sDriver, "SelectEndItemConfigurationLink", "ID", "lnk_4411_MMMIAPEG_INVTABBRVPEGGING");
				Function.AssertEqual(true,MRMIAPEG_SelectEndItemConfigurationLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMIAPEG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMIAPEG] Performing Click on SelectEndItemConfigurationLink...", Logger.MessageType.INF);
				SeleniumControl MRMIAPEG_SelectEndItemConfigurationLink = new SeleniumControl( sDriver, "SelectEndItemConfigurationLink", "ID", "lnk_4411_MMMIAPEG_INVTABBRVPEGGING");
				Function.WaitControlDisplayed(MRMIAPEG_SelectEndItemConfigurationLink);
MRMIAPEG_SelectEndItemConfigurationLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMIAPEG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMIAPEG] Performing VerifyExists on SelectEndItemConfigurationForm...", Logger.MessageType.INF);
				SeleniumControl MRMIAPEG_SelectEndItemConfigurationForm = new SeleniumControl( sDriver, "SelectEndItemConfigurationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MM_ENDPARTCONFIG_LOAD_']/ancestor::form[1]");
				Function.AssertEqual(true,MRMIAPEG_SelectEndItemConfigurationForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMIAPEG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMIAPEG] Performing VerifyExist on SelectEndItemConfigurationTable...", Logger.MessageType.INF);
				SeleniumControl MRMIAPEG_SelectEndItemConfigurationTable = new SeleniumControl( sDriver, "SelectEndItemConfigurationTable", "xpath", "//div[translate(@id,'0123456789','')='pr__MM_ENDPARTCONFIG_LOAD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,MRMIAPEG_SelectEndItemConfigurationTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMIAPEG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMIAPEG] Performing Close on SelectEndItemConfigurationForm...", Logger.MessageType.INF);
				SeleniumControl MRMIAPEG_SelectEndItemConfigurationForm = new SeleniumControl( sDriver, "SelectEndItemConfigurationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MM_ENDPARTCONFIG_LOAD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MRMIAPEG_SelectEndItemConfigurationForm);
IWebElement formBttn = MRMIAPEG_SelectEndItemConfigurationForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("COMPONENT LINES");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMIAPEG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMIAPEG] Performing VerifyExist on ComponentLinesFormTable...", Logger.MessageType.INF);
				SeleniumControl MRMIAPEG_ComponentLinesFormTable = new SeleniumControl( sDriver, "ComponentLinesFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMIAPEG_PEGGING_DETAIL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,MRMIAPEG_ComponentLinesFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMIAPEG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMIAPEG] Performing ClickButton on ComponentLinesForm...", Logger.MessageType.INF);
				SeleniumControl MRMIAPEG_ComponentLinesForm = new SeleniumControl( sDriver, "ComponentLinesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMIAPEG_PEGGING_DETAIL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MRMIAPEG_ComponentLinesForm);
IWebElement formBttn = MRMIAPEG_ComponentLinesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? MRMIAPEG_ComponentLinesForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
MRMIAPEG_ComponentLinesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMIAPEG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMIAPEG] Performing VerifyExists on ComponentLinesForm...", Logger.MessageType.INF);
				SeleniumControl MRMIAPEG_ComponentLinesForm = new SeleniumControl( sDriver, "ComponentLinesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMIAPEG_PEGGING_DETAIL_']/ancestor::form[1]");
				Function.AssertEqual(true,MRMIAPEG_ComponentLinesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMIAPEG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMIAPEG] Performing VerifyExists on ComponentLines_Part...", Logger.MessageType.INF);
				SeleniumControl MRMIAPEG_ComponentLines_Part = new SeleniumControl( sDriver, "ComponentLines_Part", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMIAPEG_PEGGING_DETAIL_']/ancestor::form[1]/descendant::*[@id='COMP_PART_ID']");
				Function.AssertEqual(true,MRMIAPEG_ComponentLines_Part.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("CLOSE APPLICATION");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMIAPEG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMIAPEG] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl MRMIAPEG_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(MRMIAPEG_MainForm);
IWebElement formBttn = MRMIAPEG_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

