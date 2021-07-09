 
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
    public class POMSCST_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Purchase Orders", "xpath","//div[@class='navItem'][.='Purchase Orders']").Click();
new SeleniumControl(sDriver,"Update Subcontract Retainage PO Status", "xpath","//div[@class='navItem'][.='Update Subcontract Retainage PO Status']").Click();


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
				Function.CurrentComponent = "POMSCST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMSCST] Performing ClickButtonIfExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl POMSCST_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(POMSCST_MainForm);
IWebElement formBttn = POMSCST_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? POMSCST_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
POMSCST_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault();
if (formBttn!=null && formBttn.Displayed)
{ new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click();
this.ScriptLogger.WriteLine("Button [Form] found and clicked.", Logger.MessageType.INF);
}


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButtonIfExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMSCST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMSCST] Performing VerifyExists on StatusUpdateID...", Logger.MessageType.INF);
				SeleniumControl POMSCST_StatusUpdateID = new SeleniumControl( sDriver, "StatusUpdateID", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='RECPT_ID']");
				Function.AssertEqual(true,POMSCST_StatusUpdateID.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMSCST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMSCST] Performing ClickButtonIfExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl POMSCST_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(POMSCST_MainForm);
IWebElement formBttn = POMSCST_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? POMSCST_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
POMSCST_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault();
if (formBttn!=null && formBttn.Displayed)
{ new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click();
this.ScriptLogger.WriteLine("Button [Table] found and clicked.", Logger.MessageType.INF);
}


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButtonIfExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMSCST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMSCST] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl POMSCST_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,POMSCST_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Order Totals");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMSCST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMSCST] Performing VerifyExists on OrderTotalsLink...", Logger.MessageType.INF);
				SeleniumControl POMSCST_OrderTotalsLink = new SeleniumControl( sDriver, "OrderTotalsLink", "ID", "lnk_1004058_POMSCST_RECPTHDR_HDR");
				Function.AssertEqual(true,POMSCST_OrderTotalsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMSCST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMSCST] Performing Click on OrderTotalsLink...", Logger.MessageType.INF);
				SeleniumControl POMSCST_OrderTotalsLink = new SeleniumControl( sDriver, "OrderTotalsLink", "ID", "lnk_1004058_POMSCST_RECPTHDR_HDR");
				Function.WaitControlDisplayed(POMSCST_OrderTotalsLink);
POMSCST_OrderTotalsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMSCST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMSCST] Performing VerifyExists on OrderTotalsForm...", Logger.MessageType.INF);
				SeleniumControl POMSCST_OrderTotalsForm = new SeleniumControl( sDriver, "OrderTotalsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POMSCST_ORDERTOTALS_']/ancestor::form[1]");
				Function.AssertEqual(true,POMSCST_OrderTotalsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMSCST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMSCST] Performing Close on OrderTotalsForm...", Logger.MessageType.INF);
				SeleniumControl POMSCST_OrderTotalsForm = new SeleniumControl( sDriver, "OrderTotalsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POMSCST_ORDERTOTALS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POMSCST_OrderTotalsForm);
IWebElement formBttn = POMSCST_OrderTotalsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Hdr Std Txt");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMSCST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMSCST] Performing VerifyExists on HdrStdTxtLink...", Logger.MessageType.INF);
				SeleniumControl POMSCST_HdrStdTxtLink = new SeleniumControl( sDriver, "HdrStdTxtLink", "ID", "lnk_1004480_POMSCST_RECPTHDR_HDR");
				Function.AssertEqual(true,POMSCST_HdrStdTxtLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMSCST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMSCST] Performing Click on HdrStdTxtLink...", Logger.MessageType.INF);
				SeleniumControl POMSCST_HdrStdTxtLink = new SeleniumControl( sDriver, "HdrStdTxtLink", "ID", "lnk_1004480_POMSCST_RECPTHDR_HDR");
				Function.WaitControlDisplayed(POMSCST_HdrStdTxtLink);
