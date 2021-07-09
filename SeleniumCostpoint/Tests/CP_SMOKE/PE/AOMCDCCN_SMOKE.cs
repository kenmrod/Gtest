 
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
    public class AOMCDCCN_SMOKE : SeleniumTestScript
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
								try
				{
				this.ScriptLogger.WriteLine("START");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "CP7Main";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[CP7Main] Performing SelectMenu on NavMenu...", Logger.MessageType.INF);
				SeleniumControl CP7Main_NavMenu = new SeleniumControl( sDriver, "NavMenu", "ID", "navCont");
				if(!sDriver.Instance.FindElement(By.CssSelector("div[class='navCont']")).Displayed) new SeleniumControl(sDriver,"Browse", "css", "span[id = 'goToLbl']").Click();
new SeleniumControl(sDriver,"People", "xpath","//div[@class='busItem'][.='People']").Click();
new SeleniumControl(sDriver,"Labor", "xpath","//div[@class='deptItem'][.='Labor']").Click();
new SeleniumControl(sDriver,"Ceridian Interface", "xpath","//div[@class='navItem'][.='Ceridian Interface']").Click();
new SeleniumControl(sDriver,"Manage Ceridian Configuration", "xpath","//div[@class='navItem'][.='Manage Ceridian Configuration']").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SelectMenu]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "AOMCDCCN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMCDCCN] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl AOMCDCCN_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,AOMCDCCN_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "AOMCDCCN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMCDCCN] Performing VerifyExists on CeridianCompanyID...", Logger.MessageType.INF);
				SeleniumControl AOMCDCCN_CeridianCompanyID = new SeleniumControl( sDriver, "CeridianCompanyID", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='CDN_CO_ID']");
				Function.AssertEqual(true,AOMCDCCN_CeridianCompanyID.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "AOMCDCCN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMCDCCN] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl AOMCDCCN_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(AOMCDCCN_MainForm);
IWebElement formBttn = AOMCDCCN_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? AOMCDCCN_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
AOMCDCCN_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "AOMCDCCN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMCDCCN] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl AOMCDCCN_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,AOMCDCCN_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "AOMCDCCN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMCDCCN] Performing VerifyExists on CeridianIDFormatForm...", Logger.MessageType.INF);
				SeleniumControl AOMCDCCN_CeridianIDFormatForm = new SeleniumControl( sDriver, "CeridianIDFormatForm", "xpath", "//div[translate(@id,'0123456789','')='pr__AOMCDCCN_XCDCIDFORMAT_CHILD_']/ancestor::form[1]");
				Function.AssertEqual(true,AOMCDCCN_CeridianIDFormatForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "AOMCDCCN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMCDCCN] Performing VerifyExist on CeridianIDFormatFormTable...", Logger.MessageType.INF);
				SeleniumControl AOMCDCCN_CeridianIDFormatFormTable = new SeleniumControl( sDriver, "CeridianIDFormatFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__AOMCDCCN_XCDCIDFORMAT_CHILD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,AOMCDCCN_CeridianIDFormatFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "AOMCDCCN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMCDCCN] Performing ClickButton on CeridianIDFormatForm...", Logger.MessageType.INF);
				SeleniumControl AOMCDCCN_CeridianIDFormatForm = new SeleniumControl( sDriver, "CeridianIDFormatForm", "xpath", "//div[translate(@id,'0123456789','')='pr__AOMCDCCN_XCDCIDFORMAT_CHILD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(AOMCDCCN_CeridianIDFormatForm);
IWebElement formBttn = AOMCDCCN_CeridianIDFormatForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? AOMCDCCN_CeridianIDFormatForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
AOMCDCCN_CeridianIDFormatForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "AOMCDCCN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMCDCCN] Performing VerifyExists on CeridianIDFormat_Sequence...", Logger.MessageType.INF);
				SeleniumControl AOMCDCCN_CeridianIDFormat_Sequence = new SeleniumControl( sDriver, "CeridianIDFormat_Sequence", "xpath", "//div[translate(@id,'0123456789','')='pr__AOMCDCCN_XCDCIDFORMAT_CHILD_']/ancestor::form[1]/descendant::*[@id='SEQUENCE_NO']");
				Function.AssertEqual(true,AOMCDCCN_CeridianIDFormat_Sequence.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "AOMCDCCN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMCDCCN] Performing Click on CeridianMappingLink...", Logger.MessageType.INF);
				SeleniumControl AOMCDCCN_CeridianMappingLink = new SeleniumControl( sDriver, "CeridianMappingLink", "ID", "lnk_5155_AOMCDCCN_XCDCCONFIG");
				Function.WaitControlDisplayed(AOMCDCCN_CeridianMappingLink);
