 
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
    public class RUMSUBOP_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Routings", "xpath","//div[@class='deptItem'][.='Routings']").Click();
new SeleniumControl(sDriver,"Operations", "xpath","//div[@class='navItem'][.='Operations']").Click();
new SeleniumControl(sDriver,"Manage Subcontractor Operations", "xpath","//div[@class='navItem'][.='Manage Subcontractor Operations']").Click();


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
				Function.CurrentComponent = "RUMSUBOP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMSUBOP] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl RUMSUBOP_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,RUMSUBOP_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMSUBOP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMSUBOP] Performing VerifyExists on Name...", Logger.MessageType.INF);
				SeleniumControl RUMSUBOP_Name = new SeleniumControl( sDriver, "Name", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='OP_DESC']");
				Function.AssertEqual(true,RUMSUBOP_Name.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMSUBOP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMSUBOP] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl RUMSUBOP_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(RUMSUBOP_MainForm);
IWebElement formBttn = RUMSUBOP_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? RUMSUBOP_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
RUMSUBOP_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMSUBOP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMSUBOP] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl RUMSUBOP_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,RUMSUBOP_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Vendors");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMSUBOP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMSUBOP] Performing Click on VendorsLink...", Logger.MessageType.INF);
				SeleniumControl RUMSUBOP_VendorsLink = new SeleniumControl( sDriver, "VendorsLink", "ID", "lnk_1001339_RUMSUBOP_OPERATION");
				Function.WaitControlDisplayed(RUMSUBOP_VendorsLink);
RUMSUBOP_VendorsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMSUBOP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMSUBOP] Performing VerifyExist on VendorFormTable...", Logger.MessageType.INF);
				SeleniumControl RUMSUBOP_VendorFormTable = new SeleniumControl( sDriver, "VendorFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMSUBOP_VEND_CHD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,RUMSUBOP_VendorFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMSUBOP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMSUBOP] Performing VerifyExists on VendorForm...", Logger.MessageType.INF);
				SeleniumControl RUMSUBOP_VendorForm = new SeleniumControl( sDriver, "VendorForm", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMSUBOP_VEND_CHD_']/ancestor::form[1]");
				Function.AssertEqual(true,RUMSUBOP_VendorForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMSUBOP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMSUBOP] Performing ClickButton on VendorForm...", Logger.MessageType.INF);
				SeleniumControl RUMSUBOP_VendorForm = new SeleniumControl( sDriver, "VendorForm", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMSUBOP_VEND_CHD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(RUMSUBOP_VendorForm);
IWebElement formBttn = RUMSUBOP_VendorForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? RUMSUBOP_VendorForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
RUMSUBOP_VendorForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMSUBOP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMSUBOP] Performing VerifyExists on Vendor_Location...", Logger.MessageType.INF);
				SeleniumControl RUMSUBOP_Vendor_Location = new SeleniumControl( sDriver, "Vendor_Location", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMSUBOP_VEND_CHD_']/ancestor::form[1]/descendant::*[@id='VEND_NAME_EXT']");
				Function.AssertEqual(true,RUMSUBOP_Vendor_Location.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMSUBOP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMSUBOP] Performing Close on VendorForm...", Logger.MessageType.INF);
				SeleniumControl RUMSUBOP_VendorForm = new SeleniumControl( sDriver, "VendorForm", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMSUBOP_VEND_CHD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(RUMSUBOP_VendorForm);
IWebElement formBttn = RUMSUBOP_VendorForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("NOTES");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMSUBOP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMSUBOP] Performing Click on NotesLink...", Logger.MessageType.INF);
				SeleniumControl RUMSUBOP_NotesLink = new SeleniumControl( sDriver, "NotesLink", "ID", "lnk_1001342_RUMSUBOP_OPERATION");
				Function.WaitControlDisplayed(RUMSUBOP_NotesLink);
RUMSUBOP_NotesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMSUBOP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMSUBOP] Performing VerifyExists on Notes_RequisitionPONoteOptions_DoNotLoadRequisitionLineNotes...", Logger.MessageType.INF);
				SeleniumControl RUMSUBOP_Notes_RequisitionPONoteOptions_DoNotLoadRequisitionLineNotes = new SeleniumControl( sDriver, "Notes_RequisitionPONoteOptions_DoNotLoadRequisitionLineNotes", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMSUBOP_OPERATIONNOTES_SUB_']/ancestor::form[1]/descendant::*[@id='S_NOTES_LOAD_CD' and @value='N']");
				Function.AssertEqual(true,RUMSUBOP_Notes_RequisitionPONoteOptions_DoNotLoadRequisitionLineNotes.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMSUBOP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMSUBOP] Performing VerifyExists on NotesForm...", Logger.MessageType.INF);
				SeleniumControl RUMSUBOP_NotesForm = new SeleniumControl( sDriver, "NotesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMSUBOP_OPERATIONNOTES_SUB_']/ancestor::form[1]");
				Function.AssertEqual(true,RUMSUBOP_NotesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMSUBOP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMSUBOP] Performing Close on NotesForm...", Logger.MessageType.INF);
				SeleniumControl RUMSUBOP_NotesForm = new SeleniumControl( sDriver, "NotesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMSUBOP_OPERATIONNOTES_SUB_']/ancestor::form[1]");
				Function.WaitControlDisplayed(RUMSUBOP_NotesForm);
IWebElement formBttn = RUMSUBOP_NotesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "RUMSUBOP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMSUBOP] Performing Click on TextLink...", Logger.MessageType.INF);
				SeleniumControl RUMSUBOP_TextLink = new SeleniumControl( sDriver, "TextLink", "ID", "lnk_1001343_RUMSUBOP_OPERATION");
				Function.WaitControlDisplayed(RUMSUBOP_TextLink);
RUMSUBOP_TextLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMSUBOP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMSUBOP] Performing VerifyExists on StandardTextForm...", Logger.MessageType.INF);
				SeleniumControl RUMSUBOP_StandardTextForm = new SeleniumControl( sDriver, "StandardTextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMSUBOP_OPERATIONTEXT_SUB_']/ancestor::form[1]");
				Function.AssertEqual(true,RUMSUBOP_StandardTextForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMSUBOP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMSUBOP] Performing VerifyExist on StandardTextFormTable...", Logger.MessageType.INF);
				SeleniumControl RUMSUBOP_StandardTextFormTable = new SeleniumControl( sDriver, "StandardTextFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMSUBOP_OPERATIONTEXT_SUB_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,RUMSUBOP_StandardTextFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMSUBOP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMSUBOP] Performing ClickButton on StandardTextForm...", Logger.MessageType.INF);
				SeleniumControl RUMSUBOP_StandardTextForm = new SeleniumControl( sDriver, "StandardTextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMSUBOP_OPERATIONTEXT_SUB_']/ancestor::form[1]");
				Function.WaitControlDisplayed(RUMSUBOP_StandardTextForm);
