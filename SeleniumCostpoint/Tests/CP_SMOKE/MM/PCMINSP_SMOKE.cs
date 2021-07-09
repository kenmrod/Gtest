 
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
    public class PCMINSP_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Manage MO Quality Control Inspection Results", "xpath","//div[@class='navItem'][.='Manage MO Quality Control Inspection Results']").Click();


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
				Function.CurrentComponent = "PCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMINSP] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl PCMINSP_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMSFR_MAINHDR_']/ancestor::form[1]");
				Function.AssertEqual(true,PCMINSP_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMINSP] Performing VerifyExists on Warehouse...", Logger.MessageType.INF);
				SeleniumControl PCMINSP_Warehouse = new SeleniumControl( sDriver, "Warehouse", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMSFR_MAINHDR_']/ancestor::form[1]/descendant::*[@id='WHSE_ID']");
				Function.AssertEqual(true,PCMINSP_Warehouse.Exists());

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
				Function.CurrentComponent = "PCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMINSP] Performing VerifyExists on ChildForm...", Logger.MessageType.INF);
				SeleniumControl PCMINSP_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,PCMINSP_ChildForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMINSP] Performing VerifyExist on ChildForm_Table...", Logger.MessageType.INF);
				SeleniumControl PCMINSP_ChildForm_Table = new SeleniumControl( sDriver, "ChildForm_Table", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PCMINSP_ChildForm_Table.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMINSP] Performing ClickButton on ChildForm...", Logger.MessageType.INF);
				SeleniumControl PCMINSP_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PCMINSP_ChildForm);
IWebElement formBttn = PCMINSP_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PCMINSP_ChildForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PCMINSP_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMINSP] Performing VerifyExists on ChildForm_MO...", Logger.MessageType.INF);
				SeleniumControl PCMINSP_ChildForm_MO = new SeleniumControl( sDriver, "ChildForm_MO", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='MO_ID']");
				Function.AssertEqual(true,PCMINSP_ChildForm_MO.Exists());

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
				Function.CurrentComponent = "PCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMINSP] Performing VerifyExists on ChildForm_HeaderDetailLink...", Logger.MessageType.INF);
				SeleniumControl PCMINSP_ChildForm_HeaderDetailLink = new SeleniumControl( sDriver, "ChildForm_HeaderDetailLink", "ID", "lnk_19171_PCMSFR_MOROUTLNINSP_HDR");
				Function.AssertEqual(true,PCMINSP_ChildForm_HeaderDetailLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMINSP] Performing Click on ChildForm_HeaderDetailLink...", Logger.MessageType.INF);
				SeleniumControl PCMINSP_ChildForm_HeaderDetailLink = new SeleniumControl( sDriver, "ChildForm_HeaderDetailLink", "ID", "lnk_19171_PCMSFR_MOROUTLNINSP_HDR");
				Function.WaitControlDisplayed(PCMINSP_ChildForm_HeaderDetailLink);
