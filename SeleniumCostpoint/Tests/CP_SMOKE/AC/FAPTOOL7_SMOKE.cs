 
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
    public class FAPTOOL7_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Fixed Assets Utilities", "xpath","//div[@class='navItem'][.='Fixed Assets Utilities']").Click();
new SeleniumControl(sDriver,"Copy Transfer Data to Asset Audit Log", "xpath","//div[@class='navItem'][.='Copy Transfer Data to Asset Audit Log']").Click();


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
				Function.CurrentComponent = "FAPTOOL7";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAPTOOL7] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl FAPTOOL7_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,FAPTOOL7_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAPTOOL7";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAPTOOL7] Performing VerifyExists on Start_AssetItemNumbers_AssetNo...", Logger.MessageType.INF);
				SeleniumControl FAPTOOL7_Start_AssetItemNumbers_AssetNo = new SeleniumControl( sDriver, "Start_AssetItemNumbers_AssetNo", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='ASSET_NO_FR']");
				Function.AssertEqual(true,FAPTOOL7_Start_AssetItemNumbers_AssetNo.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAPTOOL7";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAPTOOL7] Performing VerifyExists on SelectTransferDataToCopyBasedOnMappingOfDataElementsForm...", Logger.MessageType.INF);
				SeleniumControl FAPTOOL7_SelectTransferDataToCopyBasedOnMappingOfDataElementsForm = new SeleniumControl( sDriver, "SelectTransferDataToCopyBasedOnMappingOfDataElementsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__FAPTOOL_XFERLOG_CHLD_']/ancestor::form[1]");
				Function.AssertEqual(true,FAPTOOL7_SelectTransferDataToCopyBasedOnMappingOfDataElementsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAPTOOL7";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAPTOOL7] Performing VerifyExists on SelectTransferDataToCopyBasedOnMappingOfDataElements_SelectTransferDataColumnContainingTransferDataColumnName...", Logger.MessageType.INF);
				SeleniumControl FAPTOOL7_SelectTransferDataToCopyBasedOnMappingOfDataElements_SelectTransferDataColumnContainingTransferDataColumnName = new SeleniumControl( sDriver, "SelectTransferDataToCopyBasedOnMappingOfDataElements_SelectTransferDataColumnContainingTransferDataColumnName", "xpath", "//div[translate(@id,'0123456789','')='pr__FAPTOOL_XFERLOG_CHLD_']/ancestor::form[1]/descendant::*[@id='MAPPING_DATA']");
				Function.AssertEqual(true,FAPTOOL7_SelectTransferDataToCopyBasedOnMappingOfDataElements_SelectTransferDataColumnContainingTransferDataColumnName.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAPTOOL7";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAPTOOL7] Performing VerifyExists on SelectTransferDataToCopyBasedOnMappingOfDataElements_DataElementsMappingForm...", Logger.MessageType.INF);
				SeleniumControl FAPTOOL7_SelectTransferDataToCopyBasedOnMappingOfDataElements_DataElementsMappingForm = new SeleniumControl( sDriver, "SelectTransferDataToCopyBasedOnMappingOfDataElements_DataElementsMappingForm", "xpath", "//div[translate(@id,'0123456789','')='pr__FAPTOOL_XFERLOG_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,FAPTOOL7_SelectTransferDataToCopyBasedOnMappingOfDataElements_DataElementsMappingForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAPTOOL7";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAPTOOL7] Performing VerifyExist on SelectTransferDataToCopyBasedOnMappingOfDataElements_DataElementsMappingFormTable...", Logger.MessageType.INF);
				SeleniumControl FAPTOOL7_SelectTransferDataToCopyBasedOnMappingOfDataElements_DataElementsMappingFormTable = new SeleniumControl( sDriver, "SelectTransferDataToCopyBasedOnMappingOfDataElements_DataElementsMappingFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__FAPTOOL_XFERLOG_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,FAPTOOL7_SelectTransferDataToCopyBasedOnMappingOfDataElements_DataElementsMappingFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Close App");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAPTOOL7";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAPTOOL7] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl FAPTOOL7_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(FAPTOOL7_MainForm);
IWebElement formBttn = FAPTOOL7_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

