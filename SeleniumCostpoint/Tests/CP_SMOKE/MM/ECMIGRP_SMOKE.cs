 
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
    public class ECMIGRP_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Manage EC Impacted Functional Groups", "xpath","//div[@class='navItem'][.='Manage EC Impacted Functional Groups']").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SelectMenu]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("MAINFORM");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMIGRP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMIGRP] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl ECMIGRP_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,ECMIGRP_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMIGRP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMIGRP] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl ECMIGRP_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,ECMIGRP_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMIGRP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMIGRP] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl ECMIGRP_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(ECMIGRP_MainForm);
IWebElement formBttn = ECMIGRP_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? ECMIGRP_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
ECMIGRP_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMIGRP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMIGRP] Performing VerifyExists on ImpactedGroup...", Logger.MessageType.INF);
				SeleniumControl ECMIGRP_ImpactedGroup = new SeleniumControl( sDriver, "ImpactedGroup", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='IMPACT_GRP_CD']");
				Function.AssertEqual(true,ECMIGRP_ImpactedGroup.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMIGRP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMIGRP] Performing VerifyExists on ImpactedGroupUsersForm...", Logger.MessageType.INF);
				SeleniumControl ECMIGRP_ImpactedGroupUsersForm = new SeleniumControl( sDriver, "ImpactedGroupUsersForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMIGRP_IMPACTGRPUSER_']/ancestor::form[1]");
				Function.AssertEqual(true,ECMIGRP_ImpactedGroupUsersForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMIGRP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMIGRP] Performing VerifyExist on ImpactedGroupUsersTable...", Logger.MessageType.INF);
				SeleniumControl ECMIGRP_ImpactedGroupUsersTable = new SeleniumControl( sDriver, "ImpactedGroupUsersTable", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMIGRP_IMPACTGRPUSER_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,ECMIGRP_ImpactedGroupUsersTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMIGRP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMIGRP] Performing ClickButton on ImpactedGroupUsersForm...", Logger.MessageType.INF);
				SeleniumControl ECMIGRP_ImpactedGroupUsersForm = new SeleniumControl( sDriver, "ImpactedGroupUsersForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMIGRP_IMPACTGRPUSER_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECMIGRP_ImpactedGroupUsersForm);
IWebElement formBttn = ECMIGRP_ImpactedGroupUsersForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? ECMIGRP_ImpactedGroupUsersForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
ECMIGRP_ImpactedGroupUsersForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMIGRP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMIGRP] Performing VerifyExists on ImpactedGroupUsers_UserDetails_User...", Logger.MessageType.INF);
				SeleniumControl ECMIGRP_ImpactedGroupUsers_UserDetails_User = new SeleniumControl( sDriver, "ImpactedGroupUsers_UserDetails_User", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMIGRP_IMPACTGRPUSER_']/ancestor::form[1]/descendant::*[@id='USER_ID']");
				Function.AssertEqual(true,ECMIGRP_ImpactedGroupUsers_UserDetails_User.Exists());

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
				Function.CurrentComponent = "ECMIGRP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMIGRP] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl ECMIGRP_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(ECMIGRP_MainForm);
IWebElement formBttn = ECMIGRP_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

