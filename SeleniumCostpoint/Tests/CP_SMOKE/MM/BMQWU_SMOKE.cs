 
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
    public class BMQWU_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Bills of Material", "xpath","//div[@class='deptItem'][.='Bills of Material']").Click();
new SeleniumControl(sDriver,"Bills of Material Reports/Inquiries", "xpath","//div[@class='navItem'][.='Bills of Material Reports/Inquiries']").Click();
new SeleniumControl(sDriver,"View Where-Used Bills of Material", "xpath","//div[@class='navItem'][.='View Where-Used Bills of Material']").Click();


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
				Function.CurrentComponent = "BMQWU";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQWU] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl BMQWU_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,BMQWU_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMQWU";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQWU] Performing VerifyExists on Component_Part...", Logger.MessageType.INF);
				SeleniumControl BMQWU_Component_Part = new SeleniumControl( sDriver, "Component_Part", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='COMPPARTID']");
				Function.AssertEqual(true,BMQWU_Component_Part.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMQWU";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQWU] Performing Set on Component_Part...", Logger.MessageType.INF);
				SeleniumControl BMQWU_Component_Part = new SeleniumControl( sDriver, "Component_Part", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='COMPPARTID']");
				BMQWU_Component_Part.Click();
BMQWU_Component_Part.SendKeys("#16 GA MTW RED", true);
Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));
BMQWU_Component_Part.SendKeys(OpenQA.Selenium.Keys.Shift + OpenQA.Selenium.Keys.Tab);


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
				this.ScriptLogger.WriteLine("Component Part Information");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMQWU";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQWU] Performing VerifyExists on ComponentPartInformationLink...", Logger.MessageType.INF);
				SeleniumControl BMQWU_ComponentPartInformationLink = new SeleniumControl( sDriver, "ComponentPartInformationLink", "ID", "lnk_1005593_BMQWU_HEADER");
				Function.AssertEqual(true,BMQWU_ComponentPartInformationLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMQWU";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQWU] Performing Click on ComponentPartInformationLink...", Logger.MessageType.INF);
				SeleniumControl BMQWU_ComponentPartInformationLink = new SeleniumControl( sDriver, "ComponentPartInformationLink", "ID", "lnk_1005593_BMQWU_HEADER");
				Function.WaitControlDisplayed(BMQWU_ComponentPartInformationLink);
