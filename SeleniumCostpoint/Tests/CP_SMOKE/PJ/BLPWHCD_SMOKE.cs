 
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
    public class BLPWHCD_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Assign Billing Withholding Codes", "xpath","//div[@class='navItem'][.='Assign Billing Withholding Codes']").Click();


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
				Function.CurrentComponent = "BLPWHCD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLPWHCD] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl BLPWHCD_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,BLPWHCD_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLPWHCD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLPWHCD] Performing VerifyExists on ParameterID...", Logger.MessageType.INF);
				SeleniumControl BLPWHCD_ParameterID = new SeleniumControl( sDriver, "ParameterID", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PARM_ID']");
				Function.AssertEqual(true,BLPWHCD_ParameterID.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("BILLING PROJECT NON CONTIGUOUS RANGES");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLPWHCD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLPWHCD] Performing VerifyExists on BillingProjectNonContiguousRangesLink...", Logger.MessageType.INF);
				SeleniumControl BLPWHCD_BillingProjectNonContiguousRangesLink = new SeleniumControl( sDriver, "BillingProjectNonContiguousRangesLink", "ID", "lnk_16037_BLPWHCD_PARAM");
				Function.AssertEqual(true,BLPWHCD_BillingProjectNonContiguousRangesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLPWHCD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLPWHCD] Performing Click on BillingProjectNonContiguousRangesLink...", Logger.MessageType.INF);
				SeleniumControl BLPWHCD_BillingProjectNonContiguousRangesLink = new SeleniumControl( sDriver, "BillingProjectNonContiguousRangesLink", "ID", "lnk_16037_BLPWHCD_PARAM");
				Function.WaitControlDisplayed(BLPWHCD_BillingProjectNonContiguousRangesLink);
BLPWHCD_BillingProjectNonContiguousRangesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLPWHCD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLPWHCD] Performing VerifyExist on BillingProjectNonContiguousRangesFormTable...", Logger.MessageType.INF);
				SeleniumControl BLPWHCD_BillingProjectNonContiguousRangesFormTable = new SeleniumControl( sDriver, "BillingProjectNonContiguousRangesFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__BLPWHCD_NCR_PROJ_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BLPWHCD_BillingProjectNonContiguousRangesFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLPWHCD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLPWHCD] Performing VerifyExists on BillingProjectNonContiguousRangesForm...", Logger.MessageType.INF);
				SeleniumControl BLPWHCD_BillingProjectNonContiguousRangesForm = new SeleniumControl( sDriver, "BillingProjectNonContiguousRangesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BLPWHCD_NCR_PROJ_']/ancestor::form[1]");
				Function.AssertEqual(true,BLPWHCD_BillingProjectNonContiguousRangesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLPWHCD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLPWHCD] Performing VerifyExists on BillingProjectNonContiguousRanges_Ok...", Logger.MessageType.INF);
				SeleniumControl BLPWHCD_BillingProjectNonContiguousRanges_Ok = new SeleniumControl( sDriver, "BillingProjectNonContiguousRanges_Ok", "xpath", "//div[translate(@id,'0123456789','')='pr__BLPWHCD_NCR_PROJ_']/ancestor::form[1]/following-sibling::div[1]/descendant::*[@id='bOk']");
				Function.AssertEqual(true,BLPWHCD_BillingProjectNonContiguousRanges_Ok.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLPWHCD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLPWHCD] Performing Close on BillingProjectNonContiguousRangesForm...", Logger.MessageType.INF);
				SeleniumControl BLPWHCD_BillingProjectNonContiguousRangesForm = new SeleniumControl( sDriver, "BillingProjectNonContiguousRangesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BLPWHCD_NCR_PROJ_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BLPWHCD_BillingProjectNonContiguousRangesForm);
IWebElement formBttn = BLPWHCD_BillingProjectNonContiguousRangesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("CUSTOMER NON CONTIGUOUS RANGES");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLPWHCD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLPWHCD] Performing VerifyExists on CustomerNonContiguousRangesLink...", Logger.MessageType.INF);
				SeleniumControl BLPWHCD_CustomerNonContiguousRangesLink = new SeleniumControl( sDriver, "CustomerNonContiguousRangesLink", "ID", "lnk_16038_BLPWHCD_PARAM");
				Function.AssertEqual(true,BLPWHCD_CustomerNonContiguousRangesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLPWHCD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLPWHCD] Performing Click on CustomerNonContiguousRangesLink...", Logger.MessageType.INF);
				SeleniumControl BLPWHCD_CustomerNonContiguousRangesLink = new SeleniumControl( sDriver, "CustomerNonContiguousRangesLink", "ID", "lnk_16038_BLPWHCD_PARAM");
				Function.WaitControlDisplayed(BLPWHCD_CustomerNonContiguousRangesLink);
BLPWHCD_CustomerNonContiguousRangesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLPWHCD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLPWHCD] Performing VerifyExist on CustomerNonContiguousRangesFormTable...", Logger.MessageType.INF);
				SeleniumControl BLPWHCD_CustomerNonContiguousRangesFormTable = new SeleniumControl( sDriver, "CustomerNonContiguousRangesFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__BLPWHCD_NCR_CUST_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BLPWHCD_CustomerNonContiguousRangesFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLPWHCD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLPWHCD] Performing VerifyExists on CustomerNonContiguousRangesForm...", Logger.MessageType.INF);
				SeleniumControl BLPWHCD_CustomerNonContiguousRangesForm = new SeleniumControl( sDriver, "CustomerNonContiguousRangesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BLPWHCD_NCR_CUST_']/ancestor::form[1]");
				Function.AssertEqual(true,BLPWHCD_CustomerNonContiguousRangesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLPWHCD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLPWHCD] Performing VerifyExists on CustomerNonContiguousRanges_Ok...", Logger.MessageType.INF);
				SeleniumControl BLPWHCD_CustomerNonContiguousRanges_Ok = new SeleniumControl( sDriver, "CustomerNonContiguousRanges_Ok", "xpath", "//div[translate(@id,'0123456789','')='pr__BLPWHCD_NCR_CUST_']/ancestor::form[1]/following-sibling::div[1]/descendant::*[@id='bOk']");
				Function.AssertEqual(true,BLPWHCD_CustomerNonContiguousRanges_Ok.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLPWHCD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLPWHCD] Performing Close on CustomerNonContiguousRangesForm...", Logger.MessageType.INF);
				SeleniumControl BLPWHCD_CustomerNonContiguousRangesForm = new SeleniumControl( sDriver, "CustomerNonContiguousRangesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BLPWHCD_NCR_CUST_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BLPWHCD_CustomerNonContiguousRangesForm);
IWebElement formBttn = BLPWHCD_CustomerNonContiguousRangesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("PROJECT TYPE NON CONTIGUOUS RANGES");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLPWHCD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLPWHCD] Performing VerifyExists on ProjectTypeNonContiguousRangesLink...", Logger.MessageType.INF);
				SeleniumControl BLPWHCD_ProjectTypeNonContiguousRangesLink = new SeleniumControl( sDriver, "ProjectTypeNonContiguousRangesLink", "ID", "lnk_16039_BLPWHCD_PARAM");
				Function.AssertEqual(true,BLPWHCD_ProjectTypeNonContiguousRangesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLPWHCD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLPWHCD] Performing Click on ProjectTypeNonContiguousRangesLink...", Logger.MessageType.INF);
				SeleniumControl BLPWHCD_ProjectTypeNonContiguousRangesLink = new SeleniumControl( sDriver, "ProjectTypeNonContiguousRangesLink", "ID", "lnk_16039_BLPWHCD_PARAM");
				Function.WaitControlDisplayed(BLPWHCD_ProjectTypeNonContiguousRangesLink);
BLPWHCD_ProjectTypeNonContiguousRangesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLPWHCD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLPWHCD] Performing VerifyExist on ProjectTypeNonContiguousRangesFormTable...", Logger.MessageType.INF);
				SeleniumControl BLPWHCD_ProjectTypeNonContiguousRangesFormTable = new SeleniumControl( sDriver, "ProjectTypeNonContiguousRangesFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__BLPWHCD_NCR_PROJTYPEDC_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BLPWHCD_ProjectTypeNonContiguousRangesFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLPWHCD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLPWHCD] Performing VerifyExists on ProjectTypeNonContiguousRangesForm...", Logger.MessageType.INF);
				SeleniumControl BLPWHCD_ProjectTypeNonContiguousRangesForm = new SeleniumControl( sDriver, "ProjectTypeNonContiguousRangesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BLPWHCD_NCR_PROJTYPEDC_']/ancestor::form[1]");
				Function.AssertEqual(true,BLPWHCD_ProjectTypeNonContiguousRangesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLPWHCD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLPWHCD] Performing VerifyExists on ProjectTypeNonContiguousRanges_Ok...", Logger.MessageType.INF);
				SeleniumControl BLPWHCD_ProjectTypeNonContiguousRanges_Ok = new SeleniumControl( sDriver, "ProjectTypeNonContiguousRanges_Ok", "xpath", "//div[translate(@id,'0123456789','')='pr__BLPWHCD_NCR_PROJTYPEDC_']/ancestor::form[1]/following-sibling::div[1]/descendant::*[@id='bOk']");
				Function.AssertEqual(true,BLPWHCD_ProjectTypeNonContiguousRanges_Ok.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLPWHCD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLPWHCD] Performing Close on ProjectTypeNonContiguousRangesForm...", Logger.MessageType.INF);
				SeleniumControl BLPWHCD_ProjectTypeNonContiguousRangesForm = new SeleniumControl( sDriver, "ProjectTypeNonContiguousRangesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BLPWHCD_NCR_PROJTYPEDC_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BLPWHCD_ProjectTypeNonContiguousRangesForm);
IWebElement formBttn = BLPWHCD_ProjectTypeNonContiguousRangesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("BILLING USER GROUP NON CONTIGUOUS RANGES");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLPWHCD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLPWHCD] Performing VerifyExists on BillingUserGroupNonContiguousRangesLink...", Logger.MessageType.INF);
				SeleniumControl BLPWHCD_BillingUserGroupNonContiguousRangesLink = new SeleniumControl( sDriver, "BillingUserGroupNonContiguousRangesLink", "ID", "lnk_16044_BLPWHCD_PARAM");
				Function.AssertEqual(true,BLPWHCD_BillingUserGroupNonContiguousRangesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLPWHCD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLPWHCD] Performing Click on BillingUserGroupNonContiguousRangesLink...", Logger.MessageType.INF);
				SeleniumControl BLPWHCD_BillingUserGroupNonContiguousRangesLink = new SeleniumControl( sDriver, "BillingUserGroupNonContiguousRangesLink", "ID", "lnk_16044_BLPWHCD_PARAM");
				Function.WaitControlDisplayed(BLPWHCD_BillingUserGroupNonContiguousRangesLink);
BLPWHCD_BillingUserGroupNonContiguousRangesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLPWHCD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLPWHCD] Performing VerifyExist on BillingUserGroupNonContiguousRangesFormTable...", Logger.MessageType.INF);
				SeleniumControl BLPWHCD_BillingUserGroupNonContiguousRangesFormTable = new SeleniumControl( sDriver, "BillingUserGroupNonContiguousRangesFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__BLPWHCD_NCR_BILL_USER_GRP_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BLPWHCD_BillingUserGroupNonContiguousRangesFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLPWHCD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLPWHCD] Performing VerifyExists on BillingUserGroupNonContiguousRangesForm...", Logger.MessageType.INF);
				SeleniumControl BLPWHCD_BillingUserGroupNonContiguousRangesForm = new SeleniumControl( sDriver, "BillingUserGroupNonContiguousRangesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BLPWHCD_NCR_BILL_USER_GRP_']/ancestor::form[1]");
				Function.AssertEqual(true,BLPWHCD_BillingUserGroupNonContiguousRangesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLPWHCD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLPWHCD] Performing VerifyExists on BillingUserGroupNonContiguousRanges_Ok...", Logger.MessageType.INF);
				SeleniumControl BLPWHCD_BillingUserGroupNonContiguousRanges_Ok = new SeleniumControl( sDriver, "BillingUserGroupNonContiguousRanges_Ok", "xpath", "//div[translate(@id,'0123456789','')='pr__BLPWHCD_NCR_BILL_USER_GRP_']/ancestor::form[1]/following-sibling::div[1]/descendant::*[@id='bOk']");
				Function.AssertEqual(true,BLPWHCD_BillingUserGroupNonContiguousRanges_Ok.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLPWHCD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLPWHCD] Performing Close on BillingUserGroupNonContiguousRangesForm...", Logger.MessageType.INF);
				SeleniumControl BLPWHCD_BillingUserGroupNonContiguousRangesForm = new SeleniumControl( sDriver, "BillingUserGroupNonContiguousRangesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BLPWHCD_NCR_BILL_USER_GRP_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BLPWHCD_BillingUserGroupNonContiguousRangesForm);
IWebElement formBttn = BLPWHCD_BillingUserGroupNonContiguousRangesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("BILLING FORMULA NON CONTIGUOUS RANGES");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLPWHCD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLPWHCD] Performing VerifyExists on BillingFormulaNonContiguousRangesLink...", Logger.MessageType.INF);
				SeleniumControl BLPWHCD_BillingFormulaNonContiguousRangesLink = new SeleniumControl( sDriver, "BillingFormulaNonContiguousRangesLink", "ID", "lnk_16045_BLPWHCD_PARAM");
				Function.AssertEqual(true,BLPWHCD_BillingFormulaNonContiguousRangesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLPWHCD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLPWHCD] Performing Click on BillingFormulaNonContiguousRangesLink...", Logger.MessageType.INF);
				SeleniumControl BLPWHCD_BillingFormulaNonContiguousRangesLink = new SeleniumControl( sDriver, "BillingFormulaNonContiguousRangesLink", "ID", "lnk_16045_BLPWHCD_PARAM");
				Function.WaitControlDisplayed(BLPWHCD_BillingFormulaNonContiguousRangesLink);
