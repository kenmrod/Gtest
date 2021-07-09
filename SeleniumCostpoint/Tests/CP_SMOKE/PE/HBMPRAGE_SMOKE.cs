 
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
    public class HBMPRAGE_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Benefits", "xpath","//div[@class='deptItem'][.='Benefits']").Click();
new SeleniumControl(sDriver,"Benefit Controls", "xpath","//div[@class='navItem'][.='Benefit Controls']").Click();
new SeleniumControl(sDriver,"Manage Premium Rates by Age", "xpath","//div[@class='navItem'][.='Manage Premium Rates by Age']").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SelectMenu]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HBMPRAGE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HBMPRAGE] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl HBMPRAGE_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,HBMPRAGE_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HBMPRAGE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HBMPRAGE] Performing VerifyExists on RateTableCode...", Logger.MessageType.INF);
				SeleniumControl HBMPRAGE_RateTableCode = new SeleniumControl( sDriver, "RateTableCode", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='AGE_RT_TBL_CD']");
				Function.AssertEqual(true,HBMPRAGE_RateTableCode.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HBMPRAGE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HBMPRAGE] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl HBMPRAGE_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(HBMPRAGE_MainForm);
IWebElement formBttn = HBMPRAGE_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? HBMPRAGE_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
HBMPRAGE_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HBMPRAGE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HBMPRAGE] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl HBMPRAGE_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,HBMPRAGE_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HBMPRAGE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HBMPRAGE] Performing Click on BenefitPremiumsByAgeDetailLink...", Logger.MessageType.INF);
				SeleniumControl HBMPRAGE_BenefitPremiumsByAgeDetailLink = new SeleniumControl( sDriver, "BenefitPremiumsByAgeDetailLink", "ID", "lnk_4092_HBMPRAGE_HBAGERT_HDR");
				Function.WaitControlDisplayed(HBMPRAGE_BenefitPremiumsByAgeDetailLink);
HBMPRAGE_BenefitPremiumsByAgeDetailLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HBMPRAGE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HBMPRAGE] Performing VerifyExists on BenefitPremiumsByAgeDetailForm...", Logger.MessageType.INF);
				SeleniumControl HBMPRAGE_BenefitPremiumsByAgeDetailForm = new SeleniumControl( sDriver, "BenefitPremiumsByAgeDetailForm", "xpath", "//div[translate(@id,'0123456789','')='pr__HBMPRAGE_HBAGERTSCH_DTL_']/ancestor::form[1]");
				Function.AssertEqual(true,HBMPRAGE_BenefitPremiumsByAgeDetailForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HBMPRAGE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HBMPRAGE] Performing VerifyExist on BenefitPremiumsByAgeDetailFormTable...", Logger.MessageType.INF);
				SeleniumControl HBMPRAGE_BenefitPremiumsByAgeDetailFormTable = new SeleniumControl( sDriver, "BenefitPremiumsByAgeDetailFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__HBMPRAGE_HBAGERTSCH_DTL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,HBMPRAGE_BenefitPremiumsByAgeDetailFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HBMPRAGE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HBMPRAGE] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl HBMPRAGE_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(HBMPRAGE_MainForm);
IWebElement formBttn = HBMPRAGE_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