PCMINSP_ChildForm_HeaderDetailLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMINSP] Performing VerifyExists on HeaderDetailForm...", Logger.MessageType.INF);
				SeleniumControl PCMINSP_HeaderDetailForm = new SeleniumControl( sDriver, "HeaderDetailForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMSFR_MOHDR_DTL_']/ancestor::form[1]");
				Function.AssertEqual(true,PCMINSP_HeaderDetailForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMINSP] Performing VerifyExists on HeaderDetail_MO...", Logger.MessageType.INF);
				SeleniumControl PCMINSP_HeaderDetail_MO = new SeleniumControl( sDriver, "HeaderDetail_MO", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMSFR_MOHDR_DTL_']/ancestor::form[1]/descendant::*[@id='MO_ID']");
				Function.AssertEqual(true,PCMINSP_HeaderDetail_MO.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMINSP] Performing Close on HeaderDetailForm...", Logger.MessageType.INF);
				SeleniumControl PCMINSP_HeaderDetailForm = new SeleniumControl( sDriver, "HeaderDetailForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMSFR_MOHDR_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCMINSP_HeaderDetailForm);
IWebElement formBttn = PCMINSP_HeaderDetailForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "PCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMINSP] Performing VerifyExists on ChildForm_MOTextLink...", Logger.MessageType.INF);
				SeleniumControl PCMINSP_ChildForm_MOTextLink = new SeleniumControl( sDriver, "ChildForm_MOTextLink", "ID", "lnk_19172_PCMSFR_MOROUTLNINSP_HDR");
				Function.AssertEqual(true,PCMINSP_ChildForm_MOTextLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMINSP] Performing Click on ChildForm_MOTextLink...", Logger.MessageType.INF);
				SeleniumControl PCMINSP_ChildForm_MOTextLink = new SeleniumControl( sDriver, "ChildForm_MOTextLink", "ID", "lnk_19172_PCMSFR_MOROUTLNINSP_HDR");
				Function.WaitControlDisplayed(PCMINSP_ChildForm_MOTextLink);
PCMINSP_ChildForm_MOTextLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMINSP] Performing VerifyExists on MOTextForm...", Logger.MessageType.INF);
				SeleniumControl PCMINSP_MOTextForm = new SeleniumControl( sDriver, "MOTextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMSFR_MOHDRTEXT_DTL_']/ancestor::form[1]");
				Function.AssertEqual(true,PCMINSP_MOTextForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMINSP] Performing ClickButton on MOTextForm...", Logger.MessageType.INF);
				SeleniumControl PCMINSP_MOTextForm = new SeleniumControl( sDriver, "MOTextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMSFR_MOHDRTEXT_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCMINSP_MOTextForm);
IWebElement formBttn = PCMINSP_MOTextForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? PCMINSP_MOTextForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
PCMINSP_MOTextForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMINSP] Performing VerifyExist on MOText_Table...", Logger.MessageType.INF);
				SeleniumControl PCMINSP_MOText_Table = new SeleniumControl( sDriver, "MOText_Table", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMSFR_MOHDRTEXT_DTL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PCMINSP_MOText_Table.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMINSP] Performing Close on MOTextForm...", Logger.MessageType.INF);
				SeleniumControl PCMINSP_MOTextForm = new SeleniumControl( sDriver, "MOTextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMSFR_MOHDRTEXT_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCMINSP_MOTextForm);
IWebElement formBttn = PCMINSP_MOTextForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "PCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMINSP] Performing VerifyExists on ChildForm_RoutingsLink...", Logger.MessageType.INF);
				SeleniumControl PCMINSP_ChildForm_RoutingsLink = new SeleniumControl( sDriver, "ChildForm_RoutingsLink", "ID", "lnk_19173_PCMSFR_MOROUTLNINSP_HDR");
				Function.AssertEqual(true,PCMINSP_ChildForm_RoutingsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMINSP] Performing Click on ChildForm_RoutingsLink...", Logger.MessageType.INF);
				SeleniumControl PCMINSP_ChildForm_RoutingsLink = new SeleniumControl( sDriver, "ChildForm_RoutingsLink", "ID", "lnk_19173_PCMSFR_MOROUTLNINSP_HDR");
				Function.WaitControlDisplayed(PCMINSP_ChildForm_RoutingsLink);
