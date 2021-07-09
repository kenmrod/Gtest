 
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
    public class PDMPPCAT_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Product Billing", "xpath","//div[@class='navItem'][.='Product Billing']").Click();
new SeleniumControl(sDriver,"Manage Product Price Catalogs", "xpath","//div[@class='navItem'][.='Manage Product Price Catalogs']").Click();


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
				Function.CurrentComponent = "PDMPPCAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPPCAT] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl PDMPPCAT_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,PDMPPCAT_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPPCAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPPCAT] Performing VerifyExists on Catalog...", Logger.MessageType.INF);
				SeleniumControl PDMPPCAT_Catalog = new SeleniumControl( sDriver, "Catalog", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PRICE_CATLG_CD']");
				Function.AssertEqual(true,PDMPPCAT_Catalog.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPPCAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPPCAT] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl PDMPPCAT_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PDMPPCAT_MainForm);
IWebElement formBttn = PDMPPCAT_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? PDMPPCAT_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
PDMPPCAT_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPPCAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPPCAT] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl PDMPPCAT_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PDMPPCAT_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Price Info");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPPCAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPPCAT] Performing VerifyExists on PriceInformationForm...", Logger.MessageType.INF);
				SeleniumControl PDMPPCAT_PriceInformationForm = new SeleniumControl( sDriver, "PriceInformationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PDMPPCAT_PRODPRICESCH_CHILD_']/ancestor::form[1]");
				Function.AssertEqual(true,PDMPPCAT_PriceInformationForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPPCAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPPCAT] Performing VerifyExist on PriceInformationTable...", Logger.MessageType.INF);
				SeleniumControl PDMPPCAT_PriceInformationTable = new SeleniumControl( sDriver, "PriceInformationTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PDMPPCAT_PRODPRICESCH_CHILD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PDMPPCAT_PriceInformationTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPPCAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPPCAT] Performing Click on PriceInformation_OK...", Logger.MessageType.INF);
				SeleniumControl PDMPPCAT_PriceInformation_OK = new SeleniumControl( sDriver, "PriceInformation_OK", "xpath", "//div[translate(@id,'0123456789','')='pr__PDMPPCAT_PRODPRICESCH_CHILD_']/ancestor::form[1]/following-sibling::div[1]/descendant::*[@id='bOk']");
				Function.WaitControlDisplayed(PDMPPCAT_PriceInformation_OK);
if (PDMPPCAT_PriceInformation_OK.mElement.GetAttribute("class") == "popupBtn" && sDriver.BrowserType == "ie")
PDMPPCAT_PriceInformation_OK.Click(5,5);
else PDMPPCAT_PriceInformation_OK.Click(4.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Cost Info");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPPCAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPPCAT] Performing Click on CostInformationLink...", Logger.MessageType.INF);
				SeleniumControl PDMPPCAT_CostInformationLink = new SeleniumControl( sDriver, "CostInformationLink", "ID", "lnk_1003300_PDMPPCAT_PRODPRICECATLG_HDR");
				Function.WaitControlDisplayed(PDMPPCAT_CostInformationLink);
