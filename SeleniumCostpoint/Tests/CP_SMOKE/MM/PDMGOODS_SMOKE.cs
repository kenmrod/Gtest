 
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
    public class PDMGOODS_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Manage Goods", "xpath","//div[@class='navItem'][.='Manage Goods']").Click();


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
				Function.CurrentComponent = "PDMGOODS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMGOODS] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl PDMGOODS_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,PDMGOODS_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMGOODS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMGOODS] Performing VerifyExists on GoodsID...", Logger.MessageType.INF);
				SeleniumControl PDMGOODS_GoodsID = new SeleniumControl( sDriver, "GoodsID", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='ITEM_ID']");
				Function.AssertEqual(true,PDMGOODS_GoodsID.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMGOODS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMGOODS] Performing VerifyExists on Characteristics_UM...", Logger.MessageType.INF);
				SeleniumControl PDMGOODS_Characteristics_UM = new SeleniumControl( sDriver, "Characteristics_UM", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='DFLT_UM_CD']");
				Function.AssertEqual(true,PDMGOODS_Characteristics_UM.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMGOODS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMGOODS] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl PDMGOODS_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PDMGOODS_MainFormTab);
IWebElement mTab = PDMGOODS_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Comments").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMGOODS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMGOODS] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl PDMGOODS_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PDMGOODS_MainForm);
IWebElement formBttn = PDMGOODS_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? PDMGOODS_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
PDMGOODS_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMGOODS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMGOODS] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl PDMGOODS_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PDMGOODS_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
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
				Function.CurrentComponent = "PDMGOODS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMGOODS] Performing Click on VendorsLink...", Logger.MessageType.INF);
				SeleniumControl PDMGOODS_VendorsLink = new SeleniumControl( sDriver, "VendorsLink", "ID", "lnk_1007195_PDMGOODS_ITEM_HDR");
				Function.WaitControlDisplayed(PDMGOODS_VendorsLink);