BMQWU_ComponentPartInformationLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMQWU";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQWU] Performing VerifyExists on ComponentPartInformationForm...", Logger.MessageType.INF);
				SeleniumControl BMQWU_ComponentPartInformationForm = new SeleniumControl( sDriver, "ComponentPartInformationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BMQWU_ZBMQWU_COMPONENTINFOHDR_']/ancestor::form[1]");
				Function.AssertEqual(true,BMQWU_ComponentPartInformationForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMQWU";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQWU] Performing ClickButton on ComponentPartInformationForm...", Logger.MessageType.INF);
				SeleniumControl BMQWU_ComponentPartInformationForm = new SeleniumControl( sDriver, "ComponentPartInformationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BMQWU_ZBMQWU_COMPONENTINFOHDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BMQWU_ComponentPartInformationForm);
IWebElement formBttn = BMQWU_ComponentPartInformationForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? BMQWU_ComponentPartInformationForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
BMQWU_ComponentPartInformationForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMQWU";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQWU] Performing VerifyExists on ComponentPartInformation_Component_MakeBuy...", Logger.MessageType.INF);
				SeleniumControl BMQWU_ComponentPartInformation_Component_MakeBuy = new SeleniumControl( sDriver, "ComponentPartInformation_Component_MakeBuy", "xpath", "//div[translate(@id,'0123456789','')='pr__BMQWU_ZBMQWU_COMPONENTINFOHDR_']/ancestor::form[1]/descendant::*[@id='S_MAKE_BUY_CD']");
				Function.AssertEqual(true,BMQWU_ComponentPartInformation_Component_MakeBuy.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMQWU";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQWU] Performing Close on ComponentPartInformationForm...", Logger.MessageType.INF);
				SeleniumControl BMQWU_ComponentPartInformationForm = new SeleniumControl( sDriver, "ComponentPartInformationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BMQWU_ZBMQWU_COMPONENTINFOHDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BMQWU_ComponentPartInformationForm);
IWebElement formBttn = BMQWU_ComponentPartInformationForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "BMQWU";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQWU] Performing VerifyExists on PartDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl BMQWU_PartDocumentsLink = new SeleniumControl( sDriver, "PartDocumentsLink", "ID", "lnk_3852_BMQWU_HEADER");
				Function.AssertEqual(true,BMQWU_PartDocumentsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMQWU";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQWU] Performing Click on PartDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl BMQWU_PartDocumentsLink = new SeleniumControl( sDriver, "PartDocumentsLink", "ID", "lnk_3852_BMQWU_HEADER");
				Function.WaitControlDisplayed(BMQWU_PartDocumentsLink);
BMQWU_PartDocumentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMQWU";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQWU] Performing VerifyExist on PartDocumentsFormTable...", Logger.MessageType.INF);
				SeleniumControl BMQWU_PartDocumentsFormTable = new SeleniumControl( sDriver, "PartDocumentsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BMQWU_PartDocumentsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMQWU";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQWU] Performing ClickButton on PartDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl BMQWU_PartDocumentsForm = new SeleniumControl( sDriver, "PartDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BMQWU_PartDocumentsForm);
IWebElement formBttn = BMQWU_PartDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? BMQWU_PartDocumentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
BMQWU_PartDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMQWU";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQWU] Performing VerifyExists on PartDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl BMQWU_PartDocumentsForm = new SeleniumControl( sDriver, "PartDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]");
				Function.AssertEqual(true,BMQWU_PartDocumentsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMQWU";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQWU] Performing VerifyExists on PartDocuments_Type...", Logger.MessageType.INF);
				SeleniumControl BMQWU_PartDocuments_Type = new SeleniumControl( sDriver, "PartDocuments_Type", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]/descendant::*[@id='DOC_TYPE_CD']");
				Function.AssertEqual(true,BMQWU_PartDocuments_Type.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMQWU";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQWU] Performing Close on PartDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl BMQWU_PartDocumentsForm = new SeleniumControl( sDriver, "PartDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BMQWU_PartDocumentsForm);
IWebElement formBttn = BMQWU_PartDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Substitute Parts");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMQWU";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQWU] Performing VerifyExists on SubstitutePartsLink...", Logger.MessageType.INF);
				SeleniumControl BMQWU_SubstitutePartsLink = new SeleniumControl( sDriver, "SubstitutePartsLink", "ID", "lnk_3896_BMQWU_HEADER");
				Function.AssertEqual(true,BMQWU_SubstitutePartsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMQWU";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQWU] Performing Click on SubstitutePartsLink...", Logger.MessageType.INF);
				SeleniumControl BMQWU_SubstitutePartsLink = new SeleniumControl( sDriver, "SubstitutePartsLink", "ID", "lnk_3896_BMQWU_HEADER");
				Function.WaitControlDisplayed(BMQWU_SubstitutePartsLink);
