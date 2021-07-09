using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using System.Threading;


namespace Core.Sys.Selenium
{
    /// <summary>
    /// This is commonly used as the base control for all other controls. It provides a basic interface with Selenium
    /// </summary>
    public class SeleniumControl : IControl
    {
        #region DECLARATIONS
        /// <summary>
        /// this is a default time to search. it is public so it can be adjusted as needed
        /// </summary>
        public int iFindElementDefaultSearchMax { get; set; }

        /// <summary>
        /// an assignable list of elements
        /// </summary>
        public IList<IWebElement> mElms { get; set; }

        /// <summary>
        /// the element we are interacting with. Selenium deals with elements; we wrap logic into controls as that allows us to provide
        /// a practical experience (i.e. textboxes cannot do the same as buttons)
        /// </summary>
        public IWebElement mElement;

        /// <summary>
        /// the contol name we searched for... assigned when we construct a control
        /// </summary>
        public String mControlName { get; set; }

        /// <summary>
        /// the parent control where the control will be searched
        /// </summary>
        public SeleniumControl mParentControl = null;

        /// <summary>
        /// used with mSearchValues to determine how we find the control... assigned when we contruct a control
        /// </summary>
        public String mSearchType { get; set; }

        /// <summary>
        /// used with mSearchType to determine how we find the control... assigned when we contruct a control
        /// </summary>
        public String[] mSearchValues { get; set; }

        private Boolean IsDeclaredAsExistngWebElement = false;

        private SeleniumDriver mDriver = null;
        #endregion
        
        /// <summary>
        /// constructor for a SeleniumControl which acts as our interface to selenium logic
        /// </summary>
        /// <param name="ControlName"></param>
        /// <param name="SearchType"></param>
        /// <param name="SearchValue"></param>
        public SeleniumControl(SeleniumDriver Driver, String ControlName, String SearchType, String SearchValue)
        {
            mControlName = ControlName;
            mSearchType = SearchType;
            mSearchValues = new String[] { SearchValue };
            iFindElementDefaultSearchMax = 40;
            mDriver = Driver;
        }

        /// <summary>
        /// constructor for a SeleniumControl which acts as our interface to selenium logic
        /// </summary>
        /// <param name="ControlName"></param>
        /// <param name="SearchType"></param>
        /// <param name="SearchValues"></param>
        public SeleniumControl(SeleniumDriver Driver, String ControlName, String SearchType, String[] SearchValues)
        {
            mControlName = ControlName;
            mSearchType = SearchType;
            mSearchValues = SearchValues;
            iFindElementDefaultSearchMax = 40;
            mDriver = Driver;
        }

        /// <summary>
        /// constructor for a SeleniumControl which acts as our interface to selenium logic
        /// </summary>
        /// <param name="ControlName"></param>
        /// <param name="ExistingWebElement"></param>
        public SeleniumControl(SeleniumDriver Driver, String ControlName, IWebElement ExistingWebElement)
        {
            mControlName = ControlName;
            mElement = ExistingWebElement;
            IsDeclaredAsExistngWebElement = true;
            iFindElementDefaultSearchMax = 40;
            mDriver = Driver;
        }

        /// <summary>
        /// constructor for a DlkControl which acts as our interface to selenium logic
        /// </summary>
        /// <param name="ControlName"></param>
        /// <param name="ParentControl"></param>
        /// <param name="SearchType"></param>
        /// <param name="SearchValue"></param>
        public SeleniumControl(SeleniumDriver Driver, String ControlName, SeleniumControl ParentControl, String SearchType, String SearchValue)
        {
            mControlName = ControlName;
            mParentControl = ParentControl;
            mSearchType = SearchType;
            mSearchValues = new String[] { SearchValue };
            iFindElementDefaultSearchMax = 40;
        }

        /// <summary>
        /// Used to find an element. An element must be found before being used.
        /// </summary>
        public void FindElement()
        {
            FindElement(iFindElementDefaultSearchMax); // look for upto n seconds by default
        }

