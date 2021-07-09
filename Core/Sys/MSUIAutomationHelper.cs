using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Automation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Threading;
using Core.Sys.Selenium;

namespace Core.Sys
{ 
    public class MSUIAPath : IEnumerator<string>
    {
        List<string> _paths;
        int _depth;
        int _index;

        public int Index
        {
            get { return this._index; }
        }

        public int Depth
        {
            get { return this._depth; }
        }

        public IList<string> Paths
        {
            get { return this._paths; }
        }

        public MSUIAPath(string path)
        {
            var list = path.Split(new char[] { '~' }).ToList();
            _paths = new List<string>();
            _paths.AddRange(list);
            _depth = list.Count;
            _index = -1;
        }

        public void Dispose()
        {
            _paths = null;
        }

        public bool MoveNext()
        {
            _index++;
            if (_index > _paths.Count - 1)
                return false;
            else
                return true;
        }

        public void Reset()
        {
            _index = -1;
        }


        string IEnumerator<string>.Current
        {
            get { return _paths[_index]; }
        }

        object IEnumerator.Current
        {
            get { return (object)_paths[_index]; }
        }
    }

    public class MSUIAutomationHelper
    {
        //Left Button - Mouse Down 
        private const int WM_LBUTTONDOWN = 0x0201;
        //Left Button - Mouse Up 
        private const int WM_LBUTTONUP = 0x0202;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData, UIntPtr dwExtraInfo);

        [Flags]
        public enum MouseEventFlags : uint
        {
            LEFTDOWN = 0x00000002,
            LEFTUP = 0x00000004,
            MIDDLEDOWN = 0x00000020,
            MIDDLEUP = 0x00000040,
            MOVE = 0x00000001,
            ABSOLUTE = 0x00008000,
            RIGHTDOWN = 0x00000008,
            RIGHTUP = 0x00000010
        }
        
        public const string GovWinIQKeyword = "GovWin IQ";
        private SeleniumDriver mDriver = null;

        public MSUIAutomationHelper(SeleniumDriver Driver)
        {
            mDriver = Driver;
        }

        public AutomationElement TraverseWindow(AutomationElement node,
                        TreeWalker treeWalker,
                        MSUIAPath keyword)
        {
            AutomationElement element = node;
            while (keyword.MoveNext())
            {
                element = FindWindow(node, treeWalker, keyword.Paths[keyword.Index]);
                if (element != null)
                    element = TraverseWindow(element, treeWalker, keyword);
                else
                    break;
            }

            return element;
        }

        public AutomationElement FindWindow(AutomationElement root,
                                TreeWalker treeWalker,
                                MSUIAPath searchPath)
        {
            searchPath.Reset();
            return TraverseWindow(root, treeWalker, searchPath);
        }

        public AutomationElement FindWindow(AutomationElement root, TreeWalker treeWalker, string keywordSearch, string controlType = "")
  {
            Thread.Sleep(300);
            AutomationElement window = null;

            //create content first
            bool bypassOtherTypes = false;
            List<AutomationElement> children = new List<AutomationElement>();
            AutomationElement child = treeWalker.GetFirstChild(root);

            while (child != null)
            {
                children.Add(child);
                child = treeWalker.GetNextSibling(child);
            }

            if (controlType != string.Empty)
            {
                bypassOtherTypes = true;
            }

            foreach (AutomationElement e in children)
            {
                if (bypassOtherTypes && e.Current.LocalizedControlType != controlType)
                {
                    continue;
                }

                if (e.Current.Name.Trim() != "" && e.Current.Name != null && e.Current.Name.Contains(keywordSearch))
                {
                    if (keywordSearch == MSUIAutomationHelper.GovWinIQKeyword)
                    {
                        if (VerifyIfRunByWebDriver(e))
                        {
                            window = e;
                            break;
                        }
                    }
                    else
                    {
                        window = e;
                        break;
                    }
                }
            }

            if (window != null)
            {
                mDriver.SessionLogger.WriteLine(string.Format("{0} found. Handle: 0x{1}.", window.Current.Name, window.Current.NativeWindowHandle.ToString("X")), Logger.MessageType.INF);
            }
            else
            {
                mDriver.SessionLogger.WriteLine(string.Format(" Can't find window that contains {0}.", keywordSearch), Logger.MessageType.INF);
            }
            return window;
        }

