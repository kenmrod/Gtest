 
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
    public class COMMAP_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Consolidations", "xpath","//div[@class='deptItem'][.='Consolidations']").Click();
new SeleniumControl(sDriver,"Consolidations Controls", "xpath","//div[@class='navItem'][.='Consolidations Controls']").Click();
new SeleniumControl(sDriver,"Manage Consolidation Acct/Org Mappings", "xpath","//div[@class='navItem'][.='Manage Consolidation Acct/Org Mappings']").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SelectMenu]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("MainForm");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "COMMAP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[COMMAP] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl COMMAP_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,COMMAP_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "COMMAP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[COMMAP] Performing VerifyExists on MappingCode...", Logger.MessageType.INF);
				SeleniumControl COMMAP_MappingCode = new SeleniumControl( sDriver, "MappingCode", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='CONS_MAP_CD']");
				Function.AssertEqual(true,COMMAP_MappingCode.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "COMMAP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[COMMAP] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl COMMAP_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(COMMAP_MainForm);
IWebElement formBttn = COMMAP_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? COMMAP_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
COMMAP_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "COMMAP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[COMMAP] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl COMMAP_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,COMMAP_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "COMMAP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[COMMAP] Performing VerifyExists on ChildForm...", Logger.MessageType.INF);
				SeleniumControl COMMAP_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__COMMAP_CONSMAP_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,COMMAP_ChildForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "COMMAP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[COMMAP] Performing VerifyExist on ChildFormTable...", Logger.MessageType.INF);
				SeleniumControl COMMAP_ChildFormTable = new SeleniumControl( sDriver, "ChildFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__COMMAP_CONSMAP_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,COMMAP_ChildFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "COMMAP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[COMMAP] Performing VerifyExists on ChildForm2...", Logger.MessageType.INF);
				SeleniumControl COMMAP_ChildForm2 = new SeleniumControl( sDriver, "ChildForm2", "xpath", "//div[translate(@id,'0123456789','')='pr__COMMAP_ACCTORG_COUNT_']/ancestor::form[1]");
				Function.AssertEqual(true,COMMAP_ChildForm2.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "COMMAP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[COMMAP] Performing VerifyExists on ChildForm2_AccountCountText...", Logger.MessageType.INF);
				SeleniumControl COMMAP_ChildForm2_AccountCountText = new SeleniumControl( sDriver, "ChildForm2_AccountCountText", "xpath", "//div[translate(@id,'0123456789','')='pr__COMMAP_ACCTORG_COUNT_']/ancestor::form[1]/descendant::*[@id='ACCT_COUNT']");
				Function.AssertEqual(true,COMMAP_ChildForm2_AccountCountText.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "COMMAP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[COMMAP] Performing VerifyExists on SampleAccountsForm...", Logger.MessageType.INF);
				SeleniumControl COMMAP_SampleAccountsForm = new SeleniumControl( sDriver, "SampleAccountsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__COMMAP_ACCT_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,COMMAP_SampleAccountsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "COMMAP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[COMMAP] Performing VerifyExist on SampleAccountsFormTable...", Logger.MessageType.INF);
				SeleniumControl COMMAP_SampleAccountsFormTable = new SeleniumControl( sDriver, "SampleAccountsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__COMMAP_ACCT_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,COMMAP_SampleAccountsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "COMMAP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[COMMAP] Performing VerifyExists on SampleOrganizationsForm...", Logger.MessageType.INF);
				SeleniumControl COMMAP_SampleOrganizationsForm = new SeleniumControl( sDriver, "SampleOrganizationsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__COMMAP_ORG_ORGCTW_']/ancestor::form[1]");
				Function.AssertEqual(true,COMMAP_SampleOrganizationsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "COMMAP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[COMMAP] Performing VerifyExist on SampleOrganizationsFormTable...", Logger.MessageType.INF);
				SeleniumControl COMMAP_SampleOrganizationsFormTable = new SeleniumControl( sDriver, "SampleOrganizationsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__COMMAP_ORG_ORGCTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,COMMAP_SampleOrganizationsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "COMMAP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[COMMAP] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl COMMAP_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(COMMAP_MainForm);
IWebElement formBttn = COMMAP_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

