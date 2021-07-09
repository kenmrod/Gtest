 
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
    public class MEMPBOM_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Materials Estimating", "xpath","//div[@class='deptItem'][.='Materials Estimating']").Click();
new SeleniumControl(sDriver,"Proposal Bills of Material", "xpath","//div[@class='navItem'][.='Proposal Bills of Material']").Click();
new SeleniumControl(sDriver,"Manage Proposal Bills of Material", "xpath","//div[@class='navItem'][.='Manage Proposal Bills of Material']").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SelectMenu]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPBOM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPBOM] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl MEMPBOM_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,MEMPBOM_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPBOM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPBOM] Performing VerifyExists on MainForm_Proposal...", Logger.MessageType.INF);
				SeleniumControl MEMPBOM_MainForm_Proposal = new SeleniumControl( sDriver, "MainForm_Proposal", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PROP_ID']");
				Function.AssertEqual(true,MEMPBOM_MainForm_Proposal.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPBOM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPBOM] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl MEMPBOM_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(MEMPBOM_MainForm);
IWebElement formBttn = MEMPBOM_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? MEMPBOM_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
MEMPBOM_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPBOM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPBOM] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl MEMPBOM_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,MEMPBOM_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPBOM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPBOM] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl MEMPBOM_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(MEMPBOM_MainForm);
IWebElement formBttn = MEMPBOM_MainForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).Count <= 0 ? MEMPBOM_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Query')]")).FirstOrDefault() :
MEMPBOM_MainForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Query not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "Query";
								Function.WaitControlDisplayed(new SeleniumControl(sDriver,"QueryTitle", "ID", "qryHeaderLabel"));
Function.AssertEqual("Maintain Proposal BOM", new SeleniumControl(sDriver,"QueryTitle", "ID", "qryHeaderLabel").GetValue().Trim());


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyTitle]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "Query";
								SeleniumControl ctl = new SeleniumControl(sDriver,"Target", "xpath_display", "//*[@id='basicQTbl']/tbody/tr/td/span[text()='Proposal']");
