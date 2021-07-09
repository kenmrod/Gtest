 
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
    public class BMMRDOC_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Product Definition", "xpath","//div[@class='deptItem'][.='Product Definition']").Click();
new SeleniumControl(sDriver,"Documents", "xpath","//div[@class='navItem'][.='Documents']").Click();
new SeleniumControl(sDriver,"Release Documents", "xpath","//div[@class='navItem'][.='Release Documents']").Click();


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
				Function.CurrentComponent = "BMMRDOC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMRDOC] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl BMMRDOC_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,BMMRDOC_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMRDOC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMRDOC] Performing VerifyExists on DocumentID...", Logger.MessageType.INF);
				SeleniumControl BMMRDOC_DocumentID = new SeleniumControl( sDriver, "DocumentID", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='DOCUMENT_ID']");
				Function.AssertEqual(true,BMMRDOC_DocumentID.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMRDOC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMRDOC] Performing Select on MainTab...", Logger.MessageType.INF);
				SeleniumControl BMMRDOC_MainTab = new SeleniumControl( sDriver, "MainTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(BMMRDOC_MainTab);
IWebElement mTab = BMMRDOC_MainTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Document Details").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMRDOC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMRDOC] Performing VerifyExists on DocumentDetails_Status...", Logger.MessageType.INF);
				SeleniumControl BMMRDOC_DocumentDetails_Status = new SeleniumControl( sDriver, "DocumentDetails_Status", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='S_STATUS_TYPE']");
				Function.AssertEqual(true,BMMRDOC_DocumentDetails_Status.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMRDOC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMRDOC] Performing Select on MainTab...", Logger.MessageType.INF);
				SeleniumControl BMMRDOC_MainTab = new SeleniumControl( sDriver, "MainTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(BMMRDOC_MainTab);
IWebElement mTab = BMMRDOC_MainTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Locations").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMRDOC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMRDOC] Performing VerifyExists on Locations_Location...", Logger.MessageType.INF);
				SeleniumControl BMMRDOC_Locations_Location = new SeleniumControl( sDriver, "Locations_Location", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='DOC_LOCATION']");
				Function.AssertEqual(true,BMMRDOC_Locations_Location.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMRDOC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMRDOC] Performing Select on MainTab...", Logger.MessageType.INF);
				SeleniumControl BMMRDOC_MainTab = new SeleniumControl( sDriver, "MainTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(BMMRDOC_MainTab);
IWebElement mTab = BMMRDOC_MainTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Customer/Project Information").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMRDOC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMRDOC] Performing VerifyExists on CustomerPROJECTInformation_CustomerInformation_Customer...", Logger.MessageType.INF);
				SeleniumControl BMMRDOC_CustomerPROJECTInformation_CustomerInformation_Customer = new SeleniumControl( sDriver, "CustomerPROJECTInformation_CustomerInformation_Customer", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='CUST_ID']");
				Function.AssertEqual(true,BMMRDOC_CustomerPROJECTInformation_CustomerInformation_Customer.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMRDOC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMRDOC] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl BMMRDOC_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(BMMRDOC_MainForm);
IWebElement formBttn = BMMRDOC_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? BMMRDOC_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
BMMRDOC_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMRDOC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMRDOC] Performing VerifyExist on MainTable...", Logger.MessageType.INF);
				SeleniumControl BMMRDOC_MainTable = new SeleniumControl( sDriver, "MainTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BMMRDOC_MainTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("PARTS");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMRDOC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMRDOC] Performing VerifyExists on PartsLink...", Logger.MessageType.INF);
				SeleniumControl BMMRDOC_PartsLink = new SeleniumControl( sDriver, "PartsLink", "ID", "lnk_1006789_MMMMDOC_DOCUMENT_DOCUMENT");
				Function.AssertEqual(true,BMMRDOC_PartsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMRDOC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMRDOC] Performing Click on PartsLink...", Logger.MessageType.INF);
				SeleniumControl BMMRDOC_PartsLink = new SeleniumControl( sDriver, "PartsLink", "ID", "lnk_1006789_MMMMDOC_DOCUMENT_DOCUMENT");
				Function.WaitControlDisplayed(BMMRDOC_PartsLink);
