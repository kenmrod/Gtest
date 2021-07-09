 
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
    public class HPMAINFO_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"People", "xpath","//div[@class='busItem'][.='People']").Click();
new SeleniumControl(sDriver,"Personnel", "xpath","//div[@class='deptItem'][.='Personnel']").Click();
new SeleniumControl(sDriver,"Work-Related Injuries/Illnesses", "xpath","//div[@class='navItem'][.='Work-Related Injuries/Illnesses']").Click();
new SeleniumControl(sDriver,"Manage Accident Information", "xpath","//div[@class='navItem'][.='Manage Accident Information']").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SelectMenu]" , ex.Message));
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
				Function.CurrentComponent = "HPMAINFO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMAINFO] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl HPMAINFO_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,HPMAINFO_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMAINFO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMAINFO] Performing VerifyExists on Employee...", Logger.MessageType.INF);
				SeleniumControl HPMAINFO_Employee = new SeleniumControl( sDriver, "Employee", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='EMPL_ID']");
				Function.AssertEqual(true,HPMAINFO_Employee.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMAINFO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMAINFO] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl HPMAINFO_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(HPMAINFO_MainFormTab);
IWebElement mTab = HPMAINFO_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Employer Info").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMAINFO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMAINFO] Performing VerifyExists on EmployerInfo_TaxableEntity...", Logger.MessageType.INF);
				SeleniumControl HPMAINFO_EmployerInfo_TaxableEntity = new SeleniumControl( sDriver, "EmployerInfo_TaxableEntity", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='TAXBLE_ENTITY_ID']");
				Function.AssertEqual(true,HPMAINFO_EmployerInfo_TaxableEntity.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMAINFO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMAINFO] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl HPMAINFO_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(HPMAINFO_MainFormTab);
IWebElement mTab = HPMAINFO_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Accident Details").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMAINFO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMAINFO] Performing VerifyExists on AccidentDetails_Location_StreetAddressOfAccident...", Logger.MessageType.INF);
				SeleniumControl HPMAINFO_AccidentDetails_Location_StreetAddressOfAccident = new SeleniumControl( sDriver, "AccidentDetails_Location_StreetAddressOfAccident", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='ACCDNT_ADR_LN1']");
				Function.AssertEqual(true,HPMAINFO_AccidentDetails_Location_StreetAddressOfAccident.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMAINFO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMAINFO] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl HPMAINFO_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(HPMAINFO_MainFormTab);
IWebElement mTab = HPMAINFO_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Employee Details").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMAINFO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMAINFO] Performing VerifyExists on EmployeeDetails_PersonalDetails_Phone...", Logger.MessageType.INF);
				SeleniumControl HPMAINFO_EmployeeDetails_PersonalDetails_Phone = new SeleniumControl( sDriver, "EmployeeDetails_PersonalDetails_Phone", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PHONE_ID']");
				Function.AssertEqual(true,HPMAINFO_EmployeeDetails_PersonalDetails_Phone.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMAINFO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMAINFO] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl HPMAINFO_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(HPMAINFO_MainFormTab);
IWebElement mTab = HPMAINFO_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Workers Compensation").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMAINFO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMAINFO] Performing VerifyExists on WorkersCompensation_WorkersComp...", Logger.MessageType.INF);
				SeleniumControl HPMAINFO_WorkersCompensation_WorkersComp = new SeleniumControl( sDriver, "WorkersCompensation_WorkersComp", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='EMPL_WORK_COMP_CD']");
				Function.AssertEqual(true,HPMAINFO_WorkersCompensation_WorkersComp.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMAINFO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMAINFO] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl HPMAINFO_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(HPMAINFO_MainFormTab);