Function.WaitControlDisplayed(ctl);
SeleniumControl RelationshipField = new SeleniumControl(sDriver,"Relationship", ctl.mElement.FindElement(By.XPath("../following-sibling::td[1]")));
SeleniumControl SearchField = new SeleniumControl(sDriver,"Relationship", ctl.mElement.FindElement(By.XPath("../following-sibling::td[2]")));
new SeleniumControl(sDriver, "RelDropdown", RelationshipField.mElement.FindElements(By.XPath("./descendant::*[@class='tCCBImg']")).FirstOrDefault()).Click();
new SeleniumControl(sDriver, "RelItem", "xpath", ".//descendant::div[text() = 'is equal to']").Click();
if (SearchField.mElement.GetAttribute("class").Equals("tCCB")) {
new SeleniumControl(sDriver, "SearchDropdown", SearchField.mElement.FindElements(By.XPath(".//descendant::*[@class='tCCBImg']")).FirstOrDefault()).Click();
new SeleniumControl(sDriver, "SearchItem", "xpath_display", ".//descendant::div[text()='10000000000000000001']").Click();
} else { 
new SeleniumControl(sDriver, "SearchDropdown", SearchField.mElement.FindElements(By.XPath(".//descendant::*[@class='queryBasicFld']")).FirstOrDefault()).SendKeys("10000000000000000001");}


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SetSearchCriterion]" , ex.Message));
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
				Function.CurrentComponent = "MEMPBOM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPBOM] Performing VerifyExists on MainForm_AssemblyDetails_PartDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl MEMPBOM_MainForm_AssemblyDetails_PartDocumentsLink = new SeleniumControl( sDriver, "MainForm_AssemblyDetails_PartDocumentsLink", "ID", "lnk_1001803_MEMPBOM_PBOMHDR");
				Function.AssertEqual(true,MEMPBOM_MainForm_AssemblyDetails_PartDocumentsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
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
				Function.CurrentComponent = "MEMPBOM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPBOM] Performing Click on MainForm_AssemblyDetails_PartDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl MEMPBOM_MainForm_AssemblyDetails_PartDocumentsLink = new SeleniumControl( sDriver, "MainForm_AssemblyDetails_PartDocumentsLink", "ID", "lnk_1001803_MEMPBOM_PBOMHDR");
				Function.WaitControlDisplayed(MEMPBOM_MainForm_AssemblyDetails_PartDocumentsLink);
MEMPBOM_MainForm_AssemblyDetails_PartDocumentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPBOM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPBOM] Performing VerifyExist on PartDocumentsFormTable...", Logger.MessageType.INF);
				SeleniumControl MEMPBOM_PartDocumentsFormTable = new SeleniumControl( sDriver, "PartDocumentsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,MEMPBOM_PartDocumentsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPBOM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPBOM] Performing VerifyExists on PartDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl MEMPBOM_PartDocumentsForm = new SeleniumControl( sDriver, "PartDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]");
				Function.AssertEqual(true,MEMPBOM_PartDocumentsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPBOM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPBOM] Performing ClickButton on PartDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl MEMPBOM_PartDocumentsForm = new SeleniumControl( sDriver, "PartDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MEMPBOM_PartDocumentsForm);
IWebElement formBttn = MEMPBOM_PartDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? MEMPBOM_PartDocumentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
MEMPBOM_PartDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPBOM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPBOM] Performing VerifyExists on PartDocuments_Type...", Logger.MessageType.INF);
				SeleniumControl MEMPBOM_PartDocuments_Type = new SeleniumControl( sDriver, "PartDocuments_Type", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]/descendant::*[@id='DOC_TYPE_CD']");
				Function.AssertEqual(true,MEMPBOM_PartDocuments_Type.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPBOM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPBOM] Performing Close on PartDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl MEMPBOM_PartDocumentsForm = new SeleniumControl( sDriver, "PartDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MEMPBOM_PartDocumentsForm);
IWebElement formBttn = MEMPBOM_PartDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("CREATEPROVISIONALPART");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPBOM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPBOM] Performing Click on MainForm_CreateProvisionalPartLink...", Logger.MessageType.INF);
				SeleniumControl MEMPBOM_MainForm_CreateProvisionalPartLink = new SeleniumControl( sDriver, "MainForm_CreateProvisionalPartLink", "ID", "lnk_5011_MEMPBOM_PBOMHDR");
				Function.WaitControlDisplayed(MEMPBOM_MainForm_CreateProvisionalPartLink);
MEMPBOM_MainForm_CreateProvisionalPartLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPBOM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPBOM] Performing VerifyExists on CreateProvisionalPartForm...", Logger.MessageType.INF);
				SeleniumControl MEMPBOM_CreateProvisionalPartForm = new SeleniumControl( sDriver, "CreateProvisionalPartForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MEMPBOM_CREATE_PROVPART_']/ancestor::form[1]");
				Function.AssertEqual(true,MEMPBOM_CreateProvisionalPartForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPBOM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPBOM] Performing VerifyExists on CreateProvisionalPart_PartID...", Logger.MessageType.INF);
				SeleniumControl MEMPBOM_CreateProvisionalPart_PartID = new SeleniumControl( sDriver, "CreateProvisionalPart_PartID", "xpath", "//div[translate(@id,'0123456789','')='pr__MEMPBOM_CREATE_PROVPART_']/ancestor::form[1]/descendant::*[@id='PROV_PART_ID']");
				Function.AssertEqual(true,MEMPBOM_CreateProvisionalPart_PartID.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPBOM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPBOM] Performing Close on CreateProvisionalPartForm...", Logger.MessageType.INF);
				SeleniumControl MEMPBOM_CreateProvisionalPartForm = new SeleniumControl( sDriver, "CreateProvisionalPartForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MEMPBOM_CREATE_PROVPART_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MEMPBOM_CreateProvisionalPartForm);
IWebElement formBttn = MEMPBOM_CreateProvisionalPartForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
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
				Function.CurrentComponent = "MEMPBOM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPBOM] Performing ClickButton on PBOMLineForm...", Logger.MessageType.INF);
				SeleniumControl MEMPBOM_PBOMLineForm = new SeleniumControl( sDriver, "PBOMLineForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MEMPBOM_PBOMLN_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MEMPBOM_PBOMLineForm);
IWebElement formBttn = MEMPBOM_PBOMLineForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? MEMPBOM_PBOMLineForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
MEMPBOM_PBOMLineForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPBOM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPBOM] Performing VerifyExists on PBOMLineForm...", Logger.MessageType.INF);
				SeleniumControl MEMPBOM_PBOMLineForm = new SeleniumControl( sDriver, "PBOMLineForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MEMPBOM_PBOMLN_']/ancestor::form[1]");
				Function.AssertEqual(true,MEMPBOM_PBOMLineForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("ALTERNATEPARTS");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPBOM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPBOM] Performing Click on PBOMLine_AlternatePartsLink...", Logger.MessageType.INF);
				SeleniumControl MEMPBOM_PBOMLine_AlternatePartsLink = new SeleniumControl( sDriver, "PBOMLine_AlternatePartsLink", "ID", "lnk_4993_MEMPBOM_PBOMLN");
				Function.WaitControlDisplayed(MEMPBOM_PBOMLine_AlternatePartsLink);
