 
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
    public class PDMPART_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Items", "xpath","//div[@class='navItem'][.='Items']").Click();
new SeleniumControl(sDriver,"Manage Parts", "xpath","//div[@class='navItem'][.='Manage Parts']").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SelectMenu]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Basic Information");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPART";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPART] Performing Select on BasicInformationTab...", Logger.MessageType.INF);
				SeleniumControl PDMPART_BasicInformationTab = new SeleniumControl( sDriver, "BasicInformationTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PDMPART_BasicInformationTab);
IWebElement mTab = PDMPART_BasicInformationTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Characteristics").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPART";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPART] Performing VerifyExists on Characteristics_BasicCharacteristics_UM...", Logger.MessageType.INF);
				SeleniumControl PDMPART_Characteristics_BasicCharacteristics_UM = new SeleniumControl( sDriver, "Characteristics_BasicCharacteristics_UM", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='DFLT_UM_CD']");
				Function.AssertEqual(true,PDMPART_Characteristics_BasicCharacteristics_UM.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPART";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPART] Performing Select on BasicInformationTab...", Logger.MessageType.INF);
				SeleniumControl PDMPART_BasicInformationTab = new SeleniumControl( sDriver, "BasicInformationTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PDMPART_BasicInformationTab);
IWebElement mTab = PDMPART_BasicInformationTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Serial Lot Information").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPART";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPART] Performing VerifyExists on SerialLotInformation_InventoryTrackingRequired_Serial...", Logger.MessageType.INF);
				SeleniumControl PDMPART_SerialLotInformation_InventoryTrackingRequired_Serial = new SeleniumControl( sDriver, "SerialLotInformation_InventoryTrackingRequired_Serial", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='SERIAL_REQD_FL']");
				Function.AssertEqual(true,PDMPART_SerialLotInformation_InventoryTrackingRequired_Serial.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPART";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPART] Performing Select on BasicInformationTab...", Logger.MessageType.INF);
				SeleniumControl PDMPART_BasicInformationTab = new SeleniumControl( sDriver, "BasicInformationTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PDMPART_BasicInformationTab);
IWebElement mTab = PDMPART_BasicInformationTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Comments").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPART";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPART] Performing VerifyExists on Comments...", Logger.MessageType.INF);
				SeleniumControl PDMPART_Comments = new SeleniumControl( sDriver, "Comments", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='ITEM_NT']");
				Function.AssertEqual(true,PDMPART_Comments.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Units of Measure");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPART";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPART] Performing Click on UnitsOfMeasureLink...", Logger.MessageType.INF);
				SeleniumControl PDMPART_UnitsOfMeasureLink = new SeleniumControl( sDriver, "UnitsOfMeasureLink", "ID", "lnk_1006518_PDMEPD_PART_PARTINFO");
				Function.WaitControlDisplayed(PDMPART_UnitsOfMeasureLink);
PDMPART_UnitsOfMeasureLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPART";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPART] Performing VerifyExist on UnitsOfMeasureTable...", Logger.MessageType.INF);
				SeleniumControl PDMPART_UnitsOfMeasureTable = new SeleniumControl( sDriver, "UnitsOfMeasureTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PDUM_ITEMUM_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PDMPART_UnitsOfMeasureTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPART";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPART] Performing Close on UnitsOfMeasureForm...", Logger.MessageType.INF);
				SeleniumControl PDMPART_UnitsOfMeasureForm = new SeleniumControl( sDriver, "UnitsOfMeasureForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PDUM_ITEMUM_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PDMPART_UnitsOfMeasureForm);
IWebElement formBttn = PDMPART_UnitsOfMeasureForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("U/M Conversion");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPART";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPART] Performing Click on UMConversionsLink...", Logger.MessageType.INF);
				SeleniumControl PDMPART_UMConversionsLink = new SeleniumControl( sDriver, "UMConversionsLink", "ID", "lnk_1006519_PDMEPD_PART_PARTINFO");
				Function.WaitControlDisplayed(PDMPART_UMConversionsLink);
