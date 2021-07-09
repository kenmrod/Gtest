 
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
    public class MRPFPO_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Material Requirements Planning", "xpath","//div[@class='deptItem'][.='Material Requirements Planning']").Click();
new SeleniumControl(sDriver,"Material Requirements Planning", "xpath","//div[@class='navItem'][.='Material Requirements Planning']").Click();
new SeleniumControl(sDriver,"Firm Material Requirements Planning Planned Orders", "xpath","//div[@class='navItem'][.='Firm Material Requirements Planning Planned Orders']").Click();


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
				Function.CurrentComponent = "MRPFPO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRPFPO] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl MRPFPO_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,MRPFPO_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRPFPO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRPFPO] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl MRPFPO_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(MRPFPO_MainForm);
IWebElement formBttn = MRPFPO_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? MRPFPO_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
MRPFPO_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRPFPO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRPFPO] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl MRPFPO_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,MRPFPO_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRPFPO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRPFPO] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl MRPFPO_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(MRPFPO_MainForm);
IWebElement formBttn = MRPFPO_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? MRPFPO_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
MRPFPO_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRPFPO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRPFPO] Performing VerifyExists on MainForm_ParameterID...", Logger.MessageType.INF);
				SeleniumControl MRPFPO_MainForm_ParameterID = new SeleniumControl( sDriver, "MainForm_ParameterID", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PARM_ID']");
				Function.AssertEqual(true,MRPFPO_MainForm_ParameterID.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRPFPO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRPFPO] Performing VerifyExists on MainForm_SelectionRanges_Planner...", Logger.MessageType.INF);
				SeleniumControl MRPFPO_MainForm_SelectionRanges_Planner = new SeleniumControl( sDriver, "MainForm_SelectionRanges_Planner", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PLANNER_RANGE']");
				Function.AssertEqual(true,MRPFPO_MainForm_SelectionRanges_Planner.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRPFPO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRPFPO] Performing VerifyExists on MainForm_Options_IncludePlannedOrderType_MRP...", Logger.MessageType.INF);
				SeleniumControl MRPFPO_MainForm_Options_IncludePlannedOrderType_MRP = new SeleniumControl( sDriver, "MainForm_Options_IncludePlannedOrderType_MRP", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='MRP_FL']");
				Function.AssertEqual(true,MRPFPO_MainForm_Options_IncludePlannedOrderType_MRP.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRPFPO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRPFPO] Performing VerifyExists on MainForm_Generate_PurchaseRequisitions...", Logger.MessageType.INF);
				SeleniumControl MRPFPO_MainForm_Generate_PurchaseRequisitions = new SeleniumControl( sDriver, "MainForm_Generate_PurchaseRequisitions", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='GEN_RQ_FL']");
				Function.AssertEqual(true,MRPFPO_MainForm_Generate_PurchaseRequisitions.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Closing Main Form");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRPFPO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRPFPO] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl MRPFPO_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(MRPFPO_MainForm);
IWebElement formBttn = MRPFPO_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

