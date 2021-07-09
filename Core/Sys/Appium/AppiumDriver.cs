using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Chrome;
using APPIUM=OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.iOS;
using OpenQA.Selenium.Appium.Android;
using Core.Sys;

namespace Core.Sys.Appium
{
    public class AppiumDriver : IDriver
    {
        public APPIUM.AppiumDriver<APPIUM.AppiumWebElement> Instance { get; set; }
        public enum Platform
        {
            ANDROID_APP,
            ANDROID_CHROME,
            IOS_APP,
            IOS_SAFARI
        }
        public Platform TargetPlatform { get; set; }
        public string PackageID { get; set; }
        public string PackagePath { get; set; }
        public Device TargetDevice { get; set; }
        public string Url { get; set; }
        public Logger SessionLogger { get; set; }
        public string InitialAppActivity { get; set; }

        public AppiumDriver(Platform TestPlatform, string AppID, string Path,  Device TestDevice, string AppUrl, Logger Logs, string AppActivity="")
        {
            TargetPlatform = TestPlatform;
            PackageID = AppID;
            PackagePath = Path;
            TargetDevice = TestDevice;
            Url = AppUrl;
            SessionLogger = Logs;
            InitialAppActivity = AppActivity;
        }

        public void CaptureScreenshot(string FileName)
        {
            try
            {
                ((ITakesScreenshot)Instance).GetScreenshot().SaveAsFile(FileName, ScreenshotImageFormat.Png);
            }
            catch
            {
                /* Do nothing */
            }
        }

        public void CloseSession()
        {
            (Instance as APPIUM.AppiumDriver<APPIUM.AppiumWebElement>).CloseApp();
            Instance.Quit();
            Instance = null;
        }

        public void StartSession()
        {
            try
            {
                var capabilities = NewDefaultCapabilities();

                switch (TargetPlatform)
                {
                    case Platform.ANDROID_APP:
                        SetupAndroid(capabilities);
                        capabilities.SetCapability("androidDeviceSocket", PackageID + "_devtools_remote");
                        if (!string.IsNullOrEmpty(InitialAppActivity))
                        {
                            capabilities.SetCapability("appActivity", InitialAppActivity);
                        }
                        Instance = new AndroidDriver<APPIUM.AppiumWebElement>(new Uri(Url), capabilities);
                        break;
                    case Platform.ANDROID_CHROME:
                        SetupAndroid(capabilities);
                        capabilities.SetCapability("automationName", "Appium");
                        capabilities.SetCapability(CapabilityType.BrowserName, "chrome");
                        Instance = new AndroidDriver<APPIUM.AppiumWebElement>(new Uri(Url), capabilities);
                        break;
                    case Platform.IOS_APP:
                        SetupIOS(capabilities);
                        break;
                    case Platform.IOS_SAFARI:
                        SetupIOS(capabilities);
                        capabilities.SetCapability("nativeWebTap", false);
                        capabilities.SetCapability(CapabilityType.BrowserName, "safari");
                        break;
                    default:
                        throw new Exception("Unsupported platform");
                }
                SetScreenSize();
            }
            catch (Exception ex)
            {
                throw ex;
                // what to do? THROW?
            }
        }

        private void SetScreenSize()
        {
            var isAndroid = TargetPlatform == Platform.ANDROID_APP || TargetPlatform == Platform.ANDROID_CHROME;
            var screenSize = isAndroid ? Instance.Manage().Window.Size
                : Instance.FindElement(By.XPath("//UIAApplication[1]")).Size;
            TargetDevice.Height = screenSize.Height;
            TargetDevice.Width = screenSize.Width;
            TargetDevice.StatusBarHeight = isAndroid ? GetAndroidStatusBarHeight() : 20;
        }

        private int GetAndroidStatusBarHeight()
        {
            int ret = 0;
            try
            {
                SetContext("NATIVE");
                ret = Instance.FindElementById("android:id/content").Location.Y;
            }
            catch
            {
                // do nothing
            }
            finally
            {
                SetContext("WEBVIEW", true);
            }
            return ret;
        }

        private void SetupAndroid(DesiredCapabilities capabilities)
        {
            capabilities.SetCapability("platformName", "Android");
            capabilities.SetCapability("setWebContentsDebuggingEnabled", true);
            capabilities.SetCapability("unicodeKeyboard", true); // disable soft keyboard
            capabilities.SetCapability("app", PackagePath);
            capabilities.SetCapability("appPackage", PackageID);
            capabilities.SetCapability("automationName", "UIAutomator2");

        }

        private void SetupIOS(DesiredCapabilities capabilities)
        {
            capabilities.SetCapability("platformName", "iOS");
            capabilities.SetCapability("nativeWebTap", true);
            capabilities.SetCapability("app", PackageID);
            capabilities.SetCapability("startIWDP", true);
        }

        private DesiredCapabilities NewDefaultCapabilities()
        {
            DesiredCapabilities ret = new DesiredCapabilities();
            ret.SetCapability(CapabilityType.IsJavaScriptEnabled, true);
            ret.SetCapability("platformVersion", TargetDevice.Version);
            ret.SetCapability("deviceName", TargetDevice.Name);

            return ret;
        }

        public void SetContext(string Context, bool DontWait=false)
        {
            for (int i = 0; i < 60; i++)
            {
                var contexts = Instance.Contexts;

                foreach (string ctx in contexts)
                {
                    if (ctx.Contains(Context))
                    {
                        Instance.Context = ctx;
                        return;
                    }
                    else if (DontWait)
                    {
                        return;
                    }
                }
                Thread.Sleep(1000);
            }
        }

    }
}
