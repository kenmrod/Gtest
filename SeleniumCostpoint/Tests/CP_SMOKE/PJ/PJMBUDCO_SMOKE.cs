 
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
    public class PJMBUDCO_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Projects", "xpath","//div[@class='busItem'][.='Projects']").Click();
new SeleniumControl(sDriver,"Project Setup", "xpath","//div[@class='deptItem'][.='Project Setup']").Click();
new SeleniumControl(sDriver,"Project Master", "xpath","//div[@class='navItem'][.='Project Master']").Click();
new SeleniumControl(sDriver,"Manage Change Orders", "xpath","//div[@class='navItem'][.='Manage Change Orders']").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SelectMenu]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("MAIN FORM");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBUDCO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBUDCO] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl PJMBUDCO_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,PJMBUDCO_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBUDCO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBUDCO] Performing VerifyExists on MainForm_Project...", Logger.MessageType.INF);
				SeleniumControl PJMBUDCO_MainForm_Project = new SeleniumControl( sDriver, "MainForm_Project", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PROJ_ID']");
				Function.AssertEqual(true,PJMBUDCO_MainForm_Project.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("TAB");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBUDCO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBUDCO] Performing VerifyExists on MainForm_ProjectInfo_CODetails_CONumber...", Logger.MessageType.INF);
				SeleniumControl PJMBUDCO_MainForm_ProjectInfo_CODetails_CONumber = new SeleniumControl( sDriver, "MainForm_ProjectInfo_CODetails_CONumber", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='BUD_CO_ID']");
				Function.AssertEqual(true,PJMBUDCO_MainForm_ProjectInfo_CODetails_CONumber.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBUDCO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBUDCO] Performing Select on MainForm_Tab...", Logger.MessageType.INF);
				SeleniumControl PJMBUDCO_MainForm_Tab = new SeleniumControl( sDriver, "MainForm_Tab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PJMBUDCO_MainForm_Tab);
IWebElement mTab = PJMBUDCO_MainForm_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Project Detail").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBUDCO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBUDCO] Performing VerifyExists on MainForm_ProjectDetail_ApproverID...", Logger.MessageType.INF);
				SeleniumControl PJMBUDCO_MainForm_ProjectDetail_ApproverID = new SeleniumControl( sDriver, "MainForm_ProjectDetail_ApproverID", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='APPRVL_USER_ID']");
				Function.AssertEqual(true,PJMBUDCO_MainForm_ProjectDetail_ApproverID.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("MAIN FORM TABLE");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBUDCO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBUDCO] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl PJMBUDCO_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PJMBUDCO_MainForm);
