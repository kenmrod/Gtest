 
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
    public class BMMEBOM2_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Release Engineering Bills of Material", "xpath","//div[@class='navItem'][.='Release Engineering Bills of Material']").Click();


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
				Function.CurrentComponent = "BMMEBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM2] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM2_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,BMMEBOM2_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM2] Performing VerifyExists on AssemblyPart...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM2_AssemblyPart = new SeleniumControl( sDriver, "AssemblyPart", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PART_ID']");
				Function.AssertEqual(true,BMMEBOM2_AssemblyPart.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM2] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM2_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(BMMEBOM2_MainForm);
IWebElement formBttn = BMMEBOM2_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? BMMEBOM2_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
BMMEBOM2_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM2] Performing VerifyExist on MainTable...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM2_MainTable = new SeleniumControl( sDriver, "MainTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BMMEBOM2_MainTable.Exists());

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
				Function.CurrentComponent = "BMMEBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM2] Performing Click on ConfigurationLink...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM2_ConfigurationLink = new SeleniumControl( sDriver, "ConfigurationLink", "ID", "lnk_4024_BMMEBOM_PART_HDR");
				Function.WaitControlDisplayed(BMMEBOM2_ConfigurationLink);
BMMEBOM2_ConfigurationLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM2] Performing VerifyExists on ConfigurationForm...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM2_ConfigurationForm = new SeleniumControl( sDriver, "ConfigurationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BM_CONFIG_IDENTIFIERS_']/ancestor::form[1]");
				Function.AssertEqual(true,BMMEBOM2_ConfigurationForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM2] Performing Close on ConfigurationForm...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM2_ConfigurationForm = new SeleniumControl( sDriver, "ConfigurationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BM_CONFIG_IDENTIFIERS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BMMEBOM2_ConfigurationForm);
IWebElement formBttn = BMMEBOM2_ConfigurationForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Assembly Serial Num");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM2] Performing Click on AssemblySerialNumbersLink...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM2_AssemblySerialNumbersLink = new SeleniumControl( sDriver, "AssemblySerialNumbersLink", "ID", "lnk_4035_BMMEBOM_PART_HDR");
				Function.WaitControlDisplayed(BMMEBOM2_AssemblySerialNumbersLink);
BMMEBOM2_AssemblySerialNumbersLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM2] Performing VerifyExists on AssemblySerialNumbersForm...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM2_AssemblySerialNumbersForm = new SeleniumControl( sDriver, "AssemblySerialNumbersForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BM_ENDPARTCONFIG_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,BMMEBOM2_AssemblySerialNumbersForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM2] Performing Close on AssemblySerialNumbersForm...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM2_AssemblySerialNumbersForm = new SeleniumControl( sDriver, "AssemblySerialNumbersForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BM_ENDPARTCONFIG_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BMMEBOM2_AssemblySerialNumbersForm);
IWebElement formBttn = BMMEBOM2_AssemblySerialNumbersForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "BMMEBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM2] Performing Click on PartDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM2_PartDocumentsLink = new SeleniumControl( sDriver, "PartDocumentsLink", "ID", "lnk_4027_BMMEBOM_PART_HDR");
				Function.WaitControlDisplayed(BMMEBOM2_PartDocumentsLink);
BMMEBOM2_PartDocumentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM2] Performing VerifyExists on PartDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM2_PartDocumentsForm = new SeleniumControl( sDriver, "PartDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]");
				Function.AssertEqual(true,BMMEBOM2_PartDocumentsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM2] Performing VerifyExist on PartDocumentsTable...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM2_PartDocumentsTable = new SeleniumControl( sDriver, "PartDocumentsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BMMEBOM2_PartDocumentsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM2] Performing ClickButton on PartDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM2_PartDocumentsForm = new SeleniumControl( sDriver, "PartDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BMMEBOM2_PartDocumentsForm);
