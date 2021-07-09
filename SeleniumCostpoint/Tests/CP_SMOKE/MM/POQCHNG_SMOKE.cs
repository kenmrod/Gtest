 
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
    public class POQCHNG_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Purchasing", "xpath","//div[@class='deptItem'][.='Purchasing']").Click();
new SeleniumControl(sDriver,"Purchasing Reports/Inquiries", "xpath","//div[@class='navItem'][.='Purchasing Reports/Inquiries']").Click();
new SeleniumControl(sDriver,"View Purchase Order Change Orders", "xpath","//div[@class='navItem'][.='View Purchase Order Change Orders']").Click();


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
				Function.CurrentComponent = "POQCHNG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQCHNG] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl POQCHNG_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,POQCHNG_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQCHNG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQCHNG] Performing VerifyExists on PO...", Logger.MessageType.INF);
				SeleniumControl POQCHNG_PO = new SeleniumControl( sDriver, "PO", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PO_ID']");
				Function.AssertEqual(true,POQCHNG_PO.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("SET DATA");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQCHNG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQCHNG] Performing Set on PO...", Logger.MessageType.INF);
				SeleniumControl POQCHNG_PO = new SeleniumControl( sDriver, "PO", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PO_ID']");
				POQCHNG_PO.Click();
POQCHNG_PO.SendKeys("16701", true);
Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));
POQCHNG_PO.SendKeys(OpenQA.Selenium.Keys.Shift + OpenQA.Selenium.Keys.Tab);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Set]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQCHNG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQCHNG] Performing Set on Release...", Logger.MessageType.INF);
				SeleniumControl POQCHNG_Release = new SeleniumControl( sDriver, "Release", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PO_RLSE_NO']");
				POQCHNG_Release.Click();
POQCHNG_Release.SendKeys("0", true);
Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));
POQCHNG_Release.SendKeys(OpenQA.Selenium.Keys.Shift + OpenQA.Selenium.Keys.Tab);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Set]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "CP7Main";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[CP7Main] Performing ClickToolbarButton on MainToolBar...", Logger.MessageType.INF);
				SeleniumControl CP7Main_MainToolBar = new SeleniumControl( sDriver, "MainToolBar", "ID", "tlbr");
				Function.WaitControlDisplayed(CP7Main_MainToolBar);
IWebElement tlbrBtn = CP7Main_MainToolBar.mElement.FindElements(By.XPath(".//*[@class='tbBtnContainer']//div[contains(@title,'Execute')]")).FirstOrDefault();
if (tlbrBtn==null) throw new Exception("Unable to find button Execute.");
tlbrBtn.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickToolbarButton]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("CHILD FORM - CURRENT CHANGE ORDER FORM");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQCHNG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQCHNG] Performing VerifyExists on CurrentChangeOrderForm...", Logger.MessageType.INF);
				SeleniumControl POQCHNG_CurrentChangeOrderForm = new SeleniumControl( sDriver, "CurrentChangeOrderForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POQCHNG_POHDR_HDR_']/ancestor::form[1]");
				Function.AssertEqual(true,POQCHNG_CurrentChangeOrderForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQCHNG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQCHNG] Performing VerifyExists on CurrentChangeOrder_ChangeOrder...", Logger.MessageType.INF);
				SeleniumControl POQCHNG_CurrentChangeOrder_ChangeOrder = new SeleniumControl( sDriver, "CurrentChangeOrder_ChangeOrder", "xpath", "//div[translate(@id,'0123456789','')='pr__POQCHNG_POHDR_HDR_']/ancestor::form[1]/descendant::*[@id='PO_CHNG_ORD_NO']");
				Function.AssertEqual(true,POQCHNG_CurrentChangeOrder_ChangeOrder.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("HEADERDOCUMENTS LINKS");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQCHNG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQCHNG] Performing VerifyExists on CurrentChangeOrder_HeaderDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl POQCHNG_CurrentChangeOrder_HeaderDocumentsLink = new SeleniumControl( sDriver, "CurrentChangeOrder_HeaderDocumentsLink", "ID", "lnk_1007742_POQCHNG_POHDR_HDR");
				Function.AssertEqual(true,POQCHNG_CurrentChangeOrder_HeaderDocumentsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQCHNG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQCHNG] Performing Click on CurrentChangeOrder_HeaderDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl POQCHNG_CurrentChangeOrder_HeaderDocumentsLink = new SeleniumControl( sDriver, "CurrentChangeOrder_HeaderDocumentsLink", "ID", "lnk_1007742_POQCHNG_POHDR_HDR");
				Function.WaitControlDisplayed(POQCHNG_CurrentChangeOrder_HeaderDocumentsLink);