        public List<AutomationElement> FindAllWindow(AutomationElement root, TreeWalker treeWalker, string keywordSearch)
        {
            Thread.Sleep(300);
            List<AutomationElement> windowsFound = new List<AutomationElement>();


            //create content first
            List<AutomationElement> children = new List<AutomationElement>();
            AutomationElement child = treeWalker.GetFirstChild(root);

            while (child != null)
            {
                children.Add(child);
                child = treeWalker.GetNextSibling(child);
            }


            foreach (AutomationElement e in children)
            {
                if (e.Current.Name != null && e.Current.Name.Contains(keywordSearch))
                {
                    if (keywordSearch == MSUIAutomationHelper.GovWinIQKeyword)
                    {
                        if (VerifyIfRunByWebDriver(e))
                        {
                            windowsFound.Add(e);
                        }
                    }
                    else
                    {
                        windowsFound.Add(e);
                    }
                }
            }

            if (windowsFound.Count > 0)
            {
                foreach (var window in windowsFound)
                {
                    mDriver.SessionLogger.WriteLine(string.Format("{0} found. Handle: 0x{1}.", window.Current.Name, window.Current.NativeWindowHandle.ToString("X")), Logger.MessageType.INF);
                }
            }
            else
            {
                mDriver.SessionLogger.WriteLine(string.Format(" Can't find window/s that contains {1} in {0}.", root.Current.Name, keywordSearch), Logger.MessageType.INF);
            }

            return windowsFound;
        }

        public bool VerifyIfRunByWebDriver(AutomationElement window)
        {
            bool ret = false;

            TreeWalker walker = new TreeWalker(Automation.ContentViewCondition);

            //toolbar properties            
            AutomationElement toolbar = window.FindFirst(TreeScope.Descendants, new AndCondition(new Condition[]{
                                                                        new PropertyCondition(  AutomationElement.ControlTypeProperty,
                                                                                                System.Windows.Automation.ControlType.ToolBar),
                                                                        new PropertyCondition( AutomationElement.NameProperty, "Add-on Bar")}));
            if (toolbar == null)
                return false;

            AutomationElement webDriverText = toolbar.FindFirst(TreeScope.Children, new PropertyCondition(AutomationElement.NameProperty, "WebDriver"));

            if (webDriverText != null)
                ret = true;

            return ret;
        }

        public void FileDownload(String BrowserTitle, String Filename, int iWaitTimeInSecs, String action = "Save")
        {
            switch (mDriver.TargetBrowser)
            {
                case SeleniumDriver.Browser.IE:
                    throw new Exception("FileDownload() failed. IE file download currently not supported.");
                case SeleniumDriver.Browser.FIREFOX:
                    FirefoxDownload(Filename, iWaitTimeInSecs, action);
                    break;
                default:
                    // do nothing
                    // chrome will fall through here
                    break;
            }

        }

        public AutomationElement GetFirstWindow(string windowTitle, string controlType, string value)
        {

            AutomationElement handle = null;
            AutomationElement aeDesktop = AutomationElement.RootElement;
            Condition contentCondition = Automation.ContentViewCondition;
            Condition controlCondition = Automation.ControlViewCondition;
            TreeWalker controlWalker = new TreeWalker(controlCondition);

            List<AutomationElement> windows = FindAllWindow(aeDesktop, controlWalker, windowTitle);

            if (controlType != "")
            {
                foreach (var window in windows)
                {
                    AutomationElementCollection controls = window.FindAll(TreeScope.Descendants,
                                    new PropertyCondition(AutomationElement.LocalizedControlTypeProperty,
                                    controlType.ToLower()));

                    //search for the value
                    foreach (AutomationElement control in controls)
                    {
                        object pattern;
                        control.TryGetCurrentPattern(ValuePattern.Pattern, out pattern);
                        if (pattern != null)
                        {
                            //the control has value
                            ValuePattern valPattern = (ValuePattern)pattern;
                            if (valPattern.Current
                                .Value.ToString().ToLower()
                                .Contains(value.ToLower()))
                            {
                                handle = control;
                                break;
                            }
                        }
                        else
                        {
                            //the control does not have value, you can get the name property
                            if (control.Current.Name
                                .ToString().ToLower()
                                .Contains(value.ToLower()))
                            {
                                handle = control;
                                break;
                            }
                        }
                    }
                }

            }
            else
            {
                if (windows.Count > 0)
                    handle = windows.First();
            }
            return handle;
        }