        /// <summary>
        /// Used to find an element. An element must be found before being used.
        /// </summary>
        /// <param name="iSecToWait"></param>
        public void FindElement(int iSecToWait)
        {
            if (mParentControl != null)
            {
                FindElementFromParent(iSecToWait);
            }
            else
            {
                if (IsDeclaredAsExistngWebElement)
                {
                    return;
                }

                mElement = null;
                Stopwatch mWatch = Stopwatch.StartNew();
                mWatch.Start();
                int i = 0, iMax = iSecToWait * 1000;
                Boolean bFound = false;
                while (mWatch.ElapsedMilliseconds < iMax)
                {
                    try
                    {
                        switch (mSearchType.ToLower())
                        {
                            case "id":
                                mElement = mDriver.Instance.FindElement(By.Id(mSearchValues[0]));
                                break;
                            case "iframe_xpath":
                                string iframeName = mSearchValues[0].Substring(0, mSearchValues[0].IndexOf('_'));
                                string searchVal = mSearchValues[0].Substring(mSearchValues[0].IndexOf('_') + 1, mSearchValues[0].Length - mSearchValues[0].IndexOf('_') - 1);

                                int n;
                                bool isNumeric = int.TryParse(iframeName, out n);

                                IList<IWebElement> frames;
                                if (isNumeric)
                                {
                                    frames = mDriver.Instance.FindElements(By.XPath("//iframe"));
                                    Thread.Sleep(1000);
                                    mDriver.Instance.SwitchTo().Frame(frames[n]);
                                    mElement = mDriver.Instance.FindElement(By.XPath(searchVal));
                                }
                                else
                                    mElement = mDriver.Instance.SwitchTo().Frame(iframeName).FindElement(By.XPath(searchVal));
                                break;
                            case "iframe_nested_xpath":
                                string iframeName0 = mSearchValues[0].Substring(0, mSearchValues[0].IndexOf('_'));
                                string[] nestedFrames = iframeName0.Split('~');
                                string searchVal0 = mSearchValues[0].Substring(mSearchValues[0].IndexOf('_') + 1, mSearchValues[0].Length - mSearchValues[0].IndexOf('_') - 1);

                                foreach (string frm in nestedFrames)
                                {
                                    IList<IWebElement> frames0;
                                    int p;
                                    bool isNumeric0 = int.TryParse(frm, out p);
                                    if (isNumeric0)
                                    {
                                        frames0 = mDriver.Instance.FindElements(By.XPath("//iframe"));
                                        Thread.Sleep(1000);
                                        mDriver.Instance.SwitchTo().Frame(frames0[p]);
                                    }
                                    else
                                    {
                                        mDriver.Instance.SwitchTo().Frame(frm);
                                    }
                                }
                                mElement = mDriver.Instance.FindElement(By.XPath(searchVal0));
                                break;
                            case "iframe_id":
                                string iframeName1 = mSearchValues[0].Substring(0, mSearchValues[0].IndexOf('_'));
                                string searchVal1 = mSearchValues[0].Substring(mSearchValues[0].IndexOf('_') + 1, mSearchValues[0].Length - mSearchValues[0].IndexOf('_') - 1);

                                int m;
                                bool isNumeric1 = int.TryParse(iframeName1, out m);

                                IList<IWebElement> frames1;
                                if (isNumeric1)
                                {
                                    frames1 = mDriver.Instance.FindElements(By.XPath("//iframe"));
                                    Thread.Sleep(1000);
                                    mDriver.Instance.SwitchTo().Frame(frames1[m]);
                                    mElement = mDriver.Instance.FindElement(By.Id(searchVal1));
                                }
                                else
                                    mElement = mDriver.Instance.SwitchTo().Frame(iframeName1).FindElement(By.XPath(searchVal1));
                                break;
                            case "linktext":
                                mElement = mDriver.Instance.FindElement(By.LinkText(mSearchValues[0]));
                                break;
                            case "name":
                                mElement = mDriver.Instance.FindElement(By.Name(mSearchValues[0]));
                                break;
                            case "css":
                                mElement = mDriver.Instance.FindElement(By.CssSelector(mSearchValues[0]));
                                break;
                            case "xpath":
                                mElement = mDriver.Instance.FindElement(By.XPath(mSearchValues[0]));
                                break;
                            case "classname":
                            case "class":
                                mElement = mDriver.Instance.FindElement(By.ClassName(mSearchValues[0]));
                                break;
                            case "partiallinktext":
                                mElement = mDriver.Instance.FindElement(By.PartialLinkText(mSearchValues[0]));
                                break;
                            case "tagname_text":
                                mElms = mDriver.Instance.FindElements(By.TagName(mSearchValues[0]));
                                foreach (IWebElement mElm in mElms)
                                {
                                    if (mElm.Text == mSearchValues[1])
                                    {
                                        mElement = mElm;
                                        break;
                                    }
                                }
                                break;
                            case "tagname_attribute":
                                mElms = mDriver.Instance.FindElements(By.TagName(mSearchValues[0]));
                                foreach (IWebElement mElm in mElms)
                                {
                                    if (mElm.GetAttribute(mSearchValues[1]).ToString() == mSearchValues[2])
                                    {
                                        mElement = mElm;
                                        break;
                                    }

                                }
                                break;
                            case "img_src":
                                mElms = mDriver.Instance.FindElements(By.TagName("img"));
                                foreach (IWebElement mElm in mElms)
                                {
                                    if (mElm.GetAttribute("src") == null)
                                    {
                                    }
                                    else if (mElm.GetAttribute("src").Contains(mSearchValues[0]))
                                    {
                                        mElement = mElm;
                                        break;
                                    }
                                }
                                break;
                            case "  ":
                                mElement = mDriver.Instance.FindElement(By.Id(mSearchValues[0])).FindElement(By.TagName(mSearchValues[1]));
                                break;
                            case "parentid_childclass":
                                mElement = mDriver.Instance.FindElement(By.Id(mSearchValues[0])).FindElement(By.ClassName(mSearchValues[1]));
                                break;
                            case "parentid_childcss":
                                mElement = mDriver.Instance.FindElement(By.Id(mSearchValues[0])).FindElement(By.CssSelector(mSearchValues[1]));
                                break;
                            case "parentclass_childtag":
                                mElement = mDriver.Instance.FindElement(By.ClassName(mSearchValues[0])).FindElement(By.TagName(mSearchValues[1]));
                                break;
                            case "class_display":
                                mElms = mDriver.Instance.FindElements(By.ClassName(mSearchValues[0]));
                                foreach (IWebElement mElm in mElms)
                                {
                                    if (mElm.Displayed == true)
                                    {
                                        mElement = mElm;
                                        break;
                                    }
                                }
                                break;
                            case "xpath_display":
                                mElms = mDriver.Instance.FindElements(By.XPath(mSearchValues[0]));
                                bool bDisplayed = false;

                                foreach (IWebElement mElm in mElms)
                                {
                                    if (mElm.Displayed)
                                    {
                                        mElement = mElm;
                                        bDisplayed = true;
                                        break;
                                    }
                                }
                                if (!bDisplayed) //bypass this check for mobile
                                {
                                    foreach (IWebElement mElm in mElms)
                                    {
                                        if (mElm.GetCssValue("display") != "none")
                                        {
                                            mElement = mElm;
                                            break;
                                        }
                                    }
                                }
                                break;
                            default:
                                break;
                        }
                        if (mElement != null) // we found and defined the control
                        {
                            bFound = true;
                            break;
                        }
                        else /* Log if element is not found */
                        {
                        }
                    }
                    catch
                    {
                    }
                    Thread.Sleep(100);
                    i = i + (int)mWatch.ElapsedMilliseconds;
                }
                mWatch.Stop();
                if (!bFound)
                {
                    throw new Exception("Couldn't find control [" + mControlName + "] within timeout: " + iSecToWait);
                }
            }
        }

