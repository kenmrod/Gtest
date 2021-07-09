 
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
    public class PRRW2_SMOKE : SeleniumTestScript
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
								try
				{
				this.ScriptLogger.WriteLine("START");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "CP7Main";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[CP7Main] Performing SelectMenu on NavMenu...", Logger.MessageType.INF);
				SeleniumControl CP7Main_NavMenu = new SeleniumControl( sDriver, "NavMenu", "ID", "navCont");
				if(!sDriver.Instance.FindElement(By.CssSelector("div[class='navCont']")).Displayed) new SeleniumControl(sDriver,"Browse", "css", "span[id = 'goToLbl']").Click();
new SeleniumControl(sDriver,"People", "xpath","//div[@class='busItem'][.='People']").Click();
new SeleniumControl(sDriver,"Payroll", "xpath","//div[@class='deptItem'][.='Payroll']").Click();
new SeleniumControl(sDriver,"Year-End Processing", "xpath","//div[@class='navItem'][.='Year-End Processing']").Click();
new SeleniumControl(sDriver,"Print W-2s", "xpath","//div[@class='navItem'][.='Print W-2s']").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SelectMenu]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRRW2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRRW2] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl PRRW2_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,PRRW2_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRRW2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRRW2] Performing VerifyExists on ParameterID...", Logger.MessageType.INF);
				SeleniumControl PRRW2_ParameterID = new SeleniumControl( sDriver, "ParameterID", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PARM_ID']");
				Function.AssertEqual(true,PRRW2_ParameterID.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRRW2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRRW2] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl PRRW2_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PRRW2_MainForm);
IWebElement formBttn = PRRW2_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? PRRW2_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
PRRW2_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRRW2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRRW2] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl PRRW2_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PRRW2_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRRW2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRRW2] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl PRRW2_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PRRW2_MainForm);
IWebElement formBttn = PRRW2_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PRRW2_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PRRW2_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRRW2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRRW2] Performing VerifyExists on EmployeeNameNonContiguousRangesLink...", Logger.MessageType.INF);
				SeleniumControl PRRW2_EmployeeNameNonContiguousRangesLink = new SeleniumControl( sDriver, "EmployeeNameNonContiguousRangesLink", "ID", "lnk_5484_PRRW2_PARAM");
				Function.AssertEqual(true,PRRW2_EmployeeNameNonContiguousRangesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRRW2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRRW2] Performing VerifyExists on EmployeeNonContiguousRangesLink...", Logger.MessageType.INF);
				SeleniumControl PRRW2_EmployeeNonContiguousRangesLink = new SeleniumControl( sDriver, "EmployeeNonContiguousRangesLink", "ID", "lnk_1006134_PRRW2_PARAM");
				Function.AssertEqual(true,PRRW2_EmployeeNonContiguousRangesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRRW2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRRW2] Performing VerifyExists on LocatorCodeNonContiguousRangesLink...", Logger.MessageType.INF);
				SeleniumControl PRRW2_LocatorCodeNonContiguousRangesLink = new SeleniumControl( sDriver, "LocatorCodeNonContiguousRangesLink", "ID", "lnk_1006141_PRRW2_PARAM");
				Function.AssertEqual(true,PRRW2_LocatorCodeNonContiguousRangesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRRW2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRRW2] Performing VerifyExists on OrganizationNonContiguousRangesLink...", Logger.MessageType.INF);
				SeleniumControl PRRW2_OrganizationNonContiguousRangesLink = new SeleniumControl( sDriver, "OrganizationNonContiguousRangesLink", "ID", "lnk_1006140_PRRW2_PARAM");
				Function.AssertEqual(true,PRRW2_OrganizationNonContiguousRangesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRRW2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRRW2] Performing VerifyExists on PostalCodeNonContiguousRangesLink...", Logger.MessageType.INF);
				SeleniumControl PRRW2_PostalCodeNonContiguousRangesLink = new SeleniumControl( sDriver, "PostalCodeNonContiguousRangesLink", "ID", "lnk_1006136_PRRW2_PARAM");
				Function.AssertEqual(true,PRRW2_PostalCodeNonContiguousRangesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRRW2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRRW2] Performing VerifyExists on SocialSecurityNumberNonContiguousRangesLink...", Logger.MessageType.INF);
				SeleniumControl PRRW2_SocialSecurityNumberNonContiguousRangesLink = new SeleniumControl( sDriver, "SocialSecurityNumberNonContiguousRangesLink", "ID", "lnk_1006135_PRRW2_PARAM");
				Function.AssertEqual(true,PRRW2_SocialSecurityNumberNonContiguousRangesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRRW2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRRW2] Performing VerifyExists on StateNonContiguousRangesLink...", Logger.MessageType.INF);
				SeleniumControl PRRW2_StateNonContiguousRangesLink = new SeleniumControl( sDriver, "StateNonContiguousRangesLink", "ID", "lnk_1006137_PRRW2_PARAM");
				Function.AssertEqual(true,PRRW2_StateNonContiguousRangesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRRW2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRRW2] Performing Click on EmployeeNonContiguousRangesLink...", Logger.MessageType.INF);
				SeleniumControl PRRW2_EmployeeNonContiguousRangesLink = new SeleniumControl( sDriver, "EmployeeNonContiguousRangesLink", "ID", "lnk_1006134_PRRW2_PARAM");
				Function.WaitControlDisplayed(PRRW2_EmployeeNonContiguousRangesLink);
PRRW2_EmployeeNonContiguousRangesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRRW2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRRW2] Performing VerifyExists on EmployeeNonContiguousRangesForm...", Logger.MessageType.INF);
				SeleniumControl PRRW2_EmployeeNonContiguousRangesForm = new SeleniumControl( sDriver, "EmployeeNonContiguousRangesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPP_NCREMPLID_']/ancestor::form[1]");
				Function.AssertEqual(true,PRRW2_EmployeeNonContiguousRangesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRRW2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRRW2] Performing VerifyExist on EmployeeNonContiguousRanges_EmployeeNonContiguousRangesTable...", Logger.MessageType.INF);
				SeleniumControl PRRW2_EmployeeNonContiguousRanges_EmployeeNonContiguousRangesTable = new SeleniumControl( sDriver, "EmployeeNonContiguousRanges_EmployeeNonContiguousRangesTable", "xpath", "//div[translate(@id,'0123456789','')='pr__CPP_NCREMPLID_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PRRW2_EmployeeNonContiguousRanges_EmployeeNonContiguousRangesTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRRW2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRRW2] Performing Click on EmployeeNonContiguousRanges_Ok...", Logger.MessageType.INF);
				SeleniumControl PRRW2_EmployeeNonContiguousRanges_Ok = new SeleniumControl( sDriver, "EmployeeNonContiguousRanges_Ok", "xpath", "//div[translate(@id,'0123456789','')='pr__CPP_NCREMPLID_']/ancestor::form[1]/following-sibling::div[1]/descendant::*[@id='bOk']");
				Function.WaitControlDisplayed(PRRW2_EmployeeNonContiguousRanges_Ok);
if (PRRW2_EmployeeNonContiguousRanges_Ok.mElement.GetAttribute("class") == "popupBtn" && sDriver.BrowserType == "ie")
PRRW2_EmployeeNonContiguousRanges_Ok.Click(5,5);
else PRRW2_EmployeeNonContiguousRanges_Ok.Click(4.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRRW2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRRW2] Performing Click on SocialSecurityNumberNonContiguousRangesLink...", Logger.MessageType.INF);
				SeleniumControl PRRW2_SocialSecurityNumberNonContiguousRangesLink = new SeleniumControl( sDriver, "SocialSecurityNumberNonContiguousRangesLink", "ID", "lnk_1006135_PRRW2_PARAM");
				Function.WaitControlDisplayed(PRRW2_SocialSecurityNumberNonContiguousRangesLink);
PRRW2_SocialSecurityNumberNonContiguousRangesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRRW2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRRW2] Performing VerifyExists on SocialSecurityNumberNonContiguousRangesForm...", Logger.MessageType.INF);
				SeleniumControl PRRW2_SocialSecurityNumberNonContiguousRangesForm = new SeleniumControl( sDriver, "SocialSecurityNumberNonContiguousRangesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRRW_NCRSSNID_NCR_']/ancestor::form[1]");
				Function.AssertEqual(true,PRRW2_SocialSecurityNumberNonContiguousRangesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRRW2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRRW2] Performing VerifyExist on SocialSecurityNumberNonContiguousRanges_SocialSecurityNumberNonContiguousRangesTable...", Logger.MessageType.INF);
				SeleniumControl PRRW2_SocialSecurityNumberNonContiguousRanges_SocialSecurityNumberNonContiguousRangesTable = new SeleniumControl( sDriver, "SocialSecurityNumberNonContiguousRanges_SocialSecurityNumberNonContiguousRangesTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PRRW_NCRSSNID_NCR_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PRRW2_SocialSecurityNumberNonContiguousRanges_SocialSecurityNumberNonContiguousRangesTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRRW2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRRW2] Performing Click on SocialSecurityNumberNonContiguousRanges_Ok...", Logger.MessageType.INF);
				SeleniumControl PRRW2_SocialSecurityNumberNonContiguousRanges_Ok = new SeleniumControl( sDriver, "SocialSecurityNumberNonContiguousRanges_Ok", "xpath", "//div[translate(@id,'0123456789','')='pr__PRRW_NCRSSNID_NCR_']/ancestor::form[1]/following-sibling::div[1]/descendant::*[@id='bOk']");
				Function.WaitControlDisplayed(PRRW2_SocialSecurityNumberNonContiguousRanges_Ok);