PDMPART_UMConversionsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPART";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPART] Performing VerifyExist on UMConversionsTable...", Logger.MessageType.INF);
				SeleniumControl PDMPART_UMConversionsTable = new SeleniumControl( sDriver, "UMConversionsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PDUM_UMCONV_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PDMPART_UMConversionsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPART";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPART] Performing ClickButton on UMConversionsForm...", Logger.MessageType.INF);
				SeleniumControl PDMPART_UMConversionsForm = new SeleniumControl( sDriver, "UMConversionsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PDUM_UMCONV_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PDMPART_UMConversionsForm);
IWebElement formBttn = PDMPART_UMConversionsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PDMPART_UMConversionsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PDMPART_UMConversionsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPART";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPART] Performing VerifyExists on UMConversions_UMFrom...", Logger.MessageType.INF);
				SeleniumControl PDMPART_UMConversions_UMFrom = new SeleniumControl( sDriver, "UMConversions_UMFrom", "xpath", "//div[translate(@id,'0123456789','')='pr__PDUM_UMCONV_CTW_']/ancestor::form[1]/descendant::*[@id='UM_CD_FR']");
				Function.AssertEqual(true,PDMPART_UMConversions_UMFrom.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPART";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPART] Performing Close on UMConversionsForm...", Logger.MessageType.INF);
				SeleniumControl PDMPART_UMConversionsForm = new SeleniumControl( sDriver, "UMConversionsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PDUM_UMCONV_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PDMPART_UMConversionsForm);
IWebElement formBttn = PDMPART_UMConversionsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Planning");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPART";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPART] Performing Click on PlanningLink...", Logger.MessageType.INF);
				SeleniumControl PDMPART_PlanningLink = new SeleniumControl( sDriver, "PlanningLink", "ID", "lnk_1006526_PDMEPD_PART_PARTINFO");
				Function.WaitControlDisplayed(PDMPART_PlanningLink);
PDMPART_PlanningLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPART";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPART] Performing VerifyExists on PlanningDetails_BasicCharacteristics_Commodity...", Logger.MessageType.INF);
				SeleniumControl PDMPART_PlanningDetails_BasicCharacteristics_Commodity = new SeleniumControl( sDriver, "PlanningDetails_BasicCharacteristics_Commodity", "xpath", "//div[translate(@id,'0123456789','')='pr__PDMPPD_PART_']/ancestor::form[1]/descendant::*[@id='COMM_CD']");
				Function.AssertEqual(true,PDMPART_PlanningDetails_BasicCharacteristics_Commodity.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPART";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPART] Performing Close on PlanningDetailsForm...", Logger.MessageType.INF);
				SeleniumControl PDMPART_PlanningDetailsForm = new SeleniumControl( sDriver, "PlanningDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PDMPPD_PART_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PDMPART_PlanningDetailsForm);
IWebElement formBttn = PDMPART_PlanningDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Alternate Parts");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPART";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPART] Performing Click on AlternatePartsLink...", Logger.MessageType.INF);
				SeleniumControl PDMPART_AlternatePartsLink = new SeleniumControl( sDriver, "AlternatePartsLink", "ID", "lnk_1006622_PDMEPD_PART_PARTINFO");
				Function.WaitControlDisplayed(PDMPART_AlternatePartsLink);
PDMPART_AlternatePartsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPART";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPART] Performing VerifyExist on AlternatePartsTable...", Logger.MessageType.INF);
				SeleniumControl PDMPART_AlternatePartsTable = new SeleniumControl( sDriver, "AlternatePartsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PDMALT_ALTPART_DTL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PDMPART_AlternatePartsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPART";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPART] Performing ClickButton on AlternatePartsForm...", Logger.MessageType.INF);
				SeleniumControl PDMPART_AlternatePartsForm = new SeleniumControl( sDriver, "AlternatePartsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PDMALT_ALTPART_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PDMPART_AlternatePartsForm);
IWebElement formBttn = PDMPART_AlternatePartsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PDMPART_AlternatePartsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PDMPART_AlternatePartsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPART";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPART] Performing VerifyExists on AlternateParts_Manufacturer_Manufacturer...", Logger.MessageType.INF);
				SeleniumControl PDMPART_AlternateParts_Manufacturer_Manufacturer = new SeleniumControl( sDriver, "AlternateParts_Manufacturer_Manufacturer", "xpath", "//div[translate(@id,'0123456789','')='pr__PDMALT_ALTPART_DTL_']/ancestor::form[1]/descendant::*[@id='MANUF_ID']");
				Function.AssertEqual(true,PDMPART_AlternateParts_Manufacturer_Manufacturer.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPART";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPART] Performing Close on AlternatePartsForm...", Logger.MessageType.INF);
				SeleniumControl PDMPART_AlternatePartsForm = new SeleniumControl( sDriver, "AlternatePartsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PDMALT_ALTPART_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PDMPART_AlternatePartsForm);
IWebElement formBttn = PDMPART_AlternatePartsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "PDMPART";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPART] Performing Click on SubstitutePartsLink...", Logger.MessageType.INF);
				SeleniumControl PDMPART_SubstitutePartsLink = new SeleniumControl( sDriver, "SubstitutePartsLink", "ID", "lnk_1006562_PDMEPD_PART_PARTINFO");
				Function.WaitControlDisplayed(PDMPART_SubstitutePartsLink);
