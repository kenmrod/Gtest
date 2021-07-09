 
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
    public class POMBUY_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Materials", "xpath","//div[@class='busItem'][.='Materials']").Click();
new SeleniumControl(sDriver,"Purchasing", "xpath","//div[@class='deptItem'][.='Purchasing']").Click();
new SeleniumControl(sDriver,"Purchasing Codes", "xpath","//div[@class='navItem'][.='Purchasing Codes']").Click();
new SeleniumControl(sDriver,"Manage Buyers", "xpath","//div[@class='navItem'][.='Manage Buyers']").Click();


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
				Function.CurrentComponent = "POMBUY";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMBUY] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl POMBUY_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,POMBUY_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMBUY";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMBUY] Performing VerifyExists on BuyerID...", Logger.MessageType.INF);
				SeleniumControl POMBUY_BuyerID = new SeleniumControl( sDriver, "BuyerID", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='BUYER_ID']");
				Function.AssertEqual(true,POMBUY_BuyerID.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMBUY";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMBUY] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl POMBUY_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(POMBUY_MainForm);
IWebElement formBttn = POMBUY_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? POMBUY_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
POMBUY_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMBUY";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMBUY] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl POMBUY_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,POMBUY_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("link acct/org");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMBUY";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMBUY] Performing Click on LinkAcctOrgLink...", Logger.MessageType.INF);
				SeleniumControl POMBUY_LinkAcctOrgLink = new SeleniumControl( sDriver, "LinkAcctOrgLink", "ID", "lnk_1002208_POMBUY_BUYER");
				Function.WaitControlDisplayed(POMBUY_LinkAcctOrgLink);
POMBUY_LinkAcctOrgLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMBUY";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMBUY] Performing VerifyExists on LinkAcctOrg_AcctOrgTable1Form...", Logger.MessageType.INF);
				SeleniumControl POMBUY_LinkAcctOrg_AcctOrgTable1Form = new SeleniumControl( sDriver, "LinkAcctOrg_AcctOrgTable1Form", "xpath", "//div[translate(@id,'0123456789','')='pr__POMBUY_VPOORGACCT_']/ancestor::form[1]");
				Function.AssertEqual(true,POMBUY_LinkAcctOrg_AcctOrgTable1Form.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMBUY";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMBUY] Performing VerifyExists on LinkAcctOrg_AcctOrgTable2Form...", Logger.MessageType.INF);
				SeleniumControl POMBUY_LinkAcctOrg_AcctOrgTable2Form = new SeleniumControl( sDriver, "LinkAcctOrg_AcctOrgTable2Form", "xpath", "//div[translate(@id,'0123456789','')='pr__POMBUY_BUYERORGACCT_']/ancestor::form[1]");
				Function.AssertEqual(true,POMBUY_LinkAcctOrg_AcctOrgTable2Form.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMBUY";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMBUY] Performing VerifyExist on LinkAcctOrg_AcctOrgTable2...", Logger.MessageType.INF);
				SeleniumControl POMBUY_LinkAcctOrg_AcctOrgTable2 = new SeleniumControl( sDriver, "LinkAcctOrg_AcctOrgTable2", "xpath", "//div[translate(@id,'0123456789','')='pr__POMBUY_BUYERORGACCT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,POMBUY_LinkAcctOrg_AcctOrgTable2.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMBUY";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMBUY] Performing VerifyExist on LinkAcctOrg_AcctOrgTable1...", Logger.MessageType.INF);
				SeleniumControl POMBUY_LinkAcctOrg_AcctOrgTable1 = new SeleniumControl( sDriver, "LinkAcctOrg_AcctOrgTable1", "xpath", "//div[translate(@id,'0123456789','')='pr__POMBUY_VPOORGACCT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,POMBUY_LinkAcctOrg_AcctOrgTable1.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMBUY";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMBUY] Performing Close on LinkAcctOrg_AcctOrgTable2Form...", Logger.MessageType.INF);
				SeleniumControl POMBUY_LinkAcctOrg_AcctOrgTable2Form = new SeleniumControl( sDriver, "LinkAcctOrg_AcctOrgTable2Form", "xpath", "//div[translate(@id,'0123456789','')='pr__POMBUY_BUYERORGACCT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POMBUY_LinkAcctOrg_AcctOrgTable2Form);
IWebElement formBttn = POMBUY_LinkAcctOrg_AcctOrgTable2Form.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Link Projects");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMBUY";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMBUY] Performing Click on LinkProjectsLink...", Logger.MessageType.INF);
				SeleniumControl POMBUY_LinkProjectsLink = new SeleniumControl( sDriver, "LinkProjectsLink", "ID", "lnk_1002211_POMBUY_BUYER");
				Function.WaitControlDisplayed(POMBUY_LinkProjectsLink);
