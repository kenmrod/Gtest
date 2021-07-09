 
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
    public class INMPCLST_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Physical Counts", "xpath","//div[@class='navItem'][.='Physical Counts']").Click();
new SeleniumControl(sDriver,"Manage Physical Counts", "xpath","//div[@class='navItem'][.='Manage Physical Counts']").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SelectMenu]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPCLST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPCLST] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl INMPCLST_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,INMPCLST_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPCLST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPCLST] Performing VerifyExists on MainForm_Identification_WAREHOUSEM...", Logger.MessageType.INF);
				SeleniumControl INMPCLST_MainForm_Identification_WAREHOUSEM = new SeleniumControl( sDriver, "MainForm_Identification_WAREHOUSEM", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='WHSE_ID']");
				Function.AssertEqual(true,INMPCLST_MainForm_Identification_WAREHOUSEM.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPCLST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPCLST] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl INMPCLST_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(INMPCLST_MainForm);
IWebElement formBttn = INMPCLST_MainForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).Count <= 0 ? INMPCLST_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Query')]")).FirstOrDefault() :
INMPCLST_MainForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).FirstOrDefault();
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
Function.AssertEqual("Maintain Physical Count List", new SeleniumControl(sDriver,"QueryTitle", "ID", "qryHeaderLabel").GetValue().Trim());


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyTitle]" , ex.Message));
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
				Function.CurrentComponent = "INMPCLST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPCLST] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl INMPCLST_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,INMPCLST_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPCLST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPCLST] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl INMPCLST_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(INMPCLST_MainForm);
IWebElement formBttn = INMPCLST_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? INMPCLST_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
INMPCLST_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPCLST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPCLST] Performing VerifyExists on PhysicalCountDetailsForm...", Logger.MessageType.INF);
				SeleniumControl INMPCLST_PhysicalCountDetailsForm = new SeleniumControl( sDriver, "PhysicalCountDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__INMPCLST_PHYSCOUNTDETL_DETL_']/ancestor::form[1]");
				Function.AssertEqual(true,INMPCLST_PhysicalCountDetailsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPCLST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPCLST] Performing ClickButton on PhysicalCountDetailsForm...", Logger.MessageType.INF);
				SeleniumControl INMPCLST_PhysicalCountDetailsForm = new SeleniumControl( sDriver, "PhysicalCountDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__INMPCLST_PHYSCOUNTDETL_DETL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(INMPCLST_PhysicalCountDetailsForm);
IWebElement formBttn = INMPCLST_PhysicalCountDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? INMPCLST_PhysicalCountDetailsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
INMPCLST_PhysicalCountDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("SERIAL/LOTINFO");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPCLST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPCLST] Performing Click on PhysicalCountDetails_SerialLotInfoLink...", Logger.MessageType.INF);
				SeleniumControl INMPCLST_PhysicalCountDetails_SerialLotInfoLink = new SeleniumControl( sDriver, "PhysicalCountDetails_SerialLotInfoLink", "ID", "lnk_1008011_INMPCLST_PHYSCOUNTDETL_DETL");
				Function.WaitControlDisplayed(INMPCLST_PhysicalCountDetails_SerialLotInfoLink);
INMPCLST_PhysicalCountDetails_SerialLotInfoLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPCLST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPCLST] Performing VerifyExists on SerialLotInfoMainForm...", Logger.MessageType.INF);
				SeleniumControl INMPCLST_SerialLotInfoMainForm = new SeleniumControl( sDriver, "SerialLotInfoMainForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MM_PHYSCOUNTDETL_SUM_']/ancestor::form[1]");
				Function.AssertEqual(true,INMPCLST_SerialLotInfoMainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPCLST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPCLST] Performing VerifyExists on SerialLotInfoMainForm_ActualCountQty...", Logger.MessageType.INF);
				SeleniumControl INMPCLST_SerialLotInfoMainForm_ActualCountQty = new SeleniumControl( sDriver, "SerialLotInfoMainForm_ActualCountQty", "xpath", "//div[translate(@id,'0123456789','')='pr__MM_PHYSCOUNTDETL_SUM_']/ancestor::form[1]/descendant::*[@id='ACTUAL_QTY']");
				Function.AssertEqual(true,INMPCLST_SerialLotInfoMainForm_ActualCountQty.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPCLST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPCLST] Performing VerifyExist on SerialLotInfoChildFormTable...", Logger.MessageType.INF);
				SeleniumControl INMPCLST_SerialLotInfoChildFormTable = new SeleniumControl( sDriver, "SerialLotInfoChildFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSRLTP_PHYSCNTDTLSRLT_CHILD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,INMPCLST_SerialLotInfoChildFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPCLST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPCLST] Performing ClickButton on SerialLotInfoChildForm...", Logger.MessageType.INF);
				SeleniumControl INMPCLST_SerialLotInfoChildForm = new SeleniumControl( sDriver, "SerialLotInfoChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSRLTP_PHYSCNTDTLSRLT_CHILD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(INMPCLST_SerialLotInfoChildForm);
IWebElement formBttn = INMPCLST_SerialLotInfoChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? INMPCLST_SerialLotInfoChildForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
INMPCLST_SerialLotInfoChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPCLST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPCLST] Performing VerifyExists on SerialLotInfoChildForm...", Logger.MessageType.INF);
				SeleniumControl INMPCLST_SerialLotInfoChildForm = new SeleniumControl( sDriver, "SerialLotInfoChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSRLTP_PHYSCNTDTLSRLT_CHILD_']/ancestor::form[1]");
				Function.AssertEqual(true,INMPCLST_SerialLotInfoChildForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPCLST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPCLST] Performing VerifyExists on SerialLotInfoChildForm_BasicInformation_ActualCountQuantity...", Logger.MessageType.INF);
				SeleniumControl INMPCLST_SerialLotInfoChildForm_BasicInformation_ActualCountQuantity = new SeleniumControl( sDriver, "SerialLotInfoChildForm_BasicInformation_ActualCountQuantity", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSRLTP_PHYSCNTDTLSRLT_CHILD_']/ancestor::form[1]/descendant::*[@id='ACTUAL_QTY']");
				Function.AssertEqual(true,INMPCLST_SerialLotInfoChildForm_BasicInformation_ActualCountQuantity.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPCLST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPCLST] Performing Close on SerialLotInfoMainForm...", Logger.MessageType.INF);
				SeleniumControl INMPCLST_SerialLotInfoMainForm = new SeleniumControl( sDriver, "SerialLotInfoMainForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MM_PHYSCOUNTDETL_SUM_']/ancestor::form[1]");
				Function.WaitControlDisplayed(INMPCLST_SerialLotInfoMainForm);
IWebElement formBttn = INMPCLST_SerialLotInfoMainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPCLST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPCLST] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl INMPCLST_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(INMPCLST_MainForm);
IWebElement formBttn = INMPCLST_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

