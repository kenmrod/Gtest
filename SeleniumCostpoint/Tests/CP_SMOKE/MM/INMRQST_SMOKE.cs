 
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
    public class INMRQST_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Manage Inventory Requests", "xpath","//div[@class='navItem'][.='Manage Inventory Requests']").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SelectMenu]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Query");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMRQST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMRQST] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl INMRQST_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(INMRQST_MainForm);
IWebElement formBttn = INMRQST_MainForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).Count <= 0 ? INMRQST_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Query')]")).FirstOrDefault() :
INMRQST_MainForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).FirstOrDefault();
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
				this.ScriptLogger.WriteLine("MainForm");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMRQST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMRQST] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl INMRQST_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,INMRQST_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMRQST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMRQST] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl INMRQST_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,INMRQST_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMRQST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMRQST] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl INMRQST_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(INMRQST_MainForm);
IWebElement formBttn = INMRQST_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? INMRQST_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
INMRQST_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMRQST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMRQST] Performing VerifyExists on Identification_Warehouse...", Logger.MessageType.INF);
				SeleniumControl INMRQST_Identification_Warehouse = new SeleniumControl( sDriver, "Identification_Warehouse", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='WHSE_ID_FR']");
				Function.AssertEqual(true,INMRQST_Identification_Warehouse.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("ChildForm");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMRQST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMRQST] Performing VerifyExist on ChildFormTable...", Logger.MessageType.INF);
				SeleniumControl INMRQST_ChildFormTable = new SeleniumControl( sDriver, "ChildFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__INM_RESLN_DTL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,INMRQST_ChildFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMRQST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMRQST] Performing VerifyExists on ChildForm...", Logger.MessageType.INF);
				SeleniumControl INMRQST_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__INM_RESLN_DTL_']/ancestor::form[1]");
				Function.AssertEqual(true,INMRQST_ChildForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMRQST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMRQST] Performing ClickButton on ChildForm...", Logger.MessageType.INF);
				SeleniumControl INMRQST_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__INM_RESLN_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(INMRQST_ChildForm);
IWebElement formBttn = INMRQST_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? INMRQST_ChildForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
INMRQST_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMRQST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMRQST] Performing VerifyExists on ChildForm_Line...", Logger.MessageType.INF);
				SeleniumControl INMRQST_ChildForm_Line = new SeleniumControl( sDriver, "ChildForm_Line", "xpath", "//div[translate(@id,'0123456789','')='pr__INM_RESLN_DTL_']/ancestor::form[1]/descendant::*[@id='RES_LN_NO']");
				Function.AssertEqual(true,INMRQST_ChildForm_Line.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("ChildFormTab");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMRQST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMRQST] Performing Select on ChildForm_Tab...", Logger.MessageType.INF);
				SeleniumControl INMRQST_ChildForm_Tab = new SeleniumControl( sDriver, "ChildForm_Tab", "xpath", "//div[translate(@id,'0123456789','')='pr__INM_RESLN_DTL_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(INMRQST_ChildForm_Tab);
IWebElement mTab = INMRQST_ChildForm_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Line Details").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMRQST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMRQST] Performing VerifyExists on ChildForm_LineDetails_Reservation_FromInvAbbrev...", Logger.MessageType.INF);
				SeleniumControl INMRQST_ChildForm_LineDetails_Reservation_FromInvAbbrev = new SeleniumControl( sDriver, "ChildForm_LineDetails_Reservation_FromInvAbbrev", "xpath", "//div[translate(@id,'0123456789','')='pr__INM_RESLN_DTL_']/ancestor::form[1]/descendant::*[@id='INVT_ABBRV_CD_FR']");
				Function.AssertEqual(true,INMRQST_ChildForm_LineDetails_Reservation_FromInvAbbrev.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMRQST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMRQST] Performing Select on ChildForm_Tab...", Logger.MessageType.INF);
				SeleniumControl INMRQST_ChildForm_Tab = new SeleniumControl( sDriver, "ChildForm_Tab", "xpath", "//div[translate(@id,'0123456789','')='pr__INM_RESLN_DTL_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(INMRQST_ChildForm_Tab);
IWebElement mTab = INMRQST_ChildForm_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Other Info").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMRQST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMRQST] Performing VerifyExists on ChildForm_OtherInfo_OtherInfo_UnitCost...", Logger.MessageType.INF);
				SeleniumControl INMRQST_ChildForm_OtherInfo_OtherInfo_UnitCost = new SeleniumControl( sDriver, "ChildForm_OtherInfo_OtherInfo_UnitCost", "xpath", "//div[translate(@id,'0123456789','')='pr__INM_RESLN_DTL_']/ancestor::form[1]/descendant::*[@id='UNIT_CST_AMT']");
				Function.AssertEqual(true,INMRQST_ChildForm_OtherInfo_OtherInfo_UnitCost.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("On Hand Locations");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMRQST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMRQST] Performing VerifyExists on ChildForm_OnHandLocationsLink...", Logger.MessageType.INF);
				SeleniumControl INMRQST_ChildForm_OnHandLocationsLink = new SeleniumControl( sDriver, "ChildForm_OnHandLocationsLink", "ID", "lnk_1007968_INM_RESLN_DTL");
				Function.AssertEqual(true,INMRQST_ChildForm_OnHandLocationsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMRQST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMRQST] Performing Click on ChildForm_OnHandLocationsLink...", Logger.MessageType.INF);
				SeleniumControl INMRQST_ChildForm_OnHandLocationsLink = new SeleniumControl( sDriver, "ChildForm_OnHandLocationsLink", "ID", "lnk_1007968_INM_RESLN_DTL");
				Function.WaitControlDisplayed(INMRQST_ChildForm_OnHandLocationsLink);
