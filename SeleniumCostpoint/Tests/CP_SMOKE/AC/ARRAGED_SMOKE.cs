 
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
    public class ARRAGED_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Accounts Receivable", "xpath","//div[@class='deptItem'][.='Accounts Receivable']").Click();
new SeleniumControl(sDriver,"Accounts Receivable Reports/Inquiries", "xpath","//div[@class='navItem'][.='Accounts Receivable Reports/Inquiries']").Click();
new SeleniumControl(sDriver,"Print Accounts Receivable Aging Report", "xpath","//div[@class='navItem'][.='Print Accounts Receivable Aging Report']").Click();


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
				Function.CurrentComponent = "ARRAGED";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARRAGED] Performing VerifyExists on Identification_ParameterID...", Logger.MessageType.INF);
				SeleniumControl ARRAGED_Identification_ParameterID = new SeleniumControl( sDriver, "Identification_ParameterID", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PARM_ID']");
				Function.AssertEqual(true,ARRAGED_Identification_ParameterID.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARRAGED";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARRAGED] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl ARRAGED_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(ARRAGED_MainForm);
IWebElement formBttn = ARRAGED_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? ARRAGED_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
ARRAGED_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARRAGED";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARRAGED] Performing VerifyExist on MainForm_Table...", Logger.MessageType.INF);
				SeleniumControl ARRAGED_MainForm_Table = new SeleniumControl( sDriver, "MainForm_Table", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,ARRAGED_MainForm_Table.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Customer Non Contiguous Ranges");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARRAGED";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARRAGED] Performing Click on Identification_CustomerNonContiguousRangesLink...", Logger.MessageType.INF);
				SeleniumControl ARRAGED_Identification_CustomerNonContiguousRangesLink = new SeleniumControl( sDriver, "Identification_CustomerNonContiguousRangesLink", "ID", "lnk_1006661_ARRAGED_PARAM");
				Function.WaitControlDisplayed(ARRAGED_Identification_CustomerNonContiguousRangesLink);
ARRAGED_Identification_CustomerNonContiguousRangesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARRAGED";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARRAGED] Performing VerifyExist on CustomerNonContiguousRanges_Table...", Logger.MessageType.INF);
				SeleniumControl ARRAGED_CustomerNonContiguousRanges_Table = new SeleniumControl( sDriver, "CustomerNonContiguousRanges_Table", "xpath", "//div[translate(@id,'0123456789','')='pr__CPP_NCRCUSTID_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,ARRAGED_CustomerNonContiguousRanges_Table.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARRAGED";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARRAGED] Performing Close on CustomerNonContiguousRangesForm...", Logger.MessageType.INF);
				SeleniumControl ARRAGED_CustomerNonContiguousRangesForm = new SeleniumControl( sDriver, "CustomerNonContiguousRangesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPP_NCRCUSTID_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ARRAGED_CustomerNonContiguousRangesForm);
IWebElement formBttn = ARRAGED_CustomerNonContiguousRangesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Project Non Contigous Ranges");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARRAGED";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARRAGED] Performing Click on Identification_ProjectNonContiguousRangesLink...", Logger.MessageType.INF);
				SeleniumControl ARRAGED_Identification_ProjectNonContiguousRangesLink = new SeleniumControl( sDriver, "Identification_ProjectNonContiguousRangesLink", "ID", "lnk_1006662_ARRAGED_PARAM");
				Function.WaitControlDisplayed(ARRAGED_Identification_ProjectNonContiguousRangesLink);
