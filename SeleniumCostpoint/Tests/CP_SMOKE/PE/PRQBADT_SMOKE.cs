 
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
    public class PRQBADT_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Payroll", "xpath","//div[@class='deptItem'][.='Payroll']").Click();
new SeleniumControl(sDriver,"Payroll Reports/Inquiries", "xpath","//div[@class='navItem'][.='Payroll Reports/Inquiries']").Click();
new SeleniumControl(sDriver,"View Bond Information", "xpath","//div[@class='navItem'][.='View Bond Information']").Click();


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
								try {
				Function.CurrentComponent = "PRQBADT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQBADT] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl PRQBADT_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,PRQBADT_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQBADT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQBADT] Performing VerifyExists on Identification_Employee...", Logger.MessageType.INF);
				SeleniumControl PRQBADT_Identification_Employee = new SeleniumControl( sDriver, "Identification_Employee", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='EMPLOYEE']");
				Function.AssertEqual(true,PRQBADT_Identification_Employee.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Inquiry Details Form");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQBADT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQBADT] Performing VerifyExist on InquiryDetailsFormTable...", Logger.MessageType.INF);
				SeleniumControl PRQBADT_InquiryDetailsFormTable = new SeleniumControl( sDriver, "InquiryDetailsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQBADT_EMPLBONDINFO_CHILD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PRQBADT_InquiryDetailsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQBADT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQBADT] Performing ClickButton on InquiryDetailsForm...", Logger.MessageType.INF);
				SeleniumControl PRQBADT_InquiryDetailsForm = new SeleniumControl( sDriver, "InquiryDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQBADT_EMPLBONDINFO_CHILD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PRQBADT_InquiryDetailsForm);
IWebElement formBttn = PRQBADT_InquiryDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PRQBADT_InquiryDetailsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PRQBADT_InquiryDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQBADT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQBADT] Performing VerifyExists on InquiryDetailsForm...", Logger.MessageType.INF);
				SeleniumControl PRQBADT_InquiryDetailsForm = new SeleniumControl( sDriver, "InquiryDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQBADT_EMPLBONDINFO_CHILD_']/ancestor::form[1]");
				Function.AssertEqual(true,PRQBADT_InquiryDetailsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQBADT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQBADT] Performing VerifyExists on InquiryDetails_TransactionType...", Logger.MessageType.INF);
				SeleniumControl PRQBADT_InquiryDetails_TransactionType = new SeleniumControl( sDriver, "InquiryDetails_TransactionType", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQBADT_EMPLBONDINFO_CHILD_']/ancestor::form[1]/descendant::*[@id='TRANS_TYPE']");
				Function.AssertEqual(true,PRQBADT_InquiryDetails_TransactionType.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQBADT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQBADT] Performing VerifyExists on InquiryDetails_InquiryDetailsTab...", Logger.MessageType.INF);
				SeleniumControl PRQBADT_InquiryDetails_InquiryDetailsTab = new SeleniumControl( sDriver, "InquiryDetails_InquiryDetailsTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQBADT_EMPLBONDINFO_CHILD_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.AssertEqual(true,PRQBADT_InquiryDetails_InquiryDetailsTab.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQBADT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQBADT] Performing Select on InquiryDetails_InquiryDetailsTab...", Logger.MessageType.INF);
				SeleniumControl PRQBADT_InquiryDetails_InquiryDetailsTab = new SeleniumControl( sDriver, "InquiryDetails_InquiryDetailsTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQBADT_EMPLBONDINFO_CHILD_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PRQBADT_InquiryDetails_InquiryDetailsTab);
IWebElement mTab = PRQBADT_InquiryDetails_InquiryDetailsTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Bond Details").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQBADT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQBADT] Performing VerifyExists on InquiryDetails_BondDetails_BondDetails_NextPurchase...", Logger.MessageType.INF);
				SeleniumControl PRQBADT_InquiryDetails_BondDetails_BondDetails_NextPurchase = new SeleniumControl( sDriver, "InquiryDetails_BondDetails_BondDetails_NextPurchase", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQBADT_EMPLBONDINFO_CHILD_']/ancestor::form[1]/descendant::*[@id='NXT_PURCHASE']");
				Function.AssertEqual(true,PRQBADT_InquiryDetails_BondDetails_BondDetails_NextPurchase.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQBADT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQBADT] Performing Select on InquiryDetails_InquiryDetailsTab...", Logger.MessageType.INF);
				SeleniumControl PRQBADT_InquiryDetails_InquiryDetailsTab = new SeleniumControl( sDriver, "InquiryDetails_InquiryDetailsTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQBADT_EMPLBONDINFO_CHILD_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PRQBADT_InquiryDetails_InquiryDetailsTab);
IWebElement mTab = PRQBADT_InquiryDetails_InquiryDetailsTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Mailing Address").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQBADT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQBADT] Performing VerifyExists on InquiryDetails_MailingAddress_UseEmployeeAddress...", Logger.MessageType.INF);
				SeleniumControl PRQBADT_InquiryDetails_MailingAddress_UseEmployeeAddress = new SeleniumControl( sDriver, "InquiryDetails_MailingAddress_UseEmployeeAddress", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQBADT_EMPLBONDINFO_CHILD_']/ancestor::form[1]/descendant::*[@id='USE_EMPL_ADD']");
				Function.AssertEqual(true,PRQBADT_InquiryDetails_MailingAddress_UseEmployeeAddress.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQBADT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQBADT] Performing Select on InquiryDetails_InquiryDetailsTab...", Logger.MessageType.INF);
				SeleniumControl PRQBADT_InquiryDetails_InquiryDetailsTab = new SeleniumControl( sDriver, "InquiryDetails_InquiryDetailsTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQBADT_EMPLBONDINFO_CHILD_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PRQBADT_InquiryDetails_InquiryDetailsTab);
IWebElement mTab = PRQBADT_InquiryDetails_InquiryDetailsTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Owner/Beneficiary").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQBADT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQBADT] Performing VerifyExists on InquiryDetails_OwnerBeneficiary_Owner_EmployeeIsOwner...", Logger.MessageType.INF);
				SeleniumControl PRQBADT_InquiryDetails_OwnerBeneficiary_Owner_EmployeeIsOwner = new SeleniumControl( sDriver, "InquiryDetails_OwnerBeneficiary_Owner_EmployeeIsOwner", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQBADT_EMPLBONDINFO_CHILD_']/ancestor::form[1]/descendant::*[@id='EMPL_OWNER']");
				Function.AssertEqual(true,PRQBADT_InquiryDetails_OwnerBeneficiary_Owner_EmployeeIsOwner.Exists());

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
				Function.CurrentComponent = "PRQBADT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQBADT] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl PRQBADT_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PRQBADT_MainForm);
IWebElement formBttn = PRQBADT_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

