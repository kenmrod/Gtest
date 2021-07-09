 
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
    public class BMMEICN_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Bills of Material", "xpath","//div[@class='deptItem'][.='Bills of Material']").Click();
new SeleniumControl(sDriver,"Bills of Material", "xpath","//div[@class='navItem'][.='Bills of Material']").Click();
new SeleniumControl(sDriver,"Manage End Item Configurations", "xpath","//div[@class='navItem'][.='Manage End Item Configurations']").Click();


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
				Function.CurrentComponent = "BMMEICN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEICN] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl BMMEICN_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,BMMEICN_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEICN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEICN] Performing VerifyExists on Part...", Logger.MessageType.INF);
				SeleniumControl BMMEICN_Part = new SeleniumControl( sDriver, "Part", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='DFSPARTID']");
				Function.AssertEqual(true,BMMEICN_Part.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEICN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEICN] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl BMMEICN_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(BMMEICN_MainForm);
IWebElement formBttn = BMMEICN_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? BMMEICN_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
BMMEICN_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEICN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEICN] Performing VerifyExist on MainTable...", Logger.MessageType.INF);
				SeleniumControl BMMEICN_MainTable = new SeleniumControl( sDriver, "MainTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BMMEICN_MainTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Configuration");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEICN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEICN] Performing VerifyExists on ConfigurationForm...", Logger.MessageType.INF);
				SeleniumControl BMMEICN_ConfigurationForm = new SeleniumControl( sDriver, "ConfigurationForm", "xpath", "//div[starts-with(@id,'pr__BMMEICN_ENDPARTCONFIG_SIB1_')]/ancestor::form[1]");
				Function.AssertEqual(true,BMMEICN_ConfigurationForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEICN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEICN] Performing VerifyExist on ConfigurationTable...", Logger.MessageType.INF);
				SeleniumControl BMMEICN_ConfigurationTable = new SeleniumControl( sDriver, "ConfigurationTable", "xpath", "//div[starts-with(@id,'pr__BMMEICN_ENDPARTCONFIG_SIB1_')]/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BMMEICN_ConfigurationTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEICN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEICN] Performing ClickButton on ConfigurationForm...", Logger.MessageType.INF);
				SeleniumControl BMMEICN_ConfigurationForm = new SeleniumControl( sDriver, "ConfigurationForm", "xpath", "//div[starts-with(@id,'pr__BMMEICN_ENDPARTCONFIG_SIB1_')]/ancestor::form[1]");
				Function.WaitControlDisplayed(BMMEICN_ConfigurationForm);
IWebElement formBttn = BMMEICN_ConfigurationForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? BMMEICN_ConfigurationForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
BMMEICN_ConfigurationForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEICN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEICN] Performing VerifyExists on Configuration_BOMConfiguration...", Logger.MessageType.INF);
				SeleniumControl BMMEICN_Configuration_BOMConfiguration = new SeleniumControl( sDriver, "Configuration_BOMConfiguration", "xpath", "//div[starts-with(@id,'pr__BMMEICN_ENDPARTCONFIG_SIB1_')]/ancestor::form[1]/descendant::*[@id='BOM_CONFIG_ID']");
				Function.AssertEqual(true,BMMEICN_Configuration_BOMConfiguration.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Project");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEICN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEICN] Performing Click on Configuration_ProjectLink...", Logger.MessageType.INF);
				SeleniumControl BMMEICN_Configuration_ProjectLink = new SeleniumControl( sDriver, "Configuration_ProjectLink", "ID", "lnk_1001623_BMMEICN_ENDPARTCONFIG_SIB1");
				Function.WaitControlDisplayed(BMMEICN_Configuration_ProjectLink);
BMMEICN_Configuration_ProjectLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEICN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEICN] Performing VerifyExists on Configuration_ProjectForm...", Logger.MessageType.INF);
				SeleniumControl BMMEICN_Configuration_ProjectForm = new SeleniumControl( sDriver, "Configuration_ProjectForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMEICN_PROJ_']/ancestor::form[1]");
				Function.AssertEqual(true,BMMEICN_Configuration_ProjectForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEICN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEICN] Performing VerifyExist on Configuration_ProjectTable...", Logger.MessageType.INF);
				SeleniumControl BMMEICN_Configuration_ProjectTable = new SeleniumControl( sDriver, "Configuration_ProjectTable", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMEICN_PROJ_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BMMEICN_Configuration_ProjectTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEICN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEICN] Performing ClickButton on Configuration_ProjectForm...", Logger.MessageType.INF);
				SeleniumControl BMMEICN_Configuration_ProjectForm = new SeleniumControl( sDriver, "Configuration_ProjectForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMEICN_PROJ_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BMMEICN_Configuration_ProjectForm);
IWebElement formBttn = BMMEICN_Configuration_ProjectForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? BMMEICN_Configuration_ProjectForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
BMMEICN_Configuration_ProjectForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEICN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEICN] Performing VerifyExists on Configuration_Project_Project...", Logger.MessageType.INF);
				SeleniumControl BMMEICN_Configuration_Project_Project = new SeleniumControl( sDriver, "Configuration_Project_Project", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMEICN_PROJ_']/ancestor::form[1]/descendant::*[@id='PROJ_ID']");
				Function.AssertEqual(true,BMMEICN_Configuration_Project_Project.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEICN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEICN] Performing Close on Configuration_ProjectForm...", Logger.MessageType.INF);
				SeleniumControl BMMEICN_Configuration_ProjectForm = new SeleniumControl( sDriver, "Configuration_ProjectForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMEICN_PROJ_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BMMEICN_Configuration_ProjectForm);
IWebElement formBttn = BMMEICN_Configuration_ProjectForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Close the application");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEICN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEICN] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl BMMEICN_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(BMMEICN_MainForm);
IWebElement formBttn = BMMEICN_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