POQCHNG_CurrentChangeOrder_HeaderDocumentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQCHNG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQCHNG] Performing VerifyExist on CurrentChangeOrder_HeaderDocumentsTable...", Logger.MessageType.INF);
				SeleniumControl POQCHNG_CurrentChangeOrder_HeaderDocumentsTable = new SeleniumControl( sDriver, "CurrentChangeOrder_HeaderDocumentsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__POM_PODOCUMENT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,POQCHNG_CurrentChangeOrder_HeaderDocumentsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQCHNG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQCHNG] Performing ClickButton on CurrentChangeOrder_HeaderDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl POQCHNG_CurrentChangeOrder_HeaderDocumentsForm = new SeleniumControl( sDriver, "CurrentChangeOrder_HeaderDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POM_PODOCUMENT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POQCHNG_CurrentChangeOrder_HeaderDocumentsForm);
IWebElement formBttn = POQCHNG_CurrentChangeOrder_HeaderDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? POQCHNG_CurrentChangeOrder_HeaderDocumentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
POQCHNG_CurrentChangeOrder_HeaderDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQCHNG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQCHNG] Performing VerifyExists on CurrentChangeOrder_HeaderDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl POQCHNG_CurrentChangeOrder_HeaderDocumentsForm = new SeleniumControl( sDriver, "CurrentChangeOrder_HeaderDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POM_PODOCUMENT_']/ancestor::form[1]");
				Function.AssertEqual(true,POQCHNG_CurrentChangeOrder_HeaderDocumentsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQCHNG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQCHNG] Performing VerifyExists on CurrentChangeOrder_HeaderDocuments_Document...", Logger.MessageType.INF);
				SeleniumControl POQCHNG_CurrentChangeOrder_HeaderDocuments_Document = new SeleniumControl( sDriver, "CurrentChangeOrder_HeaderDocuments_Document", "xpath", "//div[translate(@id,'0123456789','')='pr__POM_PODOCUMENT_']/ancestor::form[1]/descendant::*[@id='DOCUMENT_ID']");
				Function.AssertEqual(true,POQCHNG_CurrentChangeOrder_HeaderDocuments_Document.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQCHNG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQCHNG] Performing Close on CurrentChangeOrder_HeaderDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl POQCHNG_CurrentChangeOrder_HeaderDocumentsForm = new SeleniumControl( sDriver, "CurrentChangeOrder_HeaderDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POM_PODOCUMENT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POQCHNG_CurrentChangeOrder_HeaderDocumentsForm);
IWebElement formBttn = POQCHNG_CurrentChangeOrder_HeaderDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("CURRENTCOLINE FORM");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQCHNG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQCHNG] Performing VerifyExists on CurrentChangeOrder_CurrentCOLineLink...", Logger.MessageType.INF);
				SeleniumControl POQCHNG_CurrentChangeOrder_CurrentCOLineLink = new SeleniumControl( sDriver, "CurrentChangeOrder_CurrentCOLineLink", "ID", "lnk_2672_POQCHNG_POHDR_HDR");
				Function.AssertEqual(true,POQCHNG_CurrentChangeOrder_CurrentCOLineLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQCHNG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQCHNG] Performing Click on CurrentChangeOrder_CurrentCOLineLink...", Logger.MessageType.INF);
				SeleniumControl POQCHNG_CurrentChangeOrder_CurrentCOLineLink = new SeleniumControl( sDriver, "CurrentChangeOrder_CurrentCOLineLink", "ID", "lnk_2672_POQCHNG_POHDR_HDR");
				Function.WaitControlDisplayed(POQCHNG_CurrentChangeOrder_CurrentCOLineLink);