        private void FirefoxDownload(String Filename, int iWaitTimeInSecs, String action = "Save")
        {

            AutomationElement aeDesktop = AutomationElement.RootElement;            
            Condition contentCondition = Automation.ContentViewCondition;
            Condition controlCondition = Automation.ControlViewCondition;
            TreeWalker controlWalker = new TreeWalker(controlCondition);            
            AutomationElement govWinWindow = FindWindow(aeDesktop, controlWalker, MSUIAutomationHelper.GovWinIQKeyword);

            if (govWinWindow == null)
            {
                govWinWindow = FindWindow(aeDesktop, controlWalker, "Mozilla Firefox");
            }

            Thread.Sleep(1000);

            AutomationElement openingDialog = FindWindow(govWinWindow, controlWalker, "Opening");

            AutomationElementCollection aeAllRadioButton = openingDialog.FindAll(TreeScope.Descendants,
                                            new PropertyCondition(AutomationElement.ControlTypeProperty,
                                                ControlType.RadioButton));

            if (action == "Open")
            {
                AutomationElement OpenButton = openingDialog.FindFirst(TreeScope.Descendants,
                                new PropertyCondition(AutomationElement.NameProperty, "Open with"));
                ((SelectionItemPattern)OpenButton.GetCurrentPattern(SelectionItemPattern.Pattern)).Select();
            }
            else
            {
                AutomationElement SaveButton = openingDialog.FindFirst(TreeScope.Descendants,
                                    new PropertyCondition(AutomationElement.NameProperty, "Save File"));
                ((SelectionItemPattern)SaveButton.GetCurrentPattern(SelectionItemPattern.Pattern)).Select();
            }



            AutomationElement OKButton = openingDialog.FindFirst(TreeScope.Children,
                    new PropertyCondition(AutomationElement.NameProperty, "OK"));

            Thread.Sleep(300);
            ((InvokePattern)OKButton.GetCurrentPattern(InvokePattern.Pattern)).Invoke();

            //refresh from the top as previous govWInWindow could have changed
            govWinWindow = FindWindow(aeDesktop, controlWalker, MSUIAutomationHelper.GovWinIQKeyword);

            if (action == "Open")
            {
                {
                    govWinWindow = FindWindow(aeDesktop, controlWalker, "Microsoft Excel");
                }

                AutomationElement xlsDialog = FindWindow(govWinWindow, controlWalker, "Microsoft Excel");

                AutomationElement confirmYesButton = xlsDialog.FindFirst(TreeScope.Descendants,
                                        new PropertyCondition(AutomationElement.NameProperty, "Yes"));

                confirmYesButton.SetFocus();
                Thread.Sleep(300);
                ((InvokePattern)confirmYesButton.GetCurrentPattern(InvokePattern.Pattern)).Invoke();

                mDriver.SessionLogger.WriteLine("Successfully executed FileOpen(): " + Filename, Logger.MessageType.INF);
            }
            else
            {
                if (govWinWindow == null)
                {
                    govWinWindow = FindWindow(aeDesktop, controlWalker, "Mozilla Firefox");
                }
                AutomationElement filenameDialog = FindWindow(govWinWindow, controlWalker, "Enter name");

                AutomationElement fNameEditBoxElement = filenameDialog.FindFirst(TreeScope.Descendants,
                            new AndCondition(new PropertyCondition(AutomationElement.ControlTypeProperty,
                                                    System.Windows.Automation.ControlType.Edit),
                                                    new PropertyCondition(AutomationElement.NameProperty, "File name:")));

                ValuePattern fNameEditBox = (ValuePattern)fNameEditBoxElement.GetCurrentPattern(ValuePattern.Pattern);

                fNameEditBox.SetValue(Filename);

                AutomationElement fNameSaveButton = filenameDialog.FindFirst(TreeScope.Children,
                                new PropertyCondition(AutomationElement.NameProperty, action));


                Thread.Sleep(300);
                ((InvokePattern)fNameSaveButton.GetCurrentPattern(InvokePattern.Pattern)).Invoke();

                AutomationElement confirmDialog = FindWindow(filenameDialog, controlWalker, "Confirm");
                if (confirmDialog != null)
                {
                    confirmDialog.SetFocus();
                    AutomationElement confirmYesButton = confirmDialog.FindFirst(TreeScope.Descendants,
                                        new PropertyCondition(AutomationElement.NameProperty, "Yes"));

                    confirmYesButton.SetFocus();
                    Thread.Sleep(300);
                    ((InvokePattern)confirmYesButton.GetCurrentPattern(InvokePattern.Pattern)).Invoke();
                }

                mDriver.SessionLogger.WriteLine("Successfully executed FileDownload(): " + Filename, Logger.MessageType.INF);
            }

        }

