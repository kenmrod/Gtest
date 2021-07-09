using OpenQA.Selenium;
using System;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using Core.Sys;
using Core.Sys.Selenium;

namespace SeleniumCostpoint.Common
{
    public class Functions
    {
        private const int INT_LOGIN_TIMEOUT = 60;
        private const int INT_TARGET_URL_LOAD_TIMEOUT = 120;
        private const int INT_SHORT_WAIT_SEC = 3;
        private const int mLongWaitMs = 900000;
        private  SeleniumDriver mDriver = null;
        public  string CurrentComponent = string.Empty;
        private SeleniumTestScript mScript = null;

        #region PUBLIC METHODS
        public Functions(SeleniumDriver Driver, SeleniumTestScript TestScript)
        {
            mDriver = Driver;
            mScript = TestScript;
        }

        public Functions(SeleniumDriver Driver)
        {
            mDriver = Driver;
        }

        public bool Login(string EnvId, out string ErrorMessage, bool RetryOnce = true)
        {
            bool ret = true;
            ErrorMessage = string.Empty;
            SeleniumEnvironment myEnv = TestEnvironment.SeleniumEnvironments.First(x => x.Id == EnvId);

            try
            {
                PerformLogin();
            }
            catch
            {
                if (RetryOnce)
                {
                    mScript.ScriptLogger.WriteLine("First attempt at login failed. Retrying...");
                    PerformLogin();
                }
            }

            /* Local function for performing login */
            void PerformLogin()
            {
                mDriver.Instance.Url = myEnv.Url;
                int pageLoadThreshold = 0;
                SeleniumControl loginButton = new SeleniumControl(mDriver, "loginBtn", "id", "loginBtn");
                while (!loginButton.Exists() && ++pageLoadThreshold <= INT_TARGET_URL_LOAD_TIMEOUT)
                {

                    mScript.ScriptLogger.WriteLine("Waiting for " + mDriver.Instance.Url + " to load... " + pageLoadThreshold + "s");
                    Thread.Sleep(300);
                    if (pageLoadThreshold % 60 == 0)
                    {
                        mScript.ScriptLogger.WriteLine("Page did not load correctly after " + pageLoadThreshold + "s. Reloading " + mDriver.Instance.Url + "...", Logger.MessageType.INF);
                        mDriver.Instance.FindElement(By.TagName("html")).SendKeys(Keys.F5);
                    }
                }
                if (mDriver.Instance.FindElements(By.Id("loginBtn")).Count == 0 && pageLoadThreshold >= INT_TARGET_URL_LOAD_TIMEOUT)
                {
                    ret = false;
                    throw new Exception("Login cannot proceed. " + mDriver.Instance.Url
                        + " did not load as expected after " + INT_TARGET_URL_LOAD_TIMEOUT + "s. Please refer to the error image.");
                }
                try
                {
                    if (!String.IsNullOrWhiteSpace(myEnv.UserInterface))
                    {
                        //Change this if more options for user interface are added
                        string radioID = myEnv.UserInterface.ToLower().Equals("new") ? "newui" : "oldui";
                        SeleniumControl interfaceRadio = new SeleniumControl(mDriver, "UserInterface", "id", radioID);
                        interfaceRadio.Click();
                    }
                    SeleniumControl UserID = new SeleniumControl(mDriver, "UserID", "id", "USER");
                    UserID.SendKeys(myEnv.UserName, true);

                    SeleniumControl Password = new SeleniumControl(mDriver, "Password", "id", "CLIENT_PASSWORD");
                    Password.SendKeys(myEnv.Password, true);

                    SeleniumControl ShowAdditional = new SeleniumControl(mDriver, "ShowAdditional", "id", "additionalCriteria");
                    ShowAdditional.Click();

                    SeleniumControl System = new SeleniumControl(mDriver, "System", "id", "DATABASE");
                    System.SendKeys(myEnv.Database, true);

                    loginButton.Click();

                    SeleniumControl WarnOKButton = new SeleniumControl(mDriver, "WarnOkBtn", "id", "warnOkBtn");
                    if (WarnOKButton.Exists(1))
                    {
                        WarnOKButton.Click();
                        Thread.Sleep(3000);
                        loginButton.Click();
                    }
                    SeleniumControl errorHeader = new SeleniumControl(mDriver, "Error", "ID", "errMsgHeader");
                    if (errorHeader.Exists(1))
                    {
                        SeleniumControl errorText = new SeleniumControl(mDriver, "Error", "ID", "errMsgText");
                        throw new Exception(errorText.GetValue());
                    }
                    mScript.ScriptLogger.WriteLine("Successfully performed Login steps...", Logger.MessageType.INF);
                    WaitLoadingFinished();

                }
                catch (Exception e)
                {
                    ret = false;
                    throw new Exception("Login cannot proceed. " + e.Message);
                }

                SeleniumControl navCtl = new SeleniumControl(mDriver, "NavMenu", "ID", "navCont");
                try
                {
                    navCtl.FindElement(INT_LOGIN_TIMEOUT);
                    //WaitControlDisplayedWithThrow(navCtl, "Costpoint took too long to load. The app navigation menu was not reached");
                }
                catch
                {
                    throw new Exception("Costpoint took too long to Login. The app navigation menu was not reached after "
                        + INT_LOGIN_TIMEOUT + "s. Please refer to the error image.");
                }
            }            

            return ret;
        }

