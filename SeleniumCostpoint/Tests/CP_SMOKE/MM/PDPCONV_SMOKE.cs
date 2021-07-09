 
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
    public class PDPCONV_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Convert Provisional Parts to Standard Parts", "xpath","//div[@class='navItem'][.='Convert Provisional Parts to Standard Parts']").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SelectMenu]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("MAINFORM");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDPCONV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDPCONV] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl PDPCONV_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,PDPCONV_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDPCONV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDPCONV] Performing VerifyExists on ParameterID...", Logger.MessageType.INF);
				SeleniumControl PDPCONV_ParameterID = new SeleniumControl( sDriver, "ParameterID", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PARM_ID']");
				Function.AssertEqual(true,PDPCONV_ParameterID.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDPCONV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDPCONV] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl PDPCONV_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PDPCONV_MainForm);
IWebElement formBttn = PDPCONV_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? PDPCONV_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
PDPCONV_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDPCONV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDPCONV] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl PDPCONV_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PDPCONV_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
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
				Function.CurrentComponent = "PDPCONV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDPCONV] Performing VerifyExists on ChildForm...", Logger.MessageType.INF);
				SeleniumControl PDPCONV_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PDPCONV_PROVPART_HDR_']/ancestor::form[1]");
				Function.AssertEqual(true,PDPCONV_ChildForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDPCONV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDPCONV] Performing VerifyExist on ChildFormTable...", Logger.MessageType.INF);
				SeleniumControl PDPCONV_ChildFormTable = new SeleniumControl( sDriver, "ChildFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PDPCONV_PROVPART_HDR_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PDPCONV_ChildFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDPCONV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDPCONV] Performing Click on ChildForm_AutoloadTable...", Logger.MessageType.INF);
				SeleniumControl PDPCONV_ChildForm_AutoloadTable = new SeleniumControl( sDriver, "ChildForm_AutoloadTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PDPCONV_PROVPART_HDR_']/ancestor::form[1]/descendant::*[@id='PB1___T']");
				Function.WaitControlDisplayed(PDPCONV_ChildForm_AutoloadTable);
if (PDPCONV_ChildForm_AutoloadTable.mElement.GetAttribute("class") == "popupBtn" && sDriver.BrowserType == "ie")
PDPCONV_ChildForm_AutoloadTable.Click(5,5);
else PDPCONV_ChildForm_AutoloadTable.Click(4.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDPCONV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDPCONV] Performing ClickButton on ChildForm...", Logger.MessageType.INF);
				SeleniumControl PDPCONV_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PDPCONV_PROVPART_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PDPCONV_ChildForm);
IWebElement formBttn = PDPCONV_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PDPCONV_ChildForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PDPCONV_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDPCONV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDPCONV] Performing VerifyExists on ChildForm_ProvisionalPartDetails_Part...", Logger.MessageType.INF);
				SeleniumControl PDPCONV_ChildForm_ProvisionalPartDetails_Part = new SeleniumControl( sDriver, "ChildForm_ProvisionalPartDetails_Part", "xpath", "//div[translate(@id,'0123456789','')='pr__PDPCONV_PROVPART_HDR_']/ancestor::form[1]/descendant::*[@id='PROV_PART_ID']");
				Function.AssertEqual(true,PDPCONV_ChildForm_ProvisionalPartDetails_Part.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Quotes");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDPCONV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDPCONV] Performing Click on QuotesLink...", Logger.MessageType.INF);
				SeleniumControl PDPCONV_QuotesLink = new SeleniumControl( sDriver, "QuotesLink", "ID", "lnk_1004523_PDPCONV_PROVPART_HDR");
				Function.WaitControlDisplayed(PDPCONV_QuotesLink);
