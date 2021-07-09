using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.MultiTouch;


namespace Core.Sys.Appium
{
    public class AppiumControl : IControl
    {
        #region CONSTANTS
        /// <summary>
        /// Default wait time in between swipes
        /// </summary>
        private const int INT_SWIPE_WAIT_MS = 800;

        /// <summary>
        /// Pixel density of device. Note that if this cannot be obtained programmatically, should be written in config
        /// </summary>
        private const int INT_DEVICE_DENSITY = 160;
        #endregion

        #region DECLARATIONS
        /// <summary>
        /// Direction of swipe action relative to control
        /// </summary>
        public enum SwipeDirection
        {
            Left,
            Up,
            Right,
            Down
        }

        /// <summary>
        /// Origin of swipe action relative to control
        /// </summary>
        public enum SwipeOrigin
        {
            LeftTop,
            RightTop,
            CenterTop,
            LeftCenter,
            Center,
            RightCenter,
            LeftBottom,
            CenterBottom,
            RightBottom
        }


        /// <summary>
        /// this is a default time to search. it is public so it can be adjusted as needed
        /// </summary>
        public int iFindElementDefaultSearchMax { get; set; }

        /// <summary>
        /// an assignable list of elements
        /// </summary>
        public IList<AppiumWebElement> mElms { get; set; }

        /// <summary>
        /// the element we are interacting with. Selenium deals with elements; we wrap logic into controls as that allows us to provide
        /// a practical experience (i.e. textboxes cannot do the same as buttons)
        /// </summary>
        public IWebElement mElement { get; set; }

        /// <summary>
        /// the contol name we searched for... assigned when we construct a control
        /// </summary>
        public String mControlName { get; set; }

        /// <summary>
        /// used with mSearchValues to determine how we find the control... assigned when we contruct a control
        /// </summary>
        public String mSearchType { get; set; }

        public String[] mSearchValues { get; set; }


        private Boolean IsDeclaredAsExistngWebElement = false;

        private AppiumDriver mDriver = null;
        #endregion

        /// <summary>
        /// constructor for a SeleniumControl which acts as our interface to selenium logic
        /// </summary>
        /// <param name="Driver">Appium Driver to use</param>
        /// <param name="ControlName">Name of control</param>
        /// <param name="SearchType">Type of search</param>
        /// <param name="SearchValue">Search parameter</param>
        public AppiumControl(AppiumDriver Driver, String ControlName, String SearchType, String SearchValue, int SearchTimeOut=40)
        {
            mControlName = ControlName;
            mSearchType = SearchType;
            mSearchValues = new string[] { SearchValue };
            iFindElementDefaultSearchMax = SearchTimeOut;
            mDriver = Driver;
        }