POMSCST_HdrStdTxtLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMSCST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMSCST] Performing VerifyExists on HdrStdTxtForm...", Logger.MessageType.INF);
				SeleniumControl POMSCST_HdrStdTxtForm = new SeleniumControl( sDriver, "HdrStdTxtForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POMSCST_POTEXT_']/ancestor::form[1]");
				Function.AssertEqual(true,POMSCST_HdrStdTxtForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMSCST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMSCST] Performing VerifyExist on HdrStdTxtTable...", Logger.MessageType.INF);
				SeleniumControl POMSCST_HdrStdTxtTable = new SeleniumControl( sDriver, "HdrStdTxtTable", "xpath", "//div[translate(@id,'0123456789','')='pr__POMSCST_POTEXT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,POMSCST_HdrStdTxtTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMSCST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMSCST] Performing Close on HdrStdTxtForm...", Logger.MessageType.INF);
				SeleniumControl POMSCST_HdrStdTxtForm = new SeleniumControl( sDriver, "HdrStdTxtForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POMSCST_POTEXT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POMSCST_HdrStdTxtForm);
IWebElement formBttn = POMSCST_HdrStdTxtForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Header Documents");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMSCST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMSCST] Performing VerifyExists on HeaderDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl POMSCST_HeaderDocumentsLink = new SeleniumControl( sDriver, "HeaderDocumentsLink", "ID", "lnk_1007722_POMSCST_RECPTHDR_HDR");
				Function.AssertEqual(true,POMSCST_HeaderDocumentsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMSCST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMSCST] Performing Click on HeaderDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl POMSCST_HeaderDocumentsLink = new SeleniumControl( sDriver, "HeaderDocumentsLink", "ID", "lnk_1007722_POMSCST_RECPTHDR_HDR");
				Function.WaitControlDisplayed(POMSCST_HeaderDocumentsLink);
POMSCST_HeaderDocumentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMSCST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMSCST] Performing VerifyExists on HeaderDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl POMSCST_HeaderDocumentsForm = new SeleniumControl( sDriver, "HeaderDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POM_PODOCUMENT_']/ancestor::form[1]");
				Function.AssertEqual(true,POMSCST_HeaderDocumentsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMSCST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMSCST] Performing VerifyExist on HeaderDocumentsTable...", Logger.MessageType.INF);
				SeleniumControl POMSCST_HeaderDocumentsTable = new SeleniumControl( sDriver, "HeaderDocumentsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__POM_PODOCUMENT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,POMSCST_HeaderDocumentsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMSCST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMSCST] Performing ClickButtonIfExists on HeaderDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl POMSCST_HeaderDocumentsForm = new SeleniumControl( sDriver, "HeaderDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POM_PODOCUMENT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POMSCST_HeaderDocumentsForm);