        public void FileUpload(String BrowserTitle, String Filename, int iWaitTimeInSecs)
        {

            AutomationElement aeDesktop = AutomationElement.RootElement;
            AutomationElement browserWindow = null;
            AutomationElement fileUploadDialog = null;
            List<AutomationElement> uploadDialogList = new List<AutomationElement>();
            Condition contentCondition = Automation.ContentViewCondition;
            Condition controlCondition = Automation.ControlViewCondition;

            TreeWalker controlWalker = new TreeWalker(controlCondition);

            for (int i = 0; i < iWaitTimeInSecs; i++)
            {
                browserWindow = FindWindow(aeDesktop, controlWalker, BrowserTitle);
                if (browserWindow == null)
                {
                    Thread.Sleep(1000);
                }
                else
                {
                    uploadDialogList = GetDialogInfo(browserWindow, controlWalker, "Dialog");
                    if (uploadDialogList.Count(x => x != null) > 0)
                    {
                        fileUploadDialog = uploadDialogList.Find(x => x != null);
                        break;
                    }

                    else
                    {
                        Thread.Sleep(1000);
                    }
                }
            }

            AutomationElement fNameEditBoxElement = fileUploadDialog.FindFirst(TreeScope.Descendants,
                new AndCondition(new PropertyCondition(AutomationElement.ControlTypeProperty,
                    System.Windows.Automation.ControlType.Edit), new PropertyCondition(AutomationElement.NameProperty, "File name:")));

            ValuePattern fNameEditBox = (ValuePattern)fNameEditBoxElement.GetCurrentPattern(ValuePattern.Pattern);
            mDriver.SessionLogger.WriteLine("Filename: " + Filename, Logger.MessageType.INF);

            /* Allow for both (a) absolute path and (b) filename only, look for file in User data folder */
            fNameEditBox.SetValue(Filename);

            bool bClicked = false;
            for (int i = 0; i < 5; i++)
            {
                try
                {
                    //fileUploadDialog.SetFocus();
                    AutomationElement OpenButton = fileUploadDialog.FindFirst(TreeScope.Children,
                            new AndCondition(new PropertyCondition(AutomationElement.NameProperty, "Open"), new PropertyCondition(AutomationElement.ControlTypeProperty, System.Windows.Automation.ControlType.SplitButton)));
                    System.Threading.Thread.Sleep(2000);
                    //OpenButton.SetFocus();
                    InvokePattern clickOpenButton = (InvokePattern)OpenButton.GetCurrentPattern(InvokePattern.Pattern);
                    clickOpenButton.Invoke();
                    bClicked = true;
                    break;
                }
                catch
                {
                    try
                    {
                        // assuming that the focus is still on the textbox after setting the text in the try block above.
                        SendKeys.SendWait("{ENTER}");
                        break;
                    }
                    catch
                    {
                        // retry
                    }
                }

            }
            if (!bClicked)
            {
                mDriver.SessionLogger.WriteLine("FileUpload() failed. Unable to click 'Open', will now try to use keyboard event.", Logger.MessageType.INF);
                System.Threading.Thread.Sleep(1000); // wait, then check if any upload dialog still exists
                uploadDialogList.Clear();
                uploadDialogList = GetDialogInfo(browserWindow, controlWalker, "Dialog");
                if (uploadDialogList.Count(x => x != null) > 0)
                {
                    SendKeys.SendWait("{ENTER}");
                }
                System.Threading.Thread.Sleep(1000);
                //check if upload still exists
                uploadDialogList.Clear();
                uploadDialogList = GetDialogInfo(browserWindow, controlWalker, "Dialog");
                if (uploadDialogList.Count(x => x != null) > 0)
                {
                    throw new Exception("FileUpload() failed. Even keyboard event doesn't work.");
                }
            }
            else
            {
                mDriver.SessionLogger.WriteLine("FileUpload() : 'Open' clicked.", Logger.MessageType.INF);
            }
            //OpenButton.SetFocus();

            //SendKeys.SendWait("{ENTER}");
            System.Threading.Thread.Sleep(1000);

            mDriver.SessionLogger.WriteLine("Successfully executed FileUpload(): " + Filename, Logger.MessageType.INF);
        }

