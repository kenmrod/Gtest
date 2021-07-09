 
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
    public class AOMPLMAP_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Configure Project Planner Mapping Definitions", "xpath","//div[@class='navItem'][.='Configure Project Planner Mapping Definitions']").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SelectMenu]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("MAIN TABLE");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "AOMPLMAP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMPLMAP] Performing VerifyExist on RowDefinitionFormTable...", Logger.MessageType.INF);
				SeleniumControl AOMPLMAP_RowDefinitionFormTable = new SeleniumControl( sDriver, "RowDefinitionFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,AOMPLMAP_RowDefinitionFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "AOMPLMAP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMPLMAP] Performing ClickButton on RowDefinitionForm...", Logger.MessageType.INF);
				SeleniumControl AOMPLMAP_RowDefinitionForm = new SeleniumControl( sDriver, "RowDefinitionForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(AOMPLMAP_RowDefinitionForm);
IWebElement formBttn = AOMPLMAP_RowDefinitionForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? AOMPLMAP_RowDefinitionForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
AOMPLMAP_RowDefinitionForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "AOMPLMAP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMPLMAP] Performing VerifyExists on RowDefinitionForm...", Logger.MessageType.INF);
				SeleniumControl AOMPLMAP_RowDefinitionForm = new SeleniumControl( sDriver, "RowDefinitionForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,AOMPLMAP_RowDefinitionForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "AOMPLMAP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMPLMAP] Performing VerifyExists on RowDefinition_SourceName...", Logger.MessageType.INF);
				SeleniumControl AOMPLMAP_RowDefinition_SourceName = new SeleniumControl( sDriver, "RowDefinition_SourceName", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='SOURCE_ID']");
				Function.AssertEqual(true,AOMPLMAP_RowDefinition_SourceName.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("CHILDFORM TABLE");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "AOMPLMAP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMPLMAP] Performing VerifyExist on ColumnDefinitionFormTable...", Logger.MessageType.INF);
				SeleniumControl AOMPLMAP_ColumnDefinitionFormTable = new SeleniumControl( sDriver, "ColumnDefinitionFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__AOMPLMAP_SFCD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,AOMPLMAP_ColumnDefinitionFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "AOMPLMAP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMPLMAP] Performing VerifyExist on MappingDefinitionFormTable...", Logger.MessageType.INF);
				SeleniumControl AOMPLMAP_MappingDefinitionFormTable = new SeleniumControl( sDriver, "MappingDefinitionFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__AOMPLMAP_MAPDEF_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,AOMPLMAP_MappingDefinitionFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
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
				Function.CurrentComponent = "AOMPLMAP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMPLMAP] Performing Close on RowDefinitionForm...", Logger.MessageType.INF);
				SeleniumControl AOMPLMAP_RowDefinitionForm = new SeleniumControl( sDriver, "RowDefinitionForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(AOMPLMAP_RowDefinitionForm);
IWebElement formBttn = AOMPLMAP_RowDefinitionForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