MEMPBOM_PBOMLine_AlternatePartsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPBOM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPBOM] Performing VerifyExists on AlternatePartsForm...", Logger.MessageType.INF);
				SeleniumControl MEMPBOM_AlternatePartsForm = new SeleniumControl( sDriver, "AlternatePartsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ME_ALTPART_']/ancestor::form[1]");
				Function.AssertEqual(true,MEMPBOM_AlternatePartsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPBOM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPBOM] Performing VerifyExist on AlternatePartsFormTable...", Logger.MessageType.INF);
				SeleniumControl MEMPBOM_AlternatePartsFormTable = new SeleniumControl( sDriver, "AlternatePartsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__ME_ALTPART_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,MEMPBOM_AlternatePartsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPBOM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPBOM] Performing ClickButton on AlternatePartsForm...", Logger.MessageType.INF);
				SeleniumControl MEMPBOM_AlternatePartsForm = new SeleniumControl( sDriver, "AlternatePartsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ME_ALTPART_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MEMPBOM_AlternatePartsForm);
IWebElement formBttn = MEMPBOM_AlternatePartsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? MEMPBOM_AlternatePartsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
MEMPBOM_AlternatePartsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPBOM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPBOM] Performing VerifyExists on PBOMLine_AlternateParts_ManufacturerPart_Manufacturer...", Logger.MessageType.INF);
				SeleniumControl MEMPBOM_PBOMLine_AlternateParts_ManufacturerPart_Manufacturer = new SeleniumControl( sDriver, "PBOMLine_AlternateParts_ManufacturerPart_Manufacturer", "xpath", "//div[translate(@id,'0123456789','')='pr__ME_ALTPART_']/ancestor::form[1]/descendant::*[@id='MANUF_ID']");
				Function.AssertEqual(true,MEMPBOM_PBOMLine_AlternateParts_ManufacturerPart_Manufacturer.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPBOM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPBOM] Performing Close on AlternatePartsForm...", Logger.MessageType.INF);
				SeleniumControl MEMPBOM_AlternatePartsForm = new SeleniumControl( sDriver, "AlternatePartsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ME_ALTPART_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MEMPBOM_AlternatePartsForm);
IWebElement formBttn = MEMPBOM_AlternatePartsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("SUBSITITUTEPARTS");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPBOM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPBOM] Performing Click on PBOMLine_SubstitutePartsLink...", Logger.MessageType.INF);
				SeleniumControl MEMPBOM_PBOMLine_SubstitutePartsLink = new SeleniumControl( sDriver, "PBOMLine_SubstitutePartsLink", "ID", "lnk_4997_MEMPBOM_PBOMLN");
				Function.WaitControlDisplayed(MEMPBOM_PBOMLine_SubstitutePartsLink);