        public AppiumControl(AppiumDriver Driver, String ControlName, IWebElement ExistingWebElement, int SearchTimeOut = 40)
        {
            mControlName = ControlName;
            mElement = ExistingWebElement;
            IsDeclaredAsExistngWebElement = true;
            iFindElementDefaultSearchMax = SearchTimeOut;
            mDriver = Driver;
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

                            IList<AppiumWebElement> frames;
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
                                IList<AppiumWebElement> frames0;
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

                            IList<AppiumWebElement> frames1;
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

        /// <summary>
        /// Tap target control
        /// </summary>
        /// <param name="OffSetX">Optional X coordinate offset</param>
        /// <param name="OffSetY">Optional Y coordinate offset</param>
        public void Tap(int OffSetX=0, int OffSetY=0)
        {
            bool isNative = mDriver.Instance.Context.Contains("NATIVE");
            FindElement();
            Point elementCoord = GetNativeViewCenterCoordinates();
            if (!isNative)
            {
                // Adjust to device edge if negative coordinates
                elementCoord.X = elementCoord.X >= 0 ? elementCoord.X : 0;

                //Switch to NativeView
                mDriver.SetContext("NATIVE");
            }

            TouchAction tapAction = new TouchAction(mDriver.Instance);
            tapAction.Tap(elementCoord.X + OffSetX, elementCoord.Y + OffSetY);
            mDriver.Instance.PerformTouchAction(tapAction);

            if (!isNative)
            {
                //Revert back to WebView
                mDriver.SetContext("WEBVIEW");
            }
        }

        /// <summary>
        /// Swipe action relative to control
        /// </summary>
        /// <param name="Direction">Direction of swipe relative to control</param>
        /// <param name="Distance">Distance of swipe relative to input origin</param>
        /// <param name="Origin">Origin of swipe relative to control</param>
        public void Swipe(SwipeDirection Direction, int Distance=100, SwipeOrigin Origin = SwipeOrigin.Center)
        {
            TouchAction swipeAction = new TouchAction(mDriver.Instance);
            Point elementCenterCoordinates = GetNativeViewCenterCoordinates();
            Point elementTopCoordinates = GetNativeViewCoordinates();
            Point elementBottomCoordinates = ConvertToNativeViewCoordinates(mElement.Location.X + mElement.Size.Width, mElement.Location.Y + mElement.Size.Height);

            /* Determine origin point based from parameter */
            Point swipeOrigin = new Point();
            switch (Origin)
            {
                case SwipeOrigin.CenterBottom:
                    if (elementBottomCoordinates.X > mDriver.TargetDevice.Width || elementTopCoordinates.X < 0)
                    {
                        int visibleRightX = elementBottomCoordinates.X > mDriver.TargetDevice.Width ? mDriver.TargetDevice.Width : elementBottomCoordinates.X;
                        int visibleLeftX = elementTopCoordinates.X < 0 ? 0 : elementTopCoordinates.X;
                        swipeOrigin.X = (visibleRightX - visibleLeftX) / 2;
                    }
                    else
                    {
                        swipeOrigin.Y = elementCenterCoordinates.Y;
                    }
                    swipeOrigin.Y = elementBottomCoordinates.Y > mDriver.TargetDevice.Height ? mDriver.TargetDevice.Height - 1 : elementBottomCoordinates.Y;
                    break;
                case SwipeOrigin.CenterTop:
                    if (elementBottomCoordinates.X > mDriver.TargetDevice.Width || elementTopCoordinates.X < 0)
                    {
                        int visibleRightX = elementBottomCoordinates.X > mDriver.TargetDevice.Width ? mDriver.TargetDevice.Width : elementBottomCoordinates.X;
                        int visibleLeftX = elementTopCoordinates.X < 0 ? 0 : elementTopCoordinates.X;
                        swipeOrigin.X = (visibleRightX - visibleLeftX) / 2;
                    }
                    else
                    {
                        swipeOrigin.Y = elementCenterCoordinates.Y;
                    }
                    swipeOrigin.Y = elementTopCoordinates.Y < 0 ? 1 : elementTopCoordinates.Y;
                    break;
                case SwipeOrigin.LeftBottom:
                    swipeOrigin.X = elementTopCoordinates.X < 0 ? 1 : elementTopCoordinates.X;
                    swipeOrigin.Y = elementBottomCoordinates.Y > mDriver.TargetDevice.Height ? mDriver.TargetDevice.Height - 1 : elementBottomCoordinates.Y;
                    break;
                case SwipeOrigin.LeftCenter:
                    swipeOrigin.X = elementTopCoordinates.X < 0 ? 1 : elementTopCoordinates.X;
                    if (elementBottomCoordinates.Y > mDriver.TargetDevice.Height || elementTopCoordinates.Y < 0)
                    {
                        int visibleBottomY = elementBottomCoordinates.Y > mDriver.TargetDevice.Height ? mDriver.TargetDevice.Height : elementBottomCoordinates.Y;
                        int visibleTopY = elementTopCoordinates.Y < 0 ? 0 : elementTopCoordinates.Y;
                        swipeOrigin.Y = (visibleBottomY - visibleTopY) / 2;
                    }
                    else
                    {
                        swipeOrigin.Y = elementCenterCoordinates.Y;
                    }
                    break;
                case SwipeOrigin.LeftTop:
                    swipeOrigin.X = elementTopCoordinates.X < 0 ? 1 : elementTopCoordinates.X;
                    swipeOrigin.Y = elementTopCoordinates.Y < 0 ? 1 : elementTopCoordinates.Y;
                    break;
                case SwipeOrigin.RightBottom:
                    swipeOrigin.X = elementBottomCoordinates.X > mDriver.TargetDevice.Width ? mDriver.TargetDevice.Width - 1 : elementBottomCoordinates.X;
                    swipeOrigin.Y = elementBottomCoordinates.Y > mDriver.TargetDevice.Height ? mDriver.TargetDevice.Height - 1 : elementBottomCoordinates.Y;
                    break;
                case SwipeOrigin.RightCenter:
                    swipeOrigin.X = elementBottomCoordinates.X > mDriver.TargetDevice.Width ? mDriver.TargetDevice.Width - 1 : elementBottomCoordinates.X;
                    if (elementBottomCoordinates.Y > mDriver.TargetDevice.Height || elementTopCoordinates.Y < 0)
                    {
                        int visibleBottomY = elementBottomCoordinates.Y > mDriver.TargetDevice.Height ? mDriver.TargetDevice.Height : elementBottomCoordinates.Y;
                        int visibleTopY = elementTopCoordinates.Y < 0 ? 0 : elementTopCoordinates.Y;
                        swipeOrigin.Y = (visibleBottomY - visibleTopY) / 2;
                    }
                    else
                    {
                        swipeOrigin.Y = elementCenterCoordinates.Y;
                    }
                    break;
                case SwipeOrigin.RightTop:
                    swipeOrigin.X = elementBottomCoordinates.X > mDriver.TargetDevice.Width ? mDriver.TargetDevice.Width - 1 : elementBottomCoordinates.X;
                    swipeOrigin.Y = elementTopCoordinates.Y < 0 ? 1 : elementTopCoordinates.Y;
                    break;
                default: // center
                    swipeOrigin.X = elementCenterCoordinates.X;
                    if (elementBottomCoordinates.Y > mDriver.TargetDevice.Height || elementTopCoordinates.Y < 0)
                    {
                        int visibleBottomY = elementBottomCoordinates.Y > mDriver.TargetDevice.Height ? mDriver.TargetDevice.Height : elementBottomCoordinates.Y;
                        int visibleTopY = elementTopCoordinates.Y < 0 ? 0 : elementTopCoordinates.Y;
                        swipeOrigin.Y = (visibleBottomY - visibleTopY) / 2;
                    }
                    else
                    {
                        swipeOrigin.Y = elementCenterCoordinates.Y;
                    }

                    break;
            }

            Point swipeDestination = new Point();
            switch (Direction)
            {
                case SwipeDirection.Up:
                    swipeDestination.X = swipeOrigin.X;
                    swipeDestination.Y = (swipeOrigin.Y - Distance) < 0 ? 1 : swipeOrigin.Y - Distance;
                    break;
                case SwipeDirection.Down:
                    swipeDestination.X = swipeOrigin.X;
                    swipeDestination.Y = (swipeOrigin.Y + Distance) > mDriver.TargetDevice.Height
                        ? mDriver.TargetDevice.Height - 1 : Convert.ToInt32((swipeOrigin.Y + Distance) * 0.95);
                    break;
                case SwipeDirection.Left:
                    swipeDestination.X = (swipeOrigin.X - Distance) < 0 ? 1 : swipeOrigin.X - Distance;
                    swipeDestination.Y = swipeOrigin.Y;
                    break;
                case SwipeDirection.Right:
                    swipeDestination.X = (swipeOrigin.X + Distance) > mDriver.TargetDevice.Width
                        ? mDriver.TargetDevice.Width - 1 : swipeOrigin.X + Distance;
                    swipeDestination.Y = swipeOrigin.Y;
                    break;
                default: // Should not hit
                    break;
            }

            if (!mDriver.Instance.Context.Contains("NATIVE"))
            {
                mDriver.SetContext("NATIVE");
                mDriver.Instance.Swipe(swipeOrigin.X, swipeOrigin.Y, swipeDestination.X, swipeDestination.Y, INT_SWIPE_WAIT_MS);
                mDriver.SetContext("WEBVIEW");
            }
            else
            {
                mDriver.Instance.Swipe(swipeOrigin.X, swipeOrigin.Y, swipeDestination.X, swipeDestination.Y, INT_SWIPE_WAIT_MS);
            }
        }

        public Point GetNativeViewCoordinates()
        {
            Point nativeCoords = new Point();
            bool isNative = mDriver.Instance.Context.Contains("NATIVE");

            if (!isNative)
            {
                //Coordinates extracted from webview uses CSS coordinates which 
                //has different scaling from the actual device screen.

                //First compute for the scale factor.
                IWebElement htmlBody = mDriver.Instance.FindElement(By.CssSelector("html>body"));
                Size bodySize = htmlBody.Size;
                double scaleX = Convert.ToDouble(mDriver.TargetDevice.Width) / Convert.ToDouble(bodySize.Width);
                double scaleY = 0.0;
                if (mDriver.TargetPlatform == AppiumDriver.Platform.IOS_APP 
                    || mDriver.TargetPlatform == AppiumDriver.Platform.IOS_SAFARI) //We need to consider the servicebar in computing the Y ratio
                {
                    scaleY = Convert.ToDouble(mDriver.TargetDevice.Height) / (Convert.ToDouble(bodySize.Height) + mDriver.TargetDevice.StatusBarHeight);
                }
                else
                {
                    scaleY = Convert.ToDouble(mDriver.TargetDevice.Height) / Convert.ToDouble(bodySize.Height);
                }

                //Apply scale transformation to the current web element
                nativeCoords.X = Convert.ToInt32(Math.Round(scaleX * Convert.ToDouble(mElement.Location.X)));
                nativeCoords.Y = Convert.ToInt32(Math.Round(scaleY * Convert.ToDouble(mElement.Location.Y)));

                //Adjust X coordinates (there were instance that X is a negative coordinate)
                //nativeCoords.X = nativeCoords.X >= 0 ? nativeCoords.X : 0;

                nativeCoords.X = nativeCoords.X + 1;
                nativeCoords.Y = nativeCoords.Y + 1;

                //Adjust Y coordinates based on the status bar
                if (mDriver.TargetPlatform == AppiumDriver.Platform.IOS_APP 
                    || mDriver.TargetPlatform == AppiumDriver.Platform.IOS_SAFARI) //depending on the version of iOS, we need to consider the servicebar in computing the Y coordinate
                {
                    //do nothing. Status bar is already considered in the scale computation.
                    //nativeCoords.Y = nativeCoords.Y - mDriver.TargetDevice.StatusBarHeight;
                }
                else
                {
                    double statusBarWeightOffSetRate = 1d / (mDriver.TargetDevice.Height / INT_DEVICE_DENSITY);
                    double weightedStatusBarOffSet = mDriver.TargetDevice.StatusBarHeight * (1 - (statusBarWeightOffSetRate * (nativeCoords.Y / INT_DEVICE_DENSITY)));
                    if (weightedStatusBarOffSet < 0)
                    {
                        weightedStatusBarOffSet = 0;
                    }
                    nativeCoords.Y = nativeCoords.Y >= 0 ? nativeCoords.Y + Convert.ToInt32(weightedStatusBarOffSet) : nativeCoords.Y;
                }
            }
            else
            {
                nativeCoords = mElement.Location;
            }

            return nativeCoords;
        }

        public Point GetNativeViewCenterCoordinates()
        {
            Point nativeCoords = new Point();
            bool isNative = mDriver.Instance.Context.Contains("NATIVE");

            if (!isNative)
            {
                //Coordinates extracted from webview uses CSS coordinates which 
                //has different scaling from the actual device screen.

                //First compute for the scale factor.
                IWebElement htmlBody = mDriver.Instance.FindElement(By.CssSelector("html>body"));
                Size bodySize = htmlBody.Size;
                double scaleX = Convert.ToDouble(mDriver.TargetDevice.Width) / Convert.ToDouble(bodySize.Width);
                double scaleY = 0.0;
                if (mDriver.TargetPlatform == AppiumDriver.Platform.IOS_APP || mDriver.TargetPlatform == AppiumDriver.Platform.IOS_SAFARI) //We need to consider the servicebar in computing the Y ratio
                {
                    scaleY = Convert.ToDouble(mDriver.TargetDevice.Height) / (Convert.ToDouble(bodySize.Height) + mDriver.TargetDevice.StatusBarHeight);
                }
                else
                {
                    scaleY = Convert.ToDouble(mDriver.TargetDevice.Height) / Convert.ToDouble(bodySize.Height);
                }

                //Apply scale transformation to the current web element
                nativeCoords.X = Convert.ToInt32(Math.Round(scaleX * Convert.ToDouble(mElement.Location.X) + ((scaleX * Convert.ToDouble(mElement.Size.Width)) / 2)));
                nativeCoords.Y = Convert.ToInt32(Math.Round(scaleY * Convert.ToDouble(mElement.Location.Y) + ((scaleY * Convert.ToDouble(mElement.Size.Height)) / 2)));

                //Adjust X coordinates (there were instance that X is a negative coordinate)
                //nativeCoords.X = nativeCoords.X >= 0 ? nativeCoords.X : 0;

                //Adjust Y coordinates based on the status bar
                if (mDriver.TargetPlatform == AppiumDriver.Platform.IOS_APP || mDriver.TargetPlatform == AppiumDriver.Platform.IOS_SAFARI)
                {
                    //do nothing. Status bar is already considered in the scale computation.
                }
                else
                {
                    double statusBarWeightOffSetRate = 1d / (mDriver.TargetDevice.Height / INT_DEVICE_DENSITY);
                    double weightedStatusBarOffSet = mDriver.TargetDevice.StatusBarHeight * (1 - (statusBarWeightOffSetRate * (nativeCoords.Y / INT_DEVICE_DENSITY)));
                    if (weightedStatusBarOffSet < 0)
                    {
                        weightedStatusBarOffSet = 0;
                    }
                    nativeCoords.Y = nativeCoords.Y >= 0 ? nativeCoords.Y + Convert.ToInt32(weightedStatusBarOffSet) : nativeCoords.Y;
                }
            }
            else
            {
                //set coordinates to center of element
                nativeCoords.X = Convert.ToInt32(mElement.Location.X + mElement.Size.Width / 2);
                nativeCoords.Y = Convert.ToInt32(mElement.Location.Y + mElement.Size.Height / 2);
            }
            return nativeCoords;
        }

        public Point ConvertToNativeViewCoordinates(int x, int y)
        {
            Point nativeCoords = new Point();
            bool isNative = mDriver.Instance.Context.Contains("NATIVE");

            if (!isNative)
            {
                //Coordinates extracted from webview uses CSS coordinates which 
                //has different scaling from the actual device screen.

                //First compute for the scale factor.
                IWebElement htmlBody = mDriver.Instance.FindElement(By.CssSelector("html>body"));
                Size bodySize = htmlBody.Size;
                double scaleX = Convert.ToDouble(mDriver.TargetDevice.Width) / Convert.ToDouble(bodySize.Width);
                double scaleY = 0.0;
                if (mDriver.TargetPlatform == AppiumDriver.Platform.IOS_APP 
                    || mDriver.TargetPlatform == AppiumDriver.Platform.IOS_SAFARI) //We need to consider the servicebar in computing the Y ratio
                {
                    scaleY = Convert.ToDouble(mDriver.TargetDevice.Height) / (Convert.ToDouble(bodySize.Height) + mDriver.TargetDevice.StatusBarHeight);
                }
                else
                {
                    scaleY = Convert.ToDouble(mDriver.TargetDevice.Height) / Convert.ToDouble(bodySize.Height);
                }

                //Apply scale transformation to the current web element
                nativeCoords.X = Convert.ToInt32(Math.Round(scaleX * Convert.ToDouble(x)));
                nativeCoords.Y = Convert.ToInt32(Math.Round(scaleY * Convert.ToDouble(y)));

                //Adjust X coordinates (there were instance that X is a negative coordinate)
                //nativeCoords.X = nativeCoords.X >= 0 ? nativeCoords.X : 0;

                //Adjust Y coordinates based on the status bar
                if (mDriver.TargetPlatform == AppiumDriver.Platform.IOS_APP 
                    || mDriver.TargetPlatform == AppiumDriver.Platform.IOS_SAFARI) //depending on the version of iOS, we need to consider the servicebar in computing the Y coordinate
                {
                    //do nothing. Status bar is already considered in the scale computation.
                    //nativeCoords.Y = nativeCoords.Y - mDriver.TargetDevice.StatusBarHeight;
                }
                else
                {
                    double statusBarWeightOffSetRate = 1d / (mDriver.TargetDevice.Height / INT_DEVICE_DENSITY);
                    double weightedStatusBarOffSet = mDriver.TargetDevice.StatusBarHeight * (1 - (statusBarWeightOffSetRate * (nativeCoords.Y / INT_DEVICE_DENSITY)));
                    if (weightedStatusBarOffSet < 0)
                    {
                        weightedStatusBarOffSet = 0;
                    }
                    nativeCoords.Y = nativeCoords.Y >= 0 ? nativeCoords.Y + Convert.ToInt32(weightedStatusBarOffSet) : nativeCoords.Y;
                }
            }
            else
            {
                nativeCoords = new Point(x, y);
            }

            return nativeCoords;
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
