 
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
    public class MEPMCC_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Materials Estimating", "xpath","//div[@class='deptItem'][.='Materials Estimating']").Click();
new SeleniumControl(sDriver,"Proposal Bills of Material", "xpath","//div[@class='navItem'][.='Proposal Bills of Material']").Click();
new SeleniumControl(sDriver,"Apply Mass Component Changes to Proposal BOMs", "xpath","//div[@class='navItem'][.='Apply Mass Component Changes to Proposal BOMs']").Click();


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
				Function.CurrentComponent = "MEPMCC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEPMCC] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl MEPMCC_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,MEPMCC_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEPMCC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEPMCC] Performing VerifyExists on MainForm_ParameterID...", Logger.MessageType.INF);
				SeleniumControl MEPMCC_MainForm_ParameterID = new SeleniumControl( sDriver, "MainForm_ParameterID", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PARM_ID']");
				Function.AssertEqual(true,MEPMCC_MainForm_ParameterID.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEPMCC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEPMCC] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl MEPMCC_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(MEPMCC_MainForm);
IWebElement formBttn = MEPMCC_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? MEPMCC_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
MEPMCC_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEPMCC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEPMCC] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl MEPMCC_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,MEPMCC_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("PBOM Assemblies");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEPMCC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEPMCC] Performing VerifyExists on MainForm_PBOMAssembliesLink...", Logger.MessageType.INF);
				SeleniumControl MEPMCC_MainForm_PBOMAssembliesLink = new SeleniumControl( sDriver, "MainForm_PBOMAssembliesLink", "ID", "lnk_2146_MEPMCC_PARAM");
				Function.AssertEqual(true,MEPMCC_MainForm_PBOMAssembliesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEPMCC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEPMCC] Performing Click on MainForm_PBOMAssembliesLink...", Logger.MessageType.INF);
				SeleniumControl MEPMCC_MainForm_PBOMAssembliesLink = new SeleniumControl( sDriver, "MainForm_PBOMAssembliesLink", "ID", "lnk_2146_MEPMCC_PARAM");
				Function.WaitControlDisplayed(MEPMCC_MainForm_PBOMAssembliesLink);
MEPMCC_MainForm_PBOMAssembliesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEPMCC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEPMCC] Performing VerifyExist on ProposalBillOfMaterialFormTable...", Logger.MessageType.INF);
				SeleniumControl MEPMCC_ProposalBillOfMaterialFormTable = new SeleniumControl( sDriver, "ProposalBillOfMaterialFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__MEPMCC_ASSY_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,MEPMCC_ProposalBillOfMaterialFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEPMCC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEPMCC] Performing VerifyExists on ProposalBillOfMaterialForm...", Logger.MessageType.INF);
				SeleniumControl MEPMCC_ProposalBillOfMaterialForm = new SeleniumControl( sDriver, "ProposalBillOfMaterialForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MEPMCC_ASSY_']/ancestor::form[1]");
				Function.AssertEqual(true,MEPMCC_ProposalBillOfMaterialForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEPMCC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEPMCC] Performing ClickButton on ProposalBillOfMaterialForm...", Logger.MessageType.INF);
				SeleniumControl MEPMCC_ProposalBillOfMaterialForm = new SeleniumControl( sDriver, "ProposalBillOfMaterialForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MEPMCC_ASSY_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MEPMCC_ProposalBillOfMaterialForm);
IWebElement formBttn = MEPMCC_ProposalBillOfMaterialForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? MEPMCC_ProposalBillOfMaterialForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
MEPMCC_ProposalBillOfMaterialForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEPMCC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEPMCC] Performing VerifyExists on ProposalBillOfMaterial_Proposal_Proposal...", Logger.MessageType.INF);
				SeleniumControl MEPMCC_ProposalBillOfMaterial_Proposal_Proposal = new SeleniumControl( sDriver, "ProposalBillOfMaterial_Proposal_Proposal", "xpath", "//div[translate(@id,'0123456789','')='pr__MEPMCC_ASSY_']/ancestor::form[1]/descendant::*[@id='PROP_ID']");
				Function.AssertEqual(true,MEPMCC_ProposalBillOfMaterial_Proposal_Proposal.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MEPMCC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEPMCC] Performing Close on ProposalBillOfMaterialForm...", Logger.MessageType.INF);
				SeleniumControl MEPMCC_ProposalBillOfMaterialForm = new SeleniumControl( sDriver, "ProposalBillOfMaterialForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MEPMCC_ASSY_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MEPMCC_ProposalBillOfMaterialForm);
IWebElement formBttn = MEPMCC_ProposalBillOfMaterialForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "MEPMCC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MEPMCC] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl MEPMCC_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(MEPMCC_MainForm);
IWebElement formBttn = MEPMCC_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