POQCHNG_CurrentChangeOrder_CurrentCOLineLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQCHNG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQCHNG] Performing VerifyExist on CurrentChangeOrder_CurrentCOLineTable...", Logger.MessageType.INF);
				SeleniumControl POQCHNG_CurrentChangeOrder_CurrentCOLineTable = new SeleniumControl( sDriver, "CurrentChangeOrder_CurrentCOLineTable", "xpath", "//div[translate(@id,'0123456789','')='pr__POQCHNG_POLN_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,POQCHNG_CurrentChangeOrder_CurrentCOLineTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQCHNG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQCHNG] Performing ClickButton on CurrentChangeOrder_CurrentCOLineForm...", Logger.MessageType.INF);
				SeleniumControl POQCHNG_CurrentChangeOrder_CurrentCOLineForm = new SeleniumControl( sDriver, "CurrentChangeOrder_CurrentCOLineForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POQCHNG_POLN_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POQCHNG_CurrentChangeOrder_CurrentCOLineForm);
IWebElement formBttn = POQCHNG_CurrentChangeOrder_CurrentCOLineForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? POQCHNG_CurrentChangeOrder_CurrentCOLineForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
POQCHNG_CurrentChangeOrder_CurrentCOLineForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQCHNG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQCHNG] Performing VerifyExists on CurrentChangeOrder_CurrentCOLineForm...", Logger.MessageType.INF);
				SeleniumControl POQCHNG_CurrentChangeOrder_CurrentCOLineForm = new SeleniumControl( sDriver, "CurrentChangeOrder_CurrentCOLineForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POQCHNG_POLN_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,POQCHNG_CurrentChangeOrder_CurrentCOLineForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("CURRENTCOLINE TAB");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQCHNG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQCHNG] Performing VerifyExists on CurrentChangeOrder_CurrentCOLine_LineDetail_Line...", Logger.MessageType.INF);
				SeleniumControl POQCHNG_CurrentChangeOrder_CurrentCOLine_LineDetail_Line = new SeleniumControl( sDriver, "CurrentChangeOrder_CurrentCOLine_LineDetail_Line", "xpath", "//div[translate(@id,'0123456789','')='pr__POQCHNG_POLN_CTW_']/ancestor::form[1]/descendant::*[@id='PO_LN_NO']");
				Function.AssertEqual(true,POQCHNG_CurrentChangeOrder_CurrentCOLine_LineDetail_Line.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQCHNG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQCHNG] Performing Select on CurrentChangeOrder_CurrentCOLine_Tab...", Logger.MessageType.INF);
				SeleniumControl POQCHNG_CurrentChangeOrder_CurrentCOLine_Tab = new SeleniumControl( sDriver, "CurrentChangeOrder_CurrentCOLine_Tab", "xpath", "//div[translate(@id,'0123456789','')='pr__POQCHNG_POLN_CTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(POQCHNG_CurrentChangeOrder_CurrentCOLine_Tab);
IWebElement mTab = POQCHNG_CurrentChangeOrder_CurrentCOLine_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Other Info").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQCHNG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQCHNG] Performing VerifyExists on CurrentChangeOrder_CurrentCOLine_OtherInfo_OrderReference...", Logger.MessageType.INF);
				SeleniumControl POQCHNG_CurrentChangeOrder_CurrentCOLine_OtherInfo_OrderReference = new SeleniumControl( sDriver, "CurrentChangeOrder_CurrentCOLine_OtherInfo_OrderReference", "xpath", "//div[translate(@id,'0123456789','')='pr__POQCHNG_POLN_CTW_']/ancestor::form[1]/descendant::*[@id='ORDER_REF_ID']");
				Function.AssertEqual(true,POQCHNG_CurrentChangeOrder_CurrentCOLine_OtherInfo_OrderReference.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQCHNG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQCHNG] Performing Select on CurrentChangeOrder_CurrentCOLine_Tab...", Logger.MessageType.INF);
				SeleniumControl POQCHNG_CurrentChangeOrder_CurrentCOLine_Tab = new SeleniumControl( sDriver, "CurrentChangeOrder_CurrentCOLine_Tab", "xpath", "//div[translate(@id,'0123456789','')='pr__POQCHNG_POLN_CTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(POQCHNG_CurrentChangeOrder_CurrentCOLine_Tab);
IWebElement mTab = POQCHNG_CurrentChangeOrder_CurrentCOLine_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Cost Info").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQCHNG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQCHNG] Performing VerifyExists on CurrentChangeOrder_CurrentCOLine_CostInfo_GrossUnitCost...", Logger.MessageType.INF);
				SeleniumControl POQCHNG_CurrentChangeOrder_CurrentCOLine_CostInfo_GrossUnitCost = new SeleniumControl( sDriver, "CurrentChangeOrder_CurrentCOLine_CostInfo_GrossUnitCost", "xpath", "//div[translate(@id,'0123456789','')='pr__POQCHNG_POLN_CTW_']/ancestor::form[1]/descendant::*[@id='TRN_GR_UN_CST_AMT']");
				Function.AssertEqual(true,POQCHNG_CurrentChangeOrder_CurrentCOLine_CostInfo_GrossUnitCost.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQCHNG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQCHNG] Performing Select on CurrentChangeOrder_CurrentCOLine_Tab...", Logger.MessageType.INF);
				SeleniumControl POQCHNG_CurrentChangeOrder_CurrentCOLine_Tab = new SeleniumControl( sDriver, "CurrentChangeOrder_CurrentCOLine_Tab", "xpath", "//div[translate(@id,'0123456789','')='pr__POQCHNG_POLN_CTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(POQCHNG_CurrentChangeOrder_CurrentCOLine_Tab);
IWebElement mTab = POQCHNG_CurrentChangeOrder_CurrentCOLine_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Notes").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQCHNG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQCHNG] Performing VerifyExists on CurrentChangeOrder_CurrentCOLine_Notes_LineNotes_LineNotes...", Logger.MessageType.INF);
				SeleniumControl POQCHNG_CurrentChangeOrder_CurrentCOLine_Notes_LineNotes_LineNotes = new SeleniumControl( sDriver, "CurrentChangeOrder_CurrentCOLine_Notes_LineNotes_LineNotes", "xpath", "//div[translate(@id,'0123456789','')='pr__POQCHNG_POLN_CTW_']/ancestor::form[1]/descendant::*[@id='PO_LN_TX']");
				Function.AssertEqual(true,POQCHNG_CurrentChangeOrder_CurrentCOLine_Notes_LineNotes_LineNotes.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQCHNG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQCHNG] Performing Close on CurrentChangeOrder_CurrentCOLineForm...", Logger.MessageType.INF);
				SeleniumControl POQCHNG_CurrentChangeOrder_CurrentCOLineForm = new SeleniumControl( sDriver, "CurrentChangeOrder_CurrentCOLineForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POQCHNG_POLN_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POQCHNG_CurrentChangeOrder_CurrentCOLineForm);
IWebElement formBttn = POQCHNG_CurrentChangeOrder_CurrentCOLineForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("CURRENTCOLINE OLDCHANGEORDER FORM FORMTABLE");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQCHNG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQCHNG] Performing VerifyExist on CurrentChangeOrder_CurrentCOLine_OldChangeOrderTable...", Logger.MessageType.INF);
				SeleniumControl POQCHNG_CurrentChangeOrder_CurrentCOLine_OldChangeOrderTable = new SeleniumControl( sDriver, "CurrentChangeOrder_CurrentCOLine_OldChangeOrderTable", "xpath", "//div[translate(@id,'0123456789','')='pr__POQCHNG_POHDRCHNG_CHLD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,POQCHNG_CurrentChangeOrder_CurrentCOLine_OldChangeOrderTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQCHNG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQCHNG] Performing ClickButton on CurrentChangeOrder_CurrentCOLine_OldChangeOrderForm...", Logger.MessageType.INF);
				SeleniumControl POQCHNG_CurrentChangeOrder_CurrentCOLine_OldChangeOrderForm = new SeleniumControl( sDriver, "CurrentChangeOrder_CurrentCOLine_OldChangeOrderForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POQCHNG_POHDRCHNG_CHLD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POQCHNG_CurrentChangeOrder_CurrentCOLine_OldChangeOrderForm);
IWebElement formBttn = POQCHNG_CurrentChangeOrder_CurrentCOLine_OldChangeOrderForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? POQCHNG_CurrentChangeOrder_CurrentCOLine_OldChangeOrderForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
POQCHNG_CurrentChangeOrder_CurrentCOLine_OldChangeOrderForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQCHNG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQCHNG] Performing VerifyExists on CurrentChangeOrder_CurrentCOLine_OldChangeOrderForm...", Logger.MessageType.INF);
				SeleniumControl POQCHNG_CurrentChangeOrder_CurrentCOLine_OldChangeOrderForm = new SeleniumControl( sDriver, "CurrentChangeOrder_CurrentCOLine_OldChangeOrderForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POQCHNG_POHDRCHNG_CHLD_']/ancestor::form[1]");
				Function.AssertEqual(true,POQCHNG_CurrentChangeOrder_CurrentCOLine_OldChangeOrderForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("CURRENTCOLINE OLDCHANGEORDER TAB");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQCHNG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQCHNG] Performing VerifyExists on CurrentChangeOrder_OldChangeOrder_Header_ChangeOrder...", Logger.MessageType.INF);
				SeleniumControl POQCHNG_CurrentChangeOrder_OldChangeOrder_Header_ChangeOrder = new SeleniumControl( sDriver, "CurrentChangeOrder_OldChangeOrder_Header_ChangeOrder", "xpath", "//div[translate(@id,'0123456789','')='pr__POQCHNG_POHDRCHNG_CHLD_']/ancestor::form[1]/descendant::*[@id='PO_CHNG_ORD_NO']");
				Function.AssertEqual(true,POQCHNG_CurrentChangeOrder_OldChangeOrder_Header_ChangeOrder.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQCHNG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQCHNG] Performing Select on CurrentChangeOrder_OldChangeOrder_Tab...", Logger.MessageType.INF);
				SeleniumControl POQCHNG_CurrentChangeOrder_OldChangeOrder_Tab = new SeleniumControl( sDriver, "CurrentChangeOrder_OldChangeOrder_Tab", "xpath", "//div[translate(@id,'0123456789','')='pr__POQCHNG_POHDRCHNG_CHLD_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(POQCHNG_CurrentChangeOrder_OldChangeOrder_Tab);
IWebElement mTab = POQCHNG_CurrentChangeOrder_OldChangeOrder_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Details").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQCHNG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQCHNG] Performing VerifyExists on CurrentChangeOrder_OldChangeOrder_Details_VendorContact_LastName...", Logger.MessageType.INF);
				SeleniumControl POQCHNG_CurrentChangeOrder_OldChangeOrder_Details_VendorContact_LastName = new SeleniumControl( sDriver, "CurrentChangeOrder_OldChangeOrder_Details_VendorContact_LastName", "xpath", "//div[translate(@id,'0123456789','')='pr__POQCHNG_POHDRCHNG_CHLD_']/ancestor::form[1]/descendant::*[@id='CNTACT_LAST_NAME']");
				Function.AssertEqual(true,POQCHNG_CurrentChangeOrder_OldChangeOrder_Details_VendorContact_LastName.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQCHNG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQCHNG] Performing Select on CurrentChangeOrder_OldChangeOrder_Tab...", Logger.MessageType.INF);
				SeleniumControl POQCHNG_CurrentChangeOrder_OldChangeOrder_Tab = new SeleniumControl( sDriver, "CurrentChangeOrder_OldChangeOrder_Tab", "xpath", "//div[translate(@id,'0123456789','')='pr__POQCHNG_POHDRCHNG_CHLD_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(POQCHNG_CurrentChangeOrder_OldChangeOrder_Tab);
IWebElement mTab = POQCHNG_CurrentChangeOrder_OldChangeOrder_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Notes").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("CURRENTCOLINE OLDCHANGEORDER OLD CO LINE LINK");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQCHNG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQCHNG] Performing VerifyExists on CurrentChangeOrder_OldChangeOrder_OldCOLineLink...", Logger.MessageType.INF);
				SeleniumControl POQCHNG_CurrentChangeOrder_OldChangeOrder_OldCOLineLink = new SeleniumControl( sDriver, "CurrentChangeOrder_OldChangeOrder_OldCOLineLink", "ID", "lnk_2661_POQCHNG_POHDRCHNG_CHLD");
				Function.AssertEqual(true,POQCHNG_CurrentChangeOrder_OldChangeOrder_OldCOLineLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQCHNG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQCHNG] Performing Click on CurrentChangeOrder_OldChangeOrder_OldCOLineLink...", Logger.MessageType.INF);
				SeleniumControl POQCHNG_CurrentChangeOrder_OldChangeOrder_OldCOLineLink = new SeleniumControl( sDriver, "CurrentChangeOrder_OldChangeOrder_OldCOLineLink", "ID", "lnk_2661_POQCHNG_POHDRCHNG_CHLD");
				Function.WaitControlDisplayed(POQCHNG_CurrentChangeOrder_OldChangeOrder_OldCOLineLink);
