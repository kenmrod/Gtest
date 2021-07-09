using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Core.Sys;
using Core.Sys.Appium;

namespace AppiumPIM
{
    public class Functions
    {
        private const int INT_WAIT_QUICK_MS = 500;
        private const int INT_WAIT_MED_MS = 1000;
        private const int INT_WAIT_MED_S = 1;
        private const int INT_WAIT_LONG_MS = 3000;
        private const int INT_WAIT_LONG_S = 3;
        private const int INT_WAIT_MAX_SPINNER_S = 30;

        private AppiumDriver mDriver = null;
        public Functions(AppiumDriver Driver)
        {
            mDriver = Driver;
        }

        public virtual void Login(string EnvironmentID)
        {
            try
            {
                var appEnv = MyEnvironments.Environments.FirstOrDefault(x => x.UniqueName == EnvironmentID);
                //var appDriver = mDriver as AppiumDriver;
                if (appEnv == null)
                {
                    throw new Exception("Cannot find environment id: " + EnvironmentID);
                }
                if (!string.IsNullOrEmpty(appEnv.Database))
                {
                    new AppiumControl(mDriver, "ClientCode", "ID", "clientCode").SendKeys(appEnv.Database);
                    new AppiumControl(mDriver, "CompleteSetup", "ID", "getSettings").Tap();
                    new AppiumControl(mDriver, "Username", "ID", "email").SendKeys(appEnv.Username);
                    new AppiumControl(mDriver, "Password", "ID", "password").SendKeys(appEnv.Password);
                    new AppiumControl(mDriver, "SignIn", "ID", "sign_in_button").Tap();
                    WaitForSpinnerToFinishLoading();

                    AppiumControl allow = new AppiumControl(mDriver, "Allow", "ID", "com.android.packageinstaller:id/permission_allow_button");

                    while (allow.Exists())
                    {
                        mDriver.SessionLogger.WriteLine("Permission prompt/s detected...", Logger.MessageType.INF);
                        AppiumControl allowDesc = new AppiumControl(mDriver, "Description", "ID", "com.android.packageinstaller:id/permission_message");
                        mDriver.SessionLogger.WriteLine("Allowing permission: " + allowDesc.GetValue() ?? "Unknown", Logger.MessageType.INF);
                        allow.Tap();
                    }

                    AppiumControl syncDialog = new AppiumControl(mDriver, "SyncDialog", "XPATH", 
                        "//*[@resource-id='android:id/progress']/ancestor::*[@resource-id='android:id/body']");
                    int initialWaitForSync = INT_WAIT_LONG_S;
                    while(syncDialog.Exists(initialWaitForSync))
                    {
                        initialWaitForSync = INT_WAIT_MED_S;
                        mDriver.SessionLogger.WriteLine("Sync in progress. Waiting to finish...", Logger.MessageType.INF);
                        //Thread.Sleep(INT_WAIT_MED_MS);
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception("Login cannot proceed. " + e.Message);
            }
        }

        public virtual void WaitForSpinnerToFinishLoading()
        {
            for (int sleep = 1; sleep <= INT_WAIT_MAX_SPINNER_S; sleep++)
            {
                var spinner = new AppiumControl(mDriver as AppiumDriver, "Spinner", "XPATH", "//*[@class='android.widget.ProgressBar']");
                if (spinner.Exists(1))
                {
                    mDriver.SessionLogger.WriteLine("Waiting for page to load..." + sleep + "s elapsed.", Logger.MessageType.INF);
                }
                else
                {
                    mDriver.SessionLogger.WriteLine("Page loaded. " + sleep + "s elapsed.", Logger.MessageType.INF);
                    return;
                }
            }
            mDriver.SessionLogger.WriteLine("Page still loading. Timeout of " + INT_WAIT_MAX_SPINNER_S + "s reached.", Logger.MessageType.WRN);
        }
    }
}
