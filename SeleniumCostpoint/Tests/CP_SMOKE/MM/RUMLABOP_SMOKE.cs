 
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
    public class RUMLABOP_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Routings", "xpath","//div[@class='deptItem'][.='Routings']").Click();
new SeleniumControl(sDriver,"Operations", "xpath","//div[@class='navItem'][.='Operations']").Click();
new SeleniumControl(sDriver,"Manage Labor Operations", "xpath","//div[@class='navItem'][.='Manage Labor Operations']").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SelectMenu]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMLABOP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMLABOP] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl RUMLABOP_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,RUMLABOP_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMLABOP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMLABOP] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl RUMLABOP_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(RUMLABOP_MainForm);
IWebElement formBttn = RUMLABOP_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? RUMLABOP_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
RUMLABOP_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMLABOP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMLABOP] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl RUMLABOP_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,RUMLABOP_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMLABOP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMLABOP] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl RUMLABOP_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(RUMLABOP_MainForm);
IWebElement formBttn = RUMLABOP_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? RUMLABOP_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
RUMLABOP_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("ACCOUNTDEFAULTS");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMLABOP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMLABOP] Performing Click on AccountDefaultsLink...", Logger.MessageType.INF);
				SeleniumControl RUMLABOP_AccountDefaultsLink = new SeleniumControl( sDriver, "AccountDefaultsLink", "ID", "lnk_16770_RUMLABOP_OPERATION_MAINTLABOPR");
				Function.WaitControlDisplayed(RUMLABOP_AccountDefaultsLink);
RUMLABOP_AccountDefaultsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMLABOP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMLABOP] Performing VerifyExist on AccountDefaults_Table...", Logger.MessageType.INF);
				SeleniumControl RUMLABOP_AccountDefaults_Table = new SeleniumControl( sDriver, "AccountDefaults_Table", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMLABOP_ACCTDEFAULTS_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,RUMLABOP_AccountDefaults_Table.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMLABOP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMLABOP] Performing Close on AccountDefaultsForm...", Logger.MessageType.INF);
				SeleniumControl RUMLABOP_AccountDefaultsForm = new SeleniumControl( sDriver, "AccountDefaultsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMLABOP_ACCTDEFAULTS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(RUMLABOP_AccountDefaultsForm);
IWebElement formBttn = RUMLABOP_AccountDefaultsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("PLCDEFAULTS");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMLABOP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMLABOP] Performing Click on PLCDefaultsLink...", Logger.MessageType.INF);
				SeleniumControl RUMLABOP_PLCDefaultsLink = new SeleniumControl( sDriver, "PLCDefaultsLink", "ID", "lnk_16088_RUMLABOP_OPERATION_MAINTLABOPR");
				Function.WaitControlDisplayed(RUMLABOP_PLCDefaultsLink);
RUMLABOP_PLCDefaultsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMLABOP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMLABOP] Performing VerifyExist on PLCDefaults_Table...", Logger.MessageType.INF);
				SeleniumControl RUMLABOP_PLCDefaults_Table = new SeleniumControl( sDriver, "PLCDefaults_Table", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMLABOP_OPERATIONPLCDEFLTS_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,RUMLABOP_PLCDefaults_Table.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMLABOP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMLABOP] Performing Close on PLCDefaultsForm...", Logger.MessageType.INF);
				SeleniumControl RUMLABOP_PLCDefaultsForm = new SeleniumControl( sDriver, "PLCDefaultsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMLABOP_OPERATIONPLCDEFLTS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(RUMLABOP_PLCDefaultsForm);
IWebElement formBttn = RUMLABOP_PLCDefaultsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("LABORRATE");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMLABOP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMLABOP] Performing Click on LaborRateLink...", Logger.MessageType.INF);
				SeleniumControl RUMLABOP_LaborRateLink = new SeleniumControl( sDriver, "LaborRateLink", "ID", "lnk_1001251_RUMLABOP_OPERATION_MAINTLABOPR");
				Function.WaitControlDisplayed(RUMLABOP_LaborRateLink);
