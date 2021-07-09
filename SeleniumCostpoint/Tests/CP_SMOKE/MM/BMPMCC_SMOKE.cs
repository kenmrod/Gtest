 
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
    public class BMPMCC_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Bills of Material", "xpath","//div[@class='deptItem'][.='Bills of Material']").Click();
new SeleniumControl(sDriver,"Bills of Material", "xpath","//div[@class='navItem'][.='Bills of Material']").Click();
new SeleniumControl(sDriver,"Apply Mass Component Changes to Bills of Material", "xpath","//div[@class='navItem'][.='Apply Mass Component Changes to Bills of Material']").Click();


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
				Function.CurrentComponent = "BMPMCC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMPMCC] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl BMPMCC_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,BMPMCC_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMPMCC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMPMCC] Performing VerifyExists on ParameterID...", Logger.MessageType.INF);
				SeleniumControl BMPMCC_ParameterID = new SeleniumControl( sDriver, "ParameterID", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PARM_ID']");
				Function.AssertEqual(true,BMPMCC_ParameterID.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMPMCC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMPMCC] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl BMPMCC_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(BMPMCC_MainForm);
IWebElement formBttn = BMPMCC_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? BMPMCC_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
BMPMCC_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMPMCC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMPMCC] Performing VerifyExist on MainTable...", Logger.MessageType.INF);
				SeleniumControl BMPMCC_MainTable = new SeleniumControl( sDriver, "MainTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BMPMCC_MainTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("COMPONENT MBOMS WHERE USED");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMPMCC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMPMCC] Performing VerifyExists on ComponentMBOMsWhereUsedLink...", Logger.MessageType.INF);
				SeleniumControl BMPMCC_ComponentMBOMsWhereUsedLink = new SeleniumControl( sDriver, "ComponentMBOMsWhereUsedLink", "ID", "lnk_1004513_BMPMCC_PARAM");
				Function.AssertEqual(true,BMPMCC_ComponentMBOMsWhereUsedLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMPMCC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMPMCC] Performing Click on ComponentMBOMsWhereUsedLink...", Logger.MessageType.INF);
				SeleniumControl BMPMCC_ComponentMBOMsWhereUsedLink = new SeleniumControl( sDriver, "ComponentMBOMsWhereUsedLink", "ID", "lnk_1004513_BMPMCC_PARAM");
				Function.WaitControlDisplayed(BMPMCC_ComponentMBOMsWhereUsedLink);
BMPMCC_ComponentMBOMsWhereUsedLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMPMCC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMPMCC] Performing VerifyExist on ComponentMBOMSWhereUsedTable...", Logger.MessageType.INF);
				SeleniumControl BMPMCC_ComponentMBOMSWhereUsedTable = new SeleniumControl( sDriver, "ComponentMBOMSWhereUsedTable", "xpath", "//div[translate(@id,'0123456789','')='pr__BMPMCC_MFGBOM_DTL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BMPMCC_ComponentMBOMSWhereUsedTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMPMCC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMPMCC] Performing ClickButton on ComponentMBOMSWhereUsedForm...", Logger.MessageType.INF);
				SeleniumControl BMPMCC_ComponentMBOMSWhereUsedForm = new SeleniumControl( sDriver, "ComponentMBOMSWhereUsedForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BMPMCC_MFGBOM_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BMPMCC_ComponentMBOMSWhereUsedForm);
IWebElement formBttn = BMPMCC_ComponentMBOMSWhereUsedForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? BMPMCC_ComponentMBOMSWhereUsedForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
BMPMCC_ComponentMBOMSWhereUsedForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMPMCC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMPMCC] Performing VerifyExists on ComponentMBOMSWhereUsedForm...", Logger.MessageType.INF);
				SeleniumControl BMPMCC_ComponentMBOMSWhereUsedForm = new SeleniumControl( sDriver, "ComponentMBOMSWhereUsedForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BMPMCC_MFGBOM_DTL_']/ancestor::form[1]");
				Function.AssertEqual(true,BMPMCC_ComponentMBOMSWhereUsedForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMPMCC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMPMCC] Performing VerifyExists on ComponentMBOMsWhereUsed_AssemblyBOMLine_Part...", Logger.MessageType.INF);
				SeleniumControl BMPMCC_ComponentMBOMsWhereUsed_AssemblyBOMLine_Part = new SeleniumControl( sDriver, "ComponentMBOMsWhereUsed_AssemblyBOMLine_Part", "xpath", "//div[translate(@id,'0123456789','')='pr__BMPMCC_MFGBOM_DTL_']/ancestor::form[1]/descendant::*[@id='ASY_PART_ID']");
				Function.AssertEqual(true,BMPMCC_ComponentMBOMsWhereUsed_AssemblyBOMLine_Part.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMPMCC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMPMCC] Performing Close on ComponentMBOMSWhereUsedForm...", Logger.MessageType.INF);
				SeleniumControl BMPMCC_ComponentMBOMSWhereUsedForm = new SeleniumControl( sDriver, "ComponentMBOMSWhereUsedForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BMPMCC_MFGBOM_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BMPMCC_ComponentMBOMSWhereUsedForm);
IWebElement formBttn = BMPMCC_ComponentMBOMSWhereUsedForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("COMPONENT EBOMS WHERE USED");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMPMCC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMPMCC] Performing VerifyExists on ComponentEBOMsWhereUsedLink...", Logger.MessageType.INF);
				SeleniumControl BMPMCC_ComponentEBOMsWhereUsedLink = new SeleniumControl( sDriver, "ComponentEBOMsWhereUsedLink", "ID", "lnk_1004511_BMPMCC_PARAM");
				Function.AssertEqual(true,BMPMCC_ComponentEBOMsWhereUsedLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMPMCC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMPMCC] Performing Click on ComponentEBOMsWhereUsedLink...", Logger.MessageType.INF);
				SeleniumControl BMPMCC_ComponentEBOMsWhereUsedLink = new SeleniumControl( sDriver, "ComponentEBOMsWhereUsedLink", "ID", "lnk_1004511_BMPMCC_PARAM");
				Function.WaitControlDisplayed(BMPMCC_ComponentEBOMsWhereUsedLink);
BMPMCC_ComponentEBOMsWhereUsedLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMPMCC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMPMCC] Performing VerifyExist on ComponentEBOMSWhereUsedTable...", Logger.MessageType.INF);
				SeleniumControl BMPMCC_ComponentEBOMSWhereUsedTable = new SeleniumControl( sDriver, "ComponentEBOMSWhereUsedTable", "xpath", "//div[translate(@id,'0123456789','')='pr__BMPMCC_ENGBOM_DTL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BMPMCC_ComponentEBOMSWhereUsedTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMPMCC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMPMCC] Performing ClickButton on ComponentEBOMSWhereUsedForm...", Logger.MessageType.INF);
				SeleniumControl BMPMCC_ComponentEBOMSWhereUsedForm = new SeleniumControl( sDriver, "ComponentEBOMSWhereUsedForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BMPMCC_ENGBOM_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BMPMCC_ComponentEBOMSWhereUsedForm);
IWebElement formBttn = BMPMCC_ComponentEBOMSWhereUsedForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? BMPMCC_ComponentEBOMSWhereUsedForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
BMPMCC_ComponentEBOMSWhereUsedForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMPMCC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMPMCC] Performing VerifyExists on ComponentEBOMSWhereUsedForm...", Logger.MessageType.INF);
				SeleniumControl BMPMCC_ComponentEBOMSWhereUsedForm = new SeleniumControl( sDriver, "ComponentEBOMSWhereUsedForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BMPMCC_ENGBOM_DTL_']/ancestor::form[1]");
				Function.AssertEqual(true,BMPMCC_ComponentEBOMSWhereUsedForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMPMCC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMPMCC] Performing VerifyExists on ComponentEBOMsWhereUsed_AssemblyBOMLine_Part...", Logger.MessageType.INF);
				SeleniumControl BMPMCC_ComponentEBOMsWhereUsed_AssemblyBOMLine_Part = new SeleniumControl( sDriver, "ComponentEBOMsWhereUsed_AssemblyBOMLine_Part", "xpath", "//div[translate(@id,'0123456789','')='pr__BMPMCC_ENGBOM_DTL_']/ancestor::form[1]/descendant::*[@id='ASY_PART_ID']");
				Function.AssertEqual(true,BMPMCC_ComponentEBOMsWhereUsed_AssemblyBOMLine_Part.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMPMCC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMPMCC] Performing Close on ComponentEBOMSWhereUsedForm...", Logger.MessageType.INF);
				SeleniumControl BMPMCC_ComponentEBOMSWhereUsedForm = new SeleniumControl( sDriver, "ComponentEBOMSWhereUsedForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BMPMCC_ENGBOM_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BMPMCC_ComponentEBOMSWhereUsedForm);
IWebElement formBttn = BMPMCC_ComponentEBOMSWhereUsedForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("CLOSE APP");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BMPMCC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BMPMCC] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl BMPMCC_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(BMPMCC_MainForm);
IWebElement formBttn = BMPMCC_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