        public void WaitControlDisplayed(SeleniumControl Ctrl, int WaitLoadingFinished = 300)
        {
            for (int i = 0; i < WaitLoadingFinished; i++)
            {
                if (!Ctrl.Exists(1))
                {
                    // do nothing: Exist is already 1 second wait
                }
                else
                {
                    mScript.ScriptLogger.WriteLine(string.Format("{0} found, SeleniumControl found in {1} seconds."
                        , Ctrl.mControlName, i.ToString()), Logger.MessageType.INF);
                    break;
                }
            }
        }

        public void WaitControlDisplayedWithThrow(SeleniumControl Ctrl, string ThrowMsg, int WaitLoadingFinished = 300)
        {
            bool found = false;
            for (int i = 0; i < WaitLoadingFinished; i++)
            {
                if (!Ctrl.Exists(1)) found = false;
                else
                {
                    found = true;
                    mScript
                        .ScriptLogger
                        .WriteLine($"{Ctrl.mControlName} found, SeleniumControl found in {i.ToString()} seconds.", Logger.MessageType.INF);
                    break;
                }
            }
            if (!found) throw new Exception(ThrowMsg);
        }

        public void WaitLoadingFinished(Boolean IsComponentModal = false)
        {
            String WaitImageCSS = "*.pleaseWaitImage";
            //String WaitLabelCSS = "*.titleLblCover";
            Boolean bExist = false;
            IWebElement loadingImage = null;
            //IWebElement loadingLabel = null;
            IWebElement modalHider = null;

            try
            {
                mScript.ScriptLogger.WriteLine("Checking if page is loading...", Logger.MessageType.INF);
                if (!DoesAlertExist(1))
                {
                    if (mDriver.Instance.FindElements(By.CssSelector(WaitImageCSS)).Count > 0)
                    {
                        loadingImage = mDriver.Instance.FindElements(By.CssSelector(WaitImageCSS)).First();
                        modalHider = mDriver.Instance.FindElements(By.ClassName("modalHider")).First();
                    }

                    if (IsComponentModal)
                    {
                        // Modal fixed wait
                        mScript.ScriptLogger.WriteLine("Modal component fixed wait initiated...", Logger.MessageType.INF);
                        Thread.Sleep(3000);
                        mScript.ScriptLogger.WriteLine("Modal component fixed wait finished.", Logger.MessageType.INF);
                        mScript.ScriptLogger.WriteLine("Ignoring page loading state.", Logger.MessageType.INF);
                        return;
                    }

                    for (int i = 0; loadingImage != null && i < mLongWaitMs / 1000; i++)
                    {
                        Thread.Sleep(1000);
                        if (loadingImage.GetCssValue("visibility") == "visible")
                        {
                            mScript.ScriptLogger.WriteLine("Page is still loading", Logger.MessageType.INF);
                            bExist = true;
                            //Thread.Sleep(DlkEnvironment.MediumWaitMs);
                        }
                        else
                        {
                            if (!IsComponentModal && modalHider.GetCssValue("display") != "none" && !IsModalFormDisplayed())
                            {
                                bExist = true;
                                continue;
                            }
                            bExist = false;
                            break;
                        }
                    }
                    if (bExist)
                    {
                        mScript.ScriptLogger.WriteLine("Page still loading.", Logger.MessageType.WRN);
                    }
                    else
                    {
                        mScript.ScriptLogger.WriteLine("Page finished loading.", Logger.MessageType.INF);
                    }
                }
            }
            catch (Exception e)
            {
                // do nothing
                mScript.ScriptLogger.WriteLine("WaitLoadingFinished() threw an unexpected exception. Logging call stack for debugging purposes...", Logger.MessageType.WRN);
                mScript.ScriptLogger.WriteLine("Exception Message: " + e.Message, Logger.MessageType.WRN);
                mScript.ScriptLogger.WriteLine("Exceeption Call Stack: " + e.StackTrace, Logger.MessageType.WRN);
            }
        }

