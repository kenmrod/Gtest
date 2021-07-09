 
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
    public class PPMRQOP_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Procurement Planning", "xpath","//div[@class='deptItem'][.='Procurement Planning']").Click();
new SeleniumControl(sDriver,"Procurement Planning Controls", "xpath","//div[@class='navItem'][.='Procurement Planning Controls']").Click();
new SeleniumControl(sDriver,"Configure Purchase Requisition Print Options", "xpath","//div[@class='navItem'][.='Configure Purchase Requisition Print Options']").Click();


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
				Function.CurrentComponent = "PPMRQOP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQOP] Performing VerifyExists on Print_PageXOfY...", Logger.MessageType.INF);
				SeleniumControl PPMRQOP_Print_PageXOfY = new SeleniumControl( sDriver, "Print_PageXOfY", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='X_OF_Y_FL']");
				Function.AssertEqual(true,PPMRQOP_Print_PageXOfY.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQOP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQOP] Performing VerifyExists on SetAsDefaults_StandardTextPlacement_Top...", Logger.MessageType.INF);
				SeleniumControl PPMRQOP_SetAsDefaults_StandardTextPlacement_Top = new SeleniumControl( sDriver, "SetAsDefaults_StandardTextPlacement_Top", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='S_PRNT_TX_LOC_CD' and @value='T']");
				Function.AssertEqual(true,PPMRQOP_SetAsDefaults_StandardTextPlacement_Top.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
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
				Function.CurrentComponent = "PPMRQOP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQOP] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl PPMRQOP_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PPMRQOP_MainForm);
IWebElement formBttn = PPMRQOP_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

