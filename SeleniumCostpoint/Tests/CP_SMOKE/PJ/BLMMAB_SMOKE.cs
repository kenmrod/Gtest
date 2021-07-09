 
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
    public class BLMMAB_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Billing", "xpath","//div[@class='deptItem'][.='Billing']").Click();
new SeleniumControl(sDriver,"Billing Master", "xpath","//div[@class='navItem'][.='Billing Master']").Click();
new SeleniumControl(sDriver,"Manage ACRN Bills", "xpath","//div[@class='navItem'][.='Manage ACRN Bills']").Click();


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
				Function.CurrentComponent = "BLMMAB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMMAB] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl BLMMAB_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(BLMMAB_MainForm);
IWebElement formBttn = BLMMAB_MainForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).Count <= 0 ? BLMMAB_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Query')]")).FirstOrDefault() :
BLMMAB_MainForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Query not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "Query";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[Query] Performing Click on Find...", Logger.MessageType.INF);
				SeleniumControl Query_Find = new SeleniumControl( sDriver, "Find", "ID", "submitQ");
				Function.WaitControlDisplayed(Query_Find);
if (Query_Find.mElement.GetAttribute("class") == "popupBtn" && sDriver.BrowserType == "ie")
Query_Find.Click(5,5);
else Query_Find.Click(4.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMMAB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMMAB] Performing VerifyExist on MainForm_Table...", Logger.MessageType.INF);
				SeleniumControl BLMMAB_MainForm_Table = new SeleniumControl( sDriver, "MainForm_Table", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BLMMAB_MainForm_Table.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMMAB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMMAB] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl BLMMAB_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(BLMMAB_MainForm);
