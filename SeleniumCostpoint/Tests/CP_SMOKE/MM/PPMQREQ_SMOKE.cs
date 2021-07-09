 
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
    public class PPMQREQ_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Purchase Requisitions", "xpath","//div[@class='navItem'][.='Purchase Requisitions']").Click();
new SeleniumControl(sDriver,"Manage Simple Purchase Requisitions", "xpath","//div[@class='navItem'][.='Manage Simple Purchase Requisitions']").Click();


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
				Function.CurrentComponent = "PPMQREQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMQREQ] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl PPMQREQ_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,PPMQREQ_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMQREQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMQREQ] Performing VerifyExists on RequisitionType...", Logger.MessageType.INF);
				SeleniumControl PPMQREQ_RequisitionType = new SeleniumControl( sDriver, "RequisitionType", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='RQ_TYPE_ID']");
				Function.AssertEqual(true,PPMQREQ_RequisitionType.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMQREQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMQREQ] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl PPMQREQ_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PPMQREQ_MainForm);
IWebElement formBttn = PPMQREQ_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? PPMQREQ_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
PPMQREQ_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMQREQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMQREQ] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl PPMQREQ_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PPMQREQ_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Requested Items");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMQREQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMQREQ] Performing Click on RequestedItemsAddViewLink...", Logger.MessageType.INF);
				SeleniumControl PPMQREQ_RequestedItemsAddViewLink = new SeleniumControl( sDriver, "RequestedItemsAddViewLink", "ID", "lnk_3134_PPMQREQ_RQHDR");
				Function.WaitControlDisplayed(PPMQREQ_RequestedItemsAddViewLink);
PPMQREQ_RequestedItemsAddViewLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMQREQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMQREQ] Performing VerifyExists on WhatShouldBeOrderedForm...", Logger.MessageType.INF);
				SeleniumControl PPMQREQ_WhatShouldBeOrderedForm = new SeleniumControl( sDriver, "WhatShouldBeOrderedForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMQREQ_RQLN_']/ancestor::form[1]");
				Function.AssertEqual(true,PPMQREQ_WhatShouldBeOrderedForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMQREQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMQREQ] Performing VerifyExists on WhatShouldBeOrdered_Line...", Logger.MessageType.INF);
				SeleniumControl PPMQREQ_WhatShouldBeOrdered_Line = new SeleniumControl( sDriver, "WhatShouldBeOrdered_Line", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMQREQ_RQLN_']/ancestor::form[1]/descendant::*[@id='RQ_LN_NO']");
				Function.AssertEqual(true,PPMQREQ_WhatShouldBeOrdered_Line.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				Function.ScrollUp();


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ScrollUp]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMQREQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMQREQ] Performing ClickButton on WhatShouldBeOrderedForm...", Logger.MessageType.INF);
				SeleniumControl PPMQREQ_WhatShouldBeOrderedForm = new SeleniumControl( sDriver, "WhatShouldBeOrderedForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMQREQ_RQLN_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMQREQ_WhatShouldBeOrderedForm);
IWebElement formBttn = PPMQREQ_WhatShouldBeOrderedForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? PPMQREQ_WhatShouldBeOrderedForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
PPMQREQ_WhatShouldBeOrderedForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMQREQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMQREQ] Performing VerifyExist on WhatShouldBeOrderedFormTable...", Logger.MessageType.INF);
				SeleniumControl PPMQREQ_WhatShouldBeOrderedFormTable = new SeleniumControl( sDriver, "WhatShouldBeOrderedFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMQREQ_RQLN_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PPMQREQ_WhatShouldBeOrderedFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMQREQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMQREQ] Performing Close on WhatShouldBeOrderedForm...", Logger.MessageType.INF);
				SeleniumControl PPMQREQ_WhatShouldBeOrderedForm = new SeleniumControl( sDriver, "WhatShouldBeOrderedForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMQREQ_RQLN_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMQREQ_WhatShouldBeOrderedForm);
IWebElement formBttn = PPMQREQ_WhatShouldBeOrderedForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
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
				Function.CurrentComponent = "PPMQREQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMQREQ] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl PPMQREQ_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PPMQREQ_MainForm);
IWebElement formBttn = PPMQREQ_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

