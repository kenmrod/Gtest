 
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
    public class PJMCLIN_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Projects", "xpath","//div[@class='busItem'][.='Projects']").Click();
new SeleniumControl(sDriver,"Project Setup", "xpath","//div[@class='deptItem'][.='Project Setup']").Click();
new SeleniumControl(sDriver,"Unit Pricing Information", "xpath","//div[@class='navItem'][.='Unit Pricing Information']").Click();
new SeleniumControl(sDriver,"Manage CLIN Information", "xpath","//div[@class='navItem'][.='Manage CLIN Information']").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SelectMenu]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("QUERY");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMCLIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMCLIN] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl PJMCLIN_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PJMCLIN_MainForm);
IWebElement formBttn = PJMCLIN_MainForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).Count <= 0 ? PJMCLIN_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Query')]")).FirstOrDefault() :
PJMCLIN_MainForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).FirstOrDefault();
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
								try
				{
				this.ScriptLogger.WriteLine("MAIN FORM");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMCLIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMCLIN] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl PJMCLIN_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJMCLIN_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMCLIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMCLIN] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl PJMCLIN_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PJMCLIN_MainForm);
IWebElement formBttn = PJMCLIN_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PJMCLIN_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PJMCLIN_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMCLIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMCLIN] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl PJMCLIN_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,PJMCLIN_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMCLIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMCLIN] Performing VerifyExists on Identification_Project...", Logger.MessageType.INF);
				SeleniumControl PJMCLIN_Identification_Project = new SeleniumControl( sDriver, "Identification_Project", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PROJ_ID']");
				Function.AssertEqual(true,PJMCLIN_Identification_Project.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("CLIN FORM");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMCLIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMCLIN] Performing VerifyExist on ChildFormTable...", Logger.MessageType.INF);
				SeleniumControl PJMCLIN_ChildFormTable = new SeleniumControl( sDriver, "ChildFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PJM_PROJCLIN_CHILD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJMCLIN_ChildFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMCLIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMCLIN] Performing ClickButton on ChildForm...", Logger.MessageType.INF);
				SeleniumControl PJMCLIN_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJM_PROJCLIN_CHILD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJMCLIN_ChildForm);
IWebElement formBttn = PJMCLIN_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PJMCLIN_ChildForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PJMCLIN_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMCLIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMCLIN] Performing VerifyExists on ChildForm...", Logger.MessageType.INF);
				SeleniumControl PJMCLIN_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJM_PROJCLIN_CHILD_']/ancestor::form[1]");
				Function.AssertEqual(true,PJMCLIN_ChildForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMCLIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMCLIN] Performing VerifyExists on CLINDetails_CLIN...", Logger.MessageType.INF);
				SeleniumControl PJMCLIN_CLINDetails_CLIN = new SeleniumControl( sDriver, "CLINDetails_CLIN", "xpath", "//div[translate(@id,'0123456789','')='pr__PJM_PROJCLIN_CHILD_']/ancestor::form[1]/descendant::*[@id='CLIN_ID']");
				Function.AssertEqual(true,PJMCLIN_CLINDetails_CLIN.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("LINK");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMCLIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMCLIN] Performing VerifyExists on CLINDetails_ItemLinkageLink...", Logger.MessageType.INF);
				SeleniumControl PJMCLIN_CLINDetails_ItemLinkageLink = new SeleniumControl( sDriver, "CLINDetails_ItemLinkageLink", "ID", "lnk_1004317_PJM_PROJCLIN_CHILD");
				Function.AssertEqual(true,PJMCLIN_CLINDetails_ItemLinkageLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMCLIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMCLIN] Performing Click on CLINDetails_ItemLinkageLink...", Logger.MessageType.INF);
				SeleniumControl PJMCLIN_CLINDetails_ItemLinkageLink = new SeleniumControl( sDriver, "CLINDetails_ItemLinkageLink", "ID", "lnk_1004317_PJM_PROJCLIN_CHILD");
				Function.WaitControlDisplayed(PJMCLIN_CLINDetails_ItemLinkageLink);
