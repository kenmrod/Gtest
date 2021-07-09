 
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
    public class PCMMOISS_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Issues", "xpath","//div[@class='navItem'][.='Issues']").Click();
new SeleniumControl(sDriver,"Enter Manufacturing Order Issues", "xpath","//div[@class='navItem'][.='Enter Manufacturing Order Issues']").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SelectMenu]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOISS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOISS] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl PCMMOISS_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,PCMMOISS_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOISS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOISS] Performing VerifyExists on Warehouse...", Logger.MessageType.INF);
				SeleniumControl PCMMOISS_Warehouse = new SeleniumControl( sDriver, "Warehouse", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='WHSE_ID_FR']");
				Function.AssertEqual(true,PCMMOISS_Warehouse.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOISS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOISS] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl PCMMOISS_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PCMMOISS_MainForm);
IWebElement formBttn = PCMMOISS_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? PCMMOISS_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
PCMMOISS_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOISS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOISS] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl PCMMOISS_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PCMMOISS_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOISS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOISS] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl PCMMOISS_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PCMMOISS_MainForm);
IWebElement formBttn = PCMMOISS_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PCMMOISS_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PCMMOISS_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOISS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOISS] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl PCMMOISS_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,PCMMOISS_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOISS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOISS] Performing VerifyExists on Warehouse...", Logger.MessageType.INF);
				SeleniumControl PCMMOISS_Warehouse = new SeleniumControl( sDriver, "Warehouse", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='WHSE_ID_FR']");
				Function.AssertEqual(true,PCMMOISS_Warehouse.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
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
				Function.CurrentComponent = "PCMMOISS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOISS] Performing VerifyExists on AccountingPeriodLink...", Logger.MessageType.INF);
				SeleniumControl PCMMOISS_AccountingPeriodLink = new SeleniumControl( sDriver, "AccountingPeriodLink", "ID", "lnk_1004822_PCMMOISS_INVTTRN_HDR");
				Function.AssertEqual(true,PCMMOISS_AccountingPeriodLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOISS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOISS] Performing Click on AccountingPeriodLink...", Logger.MessageType.INF);
				SeleniumControl PCMMOISS_AccountingPeriodLink = new SeleniumControl( sDriver, "AccountingPeriodLink", "ID", "lnk_1004822_PCMMOISS_INVTTRN_HDR");
				Function.WaitControlDisplayed(PCMMOISS_AccountingPeriodLink);
