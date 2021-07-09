 
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
    public class GLMLREO_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Mass Link Reorganizations/Organizations", "xpath","//div[@class='navItem'][.='Mass Link Reorganizations/Organizations']").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SelectMenu]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Reorganizations Form");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMLREO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMLREO] Performing VerifyExists on ReorganizationsForm...", Logger.MessageType.INF);
				SeleniumControl GLMLREO_ReorganizationsForm = new SeleniumControl( sDriver, "ReorganizationsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLMLREO_REORGSTRUC_TBL_']/ancestor::form[1]");
				Function.AssertEqual(true,GLMLREO_ReorganizationsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMLREO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMLREO] Performing VerifyExist on ReferencesFormTable...", Logger.MessageType.INF);
				SeleniumControl GLMLREO_ReferencesFormTable = new SeleniumControl( sDriver, "ReferencesFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__GLMLREO_REORGSTRUC_TBL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,GLMLREO_ReferencesFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Organizations Form");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMLREO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMLREO] Performing VerifyExists on OrganizationsForm...", Logger.MessageType.INF);
				SeleniumControl GLMLREO_OrganizationsForm = new SeleniumControl( sDriver, "OrganizationsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLMLREO_ORGID_TBL_']/ancestor::form[1]");
				Function.AssertEqual(true,GLMLREO_OrganizationsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMLREO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMLREO] Performing VerifyExist on AccountsOrganizationsFormTable...", Logger.MessageType.INF);
				SeleniumControl GLMLREO_AccountsOrganizationsFormTable = new SeleniumControl( sDriver, "AccountsOrganizationsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__GLMLREO_ORGID_TBL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,GLMLREO_AccountsOrganizationsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Reorganizations/Organizations Form");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMLREO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMLREO] Performing VerifyExists on SelectedReorganizationsOrganizationsForm...", Logger.MessageType.INF);
				SeleniumControl GLMLREO_SelectedReorganizationsOrganizationsForm = new SeleniumControl( sDriver, "SelectedReorganizationsOrganizationsForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,GLMLREO_SelectedReorganizationsOrganizationsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMLREO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMLREO] Performing VerifyExist on SelectedReferencesAccountsOrganizationFormTable...", Logger.MessageType.INF);
				SeleniumControl GLMLREO_SelectedReferencesAccountsOrganizationFormTable = new SeleniumControl( sDriver, "SelectedReferencesAccountsOrganizationFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,GLMLREO_SelectedReferencesAccountsOrganizationFormTable.Exists());

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

