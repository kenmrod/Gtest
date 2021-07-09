 
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
    public class RCMPORC_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Receiving", "xpath","//div[@class='deptItem'][.='Receiving']").Click();
new SeleniumControl(sDriver,"Receiving", "xpath","//div[@class='navItem'][.='Receiving']").Click();
new SeleniumControl(sDriver,"Manage Purchase Order Receipts", "xpath","//div[@class='navItem'][.='Manage Purchase Order Receipts']").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SelectMenu]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMPORC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMPORC] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl RCMPORC_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,RCMPORC_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMPORC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMPORC] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl RCMPORC_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(RCMPORC_MainForm);
IWebElement formBttn = RCMPORC_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? RCMPORC_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
RCMPORC_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMPORC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMPORC] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl RCMPORC_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,RCMPORC_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMPORC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMPORC] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl RCMPORC_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(RCMPORC_MainForm);
IWebElement formBttn = RCMPORC_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? RCMPORC_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
RCMPORC_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMPORC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMPORC] Performing VerifyExists on Identification_Warehouse...", Logger.MessageType.INF);
				SeleniumControl RCMPORC_Identification_Warehouse = new SeleniumControl( sDriver, "Identification_Warehouse", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='WHSE_ID']");
				Function.AssertEqual(true,RCMPORC_Identification_Warehouse.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("CHILDFORM");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMPORC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMPORC] Performing VerifyExist on ChildFormTable...", Logger.MessageType.INF);
				SeleniumControl RCMPORC_ChildFormTable = new SeleniumControl( sDriver, "ChildFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__RCMPORC_POLN_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,RCMPORC_ChildFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMPORC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMPORC] Performing ClickButton on ChildForm...", Logger.MessageType.INF);
				SeleniumControl RCMPORC_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__RCMPORC_POLN_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(RCMPORC_ChildForm);
IWebElement formBttn = RCMPORC_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? RCMPORC_ChildForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
RCMPORC_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMPORC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMPORC] Performing VerifyExists on ChildForm...", Logger.MessageType.INF);
				SeleniumControl RCMPORC_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__RCMPORC_POLN_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,RCMPORC_ChildForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMPORC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMPORC] Performing VerifyExists on ChildForm_Line...", Logger.MessageType.INF);
				SeleniumControl RCMPORC_ChildForm_Line = new SeleniumControl( sDriver, "ChildForm_Line", "xpath", "//div[translate(@id,'0123456789','')='pr__RCMPORC_POLN_CTW_']/ancestor::form[1]/descendant::*[@id='PO_LN_NO']");
				Function.AssertEqual(true,RCMPORC_ChildForm_Line.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("POLINEDOCUMENTS");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMPORC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMPORC] Performing Click on ChildForm_POLineDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl RCMPORC_ChildForm_POLineDocumentsLink = new SeleniumControl( sDriver, "ChildForm_POLineDocumentsLink", "ID", "lnk_1007851_RCMPORC_POLN_CTW");
				Function.WaitControlDisplayed(RCMPORC_ChildForm_POLineDocumentsLink);
