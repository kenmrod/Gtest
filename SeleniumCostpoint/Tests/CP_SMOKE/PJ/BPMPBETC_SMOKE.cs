 
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
    public class BPMPBETC_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Advanced Project Budgeting", "xpath","//div[@class='deptItem'][.='Advanced Project Budgeting']").Click();
new SeleniumControl(sDriver,"Project Budget and Estimate To Complete", "xpath","//div[@class='navItem'][.='Project Budget and Estimate To Complete']").Click();
new SeleniumControl(sDriver,"Manage Project Budgets and ETC", "xpath","//div[@class='navItem'][.='Manage Project Budgets and ETC']").Click();


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
				Function.CurrentComponent = "BPMPBETC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BPMPBETC] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl BPMPBETC_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,BPMPBETC_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BPMPBETC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BPMPBETC] Performing VerifyExists on Project...", Logger.MessageType.INF);
				SeleniumControl BPMPBETC_Project = new SeleniumControl( sDriver, "Project", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PROJ_ID']");
				Function.AssertEqual(true,BPMPBETC_Project.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BPMPBETC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BPMPBETC] Performing VerifyExists on TotalBudget_Quantity_Direct...", Logger.MessageType.INF);
				SeleniumControl BPMPBETC_TotalBudget_Quantity_Direct = new SeleniumControl( sDriver, "TotalBudget_Quantity_Direct", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='QNTY_DIRECT']");
				Function.AssertEqual(true,BPMPBETC_TotalBudget_Quantity_Direct.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BPMPBETC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BPMPBETC] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl BPMPBETC_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(BPMPBETC_MainForm);
IWebElement formBttn = BPMPBETC_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? BPMPBETC_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
BPMPBETC_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BPMPBETC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BPMPBETC] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl BPMPBETC_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BPMPBETC_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("ETC");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BPMPBETC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BPMPBETC] Performing VerifyExists on ETCLink...", Logger.MessageType.INF);
				SeleniumControl BPMPBETC_ETCLink = new SeleniumControl( sDriver, "ETCLink", "ID", "lnk_3377_BPMPBETC_PROJBUDGETINFO_HDRINF");
				Function.AssertEqual(true,BPMPBETC_ETCLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BPMPBETC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BPMPBETC] Performing Click on ETCLink...", Logger.MessageType.INF);
				SeleniumControl BPMPBETC_ETCLink = new SeleniumControl( sDriver, "ETCLink", "ID", "lnk_3377_BPMPBETC_PROJBUDGETINFO_HDRINF");
				Function.WaitControlDisplayed(BPMPBETC_ETCLink);
BPMPBETC_ETCLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BPMPBETC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BPMPBETC] Performing VerifyExists on ETCForm...", Logger.MessageType.INF);
				SeleniumControl BPMPBETC_ETCForm = new SeleniumControl( sDriver, "ETCForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BPMPBETC_DUMMY_ETCHDR_']/ancestor::form[1]");
				Function.AssertEqual(true,BPMPBETC_ETCForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BPMPBETC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BPMPBETC] Performing VerifyExists on ETCChildForm...", Logger.MessageType.INF);
				SeleniumControl BPMPBETC_ETCChildForm = new SeleniumControl( sDriver, "ETCChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BPMPBETC_PROJETCSUM_CHILD_']/ancestor::form[1]");
				Function.AssertEqual(true,BPMPBETC_ETCChildForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BPMPBETC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BPMPBETC] Performing VerifyExist on ETCChildTable...", Logger.MessageType.INF);
				SeleniumControl BPMPBETC_ETCChildTable = new SeleniumControl( sDriver, "ETCChildTable", "xpath", "//div[translate(@id,'0123456789','')='pr__BPMPBETC_PROJETCSUM_CHILD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BPMPBETC_ETCChildTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BPMPBETC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BPMPBETC] Performing Close on ETCForm...", Logger.MessageType.INF);
				SeleniumControl BPMPBETC_ETCForm = new SeleniumControl( sDriver, "ETCForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BPMPBETC_DUMMY_ETCHDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BPMPBETC_ETCForm);
IWebElement formBttn = BPMPBETC_ETCForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("INDIRECT");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BPMPBETC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BPMPBETC] Performing VerifyExists on IndirectLink...", Logger.MessageType.INF);
				SeleniumControl BPMPBETC_IndirectLink = new SeleniumControl( sDriver, "IndirectLink", "ID", "lnk_1002590_BPMPBETC_PROJBUDGETINFO_HDRINF");
				Function.AssertEqual(true,BPMPBETC_IndirectLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BPMPBETC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BPMPBETC] Performing Click on IndirectLink...", Logger.MessageType.INF);
				SeleniumControl BPMPBETC_IndirectLink = new SeleniumControl( sDriver, "IndirectLink", "ID", "lnk_1002590_BPMPBETC_PROJBUDGETINFO_HDRINF");
				Function.WaitControlDisplayed(BPMPBETC_IndirectLink);
