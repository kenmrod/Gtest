 
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
    public class PDQINQ_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Product Definition Reports/Inquiries", "xpath","//div[@class='navItem'][.='Product Definition Reports/Inquiries']").Click();
new SeleniumControl(sDriver,"View Items", "xpath","//div[@class='navItem'][.='View Items']").Click();


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
				Function.CurrentComponent = "PDQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDQINQ] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl PDQINQ_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,PDQINQ_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDQINQ] Performing VerifyExists on MainForm_Item...", Logger.MessageType.INF);
				SeleniumControl PDQINQ_MainForm_Item = new SeleniumControl( sDriver, "MainForm_Item", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='ITEM_ID']");
				Function.AssertEqual(true,PDQINQ_MainForm_Item.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDQINQ] Performing Set on MainForm_Item...", Logger.MessageType.INF);
				SeleniumControl PDQINQ_MainForm_Item = new SeleniumControl( sDriver, "MainForm_Item", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='ITEM_ID']");
				PDQINQ_MainForm_Item.Click();
PDQINQ_MainForm_Item.SendKeys("0212PC500", true);
Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));
PDQINQ_MainForm_Item.SendKeys(OpenQA.Selenium.Keys.Shift + OpenQA.Selenium.Keys.Tab);


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
				this.ScriptLogger.WriteLine("Item Details");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDQINQ] Performing VerifyExist on ItemDetailsTable...", Logger.MessageType.INF);
				SeleniumControl PDQINQ_ItemDetailsTable = new SeleniumControl( sDriver, "ItemDetailsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PDQINQ_ITEM_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PDQINQ_ItemDetailsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDQINQ] Performing VerifyExists on ItemDetails...", Logger.MessageType.INF);
				SeleniumControl PDQINQ_ItemDetails = new SeleniumControl( sDriver, "ItemDetails", "xpath", "//div[translate(@id,'0123456789','')='pr__PDQINQ_ITEM_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,PDQINQ_ItemDetails.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDQINQ] Performing ClickButtonIfExists on ItemDetails...", Logger.MessageType.INF);
				SeleniumControl PDQINQ_ItemDetails = new SeleniumControl( sDriver, "ItemDetails", "xpath", "//div[translate(@id,'0123456789','')='pr__PDQINQ_ITEM_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PDQINQ_ItemDetails);
IWebElement formBttn = PDQINQ_ItemDetails.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PDQINQ_ItemDetails.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PDQINQ_ItemDetails.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault();
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
				Function.CurrentComponent = "PDQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDQINQ] Performing VerifyExists on ItemDetails_Item...", Logger.MessageType.INF);
				SeleniumControl PDQINQ_ItemDetails_Item = new SeleniumControl( sDriver, "ItemDetails_Item", "xpath", "//div[translate(@id,'0123456789','')='pr__PDQINQ_ITEM_CTW_']/ancestor::form[1]/descendant::*[@id='ITEM_ID']");
				Function.AssertEqual(true,PDQINQ_ItemDetails_Item.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Std Text");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDQINQ] Performing VerifyExists on ItemDetails_StdTextLink...", Logger.MessageType.INF);
				SeleniumControl PDQINQ_ItemDetails_StdTextLink = new SeleniumControl( sDriver, "ItemDetails_StdTextLink", "ID", "lnk_1006229_PDQINQ_ITEM_CTW");
				Function.AssertEqual(true,PDQINQ_ItemDetails_StdTextLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDQINQ] Performing Click on ItemDetails_StdTextLink...", Logger.MessageType.INF);
				SeleniumControl PDQINQ_ItemDetails_StdTextLink = new SeleniumControl( sDriver, "ItemDetails_StdTextLink", "ID", "lnk_1006229_PDQINQ_ITEM_CTW");
				Function.WaitControlDisplayed(PDQINQ_ItemDetails_StdTextLink);