RUMLABOP_LaborRateLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMLABOP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMLABOP] Performing VerifyExist on LaborRate_Table...", Logger.MessageType.INF);
				SeleniumControl RUMLABOP_LaborRate_Table = new SeleniumControl( sDriver, "LaborRate_Table", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMLABOP_OPERATIONRATES_MNLBOP_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,RUMLABOP_LaborRate_Table.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMLABOP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMLABOP] Performing Close on LaborRateForm...", Logger.MessageType.INF);
				SeleniumControl RUMLABOP_LaborRateForm = new SeleniumControl( sDriver, "LaborRateForm", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMLABOP_OPERATIONRATES_MNLBOP_']/ancestor::form[1]");
				Function.WaitControlDisplayed(RUMLABOP_LaborRateForm);
IWebElement formBttn = RUMLABOP_LaborRateForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("DETAIL");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMLABOP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMLABOP] Performing Click on DetailLink...", Logger.MessageType.INF);
				SeleniumControl RUMLABOP_DetailLink = new SeleniumControl( sDriver, "DetailLink", "ID", "lnk_1001252_RUMLABOP_OPERATION_MAINTLABOPR");
				Function.WaitControlDisplayed(RUMLABOP_DetailLink);
RUMLABOP_DetailLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMLABOP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMLABOP] Performing VerifyExists on LaborOperationDetailForm...", Logger.MessageType.INF);
				SeleniumControl RUMLABOP_LaborOperationDetailForm = new SeleniumControl( sDriver, "LaborOperationDetailForm", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMLABOP_OPERATIONNOTES_']/ancestor::form[1]");
				Function.AssertEqual(true,RUMLABOP_LaborOperationDetailForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMLABOP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMLABOP] Performing ClickButton on LaborOperationDetailForm...", Logger.MessageType.INF);
				SeleniumControl RUMLABOP_LaborOperationDetailForm = new SeleniumControl( sDriver, "LaborOperationDetailForm", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMLABOP_OPERATIONNOTES_']/ancestor::form[1]");
				Function.WaitControlDisplayed(RUMLABOP_LaborOperationDetailForm);
IWebElement formBttn = RUMLABOP_LaborOperationDetailForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? RUMLABOP_LaborOperationDetailForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
RUMLABOP_LaborOperationDetailForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMLABOP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMLABOP] Performing VerifyExist on LaborOperationDetail_Table...", Logger.MessageType.INF);
				SeleniumControl RUMLABOP_LaborOperationDetail_Table = new SeleniumControl( sDriver, "LaborOperationDetail_Table", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMLABOP_OPERATIONNOTES_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,RUMLABOP_LaborOperationDetail_Table.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMLABOP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMLABOP] Performing Close on LaborOperationDetailForm...", Logger.MessageType.INF);
				SeleniumControl RUMLABOP_LaborOperationDetailForm = new SeleniumControl( sDriver, "LaborOperationDetailForm", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMLABOP_OPERATIONNOTES_']/ancestor::form[1]");
				Function.WaitControlDisplayed(RUMLABOP_LaborOperationDetailForm);
IWebElement formBttn = RUMLABOP_LaborOperationDetailForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "RUMLABOP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMLABOP] Performing Click on LaborLink...", Logger.MessageType.INF);
				SeleniumControl RUMLABOP_LaborLink = new SeleniumControl( sDriver, "LaborLink", "ID", "lnk_1001253_RUMLABOP_OPERATION_MAINTLABOPR");
				Function.WaitControlDisplayed(RUMLABOP_LaborLink);
RUMLABOP_LaborLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMLABOP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMLABOP] Performing VerifyExist on LaborClassification_Table...", Logger.MessageType.INF);
				SeleniumControl RUMLABOP_LaborClassification_Table = new SeleniumControl( sDriver, "LaborClassification_Table", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMLABOP_OPERATIONLAB_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,RUMLABOP_LaborClassification_Table.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMLABOP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMLABOP] Performing ClickButton on LaborClassificationForm...", Logger.MessageType.INF);
				SeleniumControl RUMLABOP_LaborClassificationForm = new SeleniumControl( sDriver, "LaborClassificationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMLABOP_OPERATIONLAB_']/ancestor::form[1]");
				Function.WaitControlDisplayed(RUMLABOP_LaborClassificationForm);
IWebElement formBttn = RUMLABOP_LaborClassificationForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? RUMLABOP_LaborClassificationForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
RUMLABOP_LaborClassificationForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMLABOP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMLABOP] Performing VerifyExists on LaborClassificationForm...", Logger.MessageType.INF);
				SeleniumControl RUMLABOP_LaborClassificationForm = new SeleniumControl( sDriver, "LaborClassificationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMLABOP_OPERATIONLAB_']/ancestor::form[1]");
				Function.AssertEqual(true,RUMLABOP_LaborClassificationForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMLABOP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMLABOP] Performing Close on LaborClassificationForm...", Logger.MessageType.INF);
				SeleniumControl RUMLABOP_LaborClassificationForm = new SeleniumControl( sDriver, "LaborClassificationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMLABOP_OPERATIONLAB_']/ancestor::form[1]");
				Function.WaitControlDisplayed(RUMLABOP_LaborClassificationForm);
