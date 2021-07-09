 
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
    public class PJMETCD_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Estimate To Complete", "xpath","//div[@class='navItem'][.='Estimate To Complete']").Click();
new SeleniumControl(sDriver,"Manage Estimate To Complete Amounts", "xpath","//div[@class='navItem'][.='Manage Estimate To Complete Amounts']").Click();


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
				Function.CurrentComponent = "PJMETCD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMETCD] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl PJMETCD_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,PJMETCD_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMETCD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMETCD] Performing VerifyExists on Project...", Logger.MessageType.INF);
				SeleniumControl PJMETCD_Project = new SeleniumControl( sDriver, "Project", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PROJ_ID']");
				Function.AssertEqual(true,PJMETCD_Project.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMETCD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMETCD] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl PJMETCD_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PJMETCD_MainForm);
IWebElement formBttn = PJMETCD_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? PJMETCD_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
PJMETCD_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMETCD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMETCD] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl PJMETCD_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJMETCD_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("DIRECT COSTS");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMETCD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMETCD] Performing VerifyExists on DirectCostsDetailLink...", Logger.MessageType.INF);
				SeleniumControl PJMETCD_DirectCostsDetailLink = new SeleniumControl( sDriver, "DirectCostsDetailLink", "ID", "lnk_3824_PJMETCD_ETCDIRCST_HDR");
				Function.AssertEqual(true,PJMETCD_DirectCostsDetailLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMETCD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMETCD] Performing ClickButton on DirectCostsForm...", Logger.MessageType.INF);
				SeleniumControl PJMETCD_DirectCostsForm = new SeleniumControl( sDriver, "DirectCostsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMETCD_ETCDIRCOST_CHILD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJMETCD_DirectCostsForm);
IWebElement formBttn = PJMETCD_DirectCostsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PJMETCD_DirectCostsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PJMETCD_DirectCostsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMETCD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMETCD] Performing VerifyExists on DirectCostsForm...", Logger.MessageType.INF);
				SeleniumControl PJMETCD_DirectCostsForm = new SeleniumControl( sDriver, "DirectCostsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMETCD_ETCDIRCOST_CHILD_']/ancestor::form[1]");
				Function.AssertEqual(true,PJMETCD_DirectCostsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMETCD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMETCD] Performing VerifyExists on DirectCosts_AccountInformation_Account...", Logger.MessageType.INF);
				SeleniumControl PJMETCD_DirectCosts_AccountInformation_Account = new SeleniumControl( sDriver, "DirectCosts_AccountInformation_Account", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMETCD_ETCDIRCOST_CHILD_']/ancestor::form[1]/descendant::*[@id='ACCT_ID']");
				Function.AssertEqual(true,PJMETCD_DirectCosts_AccountInformation_Account.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMETCD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMETCD] Performing ClickButton on DirectCostsForm...", Logger.MessageType.INF);
				SeleniumControl PJMETCD_DirectCostsForm = new SeleniumControl( sDriver, "DirectCostsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMETCD_ETCDIRCOST_CHILD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJMETCD_DirectCostsForm);
IWebElement formBttn = PJMETCD_DirectCostsForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? PJMETCD_DirectCostsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
PJMETCD_DirectCostsForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMETCD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMETCD] Performing VerifyExist on DirectCostsFormTable...", Logger.MessageType.INF);
				SeleniumControl PJMETCD_DirectCostsFormTable = new SeleniumControl( sDriver, "DirectCostsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMETCD_ETCDIRCOST_CHILD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJMETCD_DirectCostsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("INDIRECT COSTS");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMETCD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMETCD] Performing VerifyExists on DirectCosts_IndirectCostsLink...", Logger.MessageType.INF);
				SeleniumControl PJMETCD_DirectCosts_IndirectCostsLink = new SeleniumControl( sDriver, "DirectCosts_IndirectCostsLink", "ID", "lnk_3826_PJMETCD_ETCDIRCOST_CHILD");
				Function.AssertEqual(true,PJMETCD_DirectCosts_IndirectCostsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMETCD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMETCD] Performing Click on DirectCosts_IndirectCostsLink...", Logger.MessageType.INF);
				SeleniumControl PJMETCD_DirectCosts_IndirectCostsLink = new SeleniumControl( sDriver, "DirectCosts_IndirectCostsLink", "ID", "lnk_3826_PJMETCD_ETCDIRCOST_CHILD");
				Function.WaitControlDisplayed(PJMETCD_DirectCosts_IndirectCostsLink);
PJMETCD_DirectCosts_IndirectCostsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMETCD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMETCD] Performing ClickButton on DirectCosts_IndirectCostsForm...", Logger.MessageType.INF);
				SeleniumControl PJMETCD_DirectCosts_IndirectCostsForm = new SeleniumControl( sDriver, "DirectCosts_IndirectCostsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMETCD_ETCINDCST_CHILDINDIREC_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJMETCD_DirectCosts_IndirectCostsForm);
IWebElement formBttn = PJMETCD_DirectCosts_IndirectCostsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PJMETCD_DirectCosts_IndirectCostsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PJMETCD_DirectCosts_IndirectCostsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMETCD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMETCD] Performing VerifyExists on DirectCosts_IndirectCostsForm...", Logger.MessageType.INF);
				SeleniumControl PJMETCD_DirectCosts_IndirectCostsForm = new SeleniumControl( sDriver, "DirectCosts_IndirectCostsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMETCD_ETCINDCST_CHILDINDIREC_']/ancestor::form[1]");
				Function.AssertEqual(true,PJMETCD_DirectCosts_IndirectCostsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMETCD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMETCD] Performing VerifyExists on DirectCosts_IndirectCosts_FiscalYear...", Logger.MessageType.INF);
				SeleniumControl PJMETCD_DirectCosts_IndirectCosts_FiscalYear = new SeleniumControl( sDriver, "DirectCosts_IndirectCosts_FiscalYear", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMETCD_ETCINDCST_CHILDINDIREC_']/ancestor::form[1]/descendant::*[@id='FY_CD']");
				Function.AssertEqual(true,PJMETCD_DirectCosts_IndirectCosts_FiscalYear.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMETCD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMETCD] Performing ClickButton on DirectCosts_IndirectCostsForm...", Logger.MessageType.INF);
				SeleniumControl PJMETCD_DirectCosts_IndirectCostsForm = new SeleniumControl( sDriver, "DirectCosts_IndirectCostsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMETCD_ETCINDCST_CHILDINDIREC_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJMETCD_DirectCosts_IndirectCostsForm);
IWebElement formBttn = PJMETCD_DirectCosts_IndirectCostsForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? PJMETCD_DirectCosts_IndirectCostsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
PJMETCD_DirectCosts_IndirectCostsForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMETCD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMETCD] Performing VerifyExist on DirectCosts_IndirectCostsFormTable...", Logger.MessageType.INF);
				SeleniumControl PJMETCD_DirectCosts_IndirectCostsFormTable = new SeleniumControl( sDriver, "DirectCosts_IndirectCostsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMETCD_ETCINDCST_CHILDINDIREC_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJMETCD_DirectCosts_IndirectCostsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMETCD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMETCD] Performing Close on DirectCosts_IndirectCostsForm...", Logger.MessageType.INF);
				SeleniumControl PJMETCD_DirectCosts_IndirectCostsForm = new SeleniumControl( sDriver, "DirectCosts_IndirectCostsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMETCD_ETCINDCST_CHILDINDIREC_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJMETCD_DirectCosts_IndirectCostsForm);
IWebElement formBttn = PJMETCD_DirectCosts_IndirectCostsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("INDIRECT COSTS");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMETCD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMETCD] Performing VerifyExists on DirectCosts_ProjectFeeLink...", Logger.MessageType.INF);
				SeleniumControl PJMETCD_DirectCosts_ProjectFeeLink = new SeleniumControl( sDriver, "DirectCosts_ProjectFeeLink", "ID", "lnk_3827_PJMETCD_ETCDIRCOST_CHILD");
				Function.AssertEqual(true,PJMETCD_DirectCosts_ProjectFeeLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMETCD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMETCD] Performing Click on DirectCosts_ProjectFeeLink...", Logger.MessageType.INF);
				SeleniumControl PJMETCD_DirectCosts_ProjectFeeLink = new SeleniumControl( sDriver, "DirectCosts_ProjectFeeLink", "ID", "lnk_3827_PJMETCD_ETCDIRCOST_CHILD");
				Function.WaitControlDisplayed(PJMETCD_DirectCosts_ProjectFeeLink);
PJMETCD_DirectCosts_ProjectFeeLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMETCD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMETCD] Performing VerifyExist on DirectCosts_ProjectFeeFormTable...", Logger.MessageType.INF);
				SeleniumControl PJMETCD_DirectCosts_ProjectFeeFormTable = new SeleniumControl( sDriver, "DirectCosts_ProjectFeeFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMETCD_ETCFEE_CHILDFEE_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJMETCD_DirectCosts_ProjectFeeFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMETCD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMETCD] Performing ClickButton on DirectCosts_ProjectFeeForm...", Logger.MessageType.INF);
				SeleniumControl PJMETCD_DirectCosts_ProjectFeeForm = new SeleniumControl( sDriver, "DirectCosts_ProjectFeeForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMETCD_ETCFEE_CHILDFEE_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJMETCD_DirectCosts_ProjectFeeForm);
IWebElement formBttn = PJMETCD_DirectCosts_ProjectFeeForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PJMETCD_DirectCosts_ProjectFeeForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PJMETCD_DirectCosts_ProjectFeeForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMETCD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMETCD] Performing VerifyExists on DirectCosts_ProjectFee_FeeType...", Logger.MessageType.INF);
				SeleniumControl PJMETCD_DirectCosts_ProjectFee_FeeType = new SeleniumControl( sDriver, "DirectCosts_ProjectFee_FeeType", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMETCD_ETCFEE_CHILDFEE_']/ancestor::form[1]/descendant::*[@id='S_FEE_TYPE']");
				Function.AssertEqual(true,PJMETCD_DirectCosts_ProjectFee_FeeType.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMETCD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMETCD] Performing VerifyExists on DirectCosts_ProjectFeeForm...", Logger.MessageType.INF);
				SeleniumControl PJMETCD_DirectCosts_ProjectFeeForm = new SeleniumControl( sDriver, "DirectCosts_ProjectFeeForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMETCD_ETCFEE_CHILDFEE_']/ancestor::form[1]");
				Function.AssertEqual(true,PJMETCD_DirectCosts_ProjectFeeForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMETCD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMETCD] Performing Close on DirectCosts_ProjectFeeForm...", Logger.MessageType.INF);
				SeleniumControl PJMETCD_DirectCosts_ProjectFeeForm = new SeleniumControl( sDriver, "DirectCosts_ProjectFeeForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMETCD_ETCFEE_CHILDFEE_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJMETCD_DirectCosts_ProjectFeeForm);
IWebElement formBttn = PJMETCD_DirectCosts_ProjectFeeForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
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
				Function.CurrentComponent = "PJMETCD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMETCD] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl PJMETCD_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PJMETCD_MainForm);
IWebElement formBttn = PJMETCD_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