        public void MultipleFileUpload(String BrowserTitle, String FileList, int iWaitTimeInSecs)
        {
            try
            {
                AutomationElement aeDesktop = AutomationElement.RootElement;
                AutomationElement browserWindow = null;
                List<AutomationElement> uploadDialogList = new List<AutomationElement>();
                AutomationElement fileUploadDialog = null;

                Condition contentCondition = Automation.ContentViewCondition;
                Condition controlCondition = Automation.ControlViewCondition;

                TreeWalker controlWalker = new TreeWalker(controlCondition);

                for (int i = 0; i < iWaitTimeInSecs; i++)
                {
                    browserWindow = FindWindow(aeDesktop, controlWalker, BrowserTitle);
                    if (browserWindow == null)
                    {
                        Thread.Sleep(1000);
                    }
                    else
                    {
                        uploadDialogList = GetDialogInfo(browserWindow, controlWalker);
                        if (uploadDialogList.Count(x => x != null) > 0)
                        {
                            fileUploadDialog = uploadDialogList.Find(x => x != null);
                            break;
                        }

                        else
                        {
                            Thread.Sleep(1000);
                        }
                    }
                }

                AutomationElement fNameEditBoxElement = fileUploadDialog.FindFirst(TreeScope.Descendants,
                    new AndCondition(new PropertyCondition(AutomationElement.ControlTypeProperty,
                        System.Windows.Automation.ControlType.Edit), new PropertyCondition(AutomationElement.NameProperty, "File name:")));

                ValuePattern fNameEditBox = (ValuePattern)fNameEditBoxElement.GetCurrentPattern(ValuePattern.Pattern);
                List<string> listedFiles = FileList.Split('~').ToList();
                listedFiles.Sort(); //multiple files entered in Upload/Open field don't work for some reason if not alphabetical
                String constructedList = String.Empty;
                foreach (string file in listedFiles)
                {
                    constructedList += "\"" + file + "\" ";
                }
                mDriver.SessionLogger.WriteLine("File names: " + constructedList, Logger.MessageType.INF);
                fNameEditBox.SetValue(Application.StartupPath); //since no absolute path for multiupload, go to user directory first
                SendKeys.SendWait("{ENTER}");
                System.Threading.Thread.Sleep(2000);
                fNameEditBox.SetValue(constructedList);
                bool bClicked = false;
                for (int i = 0; i < 5; i++)
                {
                    try
                    {
                        AutomationElement OpenButton = fileUploadDialog.FindFirst(TreeScope.Children,
                                new AndCondition(new PropertyCondition(AutomationElement.NameProperty, "Open"), new PropertyCondition(AutomationElement.ControlTypeProperty, System.Windows.Automation.ControlType.SplitButton)));
                        System.Threading.Thread.Sleep(2000);
                        InvokePattern clickOpenButton = (InvokePattern)OpenButton.GetCurrentPattern(InvokePattern.Pattern);
                        clickOpenButton.Invoke();
                        bClicked = true;
                        break;
                    }
                    catch
                    {
                        try
                        {
                            // assuming that the focus is still on the textbox after setting the text in the try block above.
                            SendKeys.SendWait("{ENTER}");
                            break;
                        }
                        catch
                        {
                            // retry
                        }
                    }

                }
                if (!bClicked)
                {
                    mDriver.SessionLogger.WriteLine("MultipleFileUpload() failed. Unable to click 'Open', will now try to use keyboard event.", Logger.MessageType.INF);
                    System.Threading.Thread.Sleep(1000); // wait, then check if any upload dialog still exists
                    uploadDialogList.Clear();
                    uploadDialogList = GetDialogInfo(browserWindow, controlWalker);
                    if (uploadDialogList.Count(x => x != null) > 0)
                    {
                        SendKeys.SendWait("{ENTER}");
                    }
                    System.Threading.Thread.Sleep(1000);
                    //check if upload still exists
                    uploadDialogList.Clear();
                    uploadDialogList = GetDialogInfo(browserWindow, controlWalker);
                    if (uploadDialogList.Count(x => x != null) > 0)
                    {
                        throw new Exception("MultipleFileUpload() failed. Even keyboard event doesn't work.");
                    }
                }
                else
                {
                    mDriver.SessionLogger.WriteLine("MultipleFileUpload() : 'Open' clicked.", Logger.MessageType.INF);
                }
                System.Threading.Thread.Sleep(1000);

                mDriver.SessionLogger.WriteLine("Successfully executed MultipleFileUpload(): " + FileList, Logger.MessageType.INF);
            }
            catch (Exception ex)
            {
                throw new Exception("MultipleFileUpload() failed: " + ex.Message);
            }
        }       

