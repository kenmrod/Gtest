 
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
    public class ECMTYPE_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Engineering Change Notices", "xpath","//div[@class='deptItem'][.='Engineering Change Notices']").Click();
new SeleniumControl(sDriver,"Engineering Change Controls", "xpath","//div[@class='navItem'][.='Engineering Change Controls']").Click();
new SeleniumControl(sDriver,"Manage Engineering Change Types", "xpath","//div[@class='navItem'][.='Manage Engineering Change Types']").Click();


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
				Function.CurrentComponent = "ECMTYPE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMTYPE] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl ECMTYPE_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,ECMTYPE_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMTYPE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMTYPE] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl ECMTYPE_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(ECMTYPE_MainForm);
IWebElement formBttn = ECMTYPE_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? ECMTYPE_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
ECMTYPE_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMTYPE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMTYPE] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl ECMTYPE_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,ECMTYPE_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMTYPE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMTYPE] Performing VerifyExists on EcType_EngineeringChangeType...", Logger.MessageType.INF);
				SeleniumControl ECMTYPE_EcType_EngineeringChangeType = new SeleniumControl( sDriver, "EcType_EngineeringChangeType", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='EC_TYPE_CD']");
				Function.AssertEqual(true,ECMTYPE_EcType_EngineeringChangeType.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("SELECTED IMPACT GROUP LINK");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMTYPE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMTYPE] Performing Click on EcType_ECTypeDetails_Defaults_SelectedImpactedGroupLink...", Logger.MessageType.INF);
				SeleniumControl ECMTYPE_EcType_ECTypeDetails_Defaults_SelectedImpactedGroupLink = new SeleniumControl( sDriver, "EcType_ECTypeDetails_Defaults_SelectedImpactedGroupLink", "ID", "lnk_1002473_ECMTYPE_ECTYPE");
				Function.WaitControlDisplayed(ECMTYPE_EcType_ECTypeDetails_Defaults_SelectedImpactedGroupLink);
ECMTYPE_EcType_ECTypeDetails_Defaults_SelectedImpactedGroupLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMTYPE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMTYPE] Performing VerifyExist on SelectedImpactedGroupFormTable...", Logger.MessageType.INF);
				SeleniumControl ECMTYPE_SelectedImpactedGroupFormTable = new SeleniumControl( sDriver, "SelectedImpactedGroupFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMTYPE_ECTYPEIMPACTGRP_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,ECMTYPE_SelectedImpactedGroupFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
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
				Function.CurrentComponent = "ECMTYPE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMTYPE] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl ECMTYPE_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(ECMTYPE_MainForm);
IWebElement formBttn = ECMTYPE_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

