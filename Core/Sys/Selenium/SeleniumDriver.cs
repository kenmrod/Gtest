﻿using Microsoft.Win32;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Threading;
using System.Linq;
using OpenQA.Selenium.Remote;

namespace Core.Sys.Selenium
{
    public class SeleniumDriver : IDriver
    {
        #region PROPERTIES
        public enum Browser
        {
            IE,
            FIREFOX,
            CHROME,
            CHROME_HEADLESS
        }
        public string BrowserType
        {
            get { return GetBrowserTypeToWrite(mBrowser); }
        }
        private Browser mBrowser = Browser.CHROME_HEADLESS;
        public SeleniumDriver.Browser TargetBrowser
        {
            get
            {
                return mBrowser;
            }
            set
            {
                mBrowser = value;
            }
        }
        public IWebDriver Instance { get; set; }
        public Logger SessionLogger { get; set; }
        public Uri RemoteURI { get; set; }
        #endregion

        #region PUBLIC METHODS
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="Logs">Contains the logs for the execution</param>
        public SeleniumDriver(Logger Logs)
        {
            SessionLogger = Logs;
        }

        /// <summary>
        /// Starts the driver session
        /// </summary>
        public void StartSession()
        {
            StartBrowser();
        }

        /// <summary>
        /// Assigns the correct driver to AutoDriver based on the browser type (firefox, ie, etc) and starts the browser
        /// </summary>
        /// <param name="HideDriver">Flag whether to display or hide driver console window</param>
        public void StartBrowser(bool HideDriver = false)
        {
            //Cursor.Position = new Point(0, 0);
            switch (TargetBrowser)
            {
                case Browser.FIREFOX:
                case Browser.CHROME:
                case Browser.IE:
                case Browser.CHROME_HEADLESS:
                    string error;
                    /* Implement a recovery logic, to try again once if first attempt to instantiate webdriver fails */
                    if (!CreateWebDriver(mBrowser, out error, HideDriver))
                    {
                        SessionLogger.WriteLine("WebDriver failed to initialize browser. Retrying...", Logger.MessageType.WRN);
                        CloseSession();
                        if (!CreateWebDriver(mBrowser, out error, HideDriver))
                        {
                            CloseSession();
                            throw new Exception("WebDriver could not recover from fatal error and exited with the following message: \""
                                + error + "\"");
                        }
                    }
                    break;
                default:
                    break;
            }
            // default timeout settings
            Instance.Manage().Timeouts().ImplicitWait = new TimeSpan(0, 0, 1);
            Instance.Manage().Timeouts().AsynchronousJavaScript = new TimeSpan(0, 0, 1);
        }

        /// <summary>
        /// Kills WebDriver instance and closes all associated browser windows
        /// </summary>
        public void CloseSession()
        {
            try
            {
                Instance.Quit(); // quit nicely
                Instance = null;
                Thread.Sleep(3000); // wait
            }
            catch
            {
                /* Do nothing */
            }
        }
        

        /// <summary>
        /// Captures a screenshot and saves the file given the specified filename.
        /// </summary>
        /// <param name="FileName"></param>
        public void CaptureScreenshot(string FileName)
        {
            try
            {
                ((ITakesScreenshot)Instance).GetScreenshot().SaveAsFile(FileName, ScreenshotImageFormat.Png);
            }
            catch
            {
                // swallow
            }
        }
        #endregion

        #region PRIVATE METHODS
        /// <summary>
        /// Checks registry for installed browsers
        /// </summary>
        /// <param name="browserName"></param>
        /// <returns></returns>
        private string GetBrowserPathFromRegistry(string browserName)
        {
            string ret = string.Empty;
            try
            {
                /*Determine whether the OS is 64bit/32bit and set the registry path */
                string regPath = @"SOFTWARE\Clients\StartMenuInternet"; //default for 32bit systems
                if (Environment.Is64BitOperatingSystem)
                    regPath = @"SOFTWARE\WOW6432Node\Clients\StartMenuInternet";

                RegistryKey mInstalledBrowsers = Registry.LocalMachine.OpenSubKey(regPath);
                string[] mBrowsers = mInstalledBrowsers.GetSubKeyNames();
                var selectedBrowser = mBrowsers.FirstOrDefault(x => mInstalledBrowsers.OpenSubKey(x).GetValue(null).ToString().ToLower().Contains(browserName));

                if (!string.IsNullOrEmpty(selectedBrowser))
                {
                    RegistryKey browserKey = mInstalledBrowsers.OpenSubKey(selectedBrowser);
                    RegistryKey browserPath = browserKey.OpenSubKey(@"shell\open\command");


                    ret = RemoveQuotesFromPath((string)browserPath.GetValue(null).ToString());
                }
            }
            catch
            {
                //do nothing if error occured
            }
            return ret;
        }

        /// <summary>
        /// Removes extra characters from file path
        /// </summary>
        private string RemoveQuotesFromPath(string text)
        {
            if (text.EndsWith("\"") && text.StartsWith("\""))
            {
                return text.Substring(1, text.Length - 2);
            }
            else if (text.StartsWith("FirefoxBinary("))
            {
                return text.Substring(14, text.Length - 15);
            }
            else
            {
                return text;
            }
        }

