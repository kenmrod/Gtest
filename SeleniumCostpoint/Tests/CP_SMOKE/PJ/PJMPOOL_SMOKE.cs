 
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
    public class PJMPOOL_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Cost and Revenue Processing", "xpath","//div[@class='deptItem'][.='Cost and Revenue Processing']").Click();
new SeleniumControl(sDriver,"Cost Pools", "xpath","//div[@class='navItem'][.='Cost Pools']").Click();
new SeleniumControl(sDriver,"Manage Cost Pools", "xpath","//div[@class='navItem'][.='Manage Cost Pools']").Click();


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
				Function.CurrentComponent = "PJMPOOL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPOOL] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl PJMPOOL_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,PJMPOOL_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPOOL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPOOL] Performing VerifyExists on AllocationGroup...", Logger.MessageType.INF);
				SeleniumControl PJMPOOL_AllocationGroup = new SeleniumControl( sDriver, "AllocationGroup", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='ALLOC_GRP_NO']");
				Function.AssertEqual(true,PJMPOOL_AllocationGroup.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("TAB");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPOOL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPOOL] Performing VerifyExists on PoolType...", Logger.MessageType.INF);
				SeleniumControl PJMPOOL_PoolType = new SeleniumControl( sDriver, "PoolType", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='POOL_TYPE_DESC']");
				Function.AssertEqual(true,PJMPOOL_PoolType.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("LINK");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPOOL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPOOL] Performing VerifyExists on PoolCostLink...", Logger.MessageType.INF);
				SeleniumControl PJMPOOL_PoolCostLink = new SeleniumControl( sDriver, "PoolCostLink", "ID", "lnk_1002408_PJMPOOL_POOLALLOC_HDR");
				Function.AssertEqual(true,PJMPOOL_PoolCostLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPOOL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPOOL] Performing Click on PoolCostLink...", Logger.MessageType.INF);
				SeleniumControl PJMPOOL_PoolCostLink = new SeleniumControl( sDriver, "PoolCostLink", "ID", "lnk_1002408_PJMPOOL_POOLALLOC_HDR");
				Function.WaitControlDisplayed(PJMPOOL_PoolCostLink);
PJMPOOL_PoolCostLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPOOL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPOOL] Performing VerifyExist on PoolCostLinkTable...", Logger.MessageType.INF);
				SeleniumControl PJMPOOL_PoolCostLinkTable = new SeleniumControl( sDriver, "PoolCostLinkTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMPOOL_POOLCOSTACCT_CHILD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJMPOOL_PoolCostLinkTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPOOL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPOOL] Performing VerifyExist on PoolCost_AvailableAccountLinkTable...", Logger.MessageType.INF);
				SeleniumControl PJMPOOL_PoolCost_AvailableAccountLinkTable = new SeleniumControl( sDriver, "PoolCost_AvailableAccountLinkTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMPOOL_ORGACCT_CHILD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJMPOOL_PoolCost_AvailableAccountLinkTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPOOL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPOOL] Performing Close on PoolCostForm...", Logger.MessageType.INF);
				SeleniumControl PJMPOOL_PoolCostForm = new SeleniumControl( sDriver, "PoolCostForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMPOOL_POOLCOSTACCT_CHILD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJMPOOL_PoolCostForm);
IWebElement formBttn = PJMPOOL_PoolCostForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPOOL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPOOL] Performing VerifyExists on PoolBaseLink...", Logger.MessageType.INF);
				SeleniumControl PJMPOOL_PoolBaseLink = new SeleniumControl( sDriver, "PoolBaseLink", "ID", "lnk_1002409_PJMPOOL_POOLALLOC_HDR");
				Function.AssertEqual(true,PJMPOOL_PoolBaseLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPOOL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPOOL] Performing Click on PoolBaseLink...", Logger.MessageType.INF);
				SeleniumControl PJMPOOL_PoolBaseLink = new SeleniumControl( sDriver, "PoolBaseLink", "ID", "lnk_1002409_PJMPOOL_POOLALLOC_HDR");
				Function.WaitControlDisplayed(PJMPOOL_PoolBaseLink);