PDQINQ_ItemDetails_StdTextLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDQINQ] Performing VerifyExist on StdText_StdTextTable...", Logger.MessageType.INF);
				SeleniumControl PDQINQ_StdText_StdTextTable = new SeleniumControl( sDriver, "StdText_StdTextTable", "xpath", "//div[translate(@id,'0123456789','')='pr__MM_ITEMTEXT_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PDQINQ_StdText_StdTextTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDQINQ] Performing VerifyExists on StdText...", Logger.MessageType.INF);
				SeleniumControl PDQINQ_StdText = new SeleniumControl( sDriver, "StdText", "xpath", "//div[translate(@id,'0123456789','')='pr__MM_ITEMTEXT_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,PDQINQ_StdText.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDQINQ] Performing Close on StdText...", Logger.MessageType.INF);
				SeleniumControl PDQINQ_StdText = new SeleniumControl( sDriver, "StdText", "xpath", "//div[translate(@id,'0123456789','')='pr__MM_ITEMTEXT_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PDQINQ_StdText);
IWebElement formBttn = PDQINQ_StdText.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "PDQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDQINQ] Performing VerifyExists on ItemDetails_VendorsLink...", Logger.MessageType.INF);
				SeleniumControl PDQINQ_ItemDetails_VendorsLink = new SeleniumControl( sDriver, "ItemDetails_VendorsLink", "ID", "lnk_1006230_PDQINQ_ITEM_CTW");
				Function.AssertEqual(true,PDQINQ_ItemDetails_VendorsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDQINQ] Performing Click on ItemDetails_VendorsLink...", Logger.MessageType.INF);
				SeleniumControl PDQINQ_ItemDetails_VendorsLink = new SeleniumControl( sDriver, "ItemDetails_VendorsLink", "ID", "lnk_1006230_PDQINQ_ITEM_CTW");
				Function.WaitControlDisplayed(PDQINQ_ItemDetails_VendorsLink);
PDQINQ_ItemDetails_VendorsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDQINQ] Performing VerifyExist on VendorsTable...", Logger.MessageType.INF);
				SeleniumControl PDQINQ_VendorsTable = new SeleniumControl( sDriver, "VendorsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PDQINQ_ITEMVEND_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PDQINQ_VendorsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDQINQ] Performing VerifyExists on Vendors...", Logger.MessageType.INF);
				SeleniumControl PDQINQ_Vendors = new SeleniumControl( sDriver, "Vendors", "xpath", "//div[translate(@id,'0123456789','')='pr__PDQINQ_ITEMVEND_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,PDQINQ_Vendors.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDQINQ] Performing ClickButtonIfExists on Vendors...", Logger.MessageType.INF);
				SeleniumControl PDQINQ_Vendors = new SeleniumControl( sDriver, "Vendors", "xpath", "//div[translate(@id,'0123456789','')='pr__PDQINQ_ITEMVEND_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PDQINQ_Vendors);
IWebElement formBttn = PDQINQ_Vendors.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PDQINQ_Vendors.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PDQINQ_Vendors.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault();
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
				Function.CurrentComponent = "PDQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDQINQ] Performing VerifyExists on Vendors_Vendor...", Logger.MessageType.INF);
				SeleniumControl PDQINQ_Vendors_Vendor = new SeleniumControl( sDriver, "Vendors_Vendor", "xpath", "//div[translate(@id,'0123456789','')='pr__PDQINQ_ITEMVEND_CTW_']/ancestor::form[1]/descendant::*[@id='VEND_ID']");
				Function.AssertEqual(true,PDQINQ_Vendors_Vendor.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDQINQ] Performing Close on Vendors...", Logger.MessageType.INF);
				SeleniumControl PDQINQ_Vendors = new SeleniumControl( sDriver, "Vendors", "xpath", "//div[translate(@id,'0123456789','')='pr__PDQINQ_ITEMVEND_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PDQINQ_Vendors);
IWebElement formBttn = PDQINQ_Vendors.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Item Cost");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDQINQ] Performing VerifyExists on ItemDetails_ItemCostLink...", Logger.MessageType.INF);
				SeleniumControl PDQINQ_ItemDetails_ItemCostLink = new SeleniumControl( sDriver, "ItemDetails_ItemCostLink", "ID", "lnk_1006231_PDQINQ_ITEM_CTW");
				Function.AssertEqual(true,PDQINQ_ItemDetails_ItemCostLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDQINQ] Performing Click on ItemDetails_ItemCostLink...", Logger.MessageType.INF);
				SeleniumControl PDQINQ_ItemDetails_ItemCostLink = new SeleniumControl( sDriver, "ItemDetails_ItemCostLink", "ID", "lnk_1006231_PDQINQ_ITEM_CTW");
				Function.WaitControlDisplayed(PDQINQ_ItemDetails_ItemCostLink);
