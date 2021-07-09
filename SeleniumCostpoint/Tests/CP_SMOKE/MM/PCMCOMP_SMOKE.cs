 
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
    public class PCMCOMP_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Production Control", "xpath","//div[@class='deptItem'][.='Production Control']").Click();
new SeleniumControl(sDriver,"Manufacturing Orders", "xpath","//div[@class='navItem'][.='Manufacturing Orders']").Click();
new SeleniumControl(sDriver,"Manage MO Operation Completions", "xpath","//div[@class='navItem'][.='Manage MO Operation Completions']").Click();


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
				Function.CurrentComponent = "PCMCOMP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMCOMP] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl PCMCOMP_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMSFR_MAINHDR_']/ancestor::form[1]");
				Function.AssertEqual(true,PCMCOMP_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMCOMP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMCOMP] Performing VerifyExists on Warehouse...", Logger.MessageType.INF);
				SeleniumControl PCMCOMP_Warehouse = new SeleniumControl( sDriver, "Warehouse", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMSFR_MAINHDR_']/ancestor::form[1]/descendant::*[@id='WHSE_ID']");
				Function.AssertEqual(true,PCMCOMP_Warehouse.Exists());

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
				Function.CurrentComponent = "PCMCOMP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMCOMP] Performing VerifyExists on ChildForm...", Logger.MessageType.INF);
				SeleniumControl PCMCOMP_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,PCMCOMP_ChildForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMCOMP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMCOMP] Performing VerifyExist on ChildForm_Table...", Logger.MessageType.INF);
				SeleniumControl PCMCOMP_ChildForm_Table = new SeleniumControl( sDriver, "ChildForm_Table", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMSFR_MOROUTLNCOMPL_HDR_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PCMCOMP_ChildForm_Table.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMCOMP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMCOMP] Performing ClickButtonIfExists on ChildForm...", Logger.MessageType.INF);
				SeleniumControl PCMCOMP_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PCMCOMP_ChildForm);
IWebElement formBttn = PCMCOMP_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PCMCOMP_ChildForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PCMCOMP_ChildForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault();
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
				Function.CurrentComponent = "PCMCOMP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMCOMP] Performing VerifyExists on ChildForm_MO...", Logger.MessageType.INF);
				SeleniumControl PCMCOMP_ChildForm_MO = new SeleniumControl( sDriver, "ChildForm_MO", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='MO_ID']");
				Function.AssertEqual(true,PCMCOMP_ChildForm_MO.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Header Detail");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMCOMP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMCOMP] Performing VerifyExists on ChildForm_HeaderDetailLink...", Logger.MessageType.INF);
				SeleniumControl PCMCOMP_ChildForm_HeaderDetailLink = new SeleniumControl( sDriver, "ChildForm_HeaderDetailLink", "ID", "lnk_19144_PCMSFR_MOROUTLNCOMPL_HDR");
				Function.AssertEqual(true,PCMCOMP_ChildForm_HeaderDetailLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMCOMP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMCOMP] Performing Click on ChildForm_HeaderDetailLink...", Logger.MessageType.INF);
				SeleniumControl PCMCOMP_ChildForm_HeaderDetailLink = new SeleniumControl( sDriver, "ChildForm_HeaderDetailLink", "ID", "lnk_19144_PCMSFR_MOROUTLNCOMPL_HDR");
				Function.WaitControlDisplayed(PCMCOMP_ChildForm_HeaderDetailLink);