if (PRRW2_SocialSecurityNumberNonContiguousRanges_Ok.mElement.GetAttribute("class") == "popupBtn" && sDriver.BrowserType == "ie")
PRRW2_SocialSecurityNumberNonContiguousRanges_Ok.Click(5,5);
else PRRW2_SocialSecurityNumberNonContiguousRanges_Ok.Click(4.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRRW2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRRW2] Performing Click on PostalCodeNonContiguousRangesLink...", Logger.MessageType.INF);
				SeleniumControl PRRW2_PostalCodeNonContiguousRangesLink = new SeleniumControl( sDriver, "PostalCodeNonContiguousRangesLink", "ID", "lnk_1006136_PRRW2_PARAM");
				Function.WaitControlDisplayed(PRRW2_PostalCodeNonContiguousRangesLink);
PRRW2_PostalCodeNonContiguousRangesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRRW2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRRW2] Performing VerifyExists on PostalCodeNonContiguousRangesForm...", Logger.MessageType.INF);
				SeleniumControl PRRW2_PostalCodeNonContiguousRangesForm = new SeleniumControl( sDriver, "PostalCodeNonContiguousRangesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRRW_NCRPOSTALCD_NCR_']/ancestor::form[1]");
				Function.AssertEqual(true,PRRW2_PostalCodeNonContiguousRangesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRRW2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRRW2] Performing VerifyExist on PostalCodeNonContiguousRanges_PostalCodeNonContiguousRangesTable...", Logger.MessageType.INF);
				SeleniumControl PRRW2_PostalCodeNonContiguousRanges_PostalCodeNonContiguousRangesTable = new SeleniumControl( sDriver, "PostalCodeNonContiguousRanges_PostalCodeNonContiguousRangesTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PRRW_NCRPOSTALCD_NCR_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PRRW2_PostalCodeNonContiguousRanges_PostalCodeNonContiguousRangesTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRRW2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRRW2] Performing Click on PostalCodeNonContiguousRanges_Ok...", Logger.MessageType.INF);
				SeleniumControl PRRW2_PostalCodeNonContiguousRanges_Ok = new SeleniumControl( sDriver, "PostalCodeNonContiguousRanges_Ok", "xpath", "//div[translate(@id,'0123456789','')='pr__PRRW_NCRPOSTALCD_NCR_']/ancestor::form[1]/following-sibling::div[1]/descendant::*[@id='bOk']");
				Function.WaitControlDisplayed(PRRW2_PostalCodeNonContiguousRanges_Ok);
if (PRRW2_PostalCodeNonContiguousRanges_Ok.mElement.GetAttribute("class") == "popupBtn" && sDriver.BrowserType == "ie")
PRRW2_PostalCodeNonContiguousRanges_Ok.Click(5,5);
else PRRW2_PostalCodeNonContiguousRanges_Ok.Click(4.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRRW2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRRW2] Performing Click on StateNonContiguousRangesLink...", Logger.MessageType.INF);
				SeleniumControl PRRW2_StateNonContiguousRangesLink = new SeleniumControl( sDriver, "StateNonContiguousRangesLink", "ID", "lnk_1006137_PRRW2_PARAM");
				Function.WaitControlDisplayed(PRRW2_StateNonContiguousRangesLink);