PDQINQ_ItemDetails_ItemCostLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDQINQ] Performing VerifyExist on ItemCostFormTable...", Logger.MessageType.INF);
				SeleniumControl PDQINQ_ItemCostFormTable = new SeleniumControl( sDriver, "ItemCostFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PDQINQ_ITEMCST_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PDQINQ_ItemCostFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDQINQ] Performing VerifyExists on ItemCostForm...", Logger.MessageType.INF);
				SeleniumControl PDQINQ_ItemCostForm = new SeleniumControl( sDriver, "ItemCostForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PDQINQ_ITEMCST_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,PDQINQ_ItemCostForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDQINQ] Performing ClickButtonIfExists on ItemCostForm...", Logger.MessageType.INF);
				SeleniumControl PDQINQ_ItemCostForm = new SeleniumControl( sDriver, "ItemCostForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PDQINQ_ITEMCST_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PDQINQ_ItemCostForm);
IWebElement formBttn = PDQINQ_ItemCostForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PDQINQ_ItemCostForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PDQINQ_ItemCostForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault();
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
				Function.CurrentComponent = "PDQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDQINQ] Performing VerifyExists on ItemCost_Type...", Logger.MessageType.INF);
				SeleniumControl PDQINQ_ItemCost_Type = new SeleniumControl( sDriver, "ItemCost_Type", "xpath", "//div[translate(@id,'0123456789','')='pr__PDQINQ_ITEMCST_CTW_']/ancestor::form[1]/descendant::*[@id='S_ITEM_CST_TYPE']");
				Function.AssertEqual(true,PDQINQ_ItemCost_Type.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDQINQ] Performing Close on ItemCostForm...", Logger.MessageType.INF);
				SeleniumControl PDQINQ_ItemCostForm = new SeleniumControl( sDriver, "ItemCostForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PDQINQ_ITEMCST_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PDQINQ_ItemCostForm);
IWebElement formBttn = PDQINQ_ItemCostForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Item Billing");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDQINQ] Performing VerifyExists on ItemDetails_ItemBillingLink...", Logger.MessageType.INF);
				SeleniumControl PDQINQ_ItemDetails_ItemBillingLink = new SeleniumControl( sDriver, "ItemDetails_ItemBillingLink", "ID", "lnk_1006232_PDQINQ_ITEM_CTW");
				Function.AssertEqual(true,PDQINQ_ItemDetails_ItemBillingLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDQINQ] Performing Click on ItemDetails_ItemBillingLink...", Logger.MessageType.INF);
				SeleniumControl PDQINQ_ItemDetails_ItemBillingLink = new SeleniumControl( sDriver, "ItemDetails_ItemBillingLink", "ID", "lnk_1006232_PDQINQ_ITEM_CTW");
				Function.WaitControlDisplayed(PDQINQ_ItemDetails_ItemBillingLink);
