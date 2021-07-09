 
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
    public class INMWHSE_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Inventory", "xpath","//div[@class='deptItem'][.='Inventory']").Click();
new SeleniumControl(sDriver,"Inventory Controls", "xpath","//div[@class='navItem'][.='Inventory Controls']").Click();
new SeleniumControl(sDriver,"Manage Warehouses", "xpath","//div[@class='navItem'][.='Manage Warehouses']").Click();


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
				Function.CurrentComponent = "INMWHSE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMWHSE] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl INMWHSE_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,INMWHSE_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMWHSE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMWHSE] Performing VerifyExists on Identification_WAREHOUSEMID...", Logger.MessageType.INF);
				SeleniumControl INMWHSE_Identification_WAREHOUSEMID = new SeleniumControl( sDriver, "Identification_WAREHOUSEMID", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='WHSE_ID']");
				Function.AssertEqual(true,INMWHSE_Identification_WAREHOUSEMID.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMWHSE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMWHSE] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl INMWHSE_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(INMWHSE_MainForm);
IWebElement formBttn = INMWHSE_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? INMWHSE_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
INMWHSE_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMWHSE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMWHSE] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl INMWHSE_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,INMWHSE_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Transaction IDs");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMWHSE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMWHSE] Performing VerifyExists on Identification_TransactionIDsLink...", Logger.MessageType.INF);
				SeleniumControl INMWHSE_Identification_TransactionIDsLink = new SeleniumControl( sDriver, "Identification_TransactionIDsLink", "ID", "lnk_1002203_INMWHSE_WHSE_WAREHOUSES");
				Function.AssertEqual(true,INMWHSE_Identification_TransactionIDsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMWHSE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMWHSE] Performing Click on Identification_TransactionIDsLink...", Logger.MessageType.INF);
				SeleniumControl INMWHSE_Identification_TransactionIDsLink = new SeleniumControl( sDriver, "Identification_TransactionIDsLink", "ID", "lnk_1002203_INMWHSE_WHSE_WAREHOUSES");
				Function.WaitControlDisplayed(INMWHSE_Identification_TransactionIDsLink);
INMWHSE_Identification_TransactionIDsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMWHSE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMWHSE] Performing VerifyExist on LeftTransactionIDTable...", Logger.MessageType.INF);
				SeleniumControl INMWHSE_LeftTransactionIDTable = new SeleniumControl( sDriver, "LeftTransactionIDTable", "xpath", "//div[translate(@id,'0123456789','')='pr__INMWHSE_SINVTTRNTYPE_TRANSID_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,INMWHSE_LeftTransactionIDTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMWHSE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMWHSE] Performing VerifyExists on LeftTransactionIDForm...", Logger.MessageType.INF);
				SeleniumControl INMWHSE_LeftTransactionIDForm = new SeleniumControl( sDriver, "LeftTransactionIDForm", "xpath", "//div[translate(@id,'0123456789','')='pr__INMWHSE_SINVTTRNTYPE_TRANSID_']/ancestor::form[1]");
				Function.AssertEqual(true,INMWHSE_LeftTransactionIDForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMWHSE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMWHSE] Performing VerifyExist on RightTransactionIDTable...", Logger.MessageType.INF);
				SeleniumControl INMWHSE_RightTransactionIDTable = new SeleniumControl( sDriver, "RightTransactionIDTable", "xpath", "//div[translate(@id,'0123456789','')='pr__INMWHSE_WHSELASTTRANS_SELTRANS_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,INMWHSE_RightTransactionIDTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMWHSE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMWHSE] Performing VerifyExists on RightTransactionIDForm...", Logger.MessageType.INF);
				SeleniumControl INMWHSE_RightTransactionIDForm = new SeleniumControl( sDriver, "RightTransactionIDForm", "xpath", "//div[translate(@id,'0123456789','')='pr__INMWHSE_WHSELASTTRANS_SELTRANS_']/ancestor::form[1]");
				Function.AssertEqual(true,INMWHSE_RightTransactionIDForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMWHSE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMWHSE] Performing Close on RightTransactionIDForm...", Logger.MessageType.INF);
				SeleniumControl INMWHSE_RightTransactionIDForm = new SeleniumControl( sDriver, "RightTransactionIDForm", "xpath", "//div[translate(@id,'0123456789','')='pr__INMWHSE_WHSELASTTRANS_SELTRANS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(INMWHSE_RightTransactionIDForm);
IWebElement formBttn = INMWHSE_RightTransactionIDForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Location Structure");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMWHSE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMWHSE] Performing VerifyExists on Identification_LocationStructureLink...", Logger.MessageType.INF);
				SeleniumControl INMWHSE_Identification_LocationStructureLink = new SeleniumControl( sDriver, "Identification_LocationStructureLink", "ID", "lnk_1007598_INMWHSE_WHSE_WAREHOUSES");
				Function.AssertEqual(true,INMWHSE_Identification_LocationStructureLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMWHSE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMWHSE] Performing Click on Identification_LocationStructureLink...", Logger.MessageType.INF);
				SeleniumControl INMWHSE_Identification_LocationStructureLink = new SeleniumControl( sDriver, "Identification_LocationStructureLink", "ID", "lnk_1007598_INMWHSE_WHSE_WAREHOUSES");
				Function.WaitControlDisplayed(INMWHSE_Identification_LocationStructureLink);
INMWHSE_Identification_LocationStructureLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMWHSE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMWHSE] Performing VerifyExist on LocationStructureTable...", Logger.MessageType.INF);
				SeleniumControl INMWHSE_LocationStructureTable = new SeleniumControl( sDriver, "LocationStructureTable", "xpath", "//div[translate(@id,'0123456789','')='pr__INMWHSE_WHSELOCSTRUC_LOCSTRUC_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,INMWHSE_LocationStructureTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMWHSE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMWHSE] Performing VerifyExists on LocationStructureForm...", Logger.MessageType.INF);
				SeleniumControl INMWHSE_LocationStructureForm = new SeleniumControl( sDriver, "LocationStructureForm", "xpath", "//div[translate(@id,'0123456789','')='pr__INMWHSE_WHSELOCSTRUC_LOCSTRUC_']/ancestor::form[1]");
				Function.AssertEqual(true,INMWHSE_LocationStructureForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMWHSE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMWHSE] Performing Close on LocationStructureForm...", Logger.MessageType.INF);
				SeleniumControl INMWHSE_LocationStructureForm = new SeleniumControl( sDriver, "LocationStructureForm", "xpath", "//div[translate(@id,'0123456789','')='pr__INMWHSE_WHSELOCSTRUC_LOCSTRUC_']/ancestor::form[1]");
				Function.WaitControlDisplayed(INMWHSE_LocationStructureForm);
IWebElement formBttn = INMWHSE_LocationStructureForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "INMWHSE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMWHSE] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl INMWHSE_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(INMWHSE_MainForm);
IWebElement formBttn = INMWHSE_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