PCMCOMP_ChildForm_HeaderDetailLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMCOMP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMCOMP] Performing VerifyExists on HeaderDetailForm...", Logger.MessageType.INF);
				SeleniumControl PCMCOMP_HeaderDetailForm = new SeleniumControl( sDriver, "HeaderDetailForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMSFR_MOHDR_DTL_']/ancestor::form[1]");
				Function.AssertEqual(true,PCMCOMP_HeaderDetailForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMCOMP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMCOMP] Performing VerifyExists on HeaderDetail_MO...", Logger.MessageType.INF);
				SeleniumControl PCMCOMP_HeaderDetail_MO = new SeleniumControl( sDriver, "HeaderDetail_MO", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMSFR_MOHDR_DTL_']/ancestor::form[1]/descendant::*[@id='MO_ID']");
				Function.AssertEqual(true,PCMCOMP_HeaderDetail_MO.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMCOMP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMCOMP] Performing Close on HeaderDetailForm...", Logger.MessageType.INF);
				SeleniumControl PCMCOMP_HeaderDetailForm = new SeleniumControl( sDriver, "HeaderDetailForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMSFR_MOHDR_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCMCOMP_HeaderDetailForm);
IWebElement formBttn = PCMCOMP_HeaderDetailForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("MO Text");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMCOMP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMCOMP] Performing VerifyExists on ChildForm_MOTextLink...", Logger.MessageType.INF);
				SeleniumControl PCMCOMP_ChildForm_MOTextLink = new SeleniumControl( sDriver, "ChildForm_MOTextLink", "ID", "lnk_19145_PCMSFR_MOROUTLNCOMPL_HDR");
				Function.AssertEqual(true,PCMCOMP_ChildForm_MOTextLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMCOMP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMCOMP] Performing Click on ChildForm_MOTextLink...", Logger.MessageType.INF);
				SeleniumControl PCMCOMP_ChildForm_MOTextLink = new SeleniumControl( sDriver, "ChildForm_MOTextLink", "ID", "lnk_19145_PCMSFR_MOROUTLNCOMPL_HDR");
				Function.WaitControlDisplayed(PCMCOMP_ChildForm_MOTextLink);
PCMCOMP_ChildForm_MOTextLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMCOMP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMCOMP] Performing VerifyExists on MOTextForm...", Logger.MessageType.INF);
				SeleniumControl PCMCOMP_MOTextForm = new SeleniumControl( sDriver, "MOTextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMSFR_MOHDRTEXT_DTL_']/ancestor::form[1]");
				Function.AssertEqual(true,PCMCOMP_MOTextForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMCOMP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMCOMP] Performing ClickButtonIfExists on MOTextForm...", Logger.MessageType.INF);
				SeleniumControl PCMCOMP_MOTextForm = new SeleniumControl( sDriver, "MOTextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMSFR_MOHDRTEXT_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCMCOMP_MOTextForm);
IWebElement formBttn = PCMCOMP_MOTextForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? PCMCOMP_MOTextForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
PCMCOMP_MOTextForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault();
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
				Function.CurrentComponent = "PCMCOMP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMCOMP] Performing VerifyExist on MOText_Table...", Logger.MessageType.INF);
				SeleniumControl PCMCOMP_MOText_Table = new SeleniumControl( sDriver, "MOText_Table", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMSFR_MOHDRTEXT_DTL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PCMCOMP_MOText_Table.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMCOMP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMCOMP] Performing Close on MOTextForm...", Logger.MessageType.INF);
				SeleniumControl PCMCOMP_MOTextForm = new SeleniumControl( sDriver, "MOTextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMSFR_MOHDRTEXT_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCMCOMP_MOTextForm);
IWebElement formBttn = PCMCOMP_MOTextForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Routings");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMCOMP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMCOMP] Performing VerifyExists on ChildForm_RoutingsLink...", Logger.MessageType.INF);
				SeleniumControl PCMCOMP_ChildForm_RoutingsLink = new SeleniumControl( sDriver, "ChildForm_RoutingsLink", "ID", "lnk_19146_PCMSFR_MOROUTLNCOMPL_HDR");
				Function.AssertEqual(true,PCMCOMP_ChildForm_RoutingsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMCOMP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMCOMP] Performing Click on ChildForm_RoutingsLink...", Logger.MessageType.INF);
				SeleniumControl PCMCOMP_ChildForm_RoutingsLink = new SeleniumControl( sDriver, "ChildForm_RoutingsLink", "ID", "lnk_19146_PCMSFR_MOROUTLNCOMPL_HDR");
				Function.WaitControlDisplayed(PCMCOMP_ChildForm_RoutingsLink);
