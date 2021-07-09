 
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
    public class OEMSHIP_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Sales Order Entry", "xpath","//div[@class='deptItem'][.='Sales Order Entry']").Click();
new SeleniumControl(sDriver,"Sales Order Shipping", "xpath","//div[@class='navItem'][.='Sales Order Shipping']").Click();
new SeleniumControl(sDriver,"Manage Shipping Transactions", "xpath","//div[@class='navItem'][.='Manage Shipping Transactions']").Click();


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
				Function.CurrentComponent = "OEMSHIP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMSHIP] Performing VerifyExists on SOHeaderDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl OEMSHIP_SOHeaderDocumentsLink = new SeleniumControl( sDriver, "SOHeaderDocumentsLink", "ID", "lnk_1007725_OEMSHIP_OEMTRN_HEADER");
				Function.AssertEqual(true,OEMSHIP_SOHeaderDocumentsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMSHIP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMSHIP] Performing Click on SOHeaderDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl OEMSHIP_SOHeaderDocumentsLink = new SeleniumControl( sDriver, "SOHeaderDocumentsLink", "ID", "lnk_1007725_OEMSHIP_OEMTRN_HEADER");
				Function.WaitControlDisplayed(OEMSHIP_SOHeaderDocumentsLink);
OEMSHIP_SOHeaderDocumentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMSHIP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMSHIP] Performing VerifyExists on SOHeaderDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl OEMSHIP_SOHeaderDocumentsForm = new SeleniumControl( sDriver, "SOHeaderDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMSHIP_HDR_DOCUMENTS_']/ancestor::form[1]");
				Function.AssertEqual(true,OEMSHIP_SOHeaderDocumentsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMSHIP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMSHIP] Performing VerifyExist on SOHeaderDocumentsTable...", Logger.MessageType.INF);
				SeleniumControl OEMSHIP_SOHeaderDocumentsTable = new SeleniumControl( sDriver, "SOHeaderDocumentsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMSHIP_HDR_DOCUMENTS_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,OEMSHIP_SOHeaderDocumentsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMSHIP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMSHIP] Performing ClickButton on SOHeaderDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl OEMSHIP_SOHeaderDocumentsForm = new SeleniumControl( sDriver, "SOHeaderDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMSHIP_HDR_DOCUMENTS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMSHIP_SOHeaderDocumentsForm);