PDMPART_SubstitutePartsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPART";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPART] Performing VerifyExist on SubstitutePartsTable...", Logger.MessageType.INF);
				SeleniumControl PDMPART_SubstitutePartsTable = new SeleniumControl( sDriver, "SubstitutePartsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PDMSUBST_SUBSTPART_HDR_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PDMPART_SubstitutePartsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPART";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPART] Performing ClickButton on SubstitutePartsForm...", Logger.MessageType.INF);
				SeleniumControl PDMPART_SubstitutePartsForm = new SeleniumControl( sDriver, "SubstitutePartsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PDMSUBST_SUBSTPART_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PDMPART_SubstitutePartsForm);
IWebElement formBttn = PDMPART_SubstitutePartsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PDMPART_SubstitutePartsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PDMPART_SubstitutePartsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPART";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPART] Performing VerifyExists on SubstituteParts_Sequence...", Logger.MessageType.INF);
				SeleniumControl PDMPART_SubstituteParts_Sequence = new SeleniumControl( sDriver, "SubstituteParts_Sequence", "xpath", "//div[translate(@id,'0123456789','')='pr__PDMSUBST_SUBSTPART_HDR_']/ancestor::form[1]/descendant::*[@id='USA_SEQ_NO']");
				Function.AssertEqual(true,PDMPART_SubstituteParts_Sequence.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPART";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPART] Performing Close on SubstitutePartsForm...", Logger.MessageType.INF);
				SeleniumControl PDMPART_SubstitutePartsForm = new SeleniumControl( sDriver, "SubstitutePartsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PDMSUBST_SUBSTPART_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PDMPART_SubstitutePartsForm);
IWebElement formBttn = PDMPART_SubstitutePartsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Project Requirements");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPART";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPART] Performing Click on ProjectRequirementsLink...", Logger.MessageType.INF);
				SeleniumControl PDMPART_ProjectRequirementsLink = new SeleniumControl( sDriver, "ProjectRequirementsLink", "ID", "lnk_1006563_PDMEPD_PART_PARTINFO");
				Function.WaitControlDisplayed(PDMPART_ProjectRequirementsLink);
PDMPART_ProjectRequirementsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPART";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPART] Performing VerifyExist on ProjectRequirementsTable...", Logger.MessageType.INF);
				SeleniumControl PDMPART_ProjectRequirementsTable = new SeleniumControl( sDriver, "ProjectRequirementsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PDMPRJPD_PARTPROJ_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PDMPART_ProjectRequirementsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPART";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPART] Performing ClickButton on ProjectRequirementsForm...", Logger.MessageType.INF);
				SeleniumControl PDMPART_ProjectRequirementsForm = new SeleniumControl( sDriver, "ProjectRequirementsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PDMPRJPD_PARTPROJ_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PDMPART_ProjectRequirementsForm);
IWebElement formBttn = PDMPART_ProjectRequirementsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PDMPART_ProjectRequirementsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PDMPART_ProjectRequirementsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPART";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPART] Performing VerifyExists on ProjectRequirements_Project...", Logger.MessageType.INF);
				SeleniumControl PDMPART_ProjectRequirements_Project = new SeleniumControl( sDriver, "ProjectRequirements_Project", "xpath", "//div[translate(@id,'0123456789','')='pr__PDMPRJPD_PARTPROJ_']/ancestor::form[1]/descendant::*[@id='PROJ_ID']");
				Function.AssertEqual(true,PDMPART_ProjectRequirements_Project.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPART";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPART] Performing Close on ProjectRequirementsForm...", Logger.MessageType.INF);
				SeleniumControl PDMPART_ProjectRequirementsForm = new SeleniumControl( sDriver, "ProjectRequirementsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PDMPRJPD_PARTPROJ_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PDMPART_ProjectRequirementsForm);
IWebElement formBttn = PDMPART_ProjectRequirementsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Vendors");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPART";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPART] Performing Click on VendorsLink...", Logger.MessageType.INF);
				SeleniumControl PDMPART_VendorsLink = new SeleniumControl( sDriver, "VendorsLink", "ID", "lnk_1007285_PDMEPD_PART_PARTINFO");
				Function.WaitControlDisplayed(PDMPART_VendorsLink);
PDMPART_VendorsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPART";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPART] Performing VerifyExist on VendorsTable...", Logger.MessageType.INF);
				SeleniumControl PDMPART_VendorsTable = new SeleniumControl( sDriver, "VendorsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMVEND_ITEMVEND_DTL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PDMPART_VendorsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPART";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPART] Performing ClickButton on VendorsForm...", Logger.MessageType.INF);
				SeleniumControl PDMPART_VendorsForm = new SeleniumControl( sDriver, "VendorsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMVEND_ITEMVEND_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PDMPART_VendorsForm);
IWebElement formBttn = PDMPART_VendorsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PDMPART_VendorsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PDMPART_VendorsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPART";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPART] Performing VerifyExists on Vendors_Vendor...", Logger.MessageType.INF);
				SeleniumControl PDMPART_Vendors_Vendor = new SeleniumControl( sDriver, "Vendors_Vendor", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMVEND_ITEMVEND_DTL_']/ancestor::form[1]/descendant::*[@id='VEND_ID']");
				Function.AssertEqual(true,PDMPART_Vendors_Vendor.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPART";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPART] Performing Close on VendorsForm...", Logger.MessageType.INF);
				SeleniumControl PDMPART_VendorsForm = new SeleniumControl( sDriver, "VendorsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMVEND_ITEMVEND_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PDMPART_VendorsForm);
IWebElement formBttn = PDMPART_VendorsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Item Billings");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPART";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPART] Performing Click on ItemBillingsLink...", Logger.MessageType.INF);
				SeleniumControl PDMPART_ItemBillingsLink = new SeleniumControl( sDriver, "ItemBillingsLink", "ID", "lnk_1007282_PDMEPD_PART_PARTINFO");
				Function.WaitControlDisplayed(PDMPART_ItemBillingsLink);
PDMPART_ItemBillingsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPART";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPART] Performing Select on ItemBillingsTab...", Logger.MessageType.INF);
				SeleniumControl PDMPART_ItemBillingsTab = new SeleniumControl( sDriver, "ItemBillingsTab", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMIBILL_ITEMPRODUCT_HDR_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PDMPART_ItemBillingsTab);