PCMCOMP_ChildForm_RoutingsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMCOMP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMCOMP] Performing VerifyExist on Routings_Table...", Logger.MessageType.INF);
				SeleniumControl PCMCOMP_Routings_Table = new SeleniumControl( sDriver, "Routings_Table", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMSFR_MOROUTING_DTL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PCMCOMP_Routings_Table.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMCOMP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMCOMP] Performing ClickButtonIfExists on RoutingsForm...", Logger.MessageType.INF);
				SeleniumControl PCMCOMP_RoutingsForm = new SeleniumControl( sDriver, "RoutingsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMSFR_MOROUTING_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCMCOMP_RoutingsForm);
IWebElement formBttn = PCMCOMP_RoutingsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PCMCOMP_RoutingsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PCMCOMP_RoutingsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault();
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
				Function.CurrentComponent = "PCMCOMP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMCOMP] Performing VerifyExists on RoutingsForm...", Logger.MessageType.INF);
				SeleniumControl PCMCOMP_RoutingsForm = new SeleniumControl( sDriver, "RoutingsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMSFR_MOROUTING_DTL_']/ancestor::form[1]");
				Function.AssertEqual(true,PCMCOMP_RoutingsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMCOMP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMCOMP] Performing VerifyExists on Routings_Operation_Sequence...", Logger.MessageType.INF);
				SeleniumControl PCMCOMP_Routings_Operation_Sequence = new SeleniumControl( sDriver, "Routings_Operation_Sequence", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMSFR_MOROUTING_DTL_']/ancestor::form[1]/descendant::*[@id='MO_OPER_SEQ_NO']");
				Function.AssertEqual(true,PCMCOMP_Routings_Operation_Sequence.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMCOMP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMCOMP] Performing Close on RoutingsForm...", Logger.MessageType.INF);
				SeleniumControl PCMCOMP_RoutingsForm = new SeleniumControl( sDriver, "RoutingsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMSFR_MOROUTING_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCMCOMP_RoutingsForm);
IWebElement formBttn = PCMCOMP_RoutingsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Routing Header Notes");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMCOMP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMCOMP] Performing VerifyExists on ChildForm_RoutingHeaderNotesLink...", Logger.MessageType.INF);
				SeleniumControl PCMCOMP_ChildForm_RoutingHeaderNotesLink = new SeleniumControl( sDriver, "ChildForm_RoutingHeaderNotesLink", "ID", "lnk_19147_PCMSFR_MOROUTLNCOMPL_HDR");
				Function.AssertEqual(true,PCMCOMP_ChildForm_RoutingHeaderNotesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMCOMP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMCOMP] Performing Click on ChildForm_RoutingHeaderNotesLink...", Logger.MessageType.INF);
				SeleniumControl PCMCOMP_ChildForm_RoutingHeaderNotesLink = new SeleniumControl( sDriver, "ChildForm_RoutingHeaderNotesLink", "ID", "lnk_19147_PCMSFR_MOROUTLNCOMPL_HDR");
				Function.WaitControlDisplayed(PCMCOMP_ChildForm_RoutingHeaderNotesLink);
PCMCOMP_ChildForm_RoutingHeaderNotesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMCOMP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMCOMP] Performing VerifyExists on RoutingHeaderNotesForm...", Logger.MessageType.INF);
				SeleniumControl PCMCOMP_RoutingHeaderNotesForm = new SeleniumControl( sDriver, "RoutingHeaderNotesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMSFR_ROUTINGHDR_NOTES_']/ancestor::form[1]");
				Function.AssertEqual(true,PCMCOMP_RoutingHeaderNotesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMCOMP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMCOMP] Performing ClickButton on RoutingHeaderNotesForm...", Logger.MessageType.INF);
				SeleniumControl PCMCOMP_RoutingHeaderNotesForm = new SeleniumControl( sDriver, "RoutingHeaderNotesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMSFR_ROUTINGHDR_NOTES_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCMCOMP_RoutingHeaderNotesForm);
IWebElement formBttn = PCMCOMP_RoutingHeaderNotesForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? PCMCOMP_RoutingHeaderNotesForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
PCMCOMP_RoutingHeaderNotesForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMCOMP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMCOMP] Performing VerifyExist on RoutingHeaderNotes_Table...", Logger.MessageType.INF);
				SeleniumControl PCMCOMP_RoutingHeaderNotes_Table = new SeleniumControl( sDriver, "RoutingHeaderNotes_Table", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMSFR_ROUTINGHDR_NOTES_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PCMCOMP_RoutingHeaderNotes_Table.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMCOMP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMCOMP] Performing Close on RoutingHeaderNotesForm...", Logger.MessageType.INF);
				SeleniumControl PCMCOMP_RoutingHeaderNotesForm = new SeleniumControl( sDriver, "RoutingHeaderNotesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMSFR_ROUTINGHDR_NOTES_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCMCOMP_RoutingHeaderNotesForm);
IWebElement formBttn = PCMCOMP_RoutingHeaderNotesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("QC Inspections");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMCOMP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMCOMP] Performing VerifyExists on ChildForm_QCInspectionsLink...", Logger.MessageType.INF);
				SeleniumControl PCMCOMP_ChildForm_QCInspectionsLink = new SeleniumControl( sDriver, "ChildForm_QCInspectionsLink", "ID", "lnk_19148_PCMSFR_MOROUTLNCOMPL_HDR");
				Function.AssertEqual(true,PCMCOMP_ChildForm_QCInspectionsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMCOMP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMCOMP] Performing Click on ChildForm_QCInspectionsLink...", Logger.MessageType.INF);
				SeleniumControl PCMCOMP_ChildForm_QCInspectionsLink = new SeleniumControl( sDriver, "ChildForm_QCInspectionsLink", "ID", "lnk_19148_PCMSFR_MOROUTLNCOMPL_HDR");
				Function.WaitControlDisplayed(PCMCOMP_ChildForm_QCInspectionsLink);
