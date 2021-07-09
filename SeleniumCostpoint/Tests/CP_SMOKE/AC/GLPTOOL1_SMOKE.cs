 
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
    public class GLPTOOL1_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Cash Management", "xpath","//div[@class='deptItem'][.='Cash Management']").Click();
new SeleniumControl(sDriver,"Cash Management Utilities", "xpath","//div[@class='navItem'][.='Cash Management Utilities']").Click();
new SeleniumControl(sDriver,"Update Beginning Bank Statement Balances", "xpath","//div[@class='navItem'][.='Update Beginning Bank Statement Balances']").Click();


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
				Function.CurrentComponent = "GLPTOOL1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLPTOOL1] Performing VerifyExists on Option_BankAbbreviation...", Logger.MessageType.INF);
				SeleniumControl GLPTOOL1_Option_BankAbbreviation = new SeleniumControl( sDriver, "Option_BankAbbreviation", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='BNK_ABREV']");
				Function.AssertEqual(true,GLPTOOL1_Option_BankAbbreviation.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Bank Abbreviation");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLPTOOL1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLPTOOL1] Performing Click on BankAbbreviationNonContiguousRangesLink...", Logger.MessageType.INF);
				SeleniumControl GLPTOOL1_BankAbbreviationNonContiguousRangesLink = new SeleniumControl( sDriver, "BankAbbreviationNonContiguousRangesLink", "ID", "lnk_3506_GLPTOOL_UPD_BNK_BEG_BAL");
				Function.WaitControlDisplayed(GLPTOOL1_BankAbbreviationNonContiguousRangesLink);
GLPTOOL1_BankAbbreviationNonContiguousRangesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLPTOOL1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLPTOOL1] Performing VerifyExist on BankAbbreviationNonContiguousFormTable...", Logger.MessageType.INF);
				SeleniumControl GLPTOOL1_BankAbbreviationNonContiguousFormTable = new SeleniumControl( sDriver, "BankAbbreviationNonContiguousFormTable", "xpath", "//div[starts-with(@id,'pr__GLPTOOL1_BANKACCTABBR_NCR_')]/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,GLPTOOL1_BankAbbreviationNonContiguousFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLPTOOL1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLPTOOL1] Performing Close on BankAbbreviationNonContiguousForm...", Logger.MessageType.INF);
				SeleniumControl GLPTOOL1_BankAbbreviationNonContiguousForm = new SeleniumControl( sDriver, "BankAbbreviationNonContiguousForm", "xpath", "//div[starts-with(@id,'pr__GLPTOOL1_BANKACCTABBR_NCR_')]/ancestor::form[1]");
				Function.WaitControlDisplayed(GLPTOOL1_BankAbbreviationNonContiguousForm);
IWebElement formBttn = GLPTOOL1_BankAbbreviationNonContiguousForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Close Form");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLPTOOL1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLPTOOL1] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl GLPTOOL1_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(GLPTOOL1_MainForm);
IWebElement formBttn = GLPTOOL1_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