IWebElement formBttn = RUMSUBOP_StandardTextForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? RUMSUBOP_StandardTextForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
RUMSUBOP_StandardTextForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMSUBOP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMSUBOP] Performing VerifyExists on StandardText_Sequence...", Logger.MessageType.INF);
				SeleniumControl RUMSUBOP_StandardText_Sequence = new SeleniumControl( sDriver, "StandardText_Sequence", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMSUBOP_OPERATIONTEXT_SUB_']/ancestor::form[1]/descendant::*[@id='SEQ_NO']");
				Function.AssertEqual(true,RUMSUBOP_StandardText_Sequence.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMSUBOP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMSUBOP] Performing Close on StandardTextForm...", Logger.MessageType.INF);
				SeleniumControl RUMSUBOP_StandardTextForm = new SeleniumControl( sDriver, "StandardTextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMSUBOP_OPERATIONTEXT_SUB_']/ancestor::form[1]");
				Function.WaitControlDisplayed(RUMSUBOP_StandardTextForm);
IWebElement formBttn = RUMSUBOP_StandardTextForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("cost");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMSUBOP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMSUBOP] Performing Click on CostLink...", Logger.MessageType.INF);
				SeleniumControl RUMSUBOP_CostLink = new SeleniumControl( sDriver, "CostLink", "ID", "lnk_1001344_RUMSUBOP_OPERATION");
				Function.WaitControlDisplayed(RUMSUBOP_CostLink);
RUMSUBOP_CostLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMSUBOP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMSUBOP] Performing VerifyExists on CostDetails_StandardUnitCost...", Logger.MessageType.INF);
				SeleniumControl RUMSUBOP_CostDetails_StandardUnitCost = new SeleniumControl( sDriver, "CostDetails_StandardUnitCost", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMSUBOP_COST_HDR_']/ancestor::form[1]/descendant::*[@id='ITEM_STD_CST']");
				Function.AssertEqual(true,RUMSUBOP_CostDetails_StandardUnitCost.Exists());

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
				Function.CurrentComponent = "RUMSUBOP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMSUBOP] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl RUMSUBOP_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(RUMSUBOP_MainForm);
IWebElement formBttn = RUMSUBOP_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

