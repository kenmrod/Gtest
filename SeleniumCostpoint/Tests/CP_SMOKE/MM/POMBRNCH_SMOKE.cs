 
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
    public class POMBRNCH_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Purchasing", "xpath","//div[@class='deptItem'][.='Purchasing']").Click();
new SeleniumControl(sDriver,"Purchasing Codes", "xpath","//div[@class='navItem'][.='Purchasing Codes']").Click();
new SeleniumControl(sDriver,"Manage Branch Locations", "xpath","//div[@class='navItem'][.='Manage Branch Locations']").Click();


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
				Function.CurrentComponent = "POMBRNCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMBRNCH] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl POMBRNCH_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,POMBRNCH_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMBRNCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMBRNCH] Performing VerifyExists on Branch...", Logger.MessageType.INF);
				SeleniumControl POMBRNCH_Branch = new SeleniumControl( sDriver, "Branch", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='BRNCH_LOC_ID']");
				Function.AssertEqual(true,POMBRNCH_Branch.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMBRNCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMBRNCH] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl POMBRNCH_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(POMBRNCH_MainForm);
IWebElement formBttn = POMBRNCH_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? POMBRNCH_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
POMBRNCH_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMBRNCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMBRNCH] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl POMBRNCH_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,POMBRNCH_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMBRNCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMBRNCH] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl POMBRNCH_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(POMBRNCH_MainForm);
IWebElement formBttn = POMBRNCH_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? POMBRNCH_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
POMBRNCH_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("BranchAddressForm");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMBRNCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMBRNCH] Performing VerifyExists on BranchAddressForm...", Logger.MessageType.INF);
				SeleniumControl POMBRNCH_BranchAddressForm = new SeleniumControl( sDriver, "BranchAddressForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POMBRNCH_BRNCHADDR_']/ancestor::form[1]");
				Function.AssertEqual(true,POMBRNCH_BranchAddressForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMBRNCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMBRNCH] Performing VerifyExist on BranchAddressFormTable...", Logger.MessageType.INF);
				SeleniumControl POMBRNCH_BranchAddressFormTable = new SeleniumControl( sDriver, "BranchAddressFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__POMBRNCH_BRNCHADDR_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,POMBRNCH_BranchAddressFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMBRNCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMBRNCH] Performing ClickButton on BranchAddressForm...", Logger.MessageType.INF);
				SeleniumControl POMBRNCH_BranchAddressForm = new SeleniumControl( sDriver, "BranchAddressForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POMBRNCH_BRNCHADDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POMBRNCH_BranchAddressForm);
IWebElement formBttn = POMBRNCH_BranchAddressForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? POMBRNCH_BranchAddressForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
POMBRNCH_BranchAddressForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMBRNCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMBRNCH] Performing VerifyExists on BranchAddress_AddressCode...", Logger.MessageType.INF);
				SeleniumControl POMBRNCH_BranchAddress_AddressCode = new SeleniumControl( sDriver, "BranchAddress_AddressCode", "xpath", "//div[translate(@id,'0123456789','')='pr__POMBRNCH_BRNCHADDR_']/ancestor::form[1]/descendant::*[@id='ADDR_DC']");
				Function.AssertEqual(true,POMBRNCH_BranchAddress_AddressCode.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMBRNCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMBRNCH] Performing Click on BranchAddress_ContactsLink...", Logger.MessageType.INF);
				SeleniumControl POMBRNCH_BranchAddress_ContactsLink = new SeleniumControl( sDriver, "BranchAddress_ContactsLink", "ID", "lnk_1007446_POMBRNCH_BRNCHADDR");
				Function.WaitControlDisplayed(POMBRNCH_BranchAddress_ContactsLink);
POMBRNCH_BranchAddress_ContactsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("BranchAddress_ContactsForm");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMBRNCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMBRNCH] Performing VerifyExists on BranchAddress_ContactsForm...", Logger.MessageType.INF);
				SeleniumControl POMBRNCH_BranchAddress_ContactsForm = new SeleniumControl( sDriver, "BranchAddress_ContactsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POMBRNCH_BRNCHADDRCNTACT_']/ancestor::form[1]");
				Function.AssertEqual(true,POMBRNCH_BranchAddress_ContactsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMBRNCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMBRNCH] Performing VerifyExists on BranchAddress_Contacts_Sequence...", Logger.MessageType.INF);
				SeleniumControl POMBRNCH_BranchAddress_Contacts_Sequence = new SeleniumControl( sDriver, "BranchAddress_Contacts_Sequence", "xpath", "//div[translate(@id,'0123456789','')='pr__POMBRNCH_BRNCHADDRCNTACT_']/ancestor::form[1]/descendant::*[@id='SEQ_NO']");
				Function.AssertEqual(true,POMBRNCH_BranchAddress_Contacts_Sequence.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMBRNCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMBRNCH] Performing ClickButton on BranchAddress_ContactsForm...", Logger.MessageType.INF);
				SeleniumControl POMBRNCH_BranchAddress_ContactsForm = new SeleniumControl( sDriver, "BranchAddress_ContactsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POMBRNCH_BRNCHADDRCNTACT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POMBRNCH_BranchAddress_ContactsForm);
IWebElement formBttn = POMBRNCH_BranchAddress_ContactsForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? POMBRNCH_BranchAddress_ContactsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
POMBRNCH_BranchAddress_ContactsForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMBRNCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMBRNCH] Performing VerifyExist on BranchAddress_ContactsFormTable...", Logger.MessageType.INF);
				SeleniumControl POMBRNCH_BranchAddress_ContactsFormTable = new SeleniumControl( sDriver, "BranchAddress_ContactsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__POMBRNCH_BRNCHADDRCNTACT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,POMBRNCH_BranchAddress_ContactsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMBRNCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMBRNCH] Performing ClickButton on BranchAddress_ContactsForm...", Logger.MessageType.INF);
				SeleniumControl POMBRNCH_BranchAddress_ContactsForm = new SeleniumControl( sDriver, "BranchAddress_ContactsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POMBRNCH_BRNCHADDRCNTACT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POMBRNCH_BranchAddress_ContactsForm);
IWebElement formBttn = POMBRNCH_BranchAddress_ContactsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? POMBRNCH_BranchAddress_ContactsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
POMBRNCH_BranchAddress_ContactsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMBRNCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMBRNCH] Performing Close on BranchAddress_ContactsForm...", Logger.MessageType.INF);
				SeleniumControl POMBRNCH_BranchAddress_ContactsForm = new SeleniumControl( sDriver, "BranchAddress_ContactsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POMBRNCH_BRNCHADDRCNTACT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POMBRNCH_BranchAddress_ContactsForm);
IWebElement formBttn = POMBRNCH_BranchAddress_ContactsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "POMBRNCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMBRNCH] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl POMBRNCH_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(POMBRNCH_MainForm);
IWebElement formBttn = POMBRNCH_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