PDQINQ_ItemDetails_ItemBillingLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDQINQ] Performing VerifyExists on ItemBillingForm...", Logger.MessageType.INF);
				SeleniumControl PDQINQ_ItemBillingForm = new SeleniumControl( sDriver, "ItemBillingForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PDQINQ_PRODPRICECATLG_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,PDQINQ_ItemBillingForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDQINQ] Performing VerifyExists on ItemBilling_Catalog...", Logger.MessageType.INF);
				SeleniumControl PDQINQ_ItemBilling_Catalog = new SeleniumControl( sDriver, "ItemBilling_Catalog", "xpath", "//div[translate(@id,'0123456789','')='pr__PDQINQ_PRODPRICECATLG_CTW_']/ancestor::form[1]/descendant::*[@id='PRICE_CATLG_CD']");
				Function.AssertEqual(true,PDQINQ_ItemBilling_Catalog.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDQINQ] Performing ClickButtonIfExists on ItemBillingForm...", Logger.MessageType.INF);
				SeleniumControl PDQINQ_ItemBillingForm = new SeleniumControl( sDriver, "ItemBillingForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PDQINQ_PRODPRICECATLG_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PDQINQ_ItemBillingForm);
IWebElement formBttn = PDQINQ_ItemBillingForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? PDQINQ_ItemBillingForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
PDQINQ_ItemBillingForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault();
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
				Function.CurrentComponent = "PDQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDQINQ] Performing VerifyExist on ItemBillingTable...", Logger.MessageType.INF);
				SeleniumControl PDQINQ_ItemBillingTable = new SeleniumControl( sDriver, "ItemBillingTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PDQINQ_PRODPRICECATLG_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PDQINQ_ItemBillingTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDQINQ] Performing Close on ItemBillingForm...", Logger.MessageType.INF);
				SeleniumControl PDQINQ_ItemBillingForm = new SeleniumControl( sDriver, "ItemBillingForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PDQINQ_PRODPRICECATLG_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PDQINQ_ItemBillingForm);
IWebElement formBttn = PDQINQ_ItemBillingForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "PDQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDQINQ] Performing VerifyExists on ItemDetails_AlternatePartsLink...", Logger.MessageType.INF);
				SeleniumControl PDQINQ_ItemDetails_AlternatePartsLink = new SeleniumControl( sDriver, "ItemDetails_AlternatePartsLink", "ID", "lnk_5290_PDQINQ_ITEM_CTW");
				Function.AssertEqual(true,PDQINQ_ItemDetails_AlternatePartsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDQINQ] Performing Click on ItemDetails_AlternatePartsLink...", Logger.MessageType.INF);
				SeleniumControl PDQINQ_ItemDetails_AlternatePartsLink = new SeleniumControl( sDriver, "ItemDetails_AlternatePartsLink", "ID", "lnk_5290_PDQINQ_ITEM_CTW");
				Function.WaitControlDisplayed(PDQINQ_ItemDetails_AlternatePartsLink);
