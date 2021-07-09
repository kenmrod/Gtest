 
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
    public class PPMRQLN_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Procurement Planning", "xpath","//div[@class='deptItem'][.='Procurement Planning']").Click();
new SeleniumControl(sDriver,"Purchase Requisitions", "xpath","//div[@class='navItem'][.='Purchase Requisitions']").Click();
new SeleniumControl(sDriver,"Apply PO Info to Purchase Requisitions by Line", "xpath","//div[@class='navItem'][.='Apply PO Info to Purchase Requisitions by Line']").Click();


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
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,PPMRQLN_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing VerifyExists on Buyer...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_Buyer = new SeleniumControl( sDriver, "Buyer", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='DFSBUYERID']");
				Function.AssertEqual(true,PPMRQLN_Buyer.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Child Form");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing ClickButton on ChildForm...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMRQLN_RQHDR_HEADER_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMRQLN_ChildForm);
IWebElement formBttn = PPMRQLN_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).Count <= 0 ? PPMRQLN_ChildForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Query')]")).FirstOrDefault() :
PPMRQLN_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).FirstOrDefault();
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

				this.ScriptLogger.WriteLine("[Query] Performing Click on Query...", Logger.MessageType.INF);
				SeleniumControl Query_Query = new SeleniumControl( sDriver, "Query", "ID", "submitQ");
				Function.WaitControlDisplayed(Query_Query);
if (Query_Query.mElement.GetAttribute("class") == "popupBtn" && sDriver.BrowserType == "ie")
Query_Query.Click(5,5);
else Query_Query.Click(4.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing VerifyExist on ChildFormTable...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_ChildFormTable = new SeleniumControl( sDriver, "ChildFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMRQLN_RQHDR_HEADER_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PPMRQLN_ChildFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing ClickButton on ChildForm...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMRQLN_RQHDR_HEADER_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMRQLN_ChildForm);
IWebElement formBttn = PPMRQLN_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PPMRQLN_ChildForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PPMRQLN_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMRQLN_RQHDR_HEADER_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PPMRQLN_MainFormTab);
IWebElement mTab = PPMRQLN_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Basic Information").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing VerifyExists on BasicInformation_Item...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_BasicInformation_Item = new SeleniumControl( sDriver, "BasicInformation_Item", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMRQLN_RQHDR_HEADER_']/ancestor::form[1]/descendant::*[@id='ITEM_ID']");
				Function.AssertEqual(true,PPMRQLN_BasicInformation_Item.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMRQLN_RQHDR_HEADER_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PPMRQLN_MainFormTab);
IWebElement mTab = PPMRQLN_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Requisition Header").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing VerifyExists on RequisitionHeader_RequisitionDate...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_RequisitionHeader_RequisitionDate = new SeleniumControl( sDriver, "RequisitionHeader_RequisitionDate", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMRQLN_RQHDR_HEADER_']/ancestor::form[1]/descendant::*[@id='RQ_DT']");
				Function.AssertEqual(true,PPMRQLN_RequisitionHeader_RequisitionDate.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMRQLN_RQHDR_HEADER_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PPMRQLN_MainFormTab);
IWebElement mTab = PPMRQLN_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Purchasing Information").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing VerifyExists on PurchasingInformation_Buyer...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_PurchasingInformation_Buyer = new SeleniumControl( sDriver, "PurchasingInformation_Buyer", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMRQLN_RQHDR_HEADER_']/ancestor::form[1]/descendant::*[@id='BUYER_ID']");
				Function.AssertEqual(true,PPMRQLN_PurchasingInformation_Buyer.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMRQLN_RQHDR_HEADER_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PPMRQLN_MainFormTab);
IWebElement mTab = PPMRQLN_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Shipping & Receiving").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing VerifyExists on ShippingAndReceiving_Warehouse...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_ShippingAndReceiving_Warehouse = new SeleniumControl( sDriver, "ShippingAndReceiving_Warehouse", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMRQLN_RQHDR_HEADER_']/ancestor::form[1]/descendant::*[@id='WHSE_ID']");
				Function.AssertEqual(true,PPMRQLN_ShippingAndReceiving_Warehouse.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMRQLN_RQHDR_HEADER_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PPMRQLN_MainFormTab);
