 
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
    public class BMMMRELS_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Bills of Material", "xpath","//div[@class='deptItem'][.='Bills of Material']").Click();
new SeleniumControl(sDriver,"Bills of Material", "xpath","//div[@class='navItem'][.='Bills of Material']").Click();
new SeleniumControl(sDriver,"Release Multiple Manufacturing Bills of Material", "xpath","//div[@class='navItem'][.='Release Multiple Manufacturing Bills of Material']").Click();


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
				Function.CurrentComponent = "BMMMRELS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMRELS] Performing VerifyExist on MainTable...", Logger.MessageType.INF);
				SeleniumControl BMMMRELS_MainTable = new SeleniumControl( sDriver, "MainTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BMMMRELS_MainTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMMRELS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMRELS] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl BMMMRELS_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(BMMMRELS_MainForm);
IWebElement formBttn = BMMMRELS_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? BMMMRELS_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
BMMMRELS_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMMRELS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMRELS] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl BMMMRELS_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,BMMMRELS_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMMRELS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMRELS] Performing VerifyExists on AssemblyPart_AssemblyPart...", Logger.MessageType.INF);
				SeleniumControl BMMMRELS_AssemblyPart_AssemblyPart = new SeleniumControl( sDriver, "AssemblyPart_AssemblyPart", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PART_ID']");
				Function.AssertEqual(true,BMMMRELS_AssemblyPart_AssemblyPart.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("COMPONENTS ");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMMRELS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMRELS] Performing VerifyExists on ComponentsLink...", Logger.MessageType.INF);
				SeleniumControl BMMMRELS_ComponentsLink = new SeleniumControl( sDriver, "ComponentsLink", "ID", "lnk_1002193_BMMMRELS_HDR");
				Function.AssertEqual(true,BMMMRELS_ComponentsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMMRELS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMRELS] Performing Click on ComponentsLink...", Logger.MessageType.INF);
				SeleniumControl BMMMRELS_ComponentsLink = new SeleniumControl( sDriver, "ComponentsLink", "ID", "lnk_1002193_BMMMRELS_HDR");
				Function.WaitControlDisplayed(BMMMRELS_ComponentsLink);
BMMMRELS_ComponentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMMRELS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMRELS] Performing VerifyExist on ComponentsTable...", Logger.MessageType.INF);
				SeleniumControl BMMMRELS_ComponentsTable = new SeleniumControl( sDriver, "ComponentsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMMRELS_COMPONENTS_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BMMMRELS_ComponentsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMMRELS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMRELS] Performing ClickButton on ComponentsForm...", Logger.MessageType.INF);
				SeleniumControl BMMMRELS_ComponentsForm = new SeleniumControl( sDriver, "ComponentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMMRELS_COMPONENTS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BMMMRELS_ComponentsForm);
IWebElement formBttn = BMMMRELS_ComponentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? BMMMRELS_ComponentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
BMMMRELS_ComponentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMMRELS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMRELS] Performing VerifyExists on ComponentsForm...", Logger.MessageType.INF);
				SeleniumControl BMMMRELS_ComponentsForm = new SeleniumControl( sDriver, "ComponentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMMRELS_COMPONENTS_']/ancestor::form[1]");
				Function.AssertEqual(true,BMMMRELS_ComponentsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMMRELS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMRELS] Performing VerifyExists on Components_LineNo...", Logger.MessageType.INF);
				SeleniumControl BMMMRELS_Components_LineNo = new SeleniumControl( sDriver, "Components_LineNo", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMMRELS_COMPONENTS_']/ancestor::form[1]/descendant::*[@id='COMP_LN_NO']");
				Function.AssertEqual(true,BMMMRELS_Components_LineNo.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMMRELS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMRELS] Performing Select on ComponentsTab...", Logger.MessageType.INF);
				SeleniumControl BMMMRELS_ComponentsTab = new SeleniumControl( sDriver, "ComponentsTab", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMMRELS_COMPONENTS_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(BMMMRELS_ComponentsTab);
IWebElement mTab = BMMMRELS_ComponentsTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Component Information").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMMRELS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMRELS] Performing VerifyExists on Components_ComponentInformation_Component_PartStatus...", Logger.MessageType.INF);
				SeleniumControl BMMMRELS_Components_ComponentInformation_Component_PartStatus = new SeleniumControl( sDriver, "Components_ComponentInformation_Component_PartStatus", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMMRELS_COMPONENTS_']/ancestor::form[1]/descendant::*[@id='S_STATUS_DESC']");
				Function.AssertEqual(true,BMMMRELS_Components_ComponentInformation_Component_PartStatus.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMMRELS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMRELS] Performing Select on ComponentsTab...", Logger.MessageType.INF);
				SeleniumControl BMMMRELS_ComponentsTab = new SeleniumControl( sDriver, "ComponentsTab", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMMRELS_COMPONENTS_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(BMMMRELS_ComponentsTab);
IWebElement mTab = BMMMRELS_ComponentsTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Component Line Notes").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMMRELS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMRELS] Performing Close on ComponentsForm...", Logger.MessageType.INF);
				SeleniumControl BMMMRELS_ComponentsForm = new SeleniumControl( sDriver, "ComponentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMMRELS_COMPONENTS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BMMMRELS_ComponentsForm);
IWebElement formBttn = BMMMRELS_ComponentsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("PART DOCUMENTS");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMMRELS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMRELS] Performing VerifyExists on PartDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl BMMMRELS_PartDocumentsLink = new SeleniumControl( sDriver, "PartDocumentsLink", "ID", "lnk_1002194_BMMMRELS_HDR");
				Function.AssertEqual(true,BMMMRELS_PartDocumentsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMMRELS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMRELS] Performing Click on PartDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl BMMMRELS_PartDocumentsLink = new SeleniumControl( sDriver, "PartDocumentsLink", "ID", "lnk_1002194_BMMMRELS_HDR");
				Function.WaitControlDisplayed(BMMMRELS_PartDocumentsLink);
BMMMRELS_PartDocumentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMMRELS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMRELS] Performing VerifyExist on PartDocumentsTable...", Logger.MessageType.INF);
				SeleniumControl BMMMRELS_PartDocumentsTable = new SeleniumControl( sDriver, "PartDocumentsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BMMMRELS_PartDocumentsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMMRELS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMRELS] Performing ClickButton on PartDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl BMMMRELS_PartDocumentsForm = new SeleniumControl( sDriver, "PartDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BMMMRELS_PartDocumentsForm);
IWebElement formBttn = BMMMRELS_PartDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? BMMMRELS_PartDocumentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
BMMMRELS_PartDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMMRELS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMRELS] Performing VerifyExists on PartDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl BMMMRELS_PartDocumentsForm = new SeleniumControl( sDriver, "PartDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]");
				Function.AssertEqual(true,BMMMRELS_PartDocumentsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMMRELS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMRELS] Performing VerifyExists on PartDocuments_Type...", Logger.MessageType.INF);
				SeleniumControl BMMMRELS_PartDocuments_Type = new SeleniumControl( sDriver, "PartDocuments_Type", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]/descendant::*[@id='DOC_TYPE_CD']");
				Function.AssertEqual(true,BMMMRELS_PartDocuments_Type.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMMRELS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMRELS] Performing Close on PartDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl BMMMRELS_PartDocumentsForm = new SeleniumControl( sDriver, "PartDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BMMMRELS_PartDocumentsForm);
IWebElement formBttn = BMMMRELS_PartDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("CLOSE APPLICATION");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMMRELS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMRELS] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl BMMMRELS_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(BMMMRELS_MainForm);
IWebElement formBttn = BMMMRELS_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

