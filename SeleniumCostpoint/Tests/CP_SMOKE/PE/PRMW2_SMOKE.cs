 
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
    public class PRMW2_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Payroll", "xpath","//div[@class='deptItem'][.='Payroll']").Click();
new SeleniumControl(sDriver,"Year-End Processing", "xpath","//div[@class='navItem'][.='Year-End Processing']").Click();
new SeleniumControl(sDriver,"Manage W-2s", "xpath","//div[@class='navItem'][.='Manage W-2s']").Click();


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
				Function.CurrentComponent = "PRMW2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMW2] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl PRMW2_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,PRMW2_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMW2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMW2] Performing VerifyExists on PayrollYear...", Logger.MessageType.INF);
				SeleniumControl PRMW2_PayrollYear = new SeleniumControl( sDriver, "PayrollYear", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PR_YR_NO']");
				Function.AssertEqual(true,PRMW2_PayrollYear.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMW2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMW2] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl PRMW2_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PRMW2_MainForm);
IWebElement formBttn = PRMW2_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? PRMW2_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
PRMW2_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMW2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMW2] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl PRMW2_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PRMW2_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
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
				Function.CurrentComponent = "PRMW2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMW2] Performing VerifyExists on Box12Link...", Logger.MessageType.INF);
				SeleniumControl PRMW2_Box12Link = new SeleniumControl( sDriver, "Box12Link", "ID", "lnk_1002800_PRMW2_FEDW2FILE_HDR");
				Function.AssertEqual(true,PRMW2_Box12Link.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMW2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMW2] Performing Click on Box12Link...", Logger.MessageType.INF);
				SeleniumControl PRMW2_Box12Link = new SeleniumControl( sDriver, "Box12Link", "ID", "lnk_1002800_PRMW2_FEDW2FILE_HDR");
				Function.WaitControlDisplayed(PRMW2_Box12Link);
PRMW2_Box12Link.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMW2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMW2] Performing VerifyExists on Box12Form...", Logger.MessageType.INF);
				SeleniumControl PRMW2_Box12Form = new SeleniumControl( sDriver, "Box12Form", "xpath", "//div[starts-with(@id,'pr__PRMW2_BOX12W2FILE_CHILD1_')]/ancestor::form[1]");
				Function.AssertEqual(true,PRMW2_Box12Form.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMW2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMW2] Performing VerifyExist on Box12_Box12LinkTable...", Logger.MessageType.INF);
				SeleniumControl PRMW2_Box12_Box12LinkTable = new SeleniumControl( sDriver, "Box12_Box12LinkTable", "xpath", "//div[starts-with(@id,'pr__PRMW2_BOX12W2FILE_CHILD1_')]/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PRMW2_Box12_Box12LinkTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMW2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMW2] Performing Close on Box12Form...", Logger.MessageType.INF);
				SeleniumControl PRMW2_Box12Form = new SeleniumControl( sDriver, "Box12Form", "xpath", "//div[starts-with(@id,'pr__PRMW2_BOX12W2FILE_CHILD1_')]/ancestor::form[1]");
				Function.WaitControlDisplayed(PRMW2_Box12Form);
IWebElement formBttn = PRMW2_Box12Form.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("State");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMW2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMW2] Performing VerifyExists on StateLink...", Logger.MessageType.INF);
				SeleniumControl PRMW2_StateLink = new SeleniumControl( sDriver, "StateLink", "ID", "lnk_1002802_PRMW2_FEDW2FILE_HDR");
				Function.AssertEqual(true,PRMW2_StateLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMW2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMW2] Performing Click on StateLink...", Logger.MessageType.INF);
				SeleniumControl PRMW2_StateLink = new SeleniumControl( sDriver, "StateLink", "ID", "lnk_1002802_PRMW2_FEDW2FILE_HDR");
				Function.WaitControlDisplayed(PRMW2_StateLink);
PRMW2_StateLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMW2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMW2] Performing VerifyExists on StateForm...", Logger.MessageType.INF);
				SeleniumControl PRMW2_StateForm = new SeleniumControl( sDriver, "StateForm", "xpath", "//div[starts-with(@id,'pr__PRMW2_STATEW2FILE_CHILD2_')]/ancestor::form[1]");
				Function.AssertEqual(true,PRMW2_StateForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMW2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMW2] Performing VerifyExist on State_StateLinkTable...", Logger.MessageType.INF);
				SeleniumControl PRMW2_State_StateLinkTable = new SeleniumControl( sDriver, "State_StateLinkTable", "xpath", "//div[starts-with(@id,'pr__PRMW2_STATEW2FILE_CHILD2_')]/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PRMW2_State_StateLinkTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMW2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMW2] Performing Close on StateForm...", Logger.MessageType.INF);
				SeleniumControl PRMW2_StateForm = new SeleniumControl( sDriver, "StateForm", "xpath", "//div[starts-with(@id,'pr__PRMW2_STATEW2FILE_CHILD2_')]/ancestor::form[1]");
				Function.WaitControlDisplayed(PRMW2_StateForm);
IWebElement formBttn = PRMW2_StateForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Local");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMW2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMW2] Performing VerifyExists on LocalLink...", Logger.MessageType.INF);
				SeleniumControl PRMW2_LocalLink = new SeleniumControl( sDriver, "LocalLink", "ID", "lnk_1002803_PRMW2_FEDW2FILE_HDR");
				Function.AssertEqual(true,PRMW2_LocalLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMW2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMW2] Performing Click on LocalLink...", Logger.MessageType.INF);
				SeleniumControl PRMW2_LocalLink = new SeleniumControl( sDriver, "LocalLink", "ID", "lnk_1002803_PRMW2_FEDW2FILE_HDR");
				Function.WaitControlDisplayed(PRMW2_LocalLink);
PRMW2_LocalLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMW2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMW2] Performing VerifyExists on LocalForm...", Logger.MessageType.INF);
				SeleniumControl PRMW2_LocalForm = new SeleniumControl( sDriver, "LocalForm", "xpath", "//div[starts-with(@id,'pr__PRMW2_LOCALW2FILE_CHILD3_')]/ancestor::form[1]");
				Function.AssertEqual(true,PRMW2_LocalForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMW2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMW2] Performing VerifyExist on Local_LocalLinkTable...", Logger.MessageType.INF);
				SeleniumControl PRMW2_Local_LocalLinkTable = new SeleniumControl( sDriver, "Local_LocalLinkTable", "xpath", "//div[starts-with(@id,'pr__PRMW2_LOCALW2FILE_CHILD3_')]/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PRMW2_Local_LocalLinkTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMW2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMW2] Performing Close on LocalForm...", Logger.MessageType.INF);
				SeleniumControl PRMW2_LocalForm = new SeleniumControl( sDriver, "LocalForm", "xpath", "//div[starts-with(@id,'pr__PRMW2_LOCALW2FILE_CHILD3_')]/ancestor::form[1]");
				Function.WaitControlDisplayed(PRMW2_LocalForm);
IWebElement formBttn = PRMW2_LocalForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
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
				Function.CurrentComponent = "PRMW2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMW2] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl PRMW2_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PRMW2_MainForm);
IWebElement formBttn = PRMW2_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