IWebElement mTab = HPMAINFO_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Physician/Health Care").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMAINFO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMAINFO] Performing VerifyExists on PhysicianHealthCare_Physician_Name...", Logger.MessageType.INF);
				SeleniumControl HPMAINFO_PhysicianHealthCare_Physician_Name = new SeleniumControl( sDriver, "PhysicianHealthCare_Physician_Name", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PHYS_NAME']");
				Function.AssertEqual(true,HPMAINFO_PhysicianHealthCare_Physician_Name.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMAINFO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMAINFO] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl HPMAINFO_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(HPMAINFO_MainForm);
IWebElement formBttn = HPMAINFO_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? HPMAINFO_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
HPMAINFO_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMAINFO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMAINFO] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl HPMAINFO_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,HPMAINFO_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMAINFO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMAINFO] Performing VerifyExists on OSHA300Link...", Logger.MessageType.INF);
				SeleniumControl HPMAINFO_OSHA300Link = new SeleniumControl( sDriver, "OSHA300Link", "ID", "lnk_1000707_HPMAINFO_ACCIDENTINFO_HDR");
				Function.AssertEqual(true,HPMAINFO_OSHA300Link.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMAINFO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMAINFO] Performing VerifyExists on OSHA200Link...", Logger.MessageType.INF);
				SeleniumControl HPMAINFO_OSHA200Link = new SeleniumControl( sDriver, "OSHA200Link", "ID", "lnk_1000710_HPMAINFO_ACCIDENTINFO_HDR");
				Function.AssertEqual(true,HPMAINFO_OSHA200Link.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMAINFO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMAINFO] Performing Click on OSHA300Link...", Logger.MessageType.INF);
				SeleniumControl HPMAINFO_OSHA300Link = new SeleniumControl( sDriver, "OSHA300Link", "ID", "lnk_1000707_HPMAINFO_ACCIDENTINFO_HDR");
				Function.WaitControlDisplayed(HPMAINFO_OSHA300Link);
HPMAINFO_OSHA300Link.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMAINFO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMAINFO] Performing VerifyExists on OSHA300Form...", Logger.MessageType.INF);
				SeleniumControl HPMAINFO_OSHA300Form = new SeleniumControl( sDriver, "OSHA300Form", "xpath", "//div[starts-with(@id,'pr__HPMAINFO_OSHA300_HDR_')]/ancestor::form[1]");
				Function.AssertEqual(true,HPMAINFO_OSHA300Form.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMAINFO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMAINFO] Performing VerifyExists on OSHA300_Summary_OSHACaseNumber...", Logger.MessageType.INF);
				SeleniumControl HPMAINFO_OSHA300_Summary_OSHACaseNumber = new SeleniumControl( sDriver, "OSHA300_Summary_OSHACaseNumber", "xpath", "//div[starts-with(@id,'pr__HPMAINFO_OSHA300_HDR_')]/ancestor::form[1]/descendant::*[@id='OSHA_CASE_ID']");
				Function.AssertEqual(true,HPMAINFO_OSHA300_Summary_OSHACaseNumber.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMAINFO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMAINFO] Performing ClickButton on OSHA300Form...", Logger.MessageType.INF);
				SeleniumControl HPMAINFO_OSHA300Form = new SeleniumControl( sDriver, "OSHA300Form", "xpath", "//div[starts-with(@id,'pr__HPMAINFO_OSHA300_HDR_')]/ancestor::form[1]");
				Function.WaitControlDisplayed(HPMAINFO_OSHA300Form);
IWebElement formBttn = HPMAINFO_OSHA300Form.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? HPMAINFO_OSHA300Form.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
HPMAINFO_OSHA300Form.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMAINFO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMAINFO] Performing VerifyExist on OSHA300FormTable...", Logger.MessageType.INF);
				SeleniumControl HPMAINFO_OSHA300FormTable = new SeleniumControl( sDriver, "OSHA300FormTable", "xpath", "//div[starts-with(@id,'pr__HPMAINFO_OSHA300_HDR_')]/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,HPMAINFO_OSHA300FormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMAINFO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMAINFO] Performing VerifyExist on OSHA300_InjuryAnatomyInformationFormTable...", Logger.MessageType.INF);
				SeleniumControl HPMAINFO_OSHA300_InjuryAnatomyInformationFormTable = new SeleniumControl( sDriver, "OSHA300_InjuryAnatomyInformationFormTable", "xpath", "//div[starts-with(@id,'pr__HPMAINFO_OSHA300_CHILD_')]/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,HPMAINFO_OSHA300_InjuryAnatomyInformationFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMAINFO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMAINFO] Performing ClickButton on OSHA300_InjuryAnatomyInformationForm...", Logger.MessageType.INF);
				SeleniumControl HPMAINFO_OSHA300_InjuryAnatomyInformationForm = new SeleniumControl( sDriver, "OSHA300_InjuryAnatomyInformationForm", "xpath", "//div[starts-with(@id,'pr__HPMAINFO_OSHA300_CHILD_')]/ancestor::form[1]");
				Function.WaitControlDisplayed(HPMAINFO_OSHA300_InjuryAnatomyInformationForm);