POQCHNG_CurrentChangeOrder_OldChangeOrder_OldCOLineLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQCHNG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQCHNG] Performing VerifyExist on CurrentChangeOrder_OldChangeOrder_OldCOLineTable...", Logger.MessageType.INF);
				SeleniumControl POQCHNG_CurrentChangeOrder_OldChangeOrder_OldCOLineTable = new SeleniumControl( sDriver, "CurrentChangeOrder_OldChangeOrder_OldCOLineTable", "xpath", "//div[translate(@id,'0123456789','')='pr__POQCHNG_POLNCHNG_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,POQCHNG_CurrentChangeOrder_OldChangeOrder_OldCOLineTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQCHNG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQCHNG] Performing ClickButton on CurrentChangeOrder_OldChangeOrder_OldCOLine...", Logger.MessageType.INF);
				SeleniumControl POQCHNG_CurrentChangeOrder_OldChangeOrder_OldCOLine = new SeleniumControl( sDriver, "CurrentChangeOrder_OldChangeOrder_OldCOLine", "xpath", "//div[translate(@id,'0123456789','')='pr__POQCHNG_POLNCHNG_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POQCHNG_CurrentChangeOrder_OldChangeOrder_OldCOLine);
IWebElement formBttn = POQCHNG_CurrentChangeOrder_OldChangeOrder_OldCOLine.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? POQCHNG_CurrentChangeOrder_OldChangeOrder_OldCOLine.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
POQCHNG_CurrentChangeOrder_OldChangeOrder_OldCOLine.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQCHNG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQCHNG] Performing VerifyExists on CurrentChangeOrder_OldChangeOrder_OldCOLine...", Logger.MessageType.INF);
				SeleniumControl POQCHNG_CurrentChangeOrder_OldChangeOrder_OldCOLine = new SeleniumControl( sDriver, "CurrentChangeOrder_OldChangeOrder_OldCOLine", "xpath", "//div[translate(@id,'0123456789','')='pr__POQCHNG_POLNCHNG_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,POQCHNG_CurrentChangeOrder_OldChangeOrder_OldCOLine.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("CURRENTCOLINE OLDCHANGEORDER OLD CO LINE TAB");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQCHNG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQCHNG] Performing VerifyExists on CurrentChangeOrder_OldChangeOrder_OldCOLine_LineDetail_Line...", Logger.MessageType.INF);
				SeleniumControl POQCHNG_CurrentChangeOrder_OldChangeOrder_OldCOLine_LineDetail_Line = new SeleniumControl( sDriver, "CurrentChangeOrder_OldChangeOrder_OldCOLine_LineDetail_Line", "xpath", "//div[translate(@id,'0123456789','')='pr__POQCHNG_POLNCHNG_CTW_']/ancestor::form[1]/descendant::*[@id='PO_LN_NO']");
				Function.AssertEqual(true,POQCHNG_CurrentChangeOrder_OldChangeOrder_OldCOLine_LineDetail_Line.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQCHNG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQCHNG] Performing Select on CurrentChangeOrder_OldChangeOrder_OldCOLine_Tab...", Logger.MessageType.INF);
				SeleniumControl POQCHNG_CurrentChangeOrder_OldChangeOrder_OldCOLine_Tab = new SeleniumControl( sDriver, "CurrentChangeOrder_OldChangeOrder_OldCOLine_Tab", "xpath", "//div[translate(@id,'0123456789','')='pr__POQCHNG_POLNCHNG_CTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(POQCHNG_CurrentChangeOrder_OldChangeOrder_OldCOLine_Tab);
IWebElement mTab = POQCHNG_CurrentChangeOrder_OldChangeOrder_OldCOLine_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Other Info").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQCHNG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQCHNG] Performing VerifyExists on CurrentChangeOrder_OldChangeOrder_OldCOLine_OtherInfo_OrderReference...", Logger.MessageType.INF);
				SeleniumControl POQCHNG_CurrentChangeOrder_OldChangeOrder_OldCOLine_OtherInfo_OrderReference = new SeleniumControl( sDriver, "CurrentChangeOrder_OldChangeOrder_OldCOLine_OtherInfo_OrderReference", "xpath", "//div[translate(@id,'0123456789','')='pr__POQCHNG_POLNCHNG_CTW_']/ancestor::form[1]/descendant::*[@id='ORDER_REF_ID']");
				Function.AssertEqual(true,POQCHNG_CurrentChangeOrder_OldChangeOrder_OldCOLine_OtherInfo_OrderReference.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQCHNG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQCHNG] Performing Select on CurrentChangeOrder_OldChangeOrder_OldCOLine_Tab...", Logger.MessageType.INF);
				SeleniumControl POQCHNG_CurrentChangeOrder_OldChangeOrder_OldCOLine_Tab = new SeleniumControl( sDriver, "CurrentChangeOrder_OldChangeOrder_OldCOLine_Tab", "xpath", "//div[translate(@id,'0123456789','')='pr__POQCHNG_POLNCHNG_CTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(POQCHNG_CurrentChangeOrder_OldChangeOrder_OldCOLine_Tab);
IWebElement mTab = POQCHNG_CurrentChangeOrder_OldChangeOrder_OldCOLine_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Cost Info").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQCHNG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQCHNG] Performing VerifyExists on CurrentChangeOrder_OldChangeOrder_OldCOLine_CostInfo_GrossUnitCost...", Logger.MessageType.INF);
				SeleniumControl POQCHNG_CurrentChangeOrder_OldChangeOrder_OldCOLine_CostInfo_GrossUnitCost = new SeleniumControl( sDriver, "CurrentChangeOrder_OldChangeOrder_OldCOLine_CostInfo_GrossUnitCost", "xpath", "//div[translate(@id,'0123456789','')='pr__POQCHNG_POLNCHNG_CTW_']/ancestor::form[1]/descendant::*[@id='TRN_GR_UN_CST_AMT']");
				Function.AssertEqual(true,POQCHNG_CurrentChangeOrder_OldChangeOrder_OldCOLine_CostInfo_GrossUnitCost.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQCHNG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQCHNG] Performing Select on CurrentChangeOrder_OldChangeOrder_OldCOLine_Tab...", Logger.MessageType.INF);
				SeleniumControl POQCHNG_CurrentChangeOrder_OldChangeOrder_OldCOLine_Tab = new SeleniumControl( sDriver, "CurrentChangeOrder_OldChangeOrder_OldCOLine_Tab", "xpath", "//div[translate(@id,'0123456789','')='pr__POQCHNG_POLNCHNG_CTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(POQCHNG_CurrentChangeOrder_OldChangeOrder_OldCOLine_Tab);
IWebElement mTab = POQCHNG_CurrentChangeOrder_OldChangeOrder_OldCOLine_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Notes").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQCHNG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQCHNG] Performing VerifyExists on CurrentChangeOrder_OldChangeOrder_OldCOLine_Notes_LineNotes...", Logger.MessageType.INF);
				SeleniumControl POQCHNG_CurrentChangeOrder_OldChangeOrder_OldCOLine_Notes_LineNotes = new SeleniumControl( sDriver, "CurrentChangeOrder_OldChangeOrder_OldCOLine_Notes_LineNotes", "xpath", "//div[translate(@id,'0123456789','')='pr__POQCHNG_POLNCHNG_CTW_']/ancestor::form[1]/descendant::*[@id='PO_LN_TX']");
				Function.AssertEqual(true,POQCHNG_CurrentChangeOrder_OldChangeOrder_OldCOLine_Notes_LineNotes.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQCHNG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQCHNG] Performing Close on CurrentChangeOrder_OldChangeOrder_OldCOLine...", Logger.MessageType.INF);
				SeleniumControl POQCHNG_CurrentChangeOrder_OldChangeOrder_OldCOLine = new SeleniumControl( sDriver, "CurrentChangeOrder_OldChangeOrder_OldCOLine", "xpath", "//div[translate(@id,'0123456789','')='pr__POQCHNG_POLNCHNG_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POQCHNG_CurrentChangeOrder_OldChangeOrder_OldCOLine);
IWebElement formBttn = POQCHNG_CurrentChangeOrder_OldChangeOrder_OldCOLine.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("PO HEADER DOCUMENT");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQCHNG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQCHNG] Performing VerifyExists on CurrentChangeOrder_OldChangeOrder_POHeaderDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl POQCHNG_CurrentChangeOrder_OldChangeOrder_POHeaderDocumentsLink = new SeleniumControl( sDriver, "CurrentChangeOrder_OldChangeOrder_POHeaderDocumentsLink", "ID", "lnk_1007743_POQCHNG_POHDRCHNG_CHLD");
				Function.AssertEqual(true,POQCHNG_CurrentChangeOrder_OldChangeOrder_POHeaderDocumentsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQCHNG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQCHNG] Performing Click on CurrentChangeOrder_OldChangeOrder_POHeaderDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl POQCHNG_CurrentChangeOrder_OldChangeOrder_POHeaderDocumentsLink = new SeleniumControl( sDriver, "CurrentChangeOrder_OldChangeOrder_POHeaderDocumentsLink", "ID", "lnk_1007743_POQCHNG_POHDRCHNG_CHLD");
				Function.WaitControlDisplayed(POQCHNG_CurrentChangeOrder_OldChangeOrder_POHeaderDocumentsLink);