MEMPBOM_PBOMLine_SubstitutePartsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPBOM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPBOM] Performing VerifyExists on SubstitutePartsForm...", Logger.MessageType.INF);
				SeleniumControl MEMPBOM_SubstitutePartsForm = new SeleniumControl( sDriver, "SubstitutePartsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ME_SUBSTPART_']/ancestor::form[1]");
				Function.AssertEqual(true,MEMPBOM_SubstitutePartsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPBOM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPBOM] Performing VerifyExist on SubstitutePartsFormTable...", Logger.MessageType.INF);
				SeleniumControl MEMPBOM_SubstitutePartsFormTable = new SeleniumControl( sDriver, "SubstitutePartsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__ME_SUBSTPART_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,MEMPBOM_SubstitutePartsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPBOM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPBOM] Performing ClickButton on SubstitutePartsForm...", Logger.MessageType.INF);
				SeleniumControl MEMPBOM_SubstitutePartsForm = new SeleniumControl( sDriver, "SubstitutePartsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ME_SUBSTPART_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MEMPBOM_SubstitutePartsForm);
IWebElement formBttn = MEMPBOM_SubstitutePartsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? MEMPBOM_SubstitutePartsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
MEMPBOM_SubstitutePartsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPBOM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPBOM] Performing VerifyExists on SubstitutePartsForm...", Logger.MessageType.INF);
				SeleniumControl MEMPBOM_SubstitutePartsForm = new SeleniumControl( sDriver, "SubstitutePartsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ME_SUBSTPART_']/ancestor::form[1]");
				Function.AssertEqual(true,MEMPBOM_SubstitutePartsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPBOM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPBOM] Performing VerifyExists on PBOMLine_SubstituteParts_AlternateParts_Sequence...", Logger.MessageType.INF);
				SeleniumControl MEMPBOM_PBOMLine_SubstituteParts_AlternateParts_Sequence = new SeleniumControl( sDriver, "PBOMLine_SubstituteParts_AlternateParts_Sequence", "xpath", "//div[translate(@id,'0123456789','')='pr__ME_SUBSTPART_']/ancestor::form[1]/descendant::*[@id='USAGE_SEQ_NO']");
				Function.AssertEqual(true,MEMPBOM_PBOMLine_SubstituteParts_AlternateParts_Sequence.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPBOM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPBOM] Performing Close on SubstitutePartsForm...", Logger.MessageType.INF);
				SeleniumControl MEMPBOM_SubstitutePartsForm = new SeleniumControl( sDriver, "SubstitutePartsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ME_SUBSTPART_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MEMPBOM_SubstitutePartsForm);
IWebElement formBttn = MEMPBOM_SubstitutePartsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "MEMPBOM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPBOM] Performing Click on PBOMLine_PartDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl MEMPBOM_PBOMLine_PartDocumentsLink = new SeleniumControl( sDriver, "PBOMLine_PartDocumentsLink", "ID", "lnk_1001629_MEMPBOM_PBOMLN");
				Function.WaitControlDisplayed(MEMPBOM_PBOMLine_PartDocumentsLink);
MEMPBOM_PBOMLine_PartDocumentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPBOM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPBOM] Performing VerifyExists on PartDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl MEMPBOM_PartDocumentsForm = new SeleniumControl( sDriver, "PartDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]");
				Function.AssertEqual(true,MEMPBOM_PartDocumentsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPBOM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPBOM] Performing ClickButton on PartDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl MEMPBOM_PartDocumentsForm = new SeleniumControl( sDriver, "PartDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MEMPBOM_PartDocumentsForm);
IWebElement formBttn = MEMPBOM_PartDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? MEMPBOM_PartDocumentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
MEMPBOM_PartDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPBOM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPBOM] Performing VerifyExists on PartDocuments_Type...", Logger.MessageType.INF);
				SeleniumControl MEMPBOM_PartDocuments_Type = new SeleniumControl( sDriver, "PartDocuments_Type", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]/descendant::*[@id='DOC_TYPE_CD']");
				Function.AssertEqual(true,MEMPBOM_PartDocuments_Type.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPBOM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPBOM] Performing Close on PartDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl MEMPBOM_PartDocumentsForm = new SeleniumControl( sDriver, "PartDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MEMPBOM_PartDocumentsForm);
IWebElement formBttn = MEMPBOM_PartDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("CREATEPROVISIONALPART");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPBOM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPBOM] Performing Click on PBOMLine_CreateProvisionalPartLink...", Logger.MessageType.INF);
				SeleniumControl MEMPBOM_PBOMLine_CreateProvisionalPartLink = new SeleniumControl( sDriver, "PBOMLine_CreateProvisionalPartLink", "ID", "lnk_5012_MEMPBOM_PBOMLN");
				Function.WaitControlDisplayed(MEMPBOM_PBOMLine_CreateProvisionalPartLink);