IWebElement formBttn = HPMAINFO_OSHA300_InjuryAnatomyInformationForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? HPMAINFO_OSHA300_InjuryAnatomyInformationForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
HPMAINFO_OSHA300_InjuryAnatomyInformationForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMAINFO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMAINFO] Performing VerifyExists on OSHA300_InjuryAnatomyInformationForm...", Logger.MessageType.INF);
				SeleniumControl HPMAINFO_OSHA300_InjuryAnatomyInformationForm = new SeleniumControl( sDriver, "OSHA300_InjuryAnatomyInformationForm", "xpath", "//div[starts-with(@id,'pr__HPMAINFO_OSHA300_CHILD_')]/ancestor::form[1]");
				Function.AssertEqual(true,HPMAINFO_OSHA300_InjuryAnatomyInformationForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMAINFO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMAINFO] Performing VerifyExists on OSHA300_InjuryAnatomyInformation_InjuryIllness...", Logger.MessageType.INF);
				SeleniumControl HPMAINFO_OSHA300_InjuryAnatomyInformation_InjuryIllness = new SeleniumControl( sDriver, "OSHA300_InjuryAnatomyInformation_InjuryIllness", "xpath", "//div[starts-with(@id,'pr__HPMAINFO_OSHA300_CHILD_')]/ancestor::form[1]/descendant::*[@id='INJURY_CD']");
				Function.AssertEqual(true,HPMAINFO_OSHA300_InjuryAnatomyInformation_InjuryIllness.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMAINFO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMAINFO] Performing Close on OSHA300Form...", Logger.MessageType.INF);
				SeleniumControl HPMAINFO_OSHA300Form = new SeleniumControl( sDriver, "OSHA300Form", "xpath", "//div[starts-with(@id,'pr__HPMAINFO_OSHA300_HDR_')]/ancestor::form[1]");
				Function.WaitControlDisplayed(HPMAINFO_OSHA300Form);
IWebElement formBttn = HPMAINFO_OSHA300Form.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMAINFO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMAINFO] Performing Click on OSHA200Link...", Logger.MessageType.INF);
				SeleniumControl HPMAINFO_OSHA200Link = new SeleniumControl( sDriver, "OSHA200Link", "ID", "lnk_1000710_HPMAINFO_ACCIDENTINFO_HDR");
				Function.WaitControlDisplayed(HPMAINFO_OSHA200Link);
HPMAINFO_OSHA200Link.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMAINFO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMAINFO] Performing VerifyExists on OSHA200Form...", Logger.MessageType.INF);
				SeleniumControl HPMAINFO_OSHA200Form = new SeleniumControl( sDriver, "OSHA200Form", "xpath", "//div[starts-with(@id,'pr__HPMAINFO_OSHA200_HDR_')]/ancestor::form[1]");
				Function.AssertEqual(true,HPMAINFO_OSHA200Form.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMAINFO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMAINFO] Performing VerifyExists on OSHA200_DateOfInjury...", Logger.MessageType.INF);
				SeleniumControl HPMAINFO_OSHA200_DateOfInjury = new SeleniumControl( sDriver, "OSHA200_DateOfInjury", "xpath", "//div[starts-with(@id,'pr__HPMAINFO_OSHA200_HDR_')]/ancestor::form[1]/descendant::*[@id='DATE_OF_INJURY']");
				Function.AssertEqual(true,HPMAINFO_OSHA200_DateOfInjury.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMAINFO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMAINFO] Performing ClickButton on OSHA200Form...", Logger.MessageType.INF);
				SeleniumControl HPMAINFO_OSHA200Form = new SeleniumControl( sDriver, "OSHA200Form", "xpath", "//div[starts-with(@id,'pr__HPMAINFO_OSHA200_HDR_')]/ancestor::form[1]");
				Function.WaitControlDisplayed(HPMAINFO_OSHA200Form);