        /// <summary>
        /// Used to find an element from a parent element. An element must be found before being used.
        /// </summary>
        /// <param name="iSecToWait"></param>
        public void FindElementFromParent(int iSecToWait)
        {
            mParentControl.FindElement();
            mElement = null;
            Stopwatch mWatch = Stopwatch.StartNew();
            mWatch.Start();
            int i = 0, iMax = iSecToWait * 1000;
            Boolean bFound = false;
            while (mWatch.ElapsedMilliseconds < iMax)
            {
                try
                {
                    switch (mSearchType.ToLower())
                    {
                        case "id":
                            mElement = mParentControl.mElement.FindElement(By.Id(mSearchValues[0]));
                            break;
                        case "linktext":
                            mElement = mParentControl.mElement.FindElement(By.LinkText(mSearchValues[0]));
                            break;
                        case "name":
                            mElement = mParentControl.mElement.FindElement(By.Name(mSearchValues[0]));
                            break;
                        case "css":
                            mElement = mParentControl.mElement.FindElement(By.CssSelector(mSearchValues[0]));
                            break;
                        case "xpath":
                            mElement = mParentControl.mElement.FindElement(By.XPath(mSearchValues[0]));
                            break;
                        case "classname":
                        case "class":
                            mElement = mParentControl.mElement.FindElement(By.ClassName(mSearchValues[0]));
                            break;
                        case "partiallinktext":
                            mElement = mParentControl.mElement.FindElement(By.PartialLinkText(mSearchValues[0]));
                            break;
                        case "tagname_text":
                            mElms = mParentControl.mElement.FindElements(By.TagName(mSearchValues[0]));
                            foreach (IWebElement mElm in mElms)
                            {
                                if (mElm.Text == mSearchValues[1])
                                {
                                    mElement = mElm;
                                    break;
                                }
                            }
                            break;
                        case "tagname_attribute":
                            mElms = mParentControl.mElement.FindElements(By.TagName(mSearchValues[0]));
                            foreach (IWebElement mElm in mElms)
                            {
                                if (mElm.GetAttribute(mSearchValues[1]).ToString() == mSearchValues[2])
                                {
                                    mElement = mElm;
                                    break;
                                }

                            }
                            break;
                        case "img_src":
                            mElms = mParentControl.mElement.FindElements(By.TagName("img"));
                            foreach (IWebElement mElm in mElms)
                            {
                                if (mElm.GetAttribute("src") == null)
                                {
                                    //skip
                                }
                                else if (mElm.GetAttribute("src").Contains(mSearchValues[0]))
                                {
                                    mElement = mElm;
                                    break;
                                }
                            }
                            break;
                        case "  ":
                            mElement = mParentControl.mElement.FindElement(By.Id(mSearchValues[0])).FindElement(By.TagName(mSearchValues[1]));
                            break;
                        case "parentid_childclass":
                            mElement = mParentControl.mElement.FindElement(By.Id(mSearchValues[0])).FindElement(By.ClassName(mSearchValues[1]));
                            break;
                        case "parentid_childcss":
                            mElement = mParentControl.mElement.FindElement(By.Id(mSearchValues[0])).FindElement(By.CssSelector(mSearchValues[1]));
                            break;
                        case "parentclass_childtag":
                            mElement = mParentControl.mElement.FindElement(By.ClassName(mSearchValues[0])).FindElement(By.TagName(mSearchValues[1]));
                            break;
                        case "class_display":
                            mElms = mParentControl.mElement.FindElements(By.ClassName(mSearchValues[0]));
                            foreach (IWebElement mElm in mElms)
                            {
                                if (mElm.GetCssValue("display") != "none")
                                {
                                    mElement = mElm;
                                    break;
                                }
                            }
                            break;
                        default:
                            break;
                    }
                    if (mElement != null) // we found and defined the control
                    {
                        if (mElement.Displayed == true)
                        {
                            bFound = true;
                            break;
                        }
                    }
                }
                catch
                {
                    //DlkLogger.LogWarning("Couldn't find control [" + mControlName + "] .");
                }
                Thread.Sleep(100);
                i = i + (int)mWatch.ElapsedMilliseconds;
            }
            mWatch.Stop();
            if (!bFound)
            {
                throw new Exception("Couldn't find control [" + mControlName + "] within timeout: " + iSecToWait);
            }
        }

