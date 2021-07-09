 
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
    public class PDMPRPT_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Product Definition", "xpath","//div[@class='deptItem'][.='Product Definition']").Click();
new SeleniumControl(sDriver,"Provisional Parts", "xpath","//div[@class='navItem'][.='Provisional Parts']").Click();
new SeleniumControl(sDriver,"Manage Provisional Parts", "xpath","//div[@class='navItem'][.='Manage Provisional Parts']").Click();


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
				Function.CurrentComponent = "PDMPRPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPRPT] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl PDMPRPT_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,PDMPRPT_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPRPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPRPT] Performing VerifyExists on ProvisionalPartID...", Logger.MessageType.INF);
				SeleniumControl PDMPRPT_ProvisionalPartID = new SeleniumControl( sDriver, "ProvisionalPartID", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PROV_PART_ID']");
				Function.AssertEqual(true,PDMPRPT_ProvisionalPartID.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPRPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPRPT] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl PDMPRPT_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PDMPRPT_MainFormTab);
IWebElement mTab = PDMPRPT_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Basic Characteristics").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPRPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPRPT] Performing VerifyExists on BasicCharacteristics_ProvisionalPartType...", Logger.MessageType.INF);
				SeleniumControl PDMPRPT_BasicCharacteristics_ProvisionalPartType = new SeleniumControl( sDriver, "BasicCharacteristics_ProvisionalPartType", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PROV_PART_TYPE_CD']");
				Function.AssertEqual(true,PDMPRPT_BasicCharacteristics_ProvisionalPartType.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPRPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPRPT] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl PDMPRPT_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PDMPRPT_MainFormTab);
IWebElement mTab = PDMPRPT_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Order Policy").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPRPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPRPT] Performing VerifyExists on OrderPolicy_OrderPolicy_PolicyType...", Logger.MessageType.INF);
				SeleniumControl PDMPRPT_OrderPolicy_OrderPolicy_PolicyType = new SeleniumControl( sDriver, "OrderPolicy_OrderPolicy_PolicyType", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='S_ORD_POLICY_TYPE']");
				Function.AssertEqual(true,PDMPRPT_OrderPolicy_OrderPolicy_PolicyType.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPRPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPRPT] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl PDMPRPT_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PDMPRPT_MainFormTab);
IWebElement mTab = PDMPRPT_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Comments").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPRPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPRPT] Performing VerifyExists on Comments...", Logger.MessageType.INF);
				SeleniumControl PDMPRPT_Comments = new SeleniumControl( sDriver, "Comments", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PROV_NT']");
				Function.AssertEqual(true,PDMPRPT_Comments.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Documents");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPRPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPRPT] Performing VerifyExists on DocumentsLink...", Logger.MessageType.INF);
				SeleniumControl PDMPRPT_DocumentsLink = new SeleniumControl( sDriver, "DocumentsLink", "ID", "lnk_1002039_PDMPRPT_PROVPART_MATNPROVPARTS");
				Function.AssertEqual(true,PDMPRPT_DocumentsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPRPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPRPT] Performing Click on DocumentsLink...", Logger.MessageType.INF);
				SeleniumControl PDMPRPT_DocumentsLink = new SeleniumControl( sDriver, "DocumentsLink", "ID", "lnk_1002039_PDMPRPT_PROVPART_MATNPROVPARTS");
				Function.WaitControlDisplayed(PDMPRPT_DocumentsLink);
PDMPRPT_DocumentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPRPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPRPT] Performing VerifyExist on DocumentsFormTable...", Logger.MessageType.INF);
				SeleniumControl PDMPRPT_DocumentsFormTable = new SeleniumControl( sDriver, "DocumentsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PDMPRPT_PROVPARTDOCUMENT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PDMPRPT_DocumentsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPRPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPRPT] Performing ClickButton on DocumentsForm...", Logger.MessageType.INF);
				SeleniumControl PDMPRPT_DocumentsForm = new SeleniumControl( sDriver, "DocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PDMPRPT_PROVPARTDOCUMENT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PDMPRPT_DocumentsForm);
IWebElement formBttn = PDMPRPT_DocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PDMPRPT_DocumentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PDMPRPT_DocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPRPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPRPT] Performing VerifyExists on DocumentsForm...", Logger.MessageType.INF);
				SeleniumControl PDMPRPT_DocumentsForm = new SeleniumControl( sDriver, "DocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PDMPRPT_PROVPARTDOCUMENT_']/ancestor::form[1]");
				Function.AssertEqual(true,PDMPRPT_DocumentsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPRPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPRPT] Performing VerifyExists on Documents_Document...", Logger.MessageType.INF);
				SeleniumControl PDMPRPT_Documents_Document = new SeleniumControl( sDriver, "Documents_Document", "xpath", "//div[translate(@id,'0123456789','')='pr__PDMPRPT_PROVPARTDOCUMENT_']/ancestor::form[1]/descendant::*[@id='DOCUMENT_ID']");
				Function.AssertEqual(true,PDMPRPT_Documents_Document.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPRPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPRPT] Performing Close on DocumentsForm...", Logger.MessageType.INF);
				SeleniumControl PDMPRPT_DocumentsForm = new SeleniumControl( sDriver, "DocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PDMPRPT_PROVPARTDOCUMENT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PDMPRPT_DocumentsForm);
IWebElement formBttn = PDMPRPT_DocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Alternate");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPRPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPRPT] Performing VerifyExists on AlternateLink...", Logger.MessageType.INF);
				SeleniumControl PDMPRPT_AlternateLink = new SeleniumControl( sDriver, "AlternateLink", "ID", "lnk_1002040_PDMPRPT_PROVPART_MATNPROVPARTS");
				Function.AssertEqual(true,PDMPRPT_AlternateLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPRPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPRPT] Performing Click on AlternateLink...", Logger.MessageType.INF);
				SeleniumControl PDMPRPT_AlternateLink = new SeleniumControl( sDriver, "AlternateLink", "ID", "lnk_1002040_PDMPRPT_PROVPART_MATNPROVPARTS");
				Function.WaitControlDisplayed(PDMPRPT_AlternateLink);