IWebElement mTab = PDMPART_ItemBillingsTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Basic Information").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPART";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPART] Performing VerifyExists on ItemBillings_BasicInformation_SellingDescription...", Logger.MessageType.INF);
				SeleniumControl PDMPART_ItemBillings_BasicInformation_SellingDescription = new SeleniumControl( sDriver, "ItemBillings_BasicInformation_SellingDescription", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMIBILL_ITEMPRODUCT_HDR_']/ancestor::form[1]/descendant::*[@id='SALES_ITEM_DESC']");
				Function.AssertEqual(true,PDMPART_ItemBillings_BasicInformation_SellingDescription.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPART";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPART] Performing Select on ItemBillingsTab...", Logger.MessageType.INF);
				SeleniumControl PDMPART_ItemBillingsTab = new SeleniumControl( sDriver, "ItemBillingsTab", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMIBILL_ITEMPRODUCT_HDR_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PDMPART_ItemBillingsTab);
IWebElement mTab = PDMPART_ItemBillingsTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Shipping Information").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPART";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPART] Performing VerifyExists on ItemBillings_ShippingInformation_Weight...", Logger.MessageType.INF);
				SeleniumControl PDMPART_ItemBillings_ShippingInformation_Weight = new SeleniumControl( sDriver, "ItemBillings_ShippingInformation_Weight", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMIBILL_ITEMPRODUCT_HDR_']/ancestor::form[1]/descendant::*[@id='SHIP_WGT_QTY']");
				Function.AssertEqual(true,PDMPART_ItemBillings_ShippingInformation_Weight.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPART";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPART] Performing ClickButtonIfExists on ItemBillingsForm...", Logger.MessageType.INF);
				SeleniumControl PDMPART_ItemBillingsForm = new SeleniumControl( sDriver, "ItemBillingsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMIBILL_ITEMPRODUCT_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PDMPART_ItemBillingsForm);
IWebElement formBttn = PDMPART_ItemBillingsForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? PDMPART_ItemBillingsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
PDMPART_ItemBillingsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault();
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
				Function.CurrentComponent = "PDMPART";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPART] Performing Close on ItemBillingsForm...", Logger.MessageType.INF);
				SeleniumControl PDMPART_ItemBillingsForm = new SeleniumControl( sDriver, "ItemBillingsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMIBILL_ITEMPRODUCT_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PDMPART_ItemBillingsForm);
IWebElement formBttn = PDMPART_ItemBillingsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Costs");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPART";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPART] Performing Click on CostsLink...", Logger.MessageType.INF);
				SeleniumControl PDMPART_CostsLink = new SeleniumControl( sDriver, "CostsLink", "ID", "lnk_1007286_PDMEPD_PART_PARTINFO");
				Function.WaitControlDisplayed(PDMPART_CostsLink);
PDMPART_CostsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPART";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPART] Performing VerifyExist on CostsTable...", Logger.MessageType.INF);
				SeleniumControl PDMPART_CostsTable = new SeleniumControl( sDriver, "CostsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMCOST_ITEMCST_DTL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PDMPART_CostsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPART";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPART] Performing ClickButton on CostsForm...", Logger.MessageType.INF);
				SeleniumControl PDMPART_CostsForm = new SeleniumControl( sDriver, "CostsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMCOST_ITEMCST_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PDMPART_CostsForm);
IWebElement formBttn = PDMPART_CostsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PDMPART_CostsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PDMPART_CostsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPART";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPART] Performing VerifyExists on Costs_CostType...", Logger.MessageType.INF);
				SeleniumControl PDMPART_Costs_CostType = new SeleniumControl( sDriver, "Costs_CostType", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMCOST_ITEMCST_DTL_']/ancestor::form[1]/descendant::*[@id='S_ITEM_CST_TYPE']");
				Function.AssertEqual(true,PDMPART_Costs_CostType.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPART";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPART] Performing Close on CostsForm...", Logger.MessageType.INF);
				SeleniumControl PDMPART_CostsForm = new SeleniumControl( sDriver, "CostsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMCOST_ITEMCST_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PDMPART_CostsForm);
IWebElement formBttn = PDMPART_CostsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Project Item Costs");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPART";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPART] Performing Click on ProjectItemCostsLink...", Logger.MessageType.INF);
				SeleniumControl PDMPART_ProjectItemCostsLink = new SeleniumControl( sDriver, "ProjectItemCostsLink", "ID", "lnk_1006949_PDMEPD_PART_PARTINFO");
				Function.WaitControlDisplayed(PDMPART_ProjectItemCostsLink);
PDMPART_ProjectItemCostsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPART";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPART] Performing VerifyExist on ProjectItemCostsTable...", Logger.MessageType.INF);
				SeleniumControl PDMPART_ProjectItemCostsTable = new SeleniumControl( sDriver, "ProjectItemCostsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PDMPRJCS_ITEMPROJCST_DTL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PDMPART_ProjectItemCostsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPART";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPART] Performing ClickButton on ProjectItemCostsForm...", Logger.MessageType.INF);
				SeleniumControl PDMPART_ProjectItemCostsForm = new SeleniumControl( sDriver, "ProjectItemCostsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PDMPRJCS_ITEMPROJCST_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PDMPART_ProjectItemCostsForm);
IWebElement formBttn = PDMPART_ProjectItemCostsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PDMPART_ProjectItemCostsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PDMPART_ProjectItemCostsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPART";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPART] Performing VerifyExists on ProjectItemCosts_CostType...", Logger.MessageType.INF);
				SeleniumControl PDMPART_ProjectItemCosts_CostType = new SeleniumControl( sDriver, "ProjectItemCosts_CostType", "xpath", "//div[translate(@id,'0123456789','')='pr__PDMPRJCS_ITEMPROJCST_DTL_']/ancestor::form[1]/descendant::*[@id='S_ITEM_CST_TYPE']");
				Function.AssertEqual(true,PDMPART_ProjectItemCosts_CostType.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPART";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPART] Performing Close on ProjectItemCostsForm...", Logger.MessageType.INF);
				SeleniumControl PDMPART_ProjectItemCostsForm = new SeleniumControl( sDriver, "ProjectItemCostsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PDMPRJCS_ITEMPROJCST_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PDMPART_ProjectItemCostsForm);
IWebElement formBttn = PDMPART_ProjectItemCostsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Assigned Standard Text");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPART";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPART] Performing Click on AssignedStandardTextLink...", Logger.MessageType.INF);
				SeleniumControl PDMPART_AssignedStandardTextLink = new SeleniumControl( sDriver, "AssignedStandardTextLink", "ID", "lnk_1007278_PDMEPD_PART_PARTINFO");
				Function.WaitControlDisplayed(PDMPART_AssignedStandardTextLink);