IWebElement mTab = PPMRQLN_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Other Information").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing VerifyExists on OtherInformation_ApprovalProcess...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_OtherInformation_ApprovalProcess = new SeleniumControl( sDriver, "OtherInformation_ApprovalProcess", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMRQLN_RQHDR_HEADER_']/ancestor::form[1]/descendant::*[@id='RQ_APPR_PROC_CDHDR']");
				Function.AssertEqual(true,PPMRQLN_OtherInformation_ApprovalProcess.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMRQLN_RQHDR_HEADER_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PPMRQLN_MainFormTab);
IWebElement mTab = PPMRQLN_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Notes").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing VerifyExists on Notes_HeaderNotes_Text...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_Notes_HeaderNotes_Text = new SeleniumControl( sDriver, "Notes_HeaderNotes_Text", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMRQLN_RQHDR_HEADER_']/ancestor::form[1]/descendant::*[@id='RQ_NOTES']");
				Function.AssertEqual(true,PPMRQLN_Notes_HeaderNotes_Text.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Hdr Text");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing VerifyExists on HdrTextLink...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_HdrTextLink = new SeleniumControl( sDriver, "HdrTextLink", "ID", "lnk_1005498_PPMRQLN_RQHDR_HEADER");
				Function.AssertEqual(true,PPMRQLN_HdrTextLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing Click on HdrTextLink...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_HdrTextLink = new SeleniumControl( sDriver, "HdrTextLink", "ID", "lnk_1005498_PPMRQLN_RQHDR_HEADER");
				Function.WaitControlDisplayed(PPMRQLN_HdrTextLink);
PPMRQLN_HdrTextLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing VerifyExist on HdrTextTable...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_HdrTextTable = new SeleniumControl( sDriver, "HdrTextTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQHDRTEXT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PPMRQLN_HdrTextTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing ClickButton on HdrTextForm...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_HdrTextForm = new SeleniumControl( sDriver, "HdrTextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQHDRTEXT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMRQLN_HdrTextForm);
IWebElement formBttn = PPMRQLN_HdrTextForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PPMRQLN_HdrTextForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PPMRQLN_HdrTextForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing VerifyExists on HdrTextForm...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_HdrTextForm = new SeleniumControl( sDriver, "HdrTextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQHDRTEXT_']/ancestor::form[1]");
				Function.AssertEqual(true,PPMRQLN_HdrTextForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing VerifyExists on HdrText_Sequence...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_HdrText_Sequence = new SeleniumControl( sDriver, "HdrText_Sequence", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQHDRTEXT_']/ancestor::form[1]/descendant::*[@id='SEQ_NO']");
				Function.AssertEqual(true,PPMRQLN_HdrText_Sequence.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing Close on HdrTextForm...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_HdrTextForm = new SeleniumControl( sDriver, "HdrTextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQHDRTEXT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMRQLN_HdrTextForm);
IWebElement formBttn = PPMRQLN_HdrTextForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Hdr Approval");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing VerifyExists on HdrApprovalsLink...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_HdrApprovalsLink = new SeleniumControl( sDriver, "HdrApprovalsLink", "ID", "lnk_2693_PPMRQLN_RQHDR_HEADER");
				Function.AssertEqual(true,PPMRQLN_HdrApprovalsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing Click on HdrApprovalsLink...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_HdrApprovalsLink = new SeleniumControl( sDriver, "HdrApprovalsLink", "ID", "lnk_2693_PPMRQLN_RQHDR_HEADER");
				Function.WaitControlDisplayed(PPMRQLN_HdrApprovalsLink);
PPMRQLN_HdrApprovalsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing VerifyExist on HdrApprovalsTable...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_HdrApprovalsTable = new SeleniumControl( sDriver, "HdrApprovalsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQHDRAPPRVL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PPMRQLN_HdrApprovalsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing ClickButton on HdrApprovalsForm...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_HdrApprovalsForm = new SeleniumControl( sDriver, "HdrApprovalsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQHDRAPPRVL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMRQLN_HdrApprovalsForm);
IWebElement formBttn = PPMRQLN_HdrApprovalsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PPMRQLN_HdrApprovalsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PPMRQLN_HdrApprovalsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing VerifyExists on HdrApprovalsForm...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_HdrApprovalsForm = new SeleniumControl( sDriver, "HdrApprovalsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQHDRAPPRVL_']/ancestor::form[1]");
				Function.AssertEqual(true,PPMRQLN_HdrApprovalsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing VerifyExists on HdrApprovals_ApprovalRevision...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_HdrApprovals_ApprovalRevision = new SeleniumControl( sDriver, "HdrApprovals_ApprovalRevision", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQHDRAPPRVL_']/ancestor::form[1]/descendant::*[@id='RVSN_NO']");
				Function.AssertEqual(true,PPMRQLN_HdrApprovals_ApprovalRevision.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing Close on HdrApprovalsForm...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_HdrApprovalsForm = new SeleniumControl( sDriver, "HdrApprovalsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQHDRAPPRVL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMRQLN_HdrApprovalsForm);
IWebElement formBttn = PPMRQLN_HdrApprovalsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Exchange Rates");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing VerifyExists on ExchangeRateLink...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_ExchangeRateLink = new SeleniumControl( sDriver, "ExchangeRateLink", "ID", "lnk_1004187_PPMRQLN_RQHDR_HEADER");
				Function.AssertEqual(true,PPMRQLN_ExchangeRateLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing Click on ExchangeRateLink...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_ExchangeRateLink = new SeleniumControl( sDriver, "ExchangeRateLink", "ID", "lnk_1004187_PPMRQLN_RQHDR_HEADER");
				Function.WaitControlDisplayed(PPMRQLN_ExchangeRateLink);
PPMRQLN_ExchangeRateLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing VerifyExists on ExchangeRateForm...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_ExchangeRateForm = new SeleniumControl( sDriver, "ExchangeRateForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPM_SEXR_']/ancestor::form[1]");
				Function.AssertEqual(true,PPMRQLN_ExchangeRateForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing VerifyExists on ExchangeRate_TransactionCurrency_RateDate...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_ExchangeRate_TransactionCurrency_RateDate = new SeleniumControl( sDriver, "ExchangeRate_TransactionCurrency_RateDate", "xpath", "//div[translate(@id,'0123456789','')='pr__CPM_SEXR_']/ancestor::form[1]/descendant::*[@id='TRN_CRNCY_DT']");
				Function.AssertEqual(true,PPMRQLN_ExchangeRate_TransactionCurrency_RateDate.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing Close on ExchangeRateForm...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_ExchangeRateForm = new SeleniumControl( sDriver, "ExchangeRateForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPM_SEXR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMRQLN_ExchangeRateForm);
IWebElement formBttn = PPMRQLN_ExchangeRateForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Hdr Documents");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing VerifyExists on HdrDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_HdrDocumentsLink = new SeleniumControl( sDriver, "HdrDocumentsLink", "ID", "lnk_1007778_PPMRQLN_RQHDR_HEADER");
				Function.AssertEqual(true,PPMRQLN_HdrDocumentsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing Click on HdrDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_HdrDocumentsLink = new SeleniumControl( sDriver, "HdrDocumentsLink", "ID", "lnk_1007778_PPMRQLN_RQHDR_HEADER");
				Function.WaitControlDisplayed(PPMRQLN_HdrDocumentsLink);
PPMRQLN_HdrDocumentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing VerifyExist on HdrDocumentsTable...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_HdrDocumentsTable = new SeleniumControl( sDriver, "HdrDocumentsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PPM_HDR_DOCUMENTS_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PPMRQLN_HdrDocumentsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing ClickButton on HdrDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_HdrDocumentsForm = new SeleniumControl( sDriver, "HdrDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPM_HDR_DOCUMENTS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMRQLN_HdrDocumentsForm);
IWebElement formBttn = PPMRQLN_HdrDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PPMRQLN_HdrDocumentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PPMRQLN_HdrDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing VerifyExists on HdrDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_HdrDocumentsForm = new SeleniumControl( sDriver, "HdrDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPM_HDR_DOCUMENTS_']/ancestor::form[1]");
				Function.AssertEqual(true,PPMRQLN_HdrDocumentsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing VerifyExists on HdrDocuments_Document...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_HdrDocuments_Document = new SeleniumControl( sDriver, "HdrDocuments_Document", "xpath", "//div[translate(@id,'0123456789','')='pr__PPM_HDR_DOCUMENTS_']/ancestor::form[1]/descendant::*[@id='DOCUMENT_ID']");
				Function.AssertEqual(true,PPMRQLN_HdrDocuments_Document.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing Close on HdrDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_HdrDocumentsForm = new SeleniumControl( sDriver, "HdrDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPM_HDR_DOCUMENTS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMRQLN_HdrDocumentsForm);
IWebElement formBttn = PPMRQLN_HdrDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("ACCOUNTXS");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing VerifyExists on AccountsLink...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_AccountsLink = new SeleniumControl( sDriver, "AccountsLink", "ID", "lnk_1005523_PPMRQLN_RQHDR_HEADER");
				Function.AssertEqual(true,PPMRQLN_AccountsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing Click on AccountsLink...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_AccountsLink = new SeleniumControl( sDriver, "AccountsLink", "ID", "lnk_1005523_PPMRQLN_RQHDR_HEADER");
				Function.WaitControlDisplayed(PPMRQLN_AccountsLink);
PPMRQLN_AccountsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing VerifyExist on AccountsTable...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_AccountsTable = new SeleniumControl( sDriver, "AccountsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLNACCT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PPMRQLN_AccountsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing ClickButton on AccountsForm...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_AccountsForm = new SeleniumControl( sDriver, "AccountsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLNACCT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMRQLN_AccountsForm);
IWebElement formBttn = PPMRQLN_AccountsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PPMRQLN_AccountsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PPMRQLN_AccountsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing VerifyExists on AccountsForm...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_AccountsForm = new SeleniumControl( sDriver, "AccountsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLNACCT_']/ancestor::form[1]");
				Function.AssertEqual(true,PPMRQLN_AccountsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing VerifyExists on Accounts_Project...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_Accounts_Project = new SeleniumControl( sDriver, "Accounts_Project", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLNACCT_']/ancestor::form[1]/descendant::*[@id='PROJ_ID']");
				Function.AssertEqual(true,PPMRQLN_Accounts_Project.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing Close on AccountsForm...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_AccountsForm = new SeleniumControl( sDriver, "AccountsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLNACCT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMRQLN_AccountsForm);
IWebElement formBttn = PPMRQLN_AccountsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Currency Line");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing VerifyExists on CurrencyLineLink...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_CurrencyLineLink = new SeleniumControl( sDriver, "CurrencyLineLink", "ID", "lnk_2685_PPMRQLN_RQHDR_HEADER");
				Function.AssertEqual(true,PPMRQLN_CurrencyLineLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing Click on CurrencyLineLink...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_CurrencyLineLink = new SeleniumControl( sDriver, "CurrencyLineLink", "ID", "lnk_2685_PPMRQLN_RQHDR_HEADER");
				Function.WaitControlDisplayed(PPMRQLN_CurrencyLineLink);
PPMRQLN_CurrencyLineLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing VerifyExists on CurrencyLineForm...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_CurrencyLineForm = new SeleniumControl( sDriver, "CurrencyLineForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPRQCURL_']/ancestor::form[1]");
				Function.AssertEqual(true,PPMRQLN_CurrencyLineForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing VerifyExists on CurrencyLine_LineAmounts_Currency...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_CurrencyLine_LineAmounts_Currency = new SeleniumControl( sDriver, "CurrencyLine_LineAmounts_Currency", "xpath", "//div[translate(@id,'0123456789','')='pr__PPRQCURL_']/ancestor::form[1]/descendant::*[@id='TRN_CRNCY_CD']");
				Function.AssertEqual(true,PPMRQLN_CurrencyLine_LineAmounts_Currency.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing ClickButton on CurrencyLineForm...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_CurrencyLineForm = new SeleniumControl( sDriver, "CurrencyLineForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPRQCURL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMRQLN_CurrencyLineForm);
IWebElement formBttn = PPMRQLN_CurrencyLineForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? PPMRQLN_CurrencyLineForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
PPMRQLN_CurrencyLineForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing VerifyExist on CurrencyLineTable...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_CurrencyLineTable = new SeleniumControl( sDriver, "CurrencyLineTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PPRQCURL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PPMRQLN_CurrencyLineTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing Close on CurrencyLineForm...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_CurrencyLineForm = new SeleniumControl( sDriver, "CurrencyLineForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPRQCURL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMRQLN_CurrencyLineForm);
IWebElement formBttn = PPMRQLN_CurrencyLineForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Line Text");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing VerifyExists on LineTextLink...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_LineTextLink = new SeleniumControl( sDriver, "LineTextLink", "ID", "lnk_2686_PPMRQLN_RQHDR_HEADER");
				Function.AssertEqual(true,PPMRQLN_LineTextLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing Click on LineTextLink...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_LineTextLink = new SeleniumControl( sDriver, "LineTextLink", "ID", "lnk_2686_PPMRQLN_RQHDR_HEADER");
				Function.WaitControlDisplayed(PPMRQLN_LineTextLink);
PPMRQLN_LineTextLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing VerifyExist on LineTextTable...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_LineTextTable = new SeleniumControl( sDriver, "LineTextTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLNTEXT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PPMRQLN_LineTextTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing ClickButton on LineTextForm...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_LineTextForm = new SeleniumControl( sDriver, "LineTextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLNTEXT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMRQLN_LineTextForm);
IWebElement formBttn = PPMRQLN_LineTextForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PPMRQLN_LineTextForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PPMRQLN_LineTextForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing VerifyExists on LineTextForm...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_LineTextForm = new SeleniumControl( sDriver, "LineTextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLNTEXT_']/ancestor::form[1]");
				Function.AssertEqual(true,PPMRQLN_LineTextForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing VerifyExists on LineText_Sequence...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_LineText_Sequence = new SeleniumControl( sDriver, "LineText_Sequence", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLNTEXT_']/ancestor::form[1]/descendant::*[@id='SEQ_NO']");
				Function.AssertEqual(true,PPMRQLN_LineText_Sequence.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing Close on LineTextForm...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_LineTextForm = new SeleniumControl( sDriver, "LineTextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLNTEXT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMRQLN_LineTextForm);
IWebElement formBttn = PPMRQLN_LineTextForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Line Charges");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing VerifyExists on LineChargesLink...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_LineChargesLink = new SeleniumControl( sDriver, "LineChargesLink", "ID", "lnk_1005528_PPMRQLN_RQHDR_HEADER");
				Function.AssertEqual(true,PPMRQLN_LineChargesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing Click on LineChargesLink...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_LineChargesLink = new SeleniumControl( sDriver, "LineChargesLink", "ID", "lnk_1005528_PPMRQLN_RQHDR_HEADER");
				Function.WaitControlDisplayed(PPMRQLN_LineChargesLink);
PPMRQLN_LineChargesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing VerifyExist on LineChargesTable...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_LineChargesTable = new SeleniumControl( sDriver, "LineChargesTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLNCHG_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PPMRQLN_LineChargesTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing ClickButton on LineChargesForm...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_LineChargesForm = new SeleniumControl( sDriver, "LineChargesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLNCHG_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMRQLN_LineChargesForm);
IWebElement formBttn = PPMRQLN_LineChargesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PPMRQLN_LineChargesForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PPMRQLN_LineChargesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing VerifyExists on LineChargesForm...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_LineChargesForm = new SeleniumControl( sDriver, "LineChargesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLNCHG_']/ancestor::form[1]");
				Function.AssertEqual(true,PPMRQLN_LineChargesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing VerifyExists on LineCharges_ChargeType...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_LineCharges_ChargeType = new SeleniumControl( sDriver, "LineCharges_ChargeType", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLNCHG_']/ancestor::form[1]/descendant::*[@id='LN_CHG_TYPE']");
				Function.AssertEqual(true,PPMRQLN_LineCharges_ChargeType.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing Close on LineChargesForm...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_LineChargesForm = new SeleniumControl( sDriver, "LineChargesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLNCHG_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMRQLN_LineChargesForm);
IWebElement formBttn = PPMRQLN_LineChargesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Ref Quotes");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing VerifyExists on RefQuoutesLink...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_RefQuoutesLink = new SeleniumControl( sDriver, "RefQuoutesLink", "ID", "lnk_1005521_PPMRQLN_RQHDR_HEADER");
				Function.AssertEqual(true,PPMRQLN_RefQuoutesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing Click on RefQuoutesLink...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_RefQuoutesLink = new SeleniumControl( sDriver, "RefQuoutesLink", "ID", "lnk_1005521_PPMRQLN_RQHDR_HEADER");
				Function.WaitControlDisplayed(PPMRQLN_RefQuoutesLink);
PPMRQLN_RefQuoutesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing VerifyExist on RefQuoutesTable...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_RefQuoutesTable = new SeleniumControl( sDriver, "RefQuoutesTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLNQUOTES_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PPMRQLN_RefQuoutesTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing ClickButton on RefQuoutesForm...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_RefQuoutesForm = new SeleniumControl( sDriver, "RefQuoutesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLNQUOTES_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMRQLN_RefQuoutesForm);
IWebElement formBttn = PPMRQLN_RefQuoutesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PPMRQLN_RefQuoutesForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PPMRQLN_RefQuoutesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing VerifyExists on RefQuoutesForm...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_RefQuoutesForm = new SeleniumControl( sDriver, "RefQuoutesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLNQUOTES_']/ancestor::form[1]");
				Function.AssertEqual(true,PPMRQLN_RefQuoutesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing VerifyExists on RefQuotes_Quote_Quote...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_RefQuotes_Quote_Quote = new SeleniumControl( sDriver, "RefQuotes_Quote_Quote", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLNQUOTES_']/ancestor::form[1]/descendant::*[@id='QUOTE_ID']");
				Function.AssertEqual(true,PPMRQLN_RefQuotes_Quote_Quote.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing Close on RefQuoutesForm...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_RefQuoutesForm = new SeleniumControl( sDriver, "RefQuoutesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLNQUOTES_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMRQLN_RefQuoutesForm);
IWebElement formBttn = PPMRQLN_RefQuoutesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("RFQs");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing VerifyExists on RFQLink...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_RFQLink = new SeleniumControl( sDriver, "RFQLink", "ID", "lnk_1005515_PPMRQLN_RQHDR_HEADER");
				Function.AssertEqual(true,PPMRQLN_RFQLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing Click on RFQLink...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_RFQLink = new SeleniumControl( sDriver, "RFQLink", "ID", "lnk_1005515_PPMRQLN_RQHDR_HEADER");
				Function.WaitControlDisplayed(PPMRQLN_RFQLink);
PPMRQLN_RFQLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing VerifyExist on RFQTable...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_RFQTable = new SeleniumControl( sDriver, "RFQTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RFQLN_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PPMRQLN_RFQTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing ClickButton on RFQForm...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_RFQForm = new SeleniumControl( sDriver, "RFQForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RFQLN_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMRQLN_RFQForm);
IWebElement formBttn = PPMRQLN_RFQForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PPMRQLN_RFQForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PPMRQLN_RFQForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing VerifyExists on RFQForm...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_RFQForm = new SeleniumControl( sDriver, "RFQForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RFQLN_']/ancestor::form[1]");
				Function.AssertEqual(true,PPMRQLN_RFQForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing VerifyExists on RFQs_RequestForQuote_RFQ...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_RFQs_RequestForQuote_RFQ = new SeleniumControl( sDriver, "RFQs_RequestForQuote_RFQ", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RFQLN_']/ancestor::form[1]/descendant::*[@id='RFQ_ID']");
				Function.AssertEqual(true,PPMRQLN_RFQs_RequestForQuote_RFQ.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing Close on RFQForm...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_RFQForm = new SeleniumControl( sDriver, "RFQForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RFQLN_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMRQLN_RFQForm);
IWebElement formBttn = PPMRQLN_RFQForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Assign PO");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing VerifyExists on AssignPOLink...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_AssignPOLink = new SeleniumControl( sDriver, "AssignPOLink", "ID", "lnk_2973_PPMRQLN_RQHDR_HEADER");
				Function.AssertEqual(true,PPMRQLN_AssignPOLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing Click on AssignPOLink...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_AssignPOLink = new SeleniumControl( sDriver, "AssignPOLink", "ID", "lnk_2973_PPMRQLN_RQHDR_HEADER");
				Function.WaitControlDisplayed(PPMRQLN_AssignPOLink);
PPMRQLN_AssignPOLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing VerifyExist on AssignPOTable...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_AssignPOTable = new SeleniumControl( sDriver, "AssignPOTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLNPO_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PPMRQLN_AssignPOTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing ClickButton on AssignPOForm...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_AssignPOForm = new SeleniumControl( sDriver, "AssignPOForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLNPO_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMRQLN_AssignPOForm);
IWebElement formBttn = PPMRQLN_AssignPOForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PPMRQLN_AssignPOForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PPMRQLN_AssignPOForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing VerifyExists on AssignPOForm...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_AssignPOForm = new SeleniumControl( sDriver, "AssignPOForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLNPO_']/ancestor::form[1]");
				Function.AssertEqual(true,PPMRQLN_AssignPOForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing VerifyExists on AssignPO_ReadyForPO...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_AssignPO_ReadyForPO = new SeleniumControl( sDriver, "AssignPO_ReadyForPO", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLNPO_']/ancestor::form[1]/descendant::*[@id='RDY_FOR_PO_FL']");
				Function.AssertEqual(true,PPMRQLN_AssignPO_ReadyForPO.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing Select on AssignPOFormTab...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_AssignPOFormTab = new SeleniumControl( sDriver, "AssignPOFormTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLNPO_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PPMRQLN_AssignPOFormTab);
IWebElement mTab = PPMRQLN_AssignPOFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Purchase Order Information").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing VerifyExists on AssignPO_PurchaseOrderInformation_Vendor...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_AssignPO_PurchaseOrderInformation_Vendor = new SeleniumControl( sDriver, "AssignPO_PurchaseOrderInformation_Vendor", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLNPO_']/ancestor::form[1]/descendant::*[@id='VEND_ID']");
				Function.AssertEqual(true,PPMRQLN_AssignPO_PurchaseOrderInformation_Vendor.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing Select on AssignPOFormTab...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_AssignPOFormTab = new SeleniumControl( sDriver, "AssignPOFormTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLNPO_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PPMRQLN_AssignPOFormTab);
IWebElement mTab = PPMRQLN_AssignPOFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Functional Currency Amounts").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing VerifyExists on AssignPO_FunctionalCurrencyAmounts_GrossUnitCost...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_AssignPO_FunctionalCurrencyAmounts_GrossUnitCost = new SeleniumControl( sDriver, "AssignPO_FunctionalCurrencyAmounts_GrossUnitCost", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLNPO_']/ancestor::form[1]/descendant::*[@id='NEG_GROSS_UNIT_AMT']");
				Function.AssertEqual(true,PPMRQLN_AssignPO_FunctionalCurrencyAmounts_GrossUnitCost.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("ChildForm_SerialLotInfoForm");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing VerifyExists on SerialLotLink...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_SerialLotLink = new SeleniumControl( sDriver, "SerialLotLink", "ID", "lnk_18822_PPMRQLN_RQHDR_HEADER");
				Function.AssertEqual(true,PPMRQLN_SerialLotLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing VerifyExists on ExchangeRateLink...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_ExchangeRateLink = new SeleniumControl( sDriver, "ExchangeRateLink", "ID", "lnk_1004187_PPMRQLN_RQHDR_HEADER");
				Function.AssertEqual(true,PPMRQLN_ExchangeRateLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing Close on AssignPOForm...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_AssignPOForm = new SeleniumControl( sDriver, "AssignPOForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLNPO_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMRQLN_AssignPOForm);
IWebElement formBttn = PPMRQLN_AssignPOForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Line Approvals");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing VerifyExists on LineApprovalLink...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_LineApprovalLink = new SeleniumControl( sDriver, "LineApprovalLink", "ID", "lnk_1005503_PPMRQLN_RQHDR_HEADER");
				Function.AssertEqual(true,PPMRQLN_LineApprovalLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing Click on LineApprovalLink...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_LineApprovalLink = new SeleniumControl( sDriver, "LineApprovalLink", "ID", "lnk_1005503_PPMRQLN_RQHDR_HEADER");
				Function.WaitControlDisplayed(PPMRQLN_LineApprovalLink);
PPMRQLN_LineApprovalLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing VerifyExist on LineApprovalTable...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_LineApprovalTable = new SeleniumControl( sDriver, "LineApprovalTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLNAPPRVL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PPMRQLN_LineApprovalTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing ClickButton on LineApprovalForm...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_LineApprovalForm = new SeleniumControl( sDriver, "LineApprovalForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLNAPPRVL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMRQLN_LineApprovalForm);
IWebElement formBttn = PPMRQLN_LineApprovalForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PPMRQLN_LineApprovalForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PPMRQLN_LineApprovalForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing VerifyExists on LineApprovalForm...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_LineApprovalForm = new SeleniumControl( sDriver, "LineApprovalForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLNAPPRVL_']/ancestor::form[1]");
				Function.AssertEqual(true,PPMRQLN_LineApprovalForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing VerifyExists on LineApprovals_ApprovalRevision...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_LineApprovals_ApprovalRevision = new SeleniumControl( sDriver, "LineApprovals_ApprovalRevision", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLNAPPRVL_']/ancestor::form[1]/descendant::*[@id='RQ_LN_RVSN_NO']");
				Function.AssertEqual(true,PPMRQLN_LineApprovals_ApprovalRevision.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing Close on LineApprovalForm...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_LineApprovalForm = new SeleniumControl( sDriver, "LineApprovalForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLNAPPRVL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMRQLN_LineApprovalForm);
IWebElement formBttn = PPMRQLN_LineApprovalForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Line Documents");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing VerifyExists on LineDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_LineDocumentsLink = new SeleniumControl( sDriver, "LineDocumentsLink", "ID", "lnk_1007779_PPMRQLN_RQHDR_HEADER");
				Function.AssertEqual(true,PPMRQLN_LineDocumentsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing Click on LineDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_LineDocumentsLink = new SeleniumControl( sDriver, "LineDocumentsLink", "ID", "lnk_1007779_PPMRQLN_RQHDR_HEADER");
				Function.WaitControlDisplayed(PPMRQLN_LineDocumentsLink);
PPMRQLN_LineDocumentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing VerifyExist on LineDocumentsTable...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_LineDocumentsTable = new SeleniumControl( sDriver, "LineDocumentsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PPM_LN_DOCUMENTS_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PPMRQLN_LineDocumentsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing ClickButton on LineDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_LineDocumentsForm = new SeleniumControl( sDriver, "LineDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPM_LN_DOCUMENTS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMRQLN_LineDocumentsForm);
IWebElement formBttn = PPMRQLN_LineDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PPMRQLN_LineDocumentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PPMRQLN_LineDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing VerifyExists on LineDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_LineDocumentsForm = new SeleniumControl( sDriver, "LineDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPM_LN_DOCUMENTS_']/ancestor::form[1]");
				Function.AssertEqual(true,PPMRQLN_LineDocumentsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing VerifyExists on LineDocuments_Document...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_LineDocuments_Document = new SeleniumControl( sDriver, "LineDocuments_Document", "xpath", "//div[translate(@id,'0123456789','')='pr__PPM_LN_DOCUMENTS_']/ancestor::form[1]/descendant::*[@id='DOCUMENT_ID']");
				Function.AssertEqual(true,PPMRQLN_LineDocuments_Document.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing Close on LineDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_LineDocumentsForm = new SeleniumControl( sDriver, "LineDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPM_LN_DOCUMENTS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMRQLN_LineDocumentsForm);
IWebElement formBttn = PPMRQLN_LineDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Substitutes");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing VerifyExists on ProjSubPartsLink...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_ProjSubPartsLink = new SeleniumControl( sDriver, "ProjSubPartsLink", "ID", "lnk_16471_PPMRQLN_RQHDR_HEADER");
				Function.AssertEqual(true,PPMRQLN_ProjSubPartsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing Click on ProjSubPartsLink...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_ProjSubPartsLink = new SeleniumControl( sDriver, "ProjSubPartsLink", "ID", "lnk_16471_PPMRQLN_RQHDR_HEADER");
				Function.WaitControlDisplayed(PPMRQLN_ProjSubPartsLink);
PPMRQLN_ProjSubPartsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing VerifyExists on ProjSubPartsForm...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_ProjSubPartsForm = new SeleniumControl( sDriver, "ProjSubPartsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSUBSTPART_']/ancestor::form[1]");
				Function.AssertEqual(true,PPMRQLN_ProjSubPartsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing VerifyExist on ProjSubPartsTable...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_ProjSubPartsTable = new SeleniumControl( sDriver, "ProjSubPartsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSUBSTPART_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PPMRQLN_ProjSubPartsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing ClickButton on ProjSubPartsForm...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_ProjSubPartsForm = new SeleniumControl( sDriver, "ProjSubPartsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSUBSTPART_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMRQLN_ProjSubPartsForm);
IWebElement formBttn = PPMRQLN_ProjSubPartsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PPMRQLN_ProjSubPartsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PPMRQLN_ProjSubPartsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing VerifyExists on ProjSubParts_Sequence...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_ProjSubParts_Sequence = new SeleniumControl( sDriver, "ProjSubParts_Sequence", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSUBSTPART_']/ancestor::form[1]/descendant::*[@id='USAGE_SEQ_NO']");
				Function.AssertEqual(true,PPMRQLN_ProjSubParts_Sequence.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing Close on ProjSubPartsForm...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_ProjSubPartsForm = new SeleniumControl( sDriver, "ProjSubPartsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSUBSTPART_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMRQLN_ProjSubPartsForm);
IWebElement formBttn = PPMRQLN_ProjSubPartsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Closing App");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQLN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQLN] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl PPMRQLN_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PPMRQLN_MainForm);
IWebElement formBttn = PPMRQLN_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

