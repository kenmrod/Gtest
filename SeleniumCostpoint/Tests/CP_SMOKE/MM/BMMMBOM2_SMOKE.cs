 
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
    public class BMMMBOM2_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Release Manufacturing Bills of Material", "xpath","//div[@class='navItem'][.='Release Manufacturing Bills of Material']").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SelectMenu]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("MainForm");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMMBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMBOM2] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl BMMMBOM2_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,BMMMBOM2_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMMBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMBOM2] Performing VerifyExists on AssemblyPart...", Logger.MessageType.INF);
				SeleniumControl BMMMBOM2_AssemblyPart = new SeleniumControl( sDriver, "AssemblyPart", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PART_ID']");
				Function.AssertEqual(true,BMMMBOM2_AssemblyPart.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMMBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMBOM2] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl BMMMBOM2_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(BMMMBOM2_MainForm);
IWebElement formBttn = BMMMBOM2_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? BMMMBOM2_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
BMMMBOM2_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMMBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMBOM2] Performing VerifyExist on MainTable...", Logger.MessageType.INF);
				SeleniumControl BMMMBOM2_MainTable = new SeleniumControl( sDriver, "MainTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BMMMBOM2_MainTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
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
				Function.CurrentComponent = "BMMMBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMBOM2] Performing VerifyExists on ConfigurationLink...", Logger.MessageType.INF);
				SeleniumControl BMMMBOM2_ConfigurationLink = new SeleniumControl( sDriver, "ConfigurationLink", "ID", "lnk_4026_BMMMBOM_PART_HDR");
				Function.AssertEqual(true,BMMMBOM2_ConfigurationLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMMBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMBOM2] Performing Click on ConfigurationLink...", Logger.MessageType.INF);
				SeleniumControl BMMMBOM2_ConfigurationLink = new SeleniumControl( sDriver, "ConfigurationLink", "ID", "lnk_4026_BMMMBOM_PART_HDR");
				Function.WaitControlDisplayed(BMMMBOM2_ConfigurationLink);
BMMMBOM2_ConfigurationLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMMBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMBOM2] Performing VerifyExists on ConfigurationForm...", Logger.MessageType.INF);
				SeleniumControl BMMMBOM2_ConfigurationForm = new SeleniumControl( sDriver, "ConfigurationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BM_CONFIG_IDENTIFIERS_']/ancestor::form[1]");
				Function.AssertEqual(true,BMMMBOM2_ConfigurationForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMMBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMBOM2] Performing VerifyExists on Configuration_ShowAllConfigurations...", Logger.MessageType.INF);
				SeleniumControl BMMMBOM2_Configuration_ShowAllConfigurations = new SeleniumControl( sDriver, "Configuration_ShowAllConfigurations", "xpath", "//div[translate(@id,'0123456789','')='pr__BM_CONFIG_IDENTIFIERS_']/ancestor::form[1]/descendant::*[@id='SHOW_ALL_CONFIG']");
				Function.AssertEqual(true,BMMMBOM2_Configuration_ShowAllConfigurations.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMMBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMBOM2] Performing Close on ConfigurationForm...", Logger.MessageType.INF);
				SeleniumControl BMMMBOM2_ConfigurationForm = new SeleniumControl( sDriver, "ConfigurationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BM_CONFIG_IDENTIFIERS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BMMMBOM2_ConfigurationForm);
IWebElement formBttn = BMMMBOM2_ConfigurationForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "BMMMBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMBOM2] Performing VerifyExists on AssemblySerialNumbersLink...", Logger.MessageType.INF);
				SeleniumControl BMMMBOM2_AssemblySerialNumbersLink = new SeleniumControl( sDriver, "AssemblySerialNumbersLink", "ID", "lnk_3910_BMMMBOM_PART_HDR");
				Function.AssertEqual(true,BMMMBOM2_AssemblySerialNumbersLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMMBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMBOM2] Performing Click on AssemblySerialNumbersLink...", Logger.MessageType.INF);
				SeleniumControl BMMMBOM2_AssemblySerialNumbersLink = new SeleniumControl( sDriver, "AssemblySerialNumbersLink", "ID", "lnk_3910_BMMMBOM_PART_HDR");
				Function.WaitControlDisplayed(BMMMBOM2_AssemblySerialNumbersLink);
