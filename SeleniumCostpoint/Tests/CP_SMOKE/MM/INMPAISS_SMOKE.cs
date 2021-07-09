 
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
    public class INMPAISS_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Issues", "xpath","//div[@class='navItem'][.='Issues']").Click();
new SeleniumControl(sDriver,"Enter Issues to Project/Account/Org or PO", "xpath","//div[@class='navItem'][.='Enter Issues to Project/Account/Org or PO']").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SelectMenu]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Main Form");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPAISS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPAISS] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl INMPAISS_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,INMPAISS_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPAISS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPAISS] Performing VerifyExists on Identification_Warehouse...", Logger.MessageType.INF);
				SeleniumControl INMPAISS_Identification_Warehouse = new SeleniumControl( sDriver, "Identification_Warehouse", "ID", "WHSE_ID");
				Function.AssertEqual(true,INMPAISS_Identification_Warehouse.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPAISS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPAISS] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl INMPAISS_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(INMPAISS_MainForm);
IWebElement formBttn = INMPAISS_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? INMPAISS_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
INMPAISS_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPAISS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPAISS] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl INMPAISS_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,INMPAISS_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPAISS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPAISS] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl INMPAISS_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(INMPAISS_MainForm);
IWebElement formBttn = INMPAISS_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? INMPAISS_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
INMPAISS_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPAISS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPAISS] Performing VerifyExists on Identification_Warehouse...", Logger.MessageType.INF);
				SeleniumControl INMPAISS_Identification_Warehouse = new SeleniumControl( sDriver, "Identification_Warehouse", "ID", "WHSE_ID");
				Function.AssertEqual(true,INMPAISS_Identification_Warehouse.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Accounting Period");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPAISS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPAISS] Performing VerifyExists on AccountingPeriodLink...", Logger.MessageType.INF);
				SeleniumControl INMPAISS_AccountingPeriodLink = new SeleniumControl( sDriver, "AccountingPeriodLink", "ID", "lnk_1008089_INMPAISS_INVTTRN_HDR");
				Function.AssertEqual(true,INMPAISS_AccountingPeriodLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPAISS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPAISS] Performing Click on AccountingPeriodLink...", Logger.MessageType.INF);
				SeleniumControl INMPAISS_AccountingPeriodLink = new SeleniumControl( sDriver, "AccountingPeriodLink", "ID", "lnk_1008089_INMPAISS_INVTTRN_HDR");
				Function.WaitControlDisplayed(INMPAISS_AccountingPeriodLink);