        /// <summary>
        /// According to Selenium doc, this will find the object using coordinates 
        /// </summary>
        public void ClickByObjectCoordinates()
        {
            FindElement();
            OpenQA.Selenium.Interactions.Actions mAction = new OpenQA.Selenium.Interactions.Actions(mDriver.Instance);
            mAction.Click(mElement).Build().Perform();
        }

        /// <summary>
        /// Gets a point for where the object is
        /// </summary>
        /// <param name="bCenterTop"></param>
        /// <returns></returns>
        public Point GetElementLocationOnScreen(Boolean bCenterTop)
        {
            FindElement();
            // off set element location by window position
            Point mWindowPos = new Point(0, 0);
            if (mDriver.TargetBrowser != SeleniumDriver.Browser.CHROME)
            {
                mWindowPos = mDriver.Instance.Manage().Window.Position;
            }
            //DlkLogger.LogDebug("WinPos", mWindowPos);

            Point mPoint = mElement.Location;
            //DlkLogger.LogDebug("Element", mPoint);

            mPoint.Offset(mWindowPos);
            //DlkLogger.LogDebug("Element after position offset", mPoint);

            // adjust to center of element
            if (bCenterTop)
            {
                mPoint.Offset(mElement.Size.Width / 2, 0);
            }
            //DlkLogger.LogDebug("Element after center offset", mPoint);

            int iOffSetHeight = GetWindowHeightOffSet();
            mPoint.Offset(0, iOffSetHeight);

            return mPoint;
        }

        /// <summary>
        /// uses java script to get an offset height
        /// </summary>
        /// <returns></returns>
        public int GetWindowHeightOffSet()
        {
            IJavaScriptExecutor jse = (IJavaScriptExecutor)mDriver.Instance;
            int iOuterHeight = 0, iInnerHeight = 0, iOffSetHeight = 0;
            iOuterHeight = Convert.ToInt32(jse.ExecuteScript("return window.outerHeight"));
            iInnerHeight = Convert.ToInt32(jse.ExecuteScript("return window.innerHeight"));
            iOffSetHeight = iOuterHeight - iInnerHeight;
            return iOffSetHeight;
        }

        /// <summary>
        /// Perfroms a mouse over the element
        /// </summary>
        public void MouseOver()
        {
            Cursor.Position = new Point(0, 0);
            if (mDriver.TargetBrowser == SeleniumDriver.Browser.FIREFOX)
            {
                MouseOverFirefox();
            }
            else
            {
                MouseOverStandard();
            }
        }

        /// <summary>
        /// standard mouse over code using selenium interactions
        /// </summary>
        private void MouseOverStandard()
        {
            FindElement();
            OpenQA.Selenium.Interactions.Actions mAction = new OpenQA.Selenium.Interactions.Actions(mDriver.Instance);
            mAction.MoveToElement(mElement).Build().Perform();
        }

