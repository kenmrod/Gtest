 
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
    public class HPMEDS_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"People", "xpath","//div[@class='busItem'][.='People']").Click();
new SeleniumControl(sDriver,"Employee", "xpath","//div[@class='deptItem'][.='Employee']").Click();
new SeleniumControl(sDriver,"Basic Employee Information", "xpath","//div[@class='navItem'][.='Basic Employee Information']").Click();
new SeleniumControl(sDriver,"Manage Education, Skills & Training Data", "xpath","//div[@class='navItem'][.='Manage Education, Skills & Training Data']").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SelectMenu]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("MainForm");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMEDS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMEDS] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl HPMEDS_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,HPMEDS_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMEDS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMEDS] Performing VerifyExists on Employee...", Logger.MessageType.INF);
				SeleniumControl HPMEDS_Employee = new SeleniumControl( sDriver, "Employee", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='EMPL_ID']");
				Function.AssertEqual(true,HPMEDS_Employee.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMEDS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMEDS] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl HPMEDS_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(HPMEDS_MainForm);
IWebElement formBttn = HPMEDS_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? HPMEDS_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
HPMEDS_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMEDS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMEDS] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl HPMEDS_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,HPMEDS_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("DegreesForm");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMEDS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMEDS] Performing VerifyExists on DegreesLink...", Logger.MessageType.INF);
				SeleniumControl HPMEDS_DegreesLink = new SeleniumControl( sDriver, "DegreesLink", "ID", "lnk_1005958_HPMEDS_HEDSKILLTRAIN_HDR");
				Function.AssertEqual(true,HPMEDS_DegreesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMEDS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMEDS] Performing Click on DegreesLink...", Logger.MessageType.INF);
				SeleniumControl HPMEDS_DegreesLink = new SeleniumControl( sDriver, "DegreesLink", "ID", "lnk_1005958_HPMEDS_HEDSKILLTRAIN_HDR");
				Function.WaitControlDisplayed(HPMEDS_DegreesLink);
HPMEDS_DegreesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMEDS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMEDS] Performing VerifyExists on DegreesLinkForm...", Logger.MessageType.INF);
				SeleniumControl HPMEDS_DegreesLinkForm = new SeleniumControl( sDriver, "DegreesLinkForm", "xpath", "//div[translate(@id,'0123456789','')='pr__HPMEDS_HEMPLDEGREE_DETL_']/ancestor::form[1]");
				Function.AssertEqual(true,HPMEDS_DegreesLinkForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMEDS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMEDS] Performing VerifyExist on DegreesLinkFormTable...", Logger.MessageType.INF);
				SeleniumControl HPMEDS_DegreesLinkFormTable = new SeleniumControl( sDriver, "DegreesLinkFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__HPMEDS_HEMPLDEGREE_DETL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,HPMEDS_DegreesLinkFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMEDS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMEDS] Performing ClickButton on DegreesLinkForm...", Logger.MessageType.INF);
				SeleniumControl HPMEDS_DegreesLinkForm = new SeleniumControl( sDriver, "DegreesLinkForm", "xpath", "//div[translate(@id,'0123456789','')='pr__HPMEDS_HEMPLDEGREE_DETL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(HPMEDS_DegreesLinkForm);
IWebElement formBttn = HPMEDS_DegreesLinkForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? HPMEDS_DegreesLinkForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
HPMEDS_DegreesLinkForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMEDS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMEDS] Performing VerifyExists on Degrees_Degree...", Logger.MessageType.INF);
				SeleniumControl HPMEDS_Degrees_Degree = new SeleniumControl( sDriver, "Degrees_Degree", "xpath", "//div[translate(@id,'0123456789','')='pr__HPMEDS_HEMPLDEGREE_DETL_']/ancestor::form[1]/descendant::*[@id='DEG_ID']");
				Function.AssertEqual(true,HPMEDS_Degrees_Degree.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("CoursesLink");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMEDS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMEDS] Performing VerifyExists on CoursesLink...", Logger.MessageType.INF);
				SeleniumControl HPMEDS_CoursesLink = new SeleniumControl( sDriver, "CoursesLink", "ID", "lnk_1005959_HPMEDS_HEDSKILLTRAIN_HDR");
				Function.AssertEqual(true,HPMEDS_CoursesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMEDS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMEDS] Performing Click on CoursesLink...", Logger.MessageType.INF);
				SeleniumControl HPMEDS_CoursesLink = new SeleniumControl( sDriver, "CoursesLink", "ID", "lnk_1005959_HPMEDS_HEDSKILLTRAIN_HDR");
				Function.WaitControlDisplayed(HPMEDS_CoursesLink);