BMMMBOM2_AssemblySerialNumbersLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMMBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMBOM2] Performing VerifyExist on AssemblySerialNumbersTable...", Logger.MessageType.INF);
				SeleniumControl BMMMBOM2_AssemblySerialNumbersTable = new SeleniumControl( sDriver, "AssemblySerialNumbersTable", "xpath", "//div[translate(@id,'0123456789','')='pr__BM_ENDPARTCONFIG_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BMMMBOM2_AssemblySerialNumbersTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMMBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMBOM2] Performing VerifyExists on AssemblySerialNumbersForm...", Logger.MessageType.INF);
				SeleniumControl BMMMBOM2_AssemblySerialNumbersForm = new SeleniumControl( sDriver, "AssemblySerialNumbersForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BM_ENDPARTCONFIG_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,BMMMBOM2_AssemblySerialNumbersForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMMBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMBOM2] Performing Close on AssemblySerialNumbersForm...", Logger.MessageType.INF);
				SeleniumControl BMMMBOM2_AssemblySerialNumbersForm = new SeleniumControl( sDriver, "AssemblySerialNumbersForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BM_ENDPARTCONFIG_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BMMMBOM2_AssemblySerialNumbersForm);
IWebElement formBttn = BMMMBOM2_AssemblySerialNumbersForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "BMMMBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMBOM2] Performing VerifyExists on PartDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl BMMMBOM2_PartDocumentsLink = new SeleniumControl( sDriver, "PartDocumentsLink", "ID", "lnk_3915_BMMMBOM_PART_HDR");
				Function.AssertEqual(true,BMMMBOM2_PartDocumentsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMMBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMBOM2] Performing Click on PartDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl BMMMBOM2_PartDocumentsLink = new SeleniumControl( sDriver, "PartDocumentsLink", "ID", "lnk_3915_BMMMBOM_PART_HDR");
				Function.WaitControlDisplayed(BMMMBOM2_PartDocumentsLink);
BMMMBOM2_PartDocumentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMMBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMBOM2] Performing VerifyExist on PartDocumentsTable...", Logger.MessageType.INF);
				SeleniumControl BMMMBOM2_PartDocumentsTable = new SeleniumControl( sDriver, "PartDocumentsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BMMMBOM2_PartDocumentsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMMBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMBOM2] Performing VerifyExists on PartDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl BMMMBOM2_PartDocumentsForm = new SeleniumControl( sDriver, "PartDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]");
				Function.AssertEqual(true,BMMMBOM2_PartDocumentsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMMBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMBOM2] Performing ClickButton on PartDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl BMMMBOM2_PartDocumentsForm = new SeleniumControl( sDriver, "PartDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BMMMBOM2_PartDocumentsForm);
IWebElement formBttn = BMMMBOM2_PartDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? BMMMBOM2_PartDocumentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
BMMMBOM2_PartDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMMBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMBOM2] Performing VerifyExists on PartDocuments_Type...", Logger.MessageType.INF);
				SeleniumControl BMMMBOM2_PartDocuments_Type = new SeleniumControl( sDriver, "PartDocuments_Type", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]/descendant::*[@id='DOC_TYPE_CD']");
				Function.AssertEqual(true,BMMMBOM2_PartDocuments_Type.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMMBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMBOM2] Performing Close on PartDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl BMMMBOM2_PartDocumentsForm = new SeleniumControl( sDriver, "PartDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BMMMBOM2_PartDocumentsForm);
IWebElement formBttn = BMMMBOM2_PartDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Clone BOM Lines");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMMBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMBOM2] Performing VerifyExists on CloneMBOMLinesLink...", Logger.MessageType.INF);
				SeleniumControl BMMMBOM2_CloneMBOMLinesLink = new SeleniumControl( sDriver, "CloneMBOMLinesLink", "ID", "lnk_4065_BMMMBOM_PART_HDR");
				Function.AssertEqual(true,BMMMBOM2_CloneMBOMLinesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMMBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMBOM2] Performing Click on CloneMBOMLinesLink...", Logger.MessageType.INF);
				SeleniumControl BMMMBOM2_CloneMBOMLinesLink = new SeleniumControl( sDriver, "CloneMBOMLinesLink", "ID", "lnk_4065_BMMMBOM_PART_HDR");
				Function.WaitControlDisplayed(BMMMBOM2_CloneMBOMLinesLink);