PDMPRPT_AlternateLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPRPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPRPT] Performing VerifyExist on AlternateFormTable...", Logger.MessageType.INF);
				SeleniumControl PDMPRPT_AlternateFormTable = new SeleniumControl( sDriver, "AlternateFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PDMPRPT_PROVALTPART_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PDMPRPT_AlternateFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPRPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPRPT] Performing ClickButton on AlternateForm...", Logger.MessageType.INF);
				SeleniumControl PDMPRPT_AlternateForm = new SeleniumControl( sDriver, "AlternateForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PDMPRPT_PROVALTPART_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PDMPRPT_AlternateForm);
IWebElement formBttn = PDMPRPT_AlternateForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PDMPRPT_AlternateForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PDMPRPT_AlternateForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPRPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPRPT] Performing VerifyExists on AlternateForm...", Logger.MessageType.INF);
				SeleniumControl PDMPRPT_AlternateForm = new SeleniumControl( sDriver, "AlternateForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PDMPRPT_PROVALTPART_']/ancestor::form[1]");
				Function.AssertEqual(true,PDMPRPT_AlternateForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPRPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPRPT] Performing VerifyExists on Alternate_Sequence...", Logger.MessageType.INF);
				SeleniumControl PDMPRPT_Alternate_Sequence = new SeleniumControl( sDriver, "Alternate_Sequence", "xpath", "//div[translate(@id,'0123456789','')='pr__PDMPRPT_PROVALTPART_']/ancestor::form[1]/descendant::*[@id='SEQ_NO']");
				Function.AssertEqual(true,PDMPRPT_Alternate_Sequence.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPRPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPRPT] Performing Close on AlternateForm...", Logger.MessageType.INF);
				SeleniumControl PDMPRPT_AlternateForm = new SeleniumControl( sDriver, "AlternateForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PDMPRPT_PROVALTPART_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PDMPRPT_AlternateForm);
IWebElement formBttn = PDMPRPT_AlternateForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Lead Time");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPRPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPRPT] Performing VerifyExists on LeadTimeLink...", Logger.MessageType.INF);
				SeleniumControl PDMPRPT_LeadTimeLink = new SeleniumControl( sDriver, "LeadTimeLink", "ID", "lnk_1002197_PDMPRPT_PROVPART_MATNPROVPARTS");
				Function.AssertEqual(true,PDMPRPT_LeadTimeLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPRPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPRPT] Performing Click on LeadTimeLink...", Logger.MessageType.INF);
				SeleniumControl PDMPRPT_LeadTimeLink = new SeleniumControl( sDriver, "LeadTimeLink", "ID", "lnk_1002197_PDMPRPT_PROVPART_MATNPROVPARTS");
				Function.WaitControlDisplayed(PDMPRPT_LeadTimeLink);