ARRAGED_Identification_ProjectNonContiguousRangesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARRAGED";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARRAGED] Performing VerifyExist on ProjectNonContiguousRanges_Table...", Logger.MessageType.INF);
				SeleniumControl ARRAGED_ProjectNonContiguousRanges_Table = new SeleniumControl( sDriver, "ProjectNonContiguousRanges_Table", "xpath", "//div[translate(@id,'0123456789','')='pr__CPP_NCRPROJID_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,ARRAGED_ProjectNonContiguousRanges_Table.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARRAGED";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARRAGED] Performing Close on ProjectNonContiguousRangesForm...", Logger.MessageType.INF);
				SeleniumControl ARRAGED_ProjectNonContiguousRangesForm = new SeleniumControl( sDriver, "ProjectNonContiguousRangesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPP_NCRPROJID_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ARRAGED_ProjectNonContiguousRangesForm);
IWebElement formBttn = ARRAGED_ProjectNonContiguousRangesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Account Non Contigouos");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARRAGED";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARRAGED] Performing Click on Identification_AccountNonContiguousRangesLink...", Logger.MessageType.INF);
				SeleniumControl ARRAGED_Identification_AccountNonContiguousRangesLink = new SeleniumControl( sDriver, "Identification_AccountNonContiguousRangesLink", "ID", "lnk_1006665_ARRAGED_PARAM");
				Function.WaitControlDisplayed(ARRAGED_Identification_AccountNonContiguousRangesLink);
ARRAGED_Identification_AccountNonContiguousRangesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARRAGED";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARRAGED] Performing VerifyExist on AccountNonContiguousRanges_Table...", Logger.MessageType.INF);
				SeleniumControl ARRAGED_AccountNonContiguousRanges_Table = new SeleniumControl( sDriver, "AccountNonContiguousRanges_Table", "xpath", "//div[translate(@id,'0123456789','')='pr__CPP_NCRACCTID_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,ARRAGED_AccountNonContiguousRanges_Table.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARRAGED";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARRAGED] Performing Close on AccountNonContiguousRangesForm...", Logger.MessageType.INF);
				SeleniumControl ARRAGED_AccountNonContiguousRangesForm = new SeleniumControl( sDriver, "AccountNonContiguousRangesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPP_NCRACCTID_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ARRAGED_AccountNonContiguousRangesForm);
IWebElement formBttn = ARRAGED_AccountNonContiguousRangesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Organization Non Contigouos");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARRAGED";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARRAGED] Performing Click on Identification_OrganizationNonContiguousRangesLink...", Logger.MessageType.INF);
				SeleniumControl ARRAGED_Identification_OrganizationNonContiguousRangesLink = new SeleniumControl( sDriver, "Identification_OrganizationNonContiguousRangesLink", "ID", "lnk_1006666_ARRAGED_PARAM");
				Function.WaitControlDisplayed(ARRAGED_Identification_OrganizationNonContiguousRangesLink);
ARRAGED_Identification_OrganizationNonContiguousRangesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARRAGED";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARRAGED] Performing VerifyExist on OrganizationNonContiguousRanges_Table...", Logger.MessageType.INF);
				SeleniumControl ARRAGED_OrganizationNonContiguousRanges_Table = new SeleniumControl( sDriver, "OrganizationNonContiguousRanges_Table", "xpath", "//div[translate(@id,'0123456789','')='pr__CPP_NCRORGID_NCR_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,ARRAGED_OrganizationNonContiguousRanges_Table.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARRAGED";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARRAGED] Performing Close on OrganizationNonContiguousRangesForm...", Logger.MessageType.INF);
				SeleniumControl ARRAGED_OrganizationNonContiguousRangesForm = new SeleniumControl( sDriver, "OrganizationNonContiguousRangesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPP_NCRORGID_NCR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ARRAGED_OrganizationNonContiguousRangesForm);
IWebElement formBttn = ARRAGED_OrganizationNonContiguousRangesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Customer Name Non Contigouos");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARRAGED";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARRAGED] Performing Click on Identification_CustomerNameNonContiguousRangesLink...", Logger.MessageType.INF);
				SeleniumControl ARRAGED_Identification_CustomerNameNonContiguousRangesLink = new SeleniumControl( sDriver, "Identification_CustomerNameNonContiguousRangesLink", "ID", "lnk_1006667_ARRAGED_PARAM");
				Function.WaitControlDisplayed(ARRAGED_Identification_CustomerNameNonContiguousRangesLink);
