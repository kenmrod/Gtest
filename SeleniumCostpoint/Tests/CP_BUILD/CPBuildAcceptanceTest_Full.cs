using System;
using System.Collections.Generic;
using System.Linq;
using Core.Sys;
using Core.Sys.Selenium;
using SeleniumCostpoint.Common;
using OpenQA.Selenium;
using System.Threading;

namespace SeleniumCostpoint.Tests
{
    public class CPBuildAcceptanceTest_Full : SeleniumTestScript
    {
        public override bool TestExecute(out string ErrorMessage, string TestEnvironment, IDriver Driver)
        {
            bool ret = true;
            ErrorMessage = string.Empty;
            SeleniumDriver sDriver = Driver as SeleniumDriver;
            Functions Function = new Functions(sDriver, this);

            try
            {
                /* Log-in */
                Function.Login(TestEnvironment, out ErrorMessage);

                /* 1 - Comment */
                this.ScriptLogger.WriteLine("Process progress");

                /* 2 - Navigate to Re build Global Settings */
                try
                {
                    Function.CurrentComponent = "CP7Main";
                    Function.WaitLoadingFinished();
                    this.ScriptLogger.WriteLine("[CP7Main] Perfoming SelectMenu on NavMenu...", Logger.MessageType.INF);
                    SeleniumControl CP7Main_NavMenu = new SeleniumControl(sDriver, "NavMenu", "ID", "navCont");
                    if (!sDriver.Instance.FindElement(By.CssSelector("div[class='navCont']")).Displayed)
                        new SeleniumControl(sDriver, "Browse", "css", "span[id = 'goToLbl']").Click();
                    new SeleniumControl(sDriver, "Admin", "xpath", "//div[@class='busItem'][.='Admin']").Click();
                    new SeleniumControl(sDriver, "System Administration", "xpath", "//div[@class='deptItem'][.='System Administration']").Click();
                    new SeleniumControl(sDriver, "System Administration Utilities", "xpath", "//div[@class='navItem'][.='System Administration Utilities']").Click();
                    new SeleniumControl(sDriver, "Rebuild Global Settings", "xpath", "//div[@class='navItem'][.='Rebuild Global Settings']").Click();
                    Function.WaitLoadingFinished();
                }
                catch (Exception ex)
                {
                    throw new Exception(TraceMessage("Error navigating to Rebuild Global Settings app ", ex.Message));
                }

                /* 3 - Click Re-load Settings */
                try
                {
                    Function.CurrentComponent = "CP7Main";
                    Function.WaitLoadingFinished();
                    this.ScriptLogger.WriteLine("[CP7Main] Perfoming ClickToolbarButton on MainToolBar...", Logger.MessageType.INF);
                    SeleniumControl CP7Main_MainToolBar = new SeleniumControl(sDriver, "MainToolBar", "ID", "tlbr");
                    Function.WaitControlDisplayed(CP7Main_MainToolBar);
                    IWebElement tlbrBtn = CP7Main_MainToolBar.mElement.FindElements(By.XPath(".//*[@class='tbBtnContainer']//div[contains(@title,'Action Menu')]")).FirstOrDefault();
                    if (tlbrBtn == null)
                        throw new Exception("Unable to find button Action Menu~Reload Settings.");
                    tlbrBtn.Click();
                    CP7Main_MainToolBar.mElement.FindElements(By.XPath("//*[@class = 'tlbrDDItem' and contains(text(),'Reload Settings')]")).FirstOrDefault().Click();
                    Function.WaitLoadingFinished();
                }
                catch (Exception ex)
                {
                    throw new Exception(TraceMessage("Error clicking Re-load Settings. ", ex.Message));
                }

                /* ADDTIONAL STEP - Need to wait */
                try
                {
                    this.ScriptLogger.WriteLine("[ProcessProgress] Waiting for process to finish...", Logger.MessageType.INF);
                    Function.WaitProcessProgressFinished(20);
                    Function.WaitLoadingFinished();
                }
                catch (Exception ex)
                {
                    throw new Exception(TraceMessage("Error waiting for process to finish. ", ex.Message));
                }

                /* 4 - Verify ProcessProgress Header */
                try
                {
                    Function.CurrentComponent = "ProcessProgress";
                    Function.WaitLoadingFinished(true);
                    this.ScriptLogger.WriteLine("[ProcessProgress] Verifying Header...", Logger.MessageType.INF);
                    SeleniumControl ProcessProgress_Header = new SeleniumControl(sDriver, "Header", "ID", "progMtrSysTxt");
                    ProcessProgress_Header.FindElement();
                    Function.AssertEqual(Function.ReplaceCarriageReturn("Process complete.", ". "), Function.ReplaceCarriageReturn(ProcessProgress_Header.mElement.Text.Trim(), ". "));
                    Function.WaitLoadingFinished();
                }
                catch (Exception ex)
                {
                    throw new Exception(TraceMessage("Error verifying Process Progress header ", ex.Message));
                }

                /* 5 - Click ProcessProgress OK */
                try
                {
                    Function.CurrentComponent = "ProcessProgress";
                    Function.WaitLoadingFinished(true);
                    this.ScriptLogger.WriteLine("[ProcessProgress] Perfoming Click on OK...", Logger.MessageType.INF);
                    SeleniumControl ProcessProgress_OK = new SeleniumControl(sDriver, "OK", "ID", "progMtrBtn");
                    Function.WaitControlDisplayed(ProcessProgress_OK);
                    if (ProcessProgress_OK.mElement.GetAttribute("class") == "popupBtn" && sDriver.BrowserType == "ie")
                        ProcessProgress_OK.Click(5, 5);
                    else
                        ProcessProgress_OK.Click(4.5);
                    Function.WaitLoadingFinished();
                }
                catch (Exception ex)
                {
                    throw new Exception(TraceMessage("Error clicking Process Progress OK button ", ex.Message));
                }

                /* 6 - Close Main form */
                try
                {
                    Function.CurrentComponent = "SYPSTNG";
                    Function.WaitLoadingFinished();
                    this.ScriptLogger.WriteLine("[SYPSTNG] Perfoming Close on MainForm...", Logger.MessageType.INF);
                    SeleniumControl SYPSTNG_MainForm = new SeleniumControl(sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
                    Function.WaitControlDisplayed(SYPSTNG_MainForm);
                    IWebElement formBttn = SYPSTNG_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x => x.Displayed).FirstOrDefault();
                    if (formBttn != null)
                        formBttn.Click();
                    else
                        throw new Exception("Close Button not found ");
                    Function.WaitLoadingFinished();
                }
                catch (Exception ex)
                {
                    throw new Exception(TraceMessage("Error closing SYPSTNG main form ", ex.Message));
                }

                try
                {
                    /* 7 - Click OK on Message Box */
                    Function.CurrentComponent = "Dialog";
                    Function.WaitLoadingFinished(true);
                    Function.ClickOkDialogWithMessage("You have unsaved changes. Select Cancel to go back and save changes or select OK to discard changes and close this application.");
                }
                catch (Exception ex)
                {
                    throw new Exception(TraceMessage("Error clicking message box OK button ", ex.Message));
                }

                /* 8 - Comment */
                this.ScriptLogger.WriteLine("Save");

                /* 9 - Navigate to Manage Users */
                try
                {
                    Function.CurrentComponent = "CP7Main";
                    Function.WaitLoadingFinished();
                    if (!sDriver.Instance.FindElement(By.CssSelector("div[class='navCont']")).Displayed)
                        new SeleniumControl( sDriver, "Browse", "css", "span[id = 'goToLbl']").Click();
                    new SeleniumControl( sDriver, "Admin", "xpath", "//div[@class='busItem'][.='Admin']").Click();
                    new SeleniumControl( sDriver, "Security", "xpath", "//div[@class='deptItem'][.='Security']").Click();
                    new SeleniumControl( sDriver, "System Security", "xpath", "//div[@class='navItem'][.='System Security']").Click();
                    new SeleniumControl( sDriver, "Manage Users", "xpath", "//div[@class='navItem'][.='Manage Users']").Click();
                    Function.WaitLoadingFinished();
                }
                catch (Exception ex)
                {
                    throw new Exception(TraceMessage("Error navigating to Manage Users app ", ex.Message));
                }

                #region SETUP STEPS 
                /* IF FAILED, SWALLOW EXCEPTION */
                try
                {
                    /* CHECK USER AND DELETE IF EXISTS */

                    /* 2 - Click Query button */
                    Function.CurrentComponent = "SYMUSR";
                    Function.WaitLoadingFinished();
                    this.ScriptLogger.WriteLine("[SYMUSR] Perfoming Click on Query...", Logger.MessageType.INF);
                    SeleniumControl SYMUSR_MainForm = new SeleniumControl( sDriver, "Query", "xpath", "//div[@id='0']/form[1]");
                    Function.WaitControlDisplayed(SYMUSR_MainForm);
                    IWebElement formBttn = SYMUSR_MainForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).Where(x => x.Displayed).FirstOrDefault();
                    if (formBttn != null)
                        formBttn.Click();


                    /* 3 - Set Criteria Value */
                    Function.CurrentComponent = "Query";
                    Function.WaitLoadingFinished();
                    this.ScriptLogger.WriteLine("[Query] Perfoming Set on Criteria Value...", Logger.MessageType.INF);
                    SeleniumControl QUERY_Find_CriteriaValue1 = new SeleniumControl( sDriver, "Find_CriteriaValue1", "ID", "basicField0");
                    QUERY_Find_CriteriaValue1.Click();
                    QUERY_Find_CriteriaValue1.SendKeys("CPBUILDACCEPTANCE", true);
                    Function.WaitLoadingFinished();
                    QUERY_Find_CriteriaValue1.SendKeys(OpenQA.Selenium.Keys.Shift + OpenQA.Selenium.Keys.Tab);


                    /* 4 - Click Find Count */
                    Function.CurrentComponent = "Query";
                    Function.WaitLoadingFinished();
                    this.ScriptLogger.WriteLine("[Query] Perfoming click on Find Count...", Logger.MessageType.INF);
                    new SeleniumControl( sDriver, "Find_Count", "ID", "basicCountBttn").Click();


                    /* 5 - Verify Find Count Results */
                    try
                    {
                        Function.CurrentComponent = "Query";
                        Function.WaitLoadingFinished();
                        SeleniumControl QUERY_Find_Count_Results = new SeleniumControl( sDriver, "Find_Count_Results", "ID", "basicCountBox");
                        QUERY_Find_Count_Results.FindElement();
                        Function.AssertEqual(Function.ReplaceCarriageReturn("0 records will be returned", ""), Function.ReplaceCarriageReturn(QUERY_Find_Count_Results.mElement.Text.Trim(), ""));

                        /* Click Close */
                        this.ScriptLogger.WriteLine("[Query] Perfoming Click on Close...", Logger.MessageType.INF);
                        new SeleniumControl( sDriver, "Find", "ID", "closeQ").Click();
                        Thread.Sleep(800);
                    }
                    catch (Exception)
                    {
                        /* If records are found, delete record */

                        /* 6 - Click Find */
                        Function.CurrentComponent = "Query";
                        Function.WaitLoadingFinished();
                        this.ScriptLogger.WriteLine("[Query] Perfoming Click on Find...", Logger.MessageType.INF);
                        new SeleniumControl( sDriver, "Find", "ID", "submitQ").Click();
                        Thread.Sleep(800);

                        /* 7 - Click Delete button */
                        Function.CurrentComponent = "SYMUSR";
                        Function.WaitLoadingFinished();
                        this.ScriptLogger.WriteLine("[SYMUSR] Perfoming Click on Delete button...", Logger.MessageType.INF);
                        Function.WaitControlDisplayed(SYMUSR_MainForm);
                        formBttn = SYMUSR_MainForm.mElement.FindElements(By.CssSelector("*[title*='Delete']")).Where(x => x.Displayed).FirstOrDefault();
                        if (formBttn != null)
                        {
                            formBttn.Click();
                        }

                        /* 8 - Click Save and continue */
                        Function.CurrentComponent = "CP7Main";
                        SeleniumControl CP7Main_MainToolBar = new SeleniumControl( sDriver, "MainToolBar", "ID", "tlbr");
                        Function.WaitControlDisplayed(CP7Main_MainToolBar);
                        IWebElement tlbrBtn = CP7Main_MainToolBar.mElement.FindElements(By.XPath(".//*[@class='tbBtnContainer']//div[contains(@title,'Save & Continue (F6)')]")).FirstOrDefault();
                        if (tlbrBtn == null)
                            throw new Exception("Unable to find button Save & Continue (F6).");
                        Thread.Sleep(800);
                        tlbrBtn.Click();
                    }
                }
                catch
                {
                    //DO NOTHING
                }
                #endregion

                /* 10 - Set UserID */
                try
                {
                    Function.CurrentComponent = "SYMUSR";
                    Function.WaitLoadingFinished();
                    this.ScriptLogger.WriteLine("[SYMUSR] Perfoming Set on Identification_UserID...", Logger.MessageType.INF);
                    SeleniumControl SYMUSR_Identification_UserID = new SeleniumControl( sDriver, "Identification_UserID", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='SEC_OBJ_ID']");
                    SYMUSR_Identification_UserID.Click();
                    SYMUSR_Identification_UserID.SendKeys("CPBUILDACCEPTANCE_1", true);
                    Function.WaitLoadingFinished();
                    SYMUSR_Identification_UserID.SendKeys(OpenQA.Selenium.Keys.Shift + OpenQA.Selenium.Keys.Tab);
                    Function.WaitLoadingFinished();
                }
                catch (Exception ex)
                {
                    throw new Exception(TraceMessage("Error setting UserId in SYMUSR app ", ex.Message));
                }

                /* 11 - Set UserName */
                try
                {
                    Function.CurrentComponent = "SYMUSR";
                    Function.WaitLoadingFinished();
                    this.ScriptLogger.WriteLine("[SYMUSR] Perfoming Set on Identification_UserName...", Logger.MessageType.INF);
                    SeleniumControl SYMUSR_Identification_UserName = new SeleniumControl( sDriver, "Identification_UserName", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='U___NAME']");
                    SYMUSR_Identification_UserName.Click();
                    SYMUSR_Identification_UserName.SendKeys("Asaka C.P.A., Leslie k", true);
                    Function.WaitLoadingFinished();
                    SYMUSR_Identification_UserName.SendKeys(OpenQA.Selenium.Keys.Shift + OpenQA.Selenium.Keys.Tab);
                    Function.WaitLoadingFinished();
                }
                catch (Exception ex)
                {
                    throw new Exception(TraceMessage("Error setting UserName in SYMUSR app ", ex.Message));
                }

                /* 12 - Set DefaultCompany */
                try
                {
                    Function.CurrentComponent = "SYMUSR";
                    Function.WaitLoadingFinished();
                    this.ScriptLogger.WriteLine("[SYMUSR] Perfoming Set on Identification_Information_PreferencesUserCanChange_DefaultCompany...", Logger.MessageType.INF);
                    SeleniumControl SYMUSR_Identification_Information_PreferencesUserCanChange_DefaultCompany = new SeleniumControl( sDriver, "Identification_Information_PreferencesUserCanChange_DefaultCompany", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='U___DFLT_COMPANY_ID']");
                    SYMUSR_Identification_Information_PreferencesUserCanChange_DefaultCompany.Click();
                    SYMUSR_Identification_Information_PreferencesUserCanChange_DefaultCompany.SendKeys("1", true);
                    Function.WaitLoadingFinished();
                    SYMUSR_Identification_Information_PreferencesUserCanChange_DefaultCompany.SendKeys(OpenQA.Selenium.Keys.Shift + OpenQA.Selenium.Keys.Tab);
                    Function.WaitLoadingFinished();
                }
                catch (Exception ex)
                {
                    throw new Exception(TraceMessage("Error setting Deafult Company in SYMUSR app ", ex.Message));
                }

                /* 13 - Click New in Company Access Form */
                try
                {
                    Function.CurrentComponent = "SYMUSR";
                    Function.WaitLoadingFinished();
                    this.ScriptLogger.WriteLine("[SYMUSR] Perfoming ClickButtonIfExists on CompanyAccessForm...", Logger.MessageType.INF);
                    SeleniumControl SYMUSR_CompanyAccessForm = new SeleniumControl( sDriver, "CompanyAccessForm", "xpath", "//div[translate(@id,'0123456789','')='pr__SYMUSR_WUSERCOMPANY_']/ancestor::form[1]");
                    Function.WaitControlDisplayed(SYMUSR_CompanyAccessForm);
                    IWebElement formBttn = SYMUSR_CompanyAccessForm.mElement.FindElements(By.CssSelector("*[title*='New']")).Count <= 0 ? SYMUSR_CompanyAccessForm.mElement.FindElements(By.XPath(".//*[contains(text(),'New')]")).FirstOrDefault()
                        : SYMUSR_CompanyAccessForm.mElement.FindElements(By.XPath(".//*[contains(text(),'New')]")).FirstOrDefault();
                    if (formBttn != null && formBttn.Displayed)
                    {
                        new SeleniumControl( sDriver, "FormButton", formBttn).MouseOver(); formBttn.Click();
                        this.ScriptLogger.WriteLine("Button [New] found and clicked.", Logger.MessageType.INF);
                    }
                    Function.WaitLoadingFinished();
                }
                catch (Exception ex)
                {
                    throw new Exception(TraceMessage("Error clicking New button in SYMUSR Company Access form ", ex.Message));
                }

                /* 14 - Click Form button */
                try
                {
                    Function.CurrentComponent = "SYMUSR";
                    SeleniumControl SYMUSR_CompanyAccessForm = new SeleniumControl( sDriver, "CompanyAccessForm", "xpath", "//div[translate(@id,'0123456789','')='pr__SYMUSR_WUSERCOMPANY_']/ancestor::form[1]");
                    Function.WaitControlDisplayed(SYMUSR_CompanyAccessForm);
                    IWebElement formBttn = SYMUSR_CompanyAccessForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? SYMUSR_CompanyAccessForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault()
                        : SYMUSR_CompanyAccessForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault();
                    if (formBttn != null && formBttn.Displayed)
                    {
                        new SeleniumControl( sDriver, "FormButton", formBttn).MouseOver(); formBttn.Click();
                        this.ScriptLogger.WriteLine("Button [Form] found and clicked.", Logger.MessageType.INF);
                    }
                    Function.WaitLoadingFinished();
                }
                catch (Exception ex)
                {
                    throw new Exception(TraceMessage("Error clicking Form button in SYMUSR Company Access Form ", ex.Message));
                }

                /* 15 - Set Company ID */
                try
                {
                    Function.CurrentComponent = "SYMUSR";
                    Function.WaitLoadingFinished();
                    this.ScriptLogger.WriteLine("[SYMUSR] Perfoming Set on Company_CompanyID...", Logger.MessageType.INF);
                    SeleniumControl SYMUSR_Company_CompanyID = new SeleniumControl( sDriver, "Company_CompanyID", "xpath", "//div[translate(@id,'0123456789','')='pr__SYMUSR_WUSERCOMPANY_']/ancestor::form[1]/descendant::*[@id='COMPANY_ID']");
                    SYMUSR_Company_CompanyID.Click();
                    SYMUSR_Company_CompanyID.SendKeys("1", true);
                    Function.WaitLoadingFinished();
                    SYMUSR_Company_CompanyID.SendKeys(OpenQA.Selenium.Keys.Shift + OpenQA.Selenium.Keys.Tab);
                    Function.WaitLoadingFinished();
                }
                catch (Exception ex)
                {
                    throw new Exception(TraceMessage("Error setting Company ID in SYMUSR app ", ex.Message));
                }

                /* 16 - Set Default Tax Entity ID */
                try
                {
                    Function.CurrentComponent = "SYMUSR";
                    Function.WaitLoadingFinished();
                    this.ScriptLogger.WriteLine("[SYMUSR] Perfoming Set on Company_DefaultTaxableEntityID...", Logger.MessageType.INF);
                    SeleniumControl SYMUSR_Company_DefaultTaxableEntityID = new SeleniumControl( sDriver, "Company_DefaultTaxableEntityID", "xpath", "//div[translate(@id,'0123456789','')='pr__SYMUSR_WUSERCOMPANY_']/ancestor::form[1]/descendant::*[@id='UC___DFLT_TAXBLE_ENT_ID']");
                    SYMUSR_Company_DefaultTaxableEntityID.Click();
                    SYMUSR_Company_DefaultTaxableEntityID.SendKeys("1", true);
                    Function.WaitLoadingFinished();
                    SYMUSR_Company_DefaultTaxableEntityID.SendKeys(OpenQA.Selenium.Keys.Shift + OpenQA.Selenium.Keys.Tab);
                    Function.WaitLoadingFinished();
                }
                catch (Exception ex)
                {
                    throw new Exception(TraceMessage("Error setting Default Taxable Entity ID in SYMUSER app ", ex.Message));
                }

                /* 17 - Set Org Sec Grp ID */
                try
                {
                    Function.CurrentComponent = "SYMUSR";
                    Function.WaitLoadingFinished();
                    this.ScriptLogger.WriteLine("[SYMUSR] Perfoming Set on Company_OrgSecurityGroupID...", Logger.MessageType.INF);
                    SeleniumControl SYMUSR_Company_OrgSecurityGroupID = new SeleniumControl( sDriver, "Company_OrgSecurityGroupID", "xpath", "//div[translate(@id,'0123456789','')='pr__SYMUSR_WUSERCOMPANY_']/ancestor::form[1]/descendant::*[@id='UC___ORG_SEC_GRP_CD']");
                    SYMUSR_Company_OrgSecurityGroupID.Click();
                    SYMUSR_Company_OrgSecurityGroupID.SendKeys("ALL", true);
                    Function.WaitLoadingFinished();
                    SYMUSR_Company_OrgSecurityGroupID.SendKeys(OpenQA.Selenium.Keys.Shift + OpenQA.Selenium.Keys.Tab);
                    Function.WaitLoadingFinished();
                }
                catch (Exception ex)
                {
                    throw new Exception(TraceMessage("Error setting Org Sec ID in SYMUSER app ", ex.Message));
                }

                /* 18 - Select Authentication tab */
                try
                {
                    Function.CurrentComponent = "SYMUSR";
                    Function.WaitLoadingFinished();
                    this.ScriptLogger.WriteLine("[SYMUSR] Perfoming Select on IdentificationTab...", Logger.MessageType.INF);
                    SeleniumControl SYMUSR_IdentificationTab = new SeleniumControl( sDriver, "IdentificationTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
                    Function.WaitControlDisplayed(SYMUSR_IdentificationTab);
                    IWebElement mTab = SYMUSR_IdentificationTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl( sDriver, "Tab", x).GetValue() == "Authentication").FirstOrDefault();
                    mTab.Click();
                    Thread.Sleep(2000);
                    Function.WaitLoadingFinished();
                }
                catch (Exception ex)
                {
                    throw new Exception(TraceMessage("Error clicking Authentication tab in SYMUSER app ", ex.Message));
                }

                /* 18.5 - Set Authentication Method to Database */
                try
                {
                    Function.CurrentComponent = "SYMUSR";
                    Function.WaitLoadingFinished();
                    this.ScriptLogger.WriteLine("[SYMUSR] Perfoming Set on Identification_Authentication_AuthenticationSettings_AuthenticationMethod", Logger.MessageType.INF);
                    SeleniumControl SYMUSR_AuthSettings_AuthenticationMethod = new SeleniumControl(sDriver, "AuthenticationMethod", "xpath", "//*[@id='AUTH_METHOD']");
                    SYMUSR_AuthSettings_AuthenticationMethod.Click();
                    Thread.Sleep(1000);
                    SeleniumControl itemDatabase = new SeleniumControl(sDriver, "itemDatabase", "xpath", "//*[@class='tCCBV' and not(contains(@style, 'display: none;'))]//*[@name='CPDB']");
                    itemDatabase.Click();
                    Thread.Sleep(2000);
                    Function.WaitLoadingFinished();
                }
                catch (Exception ex)
                {
                    throw new Exception(TraceMessage("Error setting on Identification_Authentication_AuthenticationSettings_AuthenticationMethod in SYMUSER app ", ex.Message));
                }

                /* 19 - Set CP password */
                try
                {
                    Function.CurrentComponent = "SYMUSR";
                    Function.WaitLoadingFinished();
                    this.ScriptLogger.WriteLine("[SYMUSR] Perfoming Set on Identification_Authentication_AuthenticationSettings_CostpointPassword...", Logger.MessageType.INF);
                    SeleniumControl SYMUSR_Identification_Authentication_AuthenticationSettings_CostpointPassword = new SeleniumControl( sDriver, "Identification_Authentication_AuthenticationSettings_CostpointPassword", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='NEW_PASSWORD']");
                    //Check if CP password is visible. Click Authentication Tab again if not working//
                    if (!SYMUSR_Identification_Authentication_AuthenticationSettings_CostpointPassword.Exists())
                    {
                        SeleniumControl SYMUSR_IdentificationTab = new SeleniumControl(sDriver, "IdentificationTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
                        Function.WaitControlDisplayed(SYMUSR_IdentificationTab);
                        IWebElement mTab = SYMUSR_IdentificationTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver, "Tab", x).GetValue() == "Authentication").FirstOrDefault();
                        mTab.Click();
                        Thread.Sleep(2000);
                    }
                    SYMUSR_Identification_Authentication_AuthenticationSettings_CostpointPassword.Click();
                    SYMUSR_Identification_Authentication_AuthenticationSettings_CostpointPassword.SendKeys("Password1", true);
                    Function.WaitLoadingFinished();
                    SYMUSR_Identification_Authentication_AuthenticationSettings_CostpointPassword.SendKeys(OpenQA.Selenium.Keys.Shift + OpenQA.Selenium.Keys.Tab);
                    Function.WaitLoadingFinished();
                }
                catch (Exception ex)
                {
                    throw new Exception(TraceMessage("Error setting CP password in SYMUSER app ", ex.Message));
                }

