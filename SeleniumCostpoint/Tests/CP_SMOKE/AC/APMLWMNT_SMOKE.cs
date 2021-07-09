 
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
    public class APMLWMNT_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Accounting", "xpath","//div[@class='busItem'][.='Accounting']").Click();
new SeleniumControl(sDriver,"Accounts Payable", "xpath","//div[@class='deptItem'][.='Accounts Payable']").Click();
new SeleniumControl(sDriver,"Lien Waiver Controls", "xpath","//div[@class='navItem'][.='Lien Waiver Controls']").Click();
new SeleniumControl(sDriver,"Manage Lien Waiver Information", "xpath","//div[@class='navItem'][.='Manage Lien Waiver Information']").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SelectMenu]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMLWMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMLWMNT] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl APMLWMNT_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(APMLWMNT_MainForm);
IWebElement formBttn = APMLWMNT_MainForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).Count <= 0 ? APMLWMNT_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Query')]")).FirstOrDefault() :
APMLWMNT_MainForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).FirstOrDefault();
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
				Function.CurrentComponent = "APMLWMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMLWMNT] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl APMLWMNT_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,APMLWMNT_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMLWMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMLWMNT] Performing ClickButtonIfExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl APMLWMNT_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(APMLWMNT_MainForm);
IWebElement formBttn = APMLWMNT_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? APMLWMNT_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
APMLWMNT_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault();
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
				Function.CurrentComponent = "APMLWMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMLWMNT] Performing ClickButtonIfExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl APMLWMNT_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(APMLWMNT_MainForm);
IWebElement formBttn = APMLWMNT_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? APMLWMNT_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
APMLWMNT_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault();
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
				Function.CurrentComponent = "APMLWMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMLWMNT] Performing ClickButtonIfExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl APMLWMNT_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(APMLWMNT_MainForm);
