 
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
    public class PJMMLPAO_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Charging Information", "xpath","//div[@class='navItem'][.='Charging Information']").Click();
new SeleniumControl(sDriver,"Mass Link Projects/Accounts/Organizations", "xpath","//div[@class='navItem'][.='Mass Link Projects/Accounts/Organizations']").Click();


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
				Function.CurrentComponent = "Query";
								Function.WaitControlDisplayed(new SeleniumControl(sDriver,"QueryTitle", "ID", "qryHeaderLabel"));
Function.AssertEqual("Mass Link Proj/Acct/Org", new SeleniumControl(sDriver,"QueryTitle", "ID", "qryHeaderLabel").GetValue().Trim());


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyTitle]" , ex.Message));
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
				Function.CurrentComponent = "PJMMLPAO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMMLPAO] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl PJMMLPAO_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJMMLPAO_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMMLPAO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMMLPAO] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl PJMMLPAO_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PJMMLPAO_MainForm);
IWebElement formBttn = PJMMLPAO_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PJMMLPAO_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PJMMLPAO_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMMLPAO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMMLPAO] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl PJMMLPAO_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,PJMMLPAO_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMMLPAO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMMLPAO] Performing VerifyExists on Project...", Logger.MessageType.INF);
				SeleniumControl PJMMLPAO_Project = new SeleniumControl( sDriver, "Project", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PROJ_ID']");
				Function.AssertEqual(true,PJMMLPAO_Project.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("MASS LINK PROJ/ACCT/ORG");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMMLPAO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMMLPAO] Performing VerifyExists on MassLinkProjAcctOrgForm...", Logger.MessageType.INF);
				SeleniumControl PJMMLPAO_MassLinkProjAcctOrgForm = new SeleniumControl( sDriver, "MassLinkProjAcctOrgForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJM_ACCTGRPSETUPMLPAO_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,PJMMLPAO_MassLinkProjAcctOrgForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMMLPAO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMMLPAO] Performing VerifyExist on MassLinkProjAcctOrgFormTable...", Logger.MessageType.INF);
				SeleniumControl PJMMLPAO_MassLinkProjAcctOrgFormTable = new SeleniumControl( sDriver, "MassLinkProjAcctOrgFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PJM_ACCTGRPSETUPMLPAO_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJMMLPAO_MassLinkProjAcctOrgFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMMLPAO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMMLPAO] Performing VerifyExists on MassLinkProjAcctOrg_Select...", Logger.MessageType.INF);
				SeleniumControl PJMMLPAO_MassLinkProjAcctOrg_Select = new SeleniumControl( sDriver, "MassLinkProjAcctOrg_Select", "xpath", "//div[translate(@id,'0123456789','')='pr__PJM_ACCTGRPSETUPMLPAO_CTW_']/ancestor::form[1]/descendant::*[contains(@id,'SELECT') and contains(@style,'visible')]");
				Function.AssertEqual(true,PJMMLPAO_MassLinkProjAcctOrg_Select.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMMLPAO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMMLPAO] Performing VerifyExist on OrganizationsFormTable...", Logger.MessageType.INF);
				SeleniumControl PJMMLPAO_OrganizationsFormTable = new SeleniumControl( sDriver, "OrganizationsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PJM_VGLLOOKUPAOMLPAO_CHILD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJMMLPAO_OrganizationsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMMLPAO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMMLPAO] Performing VerifyExists on OrganizationsForm...", Logger.MessageType.INF);
				SeleniumControl PJMMLPAO_OrganizationsForm = new SeleniumControl( sDriver, "OrganizationsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJM_VGLLOOKUPAOMLPAO_CHILD_']/ancestor::form[1]");
				Function.AssertEqual(true,PJMMLPAO_OrganizationsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("SELECTED ACCOUNTS / ORGANIZATIONS");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMMLPAO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMMLPAO] Performing VerifyExist on SelectedAccountOrganizationsFormTable...", Logger.MessageType.INF);
				SeleniumControl PJMMLPAO_SelectedAccountOrganizationsFormTable = new SeleniumControl( sDriver, "SelectedAccountOrganizationsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PJM_PROJORGACCTMLPAO_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJMMLPAO_SelectedAccountOrganizationsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMMLPAO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMMLPAO] Performing ClickButton on SelectedAccountOrganizationsForm...", Logger.MessageType.INF);
				SeleniumControl PJMMLPAO_SelectedAccountOrganizationsForm = new SeleniumControl( sDriver, "SelectedAccountOrganizationsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJM_PROJORGACCTMLPAO_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJMMLPAO_SelectedAccountOrganizationsForm);
IWebElement formBttn = PJMMLPAO_SelectedAccountOrganizationsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PJMMLPAO_SelectedAccountOrganizationsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PJMMLPAO_SelectedAccountOrganizationsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMMLPAO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMMLPAO] Performing VerifyExists on SelectedAccountOrganizationsForm...", Logger.MessageType.INF);
				SeleniumControl PJMMLPAO_SelectedAccountOrganizationsForm = new SeleniumControl( sDriver, "SelectedAccountOrganizationsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJM_PROJORGACCTMLPAO_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,PJMMLPAO_SelectedAccountOrganizationsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMMLPAO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMMLPAO] Performing VerifyExists on SelectedAccountOrganizations_Account...", Logger.MessageType.INF);
				SeleniumControl PJMMLPAO_SelectedAccountOrganizations_Account = new SeleniumControl( sDriver, "SelectedAccountOrganizations_Account", "xpath", "//div[translate(@id,'0123456789','')='pr__PJM_PROJORGACCTMLPAO_CTW_']/ancestor::form[1]/descendant::*[@id='ACCT_ID']");
				Function.AssertEqual(true,PJMMLPAO_SelectedAccountOrganizations_Account.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
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
				Function.CurrentComponent = "PJMMLPAO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMMLPAO] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl PJMMLPAO_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PJMMLPAO_MainForm);
IWebElement formBttn = PJMMLPAO_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

