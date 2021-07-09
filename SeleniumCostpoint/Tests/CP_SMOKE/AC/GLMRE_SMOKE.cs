 
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
    public class GLMRE_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"General Ledger", "xpath","//div[@class='deptItem'][.='General Ledger']").Click();
new SeleniumControl(sDriver,"Reorganizations", "xpath","//div[@class='navItem'][.='Reorganizations']").Click();
new SeleniumControl(sDriver,"Manage Reorganization Elements", "xpath","//div[@class='navItem'][.='Manage Reorganization Elements']").Click();


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
				Function.CurrentComponent = "GLMRE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMRE] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl GLMRE_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,GLMRE_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMRE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMRE] Performing VerifyExists on Identification_Reorganization...", Logger.MessageType.INF);
				SeleniumControl GLMRE_Identification_Reorganization = new SeleniumControl( sDriver, "Identification_Reorganization", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='DFSREORGID']");
				Function.AssertEqual(true,GLMRE_Identification_Reorganization.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMRE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMRE] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl GLMRE_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(GLMRE_MainForm);
IWebElement formBttn = GLMRE_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? GLMRE_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
GLMRE_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMRE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMRE] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl GLMRE_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,GLMRE_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("CHILD");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMRE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMRE] Performing VerifyExists on Identification_LinkReorganizationsToOrgsLink...", Logger.MessageType.INF);
				SeleniumControl GLMRE_Identification_LinkReorganizationsToOrgsLink = new SeleniumControl( sDriver, "Identification_LinkReorganizationsToOrgsLink", "ID", "lnk_1000695_GLMRE_REORGSTRUC_MAINTREORG");
				Function.AssertEqual(true,GLMRE_Identification_LinkReorganizationsToOrgsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMRE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMRE] Performing Click on Identification_LinkReorganizationsToOrgsLink...", Logger.MessageType.INF);
				SeleniumControl GLMRE_Identification_LinkReorganizationsToOrgsLink = new SeleniumControl( sDriver, "Identification_LinkReorganizationsToOrgsLink", "ID", "lnk_1000695_GLMRE_REORGSTRUC_MAINTREORG");
				Function.WaitControlDisplayed(GLMRE_Identification_LinkReorganizationsToOrgsLink);
GLMRE_Identification_LinkReorganizationsToOrgsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMRE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMRE] Performing VerifyExists on LinkReorganizationsToOrgsForm...", Logger.MessageType.INF);
				SeleniumControl GLMRE_LinkReorganizationsToOrgsForm = new SeleniumControl( sDriver, "LinkReorganizationsToOrgsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLMRE_REORGORGLINK_LINK_']/ancestor::form[1]");
				Function.AssertEqual(true,GLMRE_LinkReorganizationsToOrgsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMRE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMRE] Performing VerifyExist on LinkReorganizationsToOrgsFormTable...", Logger.MessageType.INF);
				SeleniumControl GLMRE_LinkReorganizationsToOrgsFormTable = new SeleniumControl( sDriver, "LinkReorganizationsToOrgsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__GLMRE_REORGORGLINK_LINK_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,GLMRE_LinkReorganizationsToOrgsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMRE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMRE] Performing Close on LinkReorganizationsToOrgsForm...", Logger.MessageType.INF);
				SeleniumControl GLMRE_LinkReorganizationsToOrgsForm = new SeleniumControl( sDriver, "LinkReorganizationsToOrgsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLMRE_REORGORGLINK_LINK_']/ancestor::form[1]");
				Function.WaitControlDisplayed(GLMRE_LinkReorganizationsToOrgsForm);
IWebElement formBttn = GLMRE_LinkReorganizationsToOrgsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("CLOSE APP");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMRE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMRE] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl GLMRE_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(GLMRE_MainForm);
IWebElement formBttn = GLMRE_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