PCMMOISS_AccountingPeriodLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOISS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOISS] Performing VerifyExists on AccountingPeriodForm...", Logger.MessageType.INF);
				SeleniumControl PCMMOISS_AccountingPeriodForm = new SeleniumControl( sDriver, "AccountingPeriodForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMACCPD_HDR_']/ancestor::form[1]");
				Function.AssertEqual(true,PCMMOISS_AccountingPeriodForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOISS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOISS] Performing VerifyExists on AccountingPeriod_FiscalYear...", Logger.MessageType.INF);
				SeleniumControl PCMMOISS_AccountingPeriod_FiscalYear = new SeleniumControl( sDriver, "AccountingPeriod_FiscalYear", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMACCPD_HDR_']/ancestor::form[1]/descendant::*[@id='DFS_FYCD_ST']");
				Function.AssertEqual(true,PCMMOISS_AccountingPeriod_FiscalYear.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOISS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOISS] Performing Close on AccountingPeriodForm...", Logger.MessageType.INF);
				SeleniumControl PCMMOISS_AccountingPeriodForm = new SeleniumControl( sDriver, "AccountingPeriodForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMACCPD_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCMMOISS_AccountingPeriodForm);
IWebElement formBttn = PCMMOISS_AccountingPeriodForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("check documents");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOISS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOISS] Performing VerifyExists on DocumentsLink...", Logger.MessageType.INF);
				SeleniumControl PCMMOISS_DocumentsLink = new SeleniumControl( sDriver, "DocumentsLink", "ID", "lnk_4598_PCMMOISS_INVTTRN_HDR");
				Function.AssertEqual(true,PCMMOISS_DocumentsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOISS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOISS] Performing Click on DocumentsLink...", Logger.MessageType.INF);
				SeleniumControl PCMMOISS_DocumentsLink = new SeleniumControl( sDriver, "DocumentsLink", "ID", "lnk_4598_PCMMOISS_INVTTRN_HDR");
				Function.WaitControlDisplayed(PCMMOISS_DocumentsLink);
PCMMOISS_DocumentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOISS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOISS] Performing VerifyExist on DocumentsTable...", Logger.MessageType.INF);
				SeleniumControl PCMMOISS_DocumentsTable = new SeleniumControl( sDriver, "DocumentsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PCM_MODOCUMENT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PCMMOISS_DocumentsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOISS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOISS] Performing ClickButton on DocumentsForm...", Logger.MessageType.INF);
				SeleniumControl PCMMOISS_DocumentsForm = new SeleniumControl( sDriver, "DocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCM_MODOCUMENT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCMMOISS_DocumentsForm);
IWebElement formBttn = PCMMOISS_DocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PCMMOISS_DocumentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PCMMOISS_DocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOISS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOISS] Performing VerifyExists on Documents_Document...", Logger.MessageType.INF);
				SeleniumControl PCMMOISS_Documents_Document = new SeleniumControl( sDriver, "Documents_Document", "xpath", "//div[translate(@id,'0123456789','')='pr__PCM_MODOCUMENT_']/ancestor::form[1]/descendant::*[@id='DOCUMENT_ID']");
				Function.AssertEqual(true,PCMMOISS_Documents_Document.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOISS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOISS] Performing VerifyExists on DocumentsForm...", Logger.MessageType.INF);
				SeleniumControl PCMMOISS_DocumentsForm = new SeleniumControl( sDriver, "DocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCM_MODOCUMENT_']/ancestor::form[1]");
				Function.AssertEqual(true,PCMMOISS_DocumentsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOISS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOISS] Performing Close on DocumentsForm...", Logger.MessageType.INF);
				SeleniumControl PCMMOISS_DocumentsForm = new SeleniumControl( sDriver, "DocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCM_MODOCUMENT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCMMOISS_DocumentsForm);
IWebElement formBttn = PCMMOISS_DocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
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
				Function.CurrentComponent = "PCMMOISS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOISS] Performing VerifyExist on TableWindowTable...", Logger.MessageType.INF);
				SeleniumControl PCMMOISS_TableWindowTable = new SeleniumControl( sDriver, "TableWindowTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMMOISS_INVTTRNLN_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PCMMOISS_TableWindowTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOISS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOISS] Performing ClickButton on TableWindowForm...", Logger.MessageType.INF);
				SeleniumControl PCMMOISS_TableWindowForm = new SeleniumControl( sDriver, "TableWindowForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMMOISS_INVTTRNLN_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCMMOISS_TableWindowForm);
IWebElement formBttn = PCMMOISS_TableWindowForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PCMMOISS_TableWindowForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PCMMOISS_TableWindowForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOISS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOISS] Performing VerifyExists on TableWindow_IssueLine...", Logger.MessageType.INF);
				SeleniumControl PCMMOISS_TableWindow_IssueLine = new SeleniumControl( sDriver, "TableWindow_IssueLine", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMMOISS_INVTTRNLN_CTW_']/ancestor::form[1]/descendant::*[@id='INVT_TRN_LN_NO']");
				Function.AssertEqual(true,PCMMOISS_TableWindow_IssueLine.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOISS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOISS] Performing VerifyExists on TableWindowForm...", Logger.MessageType.INF);
				SeleniumControl PCMMOISS_TableWindowForm = new SeleniumControl( sDriver, "TableWindowForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMMOISS_INVTTRNLN_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,PCMMOISS_TableWindowForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOISS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOISS] Performing ClickButton on TableWindowForm...", Logger.MessageType.INF);
				SeleniumControl PCMMOISS_TableWindowForm = new SeleniumControl( sDriver, "TableWindowForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMMOISS_INVTTRNLN_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCMMOISS_TableWindowForm);
IWebElement formBttn = PCMMOISS_TableWindowForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? PCMMOISS_TableWindowForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
PCMMOISS_TableWindowForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOISS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOISS] Performing VerifyExist on TableWindowTable...", Logger.MessageType.INF);
				SeleniumControl PCMMOISS_TableWindowTable = new SeleniumControl( sDriver, "TableWindowTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMMOISS_INVTTRNLN_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PCMMOISS_TableWindowTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOISS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOISS] Performing ClickButton on TableWindowForm...", Logger.MessageType.INF);
				SeleniumControl PCMMOISS_TableWindowForm = new SeleniumControl( sDriver, "TableWindowForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMMOISS_INVTTRNLN_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCMMOISS_TableWindowForm);
IWebElement formBttn = PCMMOISS_TableWindowForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PCMMOISS_TableWindowForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PCMMOISS_TableWindowForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOISS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOISS] Performing VerifyExists on TableWindowForm...", Logger.MessageType.INF);
				SeleniumControl PCMMOISS_TableWindowForm = new SeleniumControl( sDriver, "TableWindowForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMMOISS_INVTTRNLN_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,PCMMOISS_TableWindowForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOISS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOISS] Performing VerifyExists on TableWindow_IssueLine...", Logger.MessageType.INF);
				SeleniumControl PCMMOISS_TableWindow_IssueLine = new SeleniumControl( sDriver, "TableWindow_IssueLine", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMMOISS_INVTTRNLN_CTW_']/ancestor::form[1]/descendant::*[@id='INVT_TRN_LN_NO']");
				Function.AssertEqual(true,PCMMOISS_TableWindow_IssueLine.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Check MO Issue Operations");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOISS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOISS] Performing VerifyExists on TableWindow_MOIssueOperationsLink...", Logger.MessageType.INF);
				SeleniumControl PCMMOISS_TableWindow_MOIssueOperationsLink = new SeleniumControl( sDriver, "TableWindow_MOIssueOperationsLink", "ID", "lnk_16357_PCMMOISS_INVTTRNLN_CTW");
				Function.AssertEqual(true,PCMMOISS_TableWindow_MOIssueOperationsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOISS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOISS] Performing Click on TableWindow_MOIssueOperationsLink...", Logger.MessageType.INF);
				SeleniumControl PCMMOISS_TableWindow_MOIssueOperationsLink = new SeleniumControl( sDriver, "TableWindow_MOIssueOperationsLink", "ID", "lnk_16357_PCMMOISS_INVTTRNLN_CTW");
				Function.WaitControlDisplayed(PCMMOISS_TableWindow_MOIssueOperationsLink);
PCMMOISS_TableWindow_MOIssueOperationsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOISS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOISS] Performing VerifyExist on TableWindow_MOIssueOperationsTable...", Logger.MessageType.INF);
				SeleniumControl PCMMOISS_TableWindow_MOIssueOperationsTable = new SeleniumControl( sDriver, "TableWindow_MOIssueOperationsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMMOISS_INVTTRNLN_OPER_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PCMMOISS_TableWindow_MOIssueOperationsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOISS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOISS] Performing ClickButton on TableWindow_MOIssueOperationsForm...", Logger.MessageType.INF);
				SeleniumControl PCMMOISS_TableWindow_MOIssueOperationsForm = new SeleniumControl( sDriver, "TableWindow_MOIssueOperationsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMMOISS_INVTTRNLN_OPER_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCMMOISS_TableWindow_MOIssueOperationsForm);
IWebElement formBttn = PCMMOISS_TableWindow_MOIssueOperationsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PCMMOISS_TableWindow_MOIssueOperationsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PCMMOISS_TableWindow_MOIssueOperationsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOISS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOISS] Performing VerifyExists on TableWindow_MOIssueOperationsForm...", Logger.MessageType.INF);
				SeleniumControl PCMMOISS_TableWindow_MOIssueOperationsForm = new SeleniumControl( sDriver, "TableWindow_MOIssueOperationsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMMOISS_INVTTRNLN_OPER_']/ancestor::form[1]");
				Function.AssertEqual(true,PCMMOISS_TableWindow_MOIssueOperationsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOISS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOISS] Performing VerifyExists on TableWindow_MOIssueOperations_OperationSeq...", Logger.MessageType.INF);
				SeleniumControl PCMMOISS_TableWindow_MOIssueOperations_OperationSeq = new SeleniumControl( sDriver, "TableWindow_MOIssueOperations_OperationSeq", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMMOISS_INVTTRNLN_OPER_']/ancestor::form[1]/descendant::*[@id='MO_OPER_SEQ_NO']");
				Function.AssertEqual(true,PCMMOISS_TableWindow_MOIssueOperations_OperationSeq.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOISS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOISS] Performing ClickButton on TableWindow_MOIssueOperationsForm...", Logger.MessageType.INF);
				SeleniumControl PCMMOISS_TableWindow_MOIssueOperationsForm = new SeleniumControl( sDriver, "TableWindow_MOIssueOperationsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMMOISS_INVTTRNLN_OPER_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCMMOISS_TableWindow_MOIssueOperationsForm);
IWebElement formBttn = PCMMOISS_TableWindow_MOIssueOperationsForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? PCMMOISS_TableWindow_MOIssueOperationsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
PCMMOISS_TableWindow_MOIssueOperationsForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOISS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOISS] Performing VerifyExist on TableWindow_MOIssueOperationsTable...", Logger.MessageType.INF);
				SeleniumControl PCMMOISS_TableWindow_MOIssueOperationsTable = new SeleniumControl( sDriver, "TableWindow_MOIssueOperationsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMMOISS_INVTTRNLN_OPER_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PCMMOISS_TableWindow_MOIssueOperationsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOISS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOISS] Performing Close on TableWindow_MOIssueOperationsForm...", Logger.MessageType.INF);
				SeleniumControl PCMMOISS_TableWindow_MOIssueOperationsForm = new SeleniumControl( sDriver, "TableWindow_MOIssueOperationsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMMOISS_INVTTRNLN_OPER_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCMMOISS_TableWindow_MOIssueOperationsForm);
IWebElement formBttn = PCMMOISS_TableWindow_MOIssueOperationsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Check substitute parts");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOISS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOISS] Performing VerifyExists on TableWindow_SubstitutePartsLink...", Logger.MessageType.INF);
				SeleniumControl PCMMOISS_TableWindow_SubstitutePartsLink = new SeleniumControl( sDriver, "TableWindow_SubstitutePartsLink", "ID", "lnk_4706_PCMMOISS_INVTTRNLN_CTW");
				Function.AssertEqual(true,PCMMOISS_TableWindow_SubstitutePartsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOISS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOISS] Performing Click on TableWindow_SubstitutePartsLink...", Logger.MessageType.INF);
				SeleniumControl PCMMOISS_TableWindow_SubstitutePartsLink = new SeleniumControl( sDriver, "TableWindow_SubstitutePartsLink", "ID", "lnk_4706_PCMMOISS_INVTTRNLN_CTW");
				Function.WaitControlDisplayed(PCMMOISS_TableWindow_SubstitutePartsLink);
PCMMOISS_TableWindow_SubstitutePartsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOISS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOISS] Performing VerifyExist on SubstitutePartsTable...", Logger.MessageType.INF);
				SeleniumControl PCMMOISS_SubstitutePartsTable = new SeleniumControl( sDriver, "SubstitutePartsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMM_PROJSUBSTPART_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PCMMOISS_SubstitutePartsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOISS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOISS] Performing Close on SubstitutePartsForm...", Logger.MessageType.INF);
				SeleniumControl PCMMOISS_SubstitutePartsForm = new SeleniumControl( sDriver, "SubstitutePartsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMM_PROJSUBSTPART_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCMMOISS_SubstitutePartsForm);
IWebElement formBttn = PCMMOISS_SubstitutePartsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Check serial lot");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOISS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOISS] Performing VerifyExists on TableWindow_SerialLotInfoLink...", Logger.MessageType.INF);
				SeleniumControl PCMMOISS_TableWindow_SerialLotInfoLink = new SeleniumControl( sDriver, "TableWindow_SerialLotInfoLink", "ID", "lnk_4786_PCMMOISS_INVTTRNLN_CTW");
				Function.AssertEqual(true,PCMMOISS_TableWindow_SerialLotInfoLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOISS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOISS] Performing Click on TableWindow_SerialLotInfoLink...", Logger.MessageType.INF);
				SeleniumControl PCMMOISS_TableWindow_SerialLotInfoLink = new SeleniumControl( sDriver, "TableWindow_SerialLotInfoLink", "ID", "lnk_4786_PCMMOISS_INVTTRNLN_CTW");
				Function.WaitControlDisplayed(PCMMOISS_TableWindow_SerialLotInfoLink);
PCMMOISS_TableWindow_SerialLotInfoLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOISS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOISS] Performing VerifyExist on TableWindow_SerialLotInfoTable...", Logger.MessageType.INF);
				SeleniumControl PCMMOISS_TableWindow_SerialLotInfoTable = new SeleniumControl( sDriver, "TableWindow_SerialLotInfoTable", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSRLT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PCMMOISS_TableWindow_SerialLotInfoTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOISS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOISS] Performing ClickButton on TableWindow_SerialLotInfoForm...", Logger.MessageType.INF);
				SeleniumControl PCMMOISS_TableWindow_SerialLotInfoForm = new SeleniumControl( sDriver, "TableWindow_SerialLotInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSRLT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCMMOISS_TableWindow_SerialLotInfoForm);
IWebElement formBttn = PCMMOISS_TableWindow_SerialLotInfoForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PCMMOISS_TableWindow_SerialLotInfoForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PCMMOISS_TableWindow_SerialLotInfoForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOISS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOISS] Performing VerifyExists on TableWindow_SerialLotInfoForm...", Logger.MessageType.INF);
				SeleniumControl PCMMOISS_TableWindow_SerialLotInfoForm = new SeleniumControl( sDriver, "TableWindow_SerialLotInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSRLT_']/ancestor::form[1]");
				Function.AssertEqual(true,PCMMOISS_TableWindow_SerialLotInfoForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOISS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOISS] Performing VerifyExists on TableWindow_SerialLotInfo_LotNumber...", Logger.MessageType.INF);
				SeleniumControl PCMMOISS_TableWindow_SerialLotInfo_LotNumber = new SeleniumControl( sDriver, "TableWindow_SerialLotInfo_LotNumber", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSRLT_']/ancestor::form[1]/descendant::*[@id='LOT_ID']");
				Function.AssertEqual(true,PCMMOISS_TableWindow_SerialLotInfo_LotNumber.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOISS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOISS] Performing Select on TableWindow_SerialLotInfoTab...", Logger.MessageType.INF);
				SeleniumControl PCMMOISS_TableWindow_SerialLotInfoTab = new SeleniumControl( sDriver, "TableWindow_SerialLotInfoTab", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSRLT_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PCMMOISS_TableWindow_SerialLotInfoTab);
IWebElement mTab = PCMMOISS_TableWindow_SerialLotInfoTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Shelf Life").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOISS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOISS] Performing VerifyExists on TableWindow_SerialLotInfo_ShelfLife_ShelfLife_ShelfLifeType...", Logger.MessageType.INF);
				SeleniumControl PCMMOISS_TableWindow_SerialLotInfo_ShelfLife_ShelfLife_ShelfLifeType = new SeleniumControl( sDriver, "TableWindow_SerialLotInfo_ShelfLife_ShelfLife_ShelfLifeType", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSRLT_']/ancestor::form[1]/descendant::*[@id='S_SHELF_LIFE_TYPE']");
				Function.AssertEqual(true,PCMMOISS_TableWindow_SerialLotInfo_ShelfLife_ShelfLife_ShelfLifeType.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOISS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOISS] Performing ClickButton on TableWindow_SerialLotInfoForm...", Logger.MessageType.INF);
				SeleniumControl PCMMOISS_TableWindow_SerialLotInfoForm = new SeleniumControl( sDriver, "TableWindow_SerialLotInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSRLT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCMMOISS_TableWindow_SerialLotInfoForm);
IWebElement formBttn = PCMMOISS_TableWindow_SerialLotInfoForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? PCMMOISS_TableWindow_SerialLotInfoForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
PCMMOISS_TableWindow_SerialLotInfoForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOISS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOISS] Performing VerifyExist on TableWindow_SerialLotInfoTable...", Logger.MessageType.INF);
				SeleniumControl PCMMOISS_TableWindow_SerialLotInfoTable = new SeleniumControl( sDriver, "TableWindow_SerialLotInfoTable", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSRLT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PCMMOISS_TableWindow_SerialLotInfoTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOISS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOISS] Performing Close on TableWindow_SerialLotInfoForm...", Logger.MessageType.INF);
				SeleniumControl PCMMOISS_TableWindow_SerialLotInfoForm = new SeleniumControl( sDriver, "TableWindow_SerialLotInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSRLT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCMMOISS_TableWindow_SerialLotInfoForm);
IWebElement formBttn = PCMMOISS_TableWindow_SerialLotInfoForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMMOISS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMMOISS] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl PCMMOISS_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PCMMOISS_MainForm);
IWebElement formBttn = PCMMOISS_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