IWebElement formBttn = RUMLABOP_LaborClassificationForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("EQUIPMENT");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMLABOP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMLABOP] Performing Click on EquipmentLink...", Logger.MessageType.INF);
				SeleniumControl RUMLABOP_EquipmentLink = new SeleniumControl( sDriver, "EquipmentLink", "ID", "lnk_1001254_RUMLABOP_OPERATION_MAINTLABOPR");
				Function.WaitControlDisplayed(RUMLABOP_EquipmentLink);
RUMLABOP_EquipmentLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMLABOP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMLABOP] Performing VerifyExist on Equipment_Table...", Logger.MessageType.INF);
				SeleniumControl RUMLABOP_Equipment_Table = new SeleniumControl( sDriver, "Equipment_Table", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMLABOP_OPERATIONEQUIP_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,RUMLABOP_Equipment_Table.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMLABOP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMLABOP] Performing ClickButton on EquipmentForm...", Logger.MessageType.INF);
				SeleniumControl RUMLABOP_EquipmentForm = new SeleniumControl( sDriver, "EquipmentForm", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMLABOP_OPERATIONEQUIP_']/ancestor::form[1]");
				Function.WaitControlDisplayed(RUMLABOP_EquipmentForm);
IWebElement formBttn = RUMLABOP_EquipmentForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? RUMLABOP_EquipmentForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
RUMLABOP_EquipmentForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMLABOP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMLABOP] Performing VerifyExists on EquipmentForm...", Logger.MessageType.INF);
				SeleniumControl RUMLABOP_EquipmentForm = new SeleniumControl( sDriver, "EquipmentForm", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMLABOP_OPERATIONEQUIP_']/ancestor::form[1]");
				Function.AssertEqual(true,RUMLABOP_EquipmentForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMLABOP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMLABOP] Performing Close on EquipmentForm...", Logger.MessageType.INF);
				SeleniumControl RUMLABOP_EquipmentForm = new SeleniumControl( sDriver, "EquipmentForm", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMLABOP_OPERATIONEQUIP_']/ancestor::form[1]");
				Function.WaitControlDisplayed(RUMLABOP_EquipmentForm);
IWebElement formBttn = RUMLABOP_EquipmentForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("TEXT");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMLABOP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMLABOP] Performing Click on TextLink...", Logger.MessageType.INF);
				SeleniumControl RUMLABOP_TextLink = new SeleniumControl( sDriver, "TextLink", "ID", "lnk_5115_RUMLABOP_OPERATION_MAINTLABOPR");
				Function.WaitControlDisplayed(RUMLABOP_TextLink);
RUMLABOP_TextLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMLABOP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMLABOP] Performing VerifyExist on Text_Table...", Logger.MessageType.INF);
				SeleniumControl RUMLABOP_Text_Table = new SeleniumControl( sDriver, "Text_Table", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMLABOP_OPERATIONTEXT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,RUMLABOP_Text_Table.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMLABOP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMLABOP] Performing ClickButton on TextForm...", Logger.MessageType.INF);
				SeleniumControl RUMLABOP_TextForm = new SeleniumControl( sDriver, "TextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMLABOP_OPERATIONTEXT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(RUMLABOP_TextForm);
IWebElement formBttn = RUMLABOP_TextForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? RUMLABOP_TextForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
RUMLABOP_TextForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMLABOP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMLABOP] Performing VerifyExists on TextForm...", Logger.MessageType.INF);
				SeleniumControl RUMLABOP_TextForm = new SeleniumControl( sDriver, "TextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMLABOP_OPERATIONTEXT_']/ancestor::form[1]");
				Function.AssertEqual(true,RUMLABOP_TextForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMLABOP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMLABOP] Performing Close on TextForm...", Logger.MessageType.INF);
				SeleniumControl RUMLABOP_TextForm = new SeleniumControl( sDriver, "TextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMLABOP_OPERATIONTEXT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(RUMLABOP_TextForm);
IWebElement formBttn = RUMLABOP_TextForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMLABOP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMLABOP] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl RUMLABOP_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(RUMLABOP_MainForm);
IWebElement formBttn = RUMLABOP_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