ARRAGED_Identification_CustomerNameNonContiguousRangesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARRAGED";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARRAGED] Performing VerifyExist on CustomerNameNonContiguousRanges_Table...", Logger.MessageType.INF);
				SeleniumControl ARRAGED_CustomerNameNonContiguousRanges_Table = new SeleniumControl( sDriver, "CustomerNameNonContiguousRanges_Table", "xpath", "//div[translate(@id,'0123456789','')='pr__CPP_NCRCUSTNAME_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,ARRAGED_CustomerNameNonContiguousRanges_Table.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARRAGED";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARRAGED] Performing Close on CustomerNameNonContiguousRangesForm...", Logger.MessageType.INF);
				SeleniumControl ARRAGED_CustomerNameNonContiguousRangesForm = new SeleniumControl( sDriver, "CustomerNameNonContiguousRangesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPP_NCRCUSTNAME_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ARRAGED_CustomerNameNonContiguousRangesForm);
IWebElement formBttn = ARRAGED_CustomerNameNonContiguousRangesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("User Def1 Non Contigous");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARRAGED";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARRAGED] Performing Click on Identification_UserDef1NonContiguousRangesLink...", Logger.MessageType.INF);
				SeleniumControl ARRAGED_Identification_UserDef1NonContiguousRangesLink = new SeleniumControl( sDriver, "Identification_UserDef1NonContiguousRangesLink", "ID", "lnk_1006674_ARRAGED_PARAM");
				Function.WaitControlDisplayed(ARRAGED_Identification_UserDef1NonContiguousRangesLink);
ARRAGED_Identification_UserDef1NonContiguousRangesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARRAGED";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARRAGED] Performing VerifyExist on UserDef1NonContiguousRanges_Table...", Logger.MessageType.INF);
				SeleniumControl ARRAGED_UserDef1NonContiguousRanges_Table = new SeleniumControl( sDriver, "UserDef1NonContiguousRanges_Table", "xpath", "//div[translate(@id,'0123456789','')='pr__CPP_NCRUSERDEFFLD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,ARRAGED_UserDef1NonContiguousRanges_Table.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARRAGED";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARRAGED] Performing Close on UserDef1NonContiguousRangesForm...", Logger.MessageType.INF);
				SeleniumControl ARRAGED_UserDef1NonContiguousRangesForm = new SeleniumControl( sDriver, "UserDef1NonContiguousRangesForm", "xpath", "//div[starts-with(@id,'pr__CPP_NCRUSERDEF1FLD_')]/ancestor::form[1]");
				Function.WaitControlDisplayed(ARRAGED_UserDef1NonContiguousRangesForm);
IWebElement formBttn = ARRAGED_UserDef1NonContiguousRangesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("User Def2 Non Contigous");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARRAGED";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARRAGED] Performing Click on Identification_UserDef2NonContiguousRangesLink...", Logger.MessageType.INF);
				SeleniumControl ARRAGED_Identification_UserDef2NonContiguousRangesLink = new SeleniumControl( sDriver, "Identification_UserDef2NonContiguousRangesLink", "ID", "lnk_1006675_ARRAGED_PARAM");
				Function.WaitControlDisplayed(ARRAGED_Identification_UserDef2NonContiguousRangesLink);
ARRAGED_Identification_UserDef2NonContiguousRangesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARRAGED";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARRAGED] Performing VerifyExist on UserDef2NonContiguousRanges_Table...", Logger.MessageType.INF);
				SeleniumControl ARRAGED_UserDef2NonContiguousRanges_Table = new SeleniumControl( sDriver, "UserDef2NonContiguousRanges_Table", "xpath", "//div[translate(@id,'0123456789','')='pr__CPP_NCRUSERDEFFLD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,ARRAGED_UserDef2NonContiguousRanges_Table.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARRAGED";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARRAGED] Performing Close on UserDef2NonContiguousRangesForm...", Logger.MessageType.INF);
				SeleniumControl ARRAGED_UserDef2NonContiguousRangesForm = new SeleniumControl( sDriver, "UserDef2NonContiguousRangesForm", "xpath", "//div[starts-with(@id,'pr__CPP_NCRUSERDEF2FLD_')]/ancestor::form[1]");
				Function.WaitControlDisplayed(ARRAGED_UserDef2NonContiguousRangesForm);
IWebElement formBttn = ARRAGED_UserDef2NonContiguousRangesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "ARRAGED";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARRAGED] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl ARRAGED_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(ARRAGED_MainForm);
IWebElement formBttn = ARRAGED_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