INMPAISS_AccountingPeriodLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPAISS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPAISS] Performing VerifyExists on AccountingPeriodForm...", Logger.MessageType.INF);
				SeleniumControl INMPAISS_AccountingPeriodForm = new SeleniumControl( sDriver, "AccountingPeriodForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMACCPD_HDR_']/ancestor::form[1]");
				Function.AssertEqual(true,INMPAISS_AccountingPeriodForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPAISS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPAISS] Performing ClickButton on AccountingPeriodForm...", Logger.MessageType.INF);
				SeleniumControl INMPAISS_AccountingPeriodForm = new SeleniumControl( sDriver, "AccountingPeriodForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMACCPD_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(INMPAISS_AccountingPeriodForm);
IWebElement formBttn = INMPAISS_AccountingPeriodForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? INMPAISS_AccountingPeriodForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
INMPAISS_AccountingPeriodForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPAISS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPAISS] Performing VerifyExist on AccountingPeriodTable...", Logger.MessageType.INF);
				SeleniumControl INMPAISS_AccountingPeriodTable = new SeleniumControl( sDriver, "AccountingPeriodTable", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMACCPD_HDR_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,INMPAISS_AccountingPeriodTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPAISS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPAISS] Performing Close on AccountingPeriodForm...", Logger.MessageType.INF);
				SeleniumControl INMPAISS_AccountingPeriodForm = new SeleniumControl( sDriver, "AccountingPeriodForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMACCPD_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(INMPAISS_AccountingPeriodForm);
IWebElement formBttn = INMPAISS_AccountingPeriodForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Table Window Form");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPAISS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPAISS] Performing VerifyExists on TableWindowForm...", Logger.MessageType.INF);
				SeleniumControl INMPAISS_TableWindowForm = new SeleniumControl( sDriver, "TableWindowForm", "xpath", "//div[translate(@id,'0123456789','')='pr__INMPAISS_INVTTRNLN_DTL_']/ancestor::form[1]");
				Function.AssertEqual(true,INMPAISS_TableWindowForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPAISS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPAISS] Performing VerifyExist on TableWindowTable...", Logger.MessageType.INF);
				SeleniumControl INMPAISS_TableWindowTable = new SeleniumControl( sDriver, "TableWindowTable", "xpath", "//div[translate(@id,'0123456789','')='pr__INMPAISS_INVTTRNLN_DTL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,INMPAISS_TableWindowTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPAISS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPAISS] Performing ClickButton on TableWindowForm...", Logger.MessageType.INF);
				SeleniumControl INMPAISS_TableWindowForm = new SeleniumControl( sDriver, "TableWindowForm", "xpath", "//div[translate(@id,'0123456789','')='pr__INMPAISS_INVTTRNLN_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(INMPAISS_TableWindowForm);
IWebElement formBttn = INMPAISS_TableWindowForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? INMPAISS_TableWindowForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
INMPAISS_TableWindowForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPAISS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPAISS] Performing VerifyExists on TableWindow_Line...", Logger.MessageType.INF);
				SeleniumControl INMPAISS_TableWindow_Line = new SeleniumControl( sDriver, "TableWindow_Line", "xpath", "//div[translate(@id,'0123456789','')='pr__INMPAISS_INVTTRNLN_DTL_']/ancestor::form[1]/descendant::*[@id='INVT_TRN_LN_NO']");
				Function.AssertEqual(true,INMPAISS_TableWindow_Line.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPAISS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPAISS] Performing Select on TableWindowTab...", Logger.MessageType.INF);
				SeleniumControl INMPAISS_TableWindowTab = new SeleniumControl( sDriver, "TableWindowTab", "xpath", "//div[translate(@id,'0123456789','')='pr__INMPAISS_INVTTRNLN_DTL_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(INMPAISS_TableWindowTab);
IWebElement mTab = INMPAISS_TableWindowTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Line Details").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPAISS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPAISS] Performing VerifyExists on TableWindow_LineDetails_Issue_FromInvAbbrev...", Logger.MessageType.INF);
				SeleniumControl INMPAISS_TableWindow_LineDetails_Issue_FromInvAbbrev = new SeleniumControl( sDriver, "TableWindow_LineDetails_Issue_FromInvAbbrev", "xpath", "//div[translate(@id,'0123456789','')='pr__INMPAISS_INVTTRNLN_DTL_']/ancestor::form[1]/descendant::*[@id='INVT_ABBRV_CD_FR']");
				Function.AssertEqual(true,INMPAISS_TableWindow_LineDetails_Issue_FromInvAbbrev.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPAISS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPAISS] Performing Select on TableWindowTab...", Logger.MessageType.INF);
				SeleniumControl INMPAISS_TableWindowTab = new SeleniumControl( sDriver, "TableWindowTab", "xpath", "//div[translate(@id,'0123456789','')='pr__INMPAISS_INVTTRNLN_DTL_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(INMPAISS_TableWindowTab);
IWebElement mTab = INMPAISS_TableWindowTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Cost Elements").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPAISS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPAISS] Performing VerifyExists on TableWindow_CostElements_DirectCostElements_Material...", Logger.MessageType.INF);
				SeleniumControl INMPAISS_TableWindow_CostElements_DirectCostElements_Material = new SeleniumControl( sDriver, "TableWindow_CostElements_DirectCostElements_Material", "xpath", "//div[translate(@id,'0123456789','')='pr__INMPAISS_INVTTRNLN_DTL_']/ancestor::form[1]/descendant::*[@id='MATL_CST_AMT']");
				Function.AssertEqual(true,INMPAISS_TableWindow_CostElements_DirectCostElements_Material.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPAISS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPAISS] Performing Select on TableWindowTab...", Logger.MessageType.INF);
				SeleniumControl INMPAISS_TableWindowTab = new SeleniumControl( sDriver, "TableWindowTab", "xpath", "//div[translate(@id,'0123456789','')='pr__INMPAISS_INVTTRNLN_DTL_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(INMPAISS_TableWindowTab);
IWebElement mTab = INMPAISS_TableWindowTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Other Info").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPAISS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPAISS] Performing VerifyExists on TableWindow_OtherInfo_ReferenceNumbers_From_REF1...", Logger.MessageType.INF);
				SeleniumControl INMPAISS_TableWindow_OtherInfo_ReferenceNumbers_From_REF1 = new SeleniumControl( sDriver, "TableWindow_OtherInfo_ReferenceNumbers_From_REF1", "xpath", "//div[translate(@id,'0123456789','')='pr__INMPAISS_INVTTRNLN_DTL_']/ancestor::form[1]/descendant::*[@id='REF_STRUC_1_ID_FR']");
				Function.AssertEqual(true,INMPAISS_TableWindow_OtherInfo_ReferenceNumbers_From_REF1.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Serial/Lot Info");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPAISS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPAISS] Performing VerifyExists on TableWindow_SerialLotInfoLink...", Logger.MessageType.INF);
				SeleniumControl INMPAISS_TableWindow_SerialLotInfoLink = new SeleniumControl( sDriver, "TableWindow_SerialLotInfoLink", "ID", "lnk_1008059_INMPAISS_INVTTRNLN_DTL");
				Function.AssertEqual(true,INMPAISS_TableWindow_SerialLotInfoLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPAISS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPAISS] Performing Click on TableWindow_SerialLotInfoLink...", Logger.MessageType.INF);
				SeleniumControl INMPAISS_TableWindow_SerialLotInfoLink = new SeleniumControl( sDriver, "TableWindow_SerialLotInfoLink", "ID", "lnk_1008059_INMPAISS_INVTTRNLN_DTL");
				Function.WaitControlDisplayed(INMPAISS_TableWindow_SerialLotInfoLink);