PDMPRPT_LeadTimeLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPRPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPRPT] Performing VerifyExist on LeadTime1FormTable...", Logger.MessageType.INF);
				SeleniumControl PDMPRPT_LeadTime1FormTable = new SeleniumControl( sDriver, "LeadTime1FormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PDMPRPT_SLTTYPE_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PDMPRPT_LeadTime1FormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPRPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPRPT] Performing VerifyExist on LeadTime2FormTable...", Logger.MessageType.INF);
				SeleniumControl PDMPRPT_LeadTime2FormTable = new SeleniumControl( sDriver, "LeadTime2FormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PDMPRPT_PROVPARTLT_MTNPROVPT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PDMPRPT_LeadTime2FormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPRPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPRPT] Performing Close on LeadTime2Form...", Logger.MessageType.INF);
				SeleniumControl PDMPRPT_LeadTime2Form = new SeleniumControl( sDriver, "LeadTime2Form", "xpath", "//div[translate(@id,'0123456789','')='pr__PDMPRPT_PROVPARTLT_MTNPROVPT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PDMPRPT_LeadTime2Form);
IWebElement formBttn = PDMPRPT_LeadTime2Form.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Assigned Standard text");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPRPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPRPT] Performing VerifyExists on AssignedStandardTextLink...", Logger.MessageType.INF);
				SeleniumControl PDMPRPT_AssignedStandardTextLink = new SeleniumControl( sDriver, "AssignedStandardTextLink", "ID", "lnk_1002198_PDMPRPT_PROVPART_MATNPROVPARTS");
				Function.AssertEqual(true,PDMPRPT_AssignedStandardTextLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPRPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPRPT] Performing Click on AssignedStandardTextLink...", Logger.MessageType.INF);
				SeleniumControl PDMPRPT_AssignedStandardTextLink = new SeleniumControl( sDriver, "AssignedStandardTextLink", "ID", "lnk_1002198_PDMPRPT_PROVPART_MATNPROVPARTS");
				Function.WaitControlDisplayed(PDMPRPT_AssignedStandardTextLink);
PDMPRPT_AssignedStandardTextLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPRPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPRPT] Performing VerifyExist on StandardTextFormTable...", Logger.MessageType.INF);
				SeleniumControl PDMPRPT_StandardTextFormTable = new SeleniumControl( sDriver, "StandardTextFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PDMPRPT_STDTEXT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PDMPRPT_StandardTextFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPRPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPRPT] Performing VerifyExist on AssignedStandardTextFormTable...", Logger.MessageType.INF);
				SeleniumControl PDMPRPT_AssignedStandardTextFormTable = new SeleniumControl( sDriver, "AssignedStandardTextFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PDMPRPT_PROVPARTTEXT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PDMPRPT_AssignedStandardTextFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPRPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPRPT] Performing Close on AssignedStandardTextForm...", Logger.MessageType.INF);
				SeleniumControl PDMPRPT_AssignedStandardTextForm = new SeleniumControl( sDriver, "AssignedStandardTextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PDMPRPT_PROVPARTTEXT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PDMPRPT_AssignedStandardTextForm);
IWebElement formBttn = PDMPRPT_AssignedStandardTextForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("EBOM Assy");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPRPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPRPT] Performing VerifyExists on EBOMAssyLink...", Logger.MessageType.INF);
				SeleniumControl PDMPRPT_EBOMAssyLink = new SeleniumControl( sDriver, "EBOMAssyLink", "ID", "lnk_1002071_PDMPRPT_PROVPART_MATNPROVPARTS");
				Function.AssertEqual(true,PDMPRPT_EBOMAssyLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPRPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPRPT] Performing Click on EBOMAssyLink...", Logger.MessageType.INF);
				SeleniumControl PDMPRPT_EBOMAssyLink = new SeleniumControl( sDriver, "EBOMAssyLink", "ID", "lnk_1002071_PDMPRPT_PROVPART_MATNPROVPARTS");
				Function.WaitControlDisplayed(PDMPRPT_EBOMAssyLink);
