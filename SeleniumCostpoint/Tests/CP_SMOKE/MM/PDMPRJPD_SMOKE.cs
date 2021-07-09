 
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
    public class PDMPRJPD_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Product Definition", "xpath","//div[@class='deptItem'][.='Product Definition']").Click();
new SeleniumControl(sDriver,"Items", "xpath","//div[@class='navItem'][.='Items']").Click();
new SeleniumControl(sDriver,"Manage Part Project Data", "xpath","//div[@class='navItem'][.='Manage Part Project Data']").Click();


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
				Function.CurrentComponent = "PDMPRJPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPRJPD] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl PDMPRJPD_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PDMPRJPD_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPRJPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPRJPD] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl PDMPRJPD_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PDMPRJPD_MainForm);
IWebElement formBttn = PDMPRJPD_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PDMPRJPD_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PDMPRJPD_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPRJPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPRJPD] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl PDMPRJPD_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,PDMPRJPD_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPRJPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPRJPD] Performing VerifyExists on Part...", Logger.MessageType.INF);
				SeleniumControl PDMPRJPD_Part = new SeleniumControl( sDriver, "Part", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='ITEM_ID']");
				Function.AssertEqual(true,PDMPRJPD_Part.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("LINK");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPRJPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPRJPD] Performing Click on SubstituteProjectPartsLink...", Logger.MessageType.INF);
				SeleniumControl PDMPRJPD_SubstituteProjectPartsLink = new SeleniumControl( sDriver, "SubstituteProjectPartsLink", "ID", "lnk_1006551_PDMPRJPD_PARTPROJ");
				Function.WaitControlDisplayed(PDMPRJPD_SubstituteProjectPartsLink);
PDMPRJPD_SubstituteProjectPartsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPRJPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPRJPD] Performing VerifyExist on ProjectSubstitutePartsFormTable...", Logger.MessageType.INF);
				SeleniumControl PDMPRJPD_ProjectSubstitutePartsFormTable = new SeleniumControl( sDriver, "ProjectSubstitutePartsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PDMPRJPD_PROJSUBSTPART_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PDMPRJPD_ProjectSubstitutePartsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPRJPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPRJPD] Performing ClickButton on ProjectSubstitutePartsForm...", Logger.MessageType.INF);
				SeleniumControl PDMPRJPD_ProjectSubstitutePartsForm = new SeleniumControl( sDriver, "ProjectSubstitutePartsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PDMPRJPD_PROJSUBSTPART_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PDMPRJPD_ProjectSubstitutePartsForm);
IWebElement formBttn = PDMPRJPD_ProjectSubstitutePartsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PDMPRJPD_ProjectSubstitutePartsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PDMPRJPD_ProjectSubstitutePartsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPRJPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPRJPD] Performing VerifyExists on ProjectSubstitutePartsForm...", Logger.MessageType.INF);
				SeleniumControl PDMPRJPD_ProjectSubstitutePartsForm = new SeleniumControl( sDriver, "ProjectSubstitutePartsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PDMPRJPD_PROJSUBSTPART_']/ancestor::form[1]");
				Function.AssertEqual(true,PDMPRJPD_ProjectSubstitutePartsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPRJPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPRJPD] Performing VerifyExists on ProjectSubstituteParts_Sequence...", Logger.MessageType.INF);
				SeleniumControl PDMPRJPD_ProjectSubstituteParts_Sequence = new SeleniumControl( sDriver, "ProjectSubstituteParts_Sequence", "xpath", "//div[translate(@id,'0123456789','')='pr__PDMPRJPD_PROJSUBSTPART_']/ancestor::form[1]/descendant::*[@id='USAGE_SEQ_NO']");
				Function.AssertEqual(true,PDMPRJPD_ProjectSubstituteParts_Sequence.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMPRJPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMPRJPD] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl PDMPRJPD_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PDMPRJPD_MainForm);
IWebElement formBttn = PDMPRJPD_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