                /* 20 - Set CP Verify password */
                try
                {
                    Function.CurrentComponent = "SYMUSR";
                    Function.WaitLoadingFinished();
                    this.ScriptLogger.WriteLine("[SYMUSR] Perfoming Set on Identification_Authentication_AuthenticationSettings_VerifyPassword...", Logger.MessageType.INF);
                    SeleniumControl SYMUSR_Identification_Authentication_AuthenticationSettings_VerifyPassword = new SeleniumControl( sDriver, "Identification_Authentication_AuthenticationSettings_VerifyPassword", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='VERIFY_PASSWORD']");
                    SYMUSR_Identification_Authentication_AuthenticationSettings_VerifyPassword.Click();
                    SYMUSR_Identification_Authentication_AuthenticationSettings_VerifyPassword.SendKeys("Password1", true);
                    Function.WaitLoadingFinished();
                    SYMUSR_Identification_Authentication_AuthenticationSettings_VerifyPassword.SendKeys(OpenQA.Selenium.Keys.Shift + OpenQA.Selenium.Keys.Tab);
                    Function.WaitLoadingFinished();
                }
                catch (Exception ex)
                {
                    throw new Exception(TraceMessage("Error setting Verify Password in SYMUSER app ", ex.Message));
                }

                /* 21 - Click Save and Continue */
                try
                {
                    Function.CurrentComponent = "CP7Main";
                    SeleniumControl CP7Main_MainToolBar = new SeleniumControl( sDriver, "MainToolBar", "ID", "tlbr");
                    Function.WaitControlDisplayed(CP7Main_MainToolBar);
                    IWebElement tlbrBtn = CP7Main_MainToolBar.mElement.FindElements(By.XPath(".//*[@class='tbBtnContainer']//div[contains(@title,'Save & Continue (F6)')]")).FirstOrDefault();
                    if (tlbrBtn == null)
                        throw new Exception("Unable to find button Save & Continue (F6).");
                    tlbrBtn.Click();
                    Function.WaitLoadingFinished();
                }
                catch (Exception ex)
                {
                    throw new Exception(TraceMessage("Error clicking Save and Continue ", ex.Message));
                }

