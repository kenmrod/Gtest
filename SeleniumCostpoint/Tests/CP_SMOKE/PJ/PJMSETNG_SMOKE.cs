 
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
    public class PJMSETNG_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Project Setup Controls", "xpath","//div[@class='navItem'][.='Project Setup Controls']").Click();
new SeleniumControl(sDriver,"Configure Project Settings", "xpath","//div[@class='navItem'][.='Configure Project Settings']").Click();


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
				Function.CurrentComponent = "PJMSETNG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMSETNG] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl PJMSETNG_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,PJMSETNG_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMSETNG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMSETNG] Performing VerifyExists on InterCompanyWorkOrders_HomeLocation...", Logger.MessageType.INF);
				SeleniumControl PJMSETNG_InterCompanyWorkOrders_HomeLocation = new SeleniumControl( sDriver, "InterCompanyWorkOrders_HomeLocation", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='IWO_LOC_CD']");
				Function.AssertEqual(true,PJMSETNG_InterCompanyWorkOrders_HomeLocation.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Revenue Formulas");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try
				{
				Function.ScrollDown();


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ScrollDown]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMSETNG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMSETNG] Performing Click on InterCompanyWorkOrders_ProjectProcessSettings_RevenueFormulasLink...", Logger.MessageType.INF);
				SeleniumControl PJMSETNG_InterCompanyWorkOrders_ProjectProcessSettings_RevenueFormulasLink = new SeleniumControl( sDriver, "InterCompanyWorkOrders_ProjectProcessSettings_RevenueFormulasLink", "ID", "lnk_3185_PJMSETNG_PROJCNTL");
				Function.WaitControlDisplayed(PJMSETNG_InterCompanyWorkOrders_ProjectProcessSettings_RevenueFormulasLink);
PJMSETNG_InterCompanyWorkOrders_ProjectProcessSettings_RevenueFormulasLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMSETNG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMSETNG] Performing VerifyExist on RevenueFormulas_Table...", Logger.MessageType.INF);
				SeleniumControl PJMSETNG_RevenueFormulas_Table = new SeleniumControl( sDriver, "RevenueFormulas_Table", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMSETNG_REVFORM_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJMSETNG_RevenueFormulas_Table.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMSETNG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMSETNG] Performing ClickButton on SelectedRevenueFormulas_Form...", Logger.MessageType.INF);
				SeleniumControl PJMSETNG_SelectedRevenueFormulas_Form = new SeleniumControl( sDriver, "SelectedRevenueFormulas_Form", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMSETNG_REVFORMCOMP_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJMSETNG_SelectedRevenueFormulas_Form);
IWebElement formBttn = PJMSETNG_SelectedRevenueFormulas_Form.mElement.FindElements(By.CssSelector("*[title*='Close']")).Count <= 0 ? PJMSETNG_SelectedRevenueFormulas_Form.mElement.FindElements(By.XPath(".//*[contains(text(),'Close')]")).FirstOrDefault() :
PJMSETNG_SelectedRevenueFormulas_Form.mElement.FindElements(By.CssSelector("*[title*='Close']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Close not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Corporate Settings");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try
				{
				Function.ScrollDown();


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ScrollDown]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMSETNG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMSETNG] Performing Click on InterCompanyWorkOrders_ProjectProcessSettings_CorporateSettingsLink...", Logger.MessageType.INF);
				SeleniumControl PJMSETNG_InterCompanyWorkOrders_ProjectProcessSettings_CorporateSettingsLink = new SeleniumControl( sDriver, "InterCompanyWorkOrders_ProjectProcessSettings_CorporateSettingsLink", "ID", "lnk_3152_PJMSETNG_PROJCNTL");
				Function.WaitControlDisplayed(PJMSETNG_InterCompanyWorkOrders_ProjectProcessSettings_CorporateSettingsLink);
