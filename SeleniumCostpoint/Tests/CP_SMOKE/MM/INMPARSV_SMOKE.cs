 
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
    public class INMPARSV_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Manage Inventory Reservations", "xpath","//div[@class='navItem'][.='Manage Inventory Reservations']").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SelectMenu]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPARSV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPARSV] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl INMPARSV_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,INMPARSV_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPARSV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPARSV] Performing VerifyExists on Identification_Warehouse...", Logger.MessageType.INF);
				SeleniumControl INMPARSV_Identification_Warehouse = new SeleniumControl( sDriver, "Identification_Warehouse", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='WHSE_ID_FR']");
				Function.AssertEqual(true,INMPARSV_Identification_Warehouse.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPARSV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPARSV] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl INMPARSV_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(INMPARSV_MainForm);
IWebElement formBttn = INMPARSV_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? INMPARSV_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
INMPARSV_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPARSV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPARSV] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl INMPARSV_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,INMPARSV_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPARSV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPARSV] Performing VerifyExist on ChildFormTable...", Logger.MessageType.INF);
				SeleniumControl INMPARSV_ChildFormTable = new SeleniumControl( sDriver, "ChildFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__INM_RESLN_DTL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,INMPARSV_ChildFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPARSV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPARSV] Performing ClickButton on ChildForm...", Logger.MessageType.INF);
				SeleniumControl INMPARSV_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__INM_RESLN_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(INMPARSV_ChildForm);
IWebElement formBttn = INMPARSV_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? INMPARSV_ChildForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
INMPARSV_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPARSV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPARSV] Performing VerifyExists on ChildForm...", Logger.MessageType.INF);
				SeleniumControl INMPARSV_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__INM_RESLN_DTL_']/ancestor::form[1]");
				Function.AssertEqual(true,INMPARSV_ChildForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("ONHAND LOCATIONS");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPARSV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPARSV] Performing Click on ChildForm_OnHandLocationsLink...", Logger.MessageType.INF);
				SeleniumControl INMPARSV_ChildForm_OnHandLocationsLink = new SeleniumControl( sDriver, "ChildForm_OnHandLocationsLink", "ID", "lnk_1007968_INM_RESLN_DTL");
				Function.WaitControlDisplayed(INMPARSV_ChildForm_OnHandLocationsLink);
INMPARSV_ChildForm_OnHandLocationsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPARSV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPARSV] Performing VerifyExist on OnHandLocations_Table...", Logger.MessageType.INF);
				SeleniumControl INMPARSV_OnHandLocations_Table = new SeleniumControl( sDriver, "OnHandLocations_Table", "xpath", "//div[translate(@id,'0123456789','')='pr__INM_INVTWHSELOC_ONHAND_QTY_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,INMPARSV_OnHandLocations_Table.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPARSV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPARSV] Performing Close on OnHandLocationForm...", Logger.MessageType.INF);
				SeleniumControl INMPARSV_OnHandLocationForm = new SeleniumControl( sDriver, "OnHandLocationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__INM_INVTWHSELOC_ONHAND_QTY_']/ancestor::form[1]");
				Function.WaitControlDisplayed(INMPARSV_OnHandLocationForm);
IWebElement formBttn = INMPARSV_OnHandLocationForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("SUBSTITUTEPARTS");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPARSV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPARSV] Performing Click on ChildForm_SubstitutePartsLink...", Logger.MessageType.INF);
				SeleniumControl INMPARSV_ChildForm_SubstitutePartsLink = new SeleniumControl( sDriver, "ChildForm_SubstitutePartsLink", "ID", "lnk_16581_INM_RESLN_DTL");
				Function.WaitControlDisplayed(INMPARSV_ChildForm_SubstitutePartsLink);
INMPARSV_ChildForm_SubstitutePartsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPARSV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPARSV] Performing VerifyExist on SubtitutePartsFormTable...", Logger.MessageType.INF);
				SeleniumControl INMPARSV_SubtitutePartsFormTable = new SeleniumControl( sDriver, "SubtitutePartsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSUBSTPART_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,INMPARSV_SubtitutePartsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPARSV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPARSV] Performing ClickButton on SubtitutePartsForm...", Logger.MessageType.INF);
				SeleniumControl INMPARSV_SubtitutePartsForm = new SeleniumControl( sDriver, "SubtitutePartsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSUBSTPART_']/ancestor::form[1]");
				Function.WaitControlDisplayed(INMPARSV_SubtitutePartsForm);
IWebElement formBttn = INMPARSV_SubtitutePartsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? INMPARSV_SubtitutePartsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
INMPARSV_SubtitutePartsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPARSV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPARSV] Performing VerifyExists on SubtitutePartsForm...", Logger.MessageType.INF);
				SeleniumControl INMPARSV_SubtitutePartsForm = new SeleniumControl( sDriver, "SubtitutePartsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSUBSTPART_']/ancestor::form[1]");
				Function.AssertEqual(true,INMPARSV_SubtitutePartsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPARSV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPARSV] Performing VerifyExists on SubstituteParts_SubstitutePart...", Logger.MessageType.INF);
				SeleniumControl INMPARSV_SubstituteParts_SubstitutePart = new SeleniumControl( sDriver, "SubstituteParts_SubstitutePart", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSUBSTPART_']/ancestor::form[1]/descendant::*[@id='SUBST_PART_ID']");
				Function.AssertEqual(true,INMPARSV_SubstituteParts_SubstitutePart.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPARSV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPARSV] Performing Close on SubtitutePartsForm...", Logger.MessageType.INF);
				SeleniumControl INMPARSV_SubtitutePartsForm = new SeleniumControl( sDriver, "SubtitutePartsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSUBSTPART_']/ancestor::form[1]");
				Function.WaitControlDisplayed(INMPARSV_SubtitutePartsForm);
IWebElement formBttn = INMPARSV_SubtitutePartsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPARSV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPARSV] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl INMPARSV_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(INMPARSV_MainForm);
IWebElement formBttn = INMPARSV_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