        private List<AutomationElement> GetDialogInfo(AutomationElement window, TreeWalker walker, string controlType = "")
        {
            List<AutomationElement> dialogList = new List<AutomationElement>();
            dialogList.Add(FindWindow(window, walker, "Upload", controlType));
            dialogList.Add(FindWindow(window, walker, "Open", controlType));
            dialogList.Add(FindWindow(window, walker, "Choose File to Upload", controlType));
            return dialogList;
        }

        public String GetBrowserStatusBar(String BrowserTitle, String iWaitTimeInSecs)
        {

            AutomationElement aeDesktop = AutomationElement.RootElement;
            AutomationElement browserWindow = null;
            AutomationElement frameTabPane = null;
            AutomationElement browserPane = null;
            AutomationElement statusBar = null;

            string statusBarTextProp = "";

            Condition contentCondition = Automation.ContentViewCondition;
            Condition controlCondition = Automation.ControlViewCondition;
            TreeWalker controlWalker = new TreeWalker(controlCondition);

            int sec = 0;

            if (int.TryParse(iWaitTimeInSecs, out sec))
            {
                for (int i = 0; i < sec; i++)
                {
                    browserWindow = FindWindow(aeDesktop, controlWalker, BrowserTitle);
                    if (browserWindow == null)
                    {
                        Thread.Sleep(1000);
                    }
                    else
                    {
                        frameTabPane = browserWindow.FindFirst(TreeScope.Descendants,
                            new PropertyCondition(AutomationElement.ClassNameProperty, "Frame Tab"));

                        browserPane = frameTabPane.FindFirst(TreeScope.Descendants,
                            new PropertyCondition(AutomationElement.ClassNameProperty, "TabWindowClass"));

                        statusBar = browserPane.FindFirst(TreeScope.Descendants,
                            new PropertyCondition(AutomationElement.ClassNameProperty, "msctls_statusbar32"));

                        statusBarTextProp = statusBar.GetCurrentPropertyValue(AutomationElement.NameProperty) as string;
                        break;
                    }
                }
            }
            mDriver.SessionLogger.WriteLine("Successfully executed GetBrowserStatusBar().", Logger.MessageType.INF);
            return statusBarTextProp;

        }
        
    }
}