PCMCOMP_ChildForm_QCInspectionsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMCOMP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMCOMP] Performing VerifyExists on QCInspectionsForm...", Logger.MessageType.INF);
				SeleniumControl PCMCOMP_QCInspectionsForm = new SeleniumControl( sDriver, "QCInspectionsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMSFR_MOROUTLNINSP_DTL_']/ancestor::form[1]");
				Function.AssertEqual(true,PCMCOMP_QCInspectionsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMCOMP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMCOMP] Performing VerifyExist on QCInspections_Table...", Logger.MessageType.INF);
				SeleniumControl PCMCOMP_QCInspections_Table = new SeleniumControl( sDriver, "QCInspections_Table", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMSFR_MOROUTLNINSP_DTL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PCMCOMP_QCInspections_Table.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMCOMP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMCOMP] Performing ClickButton on QCInspectionsForm...", Logger.MessageType.INF);
				SeleniumControl PCMCOMP_QCInspectionsForm = new SeleniumControl( sDriver, "QCInspectionsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMSFR_MOROUTLNINSP_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCMCOMP_QCInspectionsForm);
IWebElement formBttn = PCMCOMP_QCInspectionsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PCMCOMP_QCInspectionsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PCMCOMP_QCInspectionsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMCOMP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMCOMP] Performing VerifyExists on QCInspections_InspectionReport...", Logger.MessageType.INF);
				SeleniumControl PCMCOMP_QCInspections_InspectionReport = new SeleniumControl( sDriver, "QCInspections_InspectionReport", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMSFR_MOROUTLNINSP_DTL_']/ancestor::form[1]/descendant::*[@id='INSP_RPT_ID']");
				Function.AssertEqual(true,PCMCOMP_QCInspections_InspectionReport.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMCOMP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMCOMP] Performing Close on QCInspectionsForm...", Logger.MessageType.INF);
				SeleniumControl PCMCOMP_QCInspectionsForm = new SeleniumControl( sDriver, "QCInspectionsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMSFR_MOROUTLNINSP_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCMCOMP_QCInspectionsForm);
IWebElement formBttn = PCMCOMP_QCInspectionsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Subcontractor Reqs/Pos");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMCOMP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMCOMP] Performing VerifyExists on ChildForm_SubcontractorReqsPOsLink...", Logger.MessageType.INF);
				SeleniumControl PCMCOMP_ChildForm_SubcontractorReqsPOsLink = new SeleniumControl( sDriver, "ChildForm_SubcontractorReqsPOsLink", "ID", "lnk_19149_PCMSFR_MOROUTLNCOMPL_HDR");
				Function.AssertEqual(true,PCMCOMP_ChildForm_SubcontractorReqsPOsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMCOMP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMCOMP] Performing Click on ChildForm_SubcontractorReqsPOsLink...", Logger.MessageType.INF);
				SeleniumControl PCMCOMP_ChildForm_SubcontractorReqsPOsLink = new SeleniumControl( sDriver, "ChildForm_SubcontractorReqsPOsLink", "ID", "lnk_19149_PCMSFR_MOROUTLNCOMPL_HDR");
				Function.WaitControlDisplayed(PCMCOMP_ChildForm_SubcontractorReqsPOsLink);
PCMCOMP_ChildForm_SubcontractorReqsPOsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMCOMP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMCOMP] Performing VerifyExists on SubContractorReqsPOsForm...", Logger.MessageType.INF);
				SeleniumControl PCMCOMP_SubContractorReqsPOsForm = new SeleniumControl( sDriver, "SubContractorReqsPOsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCM_SUBREQPOS_']/ancestor::form[1]");
				Function.AssertEqual(true,PCMCOMP_SubContractorReqsPOsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMCOMP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMCOMP] Performing VerifyExist on SubContractorReqsPOs_PurchaseOrder_Table...", Logger.MessageType.INF);
				SeleniumControl PCMCOMP_SubContractorReqsPOs_PurchaseOrder_Table = new SeleniumControl( sDriver, "SubContractorReqsPOs_PurchaseOrder_Table", "xpath", "//div[translate(@id,'0123456789','')='pr__PCM_SUBREQPOS_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PCMCOMP_SubContractorReqsPOs_PurchaseOrder_Table.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMCOMP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMCOMP] Performing ClickButton on SubContractorReqsPOsForm...", Logger.MessageType.INF);
				SeleniumControl PCMCOMP_SubContractorReqsPOsForm = new SeleniumControl( sDriver, "SubContractorReqsPOsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCM_SUBREQPOS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCMCOMP_SubContractorReqsPOsForm);
IWebElement formBttn = PCMCOMP_SubContractorReqsPOsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PCMCOMP_SubContractorReqsPOsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PCMCOMP_SubContractorReqsPOsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMCOMP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMCOMP] Performing VerifyExists on SubContractorReqsPOs_Requisition_Requisition...", Logger.MessageType.INF);
				SeleniumControl PCMCOMP_SubContractorReqsPOs_Requisition_Requisition = new SeleniumControl( sDriver, "SubContractorReqsPOs_Requisition_Requisition", "xpath", "//div[translate(@id,'0123456789','')='pr__PCM_SUBREQPOS_']/ancestor::form[1]/descendant::*[@id='RQ_ID']");
				Function.AssertEqual(true,PCMCOMP_SubContractorReqsPOs_Requisition_Requisition.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMCOMP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMCOMP] Performing Close on SubContractorReqsPOsForm...", Logger.MessageType.INF);
				SeleniumControl PCMCOMP_SubContractorReqsPOsForm = new SeleniumControl( sDriver, "SubContractorReqsPOsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCM_SUBREQPOS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCMCOMP_SubContractorReqsPOsForm);
IWebElement formBttn = PCMCOMP_SubContractorReqsPOsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
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
				Function.CurrentComponent = "PCMCOMP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMCOMP] Performing VerifyExists on ChildForm_DocumentsLink...", Logger.MessageType.INF);
				SeleniumControl PCMCOMP_ChildForm_DocumentsLink = new SeleniumControl( sDriver, "ChildForm_DocumentsLink", "ID", "lnk_19150_PCMSFR_MOROUTLNCOMPL_HDR");
				Function.AssertEqual(true,PCMCOMP_ChildForm_DocumentsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMCOMP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMCOMP] Performing Click on ChildForm_DocumentsLink...", Logger.MessageType.INF);
				SeleniumControl PCMCOMP_ChildForm_DocumentsLink = new SeleniumControl( sDriver, "ChildForm_DocumentsLink", "ID", "lnk_19150_PCMSFR_MOROUTLNCOMPL_HDR");
				Function.WaitControlDisplayed(PCMCOMP_ChildForm_DocumentsLink);