HPMEDS_CoursesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMEDS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMEDS] Performing VerifyExists on CoursesLinkForm...", Logger.MessageType.INF);
				SeleniumControl HPMEDS_CoursesLinkForm = new SeleniumControl( sDriver, "CoursesLinkForm", "xpath", "//div[translate(@id,'0123456789','')='pr__HPMEDS_HEMPLCOURSE_DETL_']/ancestor::form[1]");
				Function.AssertEqual(true,HPMEDS_CoursesLinkForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMEDS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMEDS] Performing VerifyExist on CoursesLinkFormTable...", Logger.MessageType.INF);
				SeleniumControl HPMEDS_CoursesLinkFormTable = new SeleniumControl( sDriver, "CoursesLinkFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__HPMEDS_HEMPLCOURSE_DETL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,HPMEDS_CoursesLinkFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMEDS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMEDS] Performing ClickButton on CoursesLinkForm...", Logger.MessageType.INF);
				SeleniumControl HPMEDS_CoursesLinkForm = new SeleniumControl( sDriver, "CoursesLinkForm", "xpath", "//div[translate(@id,'0123456789','')='pr__HPMEDS_HEMPLCOURSE_DETL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(HPMEDS_CoursesLinkForm);
IWebElement formBttn = HPMEDS_CoursesLinkForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? HPMEDS_CoursesLinkForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
HPMEDS_CoursesLinkForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMEDS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMEDS] Performing VerifyExists on Courses_Course...", Logger.MessageType.INF);
				SeleniumControl HPMEDS_Courses_Course = new SeleniumControl( sDriver, "Courses_Course", "xpath", "//div[translate(@id,'0123456789','')='pr__HPMEDS_HEMPLCOURSE_DETL_']/ancestor::form[1]/descendant::*[@id='COURS_ID']");
				Function.AssertEqual(true,HPMEDS_Courses_Course.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("SkillsLink");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMEDS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMEDS] Performing VerifyExists on SkillsLink...", Logger.MessageType.INF);
				SeleniumControl HPMEDS_SkillsLink = new SeleniumControl( sDriver, "SkillsLink", "ID", "lnk_1005960_HPMEDS_HEDSKILLTRAIN_HDR");
				Function.AssertEqual(true,HPMEDS_SkillsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMEDS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMEDS] Performing Click on SkillsLink...", Logger.MessageType.INF);
				SeleniumControl HPMEDS_SkillsLink = new SeleniumControl( sDriver, "SkillsLink", "ID", "lnk_1005960_HPMEDS_HEDSKILLTRAIN_HDR");
				Function.WaitControlDisplayed(HPMEDS_SkillsLink);
HPMEDS_SkillsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMEDS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMEDS] Performing VerifyExists on SkillsLinkForm...", Logger.MessageType.INF);
				SeleniumControl HPMEDS_SkillsLinkForm = new SeleniumControl( sDriver, "SkillsLinkForm", "xpath", "//div[translate(@id,'0123456789','')='pr__HPMEDS_HEMPLSKILLS_DETL_']/ancestor::form[1]");
				Function.AssertEqual(true,HPMEDS_SkillsLinkForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMEDS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMEDS] Performing VerifyExist on SkillsLinkFormTable...", Logger.MessageType.INF);
				SeleniumControl HPMEDS_SkillsLinkFormTable = new SeleniumControl( sDriver, "SkillsLinkFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__HPMEDS_HEMPLSKILLS_DETL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,HPMEDS_SkillsLinkFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMEDS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMEDS] Performing ClickButton on SkillsLinkForm...", Logger.MessageType.INF);
				SeleniumControl HPMEDS_SkillsLinkForm = new SeleniumControl( sDriver, "SkillsLinkForm", "xpath", "//div[translate(@id,'0123456789','')='pr__HPMEDS_HEMPLSKILLS_DETL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(HPMEDS_SkillsLinkForm);
IWebElement formBttn = HPMEDS_SkillsLinkForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? HPMEDS_SkillsLinkForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
HPMEDS_SkillsLinkForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMEDS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMEDS] Performing VerifyExists on Skills_Skill...", Logger.MessageType.INF);
				SeleniumControl HPMEDS_Skills_Skill = new SeleniumControl( sDriver, "Skills_Skill", "xpath", "//div[translate(@id,'0123456789','')='pr__HPMEDS_HEMPLSKILLS_DETL_']/ancestor::form[1]/descendant::*[@id='SKILL_ID']");
				Function.AssertEqual(true,HPMEDS_Skills_Skill.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("TrainingsLink");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMEDS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMEDS] Performing VerifyExists on TrainingsLink...", Logger.MessageType.INF);
				SeleniumControl HPMEDS_TrainingsLink = new SeleniumControl( sDriver, "TrainingsLink", "ID", "lnk_1005961_HPMEDS_HEDSKILLTRAIN_HDR");
				Function.AssertEqual(true,HPMEDS_TrainingsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMEDS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMEDS] Performing Click on TrainingsLink...", Logger.MessageType.INF);
				SeleniumControl HPMEDS_TrainingsLink = new SeleniumControl( sDriver, "TrainingsLink", "ID", "lnk_1005961_HPMEDS_HEDSKILLTRAIN_HDR");
				Function.WaitControlDisplayed(HPMEDS_TrainingsLink);