BMMMBOM2_CloneMBOMLinesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMMBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMBOM2] Performing VerifyExists on CloneBOMLinesForm...", Logger.MessageType.INF);
				SeleniumControl BMMMBOM2_CloneBOMLinesForm = new SeleniumControl( sDriver, "CloneBOMLinesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BM_BOM_COPY_']/ancestor::form[1]");
				Function.AssertEqual(true,BMMMBOM2_CloneBOMLinesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMMBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMBOM2] Performing VerifyExists on CloneBOMLines_FromAssemblyPart...", Logger.MessageType.INF);
				SeleniumControl BMMMBOM2_CloneBOMLines_FromAssemblyPart = new SeleniumControl( sDriver, "CloneBOMLines_FromAssemblyPart", "xpath", "//div[translate(@id,'0123456789','')='pr__BM_BOM_COPY_']/ancestor::form[1]/descendant::*[@id='PART_ID']");
				Function.AssertEqual(true,BMMMBOM2_CloneBOMLines_FromAssemblyPart.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMMBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMBOM2] Performing Close on CloneBOMLinesForm...", Logger.MessageType.INF);
				SeleniumControl BMMMBOM2_CloneBOMLinesForm = new SeleniumControl( sDriver, "CloneBOMLinesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BM_BOM_COPY_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BMMMBOM2_CloneBOMLinesForm);
IWebElement formBttn = BMMMBOM2_CloneBOMLinesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("MBOM Line Form");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMMBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMBOM2] Performing VerifyExist on MBOMLineTable...", Logger.MessageType.INF);
				SeleniumControl BMMMBOM2_MBOMLineTable = new SeleniumControl( sDriver, "MBOMLineTable", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMMBOM_MFGBOM_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BMMMBOM2_MBOMLineTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMMBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMBOM2] Performing VerifyExists on MBOMLineForm...", Logger.MessageType.INF);
				SeleniumControl BMMMBOM2_MBOMLineForm = new SeleniumControl( sDriver, "MBOMLineForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMMBOM_MFGBOM_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,BMMMBOM2_MBOMLineForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMMBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMBOM2] Performing ClickButton on MBOMLineForm...", Logger.MessageType.INF);
				SeleniumControl BMMMBOM2_MBOMLineForm = new SeleniumControl( sDriver, "MBOMLineForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMMBOM_MFGBOM_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BMMMBOM2_MBOMLineForm);
IWebElement formBttn = BMMMBOM2_MBOMLineForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? BMMMBOM2_MBOMLineForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
BMMMBOM2_MBOMLineForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMMBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMBOM2] Performing VerifyExists on MBOMLine_LineNo...", Logger.MessageType.INF);
				SeleniumControl BMMMBOM2_MBOMLine_LineNo = new SeleniumControl( sDriver, "MBOMLine_LineNo", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMMBOM_MFGBOM_CTW_']/ancestor::form[1]/descendant::*[@id='COMP_LN_NO']");
				Function.AssertEqual(true,BMMMBOM2_MBOMLine_LineNo.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("MBOM LineTab");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMMBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMBOM2] Performing Select on MBOMLineTab...", Logger.MessageType.INF);
				SeleniumControl BMMMBOM2_MBOMLineTab = new SeleniumControl( sDriver, "MBOMLineTab", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMMBOM_MFGBOM_CTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(BMMMBOM2_MBOMLineTab);
IWebElement mTab = BMMMBOM2_MBOMLineTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Component Information").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMMBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMBOM2] Performing VerifyExists on MBOMLine_ComponentInformation_Component_PartStatus...", Logger.MessageType.INF);
				SeleniumControl BMMMBOM2_MBOMLine_ComponentInformation_Component_PartStatus = new SeleniumControl( sDriver, "MBOMLine_ComponentInformation_Component_PartStatus", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMMBOM_MFGBOM_CTW_']/ancestor::form[1]/descendant::*[@id='S_STATUS_TYPE']");
				Function.AssertEqual(true,BMMMBOM2_MBOMLine_ComponentInformation_Component_PartStatus.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMMBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMBOM2] Performing Select on MBOMLineTab...", Logger.MessageType.INF);
				SeleniumControl BMMMBOM2_MBOMLineTab = new SeleniumControl( sDriver, "MBOMLineTab", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMMBOM_MFGBOM_CTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(BMMMBOM2_MBOMLineTab);
IWebElement mTab = BMMMBOM2_MBOMLineTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Planning Details").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMMBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMBOM2] Performing VerifyExists on MBOMLine_PlanningDetails_AssemblyDetails_Warehouse...", Logger.MessageType.INF);
				SeleniumControl BMMMBOM2_MBOMLine_PlanningDetails_AssemblyDetails_Warehouse = new SeleniumControl( sDriver, "MBOMLine_PlanningDetails_AssemblyDetails_Warehouse", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMMBOM_MFGBOM_CTW_']/ancestor::form[1]/descendant::*[@id='BKFLSH_WHSE_ID']");
				Function.AssertEqual(true,BMMMBOM2_MBOMLine_PlanningDetails_AssemblyDetails_Warehouse.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMMBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMBOM2] Performing Select on MBOMLineTab...", Logger.MessageType.INF);
				SeleniumControl BMMMBOM2_MBOMLineTab = new SeleniumControl( sDriver, "MBOMLineTab", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMMBOM_MFGBOM_CTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(BMMMBOM2_MBOMLineTab);
IWebElement mTab = BMMMBOM2_MBOMLineTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Component Comments").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMMBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMBOM2] Performing VerifyExists on MBOMLine_ComponentComments_ComponentNotes...", Logger.MessageType.INF);
				SeleniumControl BMMMBOM2_MBOMLine_ComponentComments_ComponentNotes = new SeleniumControl( sDriver, "MBOMLine_ComponentComments_ComponentNotes", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMMBOM_MFGBOM_CTW_']/ancestor::form[1]/descendant::*[@id='COMP_LN_NT']");
				Function.AssertEqual(true,BMMMBOM2_MBOMLine_ComponentComments_ComponentNotes.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Product Option Items");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMMBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMBOM2] Performing VerifyExists on MBOMLine_ProductOptionItemsLink...", Logger.MessageType.INF);
				SeleniumControl BMMMBOM2_MBOMLine_ProductOptionItemsLink = new SeleniumControl( sDriver, "MBOMLine_ProductOptionItemsLink", "ID", "lnk_3993_BMMMBOM_MFGBOM_CTW");
				Function.AssertEqual(true,BMMMBOM2_MBOMLine_ProductOptionItemsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMMBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMBOM2] Performing Click on MBOMLine_ProductOptionItemsLink...", Logger.MessageType.INF);
				SeleniumControl BMMMBOM2_MBOMLine_ProductOptionItemsLink = new SeleniumControl( sDriver, "MBOMLine_ProductOptionItemsLink", "ID", "lnk_3993_BMMMBOM_MFGBOM_CTW");
				Function.WaitControlDisplayed(BMMMBOM2_MBOMLine_ProductOptionItemsLink);
BMMMBOM2_MBOMLine_ProductOptionItemsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMMBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMBOM2] Performing VerifyExist on MBOMLine_ProductOptionItemsTable...", Logger.MessageType.INF);
				SeleniumControl BMMMBOM2_MBOMLine_ProductOptionItemsTable = new SeleniumControl( sDriver, "MBOMLine_ProductOptionItemsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__BM_PRODOPTIONID_DEFAULT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BMMMBOM2_MBOMLine_ProductOptionItemsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMMBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMBOM2] Performing VerifyExists on MBOMLine_ProductOptionItemsForm...", Logger.MessageType.INF);
				SeleniumControl BMMMBOM2_MBOMLine_ProductOptionItemsForm = new SeleniumControl( sDriver, "MBOMLine_ProductOptionItemsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BM_PRODOPTIONID_DEFAULT_']/ancestor::form[1]");
				Function.AssertEqual(true,BMMMBOM2_MBOMLine_ProductOptionItemsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMMBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMBOM2] Performing Close on MBOMLine_ProductOptionItemsForm...", Logger.MessageType.INF);
				SeleniumControl BMMMBOM2_MBOMLine_ProductOptionItemsForm = new SeleniumControl( sDriver, "MBOMLine_ProductOptionItemsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BM_PRODOPTIONID_DEFAULT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BMMMBOM2_MBOMLine_ProductOptionItemsForm);
IWebElement formBttn = BMMMBOM2_MBOMLine_ProductOptionItemsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
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
				Function.CurrentComponent = "BMMMBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMBOM2] Performing VerifyExists on MBOMLine_ReferenceDesignatorsLink...", Logger.MessageType.INF);
				SeleniumControl BMMMBOM2_MBOMLine_ReferenceDesignatorsLink = new SeleniumControl( sDriver, "MBOMLine_ReferenceDesignatorsLink", "ID", "lnk_3911_BMMMBOM_MFGBOM_CTW");
				Function.AssertEqual(true,BMMMBOM2_MBOMLine_ReferenceDesignatorsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMMBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMBOM2] Performing Click on MBOMLine_ReferenceDesignatorsLink...", Logger.MessageType.INF);
				SeleniumControl BMMMBOM2_MBOMLine_ReferenceDesignatorsLink = new SeleniumControl( sDriver, "MBOMLine_ReferenceDesignatorsLink", "ID", "lnk_3911_BMMMBOM_MFGBOM_CTW");
				Function.WaitControlDisplayed(BMMMBOM2_MBOMLine_ReferenceDesignatorsLink);
BMMMBOM2_MBOMLine_ReferenceDesignatorsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMMBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMBOM2] Performing VerifyExists on MBOMLine_ReferenceDesignatorsForm...", Logger.MessageType.INF);
				SeleniumControl BMMMBOM2_MBOMLine_ReferenceDesignatorsForm = new SeleniumControl( sDriver, "MBOMLine_ReferenceDesignatorsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BM_MFGBOMREF_']/ancestor::form[1]");
				Function.AssertEqual(true,BMMMBOM2_MBOMLine_ReferenceDesignatorsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMMBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMBOM2] Performing ClickButton on MBOMLine_ReferenceDesignatorsForm...", Logger.MessageType.INF);
				SeleniumControl BMMMBOM2_MBOMLine_ReferenceDesignatorsForm = new SeleniumControl( sDriver, "MBOMLine_ReferenceDesignatorsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BM_MFGBOMREF_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BMMMBOM2_MBOMLine_ReferenceDesignatorsForm);
IWebElement formBttn = BMMMBOM2_MBOMLine_ReferenceDesignatorsForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? BMMMBOM2_MBOMLine_ReferenceDesignatorsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
BMMMBOM2_MBOMLine_ReferenceDesignatorsForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMMBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMBOM2] Performing VerifyExist on MBOMLine_ReferenceDesignatorsTable...", Logger.MessageType.INF);
				SeleniumControl BMMMBOM2_MBOMLine_ReferenceDesignatorsTable = new SeleniumControl( sDriver, "MBOMLine_ReferenceDesignatorsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__BM_MFGBOMREF_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BMMMBOM2_MBOMLine_ReferenceDesignatorsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMMBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMBOM2] Performing Close on MBOMLine_ReferenceDesignatorsForm...", Logger.MessageType.INF);
				SeleniumControl BMMMBOM2_MBOMLine_ReferenceDesignatorsForm = new SeleniumControl( sDriver, "MBOMLine_ReferenceDesignatorsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BM_MFGBOMREF_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BMMMBOM2_MBOMLine_ReferenceDesignatorsForm);
IWebElement formBttn = BMMMBOM2_MBOMLine_ReferenceDesignatorsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "BMMMBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMBOM2] Performing VerifyExists on MBOMLine_ComponentTextLink...", Logger.MessageType.INF);
				SeleniumControl BMMMBOM2_MBOMLine_ComponentTextLink = new SeleniumControl( sDriver, "MBOMLine_ComponentTextLink", "ID", "lnk_3912_BMMMBOM_MFGBOM_CTW");
				Function.AssertEqual(true,BMMMBOM2_MBOMLine_ComponentTextLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMMBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMBOM2] Performing Click on MBOMLine_ComponentTextLink...", Logger.MessageType.INF);
				SeleniumControl BMMMBOM2_MBOMLine_ComponentTextLink = new SeleniumControl( sDriver, "MBOMLine_ComponentTextLink", "ID", "lnk_3912_BMMMBOM_MFGBOM_CTW");
				Function.WaitControlDisplayed(BMMMBOM2_MBOMLine_ComponentTextLink);
BMMMBOM2_MBOMLine_ComponentTextLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMMBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMBOM2] Performing VerifyExist on MBOMLine_ComponentTextTable...", Logger.MessageType.INF);
				SeleniumControl BMMMBOM2_MBOMLine_ComponentTextTable = new SeleniumControl( sDriver, "MBOMLine_ComponentTextTable", "xpath", "//div[translate(@id,'0123456789','')='pr__BM_MFGBOMTEXT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BMMMBOM2_MBOMLine_ComponentTextTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMMBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMBOM2] Performing VerifyExists on MBOMLine_ComponentTextForm...", Logger.MessageType.INF);
				SeleniumControl BMMMBOM2_MBOMLine_ComponentTextForm = new SeleniumControl( sDriver, "MBOMLine_ComponentTextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BM_MFGBOMTEXT_']/ancestor::form[1]");
				Function.AssertEqual(true,BMMMBOM2_MBOMLine_ComponentTextForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMMBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMBOM2] Performing ClickButton on MBOMLine_ComponentTextForm...", Logger.MessageType.INF);
				SeleniumControl BMMMBOM2_MBOMLine_ComponentTextForm = new SeleniumControl( sDriver, "MBOMLine_ComponentTextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BM_MFGBOMTEXT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BMMMBOM2_MBOMLine_ComponentTextForm);
IWebElement formBttn = BMMMBOM2_MBOMLine_ComponentTextForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? BMMMBOM2_MBOMLine_ComponentTextForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
BMMMBOM2_MBOMLine_ComponentTextForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMMBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMBOM2] Performing VerifyExists on MBOMLine_ComponentText_Sequence...", Logger.MessageType.INF);
				SeleniumControl BMMMBOM2_MBOMLine_ComponentText_Sequence = new SeleniumControl( sDriver, "MBOMLine_ComponentText_Sequence", "xpath", "//div[translate(@id,'0123456789','')='pr__BM_MFGBOMTEXT_']/ancestor::form[1]/descendant::*[@id='SEQ_NO']");
				Function.AssertEqual(true,BMMMBOM2_MBOMLine_ComponentText_Sequence.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMMBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMBOM2] Performing Close on MBOMLine_ComponentTextForm...", Logger.MessageType.INF);
				SeleniumControl BMMMBOM2_MBOMLine_ComponentTextForm = new SeleniumControl( sDriver, "MBOMLine_ComponentTextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BM_MFGBOMTEXT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BMMMBOM2_MBOMLine_ComponentTextForm);
IWebElement formBttn = BMMMBOM2_MBOMLine_ComponentTextForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "BMMMBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMBOM2] Performing VerifyExists on MBOMLine_AlternatePartsLink...", Logger.MessageType.INF);
				SeleniumControl BMMMBOM2_MBOMLine_AlternatePartsLink = new SeleniumControl( sDriver, "MBOMLine_AlternatePartsLink", "ID", "lnk_3913_BMMMBOM_MFGBOM_CTW");
				Function.AssertEqual(true,BMMMBOM2_MBOMLine_AlternatePartsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMMBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMBOM2] Performing Click on MBOMLine_AlternatePartsLink...", Logger.MessageType.INF);
				SeleniumControl BMMMBOM2_MBOMLine_AlternatePartsLink = new SeleniumControl( sDriver, "MBOMLine_AlternatePartsLink", "ID", "lnk_3913_BMMMBOM_MFGBOM_CTW");
				Function.WaitControlDisplayed(BMMMBOM2_MBOMLine_AlternatePartsLink);
BMMMBOM2_MBOMLine_AlternatePartsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMMBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMBOM2] Performing VerifyExist on MBOMLine_AlternatePartsTable...", Logger.MessageType.INF);
				SeleniumControl BMMMBOM2_MBOMLine_AlternatePartsTable = new SeleniumControl( sDriver, "MBOMLine_AlternatePartsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__BM_ALTPART_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BMMMBOM2_MBOMLine_AlternatePartsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMMBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMBOM2] Performing VerifyExists on MBOMLine_AlternatePartsForm...", Logger.MessageType.INF);
				SeleniumControl BMMMBOM2_MBOMLine_AlternatePartsForm = new SeleniumControl( sDriver, "MBOMLine_AlternatePartsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BM_ALTPART_']/ancestor::form[1]");
				Function.AssertEqual(true,BMMMBOM2_MBOMLine_AlternatePartsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMMBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMBOM2] Performing ClickButton on MBOMLine_AlternatePartsForm...", Logger.MessageType.INF);
				SeleniumControl BMMMBOM2_MBOMLine_AlternatePartsForm = new SeleniumControl( sDriver, "MBOMLine_AlternatePartsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BM_ALTPART_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BMMMBOM2_MBOMLine_AlternatePartsForm);
IWebElement formBttn = BMMMBOM2_MBOMLine_AlternatePartsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? BMMMBOM2_MBOMLine_AlternatePartsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
BMMMBOM2_MBOMLine_AlternatePartsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMMBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMBOM2] Performing VerifyExists on MBOMLine_AlternateParts_Manufacturer_Manufacturer...", Logger.MessageType.INF);
				SeleniumControl BMMMBOM2_MBOMLine_AlternateParts_Manufacturer_Manufacturer = new SeleniumControl( sDriver, "MBOMLine_AlternateParts_Manufacturer_Manufacturer", "xpath", "//div[translate(@id,'0123456789','')='pr__BM_ALTPART_']/ancestor::form[1]/descendant::*[@id='MANUF_ID']");
				Function.AssertEqual(true,BMMMBOM2_MBOMLine_AlternateParts_Manufacturer_Manufacturer.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMMBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMBOM2] Performing Close on MBOMLine_AlternatePartsForm...", Logger.MessageType.INF);
				SeleniumControl BMMMBOM2_MBOMLine_AlternatePartsForm = new SeleniumControl( sDriver, "MBOMLine_AlternatePartsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BM_ALTPART_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BMMMBOM2_MBOMLine_AlternatePartsForm);
IWebElement formBttn = BMMMBOM2_MBOMLine_AlternatePartsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "BMMMBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMBOM2] Performing VerifyExists on MBOMLine_SubstitutePartsLink...", Logger.MessageType.INF);
				SeleniumControl BMMMBOM2_MBOMLine_SubstitutePartsLink = new SeleniumControl( sDriver, "MBOMLine_SubstitutePartsLink", "ID", "lnk_3914_BMMMBOM_MFGBOM_CTW");
				Function.AssertEqual(true,BMMMBOM2_MBOMLine_SubstitutePartsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMMBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMBOM2] Performing Click on MBOMLine_SubstitutePartsLink...", Logger.MessageType.INF);
				SeleniumControl BMMMBOM2_MBOMLine_SubstitutePartsLink = new SeleniumControl( sDriver, "MBOMLine_SubstitutePartsLink", "ID", "lnk_3914_BMMMBOM_MFGBOM_CTW");
				Function.WaitControlDisplayed(BMMMBOM2_MBOMLine_SubstitutePartsLink);
