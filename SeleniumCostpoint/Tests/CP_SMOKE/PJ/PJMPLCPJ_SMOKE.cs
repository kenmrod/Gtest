 
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
    public class PJMPLCPJ_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Projects", "xpath","//div[@class='busItem'][.='Projects']").Click();
new SeleniumControl(sDriver,"Project Setup", "xpath","//div[@class='deptItem'][.='Project Setup']").Click();
new SeleniumControl(sDriver,"Project Labor", "xpath","//div[@class='navItem'][.='Project Labor']").Click();
new SeleniumControl(sDriver,"Link Project Labor Categories to Projects", "xpath","//div[@class='navItem'][.='Link Project Labor Categories to Projects']").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SelectMenu]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("QUERY");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPLCPJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPLCPJ] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl PJMPLCPJ_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PJMPLCPJ_MainForm);
IWebElement formBttn = PJMPLCPJ_MainForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).Count <= 0 ? PJMPLCPJ_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Query')]")).FirstOrDefault() :
PJMPLCPJ_MainForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Query not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "Query";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[Query] Performing Click on Find...", Logger.MessageType.INF);
				SeleniumControl Query_Find = new SeleniumControl( sDriver, "Find", "ID", "submitQ");
				Function.WaitControlDisplayed(Query_Find);
if (Query_Find.mElement.GetAttribute("class") == "popupBtn" && sDriver.BrowserType == "ie")
Query_Find.Click(5,5);
else Query_Find.Click(4.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
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
				Function.CurrentComponent = "PJMPLCPJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPLCPJ] Performing VerifyExist on MainTable...", Logger.MessageType.INF);
				SeleniumControl PJMPLCPJ_MainTable = new SeleniumControl( sDriver, "MainTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJMPLCPJ_MainTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPLCPJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPLCPJ] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl PJMPLCPJ_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PJMPLCPJ_MainForm);
IWebElement formBttn = PJMPLCPJ_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PJMPLCPJ_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PJMPLCPJ_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPLCPJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPLCPJ] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl PJMPLCPJ_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,PJMPLCPJ_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPLCPJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPLCPJ] Performing VerifyExists on Project...", Logger.MessageType.INF);
				SeleniumControl PJMPLCPJ_Project = new SeleniumControl( sDriver, "Project", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PROJ_ID']");
				Function.AssertEqual(true,PJMPLCPJ_Project.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPLCPJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPLCPJ] Performing VerifyExist on ProjectLaborCategoriesTable...", Logger.MessageType.INF);
				SeleniumControl PJMPLCPJ_ProjectLaborCategoriesTable = new SeleniumControl( sDriver, "ProjectLaborCategoriesTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PJM_BILLLABCAT_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJMPLCPJ_ProjectLaborCategoriesTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPLCPJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPLCPJ] Performing VerifyExist on AssignPLCTable...", Logger.MessageType.INF);
				SeleniumControl PJMPLCPJ_AssignPLCTable = new SeleniumControl( sDriver, "AssignPLCTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PJM_PROJLABCAT_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJMPLCPJ_AssignPLCTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPLCPJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPLCPJ] Performing VerifyExists on AssignPLC_LinkGLCToProjectPLCLink...", Logger.MessageType.INF);
				SeleniumControl PJMPLCPJ_AssignPLC_LinkGLCToProjectPLCLink = new SeleniumControl( sDriver, "AssignPLC_LinkGLCToProjectPLCLink", "ID", "lnk_1007349_PJM_PROJLABCAT_CTW");
				Function.AssertEqual(true,PJMPLCPJ_AssignPLC_LinkGLCToProjectPLCLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPLCPJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPLCPJ] Performing Click on AssignPLC_LinkGLCToProjectPLCLink...", Logger.MessageType.INF);
				SeleniumControl PJMPLCPJ_AssignPLC_LinkGLCToProjectPLCLink = new SeleniumControl( sDriver, "AssignPLC_LinkGLCToProjectPLCLink", "ID", "lnk_1007349_PJM_PROJLABCAT_CTW");
				Function.WaitControlDisplayed(PJMPLCPJ_AssignPLC_LinkGLCToProjectPLCLink);
PJMPLCPJ_AssignPLC_LinkGLCToProjectPLCLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPLCPJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPLCPJ] Performing VerifyExist on GeneralLaborCategoriesTable...", Logger.MessageType.INF);
				SeleniumControl PJMPLCPJ_GeneralLaborCategoriesTable = new SeleniumControl( sDriver, "GeneralLaborCategoriesTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PJM_GENLLABCAT_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJMPLCPJ_GeneralLaborCategoriesTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPLCPJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPLCPJ] Performing VerifyExists on LinkedGLCtoProjectPLCForm...", Logger.MessageType.INF);
				SeleniumControl PJMPLCPJ_LinkedGLCtoProjectPLCForm = new SeleniumControl( sDriver, "LinkedGLCtoProjectPLCForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJM_PROJLABCATMAP_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,PJMPLCPJ_LinkedGLCtoProjectPLCForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPLCPJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPLCPJ] Performing VerifyExists on LinkedGLCsLink...", Logger.MessageType.INF);
				SeleniumControl PJMPLCPJ_LinkedGLCsLink = new SeleniumControl( sDriver, "LinkedGLCsLink", "ID", "lnk_1007353_PJM_PROJLABCAT_HDR");
				Function.AssertEqual(true,PJMPLCPJ_LinkedGLCsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPLCPJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPLCPJ] Performing Click on LinkedGLCsLink...", Logger.MessageType.INF);
				SeleniumControl PJMPLCPJ_LinkedGLCsLink = new SeleniumControl( sDriver, "LinkedGLCsLink", "ID", "lnk_1007353_PJM_PROJLABCAT_HDR");
				Function.WaitControlDisplayed(PJMPLCPJ_LinkedGLCsLink);
PJMPLCPJ_LinkedGLCsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPLCPJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPLCPJ] Performing VerifyExist on LinkedGLCTable...", Logger.MessageType.INF);
				SeleniumControl PJMPLCPJ_LinkedGLCTable = new SeleniumControl( sDriver, "LinkedGLCTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PJM_PROJLABCATMAPPLC_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJMPLCPJ_LinkedGLCTable.Exists());

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
				Function.CurrentComponent = "PJMPLCPJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPLCPJ] Performing Close on LinkedGLCForm...", Logger.MessageType.INF);
				SeleniumControl PJMPLCPJ_LinkedGLCForm = new SeleniumControl( sDriver, "LinkedGLCForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJM_PROJLABCATMAPPLC_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJMPLCPJ_LinkedGLCForm);
IWebElement formBttn = PJMPLCPJ_LinkedGLCForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPLCPJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPLCPJ] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl PJMPLCPJ_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PJMPLCPJ_MainForm);
IWebElement formBttn = PJMPLCPJ_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