POMBUY_LinkProjectsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMBUY";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMBUY] Performing VerifyExists on LinkProjects_ProjectsTable1Form...", Logger.MessageType.INF);
				SeleniumControl POMBUY_LinkProjects_ProjectsTable1Form = new SeleniumControl( sDriver, "LinkProjects_ProjectsTable1Form", "xpath", "//div[translate(@id,'0123456789','')='pr__POMBUY_PROJ_']/ancestor::form[1]");
				Function.AssertEqual(true,POMBUY_LinkProjects_ProjectsTable1Form.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMBUY";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMBUY] Performing VerifyExists on LinkProjects_ProjectsTable2Form...", Logger.MessageType.INF);
				SeleniumControl POMBUY_LinkProjects_ProjectsTable2Form = new SeleniumControl( sDriver, "LinkProjects_ProjectsTable2Form", "xpath", "//div[translate(@id,'0123456789','')='pr__POMBUY_BUYERPROJ_']/ancestor::form[1]");
				Function.AssertEqual(true,POMBUY_LinkProjects_ProjectsTable2Form.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMBUY";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMBUY] Performing VerifyExist on LinkProjects_ProjectsTable1...", Logger.MessageType.INF);
				SeleniumControl POMBUY_LinkProjects_ProjectsTable1 = new SeleniumControl( sDriver, "LinkProjects_ProjectsTable1", "xpath", "//div[translate(@id,'0123456789','')='pr__POMBUY_PROJ_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,POMBUY_LinkProjects_ProjectsTable1.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMBUY";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMBUY] Performing VerifyExist on LinkProjects_ProjectsTable2...", Logger.MessageType.INF);
				SeleniumControl POMBUY_LinkProjects_ProjectsTable2 = new SeleniumControl( sDriver, "LinkProjects_ProjectsTable2", "xpath", "//div[translate(@id,'0123456789','')='pr__POMBUY_BUYERPROJ_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,POMBUY_LinkProjects_ProjectsTable2.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMBUY";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMBUY] Performing Close on LinkProjects_ProjectsTable2Form...", Logger.MessageType.INF);
				SeleniumControl POMBUY_LinkProjects_ProjectsTable2Form = new SeleniumControl( sDriver, "LinkProjects_ProjectsTable2Form", "xpath", "//div[translate(@id,'0123456789','')='pr__POMBUY_BUYERPROJ_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POMBUY_LinkProjects_ProjectsTable2Form);
IWebElement formBttn = POMBUY_LinkProjects_ProjectsTable2Form.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Link Vendors");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMBUY";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMBUY] Performing Click on LinkVendorsLink...", Logger.MessageType.INF);
				SeleniumControl POMBUY_LinkVendorsLink = new SeleniumControl( sDriver, "LinkVendorsLink", "ID", "lnk_1002061_POMBUY_BUYER");
				Function.WaitControlDisplayed(POMBUY_LinkVendorsLink);
POMBUY_LinkVendorsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMBUY";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMBUY] Performing VerifyExists on LinkVendors_VendorsTableForm...", Logger.MessageType.INF);
				SeleniumControl POMBUY_LinkVendors_VendorsTableForm = new SeleniumControl( sDriver, "LinkVendors_VendorsTableForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POMBUY_VEND_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,POMBUY_LinkVendors_VendorsTableForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMBUY";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMBUY] Performing VerifyExist on LinkVendors_VendorsTable...", Logger.MessageType.INF);
				SeleniumControl POMBUY_LinkVendors_VendorsTable = new SeleniumControl( sDriver, "LinkVendors_VendorsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__POMBUY_VEND_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,POMBUY_LinkVendors_VendorsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMBUY";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMBUY] Performing Close on LinkVendors_VendorsTableForm...", Logger.MessageType.INF);
				SeleniumControl POMBUY_LinkVendors_VendorsTableForm = new SeleniumControl( sDriver, "LinkVendors_VendorsTableForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POMBUY_VEND_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POMBUY_LinkVendors_VendorsTableForm);
IWebElement formBttn = POMBUY_LinkVendors_VendorsTableForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Close the application");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMBUY";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMBUY] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl POMBUY_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(POMBUY_MainForm);
IWebElement formBttn = POMBUY_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