RCMPORC_ChildForm_POLineDocumentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMPORC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMPORC] Performing VerifyExist on POLineDocumentsTable...", Logger.MessageType.INF);
				SeleniumControl RCMPORC_POLineDocumentsTable = new SeleniumControl( sDriver, "POLineDocumentsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__RCM_POLNDOCUMENT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,RCMPORC_POLineDocumentsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMPORC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMPORC] Performing ClickButton on POLineDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl RCMPORC_POLineDocumentsForm = new SeleniumControl( sDriver, "POLineDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__RCM_POLNDOCUMENT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(RCMPORC_POLineDocumentsForm);
IWebElement formBttn = RCMPORC_POLineDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? RCMPORC_POLineDocumentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
RCMPORC_POLineDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMPORC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMPORC] Performing VerifyExists on POLineDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl RCMPORC_POLineDocumentsForm = new SeleniumControl( sDriver, "POLineDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__RCM_POLNDOCUMENT_']/ancestor::form[1]");
				Function.AssertEqual(true,RCMPORC_POLineDocumentsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMPORC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMPORC] Performing VerifyExists on POLineDocuments_Document...", Logger.MessageType.INF);
				SeleniumControl RCMPORC_POLineDocuments_Document = new SeleniumControl( sDriver, "POLineDocuments_Document", "xpath", "//div[translate(@id,'0123456789','')='pr__RCM_POLNDOCUMENT_']/ancestor::form[1]/descendant::*[@id='DOCUMENT_ID']");
				Function.AssertEqual(true,RCMPORC_POLineDocuments_Document.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMPORC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMPORC] Performing Close on POLineDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl RCMPORC_POLineDocumentsForm = new SeleniumControl( sDriver, "POLineDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__RCM_POLNDOCUMENT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(RCMPORC_POLineDocumentsForm);
IWebElement formBttn = RCMPORC_POLineDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("POLINEACCOUNTS");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMPORC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMPORC] Performing Click on ChildForm_POLineAccountsLink...", Logger.MessageType.INF);
				SeleniumControl RCMPORC_ChildForm_POLineAccountsLink = new SeleniumControl( sDriver, "ChildForm_POLineAccountsLink", "ID", "lnk_1004412_RCMPORC_POLN_CTW");
				Function.WaitControlDisplayed(RCMPORC_ChildForm_POLineAccountsLink);
RCMPORC_ChildForm_POLineAccountsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMPORC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMPORC] Performing VerifyExist on POLineAccountsTable...", Logger.MessageType.INF);
				SeleniumControl RCMPORC_POLineAccountsTable = new SeleniumControl( sDriver, "POLineAccountsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__RCMPORC_POLNACCT_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,RCMPORC_POLineAccountsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMPORC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMPORC] Performing ClickButton on POLineAccountsForm...", Logger.MessageType.INF);
				SeleniumControl RCMPORC_POLineAccountsForm = new SeleniumControl( sDriver, "POLineAccountsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__RCMPORC_POLNACCT_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(RCMPORC_POLineAccountsForm);
IWebElement formBttn = RCMPORC_POLineAccountsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? RCMPORC_POLineAccountsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
RCMPORC_POLineAccountsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMPORC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMPORC] Performing VerifyExists on POLineAccountsForm...", Logger.MessageType.INF);
				SeleniumControl RCMPORC_POLineAccountsForm = new SeleniumControl( sDriver, "POLineAccountsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__RCMPORC_POLNACCT_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,RCMPORC_POLineAccountsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMPORC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMPORC] Performing VerifyExists on POLineAccounts_Project...", Logger.MessageType.INF);
				SeleniumControl RCMPORC_POLineAccounts_Project = new SeleniumControl( sDriver, "POLineAccounts_Project", "xpath", "//div[translate(@id,'0123456789','')='pr__RCMPORC_POLNACCT_CTW_']/ancestor::form[1]/descendant::*[@id='PROJ_ID']");
				Function.AssertEqual(true,RCMPORC_POLineAccounts_Project.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMPORC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMPORC] Performing Close on POLineAccountsForm...", Logger.MessageType.INF);
				SeleniumControl RCMPORC_POLineAccountsForm = new SeleniumControl( sDriver, "POLineAccountsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__RCMPORC_POLNACCT_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(RCMPORC_POLineAccountsForm);
IWebElement formBttn = RCMPORC_POLineAccountsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("SERIALLOTNFO");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMPORC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMPORC] Performing Click on ChildForm_SerialLotInfoLink...", Logger.MessageType.INF);
				SeleniumControl RCMPORC_ChildForm_SerialLotInfoLink = new SeleniumControl( sDriver, "ChildForm_SerialLotInfoLink", "ID", "lnk_1004413_RCMPORC_POLN_CTW");
				Function.WaitControlDisplayed(RCMPORC_ChildForm_SerialLotInfoLink);