        /// <summary>
        /// firefox specific mouse over code
        /// </summary>
        private void MouseOverFirefox()
        {
            // Firefox works sporadically; we have to try a few things :)
            mDriver.Instance.SwitchTo().Window(mDriver.Instance.CurrentWindowHandle);
            mDriver.Instance.SwitchTo().ActiveElement();
            FindElement();

            //// attempt to move mouse to correctplace
            Point mPoint = GetElementLocationOnScreen(true);
            Cursor.Position = new Point(0, 0);
            Thread.Sleep(250);
            Cursor.Position = mPoint;
            Thread.Sleep(250);

            OpenQA.Selenium.Interactions.Actions mAction = new OpenQA.Selenium.Interactions.Actions(mDriver.Instance);
            for (int i = 1; i <= 5; i++)
            {
                mAction.MoveToElement(mElement).Perform();
                Thread.Sleep(100);
            }
            Thread.Sleep(250);
        }

        /// <summary>
        /// Perfroms a mouse over the element with an offset value
        /// </summary>
        public void MouseOverOffset(int x, int y)
        {
            Cursor.Position = new Point(0, 0);
            //Thread.Sleep(SeleniumDriver.Instance.mMediumWaitMs);
            FindElement();
            Point mPoint = GetElementLocationOnScreen(true);
            Cursor.Position = new Point(0, 0);
            mPoint.Offset(x, y);
            Cursor.Position = mPoint;
            OpenQA.Selenium.Interactions.Actions mAction = new OpenQA.Selenium.Interactions.Actions(mDriver.Instance);
            for (int i = 1; i <= 5; i++)
            {
                mAction.MoveToElement(mElement).Perform();
                Thread.Sleep(100);
            }
        }

        private void MouseOverUsingJavaScript()
        {
            FindElement();
            String mouseOverScript = "if(document.createEvent){" +
                                        " var evObj = document.createEvent('MouseEvents');" +
                                        " evObj.initEvent('mouseover', true, false);" +
                                        " arguments[0].dispatchEvent(evObj);" +
                                        "}" +
                                        "else if(document.createEventObject){" +
                                        " arguments[0].fireEvent('onmouseover');" +
                                        "}";
            IJavaScriptExecutor js = (IJavaScriptExecutor)mDriver.Instance;
            js.ExecuteScript(mouseOverScript, mElement);
        }

        /// <summary>
        /// selenium interactions code to click and hold an element
        /// </summary>
        public void ClickAndHold()
        {
            FindElement();
            OpenQA.Selenium.Interactions.Actions mAction = new OpenQA.Selenium.Interactions.Actions(mDriver.Instance);
            mAction.ClickAndHold(mElement).Build().Perform();
        }

        public void DragAndDropToElement(IWebElement target)
        {
            FindElement();
            OpenQA.Selenium.Interactions.Actions mAction = new OpenQA.Selenium.Interactions.Actions(mDriver.Instance);
            //mAction.DragAndDrop(mElement, target).Build().Perform();
            mAction.ClickAndHold(mElement).MoveToElement(target).Release().Build().Perform();
        }

        public void DragAndDropToOffset(int offsetX, int offsetY)
        {
            FindElement();
            OpenQA.Selenium.Interactions.Actions mAction = new OpenQA.Selenium.Interactions.Actions(mDriver.Instance);
            //mAction.DragAndDropToOffset(mElement, offsetX, offsetY).Build().Perform();
            mAction.ClickAndHold(mElement).MoveByOffset(offsetX, offsetY).Release().Build().Perform();
        }

        /// <summary>
        /// clicks the element if it exists
        /// </summary>
        /// <param name="iMaxTimeToWaitSec"></param>
        /// <param name="bError"></param>
        public void ClickIfExists(int iMaxTimeToWaitSec, Boolean bError)
        {
            if (Exists(iMaxTimeToWaitSec))
            {
                Click();
            }
            else
            {
                if (bError)
                {
                    throw new Exception("Expected control to exist. Control: " + mControlName + ", Timeout: " + iMaxTimeToWaitSec.ToString());
                }
                else
                {
                    //swallow
                }
            }
        }

        private void ClickElement()
        {

            mElement.Click();
        }

        private void ClickElement(int offsetX, int offsetY)
        {
            FindElement();
            OpenQA.Selenium.Interactions.Actions mAction = new OpenQA.Selenium.Interactions.Actions(mDriver.Instance);
            mAction.MoveToElement(mElement, offsetX, offsetY).Click().Perform();
        }

        /// <summary>
        /// Finds and clicks the element
        /// </summary>
        public void Click()
        {
            FindElement();
            ClickElement();
        }

        /// <summary>
        /// finds and clicks the element at a specific point
        /// </summary>
        /// <param name="offsetX"></param>
        /// <param name="offsetY"></param>
        public void Click(int offsetX, int offsetY)
        {
            FindElement();
            ClickElement(offsetX, offsetY);
        }

        /// <summary>
        /// clicks the element and waits n seconds
        /// </summary>
        /// <param name="iSecToWait"></param>
        public void Click(int iSecToWait)
        {
            Click(Convert.ToDouble(iSecToWait));
        }