BMQWU_SubstitutePartsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMQWU";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQWU] Performing VerifyExist on SubtitutePartsFormTable...", Logger.MessageType.INF);
				SeleniumControl BMQWU_SubtitutePartsFormTable = new SeleniumControl( sDriver, "SubtitutePartsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__BMQWU_ZBMQWU_COMPONENTINFODTL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BMQWU_SubtitutePartsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMQWU";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQWU] Performing ClickButton on SubtitutePartsForm...", Logger.MessageType.INF);
				SeleniumControl BMQWU_SubtitutePartsForm = new SeleniumControl( sDriver, "SubtitutePartsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BMQWU_ZBMQWU_COMPONENTINFODTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BMQWU_SubtitutePartsForm);
IWebElement formBttn = BMQWU_SubtitutePartsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? BMQWU_SubtitutePartsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
BMQWU_SubtitutePartsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMQWU";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQWU] Performing VerifyExists on SubtitutePartsForm...", Logger.MessageType.INF);
				SeleniumControl BMQWU_SubtitutePartsForm = new SeleniumControl( sDriver, "SubtitutePartsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BMQWU_ZBMQWU_COMPONENTINFODTL_']/ancestor::form[1]");
				Function.AssertEqual(true,BMQWU_SubtitutePartsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMQWU";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQWU] Performing VerifyExists on SubtituteParts_SubstitueParts_Sequence...", Logger.MessageType.INF);
				SeleniumControl BMQWU_SubtituteParts_SubstitueParts_Sequence = new SeleniumControl( sDriver, "SubtituteParts_SubstitueParts_Sequence", "xpath", "//div[translate(@id,'0123456789','')='pr__BMQWU_ZBMQWU_COMPONENTINFODTL_']/ancestor::form[1]/descendant::*[@id='USAGE_SEQ_NO']");
				Function.AssertEqual(true,BMQWU_SubtituteParts_SubstitueParts_Sequence.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMQWU";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQWU] Performing Close on SubtitutePartsForm...", Logger.MessageType.INF);
				SeleniumControl BMQWU_SubtitutePartsForm = new SeleniumControl( sDriver, "SubtitutePartsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BMQWU_ZBMQWU_COMPONENTINFODTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BMQWU_SubtitutePartsForm);
IWebElement formBttn = BMQWU_SubtitutePartsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
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
				Function.CurrentComponent = "BMQWU";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQWU] Performing VerifyExist on ChildFormTable...", Logger.MessageType.INF);
				SeleniumControl BMQWU_ChildFormTable = new SeleniumControl( sDriver, "ChildFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__BMQWU_ZBMQWU_DETAIL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BMQWU_ChildFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMQWU";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQWU] Performing ClickButton on ChildForm...", Logger.MessageType.INF);
				SeleniumControl BMQWU_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BMQWU_ZBMQWU_DETAIL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BMQWU_ChildForm);
