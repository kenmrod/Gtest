 
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
    public class IWMALLOC_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Inter-Company Work Orders", "xpath","//div[@class='deptItem'][.='Inter-Company Work Orders']").Click();
new SeleniumControl(sDriver,"Inter-Company Work Orders Processing", "xpath","//div[@class='navItem'][.='Inter-Company Work Orders Processing']").Click();
new SeleniumControl(sDriver,"Manage IWO Allocations", "xpath","//div[@class='navItem'][.='Manage IWO Allocations']").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SelectMenu]" , ex.Message));
				}
								try
				{
				Function.Wait(10);


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Wait]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "Query";
								Function.WaitControlDisplayed(new SeleniumControl(sDriver,"QueryTitle", "ID", "qryHeaderLabel"));
Function.AssertEqual("Manage IWO Allocations", new SeleniumControl(sDriver,"QueryTitle", "ID", "qryHeaderLabel").GetValue().Trim());


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyTitle]" , ex.Message));
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
								try {
				Function.CurrentComponent = "IWMALLOC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[IWMALLOC] Performing ClickButtonIfExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl IWMALLOC_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(IWMALLOC_MainForm);
IWebElement formBttn = IWMALLOC_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? IWMALLOC_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
IWMALLOC_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault();
if (formBttn!=null && formBttn.Displayed)
{ new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click();
this.ScriptLogger.WriteLine("Button [Table] found and clicked.", Logger.MessageType.INF);
}


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButtonIfExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "IWMALLOC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[IWMALLOC] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl IWMALLOC_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,IWMALLOC_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "IWMALLOC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[IWMALLOC] Performing ClickButtonIfExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl IWMALLOC_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(IWMALLOC_MainForm);
IWebElement formBttn = IWMALLOC_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? IWMALLOC_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
IWMALLOC_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault();
if (formBttn!=null && formBttn.Displayed)
{ new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click();
this.ScriptLogger.WriteLine("Button [Form] found and clicked.", Logger.MessageType.INF);
}


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButtonIfExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "IWMALLOC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[IWMALLOC] Performing ClickButtonIfExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl IWMALLOC_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(IWMALLOC_MainForm);
IWebElement formBttn = IWMALLOC_MainForm.mElement.FindElements(By.CssSelector("*[title*='Next']")).Count <= 0 ? IWMALLOC_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Next')]")).FirstOrDefault() :
IWMALLOC_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Next')]")).FirstOrDefault();
if (formBttn!=null && formBttn.Displayed)
{ new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click();
this.ScriptLogger.WriteLine("Button [Next] found and clicked.", Logger.MessageType.INF);
}


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButtonIfExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "IWMALLOC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[IWMALLOC] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl IWMALLOC_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,IWMALLOC_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "IWMALLOC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[IWMALLOC] Performing VerifyExists on IWONumber...", Logger.MessageType.INF);
				SeleniumControl IWMALLOC_IWONumber = new SeleniumControl( sDriver, "IWONumber", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='IWO_NO']");
				Function.AssertEqual(true,IWMALLOC_IWONumber.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("ALLOCATION DETAIL");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "IWMALLOC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[IWMALLOC] Performing VerifyExists on AllocationDetailLink...", Logger.MessageType.INF);
				SeleniumControl IWMALLOC_AllocationDetailLink = new SeleniumControl( sDriver, "AllocationDetailLink", "ID", "lnk_1002109_IWMALLOC_IWOALLOCHDR_HDR");
				Function.AssertEqual(true,IWMALLOC_AllocationDetailLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "IWMALLOC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[IWMALLOC] Performing ClickButtonIfExists on AllocationDetailForm...", Logger.MessageType.INF);
				SeleniumControl IWMALLOC_AllocationDetailForm = new SeleniumControl( sDriver, "AllocationDetailForm", "xpath", "//div[translate(@id,'0123456789','')='pr__IWMALLOC_IWOALLOCTRN_CHLD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(IWMALLOC_AllocationDetailForm);
IWebElement formBttn = IWMALLOC_AllocationDetailForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? IWMALLOC_AllocationDetailForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
IWMALLOC_AllocationDetailForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault();
if (formBttn!=null && formBttn.Displayed)
{ new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click();
this.ScriptLogger.WriteLine("Button [Table] found and clicked.", Logger.MessageType.INF);
}


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButtonIfExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "IWMALLOC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[IWMALLOC] Performing VerifyExist on AllocationDetailFormTable...", Logger.MessageType.INF);
				SeleniumControl IWMALLOC_AllocationDetailFormTable = new SeleniumControl( sDriver, "AllocationDetailFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__IWMALLOC_IWOALLOCTRN_CHLD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,IWMALLOC_AllocationDetailFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "IWMALLOC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[IWMALLOC] Performing ClickButtonIfExists on AllocationDetailForm...", Logger.MessageType.INF);
				SeleniumControl IWMALLOC_AllocationDetailForm = new SeleniumControl( sDriver, "AllocationDetailForm", "xpath", "//div[translate(@id,'0123456789','')='pr__IWMALLOC_IWOALLOCTRN_CHLD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(IWMALLOC_AllocationDetailForm);
IWebElement formBttn = IWMALLOC_AllocationDetailForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? IWMALLOC_AllocationDetailForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
IWMALLOC_AllocationDetailForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault();
if (formBttn!=null && formBttn.Displayed)
{ new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click();
this.ScriptLogger.WriteLine("Button [Form] found and clicked.", Logger.MessageType.INF);
}


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButtonIfExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "IWMALLOC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[IWMALLOC] Performing VerifyExists on AllocationDetailForm...", Logger.MessageType.INF);
				SeleniumControl IWMALLOC_AllocationDetailForm = new SeleniumControl( sDriver, "AllocationDetailForm", "xpath", "//div[translate(@id,'0123456789','')='pr__IWMALLOC_IWOALLOCTRN_CHLD_']/ancestor::form[1]");
				Function.AssertEqual(true,IWMALLOC_AllocationDetailForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "IWMALLOC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[IWMALLOC] Performing VerifyExists on AllocationDetail_Line...", Logger.MessageType.INF);
				SeleniumControl IWMALLOC_AllocationDetail_Line = new SeleniumControl( sDriver, "AllocationDetail_Line", "xpath", "//div[translate(@id,'0123456789','')='pr__IWMALLOC_IWOALLOCTRN_CHLD_']/ancestor::form[1]/descendant::*[@id='IWO_LN_NO']");
				Function.AssertEqual(true,IWMALLOC_AllocationDetail_Line.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("LABOR DETAIL");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "IWMALLOC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[IWMALLOC] Performing ClickButtonIfExists on AllocationDetailForm...", Logger.MessageType.INF);
				SeleniumControl IWMALLOC_AllocationDetailForm = new SeleniumControl( sDriver, "AllocationDetailForm", "xpath", "//div[translate(@id,'0123456789','')='pr__IWMALLOC_IWOALLOCTRN_CHLD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(IWMALLOC_AllocationDetailForm);
IWebElement formBttn = IWMALLOC_AllocationDetailForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).Count <= 0 ? IWMALLOC_AllocationDetailForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Query')]")).FirstOrDefault() :
IWMALLOC_AllocationDetailForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Query')]")).FirstOrDefault();
if (formBttn!=null && formBttn.Displayed)
{ new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click();
this.ScriptLogger.WriteLine("Button [Query] found and clicked.", Logger.MessageType.INF);
}


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButtonIfExists]" , ex.Message));
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
								try {
				Function.CurrentComponent = "IWMALLOC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[IWMALLOC] Performing VerifyExists on AllocationDetail_LaborDetailLink...", Logger.MessageType.INF);
				SeleniumControl IWMALLOC_AllocationDetail_LaborDetailLink = new SeleniumControl( sDriver, "AllocationDetail_LaborDetailLink", "ID", "lnk_1002110_IWMALLOC_IWOALLOCTRN_CHLD");
				Function.AssertEqual(true,IWMALLOC_AllocationDetail_LaborDetailLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "IWMALLOC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[IWMALLOC] Performing Click on AllocationDetail_LaborDetailLink...", Logger.MessageType.INF);
				SeleniumControl IWMALLOC_AllocationDetail_LaborDetailLink = new SeleniumControl( sDriver, "AllocationDetail_LaborDetailLink", "ID", "lnk_1002110_IWMALLOC_IWOALLOCTRN_CHLD");
				Function.WaitControlDisplayed(IWMALLOC_AllocationDetail_LaborDetailLink);
IWMALLOC_AllocationDetail_LaborDetailLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "IWMALLOC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[IWMALLOC] Performing ClickButtonIfExists on AllocationDetail_LaborDetailForm...", Logger.MessageType.INF);
				SeleniumControl IWMALLOC_AllocationDetail_LaborDetailForm = new SeleniumControl( sDriver, "AllocationDetail_LaborDetailForm", "xpath", "//div[translate(@id,'0123456789','')='pr__IWMALLOC_IWOALLOCLAB_TBL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(IWMALLOC_AllocationDetail_LaborDetailForm);
IWebElement formBttn = IWMALLOC_AllocationDetail_LaborDetailForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? IWMALLOC_AllocationDetail_LaborDetailForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
IWMALLOC_AllocationDetail_LaborDetailForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault();
if (formBttn!=null && formBttn.Displayed)
{ new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click();
this.ScriptLogger.WriteLine("Button [Table] found and clicked.", Logger.MessageType.INF);
}


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButtonIfExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "IWMALLOC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[IWMALLOC] Performing VerifyExist on AllocationDetail_LaborDetailFormTable...", Logger.MessageType.INF);
				SeleniumControl IWMALLOC_AllocationDetail_LaborDetailFormTable = new SeleniumControl( sDriver, "AllocationDetail_LaborDetailFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__IWMALLOC_IWOALLOCLAB_TBL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,IWMALLOC_AllocationDetail_LaborDetailFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "IWMALLOC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[IWMALLOC] Performing ClickButtonIfExists on AllocationDetail_LaborDetailForm...", Logger.MessageType.INF);
				SeleniumControl IWMALLOC_AllocationDetail_LaborDetailForm = new SeleniumControl( sDriver, "AllocationDetail_LaborDetailForm", "xpath", "//div[translate(@id,'0123456789','')='pr__IWMALLOC_IWOALLOCLAB_TBL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(IWMALLOC_AllocationDetail_LaborDetailForm);
IWebElement formBttn = IWMALLOC_AllocationDetail_LaborDetailForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? IWMALLOC_AllocationDetail_LaborDetailForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
IWMALLOC_AllocationDetail_LaborDetailForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault();
if (formBttn!=null && formBttn.Displayed)
{ new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click();
this.ScriptLogger.WriteLine("Button [Form] found and clicked.", Logger.MessageType.INF);
}


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButtonIfExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "IWMALLOC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[IWMALLOC] Performing VerifyExists on AllocationDetail_LaborDetailForm...", Logger.MessageType.INF);
				SeleniumControl IWMALLOC_AllocationDetail_LaborDetailForm = new SeleniumControl( sDriver, "AllocationDetail_LaborDetailForm", "xpath", "//div[translate(@id,'0123456789','')='pr__IWMALLOC_IWOALLOCLAB_TBL_']/ancestor::form[1]");
				Function.AssertEqual(true,IWMALLOC_AllocationDetail_LaborDetailForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "IWMALLOC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[IWMALLOC] Performing VerifyExists on AllocationDetail_LaborDetail_PLC...", Logger.MessageType.INF);
				SeleniumControl IWMALLOC_AllocationDetail_LaborDetail_PLC = new SeleniumControl( sDriver, "AllocationDetail_LaborDetail_PLC", "xpath", "//div[translate(@id,'0123456789','')='pr__IWMALLOC_IWOALLOCLAB_TBL_']/ancestor::form[1]/descendant::*[@id='BILL_LAB_CAT_CD']");
				Function.AssertEqual(true,IWMALLOC_AllocationDetail_LaborDetail_PLC.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "IWMALLOC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[IWMALLOC] Performing Close on AllocationDetail_LaborDetailForm...", Logger.MessageType.INF);
				SeleniumControl IWMALLOC_AllocationDetail_LaborDetailForm = new SeleniumControl( sDriver, "AllocationDetail_LaborDetailForm", "xpath", "//div[translate(@id,'0123456789','')='pr__IWMALLOC_IWOALLOCLAB_TBL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(IWMALLOC_AllocationDetail_LaborDetailForm);
IWebElement formBttn = IWMALLOC_AllocationDetail_LaborDetailForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "IWMALLOC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[IWMALLOC] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl IWMALLOC_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(IWMALLOC_MainForm);
IWebElement formBttn = IWMALLOC_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

