 
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
    public class HPMEMPEF_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Employee", "xpath","//div[@class='deptItem'][.='Employee']").Click();
new SeleniumControl(sDriver,"Employee Offboarding", "xpath","//div[@class='navItem'][.='Employee Offboarding']").Click();
new SeleniumControl(sDriver,"Manage Employee Exit Interviews", "xpath","//div[@class='navItem'][.='Manage Employee Exit Interviews']").Click();


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
				Function.CurrentComponent = "HPMEMPEF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMEMPEF] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl HPMEMPEF_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,HPMEMPEF_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMEMPEF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMEMPEF] Performing VerifyExists on Employee...", Logger.MessageType.INF);
				SeleniumControl HPMEMPEF_Employee = new SeleniumControl( sDriver, "Employee", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='EMPL_ID']");
				Function.AssertEqual(true,HPMEMPEF_Employee.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMEMPEF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMEMPEF] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl HPMEMPEF_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(HPMEMPEF_MainForm);
IWebElement formBttn = HPMEMPEF_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? HPMEMPEF_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
HPMEMPEF_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMEMPEF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMEMPEF] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl HPMEMPEF_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,HPMEMPEF_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("EMPLOYEE INFORMATION LINK");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMEMPEF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMEMPEF] Performing Click on EmployeeInformationLink...", Logger.MessageType.INF);
				SeleniumControl HPMEMPEF_EmployeeInformationLink = new SeleniumControl( sDriver, "EmployeeInformationLink", "ID", "lnk_1003341_HPMEMPEF_HEMPLEXITINTV_HDR");
				Function.WaitControlDisplayed(HPMEMPEF_EmployeeInformationLink);
HPMEMPEF_EmployeeInformationLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMEMPEF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMEMPEF] Performing VerifyExists on EmployeeInformationForm...", Logger.MessageType.INF);
				SeleniumControl HPMEMPEF_EmployeeInformationForm = new SeleniumControl( sDriver, "EmployeeInformationForm", "xpath", "//div[starts-with(@id,'pr__HPMEMPEF_HSECT1EMPLEXIT_')]/ancestor::form[1]");
				Function.AssertEqual(true,HPMEMPEF_EmployeeInformationForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMEMPEF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMEMPEF] Performing VerifyExists on EmployeeInformation_ForwardingAddress_Line1...", Logger.MessageType.INF);
				SeleniumControl HPMEMPEF_EmployeeInformation_ForwardingAddress_Line1 = new SeleniumControl( sDriver, "EmployeeInformation_ForwardingAddress_Line1", "xpath", "//div[starts-with(@id,'pr__HPMEMPEF_HSECT1EMPLEXIT_')]/ancestor::form[1]/descendant::*[@id='LN_1_ADR']");
				Function.AssertEqual(true,HPMEMPEF_EmployeeInformation_ForwardingAddress_Line1.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMEMPEF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMEMPEF] Performing Close on EmployeeInformationForm...", Logger.MessageType.INF);
				SeleniumControl HPMEMPEF_EmployeeInformationForm = new SeleniumControl( sDriver, "EmployeeInformationForm", "xpath", "//div[starts-with(@id,'pr__HPMEMPEF_HSECT1EMPLEXIT_')]/ancestor::form[1]");
				Function.WaitControlDisplayed(HPMEMPEF_EmployeeInformationForm);
IWebElement formBttn = HPMEMPEF_EmployeeInformationForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("SECURITY & PROPERTY LINK");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMEMPEF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMEMPEF] Performing Click on SecurityPropertyLink...", Logger.MessageType.INF);
				SeleniumControl HPMEMPEF_SecurityPropertyLink = new SeleniumControl( sDriver, "SecurityPropertyLink", "ID", "lnk_1003342_HPMEMPEF_HEMPLEXITINTV_HDR");
				Function.WaitControlDisplayed(HPMEMPEF_SecurityPropertyLink);
HPMEMPEF_SecurityPropertyLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMEMPEF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMEMPEF] Performing VerifyExist on SecurityPropertyFormTable...", Logger.MessageType.INF);
				SeleniumControl HPMEMPEF_SecurityPropertyFormTable = new SeleniumControl( sDriver, "SecurityPropertyFormTable", "xpath", "//div[starts-with(@id,'pr__HPMEMPEF_HEMPLS2LNSEC_')]/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,HPMEMPEF_SecurityPropertyFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMEMPEF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMEMPEF] Performing ClickButton on SecurityPropertyForm...", Logger.MessageType.INF);
				SeleniumControl HPMEMPEF_SecurityPropertyForm = new SeleniumControl( sDriver, "SecurityPropertyForm", "xpath", "//div[starts-with(@id,'pr__HPMEMPEF_HEMPLS2LNSEC_')]/ancestor::form[1]");
				Function.WaitControlDisplayed(HPMEMPEF_SecurityPropertyForm);