        /// <summary>
        /// clicks the element and waits n seconds
        /// </summary>
        /// <param name="dbSecToWait"></param>
        public void Click(double dbSecToWait)
        {
            try
            {
                Click();
            }
            catch (Exception e)
            {
                //Known issue with Chrome driver. When an element overlaps the desired element to be clicked, it will render the desired element to be unclickable.
                if (e.Message.Contains("Element is not clickable at point"))
                {
                    Click(5, 5);
                }
                else
                {
                    throw e;
                }
            }
            int iWait = Convert.ToInt32(dbSecToWait * 1000);
            Thread.Sleep(iWait);
        }

        /// <summary>
        /// clicks the element using javascript instead of selenium core logic
        /// </summary>
        public void ClickUsingJavaScript()
        {
            IJavaScriptExecutor jse = (IJavaScriptExecutor)mDriver.Instance;
            jse.ExecuteScript("$(arguments[0]).click()", mElement);
        }

        /// <summary>
        /// Double clicks the element
        /// </summary>
        /// <param name="dbSecToWait"></param>
        public void DoubleClick()
        {
            FindElement();
            OpenQA.Selenium.Interactions.Actions mAction = new OpenQA.Selenium.Interactions.Actions(mDriver.Instance);
            mAction.DoubleClick(mElement).Perform();
        }

        /// <summary>
        /// Sets the focus on the element using javascript instead of selenium core logic
        /// </summary>
        public void FocusUsingJavaScript()
        {
            IJavaScriptExecutor javascript = (IJavaScriptExecutor)mDriver.Instance;
            javascript.ExecuteScript("arguments[0].focus();", mElement);
        }

        public void SendKeys(string text, bool ClearFirst = false)
        {
            FindElement();
            if (ClearFirst)
            {
                mElement.Clear();
            }
            mElement.SendKeys(text);
        }

        /// <summary>
        /// Verifies the element exists
        /// </summary>
        /// <param name="ExpResult"></param>
        public void VerifyExists(Boolean ExpResult)
        {
            Boolean bExists = Exists();
        }
        
        /// <summary>
        /// verifies the element exists within a period
        /// </summary>
        /// <param name="iSecsToWait"></param>
        /// <returns></returns>
        public Boolean Exists(int iSecsToWait)
        {
            Boolean bExists = false;
            try
            {
                FindElement(iSecsToWait);
                if (mElement.Displayed)
                {
                    bExists = true;
                }
            }
            catch
            {
                bExists = false;
            }
            return bExists;
        }

        /// <summary>
        /// true/false if the element exists or not
        /// </summary>
        /// <returns></returns>
        public Boolean Exists()
        {
            Boolean bExists = false;
            bExists = Exists(2);
            return bExists;
        }

        /// <summary>
        /// asserts if the specified attribute has the specified value
        /// </summary>
        /// <param name="AttribName"></param>
        /// <param name="ExpectedValue"></param>
        public void VerifyAttribute(String AttribName, String ExpectedValue)
        {
            String ActValue = GetAttributeValue(AttribName);
        }

        /// <summary>
        /// returns a value for the specified attribute
        /// </summary>
        /// <param name="AttribName"></param>
        /// <returns></returns>
        public String GetAttributeValue(String AttribName)
        {
            FindElement();
            String ActValue = this.mElement.GetAttribute(AttribName);
            if (ActValue != null)
            {
                ActValue = ActValue.Trim();
            }
            return ActValue;

        }

        /// <summary>
        /// gets the path to the element; useful for debugging
        /// </summary>
        /// <returns></returns>
        public String GetPath()
        {
            return GetPath(mElement, false);
        }

        /// <summary>
        /// gets the path to the element; useful for debugging
        /// </summary>
        /// <returns></returns>
        public List<String> GetPathAsList()
        {
            return GetPathAsList(mElement, false);
        }