PJMCLIN_CLINDetails_ItemLinkageLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMCLIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMCLIN] Performing VerifyExist on ItemLinkage_Table...", Logger.MessageType.INF);
				SeleniumControl PJMCLIN_ItemLinkage_Table = new SeleniumControl( sDriver, "ItemLinkage_Table", "xpath", "//div[translate(@id,'0123456789','')='pr__PJM_PROJCLINPROD_CHILD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJMCLIN_ItemLinkage_Table.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMCLIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMCLIN] Performing VerifyExists on ItemLinkageForm...", Logger.MessageType.INF);
				SeleniumControl PJMCLIN_ItemLinkageForm = new SeleniumControl( sDriver, "ItemLinkageForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJM_PROJCLINPROD_CHILD_']/ancestor::form[1]");
				Function.AssertEqual(true,PJMCLIN_ItemLinkageForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMCLIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMCLIN] Performing ClickButton on ItemLinkageForm...", Logger.MessageType.INF);
				SeleniumControl PJMCLIN_ItemLinkageForm = new SeleniumControl( sDriver, "ItemLinkageForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJM_PROJCLINPROD_CHILD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJMCLIN_ItemLinkageForm);
IWebElement formBttn = PJMCLIN_ItemLinkageForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PJMCLIN_ItemLinkageForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PJMCLIN_ItemLinkageForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMCLIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMCLIN] Performing VerifyExists on ItemLinkage_Item...", Logger.MessageType.INF);
				SeleniumControl PJMCLIN_ItemLinkage_Item = new SeleniumControl( sDriver, "ItemLinkage_Item", "xpath", "//div[translate(@id,'0123456789','')='pr__PJM_PROJCLINPROD_CHILD_']/ancestor::form[1]/descendant::*[@id='ITEM_ID']");
				Function.AssertEqual(true,PJMCLIN_ItemLinkage_Item.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMCLIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMCLIN] Performing Close on ItemLinkageForm...", Logger.MessageType.INF);
				SeleniumControl PJMCLIN_ItemLinkageForm = new SeleniumControl( sDriver, "ItemLinkageForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJM_PROJCLINPROD_CHILD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJMCLIN_ItemLinkageForm);
IWebElement formBttn = PJMCLIN_ItemLinkageForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMCLIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMCLIN] Performing VerifyExists on CLINDetails_ProjectUnitPricingLink...", Logger.MessageType.INF);
				SeleniumControl PJMCLIN_CLINDetails_ProjectUnitPricingLink = new SeleniumControl( sDriver, "CLINDetails_ProjectUnitPricingLink", "ID", "lnk_3283_PJM_PROJCLIN_CHILD");
				Function.AssertEqual(true,PJMCLIN_CLINDetails_ProjectUnitPricingLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMCLIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMCLIN] Performing Click on CLINDetails_ProjectUnitPricingLink...", Logger.MessageType.INF);
				SeleniumControl PJMCLIN_CLINDetails_ProjectUnitPricingLink = new SeleniumControl( sDriver, "CLINDetails_ProjectUnitPricingLink", "ID", "lnk_3283_PJM_PROJCLIN_CHILD");
				Function.WaitControlDisplayed(PJMCLIN_CLINDetails_ProjectUnitPricingLink);
PJMCLIN_CLINDetails_ProjectUnitPricingLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMCLIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMCLIN] Performing VerifyExists on ItemDetailsForm...", Logger.MessageType.INF);
				SeleniumControl PJMCLIN_ItemDetailsForm = new SeleniumControl( sDriver, "ItemDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBASIC_PROJCLINPROD_ITPRCHDR_']/ancestor::form[1]");
				Function.AssertEqual(true,PJMCLIN_ItemDetailsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMCLIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMCLIN] Performing VerifyExists on ItemDetails_Item...", Logger.MessageType.INF);
				SeleniumControl PJMCLIN_ItemDetails_Item = new SeleniumControl( sDriver, "ItemDetails_Item", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBASIC_PROJCLINPROD_ITPRCHDR_']/ancestor::form[1]/descendant::*[@id='ITEM_ID']");
				Function.AssertEqual(true,PJMCLIN_ItemDetails_Item.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMCLIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMCLIN] Performing VerifyExist on PricingDetailsTable...", Logger.MessageType.INF);
				SeleniumControl PJMCLIN_PricingDetailsTable = new SeleniumControl( sDriver, "PricingDetailsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBASIC_CLINPRICESCH_ITPRC_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJMCLIN_PricingDetailsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMCLIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMCLIN] Performing ClickButton on PricingDetailsForm...", Logger.MessageType.INF);
				SeleniumControl PJMCLIN_PricingDetailsForm = new SeleniumControl( sDriver, "PricingDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBASIC_CLINPRICESCH_ITPRC_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJMCLIN_PricingDetailsForm);
IWebElement formBttn = PJMCLIN_PricingDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PJMCLIN_PricingDetailsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PJMCLIN_PricingDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMCLIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMCLIN] Performing VerifyExists on PricingDetailsForm...", Logger.MessageType.INF);
				SeleniumControl PJMCLIN_PricingDetailsForm = new SeleniumControl( sDriver, "PricingDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBASIC_CLINPRICESCH_ITPRC_']/ancestor::form[1]");
				Function.AssertEqual(true,PJMCLIN_PricingDetailsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMCLIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMCLIN] Performing VerifyExists on PricingDetails_FromQuantity...", Logger.MessageType.INF);
				SeleniumControl PJMCLIN_PricingDetails_FromQuantity = new SeleniumControl( sDriver, "PricingDetails_FromQuantity", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBASIC_CLINPRICESCH_ITPRC_']/ancestor::form[1]/descendant::*[@id='FROM_QTY']");
				Function.AssertEqual(true,PJMCLIN_PricingDetails_FromQuantity.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("CLOSE");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMCLIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMCLIN] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl PJMCLIN_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PJMCLIN_MainForm);
IWebElement formBttn = PJMCLIN_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