IWebElement formBttn = HPMAINFO_OSHA200Form.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? HPMAINFO_OSHA200Form.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
HPMAINFO_OSHA200Form.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMAINFO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMAINFO] Performing VerifyExist on OSHA200FormTable...", Logger.MessageType.INF);
				SeleniumControl HPMAINFO_OSHA200FormTable = new SeleniumControl( sDriver, "OSHA200FormTable", "xpath", "//div[starts-with(@id,'pr__HPMAINFO_OSHA200_HDR_')]/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,HPMAINFO_OSHA200FormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMAINFO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMAINFO] Performing VerifyExist on OSHA200_InjuryAnatomyInformationFormTable...", Logger.MessageType.INF);
				SeleniumControl HPMAINFO_OSHA200_InjuryAnatomyInformationFormTable = new SeleniumControl( sDriver, "OSHA200_InjuryAnatomyInformationFormTable", "xpath", "//div[starts-with(@id,'pr__HPMAINFO_OSHA200_CHILD_')]/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,HPMAINFO_OSHA200_InjuryAnatomyInformationFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMAINFO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMAINFO] Performing ClickButton on OSHA200_InjuryAnatomyInformationForm...", Logger.MessageType.INF);
				SeleniumControl HPMAINFO_OSHA200_InjuryAnatomyInformationForm = new SeleniumControl( sDriver, "OSHA200_InjuryAnatomyInformationForm", "xpath", "//div[starts-with(@id,'pr__HPMAINFO_OSHA200_CHILD_')]/ancestor::form[1]");
				Function.WaitControlDisplayed(HPMAINFO_OSHA200_InjuryAnatomyInformationForm);
IWebElement formBttn = HPMAINFO_OSHA200_InjuryAnatomyInformationForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? HPMAINFO_OSHA200_InjuryAnatomyInformationForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
HPMAINFO_OSHA200_InjuryAnatomyInformationForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMAINFO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMAINFO] Performing VerifyExists on OSHA200_InjuryAnatomyInformationForm...", Logger.MessageType.INF);
				SeleniumControl HPMAINFO_OSHA200_InjuryAnatomyInformationForm = new SeleniumControl( sDriver, "OSHA200_InjuryAnatomyInformationForm", "xpath", "//div[starts-with(@id,'pr__HPMAINFO_OSHA200_CHILD_')]/ancestor::form[1]");
				Function.AssertEqual(true,HPMAINFO_OSHA200_InjuryAnatomyInformationForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMAINFO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMAINFO] Performing VerifyExists on OSHA200_InjuryAnatomyInformation_LineNo...", Logger.MessageType.INF);
				SeleniumControl HPMAINFO_OSHA200_InjuryAnatomyInformation_LineNo = new SeleniumControl( sDriver, "OSHA200_InjuryAnatomyInformation_LineNo", "xpath", "//div[starts-with(@id,'pr__HPMAINFO_OSHA200_CHILD_')]/ancestor::form[1]/descendant::*[@id='LN_NO']");
				Function.AssertEqual(true,HPMAINFO_OSHA200_InjuryAnatomyInformation_LineNo.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMAINFO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMAINFO] Performing Close on OSHA200Form...", Logger.MessageType.INF);
				SeleniumControl HPMAINFO_OSHA200Form = new SeleniumControl( sDriver, "OSHA200Form", "xpath", "//div[starts-with(@id,'pr__HPMAINFO_OSHA200_HDR_')]/ancestor::form[1]");
				Function.WaitControlDisplayed(HPMAINFO_OSHA200Form);
IWebElement formBttn = HPMAINFO_OSHA200Form.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Close App");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMAINFO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMAINFO] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl HPMAINFO_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(HPMAINFO_MainForm);
IWebElement formBttn = HPMAINFO_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