IWebElement formBttn = POMSCST_HeaderDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? POMSCST_HeaderDocumentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
POMSCST_HeaderDocumentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault();
if (formBttn!=null && formBttn.Displayed)
{ new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click();
this.ScriptLogger.WriteLine("Button [Form] found and clicked.", Logger.MessageType.INF);
}


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButtonIfExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMSCST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMSCST] Performing VerifyExists on HeaderDocuments_Document...", Logger.MessageType.INF);
				SeleniumControl POMSCST_HeaderDocuments_Document = new SeleniumControl( sDriver, "HeaderDocuments_Document", "xpath", "//div[translate(@id,'0123456789','')='pr__POM_PODOCUMENT_']/ancestor::form[1]/descendant::*[@id='DOCUMENT_ID']");
				Function.AssertEqual(true,POMSCST_HeaderDocuments_Document.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMSCST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMSCST] Performing Close on HeaderDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl POMSCST_HeaderDocumentsForm = new SeleniumControl( sDriver, "HeaderDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POM_PODOCUMENT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POMSCST_HeaderDocumentsForm);
IWebElement formBttn = POMSCST_HeaderDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Sub - Contract");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMSCST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMSCST] Performing VerifyExists on SubContractForm...", Logger.MessageType.INF);
				SeleniumControl POMSCST_SubContractForm = new SeleniumControl( sDriver, "SubContractForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POMSCST_POLN_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,POMSCST_SubContractForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMSCST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMSCST] Performing VerifyExist on SubContractTable...", Logger.MessageType.INF);
				SeleniumControl POMSCST_SubContractTable = new SeleniumControl( sDriver, "SubContractTable", "xpath", "//div[translate(@id,'0123456789','')='pr__POMSCST_POLN_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,POMSCST_SubContractTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMSCST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMSCST] Performing ClickButton on SubContractForm...", Logger.MessageType.INF);
				SeleniumControl POMSCST_SubContractForm = new SeleniumControl( sDriver, "SubContractForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POMSCST_POLN_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POMSCST_SubContractForm);
IWebElement formBttn = POMSCST_SubContractForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? POMSCST_SubContractForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
POMSCST_SubContractForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMSCST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMSCST] Performing VerifyExists on SubcontractLine...", Logger.MessageType.INF);
				SeleniumControl POMSCST_SubcontractLine = new SeleniumControl( sDriver, "SubcontractLine", "xpath", "//div[translate(@id,'0123456789','')='pr__POMSCST_POLN_CTW_']/ancestor::form[1]/descendant::*[@id='PO_LN_NO']");
				Function.AssertEqual(true,POMSCST_SubcontractLine.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMSCST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMSCST] Performing Select on Tab...", Logger.MessageType.INF);
				SeleniumControl POMSCST_Tab = new SeleniumControl( sDriver, "Tab", "xpath", "//div[translate(@id,'0123456789','')='pr__POMSCST_POLN_CTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(POMSCST_Tab);
IWebElement mTab = POMSCST_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Work Details").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMSCST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMSCST] Performing VerifyExists on WorkDetails_RequestedWorkAmt...", Logger.MessageType.INF);
				SeleniumControl POMSCST_WorkDetails_RequestedWorkAmt = new SeleniumControl( sDriver, "WorkDetails_RequestedWorkAmt", "xpath", "//div[translate(@id,'0123456789','')='pr__POMSCST_POLN_CTW_']/ancestor::form[1]/descendant::*[@id='TRN_RQSTD_AMT']");
				Function.AssertEqual(true,POMSCST_WorkDetails_RequestedWorkAmt.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Ln Std Txt");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMSCST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMSCST] Performing VerifyExists on LnStdTxtLink...", Logger.MessageType.INF);
				SeleniumControl POMSCST_LnStdTxtLink = new SeleniumControl( sDriver, "LnStdTxtLink", "ID", "lnk_1003973_POMSCST_POLN_CTW");
				Function.AssertEqual(true,POMSCST_LnStdTxtLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
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
				Function.CurrentComponent = "POMSCST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMSCST] Performing VerifyExists on LineDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl POMSCST_LineDocumentsLink = new SeleniumControl( sDriver, "LineDocumentsLink", "ID", "lnk_1007723_POMSCST_POLN_CTW");
				Function.AssertEqual(true,POMSCST_LineDocumentsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("PO Line Accounts");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMSCST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMSCST] Performing VerifyExists on POLineAccountsXLink...", Logger.MessageType.INF);
				SeleniumControl POMSCST_POLineAccountsXLink = new SeleniumControl( sDriver, "POLineAccountsXLink", "ID", "lnk_1003975_POMSCST_POLN_CTW");
				Function.AssertEqual(true,POMSCST_POLineAccountsXLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
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
				Function.CurrentComponent = "POMSCST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMSCST] Performing VerifyExists on CurrencyLineLink...", Logger.MessageType.INF);
				SeleniumControl POMSCST_CurrencyLineLink = new SeleniumControl( sDriver, "CurrencyLineLink", "ID", "lnk_1004057_POMSCST_POLN_CTW");
				Function.AssertEqual(true,POMSCST_CurrencyLineLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
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
				Function.CurrentComponent = "POMSCST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMSCST] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl POMSCST_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(POMSCST_MainForm);
IWebElement formBttn = POMSCST_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