                /* 22 - Verify Save Message */
                try
                {
                    Function.CurrentComponent = "CP7Main";
                    Function.WaitControlDisplayed(new SeleniumControl(sDriver, "MessageArea", "xpath", "//span[contains(@class,'msgTextHdr')]"));
                    IList<IWebElement> msgElements = sDriver.Instance.FindElements(By.XPath("//span[contains(@class,'msgTextHdr')]/following-sibling::span[contains(@class,'msgText')]"));
                    Function.AssertEqual(true, msgElements.ToList().Select(x => new SeleniumControl( sDriver, "x", x).GetValue().Trim())
                        .Any(x => x == "Record modifications successfully completed."));
                    Function.WaitLoadingFinished();
                }
                catch (Exception ex)
                {
                    throw new Exception(TraceMessage("Error verifying save message ", ex.Message));
                }

                /* 23 - Click Save and Continue */
                try
                {
                    Function.CurrentComponent = "CP7Main";
                    SeleniumControl CP7Main_MainToolBar = new SeleniumControl( sDriver, "MainToolBar", "ID", "tlbr");
                    Function.WaitControlDisplayed(CP7Main_MainToolBar);
                    IWebElement tlbrBtn = CP7Main_MainToolBar.mElement.FindElements(By.XPath(".//*[@class='tbBtnContainer']//div[contains(@title,'Save & Continue')]")).FirstOrDefault();
                    if (tlbrBtn == null)
                        throw new Exception("Unable to find button Save & Continue.");
                    tlbrBtn.Click();
                    Function.WaitLoadingFinished();
                }
                catch (Exception ex)
                {
                    throw new Exception(TraceMessage("Error clicking Save and Continue ", ex.Message));
                }

