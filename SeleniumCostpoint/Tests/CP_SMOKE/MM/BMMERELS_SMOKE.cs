 
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
    public class BMMERELS_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Release Multiple Engineering Bills of Material", "xpath","//div[@class='navItem'][.='Release Multiple Engineering Bills of Material']").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SelectMenu]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("MAINFORM");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMERELS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMERELS] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl BMMERELS_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,BMMERELS_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMERELS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMERELS] Performing VerifyExist on MainTable...", Logger.MessageType.INF);
				SeleniumControl BMMERELS_MainTable = new SeleniumControl( sDriver, "MainTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BMMERELS_MainTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMERELS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMERELS] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl BMMERELS_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(BMMERELS_MainForm);
IWebElement formBttn = BMMERELS_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? BMMERELS_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
BMMERELS_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMERELS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMERELS] Performing VerifyExists on AssemblyPart...", Logger.MessageType.INF);
				SeleniumControl BMMERELS_AssemblyPart = new SeleniumControl( sDriver, "AssemblyPart", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PART_ID']");
				Function.AssertEqual(true,BMMERELS_AssemblyPart.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMERELS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMERELS] Performing VerifyExists on BillOfMaterialDetails_MakeBuy...", Logger.MessageType.INF);
				SeleniumControl BMMERELS_BillOfMaterialDetails_MakeBuy = new SeleniumControl( sDriver, "BillOfMaterialDetails_MakeBuy", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='S_MAKE_BUY_CD']");
				Function.AssertEqual(true,BMMERELS_BillOfMaterialDetails_MakeBuy.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMERELS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMERELS] Performing Select on MainTab...", Logger.MessageType.INF);
				SeleniumControl BMMERELS_MainTab = new SeleniumControl( sDriver, "MainTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(BMMERELS_MainTab);
IWebElement mTab = BMMERELS_MainTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Assembly Notes").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMERELS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMERELS] Performing VerifyExists on AssemblyNotes_Notes...", Logger.MessageType.INF);
				SeleniumControl BMMERELS_AssemblyNotes_Notes = new SeleniumControl( sDriver, "AssemblyNotes_Notes", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='EBOM_ASY_NOTES']");
				Function.AssertEqual(true,BMMERELS_AssemblyNotes_Notes.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Components");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMERELS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMERELS] Performing Click on ComponentsLink...", Logger.MessageType.INF);
				SeleniumControl BMMERELS_ComponentsLink = new SeleniumControl( sDriver, "ComponentsLink", "ID", "lnk_1002223_BMMERELS_PART_HDR");
				Function.WaitControlDisplayed(BMMERELS_ComponentsLink);
BMMERELS_ComponentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMERELS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMERELS] Performing VerifyExists on ComponentsForm...", Logger.MessageType.INF);
				SeleniumControl BMMERELS_ComponentsForm = new SeleniumControl( sDriver, "ComponentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMERELS_ENGBOM_DTL_']/ancestor::form[1]");
				Function.AssertEqual(true,BMMERELS_ComponentsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMERELS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMERELS] Performing VerifyExist on ComponentsTable...", Logger.MessageType.INF);
				SeleniumControl BMMERELS_ComponentsTable = new SeleniumControl( sDriver, "ComponentsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMERELS_ENGBOM_DTL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BMMERELS_ComponentsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMERELS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMERELS] Performing ClickButton on ComponentsForm...", Logger.MessageType.INF);
				SeleniumControl BMMERELS_ComponentsForm = new SeleniumControl( sDriver, "ComponentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMERELS_ENGBOM_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BMMERELS_ComponentsForm);
IWebElement formBttn = BMMERELS_ComponentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? BMMERELS_ComponentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
BMMERELS_ComponentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMERELS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMERELS] Performing VerifyExists on Components_LineNo...", Logger.MessageType.INF);
				SeleniumControl BMMERELS_Components_LineNo = new SeleniumControl( sDriver, "Components_LineNo", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMERELS_ENGBOM_DTL_']/ancestor::form[1]/descendant::*[@id='COMP_LN_NO']");
				Function.AssertEqual(true,BMMERELS_Components_LineNo.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMERELS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMERELS] Performing VerifyExists on Components_ComponentInformatiom_Component_UM...", Logger.MessageType.INF);
				SeleniumControl BMMERELS_Components_ComponentInformatiom_Component_UM = new SeleniumControl( sDriver, "Components_ComponentInformatiom_Component_UM", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMERELS_ENGBOM_DTL_']/ancestor::form[1]/descendant::*[@id='UM']");
				Function.AssertEqual(true,BMMERELS_Components_ComponentInformatiom_Component_UM.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMERELS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMERELS] Performing Select on ComponentsTab...", Logger.MessageType.INF);
				SeleniumControl BMMERELS_ComponentsTab = new SeleniumControl( sDriver, "ComponentsTab", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMERELS_ENGBOM_DTL_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(BMMERELS_ComponentsTab);
IWebElement mTab = BMMERELS_ComponentsTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Component Line Notes").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMERELS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMERELS] Performing Close on ComponentsForm...", Logger.MessageType.INF);
				SeleniumControl BMMERELS_ComponentsForm = new SeleniumControl( sDriver, "ComponentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMERELS_ENGBOM_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BMMERELS_ComponentsForm);
IWebElement formBttn = BMMERELS_ComponentsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Part Documents");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMERELS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMERELS] Performing Click on PartDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl BMMERELS_PartDocumentsLink = new SeleniumControl( sDriver, "PartDocumentsLink", "ID", "lnk_1002224_BMMERELS_PART_HDR");
				Function.WaitControlDisplayed(BMMERELS_PartDocumentsLink);
BMMERELS_PartDocumentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMERELS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMERELS] Performing VerifyExists on PartDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl BMMERELS_PartDocumentsForm = new SeleniumControl( sDriver, "PartDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]");
				Function.AssertEqual(true,BMMERELS_PartDocumentsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMERELS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMERELS] Performing VerifyExist on PartDocumentsTable...", Logger.MessageType.INF);
				SeleniumControl BMMERELS_PartDocumentsTable = new SeleniumControl( sDriver, "PartDocumentsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BMMERELS_PartDocumentsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMERELS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMERELS] Performing ClickButton on PartDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl BMMERELS_PartDocumentsForm = new SeleniumControl( sDriver, "PartDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BMMERELS_PartDocumentsForm);
IWebElement formBttn = BMMERELS_PartDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? BMMERELS_PartDocumentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
BMMERELS_PartDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMERELS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMERELS] Performing VerifyExists on PartDocuments_Type...", Logger.MessageType.INF);
				SeleniumControl BMMERELS_PartDocuments_Type = new SeleniumControl( sDriver, "PartDocuments_Type", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]/descendant::*[@id='DOC_TYPE_CD']");
				Function.AssertEqual(true,BMMERELS_PartDocuments_Type.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
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
				Function.CurrentComponent = "BMMERELS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMERELS] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl BMMERELS_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(BMMERELS_MainForm);
IWebElement formBttn = BMMERELS_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