IWebElement formBttn = BMMEBOM2_PartDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? BMMEBOM2_PartDocumentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
BMMEBOM2_PartDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM2] Performing VerifyExists on PartDocuments_Type...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM2_PartDocuments_Type = new SeleniumControl( sDriver, "PartDocuments_Type", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]/descendant::*[@id='DOC_TYPE_CD']");
				Function.AssertEqual(true,BMMEBOM2_PartDocuments_Type.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM2] Performing Close on PartDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM2_PartDocumentsForm = new SeleniumControl( sDriver, "PartDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BMMEBOM2_PartDocumentsForm);
IWebElement formBttn = BMMEBOM2_PartDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Clone EBOM");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM2] Performing Click on CloneEBOMLinesLink...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM2_CloneEBOMLinesLink = new SeleniumControl( sDriver, "CloneEBOMLinesLink", "ID", "lnk_4083_BMMEBOM_PART_HDR");
				Function.WaitControlDisplayed(BMMEBOM2_CloneEBOMLinesLink);
BMMEBOM2_CloneEBOMLinesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM2] Performing VerifyExists on CloneEBOMLinesForm...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM2_CloneEBOMLinesForm = new SeleniumControl( sDriver, "CloneEBOMLinesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMEBOM_EBOM_CLONE_']/ancestor::form[1]");
				Function.AssertEqual(true,BMMEBOM2_CloneEBOMLinesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM2] Performing ClickButton on CloneEBOMLinesForm...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM2_CloneEBOMLinesForm = new SeleniumControl( sDriver, "CloneEBOMLinesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMEBOM_EBOM_CLONE_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BMMEBOM2_CloneEBOMLinesForm);
IWebElement formBttn = BMMEBOM2_CloneEBOMLinesForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? BMMEBOM2_CloneEBOMLinesForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
BMMEBOM2_CloneEBOMLinesForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM2] Performing VerifyExist on CloneEBOMLinesTable...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM2_CloneEBOMLinesTable = new SeleniumControl( sDriver, "CloneEBOMLinesTable", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMEBOM_EBOM_CLONE_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BMMEBOM2_CloneEBOMLinesTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM2] Performing Close on CloneEBOMLinesForm...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM2_CloneEBOMLinesForm = new SeleniumControl( sDriver, "CloneEBOMLinesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMEBOM_EBOM_CLONE_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BMMEBOM2_CloneEBOMLinesForm);
IWebElement formBttn = BMMEBOM2_CloneEBOMLinesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Create Prov Part");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM2] Performing Click on CreateProvisionalPartLink...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM2_CreateProvisionalPartLink = new SeleniumControl( sDriver, "CreateProvisionalPartLink", "ID", "lnk_16811_BMMEBOM_PART_HDR");
				Function.WaitControlDisplayed(BMMEBOM2_CreateProvisionalPartLink);
BMMEBOM2_CreateProvisionalPartLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM2] Performing VerifyExists on CreateProvisionalPartForm...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM2_CreateProvisionalPartForm = new SeleniumControl( sDriver, "CreateProvisionalPartForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMEBOM_CREATE_PROVPART_']/ancestor::form[1]");
				Function.AssertEqual(true,BMMEBOM2_CreateProvisionalPartForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM2] Performing VerifyExists on CreateProvisionalPart_PartID...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM2_CreateProvisionalPart_PartID = new SeleniumControl( sDriver, "CreateProvisionalPart_PartID", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMEBOM_CREATE_PROVPART_']/ancestor::form[1]/descendant::*[@id='PROV_PART_ID']");
				Function.AssertEqual(true,BMMEBOM2_CreateProvisionalPart_PartID.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM2] Performing ClickButton on CreateProvisionalPartForm...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM2_CreateProvisionalPartForm = new SeleniumControl( sDriver, "CreateProvisionalPartForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMEBOM_CREATE_PROVPART_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BMMEBOM2_CreateProvisionalPartForm);
IWebElement formBttn = BMMEBOM2_CreateProvisionalPartForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? BMMEBOM2_CreateProvisionalPartForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
BMMEBOM2_CreateProvisionalPartForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM2] Performing VerifyExist on CreateProvisionalPartFormTable...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM2_CreateProvisionalPartFormTable = new SeleniumControl( sDriver, "CreateProvisionalPartFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMEBOM_CREATE_PROVPART_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BMMEBOM2_CreateProvisionalPartFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM2] Performing Close on CreateProvisionalPartForm...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM2_CreateProvisionalPartForm = new SeleniumControl( sDriver, "CreateProvisionalPartForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMEBOM_CREATE_PROVPART_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BMMEBOM2_CreateProvisionalPartForm);
IWebElement formBttn = BMMEBOM2_CreateProvisionalPartForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "BMMEBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM2] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM2_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(BMMEBOM2_MainForm);
IWebElement formBttn = BMMEBOM2_MainForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).Count <= 0 ? BMMEBOM2_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Query')]")).FirstOrDefault() :
BMMEBOM2_MainForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Query not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "Dialog";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));
Function.ClickOkDialogIfExists("You have unsaved changes. Select Cancel to go back and save changes or select OK to discard changes and proceed to Query.");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickOkDialogIfExists]" , ex.Message));
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
				Function.CurrentComponent = "BMMEBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM2] Performing VerifyExists on EBOMLineForm...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM2_EBOMLineForm = new SeleniumControl( sDriver, "EBOMLineForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMEBOM_ENGBOM_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,BMMEBOM2_EBOMLineForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM2] Performing VerifyExist on EBOMLineTable...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM2_EBOMLineTable = new SeleniumControl( sDriver, "EBOMLineTable", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMEBOM_ENGBOM_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BMMEBOM2_EBOMLineTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM2] Performing ClickButton on EBOMLineForm...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM2_EBOMLineForm = new SeleniumControl( sDriver, "EBOMLineForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMEBOM_ENGBOM_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BMMEBOM2_EBOMLineForm);
IWebElement formBttn = BMMEBOM2_EBOMLineForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? BMMEBOM2_EBOMLineForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
BMMEBOM2_EBOMLineForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM2] Performing VerifyExists on EBOMLine_LineNo...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM2_EBOMLine_LineNo = new SeleniumControl( sDriver, "EBOMLine_LineNo", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMEBOM_ENGBOM_CTW_']/ancestor::form[1]/descendant::*[@id='COMP_LN_NO']");
				Function.AssertEqual(true,BMMEBOM2_EBOMLine_LineNo.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM2] Performing VerifyExists on EBOMLine_ComponentInformation_Component_EBOMExists...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM2_EBOMLine_ComponentInformation_Component_EBOMExists = new SeleniumControl( sDriver, "EBOMLine_ComponentInformation_Component_EBOMExists", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMEBOM_ENGBOM_CTW_']/ancestor::form[1]/descendant::*[@id='EBOM_EXIST_FL']");
				Function.AssertEqual(true,BMMEBOM2_EBOMLine_ComponentInformation_Component_EBOMExists.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM2] Performing Select on EBOMLineTab...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM2_EBOMLineTab = new SeleniumControl( sDriver, "EBOMLineTab", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMEBOM_ENGBOM_CTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(BMMEBOM2_EBOMLineTab);
IWebElement mTab = BMMEBOM2_EBOMLineTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Component Comments").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM2] Performing VerifyExists on EBOMLine_ComponentComments_ComponentNotes...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM2_EBOMLine_ComponentComments_ComponentNotes = new SeleniumControl( sDriver, "EBOMLine_ComponentComments_ComponentNotes", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMEBOM_ENGBOM_CTW_']/ancestor::form[1]/descendant::*[@id='COMP_LN_NT']");
				Function.AssertEqual(true,BMMEBOM2_EBOMLine_ComponentComments_ComponentNotes.Exists());

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
				Function.CurrentComponent = "BMMEBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM2] Performing Click on EBOMLine_ReferenceDesignatorsLink...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM2_EBOMLine_ReferenceDesignatorsLink = new SeleniumControl( sDriver, "EBOMLine_ReferenceDesignatorsLink", "ID", "lnk_4036_BMMEBOM_ENGBOM_CTW");
				Function.WaitControlDisplayed(BMMEBOM2_EBOMLine_ReferenceDesignatorsLink);
BMMEBOM2_EBOMLine_ReferenceDesignatorsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM2] Performing VerifyExists on EBOMLine_ReferenceDesignatorsForm...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM2_EBOMLine_ReferenceDesignatorsForm = new SeleniumControl( sDriver, "EBOMLine_ReferenceDesignatorsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMEBOM_ENGBOMREF_']/ancestor::form[1]");
				Function.AssertEqual(true,BMMEBOM2_EBOMLine_ReferenceDesignatorsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM2] Performing Close on EBOMLine_ReferenceDesignatorsForm...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM2_EBOMLine_ReferenceDesignatorsForm = new SeleniumControl( sDriver, "EBOMLine_ReferenceDesignatorsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMEBOM_ENGBOMREF_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BMMEBOM2_EBOMLine_ReferenceDesignatorsForm);
IWebElement formBttn = BMMEBOM2_EBOMLine_ReferenceDesignatorsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "BMMEBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM2] Performing Click on EBOMLine_ComponentTextLink...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM2_EBOMLine_ComponentTextLink = new SeleniumControl( sDriver, "EBOMLine_ComponentTextLink", "ID", "lnk_4030_BMMEBOM_ENGBOM_CTW");
				Function.WaitControlDisplayed(BMMEBOM2_EBOMLine_ComponentTextLink);
BMMEBOM2_EBOMLine_ComponentTextLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM2] Performing VerifyExists on EBOMLine_ComponentTextForm...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM2_EBOMLine_ComponentTextForm = new SeleniumControl( sDriver, "EBOMLine_ComponentTextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMEBOM_ENGBOMTEXT_']/ancestor::form[1]");
				Function.AssertEqual(true,BMMEBOM2_EBOMLine_ComponentTextForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM2] Performing VerifyExist on EBOMLine_ComponentTextTable...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM2_EBOMLine_ComponentTextTable = new SeleniumControl( sDriver, "EBOMLine_ComponentTextTable", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMEBOM_ENGBOMTEXT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BMMEBOM2_EBOMLine_ComponentTextTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM2] Performing ClickButton on EBOMLine_ComponentTextForm...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM2_EBOMLine_ComponentTextForm = new SeleniumControl( sDriver, "EBOMLine_ComponentTextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMEBOM_ENGBOMTEXT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BMMEBOM2_EBOMLine_ComponentTextForm);
IWebElement formBttn = BMMEBOM2_EBOMLine_ComponentTextForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? BMMEBOM2_EBOMLine_ComponentTextForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
BMMEBOM2_EBOMLine_ComponentTextForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM2] Performing VerifyExists on EBOMLine_ComponentText_Sequence...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM2_EBOMLine_ComponentText_Sequence = new SeleniumControl( sDriver, "EBOMLine_ComponentText_Sequence", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMEBOM_ENGBOMTEXT_']/ancestor::form[1]/descendant::*[@id='SEQ_NO']");
				Function.AssertEqual(true,BMMEBOM2_EBOMLine_ComponentText_Sequence.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM2] Performing Close on EBOMLine_ComponentTextForm...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM2_EBOMLine_ComponentTextForm = new SeleniumControl( sDriver, "EBOMLine_ComponentTextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMEBOM_ENGBOMTEXT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BMMEBOM2_EBOMLine_ComponentTextForm);
IWebElement formBttn = BMMEBOM2_EBOMLine_ComponentTextForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "BMMEBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM2] Performing Click on EBOMLine_AlternatePartsLink...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM2_EBOMLine_AlternatePartsLink = new SeleniumControl( sDriver, "EBOMLine_AlternatePartsLink", "ID", "lnk_4232_BMMEBOM_ENGBOM_CTW");
				Function.WaitControlDisplayed(BMMEBOM2_EBOMLine_AlternatePartsLink);
BMMEBOM2_EBOMLine_AlternatePartsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM2] Performing VerifyExists on EBOMLine_AlternatePartsForm...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM2_EBOMLine_AlternatePartsForm = new SeleniumControl( sDriver, "EBOMLine_AlternatePartsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMEBOM_ALTPART_']/ancestor::form[1]");
				Function.AssertEqual(true,BMMEBOM2_EBOMLine_AlternatePartsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM2] Performing VerifyExist on EBOMLine_AlternatePartsTable...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM2_EBOMLine_AlternatePartsTable = new SeleniumControl( sDriver, "EBOMLine_AlternatePartsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMEBOM_ALTPART_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BMMEBOM2_EBOMLine_AlternatePartsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM2] Performing ClickButton on EBOMLine_AlternatePartsForm...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM2_EBOMLine_AlternatePartsForm = new SeleniumControl( sDriver, "EBOMLine_AlternatePartsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMEBOM_ALTPART_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BMMEBOM2_EBOMLine_AlternatePartsForm);
IWebElement formBttn = BMMEBOM2_EBOMLine_AlternatePartsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? BMMEBOM2_EBOMLine_AlternatePartsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
BMMEBOM2_EBOMLine_AlternatePartsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM2] Performing VerifyExists on EBOMLine_AlternateParts_Manufacturer_Manufacturer...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM2_EBOMLine_AlternateParts_Manufacturer_Manufacturer = new SeleniumControl( sDriver, "EBOMLine_AlternateParts_Manufacturer_Manufacturer", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMEBOM_ALTPART_']/ancestor::form[1]/descendant::*[@id='MANUF_ID']");
				Function.AssertEqual(true,BMMEBOM2_EBOMLine_AlternateParts_Manufacturer_Manufacturer.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM2] Performing Close on EBOMLine_AlternatePartsForm...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM2_EBOMLine_AlternatePartsForm = new SeleniumControl( sDriver, "EBOMLine_AlternatePartsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMEBOM_ALTPART_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BMMEBOM2_EBOMLine_AlternatePartsForm);
IWebElement formBttn = BMMEBOM2_EBOMLine_AlternatePartsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "BMMEBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM2] Performing Click on EBOMLine_SubstitutePartsLink...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM2_EBOMLine_SubstitutePartsLink = new SeleniumControl( sDriver, "EBOMLine_SubstitutePartsLink", "ID", "lnk_4032_BMMEBOM_ENGBOM_CTW");
				Function.WaitControlDisplayed(BMMEBOM2_EBOMLine_SubstitutePartsLink);
BMMEBOM2_EBOMLine_SubstitutePartsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM2] Performing VerifyExist on EBOMLine_SubstitutePartsTable...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM2_EBOMLine_SubstitutePartsTable = new SeleniumControl( sDriver, "EBOMLine_SubstitutePartsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMEBOM_SUBSTPART_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BMMEBOM2_EBOMLine_SubstitutePartsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM2] Performing ClickButton on EBOMLine_SubstitutePartsForm...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM2_EBOMLine_SubstitutePartsForm = new SeleniumControl( sDriver, "EBOMLine_SubstitutePartsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMEBOM_SUBSTPART_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BMMEBOM2_EBOMLine_SubstitutePartsForm);
IWebElement formBttn = BMMEBOM2_EBOMLine_SubstitutePartsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? BMMEBOM2_EBOMLine_SubstitutePartsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
BMMEBOM2_EBOMLine_SubstitutePartsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM2] Performing VerifyExists on EBOMLine_SubstituteParts_Sequence...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM2_EBOMLine_SubstituteParts_Sequence = new SeleniumControl( sDriver, "EBOMLine_SubstituteParts_Sequence", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMEBOM_SUBSTPART_']/ancestor::form[1]/descendant::*[@id='USAGE_SEQ_NO']");
				Function.AssertEqual(true,BMMEBOM2_EBOMLine_SubstituteParts_Sequence.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM2] Performing Close on EBOMLine_SubstitutePartsForm...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM2_EBOMLine_SubstitutePartsForm = new SeleniumControl( sDriver, "EBOMLine_SubstitutePartsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMEBOM_SUBSTPART_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BMMEBOM2_EBOMLine_SubstitutePartsForm);
IWebElement formBttn = BMMEBOM2_EBOMLine_SubstitutePartsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "BMMEBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM2] Performing Click on EBOMLine_PartDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM2_EBOMLine_PartDocumentsLink = new SeleniumControl( sDriver, "EBOMLine_PartDocumentsLink", "ID", "lnk_4033_BMMEBOM_ENGBOM_CTW");
				Function.WaitControlDisplayed(BMMEBOM2_EBOMLine_PartDocumentsLink);
BMMEBOM2_EBOMLine_PartDocumentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM2] Performing VerifyExists on EBOMLine_PartDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM2_EBOMLine_PartDocumentsForm = new SeleniumControl( sDriver, "EBOMLine_PartDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]");
				Function.AssertEqual(true,BMMEBOM2_EBOMLine_PartDocumentsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM2] Performing VerifyExist on EBOMLine_PartDocumentsTable...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM2_EBOMLine_PartDocumentsTable = new SeleniumControl( sDriver, "EBOMLine_PartDocumentsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BMMEBOM2_EBOMLine_PartDocumentsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM2] Performing ClickButton on EBOMLine_PartDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM2_EBOMLine_PartDocumentsForm = new SeleniumControl( sDriver, "EBOMLine_PartDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BMMEBOM2_EBOMLine_PartDocumentsForm);
IWebElement formBttn = BMMEBOM2_EBOMLine_PartDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? BMMEBOM2_EBOMLine_PartDocumentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
BMMEBOM2_EBOMLine_PartDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM2] Performing VerifyExists on EBOMLine_PartDocuments_Type...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM2_EBOMLine_PartDocuments_Type = new SeleniumControl( sDriver, "EBOMLine_PartDocuments_Type", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]/descendant::*[@id='DOC_TYPE_CD']");
				Function.AssertEqual(true,BMMEBOM2_EBOMLine_PartDocuments_Type.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM2] Performing Close on EBOMLine_PartDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM2_EBOMLine_PartDocumentsForm = new SeleniumControl( sDriver, "EBOMLine_PartDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BMMEBOM2_EBOMLine_PartDocumentsForm);
IWebElement formBttn = BMMEBOM2_EBOMLine_PartDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Create Prov Part");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM2] Performing Click on EBOMLine_CreateProvisionalPartLink...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM2_EBOMLine_CreateProvisionalPartLink = new SeleniumControl( sDriver, "EBOMLine_CreateProvisionalPartLink", "ID", "lnk_4034_BMMEBOM_ENGBOM_CTW");
				Function.WaitControlDisplayed(BMMEBOM2_EBOMLine_CreateProvisionalPartLink);
BMMEBOM2_EBOMLine_CreateProvisionalPartLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM2] Performing VerifyExists on EBOMLine_CreateProvisionalPartForm...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM2_EBOMLine_CreateProvisionalPartForm = new SeleniumControl( sDriver, "EBOMLine_CreateProvisionalPartForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMEBOM_CREATE_PROVPART_']/ancestor::form[1]");
				Function.AssertEqual(true,BMMEBOM2_EBOMLine_CreateProvisionalPartForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM2] Performing VerifyExists on EBOMLine_CreateProvisionalPart_PartID...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM2_EBOMLine_CreateProvisionalPart_PartID = new SeleniumControl( sDriver, "EBOMLine_CreateProvisionalPart_PartID", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMEBOM_CREATE_PROVPART_']/ancestor::form[1]/descendant::*[@id='PROV_PART_ID']");
				Function.AssertEqual(true,BMMEBOM2_EBOMLine_CreateProvisionalPart_PartID.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM2] Performing ClickButton on EBOMLine_CreateProvisionalPartForm...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM2_EBOMLine_CreateProvisionalPartForm = new SeleniumControl( sDriver, "EBOMLine_CreateProvisionalPartForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMEBOM_CREATE_PROVPART_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BMMEBOM2_EBOMLine_CreateProvisionalPartForm);
IWebElement formBttn = BMMEBOM2_EBOMLine_CreateProvisionalPartForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? BMMEBOM2_EBOMLine_CreateProvisionalPartForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
BMMEBOM2_EBOMLine_CreateProvisionalPartForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM2] Performing VerifyExist on EBOMLine_CreateProvisionalPartTable...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM2_EBOMLine_CreateProvisionalPartTable = new SeleniumControl( sDriver, "EBOMLine_CreateProvisionalPartTable", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMEBOM_CREATE_PROVPART_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BMMEBOM2_EBOMLine_CreateProvisionalPartTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMMEBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM2] Performing Close on EBOMLine_CreateProvisionalPartForm...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM2_EBOMLine_CreateProvisionalPartForm = new SeleniumControl( sDriver, "EBOMLine_CreateProvisionalPartForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMEBOM_CREATE_PROVPART_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BMMEBOM2_EBOMLine_CreateProvisionalPartForm);
IWebElement formBttn = BMMEBOM2_EBOMLine_CreateProvisionalPartForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "BMMEBOM2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMMEBOM2] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl BMMEBOM2_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(BMMEBOM2_MainForm);
IWebElement formBttn = BMMEBOM2_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