PDQINQ_ItemDetails_AlternatePartsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDQINQ] Performing VerifyExist on AlternatePartsFormTable...", Logger.MessageType.INF);
				SeleniumControl PDQINQ_AlternatePartsFormTable = new SeleniumControl( sDriver, "AlternatePartsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__MM_ALTPART_MEALTPARTS_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PDQINQ_AlternatePartsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDQINQ] Performing VerifyExists on AlternatePartsForm...", Logger.MessageType.INF);
				SeleniumControl PDQINQ_AlternatePartsForm = new SeleniumControl( sDriver, "AlternatePartsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MM_ALTPART_MEALTPARTS_']/ancestor::form[1]");
				Function.AssertEqual(true,PDQINQ_AlternatePartsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDQINQ] Performing ClickButtonIfExists on AlternatePartsForm...", Logger.MessageType.INF);
				SeleniumControl PDQINQ_AlternatePartsForm = new SeleniumControl( sDriver, "AlternatePartsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MM_ALTPART_MEALTPARTS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PDQINQ_AlternatePartsForm);
IWebElement formBttn = PDQINQ_AlternatePartsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PDQINQ_AlternatePartsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PDQINQ_AlternatePartsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault();
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
				Function.CurrentComponent = "PDQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDQINQ] Performing VerifyExists on Preferred...", Logger.MessageType.INF);
				SeleniumControl PDQINQ_Preferred = new SeleniumControl( sDriver, "Preferred", "xpath", "//input[@id='VEND_PART_RVSN_ID']/ancestor::form[1]/descendant::*[@id='PREF_FL']");
				Function.AssertEqual(true,PDQINQ_Preferred.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDQINQ] Performing Close on AlternatePartsForm...", Logger.MessageType.INF);
				SeleniumControl PDQINQ_AlternatePartsForm = new SeleniumControl( sDriver, "AlternatePartsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MM_ALTPART_MEALTPARTS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PDQINQ_AlternatePartsForm);
IWebElement formBttn = PDQINQ_AlternatePartsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "PDQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDQINQ] Performing VerifyExists on ItemDetails_SubstitutePartsLink...", Logger.MessageType.INF);
				SeleniumControl PDQINQ_ItemDetails_SubstitutePartsLink = new SeleniumControl( sDriver, "ItemDetails_SubstitutePartsLink", "ID", "lnk_1007294_PDQINQ_ITEM_CTW");
				Function.AssertEqual(true,PDQINQ_ItemDetails_SubstitutePartsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDQINQ] Performing Click on ItemDetails_SubstitutePartsLink...", Logger.MessageType.INF);
				SeleniumControl PDQINQ_ItemDetails_SubstitutePartsLink = new SeleniumControl( sDriver, "ItemDetails_SubstitutePartsLink", "ID", "lnk_1007294_PDQINQ_ITEM_CTW");
				Function.WaitControlDisplayed(PDQINQ_ItemDetails_SubstitutePartsLink);
PDQINQ_ItemDetails_SubstitutePartsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDQINQ] Performing VerifyExist on SubstitutePartsFormTable...", Logger.MessageType.INF);
				SeleniumControl PDQINQ_SubstitutePartsFormTable = new SeleniumControl( sDriver, "SubstitutePartsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__MM_SUBSTPART_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PDQINQ_SubstitutePartsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDQINQ] Performing VerifyExists on SubstitutePartsForm...", Logger.MessageType.INF);
				SeleniumControl PDQINQ_SubstitutePartsForm = new SeleniumControl( sDriver, "SubstitutePartsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MM_SUBSTPART_']/ancestor::form[1]");
				Function.AssertEqual(true,PDQINQ_SubstitutePartsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDQINQ] Performing ClickButtonIfExists on SubstitutePartsForm...", Logger.MessageType.INF);
				SeleniumControl PDQINQ_SubstitutePartsForm = new SeleniumControl( sDriver, "SubstitutePartsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MM_SUBSTPART_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PDQINQ_SubstitutePartsForm);
IWebElement formBttn = PDQINQ_SubstitutePartsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PDQINQ_SubstitutePartsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PDQINQ_SubstitutePartsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault();
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
				Function.CurrentComponent = "PDQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDQINQ] Performing VerifyExists on SubstituteParts_Sequence...", Logger.MessageType.INF);
				SeleniumControl PDQINQ_SubstituteParts_Sequence = new SeleniumControl( sDriver, "SubstituteParts_Sequence", "xpath", "//div[translate(@id,'0123456789','')='pr__MM_SUBSTPART_']/ancestor::form[1]/descendant::*[@id='USAGE_SEQ_NO']");
				Function.AssertEqual(true,PDQINQ_SubstituteParts_Sequence.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDQINQ] Performing Close on SubstitutePartsForm...", Logger.MessageType.INF);
				SeleniumControl PDQINQ_SubstitutePartsForm = new SeleniumControl( sDriver, "SubstitutePartsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MM_SUBSTPART_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PDQINQ_SubstitutePartsForm);
IWebElement formBttn = PDQINQ_SubstitutePartsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Projects");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDQINQ] Performing VerifyExists on ItemDetails_ProjectsLink...", Logger.MessageType.INF);
				SeleniumControl PDQINQ_ItemDetails_ProjectsLink = new SeleniumControl( sDriver, "ItemDetails_ProjectsLink", "ID", "lnk_1006244_PDQINQ_ITEM_CTW");
				Function.AssertEqual(true,PDQINQ_ItemDetails_ProjectsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDQINQ] Performing Click on ItemDetails_ProjectsLink...", Logger.MessageType.INF);
				SeleniumControl PDQINQ_ItemDetails_ProjectsLink = new SeleniumControl( sDriver, "ItemDetails_ProjectsLink", "ID", "lnk_1006244_PDQINQ_ITEM_CTW");
				Function.WaitControlDisplayed(PDQINQ_ItemDetails_ProjectsLink);
