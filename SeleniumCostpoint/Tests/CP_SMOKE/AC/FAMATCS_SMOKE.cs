 
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
    public class FAMATCS_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Accounting", "xpath","//div[@class='busItem'][.='Accounting']").Click();
new SeleniumControl(sDriver,"Fixed Assets", "xpath","//div[@class='deptItem'][.='Fixed Assets']").Click();
new SeleniumControl(sDriver,"Fixed Assets Utilities", "xpath","//div[@class='navItem'][.='Fixed Assets Utilities']").Click();
new SeleniumControl(sDriver,"Configure Asset/Template Change Settings", "xpath","//div[@class='navItem'][.='Configure Asset/Template Change Settings']").Click();


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
				Function.CurrentComponent = "FAMATCS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAMATCS] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl FAMATCS_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,FAMATCS_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAMATCS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAMATCS] Performing VerifyExists on WriteChangeDetailsToAuditLogFor_AssetMasterRecords...", Logger.MessageType.INF);
				SeleniumControl FAMATCS_WriteChangeDetailsToAuditLogFor_AssetMasterRecords = new SeleniumControl( sDriver, "WriteChangeDetailsToAuditLogFor_AssetMasterRecords", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='ASSET_AUDIT_LOG_FL']");
				Function.AssertEqual(true,FAMATCS_WriteChangeDetailsToAuditLogFor_AssetMasterRecords.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Asset/Templaye Field/Column Names");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAMATCS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAMATCS] Performing Click on AssetTemplateFieldColumnNamesLink...", Logger.MessageType.INF);
				SeleniumControl FAMATCS_AssetTemplateFieldColumnNamesLink = new SeleniumControl( sDriver, "AssetTemplateFieldColumnNamesLink", "ID", "lnk_1002100_FAMATCS_SFAAUDITSETTING");
				Function.WaitControlDisplayed(FAMATCS_AssetTemplateFieldColumnNamesLink);
FAMATCS_AssetTemplateFieldColumnNamesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAMATCS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAMATCS] Performing VerifyExist on AssetTemplateFieldColumnNamesFormTable...", Logger.MessageType.INF);
				SeleniumControl FAMATCS_AssetTemplateFieldColumnNamesFormTable = new SeleniumControl( sDriver, "AssetTemplateFieldColumnNamesFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__FAMATCS_SFADBCOLDEF_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,FAMATCS_AssetTemplateFieldColumnNamesFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAMATCS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAMATCS] Performing ClickButton on AssetTemplateFieldColumnNamesForm...", Logger.MessageType.INF);
				SeleniumControl FAMATCS_AssetTemplateFieldColumnNamesForm = new SeleniumControl( sDriver, "AssetTemplateFieldColumnNamesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__FAMATCS_SFADBCOLDEF_']/ancestor::form[1]");
				Function.WaitControlDisplayed(FAMATCS_AssetTemplateFieldColumnNamesForm);
IWebElement formBttn = FAMATCS_AssetTemplateFieldColumnNamesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? FAMATCS_AssetTemplateFieldColumnNamesForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
FAMATCS_AssetTemplateFieldColumnNamesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAMATCS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAMATCS] Performing VerifyExists on AssetTemplateFieldColumnNames_EnglishFieldColumnName...", Logger.MessageType.INF);
				SeleniumControl FAMATCS_AssetTemplateFieldColumnNames_EnglishFieldColumnName = new SeleniumControl( sDriver, "AssetTemplateFieldColumnNames_EnglishFieldColumnName", "xpath", "//div[translate(@id,'0123456789','')='pr__FAMATCS_SFADBCOLDEF_']/ancestor::form[1]/descendant::*[@id='ENGL_COL_NAME']");
				Function.AssertEqual(true,FAMATCS_AssetTemplateFieldColumnNames_EnglishFieldColumnName.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAMATCS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAMATCS] Performing Close on AssetTemplateFieldColumnNamesForm...", Logger.MessageType.INF);
				SeleniumControl FAMATCS_AssetTemplateFieldColumnNamesForm = new SeleniumControl( sDriver, "AssetTemplateFieldColumnNamesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__FAMATCS_SFADBCOLDEF_']/ancestor::form[1]");
				Function.WaitControlDisplayed(FAMATCS_AssetTemplateFieldColumnNamesForm);
IWebElement formBttn = FAMATCS_AssetTemplateFieldColumnNamesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Close Form");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAMATCS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAMATCS] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl FAMATCS_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(FAMATCS_MainForm);
IWebElement formBttn = FAMATCS_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