                /* 24 - Verify Save Message */
                try
                {
                    Function.CurrentComponent = "CP7Main";
                    Function.WaitControlDisplayed(new SeleniumControl(sDriver, "MessageArea", "xpath", "//span[contains(@class,'msgTextHdr')]"));
                    IReadOnlyCollection<IWebElement> msgElements = sDriver.Instance.FindElements(By.XPath("//span[contains(@class,'msgTextHdr')]/following-sibling::span[contains(@class,'msgText')]"));
                    Function.AssertEqual(true, msgElements.ToList().Select(x => new SeleniumControl( sDriver, "x", x).GetValue().Trim())
                        .Any(x => x == "Record modifications successfully completed."));
                    Function.WaitLoadingFinished();
                }
                catch (Exception ex)
                {
                    throw new Exception(TraceMessage("Error verifying save message ", ex.Message));
                }

                /* 25 - Comment */
                this.ScriptLogger.WriteLine("Print");

                /* 26 - Click Horizontal Layout */
                try
                {
                    Function.CurrentComponent = "CP7Main";
                    SeleniumControl CP7Main_MainToolBar = new SeleniumControl( sDriver, "MainToolBar", "ID", "tlbr");
                    Function.WaitControlDisplayed(CP7Main_MainToolBar);
                    IWebElement tlbrBtn = CP7Main_MainToolBar.mElement.FindElements(By.XPath(".//*[@class='tbBtnContainer']//div[contains(@title,'Print Menu')]")).FirstOrDefault();
                    if (tlbrBtn == null)
                        throw new Exception("Unable to find button Print Menu~Current Record Information - Horizontal Layout.");
                    tlbrBtn.Click();
                    CP7Main_MainToolBar.mElement.FindElements(By.XPath("//*[@class = 'tlbrDDItem' and contains(text(),'Current Record Information - Horizontal Layout')]")).FirstOrDefault().Click();
                    Function.WaitLoadingFinished();
                }
                catch (Exception ex)
                {
                    throw new Exception(TraceMessage("Error clicking Horizontal Layout ", ex.Message));
                }