IWebElement formBttn = OEMSHIP_SOHeaderDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? OEMSHIP_SOHeaderDocumentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
OEMSHIP_SOHeaderDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMSHIP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMSHIP] Performing VerifyExists on SOHeaderDocuments_Document...", Logger.MessageType.INF);
				SeleniumControl OEMSHIP_SOHeaderDocuments_Document = new SeleniumControl( sDriver, "SOHeaderDocuments_Document", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMSHIP_HDR_DOCUMENTS_']/ancestor::form[1]/descendant::*[@id='DOCUMENT_ID']");
				Function.AssertEqual(true,OEMSHIP_SOHeaderDocuments_Document.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMSHIP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMSHIP] Performing Close on SOHeaderDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl OEMSHIP_SOHeaderDocumentsForm = new SeleniumControl( sDriver, "SOHeaderDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMSHIP_HDR_DOCUMENTS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMSHIP_SOHeaderDocumentsForm);
IWebElement formBttn = OEMSHIP_SOHeaderDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMSHIP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMSHIP] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl OEMSHIP_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,OEMSHIP_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMSHIP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMSHIP] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl OEMSHIP_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(OEMSHIP_MainForm);
IWebElement formBttn = OEMSHIP_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? OEMSHIP_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
OEMSHIP_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMSHIP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMSHIP] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl OEMSHIP_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,OEMSHIP_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMSHIP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMSHIP] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl OEMSHIP_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(OEMSHIP_MainForm);
IWebElement formBttn = OEMSHIP_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? OEMSHIP_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
OEMSHIP_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMSHIP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMSHIP] Performing VerifyExists on Identification_PackingSlipNo...", Logger.MessageType.INF);
				SeleniumControl OEMSHIP_Identification_PackingSlipNo = new SeleniumControl( sDriver, "Identification_PackingSlipNo", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PS_ID']");
				Function.AssertEqual(true,OEMSHIP_Identification_PackingSlipNo.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMSHIP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMSHIP] Performing Select on MainTab...", Logger.MessageType.INF);
				SeleniumControl OEMSHIP_MainTab = new SeleniumControl( sDriver, "MainTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(OEMSHIP_MainTab);
IWebElement mTab = OEMSHIP_MainTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Shipping Information").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMSHIP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMSHIP] Performing VerifyExists on ShippingInformation_ShippingInformation_ShipVia...", Logger.MessageType.INF);
				SeleniumControl OEMSHIP_ShippingInformation_ShippingInformation_ShipVia = new SeleniumControl( sDriver, "ShippingInformation_ShippingInformation_ShipVia", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='SHIP_VIA_FLD']");
				Function.AssertEqual(true,OEMSHIP_ShippingInformation_ShippingInformation_ShipVia.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMSHIP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMSHIP] Performing Select on MainTab...", Logger.MessageType.INF);
				SeleniumControl OEMSHIP_MainTab = new SeleniumControl( sDriver, "MainTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(OEMSHIP_MainTab);
IWebElement mTab = OEMSHIP_MainTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Customs Information").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMSHIP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMSHIP] Performing VerifyExists on CustomsInformation_ValueAddedTaxInfo_TaxID...", Logger.MessageType.INF);
				SeleniumControl OEMSHIP_CustomsInformation_ValueAddedTaxInfo_TaxID = new SeleniumControl( sDriver, "CustomsInformation_ValueAddedTaxInfo_TaxID", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='VAT_TAX_ID']");
				Function.AssertEqual(true,OEMSHIP_CustomsInformation_ValueAddedTaxInfo_TaxID.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMSHIP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMSHIP] Performing Select on MainTab...", Logger.MessageType.INF);
				SeleniumControl OEMSHIP_MainTab = new SeleniumControl( sDriver, "MainTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(OEMSHIP_MainTab);
IWebElement mTab = OEMSHIP_MainTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Ship to Address").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMSHIP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMSHIP] Performing VerifyExists on ShipToAddress_Address_Line1...", Logger.MessageType.INF);
				SeleniumControl OEMSHIP_ShipToAddress_Address_Line1 = new SeleniumControl( sDriver, "ShipToAddress_Address_Line1", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='LN_1_ADDR']");
				Function.AssertEqual(true,OEMSHIP_ShipToAddress_Address_Line1.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMSHIP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMSHIP] Performing Select on MainTab...", Logger.MessageType.INF);
				SeleniumControl OEMSHIP_MainTab = new SeleniumControl( sDriver, "MainTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(OEMSHIP_MainTab);
IWebElement mTab = OEMSHIP_MainTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Notes").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("RFID Details");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMSHIP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMSHIP] Performing VerifyExists on RFIDDetailsLink...", Logger.MessageType.INF);
				SeleniumControl OEMSHIP_RFIDDetailsLink = new SeleniumControl( sDriver, "RFIDDetailsLink", "ID", "lnk_1008097_OEMSHIP_OEMTRN_HEADER");
				Function.AssertEqual(true,OEMSHIP_RFIDDetailsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMSHIP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMSHIP] Performing Click on RFIDDetailsLink...", Logger.MessageType.INF);
				SeleniumControl OEMSHIP_RFIDDetailsLink = new SeleniumControl( sDriver, "RFIDDetailsLink", "ID", "lnk_1008097_OEMSHIP_OEMTRN_HEADER");
				Function.WaitControlDisplayed(OEMSHIP_RFIDDetailsLink);
OEMSHIP_RFIDDetailsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMSHIP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMSHIP] Performing VerifyExists on RFIDDetailsForm...", Logger.MessageType.INF);
				SeleniumControl OEMSHIP_RFIDDetailsForm = new SeleniumControl( sDriver, "RFIDDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMSHIP_RFID_HEADER_']/ancestor::form[1]");
				Function.AssertEqual(true,OEMSHIP_RFIDDetailsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMSHIP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMSHIP] Performing VerifyExist on RFIDDetails2Table...", Logger.MessageType.INF);
				SeleniumControl OEMSHIP_RFIDDetails2Table = new SeleniumControl( sDriver, "RFIDDetails2Table", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMSHIP_RFID_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,OEMSHIP_RFIDDetails2Table.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMSHIP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMSHIP] Performing VerifyExists on RFIDDetails2Form...", Logger.MessageType.INF);
				SeleniumControl OEMSHIP_RFIDDetails2Form = new SeleniumControl( sDriver, "RFIDDetails2Form", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMSHIP_RFID_']/ancestor::form[1]");
				Function.AssertEqual(true,OEMSHIP_RFIDDetails2Form.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMSHIP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMSHIP] Performing ClickButton on RFIDDetails2Form...", Logger.MessageType.INF);
				SeleniumControl OEMSHIP_RFIDDetails2Form = new SeleniumControl( sDriver, "RFIDDetails2Form", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMSHIP_RFID_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMSHIP_RFIDDetails2Form);
IWebElement formBttn = OEMSHIP_RFIDDetails2Form.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? OEMSHIP_RFIDDetails2Form.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
OEMSHIP_RFIDDetails2Form.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMSHIP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMSHIP] Performing VerifyExists on RFIDDetails_RFIDDetails_SOLine...", Logger.MessageType.INF);
				SeleniumControl OEMSHIP_RFIDDetails_RFIDDetails_SOLine = new SeleniumControl( sDriver, "RFIDDetails_RFIDDetails_SOLine", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMSHIP_RFID_']/ancestor::form[1]/descendant::*[@id='SO_LN_NO']");
				Function.AssertEqual(true,OEMSHIP_RFIDDetails_RFIDDetails_SOLine.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMSHIP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMSHIP] Performing Close on RFIDDetailsForm...", Logger.MessageType.INF);
				SeleniumControl OEMSHIP_RFIDDetailsForm = new SeleniumControl( sDriver, "RFIDDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMSHIP_RFID_HEADER_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMSHIP_RFIDDetailsForm);
IWebElement formBttn = OEMSHIP_RFIDDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("PS Std Text");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMSHIP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMSHIP] Performing VerifyExists on PSStdTextLink...", Logger.MessageType.INF);
				SeleniumControl OEMSHIP_PSStdTextLink = new SeleniumControl( sDriver, "PSStdTextLink", "ID", "lnk_1003609_OEMSHIP_OEMTRN_HEADER");
				Function.AssertEqual(true,OEMSHIP_PSStdTextLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMSHIP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMSHIP] Performing Click on PSStdTextLink...", Logger.MessageType.INF);
				SeleniumControl OEMSHIP_PSStdTextLink = new SeleniumControl( sDriver, "PSStdTextLink", "ID", "lnk_1003609_OEMSHIP_OEMTRN_HEADER");
				Function.WaitControlDisplayed(OEMSHIP_PSStdTextLink);
OEMSHIP_PSStdTextLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMSHIP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMSHIP] Performing VerifyExists on PSStdTextForm...", Logger.MessageType.INF);
				SeleniumControl OEMSHIP_PSStdTextForm = new SeleniumControl( sDriver, "PSStdTextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMSHIP_SHIPTRNTEXT_DETAIL_']/ancestor::form[1]");
				Function.AssertEqual(true,OEMSHIP_PSStdTextForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMSHIP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMSHIP] Performing VerifyExist on PSStdTextTable...", Logger.MessageType.INF);
				SeleniumControl OEMSHIP_PSStdTextTable = new SeleniumControl( sDriver, "PSStdTextTable", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMSHIP_SHIPTRNTEXT_DETAIL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,OEMSHIP_PSStdTextTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMSHIP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMSHIP] Performing Close on PSStdTextForm...", Logger.MessageType.INF);
				SeleniumControl OEMSHIP_PSStdTextForm = new SeleniumControl( sDriver, "PSStdTextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMSHIP_SHIPTRNTEXT_DETAIL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMSHIP_PSStdTextForm);
IWebElement formBttn = OEMSHIP_PSStdTextForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("SO Header Documents");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("WAWF");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMSHIP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMSHIP] Performing VerifyExists on WAWFLink...", Logger.MessageType.INF);
				SeleniumControl OEMSHIP_WAWFLink = new SeleniumControl( sDriver, "WAWFLink", "ID", "lnk_1008087_OEMSHIP_OEMTRN_HEADER");
				Function.AssertEqual(true,OEMSHIP_WAWFLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMSHIP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMSHIP] Performing Click on WAWFLink...", Logger.MessageType.INF);
				SeleniumControl OEMSHIP_WAWFLink = new SeleniumControl( sDriver, "WAWFLink", "ID", "lnk_1008087_OEMSHIP_OEMTRN_HEADER");
				Function.WaitControlDisplayed(OEMSHIP_WAWFLink);