INMRQST_ChildForm_OnHandLocationsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMRQST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMRQST] Performing VerifyExist on OnHandLocationsFormTable...", Logger.MessageType.INF);
				SeleniumControl INMRQST_OnHandLocationsFormTable = new SeleniumControl( sDriver, "OnHandLocationsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__INM_INVTWHSELOC_ONHAND_QTY_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,INMRQST_OnHandLocationsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMRQST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMRQST] Performing VerifyExists on OnHandLocationsForm...", Logger.MessageType.INF);
				SeleniumControl INMRQST_OnHandLocationsForm = new SeleniumControl( sDriver, "OnHandLocationsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__INM_INVTWHSELOC_ONHAND_QTY_']/ancestor::form[1]");
				Function.AssertEqual(true,INMRQST_OnHandLocationsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMRQST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMRQST] Performing Close on OnHandLocationsForm...", Logger.MessageType.INF);
				SeleniumControl INMRQST_OnHandLocationsForm = new SeleniumControl( sDriver, "OnHandLocationsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__INM_INVTWHSELOC_ONHAND_QTY_']/ancestor::form[1]");
				Function.WaitControlDisplayed(INMRQST_OnHandLocationsForm);
IWebElement formBttn = INMRQST_OnHandLocationsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "INMRQST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMRQST] Performing VerifyExists on ChildForm_SubstitutePartsLink...", Logger.MessageType.INF);
				SeleniumControl INMRQST_ChildForm_SubstitutePartsLink = new SeleniumControl( sDriver, "ChildForm_SubstitutePartsLink", "ID", "lnk_16581_INM_RESLN_DTL");
				Function.AssertEqual(true,INMRQST_ChildForm_SubstitutePartsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMRQST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMRQST] Performing Click on ChildForm_SubstitutePartsLink...", Logger.MessageType.INF);
				SeleniumControl INMRQST_ChildForm_SubstitutePartsLink = new SeleniumControl( sDriver, "ChildForm_SubstitutePartsLink", "ID", "lnk_16581_INM_RESLN_DTL");
				Function.WaitControlDisplayed(INMRQST_ChildForm_SubstitutePartsLink);
INMRQST_ChildForm_SubstitutePartsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMRQST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMRQST] Performing VerifyExist on SubstitutePartsFormTable...", Logger.MessageType.INF);
				SeleniumControl INMRQST_SubstitutePartsFormTable = new SeleniumControl( sDriver, "SubstitutePartsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSUBSTPART_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,INMRQST_SubstitutePartsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMRQST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMRQST] Performing VerifyExists on SubstitutePartsForm...", Logger.MessageType.INF);
				SeleniumControl INMRQST_SubstitutePartsForm = new SeleniumControl( sDriver, "SubstitutePartsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSUBSTPART_']/ancestor::form[1]");
				Function.AssertEqual(true,INMRQST_SubstitutePartsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMRQST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMRQST] Performing ClickButton on SubstitutePartsForm...", Logger.MessageType.INF);
				SeleniumControl INMRQST_SubstitutePartsForm = new SeleniumControl( sDriver, "SubstitutePartsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSUBSTPART_']/ancestor::form[1]");
				Function.WaitControlDisplayed(INMRQST_SubstitutePartsForm);
IWebElement formBttn = INMRQST_SubstitutePartsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? INMRQST_SubstitutePartsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
INMRQST_SubstitutePartsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMRQST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMRQST] Performing VerifyExists on SubstituteParts_SubstitutePart...", Logger.MessageType.INF);
				SeleniumControl INMRQST_SubstituteParts_SubstitutePart = new SeleniumControl( sDriver, "SubstituteParts_SubstitutePart", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSUBSTPART_']/ancestor::form[1]/descendant::*[@id='SUBST_PART_ID']");
				Function.AssertEqual(true,INMRQST_SubstituteParts_SubstitutePart.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMRQST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMRQST] Performing Close on SubstitutePartsForm...", Logger.MessageType.INF);
				SeleniumControl INMRQST_SubstitutePartsForm = new SeleniumControl( sDriver, "SubstitutePartsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSUBSTPART_']/ancestor::form[1]");
				Function.WaitControlDisplayed(INMRQST_SubstitutePartsForm);
IWebElement formBttn = INMRQST_SubstitutePartsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "INMRQST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMRQST] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl INMRQST_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(INMRQST_MainForm);
IWebElement formBttn = INMRQST_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

