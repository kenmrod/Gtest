 
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
    public class PJQETC_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Budgeting and ETC", "xpath","//div[@class='deptItem'][.='Budgeting and ETC']").Click();
new SeleniumControl(sDriver,"Estimate To Complete Reports/Inquiries", "xpath","//div[@class='navItem'][.='Estimate To Complete Reports/Inquiries']").Click();
new SeleniumControl(sDriver,"View Estimate To Complete", "xpath","//div[@class='navItem'][.='View Estimate To Complete']").Click();


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
				Function.CurrentComponent = "PJQETC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQETC] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl PJQETC_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,PJQETC_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQETC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQETC] Performing VerifyExists on Project...", Logger.MessageType.INF);
				SeleniumControl PJQETC_Project = new SeleniumControl( sDriver, "Project", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PROJ_ID']");
				Function.AssertEqual(true,PJQETC_Project.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQETC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQETC] Performing VerifyExists on ETCDetailsLink...", Logger.MessageType.INF);
				SeleniumControl PJQETC_ETCDetailsLink = new SeleniumControl( sDriver, "ETCDetailsLink", "ID", "lnk_1005084_PJQETC_HDR");
				Function.AssertEqual(true,PJQETC_ETCDetailsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQETC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQETC] Performing Set on Project...", Logger.MessageType.INF);
				SeleniumControl PJQETC_Project = new SeleniumControl( sDriver, "Project", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PROJ_ID']");
				PJQETC_Project.Click();
PJQETC_Project.SendKeys("0400", true);
Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));
PJQETC_Project.SendKeys(OpenQA.Selenium.Keys.Shift + OpenQA.Selenium.Keys.Tab);


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
				this.ScriptLogger.WriteLine("ETC Details");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQETC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQETC] Performing VerifyExists on ETCDetailsForm...", Logger.MessageType.INF);
				SeleniumControl PJQETC_ETCDetailsForm = new SeleniumControl( sDriver, "ETCDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQETC_RPTETCAMT_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,PJQETC_ETCDetailsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQETC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQETC] Performing ClickButton on ETCDetailsForm...", Logger.MessageType.INF);
				SeleniumControl PJQETC_ETCDetailsForm = new SeleniumControl( sDriver, "ETCDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQETC_RPTETCAMT_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJQETC_ETCDetailsForm);
IWebElement formBttn = PJQETC_ETCDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).Count <= 0 ? PJQETC_ETCDetailsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Query')]")).FirstOrDefault() :
PJQETC_ETCDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).FirstOrDefault();
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
				Function.CurrentComponent = "PJQETC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQETC] Performing VerifyExist on ETCDetailsFormTable...", Logger.MessageType.INF);
				SeleniumControl PJQETC_ETCDetailsFormTable = new SeleniumControl( sDriver, "ETCDetailsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQETC_RPTETCAMT_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJQETC_ETCDetailsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQETC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQETC] Performing ClickButton on ETCDetailsForm...", Logger.MessageType.INF);
				SeleniumControl PJQETC_ETCDetailsForm = new SeleniumControl( sDriver, "ETCDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQETC_RPTETCAMT_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJQETC_ETCDetailsForm);
IWebElement formBttn = PJQETC_ETCDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PJQETC_ETCDetailsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PJQETC_ETCDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQETC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQETC] Performing VerifyExists on ETCDetails_ProjectManager...", Logger.MessageType.INF);
				SeleniumControl PJQETC_ETCDetails_ProjectManager = new SeleniumControl( sDriver, "ETCDetails_ProjectManager", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQETC_RPTETCAMT_CTW_']/ancestor::form[1]/descendant::*[@id='PROJ_MGR_NAME']");
				Function.AssertEqual(true,PJQETC_ETCDetails_ProjectManager.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQETC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQETC] Performing VerifyExists on ETCDetailsLink...", Logger.MessageType.INF);
				SeleniumControl PJQETC_ETCDetailsLink = new SeleniumControl( sDriver, "ETCDetailsLink", "ID", "lnk_1005084_PJQETC_HDR");
				Function.AssertEqual(true,PJQETC_ETCDetailsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQETC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQETC] Performing VerifyExists on ETCDetails_CostInfoLink...", Logger.MessageType.INF);
				SeleniumControl PJQETC_ETCDetails_CostInfoLink = new SeleniumControl( sDriver, "ETCDetails_CostInfoLink", "ID", "lnk_1005085_PJQETC_RPTETCAMT_CTW");
				Function.AssertEqual(true,PJQETC_ETCDetails_CostInfoLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQETC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQETC] Performing VerifyExists on ETCDetails_ProjectCostDetailLink...", Logger.MessageType.INF);
				SeleniumControl PJQETC_ETCDetails_ProjectCostDetailLink = new SeleniumControl( sDriver, "ETCDetails_ProjectCostDetailLink", "ID", "lnk_1005087_PJQETC_RPTETCAMT_CTW");
				Function.AssertEqual(true,PJQETC_ETCDetails_ProjectCostDetailLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQETC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQETC] Performing VerifyExists on ETCDetails_OrgDetailLink...", Logger.MessageType.INF);
				SeleniumControl PJQETC_ETCDetails_OrgDetailLink = new SeleniumControl( sDriver, "ETCDetails_OrgDetailLink", "ID", "lnk_1005089_PJQETC_RPTETCAMT_CTW");
				Function.AssertEqual(true,PJQETC_ETCDetails_OrgDetailLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQETC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQETC] Performing Click on ETCDetails_CostInfoLink...", Logger.MessageType.INF);
				SeleniumControl PJQETC_ETCDetails_CostInfoLink = new SeleniumControl( sDriver, "ETCDetails_CostInfoLink", "ID", "lnk_1005085_PJQETC_RPTETCAMT_CTW");
				Function.WaitControlDisplayed(PJQETC_ETCDetails_CostInfoLink);
PJQETC_ETCDetails_CostInfoLink.Click(1.5);


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
				Function.CurrentComponent = "PJQETC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQETC] Performing VerifyExists on ETCDetails_CostInfoForm...", Logger.MessageType.INF);
				SeleniumControl PJQETC_ETCDetails_CostInfoForm = new SeleniumControl( sDriver, "ETCDetails_CostInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQETC_ETCUPDDT_HDR_']/ancestor::form[1]");
				Function.AssertEqual(true,PJQETC_ETCDetails_CostInfoForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQETC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQETC] Performing VerifyExists on ETCDetails_CostInfo_DateUpdated_Incurred...", Logger.MessageType.INF);
				SeleniumControl PJQETC_ETCDetails_CostInfo_DateUpdated_Incurred = new SeleniumControl( sDriver, "ETCDetails_CostInfo_DateUpdated_Incurred", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQETC_ETCUPDDT_HDR_']/ancestor::form[1]/descendant::*[@id='INC_AMT_UPD_DT']");
				Function.AssertEqual(true,PJQETC_ETCDetails_CostInfo_DateUpdated_Incurred.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Cost Info Detail");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQETC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQETC] Performing VerifyExists on ETCDetails_CostInfo_CostInfoDetailForm...", Logger.MessageType.INF);
				SeleniumControl PJQETC_ETCDetails_CostInfo_CostInfoDetailForm = new SeleniumControl( sDriver, "ETCDetails_CostInfo_CostInfoDetailForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQETC_RPTETCAMT_CHLD_']/ancestor::form[1]");
				Function.AssertEqual(true,PJQETC_ETCDetails_CostInfo_CostInfoDetailForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQETC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQETC] Performing ClickButtonIfExists on ETCDetails_CostInfo_CostInfoDetailForm...", Logger.MessageType.INF);
				SeleniumControl PJQETC_ETCDetails_CostInfo_CostInfoDetailForm = new SeleniumControl( sDriver, "ETCDetails_CostInfo_CostInfoDetailForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQETC_RPTETCAMT_CHLD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJQETC_ETCDetails_CostInfo_CostInfoDetailForm);
IWebElement formBttn = PJQETC_ETCDetails_CostInfo_CostInfoDetailForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? PJQETC_ETCDetails_CostInfo_CostInfoDetailForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
PJQETC_ETCDetails_CostInfo_CostInfoDetailForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault();
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
				Function.CurrentComponent = "PJQETC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQETC] Performing VerifyExist on ETCDetails_CostInfo_CostInfoDetailFormTable...", Logger.MessageType.INF);
				SeleniumControl PJQETC_ETCDetails_CostInfo_CostInfoDetailFormTable = new SeleniumControl( sDriver, "ETCDetails_CostInfo_CostInfoDetailFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQETC_RPTETCAMT_CHLD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJQETC_ETCDetails_CostInfo_CostInfoDetailFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQETC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQETC] Performing ClickButtonIfExists on ETCDetails_CostInfo_CostInfoDetailForm...", Logger.MessageType.INF);
				SeleniumControl PJQETC_ETCDetails_CostInfo_CostInfoDetailForm = new SeleniumControl( sDriver, "ETCDetails_CostInfo_CostInfoDetailForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQETC_RPTETCAMT_CHLD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJQETC_ETCDetails_CostInfo_CostInfoDetailForm);
IWebElement formBttn = PJQETC_ETCDetails_CostInfo_CostInfoDetailForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PJQETC_ETCDetails_CostInfo_CostInfoDetailForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PJQETC_ETCDetails_CostInfo_CostInfoDetailForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault();
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
				Function.CurrentComponent = "PJQETC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQETC] Performing VerifyExists on ETCDetails_CostInfo_CostInfoDetail_IncurredCost_Labor...", Logger.MessageType.INF);
				SeleniumControl PJQETC_ETCDetails_CostInfo_CostInfoDetail_IncurredCost_Labor = new SeleniumControl( sDriver, "ETCDetails_CostInfo_CostInfoDetail_IncurredCost_Labor", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQETC_RPTETCAMT_CHLD_']/ancestor::form[1]/descendant::*[@id='INCLABOR']");
				Function.AssertEqual(true,PJQETC_ETCDetails_CostInfo_CostInfoDetail_IncurredCost_Labor.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQETC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQETC] Performing Close on ETCDetails_CostInfoForm...", Logger.MessageType.INF);
				SeleniumControl PJQETC_ETCDetails_CostInfoForm = new SeleniumControl( sDriver, "ETCDetails_CostInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQETC_ETCUPDDT_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJQETC_ETCDetails_CostInfoForm);
IWebElement formBttn = PJQETC_ETCDetails_CostInfoForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQETC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQETC] Performing Click on ETCDetails_ProjectCostDetailLink...", Logger.MessageType.INF);
				SeleniumControl PJQETC_ETCDetails_ProjectCostDetailLink = new SeleniumControl( sDriver, "ETCDetails_ProjectCostDetailLink", "ID", "lnk_1005087_PJQETC_RPTETCAMT_CTW");
				Function.WaitControlDisplayed(PJQETC_ETCDetails_ProjectCostDetailLink);
PJQETC_ETCDetails_ProjectCostDetailLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("ProjectCostDetail");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQETC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQETC] Performing VerifyExists on ETCDetails_ProjectCostDetailForm...", Logger.MessageType.INF);
				SeleniumControl PJQETC_ETCDetails_ProjectCostDetailForm = new SeleniumControl( sDriver, "ETCDetails_ProjectCostDetailForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQETC_ETCUPDDT_CHLD_']/ancestor::form[1]");
				Function.AssertEqual(true,PJQETC_ETCDetails_ProjectCostDetailForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQETC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQETC] Performing VerifyExists on ETCDetails_ProjectCostDetail_DateUpdated_Incurred...", Logger.MessageType.INF);
				SeleniumControl PJQETC_ETCDetails_ProjectCostDetail_DateUpdated_Incurred = new SeleniumControl( sDriver, "ETCDetails_ProjectCostDetail_DateUpdated_Incurred", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQETC_ETCUPDDT_CHLD_']/ancestor::form[1]/descendant::*[@id='INC_AMT_UPD_DT']");
				Function.AssertEqual(true,PJQETC_ETCDetails_ProjectCostDetail_DateUpdated_Incurred.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("ProjectCostDetail_ProjectCostDetail");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQETC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQETC] Performing VerifyExists on ETCDetails_ProjectCostDetail_ProjectCostDetailForm...", Logger.MessageType.INF);
				SeleniumControl PJQETC_ETCDetails_ProjectCostDetail_ProjectCostDetailForm = new SeleniumControl( sDriver, "ETCDetails_ProjectCostDetail_ProjectCostDetailForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQETC_RPTETCAMT_CHLD_']/ancestor::form[1]");
				Function.AssertEqual(true,PJQETC_ETCDetails_ProjectCostDetail_ProjectCostDetailForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQETC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQETC] Performing VerifyExist on ETCDetails_ProjectCostDetail_ProjectCostDetailFormTable...", Logger.MessageType.INF);
				SeleniumControl PJQETC_ETCDetails_ProjectCostDetail_ProjectCostDetailFormTable = new SeleniumControl( sDriver, "ETCDetails_ProjectCostDetail_ProjectCostDetailFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQETC_RPTETCAMT_CHLD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJQETC_ETCDetails_ProjectCostDetail_ProjectCostDetailFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQETC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQETC] Performing ClickButtonIfExists on ETCDetails_ProjectCostDetail_ProjectCostDetailForm...", Logger.MessageType.INF);
				SeleniumControl PJQETC_ETCDetails_ProjectCostDetail_ProjectCostDetailForm = new SeleniumControl( sDriver, "ETCDetails_ProjectCostDetail_ProjectCostDetailForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQETC_RPTETCAMT_CHLD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJQETC_ETCDetails_ProjectCostDetail_ProjectCostDetailForm);
IWebElement formBttn = PJQETC_ETCDetails_ProjectCostDetail_ProjectCostDetailForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PJQETC_ETCDetails_ProjectCostDetail_ProjectCostDetailForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PJQETC_ETCDetails_ProjectCostDetail_ProjectCostDetailForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault();
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
				Function.CurrentComponent = "PJQETC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQETC] Performing VerifyExists on ETCDetails_ProjectCostDetail_ProjectCostDetail_Description...", Logger.MessageType.INF);
				SeleniumControl PJQETC_ETCDetails_ProjectCostDetail_ProjectCostDetail_Description = new SeleniumControl( sDriver, "ETCDetails_ProjectCostDetail_ProjectCostDetail_Description", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQETC_RPTETCAMT_CHLD_']/ancestor::form[1]/descendant::*[@id='DESCRIPTION']");
				Function.AssertEqual(true,PJQETC_ETCDetails_ProjectCostDetail_ProjectCostDetail_Description.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQETC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQETC] Performing Close on ETCDetails_ProjectCostDetailForm...", Logger.MessageType.INF);
				SeleniumControl PJQETC_ETCDetails_ProjectCostDetailForm = new SeleniumControl( sDriver, "ETCDetails_ProjectCostDetailForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQETC_ETCUPDDT_CHLD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJQETC_ETCDetails_ProjectCostDetailForm);
IWebElement formBttn = PJQETC_ETCDetails_ProjectCostDetailForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQETC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQETC] Performing Click on ETCDetails_OrgDetailLink...", Logger.MessageType.INF);
				SeleniumControl PJQETC_ETCDetails_OrgDetailLink = new SeleniumControl( sDriver, "ETCDetails_OrgDetailLink", "ID", "lnk_1005089_PJQETC_RPTETCAMT_CTW");
				Function.WaitControlDisplayed(PJQETC_ETCDetails_OrgDetailLink);
PJQETC_ETCDetails_OrgDetailLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Org Detail");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQETC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQETC] Performing VerifyExists on ETCDetails_OrgDetailForm...", Logger.MessageType.INF);
				SeleniumControl PJQETC_ETCDetails_OrgDetailForm = new SeleniumControl( sDriver, "ETCDetails_OrgDetailForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQETC_ETCUPDDT_ORGDETAIL_']/ancestor::form[1]");
				Function.AssertEqual(true,PJQETC_ETCDetails_OrgDetailForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQETC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQETC] Performing VerifyExists on ETCDetails_OrgDetail_DateUpdated_Incurred...", Logger.MessageType.INF);
				SeleniumControl PJQETC_ETCDetails_OrgDetail_DateUpdated_Incurred = new SeleniumControl( sDriver, "ETCDetails_OrgDetail_DateUpdated_Incurred", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQETC_ETCUPDDT_ORGDETAIL_']/ancestor::form[1]/descendant::*[@id='INC_AMT_UPD_DT']");
				Function.AssertEqual(true,PJQETC_ETCDetails_OrgDetail_DateUpdated_Incurred.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Org Detail_Org Detail");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQETC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQETC] Performing ClickButtonIfExists on ETCDetails_OrgDetailForm...", Logger.MessageType.INF);
				SeleniumControl PJQETC_ETCDetails_OrgDetailForm = new SeleniumControl( sDriver, "ETCDetails_OrgDetailForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQETC_ETCUPDDT_ORGDETAIL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJQETC_ETCDetails_OrgDetailForm);
IWebElement formBttn = PJQETC_ETCDetails_OrgDetailForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? PJQETC_ETCDetails_OrgDetailForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
PJQETC_ETCDetails_OrgDetailForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault();
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
				Function.CurrentComponent = "PJQETC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQETC] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl PJQETC_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PJQETC_MainForm);
IWebElement formBttn = PJQETC_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