MEMPBOM_PBOMLine_CreateProvisionalPartLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPBOM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPBOM] Performing VerifyExists on CreateProvisionalPartForm...", Logger.MessageType.INF);
				SeleniumControl MEMPBOM_CreateProvisionalPartForm = new SeleniumControl( sDriver, "CreateProvisionalPartForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MEMPBOM_CREATE_PROVPART_']/ancestor::form[1]");
				Function.AssertEqual(true,MEMPBOM_CreateProvisionalPartForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPBOM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPBOM] Performing VerifyExists on CreateProvisionalPart_PartID...", Logger.MessageType.INF);
				SeleniumControl MEMPBOM_CreateProvisionalPart_PartID = new SeleniumControl( sDriver, "CreateProvisionalPart_PartID", "xpath", "//div[translate(@id,'0123456789','')='pr__MEMPBOM_CREATE_PROVPART_']/ancestor::form[1]/descendant::*[@id='PROV_PART_ID']");
				Function.AssertEqual(true,MEMPBOM_CreateProvisionalPart_PartID.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPBOM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPBOM] Performing Close on CreateProvisionalPartForm...", Logger.MessageType.INF);
				SeleniumControl MEMPBOM_CreateProvisionalPartForm = new SeleniumControl( sDriver, "CreateProvisionalPartForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MEMPBOM_CREATE_PROVPART_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MEMPBOM_CreateProvisionalPartForm);
IWebElement formBttn = MEMPBOM_CreateProvisionalPartForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("PRODUCTOPTIONITEMS");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPBOM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPBOM] Performing Click on PBOMLine_ProductOptionItemsLink...", Logger.MessageType.INF);
				SeleniumControl MEMPBOM_PBOMLine_ProductOptionItemsLink = new SeleniumControl( sDriver, "PBOMLine_ProductOptionItemsLink", "ID", "lnk_5060_MEMPBOM_PBOMLN");
				Function.WaitControlDisplayed(MEMPBOM_PBOMLine_ProductOptionItemsLink);
MEMPBOM_PBOMLine_ProductOptionItemsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPBOM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPBOM] Performing VerifyExist on ProductOptionItemsFormTable...", Logger.MessageType.INF);
				SeleniumControl MEMPBOM_ProductOptionItemsFormTable = new SeleniumControl( sDriver, "ProductOptionItemsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__MEMPBOM_PRODOPTIONID_DEFAULT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,MEMPBOM_ProductOptionItemsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPBOM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPBOM] Performing Close on ProductOptionItemsForm...", Logger.MessageType.INF);
				SeleniumControl MEMPBOM_ProductOptionItemsForm = new SeleniumControl( sDriver, "ProductOptionItemsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MEMPBOM_PRODOPTIONID_DEFAULT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MEMPBOM_ProductOptionItemsForm);
IWebElement formBttn = MEMPBOM_ProductOptionItemsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMPBOM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMPBOM] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl MEMPBOM_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(MEMPBOM_MainForm);
IWebElement formBttn = MEMPBOM_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