OEMSHIP_WAWFLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMSHIP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMSHIP] Performing VerifyExists on WAWFForm...", Logger.MessageType.INF);
				SeleniumControl OEMSHIP_WAWFForm = new SeleniumControl( sDriver, "WAWFForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMSHIP_SOINVCHDR_WAWF_']/ancestor::form[1]");
				Function.AssertEqual(true,OEMSHIP_WAWFForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMSHIP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMSHIP] Performing VerifyExists on WAWF_Invoice...", Logger.MessageType.INF);
				SeleniumControl OEMSHIP_WAWF_Invoice = new SeleniumControl( sDriver, "WAWF_Invoice", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMSHIP_SOINVCHDR_WAWF_']/ancestor::form[1]/descendant::*[@id='SO_INVC_ID']");
				Function.AssertEqual(true,OEMSHIP_WAWF_Invoice.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMSHIP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMSHIP] Performing ClickButton on WAWFForm...", Logger.MessageType.INF);
				SeleniumControl OEMSHIP_WAWFForm = new SeleniumControl( sDriver, "WAWFForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMSHIP_SOINVCHDR_WAWF_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMSHIP_WAWFForm);
IWebElement formBttn = OEMSHIP_WAWFForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? OEMSHIP_WAWFForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
OEMSHIP_WAWFForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMSHIP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMSHIP] Performing VerifyExist on WAWFTable...", Logger.MessageType.INF);
				SeleniumControl OEMSHIP_WAWFTable = new SeleniumControl( sDriver, "WAWFTable", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMSHIP_SOINVCHDR_WAWF_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,OEMSHIP_WAWFTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMSHIP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMSHIP] Performing Close on WAWFForm...", Logger.MessageType.INF);
				SeleniumControl OEMSHIP_WAWFForm = new SeleniumControl( sDriver, "WAWFForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMSHIP_SOINVCHDR_WAWF_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMSHIP_WAWFForm);
IWebElement formBttn = OEMSHIP_WAWFForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Query to populate records in Child Form and Sub Forms");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMSHIP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMSHIP] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl OEMSHIP_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(OEMSHIP_MainForm);
IWebElement formBttn = OEMSHIP_MainForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).Count <= 0 ? OEMSHIP_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Query')]")).FirstOrDefault() :
OEMSHIP_MainForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Query not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "Query";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[Query] Performing Click on Find...", Logger.MessageType.INF);
				SeleniumControl Query_Find = new SeleniumControl( sDriver, "Find", "ID", "submitQ");
				Function.WaitControlDisplayed(Query_Find);
if (Query_Find.mElement.GetAttribute("class") == "popupBtn" && sDriver.BrowserType == "ie")
Query_Find.Click(5,5);
else Query_Find.Click(4.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Child Form");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMSHIP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMSHIP] Performing VerifyExists on ChildForm...", Logger.MessageType.INF);
				SeleniumControl OEMSHIP_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMSHIP_SHIPTRNISSUE_DTL_']/ancestor::form[1]");
				Function.AssertEqual(true,OEMSHIP_ChildForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMSHIP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMSHIP] Performing VerifyExist on ChildForm_ChildTable...", Logger.MessageType.INF);
				SeleniumControl OEMSHIP_ChildForm_ChildTable = new SeleniumControl( sDriver, "ChildForm_ChildTable", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMSHIP_SHIPTRNISSUE_DTL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,OEMSHIP_ChildForm_ChildTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Issue Detail");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMSHIP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMSHIP] Performing VerifyExists on ChildForm_IssueDetailLink...", Logger.MessageType.INF);
				SeleniumControl OEMSHIP_ChildForm_IssueDetailLink = new SeleniumControl( sDriver, "ChildForm_IssueDetailLink", "ID", "lnk_1004379_OEMSHIP_SHIPTRNISSUE_DTL");
				Function.AssertEqual(true,OEMSHIP_ChildForm_IssueDetailLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMSHIP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMSHIP] Performing Click on ChildForm_IssueDetailLink...", Logger.MessageType.INF);
				SeleniumControl OEMSHIP_ChildForm_IssueDetailLink = new SeleniumControl( sDriver, "ChildForm_IssueDetailLink", "ID", "lnk_1004379_OEMSHIP_SHIPTRNISSUE_DTL");
				Function.WaitControlDisplayed(OEMSHIP_ChildForm_IssueDetailLink);
OEMSHIP_ChildForm_IssueDetailLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMSHIP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMSHIP] Performing VerifyExists on ChildForm_IssueDetailForm...", Logger.MessageType.INF);
				SeleniumControl OEMSHIP_ChildForm_IssueDetailForm = new SeleniumControl( sDriver, "ChildForm_IssueDetailForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMSHIP_SOISSUELN_DETAIL_']/ancestor::form[1]");
				Function.AssertEqual(true,OEMSHIP_ChildForm_IssueDetailForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMSHIP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMSHIP] Performing VerifyExist on ChildForm_IssueDetailTable...", Logger.MessageType.INF);
				SeleniumControl OEMSHIP_ChildForm_IssueDetailTable = new SeleniumControl( sDriver, "ChildForm_IssueDetailTable", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMSHIP_SOISSUELN_DETAIL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,OEMSHIP_ChildForm_IssueDetailTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMSHIP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMSHIP] Performing ClickButton on ChildForm_IssueDetailForm...", Logger.MessageType.INF);
				SeleniumControl OEMSHIP_ChildForm_IssueDetailForm = new SeleniumControl( sDriver, "ChildForm_IssueDetailForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMSHIP_SOISSUELN_DETAIL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMSHIP_ChildForm_IssueDetailForm);
IWebElement formBttn = OEMSHIP_ChildForm_IssueDetailForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? OEMSHIP_ChildForm_IssueDetailForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
OEMSHIP_ChildForm_IssueDetailForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMSHIP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMSHIP] Performing VerifyExists on ChildForm_IssueDetail_SOLine...", Logger.MessageType.INF);
				SeleniumControl OEMSHIP_ChildForm_IssueDetail_SOLine = new SeleniumControl( sDriver, "ChildForm_IssueDetail_SOLine", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMSHIP_SOISSUELN_DETAIL_']/ancestor::form[1]/descendant::*[@id='SO_LN_NO']");
				Function.AssertEqual(true,OEMSHIP_ChildForm_IssueDetail_SOLine.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMSHIP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMSHIP] Performing Close on ChildForm_IssueDetailForm...", Logger.MessageType.INF);
				SeleniumControl OEMSHIP_ChildForm_IssueDetailForm = new SeleniumControl( sDriver, "ChildForm_IssueDetailForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMSHIP_SOISSUELN_DETAIL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMSHIP_ChildForm_IssueDetailForm);
IWebElement formBttn = OEMSHIP_ChildForm_IssueDetailForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Line Documents");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Closing Main Form");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMSHIP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMSHIP] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl OEMSHIP_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(OEMSHIP_MainForm);
IWebElement formBttn = OEMSHIP_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