IWebElement formBttn = BMQWU_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? BMQWU_ChildForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
BMQWU_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMQWU";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQWU] Performing VerifyExists on ChildForm...", Logger.MessageType.INF);
				SeleniumControl BMQWU_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BMQWU_ZBMQWU_DETAIL_']/ancestor::form[1]");
				Function.AssertEqual(true,BMQWU_ChildForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMQWU";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQWU] Performing VerifyExists on ChildForm_AssemblyPart...", Logger.MessageType.INF);
				SeleniumControl BMQWU_ChildForm_AssemblyPart = new SeleniumControl( sDriver, "ChildForm_AssemblyPart", "xpath", "//div[translate(@id,'0123456789','')='pr__BMQWU_ZBMQWU_DETAIL_']/ancestor::form[1]/descendant::*[@id='ASY_PART_ID']");
				Function.AssertEqual(true,BMQWU_ChildForm_AssemblyPart.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMQWU";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQWU] Performing Select on ChildForm_ChildFormTab...", Logger.MessageType.INF);
				SeleniumControl BMQWU_ChildForm_ChildFormTab = new SeleniumControl( sDriver, "ChildForm_ChildFormTab", "xpath", "//div[translate(@id,'0123456789','')='pr__BMQWU_ZBMQWU_DETAIL_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(BMQWU_ChildForm_ChildFormTab);
IWebElement mTab = BMQWU_ChildForm_ChildFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Assembly Information").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMQWU";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQWU] Performing VerifyExists on ChildForm_AssemblyInformation_PartStatus...", Logger.MessageType.INF);
				SeleniumControl BMQWU_ChildForm_AssemblyInformation_PartStatus = new SeleniumControl( sDriver, "ChildForm_AssemblyInformation_PartStatus", "xpath", "//div[translate(@id,'0123456789','')='pr__BMQWU_ZBMQWU_DETAIL_']/ancestor::form[1]/descendant::*[@id='ASY_STATUS_DESC']");
				Function.AssertEqual(true,BMQWU_ChildForm_AssemblyInformation_PartStatus.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMQWU";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQWU] Performing Select on ChildForm_ChildFormTab...", Logger.MessageType.INF);
				SeleniumControl BMQWU_ChildForm_ChildFormTab = new SeleniumControl( sDriver, "ChildForm_ChildFormTab", "xpath", "//div[translate(@id,'0123456789','')='pr__BMQWU_ZBMQWU_DETAIL_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(BMQWU_ChildForm_ChildFormTab);
IWebElement mTab = BMQWU_ChildForm_ChildFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "BOM Line Information").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMQWU";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQWU] Performing VerifyExists on ChildForm_BOMLineInformation_ComponentType...", Logger.MessageType.INF);
				SeleniumControl BMQWU_ChildForm_BOMLineInformation_ComponentType = new SeleniumControl( sDriver, "ChildForm_BOMLineInformation_ComponentType", "xpath", "//div[translate(@id,'0123456789','')='pr__BMQWU_ZBMQWU_DETAIL_']/ancestor::form[1]/descendant::*[@id='S_COMP_TYP_CD']");
				Function.AssertEqual(true,BMQWU_ChildForm_BOMLineInformation_ComponentType.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMQWU";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQWU] Performing Select on ChildForm_ChildFormTab...", Logger.MessageType.INF);
				SeleniumControl BMQWU_ChildForm_ChildFormTab = new SeleniumControl( sDriver, "ChildForm_ChildFormTab", "xpath", "//div[translate(@id,'0123456789','')='pr__BMQWU_ZBMQWU_DETAIL_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(BMQWU_ChildForm_ChildFormTab);
IWebElement mTab = BMQWU_ChildForm_ChildFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Notes").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMQWU";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQWU] Performing VerifyExists on ChildForm_Notes_ReferenceDesignators...", Logger.MessageType.INF);
				SeleniumControl BMQWU_ChildForm_Notes_ReferenceDesignators = new SeleniumControl( sDriver, "ChildForm_Notes_ReferenceDesignators", "xpath", "//div[translate(@id,'0123456789','')='pr__BMQWU_ZBMQWU_DETAIL_']/ancestor::form[1]/descendant::*[@id='REF_DESIGNATOR_NT']");
				Function.AssertEqual(true,BMQWU_ChildForm_Notes_ReferenceDesignators.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
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
				Function.CurrentComponent = "BMQWU";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQWU] Performing VerifyExists on ChildForm_LineTextLink...", Logger.MessageType.INF);
				SeleniumControl BMQWU_ChildForm_LineTextLink = new SeleniumControl( sDriver, "ChildForm_LineTextLink", "ID", "lnk_3858_BMQWU_ZBMQWU_DETAIL");
				Function.AssertEqual(true,BMQWU_ChildForm_LineTextLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMQWU";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQWU] Performing Click on ChildForm_LineTextLink...", Logger.MessageType.INF);
				SeleniumControl BMQWU_ChildForm_LineTextLink = new SeleniumControl( sDriver, "ChildForm_LineTextLink", "ID", "lnk_3858_BMQWU_ZBMQWU_DETAIL");
				Function.WaitControlDisplayed(BMQWU_ChildForm_LineTextLink);