                /* 27 - Wait process finished */
                try
                {
                    this.ScriptLogger.WriteLine("[ProcessProgress] Waiting for process to finish...", Logger.MessageType.INF);
                    Function.WaitProcessProgressFinished(20);
                }
                catch (Exception ex)
                {
                    throw new Exception(TraceMessage("Error waiting for process to finish ", ex.Message));
                }

                /* 28 - Verify process progress header */
                try
                {
                    Function.CurrentComponent = "ProcessProgress";
                    Function.WaitLoadingFinished(true);
                    this.ScriptLogger.WriteLine("[ProcessProgress] Verifying Header...", Logger.MessageType.INF);
                    SeleniumControl ProcessProgress_Header1 = new SeleniumControl( sDriver, "Header", "ID", "progMtrSysTxt");
                    ProcessProgress_Header1.FindElement();
                    Function.AssertEqual(Function.ReplaceCarriageReturn("Process complete.", ". "), Function.ReplaceCarriageReturn(ProcessProgress_Header1.mElement.Text.Trim(), ". "));
                    Function.WaitLoadingFinished();
                }
                catch (Exception ex)
                {
                    throw new Exception(TraceMessage("Error verifying process progress header ", ex.Message));
                }

                /* 29 - Click process progress OK */
                try
                {
                    Function.CurrentComponent = "ProcessProgress";
                    SeleniumControl ProcessProgress_OK = new SeleniumControl( sDriver, "OK", "ID", "progMtrBtn");
                    Function.WaitControlDisplayed(ProcessProgress_OK);
                    if (ProcessProgress_OK.mElement.GetAttribute("class") == "popupBtn" && sDriver.BrowserType == "ie")
                        ProcessProgress_OK.Click(5, 5);
                    else
                        ProcessProgress_OK.Click(4.5);
                    Function.WaitLoadingFinished();
                }
                catch (Exception ex)
                {
                    throw new Exception(TraceMessage("Error clicking Process Progress OK button ", ex.Message));
                }