PDQINQ_ItemDetails_ProjectsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDQINQ] Performing VerifyExist on ProjectsFormTable...", Logger.MessageType.INF);
				SeleniumControl PDQINQ_ProjectsFormTable = new SeleniumControl( sDriver, "ProjectsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PDQINQ_PARTPROJ_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PDQINQ_ProjectsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDQINQ] Performing VerifyExists on ProjectsForm...", Logger.MessageType.INF);
				SeleniumControl PDQINQ_ProjectsForm = new SeleniumControl( sDriver, "ProjectsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PDQINQ_PARTPROJ_']/ancestor::form[1]");
				Function.AssertEqual(true,PDQINQ_ProjectsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDQINQ] Performing ClickButtonIfExists on ProjectsForm...", Logger.MessageType.INF);
				SeleniumControl PDQINQ_ProjectsForm = new SeleniumControl( sDriver, "ProjectsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PDQINQ_PARTPROJ_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PDQINQ_ProjectsForm);
IWebElement formBttn = PDQINQ_ProjectsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PDQINQ_ProjectsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PDQINQ_ProjectsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault();
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
				Function.CurrentComponent = "PDQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDQINQ] Performing VerifyExists on Projects_Project...", Logger.MessageType.INF);
				SeleniumControl PDQINQ_Projects_Project = new SeleniumControl( sDriver, "Projects_Project", "xpath", "//div[translate(@id,'0123456789','')='pr__PDQINQ_PARTPROJ_']/ancestor::form[1]/descendant::*[@id='PROJ_ID']");
				Function.AssertEqual(true,PDQINQ_Projects_Project.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDQINQ] Performing Close on ProjectsForm...", Logger.MessageType.INF);
				SeleniumControl PDQINQ_ProjectsForm = new SeleniumControl( sDriver, "ProjectsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PDQINQ_PARTPROJ_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PDQINQ_ProjectsForm);
IWebElement formBttn = PDQINQ_ProjectsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Project Item Cost");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDQINQ] Performing VerifyExists on ItemDetails_ProjectItemCostLink...", Logger.MessageType.INF);
				SeleniumControl PDQINQ_ItemDetails_ProjectItemCostLink = new SeleniumControl( sDriver, "ItemDetails_ProjectItemCostLink", "ID", "lnk_1006245_PDQINQ_ITEM_CTW");
				Function.AssertEqual(true,PDQINQ_ItemDetails_ProjectItemCostLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDQINQ] Performing Click on ItemDetails_ProjectItemCostLink...", Logger.MessageType.INF);
				SeleniumControl PDQINQ_ItemDetails_ProjectItemCostLink = new SeleniumControl( sDriver, "ItemDetails_ProjectItemCostLink", "ID", "lnk_1006245_PDQINQ_ITEM_CTW");
				Function.WaitControlDisplayed(PDQINQ_ItemDetails_ProjectItemCostLink);
