 
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
    public class MEMRFQS_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Materials Estimating", "xpath","//div[@class='deptItem'][.='Materials Estimating']").Click();
new SeleniumControl(sDriver,"Request for Quotes", "xpath","//div[@class='navItem'][.='Request for Quotes']").Click();
new SeleniumControl(sDriver,"Select Request for Quotes from Proposals", "xpath","//div[@class='navItem'][.='Select Request for Quotes from Proposals']").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SelectMenu]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("MainForm");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMRFQS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMRFQS] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl MEMRFQS_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,MEMRFQS_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMRFQS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMRFQS] Performing VerifyExists on Proposal...", Logger.MessageType.INF);
				SeleniumControl MEMRFQS_Proposal = new SeleniumControl( sDriver, "Proposal", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PROP_ID']");
				Function.AssertEqual(true,MEMRFQS_Proposal.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Query");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMRFQS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMRFQS] Performing Set on Proposal...", Logger.MessageType.INF);
				SeleniumControl MEMRFQS_Proposal = new SeleniumControl( sDriver, "Proposal", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PROP_ID']");
				MEMRFQS_Proposal.Click();
MEMRFQS_Proposal.SendKeys("10000000000000000001", true);
Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));
MEMRFQS_Proposal.SendKeys(OpenQA.Selenium.Keys.Shift + OpenQA.Selenium.Keys.Tab);


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
				this.ScriptLogger.WriteLine("Select Items");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMRFQS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMRFQS] Performing VerifyExist on SelectItems_SelectItemsTable...", Logger.MessageType.INF);
				SeleniumControl MEMRFQS_SelectItems_SelectItemsTable = new SeleniumControl( sDriver, "SelectItems_SelectItemsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__MEMRFQS_PROPITEMDTL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,MEMRFQS_SelectItems_SelectItemsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMRFQS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMRFQS] Performing VerifyExists on SelectItemsform...", Logger.MessageType.INF);
				SeleniumControl MEMRFQS_SelectItemsform = new SeleniumControl( sDriver, "SelectItemsform", "xpath", "//div[translate(@id,'0123456789','')='pr__MEMRFQS_PROPITEMDTL_']/ancestor::form[1]");
				Function.AssertEqual(true,MEMRFQS_SelectItemsform.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Item Info");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMRFQS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMRFQS] Performing VerifyExists on SelectItems_ItemInfoLink...", Logger.MessageType.INF);
				SeleniumControl MEMRFQS_SelectItems_ItemInfoLink = new SeleniumControl( sDriver, "SelectItems_ItemInfoLink", "ID", "lnk_5340_MEMRFQS_PROPITEMDTL");
				Function.AssertEqual(true,MEMRFQS_SelectItems_ItemInfoLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMRFQS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMRFQS] Performing Click on SelectItems_ItemInfoLink...", Logger.MessageType.INF);
				SeleniumControl MEMRFQS_SelectItems_ItemInfoLink = new SeleniumControl( sDriver, "SelectItems_ItemInfoLink", "ID", "lnk_5340_MEMRFQS_PROPITEMDTL");
				Function.WaitControlDisplayed(MEMRFQS_SelectItems_ItemInfoLink);
