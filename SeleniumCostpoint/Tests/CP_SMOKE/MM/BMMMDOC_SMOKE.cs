 
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
    public class BMMMDOC_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Manage Documents", "xpath","//div[@class='navItem'][.='Manage Documents']").Click();


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
				Function.CurrentComponent = "BMMMDOC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMDOC] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl BMMMDOC_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,BMMMDOC_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMMDOC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMDOC] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl BMMMDOC_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(BMMMDOC_MainForm);
IWebElement formBttn = BMMMDOC_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? BMMMDOC_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
BMMMDOC_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMMDOC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMDOC] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl BMMMDOC_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BMMMDOC_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMMDOC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMDOC] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl BMMMDOC_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(BMMMDOC_MainForm);
IWebElement formBttn = BMMMDOC_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? BMMMDOC_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
BMMMDOC_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMMDOC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMDOC] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl BMMMDOC_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(BMMMDOC_MainFormTab);
IWebElement mTab = BMMMDOC_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Document Details").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMMDOC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMDOC] Performing VerifyExists on DocumentID...", Logger.MessageType.INF);
				SeleniumControl BMMMDOC_DocumentID = new SeleniumControl( sDriver, "DocumentID", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='DOCUMENT_ID']");
				Function.AssertEqual(true,BMMMDOC_DocumentID.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMMDOC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMDOC] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl BMMMDOC_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(BMMMDOC_MainFormTab);
IWebElement mTab = BMMMDOC_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Locations").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMMDOC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMDOC] Performing VerifyExists on Locations_Location...", Logger.MessageType.INF);
				SeleniumControl BMMMDOC_Locations_Location = new SeleniumControl( sDriver, "Locations_Location", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='DOC_LOCATION']");
				Function.AssertEqual(true,BMMMDOC_Locations_Location.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMMDOC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMDOC] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl BMMMDOC_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(BMMMDOC_MainFormTab);
IWebElement mTab = BMMMDOC_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Customer/Project Information").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMMDOC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMDOC] Performing VerifyExists on CustomerProjectInformation_CustomerInformation_Customer...", Logger.MessageType.INF);
				SeleniumControl BMMMDOC_CustomerProjectInformation_CustomerInformation_Customer = new SeleniumControl( sDriver, "CustomerProjectInformation_CustomerInformation_Customer", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='CUST_ID']");
				Function.AssertEqual(true,BMMMDOC_CustomerProjectInformation_CustomerInformation_Customer.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMMDOC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMDOC] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl BMMMDOC_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(BMMMDOC_MainFormTab);
IWebElement mTab = BMMMDOC_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Document Details").FirstOrDefault();
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
				this.ScriptLogger.WriteLine("Parts");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMMDOC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMDOC] Performing VerifyExists on PartsLink...", Logger.MessageType.INF);
				SeleniumControl BMMMDOC_PartsLink = new SeleniumControl( sDriver, "PartsLink", "ID", "lnk_1006789_MMMMDOC_DOCUMENT_DOCUMENT");
				Function.AssertEqual(true,BMMMDOC_PartsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMMDOC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMDOC] Performing Click on PartsLink...", Logger.MessageType.INF);
				SeleniumControl BMMMDOC_PartsLink = new SeleniumControl( sDriver, "PartsLink", "ID", "lnk_1006789_MMMMDOC_DOCUMENT_DOCUMENT");
				Function.WaitControlDisplayed(BMMMDOC_PartsLink);
BMMMDOC_PartsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMMDOC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMDOC] Performing VerifyExist on PartsFormTable...", Logger.MessageType.INF);
				SeleniumControl BMMMDOC_PartsFormTable = new SeleniumControl( sDriver, "PartsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMMDOC_PARTDOCUMENT_PARTS_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BMMMDOC_PartsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMMDOC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMDOC] Performing VerifyExists on PartsForm...", Logger.MessageType.INF);
				SeleniumControl BMMMDOC_PartsForm = new SeleniumControl( sDriver, "PartsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMMDOC_PARTDOCUMENT_PARTS_']/ancestor::form[1]");
				Function.AssertEqual(true,BMMMDOC_PartsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMMDOC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMDOC] Performing ClickButton on PartsForm...", Logger.MessageType.INF);
				SeleniumControl BMMMDOC_PartsForm = new SeleniumControl( sDriver, "PartsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMMDOC_PARTDOCUMENT_PARTS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BMMMDOC_PartsForm);
IWebElement formBttn = BMMMDOC_PartsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? BMMMDOC_PartsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
BMMMDOC_PartsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMMDOC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMDOC] Performing VerifyExists on Parts_Part...", Logger.MessageType.INF);
				SeleniumControl BMMMDOC_Parts_Part = new SeleniumControl( sDriver, "Parts_Part", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMMDOC_PARTDOCUMENT_PARTS_']/ancestor::form[1]/descendant::*[@id='PART_ID']");
				Function.AssertEqual(true,BMMMDOC_Parts_Part.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMMDOC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMDOC] Performing Close on PartsForm...", Logger.MessageType.INF);
				SeleniumControl BMMMDOC_PartsForm = new SeleniumControl( sDriver, "PartsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMMDOC_PARTDOCUMENT_PARTS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BMMMDOC_PartsForm);
IWebElement formBttn = BMMMDOC_PartsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Text");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMMDOC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMDOC] Performing VerifyExists on TextLink...", Logger.MessageType.INF);
				SeleniumControl BMMMDOC_TextLink = new SeleniumControl( sDriver, "TextLink", "ID", "lnk_1001726_MMMMDOC_DOCUMENT_DOCUMENT");
				Function.AssertEqual(true,BMMMDOC_TextLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMMDOC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMDOC] Performing Click on TextLink...", Logger.MessageType.INF);
				SeleniumControl BMMMDOC_TextLink = new SeleniumControl( sDriver, "TextLink", "ID", "lnk_1001726_MMMMDOC_DOCUMENT_DOCUMENT");
				Function.WaitControlDisplayed(BMMMDOC_TextLink);
BMMMDOC_TextLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMMDOC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMDOC] Performing VerifyExist on TextFormTable...", Logger.MessageType.INF);
				SeleniumControl BMMMDOC_TextFormTable = new SeleniumControl( sDriver, "TextFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMMDOC_DOCUMENTTEXT_TEXT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BMMMDOC_TextFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMMDOC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMDOC] Performing VerifyExists on TextForm...", Logger.MessageType.INF);
				SeleniumControl BMMMDOC_TextForm = new SeleniumControl( sDriver, "TextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMMDOC_DOCUMENTTEXT_TEXT_']/ancestor::form[1]");
				Function.AssertEqual(true,BMMMDOC_TextForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMMDOC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMDOC] Performing Close on TextForm...", Logger.MessageType.INF);
				SeleniumControl BMMMDOC_TextForm = new SeleniumControl( sDriver, "TextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMMDOC_DOCUMENTTEXT_TEXT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BMMMDOC_TextForm);
IWebElement formBttn = BMMMDOC_TextForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Close Main Form");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMMDOC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMDOC] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl BMMMDOC_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(BMMMDOC_MainForm);
IWebElement formBttn = BMMMDOC_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