PDMPART_AssignedStandardTextLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPART";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPART] Performing VerifyExist on StandardTextTable...", Logger.MessageType.INF);
				SeleniumControl PDMPART_StandardTextTable = new SeleniumControl( sDriver, "StandardTextTable", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSTDTX_TEXTCODES_DTL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PDMPART_StandardTextTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPART";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPART] Performing VerifyExist on AssignedStandardTextTable...", Logger.MessageType.INF);
				SeleniumControl PDMPART_AssignedStandardTextTable = new SeleniumControl( sDriver, "AssignedStandardTextTable", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSTDTX_ITEMTEXT_DTL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PDMPART_AssignedStandardTextTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPART";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPART] Performing Close on AssignedStandardTextForm...", Logger.MessageType.INF);
				SeleniumControl PDMPART_AssignedStandardTextForm = new SeleniumControl( sDriver, "AssignedStandardTextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSTDTX_ITEMTEXT_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PDMPART_AssignedStandardTextForm);
IWebElement formBttn = PDMPART_AssignedStandardTextForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "PDMPART";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPART] Performing Click on DocumentsLink...", Logger.MessageType.INF);
				SeleniumControl PDMPART_DocumentsLink = new SeleniumControl( sDriver, "DocumentsLink", "ID", "lnk_1006520_PDMEPD_PART_PARTINFO");
				Function.WaitControlDisplayed(PDMPART_DocumentsLink);