BMQWU_ChildForm_LineTextLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMQWU";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQWU] Performing VerifyExist on ChildForm_LineTextFormTable...", Logger.MessageType.INF);
				SeleniumControl BMQWU_ChildForm_LineTextFormTable = new SeleniumControl( sDriver, "ChildForm_LineTextFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__BMQWU_COMPTEXTCODES_HDR_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BMQWU_ChildForm_LineTextFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMQWU";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQWU] Performing ClickButton on ChildForm_LineTextForm...", Logger.MessageType.INF);
				SeleniumControl BMQWU_ChildForm_LineTextForm = new SeleniumControl( sDriver, "ChildForm_LineTextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BMQWU_COMPTEXTCODES_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BMQWU_ChildForm_LineTextForm);
IWebElement formBttn = BMQWU_ChildForm_LineTextForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? BMQWU_ChildForm_LineTextForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
BMQWU_ChildForm_LineTextForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMQWU";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQWU] Performing VerifyExists on ChildForm_LineTextForm...", Logger.MessageType.INF);
				SeleniumControl BMQWU_ChildForm_LineTextForm = new SeleniumControl( sDriver, "ChildForm_LineTextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BMQWU_COMPTEXTCODES_HDR_']/ancestor::form[1]");
				Function.AssertEqual(true,BMQWU_ChildForm_LineTextForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMQWU";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQWU] Performing VerifyExists on ChildForm_LineText_Sequence...", Logger.MessageType.INF);
				SeleniumControl BMQWU_ChildForm_LineText_Sequence = new SeleniumControl( sDriver, "ChildForm_LineText_Sequence", "xpath", "//div[translate(@id,'0123456789','')='pr__BMQWU_COMPTEXTCODES_HDR_']/ancestor::form[1]/descendant::*[@id='SEQ_NO']");
				Function.AssertEqual(true,BMQWU_ChildForm_LineText_Sequence.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMQWU";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQWU] Performing Close on ChildForm_LineTextForm...", Logger.MessageType.INF);
				SeleniumControl BMQWU_ChildForm_LineTextForm = new SeleniumControl( sDriver, "ChildForm_LineTextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BMQWU_COMPTEXTCODES_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BMQWU_ChildForm_LineTextForm);
IWebElement formBttn = BMQWU_ChildForm_LineTextForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Configuration Projects");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMQWU";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQWU] Performing VerifyExists on ChildForm_ConfigurationPROJECTSLink...", Logger.MessageType.INF);
				SeleniumControl BMQWU_ChildForm_ConfigurationPROJECTSLink = new SeleniumControl( sDriver, "ChildForm_ConfigurationPROJECTSLink", "ID", "lnk_1005459_BMQWU_ZBMQWU_DETAIL");
				Function.AssertEqual(true,BMQWU_ChildForm_ConfigurationPROJECTSLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMQWU";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQWU] Performing Click on ChildForm_ConfigurationPROJECTSLink...", Logger.MessageType.INF);
				SeleniumControl BMQWU_ChildForm_ConfigurationPROJECTSLink = new SeleniumControl( sDriver, "ChildForm_ConfigurationPROJECTSLink", "ID", "lnk_1005459_BMQWU_ZBMQWU_DETAIL");
				Function.WaitControlDisplayed(BMQWU_ChildForm_ConfigurationPROJECTSLink);