PDQINQ_ItemDetails_ProjectItemCostLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDQINQ] Performing VerifyExist on ProjectItemCostFormTable...", Logger.MessageType.INF);
				SeleniumControl PDQINQ_ProjectItemCostFormTable = new SeleniumControl( sDriver, "ProjectItemCostFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PDQINQ_ITEMPROJCST_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PDQINQ_ProjectItemCostFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDQINQ] Performing VerifyExists on ProjectItemCostForm...", Logger.MessageType.INF);
				SeleniumControl PDQINQ_ProjectItemCostForm = new SeleniumControl( sDriver, "ProjectItemCostForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PDQINQ_ITEMPROJCST_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,PDQINQ_ProjectItemCostForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDQINQ] Performing ClickButtonIfExists on ProjectItemCostForm...", Logger.MessageType.INF);
				SeleniumControl PDQINQ_ProjectItemCostForm = new SeleniumControl( sDriver, "ProjectItemCostForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PDQINQ_ITEMPROJCST_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PDQINQ_ProjectItemCostForm);
IWebElement formBttn = PDQINQ_ProjectItemCostForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PDQINQ_ProjectItemCostForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PDQINQ_ProjectItemCostForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault();
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
				Function.CurrentComponent = "PDQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDQINQ] Performing VerifyExists on ProjectItemCost_ProjectID...", Logger.MessageType.INF);
				SeleniumControl PDQINQ_ProjectItemCost_ProjectID = new SeleniumControl( sDriver, "ProjectItemCost_ProjectID", "xpath", "//div[translate(@id,'0123456789','')='pr__PDQINQ_ITEMPROJCST_CTW_']/ancestor::form[1]/descendant::*[@id='PROJ_ID']");
				Function.AssertEqual(true,PDQINQ_ProjectItemCost_ProjectID.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDQINQ] Performing Close on ProjectItemCostForm...", Logger.MessageType.INF);
				SeleniumControl PDQINQ_ProjectItemCostForm = new SeleniumControl( sDriver, "ProjectItemCostForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PDQINQ_ITEMPROJCST_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PDQINQ_ProjectItemCostForm);
IWebElement formBttn = PDQINQ_ProjectItemCostForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("ECNs");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDQINQ] Performing VerifyExists on ItemDetails_ECNsLink...", Logger.MessageType.INF);
				SeleniumControl PDQINQ_ItemDetails_ECNsLink = new SeleniumControl( sDriver, "ItemDetails_ECNsLink", "ID", "lnk_1006300_PDQINQ_ITEM_CTW");
				Function.AssertEqual(true,PDQINQ_ItemDetails_ECNsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDQINQ] Performing Click on ItemDetails_ECNsLink...", Logger.MessageType.INF);
				SeleniumControl PDQINQ_ItemDetails_ECNsLink = new SeleniumControl( sDriver, "ItemDetails_ECNsLink", "ID", "lnk_1006300_PDQINQ_ITEM_CTW");
				Function.WaitControlDisplayed(PDQINQ_ItemDetails_ECNsLink);