MEMRFQS_SelectItems_ItemInfoLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMRFQS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMRFQS] Performing VerifyExists on ItemInfoform...", Logger.MessageType.INF);
				SeleniumControl MEMRFQS_ItemInfoform = new SeleniumControl( sDriver, "ItemInfoform", "xpath", "//div[translate(@id,'0123456789','')='pr__MEMRFQS_ITEMINFO_']/ancestor::form[1]");
				Function.AssertEqual(true,MEMRFQS_ItemInfoform.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMRFQS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMRFQS] Performing VerifyExists on ItemInfo_Item...", Logger.MessageType.INF);
				SeleniumControl MEMRFQS_ItemInfo_Item = new SeleniumControl( sDriver, "ItemInfo_Item", "xpath", "//div[translate(@id,'0123456789','')='pr__MEMRFQS_ITEMINFO_']/ancestor::form[1]/descendant::*[@id='PROP_ITEM_ID']");
				Function.AssertEqual(true,MEMRFQS_ItemInfo_Item.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Assigned Vendors");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMRFQS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMRFQS] Performing VerifyExist on ItemInfo_AssignedVendorsFormTable...", Logger.MessageType.INF);
				SeleniumControl MEMRFQS_ItemInfo_AssignedVendorsFormTable = new SeleniumControl( sDriver, "ItemInfo_AssignedVendorsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__MEMRFQS_ITEMVEND_ASSIGNVEND_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,MEMRFQS_ItemInfo_AssignedVendorsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMRFQS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMRFQS] Performing VerifyExists on ItemInfo_AssignedVendorsform...", Logger.MessageType.INF);
				SeleniumControl MEMRFQS_ItemInfo_AssignedVendorsform = new SeleniumControl( sDriver, "ItemInfo_AssignedVendorsform", "xpath", "//div[translate(@id,'0123456789','')='pr__MEMRFQS_ITEMVEND_ASSIGNVEND_']/ancestor::form[1]");
				Function.AssertEqual(true,MEMRFQS_ItemInfo_AssignedVendorsform.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMRFQS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMRFQS] Performing ClickButton on ItemInfo_AssignedVendorsform...", Logger.MessageType.INF);
				SeleniumControl MEMRFQS_ItemInfo_AssignedVendorsform = new SeleniumControl( sDriver, "ItemInfo_AssignedVendorsform", "xpath", "//div[translate(@id,'0123456789','')='pr__MEMRFQS_ITEMVEND_ASSIGNVEND_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MEMRFQS_ItemInfo_AssignedVendorsform);
IWebElement formBttn = MEMRFQS_ItemInfo_AssignedVendorsform.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? MEMRFQS_ItemInfo_AssignedVendorsform.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
MEMRFQS_ItemInfo_AssignedVendorsform.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMRFQS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMRFQS] Performing VerifyExists on ItemInfo_AssignedVendors_Vendor...", Logger.MessageType.INF);
				SeleniumControl MEMRFQS_ItemInfo_AssignedVendors_Vendor = new SeleniumControl( sDriver, "ItemInfo_AssignedVendors_Vendor", "xpath", "//div[translate(@id,'0123456789','')='pr__MEMRFQS_ITEMVEND_ASSIGNVEND_']/ancestor::form[1]/descendant::*[@id='VEND_ID']");
				Function.AssertEqual(true,MEMRFQS_ItemInfo_AssignedVendors_Vendor.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMRFQS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMRFQS] Performing Close on ItemInfoform...", Logger.MessageType.INF);
				SeleniumControl MEMRFQS_ItemInfoform = new SeleniumControl( sDriver, "ItemInfoform", "xpath", "//div[translate(@id,'0123456789','')='pr__MEMRFQS_ITEMINFO_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MEMRFQS_ItemInfoform);
IWebElement formBttn = MEMRFQS_ItemInfoform.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("SelectVendors");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMRFQS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMRFQS] Performing VerifyExist on SelectVendorsFormTable...", Logger.MessageType.INF);
				SeleniumControl MEMRFQS_SelectVendorsFormTable = new SeleniumControl( sDriver, "SelectVendorsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__MEMRFQS_VEND_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,MEMRFQS_SelectVendorsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMRFQS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMRFQS] Performing VerifyExists on SelectVendorsForm...", Logger.MessageType.INF);
				SeleniumControl MEMRFQS_SelectVendorsForm = new SeleniumControl( sDriver, "SelectVendorsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MEMRFQS_VEND_']/ancestor::form[1]");
				Function.AssertEqual(true,MEMRFQS_SelectVendorsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("VendorInfo");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMRFQS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMRFQS] Performing VerifyExists on SelectVendors_VendorInfoLink...", Logger.MessageType.INF);
				SeleniumControl MEMRFQS_SelectVendors_VendorInfoLink = new SeleniumControl( sDriver, "SelectVendors_VendorInfoLink", "ID", "lnk_5361_MEMRFQS_VEND");
				Function.AssertEqual(true,MEMRFQS_SelectVendors_VendorInfoLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMRFQS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMRFQS] Performing Click on SelectVendors_VendorInfoLink...", Logger.MessageType.INF);
				SeleniumControl MEMRFQS_SelectVendors_VendorInfoLink = new SeleniumControl( sDriver, "SelectVendors_VendorInfoLink", "ID", "lnk_5361_MEMRFQS_VEND");
				Function.WaitControlDisplayed(MEMRFQS_SelectVendors_VendorInfoLink);