PJMSETNG_InterCompanyWorkOrders_ProjectProcessSettings_CorporateSettingsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Scroll Down Again");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try
				{
				Function.ScrollDown();


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ScrollDown]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMSETNG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMSETNG] Performing Click on InterCompanyWorkOrders_ProjectProcessSettings_CorporateSettingsLink...", Logger.MessageType.INF);
				SeleniumControl PJMSETNG_InterCompanyWorkOrders_ProjectProcessSettings_CorporateSettingsLink = new SeleniumControl( sDriver, "InterCompanyWorkOrders_ProjectProcessSettings_CorporateSettingsLink", "ID", "lnk_3152_PJMSETNG_PROJCNTL");
				Function.WaitControlDisplayed(PJMSETNG_InterCompanyWorkOrders_ProjectProcessSettings_CorporateSettingsLink);
PJMSETNG_InterCompanyWorkOrders_ProjectProcessSettings_CorporateSettingsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try
				{
				Function.ScrollUp();


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ScrollUp]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMSETNG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMSETNG] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl PJMSETNG_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PJMSETNG_MainForm);
IWebElement formBttn = PJMSETNG_MainForm.mElement.FindElements(By.CssSelector("*[title*='Minimize']")).Count <= 0 ? PJMSETNG_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Minimize')]")).FirstOrDefault() :
PJMSETNG_MainForm.mElement.FindElements(By.CssSelector("*[title*='Minimize']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Minimize not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMSETNG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMSETNG] Performing VerifyExists on CorporateSettingsForm...", Logger.MessageType.INF);
				SeleniumControl PJMSETNG_CorporateSettingsForm = new SeleniumControl( sDriver, "CorporateSettingsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMSETNG_PROJCNTLCORP_']/ancestor::form[1]");
				Function.AssertEqual(true,PJMSETNG_CorporateSettingsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMSETNG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMSETNG] Performing VerifyExists on CorporateSettings_ApplyBurdeningBasedOn_YearToDateRates...", Logger.MessageType.INF);
				SeleniumControl PJMSETNG_CorporateSettings_ApplyBurdeningBasedOn_YearToDateRates = new SeleniumControl( sDriver, "CorporateSettings_ApplyBurdeningBasedOn_YearToDateRates", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMSETNG_PROJCNTLCORP_']/ancestor::form[1]/descendant::*[@id='S_RT_APPL_PD_CD' and @value='Y']");
				Function.AssertEqual(true,PJMSETNG_CorporateSettings_ApplyBurdeningBasedOn_YearToDateRates.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMSETNG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMSETNG] Performing Close on CorporateSettingsForm...", Logger.MessageType.INF);
				SeleniumControl PJMSETNG_CorporateSettingsForm = new SeleniumControl( sDriver, "CorporateSettingsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMSETNG_PROJCNTLCORP_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJMSETNG_CorporateSettingsForm);
IWebElement formBttn = PJMSETNG_CorporateSettingsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMSETNG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMSETNG] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl PJMSETNG_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PJMSETNG_MainForm);
IWebElement formBttn = PJMSETNG_MainForm.mElement.FindElements(By.CssSelector("*[title*='Maximize']")).Count <= 0 ? PJMSETNG_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Maximize')]")).FirstOrDefault() :
PJMSETNG_MainForm.mElement.FindElements(By.CssSelector("*[title*='Maximize']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Maximize not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Project Segment Lengths");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMSETNG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMSETNG] Performing VerifyExist on ProjectSegmentLengthsTable...", Logger.MessageType.INF);
				SeleniumControl PJMSETNG_ProjectSegmentLengthsTable = new SeleniumControl( sDriver, "ProjectSegmentLengthsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMSETNG_DFLTPROJLVLS_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJMSETNG_ProjectSegmentLengthsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
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
				Function.CurrentComponent = "PJMSETNG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMSETNG] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl PJMSETNG_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PJMSETNG_MainForm);
IWebElement formBttn = PJMSETNG_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