HPMEDS_TrainingsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMEDS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMEDS] Performing VerifyExists on TrainingsLinkForm...", Logger.MessageType.INF);
				SeleniumControl HPMEDS_TrainingsLinkForm = new SeleniumControl( sDriver, "TrainingsLinkForm", "xpath", "//div[translate(@id,'0123456789','')='pr__HPMEDS_HEMPLTRAIN_DETL_']/ancestor::form[1]");
				Function.AssertEqual(true,HPMEDS_TrainingsLinkForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMEDS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMEDS] Performing VerifyExist on TrainingsLinkFormTable...", Logger.MessageType.INF);
				SeleniumControl HPMEDS_TrainingsLinkFormTable = new SeleniumControl( sDriver, "TrainingsLinkFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__HPMEDS_HEMPLTRAIN_DETL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,HPMEDS_TrainingsLinkFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMEDS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMEDS] Performing ClickButton on TrainingsLinkForm...", Logger.MessageType.INF);
				SeleniumControl HPMEDS_TrainingsLinkForm = new SeleniumControl( sDriver, "TrainingsLinkForm", "xpath", "//div[translate(@id,'0123456789','')='pr__HPMEDS_HEMPLTRAIN_DETL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(HPMEDS_TrainingsLinkForm);
IWebElement formBttn = HPMEDS_TrainingsLinkForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? HPMEDS_TrainingsLinkForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
HPMEDS_TrainingsLinkForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMEDS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMEDS] Performing VerifyExists on Trainings_Training...", Logger.MessageType.INF);
				SeleniumControl HPMEDS_Trainings_Training = new SeleniumControl( sDriver, "Trainings_Training", "xpath", "//div[translate(@id,'0123456789','')='pr__HPMEDS_HEMPLTRAIN_DETL_']/ancestor::form[1]/descendant::*[@id='TRAIN_ID']");
				Function.AssertEqual(true,HPMEDS_Trainings_Training.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("ProfessionalOrganizationsLink");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMEDS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMEDS] Performing VerifyExists on ProfessionalOrganizationsLink...", Logger.MessageType.INF);
				SeleniumControl HPMEDS_ProfessionalOrganizationsLink = new SeleniumControl( sDriver, "ProfessionalOrganizationsLink", "ID", "lnk_1005962_HPMEDS_HEDSKILLTRAIN_HDR");
				Function.AssertEqual(true,HPMEDS_ProfessionalOrganizationsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMEDS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMEDS] Performing Click on ProfessionalOrganizationsLink...", Logger.MessageType.INF);
				SeleniumControl HPMEDS_ProfessionalOrganizationsLink = new SeleniumControl( sDriver, "ProfessionalOrganizationsLink", "ID", "lnk_1005962_HPMEDS_HEDSKILLTRAIN_HDR");
				Function.WaitControlDisplayed(HPMEDS_ProfessionalOrganizationsLink);