        public void WaitProcessProgressFinished(int Timeout)
        {
            SeleniumControl ProcessProgress_OK = new SeleniumControl(mDriver, "OK", "ID", "progMtrBtn");
            for (int i = 0; i < Timeout; i++)
            {
                Thread.Sleep(1000);
                if (ProcessProgress_OK.GetValue().ToLower() != "ok")
                {
                    mScript.ScriptLogger.WriteLine("OK button not yet visible. Waiting...", Logger.MessageType.INF);
                    continue;
                }
                mScript.ScriptLogger.WriteLine("Successfully executed WaitForProcessFinished().", Logger.MessageType.INF);
                return;
            }
            mScript.ScriptLogger.WriteLine("WaitForProcessFinished() has timed out.", Logger.MessageType.INF);
        }

        public Boolean DoesAlertExist(int iTimeInSecs)
        {
            Boolean bExist = false;
            IAlert mAlert;
            for (int i = 1; i <= iTimeInSecs; i++)
            {
                try
                {
                    mAlert = mDriver.Instance.SwitchTo().Alert();
                    if (mAlert.Text.Length > 0)
                    {
                        bExist = true;
                        break;
                    }
                }
                catch
                {
                    // do nothing...
                }
                Thread.Sleep(1000);
            }
            return bExist;
        }

        public void AssertEqual(string Expected, string Actual, bool IsCaseSensitive = true)
        {
            if (IsCaseSensitive)
            {
                if (!Expected.Equals(Actual))
                {
                    throw new Exception("Expected Result [" + Expected + "] is NOT equal to Actual Result [" + Actual + "].");
                }
            }
            else
            {
                if (!Expected.Equals(Actual, StringComparison.InvariantCultureIgnoreCase))
                {
                    throw new Exception("Expected Result [" + Expected + "] is NOT equal to Actual Result [" + Actual + "].");
                }
            }

            mScript.ScriptLogger.WriteLine("Expected Result [" + Expected + "] is equal to Actual Result [" + Actual + "].", Logger.MessageType.INF);
        }

        public void AssertEqual(bool Expected, bool Actual)
        {
            if (Expected != Actual)
            {
                throw new Exception("Expected Result [" + Expected + "] is NOT equal to Actual Result [" + Actual + "].");
            }

            mScript.ScriptLogger.WriteLine("Expected Result [" + Expected + "] is equal to Actual Result [" + Actual + "].", Logger.MessageType.INF);
        }