BLPWHCD_BillingFormulaNonContiguousRangesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLPWHCD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLPWHCD] Performing VerifyExist on BillingFormulaNonContiguousRangesFormTable...", Logger.MessageType.INF);
				SeleniumControl BLPWHCD_BillingFormulaNonContiguousRangesFormTable = new SeleniumControl( sDriver, "BillingFormulaNonContiguousRangesFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__BLPWHCD_NCR_BILLFRMLADESC_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BLPWHCD_BillingFormulaNonContiguousRangesFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLPWHCD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLPWHCD] Performing VerifyExists on BillingFormulaNonContiguousRangesForm...", Logger.MessageType.INF);
				SeleniumControl BLPWHCD_BillingFormulaNonContiguousRangesForm = new SeleniumControl( sDriver, "BillingFormulaNonContiguousRangesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BLPWHCD_NCR_BILLFRMLADESC_']/ancestor::form[1]");
				Function.AssertEqual(true,BLPWHCD_BillingFormulaNonContiguousRangesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLPWHCD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLPWHCD] Performing VerifyExists on BillingFormulaNonContiguousRanges_Ok...", Logger.MessageType.INF);
				SeleniumControl BLPWHCD_BillingFormulaNonContiguousRanges_Ok = new SeleniumControl( sDriver, "BillingFormulaNonContiguousRanges_Ok", "xpath", "//div[translate(@id,'0123456789','')='pr__BLPWHCD_NCR_BILLFRMLADESC_']/ancestor::form[1]/following-sibling::div[1]/descendant::*[@id='bOk']");
				Function.AssertEqual(true,BLPWHCD_BillingFormulaNonContiguousRanges_Ok.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLPWHCD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLPWHCD] Performing Close on BillingFormulaNonContiguousRangesForm...", Logger.MessageType.INF);
				SeleniumControl BLPWHCD_BillingFormulaNonContiguousRangesForm = new SeleniumControl( sDriver, "BillingFormulaNonContiguousRangesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BLPWHCD_NCR_BILLFRMLADESC_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BLPWHCD_BillingFormulaNonContiguousRangesForm);
IWebElement formBttn = BLPWHCD_BillingFormulaNonContiguousRangesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "CP7Main";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[CP7Main] Performing ClickToolbarButton on MainToolBar...", Logger.MessageType.INF);
				SeleniumControl CP7Main_MainToolBar = new SeleniumControl( sDriver, "MainToolBar", "ID", "tlbr");
				Function.WaitControlDisplayed(CP7Main_MainToolBar);
IWebElement tlbrBtn = CP7Main_MainToolBar.mElement.FindElements(By.XPath(".//*[@class='tbBtnContainer']//div[contains(@title,'Save')]")).FirstOrDefault();
if (tlbrBtn==null) throw new Exception("Unable to find button Save.");
tlbrBtn.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickToolbarButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLPWHCD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLPWHCD] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl BLPWHCD_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(BLPWHCD_MainForm);
IWebElement formBttn = BLPWHCD_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