PCMINSP_ChildForm_RoutingsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMINSP] Performing VerifyExists on RoutingsForm...", Logger.MessageType.INF);
				SeleniumControl PCMINSP_RoutingsForm = new SeleniumControl( sDriver, "RoutingsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMSFR_MOROUTING_DTL_']/ancestor::form[1]");
				Function.AssertEqual(true,PCMINSP_RoutingsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMINSP] Performing VerifyExist on Routings_Table...", Logger.MessageType.INF);
				SeleniumControl PCMINSP_Routings_Table = new SeleniumControl( sDriver, "Routings_Table", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMSFR_MOROUTING_DTL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PCMINSP_Routings_Table.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMINSP] Performing ClickButton on RoutingsForm...", Logger.MessageType.INF);
				SeleniumControl PCMINSP_RoutingsForm = new SeleniumControl( sDriver, "RoutingsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMSFR_MOROUTING_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCMINSP_RoutingsForm);
IWebElement formBttn = PCMINSP_RoutingsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PCMINSP_RoutingsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PCMINSP_RoutingsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMINSP] Performing VerifyExists on Routings_Operation_Sequence...", Logger.MessageType.INF);
				SeleniumControl PCMINSP_Routings_Operation_Sequence = new SeleniumControl( sDriver, "Routings_Operation_Sequence", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMSFR_MOROUTING_DTL_']/ancestor::form[1]/descendant::*[@id='MO_OPER_SEQ_NO']");
				Function.AssertEqual(true,PCMINSP_Routings_Operation_Sequence.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMINSP] Performing Close on RoutingsForm...", Logger.MessageType.INF);
				SeleniumControl PCMINSP_RoutingsForm = new SeleniumControl( sDriver, "RoutingsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMSFR_MOROUTING_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCMINSP_RoutingsForm);
IWebElement formBttn = PCMINSP_RoutingsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "PCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMINSP] Performing VerifyExists on ChildForm_RoutingHeaderNotesLink...", Logger.MessageType.INF);
				SeleniumControl PCMINSP_ChildForm_RoutingHeaderNotesLink = new SeleniumControl( sDriver, "ChildForm_RoutingHeaderNotesLink", "ID", "lnk_19174_PCMSFR_MOROUTLNINSP_HDR");
				Function.AssertEqual(true,PCMINSP_ChildForm_RoutingHeaderNotesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMINSP] Performing Click on ChildForm_RoutingHeaderNotesLink...", Logger.MessageType.INF);
				SeleniumControl PCMINSP_ChildForm_RoutingHeaderNotesLink = new SeleniumControl( sDriver, "ChildForm_RoutingHeaderNotesLink", "ID", "lnk_19174_PCMSFR_MOROUTLNINSP_HDR");
				Function.WaitControlDisplayed(PCMINSP_ChildForm_RoutingHeaderNotesLink);
PCMINSP_ChildForm_RoutingHeaderNotesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMINSP] Performing VerifyExists on RoutingHeaderNotesForm...", Logger.MessageType.INF);
				SeleniumControl PCMINSP_RoutingHeaderNotesForm = new SeleniumControl( sDriver, "RoutingHeaderNotesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMSFR_ROUTINGHDR_NOTES_']/ancestor::form[1]");
				Function.AssertEqual(true,PCMINSP_RoutingHeaderNotesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMINSP] Performing ClickButton on RoutingHeaderNotesForm...", Logger.MessageType.INF);
				SeleniumControl PCMINSP_RoutingHeaderNotesForm = new SeleniumControl( sDriver, "RoutingHeaderNotesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMSFR_ROUTINGHDR_NOTES_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCMINSP_RoutingHeaderNotesForm);
IWebElement formBttn = PCMINSP_RoutingHeaderNotesForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? PCMINSP_RoutingHeaderNotesForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
PCMINSP_RoutingHeaderNotesForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMINSP] Performing VerifyExist on RoutingHeaderNotes_Table...", Logger.MessageType.INF);
				SeleniumControl PCMINSP_RoutingHeaderNotes_Table = new SeleniumControl( sDriver, "RoutingHeaderNotes_Table", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMSFR_ROUTINGHDR_NOTES_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PCMINSP_RoutingHeaderNotes_Table.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMINSP] Performing Close on RoutingHeaderNotesForm...", Logger.MessageType.INF);
				SeleniumControl PCMINSP_RoutingHeaderNotesForm = new SeleniumControl( sDriver, "RoutingHeaderNotesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMSFR_ROUTINGHDR_NOTES_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCMINSP_RoutingHeaderNotesForm);
IWebElement formBttn = PCMINSP_RoutingHeaderNotesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("MO Completions");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMINSP] Performing VerifyExists on ChildForm_MOCompletionsLink...", Logger.MessageType.INF);
				SeleniumControl PCMINSP_ChildForm_MOCompletionsLink = new SeleniumControl( sDriver, "ChildForm_MOCompletionsLink", "ID", "lnk_19175_PCMSFR_MOROUTLNINSP_HDR");
				Function.AssertEqual(true,PCMINSP_ChildForm_MOCompletionsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMINSP] Performing Click on ChildForm_MOCompletionsLink...", Logger.MessageType.INF);
				SeleniumControl PCMINSP_ChildForm_MOCompletionsLink = new SeleniumControl( sDriver, "ChildForm_MOCompletionsLink", "ID", "lnk_19175_PCMSFR_MOROUTLNINSP_HDR");
				Function.WaitControlDisplayed(PCMINSP_ChildForm_MOCompletionsLink);