PCMCOMP_ChildForm_DocumentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMCOMP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMCOMP] Performing VerifyExists on DocumentsForm...", Logger.MessageType.INF);
				SeleniumControl PCMCOMP_DocumentsForm = new SeleniumControl( sDriver, "DocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCM_MODOCUMENT_']/ancestor::form[1]");
				Function.AssertEqual(true,PCMCOMP_DocumentsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMCOMP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMCOMP] Performing VerifyExist on Documents_Table...", Logger.MessageType.INF);
				SeleniumControl PCMCOMP_Documents_Table = new SeleniumControl( sDriver, "Documents_Table", "xpath", "//div[translate(@id,'0123456789','')='pr__PCM_MODOCUMENT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PCMCOMP_Documents_Table.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMCOMP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMCOMP] Performing ClickButton on DocumentsForm...", Logger.MessageType.INF);
				SeleniumControl PCMCOMP_DocumentsForm = new SeleniumControl( sDriver, "DocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCM_MODOCUMENT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCMCOMP_DocumentsForm);
IWebElement formBttn = PCMCOMP_DocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PCMCOMP_DocumentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PCMCOMP_DocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMCOMP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMCOMP] Performing VerifyExists on Documents_Document...", Logger.MessageType.INF);
				SeleniumControl PCMCOMP_Documents_Document = new SeleniumControl( sDriver, "Documents_Document", "xpath", "//div[translate(@id,'0123456789','')='pr__PCM_MODOCUMENT_']/ancestor::form[1]/descendant::*[@id='DOCUMENT_ID']");
				Function.AssertEqual(true,PCMCOMP_Documents_Document.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMCOMP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMCOMP] Performing Close on DocumentsForm...", Logger.MessageType.INF);
				SeleniumControl PCMCOMP_DocumentsForm = new SeleniumControl( sDriver, "DocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCM_MODOCUMENT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCMCOMP_DocumentsForm);
IWebElement formBttn = PCMCOMP_DocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Part Documents");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMCOMP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMCOMP] Performing VerifyExists on ChildForm_PartDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl PCMCOMP_ChildForm_PartDocumentsLink = new SeleniumControl( sDriver, "ChildForm_PartDocumentsLink", "ID", "lnk_19151_PCMSFR_MOROUTLNCOMPL_HDR");
				Function.AssertEqual(true,PCMCOMP_ChildForm_PartDocumentsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMCOMP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMCOMP] Performing Click on ChildForm_PartDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl PCMCOMP_ChildForm_PartDocumentsLink = new SeleniumControl( sDriver, "ChildForm_PartDocumentsLink", "ID", "lnk_19151_PCMSFR_MOROUTLNCOMPL_HDR");
				Function.WaitControlDisplayed(PCMCOMP_ChildForm_PartDocumentsLink);
PCMCOMP_ChildForm_PartDocumentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMCOMP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMCOMP] Performing VerifyExists on PartDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl PCMCOMP_PartDocumentsForm = new SeleniumControl( sDriver, "PartDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]");
				Function.AssertEqual(true,PCMCOMP_PartDocumentsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMCOMP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMCOMP] Performing VerifyExist on PartDocuments_Table...", Logger.MessageType.INF);
				SeleniumControl PCMCOMP_PartDocuments_Table = new SeleniumControl( sDriver, "PartDocuments_Table", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PCMCOMP_PartDocuments_Table.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMCOMP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMCOMP] Performing ClickButton on PartDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl PCMCOMP_PartDocumentsForm = new SeleniumControl( sDriver, "PartDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCMCOMP_PartDocumentsForm);
IWebElement formBttn = PCMCOMP_PartDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PCMCOMP_PartDocumentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PCMCOMP_PartDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMCOMP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMCOMP] Performing VerifyExists on PartDocuments_Type...", Logger.MessageType.INF);
				SeleniumControl PCMCOMP_PartDocuments_Type = new SeleniumControl( sDriver, "PartDocuments_Type", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]/descendant::*[@id='DOC_TYPE_CD']");
				Function.AssertEqual(true,PCMCOMP_PartDocuments_Type.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMCOMP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMCOMP] Performing Close on PartDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl PCMCOMP_PartDocumentsForm = new SeleniumControl( sDriver, "PartDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCMCOMP_PartDocumentsForm);
IWebElement formBttn = PCMCOMP_PartDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "PCMCOMP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMCOMP] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl PCMCOMP_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMSFR_MAINHDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCMCOMP_MainForm);
IWebElement formBttn = PCMCOMP_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