RCMPORC_ChildForm_SerialLotInfoLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMPORC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMPORC] Performing VerifyExist on SerialLotInfoTable...", Logger.MessageType.INF);
				SeleniumControl RCMPORC_SerialLotInfoTable = new SeleniumControl( sDriver, "SerialLotInfoTable", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSRLT_INVTTRNLNSRLT_COMMON_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,RCMPORC_SerialLotInfoTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMPORC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMPORC] Performing ClickButton on SerialLotInfoForm...", Logger.MessageType.INF);
				SeleniumControl RCMPORC_SerialLotInfoForm = new SeleniumControl( sDriver, "SerialLotInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSRLT_INVTTRNLNSRLT_COMMON_']/ancestor::form[1]");
				Function.WaitControlDisplayed(RCMPORC_SerialLotInfoForm);
IWebElement formBttn = RCMPORC_SerialLotInfoForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? RCMPORC_SerialLotInfoForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
RCMPORC_SerialLotInfoForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMPORC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMPORC] Performing VerifyExists on SerialLotInfoForm...", Logger.MessageType.INF);
				SeleniumControl RCMPORC_SerialLotInfoForm = new SeleniumControl( sDriver, "SerialLotInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSRLT_INVTTRNLNSRLT_COMMON_']/ancestor::form[1]");
				Function.AssertEqual(true,RCMPORC_SerialLotInfoForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMPORC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMPORC] Performing VerifyExists on SerialLotInfo_SerialNumber...", Logger.MessageType.INF);
				SeleniumControl RCMPORC_SerialLotInfo_SerialNumber = new SeleniumControl( sDriver, "SerialLotInfo_SerialNumber", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSRLT_INVTTRNLNSRLT_COMMON_']/ancestor::form[1]/descendant::*[@id='SERIAL_ID']");
				Function.AssertEqual(true,RCMPORC_SerialLotInfo_SerialNumber.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMPORC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMPORC] Performing Select on SerialLotInfo_SerialLotInfoTab...", Logger.MessageType.INF);
				SeleniumControl RCMPORC_SerialLotInfo_SerialLotInfoTab = new SeleniumControl( sDriver, "SerialLotInfo_SerialLotInfoTab", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSRLT_INVTTRNLNSRLT_COMMON_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(RCMPORC_SerialLotInfo_SerialLotInfoTab);
IWebElement mTab = RCMPORC_SerialLotInfo_SerialLotInfoTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Basic Information").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMPORC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMPORC] Performing VerifyExists on SerialLotInfo_BasicInformation_ReceiptQuantity...", Logger.MessageType.INF);
				SeleniumControl RCMPORC_SerialLotInfo_BasicInformation_ReceiptQuantity = new SeleniumControl( sDriver, "SerialLotInfo_BasicInformation_ReceiptQuantity", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSRLT_INVTTRNLNSRLT_COMMON_']/ancestor::form[1]/descendant::*[@id='TRN_QTY']");
				Function.AssertEqual(true,RCMPORC_SerialLotInfo_BasicInformation_ReceiptQuantity.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMPORC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMPORC] Performing Select on SerialLotInfo_SerialLotInfoTab...", Logger.MessageType.INF);
				SeleniumControl RCMPORC_SerialLotInfo_SerialLotInfoTab = new SeleniumControl( sDriver, "SerialLotInfo_SerialLotInfoTab", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSRLT_INVTTRNLNSRLT_COMMON_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(RCMPORC_SerialLotInfo_SerialLotInfoTab);
IWebElement mTab = RCMPORC_SerialLotInfo_SerialLotInfoTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Manufacturer/Vendor Information").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMPORC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMPORC] Performing VerifyExists on SerialLotInfo_ManufacturerVendorInformation_Manufacturer_Manufacturer...", Logger.MessageType.INF);
				SeleniumControl RCMPORC_SerialLotInfo_ManufacturerVendorInformation_Manufacturer_Manufacturer = new SeleniumControl( sDriver, "SerialLotInfo_ManufacturerVendorInformation_Manufacturer_Manufacturer", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSRLT_INVTTRNLNSRLT_COMMON_']/ancestor::form[1]/descendant::*[@id='MANUF_ID']");
				Function.AssertEqual(true,RCMPORC_SerialLotInfo_ManufacturerVendorInformation_Manufacturer_Manufacturer.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMPORC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMPORC] Performing Select on SerialLotInfo_SerialLotInfoTab...", Logger.MessageType.INF);
				SeleniumControl RCMPORC_SerialLotInfo_SerialLotInfoTab = new SeleniumControl( sDriver, "SerialLotInfo_SerialLotInfoTab", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSRLT_INVTTRNLNSRLT_COMMON_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(RCMPORC_SerialLotInfo_SerialLotInfoTab);
IWebElement mTab = RCMPORC_SerialLotInfo_SerialLotInfoTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Sales Order/Warranty Information").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMPORC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMPORC] Performing VerifyExists on SerialLotInfo_SalesOrderWarrantyInformation_SalesOrderInformation_SalesOrderTagNo...", Logger.MessageType.INF);
				SeleniumControl RCMPORC_SerialLotInfo_SalesOrderWarrantyInformation_SalesOrderInformation_SalesOrderTagNo = new SeleniumControl( sDriver, "SerialLotInfo_SalesOrderWarrantyInformation_SalesOrderInformation_SalesOrderTagNo", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSRLT_INVTTRNLNSRLT_COMMON_']/ancestor::form[1]/descendant::*[@id='SO_TAG_ID']");
				Function.AssertEqual(true,RCMPORC_SerialLotInfo_SalesOrderWarrantyInformation_SalesOrderInformation_SalesOrderTagNo.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMPORC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMPORC] Performing Select on SerialLotInfo_SerialLotInfoTab...", Logger.MessageType.INF);
				SeleniumControl RCMPORC_SerialLotInfo_SerialLotInfoTab = new SeleniumControl( sDriver, "SerialLotInfo_SerialLotInfoTab", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSRLT_INVTTRNLNSRLT_COMMON_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(RCMPORC_SerialLotInfo_SerialLotInfoTab);
IWebElement mTab = RCMPORC_SerialLotInfo_SerialLotInfoTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "User-Defined Info").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMPORC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMPORC] Performing VerifyExists on SerialLotInfo_UID_UIDDetails_UID...", Logger.MessageType.INF);
				SeleniumControl RCMPORC_SerialLotInfo_UID_UIDDetails_UID = new SeleniumControl( sDriver, "SerialLotInfo_UID_UIDDetails_UID", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSRLT_INVTTRNLNSRLT_COMMON_']/ancestor::form[1]/descendant::*[@id='UID_CD']");
				Function.AssertEqual(false,RCMPORC_SerialLotInfo_UID_UIDDetails_UID.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMPORC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMPORC] Performing Select on SerialLotInfo_SerialLotInfoTab...", Logger.MessageType.INF);
				SeleniumControl RCMPORC_SerialLotInfo_SerialLotInfoTab = new SeleniumControl( sDriver, "SerialLotInfo_SerialLotInfoTab", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSRLT_INVTTRNLNSRLT_COMMON_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(RCMPORC_SerialLotInfo_SerialLotInfoTab);
IWebElement mTab = RCMPORC_SerialLotInfo_SerialLotInfoTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Notes").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMPORC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMPORC] Performing VerifyExists on SerialLotInfo_Notes_Notes...", Logger.MessageType.INF);
				SeleniumControl RCMPORC_SerialLotInfo_Notes_Notes = new SeleniumControl( sDriver, "SerialLotInfo_Notes_Notes", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSRLT_INVTTRNLNSRLT_COMMON_']/ancestor::form[1]/descendant::*[@id='NOTES_NT']");
				Function.AssertEqual(true,RCMPORC_SerialLotInfo_Notes_Notes.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMPORC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMPORC] Performing Select on SerialLotInfo_SerialLotInfoTab...", Logger.MessageType.INF);
				SeleniumControl RCMPORC_SerialLotInfo_SerialLotInfoTab = new SeleniumControl( sDriver, "SerialLotInfo_SerialLotInfoTab", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSRLT_INVTTRNLNSRLT_COMMON_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(RCMPORC_SerialLotInfo_SerialLotInfoTab);
IWebElement mTab = RCMPORC_SerialLotInfo_SerialLotInfoTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Shelf Life").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMPORC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMPORC] Performing VerifyExists on ChildForm_SerialLotInfo_ShelfLife_ShelfLife_ShelfLifeType...", Logger.MessageType.INF);
				SeleniumControl RCMPORC_ChildForm_SerialLotInfo_ShelfLife_ShelfLife_ShelfLifeType = new SeleniumControl( sDriver, "ChildForm_SerialLotInfo_ShelfLife_ShelfLife_ShelfLifeType", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSRLT_INVTTRNLNSRLT_COMMON_']/ancestor::form[1]/descendant::*[@id='S_SHELF_LIFE_TYPE']");
				Function.AssertEqual(true,RCMPORC_ChildForm_SerialLotInfo_ShelfLife_ShelfLife_ShelfLifeType.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMPORC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMPORC] Performing Close on SerialLotInfoForm...", Logger.MessageType.INF);
				SeleniumControl RCMPORC_SerialLotInfoForm = new SeleniumControl( sDriver, "SerialLotInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSRLT_INVTTRNLNSRLT_COMMON_']/ancestor::form[1]");
				Function.WaitControlDisplayed(RCMPORC_SerialLotInfoForm);
IWebElement formBttn = RCMPORC_SerialLotInfoForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("FIXEDASSETS");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMPORC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMPORC] Performing Click on ChildForm_FixedAssetsLink...", Logger.MessageType.INF);
				SeleniumControl RCMPORC_ChildForm_FixedAssetsLink = new SeleniumControl( sDriver, "ChildForm_FixedAssetsLink", "ID", "lnk_1004414_RCMPORC_POLN_CTW");
				Function.WaitControlDisplayed(RCMPORC_ChildForm_FixedAssetsLink);
RCMPORC_ChildForm_FixedAssetsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMPORC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMPORC] Performing VerifyExist on FixedAssetsTable...", Logger.MessageType.INF);
				SeleniumControl RCMPORC_FixedAssetsTable = new SeleniumControl( sDriver, "FixedAssetsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__FAMAUTOC_DTL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,RCMPORC_FixedAssetsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMPORC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMPORC] Performing ClickButton on FixedAssetsForm...", Logger.MessageType.INF);
				SeleniumControl RCMPORC_FixedAssetsForm = new SeleniumControl( sDriver, "FixedAssetsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__FAMAUTOC_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(RCMPORC_FixedAssetsForm);
IWebElement formBttn = RCMPORC_FixedAssetsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? RCMPORC_FixedAssetsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
RCMPORC_FixedAssetsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMPORC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMPORC] Performing VerifyExists on FixedAssetsForm...", Logger.MessageType.INF);
				SeleniumControl RCMPORC_FixedAssetsForm = new SeleniumControl( sDriver, "FixedAssetsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__FAMAUTOC_DTL_']/ancestor::form[1]");
				Function.AssertEqual(true,RCMPORC_FixedAssetsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMPORC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMPORC] Performing Select on FixedAssets_FixedAssetsTab...", Logger.MessageType.INF);
				SeleniumControl RCMPORC_FixedAssets_FixedAssetsTab = new SeleniumControl( sDriver, "FixedAssets_FixedAssetsTab", "xpath", "//div[translate(@id,'0123456789','')='pr__FAMAUTOC_DTL_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(RCMPORC_FixedAssets_FixedAssetsTab);
IWebElement mTab = RCMPORC_FixedAssets_FixedAssetsTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Desc/Purch Info").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMPORC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMPORC] Performing VerifyExists on FixedAssets_DescPurchInfo_DescriptiveInformation_Template...", Logger.MessageType.INF);
				SeleniumControl RCMPORC_FixedAssets_DescPurchInfo_DescriptiveInformation_Template = new SeleniumControl( sDriver, "FixedAssets_DescPurchInfo_DescriptiveInformation_Template", "xpath", "//div[translate(@id,'0123456789','')='pr__FAMAUTOC_DTL_']/ancestor::form[1]/descendant::*[@id='FA_TMPLT_ID']");
				Function.AssertEqual(true,RCMPORC_FixedAssets_DescPurchInfo_DescriptiveInformation_Template.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMPORC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMPORC] Performing Select on FixedAssets_FixedAssetsTab...", Logger.MessageType.INF);
				SeleniumControl RCMPORC_FixedAssets_FixedAssetsTab = new SeleniumControl( sDriver, "FixedAssets_FixedAssetsTab", "xpath", "//div[translate(@id,'0123456789','')='pr__FAMAUTOC_DTL_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(RCMPORC_FixedAssets_FixedAssetsTab);
IWebElement mTab = RCMPORC_FixedAssets_FixedAssetsTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Location Info").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMPORC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMPORC] Performing VerifyExists on FixedAssets_LocationInfo_LocationGroupInfo_LocationGroup...", Logger.MessageType.INF);
				SeleniumControl RCMPORC_FixedAssets_LocationInfo_LocationGroupInfo_LocationGroup = new SeleniumControl( sDriver, "FixedAssets_LocationInfo_LocationGroupInfo_LocationGroup", "xpath", "//div[translate(@id,'0123456789','')='pr__FAMAUTOC_DTL_']/ancestor::form[1]/descendant::*[@id='FA_LOC_GRP_CD']");
				Function.AssertEqual(true,RCMPORC_FixedAssets_LocationInfo_LocationGroupInfo_LocationGroup.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMPORC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMPORC] Performing Select on FixedAssets_FixedAssetsTab...", Logger.MessageType.INF);
				SeleniumControl RCMPORC_FixedAssets_FixedAssetsTab = new SeleniumControl( sDriver, "FixedAssets_FixedAssetsTab", "xpath", "//div[translate(@id,'0123456789','')='pr__FAMAUTOC_DTL_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(RCMPORC_FixedAssets_FixedAssetsTab);
IWebElement mTab = RCMPORC_FixedAssets_FixedAssetsTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Govt Info").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMPORC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMPORC] Performing VerifyExists on FixedAssets_GovtInfo_TagNo...", Logger.MessageType.INF);
				SeleniumControl RCMPORC_FixedAssets_GovtInfo_TagNo = new SeleniumControl( sDriver, "FixedAssets_GovtInfo_TagNo", "xpath", "//div[translate(@id,'0123456789','')='pr__FAMAUTOC_DTL_']/ancestor::form[1]/descendant::*[@id='TAG_NO_S']");
				Function.AssertEqual(true,RCMPORC_FixedAssets_GovtInfo_TagNo.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMPORC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMPORC] Performing Select on FixedAssets_FixedAssetsTab...", Logger.MessageType.INF);
				SeleniumControl RCMPORC_FixedAssets_FixedAssetsTab = new SeleniumControl( sDriver, "FixedAssets_FixedAssetsTab", "xpath", "//div[translate(@id,'0123456789','')='pr__FAMAUTOC_DTL_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(RCMPORC_FixedAssets_FixedAssetsTab);
IWebElement mTab = RCMPORC_FixedAssets_FixedAssetsTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "UID").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMPORC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMPORC] Performing VerifyExists on FixedAssets_UID_UIDDetails_UID...", Logger.MessageType.INF);
				SeleniumControl RCMPORC_FixedAssets_UID_UIDDetails_UID = new SeleniumControl( sDriver, "FixedAssets_UID_UIDDetails_UID", "xpath", "//div[translate(@id,'0123456789','')='pr__FAMAUTOC_DTL_']/ancestor::form[1]/descendant::*[@id='UID_CD']");
				Function.AssertEqual(true,RCMPORC_FixedAssets_UID_UIDDetails_UID.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMPORC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMPORC] Performing Close on FixedAssetsForm...", Logger.MessageType.INF);
				SeleniumControl RCMPORC_FixedAssetsForm = new SeleniumControl( sDriver, "FixedAssetsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__FAMAUTOC_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(RCMPORC_FixedAssetsForm);
IWebElement formBttn = RCMPORC_FixedAssetsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("PARTDOCUMENTS");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMPORC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMPORC] Performing Click on ChildForm_PartDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl RCMPORC_ChildForm_PartDocumentsLink = new SeleniumControl( sDriver, "ChildForm_PartDocumentsLink", "ID", "lnk_1004415_RCMPORC_POLN_CTW");
				Function.WaitControlDisplayed(RCMPORC_ChildForm_PartDocumentsLink);
RCMPORC_ChildForm_PartDocumentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMPORC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMPORC] Performing VerifyExist on PartDocumentsTable...", Logger.MessageType.INF);
				SeleniumControl RCMPORC_PartDocumentsTable = new SeleniumControl( sDriver, "PartDocumentsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,RCMPORC_PartDocumentsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMPORC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMPORC] Performing ClickButton on PartDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl RCMPORC_PartDocumentsForm = new SeleniumControl( sDriver, "PartDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(RCMPORC_PartDocumentsForm);
IWebElement formBttn = RCMPORC_PartDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? RCMPORC_PartDocumentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
RCMPORC_PartDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMPORC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMPORC] Performing VerifyExists on PartDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl RCMPORC_PartDocumentsForm = new SeleniumControl( sDriver, "PartDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]");
				Function.AssertEqual(true,RCMPORC_PartDocumentsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMPORC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMPORC] Performing VerifyExists on PartDocuments_Type...", Logger.MessageType.INF);
				SeleniumControl RCMPORC_PartDocuments_Type = new SeleniumControl( sDriver, "PartDocuments_Type", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]/descendant::*[@id='DOC_TYPE_CD']");
				Function.AssertEqual(true,RCMPORC_PartDocuments_Type.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMPORC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMPORC] Performing Close on PartDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl RCMPORC_PartDocumentsForm = new SeleniumControl( sDriver, "PartDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(RCMPORC_PartDocumentsForm);
IWebElement formBttn = RCMPORC_PartDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("BACKORDERS");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMPORC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMPORC] Performing Click on ChildForm_BackOrdersLink...", Logger.MessageType.INF);
				SeleniumControl RCMPORC_ChildForm_BackOrdersLink = new SeleniumControl( sDriver, "ChildForm_BackOrdersLink", "ID", "lnk_2906_RCMPORC_POLN_CTW");
				Function.WaitControlDisplayed(RCMPORC_ChildForm_BackOrdersLink);
RCMPORC_ChildForm_BackOrdersLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMPORC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMPORC] Performing VerifyExist on BackOrdersTable...", Logger.MessageType.INF);
				SeleniumControl RCMPORC_BackOrdersTable = new SeleniumControl( sDriver, "BackOrdersTable", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGBKORD_RESLN_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,RCMPORC_BackOrdersTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMPORC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMPORC] Performing ClickButton on BackOrdersForm...", Logger.MessageType.INF);
				SeleniumControl RCMPORC_BackOrdersForm = new SeleniumControl( sDriver, "BackOrdersForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGBKORD_RESLN_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(RCMPORC_BackOrdersForm);
IWebElement formBttn = RCMPORC_BackOrdersForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? RCMPORC_BackOrdersForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
RCMPORC_BackOrdersForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMPORC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMPORC] Performing VerifyExists on BackOrdersForm...", Logger.MessageType.INF);
				SeleniumControl RCMPORC_BackOrdersForm = new SeleniumControl( sDriver, "BackOrdersForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGBKORD_RESLN_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,RCMPORC_BackOrdersForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMPORC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMPORC] Performing VerifyExists on BackOrders_NeedDate...", Logger.MessageType.INF);
				SeleniumControl RCMPORC_BackOrders_NeedDate = new SeleniumControl( sDriver, "BackOrders_NeedDate", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGBKORD_RESLN_CTW_']/ancestor::form[1]/descendant::*[@id='NEED_DT']");
				Function.AssertEqual(true,RCMPORC_BackOrders_NeedDate.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMPORC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMPORC] Performing Close on BackOrdersForm...", Logger.MessageType.INF);
				SeleniumControl RCMPORC_BackOrdersForm = new SeleniumControl( sDriver, "BackOrdersForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGBKORD_RESLN_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(RCMPORC_BackOrdersForm);
IWebElement formBttn = RCMPORC_BackOrdersForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMPORC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMPORC] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl RCMPORC_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(RCMPORC_MainForm);
IWebElement formBttn = RCMPORC_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