PJMPOOL_PoolBaseLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPOOL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPOOL] Performing VerifyExist on PoolBaseLinkTable...", Logger.MessageType.INF);
				SeleniumControl PJMPOOL_PoolBaseLinkTable = new SeleniumControl( sDriver, "PoolBaseLinkTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMPOOL_POOLBASEACCT_POOLBASE_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJMPOOL_PoolBaseLinkTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPOOL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPOOL] Performing VerifyExist on PoolBase_AvailableAccountLinkTable...", Logger.MessageType.INF);
				SeleniumControl PJMPOOL_PoolBase_AvailableAccountLinkTable = new SeleniumControl( sDriver, "PoolBase_AvailableAccountLinkTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMPOOL_POOLBASEACCT_ORGACCT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJMPOOL_PoolBase_AvailableAccountLinkTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPOOL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPOOL] Performing Close on PoolBaseForm...", Logger.MessageType.INF);
				SeleniumControl PJMPOOL_PoolBaseForm = new SeleniumControl( sDriver, "PoolBaseForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMPOOL_POOLBASEACCT_POOLBASE_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJMPOOL_PoolBaseForm);
IWebElement formBttn = PJMPOOL_PoolBaseForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPOOL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPOOL] Performing VerifyExists on ServiceCenterLink...", Logger.MessageType.INF);
				SeleniumControl PJMPOOL_ServiceCenterLink = new SeleniumControl( sDriver, "ServiceCenterLink", "ID", "lnk_1002411_PJMPOOL_POOLALLOC_HDR");
				Function.AssertEqual(true,PJMPOOL_ServiceCenterLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPOOL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPOOL] Performing Click on ServiceCenterLink...", Logger.MessageType.INF);
				SeleniumControl PJMPOOL_ServiceCenterLink = new SeleniumControl( sDriver, "ServiceCenterLink", "ID", "lnk_1002411_PJMPOOL_POOLALLOC_HDR");
				Function.WaitControlDisplayed(PJMPOOL_ServiceCenterLink);
PJMPOOL_ServiceCenterLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPOOL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPOOL] Performing VerifyExists on ServiceCenterForm...", Logger.MessageType.INF);
				SeleniumControl PJMPOOL_ServiceCenterForm = new SeleniumControl( sDriver, "ServiceCenterForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMPOOL_SVCTRINFO_SERVICECENTR_']/ancestor::form[1]");
				Function.AssertEqual(true,PJMPOOL_ServiceCenterForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPOOL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPOOL] Performing VerifyExists on ServiceCenter_StandardCost_StandardUnit...", Logger.MessageType.INF);
				SeleniumControl PJMPOOL_ServiceCenter_StandardCost_StandardUnit = new SeleniumControl( sDriver, "ServiceCenter_StandardCost_StandardUnit", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMPOOL_SVCTRINFO_SERVICECENTR_']/ancestor::form[1]/descendant::*[@id='UNIT_CST_AMT']");
				Function.AssertEqual(true,PJMPOOL_ServiceCenter_StandardCost_StandardUnit.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPOOL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPOOL] Performing Close on ServiceCenterForm...", Logger.MessageType.INF);
				SeleniumControl PJMPOOL_ServiceCenterForm = new SeleniumControl( sDriver, "ServiceCenterForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMPOOL_SVCTRINFO_SERVICECENTR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJMPOOL_ServiceCenterForm);
IWebElement formBttn = PJMPOOL_ServiceCenterForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPOOL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPOOL] Performing VerifyExists on PoolRatesLink...", Logger.MessageType.INF);
				SeleniumControl PJMPOOL_PoolRatesLink = new SeleniumControl( sDriver, "PoolRatesLink", "ID", "lnk_1002412_PJMPOOL_POOLALLOC_HDR");
				Function.AssertEqual(true,PJMPOOL_PoolRatesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPOOL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPOOL] Performing Click on PoolRatesLink...", Logger.MessageType.INF);
				SeleniumControl PJMPOOL_PoolRatesLink = new SeleniumControl( sDriver, "PoolRatesLink", "ID", "lnk_1002412_PJMPOOL_POOLALLOC_HDR");
				Function.WaitControlDisplayed(PJMPOOL_PoolRatesLink);
PJMPOOL_PoolRatesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPOOL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPOOL] Performing VerifyExist on PoolRatesTable...", Logger.MessageType.INF);
				SeleniumControl PJMPOOL_PoolRatesTable = new SeleniumControl( sDriver, "PoolRatesTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMPOOL_POOLRTTABLE_CHILD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJMPOOL_PoolRatesTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPOOL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPOOL] Performing ClickButton on PoolRatesForm...", Logger.MessageType.INF);
				SeleniumControl PJMPOOL_PoolRatesForm = new SeleniumControl( sDriver, "PoolRatesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMPOOL_POOLRTTABLE_CHILD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJMPOOL_PoolRatesForm);
IWebElement formBttn = PJMPOOL_PoolRatesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PJMPOOL_PoolRatesForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PJMPOOL_PoolRatesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPOOL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPOOL] Performing VerifyExists on PoolRatesForm...", Logger.MessageType.INF);
				SeleniumControl PJMPOOL_PoolRatesForm = new SeleniumControl( sDriver, "PoolRatesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMPOOL_POOLRTTABLE_CHILD_']/ancestor::form[1]");
				Function.AssertEqual(true,PJMPOOL_PoolRatesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
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
				Function.CurrentComponent = "PJMPOOL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPOOL] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl PJMPOOL_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PJMPOOL_MainForm);
IWebElement formBttn = PJMPOOL_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