PDMGOODS_VendorsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMGOODS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMGOODS] Performing VerifyExists on VendorAssignmentForm...", Logger.MessageType.INF);
				SeleniumControl PDMGOODS_VendorAssignmentForm = new SeleniumControl( sDriver, "VendorAssignmentForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMVEND_ITEMVEND_DTL_']/ancestor::form[1]");
				Function.AssertEqual(true,PDMGOODS_VendorAssignmentForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMGOODS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMGOODS] Performing VerifyExist on VendorAssignmentFormTable...", Logger.MessageType.INF);
				SeleniumControl PDMGOODS_VendorAssignmentFormTable = new SeleniumControl( sDriver, "VendorAssignmentFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMVEND_ITEMVEND_DTL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PDMGOODS_VendorAssignmentFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMGOODS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMGOODS] Performing ClickButton on VendorAssignmentForm...", Logger.MessageType.INF);
				SeleniumControl PDMGOODS_VendorAssignmentForm = new SeleniumControl( sDriver, "VendorAssignmentForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMVEND_ITEMVEND_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PDMGOODS_VendorAssignmentForm);
IWebElement formBttn = PDMGOODS_VendorAssignmentForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PDMGOODS_VendorAssignmentForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PDMGOODS_VendorAssignmentForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMGOODS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMGOODS] Performing VerifyExists on VendorAssignment_Vendor...", Logger.MessageType.INF);
				SeleniumControl PDMGOODS_VendorAssignment_Vendor = new SeleniumControl( sDriver, "VendorAssignment_Vendor", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMVEND_ITEMVEND_DTL_']/ancestor::form[1]/descendant::*[@id='VEND_ID']");
				Function.AssertEqual(true,PDMGOODS_VendorAssignment_Vendor.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMGOODS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMGOODS] Performing Close on VendorAssignmentForm...", Logger.MessageType.INF);
				SeleniumControl PDMGOODS_VendorAssignmentForm = new SeleniumControl( sDriver, "VendorAssignmentForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMVEND_ITEMVEND_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PDMGOODS_VendorAssignmentForm);
IWebElement formBttn = PDMGOODS_VendorAssignmentForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "PDMGOODS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMGOODS] Performing Click on ItemBillingsLink...", Logger.MessageType.INF);
				SeleniumControl PDMGOODS_ItemBillingsLink = new SeleniumControl( sDriver, "ItemBillingsLink", "ID", "lnk_1007194_PDMGOODS_ITEM_HDR");
				Function.WaitControlDisplayed(PDMGOODS_ItemBillingsLink);
PDMGOODS_ItemBillingsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMGOODS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMGOODS] Performing VerifyExists on ItemBillingsForm...", Logger.MessageType.INF);
				SeleniumControl PDMGOODS_ItemBillingsForm = new SeleniumControl( sDriver, "ItemBillingsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMIBILL_ITEMPRODUCT_HDR_']/ancestor::form[1]");
				Function.AssertEqual(true,PDMGOODS_ItemBillingsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMGOODS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMGOODS] Performing VerifyExists on ItemBillings_BasicInformation_SellingDescription...", Logger.MessageType.INF);
				SeleniumControl PDMGOODS_ItemBillings_BasicInformation_SellingDescription = new SeleniumControl( sDriver, "ItemBillings_BasicInformation_SellingDescription", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMIBILL_ITEMPRODUCT_HDR_']/ancestor::form[1]/descendant::*[@id='SALES_ITEM_DESC']");
				Function.AssertEqual(true,PDMGOODS_ItemBillings_BasicInformation_SellingDescription.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMGOODS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMGOODS] Performing Select on ItemBillings_Tab...", Logger.MessageType.INF);
				SeleniumControl PDMGOODS_ItemBillings_Tab = new SeleniumControl( sDriver, "ItemBillings_Tab", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMIBILL_ITEMPRODUCT_HDR_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PDMGOODS_ItemBillings_Tab);
IWebElement mTab = PDMGOODS_ItemBillings_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Shipping Information").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMGOODS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMGOODS] Performing VerifyExists on ItemBillings_ShippingInformation_Weight...", Logger.MessageType.INF);
				SeleniumControl PDMGOODS_ItemBillings_ShippingInformation_Weight = new SeleniumControl( sDriver, "ItemBillings_ShippingInformation_Weight", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMIBILL_ITEMPRODUCT_HDR_']/ancestor::form[1]/descendant::*[@id='SHIP_WGT_QTY']");
				Function.AssertEqual(true,PDMGOODS_ItemBillings_ShippingInformation_Weight.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMGOODS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMGOODS] Performing ClickButton on ItemBillingsForm...", Logger.MessageType.INF);
				SeleniumControl PDMGOODS_ItemBillingsForm = new SeleniumControl( sDriver, "ItemBillingsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMIBILL_ITEMPRODUCT_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PDMGOODS_ItemBillingsForm);
IWebElement formBttn = PDMGOODS_ItemBillingsForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? PDMGOODS_ItemBillingsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
PDMGOODS_ItemBillingsForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMGOODS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMGOODS] Performing VerifyExist on ItemBillingsFormTable...", Logger.MessageType.INF);
				SeleniumControl PDMGOODS_ItemBillingsFormTable = new SeleniumControl( sDriver, "ItemBillingsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMIBILL_ITEMPRODUCT_HDR_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PDMGOODS_ItemBillingsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMGOODS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMGOODS] Performing Close on ItemBillingsForm...", Logger.MessageType.INF);
				SeleniumControl PDMGOODS_ItemBillingsForm = new SeleniumControl( sDriver, "ItemBillingsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMIBILL_ITEMPRODUCT_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PDMGOODS_ItemBillingsForm);
IWebElement formBttn = PDMGOODS_ItemBillingsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "PDMGOODS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMGOODS] Performing Click on CostsLink...", Logger.MessageType.INF);
				SeleniumControl PDMGOODS_CostsLink = new SeleniumControl( sDriver, "CostsLink", "ID", "lnk_1007196_PDMGOODS_ITEM_HDR");
				Function.WaitControlDisplayed(PDMGOODS_CostsLink);
PDMGOODS_CostsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMGOODS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMGOODS] Performing VerifyExists on CostsForm...", Logger.MessageType.INF);
				SeleniumControl PDMGOODS_CostsForm = new SeleniumControl( sDriver, "CostsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMCOST_ITEMCST_DTL_']/ancestor::form[1]");
				Function.AssertEqual(true,PDMGOODS_CostsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMGOODS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMGOODS] Performing VerifyExist on CostsFormTable...", Logger.MessageType.INF);
				SeleniumControl PDMGOODS_CostsFormTable = new SeleniumControl( sDriver, "CostsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMCOST_ITEMCST_DTL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PDMGOODS_CostsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMGOODS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMGOODS] Performing ClickButton on CostsForm...", Logger.MessageType.INF);
				SeleniumControl PDMGOODS_CostsForm = new SeleniumControl( sDriver, "CostsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMCOST_ITEMCST_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PDMGOODS_CostsForm);
IWebElement formBttn = PDMGOODS_CostsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PDMGOODS_CostsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PDMGOODS_CostsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMGOODS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMGOODS] Performing VerifyExists on Costs_TotalUnitCost...", Logger.MessageType.INF);
				SeleniumControl PDMGOODS_Costs_TotalUnitCost = new SeleniumControl( sDriver, "Costs_TotalUnitCost", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMCOST_ITEMCST_DTL_']/ancestor::form[1]/descendant::*[@id='TOTAL']");
				Function.AssertEqual(true,PDMGOODS_Costs_TotalUnitCost.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMGOODS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMGOODS] Performing Close on CostsForm...", Logger.MessageType.INF);
				SeleniumControl PDMGOODS_CostsForm = new SeleniumControl( sDriver, "CostsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMCOST_ITEMCST_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PDMGOODS_CostsForm);
IWebElement formBttn = PDMGOODS_CostsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Assigned Standard txt");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMGOODS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMGOODS] Performing Click on AssignedStandardTextLink...", Logger.MessageType.INF);
				SeleniumControl PDMGOODS_AssignedStandardTextLink = new SeleniumControl( sDriver, "AssignedStandardTextLink", "ID", "lnk_1007197_PDMGOODS_ITEM_HDR");
				Function.WaitControlDisplayed(PDMGOODS_AssignedStandardTextLink);
PDMGOODS_AssignedStandardTextLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMGOODS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMGOODS] Performing VerifyExists on AssignedStandardTextForm...", Logger.MessageType.INF);
				SeleniumControl PDMGOODS_AssignedStandardTextForm = new SeleniumControl( sDriver, "AssignedStandardTextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSTDTX_ITEMTEXT_DTL_']/ancestor::form[1]");
				Function.AssertEqual(true,PDMGOODS_AssignedStandardTextForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMGOODS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMGOODS] Performing VerifyExists on StandardTextForm...", Logger.MessageType.INF);
				SeleniumControl PDMGOODS_StandardTextForm = new SeleniumControl( sDriver, "StandardTextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSTDTX_TEXTCODES_DTL_']/ancestor::form[1]");
				Function.AssertEqual(true,PDMGOODS_StandardTextForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMGOODS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMGOODS] Performing VerifyExist on AssignedStandardTextFormTable...", Logger.MessageType.INF);
				SeleniumControl PDMGOODS_AssignedStandardTextFormTable = new SeleniumControl( sDriver, "AssignedStandardTextFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSTDTX_ITEMTEXT_DTL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PDMGOODS_AssignedStandardTextFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMGOODS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMGOODS] Performing VerifyExist on StandardTextFormTable...", Logger.MessageType.INF);
				SeleniumControl PDMGOODS_StandardTextFormTable = new SeleniumControl( sDriver, "StandardTextFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSTDTX_TEXTCODES_DTL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PDMGOODS_StandardTextFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMGOODS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMGOODS] Performing Close on AssignedStandardTextForm...", Logger.MessageType.INF);
				SeleniumControl PDMGOODS_AssignedStandardTextForm = new SeleniumControl( sDriver, "AssignedStandardTextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSTDTX_ITEMTEXT_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PDMGOODS_AssignedStandardTextForm);
IWebElement formBttn = PDMGOODS_AssignedStandardTextForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "PDMGOODS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMGOODS] Performing Click on UserDefinedInfoLink...", Logger.MessageType.INF);
				SeleniumControl PDMGOODS_UserDefinedInfoLink = new SeleniumControl( sDriver, "UserDefinedInfoLink", "ID", "lnk_1001128_PDMGOODS_ITEM_HDR");
				Function.WaitControlDisplayed(PDMGOODS_UserDefinedInfoLink);