PDMPRPT_EBOMAssyLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPRPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPRPT] Performing VerifyExist on EBOMAssyFormTable...", Logger.MessageType.INF);
				SeleniumControl PDMPRPT_EBOMAssyFormTable = new SeleniumControl( sDriver, "EBOMAssyFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PDMPRPT_ENGBOM_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PDMPRPT_EBOMAssyFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPRPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPRPT] Performing ClickButton on EBOMAssyForm...", Logger.MessageType.INF);
				SeleniumControl PDMPRPT_EBOMAssyForm = new SeleniumControl( sDriver, "EBOMAssyForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PDMPRPT_ENGBOM_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PDMPRPT_EBOMAssyForm);
IWebElement formBttn = PDMPRPT_EBOMAssyForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PDMPRPT_EBOMAssyForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PDMPRPT_EBOMAssyForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPRPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPRPT] Performing VerifyExists on EBOMAssyForm...", Logger.MessageType.INF);
				SeleniumControl PDMPRPT_EBOMAssyForm = new SeleniumControl( sDriver, "EBOMAssyForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PDMPRPT_ENGBOM_']/ancestor::form[1]");
				Function.AssertEqual(true,PDMPRPT_EBOMAssyForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPRPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPRPT] Performing VerifyExists on EBOMAssy_AssemblyPart...", Logger.MessageType.INF);
				SeleniumControl PDMPRPT_EBOMAssy_AssemblyPart = new SeleniumControl( sDriver, "EBOMAssy_AssemblyPart", "xpath", "//div[translate(@id,'0123456789','')='pr__PDMPRPT_ENGBOM_']/ancestor::form[1]/descendant::*[@id='ASY_PART_ID']");
				Function.AssertEqual(true,PDMPRPT_EBOMAssy_AssemblyPart.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPRPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPRPT] Performing Close on EBOMAssyForm...", Logger.MessageType.INF);
				SeleniumControl PDMPRPT_EBOMAssyForm = new SeleniumControl( sDriver, "EBOMAssyForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PDMPRPT_ENGBOM_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PDMPRPT_EBOMAssyForm);
IWebElement formBttn = PDMPRPT_EBOMAssyForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("EBOM Comp");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPRPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPRPT] Performing VerifyExists on EBOMCompLink...", Logger.MessageType.INF);
				SeleniumControl PDMPRPT_EBOMCompLink = new SeleniumControl( sDriver, "EBOMCompLink", "ID", "lnk_1002072_PDMPRPT_PROVPART_MATNPROVPARTS");
				Function.AssertEqual(true,PDMPRPT_EBOMCompLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPRPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPRPT] Performing Click on EBOMCompLink...", Logger.MessageType.INF);
				SeleniumControl PDMPRPT_EBOMCompLink = new SeleniumControl( sDriver, "EBOMCompLink", "ID", "lnk_1002072_PDMPRPT_PROVPART_MATNPROVPARTS");
				Function.WaitControlDisplayed(PDMPRPT_EBOMCompLink);