IWebElement formBttn = PJMBUDCO_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? PJMBUDCO_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
PJMBUDCO_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBUDCO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBUDCO] Performing VerifyExist on MainForm_Table...", Logger.MessageType.INF);
				SeleniumControl PJMBUDCO_MainForm_Table = new SeleniumControl( sDriver, "MainForm_Table", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJMBUDCO_MainForm_Table.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("LINE ITEM DETAIL FORM");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBUDCO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBUDCO] Performing VerifyExist on ChildFormTable...", Logger.MessageType.INF);
				SeleniumControl PJMBUDCO_ChildFormTable = new SeleniumControl( sDriver, "ChildFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBUDCO_BUDCOLN_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJMBUDCO_ChildFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBUDCO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBUDCO] Performing ClickButton on LineItemDetailForm...", Logger.MessageType.INF);
				SeleniumControl PJMBUDCO_LineItemDetailForm = new SeleniumControl( sDriver, "LineItemDetailForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBUDCO_BUDCOLN_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJMBUDCO_LineItemDetailForm);
IWebElement formBttn = PJMBUDCO_LineItemDetailForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PJMBUDCO_LineItemDetailForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PJMBUDCO_LineItemDetailForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBUDCO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBUDCO] Performing VerifyExists on LineItemDetailForm...", Logger.MessageType.INF);
				SeleniumControl PJMBUDCO_LineItemDetailForm = new SeleniumControl( sDriver, "LineItemDetailForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBUDCO_BUDCOLN_']/ancestor::form[1]");
				Function.AssertEqual(true,PJMBUDCO_LineItemDetailForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBUDCO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBUDCO] Performing VerifyExists on LineItemDetail_Account...", Logger.MessageType.INF);
				SeleniumControl PJMBUDCO_LineItemDetail_Account = new SeleniumControl( sDriver, "LineItemDetail_Account", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBUDCO_BUDCOLN_']/ancestor::form[1]/descendant::*[@id='ACCT_ID']");
				Function.AssertEqual(true,PJMBUDCO_LineItemDetail_Account.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("HOURS");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBUDCO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBUDCO] Performing VerifyExists on LineItemDetail_HoursLink...", Logger.MessageType.INF);
				SeleniumControl PJMBUDCO_LineItemDetail_HoursLink = new SeleniumControl( sDriver, "LineItemDetail_HoursLink", "ID", "lnk_1006642_PJMBUDCO_BUDCOLN");
				Function.AssertEqual(true,PJMBUDCO_LineItemDetail_HoursLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBUDCO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBUDCO] Performing Click on LineItemDetail_HoursLink...", Logger.MessageType.INF);
				SeleniumControl PJMBUDCO_LineItemDetail_HoursLink = new SeleniumControl( sDriver, "LineItemDetail_HoursLink", "ID", "lnk_1006642_PJMBUDCO_BUDCOLN");
				Function.WaitControlDisplayed(PJMBUDCO_LineItemDetail_HoursLink);
PJMBUDCO_LineItemDetail_HoursLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBUDCO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBUDCO] Performing VerifyExists on Hours1Form...", Logger.MessageType.INF);
				SeleniumControl PJMBUDCO_Hours1Form = new SeleniumControl( sDriver, "Hours1Form", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBUDCO_HRSTOTAL_']/ancestor::form[1]");
				Function.AssertEqual(true,PJMBUDCO_Hours1Form.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBUDCO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBUDCO] Performing VerifyExists on Hours1_TotalsHrsAmt...", Logger.MessageType.INF);
				SeleniumControl PJMBUDCO_Hours1_TotalsHrsAmt = new SeleniumControl( sDriver, "Hours1_TotalsHrsAmt", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBUDCO_HRSTOTAL_']/ancestor::form[1]/descendant::*[@id='TOT_HRS']");
				Function.AssertEqual(true,PJMBUDCO_Hours1_TotalsHrsAmt.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBUDCO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBUDCO] Performing VerifyExist on Hours2_Table...", Logger.MessageType.INF);
				SeleniumControl PJMBUDCO_Hours2_Table = new SeleniumControl( sDriver, "Hours2_Table", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBUDCO_BUDCOLNHRS_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJMBUDCO_Hours2_Table.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBUDCO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBUDCO] Performing ClickButton on Hours2Form...", Logger.MessageType.INF);
				SeleniumControl PJMBUDCO_Hours2Form = new SeleniumControl( sDriver, "Hours2Form", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBUDCO_BUDCOLNHRS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJMBUDCO_Hours2Form);
IWebElement formBttn = PJMBUDCO_Hours2Form.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PJMBUDCO_Hours2Form.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PJMBUDCO_Hours2Form.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBUDCO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBUDCO] Performing VerifyExists on Hours2Form...", Logger.MessageType.INF);
				SeleniumControl PJMBUDCO_Hours2Form = new SeleniumControl( sDriver, "Hours2Form", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBUDCO_BUDCOLNHRS_']/ancestor::form[1]");
				Function.AssertEqual(true,PJMBUDCO_Hours2Form.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBUDCO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBUDCO] Performing VerifyExists on Hours2_Employee...", Logger.MessageType.INF);
				SeleniumControl PJMBUDCO_Hours2_Employee = new SeleniumControl( sDriver, "Hours2_Employee", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBUDCO_BUDCOLNHRS_']/ancestor::form[1]/descendant::*[@id='EMPL_ID']");
				Function.AssertEqual(true,PJMBUDCO_Hours2_Employee.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBUDCO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBUDCO] Performing Close on Hours1Form...", Logger.MessageType.INF);
				SeleniumControl PJMBUDCO_Hours1Form = new SeleniumControl( sDriver, "Hours1Form", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBUDCO_HRSTOTAL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJMBUDCO_Hours1Form);
IWebElement formBttn = PJMBUDCO_Hours1Form.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("SUB CONTARCT");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBUDCO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBUDCO] Performing VerifyExists on LineItemDetail_SubcontractorsLink...", Logger.MessageType.INF);
				SeleniumControl PJMBUDCO_LineItemDetail_SubcontractorsLink = new SeleniumControl( sDriver, "LineItemDetail_SubcontractorsLink", "ID", "lnk_1006644_PJMBUDCO_BUDCOLN");
				Function.AssertEqual(true,PJMBUDCO_LineItemDetail_SubcontractorsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBUDCO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBUDCO] Performing Click on LineItemDetail_SubcontractorsLink...", Logger.MessageType.INF);
				SeleniumControl PJMBUDCO_LineItemDetail_SubcontractorsLink = new SeleniumControl( sDriver, "LineItemDetail_SubcontractorsLink", "ID", "lnk_1006644_PJMBUDCO_BUDCOLN");
				Function.WaitControlDisplayed(PJMBUDCO_LineItemDetail_SubcontractorsLink);
PJMBUDCO_LineItemDetail_SubcontractorsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBUDCO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBUDCO] Performing VerifyExists on Subcontractors1Form...", Logger.MessageType.INF);
				SeleniumControl PJMBUDCO_Subcontractors1Form = new SeleniumControl( sDriver, "Subcontractors1Form", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBUDCO_SUBTOTAL_']/ancestor::form[1]");
				Function.AssertEqual(true,PJMBUDCO_Subcontractors1Form.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBUDCO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBUDCO] Performing VerifyExists on Subcontractors1_Totals...", Logger.MessageType.INF);
				SeleniumControl PJMBUDCO_Subcontractors1_Totals = new SeleniumControl( sDriver, "Subcontractors1_Totals", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBUDCO_SUBTOTAL_']/ancestor::form[1]/descendant::*[@id='PROP_AMT']");
				Function.AssertEqual(true,PJMBUDCO_Subcontractors1_Totals.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBUDCO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBUDCO] Performing Close on Subcontractors1Form...", Logger.MessageType.INF);
				SeleniumControl PJMBUDCO_Subcontractors1Form = new SeleniumControl( sDriver, "Subcontractors1Form", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBUDCO_SUBTOTAL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJMBUDCO_Subcontractors1Form);
IWebElement formBttn = PJMBUDCO_Subcontractors1Form.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("UNITS");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBUDCO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBUDCO] Performing VerifyExists on LineItemDetail_UnitsLink...", Logger.MessageType.INF);
				SeleniumControl PJMBUDCO_LineItemDetail_UnitsLink = new SeleniumControl( sDriver, "LineItemDetail_UnitsLink", "ID", "lnk_1006646_PJMBUDCO_BUDCOLN");
				Function.AssertEqual(true,PJMBUDCO_LineItemDetail_UnitsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBUDCO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBUDCO] Performing Click on LineItemDetail_UnitsLink...", Logger.MessageType.INF);
				SeleniumControl PJMBUDCO_LineItemDetail_UnitsLink = new SeleniumControl( sDriver, "LineItemDetail_UnitsLink", "ID", "lnk_1006646_PJMBUDCO_BUDCOLN");
				Function.WaitControlDisplayed(PJMBUDCO_LineItemDetail_UnitsLink);
PJMBUDCO_LineItemDetail_UnitsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBUDCO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBUDCO] Performing VerifyExists on Units1Form...", Logger.MessageType.INF);
				SeleniumControl PJMBUDCO_Units1Form = new SeleniumControl( sDriver, "Units1Form", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBUDCO_UNITTOTAL_']/ancestor::form[1]");
				Function.AssertEqual(true,PJMBUDCO_Units1Form.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBUDCO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBUDCO] Performing VerifyExists on Units1_Totals...", Logger.MessageType.INF);
				SeleniumControl PJMBUDCO_Units1_Totals = new SeleniumControl( sDriver, "Units1_Totals", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBUDCO_UNITTOTAL_']/ancestor::form[1]/descendant::*[@id='UNIT_QTY']");
				Function.AssertEqual(true,PJMBUDCO_Units1_Totals.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBUDCO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBUDCO] Performing VerifyExist on Units2_Table...", Logger.MessageType.INF);
				SeleniumControl PJMBUDCO_Units2_Table = new SeleniumControl( sDriver, "Units2_Table", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBUDCO_BUDCOLNUNITS_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJMBUDCO_Units2_Table.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBUDCO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBUDCO] Performing ClickButton on Units2Form...", Logger.MessageType.INF);
				SeleniumControl PJMBUDCO_Units2Form = new SeleniumControl( sDriver, "Units2Form", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBUDCO_BUDCOLNUNITS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJMBUDCO_Units2Form);
IWebElement formBttn = PJMBUDCO_Units2Form.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PJMBUDCO_Units2Form.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PJMBUDCO_Units2Form.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBUDCO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBUDCO] Performing VerifyExists on Units2Form...", Logger.MessageType.INF);
				SeleniumControl PJMBUDCO_Units2Form = new SeleniumControl( sDriver, "Units2Form", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBUDCO_BUDCOLNUNITS_']/ancestor::form[1]");
				Function.AssertEqual(true,PJMBUDCO_Units2Form.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBUDCO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBUDCO] Performing VerifyExists on Units2_CLIN...", Logger.MessageType.INF);
				SeleniumControl PJMBUDCO_Units2_CLIN = new SeleniumControl( sDriver, "Units2_CLIN", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBUDCO_BUDCOLNUNITS_']/ancestor::form[1]/descendant::*[@id='CLIN_ID']");
				Function.AssertEqual(true,PJMBUDCO_Units2_CLIN.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBUDCO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBUDCO] Performing Close on Units1Form...", Logger.MessageType.INF);
				SeleniumControl PJMBUDCO_Units1Form = new SeleniumControl( sDriver, "Units1Form", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBUDCO_UNITTOTAL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJMBUDCO_Units1Form);
IWebElement formBttn = PJMBUDCO_Units1Form.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("CLOSE");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBUDCO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBUDCO] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl PJMBUDCO_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PJMBUDCO_MainForm);
IWebElement formBttn = PJMBUDCO_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

