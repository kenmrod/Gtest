 
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
    public class BMMEBOM1_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Manage Engineering Bills of Material", "xpath","//div[@class='navItem'][.='Manage Engineering Bills of Material']").Click();


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
				Function.CurrentComponent = "BMMEBOM1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM1] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM1_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(BMMEBOM1_MainForm);
IWebElement formBttn = BMMEBOM1_MainForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).Count <= 0 ? BMMEBOM1_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Query')]")).FirstOrDefault() :
BMMEBOM1_MainForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).FirstOrDefault();
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
								try {
				Function.CurrentComponent = "BMMEBOM1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM1] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM1_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BMMEBOM1_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM1] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM1_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(BMMEBOM1_MainForm);
IWebElement formBttn = BMMEBOM1_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? BMMEBOM1_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
BMMEBOM1_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM1] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM1_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,BMMEBOM1_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM1] Performing VerifyExists on Identification_AssemblyPart...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM1_Identification_AssemblyPart = new SeleniumControl( sDriver, "Identification_AssemblyPart", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PART_ID']");
				Function.AssertEqual(true,BMMEBOM1_Identification_AssemblyPart.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Configuration");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM1] Performing VerifyExists on Identification_ConfigurationLink...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM1_Identification_ConfigurationLink = new SeleniumControl( sDriver, "Identification_ConfigurationLink", "ID", "lnk_4024_BMMEBOM_PART_HDR");
				Function.AssertEqual(true,BMMEBOM1_Identification_ConfigurationLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM1] Performing Click on Identification_ConfigurationLink...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM1_Identification_ConfigurationLink = new SeleniumControl( sDriver, "Identification_ConfigurationLink", "ID", "lnk_4024_BMMEBOM_PART_HDR");
				Function.WaitControlDisplayed(BMMEBOM1_Identification_ConfigurationLink);
BMMEBOM1_Identification_ConfigurationLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM1] Performing VerifyExists on ConfigurationForm...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM1_ConfigurationForm = new SeleniumControl( sDriver, "ConfigurationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BM_CONFIG_IDENTIFIERS_']/ancestor::form[1]");
				Function.AssertEqual(true,BMMEBOM1_ConfigurationForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM1] Performing VerifyExists on Configuration_ShowAllConfigurations...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM1_Configuration_ShowAllConfigurations = new SeleniumControl( sDriver, "Configuration_ShowAllConfigurations", "xpath", "//div[translate(@id,'0123456789','')='pr__BM_CONFIG_IDENTIFIERS_']/ancestor::form[1]/descendant::*[@id='SHOW_ALL_CONFIG']");
				Function.AssertEqual(true,BMMEBOM1_Configuration_ShowAllConfigurations.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM1] Performing Close on ConfigurationForm...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM1_ConfigurationForm = new SeleniumControl( sDriver, "ConfigurationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BM_CONFIG_IDENTIFIERS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BMMEBOM1_ConfigurationForm);
IWebElement formBttn = BMMEBOM1_ConfigurationForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Assembly Serial Numbers");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM1] Performing VerifyExists on Identification_AssemblySerialNumbersLink...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM1_Identification_AssemblySerialNumbersLink = new SeleniumControl( sDriver, "Identification_AssemblySerialNumbersLink", "ID", "lnk_4035_BMMEBOM_PART_HDR");
				Function.AssertEqual(true,BMMEBOM1_Identification_AssemblySerialNumbersLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM1] Performing Click on Identification_AssemblySerialNumbersLink...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM1_Identification_AssemblySerialNumbersLink = new SeleniumControl( sDriver, "Identification_AssemblySerialNumbersLink", "ID", "lnk_4035_BMMEBOM_PART_HDR");
				Function.WaitControlDisplayed(BMMEBOM1_Identification_AssemblySerialNumbersLink);
BMMEBOM1_Identification_AssemblySerialNumbersLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM1] Performing VerifyExist on AssemblySerialNumbersTable...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM1_AssemblySerialNumbersTable = new SeleniumControl( sDriver, "AssemblySerialNumbersTable", "xpath", "//div[translate(@id,'0123456789','')='pr__BM_ENDPARTCONFIG_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BMMEBOM1_AssemblySerialNumbersTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM1] Performing VerifyExists on AssemblySerialNumbers_Ok...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM1_AssemblySerialNumbers_Ok = new SeleniumControl( sDriver, "AssemblySerialNumbers_Ok", "xpath", "//div[translate(@id,'0123456789','')='pr__BM_ENDPARTCONFIG_CTW_']/ancestor::form[1]/following-sibling::div[1]/descendant::*[@id='bOk']");
				Function.AssertEqual(true,BMMEBOM1_AssemblySerialNumbers_Ok.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM1] Performing Close on AssemblySerialNumbersForm...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM1_AssemblySerialNumbersForm = new SeleniumControl( sDriver, "AssemblySerialNumbersForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BM_ENDPARTCONFIG_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BMMEBOM1_AssemblySerialNumbersForm);
IWebElement formBttn = BMMEBOM1_AssemblySerialNumbersForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "BMMEBOM1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM1] Performing VerifyExists on Identification_PartDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM1_Identification_PartDocumentsLink = new SeleniumControl( sDriver, "Identification_PartDocumentsLink", "ID", "lnk_4027_BMMEBOM_PART_HDR");
				Function.AssertEqual(true,BMMEBOM1_Identification_PartDocumentsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM1] Performing Click on Identification_PartDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM1_Identification_PartDocumentsLink = new SeleniumControl( sDriver, "Identification_PartDocumentsLink", "ID", "lnk_4027_BMMEBOM_PART_HDR");
				Function.WaitControlDisplayed(BMMEBOM1_Identification_PartDocumentsLink);
BMMEBOM1_Identification_PartDocumentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM1] Performing VerifyExist on PartDocumentsTable...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM1_PartDocumentsTable = new SeleniumControl( sDriver, "PartDocumentsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BMMEBOM1_PartDocumentsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM1] Performing ClickButton on PartDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM1_PartDocumentsForm = new SeleniumControl( sDriver, "PartDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BMMEBOM1_PartDocumentsForm);
IWebElement formBttn = BMMEBOM1_PartDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? BMMEBOM1_PartDocumentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
BMMEBOM1_PartDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM1] Performing VerifyExists on PartDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM1_PartDocumentsForm = new SeleniumControl( sDriver, "PartDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]");
				Function.AssertEqual(true,BMMEBOM1_PartDocumentsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM1] Performing VerifyExists on PartDocuments_Type...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM1_PartDocuments_Type = new SeleniumControl( sDriver, "PartDocuments_Type", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]/descendant::*[@id='DOC_TYPE_CD']");
				Function.AssertEqual(true,BMMEBOM1_PartDocuments_Type.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM1] Performing Close on PartDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM1_PartDocumentsForm = new SeleniumControl( sDriver, "PartDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BMMEBOM1_PartDocumentsForm);
IWebElement formBttn = BMMEBOM1_PartDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Clone EBOM Lines");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM1] Performing VerifyExists on Identification_CloneEBOMLinesLink...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM1_Identification_CloneEBOMLinesLink = new SeleniumControl( sDriver, "Identification_CloneEBOMLinesLink", "ID", "lnk_4083_BMMEBOM_PART_HDR");
				Function.AssertEqual(true,BMMEBOM1_Identification_CloneEBOMLinesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM1] Performing Click on Identification_CloneEBOMLinesLink...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM1_Identification_CloneEBOMLinesLink = new SeleniumControl( sDriver, "Identification_CloneEBOMLinesLink", "ID", "lnk_4083_BMMEBOM_PART_HDR");
				Function.WaitControlDisplayed(BMMEBOM1_Identification_CloneEBOMLinesLink);
BMMEBOM1_Identification_CloneEBOMLinesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM1] Performing VerifyExists on CloneEBOMLinesForm...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM1_CloneEBOMLinesForm = new SeleniumControl( sDriver, "CloneEBOMLinesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMEBOM_EBOM_CLONE_']/ancestor::form[1]");
				Function.AssertEqual(true,BMMEBOM1_CloneEBOMLinesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM1] Performing VerifyExists on CloneEBOMLines_FromAssemblyPart...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM1_CloneEBOMLines_FromAssemblyPart = new SeleniumControl( sDriver, "CloneEBOMLines_FromAssemblyPart", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMEBOM_EBOM_CLONE_']/ancestor::form[1]/descendant::*[@id='PART_ID']");
				Function.AssertEqual(true,BMMEBOM1_CloneEBOMLines_FromAssemblyPart.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM1] Performing ClickButton on CloneEBOMLinesForm...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM1_CloneEBOMLinesForm = new SeleniumControl( sDriver, "CloneEBOMLinesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMEBOM_EBOM_CLONE_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BMMEBOM1_CloneEBOMLinesForm);
IWebElement formBttn = BMMEBOM1_CloneEBOMLinesForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? BMMEBOM1_CloneEBOMLinesForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
BMMEBOM1_CloneEBOMLinesForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM1] Performing VerifyExist on CloneEBOMLinesTable...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM1_CloneEBOMLinesTable = new SeleniumControl( sDriver, "CloneEBOMLinesTable", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMEBOM_EBOM_CLONE_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BMMEBOM1_CloneEBOMLinesTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM1] Performing Close on CloneEBOMLinesForm...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM1_CloneEBOMLinesForm = new SeleniumControl( sDriver, "CloneEBOMLinesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMEBOM_EBOM_CLONE_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BMMEBOM1_CloneEBOMLinesForm);
IWebElement formBttn = BMMEBOM1_CloneEBOMLinesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Create Provisional Part");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM1] Performing VerifyExists on CreateProvisionalPartLink...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM1_CreateProvisionalPartLink = new SeleniumControl( sDriver, "CreateProvisionalPartLink", "ID", "lnk_16811_BMMEBOM_PART_HDR");
				Function.AssertEqual(true,BMMEBOM1_CreateProvisionalPartLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM1] Performing Click on CreateProvisionalPartLink...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM1_CreateProvisionalPartLink = new SeleniumControl( sDriver, "CreateProvisionalPartLink", "ID", "lnk_16811_BMMEBOM_PART_HDR");
				Function.WaitControlDisplayed(BMMEBOM1_CreateProvisionalPartLink);
BMMEBOM1_CreateProvisionalPartLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM1] Performing VerifyExists on CreateProvisionalPartForm...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM1_CreateProvisionalPartForm = new SeleniumControl( sDriver, "CreateProvisionalPartForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMEBOM_CREATE_PROVPART_']/ancestor::form[1]");
				Function.AssertEqual(true,BMMEBOM1_CreateProvisionalPartForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM1] Performing VerifyExists on CreateProvisionalPart_PartID...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM1_CreateProvisionalPart_PartID = new SeleniumControl( sDriver, "CreateProvisionalPart_PartID", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMEBOM_CREATE_PROVPART_']/ancestor::form[1]/descendant::*[@id='PROV_PART_ID']");
				Function.AssertEqual(true,BMMEBOM1_CreateProvisionalPart_PartID.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM1] Performing ClickButton on CreateProvisionalPartForm...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM1_CreateProvisionalPartForm = new SeleniumControl( sDriver, "CreateProvisionalPartForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMEBOM_CREATE_PROVPART_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BMMEBOM1_CreateProvisionalPartForm);
IWebElement formBttn = BMMEBOM1_CreateProvisionalPartForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? BMMEBOM1_CreateProvisionalPartForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
BMMEBOM1_CreateProvisionalPartForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM1] Performing VerifyExist on CreateProvisionalPartFormTable...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM1_CreateProvisionalPartFormTable = new SeleniumControl( sDriver, "CreateProvisionalPartFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMEBOM_CREATE_PROVPART_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BMMEBOM1_CreateProvisionalPartFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM1] Performing Close on CreateProvisionalPartForm...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM1_CreateProvisionalPartForm = new SeleniumControl( sDriver, "CreateProvisionalPartForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMEBOM_CREATE_PROVPART_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BMMEBOM1_CreateProvisionalPartForm);
IWebElement formBttn = BMMEBOM1_CreateProvisionalPartForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("EBOM Line");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM1] Performing VerifyExist on EBOMLineTable...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM1_EBOMLineTable = new SeleniumControl( sDriver, "EBOMLineTable", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMEBOM_ENGBOM_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BMMEBOM1_EBOMLineTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM1] Performing ClickButton on EBOMLineForm...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM1_EBOMLineForm = new SeleniumControl( sDriver, "EBOMLineForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMEBOM_ENGBOM_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BMMEBOM1_EBOMLineForm);
IWebElement formBttn = BMMEBOM1_EBOMLineForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? BMMEBOM1_EBOMLineForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
BMMEBOM1_EBOMLineForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM1] Performing VerifyExists on EBOMLineForm...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM1_EBOMLineForm = new SeleniumControl( sDriver, "EBOMLineForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMEBOM_ENGBOM_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,BMMEBOM1_EBOMLineForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM1] Performing VerifyExists on EBOMLine_LineNo...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM1_EBOMLine_LineNo = new SeleniumControl( sDriver, "EBOMLine_LineNo", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMEBOM_ENGBOM_CTW_']/ancestor::form[1]/descendant::*[@id='COMP_LN_NO']");
				Function.AssertEqual(true,BMMEBOM1_EBOMLine_LineNo.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM1] Performing Select on EBOMLineTab...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM1_EBOMLineTab = new SeleniumControl( sDriver, "EBOMLineTab", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMEBOM_ENGBOM_CTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(BMMEBOM1_EBOMLineTab);
IWebElement mTab = BMMEBOM1_EBOMLineTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Component Information").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM1] Performing VerifyExists on EBOMLine_ComponentInformation_Component_PartStatus...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM1_EBOMLine_ComponentInformation_Component_PartStatus = new SeleniumControl( sDriver, "EBOMLine_ComponentInformation_Component_PartStatus", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMEBOM_ENGBOM_CTW_']/ancestor::form[1]/descendant::*[@id='S_STATUS_TYPE']");
				Function.AssertEqual(true,BMMEBOM1_EBOMLine_ComponentInformation_Component_PartStatus.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM1] Performing Select on EBOMLineTab...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM1_EBOMLineTab = new SeleniumControl( sDriver, "EBOMLineTab", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMEBOM_ENGBOM_CTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(BMMEBOM1_EBOMLineTab);
IWebElement mTab = BMMEBOM1_EBOMLineTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Component Comments").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM1] Performing VerifyExists on ComponentComments_Comments...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM1_ComponentComments_Comments = new SeleniumControl( sDriver, "ComponentComments_Comments", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMEBOM_ENGBOM_CTW_']/ancestor::form[1]/descendant::*[@id='COMP_LN_NT']");
				Function.AssertEqual(true,BMMEBOM1_ComponentComments_Comments.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Reference Designators");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM1] Performing VerifyExists on EBOMLine_ReferenceDesignatorsLink...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM1_EBOMLine_ReferenceDesignatorsLink = new SeleniumControl( sDriver, "EBOMLine_ReferenceDesignatorsLink", "ID", "lnk_4036_BMMEBOM_ENGBOM_CTW");
				Function.AssertEqual(true,BMMEBOM1_EBOMLine_ReferenceDesignatorsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM1] Performing Click on EBOMLine_ReferenceDesignatorsLink...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM1_EBOMLine_ReferenceDesignatorsLink = new SeleniumControl( sDriver, "EBOMLine_ReferenceDesignatorsLink", "ID", "lnk_4036_BMMEBOM_ENGBOM_CTW");
				Function.WaitControlDisplayed(BMMEBOM1_EBOMLine_ReferenceDesignatorsLink);
BMMEBOM1_EBOMLine_ReferenceDesignatorsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM1] Performing VerifyExists on ReferenceDesignatorsForm...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM1_ReferenceDesignatorsForm = new SeleniumControl( sDriver, "ReferenceDesignatorsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMEBOM_ENGBOMREF_']/ancestor::form[1]");
				Function.AssertEqual(true,BMMEBOM1_ReferenceDesignatorsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM1] Performing Close on ReferenceDesignatorsForm...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM1_ReferenceDesignatorsForm = new SeleniumControl( sDriver, "ReferenceDesignatorsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMEBOM_ENGBOMREF_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BMMEBOM1_ReferenceDesignatorsForm);
IWebElement formBttn = BMMEBOM1_ReferenceDesignatorsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Component Text");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM1] Performing VerifyExists on EBOMLine_ComponentTextLink...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM1_EBOMLine_ComponentTextLink = new SeleniumControl( sDriver, "EBOMLine_ComponentTextLink", "ID", "lnk_4030_BMMEBOM_ENGBOM_CTW");
				Function.AssertEqual(true,BMMEBOM1_EBOMLine_ComponentTextLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM1] Performing Click on EBOMLine_ComponentTextLink...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM1_EBOMLine_ComponentTextLink = new SeleniumControl( sDriver, "EBOMLine_ComponentTextLink", "ID", "lnk_4030_BMMEBOM_ENGBOM_CTW");
				Function.WaitControlDisplayed(BMMEBOM1_EBOMLine_ComponentTextLink);
BMMEBOM1_EBOMLine_ComponentTextLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM1] Performing VerifyExist on ComponentTextTable...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM1_ComponentTextTable = new SeleniumControl( sDriver, "ComponentTextTable", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMEBOM_ENGBOMTEXT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BMMEBOM1_ComponentTextTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM1] Performing ClickButton on ComponentTextForm...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM1_ComponentTextForm = new SeleniumControl( sDriver, "ComponentTextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMEBOM_ENGBOMTEXT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BMMEBOM1_ComponentTextForm);
IWebElement formBttn = BMMEBOM1_ComponentTextForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? BMMEBOM1_ComponentTextForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
BMMEBOM1_ComponentTextForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM1] Performing VerifyExists on ComponentTextForm...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM1_ComponentTextForm = new SeleniumControl( sDriver, "ComponentTextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMEBOM_ENGBOMTEXT_']/ancestor::form[1]");
				Function.AssertEqual(true,BMMEBOM1_ComponentTextForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM1] Performing VerifyExists on ComponentText_Sequence...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM1_ComponentText_Sequence = new SeleniumControl( sDriver, "ComponentText_Sequence", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMEBOM_ENGBOMTEXT_']/ancestor::form[1]/descendant::*[@id='SEQ_NO']");
				Function.AssertEqual(true,BMMEBOM1_ComponentText_Sequence.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM1] Performing Close on ComponentTextForm...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM1_ComponentTextForm = new SeleniumControl( sDriver, "ComponentTextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMEBOM_ENGBOMTEXT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BMMEBOM1_ComponentTextForm);
IWebElement formBttn = BMMEBOM1_ComponentTextForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Alternate Parts");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM1] Performing VerifyExists on EBOMLine_AlternatePartsLink...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM1_EBOMLine_AlternatePartsLink = new SeleniumControl( sDriver, "EBOMLine_AlternatePartsLink", "ID", "lnk_4232_BMMEBOM_ENGBOM_CTW");
				Function.AssertEqual(true,BMMEBOM1_EBOMLine_AlternatePartsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM1] Performing Click on EBOMLine_AlternatePartsLink...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM1_EBOMLine_AlternatePartsLink = new SeleniumControl( sDriver, "EBOMLine_AlternatePartsLink", "ID", "lnk_4232_BMMEBOM_ENGBOM_CTW");
				Function.WaitControlDisplayed(BMMEBOM1_EBOMLine_AlternatePartsLink);
BMMEBOM1_EBOMLine_AlternatePartsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM1] Performing VerifyExist on AlternatePartsTable...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM1_AlternatePartsTable = new SeleniumControl( sDriver, "AlternatePartsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMEBOM_ALTPART_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BMMEBOM1_AlternatePartsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM1] Performing ClickButton on AlternatePartsForm...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM1_AlternatePartsForm = new SeleniumControl( sDriver, "AlternatePartsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMEBOM_ALTPART_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BMMEBOM1_AlternatePartsForm);
IWebElement formBttn = BMMEBOM1_AlternatePartsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? BMMEBOM1_AlternatePartsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
BMMEBOM1_AlternatePartsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM1] Performing VerifyExists on AlternatePartsForm...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM1_AlternatePartsForm = new SeleniumControl( sDriver, "AlternatePartsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMEBOM_ALTPART_']/ancestor::form[1]");
				Function.AssertEqual(true,BMMEBOM1_AlternatePartsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM1] Performing VerifyExists on AlternateParts_Manufacturer_Manufacturer...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM1_AlternateParts_Manufacturer_Manufacturer = new SeleniumControl( sDriver, "AlternateParts_Manufacturer_Manufacturer", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMEBOM_ALTPART_']/ancestor::form[1]/descendant::*[@id='MANUF_ID']");
				Function.AssertEqual(true,BMMEBOM1_AlternateParts_Manufacturer_Manufacturer.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM1] Performing Close on AlternatePartsForm...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM1_AlternatePartsForm = new SeleniumControl( sDriver, "AlternatePartsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMEBOM_ALTPART_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BMMEBOM1_AlternatePartsForm);
IWebElement formBttn = BMMEBOM1_AlternatePartsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Substitute Parts");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM1] Performing VerifyExists on EBOMLine_SubstitutePartsLink...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM1_EBOMLine_SubstitutePartsLink = new SeleniumControl( sDriver, "EBOMLine_SubstitutePartsLink", "ID", "lnk_4032_BMMEBOM_ENGBOM_CTW");
				Function.AssertEqual(true,BMMEBOM1_EBOMLine_SubstitutePartsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM1] Performing Click on EBOMLine_SubstitutePartsLink...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM1_EBOMLine_SubstitutePartsLink = new SeleniumControl( sDriver, "EBOMLine_SubstitutePartsLink", "ID", "lnk_4032_BMMEBOM_ENGBOM_CTW");
				Function.WaitControlDisplayed(BMMEBOM1_EBOMLine_SubstitutePartsLink);
BMMEBOM1_EBOMLine_SubstitutePartsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM1] Performing VerifyExist on SubstitutePartsTable...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM1_SubstitutePartsTable = new SeleniumControl( sDriver, "SubstitutePartsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMEBOM_SUBSTPART_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BMMEBOM1_SubstitutePartsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM1] Performing ClickButton on SubstitutePartsForm...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM1_SubstitutePartsForm = new SeleniumControl( sDriver, "SubstitutePartsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMEBOM_SUBSTPART_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BMMEBOM1_SubstitutePartsForm);
IWebElement formBttn = BMMEBOM1_SubstitutePartsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? BMMEBOM1_SubstitutePartsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
BMMEBOM1_SubstitutePartsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM1] Performing VerifyExists on SubstitutePartsForm...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM1_SubstitutePartsForm = new SeleniumControl( sDriver, "SubstitutePartsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMEBOM_SUBSTPART_']/ancestor::form[1]");
				Function.AssertEqual(true,BMMEBOM1_SubstitutePartsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM1] Performing VerifyExists on SubstituteParts_Sequence...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM1_SubstituteParts_Sequence = new SeleniumControl( sDriver, "SubstituteParts_Sequence", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMEBOM_SUBSTPART_']/ancestor::form[1]/descendant::*[@id='USAGE_SEQ_NO']");
				Function.AssertEqual(true,BMMEBOM1_SubstituteParts_Sequence.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM1] Performing Close on SubstitutePartsForm...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM1_SubstitutePartsForm = new SeleniumControl( sDriver, "SubstitutePartsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMEBOM_SUBSTPART_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BMMEBOM1_SubstitutePartsForm);
IWebElement formBttn = BMMEBOM1_SubstitutePartsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "BMMEBOM1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM1] Performing VerifyExists on EBOMLine_PartDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM1_EBOMLine_PartDocumentsLink = new SeleniumControl( sDriver, "EBOMLine_PartDocumentsLink", "ID", "lnk_4033_BMMEBOM_ENGBOM_CTW");
				Function.AssertEqual(true,BMMEBOM1_EBOMLine_PartDocumentsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM1] Performing Click on EBOMLine_PartDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM1_EBOMLine_PartDocumentsLink = new SeleniumControl( sDriver, "EBOMLine_PartDocumentsLink", "ID", "lnk_4033_BMMEBOM_ENGBOM_CTW");
				Function.WaitControlDisplayed(BMMEBOM1_EBOMLine_PartDocumentsLink);
BMMEBOM1_EBOMLine_PartDocumentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM1] Performing VerifyExist on EBOMLinePartDocumentsTable...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM1_EBOMLinePartDocumentsTable = new SeleniumControl( sDriver, "EBOMLinePartDocumentsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BMMEBOM1_EBOMLinePartDocumentsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM1] Performing ClickButton on EBOMLinePartDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM1_EBOMLinePartDocumentsForm = new SeleniumControl( sDriver, "EBOMLinePartDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BMMEBOM1_EBOMLinePartDocumentsForm);
IWebElement formBttn = BMMEBOM1_EBOMLinePartDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? BMMEBOM1_EBOMLinePartDocumentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
BMMEBOM1_EBOMLinePartDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM1] Performing VerifyExists on EBOMLinePartDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM1_EBOMLinePartDocumentsForm = new SeleniumControl( sDriver, "EBOMLinePartDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]");
				Function.AssertEqual(true,BMMEBOM1_EBOMLinePartDocumentsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM1] Performing VerifyExists on EBOMLinePartDocuments_Type...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM1_EBOMLinePartDocuments_Type = new SeleniumControl( sDriver, "EBOMLinePartDocuments_Type", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]/descendant::*[@id='DOC_TYPE_CD']");
				Function.AssertEqual(true,BMMEBOM1_EBOMLinePartDocuments_Type.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM1] Performing Close on EBOMLinePartDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM1_EBOMLinePartDocumentsForm = new SeleniumControl( sDriver, "EBOMLinePartDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BMMEBOM1_EBOMLinePartDocumentsForm);
IWebElement formBttn = BMMEBOM1_EBOMLinePartDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Create Provisional Part");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM1] Performing VerifyExists on EBOMLine_CreateProvisionalPartLink...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM1_EBOMLine_CreateProvisionalPartLink = new SeleniumControl( sDriver, "EBOMLine_CreateProvisionalPartLink", "ID", "lnk_4034_BMMEBOM_ENGBOM_CTW");
				Function.AssertEqual(true,BMMEBOM1_EBOMLine_CreateProvisionalPartLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM1] Performing Click on EBOMLine_CreateProvisionalPartLink...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM1_EBOMLine_CreateProvisionalPartLink = new SeleniumControl( sDriver, "EBOMLine_CreateProvisionalPartLink", "ID", "lnk_4034_BMMEBOM_ENGBOM_CTW");
				Function.WaitControlDisplayed(BMMEBOM1_EBOMLine_CreateProvisionalPartLink);
BMMEBOM1_EBOMLine_CreateProvisionalPartLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM1] Performing VerifyExists on CreateProvisionalPartForm...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM1_CreateProvisionalPartForm = new SeleniumControl( sDriver, "CreateProvisionalPartForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMEBOM_CREATE_PROVPART_']/ancestor::form[1]");
				Function.AssertEqual(true,BMMEBOM1_CreateProvisionalPartForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM1] Performing VerifyExists on CreateProvisionalPart_PartID...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM1_CreateProvisionalPart_PartID = new SeleniumControl( sDriver, "CreateProvisionalPart_PartID", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMEBOM_CREATE_PROVPART_']/ancestor::form[1]/descendant::*[@id='PROV_PART_ID']");
				Function.AssertEqual(true,BMMEBOM1_CreateProvisionalPart_PartID.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM1] Performing ClickButton on CreateProvisionalPartForm...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM1_CreateProvisionalPartForm = new SeleniumControl( sDriver, "CreateProvisionalPartForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMEBOM_CREATE_PROVPART_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BMMEBOM1_CreateProvisionalPartForm);
IWebElement formBttn = BMMEBOM1_CreateProvisionalPartForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? BMMEBOM1_CreateProvisionalPartForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
BMMEBOM1_CreateProvisionalPartForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM1] Performing VerifyExist on CreateProvisionalPartFormTable...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM1_CreateProvisionalPartFormTable = new SeleniumControl( sDriver, "CreateProvisionalPartFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMEBOM_CREATE_PROVPART_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BMMEBOM1_CreateProvisionalPartFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM1] Performing Close on CreateProvisionalPartForm...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM1_CreateProvisionalPartForm = new SeleniumControl( sDriver, "CreateProvisionalPartForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMEBOM_CREATE_PROVPART_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BMMEBOM1_CreateProvisionalPartForm);
IWebElement formBttn = BMMEBOM1_CreateProvisionalPartForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Closing App");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM1] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM1_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(BMMEBOM1_MainForm);
IWebElement formBttn = BMMEBOM1_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

