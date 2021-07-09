 
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
    public class PPQVNDP_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Vendors", "xpath","//div[@class='navItem'][.='Vendors']").Click();
new SeleniumControl(sDriver,"View Vendor Performance", "xpath","//div[@class='navItem'][.='View Vendor Performance']").Click();


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
				Function.CurrentComponent = "PPQVNDP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPQVNDP] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl PPQVNDP_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,PPQVNDP_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPQVNDP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPQVNDP] Performing VerifyExists on MainForm_LineCharges_Vendor...", Logger.MessageType.INF);
				SeleniumControl PPQVNDP_MainForm_LineCharges_Vendor = new SeleniumControl( sDriver, "MainForm_LineCharges_Vendor", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='VEND_ID']");
				Function.AssertEqual(true,PPQVNDP_MainForm_LineCharges_Vendor.Exists());

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
				Function.CurrentComponent = "PPQVNDP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPQVNDP] Performing ClickButton on VendorDetailsForm...", Logger.MessageType.INF);
				SeleniumControl PPQVNDP_VendorDetailsForm = new SeleniumControl( sDriver, "VendorDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPQVNDP_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPQVNDP_VendorDetailsForm);
IWebElement formBttn = PPQVNDP_VendorDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).Count <= 0 ? PPQVNDP_VendorDetailsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Query')]")).FirstOrDefault() :
PPQVNDP_VendorDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).FirstOrDefault();
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

				this.ScriptLogger.WriteLine("[Query] Performing Click on Find...", Logger.MessageType.INF);
				SeleniumControl Query_Find = new SeleniumControl( sDriver, "Find", "ID", "submitQ");
				Function.WaitControlDisplayed(Query_Find);
if (Query_Find.mElement.GetAttribute("class") == "popupBtn" && sDriver.BrowserType == "ie")
Query_Find.Click(5,5);
else Query_Find.Click(4.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPQVNDP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPQVNDP] Performing VerifyExist on VendorDetailsFormTable...", Logger.MessageType.INF);
				SeleniumControl PPQVNDP_VendorDetailsFormTable = new SeleniumControl( sDriver, "VendorDetailsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PPQVNDP_DTL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PPQVNDP_VendorDetailsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPQVNDP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPQVNDP] Performing ClickButton on VendorDetailsForm...", Logger.MessageType.INF);
				SeleniumControl PPQVNDP_VendorDetailsForm = new SeleniumControl( sDriver, "VendorDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPQVNDP_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPQVNDP_VendorDetailsForm);
IWebElement formBttn = PPQVNDP_VendorDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PPQVNDP_VendorDetailsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PPQVNDP_VendorDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPQVNDP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPQVNDP] Performing VerifyExists on VendorDetailsForm...", Logger.MessageType.INF);
				SeleniumControl PPQVNDP_VendorDetailsForm = new SeleniumControl( sDriver, "VendorDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPQVNDP_DTL_']/ancestor::form[1]");
				Function.AssertEqual(true,PPQVNDP_VendorDetailsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPQVNDP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPQVNDP] Performing VerifyExists on VendorDetails_Vendor...", Logger.MessageType.INF);
				SeleniumControl PPQVNDP_VendorDetails_Vendor = new SeleniumControl( sDriver, "VendorDetails_Vendor", "xpath", "//div[translate(@id,'0123456789','')='pr__PPQVNDP_DTL_']/ancestor::form[1]/descendant::*[@id='VEND_ID']");
				Function.AssertEqual(true,PPQVNDP_VendorDetails_Vendor.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Assigned Items");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPQVNDP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPQVNDP] Performing VerifyExists on VendorDetails_AssignedItemsLink...", Logger.MessageType.INF);
				SeleniumControl PPQVNDP_VendorDetails_AssignedItemsLink = new SeleniumControl( sDriver, "VendorDetails_AssignedItemsLink", "ID", "lnk_1006636_PPQVNDP_DTL");
				Function.AssertEqual(true,PPQVNDP_VendorDetails_AssignedItemsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPQVNDP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPQVNDP] Performing Click on VendorDetails_AssignedItemsLink...", Logger.MessageType.INF);
				SeleniumControl PPQVNDP_VendorDetails_AssignedItemsLink = new SeleniumControl( sDriver, "VendorDetails_AssignedItemsLink", "ID", "lnk_1006636_PPQVNDP_DTL");
				Function.WaitControlDisplayed(PPQVNDP_VendorDetails_AssignedItemsLink);
