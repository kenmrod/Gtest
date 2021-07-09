 
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
    public class INMPAXFR_SMOKE : SeleniumTestScript
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
								try
				{
				this.ScriptLogger.WriteLine("check main form ");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "CP7Main";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[CP7Main] Performing SelectMenu on NavMenu...", Logger.MessageType.INF);
				SeleniumControl CP7Main_NavMenu = new SeleniumControl( sDriver, "NavMenu", "ID", "navCont");
				if(!sDriver.Instance.FindElement(By.CssSelector("div[class='navCont']")).Displayed) new SeleniumControl(sDriver,"Browse", "css", "span[id = 'goToLbl']").Click();
new SeleniumControl(sDriver,"Materials", "xpath","//div[@class='busItem'][.='Materials']").Click();
new SeleniumControl(sDriver,"Inventory", "xpath","//div[@class='deptItem'][.='Inventory']").Click();
new SeleniumControl(sDriver,"Transfers", "xpath","//div[@class='navItem'][.='Transfers']").Click();
new SeleniumControl(sDriver,"Enter Inventory Transfers", "xpath","//div[@class='navItem'][.='Enter Inventory Transfers']").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SelectMenu]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPAXFR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPAXFR] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl INMPAXFR_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,INMPAXFR_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPAXFR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPAXFR] Performing VerifyExists on Identification_TransferID...", Logger.MessageType.INF);
				SeleniumControl INMPAXFR_Identification_TransferID = new SeleniumControl( sDriver, "Identification_TransferID", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='INVT_TRN_ID_LNK']");
				Function.AssertEqual(true,INMPAXFR_Identification_TransferID.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPAXFR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPAXFR] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl INMPAXFR_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(INMPAXFR_MainForm);
IWebElement formBttn = INMPAXFR_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? INMPAXFR_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
INMPAXFR_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPAXFR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPAXFR] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl INMPAXFR_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,INMPAXFR_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPAXFR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPAXFR] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl INMPAXFR_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(INMPAXFR_MainForm);
IWebElement formBttn = INMPAXFR_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? INMPAXFR_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
INMPAXFR_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPAXFR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPAXFR] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl INMPAXFR_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,INMPAXFR_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPAXFR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPAXFR] Performing VerifyExists on Identification_TransferID...", Logger.MessageType.INF);
				SeleniumControl INMPAXFR_Identification_TransferID = new SeleniumControl( sDriver, "Identification_TransferID", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='INVT_TRN_ID_LNK']");
				Function.AssertEqual(true,INMPAXFR_Identification_TransferID.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPAXFR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPAXFR] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl INMPAXFR_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(INMPAXFR_MainForm);
IWebElement formBttn = INMPAXFR_MainForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).Count <= 0 ? INMPAXFR_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Query')]")).FirstOrDefault() :
INMPAXFR_MainForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).FirstOrDefault();
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
				this.ScriptLogger.WriteLine("check accounting period");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPAXFR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPAXFR] Performing Click on AccountingPeriodLink...", Logger.MessageType.INF);
				SeleniumControl INMPAXFR_AccountingPeriodLink = new SeleniumControl( sDriver, "AccountingPeriodLink", "ID", "lnk_1007990_INMPAXFR_INVTTRN_HDR");
				Function.WaitControlDisplayed(INMPAXFR_AccountingPeriodLink);