PDQINQ_ItemDetails_ECNsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDQINQ] Performing VerifyExist on ECNFormTable...", Logger.MessageType.INF);
				SeleniumControl PDQINQ_ECNFormTable = new SeleniumControl( sDriver, "ECNFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__MRGMRSUB_ECNPART_ECN_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PDQINQ_ECNFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDQINQ] Performing VerifyExists on ECNForm...", Logger.MessageType.INF);
				SeleniumControl PDQINQ_ECNForm = new SeleniumControl( sDriver, "ECNForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MRGMRSUB_ECNPART_ECN_']/ancestor::form[1]");
				Function.AssertEqual(true,PDQINQ_ECNForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDQINQ] Performing ClickButtonIfExists on ECNForm...", Logger.MessageType.INF);
				SeleniumControl PDQINQ_ECNForm = new SeleniumControl( sDriver, "ECNForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MRGMRSUB_ECNPART_ECN_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PDQINQ_ECNForm);
IWebElement formBttn = PDQINQ_ECNForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PDQINQ_ECNForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PDQINQ_ECNForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault();
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
				Function.CurrentComponent = "PDQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDQINQ] Performing VerifyExists on ECNs_ECNId...", Logger.MessageType.INF);
				SeleniumControl PDQINQ_ECNs_ECNId = new SeleniumControl( sDriver, "ECNs_ECNId", "xpath", "//div[translate(@id,'0123456789','')='pr__MRGMRSUB_ECNPART_ECN_']/ancestor::form[1]/descendant::*[@id='ECN_ID']");
				Function.AssertEqual(true,PDQINQ_ECNs_ECNId.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("ECNs");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDQINQ] Performing Select on ECNs_ECNsTab...", Logger.MessageType.INF);
				SeleniumControl PDQINQ_ECNs_ECNsTab = new SeleniumControl( sDriver, "ECNs_ECNsTab", "xpath", "//div[translate(@id,'0123456789','')='pr__MRGMRSUB_ECNPART_ECN_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PDQINQ_ECNs_ECNsTab);
IWebElement mTab = PDQINQ_ECNs_ECNsTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "ECN Details").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDQINQ] Performing VerifyExists on ECNs_ECNDetails_Status...", Logger.MessageType.INF);
				SeleniumControl PDQINQ_ECNs_ECNDetails_Status = new SeleniumControl( sDriver, "ECNs_ECNDetails_Status", "xpath", "//div[translate(@id,'0123456789','')='pr__MRGMRSUB_ECNPART_ECN_']/ancestor::form[1]/descendant::*[@id='S_ECN_STATUS_CD']");
				Function.AssertEqual(true,PDQINQ_ECNs_ECNDetails_Status.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDQINQ] Performing Close on ECNForm...", Logger.MessageType.INF);
				SeleniumControl PDQINQ_ECNForm = new SeleniumControl( sDriver, "ECNForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MRGMRSUB_ECNPART_ECN_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PDQINQ_ECNForm);
IWebElement formBttn = PDQINQ_ECNForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "PDQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDQINQ] Performing VerifyExists on ItemDetails_PartDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl PDQINQ_ItemDetails_PartDocumentsLink = new SeleniumControl( sDriver, "ItemDetails_PartDocumentsLink", "ID", "lnk_1006247_PDQINQ_ITEM_CTW");
				Function.AssertEqual(true,PDQINQ_ItemDetails_PartDocumentsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDQINQ] Performing Click on ItemDetails_PartDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl PDQINQ_ItemDetails_PartDocumentsLink = new SeleniumControl( sDriver, "ItemDetails_PartDocumentsLink", "ID", "lnk_1006247_PDQINQ_ITEM_CTW");
				Function.WaitControlDisplayed(PDQINQ_ItemDetails_PartDocumentsLink);
PDQINQ_ItemDetails_PartDocumentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDQINQ] Performing VerifyExist on PartDocumentsFormTable...", Logger.MessageType.INF);
				SeleniumControl PDQINQ_PartDocumentsFormTable = new SeleniumControl( sDriver, "PartDocumentsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PDQINQ_PartDocumentsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDQINQ] Performing VerifyExists on PartDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl PDQINQ_PartDocumentsForm = new SeleniumControl( sDriver, "PartDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]");
				Function.AssertEqual(true,PDQINQ_PartDocumentsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDQINQ] Performing ClickButtonIfExists on PartDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl PDQINQ_PartDocumentsForm = new SeleniumControl( sDriver, "PartDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PDQINQ_PartDocumentsForm);
IWebElement formBttn = PDQINQ_PartDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PDQINQ_PartDocumentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PDQINQ_PartDocumentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault();
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
				Function.CurrentComponent = "PDQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDQINQ] Performing VerifyExists on PartDocuments_Type...", Logger.MessageType.INF);
				SeleniumControl PDQINQ_PartDocuments_Type = new SeleniumControl( sDriver, "PartDocuments_Type", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]/descendant::*[@id='DOC_TYPE_CD']");
				Function.AssertEqual(true,PDQINQ_PartDocuments_Type.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDQINQ] Performing Close on PartDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl PDQINQ_PartDocumentsForm = new SeleniumControl( sDriver, "PartDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PDQINQ_PartDocumentsForm);
IWebElement formBttn = PDQINQ_PartDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "PDQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDQINQ] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl PDQINQ_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PDQINQ_MainForm);
IWebElement formBttn = PDQINQ_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