        /// <summary>
        /// Create driver instance
        /// </summary>
        /// <param name="BrowserName">Name of driver to create</param>
        /// <param name="ErrorMessage">Error container in case of error</param>
        /// <param name="HideDriver">Flag whether to display or hide driver console window</param>
        /// <returns>TRUE if successful; FALSE otherwise</returns>
        private bool CreateWebDriver(Browser BrowserToCreate, out string ErrorMessage, bool HideDriver = false)
        {
            bool ret = true;
            ErrorMessage = string.Empty;
            try
            {
                switch (BrowserToCreate)
                {
                    case Browser.FIREFOX:
                        FirefoxOptions ffo = new FirefoxOptions();
                        ffo.BrowserExecutableLocation = GetBrowserPathFromRegistry("firefox");
                        /* unsupported yet by Maroinette (geckodriver) but default is Ignore as tested */
                        //ffo.UnhandledPromptBehavior = UnhandledPromptBehavior.Ignore;
                        ffo.SetPreference("browser.fixup.alternate.enabled", false);
                        ffo.SetPreference("browser.download.useDownloadDir", false);
                        if (HideDriver)
                        {
                            FirefoxDriverService svc = FirefoxDriverService.CreateDefaultService();
                            svc.HideCommandPromptWindow = true;
                            Instance = RemoteURI != null ? new RemoteWebDriver(RemoteURI, ffo) : new FirefoxDriver(svc, ffo, new TimeSpan(0, 0, 1));
                        }
                        else
                        {
                            Instance = RemoteURI != null ? new RemoteWebDriver(RemoteURI, ffo) : new FirefoxDriver(ffo);
                        }
                        Instance.Manage().Window.Maximize();
                        break;
                    case Browser.CHROME:
                        ChromeOptions ChromeCapabilities = new ChromeOptions();
                        ChromeCapabilities.AddArgument("--test-type");
                        ChromeCapabilities.AddArgument("--start-maximized=true");
                        ChromeCapabilities.AddArgument("disable-infobars");
                        ChromeCapabilities.AcceptInsecureCertificates = true;
                        if (HideDriver)
                        {
                            ChromeDriverService svc = ChromeDriverService.CreateDefaultService();
                            svc.HideCommandPromptWindow = true;
                            Instance = RemoteURI != null ? new RemoteWebDriver(RemoteURI, ChromeCapabilities) : new ChromeDriver(svc, ChromeCapabilities);
                        }
                        else
                        {
                            Instance = RemoteURI != null ? new RemoteWebDriver(RemoteURI, ChromeCapabilities) : new ChromeDriver(ChromeCapabilities);
                        }
                        Instance.Manage().Window.Maximize();
                        break;
                    case Browser.IE:
                        InternetExplorerOptions opt = new InternetExplorerOptions();
                        opt.UnhandledPromptBehavior = UnhandledPromptBehavior.Ignore;
                        opt.EnablePersistentHover = false;
                        if (HideDriver)
                        {
                            var svc = InternetExplorerDriverService.CreateDefaultService();
                            svc.HideCommandPromptWindow = true;
                            Instance = RemoteURI != null ? new RemoteWebDriver(RemoteURI, opt) : new InternetExplorerDriver(svc, opt);
                        }
                        else
                        {
                            Instance = RemoteURI != null ? new RemoteWebDriver(RemoteURI, opt) : new InternetExplorerDriver(opt);
                        }
                        Instance.Manage().Window.Maximize();
                        break;                  
                    case Browser.CHROME_HEADLESS:
                        ChromeOptions ChromeHeadlessCapabilities = new ChromeOptions();
                        ChromeHeadlessCapabilities.AddArgument("headless");
                        //Chrome Headless must run in fixed size for now. Ideal dimension for Storm VMs is 1920x1080.
                        ChromeHeadlessCapabilities.AddArgument("window-size=1920x1080");
                        ChromeHeadlessCapabilities.AddArgument("disable-gpu");
                        ChromeHeadlessCapabilities.AddArgument("proxy-server='direct://'");
                        ChromeHeadlessCapabilities.AddArgument("proxy-bypass-list=*");
                        ChromeHeadlessCapabilities.AcceptInsecureCertificates = true;
                        if (HideDriver)
                        {
                            ChromeDriverService svc = ChromeDriverService.CreateDefaultService();
                            svc.HideCommandPromptWindow = true;
                            Instance = RemoteURI != null ? new RemoteWebDriver(RemoteURI, ChromeHeadlessCapabilities.ToCapabilities(), TimeSpan.FromMinutes(3)) : new ChromeDriver(svc, ChromeHeadlessCapabilities);
                        }
                        else
                        {
                            Instance = RemoteURI != null ? new RemoteWebDriver(RemoteURI, ChromeHeadlessCapabilities.ToCapabilities(), TimeSpan.FromMinutes(3)) : new ChromeDriver(ChromeHeadlessCapabilities);
                        }
                        //AutoDriver.Manage().Window.Maximize();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception e)
            {
                ErrorMessage = e.Message;
                ret = false;
            }
            return ret;
        }
            
        private  string GetBrowserTypeToWrite(Browser BrowserType)
        {
            string ret = string.Empty;
            switch (BrowserType)
            {
                case Browser.CHROME:
                    ret = "chrome";
                    break;
                case Browser.FIREFOX:
                    ret = "firefox";
                    break;
                case Browser.IE:
                    ret = "ie";
                    break;
                default:
                    break;
            }
            return ret;
        }
        #endregion
    }
}