AOMCDCCN_CeridianMappingLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "AOMCDCCN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMCDCCN] Performing VerifyExists on CeridianMappingForm...", Logger.MessageType.INF);
				SeleniumControl AOMCDCCN_CeridianMappingForm = new SeleniumControl( sDriver, "CeridianMappingForm", "xpath", "//div[translate(@id,'0123456789','')='pr__AOMCDCCN_XCDCMAP_DTL_']/ancestor::form[1]");
				Function.AssertEqual(true,AOMCDCCN_CeridianMappingForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "AOMCDCCN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMCDCCN] Performing VerifyExist on CeridianMappingFormTable...", Logger.MessageType.INF);
				SeleniumControl AOMCDCCN_CeridianMappingFormTable = new SeleniumControl( sDriver, "CeridianMappingFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__AOMCDCCN_XCDCMAP_DTL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,AOMCDCCN_CeridianMappingFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "AOMCDCCN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMCDCCN] Performing ClickButton on CeridianMappingForm...", Logger.MessageType.INF);
				SeleniumControl AOMCDCCN_CeridianMappingForm = new SeleniumControl( sDriver, "CeridianMappingForm", "xpath", "//div[translate(@id,'0123456789','')='pr__AOMCDCCN_XCDCMAP_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(AOMCDCCN_CeridianMappingForm);
IWebElement formBttn = AOMCDCCN_CeridianMappingForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? AOMCDCCN_CeridianMappingForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
AOMCDCCN_CeridianMappingForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "AOMCDCCN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMCDCCN] Performing VerifyExists on CeridianMapping_AccountPayType...", Logger.MessageType.INF);
				SeleniumControl AOMCDCCN_CeridianMapping_AccountPayType = new SeleniumControl( sDriver, "CeridianMapping_AccountPayType", "xpath", "//div[translate(@id,'0123456789','')='pr__AOMCDCCN_XCDCMAP_DTL_']/ancestor::form[1]/descendant::*[@id='X_MAP_SRCE_S']");
				Function.AssertEqual(true,AOMCDCCN_CeridianMapping_AccountPayType.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "AOMCDCCN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMCDCCN] Performing Click on CeridianMapping_PopulateMappingTableLink...", Logger.MessageType.INF);
				SeleniumControl AOMCDCCN_CeridianMapping_PopulateMappingTableLink = new SeleniumControl( sDriver, "CeridianMapping_PopulateMappingTableLink", "ID", "lnk_5156_AOMCDCCN_XCDCMAP_DTL");
				Function.WaitControlDisplayed(AOMCDCCN_CeridianMapping_PopulateMappingTableLink);
AOMCDCCN_CeridianMapping_PopulateMappingTableLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "AOMCDCCN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMCDCCN] Performing VerifyExists on CeridianMapping_PopulateMappingTable_Form...", Logger.MessageType.INF);
				SeleniumControl AOMCDCCN_CeridianMapping_PopulateMappingTable_Form = new SeleniumControl( sDriver, "CeridianMapping_PopulateMappingTable_Form", "xpath", "//div[translate(@id,'0123456789','')='pr__AOMCDCCN_ACCT_DLG_']/ancestor::form[1]");
				Function.AssertEqual(true,AOMCDCCN_CeridianMapping_PopulateMappingTable_Form.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "AOMCDCCN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMCDCCN] Performing VerifyExists on CeridianMapping_PopulateMappingTable_PayTypes_From...", Logger.MessageType.INF);
				SeleniumControl AOMCDCCN_CeridianMapping_PopulateMappingTable_PayTypes_From = new SeleniumControl( sDriver, "CeridianMapping_PopulateMappingTable_PayTypes_From", "xpath", "//div[translate(@id,'0123456789','')='pr__AOMCDCCN_ACCT_DLG_']/ancestor::form[1]/descendant::*[@id='DFPAYTYPEFROM']");
				Function.AssertEqual(true,AOMCDCCN_CeridianMapping_PopulateMappingTable_PayTypes_From.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "AOMCDCCN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMCDCCN] Performing Close on CeridianMapping_PopulateMappingTable_Form...", Logger.MessageType.INF);
				SeleniumControl AOMCDCCN_CeridianMapping_PopulateMappingTable_Form = new SeleniumControl( sDriver, "CeridianMapping_PopulateMappingTable_Form", "xpath", "//div[translate(@id,'0123456789','')='pr__AOMCDCCN_ACCT_DLG_']/ancestor::form[1]");
				Function.WaitControlDisplayed(AOMCDCCN_CeridianMapping_PopulateMappingTable_Form);
IWebElement formBttn = AOMCDCCN_CeridianMapping_PopulateMappingTable_Form.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "AOMCDCCN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMCDCCN] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl AOMCDCCN_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(AOMCDCCN_MainForm);
IWebElement formBttn = AOMCDCCN_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "Dialog";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));
Function.ClickOkDialogIfExists("You have unsaved changes. Select Cancel to go back and save changes or select OK to discard changes and close this application.");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickOkDialogIfExists]" , ex.Message));
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