PDMPART_DocumentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPART";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPART] Performing VerifyExist on DocumentsTable...", Logger.MessageType.INF);
				SeleniumControl PDMPART_DocumentsTable = new SeleniumControl( sDriver, "DocumentsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PDMEPD_PARTDOCUMENT_DOCUMENTS_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PDMPART_DocumentsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPART";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPART] Performing ClickButton on DocumentsForm...", Logger.MessageType.INF);
				SeleniumControl PDMPART_DocumentsForm = new SeleniumControl( sDriver, "DocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PDMEPD_PARTDOCUMENT_DOCUMENTS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PDMPART_DocumentsForm);
IWebElement formBttn = PDMPART_DocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PDMPART_DocumentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PDMPART_DocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPART";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPART] Performing VerifyExists on Documents_Document_Document...", Logger.MessageType.INF);
				SeleniumControl PDMPART_Documents_Document_Document = new SeleniumControl( sDriver, "Documents_Document_Document", "xpath", "//div[translate(@id,'0123456789','')='pr__PDMEPD_PARTDOCUMENT_DOCUMENTS_']/ancestor::form[1]/descendant::*[@id='DOCUMENT_ID']");
				Function.AssertEqual(true,PDMPART_Documents_Document_Document.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPART";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPART] Performing Close on DocumentsForm...", Logger.MessageType.INF);
				SeleniumControl PDMPART_DocumentsForm = new SeleniumControl( sDriver, "DocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PDMEPD_PARTDOCUMENT_DOCUMENTS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PDMPART_DocumentsForm);
IWebElement formBttn = PDMPART_DocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("User Defined Info");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPART";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPART] Performing Click on UserDefinedInfoLink...", Logger.MessageType.INF);
				SeleniumControl PDMPART_UserDefinedInfoLink = new SeleniumControl( sDriver, "UserDefinedInfoLink", "ID", "lnk_1006521_PDMEPD_PART_PARTINFO");
				Function.WaitControlDisplayed(PDMPART_UserDefinedInfoLink);
PDMPART_UserDefinedInfoLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPART";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPART] Performing VerifyExist on UserDefinedInfoTable...", Logger.MessageType.INF);
				SeleniumControl PDMPART_UserDefinedInfoTable = new SeleniumControl( sDriver, "UserDefinedInfoTable", "xpath", "//div[translate(@id,'0123456789','')='pr__MMUDINF_USERDEFINEDINFO_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PDMPART_UserDefinedInfoTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPART";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPART] Performing ClickButton on UserDefinedInfoForm...", Logger.MessageType.INF);
				SeleniumControl PDMPART_UserDefinedInfoForm = new SeleniumControl( sDriver, "UserDefinedInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MMUDINF_USERDEFINEDINFO_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PDMPART_UserDefinedInfoForm);
IWebElement formBttn = PDMPART_UserDefinedInfoForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PDMPART_UserDefinedInfoForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PDMPART_UserDefinedInfoForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPART";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPART] Performing VerifyExists on UserDefinedInfo_Labels...", Logger.MessageType.INF);
				SeleniumControl PDMPART_UserDefinedInfo_Labels = new SeleniumControl( sDriver, "UserDefinedInfo_Labels", "xpath", "//div[translate(@id,'0123456789','')='pr__MMUDINF_USERDEFINEDINFO_']/ancestor::form[1]/descendant::*[@id='UDEF_LBL']");
				Function.AssertEqual(true,PDMPART_UserDefinedInfo_Labels.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPART";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPART] Performing Close on UserDefinedInfoForm...", Logger.MessageType.INF);
				SeleniumControl PDMPART_UserDefinedInfoForm = new SeleniumControl( sDriver, "UserDefinedInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MMUDINF_USERDEFINEDINFO_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PDMPART_UserDefinedInfoForm);
IWebElement formBttn = PDMPART_UserDefinedInfoForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("MBOM");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPART";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPART] Performing Click on ManufacturingBOMLink...", Logger.MessageType.INF);
				SeleniumControl PDMPART_ManufacturingBOMLink = new SeleniumControl( sDriver, "ManufacturingBOMLink", "ID", "lnk_4341_PDMEPD_PART_PARTINFO");
				Function.WaitControlDisplayed(PDMPART_ManufacturingBOMLink);
