 
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
    public class BLMWAWF_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Manage Project iRAPT Information", "xpath","//div[@class='navItem'][.='Manage Project iRAPT Information']").Click();


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
				Function.CurrentComponent = "BLMWAWF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMWAWF] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl BLMWAWF_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,BLMWAWF_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMWAWF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMWAWF] Performing VerifyExists on Identification_Project...", Logger.MessageType.INF);
				SeleniumControl BLMWAWF_Identification_Project = new SeleniumControl( sDriver, "Identification_Project", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PROJ_ID']");
				Function.AssertEqual(true,BLMWAWF_Identification_Project.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMWAWF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMWAWF] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl BLMWAWF_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(BLMWAWF_MainForm);
IWebElement formBttn = BLMWAWF_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? BLMWAWF_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
BLMWAWF_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMWAWF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMWAWF] Performing VerifyExist on MainForm_Table...", Logger.MessageType.INF);
				SeleniumControl BLMWAWF_MainForm_Table = new SeleniumControl( sDriver, "MainForm_Table", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BLMWAWF_MainForm_Table.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("UID");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMWAWF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMWAWF] Performing VerifyExists on Identification_UIDInformationLink...", Logger.MessageType.INF);
				SeleniumControl BLMWAWF_Identification_UIDInformationLink = new SeleniumControl( sDriver, "Identification_UIDInformationLink", "ID", "lnk_1007673_BLMWAWF_PROJWAWFINFO_HDR");
				Function.AssertEqual(true,BLMWAWF_Identification_UIDInformationLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMWAWF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMWAWF] Performing Click on Identification_UIDInformationLink...", Logger.MessageType.INF);
				SeleniumControl BLMWAWF_Identification_UIDInformationLink = new SeleniumControl( sDriver, "Identification_UIDInformationLink", "ID", "lnk_1007673_BLMWAWF_PROJWAWFINFO_HDR");
				Function.WaitControlDisplayed(BLMWAWF_Identification_UIDInformationLink);
BLMWAWF_Identification_UIDInformationLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMWAWF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMWAWF] Performing VerifyExists on UIDInformationForm...", Logger.MessageType.INF);
				SeleniumControl BLMWAWF_UIDInformationForm = new SeleniumControl( sDriver, "UIDInformationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BLMWAWF_PROJWAWFUID_UIDCHILD_']/ancestor::form[1]");
				Function.AssertEqual(true,BLMWAWF_UIDInformationForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMWAWF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMWAWF] Performing VerifyExist on UIDInformation_Table...", Logger.MessageType.INF);
				SeleniumControl BLMWAWF_UIDInformation_Table = new SeleniumControl( sDriver, "UIDInformation_Table", "xpath", "//div[translate(@id,'0123456789','')='pr__BLMWAWF_PROJWAWFUID_UIDCHILD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BLMWAWF_UIDInformation_Table.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMWAWF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMWAWF] Performing Close on UIDInformationForm...", Logger.MessageType.INF);
				SeleniumControl BLMWAWF_UIDInformationForm = new SeleniumControl( sDriver, "UIDInformationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BLMWAWF_PROJWAWFUID_UIDCHILD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BLMWAWF_UIDInformationForm);
IWebElement formBttn = BLMWAWF_UIDInformationForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("RFID");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMWAWF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMWAWF] Performing VerifyExists on Identification_RFIDInformationLink...", Logger.MessageType.INF);
				SeleniumControl BLMWAWF_Identification_RFIDInformationLink = new SeleniumControl( sDriver, "Identification_RFIDInformationLink", "ID", "lnk_1007668_BLMWAWF_PROJWAWFINFO_HDR");
				Function.AssertEqual(true,BLMWAWF_Identification_RFIDInformationLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMWAWF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMWAWF] Performing Click on Identification_RFIDInformationLink...", Logger.MessageType.INF);
				SeleniumControl BLMWAWF_Identification_RFIDInformationLink = new SeleniumControl( sDriver, "Identification_RFIDInformationLink", "ID", "lnk_1007668_BLMWAWF_PROJWAWFINFO_HDR");
				Function.WaitControlDisplayed(BLMWAWF_Identification_RFIDInformationLink);