PDPCONV_QuotesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDPCONV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDPCONV] Performing VerifyExists on QuotesForm...", Logger.MessageType.INF);
				SeleniumControl PDPCONV_QuotesForm = new SeleniumControl( sDriver, "QuotesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PDPCONV_QTHDR_DTL_']/ancestor::form[1]");
				Function.AssertEqual(true,PDPCONV_QuotesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDPCONV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDPCONV] Performing VerifyExist on QuotesTable...", Logger.MessageType.INF);
				SeleniumControl PDPCONV_QuotesTable = new SeleniumControl( sDriver, "QuotesTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PDPCONV_QTHDR_DTL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PDPCONV_QuotesTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDPCONV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDPCONV] Performing ClickButton on QuotesForm...", Logger.MessageType.INF);
				SeleniumControl PDPCONV_QuotesForm = new SeleniumControl( sDriver, "QuotesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PDPCONV_QTHDR_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PDPCONV_QuotesForm);
IWebElement formBttn = PDPCONV_QuotesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PDPCONV_QuotesForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PDPCONV_QuotesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDPCONV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDPCONV] Performing VerifyExists on Quotes_Quote...", Logger.MessageType.INF);
				SeleniumControl PDPCONV_Quotes_Quote = new SeleniumControl( sDriver, "Quotes_Quote", "xpath", "//div[translate(@id,'0123456789','')='pr__PDPCONV_QTHDR_DTL_']/ancestor::form[1]/descendant::*[@id='QUOTE_ID']");
				Function.AssertEqual(true,PDPCONV_Quotes_Quote.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDPCONV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDPCONV] Performing Close on QuotesForm...", Logger.MessageType.INF);
				SeleniumControl PDPCONV_QuotesForm = new SeleniumControl( sDriver, "QuotesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PDPCONV_QTHDR_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PDPCONV_QuotesForm);
IWebElement formBttn = PDPCONV_QuotesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Ebom Components");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDPCONV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDPCONV] Performing Click on EBOMComponentsLink...", Logger.MessageType.INF);
				SeleniumControl PDPCONV_EBOMComponentsLink = new SeleniumControl( sDriver, "EBOMComponentsLink", "ID", "lnk_1004524_PDPCONV_PROVPART_HDR");
				Function.WaitControlDisplayed(PDPCONV_EBOMComponentsLink);
PDPCONV_EBOMComponentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDPCONV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDPCONV] Performing VerifyExists on EBOMComponentsForm...", Logger.MessageType.INF);
				SeleniumControl PDPCONV_EBOMComponentsForm = new SeleniumControl( sDriver, "EBOMComponentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PDPCONV_ENGBOM_DTL_']/ancestor::form[1]");
				Function.AssertEqual(true,PDPCONV_EBOMComponentsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDPCONV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDPCONV] Performing VerifyExist on EBOMComponentsTable...", Logger.MessageType.INF);
				SeleniumControl PDPCONV_EBOMComponentsTable = new SeleniumControl( sDriver, "EBOMComponentsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PDPCONV_ENGBOM_DTL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PDPCONV_EBOMComponentsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDPCONV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDPCONV] Performing ClickButton on EBOMComponentsForm...", Logger.MessageType.INF);
				SeleniumControl PDPCONV_EBOMComponentsForm = new SeleniumControl( sDriver, "EBOMComponentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PDPCONV_ENGBOM_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PDPCONV_EBOMComponentsForm);
IWebElement formBttn = PDPCONV_EBOMComponentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PDPCONV_EBOMComponentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PDPCONV_EBOMComponentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDPCONV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDPCONV] Performing VerifyExists on EBOMComponents_CompLine...", Logger.MessageType.INF);
				SeleniumControl PDPCONV_EBOMComponents_CompLine = new SeleniumControl( sDriver, "EBOMComponents_CompLine", "xpath", "//div[translate(@id,'0123456789','')='pr__PDPCONV_ENGBOM_DTL_']/ancestor::form[1]/descendant::*[@id='COMP_LN_NO']");
				Function.AssertEqual(true,PDPCONV_EBOMComponents_CompLine.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDPCONV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDPCONV] Performing Close on EBOMComponentsForm...", Logger.MessageType.INF);
				SeleniumControl PDPCONV_EBOMComponentsForm = new SeleniumControl( sDriver, "EBOMComponentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PDPCONV_ENGBOM_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PDPCONV_EBOMComponentsForm);
IWebElement formBttn = PDPCONV_EBOMComponentsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Ebom assemb.");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDPCONV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDPCONV] Performing Click on EBOMAssembliesWhereUsedLink...", Logger.MessageType.INF);
				SeleniumControl PDPCONV_EBOMAssembliesWhereUsedLink = new SeleniumControl( sDriver, "EBOMAssembliesWhereUsedLink", "ID", "lnk_1004525_PDPCONV_PROVPART_HDR");
				Function.WaitControlDisplayed(PDPCONV_EBOMAssembliesWhereUsedLink);