HPMEDS_ProfessionalOrganizationsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMEDS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMEDS] Performing VerifyExists on ProfessionalOrganizationsLinkForm...", Logger.MessageType.INF);
				SeleniumControl HPMEDS_ProfessionalOrganizationsLinkForm = new SeleniumControl( sDriver, "ProfessionalOrganizationsLinkForm", "xpath", "//div[translate(@id,'0123456789','')='pr__HPMEDS_HEMPLPROFORG_DETL_']/ancestor::form[1]");
				Function.AssertEqual(true,HPMEDS_ProfessionalOrganizationsLinkForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMEDS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMEDS] Performing VerifyExist on ProfessionalOrganizationsLinkFormTable...", Logger.MessageType.INF);
				SeleniumControl HPMEDS_ProfessionalOrganizationsLinkFormTable = new SeleniumControl( sDriver, "ProfessionalOrganizationsLinkFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__HPMEDS_HEMPLPROFORG_DETL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,HPMEDS_ProfessionalOrganizationsLinkFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMEDS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMEDS] Performing ClickButton on ProfessionalOrganizationsLinkForm...", Logger.MessageType.INF);
				SeleniumControl HPMEDS_ProfessionalOrganizationsLinkForm = new SeleniumControl( sDriver, "ProfessionalOrganizationsLinkForm", "xpath", "//div[translate(@id,'0123456789','')='pr__HPMEDS_HEMPLPROFORG_DETL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(HPMEDS_ProfessionalOrganizationsLinkForm);
IWebElement formBttn = HPMEDS_ProfessionalOrganizationsLinkForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? HPMEDS_ProfessionalOrganizationsLinkForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
HPMEDS_ProfessionalOrganizationsLinkForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMEDS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMEDS] Performing VerifyExists on ProfessionalOrganizations_ProfessionalOrganization...", Logger.MessageType.INF);
				SeleniumControl HPMEDS_ProfessionalOrganizations_ProfessionalOrganization = new SeleniumControl( sDriver, "ProfessionalOrganizations_ProfessionalOrganization", "xpath", "//div[translate(@id,'0123456789','')='pr__HPMEDS_HEMPLPROFORG_DETL_']/ancestor::form[1]/descendant::*[@id='PROF_ORG_ID']");
				Function.AssertEqual(true,HPMEDS_ProfessionalOrganizations_ProfessionalOrganization.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("CareerPlansLink");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMEDS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMEDS] Performing VerifyExists on CareerPlansLink...", Logger.MessageType.INF);
				SeleniumControl HPMEDS_CareerPlansLink = new SeleniumControl( sDriver, "CareerPlansLink", "ID", "lnk_1005963_HPMEDS_HEDSKILLTRAIN_HDR");
				Function.AssertEqual(true,HPMEDS_CareerPlansLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMEDS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMEDS] Performing Click on CareerPlansLink...", Logger.MessageType.INF);
				SeleniumControl HPMEDS_CareerPlansLink = new SeleniumControl( sDriver, "CareerPlansLink", "ID", "lnk_1005963_HPMEDS_HEDSKILLTRAIN_HDR");
				Function.WaitControlDisplayed(HPMEDS_CareerPlansLink);
HPMEDS_CareerPlansLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMEDS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMEDS] Performing VerifyExists on CareerPlansLinkForm...", Logger.MessageType.INF);
				SeleniumControl HPMEDS_CareerPlansLinkForm = new SeleniumControl( sDriver, "CareerPlansLinkForm", "xpath", "//div[translate(@id,'0123456789','')='pr__HPMEDS_HEMPLCAREERPLAN_DETL_']/ancestor::form[1]");
				Function.AssertEqual(true,HPMEDS_CareerPlansLinkForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMEDS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMEDS] Performing VerifyExist on CareerPlansLinkFormTable...", Logger.MessageType.INF);
				SeleniumControl HPMEDS_CareerPlansLinkFormTable = new SeleniumControl( sDriver, "CareerPlansLinkFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__HPMEDS_HEMPLCAREERPLAN_DETL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,HPMEDS_CareerPlansLinkFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMEDS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMEDS] Performing ClickButton on CareerPlansLinkForm...", Logger.MessageType.INF);
				SeleniumControl HPMEDS_CareerPlansLinkForm = new SeleniumControl( sDriver, "CareerPlansLinkForm", "xpath", "//div[translate(@id,'0123456789','')='pr__HPMEDS_HEMPLCAREERPLAN_DETL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(HPMEDS_CareerPlansLinkForm);
IWebElement formBttn = HPMEDS_CareerPlansLinkForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? HPMEDS_CareerPlansLinkForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
HPMEDS_CareerPlansLinkForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMEDS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMEDS] Performing VerifyExists on CareerPlans_DetailJobTitlePreferred...", Logger.MessageType.INF);
				SeleniumControl HPMEDS_CareerPlans_DetailJobTitlePreferred = new SeleniumControl( sDriver, "CareerPlans_DetailJobTitlePreferred", "xpath", "//div[translate(@id,'0123456789','')='pr__HPMEDS_HEMPLCAREERPLAN_DETL_']/ancestor::form[1]/descendant::*[@id='DETL_JOB_CD']");
				Function.AssertEqual(true,HPMEDS_CareerPlans_DetailJobTitlePreferred.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("FutureGoalsForm");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMEDS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMEDS] Performing VerifyExists on FutureGoalsForm...", Logger.MessageType.INF);
				SeleniumControl HPMEDS_FutureGoalsForm = new SeleniumControl( sDriver, "FutureGoalsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__HPMEDS_HEDSKILLTRAIN_FUTURGOAL_']/ancestor::form[1]");
				Function.AssertEqual(true,HPMEDS_FutureGoalsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMEDS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMEDS] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl HPMEDS_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(HPMEDS_MainForm);
IWebElement formBttn = HPMEDS_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