PDMGOODS_UserDefinedInfoLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMGOODS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMGOODS] Performing VerifyExists on UserDefinedInfoForm...", Logger.MessageType.INF);
				SeleniumControl PDMGOODS_UserDefinedInfoForm = new SeleniumControl( sDriver, "UserDefinedInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MMUDINF_USERDEFINEDINFO_']/ancestor::form[1]");
				Function.AssertEqual(true,PDMGOODS_UserDefinedInfoForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMGOODS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMGOODS] Performing VerifyExist on UserDefinedInfoFormTable...", Logger.MessageType.INF);
				SeleniumControl PDMGOODS_UserDefinedInfoFormTable = new SeleniumControl( sDriver, "UserDefinedInfoFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__MMUDINF_USERDEFINEDINFO_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PDMGOODS_UserDefinedInfoFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMGOODS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMGOODS] Performing ClickButton on UserDefinedInfoForm...", Logger.MessageType.INF);
				SeleniumControl PDMGOODS_UserDefinedInfoForm = new SeleniumControl( sDriver, "UserDefinedInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MMUDINF_USERDEFINEDINFO_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PDMGOODS_UserDefinedInfoForm);
IWebElement formBttn = PDMGOODS_UserDefinedInfoForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PDMGOODS_UserDefinedInfoForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PDMGOODS_UserDefinedInfoForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMGOODS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMGOODS] Performing VerifyExists on UserDefinedInfo_Labels...", Logger.MessageType.INF);
				SeleniumControl PDMGOODS_UserDefinedInfo_Labels = new SeleniumControl( sDriver, "UserDefinedInfo_Labels", "xpath", "//div[translate(@id,'0123456789','')='pr__MMUDINF_USERDEFINEDINFO_']/ancestor::form[1]/descendant::*[@id='UDEF_LBL']");
				Function.AssertEqual(true,PDMGOODS_UserDefinedInfo_Labels.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMGOODS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMGOODS] Performing Close on UserDefinedInfoForm...", Logger.MessageType.INF);
				SeleniumControl PDMGOODS_UserDefinedInfoForm = new SeleniumControl( sDriver, "UserDefinedInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MMUDINF_USERDEFINEDINFO_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PDMGOODS_UserDefinedInfoForm);
IWebElement formBttn = PDMGOODS_UserDefinedInfoForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "PDMGOODS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMGOODS] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl PDMGOODS_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PDMGOODS_MainForm);
IWebElement formBttn = PDMGOODS_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

