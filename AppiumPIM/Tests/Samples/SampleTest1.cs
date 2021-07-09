using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Core.Sys;
using Core.Sys.Appium;

namespace AppiumPIM.Tests
{
    public class SampleTest1 : AppiumTestScript
    {
        public override bool TestExecute(out string ErrorMessage, string TestEnvironment, IDriver Driver)
        {
            var ret = true;
            var appDriver = Driver as AppiumDriver;
            var function = new Functions(appDriver);
            ErrorMessage = string.Empty;
            try
            {
                /* Login */
                appDriver.SessionLogger.WriteLine("Logging in...", Logger.MessageType.INF);
                function.Login(TestEnvironment);
                appDriver.SessionLogger.WriteLine("Successfully logged-in.", Logger.MessageType.INF);

                /* Display sidebar */
                try
                {
                    appDriver.SessionLogger.WriteLine("Displaying header...", Logger.MessageType.INF);
                    new AppiumControl(appDriver, "DisplaySideBar", "ID", "android:id/home").Tap();
                }
                catch (Exception ex)
                {
                    throw new Exception(appDriver.SessionLogger.TraceMessage("Error displaying sidebar.", ex.Message));
                }

                /* Verify Sidebar exists */
                try
                {
                    appDriver.SessionLogger.WriteLine("Verifying Sidebar existence...", Logger.MessageType.INF);
                    if (!new AppiumControl(appDriver, "SideBar", "ID", "left_drawer").Exists())
                    {
                        throw new Exception("SideBar does not exists.");
                    }
                    appDriver.SessionLogger.WriteLine("Sidebar exists.", Logger.MessageType.INF);

                }
                catch (Exception ex)
                {
                    throw new Exception(appDriver.SessionLogger.TraceMessage("Error verifying sidebar existence.", ex.Message));
                }

                /* Selecting 'Settings' from Sidebar */
                try
                {
                    appDriver.SessionLogger.WriteLine("Selecting 'Settings' from sidebar...", Logger.MessageType.INF);
                    /* Get all items in sidebar */
                    var sidebar = appDriver.Instance.FindElements(By.Id("left_drawer")).FirstOrDefault();
                    if (sidebar == null)
                    {
                        throw new Exception("SideBar does not exists.");
                    }
                    var items = sidebar.FindElements(By.XPath(
                        ".//*[contains(@resource-id,'menuText')]/ancestor::*[@class='android.widget.LinearLayout']"));
                    if (items.Any())
                    {
                        var target = items.ToList().FindAll(x => x.Displayed).Select(x => x.FindElement(By.Id("menuText")))
                            .Select(x => new AppiumControl(appDriver, "item", x))
                            .FirstOrDefault(x => x.GetValue().Trim().ToLower() == "settings");
                        if (target == null)
                        {
                            throw new Exception("'Settings' not found in sidebar.");
                        }
                        appDriver.SessionLogger.WriteLine("'Settings' found...", Logger.MessageType.INF);
                        target.Tap();
                        appDriver.SessionLogger.WriteLine("'Settings' successfully selected.", Logger.MessageType.INF);
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(appDriver.SessionLogger.TraceMessage("Error selecting 'Settings' from sidebar.", ex.Message));
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