IWebElement formBttn = HPMEMPEF_SecurityPropertyForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? HPMEMPEF_SecurityPropertyForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
HPMEMPEF_SecurityPropertyForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMEMPEF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMEMPEF] Performing VerifyExists on SecurityPropertyForm...", Logger.MessageType.INF);
				SeleniumControl HPMEMPEF_SecurityPropertyForm = new SeleniumControl( sDriver, "SecurityPropertyForm", "xpath", "//div[starts-with(@id,'pr__HPMEMPEF_HEMPLS2LNSEC_')]/ancestor::form[1]");
				Function.AssertEqual(true,HPMEMPEF_SecurityPropertyForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMEMPEF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMEMPEF] Performing VerifyExists on SecurityProperty_OrderNumber...", Logger.MessageType.INF);
				SeleniumControl HPMEMPEF_SecurityProperty_OrderNumber = new SeleniumControl( sDriver, "SecurityProperty_OrderNumber", "xpath", "//div[starts-with(@id,'pr__HPMEMPEF_HEMPLS2LNSEC_')]/ancestor::form[1]/descendant::*[@id='ORDER_NO']");
				Function.AssertEqual(true,HPMEMPEF_SecurityProperty_OrderNumber.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMEMPEF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMEMPEF] Performing Close on SecurityPropertyForm...", Logger.MessageType.INF);
				SeleniumControl HPMEMPEF_SecurityPropertyForm = new SeleniumControl( sDriver, "SecurityPropertyForm", "xpath", "//div[starts-with(@id,'pr__HPMEMPEF_HEMPLS2LNSEC_')]/ancestor::form[1]");
				Function.WaitControlDisplayed(HPMEMPEF_SecurityPropertyForm);
IWebElement formBttn = HPMEMPEF_SecurityPropertyForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("COMPENSATION & BENEFIT LINK");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMEMPEF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMEMPEF] Performing Click on CompensationBenefitsLink...", Logger.MessageType.INF);
				SeleniumControl HPMEMPEF_CompensationBenefitsLink = new SeleniumControl( sDriver, "CompensationBenefitsLink", "ID", "lnk_1003343_HPMEMPEF_HEMPLEXITINTV_HDR");
				Function.WaitControlDisplayed(HPMEMPEF_CompensationBenefitsLink);
HPMEMPEF_CompensationBenefitsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMEMPEF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMEMPEF] Performing VerifyExist on CompensationBenefitsLinkFormTable...", Logger.MessageType.INF);
				SeleniumControl HPMEMPEF_CompensationBenefitsLinkFormTable = new SeleniumControl( sDriver, "CompensationBenefitsLinkFormTable", "xpath", "//div[starts-with(@id,'pr__HPMEMPEF_HEMPLS3LNCOMP_')]/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,HPMEMPEF_CompensationBenefitsLinkFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMEMPEF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMEMPEF] Performing ClickButton on CompensationBenefitsLinkForm...", Logger.MessageType.INF);
				SeleniumControl HPMEMPEF_CompensationBenefitsLinkForm = new SeleniumControl( sDriver, "CompensationBenefitsLinkForm", "xpath", "//div[starts-with(@id,'pr__HPMEMPEF_HEMPLS3LNCOMP_')]/ancestor::form[1]");
				Function.WaitControlDisplayed(HPMEMPEF_CompensationBenefitsLinkForm);
IWebElement formBttn = HPMEMPEF_CompensationBenefitsLinkForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? HPMEMPEF_CompensationBenefitsLinkForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
HPMEMPEF_CompensationBenefitsLinkForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMEMPEF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMEMPEF] Performing VerifyExists on CompensationBenefits_OrderNumber...", Logger.MessageType.INF);
				SeleniumControl HPMEMPEF_CompensationBenefits_OrderNumber = new SeleniumControl( sDriver, "CompensationBenefits_OrderNumber", "xpath", "//div[starts-with(@id,'pr__HPMEMPEF_HEMPLS3LNCOMP_')]/ancestor::form[1]/descendant::*[@id='ORDER_NO']");
				Function.AssertEqual(true,HPMEMPEF_CompensationBenefits_OrderNumber.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMEMPEF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMEMPEF] Performing Close on CompensationBenefitsLinkForm...", Logger.MessageType.INF);
				SeleniumControl HPMEMPEF_CompensationBenefitsLinkForm = new SeleniumControl( sDriver, "CompensationBenefitsLinkForm", "xpath", "//div[starts-with(@id,'pr__HPMEMPEF_HEMPLS3LNCOMP_')]/ancestor::form[1]");
				Function.WaitControlDisplayed(HPMEMPEF_CompensationBenefitsLinkForm);
