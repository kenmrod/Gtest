 
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
    public class MRPTOOL3_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"MRP Utilities", "xpath","//div[@class='navItem'][.='MRP Utilities']").Click();
new SeleniumControl(sDriver,"Assign Planning Warehouses to Inventory Projects", "xpath","//div[@class='navItem'][.='Assign Planning Warehouses to Inventory Projects']").Click();


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
				Function.CurrentComponent = "MRPTOOL3";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRPTOOL3] Performing VerifyExists on AssignPlanningWarehousesForm...", Logger.MessageType.INF);
				SeleniumControl MRPTOOL3_AssignPlanningWarehousesForm = new SeleniumControl( sDriver, "AssignPlanningWarehousesForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,MRPTOOL3_AssignPlanningWarehousesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRPTOOL3";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRPTOOL3] Performing VerifyExists on AssignPlanningWarehouses_SelectionRange_Start...", Logger.MessageType.INF);
				SeleniumControl MRPTOOL3_AssignPlanningWarehouses_SelectionRange_Start = new SeleniumControl( sDriver, "AssignPlanningWarehouses_SelectionRange_Start", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PROJ_ID_FR']");
				Function.AssertEqual(true,MRPTOOL3_AssignPlanningWarehouses_SelectionRange_Start.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRPTOOL3";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRPTOOL3] Performing Close on AssignPlanningWarehousesForm...", Logger.MessageType.INF);
				SeleniumControl MRPTOOL3_AssignPlanningWarehousesForm = new SeleniumControl( sDriver, "AssignPlanningWarehousesForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(MRPTOOL3_AssignPlanningWarehousesForm);
IWebElement formBttn = MRPTOOL3_AssignPlanningWarehousesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