INMPAXFR_AccountingPeriodLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPAXFR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPAXFR] Performing VerifyExists on AccountingPeriodForm...", Logger.MessageType.INF);
				SeleniumControl INMPAXFR_AccountingPeriodForm = new SeleniumControl( sDriver, "AccountingPeriodForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMACCPD_HDR_']/ancestor::form[1]");
				Function.AssertEqual(true,INMPAXFR_AccountingPeriodForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPAXFR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPAXFR] Performing VerifyExists on AccountingPeriod_FiscalYear...", Logger.MessageType.INF);
				SeleniumControl INMPAXFR_AccountingPeriod_FiscalYear = new SeleniumControl( sDriver, "AccountingPeriod_FiscalYear", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMACCPD_HDR_']/ancestor::form[1]/descendant::*[@id='DFS_FYCD_ST']");
				Function.AssertEqual(true,INMPAXFR_AccountingPeriod_FiscalYear.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPAXFR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPAXFR] Performing ClickButton on AccountingPeriodForm...", Logger.MessageType.INF);
				SeleniumControl INMPAXFR_AccountingPeriodForm = new SeleniumControl( sDriver, "AccountingPeriodForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMACCPD_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(INMPAXFR_AccountingPeriodForm);
IWebElement formBttn = INMPAXFR_AccountingPeriodForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? INMPAXFR_AccountingPeriodForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
INMPAXFR_AccountingPeriodForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPAXFR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPAXFR] Performing VerifyExist on AccountingPeriodFormTable...", Logger.MessageType.INF);
				SeleniumControl INMPAXFR_AccountingPeriodFormTable = new SeleniumControl( sDriver, "AccountingPeriodFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMACCPD_HDR_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,INMPAXFR_AccountingPeriodFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPAXFR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPAXFR] Performing ClickButton on AccountingPeriodForm...", Logger.MessageType.INF);
				SeleniumControl INMPAXFR_AccountingPeriodForm = new SeleniumControl( sDriver, "AccountingPeriodForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMACCPD_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(INMPAXFR_AccountingPeriodForm);
IWebElement formBttn = INMPAXFR_AccountingPeriodForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? INMPAXFR_AccountingPeriodForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
INMPAXFR_AccountingPeriodForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPAXFR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPAXFR] Performing VerifyExists on AccountingPeriodForm...", Logger.MessageType.INF);
				SeleniumControl INMPAXFR_AccountingPeriodForm = new SeleniumControl( sDriver, "AccountingPeriodForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMACCPD_HDR_']/ancestor::form[1]");
				Function.AssertEqual(true,INMPAXFR_AccountingPeriodForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPAXFR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPAXFR] Performing VerifyExists on AccountingPeriod_FiscalYear...", Logger.MessageType.INF);
				SeleniumControl INMPAXFR_AccountingPeriod_FiscalYear = new SeleniumControl( sDriver, "AccountingPeriod_FiscalYear", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMACCPD_HDR_']/ancestor::form[1]/descendant::*[@id='DFS_FYCD_ST']");
				Function.AssertEqual(true,INMPAXFR_AccountingPeriod_FiscalYear.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPAXFR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPAXFR] Performing Click on AccountingPeriod_OK...", Logger.MessageType.INF);
				SeleniumControl INMPAXFR_AccountingPeriod_OK = new SeleniumControl( sDriver, "AccountingPeriod_OK", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMACCPD_HDR_']/ancestor::form[1]/following-sibling::div[1]/descendant::*[@id='bOk']");
				Function.WaitControlDisplayed(INMPAXFR_AccountingPeriod_OK);
if (INMPAXFR_AccountingPeriod_OK.mElement.GetAttribute("class") == "popupBtn" && sDriver.BrowserType == "ie")
INMPAXFR_AccountingPeriod_OK.Click(5,5);
else INMPAXFR_AccountingPeriod_OK.Click(4.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("check child form");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPAXFR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPAXFR] Performing VerifyExist on ChildFormTable...", Logger.MessageType.INF);
				SeleniumControl INMPAXFR_ChildFormTable = new SeleniumControl( sDriver, "ChildFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__INMPAXFR_INVTTRNLN_CHD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,INMPAXFR_ChildFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPAXFR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPAXFR] Performing ClickButton on ChildForm...", Logger.MessageType.INF);
				SeleniumControl INMPAXFR_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__INMPAXFR_INVTTRNLN_CHD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(INMPAXFR_ChildForm);
IWebElement formBttn = INMPAXFR_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? INMPAXFR_ChildForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
INMPAXFR_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPAXFR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPAXFR] Performing VerifyExists on ChildForm...", Logger.MessageType.INF);
				SeleniumControl INMPAXFR_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__INMPAXFR_INVTTRNLN_CHD_']/ancestor::form[1]");
				Function.AssertEqual(true,INMPAXFR_ChildForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPAXFR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPAXFR] Performing VerifyExists on ChildForm_Line...", Logger.MessageType.INF);
				SeleniumControl INMPAXFR_ChildForm_Line = new SeleniumControl( sDriver, "ChildForm_Line", "xpath", "//div[translate(@id,'0123456789','')='pr__INMPAXFR_INVTTRNLN_CHD_']/ancestor::form[1]/descendant::*[@id='INVT_TRN_LN_NO']");
				Function.AssertEqual(true,INMPAXFR_ChildForm_Line.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPAXFR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPAXFR] Performing ClickButton on ChildForm...", Logger.MessageType.INF);
				SeleniumControl INMPAXFR_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__INMPAXFR_INVTTRNLN_CHD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(INMPAXFR_ChildForm);
IWebElement formBttn = INMPAXFR_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? INMPAXFR_ChildForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
INMPAXFR_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPAXFR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPAXFR] Performing VerifyExist on ChildFormTable...", Logger.MessageType.INF);
				SeleniumControl INMPAXFR_ChildFormTable = new SeleniumControl( sDriver, "ChildFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__INMPAXFR_INVTTRNLN_CHD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,INMPAXFR_ChildFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPAXFR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPAXFR] Performing ClickButton on ChildForm...", Logger.MessageType.INF);
				SeleniumControl INMPAXFR_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__INMPAXFR_INVTTRNLN_CHD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(INMPAXFR_ChildForm);
IWebElement formBttn = INMPAXFR_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? INMPAXFR_ChildForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
INMPAXFR_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Check serial lot information");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPAXFR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPAXFR] Performing Click on ChildForm_SerialLotInfoLink...", Logger.MessageType.INF);
				SeleniumControl INMPAXFR_ChildForm_SerialLotInfoLink = new SeleniumControl( sDriver, "ChildForm_SerialLotInfoLink", "ID", "lnk_1008078_INMPAXFR_INVTTRNLN_CHD");
				Function.WaitControlDisplayed(INMPAXFR_ChildForm_SerialLotInfoLink);
