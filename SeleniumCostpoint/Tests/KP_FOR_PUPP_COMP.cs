using Core.Sys;
using Core.Sys.Selenium;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumCostpoint.Tests
{
    public class KP_FOR_PUPP_COMP: SeleniumTestScript
    {
        public override bool TestExecute(out string ErrorMessage, string TestEnvironment, IDriver Driver)
        {
            bool ret = true;
            ErrorMessage = string.Empty;
            SeleniumDriver sDriver = Driver as SeleniumDriver;
            try
            {
                // Log in
                Step("Logging in", () => {
                    const string URL = "https://knowledgepointcorestaging.azurewebsites.net/login";
                    const string USER_NAME = "qcdeltekbpmadm.01@gmail.com";
                    const string PASSWORD = "Deltekpassword12345!";

                    sDriver.Instance.Url = URL;

                    var username = new SeleniumControl(sDriver, "UserName", "xpath", "//input[@id='signInName']");
                    var password = new SeleniumControl(sDriver, "Password", "xpath", "//input[@id='password']");
                    var loginBtn = new SeleniumControl(sDriver, "Password", "xpath", "//button[@id='next']");

                    username.SendKeys(USER_NAME);
                    password.SendKeys(PASSWORD);
                    loginBtn.Click();
                });

                // STEP 1 - Prepare for navigation
                Step("Clicking Hamburger button", () => {
                    ScriptLogger.WriteLine("Navigating", Logger.MessageType.INF);

                    var hamburger = new SeleniumControl(sDriver, "Hamburger", "xpath", "//button[@data-testid='hamburgerMenu']");

                    hamburger.Click();
                });

                // STEP 2 - Navigate
                Step("Navigating", () => {
                    ScriptLogger.WriteLine("Navigating", Logger.MessageType.INF);

                    var settings = new SeleniumControl(sDriver, "Settings", "xpath", "//div[@data-testid='sidebarNavListItemSettings']");
                    settings.Click();

                    var manageUsers = new SeleniumControl(sDriver, "ManageUsers", "xpath", "//a[@data-testid='sidebarNavListItemManageUsers']");
                    manageUsers.Click();
                });

                // STEP 3 - Click add new user button
                Step("Click add new user button", () => {
                    var newUser = new SeleniumControl(sDriver, "NewUser", "xpath", "//button[@data-testid='btnAddNewUser']");
                    newUser.Click();
                });

                // STEP 4 - Input first name
                Step("Click add new user button", () => {
                    var firstName = new SeleniumControl(sDriver, "firstName", "xpath", "//input[@name='firstName']");
                    firstName.SendKeys("Shannen");
                });
                // STEP 5 - Input last name
                Step("Click add new user button", () => {
                    var firstName = new SeleniumControl(sDriver, "firstName", "xpath", "//input[@name='lastName']");
                    firstName.SendKeys("Tan");
                });

                // STEP 6 - Input user email
                Step("Click add new user button", () => {
                    var firstName = new SeleniumControl(sDriver, "firstName", "xpath", "//input[@name='userEmail']");
                    firstName.SendKeys("shannenvalerietan@deltek.com");
                });

                // STEP 7 - Click cancel
                Step("Click add new user button", () => {
                    var firstName = new SeleniumControl(sDriver, "firstName", "xpath", "//button[@data-testid='btnCancel']");
                    firstName.Click();
                });
            }
            catch (Exception ex)
            {
                ret = false;
                ErrorMessage = ex.Message;
                throw new Exception(ex.Message);
            }

            return ret;

            void Step(string title, Action script)
            {
                try
                {
                    ScriptLogger.WriteLine(title, Logger.MessageType.INF);
                    script();
                }
                catch (Exception ex)
                {
                    throw new Exception(TraceMessage(title, ex.Message));
                }
            }
        }
    }
}