PDPCONV_EBOMAssembliesWhereUsedLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDPCONV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDPCONV] Performing VerifyExists on EBOMAssembliesWhereUsedForm...", Logger.MessageType.INF);
				SeleniumControl PDPCONV_EBOMAssembliesWhereUsedForm = new SeleniumControl( sDriver, "EBOMAssembliesWhereUsedForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PDPCONV_ENGBOM_DTLS_']/ancestor::form[1]");
				Function.AssertEqual(true,PDPCONV_EBOMAssembliesWhereUsedForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDPCONV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDPCONV] Performing VerifyExist on EBOMAssembliesWhereUsedTable...", Logger.MessageType.INF);
				SeleniumControl PDPCONV_EBOMAssembliesWhereUsedTable = new SeleniumControl( sDriver, "EBOMAssembliesWhereUsedTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PDPCONV_ENGBOM_DTLS_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PDPCONV_EBOMAssembliesWhereUsedTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDPCONV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDPCONV] Performing ClickButton on EBOMAssembliesWhereUsedForm...", Logger.MessageType.INF);
				SeleniumControl PDPCONV_EBOMAssembliesWhereUsedForm = new SeleniumControl( sDriver, "EBOMAssembliesWhereUsedForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PDPCONV_ENGBOM_DTLS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PDPCONV_EBOMAssembliesWhereUsedForm);
IWebElement formBttn = PDPCONV_EBOMAssembliesWhereUsedForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PDPCONV_EBOMAssembliesWhereUsedForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PDPCONV_EBOMAssembliesWhereUsedForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDPCONV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDPCONV] Performing VerifyExists on EBOMAssembliesWhereUsed_Assembly_Part...", Logger.MessageType.INF);
				SeleniumControl PDPCONV_EBOMAssembliesWhereUsed_Assembly_Part = new SeleniumControl( sDriver, "EBOMAssembliesWhereUsed_Assembly_Part", "xpath", "//div[translate(@id,'0123456789','')='pr__PDPCONV_ENGBOM_DTLS_']/ancestor::form[1]/descendant::*[@id='ASY_PART_ID']");
				Function.AssertEqual(true,PDPCONV_EBOMAssembliesWhereUsed_Assembly_Part.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDPCONV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDPCONV] Performing Close on EBOMAssembliesWhereUsedForm...", Logger.MessageType.INF);
				SeleniumControl PDPCONV_EBOMAssembliesWhereUsedForm = new SeleniumControl( sDriver, "EBOMAssembliesWhereUsedForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PDPCONV_ENGBOM_DTLS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PDPCONV_EBOMAssembliesWhereUsedForm);
IWebElement formBttn = PDPCONV_EBOMAssembliesWhereUsedForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Proposals");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDPCONV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDPCONV] Performing Click on ProposalsLink...", Logger.MessageType.INF);
				SeleniumControl PDPCONV_ProposalsLink = new SeleniumControl( sDriver, "ProposalsLink", "ID", "lnk_1004526_PDPCONV_PROVPART_HDR");
				Function.WaitControlDisplayed(PDPCONV_ProposalsLink);