BMQWU_ChildForm_ConfigurationPROJECTSLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMQWU";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQWU] Performing VerifyExist on ChildForm_ConfigurationPROJECTSFormTable...", Logger.MessageType.INF);
				SeleniumControl BMQWU_ChildForm_ConfigurationPROJECTSFormTable = new SeleniumControl( sDriver, "ChildForm_ConfigurationPROJECTSFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__BMQWU_BOMCONFIGPROJ_DETAIL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BMQWU_ChildForm_ConfigurationPROJECTSFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMQWU";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQWU] Performing ClickButton on ChildForm_ConfigurationPROJECTSForm...", Logger.MessageType.INF);
				SeleniumControl BMQWU_ChildForm_ConfigurationPROJECTSForm = new SeleniumControl( sDriver, "ChildForm_ConfigurationPROJECTSForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BMQWU_BOMCONFIGPROJ_DETAIL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BMQWU_ChildForm_ConfigurationPROJECTSForm);
IWebElement formBttn = BMQWU_ChildForm_ConfigurationPROJECTSForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? BMQWU_ChildForm_ConfigurationPROJECTSForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
BMQWU_ChildForm_ConfigurationPROJECTSForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMQWU";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQWU] Performing VerifyExists on ChildForm_ConfigurationPROJECTSForm...", Logger.MessageType.INF);
				SeleniumControl BMQWU_ChildForm_ConfigurationPROJECTSForm = new SeleniumControl( sDriver, "ChildForm_ConfigurationPROJECTSForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BMQWU_BOMCONFIGPROJ_DETAIL_']/ancestor::form[1]");
				Function.AssertEqual(true,BMQWU_ChildForm_ConfigurationPROJECTSForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMQWU";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQWU] Performing VerifyExists on ChildForm_ConfigurationPROJECTS_Configuration...", Logger.MessageType.INF);
				SeleniumControl BMQWU_ChildForm_ConfigurationPROJECTS_Configuration = new SeleniumControl( sDriver, "ChildForm_ConfigurationPROJECTS_Configuration", "xpath", "//div[translate(@id,'0123456789','')='pr__BMQWU_BOMCONFIGPROJ_DETAIL_']/ancestor::form[1]/descendant::*[@id='BOM_CONFIG_ID']");
				Function.AssertEqual(true,BMQWU_ChildForm_ConfigurationPROJECTS_Configuration.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMQWU";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQWU] Performing Close on ChildForm_ConfigurationPROJECTSForm...", Logger.MessageType.INF);
				SeleniumControl BMQWU_ChildForm_ConfigurationPROJECTSForm = new SeleniumControl( sDriver, "ChildForm_ConfigurationPROJECTSForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BMQWU_BOMCONFIGPROJ_DETAIL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BMQWU_ChildForm_ConfigurationPROJECTSForm);
IWebElement formBttn = BMQWU_ChildForm_ConfigurationPROJECTSForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("End Part Configurations");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMQWU";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQWU] Performing VerifyExists on ChildForm_EndPartConfigurationsLink...", Logger.MessageType.INF);
				SeleniumControl BMQWU_ChildForm_EndPartConfigurationsLink = new SeleniumControl( sDriver, "ChildForm_EndPartConfigurationsLink", "ID", "lnk_1005470_BMQWU_ZBMQWU_DETAIL");
				Function.AssertEqual(true,BMQWU_ChildForm_EndPartConfigurationsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMQWU";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQWU] Performing Click on ChildForm_EndPartConfigurationsLink...", Logger.MessageType.INF);
				SeleniumControl BMQWU_ChildForm_EndPartConfigurationsLink = new SeleniumControl( sDriver, "ChildForm_EndPartConfigurationsLink", "ID", "lnk_1005470_BMQWU_ZBMQWU_DETAIL");
				Function.WaitControlDisplayed(BMQWU_ChildForm_EndPartConfigurationsLink);