PDMPPCAT_CostInformationLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPPCAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPPCAT] Performing VerifyExists on CalculateCostOfGoodsSoldBasedOnForm...", Logger.MessageType.INF);
				SeleniumControl PDMPPCAT_CalculateCostOfGoodsSoldBasedOnForm = new SeleniumControl( sDriver, "CalculateCostOfGoodsSoldBasedOnForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PDMPPCAT_PRODPRICECATLG_CI_']/ancestor::form[1]");
				Function.AssertEqual(true,PDMPPCAT_CalculateCostOfGoodsSoldBasedOnForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPPCAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPPCAT] Performing VerifyExists on CalculateCostOfGoodsSoldBasedOn_PercentageOfSales...", Logger.MessageType.INF);
				SeleniumControl PDMPPCAT_CalculateCostOfGoodsSoldBasedOn_PercentageOfSales = new SeleniumControl( sDriver, "CalculateCostOfGoodsSoldBasedOn_PercentageOfSales", "xpath", "//div[translate(@id,'0123456789','')='pr__PDMPPCAT_PRODPRICECATLG_CI_']/ancestor::form[1]/descendant::*[@id='S_COGS_CALC_CD' and @value='P']");
				Function.AssertEqual(true,PDMPPCAT_CalculateCostOfGoodsSoldBasedOn_PercentageOfSales.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPPCAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPPCAT] Performing VerifyExists on CostInformationForm...", Logger.MessageType.INF);
				SeleniumControl PDMPPCAT_CostInformationForm = new SeleniumControl( sDriver, "CostInformationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PDMPPCAT_PRODCSTSCH_CISUB_']/ancestor::form[1]");
				Function.AssertEqual(true,PDMPPCAT_CostInformationForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPPCAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPPCAT] Performing VerifyExist on CostInformationTable...", Logger.MessageType.INF);
				SeleniumControl PDMPPCAT_CostInformationTable = new SeleniumControl( sDriver, "CostInformationTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PDMPPCAT_PRODCSTSCH_CISUB_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PDMPPCAT_CostInformationTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPPCAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPPCAT] Performing Close on CalculateCostOfGoodsSoldBasedOnForm...", Logger.MessageType.INF);
				SeleniumControl PDMPPCAT_CalculateCostOfGoodsSoldBasedOnForm = new SeleniumControl( sDriver, "CalculateCostOfGoodsSoldBasedOnForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PDMPPCAT_PRODPRICECATLG_CI_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PDMPPCAT_CalculateCostOfGoodsSoldBasedOnForm);
IWebElement formBttn = PDMPPCAT_CalculateCostOfGoodsSoldBasedOnForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Warranty Info");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPPCAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPPCAT] Performing Click on WarrantyInformationLink...", Logger.MessageType.INF);
				SeleniumControl PDMPPCAT_WarrantyInformationLink = new SeleniumControl( sDriver, "WarrantyInformationLink", "ID", "lnk_1003302_PDMPPCAT_PRODPRICECATLG_HDR");
				Function.WaitControlDisplayed(PDMPPCAT_WarrantyInformationLink);
PDMPPCAT_WarrantyInformationLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPPCAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPPCAT] Performing VerifyExists on WarrantyInformationUpperForm...", Logger.MessageType.INF);
				SeleniumControl PDMPPCAT_WarrantyInformationUpperForm = new SeleniumControl( sDriver, "WarrantyInformationUpperForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PDMPPCAT_PRODPRICECATLG_WI_']/ancestor::form[1]");
				Function.AssertEqual(true,PDMPPCAT_WarrantyInformationUpperForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPPCAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPPCAT] Performing VerifyExists on WarrantyInformationUpperForm_CalculateWarrantyCostsBasedOn_EnterPercentageOfSalesToCalculateWarrantyCosts...", Logger.MessageType.INF);
				SeleniumControl PDMPPCAT_WarrantyInformationUpperForm_CalculateWarrantyCostsBasedOn_EnterPercentageOfSalesToCalculateWarrantyCosts = new SeleniumControl( sDriver, "WarrantyInformationUpperForm_CalculateWarrantyCostsBasedOn_EnterPercentageOfSalesToCalculateWarrantyCosts", "xpath", "//div[translate(@id,'0123456789','')='pr__PDMPPCAT_PRODPRICECATLG_WI_']/ancestor::form[1]/descendant::*[@id='WARR_PCT_RT']");
				Function.AssertEqual(true,PDMPPCAT_WarrantyInformationUpperForm_CalculateWarrantyCostsBasedOn_EnterPercentageOfSalesToCalculateWarrantyCosts.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPPCAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPPCAT] Performing VerifyExists on WarrantyInformationLowerForm...", Logger.MessageType.INF);
				SeleniumControl PDMPPCAT_WarrantyInformationLowerForm = new SeleniumControl( sDriver, "WarrantyInformationLowerForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PDMPPCAT_PRODWARRCSTSCH_WISUB_']/ancestor::form[1]");
				Function.AssertEqual(true,PDMPPCAT_WarrantyInformationLowerForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPPCAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPPCAT] Performing VerifyExist on WarrantyInformationLowerFormTable...", Logger.MessageType.INF);
				SeleniumControl PDMPPCAT_WarrantyInformationLowerFormTable = new SeleniumControl( sDriver, "WarrantyInformationLowerFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PDMPPCAT_PRODWARRCSTSCH_WISUB_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PDMPPCAT_WarrantyInformationLowerFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPPCAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPPCAT] Performing VerifyExists on WarrantyInformationUpperForm...", Logger.MessageType.INF);
				SeleniumControl PDMPPCAT_WarrantyInformationUpperForm = new SeleniumControl( sDriver, "WarrantyInformationUpperForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PDMPPCAT_PRODPRICECATLG_WI_']/ancestor::form[1]");
				Function.AssertEqual(true,PDMPPCAT_WarrantyInformationUpperForm.Exists());

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
				Function.CurrentComponent = "PDMPPCAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPPCAT] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl PDMPPCAT_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PDMPPCAT_MainForm);
IWebElement formBttn = PDMPPCAT_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