PCMINSP_ChildForm_MOCompletionsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMINSP] Performing VerifyExists on MOCompletionsForm...", Logger.MessageType.INF);
				SeleniumControl PCMINSP_MOCompletionsForm = new SeleniumControl( sDriver, "MOCompletionsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMSFR_MOROUTLNCOMPL_DTL_']/ancestor::form[1]");
				Function.AssertEqual(true,PCMINSP_MOCompletionsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMINSP] Performing VerifyExist on MOCompletions_Table...", Logger.MessageType.INF);
				SeleniumControl PCMINSP_MOCompletions_Table = new SeleniumControl( sDriver, "MOCompletions_Table", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMSFR_MOROUTLNCOMPL_DTL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PCMINSP_MOCompletions_Table.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMINSP] Performing ClickButton on MOCompletionsForm...", Logger.MessageType.INF);
				SeleniumControl PCMINSP_MOCompletionsForm = new SeleniumControl( sDriver, "MOCompletionsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMSFR_MOROUTLNCOMPL_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCMINSP_MOCompletionsForm);
IWebElement formBttn = PCMINSP_MOCompletionsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PCMINSP_MOCompletionsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PCMINSP_MOCompletionsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMINSP] Performing VerifyExists on MOCompletions_TransactionDate...", Logger.MessageType.INF);
				SeleniumControl PCMINSP_MOCompletions_TransactionDate = new SeleniumControl( sDriver, "MOCompletions_TransactionDate", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMSFR_MOROUTLNCOMPL_DTL_']/ancestor::form[1]/descendant::*[@id='TRANS_DT']");
				Function.AssertEqual(true,PCMINSP_MOCompletions_TransactionDate.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMINSP] Performing Close on MOCompletionsForm...", Logger.MessageType.INF);
				SeleniumControl PCMINSP_MOCompletionsForm = new SeleniumControl( sDriver, "MOCompletionsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMSFR_MOROUTLNCOMPL_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCMINSP_MOCompletionsForm);
IWebElement formBttn = PCMINSP_MOCompletionsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "PCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMINSP] Performing VerifyExists on ChildForm_SubcontractorReqsPOsLink...", Logger.MessageType.INF);
				SeleniumControl PCMINSP_ChildForm_SubcontractorReqsPOsLink = new SeleniumControl( sDriver, "ChildForm_SubcontractorReqsPOsLink", "ID", "lnk_19176_PCMSFR_MOROUTLNINSP_HDR");
				Function.AssertEqual(true,PCMINSP_ChildForm_SubcontractorReqsPOsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMINSP] Performing Click on ChildForm_SubcontractorReqsPOsLink...", Logger.MessageType.INF);
				SeleniumControl PCMINSP_ChildForm_SubcontractorReqsPOsLink = new SeleniumControl( sDriver, "ChildForm_SubcontractorReqsPOsLink", "ID", "lnk_19176_PCMSFR_MOROUTLNINSP_HDR");
				Function.WaitControlDisplayed(PCMINSP_ChildForm_SubcontractorReqsPOsLink);
PCMINSP_ChildForm_SubcontractorReqsPOsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMINSP] Performing VerifyExists on SubContractorReqsPOsForm...", Logger.MessageType.INF);
				SeleniumControl PCMINSP_SubContractorReqsPOsForm = new SeleniumControl( sDriver, "SubContractorReqsPOsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCM_SUBREQPOS_']/ancestor::form[1]");
				Function.AssertEqual(true,PCMINSP_SubContractorReqsPOsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMINSP] Performing VerifyExist on SubContractorReqsPOs_PurchaseOrder_Table...", Logger.MessageType.INF);
				SeleniumControl PCMINSP_SubContractorReqsPOs_PurchaseOrder_Table = new SeleniumControl( sDriver, "SubContractorReqsPOs_PurchaseOrder_Table", "xpath", "//div[translate(@id,'0123456789','')='pr__PCM_SUBREQPOS_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PCMINSP_SubContractorReqsPOs_PurchaseOrder_Table.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMINSP] Performing ClickButton on SubContractorReqsPOsForm...", Logger.MessageType.INF);
				SeleniumControl PCMINSP_SubContractorReqsPOsForm = new SeleniumControl( sDriver, "SubContractorReqsPOsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCM_SUBREQPOS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCMINSP_SubContractorReqsPOsForm);
IWebElement formBttn = PCMINSP_SubContractorReqsPOsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PCMINSP_SubContractorReqsPOsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PCMINSP_SubContractorReqsPOsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMINSP] Performing VerifyExists on SubContractorReqsPOs_Requisition_Requisition...", Logger.MessageType.INF);
				SeleniumControl PCMINSP_SubContractorReqsPOs_Requisition_Requisition = new SeleniumControl( sDriver, "SubContractorReqsPOs_Requisition_Requisition", "xpath", "//div[translate(@id,'0123456789','')='pr__PCM_SUBREQPOS_']/ancestor::form[1]/descendant::*[@id='RQ_ID']");
				Function.AssertEqual(true,PCMINSP_SubContractorReqsPOs_Requisition_Requisition.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMINSP] Performing Close on SubContractorReqsPOsForm...", Logger.MessageType.INF);
				SeleniumControl PCMINSP_SubContractorReqsPOsForm = new SeleniumControl( sDriver, "SubContractorReqsPOsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCM_SUBREQPOS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCMINSP_SubContractorReqsPOsForm);
IWebElement formBttn = PCMINSP_SubContractorReqsPOsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "PCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMINSP] Performing VerifyExists on ChildForm_DocumentsLink...", Logger.MessageType.INF);
				SeleniumControl PCMINSP_ChildForm_DocumentsLink = new SeleniumControl( sDriver, "ChildForm_DocumentsLink", "ID", "lnk_19177_PCMSFR_MOROUTLNINSP_HDR");
				Function.AssertEqual(true,PCMINSP_ChildForm_DocumentsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMINSP] Performing Click on ChildForm_DocumentsLink...", Logger.MessageType.INF);
				SeleniumControl PCMINSP_ChildForm_DocumentsLink = new SeleniumControl( sDriver, "ChildForm_DocumentsLink", "ID", "lnk_19177_PCMSFR_MOROUTLNINSP_HDR");
				Function.WaitControlDisplayed(PCMINSP_ChildForm_DocumentsLink);