PRRW2_StateNonContiguousRangesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRRW2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRRW2] Performing VerifyExists on StateNonContiguousRangesForm...", Logger.MessageType.INF);
				SeleniumControl PRRW2_StateNonContiguousRangesForm = new SeleniumControl( sDriver, "StateNonContiguousRangesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRRW_NCRSTATECD_']/ancestor::form[1]");
				Function.AssertEqual(true,PRRW2_StateNonContiguousRangesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRRW2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRRW2] Performing VerifyExist on StateNonContiguousRanges_StateNonContiguousRangesTable...", Logger.MessageType.INF);
				SeleniumControl PRRW2_StateNonContiguousRanges_StateNonContiguousRangesTable = new SeleniumControl( sDriver, "StateNonContiguousRanges_StateNonContiguousRangesTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PRRW_NCRSTATECD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PRRW2_StateNonContiguousRanges_StateNonContiguousRangesTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRRW2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRRW2] Performing Click on StateNonContiguousRanges_Ok...", Logger.MessageType.INF);
				SeleniumControl PRRW2_StateNonContiguousRanges_Ok = new SeleniumControl( sDriver, "StateNonContiguousRanges_Ok", "xpath", "//div[translate(@id,'0123456789','')='pr__PRRW_NCRSTATECD_']/ancestor::form[1]/following-sibling::div[1]/descendant::*[@id='bOk']");
				Function.WaitControlDisplayed(PRRW2_StateNonContiguousRanges_Ok);
if (PRRW2_StateNonContiguousRanges_Ok.mElement.GetAttribute("class") == "popupBtn" && sDriver.BrowserType == "ie")
PRRW2_StateNonContiguousRanges_Ok.Click(5,5);
else PRRW2_StateNonContiguousRanges_Ok.Click(4.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRRW2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRRW2] Performing Click on OrganizationNonContiguousRangesLink...", Logger.MessageType.INF);
				SeleniumControl PRRW2_OrganizationNonContiguousRangesLink = new SeleniumControl( sDriver, "OrganizationNonContiguousRangesLink", "ID", "lnk_1006140_PRRW2_PARAM");
				Function.WaitControlDisplayed(PRRW2_OrganizationNonContiguousRangesLink);
PRRW2_OrganizationNonContiguousRangesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRRW2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRRW2] Performing VerifyExists on OrganizationNonContiguousRangesForm...", Logger.MessageType.INF);
				SeleniumControl PRRW2_OrganizationNonContiguousRangesForm = new SeleniumControl( sDriver, "OrganizationNonContiguousRangesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPP_NCRORGID_NCR_']/ancestor::form[1]");
				Function.AssertEqual(true,PRRW2_OrganizationNonContiguousRangesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRRW2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRRW2] Performing VerifyExist on OrganizationNonContiguousRanges_OrganizationNonContiguousRangesTable...", Logger.MessageType.INF);
				SeleniumControl PRRW2_OrganizationNonContiguousRanges_OrganizationNonContiguousRangesTable = new SeleniumControl( sDriver, "OrganizationNonContiguousRanges_OrganizationNonContiguousRangesTable", "xpath", "//div[translate(@id,'0123456789','')='pr__CPP_NCRORGID_NCR_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PRRW2_OrganizationNonContiguousRanges_OrganizationNonContiguousRangesTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRRW2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRRW2] Performing Click on OrganizationNonContiguousRanges_Ok...", Logger.MessageType.INF);
				SeleniumControl PRRW2_OrganizationNonContiguousRanges_Ok = new SeleniumControl( sDriver, "OrganizationNonContiguousRanges_Ok", "xpath", "//div[translate(@id,'0123456789','')='pr__CPP_NCRORGID_NCR_']/ancestor::form[1]/following-sibling::div[1]/descendant::*[@id='bOk']");
				Function.WaitControlDisplayed(PRRW2_OrganizationNonContiguousRanges_Ok);
if (PRRW2_OrganizationNonContiguousRanges_Ok.mElement.GetAttribute("class") == "popupBtn" && sDriver.BrowserType == "ie")
PRRW2_OrganizationNonContiguousRanges_Ok.Click(5,5);
else PRRW2_OrganizationNonContiguousRanges_Ok.Click(4.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRRW2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRRW2] Performing Click on LocatorCodeNonContiguousRangesLink...", Logger.MessageType.INF);
				SeleniumControl PRRW2_LocatorCodeNonContiguousRangesLink = new SeleniumControl( sDriver, "LocatorCodeNonContiguousRangesLink", "ID", "lnk_1006141_PRRW2_PARAM");
				Function.WaitControlDisplayed(PRRW2_LocatorCodeNonContiguousRangesLink);
PRRW2_LocatorCodeNonContiguousRangesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRRW2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRRW2] Performing VerifyExists on LocatorCodeNonContiguousRangesForm...", Logger.MessageType.INF);
				SeleniumControl PRRW2_LocatorCodeNonContiguousRangesForm = new SeleniumControl( sDriver, "LocatorCodeNonContiguousRangesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRRW_NCRLOCATORCD_NCR_']/ancestor::form[1]");
				Function.AssertEqual(true,PRRW2_LocatorCodeNonContiguousRangesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRRW2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRRW2] Performing VerifyExist on LocatorCodeNonContiguousRanges_LocatorCodeNonContiguousRangesTable...", Logger.MessageType.INF);
				SeleniumControl PRRW2_LocatorCodeNonContiguousRanges_LocatorCodeNonContiguousRangesTable = new SeleniumControl( sDriver, "LocatorCodeNonContiguousRanges_LocatorCodeNonContiguousRangesTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PRRW_NCRLOCATORCD_NCR_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PRRW2_LocatorCodeNonContiguousRanges_LocatorCodeNonContiguousRangesTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRRW2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRRW2] Performing Click on LocatorCodeNonContiguousRanges_Ok...", Logger.MessageType.INF);
				SeleniumControl PRRW2_LocatorCodeNonContiguousRanges_Ok = new SeleniumControl( sDriver, "LocatorCodeNonContiguousRanges_Ok", "xpath", "//div[translate(@id,'0123456789','')='pr__PRRW_NCRLOCATORCD_NCR_']/ancestor::form[1]/following-sibling::div[1]/descendant::*[@id='bOk']");
				Function.WaitControlDisplayed(PRRW2_LocatorCodeNonContiguousRanges_Ok);
if (PRRW2_LocatorCodeNonContiguousRanges_Ok.mElement.GetAttribute("class") == "popupBtn" && sDriver.BrowserType == "ie")
PRRW2_LocatorCodeNonContiguousRanges_Ok.Click(5,5);
else PRRW2_LocatorCodeNonContiguousRanges_Ok.Click(4.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRRW2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRRW2] Performing Click on EmployeeNameNonContiguousRangesLink...", Logger.MessageType.INF);
				SeleniumControl PRRW2_EmployeeNameNonContiguousRangesLink = new SeleniumControl( sDriver, "EmployeeNameNonContiguousRangesLink", "ID", "lnk_5484_PRRW2_PARAM");
				Function.WaitControlDisplayed(PRRW2_EmployeeNameNonContiguousRangesLink);
PRRW2_EmployeeNameNonContiguousRangesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRRW2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRRW2] Performing VerifyExists on EmployeeNameNonContiguousRangesForm...", Logger.MessageType.INF);
				SeleniumControl PRRW2_EmployeeNameNonContiguousRangesForm = new SeleniumControl( sDriver, "EmployeeNameNonContiguousRangesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRRW_NCRLASTFIRSTNAME_NCR_']/ancestor::form[1]");
				Function.AssertEqual(true,PRRW2_EmployeeNameNonContiguousRangesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRRW2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRRW2] Performing VerifyExist on EmployeeNameNonContiguousRanges_EmployeeNameNonContiguousRangesTable...", Logger.MessageType.INF);
				SeleniumControl PRRW2_EmployeeNameNonContiguousRanges_EmployeeNameNonContiguousRangesTable = new SeleniumControl( sDriver, "EmployeeNameNonContiguousRanges_EmployeeNameNonContiguousRangesTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PRRW_NCRLASTFIRSTNAME_NCR_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PRRW2_EmployeeNameNonContiguousRanges_EmployeeNameNonContiguousRangesTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRRW2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRRW2] Performing Click on EmployeeNameNonContiguousRanges_Ok...", Logger.MessageType.INF);
				SeleniumControl PRRW2_EmployeeNameNonContiguousRanges_Ok = new SeleniumControl( sDriver, "EmployeeNameNonContiguousRanges_Ok", "xpath", "//div[translate(@id,'0123456789','')='pr__PRRW_NCRLASTFIRSTNAME_NCR_']/ancestor::form[1]/following-sibling::div[1]/descendant::*[@id='bOk']");
				Function.WaitControlDisplayed(PRRW2_EmployeeNameNonContiguousRanges_Ok);
if (PRRW2_EmployeeNameNonContiguousRanges_Ok.mElement.GetAttribute("class") == "popupBtn" && sDriver.BrowserType == "ie")
PRRW2_EmployeeNameNonContiguousRanges_Ok.Click(5,5);
else PRRW2_EmployeeNameNonContiguousRanges_Ok.Click(4.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRRW2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRRW2] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl PRRW2_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PRRW2_MainForm);
IWebElement formBttn = PRRW2_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