IWebElement formBttn = BLMMAB_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? BLMMAB_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
BLMMAB_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMMAB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMMAB] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl BLMMAB_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,BLMMAB_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMMAB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMMAB] Performing VerifyExists on Identification_Project...", Logger.MessageType.INF);
				SeleniumControl BLMMAB_Identification_Project = new SeleniumControl( sDriver, "Identification_Project", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PROJ_ID']");
				Function.AssertEqual(true,BLMMAB_Identification_Project.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("ACRN Details");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMMAB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMMAB] Performing VerifyExist on ACRNDetails_Table...", Logger.MessageType.INF);
				SeleniumControl BLMMAB_ACRNDetails_Table = new SeleniumControl( sDriver, "ACRNDetails_Table", "xpath", "//div[translate(@id,'0123456789','')='pr__PBM_ACRNBILL_PROJACRNDETL_CHLD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BLMMAB_ACRNDetails_Table.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMMAB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMMAB] Performing ClickButton on ProjectACRNDetailsForm...", Logger.MessageType.INF);
				SeleniumControl BLMMAB_ProjectACRNDetailsForm = new SeleniumControl( sDriver, "ProjectACRNDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PBM_ACRNBILL_PROJACRNDETL_CHLD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BLMMAB_ProjectACRNDetailsForm);
IWebElement formBttn = BLMMAB_ProjectACRNDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? BLMMAB_ProjectACRNDetailsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
BLMMAB_ProjectACRNDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMMAB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMMAB] Performing VerifyExists on ProjectACRNDetailsForm...", Logger.MessageType.INF);
				SeleniumControl BLMMAB_ProjectACRNDetailsForm = new SeleniumControl( sDriver, "ProjectACRNDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PBM_ACRNBILL_PROJACRNDETL_CHLD_']/ancestor::form[1]");
				Function.AssertEqual(true,BLMMAB_ProjectACRNDetailsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMMAB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMMAB] Performing VerifyExists on ProjectACRNDetails_SequenceNumber...", Logger.MessageType.INF);
				SeleniumControl BLMMAB_ProjectACRNDetails_SequenceNumber = new SeleniumControl( sDriver, "ProjectACRNDetails_SequenceNumber", "xpath", "//div[translate(@id,'0123456789','')='pr__PBM_ACRNBILL_PROJACRNDETL_CHLD_']/ancestor::form[1]/descendant::*[@id='SEQ_NO']");
				Function.AssertEqual(true,BLMMAB_ProjectACRNDetails_SequenceNumber.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Acconts");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMMAB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMMAB] Performing VerifyExists on ProjectACRNDetails_AccountsLink...", Logger.MessageType.INF);
				SeleniumControl BLMMAB_ProjectACRNDetails_AccountsLink = new SeleniumControl( sDriver, "ProjectACRNDetails_AccountsLink", "ID", "lnk_16420_PBM_ACRNBILL_PROJACRNDETL_CHLD");
				Function.AssertEqual(true,BLMMAB_ProjectACRNDetails_AccountsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMMAB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMMAB] Performing Click on ProjectACRNDetails_AccountsLink...", Logger.MessageType.INF);
				SeleniumControl BLMMAB_ProjectACRNDetails_AccountsLink = new SeleniumControl( sDriver, "ProjectACRNDetails_AccountsLink", "ID", "lnk_16420_PBM_ACRNBILL_PROJACRNDETL_CHLD");
				Function.WaitControlDisplayed(BLMMAB_ProjectACRNDetails_AccountsLink);
BLMMAB_ProjectACRNDetails_AccountsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMMAB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMMAB] Performing VerifyExist on Accounts_Table...", Logger.MessageType.INF);
				SeleniumControl BLMMAB_Accounts_Table = new SeleniumControl( sDriver, "Accounts_Table", "xpath", "//div[translate(@id,'0123456789','')='pr__PBM_ACRNBILL_PROJACRNACCT_CHLD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BLMMAB_Accounts_Table.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMMAB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMMAB] Performing Close on AccountsForm...", Logger.MessageType.INF);
				SeleniumControl BLMMAB_AccountsForm = new SeleniumControl( sDriver, "AccountsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PBM_ACRNBILL_PROJACRNACCT_CHLD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BLMMAB_AccountsForm);
IWebElement formBttn = BLMMAB_AccountsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("PLC Mapping");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMMAB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMMAB] Performing VerifyExists on ProjectACRNDetails_PLCMappingLink...", Logger.MessageType.INF);
				SeleniumControl BLMMAB_ProjectACRNDetails_PLCMappingLink = new SeleniumControl( sDriver, "ProjectACRNDetails_PLCMappingLink", "ID", "lnk_16421_PBM_ACRNBILL_PROJACRNDETL_CHLD");
				Function.AssertEqual(true,BLMMAB_ProjectACRNDetails_PLCMappingLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMMAB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMMAB] Performing Click on ProjectACRNDetails_PLCMappingLink...", Logger.MessageType.INF);
				SeleniumControl BLMMAB_ProjectACRNDetails_PLCMappingLink = new SeleniumControl( sDriver, "ProjectACRNDetails_PLCMappingLink", "ID", "lnk_16421_PBM_ACRNBILL_PROJACRNDETL_CHLD");
				Function.WaitControlDisplayed(BLMMAB_ProjectACRNDetails_PLCMappingLink);
BLMMAB_ProjectACRNDetails_PLCMappingLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMMAB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMMAB] Performing VerifyExist on PLCMapping_Table...", Logger.MessageType.INF);
				SeleniumControl BLMMAB_PLCMapping_Table = new SeleniumControl( sDriver, "PLCMapping_Table", "xpath", "//div[translate(@id,'0123456789','')='pr__PBM_ACRNBILL_PROJACRNPLC_CHILD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BLMMAB_PLCMapping_Table.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMMAB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMMAB] Performing Close on PLCMappingForm...", Logger.MessageType.INF);
				SeleniumControl BLMMAB_PLCMappingForm = new SeleniumControl( sDriver, "PLCMappingForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PBM_ACRNBILL_PROJACRNPLC_CHILD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BLMMAB_PLCMappingForm);
IWebElement formBttn = BLMMAB_PLCMappingForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "BLMMAB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMMAB] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl BLMMAB_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(BLMMAB_MainForm);
IWebElement formBttn = BLMMAB_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