PCMINSP_ChildForm_DocumentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMINSP] Performing VerifyExists on DocumentsForm...", Logger.MessageType.INF);
				SeleniumControl PCMINSP_DocumentsForm = new SeleniumControl( sDriver, "DocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCM_MODOCUMENT_']/ancestor::form[1]");
				Function.AssertEqual(true,PCMINSP_DocumentsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMINSP] Performing VerifyExist on Documents_Table...", Logger.MessageType.INF);
				SeleniumControl PCMINSP_Documents_Table = new SeleniumControl( sDriver, "Documents_Table", "xpath", "//div[translate(@id,'0123456789','')='pr__PCM_MODOCUMENT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PCMINSP_Documents_Table.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMINSP] Performing ClickButton on DocumentsForm...", Logger.MessageType.INF);
				SeleniumControl PCMINSP_DocumentsForm = new SeleniumControl( sDriver, "DocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCM_MODOCUMENT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCMINSP_DocumentsForm);
IWebElement formBttn = PCMINSP_DocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PCMINSP_DocumentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PCMINSP_DocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMINSP] Performing VerifyExists on Documents_Document...", Logger.MessageType.INF);
				SeleniumControl PCMINSP_Documents_Document = new SeleniumControl( sDriver, "Documents_Document", "xpath", "//div[translate(@id,'0123456789','')='pr__PCM_MODOCUMENT_']/ancestor::form[1]/descendant::*[@id='DOCUMENT_ID']");
				Function.AssertEqual(true,PCMINSP_Documents_Document.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMINSP] Performing Close on DocumentsForm...", Logger.MessageType.INF);
				SeleniumControl PCMINSP_DocumentsForm = new SeleniumControl( sDriver, "DocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCM_MODOCUMENT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCMINSP_DocumentsForm);
IWebElement formBttn = PCMINSP_DocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "PCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMINSP] Performing VerifyExists on ChildForm_PartDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl PCMINSP_ChildForm_PartDocumentsLink = new SeleniumControl( sDriver, "ChildForm_PartDocumentsLink", "ID", "lnk_19178_PCMSFR_MOROUTLNINSP_HDR");
				Function.AssertEqual(true,PCMINSP_ChildForm_PartDocumentsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMINSP] Performing Click on ChildForm_PartDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl PCMINSP_ChildForm_PartDocumentsLink = new SeleniumControl( sDriver, "ChildForm_PartDocumentsLink", "ID", "lnk_19178_PCMSFR_MOROUTLNINSP_HDR");
				Function.WaitControlDisplayed(PCMINSP_ChildForm_PartDocumentsLink);
PCMINSP_ChildForm_PartDocumentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMINSP] Performing VerifyExists on PartDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl PCMINSP_PartDocumentsForm = new SeleniumControl( sDriver, "PartDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]");
				Function.AssertEqual(true,PCMINSP_PartDocumentsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMINSP] Performing VerifyExist on PartDocuments_Table...", Logger.MessageType.INF);
				SeleniumControl PCMINSP_PartDocuments_Table = new SeleniumControl( sDriver, "PartDocuments_Table", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PCMINSP_PartDocuments_Table.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMINSP] Performing ClickButton on PartDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl PCMINSP_PartDocumentsForm = new SeleniumControl( sDriver, "PartDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCMINSP_PartDocumentsForm);
IWebElement formBttn = PCMINSP_PartDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PCMINSP_PartDocumentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PCMINSP_PartDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMINSP] Performing VerifyExists on PartDocuments_Type...", Logger.MessageType.INF);
				SeleniumControl PCMINSP_PartDocuments_Type = new SeleniumControl( sDriver, "PartDocuments_Type", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]/descendant::*[@id='DOC_TYPE_CD']");
				Function.AssertEqual(true,PCMINSP_PartDocuments_Type.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMINSP] Performing Close on PartDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl PCMINSP_PartDocumentsForm = new SeleniumControl( sDriver, "PartDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCMINSP_PartDocumentsForm);
IWebElement formBttn = PCMINSP_PartDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "PCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCMINSP] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl PCMINSP_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCMSFR_MAINHDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCMINSP_MainForm);
IWebElement formBttn = PCMINSP_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

