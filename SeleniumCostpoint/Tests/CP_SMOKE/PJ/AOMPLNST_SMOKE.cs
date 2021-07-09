 
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
    public class AOMPLNST_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Budgeting and ETC", "xpath","//div[@class='deptItem'][.='Budgeting and ETC']").Click();
new SeleniumControl(sDriver,"Budget Interfaces", "xpath","//div[@class='navItem'][.='Budget Interfaces']").Click();
new SeleniumControl(sDriver,"Configure Interface Settings", "xpath","//div[@class='navItem'][.='Configure Interface Settings']").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SelectMenu]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("MAINFORMTABLE");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "AOMPLNST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMPLNST] Performing VerifyExist on SourceFileDefinitionFormTable...", Logger.MessageType.INF);
				SeleniumControl AOMPLNST_SourceFileDefinitionFormTable = new SeleniumControl( sDriver, "SourceFileDefinitionFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,AOMPLNST_SourceFileDefinitionFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "AOMPLNST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMPLNST] Performing ClickButton on SourceFileDefinitionForm...", Logger.MessageType.INF);
				SeleniumControl AOMPLNST_SourceFileDefinitionForm = new SeleniumControl( sDriver, "SourceFileDefinitionForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(AOMPLNST_SourceFileDefinitionForm);
IWebElement formBttn = AOMPLNST_SourceFileDefinitionForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? AOMPLNST_SourceFileDefinitionForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
AOMPLNST_SourceFileDefinitionForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "AOMPLNST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMPLNST] Performing VerifyExists on SourceFileDefinition_SourceName...", Logger.MessageType.INF);
				SeleniumControl AOMPLNST_SourceFileDefinition_SourceName = new SeleniumControl( sDriver, "SourceFileDefinition_SourceName", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='SOURCE_ID']");
				Function.AssertEqual(true,AOMPLNST_SourceFileDefinition_SourceName.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("MAINFORM TABLE LINK");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "AOMPLNST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMPLNST] Performing VerifyExists on SourceFileDefinition_IncludeExcludeDefinitionLink...", Logger.MessageType.INF);
				SeleniumControl AOMPLNST_SourceFileDefinition_IncludeExcludeDefinitionLink = new SeleniumControl( sDriver, "SourceFileDefinition_IncludeExcludeDefinitionLink", "ID", "lnk_15216_AOMPLNST_SFD");
				Function.AssertEqual(true,AOMPLNST_SourceFileDefinition_IncludeExcludeDefinitionLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "AOMPLNST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMPLNST] Performing Click on SourceFileDefinition_IncludeExcludeDefinitionLink...", Logger.MessageType.INF);
				SeleniumControl AOMPLNST_SourceFileDefinition_IncludeExcludeDefinitionLink = new SeleniumControl( sDriver, "SourceFileDefinition_IncludeExcludeDefinitionLink", "ID", "lnk_15216_AOMPLNST_SFD");
				Function.WaitControlDisplayed(AOMPLNST_SourceFileDefinition_IncludeExcludeDefinitionLink);
AOMPLNST_SourceFileDefinition_IncludeExcludeDefinitionLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "AOMPLNST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMPLNST] Performing VerifyExist on IncludeExcludeDefinitionFormTable...", Logger.MessageType.INF);
				SeleniumControl AOMPLNST_IncludeExcludeDefinitionFormTable = new SeleniumControl( sDriver, "IncludeExcludeDefinitionFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__AOMPLNST_IEPD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,AOMPLNST_IncludeExcludeDefinitionFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("MAINFORM TABLE LINK");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "AOMPLNST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMPLNST] Performing VerifyExists on SourceFileDefinition_RowDefinitionLink...", Logger.MessageType.INF);
				SeleniumControl AOMPLNST_SourceFileDefinition_RowDefinitionLink = new SeleniumControl( sDriver, "SourceFileDefinition_RowDefinitionLink", "ID", "lnk_15217_AOMPLNST_SFD");
				Function.AssertEqual(true,AOMPLNST_SourceFileDefinition_RowDefinitionLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "AOMPLNST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMPLNST] Performing Click on SourceFileDefinition_RowDefinitionLink...", Logger.MessageType.INF);
				SeleniumControl AOMPLNST_SourceFileDefinition_RowDefinitionLink = new SeleniumControl( sDriver, "SourceFileDefinition_RowDefinitionLink", "ID", "lnk_15217_AOMPLNST_SFD");
				Function.WaitControlDisplayed(AOMPLNST_SourceFileDefinition_RowDefinitionLink);
AOMPLNST_SourceFileDefinition_RowDefinitionLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "AOMPLNST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMPLNST] Performing VerifyExist on RowDefinitionFormTable...", Logger.MessageType.INF);
				SeleniumControl AOMPLNST_RowDefinitionFormTable = new SeleniumControl( sDriver, "RowDefinitionFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__AOMPLNST_SFRD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,AOMPLNST_RowDefinitionFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "CP7Main";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[CP7Main] Performing SelectMenu on MainMenu...", Logger.MessageType.INF);
				SeleniumControl CP7Main_MainMenu = new SeleniumControl( sDriver, "MainMenu", "ID", "wMnuBar");
				new SeleniumControl(sDriver,"File", "xpath","//span[@class='wMnuHead'][.='FILE']").Click();
new SeleniumControl(sDriver,"Close Application", "xpath","//*[@class='wMnuPickLbl'][.='Close Application']").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SelectMenu]" , ex.Message));
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