        /// <summary>
        /// gets the path to the element; useful for debugging
        /// </summary>
        /// <param name="ElementToExamine"></param>
        /// <param name="bStopAtFirstDiv"></param>
        /// <returns></returns>
        public String GetPath(IWebElement ElementToExamine, Boolean bStopAtFirstDiv)
        {
            String result = "";
            for (int i = 0; i < 100; i++)
            {
                try
                {
                    IWebElement mTmp;
                    if (i == 0)
                    {
                        mTmp = ElementToExamine.FindElement(By.XPath("."));
                    }
                    else
                    {
                        mTmp = ElementToExamine.FindElement(By.XPath(".."));
                    }
                    String mTag = mTmp.TagName;
                    if ((mTag == "") || (mTag == null))
                    {
                        break;
                    }
                    String mID = mTmp.GetAttribute("id");
                    String mClass = mTmp.GetAttribute("class");
                    String newData = mTag;
                    if (mID != "")
                    {
                        newData = newData + @"#" + mID;
                    }
                    else
                    {
                        if (mClass != "")
                        {
                            newData = newData + @"." + mClass;
                        }
                    }
                    if (i > 0)
                    {
                        result = ">" + result;
                    }
                    result = newData + result;
                    if (bStopAtFirstDiv)
                    {
                        if (mTag.ToLower() == "div")
                        {
                            break;
                        }
                    }
                    if (mTag == "html")
                    {
                        break;
                    }
                    ElementToExamine = mTmp;
                }
                catch
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>
        /// gets the path to the element; useful for debugging
        /// </summary>
        /// <param name="ElementToExamine"></param>
        /// <param name="bStopAtFirstDiv"></param>
        /// <returns></returns>
        public List<String> GetPathAsList(IWebElement ElementToExamine, Boolean bStopAtFirstDiv)
        {
            String mPath = GetPath(ElementToExamine, bStopAtFirstDiv);
            List<String> mResults = mPath.Split('>').ToList();
            return mResults;
        }
        

        /// <summary>
        /// scrolls the element into view using the Selenium interactions MoveToElement code
        /// </summary>
        public void ScrollIntoView()
        {
            FindElement();
            OpenQA.Selenium.Interactions.Actions mAction = new OpenQA.Selenium.Interactions.Actions(mDriver.Instance);
            mAction.MoveToElement(mElement);
        }

        /// <summary>
        /// Returns a value of an element by looking at these properties: text, textContext, value, innerHtml, innerText
        /// The first property with a value get returned
        /// Please do not reorder the properties : just us GetAttribute where this is not effective
        /// </summary>
        /// <returns></returns>
        public String GetValue()
        {
            String sValue = "";

            if (mElement == null)
            {
                FindElement();
            }

            sValue = mElement.Text;
            if ((sValue != "") && (sValue != null))
            {

                return sValue;
            }

            sValue = mElement.GetAttribute("textContext");
            if ((sValue != "") && (sValue != null))
            {
                return sValue;
            }

            sValue = mElement.GetAttribute("value");
            if ((sValue != "") && (sValue != null))
            {
                return sValue;
            }

            sValue = mElement.GetAttribute("innerText");
            if ((sValue != "") && (sValue != null))
            {
                return sValue;
            }

            sValue = mElement.GetAttribute("innerHTML");
            if ((sValue != "") && (sValue != null) && (sValue != "\r\n"))
            {
                return sValue;
            }

            sValue = mElement.GetAttribute("placeholder");
            if ((sValue != "") && (sValue != null))
            {
                return sValue;
            }

            sValue = mElement.GetAttribute("title");
            if ((sValue != "") && (sValue != null))
            {
                return sValue;
            }

            return "";
        }

        /// <summary>
        /// returns the height of the element
        /// </summary>
        /// <returns></returns>
        public int GetHeight()
        {
            FindElement();
            return Convert.ToInt32(mElement.Size.Height);
        }

        /// <summary>
        /// returns the width of the element
        /// </summary>
        /// <returns></returns>
        public int GetWidth()
        {
            FindElement();
            return Convert.ToInt32(mElement.Size.Width);
        }

        /// <summary>
        /// Set the value of an attribute of the control
        /// </summary>
        /// <param name="attributeName"></param>
        /// <param name="value"></param>
        public void SetAttribute(string attributeName, string value)
        {
            IJavaScriptExecutor javascript = (IJavaScriptExecutor)mDriver.Instance;
            javascript.ExecuteScript("arguments[0].setAttribute(arguments[1], arguments[2])", mElement, attributeName, value);
        }
        
        /// <summary>
        /// Returns "true" if element is read only otherwise "false"
        /// </summary>
        public String IsReadOnly()
        {
            String sValue = "";
            if (mElement == null)
            {
                FindElement();
            }
            sValue = mElement.GetAttribute("readonly");
            if (sValue != null)
            {
                if (sValue == "readonly")
                {
                    sValue = "TRUE";
                }
                return sValue;
            }

            sValue = mElement.GetAttribute("readOnly");
            if (sValue != null)
            {
                return sValue;
            }

            sValue = mElement.GetAttribute("isDisabled");
            if (sValue != null)
            {
                return sValue;
            }

            sValue = mElement.GetAttribute("disabled");
            if (sValue != null)
            {
                return sValue;
            }

            sValue = mElement.GetAttribute("class");
            if (sValue.Contains("disabled"))
            {
                return "true";
            }

            sValue = mElement.GetAttribute("contenteditable");
            if (sValue != null && sValue.Contains("false"))
            {
                return "true";
            }

            sValue = mElement.GetAttribute("src");
            if (sValue != null && sValue.ToLower().Contains("disabled"))
            {
                return "true";
            }
            return "false";
        }

        public void ScrollIntoViewUsingJavaScript(bool IgnoreForIE = false)
        {
            // JPV: Temp hotfix for IE UI issue introduced by calls to this routine. Observe if no adverse effects
            if (IgnoreForIE && mDriver.TargetBrowser == SeleniumDriver.Browser.IE)
            {
                return;
            }
            IJavaScriptExecutor javascript = (IJavaScriptExecutor)mDriver.Instance;

            javascript.ExecuteScript("arguments[0].scrollIntoView(true);", mElement);
            javascript.ExecuteScript("arguments[0].scrollIntoView(false);", mElement);
        }

        /// <summary>
        /// Some tabs have an internal scroll bar within the tab container. This method allow us to scroll to the tab we want to select within tab container.
        /// </summary>
        /// <param name="tabElem">The tab we want to scroll to within the tab cotainer</param>
        public void ScrollTab(IWebElement tabElem)
        {
            IJavaScriptExecutor javascript = (IJavaScriptExecutor)mDriver.Instance;
            //get the top position of the tab to select, then scroll the tab container to its position
            javascript.ExecuteScript(
                "var topOffset = arguments[0].offsetTop;" +
                "var topMargin = parseInt(getComputedStyle(arguments[0]).getPropertyValue('margin-top', 10));" +
                "arguments[1].scrollTop = topOffset - topMargin;"
                , tabElem, mElement);
        }

        /// <summary>
        /// Used by the Object Store Recorder tool to verify the control type of the recorded control
        /// </summary>
        public bool VerifyControlType()
        {
            return false;
        }

        /// <summary>
        /// Used by the Object Store Recorder tool to auto correct the entered SearchType and SearchValue.
        /// Returns true if there is a suggested search method
        /// </summary>
        /// <param name="SearchType"></param>
        /// <param name="SearchValue"></param>
        public void AutoCorrectSearchMethod(ref string SearchType, ref string SearchValue)
        {
        }

        public string FindXPath()
        {
            return (String)((IJavaScriptExecutor)mDriver.Instance).ExecuteScript(
                "gPt=function(c)" +
                "{" +
                    "if(c.id!=='')" +
                    "{" +
                        "return'id(\"'+c.id+'\")'" +
                    "}" +
                    "if(c===document.body)" +
                    "{" +
                        "return c.tagName" +
                    "}" +
                    "var a=0;" +
                    "var e=c.parentNode.childNodes;" +
                    "for(var b=0;b<e.length;b++)" +
                    "{" +
                        "var d=e[b];" +
                        "if(d===c)" +
                        "{" +
                            "return gPt(c.parentNode)+'/'+c.tagName+'['+(a+1)+']'" +
                        "}" +
                        "if(d.nodeType===1&&d.tagName===c.tagName)" +
                        "{" +
                            "a++" +
                        "}" +
                    "}" +
                "};" +
                "return gPt(arguments[0]).toLowerCase();", mElement);
        }

        /// <summary>
        /// Recursive function to find parent using tag name.
        /// </summary>
        /// <param name="tagName">Tag name of the parent element.</param>
        /// <param name="element">Child element which will be use as starting point.</param>
        /// <returns></returns>
        public IWebElement FindParentByTagName(string tagName, IWebElement element = null)
        {
            IWebElement parentElement = null;

            if (element == null)
            {
                element = mElement;
            }

            try
            {
                if (element.TagName.Trim().Equals("html"))
                {
                    return null;
                }
                else if (element.TagName.Trim().Equals(tagName))
                {
                    parentElement = element;
                }
                else if (element.FindElements(By.XPath("..")).Count > 0)
                {
                    parentElement = FindParentByTagName(tagName, element.FindElement(By.XPath("..")));
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return parentElement;
        }

        /// <summary>
        /// Recursive function that will find parent element of mElement or argument.
        /// </summary>
        /// <param name="attribute">attribute of the parent element to search.</param>
        /// <param name="attributeValue">attribute value of the parent element to search.</param>
        /// <param name="element">Child element which will be use as starting point.</param>
        /// <returns></returns>
        public IWebElement FindParentByAttribute(string attribute, string attributeValue, IWebElement element = null)
        {
            IWebElement parentElement = null;

            if (element == null)
            {
                element = mElement;
            }

            try
            {
                string elementAttributeValue = element.GetAttribute(attribute);

                if (element.TagName.Equals("html"))
                {
                    parentElement = null;
                }
                else if (elementAttributeValue != null &&
                         elementAttributeValue.Contains(attributeValue))
                {
                    parentElement = element;
                }
                else if (element.FindElements(By.XPath("..")).Count > 0)
                {
                    parentElement = FindParentByAttribute(attribute, attributeValue, element.FindElement(By.XPath("..")));
                }
            }
            catch
            {
                parentElement = null;
            }

            return parentElement;
        }


        public void ShiftTab()
        {
            mElement.SendKeys(OpenQA.Selenium.Keys.Shift + OpenQA.Selenium.Keys.Tab);
        }

        public SeleniumControl GetControl()
        {
            return this;
        }

        public Boolean IsElementStale()
        {
            try
            {
                String sTagName = mElement.TagName;
                return false;
            }
            catch (StaleElementReferenceException)
            {
                return true;
            }
        }
    }
}