        public bool IsCurrentComponentModal(bool isMessageArea = false)
        {
            bool ret = false;
            switch (CurrentComponent.ToLower())
            {
                case "query":
                case "printoptions":
                case "processprogress":
                case "dialog":
                case "fileuploadmanager":
                    ret = true;
                    break;
                case "cp7main":
                    switch (isMessageArea)
                    {
                        case true:
                            ret = true;
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
            return ret;
        }

        public void SendKeys(String Keys)
        {
            String[] arrKeys = Keys.Split('~');
            String strKeyToSend = String.Empty;
            try
            {
                Type typeOfKeys = typeof(OpenQA.Selenium.Keys);

                // To handle special case of 'Ctrl+~/Ctrl~~' for shortcut key of Next tab in Costpoint/TE
                if (Keys.Contains("~~"))
                {
                    FieldInfo fld = typeOfKeys.GetField(arrKeys[0]);
                    if (fld != null)
                    {
                        strKeyToSend += fld.GetValue(typeOfKeys).ToString();
                        strKeyToSend += "`".ToLower();
                    }
                }
                else
                {
                    // parse input Keys and convert to Selenium.Keys equivalent
                    for (int i = 0; i < arrKeys.Count(); i++)
                    {
                        FieldInfo fld = typeOfKeys.GetField(arrKeys[i]);

                        if (fld != null) // key is a special key, Tab, Control, etc.
                        {
                            strKeyToSend += fld.GetValue(typeOfKeys).ToString();
                        }
                        else // key is a standard input key, A, 2, etc.
                        {
                            strKeyToSend += arrKeys[i].ToLower();
                        }
                    }
                }
                mScript.ScriptLogger.WriteLine("SendKeys() : keys to send = " + strKeyToSend, Logger.MessageType.INF);
                OpenQA.Selenium.Interactions.Actions mAction = new OpenQA.Selenium.Interactions.Actions(mDriver.Instance);
                mAction.SendKeys(strKeyToSend).Build().Perform();
                mScript.ScriptLogger.WriteLine("Successfully executed SendKeys()", Logger.MessageType.INF);
            }
            catch (Exception e)
            {
                throw new Exception("SendKeys() failed : " + e.Message, e);
            }
        }

        public void Wait(int WaitTime)
        {

            for (int cnt = 1; cnt <= WaitTime; cnt++)
            {
                Thread.Sleep(1000);
                mScript.ScriptLogger.WriteLine("Wait() : Waiting ... " + cnt + " sec elapsed", Logger.MessageType.INF);
            }

        }

        public void ClickOkDialogIfExists(String ExpectedAlertText)
        {
            if (DoesAlertExist(INT_SHORT_WAIT_SEC) && VerifyAlertText(ExpectedAlertText))
            {
                mDriver.Instance.SwitchTo().Alert().Accept();
                mScript.ScriptLogger.WriteLine("Successfully executed Accept() on alert.", Logger.MessageType.INF);
            }
            else
            {
                mScript.ScriptLogger.WriteLine("No alert exists.", Logger.MessageType.INF);
            }
        }

        public void ClickOkDialogWithMessage(String Message)
        {
            if (DoesAlertExist(INT_SHORT_WAIT_SEC) && VerifyAlertText(Message))
            {
                mDriver.Instance.SwitchTo().Alert().Accept();
                mScript.ScriptLogger.WriteLine("Successfully executed Accept() on alert.", Logger.MessageType.INF);
            }
            else
            {
                throw new Exception("No alert with " + Message + " exists.");
            }
        }

        public bool VerifyAlertText(String ExpectedAlertText)
        {
            String ActAlertText = "";
            if (DoesAlertExist(INT_SHORT_WAIT_SEC))
            {
                ActAlertText = System.Text.RegularExpressions.Regex.Replace(mDriver.Instance.SwitchTo().Alert().Text.Replace("\r\n", " ").Replace("\n", " ").Replace("\r", " "), @"\s+", " ");
            }
            return ExpectedAlertText == ActAlertText;
        }
        
        public void ScrollUp()
        {
            try
            {
                ((OpenQA.Selenium.Remote.RemoteWebDriver)mDriver.Instance).ExecuteScript("scroll(20000,0)");
                mScript.ScriptLogger.WriteLine("Successfully executed ScrollUp()", Logger.MessageType.INF);
            }
            catch (Exception e)
            {
                throw new Exception("ScrollUp() failed : " + e.Message);
            }
        }

        public void ScrollDown()
        {
            try
            {
                ((OpenQA.Selenium.Remote.RemoteWebDriver)mDriver.Instance).ExecuteScript("scroll(0,20000)");
                mScript.ScriptLogger.WriteLine("Successfully executed ScrollDown()", Logger.MessageType.INF);
            }
            catch (Exception e)
            {
                throw new Exception("ScrollDown() failed : " + e.Message);
            }
        }

        public String ReplaceCarriageReturn(String InputString, String ReplacementString)
        {
            String sResult = "";
            sResult = InputString.Replace("\n\r", ReplacementString);
            sResult = sResult.Replace("\r\n", ReplacementString);
            sResult = sResult.Replace("\n", ReplacementString);
            sResult = sResult.Replace("\r", ReplacementString);
            return sResult;
        }
        
        #endregion

        #region PRIVATE METHODS
        private bool IsModalFormDisplayed()
        {
            IWebElement qry = mDriver.Instance.FindElements(By.Id("qryFrm")).First();
            IWebElement printOptions = mDriver.Instance.FindElements(By.Id("printSetupForm")).First();
            IWebElement pageSetup = mDriver.Instance.FindElements(By.Id("pageSetupForm")).First();
            IWebElement processProgress = mDriver.Instance.FindElements(By.Id("progMtrDiv")).First();

            if (qry.GetCssValue("visibility") == "visible")
            {
                return true;
            }
            if (printOptions.GetCssValue("visibility") == "visible")
            {
                return true;
            }
            if (pageSetup.GetCssValue("visibility") == "visible")
            {
                return true;
            }
            if (pageSetup.GetCssValue("display") == "block")
            {
                return true;
            }
            return false;
        }
        #endregion
    }
}