PDMPRPT_EBOMCompLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPRPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPRPT] Performing VerifyExist on EBOMCompFormTable...", Logger.MessageType.INF);
				SeleniumControl PDMPRPT_EBOMCompFormTable = new SeleniumControl( sDriver, "EBOMCompFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PDMPRPT_ENGBOM_MTNPROVPART_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PDMPRPT_EBOMCompFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPRPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPRPT] Performing ClickButton on EBOMCompForm...", Logger.MessageType.INF);
				SeleniumControl PDMPRPT_EBOMCompForm = new SeleniumControl( sDriver, "EBOMCompForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PDMPRPT_ENGBOM_MTNPROVPART_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PDMPRPT_EBOMCompForm);
IWebElement formBttn = PDMPRPT_EBOMCompForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PDMPRPT_EBOMCompForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PDMPRPT_EBOMCompForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPRPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPRPT] Performing VerifyExists on EBOMCompForm...", Logger.MessageType.INF);
				SeleniumControl PDMPRPT_EBOMCompForm = new SeleniumControl( sDriver, "EBOMCompForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PDMPRPT_ENGBOM_MTNPROVPART_']/ancestor::form[1]");
				Function.AssertEqual(true,PDMPRPT_EBOMCompForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPRPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPRPT] Performing VerifyExists on EBOMComp_CompLine...", Logger.MessageType.INF);
				SeleniumControl PDMPRPT_EBOMComp_CompLine = new SeleniumControl( sDriver, "EBOMComp_CompLine", "xpath", "//div[translate(@id,'0123456789','')='pr__PDMPRPT_ENGBOM_MTNPROVPART_']/ancestor::form[1]/descendant::*[@id='COMP_LN_NO']");
				Function.AssertEqual(true,PDMPRPT_EBOMComp_CompLine.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPRPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPRPT] Performing Close on EBOMCompForm...", Logger.MessageType.INF);
				SeleniumControl PDMPRPT_EBOMCompForm = new SeleniumControl( sDriver, "EBOMCompForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PDMPRPT_ENGBOM_MTNPROVPART_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PDMPRPT_EBOMCompForm);
IWebElement formBttn = PDMPRPT_EBOMCompForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("PBOM");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPRPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPRPT] Performing VerifyExists on PBOMLink...", Logger.MessageType.INF);
				SeleniumControl PDMPRPT_PBOMLink = new SeleniumControl( sDriver, "PBOMLink", "ID", "lnk_1002073_PDMPRPT_PROVPART_MATNPROVPARTS");
				Function.AssertEqual(true,PDMPRPT_PBOMLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPRPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPRPT] Performing Click on PBOMLink...", Logger.MessageType.INF);
				SeleniumControl PDMPRPT_PBOMLink = new SeleniumControl( sDriver, "PBOMLink", "ID", "lnk_1002073_PDMPRPT_PROVPART_MATNPROVPARTS");
				Function.WaitControlDisplayed(PDMPRPT_PBOMLink);
PDMPRPT_PBOMLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPRPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPRPT] Performing VerifyExist on PBOMFormTable...", Logger.MessageType.INF);
				SeleniumControl PDMPRPT_PBOMFormTable = new SeleniumControl( sDriver, "PBOMFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PDMPRPT_PBOMLN_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PDMPRPT_PBOMFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPRPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPRPT] Performing ClickButton on PBOMForm...", Logger.MessageType.INF);
				SeleniumControl PDMPRPT_PBOMForm = new SeleniumControl( sDriver, "PBOMForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PDMPRPT_PBOMLN_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PDMPRPT_PBOMForm);
IWebElement formBttn = PDMPRPT_PBOMForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PDMPRPT_PBOMForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PDMPRPT_PBOMForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPRPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPRPT] Performing VerifyExists on PBOMForm...", Logger.MessageType.INF);
				SeleniumControl PDMPRPT_PBOMForm = new SeleniumControl( sDriver, "PBOMForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PDMPRPT_PBOMLN_']/ancestor::form[1]");
				Function.AssertEqual(true,PDMPRPT_PBOMForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPRPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPRPT] Performing VerifyExists on PBOM_Proposal...", Logger.MessageType.INF);
				SeleniumControl PDMPRPT_PBOM_Proposal = new SeleniumControl( sDriver, "PBOM_Proposal", "xpath", "//div[translate(@id,'0123456789','')='pr__PDMPRPT_PBOMLN_']/ancestor::form[1]/descendant::*[@id='PROP_ID']");
				Function.AssertEqual(true,PDMPRPT_PBOM_Proposal.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPRPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPRPT] Performing Close on PBOMForm...", Logger.MessageType.INF);
				SeleniumControl PDMPRPT_PBOMForm = new SeleniumControl( sDriver, "PBOMForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PDMPRPT_PBOMLN_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PDMPRPT_PBOMForm);
IWebElement formBttn = PDMPRPT_PBOMForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "PDMPRPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPRPT] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl PDMPRPT_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PDMPRPT_MainForm);
IWebElement formBttn = PDMPRPT_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