BMMRDOC_PartsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMRDOC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMRDOC] Performing VerifyExist on PartsTable...", Logger.MessageType.INF);
				SeleniumControl BMMRDOC_PartsTable = new SeleniumControl( sDriver, "PartsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMMDOC_PARTDOCUMENT_PARTS_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BMMRDOC_PartsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMRDOC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMRDOC] Performing ClickButton on PartsForm...", Logger.MessageType.INF);
				SeleniumControl BMMRDOC_PartsForm = new SeleniumControl( sDriver, "PartsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMMDOC_PARTDOCUMENT_PARTS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BMMRDOC_PartsForm);
IWebElement formBttn = BMMRDOC_PartsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? BMMRDOC_PartsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
BMMRDOC_PartsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMRDOC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMRDOC] Performing VerifyExists on PartsForm...", Logger.MessageType.INF);
				SeleniumControl BMMRDOC_PartsForm = new SeleniumControl( sDriver, "PartsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMMDOC_PARTDOCUMENT_PARTS_']/ancestor::form[1]");
				Function.AssertEqual(true,BMMRDOC_PartsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMRDOC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMRDOC] Performing VerifyExists on Parts_Part...", Logger.MessageType.INF);
				SeleniumControl BMMRDOC_Parts_Part = new SeleniumControl( sDriver, "Parts_Part", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMMDOC_PARTDOCUMENT_PARTS_']/ancestor::form[1]/descendant::*[@id='PART_ID']");
				Function.AssertEqual(true,BMMRDOC_Parts_Part.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMRDOC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMRDOC] Performing Close on PartsForm...", Logger.MessageType.INF);
				SeleniumControl BMMRDOC_PartsForm = new SeleniumControl( sDriver, "PartsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMMDOC_PARTDOCUMENT_PARTS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BMMRDOC_PartsForm);
IWebElement formBttn = BMMRDOC_PartsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("TEXT");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMRDOC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMRDOC] Performing VerifyExists on TextLink...", Logger.MessageType.INF);
				SeleniumControl BMMRDOC_TextLink = new SeleniumControl( sDriver, "TextLink", "ID", "lnk_1001726_MMMMDOC_DOCUMENT_DOCUMENT");
				Function.AssertEqual(true,BMMRDOC_TextLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMRDOC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMRDOC] Performing Click on TextLink...", Logger.MessageType.INF);
				SeleniumControl BMMRDOC_TextLink = new SeleniumControl( sDriver, "TextLink", "ID", "lnk_1001726_MMMMDOC_DOCUMENT_DOCUMENT");
				Function.WaitControlDisplayed(BMMRDOC_TextLink);
BMMRDOC_TextLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMRDOC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMRDOC] Performing VerifyExist on TextTable...", Logger.MessageType.INF);
				SeleniumControl BMMRDOC_TextTable = new SeleniumControl( sDriver, "TextTable", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMMDOC_DOCUMENTTEXT_TEXT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BMMRDOC_TextTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMRDOC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMRDOC] Performing VerifyExists on TextForm...", Logger.MessageType.INF);
				SeleniumControl BMMRDOC_TextForm = new SeleniumControl( sDriver, "TextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMMDOC_DOCUMENTTEXT_TEXT_']/ancestor::form[1]");
				Function.AssertEqual(true,BMMRDOC_TextForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMRDOC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMRDOC] Performing Close on TextForm...", Logger.MessageType.INF);
				SeleniumControl BMMRDOC_TextForm = new SeleniumControl( sDriver, "TextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMMDOC_DOCUMENTTEXT_TEXT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BMMRDOC_TextForm);
IWebElement formBttn = BMMRDOC_TextForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "BMMRDOC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMRDOC] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl BMMRDOC_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(BMMRDOC_MainForm);
IWebElement formBttn = BMMRDOC_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