INMPAISS_TableWindow_SerialLotInfoLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPAISS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPAISS] Performing VerifyExists on TableWindow_SerialLotInfoForm...", Logger.MessageType.INF);
				SeleniumControl INMPAISS_TableWindow_SerialLotInfoForm = new SeleniumControl( sDriver, "TableWindow_SerialLotInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSRLT_']/ancestor::form[1]");
				Function.AssertEqual(true,INMPAISS_TableWindow_SerialLotInfoForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPAISS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPAISS] Performing VerifyExist on TableWindow_SerialLotInfoTable...", Logger.MessageType.INF);
				SeleniumControl INMPAISS_TableWindow_SerialLotInfoTable = new SeleniumControl( sDriver, "TableWindow_SerialLotInfoTable", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSRLT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,INMPAISS_TableWindow_SerialLotInfoTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPAISS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPAISS] Performing ClickButton on TableWindow_SerialLotInfoForm...", Logger.MessageType.INF);
				SeleniumControl INMPAISS_TableWindow_SerialLotInfoForm = new SeleniumControl( sDriver, "TableWindow_SerialLotInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSRLT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(INMPAISS_TableWindow_SerialLotInfoForm);
IWebElement formBttn = INMPAISS_TableWindow_SerialLotInfoForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? INMPAISS_TableWindow_SerialLotInfoForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
INMPAISS_TableWindow_SerialLotInfoForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPAISS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPAISS] Performing VerifyExists on TableWindow_SerialLotInfo_SerialNumber...", Logger.MessageType.INF);
				SeleniumControl INMPAISS_TableWindow_SerialLotInfo_SerialNumber = new SeleniumControl( sDriver, "TableWindow_SerialLotInfo_SerialNumber", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSRLT_']/ancestor::form[1]/descendant::*[@id='SERIAL_ID']");
				Function.AssertEqual(true,INMPAISS_TableWindow_SerialLotInfo_SerialNumber.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPAISS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPAISS] Performing Select on TableWindow_SerialLotInfoTab...", Logger.MessageType.INF);
				SeleniumControl INMPAISS_TableWindow_SerialLotInfoTab = new SeleniumControl( sDriver, "TableWindow_SerialLotInfoTab", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSRLT_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(INMPAISS_TableWindow_SerialLotInfoTab);
IWebElement mTab = INMPAISS_TableWindow_SerialLotInfoTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Basic Information").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPAISS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPAISS] Performing VerifyExists on TableWindow_SerialLotInfo_BasicInformation_Quantity...", Logger.MessageType.INF);
				SeleniumControl INMPAISS_TableWindow_SerialLotInfo_BasicInformation_Quantity = new SeleniumControl( sDriver, "TableWindow_SerialLotInfo_BasicInformation_Quantity", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSRLT_']/ancestor::form[1]/descendant::*[@id='TRN_QTY']");
				Function.AssertEqual(true,INMPAISS_TableWindow_SerialLotInfo_BasicInformation_Quantity.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPAISS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPAISS] Performing Select on TableWindow_SerialLotInfoTab...", Logger.MessageType.INF);
				SeleniumControl INMPAISS_TableWindow_SerialLotInfoTab = new SeleniumControl( sDriver, "TableWindow_SerialLotInfoTab", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSRLT_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(INMPAISS_TableWindow_SerialLotInfoTab);
IWebElement mTab = INMPAISS_TableWindow_SerialLotInfoTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Manufacturer/Vendor Information").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPAISS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPAISS] Performing VerifyExists on TableWindow_SerialLotInfo_ManufacturerVendorInformation_Manufacturer_Manufacturer...", Logger.MessageType.INF);
				SeleniumControl INMPAISS_TableWindow_SerialLotInfo_ManufacturerVendorInformation_Manufacturer_Manufacturer = new SeleniumControl( sDriver, "TableWindow_SerialLotInfo_ManufacturerVendorInformation_Manufacturer_Manufacturer", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSRLT_']/ancestor::form[1]/descendant::*[@id='MANUF_ID']");
				Function.AssertEqual(true,INMPAISS_TableWindow_SerialLotInfo_ManufacturerVendorInformation_Manufacturer_Manufacturer.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPAISS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPAISS] Performing Select on TableWindow_SerialLotInfoTab...", Logger.MessageType.INF);
				SeleniumControl INMPAISS_TableWindow_SerialLotInfoTab = new SeleniumControl( sDriver, "TableWindow_SerialLotInfoTab", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSRLT_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(INMPAISS_TableWindow_SerialLotInfoTab);
IWebElement mTab = INMPAISS_TableWindow_SerialLotInfoTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Sales Order/Warranty Information").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPAISS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPAISS] Performing VerifyExists on TableWindow_SerialLotInfo_SalesOrderWarrantyInformation_SalesOrderInformation_SalesOrder...", Logger.MessageType.INF);
				SeleniumControl INMPAISS_TableWindow_SerialLotInfo_SalesOrderWarrantyInformation_SalesOrderInformation_SalesOrder = new SeleniumControl( sDriver, "TableWindow_SerialLotInfo_SalesOrderWarrantyInformation_SalesOrderInformation_SalesOrder", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSRLT_']/ancestor::form[1]/descendant::*[@id='MAINT_SO_ID']");
				Function.AssertEqual(true,INMPAISS_TableWindow_SerialLotInfo_SalesOrderWarrantyInformation_SalesOrderInformation_SalesOrder.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPAISS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPAISS] Performing Select on TableWindow_SerialLotInfoTab...", Logger.MessageType.INF);
				SeleniumControl INMPAISS_TableWindow_SerialLotInfoTab = new SeleniumControl( sDriver, "TableWindow_SerialLotInfoTab", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSRLT_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(INMPAISS_TableWindow_SerialLotInfoTab);
IWebElement mTab = INMPAISS_TableWindow_SerialLotInfoTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "User-Defined Info").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPAISS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPAISS] Performing VerifyExists on TableWindow_SerialLotInfo_UID_UIDDetails_UID...", Logger.MessageType.INF);
				SeleniumControl INMPAISS_TableWindow_SerialLotInfo_UID_UIDDetails_UID = new SeleniumControl( sDriver, "TableWindow_SerialLotInfo_UID_UIDDetails_UID", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSRLT_']/ancestor::form[1]/descendant::*[@id='UID_CD']");
				Function.AssertEqual(false,INMPAISS_TableWindow_SerialLotInfo_UID_UIDDetails_UID.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPAISS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPAISS] Performing Select on TableWindow_SerialLotInfoTab...", Logger.MessageType.INF);
				SeleniumControl INMPAISS_TableWindow_SerialLotInfoTab = new SeleniumControl( sDriver, "TableWindow_SerialLotInfoTab", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSRLT_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(INMPAISS_TableWindow_SerialLotInfoTab);
IWebElement mTab = INMPAISS_TableWindow_SerialLotInfoTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Notes").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPAISS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPAISS] Performing VerifyExists on TableWindow_SerialLotInfo_Notes_Notes...", Logger.MessageType.INF);
				SeleniumControl INMPAISS_TableWindow_SerialLotInfo_Notes_Notes = new SeleniumControl( sDriver, "TableWindow_SerialLotInfo_Notes_Notes", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSRLT_']/ancestor::form[1]/descendant::*[@id='NOTES_NT']");
				Function.AssertEqual(true,INMPAISS_TableWindow_SerialLotInfo_Notes_Notes.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPAISS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPAISS] Performing Select on TableWindow_SerialLotInfoTab...", Logger.MessageType.INF);
				SeleniumControl INMPAISS_TableWindow_SerialLotInfoTab = new SeleniumControl( sDriver, "TableWindow_SerialLotInfoTab", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSRLT_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(INMPAISS_TableWindow_SerialLotInfoTab);
IWebElement mTab = INMPAISS_TableWindow_SerialLotInfoTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Shelf Life").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPAISS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPAISS] Performing VerifyExists on ChildForm_SerialLotInfo_ShelfLife_ShelfLife_LastExtensionDate...", Logger.MessageType.INF);
				SeleniumControl INMPAISS_ChildForm_SerialLotInfo_ShelfLife_ShelfLife_LastExtensionDate = new SeleniumControl( sDriver, "ChildForm_SerialLotInfo_ShelfLife_ShelfLife_LastExtensionDate", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSRLT_']/ancestor::form[1]/descendant::*[@id='LAST_EXT_DT']");
				Function.AssertEqual(true,INMPAISS_ChildForm_SerialLotInfo_ShelfLife_ShelfLife_LastExtensionDate.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPAISS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPAISS] Performing Close on TableWindow_SerialLotInfoForm...", Logger.MessageType.INF);
				SeleniumControl INMPAISS_TableWindow_SerialLotInfoForm = new SeleniumControl( sDriver, "TableWindow_SerialLotInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSRLT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(INMPAISS_TableWindow_SerialLotInfoForm);
IWebElement formBttn = INMPAISS_TableWindow_SerialLotInfoForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Closing Main Form");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMPAISS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMPAISS] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl INMPAISS_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(INMPAISS_MainForm);
IWebElement formBttn = INMPAISS_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

