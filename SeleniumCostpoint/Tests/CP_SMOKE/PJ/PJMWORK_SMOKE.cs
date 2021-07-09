 
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
    public class PJMWORK_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Manage Employee Work Force", "xpath","//div[@class='navItem'][.='Manage Employee Work Force']").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SelectMenu]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Query an existing record");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMWORK";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMWORK] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl PJMWORK_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PJMWORK_MainForm);
IWebElement formBttn = PJMWORK_MainForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).Count <= 0 ? PJMWORK_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Query')]")).FirstOrDefault() :
PJMWORK_MainForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).FirstOrDefault();
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
				this.ScriptLogger.WriteLine("Main Form");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMWORK";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMWORK] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl PJMWORK_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJMWORK_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMWORK";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMWORK] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl PJMWORK_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PJMWORK_MainForm);
IWebElement formBttn = PJMWORK_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PJMWORK_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PJMWORK_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMWORK";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMWORK] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl PJMWORK_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,PJMWORK_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMWORK";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMWORK] Performing VerifyExists on Identification_Project...", Logger.MessageType.INF);
				SeleniumControl PJMWORK_Identification_Project = new SeleniumControl( sDriver, "Identification_Project", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PROJ_ID']");
				Function.AssertEqual(true,PJMWORK_Identification_Project.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Employees");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("SelectedEmployees");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMWORK";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMWORK] Performing VerifyExists on SelectedEmployeesForm...", Logger.MessageType.INF);
				SeleniumControl PJMWORK_SelectedEmployeesForm = new SeleniumControl( sDriver, "SelectedEmployeesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJM_PROJEMPL_CHILDTO_']/ancestor::form[1]");
				Function.AssertEqual(true,PJMWORK_SelectedEmployeesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMWORK";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMWORK] Performing VerifyExist on SelectedEmployees_Table...", Logger.MessageType.INF);
				SeleniumControl PJMWORK_SelectedEmployees_Table = new SeleniumControl( sDriver, "SelectedEmployees_Table", "xpath", "//div[translate(@id,'0123456789','')='pr__PJM_PROJEMPL_CHILDTO_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJMWORK_SelectedEmployees_Table.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
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
				Function.CurrentComponent = "PJMWORK";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMWORK] Performing VerifyExists on SelectedEmployees_AssignPLCToEmployeeWorkForceLink...", Logger.MessageType.INF);
				SeleniumControl PJMWORK_SelectedEmployees_AssignPLCToEmployeeWorkForceLink = new SeleniumControl( sDriver, "SelectedEmployees_AssignPLCToEmployeeWorkForceLink", "ID", "lnk_17452_PJM_PROJEMPL_HDR");
				Function.AssertEqual(true,PJMWORK_SelectedEmployees_AssignPLCToEmployeeWorkForceLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMWORK";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMWORK] Performing Click on SelectedEmployees_AssignPLCToEmployeeWorkForceLink...", Logger.MessageType.INF);
				SeleniumControl PJMWORK_SelectedEmployees_AssignPLCToEmployeeWorkForceLink = new SeleniumControl( sDriver, "SelectedEmployees_AssignPLCToEmployeeWorkForceLink", "ID", "lnk_17452_PJM_PROJEMPL_HDR");
				Function.WaitControlDisplayed(PJMWORK_SelectedEmployees_AssignPLCToEmployeeWorkForceLink);
PJMWORK_SelectedEmployees_AssignPLCToEmployeeWorkForceLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("AssignPLCToEmployeeWorkForce_PLCs");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMWORK";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMWORK] Performing VerifyExists on AssignPLCToEmployeeWorkForce_PLCsForm...", Logger.MessageType.INF);
				SeleniumControl PJMWORK_AssignPLCToEmployeeWorkForce_PLCsForm = new SeleniumControl( sDriver, "AssignPLCToEmployeeWorkForce_PLCsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJM_PROJEMPLLABCAT_PLC_']/ancestor::form[1]");
				Function.AssertEqual(true,PJMWORK_AssignPLCToEmployeeWorkForce_PLCsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMWORK";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMWORK] Performing VerifyExist on AssignPLCToEmployeeWorkForce_PLCsFormTable...", Logger.MessageType.INF);
				SeleniumControl PJMWORK_AssignPLCToEmployeeWorkForce_PLCsFormTable = new SeleniumControl( sDriver, "AssignPLCToEmployeeWorkForce_PLCsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PJM_PROJEMPLLABCAT_PLC_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJMWORK_AssignPLCToEmployeeWorkForce_PLCsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("AssignPLCToEmployeeWorkForce_SelectedEmployees");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMWORK";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMWORK] Performing VerifyExists on AssignPLCToEmployeeWorkForce_SelectedEmployeesForm...", Logger.MessageType.INF);
				SeleniumControl PJMWORK_AssignPLCToEmployeeWorkForce_SelectedEmployeesForm = new SeleniumControl( sDriver, "AssignPLCToEmployeeWorkForce_SelectedEmployeesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJM_PROJEMPLLABCAT_EMPL_']/ancestor::form[1]");
				Function.AssertEqual(true,PJMWORK_AssignPLCToEmployeeWorkForce_SelectedEmployeesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMWORK";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMWORK] Performing VerifyExist on AssignPLCToEmployeeWorkForce_SelectedEmployeesFormTable...", Logger.MessageType.INF);
				SeleniumControl PJMWORK_AssignPLCToEmployeeWorkForce_SelectedEmployeesFormTable = new SeleniumControl( sDriver, "AssignPLCToEmployeeWorkForce_SelectedEmployeesFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PJM_PROJEMPLLABCAT_EMPL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJMWORK_AssignPLCToEmployeeWorkForce_SelectedEmployeesFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("AssignPLCToEmployeeWorkForce");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMWORK";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMWORK] Performing VerifyExists on AssignPLCToEmployeeWorkForceForm...", Logger.MessageType.INF);
				SeleniumControl PJMWORK_AssignPLCToEmployeeWorkForceForm = new SeleniumControl( sDriver, "AssignPLCToEmployeeWorkForceForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJM_PROJEMPL_LABCAT_PLCWKFRCE_']/ancestor::form[1]");
				Function.AssertEqual(true,PJMWORK_AssignPLCToEmployeeWorkForceForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMWORK";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMWORK] Performing VerifyExist on AssignPLCtoEmployeeWorkForce_PLCsAssignedToEmployeeWorkForceTable...", Logger.MessageType.INF);
				SeleniumControl PJMWORK_AssignPLCtoEmployeeWorkForce_PLCsAssignedToEmployeeWorkForceTable = new SeleniumControl( sDriver, "AssignPLCtoEmployeeWorkForce_PLCsAssignedToEmployeeWorkForceTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PJM_PROJEMPLLABCAT_PLCWK_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJMWORK_AssignPLCtoEmployeeWorkForce_PLCsAssignedToEmployeeWorkForceTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMWORK";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMWORK] Performing ClickButton on AssignPLCToEmployeeWorkForce_PLCsAssignedToEmployeeWorkForceForm...", Logger.MessageType.INF);
				SeleniumControl PJMWORK_AssignPLCToEmployeeWorkForce_PLCsAssignedToEmployeeWorkForceForm = new SeleniumControl( sDriver, "AssignPLCToEmployeeWorkForce_PLCsAssignedToEmployeeWorkForceForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJM_PROJEMPLLABCAT_PLCWK_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJMWORK_AssignPLCToEmployeeWorkForce_PLCsAssignedToEmployeeWorkForceForm);
IWebElement formBttn = PJMWORK_AssignPLCToEmployeeWorkForce_PLCsAssignedToEmployeeWorkForceForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PJMWORK_AssignPLCToEmployeeWorkForce_PLCsAssignedToEmployeeWorkForceForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PJMWORK_AssignPLCToEmployeeWorkForce_PLCsAssignedToEmployeeWorkForceForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMWORK";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMWORK] Performing VerifyExists on AssignPLCtoEmployeeWorkForce_AssignPLCToEmployeeWorkForce_Employee...", Logger.MessageType.INF);
				SeleniumControl PJMWORK_AssignPLCtoEmployeeWorkForce_AssignPLCToEmployeeWorkForce_Employee = new SeleniumControl( sDriver, "AssignPLCtoEmployeeWorkForce_AssignPLCToEmployeeWorkForce_Employee", "xpath", "//div[translate(@id,'0123456789','')='pr__PJM_PROJEMPLLABCAT_PLCWK_']/ancestor::form[1]/descendant::*[@id='EMPL_ID']");
				Function.AssertEqual(true,PJMWORK_AssignPLCtoEmployeeWorkForce_AssignPLCToEmployeeWorkForce_Employee.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Closing App");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMWORK";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMWORK] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl PJMWORK_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PJMWORK_MainForm);
IWebElement formBttn = PJMWORK_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