IWebElement formBttn = HPMEMPEF_CompensationBenefitsLinkForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("LEAVE LINK");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMEMPEF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMEMPEF] Performing Click on LeaveLink...", Logger.MessageType.INF);
				SeleniumControl HPMEMPEF_LeaveLink = new SeleniumControl( sDriver, "LeaveLink", "ID", "lnk_1003344_HPMEMPEF_HEMPLEXITINTV_HDR");
				Function.WaitControlDisplayed(HPMEMPEF_LeaveLink);
HPMEMPEF_LeaveLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMEMPEF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMEMPEF] Performing VerifyExists on LeaveForm...", Logger.MessageType.INF);
				SeleniumControl HPMEMPEF_LeaveForm = new SeleniumControl( sDriver, "LeaveForm", "xpath", "//div[starts-with(@id,'pr__HPMEMPEF_HEMPLS4LNLV_')]/ancestor::form[1]");
				Function.AssertEqual(true,HPMEMPEF_LeaveForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMEMPEF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMEMPEF] Performing VerifyExist on LeaveFormTable...", Logger.MessageType.INF);
				SeleniumControl HPMEMPEF_LeaveFormTable = new SeleniumControl( sDriver, "LeaveFormTable", "xpath", "//div[starts-with(@id,'pr__HPMEMPEF_HEMPLS4LNLV_')]/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,HPMEMPEF_LeaveFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMEMPEF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMEMPEF] Performing ClickButton on LeaveForm...", Logger.MessageType.INF);
				SeleniumControl HPMEMPEF_LeaveForm = new SeleniumControl( sDriver, "LeaveForm", "xpath", "//div[starts-with(@id,'pr__HPMEMPEF_HEMPLS4LNLV_')]/ancestor::form[1]");
				Function.WaitControlDisplayed(HPMEMPEF_LeaveForm);
IWebElement formBttn = HPMEMPEF_LeaveForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? HPMEMPEF_LeaveForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
HPMEMPEF_LeaveForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMEMPEF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMEMPEF] Performing VerifyExists on Leave_OrderNumber...", Logger.MessageType.INF);
				SeleniumControl HPMEMPEF_Leave_OrderNumber = new SeleniumControl( sDriver, "Leave_OrderNumber", "xpath", "//div[starts-with(@id,'pr__HPMEMPEF_HEMPLS4LNLV_')]/ancestor::form[1]/descendant::*[@id='ORDER_NO']");
				Function.AssertEqual(true,HPMEMPEF_Leave_OrderNumber.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMEMPEF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMEMPEF] Performing Close on LeaveForm...", Logger.MessageType.INF);
				SeleniumControl HPMEMPEF_LeaveForm = new SeleniumControl( sDriver, "LeaveForm", "xpath", "//div[starts-with(@id,'pr__HPMEMPEF_HEMPLS4LNLV_')]/ancestor::form[1]");
				Function.WaitControlDisplayed(HPMEMPEF_LeaveForm);
IWebElement formBttn = HPMEMPEF_LeaveForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("AMOUNTS OWED LINK");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMEMPEF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMEMPEF] Performing Click on AmountsOwedLink...", Logger.MessageType.INF);
				SeleniumControl HPMEMPEF_AmountsOwedLink = new SeleniumControl( sDriver, "AmountsOwedLink", "ID", "lnk_1003345_HPMEMPEF_HEMPLEXITINTV_HDR");
				Function.WaitControlDisplayed(HPMEMPEF_AmountsOwedLink);
HPMEMPEF_AmountsOwedLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMEMPEF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMEMPEF] Performing VerifyExist on AmountsOwedLinkFormTable...", Logger.MessageType.INF);
				SeleniumControl HPMEMPEF_AmountsOwedLinkFormTable = new SeleniumControl( sDriver, "AmountsOwedLinkFormTable", "xpath", "//div[starts-with(@id,'pr__HPMEMPEF_HEMPLS5LNAMT_')]/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,HPMEMPEF_AmountsOwedLinkFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMEMPEF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMEMPEF] Performing ClickButton on AmountsOwedLinkForm...", Logger.MessageType.INF);
				SeleniumControl HPMEMPEF_AmountsOwedLinkForm = new SeleniumControl( sDriver, "AmountsOwedLinkForm", "xpath", "//div[starts-with(@id,'pr__HPMEMPEF_HEMPLS5LNAMT_')]/ancestor::form[1]");
				Function.WaitControlDisplayed(HPMEMPEF_AmountsOwedLinkForm);