                /* 30 - Download file */
                try
                {
                    this.ScriptLogger.WriteLine("[Dialog] File Download...", Logger.MessageType.INF);
                    new MSUIAutomationHelper(sDriver).FileDownload(sDriver.Instance.Title, "symusr.pdf", 6000);
                }
                catch (Exception ex)
                {
                    throw new Exception(TraceMessage("Error downloading file ", ex.Message));
                }

                /* 31 - Comment */
                this.ScriptLogger.WriteLine("Delete");

                /* 32 - Click Delete in Manage Users mainform */
                try
                {
                    Function.CurrentComponent = "SYMUSR";
                    Function.WaitLoadingFinished();
                    this.ScriptLogger.WriteLine("[SYMUSR] Perfoming ClickButton on MainForm...", Logger.MessageType.INF);
                    SeleniumControl SYMUSR_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
                    Function.WaitControlDisplayed(SYMUSR_MainForm);
                    IWebElement formBttn = SYMUSR_MainForm.mElement.FindElements(By.CssSelector("*[title*='Delete']")).Count <= 0 ? SYMUSR_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Delete')]")).FirstOrDefault() :
                        SYMUSR_MainForm.mElement.FindElements(By.CssSelector("*[title*='Delete']")).FirstOrDefault();
                    if (formBttn != null)
                    {
                        new SeleniumControl( sDriver, "FormButton", formBttn).MouseOver();
                        formBttn.Click();
                    }
                    else
                        throw new Exception(" Delete not found ");
                    Function.WaitLoadingFinished();
                }
                catch (Exception ex)
                {
                    throw new Exception(TraceMessage("Error clicking Delete in SYMUSR app ", ex.Message));
                }