BLMWAWF_Identification_RFIDInformationLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMWAWF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMWAWF] Performing VerifyExists on RFIDInformationForm...", Logger.MessageType.INF);
				SeleniumControl BLMWAWF_RFIDInformationForm = new SeleniumControl( sDriver, "RFIDInformationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BLMWAWF_PROJWAWFRFID_RFIDCHILD_']/ancestor::form[1]");
				Function.AssertEqual(true,BLMWAWF_RFIDInformationForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMWAWF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMWAWF] Performing VerifyExist on RFIDInformation_Table...", Logger.MessageType.INF);
				SeleniumControl BLMWAWF_RFIDInformation_Table = new SeleniumControl( sDriver, "RFIDInformation_Table", "xpath", "//div[translate(@id,'0123456789','')='pr__BLMWAWF_PROJWAWFRFID_RFIDCHILD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BLMWAWF_RFIDInformation_Table.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMWAWF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMWAWF] Performing Close on RFIDInformationForm...", Logger.MessageType.INF);
				SeleniumControl BLMWAWF_RFIDInformationForm = new SeleniumControl( sDriver, "RFIDInformationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BLMWAWF_PROJWAWFRFID_RFIDCHILD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BLMWAWF_RFIDInformationForm);
IWebElement formBttn = BLMWAWF_RFIDInformationForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("CLIN");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMWAWF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMWAWF] Performing VerifyExists on Identification_CLINMappingLink...", Logger.MessageType.INF);
				SeleniumControl BLMWAWF_Identification_CLINMappingLink = new SeleniumControl( sDriver, "Identification_CLINMappingLink", "ID", "lnk_3610_BLMWAWF_PROJWAWFINFO_HDR");
				Function.AssertEqual(true,BLMWAWF_Identification_CLINMappingLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMWAWF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMWAWF] Performing Click on Identification_CLINMappingLink...", Logger.MessageType.INF);
				SeleniumControl BLMWAWF_Identification_CLINMappingLink = new SeleniumControl( sDriver, "Identification_CLINMappingLink", "ID", "lnk_3610_BLMWAWF_PROJWAWFINFO_HDR");
				Function.WaitControlDisplayed(BLMWAWF_Identification_CLINMappingLink);
BLMWAWF_Identification_CLINMappingLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMWAWF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMWAWF] Performing VerifyExists on CLINMappingForm...", Logger.MessageType.INF);
				SeleniumControl BLMWAWF_CLINMappingForm = new SeleniumControl( sDriver, "CLINMappingForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BLMWAWF_PROJWAWCLIN_']/ancestor::form[1]");
				Function.AssertEqual(true,BLMWAWF_CLINMappingForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMWAWF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMWAWF] Performing VerifyExist on CLINMapping_Table...", Logger.MessageType.INF);
				SeleniumControl BLMWAWF_CLINMapping_Table = new SeleniumControl( sDriver, "CLINMapping_Table", "xpath", "//div[translate(@id,'0123456789','')='pr__BLMWAWF_PROJWAWCLIN_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BLMWAWF_CLINMapping_Table.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMWAWF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMWAWF] Performing Close on CLINMappingForm...", Logger.MessageType.INF);
				SeleniumControl BLMWAWF_CLINMappingForm = new SeleniumControl( sDriver, "CLINMappingForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BLMWAWF_PROJWAWCLIN_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BLMWAWF_CLINMappingForm);
IWebElement formBttn = BLMWAWF_CLINMappingForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("ACRN");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMWAWF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMWAWF] Performing VerifyExists on Identification_ACRNFMSWorksheetLink...", Logger.MessageType.INF);
				SeleniumControl BLMWAWF_Identification_ACRNFMSWorksheetLink = new SeleniumControl( sDriver, "Identification_ACRNFMSWorksheetLink", "ID", "lnk_1007665_BLMWAWF_PROJWAWFINFO_HDR");
				Function.AssertEqual(true,BLMWAWF_Identification_ACRNFMSWorksheetLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMWAWF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMWAWF] Performing Click on Identification_ACRNFMSWorksheetLink...", Logger.MessageType.INF);
				SeleniumControl BLMWAWF_Identification_ACRNFMSWorksheetLink = new SeleniumControl( sDriver, "Identification_ACRNFMSWorksheetLink", "ID", "lnk_1007665_BLMWAWF_PROJWAWFINFO_HDR");
				Function.WaitControlDisplayed(BLMWAWF_Identification_ACRNFMSWorksheetLink);
BLMWAWF_Identification_ACRNFMSWorksheetLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMWAWF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMWAWF] Performing VerifyExists on ACRNFMSWorksheetForm...", Logger.MessageType.INF);
				SeleniumControl BLMWAWF_ACRNFMSWorksheetForm = new SeleniumControl( sDriver, "ACRNFMSWorksheetForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BLMWAWF_PROJWAWFACRN_CHILD_']/ancestor::form[1]");
				Function.AssertEqual(true,BLMWAWF_ACRNFMSWorksheetForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMWAWF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMWAWF] Performing VerifyExist on ACRNFMSWorksheet_Table...", Logger.MessageType.INF);
				SeleniumControl BLMWAWF_ACRNFMSWorksheet_Table = new SeleniumControl( sDriver, "ACRNFMSWorksheet_Table", "xpath", "//div[translate(@id,'0123456789','')='pr__BLMWAWF_PROJWAWFACRN_CHILD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BLMWAWF_ACRNFMSWorksheet_Table.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMWAWF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMWAWF] Performing Close on ACRNFMSWorksheetForm...", Logger.MessageType.INF);
				SeleniumControl BLMWAWF_ACRNFMSWorksheetForm = new SeleniumControl( sDriver, "ACRNFMSWorksheetForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BLMWAWF_PROJWAWFACRN_CHILD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BLMWAWF_ACRNFMSWorksheetForm);
IWebElement formBttn = BLMWAWF_ACRNFMSWorksheetForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "BLMWAWF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMWAWF] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl BLMWAWF_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(BLMWAWF_MainForm);
IWebElement formBttn = BLMWAWF_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