BPMPBETC_IndirectLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BPMPBETC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BPMPBETC] Performing VerifyExist on IndirectTable...", Logger.MessageType.INF);
				SeleniumControl BPMPBETC_IndirectTable = new SeleniumControl( sDriver, "IndirectTable", "xpath", "//div[translate(@id,'0123456789','')='pr__BPMPBETC_PROJBUDGETINDIR_INDIR_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BPMPBETC_IndirectTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BPMPBETC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BPMPBETC] Performing ClickButton on IndirectForm...", Logger.MessageType.INF);
				SeleniumControl BPMPBETC_IndirectForm = new SeleniumControl( sDriver, "IndirectForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BPMPBETC_PROJBUDGETINDIR_INDIR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BPMPBETC_IndirectForm);
IWebElement formBttn = BPMPBETC_IndirectForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? BPMPBETC_IndirectForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
BPMPBETC_IndirectForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BPMPBETC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BPMPBETC] Performing VerifyExists on IndirectForm...", Logger.MessageType.INF);
				SeleniumControl BPMPBETC_IndirectForm = new SeleniumControl( sDriver, "IndirectForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BPMPBETC_PROJBUDGETINDIR_INDIR_']/ancestor::form[1]");
				Function.AssertEqual(true,BPMPBETC_IndirectForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BPMPBETC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BPMPBETC] Performing VerifyExists on Indirect_Organization_Organization...", Logger.MessageType.INF);
				SeleniumControl BPMPBETC_Indirect_Organization_Organization = new SeleniumControl( sDriver, "Indirect_Organization_Organization", "xpath", "//div[translate(@id,'0123456789','')='pr__BPMPBETC_PROJBUDGETINDIR_INDIR_']/ancestor::form[1]/descendant::*[@id='ORG_ID']");
				Function.AssertEqual(true,BPMPBETC_Indirect_Organization_Organization.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BPMPBETC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BPMPBETC] Performing Close on IndirectForm...", Logger.MessageType.INF);
				SeleniumControl BPMPBETC_IndirectForm = new SeleniumControl( sDriver, "IndirectForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BPMPBETC_PROJBUDGETINDIR_INDIR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BPMPBETC_IndirectForm);
IWebElement formBttn = BPMPBETC_IndirectForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("FEES");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BPMPBETC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BPMPBETC] Performing VerifyExists on FeesLink...", Logger.MessageType.INF);
				SeleniumControl BPMPBETC_FeesLink = new SeleniumControl( sDriver, "FeesLink", "ID", "lnk_1002591_BPMPBETC_PROJBUDGETINFO_HDRINF");
				Function.AssertEqual(true,BPMPBETC_FeesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BPMPBETC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BPMPBETC] Performing Click on FeesLink...", Logger.MessageType.INF);
				SeleniumControl BPMPBETC_FeesLink = new SeleniumControl( sDriver, "FeesLink", "ID", "lnk_1002591_BPMPBETC_PROJBUDGETINFO_HDRINF");
				Function.WaitControlDisplayed(BPMPBETC_FeesLink);
BPMPBETC_FeesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BPMPBETC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BPMPBETC] Performing VerifyExists on FeesForm...", Logger.MessageType.INF);
				SeleniumControl BPMPBETC_FeesForm = new SeleniumControl( sDriver, "FeesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BPMPBETC_PROJBUDGETFEE_CHILD_']/ancestor::form[1]");
				Function.AssertEqual(true,BPMPBETC_FeesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BPMPBETC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BPMPBETC] Performing VerifyExist on FeesTable...", Logger.MessageType.INF);
				SeleniumControl BPMPBETC_FeesTable = new SeleniumControl( sDriver, "FeesTable", "xpath", "//div[translate(@id,'0123456789','')='pr__BPMPBETC_PROJBUDGETFEE_CHILD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BPMPBETC_FeesTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BPMPBETC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BPMPBETC] Performing Close on FeesForm...", Logger.MessageType.INF);
				SeleniumControl BPMPBETC_FeesForm = new SeleniumControl( sDriver, "FeesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BPMPBETC_PROJBUDGETFEE_CHILD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BPMPBETC_FeesForm);
IWebElement formBttn = BPMPBETC_FeesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("UNITS");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BPMPBETC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BPMPBETC] Performing VerifyExists on UnitsLink...", Logger.MessageType.INF);
				SeleniumControl BPMPBETC_UnitsLink = new SeleniumControl( sDriver, "UnitsLink", "ID", "lnk_1002592_BPMPBETC_PROJBUDGETINFO_HDRINF");
				Function.AssertEqual(true,BPMPBETC_UnitsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BPMPBETC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BPMPBETC] Performing Click on UnitsLink...", Logger.MessageType.INF);
				SeleniumControl BPMPBETC_UnitsLink = new SeleniumControl( sDriver, "UnitsLink", "ID", "lnk_1002592_BPMPBETC_PROJBUDGETINFO_HDRINF");
				Function.WaitControlDisplayed(BPMPBETC_UnitsLink);
