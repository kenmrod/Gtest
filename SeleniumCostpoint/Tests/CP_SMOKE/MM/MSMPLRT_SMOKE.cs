 
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
    public class MSMPLRT_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Master Production Scheduling", "xpath","//div[@class='deptItem'][.='Master Production Scheduling']").Click();
new SeleniumControl(sDriver,"Planning Routings", "xpath","//div[@class='navItem'][.='Planning Routings']").Click();
new SeleniumControl(sDriver,"Manage Planning Routings", "xpath","//div[@class='navItem'][.='Manage Planning Routings']").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SelectMenu]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMPLRT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMPLRT] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl MSMPLRT_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,MSMPLRT_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMPLRT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMPLRT] Performing VerifyExists on MainForm_Part...", Logger.MessageType.INF);
				SeleniumControl MSMPLRT_MainForm_Part = new SeleniumControl( sDriver, "MainForm_Part", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PART_ID']");
				Function.AssertEqual(true,MSMPLRT_MainForm_Part.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMPLRT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMPLRT] Performing VerifyExist on PlanningRoutingsFormTable...", Logger.MessageType.INF);
				SeleniumControl MSMPLRT_PlanningRoutingsFormTable = new SeleniumControl( sDriver, "PlanningRoutingsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__MSMPLRT_PARTPLNROUTING_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,MSMPLRT_PlanningRoutingsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMPLRT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMPLRT] Performing ClickButton on PlanningRoutingsForm...", Logger.MessageType.INF);
				SeleniumControl MSMPLRT_PlanningRoutingsForm = new SeleniumControl( sDriver, "PlanningRoutingsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MSMPLRT_PARTPLNROUTING_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MSMPLRT_PlanningRoutingsForm);
IWebElement formBttn = MSMPLRT_PlanningRoutingsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? MSMPLRT_PlanningRoutingsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
MSMPLRT_PlanningRoutingsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMPLRT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMPLRT] Performing VerifyExists on PlanningRoutingsForm...", Logger.MessageType.INF);
				SeleniumControl MSMPLRT_PlanningRoutingsForm = new SeleniumControl( sDriver, "PlanningRoutingsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MSMPLRT_PARTPLNROUTING_']/ancestor::form[1]");
				Function.AssertEqual(true,MSMPLRT_PlanningRoutingsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMPLRT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMPLRT] Performing VerifyExists on PlanningRoutings_Part...", Logger.MessageType.INF);
				SeleniumControl MSMPLRT_PlanningRoutings_Part = new SeleniumControl( sDriver, "PlanningRoutings_Part", "xpath", "//div[translate(@id,'0123456789','')='pr__MSMPLRT_PARTPLNROUTING_']/ancestor::form[1]/descendant::*[@id='PART_ID']");
				Function.AssertEqual(true,MSMPLRT_PlanningRoutings_Part.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMPLRT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMPLRT] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl MSMPLRT_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(MSMPLRT_MainForm);
IWebElement formBttn = MSMPLRT_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

