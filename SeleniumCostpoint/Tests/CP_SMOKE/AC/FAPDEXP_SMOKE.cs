 
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
    public class FAPDEXP_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Fixed Assets", "xpath","//div[@class='deptItem'][.='Fixed Assets']").Click();
new SeleniumControl(sDriver,"Fixed Assets Interfaces", "xpath","//div[@class='navItem'][.='Fixed Assets Interfaces']").Click();
new SeleniumControl(sDriver,"Export Asset Disposals", "xpath","//div[@class='navItem'][.='Export Asset Disposals']").Click();


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
				Function.CurrentComponent = "FAPDEXP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAPDEXP] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl FAPDEXP_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,FAPDEXP_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAPDEXP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAPDEXP] Performing VerifyExists on ParameterID...", Logger.MessageType.INF);
				SeleniumControl FAPDEXP_ParameterID = new SeleniumControl( sDriver, "ParameterID", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PARM_ID']");
				Function.AssertEqual(true,FAPDEXP_ParameterID.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAPDEXP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAPDEXP] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl FAPDEXP_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(FAPDEXP_MainForm);
IWebElement formBttn = FAPDEXP_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? FAPDEXP_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
FAPDEXP_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAPDEXP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAPDEXP] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl FAPDEXP_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,FAPDEXP_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAPDEXP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAPDEXP] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl FAPDEXP_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(FAPDEXP_MainForm);
IWebElement formBttn = FAPDEXP_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? FAPDEXP_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
FAPDEXP_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAPDEXP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAPDEXP] Performing VerifyExists on AssetItemNumberNonContiguousLink...", Logger.MessageType.INF);
				SeleniumControl FAPDEXP_AssetItemNumberNonContiguousLink = new SeleniumControl( sDriver, "AssetItemNumberNonContiguousLink", "ID", "lnk_5606_FAPDEXP_PARAM");
				Function.AssertEqual(true,FAPDEXP_AssetItemNumberNonContiguousLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAPDEXP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAPDEXP] Performing VerifyExists on AssetMasterAndDisposalDataRecordsLink...", Logger.MessageType.INF);
				SeleniumControl FAPDEXP_AssetMasterAndDisposalDataRecordsLink = new SeleniumControl( sDriver, "AssetMasterAndDisposalDataRecordsLink", "ID", "lnk_5574_FAPDEXP_PARAM");
				Function.AssertEqual(true,FAPDEXP_AssetMasterAndDisposalDataRecordsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Asset/Item Number Non-Contiguous");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAPDEXP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAPDEXP] Performing VerifyExists on AssetItemNumberNonContiguousForm...", Logger.MessageType.INF);
				SeleniumControl FAPDEXP_AssetItemNumberNonContiguousForm = new SeleniumControl( sDriver, "AssetItemNumberNonContiguousForm", "xpath", "//div[translate(@id,'0123456789','')='pr__FAPDEXP_NCR_ASSETID_ITEMNO_']/ancestor::form[1]");
				Function.AssertEqual(true,FAPDEXP_AssetItemNumberNonContiguousForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAPDEXP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAPDEXP] Performing VerifyExist on AssetItemNumberNonContiguousFormTable...", Logger.MessageType.INF);
				SeleniumControl FAPDEXP_AssetItemNumberNonContiguousFormTable = new SeleniumControl( sDriver, "AssetItemNumberNonContiguousFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__FAPDEXP_NCR_ASSETID_ITEMNO_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,FAPDEXP_AssetItemNumberNonContiguousFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Asset Master and Disposal Data Records");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAPDEXP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAPDEXP] Performing VerifyExists on AssetMasterAndDisposalDataRecordsForm...", Logger.MessageType.INF);
				SeleniumControl FAPDEXP_AssetMasterAndDisposalDataRecordsForm = new SeleniumControl( sDriver, "AssetMasterAndDisposalDataRecordsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__FAPDEXP_LN_']/ancestor::form[1]");
				Function.AssertEqual(true,FAPDEXP_AssetMasterAndDisposalDataRecordsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAPDEXP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAPDEXP] Performing VerifyExist on AssetMasterAndDisposalDataRecordsFormTable...", Logger.MessageType.INF);
				SeleniumControl FAPDEXP_AssetMasterAndDisposalDataRecordsFormTable = new SeleniumControl( sDriver, "AssetMasterAndDisposalDataRecordsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__FAPDEXP_LN_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,FAPDEXP_AssetMasterAndDisposalDataRecordsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAPDEXP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAPDEXP] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl FAPDEXP_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(FAPDEXP_MainForm);
IWebElement formBttn = FAPDEXP_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