POQCHNG_CurrentChangeOrder_OldChangeOrder_POHeaderDocumentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQCHNG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQCHNG] Performing VerifyExist on CurrentChangeOrder_OldChangeOrder_POHeaderDocumentsTable...", Logger.MessageType.INF);
				SeleniumControl POQCHNG_CurrentChangeOrder_OldChangeOrder_POHeaderDocumentsTable = new SeleniumControl( sDriver, "CurrentChangeOrder_OldChangeOrder_POHeaderDocumentsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__POM_PODOCUMENTCHNG_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,POQCHNG_CurrentChangeOrder_OldChangeOrder_POHeaderDocumentsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQCHNG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQCHNG] Performing ClickButton on CurrentChangeOrder_OldChangeOrder_POHeaderDocuments...", Logger.MessageType.INF);
				SeleniumControl POQCHNG_CurrentChangeOrder_OldChangeOrder_POHeaderDocuments = new SeleniumControl( sDriver, "CurrentChangeOrder_OldChangeOrder_POHeaderDocuments", "xpath", "//div[translate(@id,'0123456789','')='pr__POM_PODOCUMENTCHNG_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POQCHNG_CurrentChangeOrder_OldChangeOrder_POHeaderDocuments);
IWebElement formBttn = POQCHNG_CurrentChangeOrder_OldChangeOrder_POHeaderDocuments.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? POQCHNG_CurrentChangeOrder_OldChangeOrder_POHeaderDocuments.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
POQCHNG_CurrentChangeOrder_OldChangeOrder_POHeaderDocuments.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQCHNG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQCHNG] Performing VerifyExists on CurrentChangeOrder_OldChangeOrder_POHeaderDocuments...", Logger.MessageType.INF);
				SeleniumControl POQCHNG_CurrentChangeOrder_OldChangeOrder_POHeaderDocuments = new SeleniumControl( sDriver, "CurrentChangeOrder_OldChangeOrder_POHeaderDocuments", "xpath", "//div[translate(@id,'0123456789','')='pr__POM_PODOCUMENTCHNG_']/ancestor::form[1]");
				Function.AssertEqual(true,POQCHNG_CurrentChangeOrder_OldChangeOrder_POHeaderDocuments.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQCHNG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQCHNG] Performing VerifyExists on CurrentChangeOrder_OldChangeOrder_POHeaderDocuments_Document...", Logger.MessageType.INF);
				SeleniumControl POQCHNG_CurrentChangeOrder_OldChangeOrder_POHeaderDocuments_Document = new SeleniumControl( sDriver, "CurrentChangeOrder_OldChangeOrder_POHeaderDocuments_Document", "xpath", "//div[translate(@id,'0123456789','')='pr__POM_PODOCUMENTCHNG_']/ancestor::form[1]/descendant::*[@id='DOCUMENT_ID']");
				Function.AssertEqual(true,POQCHNG_CurrentChangeOrder_OldChangeOrder_POHeaderDocuments_Document.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQCHNG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQCHNG] Performing Close on CurrentChangeOrder_OldChangeOrder_POHeaderDocuments...", Logger.MessageType.INF);
				SeleniumControl POQCHNG_CurrentChangeOrder_OldChangeOrder_POHeaderDocuments = new SeleniumControl( sDriver, "CurrentChangeOrder_OldChangeOrder_POHeaderDocuments", "xpath", "//div[translate(@id,'0123456789','')='pr__POM_PODOCUMENTCHNG_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POQCHNG_CurrentChangeOrder_OldChangeOrder_POHeaderDocuments);
IWebElement formBttn = POQCHNG_CurrentChangeOrder_OldChangeOrder_POHeaderDocuments.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("HEADER TEXT");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQCHNG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQCHNG] Performing VerifyExists on CurrentChangeOrder_OldChangeOrder_HeaderTextLink...", Logger.MessageType.INF);
				SeleniumControl POQCHNG_CurrentChangeOrder_OldChangeOrder_HeaderTextLink = new SeleniumControl( sDriver, "CurrentChangeOrder_OldChangeOrder_HeaderTextLink", "ID", "lnk_2649_POQCHNG_POHDRCHNG_CHLD");
				Function.AssertEqual(true,POQCHNG_CurrentChangeOrder_OldChangeOrder_HeaderTextLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQCHNG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQCHNG] Performing Click on CurrentChangeOrder_OldChangeOrder_HeaderTextLink...", Logger.MessageType.INF);
				SeleniumControl POQCHNG_CurrentChangeOrder_OldChangeOrder_HeaderTextLink = new SeleniumControl( sDriver, "CurrentChangeOrder_OldChangeOrder_HeaderTextLink", "ID", "lnk_2649_POQCHNG_POHDRCHNG_CHLD");
				Function.WaitControlDisplayed(POQCHNG_CurrentChangeOrder_OldChangeOrder_HeaderTextLink);
