 
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
    public class INMPORSV_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Inventory", "xpath","//div[@class='deptItem'][.='Inventory']").Click();
new SeleniumControl(sDriver,"Reservations", "xpath","//div[@class='navItem'][.='Reservations']").Click();
new SeleniumControl(sDriver,"Manage PO/Req Inventory Reservations", "xpath","//div[@class='navItem'][.='Manage PO/Req Inventory Reservations']").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SelectMenu]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPORSV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPORSV] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl INMPORSV_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,INMPORSV_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPORSV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPORSV] Performing VerifyExists on Identification_WAREHOUSEM...", Logger.MessageType.INF);
				SeleniumControl INMPORSV_Identification_WAREHOUSEM = new SeleniumControl( sDriver, "Identification_WAREHOUSEM", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='WHSE_ID_FR']");
				Function.AssertEqual(true,INMPORSV_Identification_WAREHOUSEM.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPORSV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPORSV] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl INMPORSV_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(INMPORSV_MainForm);
IWebElement formBttn = INMPORSV_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? INMPORSV_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
INMPORSV_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPORSV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPORSV] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl INMPORSV_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,INMPORSV_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPORSV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPORSV] Performing VerifyExist on ChildTable...", Logger.MessageType.INF);
				SeleniumControl INMPORSV_ChildTable = new SeleniumControl( sDriver, "ChildTable", "xpath", "//div[translate(@id,'0123456789','')='pr__INMPORSV_RESLN_DTL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,INMPORSV_ChildTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPORSV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPORSV] Performing ClickButton on ChildForm...", Logger.MessageType.INF);
				SeleniumControl INMPORSV_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__INMPORSV_RESLN_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(INMPORSV_ChildForm);
IWebElement formBttn = INMPORSV_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? INMPORSV_ChildForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
INMPORSV_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPORSV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPORSV] Performing VerifyExists on ChildForm...", Logger.MessageType.INF);
				SeleniumControl INMPORSV_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__INMPORSV_RESLN_DTL_']/ancestor::form[1]");
				Function.AssertEqual(true,INMPORSV_ChildForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPORSV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPORSV] Performing VerifyExists on ChildForm_Line...", Logger.MessageType.INF);
				SeleniumControl INMPORSV_ChildForm_Line = new SeleniumControl( sDriver, "ChildForm_Line", "xpath", "//div[translate(@id,'0123456789','')='pr__INMPORSV_RESLN_DTL_']/ancestor::form[1]/descendant::*[@id='RES_LN_NO']");
				Function.AssertEqual(true,INMPORSV_ChildForm_Line.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("SUBSTITUTE PARTS");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPORSV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPORSV] Performing Click on ChildForm_SubstitutePartsLink...", Logger.MessageType.INF);
				SeleniumControl INMPORSV_ChildForm_SubstitutePartsLink = new SeleniumControl( sDriver, "ChildForm_SubstitutePartsLink", "ID", "lnk_16651_INMPORSV_RESLN_DTL");
				Function.WaitControlDisplayed(INMPORSV_ChildForm_SubstitutePartsLink);
INMPORSV_ChildForm_SubstitutePartsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPORSV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPORSV] Performing VerifyExist on SubstitutePartsTable...", Logger.MessageType.INF);
				SeleniumControl INMPORSV_SubstitutePartsTable = new SeleniumControl( sDriver, "SubstitutePartsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSUBSTPART_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,INMPORSV_SubstitutePartsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPORSV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPORSV] Performing ClickButton on SubstitutePartsForm...", Logger.MessageType.INF);
				SeleniumControl INMPORSV_SubstitutePartsForm = new SeleniumControl( sDriver, "SubstitutePartsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSUBSTPART_']/ancestor::form[1]");
				Function.WaitControlDisplayed(INMPORSV_SubstitutePartsForm);
IWebElement formBttn = INMPORSV_SubstitutePartsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? INMPORSV_SubstitutePartsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
INMPORSV_SubstitutePartsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPORSV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPORSV] Performing VerifyExists on SubstitutePartsForm...", Logger.MessageType.INF);
				SeleniumControl INMPORSV_SubstitutePartsForm = new SeleniumControl( sDriver, "SubstitutePartsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSUBSTPART_']/ancestor::form[1]");
				Function.AssertEqual(true,INMPORSV_SubstitutePartsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPORSV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPORSV] Performing VerifyExists on SubstituteParts_SubstitutePart...", Logger.MessageType.INF);
				SeleniumControl INMPORSV_SubstituteParts_SubstitutePart = new SeleniumControl( sDriver, "SubstituteParts_SubstitutePart", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSUBSTPART_']/ancestor::form[1]/descendant::*[@id='SUBST_PART_ID']");
				Function.AssertEqual(true,INMPORSV_SubstituteParts_SubstitutePart.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPORSV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPORSV] Performing Close on SubstitutePartsForm...", Logger.MessageType.INF);
				SeleniumControl INMPORSV_SubstitutePartsForm = new SeleniumControl( sDriver, "SubstitutePartsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSUBSTPART_']/ancestor::form[1]");
				Function.WaitControlDisplayed(INMPORSV_SubstitutePartsForm);
IWebElement formBttn = INMPORSV_SubstitutePartsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPORSV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPORSV] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl INMPORSV_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(INMPORSV_MainForm);
IWebElement formBttn = INMPORSV_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