BMQWU_ChildForm_EndPartConfigurationsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMQWU";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQWU] Performing VerifyExist on ChildForm_EndPartConfigurationsFormTable...", Logger.MessageType.INF);
				SeleniumControl BMQWU_ChildForm_EndPartConfigurationsFormTable = new SeleniumControl( sDriver, "ChildForm_EndPartConfigurationsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__BMQWU_ENDPARTCONFIG_DTL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BMQWU_ChildForm_EndPartConfigurationsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMQWU";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQWU] Performing ClickButton on ChildForm_EndPartConfigurationsForm...", Logger.MessageType.INF);
				SeleniumControl BMQWU_ChildForm_EndPartConfigurationsForm = new SeleniumControl( sDriver, "ChildForm_EndPartConfigurationsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BMQWU_ENDPARTCONFIG_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BMQWU_ChildForm_EndPartConfigurationsForm);
IWebElement formBttn = BMQWU_ChildForm_EndPartConfigurationsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? BMQWU_ChildForm_EndPartConfigurationsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
BMQWU_ChildForm_EndPartConfigurationsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMQWU";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQWU] Performing VerifyExists on ChildForm_EndPartConfigurationsForm...", Logger.MessageType.INF);
				SeleniumControl BMQWU_ChildForm_EndPartConfigurationsForm = new SeleniumControl( sDriver, "ChildForm_EndPartConfigurationsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BMQWU_ENDPARTCONFIG_DTL_']/ancestor::form[1]");
				Function.AssertEqual(true,BMQWU_ChildForm_EndPartConfigurationsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMQWU";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQWU] Performing VerifyExists on ChildForm_EndPartConfigurations_Configuration...", Logger.MessageType.INF);
				SeleniumControl BMQWU_ChildForm_EndPartConfigurations_Configuration = new SeleniumControl( sDriver, "ChildForm_EndPartConfigurations_Configuration", "xpath", "//div[translate(@id,'0123456789','')='pr__BMQWU_ENDPARTCONFIG_DTL_']/ancestor::form[1]/descendant::*[@id='BOM_CONFIG_ID']");
				Function.AssertEqual(true,BMQWU_ChildForm_EndPartConfigurations_Configuration.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMQWU";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQWU] Performing Close on ChildForm_EndPartConfigurationsForm...", Logger.MessageType.INF);
				SeleniumControl BMQWU_ChildForm_EndPartConfigurationsForm = new SeleniumControl( sDriver, "ChildForm_EndPartConfigurationsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BMQWU_ENDPARTCONFIG_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BMQWU_ChildForm_EndPartConfigurationsForm);
IWebElement formBttn = BMQWU_ChildForm_EndPartConfigurationsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "BMQWU";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQWU] Performing VerifyExists on ChildForm_PartDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl BMQWU_ChildForm_PartDocumentsLink = new SeleniumControl( sDriver, "ChildForm_PartDocumentsLink", "ID", "lnk_1005573_BMQWU_ZBMQWU_DETAIL");
				Function.AssertEqual(true,BMQWU_ChildForm_PartDocumentsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMQWU";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQWU] Performing Click on ChildForm_PartDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl BMQWU_ChildForm_PartDocumentsLink = new SeleniumControl( sDriver, "ChildForm_PartDocumentsLink", "ID", "lnk_1005573_BMQWU_ZBMQWU_DETAIL");
				Function.WaitControlDisplayed(BMQWU_ChildForm_PartDocumentsLink);
BMQWU_ChildForm_PartDocumentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMQWU";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQWU] Performing VerifyExist on ChildForm_PartDocumentsFormTable...", Logger.MessageType.INF);
				SeleniumControl BMQWU_ChildForm_PartDocumentsFormTable = new SeleniumControl( sDriver, "ChildForm_PartDocumentsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BMQWU_ChildForm_PartDocumentsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMQWU";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQWU] Performing ClickButton on ChildForm_PartDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl BMQWU_ChildForm_PartDocumentsForm = new SeleniumControl( sDriver, "ChildForm_PartDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BMQWU_ChildForm_PartDocumentsForm);
IWebElement formBttn = BMQWU_ChildForm_PartDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? BMQWU_ChildForm_PartDocumentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
BMQWU_ChildForm_PartDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMQWU";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQWU] Performing VerifyExists on ChildForm_PartDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl BMQWU_ChildForm_PartDocumentsForm = new SeleniumControl( sDriver, "ChildForm_PartDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]");
				Function.AssertEqual(true,BMQWU_ChildForm_PartDocumentsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMQWU";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQWU] Performing VerifyExists on ChildForm_PartDocuments_Type...", Logger.MessageType.INF);
				SeleniumControl BMQWU_ChildForm_PartDocuments_Type = new SeleniumControl( sDriver, "ChildForm_PartDocuments_Type", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]/descendant::*[@id='DOC_TYPE_CD']");
				Function.AssertEqual(true,BMQWU_ChildForm_PartDocuments_Type.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMQWU";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQWU] Performing Close on ChildForm_PartDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl BMQWU_ChildForm_PartDocumentsForm = new SeleniumControl( sDriver, "ChildForm_PartDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BMQWU_ChildForm_PartDocumentsForm);
IWebElement formBttn = BMQWU_ChildForm_PartDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "BMQWU";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMQWU] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl BMQWU_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(BMQWU_MainForm);
IWebElement formBttn = BMQWU_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