POQCHNG_CurrentChangeOrder_OldChangeOrder_HeaderTextLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQCHNG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQCHNG] Performing VerifyExist on CurrentChangeOrder_OldChangeOrder_HeaderTextTable...", Logger.MessageType.INF);
				SeleniumControl POQCHNG_CurrentChangeOrder_OldChangeOrder_HeaderTextTable = new SeleniumControl( sDriver, "CurrentChangeOrder_OldChangeOrder_HeaderTextTable", "xpath", "//div[translate(@id,'0123456789','')='pr__POQCHNG_POHDRTEXT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,POQCHNG_CurrentChangeOrder_OldChangeOrder_HeaderTextTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQCHNG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQCHNG] Performing ClickButton on CurrentChangeOrder_OldChangeOrder_HeaderText...", Logger.MessageType.INF);
				SeleniumControl POQCHNG_CurrentChangeOrder_OldChangeOrder_HeaderText = new SeleniumControl( sDriver, "CurrentChangeOrder_OldChangeOrder_HeaderText", "xpath", "//div[translate(@id,'0123456789','')='pr__POQCHNG_POHDRTEXT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POQCHNG_CurrentChangeOrder_OldChangeOrder_HeaderText);
IWebElement formBttn = POQCHNG_CurrentChangeOrder_OldChangeOrder_HeaderText.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? POQCHNG_CurrentChangeOrder_OldChangeOrder_HeaderText.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
POQCHNG_CurrentChangeOrder_OldChangeOrder_HeaderText.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQCHNG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQCHNG] Performing VerifyExists on CurrentChangeOrder_OldChangeOrder_HeaderText...", Logger.MessageType.INF);
				SeleniumControl POQCHNG_CurrentChangeOrder_OldChangeOrder_HeaderText = new SeleniumControl( sDriver, "CurrentChangeOrder_OldChangeOrder_HeaderText", "xpath", "//div[translate(@id,'0123456789','')='pr__POQCHNG_POHDRTEXT_']/ancestor::form[1]");
				Function.AssertEqual(true,POQCHNG_CurrentChangeOrder_OldChangeOrder_HeaderText.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQCHNG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQCHNG] Performing VerifyExists on CurrentChangeOrder_OldChangeOrder_HeaderText_TextCode...", Logger.MessageType.INF);
				SeleniumControl POQCHNG_CurrentChangeOrder_OldChangeOrder_HeaderText_TextCode = new SeleniumControl( sDriver, "CurrentChangeOrder_OldChangeOrder_HeaderText_TextCode", "xpath", "//div[translate(@id,'0123456789','')='pr__POQCHNG_POHDRTEXT_']/ancestor::form[1]/descendant::*[@id='TEXT_CD']");
				Function.AssertEqual(true,POQCHNG_CurrentChangeOrder_OldChangeOrder_HeaderText_TextCode.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQCHNG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQCHNG] Performing Close on CurrentChangeOrder_OldChangeOrder_HeaderText...", Logger.MessageType.INF);
				SeleniumControl POQCHNG_CurrentChangeOrder_OldChangeOrder_HeaderText = new SeleniumControl( sDriver, "CurrentChangeOrder_OldChangeOrder_HeaderText", "xpath", "//div[translate(@id,'0123456789','')='pr__POQCHNG_POHDRTEXT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POQCHNG_CurrentChangeOrder_OldChangeOrder_HeaderText);
IWebElement formBttn = POQCHNG_CurrentChangeOrder_OldChangeOrder_HeaderText.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "POQCHNG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQCHNG] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl POQCHNG_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(POQCHNG_MainForm);
IWebElement formBttn = POQCHNG_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