IWebElement formBttn = HPMEMPEF_AmountsOwedLinkForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? HPMEMPEF_AmountsOwedLinkForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
HPMEMPEF_AmountsOwedLinkForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMEMPEF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMEMPEF] Performing VerifyExists on AmountsOwedLinkForm...", Logger.MessageType.INF);
				SeleniumControl HPMEMPEF_AmountsOwedLinkForm = new SeleniumControl( sDriver, "AmountsOwedLinkForm", "xpath", "//div[starts-with(@id,'pr__HPMEMPEF_HEMPLS5LNAMT_')]/ancestor::form[1]");
				Function.AssertEqual(true,HPMEMPEF_AmountsOwedLinkForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMEMPEF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMEMPEF] Performing VerifyExists on AmountsOwed_OrderNumber...", Logger.MessageType.INF);
				SeleniumControl HPMEMPEF_AmountsOwed_OrderNumber = new SeleniumControl( sDriver, "AmountsOwed_OrderNumber", "xpath", "//div[starts-with(@id,'pr__HPMEMPEF_HEMPLS5LNAMT_')]/ancestor::form[1]/descendant::*[@id='ORDER_NO']");
				Function.AssertEqual(true,HPMEMPEF_AmountsOwed_OrderNumber.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMEMPEF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMEMPEF] Performing Close on AmountsOwedLinkForm...", Logger.MessageType.INF);
				SeleniumControl HPMEMPEF_AmountsOwedLinkForm = new SeleniumControl( sDriver, "AmountsOwedLinkForm", "xpath", "//div[starts-with(@id,'pr__HPMEMPEF_HEMPLS5LNAMT_')]/ancestor::form[1]");
				Function.WaitControlDisplayed(HPMEMPEF_AmountsOwedLinkForm);
IWebElement formBttn = HPMEMPEF_AmountsOwedLinkForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("COMMENTS LINK");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMEMPEF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMEMPEF] Performing Click on CommentsLink...", Logger.MessageType.INF);
				SeleniumControl HPMEMPEF_CommentsLink = new SeleniumControl( sDriver, "CommentsLink", "ID", "lnk_1003347_HPMEMPEF_HEMPLEXITINTV_HDR");
				Function.WaitControlDisplayed(HPMEMPEF_CommentsLink);
HPMEMPEF_CommentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMEMPEF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMEMPEF] Performing VerifyExists on CommentsLinkForm...", Logger.MessageType.INF);
				SeleniumControl HPMEMPEF_CommentsLinkForm = new SeleniumControl( sDriver, "CommentsLinkForm", "xpath", "//div[starts-with(@id,'pr__HPMEMPEF_HEMPLS6COMMENTS_')]/ancestor::form[1]");
				Function.AssertEqual(true,HPMEMPEF_CommentsLinkForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMEMPEF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMEMPEF] Performing VerifyExists on Comments_Comments...", Logger.MessageType.INF);
				SeleniumControl HPMEMPEF_Comments_Comments = new SeleniumControl( sDriver, "Comments_Comments", "xpath", "//div[starts-with(@id,'pr__HPMEMPEF_HEMPLS6COMMENTS_')]/ancestor::form[1]/descendant::*[@id='COMMENTS']");
				Function.AssertEqual(true,HPMEMPEF_Comments_Comments.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMEMPEF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMEMPEF] Performing Close on CommentsLinkForm...", Logger.MessageType.INF);
				SeleniumControl HPMEMPEF_CommentsLinkForm = new SeleniumControl( sDriver, "CommentsLinkForm", "xpath", "//div[starts-with(@id,'pr__HPMEMPEF_HEMPLS6COMMENTS_')]/ancestor::form[1]");
				Function.WaitControlDisplayed(HPMEMPEF_CommentsLinkForm);
IWebElement formBttn = HPMEMPEF_CommentsLinkForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
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
				Function.CurrentComponent = "HPMEMPEF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMEMPEF] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl HPMEMPEF_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(HPMEMPEF_MainForm);
IWebElement formBttn = HPMEMPEF_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

