 
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
    public class PCQMOST_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Production Control", "xpath","//div[@class='deptItem'][.='Production Control']").Click();
new SeleniumControl(sDriver,"Production Control Reports/Inquiries", "xpath","//div[@class='navItem'][.='Production Control Reports/Inquiries']").Click();
new SeleniumControl(sDriver,"View Manufacturing Order Status", "xpath","//div[@class='navItem'][.='View Manufacturing Order Status']").Click();


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
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,PCQMOST_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing VerifyExists on MO...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_MO = new SeleniumControl( sDriver, "MO", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='MO_ID']");
				Function.AssertEqual(true,PCQMOST_MO.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
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
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing VerifyExists on ChildForm...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCQMOST_MOHDR_CHLD_']/ancestor::form[1]");
				Function.AssertEqual(true,PCQMOST_ChildForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing VerifyExist on ChildFormTable...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildFormTable = new SeleniumControl( sDriver, "ChildFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PCQMOST_MOHDR_CHLD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PCQMOST_ChildFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing ClickButton on ChildForm...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCQMOST_MOHDR_CHLD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCQMOST_ChildForm);
IWebElement formBttn = PCQMOST_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).Count <= 0 ? PCQMOST_ChildForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Query')]")).FirstOrDefault() :
PCQMOST_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).FirstOrDefault();
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
				this.ScriptLogger.WriteLine("Text Codes");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing Click on ChildForm_TextCodesLink...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildForm_TextCodesLink = new SeleniumControl( sDriver, "ChildForm_TextCodesLink", "ID", "lnk_1006482_PCQMOST_MOHDR_CHLD");
				Function.WaitControlDisplayed(PCQMOST_ChildForm_TextCodesLink);
PCQMOST_ChildForm_TextCodesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing VerifyExists on ChildForm_TextCodesForm...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildForm_TextCodesForm = new SeleniumControl( sDriver, "ChildForm_TextCodesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCQMOST_MOHDRTXT_DETAIL_']/ancestor::form[1]");
				Function.AssertEqual(true,PCQMOST_ChildForm_TextCodesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing VerifyExist on ChildForm_TextCodesFormTable...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildForm_TextCodesFormTable = new SeleniumControl( sDriver, "ChildForm_TextCodesFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PCQMOST_MOHDRTXT_DETAIL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PCQMOST_ChildForm_TextCodesFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing ClickButton on ChildForm_TextCodesForm...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildForm_TextCodesForm = new SeleniumControl( sDriver, "ChildForm_TextCodesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCQMOST_MOHDRTXT_DETAIL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCQMOST_ChildForm_TextCodesForm);
IWebElement formBttn = PCQMOST_ChildForm_TextCodesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PCQMOST_ChildForm_TextCodesForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PCQMOST_ChildForm_TextCodesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing VerifyExists on ChildForm_TextCodes_Sequence...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildForm_TextCodes_Sequence = new SeleniumControl( sDriver, "ChildForm_TextCodes_Sequence", "xpath", "//div[translate(@id,'0123456789','')='pr__PCQMOST_MOHDRTXT_DETAIL_']/ancestor::form[1]/descendant::*[@id='SEQ_NO']");
				Function.AssertEqual(true,PCQMOST_ChildForm_TextCodes_Sequence.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing Close on ChildForm_TextCodesForm...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildForm_TextCodesForm = new SeleniumControl( sDriver, "ChildForm_TextCodesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCQMOST_MOHDRTXT_DETAIL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCQMOST_ChildForm_TextCodesForm);
IWebElement formBttn = PCQMOST_ChildForm_TextCodesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing Click on ChildForm_PartDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildForm_PartDocumentsLink = new SeleniumControl( sDriver, "ChildForm_PartDocumentsLink", "ID", "lnk_1006483_PCQMOST_MOHDR_CHLD");
				Function.WaitControlDisplayed(PCQMOST_ChildForm_PartDocumentsLink);
PCQMOST_ChildForm_PartDocumentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing VerifyExists on ChildForm_PartDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildForm_PartDocumentsForm = new SeleniumControl( sDriver, "ChildForm_PartDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]");
				Function.AssertEqual(true,PCQMOST_ChildForm_PartDocumentsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing VerifyExist on ChildForm_PartDocumentsFormTable...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildForm_PartDocumentsFormTable = new SeleniumControl( sDriver, "ChildForm_PartDocumentsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PCQMOST_ChildForm_PartDocumentsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing ClickButton on ChildForm_PartDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildForm_PartDocumentsForm = new SeleniumControl( sDriver, "ChildForm_PartDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCQMOST_ChildForm_PartDocumentsForm);
IWebElement formBttn = PCQMOST_ChildForm_PartDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PCQMOST_ChildForm_PartDocumentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PCQMOST_ChildForm_PartDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing VerifyExists on ChildForm_PartDocuments_Type...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildForm_PartDocuments_Type = new SeleniumControl( sDriver, "ChildForm_PartDocuments_Type", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]/descendant::*[@id='DOC_TYPE_CD']");
				Function.AssertEqual(true,PCQMOST_ChildForm_PartDocuments_Type.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing Close on ChildForm_PartDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildForm_PartDocumentsForm = new SeleniumControl( sDriver, "ChildForm_PartDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCQMOST_ChildForm_PartDocumentsForm);
IWebElement formBttn = PCQMOST_ChildForm_PartDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Requirements");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing ClickButton on ChildForm...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCQMOST_MOHDR_CHLD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCQMOST_ChildForm);
IWebElement formBttn = PCQMOST_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).Count <= 0 ? PCQMOST_ChildForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Query')]")).FirstOrDefault() :
PCQMOST_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Query not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "Query";
								SeleniumControl ctl = new SeleniumControl(sDriver,"Target", "xpath_display", "//*[@id='basicQTbl']/tbody/tr/td/span[text()='Manufacturing Order ']");
Function.WaitControlDisplayed(ctl);
SeleniumControl RelationshipField = new SeleniumControl(sDriver,"Relationship", ctl.mElement.FindElement(By.XPath("../following-sibling::td[1]")));
SeleniumControl SearchField = new SeleniumControl(sDriver,"Relationship", ctl.mElement.FindElement(By.XPath("../following-sibling::td[2]")));
new SeleniumControl(sDriver, "RelDropdown", RelationshipField.mElement.FindElements(By.XPath("./descendant::*[@class='tCCBImg']")).FirstOrDefault()).Click();
new SeleniumControl(sDriver, "RelItem", "xpath_display", ".//descendant::div[text() = 'begins with']").Click();
if (SearchField.mElement.GetAttribute("class").Equals("tCCB")) {
new SeleniumControl(sDriver, "SearchDropdown", SearchField.mElement.FindElements(By.XPath(".//descendant::*[@class='tCCBImg']")).FirstOrDefault()).Click();
new SeleniumControl(sDriver, "SearchItem", "xpath_display", ".//descendant::div[text()='MO-W010002']").Click();
} else { 
new SeleniumControl(sDriver, "SearchDropdown", SearchField.mElement.FindElements(By.XPath(".//descendant::*[@class='queryBasicFld']")).FirstOrDefault()).SendKeys("MO-W010002");}


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
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing Click on ChildForm_RequirementsLink...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildForm_RequirementsLink = new SeleniumControl( sDriver, "ChildForm_RequirementsLink", "ID", "lnk_1006553_PCQMOST_MOHDR_CHLD");
				Function.WaitControlDisplayed(PCQMOST_ChildForm_RequirementsLink);
PCQMOST_ChildForm_RequirementsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing ClickButton on ChildForm_RequirementsForm...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildForm_RequirementsForm = new SeleniumControl( sDriver, "ChildForm_RequirementsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCQMOST_MORQMT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCQMOST_ChildForm_RequirementsForm);
IWebElement formBttn = PCQMOST_ChildForm_RequirementsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PCQMOST_ChildForm_RequirementsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PCQMOST_ChildForm_RequirementsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing VerifyExists on ChildForm_RequirementsForm...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildForm_RequirementsForm = new SeleniumControl( sDriver, "ChildForm_RequirementsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCQMOST_MORQMT_']/ancestor::form[1]");
				Function.AssertEqual(true,PCQMOST_ChildForm_RequirementsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing ClickButton on ChildForm_RequirementsForm...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildForm_RequirementsForm = new SeleniumControl( sDriver, "ChildForm_RequirementsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCQMOST_MORQMT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCQMOST_ChildForm_RequirementsForm);
IWebElement formBttn = PCQMOST_ChildForm_RequirementsForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? PCQMOST_ChildForm_RequirementsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
PCQMOST_ChildForm_RequirementsForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing VerifyExist on ChildForm_RequirementsFormTable...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildForm_RequirementsFormTable = new SeleniumControl( sDriver, "ChildForm_RequirementsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PCQMOST_MORQMT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PCQMOST_ChildForm_RequirementsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing ClickButton on ChildForm_RequirementsForm...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildForm_RequirementsForm = new SeleniumControl( sDriver, "ChildForm_RequirementsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCQMOST_MORQMT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCQMOST_ChildForm_RequirementsForm);
IWebElement formBttn = PCQMOST_ChildForm_RequirementsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PCQMOST_ChildForm_RequirementsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PCQMOST_ChildForm_RequirementsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing VerifyExists on ChildForm_Requirements_LineNumber...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildForm_Requirements_LineNumber = new SeleniumControl( sDriver, "ChildForm_Requirements_LineNumber", "xpath", "//div[translate(@id,'0123456789','')='pr__PCQMOST_MORQMT_']/ancestor::form[1]/descendant::*[@id='COMP_LN_NO']");
				Function.AssertEqual(true,PCQMOST_ChildForm_Requirements_LineNumber.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing VerifyExists on ChildForm_Requirements_Details_InvAbbrev...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildForm_Requirements_Details_InvAbbrev = new SeleniumControl( sDriver, "ChildForm_Requirements_Details_InvAbbrev", "xpath", "//div[translate(@id,'0123456789','')='pr__PCQMOST_MORQMT_']/ancestor::form[1]/descendant::*[@id='INVT_ABBRV_CD']");
				Function.AssertEqual(true,PCQMOST_ChildForm_Requirements_Details_InvAbbrev.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing Select on ChildForm_Requirements_RequirementsTab...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildForm_Requirements_RequirementsTab = new SeleniumControl( sDriver, "ChildForm_Requirements_RequirementsTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PCQMOST_MORQMT_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PCQMOST_ChildForm_Requirements_RequirementsTab);
IWebElement mTab = PCQMOST_ChildForm_Requirements_RequirementsTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Component Inventory").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing VerifyExists on ChildForm_Requirements_ComponentInventory_InventoryQuantities_CurrentAvailable...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildForm_Requirements_ComponentInventory_InventoryQuantities_CurrentAvailable = new SeleniumControl( sDriver, "ChildForm_Requirements_ComponentInventory_InventoryQuantities_CurrentAvailable", "xpath", "//div[translate(@id,'0123456789','')='pr__PCQMOST_MORQMT_']/ancestor::form[1]/descendant::*[@id='CUR_AVAIL_QTY']");
				Function.AssertEqual(true,PCQMOST_ChildForm_Requirements_ComponentInventory_InventoryQuantities_CurrentAvailable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing Select on ChildForm_Requirements_RequirementsTab...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildForm_Requirements_RequirementsTab = new SeleniumControl( sDriver, "ChildForm_Requirements_RequirementsTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PCQMOST_MORQMT_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PCQMOST_ChildForm_Requirements_RequirementsTab);
IWebElement mTab = PCQMOST_ChildForm_Requirements_RequirementsTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue().ToLower() == "component info").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing VerifyExists on ChildForm_Requirements_ComponentInfo_ComponentInformation_Backflush...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildForm_Requirements_ComponentInfo_ComponentInformation_Backflush = new SeleniumControl( sDriver, "ChildForm_Requirements_ComponentInfo_ComponentInformation_Backflush", "xpath", "//div[translate(@id,'0123456789','')='pr__PCQMOST_MORQMT_']/ancestor::form[1]/descendant::*[@id='BKFLSH_FL']");
				Function.AssertEqual(true,PCQMOST_ChildForm_Requirements_ComponentInfo_ComponentInformation_Backflush.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing Select on ChildForm_Requirements_RequirementsTab...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildForm_Requirements_RequirementsTab = new SeleniumControl( sDriver, "ChildForm_Requirements_RequirementsTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PCQMOST_MORQMT_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PCQMOST_ChildForm_Requirements_RequirementsTab);
IWebElement mTab = PCQMOST_ChildForm_Requirements_RequirementsTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Notes").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing VerifyExists on ChildForm_Requirements_Notes_PartExpediteNotes...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildForm_Requirements_Notes_PartExpediteNotes = new SeleniumControl( sDriver, "ChildForm_Requirements_Notes_PartExpediteNotes", "xpath", "//div[translate(@id,'0123456789','')='pr__PCQMOST_MORQMT_']/ancestor::form[1]/descendant::*[@id='EXPDT_TX']");
				Function.AssertEqual(true,PCQMOST_ChildForm_Requirements_Notes_PartExpediteNotes.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing Close on ChildForm_RequirementsForm...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildForm_RequirementsForm = new SeleniumControl( sDriver, "ChildForm_RequirementsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCQMOST_MORQMT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCQMOST_ChildForm_RequirementsForm);
IWebElement formBttn = PCQMOST_ChildForm_RequirementsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Issues");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing Click on ChildForm_IssuesLink...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildForm_IssuesLink = new SeleniumControl( sDriver, "ChildForm_IssuesLink", "ID", "lnk_1006649_PCQMOST_MOHDR_CHLD");
				Function.WaitControlDisplayed(PCQMOST_ChildForm_IssuesLink);
PCQMOST_ChildForm_IssuesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing VerifyExists on ChildForm_IssuesForm...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildForm_IssuesForm = new SeleniumControl( sDriver, "ChildForm_IssuesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCQMOST_ISSUE_HDR_']/ancestor::form[1]");
				Function.AssertEqual(true,PCQMOST_ChildForm_IssuesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing VerifyExists on ChildForm_Issues_TotalMaterialIssueAmount...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildForm_Issues_TotalMaterialIssueAmount = new SeleniumControl( sDriver, "ChildForm_Issues_TotalMaterialIssueAmount", "xpath", "//div[translate(@id,'0123456789','')='pr__PCQMOST_ISSUE_HDR_']/ancestor::form[1]/descendant::*[@id='ISS_AMT']");
				Function.AssertEqual(true,PCQMOST_ChildForm_Issues_TotalMaterialIssueAmount.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing VerifyExists on ChildForm_Issues_IssuesForm...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildForm_Issues_IssuesForm = new SeleniumControl( sDriver, "ChildForm_Issues_IssuesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCQMOST_INVTTRN_ISSUES_']/ancestor::form[1]");
				Function.AssertEqual(true,PCQMOST_ChildForm_Issues_IssuesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing VerifyExist on ChildForm_Issues_IssuesFormTable...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildForm_Issues_IssuesFormTable = new SeleniumControl( sDriver, "ChildForm_Issues_IssuesFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PCQMOST_INVTTRN_ISSUES_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PCQMOST_ChildForm_Issues_IssuesFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing ClickButton on ChildForm_Issues_IssuesForm...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildForm_Issues_IssuesForm = new SeleniumControl( sDriver, "ChildForm_Issues_IssuesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCQMOST_INVTTRN_ISSUES_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCQMOST_ChildForm_Issues_IssuesForm);
IWebElement formBttn = PCQMOST_ChildForm_Issues_IssuesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PCQMOST_ChildForm_Issues_IssuesForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PCQMOST_ChildForm_Issues_IssuesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing VerifyExists on ChildForm_Issues_Issues_Details_Issue...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildForm_Issues_Issues_Details_Issue = new SeleniumControl( sDriver, "ChildForm_Issues_Issues_Details_Issue", "xpath", "//div[translate(@id,'0123456789','')='pr__PCQMOST_INVTTRN_ISSUES_']/ancestor::form[1]/descendant::*[@id='INVT_TRN_ID']");
				Function.AssertEqual(true,PCQMOST_ChildForm_Issues_Issues_Details_Issue.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing Select on ChildForm_Issues_IssuesTab...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildForm_Issues_IssuesTab = new SeleniumControl( sDriver, "ChildForm_Issues_IssuesTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PCQMOST_INVTTRN_ISSUES_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PCQMOST_ChildForm_Issues_IssuesTab);
IWebElement mTab = PCQMOST_ChildForm_Issues_IssuesTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Cost Elements").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing VerifyExists on ChildForm_Issues_Issues_CostElements_Burden_Labor...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildForm_Issues_Issues_CostElements_Burden_Labor = new SeleniumControl( sDriver, "ChildForm_Issues_Issues_CostElements_Burden_Labor", "xpath", "//div[translate(@id,'0123456789','')='pr__PCQMOST_INVTTRN_ISSUES_']/ancestor::form[1]/descendant::*[@id='LAB_BURD_CST_AMT']");
				Function.AssertEqual(true,PCQMOST_ChildForm_Issues_Issues_CostElements_Burden_Labor.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing Select on ChildForm_Issues_IssuesTab...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildForm_Issues_IssuesTab = new SeleniumControl( sDriver, "ChildForm_Issues_IssuesTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PCQMOST_INVTTRN_ISSUES_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PCQMOST_ChildForm_Issues_IssuesTab);
IWebElement mTab = PCQMOST_ChildForm_Issues_IssuesTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Notes").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing VerifyExists on ChildForm_Issues_Issues_Notes_Notes...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildForm_Issues_Issues_Notes_Notes = new SeleniumControl( sDriver, "ChildForm_Issues_Issues_Notes_Notes", "xpath", "//div[translate(@id,'0123456789','')='pr__PCQMOST_INVTTRN_ISSUES_']/ancestor::form[1]/descendant::*[@id='COMMENT_NT']");
				Function.AssertEqual(true,PCQMOST_ChildForm_Issues_Issues_Notes_Notes.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing Close on ChildForm_IssuesForm...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildForm_IssuesForm = new SeleniumControl( sDriver, "ChildForm_IssuesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCQMOST_ISSUE_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCQMOST_ChildForm_IssuesForm);
IWebElement formBttn = PCQMOST_ChildForm_IssuesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Reliefs");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing ClickButton on ChildForm...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCQMOST_MOHDR_CHLD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCQMOST_ChildForm);
IWebElement formBttn = PCQMOST_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).Count <= 0 ? PCQMOST_ChildForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Query')]")).FirstOrDefault() :
PCQMOST_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Query not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "Query";
								SeleniumControl ctl = new SeleniumControl(sDriver,"Target", "xpath_display", "//*[@id='basicQTbl']/tbody/tr/td/span[text()='Manufacturing Order ']");
Function.WaitControlDisplayed(ctl);
SeleniumControl RelationshipField = new SeleniumControl(sDriver,"Relationship", ctl.mElement.FindElement(By.XPath("../following-sibling::td[1]")));
SeleniumControl SearchField = new SeleniumControl(sDriver,"Relationship", ctl.mElement.FindElement(By.XPath("../following-sibling::td[2]")));
new SeleniumControl(sDriver, "RelDropdown", RelationshipField.mElement.FindElements(By.XPath("./descendant::*[@class='tCCBImg']")).FirstOrDefault()).Click();
new SeleniumControl(sDriver, "RelItem", "xpath_display", ".//descendant::div[text() = 'begins with']").Click();
if (SearchField.mElement.GetAttribute("class").Equals("tCCB")) {
new SeleniumControl(sDriver, "SearchDropdown", SearchField.mElement.FindElements(By.XPath(".//descendant::*[@class='tCCBImg']")).FirstOrDefault()).Click();
new SeleniumControl(sDriver, "SearchItem", "xpath_display", ".//descendant::div[text()='MOW100001']").Click();
} else {
        IWebElement elem = SearchField.mElement.FindElements(By.XPath(".//descendant::*[@class='queryBasicFld']")).FirstOrDefault(); elem.Clear(); elem.Click();
        new SeleniumControl(sDriver, "SearchDropdown", SearchField.mElement.FindElements(By.XPath(".//descendant::*[@class='queryBasicFld']")).FirstOrDefault()).SendKeys("MOW100001");}
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
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing Click on ChildForm_ReliefsLink...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildForm_ReliefsLink = new SeleniumControl( sDriver, "ChildForm_ReliefsLink", "ID", "lnk_4862_PCQMOST_MOHDR_CHLD");
				Function.WaitControlDisplayed(PCQMOST_ChildForm_ReliefsLink);
PCQMOST_ChildForm_ReliefsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing VerifyExists on ChildForm_ReliefsForm...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildForm_ReliefsForm = new SeleniumControl( sDriver, "ChildForm_ReliefsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCQMOST_RELIEF_HDR_RS_']/ancestor::form[1]");
				Function.AssertEqual(true,PCQMOST_ChildForm_ReliefsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing VerifyExists on ChildForm_Reliefs_TotalMOCostAmount...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildForm_Reliefs_TotalMOCostAmount = new SeleniumControl( sDriver, "ChildForm_Reliefs_TotalMOCostAmount", "xpath", "//div[translate(@id,'0123456789','')='pr__PCQMOST_RELIEF_HDR_RS_']/ancestor::form[1]/descendant::*[@id='TOT_MO']");
				Function.AssertEqual(true,PCQMOST_ChildForm_Reliefs_TotalMOCostAmount.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing VerifyExists on ChildForm_Reliefs_ReliefsForm...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildForm_Reliefs_ReliefsForm = new SeleniumControl( sDriver, "ChildForm_Reliefs_ReliefsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCQMOST_INVTTRN_RELIEF_']/ancestor::form[1]");
				Function.AssertEqual(true,PCQMOST_ChildForm_Reliefs_ReliefsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing VerifyExist on ChildForm_Reliefs_ReliefsFormTable...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildForm_Reliefs_ReliefsFormTable = new SeleniumControl( sDriver, "ChildForm_Reliefs_ReliefsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PCQMOST_INVTTRN_RELIEF_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PCQMOST_ChildForm_Reliefs_ReliefsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing ClickButton on ChildForm_Reliefs_ReliefsForm...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildForm_Reliefs_ReliefsForm = new SeleniumControl( sDriver, "ChildForm_Reliefs_ReliefsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCQMOST_INVTTRN_RELIEF_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCQMOST_ChildForm_Reliefs_ReliefsForm);
IWebElement formBttn = PCQMOST_ChildForm_Reliefs_ReliefsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PCQMOST_ChildForm_Reliefs_ReliefsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PCQMOST_ChildForm_Reliefs_ReliefsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing VerifyExists on ChildForm_Reliefs_Reliefs_Details_Relief...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildForm_Reliefs_Reliefs_Details_Relief = new SeleniumControl( sDriver, "ChildForm_Reliefs_Reliefs_Details_Relief", "xpath", "//div[translate(@id,'0123456789','')='pr__PCQMOST_INVTTRN_RELIEF_']/ancestor::form[1]/descendant::*[@id='INVT_TRN_ID']");
				Function.AssertEqual(true,PCQMOST_ChildForm_Reliefs_Reliefs_Details_Relief.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing Select on ChildForm_Reliefs_ReliefsTab...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildForm_Reliefs_ReliefsTab = new SeleniumControl( sDriver, "ChildForm_Reliefs_ReliefsTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PCQMOST_INVTTRN_RELIEF_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PCQMOST_ChildForm_Reliefs_ReliefsTab);
IWebElement mTab = PCQMOST_ChildForm_Reliefs_ReliefsTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Cost Elements").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing VerifyExists on ChildForm_Reliefs_Reliefs_CostElements_Burden_Labor...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildForm_Reliefs_Reliefs_CostElements_Burden_Labor = new SeleniumControl( sDriver, "ChildForm_Reliefs_Reliefs_CostElements_Burden_Labor", "xpath", "//div[translate(@id,'0123456789','')='pr__PCQMOST_INVTTRN_RELIEF_']/ancestor::form[1]/descendant::*[@id='LAB_BURD_CST_AMT']");
				Function.AssertEqual(true,PCQMOST_ChildForm_Reliefs_Reliefs_CostElements_Burden_Labor.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing Select on ChildForm_Reliefs_ReliefsTab...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildForm_Reliefs_ReliefsTab = new SeleniumControl( sDriver, "ChildForm_Reliefs_ReliefsTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PCQMOST_INVTTRN_RELIEF_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PCQMOST_ChildForm_Reliefs_ReliefsTab);
IWebElement mTab = PCQMOST_ChildForm_Reliefs_ReliefsTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Notes").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing VerifyExists on ChildForm_Reliefs_Reliefs_Notes_Notes...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildForm_Reliefs_Reliefs_Notes_Notes = new SeleniumControl( sDriver, "ChildForm_Reliefs_Reliefs_Notes_Notes", "xpath", "//div[translate(@id,'0123456789','')='pr__PCQMOST_INVTTRN_RELIEF_']/ancestor::form[1]/descendant::*[@id='COMMENT_NT']");
				Function.AssertEqual(true,PCQMOST_ChildForm_Reliefs_Reliefs_Notes_Notes.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing Close on ChildForm_ReliefsForm...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildForm_ReliefsForm = new SeleniumControl( sDriver, "ChildForm_ReliefsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCQMOST_RELIEF_HDR_RS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCQMOST_ChildForm_ReliefsForm);
IWebElement formBttn = PCQMOST_ChildForm_ReliefsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Routings");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing Click on ChildForm_RoutingsLink...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildForm_RoutingsLink = new SeleniumControl( sDriver, "ChildForm_RoutingsLink", "ID", "lnk_1006489_PCQMOST_MOHDR_CHLD");
				Function.WaitControlDisplayed(PCQMOST_ChildForm_RoutingsLink);
PCQMOST_ChildForm_RoutingsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing VerifyExists on ChildForm_RoutingsForm...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildForm_RoutingsForm = new SeleniumControl( sDriver, "ChildForm_RoutingsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCQMOST_MOROUTING_']/ancestor::form[1]");
				Function.AssertEqual(true,PCQMOST_ChildForm_RoutingsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing VerifyExist on ChildForm_RoutingsFormTable...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildForm_RoutingsFormTable = new SeleniumControl( sDriver, "ChildForm_RoutingsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PCQMOST_MOROUTING_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PCQMOST_ChildForm_RoutingsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing ClickButton on ChildForm_RoutingsForm...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildForm_RoutingsForm = new SeleniumControl( sDriver, "ChildForm_RoutingsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCQMOST_MOROUTING_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCQMOST_ChildForm_RoutingsForm);
IWebElement formBttn = PCQMOST_ChildForm_RoutingsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PCQMOST_ChildForm_RoutingsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PCQMOST_ChildForm_RoutingsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing VerifyExists on ChildForm_Routings_RoutingNo...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildForm_Routings_RoutingNo = new SeleniumControl( sDriver, "ChildForm_Routings_RoutingNo", "xpath", "//div[translate(@id,'0123456789','')='pr__PCQMOST_MOROUTING_']/ancestor::form[1]/descendant::*[@id='ROUT_NO']");
				Function.AssertEqual(true,PCQMOST_ChildForm_Routings_RoutingNo.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing Close on ChildForm_RoutingsForm...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildForm_RoutingsForm = new SeleniumControl( sDriver, "ChildForm_RoutingsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCQMOST_MOROUTING_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCQMOST_ChildForm_RoutingsForm);
IWebElement formBttn = PCQMOST_ChildForm_RoutingsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Subcontractor Reqs");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing Click on ChildForm_SubcontractorReqsPOsLink...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildForm_SubcontractorReqsPOsLink = new SeleniumControl( sDriver, "ChildForm_SubcontractorReqsPOsLink", "ID", "lnk_4856_PCQMOST_MOHDR_CHLD");
				Function.WaitControlDisplayed(PCQMOST_ChildForm_SubcontractorReqsPOsLink);
PCQMOST_ChildForm_SubcontractorReqsPOsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing VerifyExists on ChildForm_SubcontractorReqsPOsForm...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildForm_SubcontractorReqsPOsForm = new SeleniumControl( sDriver, "ChildForm_SubcontractorReqsPOsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCQMOST_SUBREQ_POS_']/ancestor::form[1]");
				Function.AssertEqual(true,PCQMOST_ChildForm_SubcontractorReqsPOsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing VerifyExist on ChildForm_SubcontractorReqsPOsFormTable...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildForm_SubcontractorReqsPOsFormTable = new SeleniumControl( sDriver, "ChildForm_SubcontractorReqsPOsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PCQMOST_SUBREQ_POS_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PCQMOST_ChildForm_SubcontractorReqsPOsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing ClickButton on ChildForm_SubcontractorReqsPOsForm...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildForm_SubcontractorReqsPOsForm = new SeleniumControl( sDriver, "ChildForm_SubcontractorReqsPOsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCQMOST_SUBREQ_POS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCQMOST_ChildForm_SubcontractorReqsPOsForm);
IWebElement formBttn = PCQMOST_ChildForm_SubcontractorReqsPOsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PCQMOST_ChildForm_SubcontractorReqsPOsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PCQMOST_ChildForm_SubcontractorReqsPOsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing VerifyExists on ChildForm_SubcontractorReqsPOs_Operation_OperationSequence...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildForm_SubcontractorReqsPOs_Operation_OperationSequence = new SeleniumControl( sDriver, "ChildForm_SubcontractorReqsPOs_Operation_OperationSequence", "xpath", "//div[translate(@id,'0123456789','')='pr__PCQMOST_SUBREQ_POS_']/ancestor::form[1]/descendant::*[@id='MO_OPER_SEQ_NO']");
				Function.AssertEqual(true,PCQMOST_ChildForm_SubcontractorReqsPOs_Operation_OperationSequence.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing Close on ChildForm_SubcontractorReqsPOsForm...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildForm_SubcontractorReqsPOsForm = new SeleniumControl( sDriver, "ChildForm_SubcontractorReqsPOsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCQMOST_SUBREQ_POS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCQMOST_ChildForm_SubcontractorReqsPOsForm);
IWebElement formBttn = PCQMOST_ChildForm_SubcontractorReqsPOsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Timesheet");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing Click on ChildForm_TimesheetLink...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildForm_TimesheetLink = new SeleniumControl( sDriver, "ChildForm_TimesheetLink", "ID", "lnk_1006603_PCQMOST_MOHDR_CHLD");
				Function.WaitControlDisplayed(PCQMOST_ChildForm_TimesheetLink);
PCQMOST_ChildForm_TimesheetLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing VerifyExists on ChildForm_TimesheetForm...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildForm_TimesheetForm = new SeleniumControl( sDriver, "ChildForm_TimesheetForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCQMOST_TSLNHIS_TMSHDR_']/ancestor::form[1]");
				Function.AssertEqual(true,PCQMOST_ChildForm_TimesheetForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing VerifyExists on ChildForm_Timesheet_OpenTimeSheetTotal_TotalAmount...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildForm_Timesheet_OpenTimeSheetTotal_TotalAmount = new SeleniumControl( sDriver, "ChildForm_Timesheet_OpenTimeSheetTotal_TotalAmount", "xpath", "//div[translate(@id,'0123456789','')='pr__PCQMOST_TSLNHIS_TMSHDR_']/ancestor::form[1]/descendant::*[@id='TOT_AMT_TIMESHEET']");
				Function.AssertEqual(true,PCQMOST_ChildForm_Timesheet_OpenTimeSheetTotal_TotalAmount.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing VerifyExist on ChildForm_Timesheet_PostedTimeSheetFormTable...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildForm_Timesheet_PostedTimeSheetFormTable = new SeleniumControl( sDriver, "ChildForm_Timesheet_PostedTimeSheetFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PCQMOST_TSLN_TMHISST_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PCQMOST_ChildForm_Timesheet_PostedTimeSheetFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing VerifyExist on ChildForm_Timesheet_OpenTimeSheetDetailsFormTable...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildForm_Timesheet_OpenTimeSheetDetailsFormTable = new SeleniumControl( sDriver, "ChildForm_Timesheet_OpenTimeSheetDetailsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PCQMOST_TSLN_TMSHEET_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PCQMOST_ChildForm_Timesheet_OpenTimeSheetDetailsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing Close on ChildForm_TimesheetForm...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildForm_TimesheetForm = new SeleniumControl( sDriver, "ChildForm_TimesheetForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCQMOST_TSLNHIS_TMSHDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCQMOST_ChildForm_TimesheetForm);
IWebElement formBttn = PCQMOST_ChildForm_TimesheetForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Assy Serial");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing ClickButton on ChildForm...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCQMOST_MOHDR_CHLD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCQMOST_ChildForm);
IWebElement formBttn = PCQMOST_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).Count <= 0 ? PCQMOST_ChildForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Query')]")).FirstOrDefault() :
PCQMOST_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Query not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "Query";
								SeleniumControl ctl = new SeleniumControl(sDriver,"Target", "xpath_display", "//*[@id='basicQTbl']/tbody/tr/td/span[text()='Manufacturing Order ']");
Function.WaitControlDisplayed(ctl);
SeleniumControl RelationshipField = new SeleniumControl(sDriver,"Relationship", ctl.mElement.FindElement(By.XPath("../following-sibling::td[1]")));
SeleniumControl SearchField = new SeleniumControl(sDriver,"Relationship", ctl.mElement.FindElement(By.XPath("../following-sibling::td[2]")));
new SeleniumControl(sDriver, "RelDropdown", RelationshipField.mElement.FindElements(By.XPath("./descendant::*[@class='tCCBImg']")).FirstOrDefault()).Click();
new SeleniumControl(sDriver, "RelItem", "xpath_display", ".//descendant::div[text() = 'begins with']").Click();
if (SearchField.mElement.GetAttribute("class").Equals("tCCB")) {
new SeleniumControl(sDriver, "SearchDropdown", SearchField.mElement.FindElements(By.XPath(".//descendant::*[@class='tCCBImg']")).FirstOrDefault()).Click();
new SeleniumControl(sDriver, "SearchItem", "xpath_display", ".//descendant::div[text()='MO31-00007']").Click();
} else {
                        IWebElement elem = SearchField.mElement.FindElements(By.XPath(".//descendant::*[@class='queryBasicFld']")).FirstOrDefault(); elem.Clear(); elem.Click();
                        new SeleniumControl(sDriver, "SearchDropdown", SearchField.mElement.FindElements(By.XPath(".//descendant::*[@class='queryBasicFld']")).FirstOrDefault()).SendKeys("MO31-00007");}


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
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing Click on ChildForm_AssySerialLotLink...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildForm_AssySerialLotLink = new SeleniumControl( sDriver, "ChildForm_AssySerialLotLink", "ID", "lnk_1006487_PCQMOST_MOHDR_CHLD");
				Function.WaitControlDisplayed(PCQMOST_ChildForm_AssySerialLotLink);
PCQMOST_ChildForm_AssySerialLotLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing VerifyExists on ChildForm_AssySerialLotForm...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildForm_AssySerialLotForm = new SeleniumControl( sDriver, "ChildForm_AssySerialLotForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCQMOST_SERIALLT_']/ancestor::form[1]");
				Function.AssertEqual(true,PCQMOST_ChildForm_AssySerialLotForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing VerifyExist on ChildForm_AssySerialLotFormTable...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildForm_AssySerialLotFormTable = new SeleniumControl( sDriver, "ChildForm_AssySerialLotFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PCQMOST_SERIALLT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PCQMOST_ChildForm_AssySerialLotFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing ClickButton on ChildForm_AssySerialLotForm...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildForm_AssySerialLotForm = new SeleniumControl( sDriver, "ChildForm_AssySerialLotForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCQMOST_SERIALLT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCQMOST_ChildForm_AssySerialLotForm);
IWebElement formBttn = PCQMOST_ChildForm_AssySerialLotForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PCQMOST_ChildForm_AssySerialLotForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PCQMOST_ChildForm_AssySerialLotForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing VerifyExists on ChildForm_AssySerialLot_Serial...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildForm_AssySerialLot_Serial = new SeleniumControl( sDriver, "ChildForm_AssySerialLot_Serial", "xpath", "//div[translate(@id,'0123456789','')='pr__PCQMOST_SERIALLT_']/ancestor::form[1]/descendant::*[@id='SERIAL_ID']");
				Function.AssertEqual(true,PCQMOST_ChildForm_AssySerialLot_Serial.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing Select on ChildForm_AssySerialLotTab...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildForm_AssySerialLotTab = new SeleniumControl( sDriver, "ChildForm_AssySerialLotTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PCQMOST_SERIALLT_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PCQMOST_ChildForm_AssySerialLotTab);
IWebElement mTab = PCQMOST_ChildForm_AssySerialLotTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Shelf Life").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing VerifyExists on ChildForm_AssySerialLot_ShelfLife_ShelfLife_ShelfLifeType...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildForm_AssySerialLot_ShelfLife_ShelfLife_ShelfLifeType = new SeleniumControl( sDriver, "ChildForm_AssySerialLot_ShelfLife_ShelfLife_ShelfLifeType", "xpath", "//div[translate(@id,'0123456789','')='pr__PCQMOST_SERIALLT_']/ancestor::form[1]/descendant::*[@id='S_SHELF_LIFE_TYPE']");
				Function.AssertEqual(true,PCQMOST_ChildForm_AssySerialLot_ShelfLife_ShelfLife_ShelfLifeType.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing Close on ChildForm_AssySerialLotForm...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildForm_AssySerialLotForm = new SeleniumControl( sDriver, "ChildForm_AssySerialLotForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCQMOST_SERIALLT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCQMOST_ChildForm_AssySerialLotForm);
IWebElement formBttn = PCQMOST_ChildForm_AssySerialLotForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Comp Serial Lot");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing ClickButton on ChildForm...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCQMOST_MOHDR_CHLD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCQMOST_ChildForm);
IWebElement formBttn = PCQMOST_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).Count <= 0 ? PCQMOST_ChildForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Query')]")).FirstOrDefault() :
PCQMOST_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Query not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "Query";
								SeleniumControl ctl = new SeleniumControl(sDriver,"Target", "xpath_display", "//*[@id='basicQTbl']/tbody/tr/td/span[text()='Manufacturing Order ']");
Function.WaitControlDisplayed(ctl);
SeleniumControl RelationshipField = new SeleniumControl(sDriver,"Relationship", ctl.mElement.FindElement(By.XPath("../following-sibling::td[1]")));
SeleniumControl SearchField = new SeleniumControl(sDriver,"Relationship", ctl.mElement.FindElement(By.XPath("../following-sibling::td[2]")));
new SeleniumControl(sDriver, "RelDropdown", RelationshipField.mElement.FindElements(By.XPath("./descendant::*[@class='tCCBImg']")).FirstOrDefault()).Click();
new SeleniumControl(sDriver, "RelItem", "xpath_display", ".//descendant::div[text() = 'begins with']").Click();
if (SearchField.mElement.GetAttribute("class").Equals("tCCB")) {
new SeleniumControl(sDriver, "SearchDropdown", SearchField.mElement.FindElements(By.XPath(".//descendant::*[@class='tCCBImg']")).FirstOrDefault()).Click();
new SeleniumControl(sDriver, "SearchItem", "xpath_display", ".//descendant::div[text()='MO31-00059']").Click();
} else {
                        IWebElement elem = SearchField.mElement.FindElements(By.XPath(".//descendant::*[@class='queryBasicFld']")).FirstOrDefault(); elem.Clear(); elem.Click();
                        new SeleniumControl(sDriver, "SearchDropdown", SearchField.mElement.FindElements(By.XPath(".//descendant::*[@class='queryBasicFld']")).FirstOrDefault()).SendKeys("MO31-00059");}


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
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing Click on ChildForm_CompSerialLotLink...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildForm_CompSerialLotLink = new SeleniumControl( sDriver, "ChildForm_CompSerialLotLink", "ID", "lnk_1006488_PCQMOST_MOHDR_CHLD");
				Function.WaitControlDisplayed(PCQMOST_ChildForm_CompSerialLotLink);
PCQMOST_ChildForm_CompSerialLotLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing VerifyExists on ChildForm_CompSerialLotForm...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildForm_CompSerialLotForm = new SeleniumControl( sDriver, "ChildForm_CompSerialLotForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCQMOST_INVTTRNLNSRLT_']/ancestor::form[1]");
				Function.AssertEqual(true,PCQMOST_ChildForm_CompSerialLotForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing VerifyExist on ChildForm_CompSerialLotFormTable...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildForm_CompSerialLotFormTable = new SeleniumControl( sDriver, "ChildForm_CompSerialLotFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PCQMOST_INVTTRNLNSRLT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PCQMOST_ChildForm_CompSerialLotFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing ClickButton on ChildForm_CompSerialLotForm...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildForm_CompSerialLotForm = new SeleniumControl( sDriver, "ChildForm_CompSerialLotForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCQMOST_INVTTRNLNSRLT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCQMOST_ChildForm_CompSerialLotForm);
IWebElement formBttn = PCQMOST_ChildForm_CompSerialLotForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PCQMOST_ChildForm_CompSerialLotForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PCQMOST_ChildForm_CompSerialLotForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing VerifyExists on ChildForm_CompSerialLot_Part...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildForm_CompSerialLot_Part = new SeleniumControl( sDriver, "ChildForm_CompSerialLot_Part", "xpath", "//div[translate(@id,'0123456789','')='pr__PCQMOST_INVTTRNLNSRLT_']/ancestor::form[1]/descendant::*[@id='PART_ID']");
				Function.AssertEqual(true,PCQMOST_ChildForm_CompSerialLot_Part.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing VerifyExists on ChildForm_CompSerialLot_SerialLot_Serial...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildForm_CompSerialLot_SerialLot_Serial = new SeleniumControl( sDriver, "ChildForm_CompSerialLot_SerialLot_Serial", "xpath", "//div[translate(@id,'0123456789','')='pr__PCQMOST_INVTTRNLNSRLT_']/ancestor::form[1]/descendant::*[@id='SERIAL_ID']");
				Function.AssertEqual(true,PCQMOST_ChildForm_CompSerialLot_SerialLot_Serial.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing Select on ChildForm_CompSerialLotTab...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildForm_CompSerialLotTab = new SeleniumControl( sDriver, "ChildForm_CompSerialLotTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PCQMOST_INVTTRNLNSRLT_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PCQMOST_ChildForm_CompSerialLotTab);
IWebElement mTab = PCQMOST_ChildForm_CompSerialLotTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Manuf/Vendor").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing VerifyExists on ChildForm_CompSerialLot_ManufVendor_ManufacturerVendor_Manufacturer...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildForm_CompSerialLot_ManufVendor_ManufacturerVendor_Manufacturer = new SeleniumControl( sDriver, "ChildForm_CompSerialLot_ManufVendor_ManufacturerVendor_Manufacturer", "xpath", "//div[translate(@id,'0123456789','')='pr__PCQMOST_INVTTRNLNSRLT_']/ancestor::form[1]/descendant::*[@id='MANUF_ID']");
				Function.AssertEqual(true,PCQMOST_ChildForm_CompSerialLot_ManufVendor_ManufacturerVendor_Manufacturer.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing Select on ChildForm_CompSerialLotTab...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildForm_CompSerialLotTab = new SeleniumControl( sDriver, "ChildForm_CompSerialLotTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PCQMOST_INVTTRNLNSRLT_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PCQMOST_ChildForm_CompSerialLotTab);
IWebElement mTab = PCQMOST_ChildForm_CompSerialLotTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "User-Defined Info").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing VerifyExists on ChildForm_CompSerialLot_UserDefinedInfo_UserDefinedInformation_TEST1...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildForm_CompSerialLot_UserDefinedInfo_UserDefinedInformation_TEST1 = new SeleniumControl( sDriver, "ChildForm_CompSerialLot_UserDefinedInfo_UserDefinedInformation_TEST1", "xpath", "//div[translate(@id,'0123456789','')='pr__PCQMOST_INVTTRNLNSRLT_']/ancestor::form[1]/descendant::*[@id='UDEF_DESC_1']");
				Function.AssertEqual(true,PCQMOST_ChildForm_CompSerialLot_UserDefinedInfo_UserDefinedInformation_TEST1.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing Select on ChildForm_CompSerialLotTab...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildForm_CompSerialLotTab = new SeleniumControl( sDriver, "ChildForm_CompSerialLotTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PCQMOST_INVTTRNLNSRLT_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PCQMOST_ChildForm_CompSerialLotTab);
IWebElement mTab = PCQMOST_ChildForm_CompSerialLotTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "UID").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing VerifyExists on ChildForm_CompSerialLot_UID_UIDDetails_UID...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildForm_CompSerialLot_UID_UIDDetails_UID = new SeleniumControl( sDriver, "ChildForm_CompSerialLot_UID_UIDDetails_UID", "xpath", "//div[translate(@id,'0123456789','')='pr__PCQMOST_INVTTRNLNSRLT_']/ancestor::form[1]/descendant::*[@id='UID_CD']");
				Function.AssertEqual(true,PCQMOST_ChildForm_CompSerialLot_UID_UIDDetails_UID.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing Select on ChildForm_CompSerialLotTab...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildForm_CompSerialLotTab = new SeleniumControl( sDriver, "ChildForm_CompSerialLotTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PCQMOST_INVTTRNLNSRLT_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PCQMOST_ChildForm_CompSerialLotTab);
IWebElement mTab = PCQMOST_ChildForm_CompSerialLotTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Shelf Life").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing VerifyExists on ChildForm_CompSerialLot_SerialLot_ShelfLifeExpDate...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildForm_CompSerialLot_SerialLot_ShelfLifeExpDate = new SeleniumControl( sDriver, "ChildForm_CompSerialLot_SerialLot_ShelfLifeExpDate", "xpath", "//div[translate(@id,'0123456789','')='pr__PCQMOST_INVTTRNLNSRLT_']/ancestor::form[1]/descendant::*[@id='SHELF_LIFE_EXP_DT']");
				Function.AssertEqual(true,PCQMOST_ChildForm_CompSerialLot_SerialLot_ShelfLifeExpDate.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing Close on ChildForm_CompSerialLotForm...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildForm_CompSerialLotForm = new SeleniumControl( sDriver, "ChildForm_CompSerialLotForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCQMOST_INVTTRNLNSRLT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCQMOST_ChildForm_CompSerialLotForm);
IWebElement formBttn = PCQMOST_ChildForm_CompSerialLotForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Assy Part Demand");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing Click on ChildForm_AssyPartDemandLink...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildForm_AssyPartDemandLink = new SeleniumControl( sDriver, "ChildForm_AssyPartDemandLink", "ID", "lnk_4649_PCQMOST_MOHDR_CHLD");
				Function.WaitControlDisplayed(PCQMOST_ChildForm_AssyPartDemandLink);
PCQMOST_ChildForm_AssyPartDemandLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing VerifyExists on ChildForm_AssyPartDemandForm...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildForm_AssyPartDemandForm = new SeleniumControl( sDriver, "ChildForm_AssyPartDemandForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCQMOST_ASSYPART_DEMAND_']/ancestor::form[1]");
				Function.AssertEqual(true,PCQMOST_ChildForm_AssyPartDemandForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing VerifyExist on ChildForm_AssyPartDemandFormTable...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildForm_AssyPartDemandFormTable = new SeleniumControl( sDriver, "ChildForm_AssyPartDemandFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PCQMOST_ASSYPART_DEMAND_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PCQMOST_ChildForm_AssyPartDemandFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing ClickButton on ChildForm_AssyPartDemandForm...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildForm_AssyPartDemandForm = new SeleniumControl( sDriver, "ChildForm_AssyPartDemandForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCQMOST_ASSYPART_DEMAND_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCQMOST_ChildForm_AssyPartDemandForm);
IWebElement formBttn = PCQMOST_ChildForm_AssyPartDemandForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PCQMOST_ChildForm_AssyPartDemandForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PCQMOST_ChildForm_AssyPartDemandForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing VerifyExists on ChildForm_AssyPartDemand_NeedDate...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildForm_AssyPartDemand_NeedDate = new SeleniumControl( sDriver, "ChildForm_AssyPartDemand_NeedDate", "xpath", "//div[translate(@id,'0123456789','')='pr__PCQMOST_ASSYPART_DEMAND_']/ancestor::form[1]/descendant::*[@id='NEED_DT']");
				Function.AssertEqual(true,PCQMOST_ChildForm_AssyPartDemand_NeedDate.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing Close on ChildForm_AssyPartDemandForm...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildForm_AssyPartDemandForm = new SeleniumControl( sDriver, "ChildForm_AssyPartDemandForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCQMOST_ASSYPART_DEMAND_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCQMOST_ChildForm_AssyPartDemandForm);
IWebElement formBttn = PCQMOST_ChildForm_AssyPartDemandForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Documents");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing Click on ChildForm_DocumentsLink...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildForm_DocumentsLink = new SeleniumControl( sDriver, "ChildForm_DocumentsLink", "ID", "lnk_4650_PCQMOST_MOHDR_CHLD");
				Function.WaitControlDisplayed(PCQMOST_ChildForm_DocumentsLink);
PCQMOST_ChildForm_DocumentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing VerifyExists on ChildForm_DocumentsForm...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildForm_DocumentsForm = new SeleniumControl( sDriver, "ChildForm_DocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCQMOST_DOCUMENT_']/ancestor::form[1]");
				Function.AssertEqual(true,PCQMOST_ChildForm_DocumentsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing VerifyExist on ChildForm_DocumentsFormTable...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildForm_DocumentsFormTable = new SeleniumControl( sDriver, "ChildForm_DocumentsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PCQMOST_DOCUMENT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PCQMOST_ChildForm_DocumentsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing ClickButton on ChildForm_DocumentsForm...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildForm_DocumentsForm = new SeleniumControl( sDriver, "ChildForm_DocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCQMOST_DOCUMENT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCQMOST_ChildForm_DocumentsForm);
IWebElement formBttn = PCQMOST_ChildForm_DocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PCQMOST_ChildForm_DocumentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PCQMOST_ChildForm_DocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing VerifyExists on ChildForm_Documents_Type...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildForm_Documents_Type = new SeleniumControl( sDriver, "ChildForm_Documents_Type", "xpath", "//div[translate(@id,'0123456789','')='pr__PCQMOST_DOCUMENT_']/ancestor::form[1]/descendant::*[@id='DOC_TYP_CD']");
				Function.AssertEqual(true,PCQMOST_ChildForm_Documents_Type.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing Close on ChildForm_DocumentsForm...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildForm_DocumentsForm = new SeleniumControl( sDriver, "ChildForm_DocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCQMOST_DOCUMENT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCQMOST_ChildForm_DocumentsForm);
IWebElement formBttn = PCQMOST_ChildForm_DocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Costs");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing Click on ChildForm_CostsLink...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildForm_CostsLink = new SeleniumControl( sDriver, "ChildForm_CostsLink", "ID", "lnk_4837_PCQMOST_MOHDR_CHLD");
				Function.WaitControlDisplayed(PCQMOST_ChildForm_CostsLink);
PCQMOST_ChildForm_CostsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing ClickButton on ChildForm_CostsForm...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildForm_CostsForm = new SeleniumControl( sDriver, "ChildForm_CostsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCQMOST_COSTS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCQMOST_ChildForm_CostsForm);
IWebElement formBttn = PCQMOST_ChildForm_CostsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PCQMOST_ChildForm_CostsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PCQMOST_ChildForm_CostsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing VerifyExists on ChildForm_CostsForm...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildForm_CostsForm = new SeleniumControl( sDriver, "ChildForm_CostsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCQMOST_COSTS_']/ancestor::form[1]");
				Function.AssertEqual(true,PCQMOST_ChildForm_CostsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing VerifyExists on ChildForm_Costs_UnitCost...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildForm_Costs_UnitCost = new SeleniumControl( sDriver, "ChildForm_Costs_UnitCost", "xpath", "//div[translate(@id,'0123456789','')='pr__PCQMOST_COSTS_']/ancestor::form[1]/descendant::*[@id='UNIT_CST']");
				Function.AssertEqual(true,PCQMOST_ChildForm_Costs_UnitCost.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing Close on ChildForm_CostsForm...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_ChildForm_CostsForm = new SeleniumControl( sDriver, "ChildForm_CostsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCQMOST_COSTS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCQMOST_ChildForm_CostsForm);
IWebElement formBttn = PCQMOST_ChildForm_CostsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "PCQMOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCQMOST] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl PCQMOST_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PCQMOST_MainForm);
IWebElement formBttn = PCQMOST_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

