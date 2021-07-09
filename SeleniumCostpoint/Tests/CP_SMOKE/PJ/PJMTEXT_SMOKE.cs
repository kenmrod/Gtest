 
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
    public class PJMTEXT_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Manage Standard Text", "xpath","//div[@class='navItem'][.='Manage Standard Text']").Click();


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
				Function.CurrentComponent = "PJMTEXT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMTEXT] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl PJMTEXT_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,PJMTEXT_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMTEXT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMTEXT] Performing VerifyExists on Project...", Logger.MessageType.INF);
				SeleniumControl PJMTEXT_Project = new SeleniumControl( sDriver, "Project", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PROJ_ID']");
				Function.AssertEqual(true,PJMTEXT_Project.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMTEXT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMTEXT] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl PJMTEXT_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PJMTEXT_MainForm);
IWebElement formBttn = PJMTEXT_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? PJMTEXT_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
PJMTEXT_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMTEXT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMTEXT] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl PJMTEXT_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJMTEXT_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Standard Text Codes");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMTEXT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMTEXT] Performing VerifyExist on StandardTextCodesFormTable...", Logger.MessageType.INF);
				SeleniumControl PJMTEXT_StandardTextCodesFormTable = new SeleniumControl( sDriver, "StandardTextCodesFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PJM_STDTEXT_AVAILSTDTEXT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJMTEXT_StandardTextCodesFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMTEXT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMTEXT] Performing VerifyExist on StandardTextFormTable...", Logger.MessageType.INF);
				SeleniumControl PJMTEXT_StandardTextFormTable = new SeleniumControl( sDriver, "StandardTextFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PJM_STDTEXT_SELECTED_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJMTEXT_StandardTextFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Where Used");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMTEXT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMTEXT] Performing VerifyExists on StandardTextCodes_WhereUsedLink...", Logger.MessageType.INF);
				SeleniumControl PJMTEXT_StandardTextCodes_WhereUsedLink = new SeleniumControl( sDriver, "StandardTextCodes_WhereUsedLink", "ID", "lnk_1007158_PJM_STDTEXT_AVAILSTDTEXT");
				Function.AssertEqual(true,PJMTEXT_StandardTextCodes_WhereUsedLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMTEXT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMTEXT] Performing Click on StandardTextCodes_WhereUsedLink...", Logger.MessageType.INF);
				SeleniumControl PJMTEXT_StandardTextCodes_WhereUsedLink = new SeleniumControl( sDriver, "StandardTextCodes_WhereUsedLink", "ID", "lnk_1007158_PJM_STDTEXT_AVAILSTDTEXT");
				Function.WaitControlDisplayed(PJMTEXT_StandardTextCodes_WhereUsedLink);
PJMTEXT_StandardTextCodes_WhereUsedLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMTEXT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMTEXT] Performing VerifyExists on StandardTextCodes_WhereUsedForm...", Logger.MessageType.INF);
				SeleniumControl PJMTEXT_StandardTextCodes_WhereUsedForm = new SeleniumControl( sDriver, "StandardTextCodes_WhereUsedForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJM_WHEREUSEDPARENT_']/ancestor::form[1]");
				Function.AssertEqual(true,PJMTEXT_StandardTextCodes_WhereUsedForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMTEXT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMTEXT] Performing VerifyExists on StandardTextCodes_WhereUsed_TextCode...", Logger.MessageType.INF);
				SeleniumControl PJMTEXT_StandardTextCodes_WhereUsed_TextCode = new SeleniumControl( sDriver, "StandardTextCodes_WhereUsed_TextCode", "xpath", "//div[translate(@id,'0123456789','')='pr__PJM_WHEREUSEDPARENT_']/ancestor::form[1]/descendant::*[@id='TEXT_CD']");
				Function.AssertEqual(true,PJMTEXT_StandardTextCodes_WhereUsed_TextCode.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMTEXT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMTEXT] Performing VerifyExist on StandardTextCodes_WhereUsed_ChildFormTable...", Logger.MessageType.INF);
				SeleniumControl PJMTEXT_StandardTextCodes_WhereUsed_ChildFormTable = new SeleniumControl( sDriver, "StandardTextCodes_WhereUsed_ChildFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PJM_WHEREUSEDCHILD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJMTEXT_StandardTextCodes_WhereUsed_ChildFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMTEXT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMTEXT] Performing Close on StandardTextCodes_WhereUsedForm...", Logger.MessageType.INF);
				SeleniumControl PJMTEXT_StandardTextCodes_WhereUsedForm = new SeleniumControl( sDriver, "StandardTextCodes_WhereUsedForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJM_WHEREUSEDPARENT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJMTEXT_StandardTextCodes_WhereUsedForm);
IWebElement formBttn = PJMTEXT_StandardTextCodes_WhereUsedForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Closing App");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMTEXT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMTEXT] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl PJMTEXT_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PJMTEXT_MainForm);
IWebElement formBttn = PJMTEXT_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