BMMMBOM2_MBOMLine_SubstitutePartsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMMBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMBOM2] Performing VerifyExist on MBOMLine_SubstitutePartsTable...", Logger.MessageType.INF);
				SeleniumControl BMMMBOM2_MBOMLine_SubstitutePartsTable = new SeleniumControl( sDriver, "MBOMLine_SubstitutePartsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__BM_SUBSTPART_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BMMMBOM2_MBOMLine_SubstitutePartsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMMBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMBOM2] Performing VerifyExists on MBOMLine_SubstitutePartsForm...", Logger.MessageType.INF);
				SeleniumControl BMMMBOM2_MBOMLine_SubstitutePartsForm = new SeleniumControl( sDriver, "MBOMLine_SubstitutePartsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BM_SUBSTPART_']/ancestor::form[1]");
				Function.AssertEqual(true,BMMMBOM2_MBOMLine_SubstitutePartsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMMBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMBOM2] Performing ClickButton on MBOMLine_SubstitutePartsForm...", Logger.MessageType.INF);
				SeleniumControl BMMMBOM2_MBOMLine_SubstitutePartsForm = new SeleniumControl( sDriver, "MBOMLine_SubstitutePartsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BM_SUBSTPART_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BMMMBOM2_MBOMLine_SubstitutePartsForm);
IWebElement formBttn = BMMMBOM2_MBOMLine_SubstitutePartsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? BMMMBOM2_MBOMLine_SubstitutePartsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
BMMMBOM2_MBOMLine_SubstitutePartsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMMBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMBOM2] Performing VerifyExists on MBOMLine_SubstituteParts_Sequence...", Logger.MessageType.INF);
				SeleniumControl BMMMBOM2_MBOMLine_SubstituteParts_Sequence = new SeleniumControl( sDriver, "MBOMLine_SubstituteParts_Sequence", "xpath", "//div[translate(@id,'0123456789','')='pr__BM_SUBSTPART_']/ancestor::form[1]/descendant::*[@id='USAGE_SEQ_NO']");
				Function.AssertEqual(true,BMMMBOM2_MBOMLine_SubstituteParts_Sequence.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMMBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMBOM2] Performing Close on MBOMLine_SubstitutePartsForm...", Logger.MessageType.INF);
				SeleniumControl BMMMBOM2_MBOMLine_SubstitutePartsForm = new SeleniumControl( sDriver, "MBOMLine_SubstitutePartsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BM_SUBSTPART_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BMMMBOM2_MBOMLine_SubstitutePartsForm);
IWebElement formBttn = BMMMBOM2_MBOMLine_SubstitutePartsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "BMMMBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMBOM2] Performing VerifyExists on MBOMLine_PartDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl BMMMBOM2_MBOMLine_PartDocumentsLink = new SeleniumControl( sDriver, "MBOMLine_PartDocumentsLink", "ID", "lnk_3916_BMMMBOM_MFGBOM_CTW");
				Function.AssertEqual(true,BMMMBOM2_MBOMLine_PartDocumentsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMMBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMBOM2] Performing Click on MBOMLine_PartDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl BMMMBOM2_MBOMLine_PartDocumentsLink = new SeleniumControl( sDriver, "MBOMLine_PartDocumentsLink", "ID", "lnk_3916_BMMMBOM_MFGBOM_CTW");
				Function.WaitControlDisplayed(BMMMBOM2_MBOMLine_PartDocumentsLink);
BMMMBOM2_MBOMLine_PartDocumentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMMBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMBOM2] Performing VerifyExist on MBOMLine_PartDocumentsTable...", Logger.MessageType.INF);
				SeleniumControl BMMMBOM2_MBOMLine_PartDocumentsTable = new SeleniumControl( sDriver, "MBOMLine_PartDocumentsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BMMMBOM2_MBOMLine_PartDocumentsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMMBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMBOM2] Performing VerifyExists on MBOMLine_PartDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl BMMMBOM2_MBOMLine_PartDocumentsForm = new SeleniumControl( sDriver, "MBOMLine_PartDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]");
				Function.AssertEqual(true,BMMMBOM2_MBOMLine_PartDocumentsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMMBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMBOM2] Performing ClickButton on MBOMLine_PartDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl BMMMBOM2_MBOMLine_PartDocumentsForm = new SeleniumControl( sDriver, "MBOMLine_PartDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BMMMBOM2_MBOMLine_PartDocumentsForm);
IWebElement formBttn = BMMMBOM2_MBOMLine_PartDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? BMMMBOM2_MBOMLine_PartDocumentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
BMMMBOM2_MBOMLine_PartDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMMBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMBOM2] Performing VerifyExists on MBOMLine_PartDocuments_Type...", Logger.MessageType.INF);
				SeleniumControl BMMMBOM2_MBOMLine_PartDocuments_Type = new SeleniumControl( sDriver, "MBOMLine_PartDocuments_Type", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]/descendant::*[@id='DOC_TYPE_CD']");
				Function.AssertEqual(true,BMMMBOM2_MBOMLine_PartDocuments_Type.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMMBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMBOM2] Performing Close on MBOMLine_PartDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl BMMMBOM2_MBOMLine_PartDocumentsForm = new SeleniumControl( sDriver, "MBOMLine_PartDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BMMMBOM2_MBOMLine_PartDocumentsForm);
IWebElement formBttn = BMMMBOM2_MBOMLine_PartDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
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
				Function.CurrentComponent = "BMMMBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMMBOM2] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl BMMMBOM2_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(BMMMBOM2_MainForm);
IWebElement formBttn = BMMMBOM2_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
Function.ClickOkDialogWithMessage("You have unsaved changes. Select Cancel to go back and save changes or select OK to discard changes and close this application.");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickOkDialogWithMessage]" , ex.Message));
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