MEMRFQS_SelectVendors_VendorInfoLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMRFQS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMRFQS] Performing VerifyExists on VendorInfoForm...", Logger.MessageType.INF);
				SeleniumControl MEMRFQS_VendorInfoForm = new SeleniumControl( sDriver, "VendorInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MEMRFQS_VENDINFO_']/ancestor::form[1]");
				Function.AssertEqual(true,MEMRFQS_VendorInfoForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMRFQS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMRFQS] Performing VerifyExists on VendorInfo_Vendor...", Logger.MessageType.INF);
				SeleniumControl MEMRFQS_VendorInfo_Vendor = new SeleniumControl( sDriver, "VendorInfo_Vendor", "xpath", "//div[translate(@id,'0123456789','')='pr__MEMRFQS_VENDINFO_']/ancestor::form[1]/descendant::*[@id='VEND_ID']");
				Function.AssertEqual(true,MEMRFQS_VendorInfo_Vendor.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Order Addresses");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMRFQS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMRFQS] Performing VerifyExist on VendorInfo_OrderAddressesFormTable...", Logger.MessageType.INF);
				SeleniumControl MEMRFQS_VendorInfo_OrderAddressesFormTable = new SeleniumControl( sDriver, "VendorInfo_OrderAddressesFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__MEMRFQS_VENDADDR_ORDADDR_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,MEMRFQS_VendorInfo_OrderAddressesFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMRFQS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMRFQS] Performing VerifyExists on VendorInfo_OrderAddressesForm...", Logger.MessageType.INF);
				SeleniumControl MEMRFQS_VendorInfo_OrderAddressesForm = new SeleniumControl( sDriver, "VendorInfo_OrderAddressesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MEMRFQS_VENDADDR_ORDADDR_']/ancestor::form[1]");
				Function.AssertEqual(true,MEMRFQS_VendorInfo_OrderAddressesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMRFQS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMRFQS] Performing ClickButton on VendorInfo_OrderAddressesForm...", Logger.MessageType.INF);
				SeleniumControl MEMRFQS_VendorInfo_OrderAddressesForm = new SeleniumControl( sDriver, "VendorInfo_OrderAddressesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MEMRFQS_VENDADDR_ORDADDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MEMRFQS_VendorInfo_OrderAddressesForm);
IWebElement formBttn = MEMRFQS_VendorInfo_OrderAddressesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? MEMRFQS_VendorInfo_OrderAddressesForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
MEMRFQS_VendorInfo_OrderAddressesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMRFQS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMRFQS] Performing VerifyExists on VendorInfo_OrderAddresses_AddressCode...", Logger.MessageType.INF);
				SeleniumControl MEMRFQS_VendorInfo_OrderAddresses_AddressCode = new SeleniumControl( sDriver, "VendorInfo_OrderAddresses_AddressCode", "xpath", "//div[translate(@id,'0123456789','')='pr__MEMRFQS_VENDADDR_ORDADDR_']/ancestor::form[1]/descendant::*[@id='ADDR_DC']");
				Function.AssertEqual(true,MEMRFQS_VendorInfo_OrderAddresses_AddressCode.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Industry Classification");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMRFQS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMRFQS] Performing VerifyExist on VendorInfo_IndustryClassificationsFormTable...", Logger.MessageType.INF);
				SeleniumControl MEMRFQS_VendorInfo_IndustryClassificationsFormTable = new SeleniumControl( sDriver, "VendorInfo_IndustryClassificationsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__MEMRFQS_VENDINDCLASS_INDCLASS_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,MEMRFQS_VendorInfo_IndustryClassificationsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMRFQS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMRFQS] Performing VerifyExists on VendorInfo_IndustryClassificationsForm...", Logger.MessageType.INF);
				SeleniumControl MEMRFQS_VendorInfo_IndustryClassificationsForm = new SeleniumControl( sDriver, "VendorInfo_IndustryClassificationsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MEMRFQS_VENDINDCLASS_INDCLASS_']/ancestor::form[1]");
				Function.AssertEqual(true,MEMRFQS_VendorInfo_IndustryClassificationsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMRFQS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMRFQS] Performing Close on VendorInfoForm...", Logger.MessageType.INF);
				SeleniumControl MEMRFQS_VendorInfoForm = new SeleniumControl( sDriver, "VendorInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MEMRFQS_VENDINFO_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MEMRFQS_VendorInfoForm);
IWebElement formBttn = MEMRFQS_VendorInfoForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Assigned Vendors");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMRFQS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMRFQS] Performing VerifyExist on RFQLineSelectionsFormTable...", Logger.MessageType.INF);
				SeleniumControl MEMRFQS_RFQLineSelectionsFormTable = new SeleniumControl( sDriver, "RFQLineSelectionsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__MEMRFQS_RFQSELECTIONS_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,MEMRFQS_RFQLineSelectionsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMRFQS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMRFQS] Performing VerifyExists on RFQLineSelectionsForm...", Logger.MessageType.INF);
				SeleniumControl MEMRFQS_RFQLineSelectionsForm = new SeleniumControl( sDriver, "RFQLineSelectionsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MEMRFQS_RFQSELECTIONS_']/ancestor::form[1]");
				Function.AssertEqual(true,MEMRFQS_RFQLineSelectionsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMRFQS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMRFQS] Performing ClickButton on RFQLineSelectionsForm...", Logger.MessageType.INF);
				SeleniumControl MEMRFQS_RFQLineSelectionsForm = new SeleniumControl( sDriver, "RFQLineSelectionsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MEMRFQS_RFQSELECTIONS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MEMRFQS_RFQLineSelectionsForm);
IWebElement formBttn = MEMRFQS_RFQLineSelectionsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? MEMRFQS_RFQLineSelectionsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
MEMRFQS_RFQLineSelectionsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEMRFQS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMRFQS] Performing VerifyExists on RFQLineSelections_Item...", Logger.MessageType.INF);
				SeleniumControl MEMRFQS_RFQLineSelections_Item = new SeleniumControl( sDriver, "RFQLineSelections_Item", "xpath", "//div[translate(@id,'0123456789','')='pr__MEMRFQS_RFQSELECTIONS_']/ancestor::form[1]/descendant::*[@id='ITEM_ID']");
				Function.AssertEqual(true,MEMRFQS_RFQLineSelections_Item.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
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
				Function.CurrentComponent = "MEMRFQS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEMRFQS] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl MEMRFQS_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(MEMRFQS_MainForm);
IWebElement formBttn = MEMRFQS_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