PPQVNDP_VendorDetails_AssignedItemsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPQVNDP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPQVNDP] Performing VerifyExist on AssignedItemsFormTable...", Logger.MessageType.INF);
				SeleniumControl PPQVNDP_AssignedItemsFormTable = new SeleniumControl( sDriver, "AssignedItemsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PPQVNDP_ASSIGNEDITEMS_DTL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PPQVNDP_AssignedItemsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPQVNDP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPQVNDP] Performing ClickButton on AssignedItemsForm...", Logger.MessageType.INF);
				SeleniumControl PPQVNDP_AssignedItemsForm = new SeleniumControl( sDriver, "AssignedItemsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPQVNDP_ASSIGNEDITEMS_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPQVNDP_AssignedItemsForm);
IWebElement formBttn = PPQVNDP_AssignedItemsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PPQVNDP_AssignedItemsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PPQVNDP_AssignedItemsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPQVNDP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPQVNDP] Performing VerifyExists on AssignedItemsForm...", Logger.MessageType.INF);
				SeleniumControl PPQVNDP_AssignedItemsForm = new SeleniumControl( sDriver, "AssignedItemsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPQVNDP_ASSIGNEDITEMS_DTL_']/ancestor::form[1]");
				Function.AssertEqual(true,PPQVNDP_AssignedItemsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPQVNDP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPQVNDP] Performing VerifyExists on AssignedItems_Item...", Logger.MessageType.INF);
				SeleniumControl PPQVNDP_AssignedItems_Item = new SeleniumControl( sDriver, "AssignedItems_Item", "xpath", "//div[translate(@id,'0123456789','')='pr__PPQVNDP_ASSIGNEDITEMS_DTL_']/ancestor::form[1]/descendant::*[@id='ITEM_ID']");
				Function.AssertEqual(true,PPQVNDP_AssignedItems_Item.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPQVNDP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPQVNDP] Performing Close on AssignedItemsForm...", Logger.MessageType.INF);
				SeleniumControl PPQVNDP_AssignedItemsForm = new SeleniumControl( sDriver, "AssignedItemsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPQVNDP_ASSIGNEDITEMS_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPQVNDP_AssignedItemsForm);
IWebElement formBttn = PPQVNDP_AssignedItemsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Addresses");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPQVNDP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPQVNDP] Performing VerifyExists on VendorDetails_AddressesLink...", Logger.MessageType.INF);
				SeleniumControl PPQVNDP_VendorDetails_AddressesLink = new SeleniumControl( sDriver, "VendorDetails_AddressesLink", "ID", "lnk_1006635_PPQVNDP_DTL");
				Function.AssertEqual(true,PPQVNDP_VendorDetails_AddressesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPQVNDP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPQVNDP] Performing Click on VendorDetails_AddressesLink...", Logger.MessageType.INF);
				SeleniumControl PPQVNDP_VendorDetails_AddressesLink = new SeleniumControl( sDriver, "VendorDetails_AddressesLink", "ID", "lnk_1006635_PPQVNDP_DTL");
				Function.WaitControlDisplayed(PPQVNDP_VendorDetails_AddressesLink);
PPQVNDP_VendorDetails_AddressesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPQVNDP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPQVNDP] Performing VerifyExist on AddressesFormTable...", Logger.MessageType.INF);
				SeleniumControl PPQVNDP_AddressesFormTable = new SeleniumControl( sDriver, "AddressesFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PPQVNDP_ADDRESSES_DTL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PPQVNDP_AddressesFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPQVNDP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPQVNDP] Performing ClickButton on AddressesForm...", Logger.MessageType.INF);
				SeleniumControl PPQVNDP_AddressesForm = new SeleniumControl( sDriver, "AddressesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPQVNDP_ADDRESSES_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPQVNDP_AddressesForm);
IWebElement formBttn = PPQVNDP_AddressesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PPQVNDP_AddressesForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PPQVNDP_AddressesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPQVNDP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPQVNDP] Performing VerifyExists on AddressesForm...", Logger.MessageType.INF);
				SeleniumControl PPQVNDP_AddressesForm = new SeleniumControl( sDriver, "AddressesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPQVNDP_ADDRESSES_DTL_']/ancestor::form[1]");
				Function.AssertEqual(true,PPQVNDP_AddressesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPQVNDP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPQVNDP] Performing VerifyExists on Addresses_AddressCode...", Logger.MessageType.INF);
				SeleniumControl PPQVNDP_Addresses_AddressCode = new SeleniumControl( sDriver, "Addresses_AddressCode", "xpath", "//div[translate(@id,'0123456789','')='pr__PPQVNDP_ADDRESSES_DTL_']/ancestor::form[1]/descendant::*[@id='ADDR_DC']");
				Function.AssertEqual(true,PPQVNDP_Addresses_AddressCode.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPQVNDP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPQVNDP] Performing Close on AddressesForm...", Logger.MessageType.INF);
				SeleniumControl PPQVNDP_AddressesForm = new SeleniumControl( sDriver, "AddressesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPQVNDP_ADDRESSES_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPQVNDP_AddressesForm);
IWebElement formBttn = PPQVNDP_AddressesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "PPQVNDP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPQVNDP] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl PPQVNDP_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PPQVNDP_MainForm);
IWebElement formBttn = PPQVNDP_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