PDPCONV_ProposalsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDPCONV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDPCONV] Performing VerifyExists on ProposalsForm...", Logger.MessageType.INF);
				SeleniumControl PDPCONV_ProposalsForm = new SeleniumControl( sDriver, "ProposalsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PDPCONV_PROPHDR_DTL_']/ancestor::form[1]");
				Function.AssertEqual(true,PDPCONV_ProposalsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDPCONV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDPCONV] Performing VerifyExist on ProposalsTable...", Logger.MessageType.INF);
				SeleniumControl PDPCONV_ProposalsTable = new SeleniumControl( sDriver, "ProposalsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PDPCONV_PROPHDR_DTL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PDPCONV_ProposalsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDPCONV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDPCONV] Performing ClickButton on ProposalsForm...", Logger.MessageType.INF);
				SeleniumControl PDPCONV_ProposalsForm = new SeleniumControl( sDriver, "ProposalsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PDPCONV_PROPHDR_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PDPCONV_ProposalsForm);
IWebElement formBttn = PDPCONV_ProposalsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PDPCONV_ProposalsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PDPCONV_ProposalsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDPCONV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDPCONV] Performing VerifyExists on Proposals_Proposal...", Logger.MessageType.INF);
				SeleniumControl PDPCONV_Proposals_Proposal = new SeleniumControl( sDriver, "Proposals_Proposal", "xpath", "//div[translate(@id,'0123456789','')='pr__PDPCONV_PROPHDR_DTL_']/ancestor::form[1]/descendant::*[@id='PROP_ID']");
				Function.AssertEqual(true,PDPCONV_Proposals_Proposal.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDPCONV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDPCONV] Performing Close on ProposalsForm...", Logger.MessageType.INF);
				SeleniumControl PDPCONV_ProposalsForm = new SeleniumControl( sDriver, "ProposalsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PDPCONV_PROPHDR_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PDPCONV_ProposalsForm);
IWebElement formBttn = PDPCONV_ProposalsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Proposals");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDPCONV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDPCONV] Performing Click on RFQsLink...", Logger.MessageType.INF);
				SeleniumControl PDPCONV_RFQsLink = new SeleniumControl( sDriver, "RFQsLink", "ID", "lnk_1004527_PDPCONV_PROVPART_HDR");
				Function.WaitControlDisplayed(PDPCONV_RFQsLink);
PDPCONV_RFQsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDPCONV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDPCONV] Performing VerifyExists on RFQsForm...", Logger.MessageType.INF);
				SeleniumControl PDPCONV_RFQsForm = new SeleniumControl( sDriver, "RFQsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PDPCONV_RFQHDR_DTL_']/ancestor::form[1]");
				Function.AssertEqual(true,PDPCONV_RFQsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDPCONV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDPCONV] Performing VerifyExist on RFQsTable...", Logger.MessageType.INF);
				SeleniumControl PDPCONV_RFQsTable = new SeleniumControl( sDriver, "RFQsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PDPCONV_RFQHDR_DTL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PDPCONV_RFQsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDPCONV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDPCONV] Performing ClickButton on RFQsForm...", Logger.MessageType.INF);
				SeleniumControl PDPCONV_RFQsForm = new SeleniumControl( sDriver, "RFQsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PDPCONV_RFQHDR_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PDPCONV_RFQsForm);
IWebElement formBttn = PDPCONV_RFQsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PDPCONV_RFQsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PDPCONV_RFQsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDPCONV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDPCONV] Performing VerifyExists on RFQs_RFQ...", Logger.MessageType.INF);
				SeleniumControl PDPCONV_RFQs_RFQ = new SeleniumControl( sDriver, "RFQs_RFQ", "xpath", "//div[translate(@id,'0123456789','')='pr__PDPCONV_RFQHDR_DTL_']/ancestor::form[1]/descendant::*[@id='RFQ_ID']");
				Function.AssertEqual(true,PDPCONV_RFQs_RFQ.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDPCONV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDPCONV] Performing Close on RFQsForm...", Logger.MessageType.INF);
				SeleniumControl PDPCONV_RFQsForm = new SeleniumControl( sDriver, "RFQsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PDPCONV_RFQHDR_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PDPCONV_RFQsForm);
IWebElement formBttn = PDPCONV_RFQsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "PDPCONV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDPCONV] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl PDPCONV_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PDPCONV_MainForm);
IWebElement formBttn = PDPCONV_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