BPMPBETC_UnitsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BPMPBETC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BPMPBETC] Performing VerifyExists on UnitsForm...", Logger.MessageType.INF);
				SeleniumControl BPMPBETC_UnitsForm = new SeleniumControl( sDriver, "UnitsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BPMPBETC_PROJBUDGETUNITS_UNITS_']/ancestor::form[1]");
				Function.AssertEqual(true,BPMPBETC_UnitsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BPMPBETC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BPMPBETC] Performing VerifyExist on UnitsTable...", Logger.MessageType.INF);
				SeleniumControl BPMPBETC_UnitsTable = new SeleniumControl( sDriver, "UnitsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__BPMPBETC_PROJBUDGETUNITS_UNITS_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BPMPBETC_UnitsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BPMPBETC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BPMPBETC] Performing Close on UnitsForm...", Logger.MessageType.INF);
				SeleniumControl BPMPBETC_UnitsForm = new SeleniumControl( sDriver, "UnitsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BPMPBETC_PROJBUDGETUNITS_UNITS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BPMPBETC_UnitsForm);
IWebElement formBttn = BPMPBETC_UnitsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("LABOR");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BPMPBETC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BPMPBETC] Performing VerifyExists on LaborLink...", Logger.MessageType.INF);
				SeleniumControl BPMPBETC_LaborLink = new SeleniumControl( sDriver, "LaborLink", "ID", "lnk_1002594_BPMPBETC_PROJBUDGETINFO_HDRINF");
				Function.AssertEqual(true,BPMPBETC_LaborLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BPMPBETC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BPMPBETC] Performing Click on LaborLink...", Logger.MessageType.INF);
				SeleniumControl BPMPBETC_LaborLink = new SeleniumControl( sDriver, "LaborLink", "ID", "lnk_1002594_BPMPBETC_PROJBUDGETINFO_HDRINF");
				Function.WaitControlDisplayed(BPMPBETC_LaborLink);
BPMPBETC_LaborLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BPMPBETC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BPMPBETC] Performing VerifyExists on LaborForm...", Logger.MessageType.INF);
				SeleniumControl BPMPBETC_LaborForm = new SeleniumControl( sDriver, "LaborForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BPMPBETC_PROJBUDGETLABOR_LABOR_']/ancestor::form[1]");
				Function.AssertEqual(true,BPMPBETC_LaborForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BPMPBETC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BPMPBETC] Performing VerifyExist on LaborTable...", Logger.MessageType.INF);
				SeleniumControl BPMPBETC_LaborTable = new SeleniumControl( sDriver, "LaborTable", "xpath", "//div[translate(@id,'0123456789','')='pr__BPMPBETC_PROJBUDGETLABOR_LABOR_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BPMPBETC_LaborTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BPMPBETC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BPMPBETC] Performing Close on LaborForm...", Logger.MessageType.INF);
				SeleniumControl BPMPBETC_LaborForm = new SeleniumControl( sDriver, "LaborForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BPMPBETC_PROJBUDGETLABOR_LABOR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BPMPBETC_LaborForm);
IWebElement formBttn = BPMPBETC_LaborForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("DIRECT");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BPMPBETC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BPMPBETC] Performing VerifyExists on DirectLink...", Logger.MessageType.INF);
				SeleniumControl BPMPBETC_DirectLink = new SeleniumControl( sDriver, "DirectLink", "ID", "lnk_1002596_BPMPBETC_PROJBUDGETINFO_HDRINF");
				Function.AssertEqual(true,BPMPBETC_DirectLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BPMPBETC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BPMPBETC] Performing Click on DirectLink...", Logger.MessageType.INF);
				SeleniumControl BPMPBETC_DirectLink = new SeleniumControl( sDriver, "DirectLink", "ID", "lnk_1002596_BPMPBETC_PROJBUDGETINFO_HDRINF");
				Function.WaitControlDisplayed(BPMPBETC_DirectLink);
BPMPBETC_DirectLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BPMPBETC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BPMPBETC] Performing VerifyExists on DirectForm...", Logger.MessageType.INF);
				SeleniumControl BPMPBETC_DirectForm = new SeleniumControl( sDriver, "DirectForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BPMPBETC_PROJBUDGETDIRECT_DIR_']/ancestor::form[1]");
				Function.AssertEqual(true,BPMPBETC_DirectForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BPMPBETC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BPMPBETC] Performing VerifyExist on DirectTable...", Logger.MessageType.INF);
				SeleniumControl BPMPBETC_DirectTable = new SeleniumControl( sDriver, "DirectTable", "xpath", "//div[translate(@id,'0123456789','')='pr__BPMPBETC_PROJBUDGETDIRECT_DIR_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BPMPBETC_DirectTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BPMPBETC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BPMPBETC] Performing Close on DirectForm...", Logger.MessageType.INF);
				SeleniumControl BPMPBETC_DirectForm = new SeleniumControl( sDriver, "DirectForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BPMPBETC_PROJBUDGETDIRECT_DIR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BPMPBETC_DirectForm);
IWebElement formBttn = BPMPBETC_DirectForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "BPMPBETC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BPMPBETC] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl BPMPBETC_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(BPMPBETC_MainForm);
IWebElement formBttn = BPMPBETC_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