                /* 33 - Click Save */
                try
                {
                    Function.CurrentComponent = "CP7Main";
                    SeleniumControl CP7Main_MainToolBar = new SeleniumControl( sDriver, "MainToolBar", "ID", "tlbr");
                    Function.WaitControlDisplayed(CP7Main_MainToolBar);
                    IWebElement tlbrBtn = CP7Main_MainToolBar.mElement.FindElements(By.XPath(".//*[@class='tbBtnContainer']//div[contains(@title,'Save (F5)')]")).FirstOrDefault();
                    if (tlbrBtn == null)
                        throw new Exception("Unable to find button Save (F5).");
                    Thread.Sleep(800);
                    tlbrBtn.Click();
                    Thread.Sleep(1000);
                    Function.WaitLoadingFinished();
                }
                catch (Exception ex)
                {
                    throw new Exception(TraceMessage("Error clicking Save ", ex.Message));
                }

                /* 34 - Verify Save message */
                try
                {
                    Function.CurrentComponent = "CP7Main";
                    Function.WaitControlDisplayed(new SeleniumControl(sDriver,"MessageArea","xpath", "//span[contains(@class,'msgTextHdr')]"));
                    IReadOnlyCollection<IWebElement> msgElements = sDriver.Instance.FindElements(By.XPath("//span[contains(@class,'msgTextHdr')]/following-sibling::span[contains(@class,'msgText')]"));
                    Function.AssertEqual(true, msgElements.ToList().Select(x => new SeleniumControl( sDriver, "x", x).GetValue().Trim())
                        .Any(x => x == "Record modifications successfully completed."));
                    Function.WaitLoadingFinished();
                }
                catch (Exception ex)
                {
                    throw new Exception(TraceMessage("Error verifying save message ", ex.Message));
                }

                /* 35 - Close main form */
                try
                {
                    Function.CurrentComponent = "SYMUSR";
                    SeleniumControl SYMUSR_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
                    Function.WaitControlDisplayed(SYMUSR_MainForm);
                    IWebElement formBttn = SYMUSR_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x => x.Displayed).FirstOrDefault();
                    if (formBttn != null)
                        formBttn.Click();
                    else throw
                        new Exception("Close Button not found ");
                    Function.WaitLoadingFinished();
                }
                catch (Exception ex)
                {
                    throw new Exception(TraceMessage("Error closing SYMUSR main form ", ex.Message));
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