PDMPART_ManufacturingBOMLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPART";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPART] Performing VerifyExists on ManufacturingBOM_AssemblyDetails_MakeBuy...", Logger.MessageType.INF);
				SeleniumControl PDMPART_ManufacturingBOM_AssemblyDetails_MakeBuy = new SeleniumControl( sDriver, "ManufacturingBOM_AssemblyDetails_MakeBuy", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMMBOM_PART_HDR_']/ancestor::form[1]/descendant::*[@id='S_MAKE_BUY_CD']");
				Function.AssertEqual(true,PDMPART_ManufacturingBOM_AssemblyDetails_MakeBuy.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPART";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPART] Performing ClickButton on ManufacturingBOM_AssemblyDetailsForm...", Logger.MessageType.INF);
				SeleniumControl PDMPART_ManufacturingBOM_AssemblyDetailsForm = new SeleniumControl( sDriver, "ManufacturingBOM_AssemblyDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMMBOM_PART_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PDMPART_ManufacturingBOM_AssemblyDetailsForm);
IWebElement formBttn = PDMPART_ManufacturingBOM_AssemblyDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? PDMPART_ManufacturingBOM_AssemblyDetailsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
PDMPART_ManufacturingBOM_AssemblyDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPART";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPART] Performing VerifyExist on ManufacturingBOM_AssemblyDetailsTable...", Logger.MessageType.INF);
				SeleniumControl PDMPART_ManufacturingBOM_AssemblyDetailsTable = new SeleniumControl( sDriver, "ManufacturingBOM_AssemblyDetailsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMMBOM_PART_HDR_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PDMPART_ManufacturingBOM_AssemblyDetailsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPART";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPART] Performing VerifyExist on MBOMLineTable...", Logger.MessageType.INF);
				SeleniumControl PDMPART_MBOMLineTable = new SeleniumControl( sDriver, "MBOMLineTable", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMMBOM_MFGBOM_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PDMPART_MBOMLineTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPART";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPART] Performing Click on MBOMLine_OK...", Logger.MessageType.INF);
				SeleniumControl PDMPART_MBOMLine_OK = new SeleniumControl( sDriver, "MBOMLine_OK", "xpath", "//div[@id='PDMPART']/div[@id='0']/following::span[@class='layerSpan' and contains(@style,'block')]/descendant::input[@id='bOk']");
				Function.WaitControlDisplayed(PDMPART_MBOMLine_OK);
if (PDMPART_MBOMLine_OK.mElement.GetAttribute("class") == "popupBtn" && sDriver.BrowserType == "ie")
PDMPART_MBOMLine_OK.Click(5,5);
else PDMPART_MBOMLine_OK.Click(4.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("EBOM");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPART";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPART] Performing Click on EngineeringBOMsLink...", Logger.MessageType.INF);
				SeleniumControl PDMPART_EngineeringBOMsLink = new SeleniumControl( sDriver, "EngineeringBOMsLink", "ID", "lnk_4313_PDMEPD_PART_PARTINFO");
				Function.WaitControlDisplayed(PDMPART_EngineeringBOMsLink);
PDMPART_EngineeringBOMsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPART";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPART] Performing VerifyExists on EngineeringBOMs_AssemblyDetails_MakeBuy...", Logger.MessageType.INF);
				SeleniumControl PDMPART_EngineeringBOMs_AssemblyDetails_MakeBuy = new SeleniumControl( sDriver, "EngineeringBOMs_AssemblyDetails_MakeBuy", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMEBOM_PART_HDR_']/ancestor::form[1]/descendant::*[@id='S_MAKE_BUY_CD']");
				Function.AssertEqual(true,PDMPART_EngineeringBOMs_AssemblyDetails_MakeBuy.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPART";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPART] Performing ClickButton on EngineeringBOMs_AssemblyDetailsForm...", Logger.MessageType.INF);
				SeleniumControl PDMPART_EngineeringBOMs_AssemblyDetailsForm = new SeleniumControl( sDriver, "EngineeringBOMs_AssemblyDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMEBOM_PART_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PDMPART_EngineeringBOMs_AssemblyDetailsForm);
IWebElement formBttn = PDMPART_EngineeringBOMs_AssemblyDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? PDMPART_EngineeringBOMs_AssemblyDetailsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
PDMPART_EngineeringBOMs_AssemblyDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPART";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPART] Performing VerifyExist on EngineeringBOMs_AssemblyDetailsTable...", Logger.MessageType.INF);
				SeleniumControl PDMPART_EngineeringBOMs_AssemblyDetailsTable = new SeleniumControl( sDriver, "EngineeringBOMs_AssemblyDetailsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMEBOM_PART_HDR_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PDMPART_EngineeringBOMs_AssemblyDetailsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPART";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPART] Performing VerifyExist on EBOMLineTable...", Logger.MessageType.INF);
				SeleniumControl PDMPART_EBOMLineTable = new SeleniumControl( sDriver, "EBOMLineTable", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMEBOM_ENGBOM_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PDMPART_EBOMLineTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPART";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPART] Performing ClickButton on EBOMLineForm...", Logger.MessageType.INF);
				SeleniumControl PDMPART_EBOMLineForm = new SeleniumControl( sDriver, "EBOMLineForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMEBOM_ENGBOM_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PDMPART_EBOMLineForm);
IWebElement formBttn = PDMPART_EBOMLineForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PDMPART_EBOMLineForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PDMPART_EBOMLineForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPART";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPART] Performing VerifyExists on EBOMLine_LineNo...", Logger.MessageType.INF);
				SeleniumControl PDMPART_EBOMLine_LineNo = new SeleniumControl( sDriver, "EBOMLine_LineNo", "xpath", "//div[translate(@id,'0123456789','')='pr__BMMEBOM_ENGBOM_CTW_']/ancestor::form[1]/descendant::*[@id='COMP_LN_NO']");
				Function.AssertEqual(true,PDMPART_EBOMLine_LineNo.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPART";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPART] Performing Click on EBOMLine_OK...", Logger.MessageType.INF);
				SeleniumControl PDMPART_EBOMLine_OK = new SeleniumControl( sDriver, "EBOMLine_OK", "xpath", "//div[@id='PDMPART']/div[@id='0']/following::span[@class='layerSpan' and contains(@style,'block')]/descendant::input[@id='bOk']");
				Function.WaitControlDisplayed(PDMPART_EBOMLine_OK);
if (PDMPART_EBOMLine_OK.mElement.GetAttribute("class") == "popupBtn" && sDriver.BrowserType == "ie")
PDMPART_EBOMLine_OK.Click(5,5);
else PDMPART_EBOMLine_OK.Click(4.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Maintain Routings");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPART";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPART] Performing Click on MaintainRoutingsLink...", Logger.MessageType.INF);
				SeleniumControl PDMPART_MaintainRoutingsLink = new SeleniumControl( sDriver, "MaintainRoutingsLink", "ID", "lnk_4879_PDMEPD_PART_PARTINFO");
				Function.WaitControlDisplayed(PDMPART_MaintainRoutingsLink);
PDMPART_MaintainRoutingsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPART";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPART] Performing VerifyExists on RoutingHeaderMainForm_RoutingNumber...", Logger.MessageType.INF);
				SeleniumControl PDMPART_RoutingHeaderMainForm_RoutingNumber = new SeleniumControl( sDriver, "RoutingHeaderMainForm_RoutingNumber", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMROUT_HEADER_']/ancestor::form[1]/descendant::*[@id='ROUT_NO']");
				Function.AssertEqual(true,PDMPART_RoutingHeaderMainForm_RoutingNumber.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPART";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPART] Performing ClickButton on RoutingHeaderMainForm...", Logger.MessageType.INF);
				SeleniumControl PDMPART_RoutingHeaderMainForm = new SeleniumControl( sDriver, "RoutingHeaderMainForm", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMROUT_HEADER_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PDMPART_RoutingHeaderMainForm);
IWebElement formBttn = PDMPART_RoutingHeaderMainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? PDMPART_RoutingHeaderMainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
PDMPART_RoutingHeaderMainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPART";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPART] Performing VerifyExist on RoutingHeaderMainTable...", Logger.MessageType.INF);
				SeleniumControl PDMPART_RoutingHeaderMainTable = new SeleniumControl( sDriver, "RoutingHeaderMainTable", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMROUT_HEADER_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PDMPART_RoutingHeaderMainTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPART";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPART] Performing VerifyExist on RoutingHeaderChildTable...", Logger.MessageType.INF);
				SeleniumControl PDMPART_RoutingHeaderChildTable = new SeleniumControl( sDriver, "RoutingHeaderChildTable", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMROUT_ROUTINGLN_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PDMPART_RoutingHeaderChildTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPART";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPART] Performing ClickButton on RoutingHeaderChildForm...", Logger.MessageType.INF);
				SeleniumControl PDMPART_RoutingHeaderChildForm = new SeleniumControl( sDriver, "RoutingHeaderChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMROUT_ROUTINGLN_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PDMPART_RoutingHeaderChildForm);
IWebElement formBttn = PDMPART_RoutingHeaderChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PDMPART_RoutingHeaderChildForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PDMPART_RoutingHeaderChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPART";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPART] Performing VerifyExists on RoutingHeaderChildForm_OperationSequence...", Logger.MessageType.INF);
				SeleniumControl PDMPART_RoutingHeaderChildForm_OperationSequence = new SeleniumControl( sDriver, "RoutingHeaderChildForm_OperationSequence", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMROUT_ROUTINGLN_CTW_']/ancestor::form[1]/descendant::*[@id='ROUT_OPER_SEQ_NO']");
				Function.AssertEqual(true,PDMPART_RoutingHeaderChildForm_OperationSequence.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPART";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPART] Performing Click on RoutingHeaderChildForm_OK...", Logger.MessageType.INF);
				SeleniumControl PDMPART_RoutingHeaderChildForm_OK = new SeleniumControl( sDriver, "RoutingHeaderChildForm_OK", "xpath", "//div[@id='PDMPART']/div[@id='0']/following::span[@class='layerSpan' and contains(@style,'block')]/descendant::input[@id='bOk']");
				Function.WaitControlDisplayed(PDMPART_RoutingHeaderChildForm_OK);
if (PDMPART_RoutingHeaderChildForm_OK.mElement.GetAttribute("class") == "popupBtn" && sDriver.BrowserType == "ie")
PDMPART_RoutingHeaderChildForm_OK.Click(5,5);
else PDMPART_RoutingHeaderChildForm_OK.Click(4.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
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
				Function.CurrentComponent = "PDMPART";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPART] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl PDMPART_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PDMPART_MainForm);
IWebElement formBttn = PDMPART_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