INMPAXFR_ChildForm_SerialLotInfoLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPAXFR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPAXFR] Performing VerifyExist on SerialLotInfoFormTable...", Logger.MessageType.INF);
				SeleniumControl INMPAXFR_SerialLotInfoFormTable = new SeleniumControl( sDriver, "SerialLotInfoFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSRLT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,INMPAXFR_SerialLotInfoFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPAXFR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPAXFR] Performing ClickButton on SerialLotInfoForm...", Logger.MessageType.INF);
				SeleniumControl INMPAXFR_SerialLotInfoForm = new SeleniumControl( sDriver, "SerialLotInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSRLT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(INMPAXFR_SerialLotInfoForm);
IWebElement formBttn = INMPAXFR_SerialLotInfoForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? INMPAXFR_SerialLotInfoForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
INMPAXFR_SerialLotInfoForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPAXFR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPAXFR] Performing VerifyExists on SerialLotInfoForm...", Logger.MessageType.INF);
				SeleniumControl INMPAXFR_SerialLotInfoForm = new SeleniumControl( sDriver, "SerialLotInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSRLT_']/ancestor::form[1]");
				Function.AssertEqual(true,INMPAXFR_SerialLotInfoForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPAXFR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPAXFR] Performing VerifyExists on SerialLotInfo_LotNumber...", Logger.MessageType.INF);
				SeleniumControl INMPAXFR_SerialLotInfo_LotNumber = new SeleniumControl( sDriver, "SerialLotInfo_LotNumber", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSRLT_']/ancestor::form[1]/descendant::*[@id='LOT_ID']");
				Function.AssertEqual(true,INMPAXFR_SerialLotInfo_LotNumber.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPAXFR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPAXFR] Performing VerifyExists on SerialLotInfo_BasicInformation_Origin_Order...", Logger.MessageType.INF);
				SeleniumControl INMPAXFR_SerialLotInfo_BasicInformation_Origin_Order = new SeleniumControl( sDriver, "SerialLotInfo_BasicInformation_Origin_Order", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSRLT_']/ancestor::form[1]/descendant::*[@id='ORIG_ORD_ID']");
				Function.AssertEqual(true,INMPAXFR_SerialLotInfo_BasicInformation_Origin_Order.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPAXFR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPAXFR] Performing ClickButton on SerialLotInfoForm...", Logger.MessageType.INF);
				SeleniumControl INMPAXFR_SerialLotInfoForm = new SeleniumControl( sDriver, "SerialLotInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSRLT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(INMPAXFR_SerialLotInfoForm);
IWebElement formBttn = INMPAXFR_SerialLotInfoForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? INMPAXFR_SerialLotInfoForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
INMPAXFR_SerialLotInfoForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPAXFR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPAXFR] Performing VerifyExist on SerialLotInfoFormTable...", Logger.MessageType.INF);
				SeleniumControl INMPAXFR_SerialLotInfoFormTable = new SeleniumControl( sDriver, "SerialLotInfoFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSRLT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,INMPAXFR_SerialLotInfoFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPAXFR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPAXFR] Performing Close on SerialLotInfoForm...", Logger.MessageType.INF);
				SeleniumControl INMPAXFR_SerialLotInfoForm = new SeleniumControl( sDriver, "SerialLotInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSRLT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(INMPAXFR_SerialLotInfoForm);
IWebElement formBttn = INMPAXFR_SerialLotInfoForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPAXFR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPAXFR] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl INMPAXFR_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(INMPAXFR_MainForm);
IWebElement formBttn = INMPAXFR_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