IWebElement formBttn = APMLWMNT_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? APMLWMNT_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
APMLWMNT_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault();
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
				Function.CurrentComponent = "APMLWMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMLWMNT] Performing VerifyExists on Project...", Logger.MessageType.INF);
				SeleniumControl APMLWMNT_Project = new SeleniumControl( sDriver, "Project", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PROJ_ID']");
				Function.AssertEqual(true,APMLWMNT_Project.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMLWMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMLWMNT] Performing VerifyExist on LienWaiverInformationFormTable...", Logger.MessageType.INF);
				SeleniumControl APMLWMNT_LienWaiverInformationFormTable = new SeleniumControl( sDriver, "LienWaiverInformationFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__APMLWMNT_LIENWAIVERHDR_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,APMLWMNT_LienWaiverInformationFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMLWMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMLWMNT] Performing ClickButtonIfExists on LienWaiverInformationForm...", Logger.MessageType.INF);
				SeleniumControl APMLWMNT_LienWaiverInformationForm = new SeleniumControl( sDriver, "LienWaiverInformationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__APMLWMNT_LIENWAIVERHDR_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(APMLWMNT_LienWaiverInformationForm);
IWebElement formBttn = APMLWMNT_LienWaiverInformationForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? APMLWMNT_LienWaiverInformationForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
APMLWMNT_LienWaiverInformationForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault();
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
				Function.CurrentComponent = "APMLWMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMLWMNT] Performing VerifyExists on LienWaiverInformationForm...", Logger.MessageType.INF);
				SeleniumControl APMLWMNT_LienWaiverInformationForm = new SeleniumControl( sDriver, "LienWaiverInformationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__APMLWMNT_LIENWAIVERHDR_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,APMLWMNT_LienWaiverInformationForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMLWMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMLWMNT] Performing VerifyExists on LienWaiverInformation_LienNumber...", Logger.MessageType.INF);
				SeleniumControl APMLWMNT_LienWaiverInformation_LienNumber = new SeleniumControl( sDriver, "LienWaiverInformation_LienNumber", "xpath", "//div[translate(@id,'0123456789','')='pr__APMLWMNT_LIENWAIVERHDR_CTW_']/ancestor::form[1]/descendant::*[@id='LIEN_NO']");
				Function.AssertEqual(true,APMLWMNT_LienWaiverInformation_LienNumber.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMLWMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMLWMNT] Performing VerifyExists on LienWaiverInformation_LienWaiverDetailLink...", Logger.MessageType.INF);
				SeleniumControl APMLWMNT_LienWaiverInformation_LienWaiverDetailLink = new SeleniumControl( sDriver, "LienWaiverInformation_LienWaiverDetailLink", "ID", "lnk_1002125_APMLWMNT_LIENWAIVERHDR_CTW");
				Function.AssertEqual(true,APMLWMNT_LienWaiverInformation_LienWaiverDetailLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMLWMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMLWMNT] Performing Click on LienWaiverInformation_LienWaiverDetailLink...", Logger.MessageType.INF);
				SeleniumControl APMLWMNT_LienWaiverInformation_LienWaiverDetailLink = new SeleniumControl( sDriver, "LienWaiverInformation_LienWaiverDetailLink", "ID", "lnk_1002125_APMLWMNT_LIENWAIVERHDR_CTW");
				Function.WaitControlDisplayed(APMLWMNT_LienWaiverInformation_LienWaiverDetailLink);
APMLWMNT_LienWaiverInformation_LienWaiverDetailLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMLWMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMLWMNT] Performing VerifyExist on LienLienWaiverDetailFormTable...", Logger.MessageType.INF);
				SeleniumControl APMLWMNT_LienLienWaiverDetailFormTable = new SeleniumControl( sDriver, "LienLienWaiverDetailFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__APMLWMNT_LIENWVRVCHRDETL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,APMLWMNT_LienLienWaiverDetailFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMLWMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMLWMNT] Performing ClickButtonIfExists on LienWaiverDetailForm...", Logger.MessageType.INF);
				SeleniumControl APMLWMNT_LienWaiverDetailForm = new SeleniumControl( sDriver, "LienWaiverDetailForm", "xpath", "//div[translate(@id,'0123456789','')='pr__APMLWMNT_LIENWVRVCHRDETL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(APMLWMNT_LienWaiverDetailForm);
IWebElement formBttn = APMLWMNT_LienWaiverDetailForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? APMLWMNT_LienWaiverDetailForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
APMLWMNT_LienWaiverDetailForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault();
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
				Function.CurrentComponent = "APMLWMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMLWMNT] Performing ClickButtonIfExists on LienWaiverDetailForm...", Logger.MessageType.INF);
				SeleniumControl APMLWMNT_LienWaiverDetailForm = new SeleniumControl( sDriver, "LienWaiverDetailForm", "xpath", "//div[translate(@id,'0123456789','')='pr__APMLWMNT_LIENWVRVCHRDETL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(APMLWMNT_LienWaiverDetailForm);
IWebElement formBttn = APMLWMNT_LienWaiverDetailForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? APMLWMNT_LienWaiverDetailForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
APMLWMNT_LienWaiverDetailForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault();
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
				Function.CurrentComponent = "APMLWMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMLWMNT] Performing VerifyExists on LienWaiverDetail_CheckDetails_CheckNumber...", Logger.MessageType.INF);
				SeleniumControl APMLWMNT_LienWaiverDetail_CheckDetails_CheckNumber = new SeleniumControl( sDriver, "LienWaiverDetail_CheckDetails_CheckNumber", "xpath", "//div[translate(@id,'0123456789','')='pr__APMLWMNT_LIENWVRVCHRDETL_']/ancestor::form[1]/descendant::*[@id='CHK_NO']");
				Function.AssertEqual(true,APMLWMNT_LienWaiverDetail_CheckDetails_CheckNumber.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("CLOSE APP");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMLWMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMLWMNT] Performing Close on LienWaiverDetailForm...", Logger.MessageType.INF);
				SeleniumControl APMLWMNT_LienWaiverDetailForm = new SeleniumControl( sDriver, "LienWaiverDetailForm", "xpath", "//div[translate(@id,'0123456789','')='pr__APMLWMNT_LIENWVRVCHRDETL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(APMLWMNT_LienWaiverDetailForm);
IWebElement formBttn = APMLWMNT_LienWaiverDetailForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMLWMNT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMLWMNT] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl APMLWMNT_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(APMLWMNT_MainForm);
IWebElement formBttn = APMLWMNT_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

