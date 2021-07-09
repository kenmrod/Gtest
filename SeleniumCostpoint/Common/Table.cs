using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Core.Sys;
using Core.Sys.Selenium;
using System.Text.RegularExpressions;
using System.Threading;

namespace SeleniumCostpoint.Common
{
    public class Table
    {
        private const string SCRIPT_SHEET_NAME = "Script";
        private const string SCRIPT_OUTPUT_COLUMN_NAME = "Output";
        private const char DEFAULT_DELIMETER = '~';
        private const int ROW_HEADER_SELECTOR_COL_INDEX = -1;
        private const int HORIZONTAL_SCROLL_OFFSET = 3;
        private const int VERTICAL_SCROLL_OFFSET = 2;

        private String mstrHeaderClass = "hdcll";
        private String mstrRowClass = "dRw";
        private String mstrHScrollBarXPATH = "./ancestor::div[@class='tblvw']/div[@id='hScrCnt']";
        private String mstrVScrollBarXPATH = "./ancestor::div[@class='tblvw']/div[@class='vScrCnt']";
        //private String mstrCurrentRowXPATH = "./descendant::div[@class='dRw' and contains(@style,'3px')]";
        //private String mstrClickCellCommentOkButtonXPATH = "//input[@id='expandoOK']";
        //private String mstrClickCellCommentCancelButtonXPATH = "//input[@id='expandoCancel']";
        private String mstrTableCheckbox = "./ancestor::form[1]/descendant::*[@id='selectAllImg']";
        private IList<string> mlstHeaderTexts;
        private List<IWebElement> mlstHeaders;
        private IList<IWebElement> mlstRows;
        private IWebElement mHScroll;
        private IWebElement mVScroll;
        private SeleniumDriver mDriver = null;
        private Functions mFunction = null;
        private SeleniumControl mControl = null;
        private SeleniumTestScript mScript = null;

        public Table(SeleniumDriver Driver, SeleniumControl Control, SeleniumTestScript TestScript)
        {
            mDriver = Driver;
            mFunction = new Functions(Driver, TestScript);
            mControl = Control;
            mScript = TestScript;
            mControl.FindElement();
            FindScrollBars();
        }

        public int GetTableRowWithColumnValue(String ColumnHeader, String Value)
        {
            int iRet = -1;
            bool blnFound = false;
            int intColIndex = -1;            
            bool bContinue = true;

            intColIndex = GetColumnIndexByHeader(ColumnHeader);
            if (intColIndex != -1)
            {
                VScrollStart("existing");
                VScrollStart("new");

                RefreshRows();
                int i = 0;
                while (bContinue)
                {
                    for (i = 0; i < mlstRows.Count; i++)
                    {
                        SeleniumControl cellControl = new SeleniumControl(mDriver, "Cell", GetInputControl(GetCell(i + 1, intColIndex)));
                        String cellValue = cellControl.GetValue();
                        if (cellControl.GetAttributeValue("class") == "tCB")
                        {
                            cellValue = cellControl.GetAttributeValue("checked") == null ? "false" : cellControl.GetAttributeValue("checked").ToLower();
                            Value = Value.ToLower();
                        }
                        if (cellValue.Equals(Value))
                        {
                            iRet = i + 1;
                            blnFound = true;
                            bContinue = false;
                            break;
                        }
                    }
                    if (bContinue)
                    {
                        if (VScrollEnd("existing") && VScrollEnd("new"))
                        {
                            bContinue = false;
                        }
                        else
                        {
                            VScrollDown("existing");
                            VScrollDown("new");
                        }
                    }
                }

                if (blnFound)
                {
                    mScript.ScriptLogger.WriteLine("Successfully executed GetTableRowWithColumnValue()");
                }
                else
                {
                    throw new Exception("Value = '" + Value + "' under Column = '" + ColumnHeader + "' not found in table");
                }
            }
            else
            {
                throw new Exception("Column '" + ColumnHeader + "' not found");
            }

            return iRet;
        }
        
        public void ClickTableCellByRowColumn(int Row, String ColumnHeader)
        {
            try
            {

                int intColIndex = GetColumnIndexByHeader(ColumnHeader);
                if (intColIndex != -1)
                {
                    SeleniumControl cellControl = new SeleniumControl(mDriver, "Cell", GetCell(Row, intColIndex));
                    cellControl.Click();
                }
                else
                {
                    throw new Exception("Column '" + ColumnHeader + "' not found");
                }
                mScript.ScriptLogger.WriteLine("Successfully executed ClickTableCellByRowColumn()");
            }
            catch (Exception e)
            {
                throw new Exception("ClickTableCellByRowColumn() failed : " + e.Message, e);
            }
        }

        public void DoubleClickTableRowHeader(String Row)
        {
            try
            {
               
                IWebElement rowHeader = GetRowHeaderCell(Convert.ToInt32(Row));
                if (rowHeader == null)
                {
                    throw new Exception("Row header cell not found");
                }
                SeleniumControl ctlRowHeader = new SeleniumControl(mDriver, "RowHeader", rowHeader);

                ctlRowHeader.DoubleClick(); ;
                mScript.ScriptLogger.WriteLine("Successfully executed DoubleClickTableRowHeader()");
            }
            catch (Exception e)
            {
                throw new Exception("DoubleClickTableRowHeader() failed : " + e.Message, e);
            }
        }
        
        public void ClickTableCheckBox()
        {
            try
            {
                IWebElement tableCheckBox = mControl.mElement.FindElement(By.XPath(mstrTableCheckbox));
                tableCheckBox.Click();
                mScript.ScriptLogger.WriteLine("Successfully executed Click()");
            }
            catch (Exception e)
            {
                throw new Exception("ClickTableCheckBox() failed : " + e.Message, e);
            }
        }
        
        public void VerifyTableCellReadOnly(int Row, String ColumnHeader, Boolean ExpectedValue)
        {
            try
            {
                int intColIndex = GetColumnIndexByHeader(ColumnHeader);
                if (intColIndex != -1)
                {
                    IWebElement cell = GetCell(Row, intColIndex);
                    String cellClass = cell.GetAttribute("class").ToString().ToLower();
                    mFunction.AssertEqual(ExpectedValue, cellClass.Equals("cllro"));
                }
                else
                {
                    throw new Exception("Column '" + ColumnHeader + "' not found");
                }
            }
            catch (Exception e)
            {
                throw new Exception("VerifyTableCellReadOnly() failed : " + e.Message, e);
            }

        }

        public void VerifyTableColumnHeaders(String ExpectedHeaders)
        {
            String strActualHeaders = String.Empty;
            String strDelimeter = String.Empty;
            List<IWebElement> mlstHeadersBeforeScroll;
            IList<string> mlstHeadersFullList;
            String sHeader = "";
            String sHeaderFinal = "";

            mlstHeadersFullList = new List<String>();

            try
            {
                //reset horizontal scroll bar to make sure we cover all headers
                HScrollStart();
                RefreshHeaders();
                mlstHeadersBeforeScroll = mlstHeaders;

                foreach (IWebElement hdrName in mlstHeadersBeforeScroll)
                {
                    String headerText = GetColumnHeaderText(hdrName);
                    if (headerText.Contains("<div"))
                    {
                        headerText = RemoveHTMLTagsInHeader(headerText);
                    }
                    mlstHeadersFullList.Add(headerText);
                }

                //Scroll to view the hidden columns and append the newly visible ones to the main list
                if (mHScroll.GetCssValue("visibility") != "hidden" && mHScroll.FindElement(By.CssSelector("div>div.track")).Displayed == true)
                {
                    IWebElement track = mHScroll.FindElement(By.CssSelector("div>div.track"));
                    IWebElement rightScrollButton = mHScroll.FindElement(By.CssSelector("div>*#hp2"));
                    SeleniumControl rightBtnControl = new SeleniumControl(mDriver, "Right Button", rightScrollButton);
                    double trackLeft = Convert.ToDouble(track.GetCssValue("left").Replace("px", "").Trim());
                    double trackWidth = Convert.ToDouble(track.GetCssValue("width").Replace("px", "").Trim());
                    double rightBtnLeft = Convert.ToDouble(rightScrollButton.GetCssValue("left").Replace("px", "").Trim());

                    while (mlstHeaderTexts.Contains(GetColumnHeaderText(mlstHeaders[mlstHeaders.Count - 1])) && trackLeft + trackWidth + 1 < rightBtnLeft)
                    {
                        rightBtnControl.Click();
                        RefreshHeaders();
                        rightScrollButton = mHScroll.FindElement(By.CssSelector("div>*#hp2"));
                        trackLeft = Convert.ToDouble(track.GetCssValue("left").Replace("px", "").Trim());
                        trackWidth = Convert.ToDouble(track.GetCssValue("width").Replace("px", "").Trim());
                        rightBtnLeft = Convert.ToDouble(rightScrollButton.GetCssValue("left").Replace("px", "").Trim());

                        foreach (IWebElement hdrName in mlstHeaders)
                        {
                            sHeader = GetColumnHeaderText(hdrName);
                            sHeaderFinal = SplitCamelCaseInHeader(sHeader);
                            if (sHeaderFinal.Contains("<div"))
                            {
                                sHeaderFinal = RemoveHTMLTagsInHeader(sHeaderFinal);
                            }
                            if (mlstHeadersFullList[mlstHeadersFullList.Count - 1] == sHeaderFinal.Replace("*", ""))
                            {
                                mlstHeadersFullList[mlstHeadersFullList.Count - 1] = sHeaderFinal;
                            }
                            else if (!mlstHeadersFullList.Contains(sHeaderFinal))
                            {
                                mlstHeadersFullList.Add(sHeaderFinal);
                            }
                        }
                    }
                }

                foreach (IWebElement hdrName in mlstHeaders)
                {
                    sHeader = GetColumnHeaderText(hdrName);
                    sHeaderFinal = SplitCamelCaseInHeader(sHeader);
                    if (sHeaderFinal.Contains("<div"))
                    {
                        sHeaderFinal = RemoveHTMLTagsInHeader(sHeaderFinal);
                    }
                    if (mlstHeadersFullList[mlstHeadersFullList.Count - 1] == sHeaderFinal.Replace("*", ""))
                    {
                        mlstHeadersFullList[mlstHeadersFullList.Count - 1] = sHeaderFinal;
                    }
                    else if (!mlstHeadersFullList.Contains(sHeaderFinal))
                    {
                        mlstHeadersFullList.Add(sHeaderFinal);
                    }
                }

                foreach (String hdr in mlstHeadersFullList)
                {
                    strActualHeaders += (strDelimeter + hdr);
                    strDelimeter = DEFAULT_DELIMETER.ToString();
                }

                mFunction.AssertEqual(ExpectedHeaders.ToLower(), strActualHeaders.ToLower());
            }
            catch (Exception e)
            {
                throw new Exception("VerifyTableColumnHeaders() failed : " + e.Message, e);
            }
        }
                        
        public int GetTableRowWithMultipleColumnValues(String ColumnHeaders, String Values)
        {
            String[] lstHdrs = ColumnHeaders.Split(DEFAULT_DELIMETER);
            String[] lstValues = Values.Split(DEFAULT_DELIMETER);

            if (lstHdrs.Count() != lstValues.Count())
            {
                throw new Exception("Column Headers count = " + lstHdrs.Count() + " not equal to Values count = " + lstValues.Count());
            }
                
            VScrollStart("existing");
            VScrollStart("new");
            RefreshRows();

            bool bContinue = true;

            while (bContinue)
            {
                for (int rowIndex = 1; rowIndex <= mlstRows.Count; rowIndex++)
                {
                    int inputIndex = 0;
                    for (inputIndex = 0; inputIndex < lstHdrs.Count(); inputIndex++)
                    {
                        int intColIndex = -1;
                        intColIndex = GetColumnIndexByHeader(lstHdrs[inputIndex]); // call this just to check if valid header
                        if (intColIndex != -1)
                        {
                            SeleniumControl cellControl = new SeleniumControl(mDriver, "Cell", GetInputControl(GetCell(rowIndex, intColIndex)));
                            String cellValue = cellControl.GetValue();
                            // if input control is checkbox
                            if (cellControl.GetAttributeValue("class") == "tCB")
                            {
                                cellValue = cellControl.GetAttributeValue("checked") == null ? "false" : cellControl.GetAttributeValue("checked").ToLower();
                                lstValues[inputIndex] = lstValues[inputIndex].ToLower();
                            }
                            if (!(cellValue.Equals(lstValues[inputIndex])))
                            {
                                break;
                            }
                        }
                        else
                        {
                            throw new Exception("Column '" + lstHdrs[inputIndex] + "' not found");
                        }
                    }


                    if (inputIndex == lstHdrs.Count()) // means found
                    {
                        mScript.ScriptLogger.WriteLine("Successfully executed GetTableRowWithMultipleColumnValues()");
                        return rowIndex;
                    }
                }

                if (bContinue)
                {
                    if (VScrollEnd("existing") && VScrollEnd("new"))
                    {
                        bContinue = false;
                    }
                    else
                    {
                        VScrollDown("existing");
                        VScrollDown("new");
                    }
                }
            }

            throw new Exception("Values = '" + Values + "' under Columns = '" + ColumnHeaders + "' not found in table");            
        }

        public void ClickTableCellButtonByRowColumn(String Row, String ColumnHeader, String ButtonName)
        {
            try
            {
                int intColIndex = GetColumnIndexByHeader(ColumnHeader);
                if (intColIndex != -1)
                {
                    IWebElement inputControl = GetInputControl(GetCell(Convert.ToInt32(Row), intColIndex));

                    if (inputControl == null)
                    {
                        throw new Exception("Cell does not contain an input control");
                    }
                    inputControl.Click();
                    IWebElement target = inputControl.FindWebElementCoalesce(By.XPath("./following-sibling::*[contains(@title, '" + ButtonName + "')]"),
                        By.XPath("./following-sibling::*[contains(@class, '" + ButtonName + "')]"));

                    if (target == null)
                    {
                        throw new Exception("Control = '" + ButtonName + "' not found within table cell");
                    }
                    target.Click();
                    mScript.ScriptLogger.WriteLine("Successfully executed ClickTableCellButtonByRowColumn()");
                }
                else
                {
                    throw new Exception("Column '" + ColumnHeader + "' not found");
                }
            }
            catch (Exception e)
            {
                throw new Exception("ClickTableCellButtonByRowColumn() failed : " + e.Message, e);
            }
        }
        
       
        public void ClickTableRowHeader(String Row)
        {
            try
            {
                //IWebElement rowHeader = GetCell(Convert.ToInt32(Row), ROW_HEADER_SELECTOR_COL_INDEX);
                IWebElement rowHeader = GetRowHeaderCell(Convert.ToInt32(Row));
                if (rowHeader == null)
                {
                    throw new Exception("Row header cell not found");
                }
                SeleniumControl ctlRowHeader = new SeleniumControl(mDriver, "RowHeader", rowHeader);

                try
                {
                    mControl.ScrollIntoViewUsingJavaScript();
                }
                catch (Exception)
                {
                    mScript.ScriptLogger.WriteLine("ClickTableRowHeader Scroll into view exception");
                }

                rowHeader.Click();
                mScript.ScriptLogger.WriteLine("Successfully executed ClickTableRowHeader()");
            }
            catch (Exception e)
            {
                throw new Exception("ClickTableRowHeader() failed : " + e.Message, e);
            }
        }

        public void RightClickColumnHeader(String ColumnName)
        {
            try
            {
                RefreshHeaders();
                bool hasColumn = false;
                for (int i = 0; i < mlstHeaders.Count; i++)
                {
                    if (ColumnName == GetColumnHeaderText(mlstHeaders[i]))
                    {
                        hasColumn = true;
                        IWebElement columnHeader = mlstHeaders[i];
                        OpenQA.Selenium.Interactions.Actions mAction = new OpenQA.Selenium.Interactions.Actions(mDriver.Instance);
                        mAction.ContextClick(columnHeader);
                        mAction.Perform();
                        mScript.ScriptLogger.WriteLine("Successfully executed RightClickColumnHeader(): " + ColumnName);
                        break;
                    }
                }
                if (hasColumn == false)
                {
                    throw new Exception("Column header " + ColumnName + " not found");
                }
            }
            catch (Exception e)
            {
                throw new Exception("ClickTableRowHeader() failed : " + e.Message, e);
            }
        }
        
        public string GetTableCellValue(int Row, String ColumnHeader)
        {
            String cellValue = String.Empty;
            
            int intColIndex = GetColumnIndexByHeader(ColumnHeader);
            if (intColIndex != -1)
            {
                IWebElement cell = GetCell(Row, intColIndex);
                IWebElement inputControl = GetInputControl(cell);
                if (inputControl == null)
                {
                    throw new Exception("Cell does not contain an input control");
                }
                else
                {
                    String strInputControlClass = inputControl.GetAttribute("class").ToLower();
                    String strInputControlID = inputControl.GetAttribute("id");
                    SeleniumControl mCell = new SeleniumControl(mDriver, "Cell", "ID", strInputControlID);
                    cellValue = mCell.GetValue();                    
                }
            }
            else
            {
                throw new Exception("Column '" + ColumnHeader + "' not found");
            }
            mScript.ScriptLogger.WriteLine("Successfully executed GetTableCellValue()");

            return cellValue;
        }        
        
        public String GetColumnHeaderValue(String ColumnIndex)
        {
            string ret = string.Empty;
            int iColIndex = Convert.ToInt32(ColumnIndex);
            RefreshHeaders();
            if (iColIndex >= mlstHeaderTexts.Count)
            {
                throw new Exception("Column index " + iColIndex + " out of bounds of header indices");
            }
            ret = mlstHeaderTexts[iColIndex];
            mScript.ScriptLogger.WriteLine("Successfully executed GetColumnHeaderValue(). Value obtained: " + mlstHeaderTexts[iColIndex]);            

            return ret;
        }

        #region Private Methods
        private void FindScrollBars()
        {
            mHScroll = mControl.mElement.FindElement(By.XPath(mstrHScrollBarXPATH));
            mVScroll = mControl.mElement.FindElement(By.XPath(mstrVScrollBarXPATH));
        }

        public int GetColumnIndexByHeader(String sColumnHeader)
        {
            int index = -1;
            Boolean bContinue = true;

            HScrollStart();
            RefreshHeaders();
            while (bContinue && index == -1)
            {
                for (int i = 0; i < mlstHeaders.Count; i++)
                {
                    string currentHeader = GetColumnHeaderText(mlstHeaders[i]).Trim('*').Trim();
                    if (sColumnHeader.Trim('*').Trim() == currentHeader)
                    {
                        index = i;
                        if (i == mlstHeaders.Count - 1 && mlstHeaders.Count > 1 && mHScroll.GetCssValue("visibility") != "hidden")
                        {
                            if (HScrollEnd())
                            {
                                break;
                            }
                            HScrollSingleRight();
                            index--;
                            if ((i == mlstHeaders.Count - 1))
                            {
                                i = -1;
                                continue;
                            }
                        }
                        break;
                    }
                }
                if (HScrollEnd() || index > -1)
                {
                    bContinue = false;
                }
                else
                {
                    HScrollRight(GetColumnHeaderText(mlstHeaders[mlstHeaders.Count - 1]));
                }

            }
            return index;
        }

        private void RefreshHeaders()
        {
            mlstHeaders = new List<IWebElement>();
            mlstHeaderTexts = new List<String>();

            IList<IWebElement> headers = mControl.mElement.FindElements(By.ClassName(mstrHeaderClass));
            foreach (IWebElement columnHeader in headers)
            {
                SeleniumControl hdr = new SeleniumControl(mDriver, "Header", columnHeader);
                if (columnHeader.GetCssValue("display") != "none")
                {
                    mlstHeaders.Add(columnHeader);
                    mlstHeaderTexts.Add(GetColumnHeaderText(columnHeader));
                }
            }
        }

        private void RefreshRows()
        {
            mControl.FindElement();
            mlstRows = mControl.mElement.FindElements(By.ClassName(mstrRowClass));
        }

        private String GetColumnHeaderText(IWebElement columnHeader)
        {
            String headerText = "";
            headerText = new SeleniumControl(mDriver, "ColumnHeader", columnHeader).GetValue();
            return headerText.Trim().Replace("/ ", "/").RemoveCarriageReturn(); // trim of space after slash for some headers
        }

        private void VScrollStart(String RowType)
        {
            String vscrollID = "";
            String upBtnID = "";
            if (mVScroll.GetCssValue("visibility") != "hidden")
            {
                IWebElement vScrollElement = null;
                if (RowType.ToLower() == "existing")
                {
                    vscrollID = "vScroll1O";
                    upBtnID = "vp1O";
                }
                else if (RowType.ToLower() == "new")
                {
                    vscrollID = "vScroll1N";
                    upBtnID = "vp1N";
                }

                vScrollElement = mVScroll.FindElement(By.Id(vscrollID));

                if (vScrollElement.GetCssValue("visibility") != "hidden")
                {
                    IWebElement track = vScrollElement.FindElement(By.XPath("./descendant::div[@class='track']"));
                    IWebElement upScrollButton = vScrollElement.FindElement(By.Id(upBtnID));
                    SeleniumControl upBtnControl = new SeleniumControl(mDriver, "Up Button", upScrollButton);
                    bool isTrackHiiden = !track.Displayed;
                    Boolean bContinue = true;
                    while (bContinue)
                    {
                        if (isTrackHiiden)
                        {
                            string trackStyle = track.GetAttribute("style");
                            new SeleniumControl(mDriver, "", track).SetAttribute("style", trackStyle.Replace("none", "block"));
                        }
                        int trackTop = Convert.ToInt32(track.GetCssValue("top").Replace("px", "").Trim());
                        int upBtnTop = Convert.ToInt32(upScrollButton.GetCssValue("top").Replace("px", "").Trim());
                        int upBtnHeight = Convert.ToInt32(upScrollButton.GetCssValue("height").Replace("px", "").Trim());
                        if (upBtnTop + upBtnHeight < trackTop)
                        //if (upBtnTop + upBtnHeight + 2 < trackTop)
                        {

                            upBtnControl.Click();
                        }
                        else
                        {
                            bContinue = false;
                        }
                    }
                }
            }
        }

        private void VScrollDown(String RowType)
        {
            String vscrollID = "";
            String downBtnID = "";
            String recordCSS = "";
            if (mVScroll.GetCssValue("visibility") != "hidden")
            {
                IWebElement vScrollElement = null;
                if (RowType.ToLower() == "existing")
                {
                    vscrollID = "vScroll1O";
                    downBtnID = "vp2O";
                    recordCSS = "div#EXSTNG>div";
                }
                else if (RowType.ToLower() == "new")
                {
                    vscrollID = "vScroll1N";
                    downBtnID = "vp2N";
                    recordCSS = "div#NEW>div";
                }

                vScrollElement = mVScroll.FindElement(By.Id(vscrollID));

                if (vScrollElement.GetCssValue("visibility") != "hidden")
                {
                    IList<IWebElement> rows = mControl.mElement.FindElements(By.CssSelector(recordCSS));
                    IWebElement track = vScrollElement.FindElement(By.CssSelector("div>div.track"));
                    bool isTrackHiiden = !track.Displayed;
                    IWebElement downScrollButton = vScrollElement.FindElement(By.Id(downBtnID));
                    SeleniumControl dwnBtnControl = new SeleniumControl(mDriver, "DownBtn", downScrollButton);
                    if (isTrackHiiden)
                    {
                        string trackStyle = track.GetAttribute("style");
                        new SeleniumControl(mDriver, "", track).SetAttribute("style", trackStyle.Replace("none", "block"));
                    }
                    int trackTop = Convert.ToInt32(track.GetCssValue("top").Replace("px", "").Trim());
                    int trackHeight = Convert.ToInt32(track.GetCssValue("height").Replace("px", "").Trim());
                    int downBtnTop = Convert.ToInt32(downScrollButton.GetCssValue("top").Replace("px", "").Trim());
                    if (trackTop + trackHeight + 2 < downBtnTop)
                    {
                        for (int i = 1; i < rows.Count; i++)
                        {
                            try
                            {
                                dwnBtnControl.Click();
                            }
                            catch (InvalidOperationException) // catch exception when button unclickable due to load time
                            {
                                //Costpoint.WaitLoadingFinished(Costpoint.IsCurrentComponentModal());
                                if (dwnBtnControl.Exists())
                                {
                                    dwnBtnControl.Click();
                                }
                                else
                                {
                                    throw;
                                }
                            }

                        }
                    }


                }
            }
        }

        private bool VScrollEnd(String RowType)
        {
            String vscrollID = "";
            String downBtnID = "";
            if (mVScroll.GetCssValue("visibility") != "hidden")
            {
                IWebElement vScrollElement = null;
                if (RowType.ToLower() == "existing")
                {
                    vscrollID = "vScroll1O";
                    downBtnID = "vp2O";
                }
                else if (RowType.ToLower() == "new")
                {
                    vscrollID = "vScroll1N";
                    downBtnID = "vp2N";
                }

                vScrollElement = mVScroll.FindElement(By.Id(vscrollID));

                if (vScrollElement.GetCssValue("visibility") != "hidden")
                {
                    SeleniumControl vscroll = new SeleniumControl(mDriver, "Vertical Scroll", vScrollElement);
                    IWebElement track = vScrollElement.FindElement(By.CssSelector("div>div.track"));
                    bool isTrackHiiden = !track.Displayed;
                    IWebElement downScrollButton = vScrollElement.FindElement(By.Id(downBtnID));

                    if (isTrackHiiden)
                    {
                        string trackStyle = track.GetAttribute("style");
                        new SeleniumControl(mDriver, "", track).SetAttribute("style", trackStyle.Replace("none", "block"));
                    }

                    int trackTop = Convert.ToInt32(track.GetCssValue("top").Replace("px", "").Trim());
                    int trackHeight = Convert.ToInt32(track.GetCssValue("height").Replace("px", "").Trim());
                    int downBtnTop = Convert.ToInt32(downScrollButton.GetCssValue("top").Replace("px", "").Trim());
                    if (trackTop + trackHeight + VERTICAL_SCROLL_OFFSET < downBtnTop)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return true;
            }
        }

        private void HScrollStart()
        {
            if (mHScroll.GetCssValue("visibility") != "hidden" && mHScroll.FindElement(By.CssSelector("div>div.track")).Displayed == true)
            {
                IWebElement track = mHScroll.FindElement(By.CssSelector("div>div.track"));
                IWebElement leftScrollButton = mHScroll.FindElement(By.CssSelector("div>*#hp1"));
                SeleniumControl leftBtnControl = new SeleniumControl(mDriver, "Left Button", leftScrollButton);
                Boolean bContinue = true;
                while (bContinue)
                {
                    double trackLeft = Convert.ToDouble(track.GetCssValue("left").Replace("px", "").Trim());
                    double leftBtnLeft = Convert.ToDouble(leftScrollButton.GetCssValue("left").Replace("px", "").Trim());
                    double leftBtnWidth = Convert.ToDouble(leftScrollButton.GetCssValue("width").Replace("px", "").Trim());
                    if (leftBtnLeft + leftBtnWidth + HORIZONTAL_SCROLL_OFFSET < trackLeft)
                    {
                        leftBtnControl.Click();
                    }
                    else
                    {
                        bContinue = false;
                    }
                }
            }
        }

        private void HScrollRight()
        {
            if (mHScroll.GetCssValue("visibility") != "hidden")
            {
                IWebElement track = mHScroll.FindElement(By.CssSelector("div>div.track"));
                IWebElement rightScrollButton = mHScroll.FindElement(By.CssSelector("div>*#hp2"));
                SeleniumControl rightBtnControl = new SeleniumControl(mDriver, "Right Button", rightScrollButton);
                double trackLeft = Convert.ToDouble(track.GetCssValue("left").Replace("px", "").Trim());
                double trackWidth = Convert.ToDouble(track.GetCssValue("width").Replace("px", "").Trim());
                double rightBtnLeft = Convert.ToDouble(rightScrollButton.GetCssValue("left").Replace("px", "").Trim());
                if (trackLeft + trackWidth + 1 < rightBtnLeft)
                {
                    for (int i = 1; i < mlstHeaders.Count; i++)
                    {
                        rightBtnControl.Click();
                    }
                    RefreshHeaders();
                }
            }
        }

        private void HScrollRight(String LastVisibleHeaderText)
        {
            if (mHScroll.GetCssValue("visibility") != "hidden" && mHScroll.FindElement(By.CssSelector("div>div.track")).Displayed == true)
            {
                IWebElement track = mHScroll.FindElement(By.CssSelector("div>div.track"));
                IWebElement rightScrollButton = mHScroll.FindElement(By.CssSelector("div>*#hp2"));
                SeleniumControl rightBtnControl = new SeleniumControl(mDriver, "Right Button", rightScrollButton);
                double trackLeft = Convert.ToDouble(track.GetCssValue("left").Replace("px", "").Trim());
                double trackWidth = Convert.ToDouble(track.GetCssValue("width").Replace("px", "").Trim());
                double rightBtnLeft = Convert.ToDouble(rightScrollButton.GetCssValue("left").Replace("px", "").Trim());

                while (mlstHeaderTexts.Contains(LastVisibleHeaderText) && trackLeft + trackWidth + 1 < rightBtnLeft)
                {
                    rightBtnControl.Click();
                    RefreshHeaders();
                    rightScrollButton = mHScroll.FindElement(By.CssSelector("div>*#hp2"));
                    trackLeft = Convert.ToDouble(track.GetCssValue("left").Replace("px", "").Trim());
                    trackWidth = Convert.ToDouble(track.GetCssValue("width").Replace("px", "").Trim());
                    rightBtnLeft = Convert.ToDouble(rightScrollButton.GetCssValue("left").Replace("px", "").Trim());
                }
            }
        }

        private void HScrollSingleRight()
        {
            if (mHScroll.GetCssValue("visibility") != "hidden" && mHScroll.FindElement(By.CssSelector("div>div.track")).Displayed == true)
            {
                IWebElement rightScrollButton = mHScroll.FindElement(By.CssSelector("div>*#hp2"));
                SeleniumControl rightBtnControl = new SeleniumControl(mDriver, "Right Button", rightScrollButton);

                rightBtnControl.Click();
                RefreshHeaders();
            }
        }

        private void HScrollBigSingleRight()
        {
            if (mHScroll.GetCssValue("visibility") != "hidden")
            {
                IWebElement rightScrollButton = mHScroll.FindElement(By.CssSelector("div>*#hp2"));
                SeleniumControl rightBtnControl = new SeleniumControl(mDriver, "Right Button", rightScrollButton);

                rightBtnControl.Click(-2, 0);
                RefreshHeaders();
            }
        }

        private bool HScrollEnd()
        {
            if (mHScroll.GetCssValue("visibility") != "hidden" && mHScroll.FindElement(By.CssSelector("div>div.track")).Displayed == true)
            {
                SeleniumControl hscroll = new SeleniumControl(mDriver, "Horizontal Scroll", mHScroll);
                IWebElement track = mHScroll.FindElement(By.CssSelector("div>div.track"));
                IWebElement rightScrollButton = mHScroll.FindElement(By.CssSelector("div>*#hp2"));
                double trackLeft = Convert.ToDouble(track.GetCssValue("left").Replace("px", "").Trim());
                double trackWidth = Convert.ToDouble(track.GetCssValue("width").Replace("px", "").Trim());
                double rightBtnLeft = Convert.ToDouble(rightScrollButton.GetCssValue("left").Replace("px", "").Trim());
                if (trackLeft + trackWidth + HORIZONTAL_SCROLL_OFFSET < rightBtnLeft)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return true;
            }
        }

        private IWebElement GetCell(int iRow, int iColumn)
        {
            IWebElement cell = null;
            RefreshRows();
            if (mlstRows.Count < iRow || iRow <= 0)
            {
                return cell;
            }
            IWebElement row = mlstRows[iRow - 1];
            IList<IWebElement> cells = new List<IWebElement>();
            foreach (IWebElement item in row.FindElements(By.XPath("./*")))
            {
                // do not include first cell and un-displayed cells
                if (item.GetAttribute("class") != "cllfrst" && item.GetCssValue("display") != "none")
                {
                    cells.Add(item);
                }
            }
            cell = cells[iColumn];
            return cell;
        }

        private IWebElement GetRowHeaderCell(int iRow)
        {
            IWebElement hdr = null;
            RefreshRows();
            if (mlstRows.Count < iRow || iRow <= 0)
            {
                return hdr;
            }
            IWebElement row = mlstRows[iRow - 1];
            hdr = row.FindElements(By.ClassName("cllfrst")).Count > 0 ? row.FindElements(By.ClassName("cllfrst")).First() : null;
            return hdr;
        }

        private IWebElement GetInputControl(IWebElement cell)
        {
            if (cell == null)
            {
                return null;
            }

            IList<IWebElement> cellInputs = cell.FindElements(By.CssSelector("input"));
            if (cellInputs.Count > 0)
            {
                return cellInputs.First();
            }
            else if (cell.FindElements(By.CssSelector("span")).Count > 0)
            {
                cellInputs = cell.FindElements(By.CssSelector("span"));
                if (cellInputs.Count > 0)
                {
                    return cellInputs.First();
                }
            }
            else if (cell.FindElements(By.CssSelector("textarea")).Count > 0) // added for 7.0 support
            {
                cellInputs = cell.FindElements(By.CssSelector("textarea"));
                if (cellInputs.Count > 0)
                {
                    return cellInputs.First();
                }
            }
            return null;

        }

        private string SplitCamelCaseInHeader(String strToFormat)
        {
            return Regex.Replace(strToFormat, "(?<=[a-z])(?=[A-Z])", " ");
        }

        private string RemoveHTMLTagsInHeader(String strToFormat)
        {
            return Regex.Replace(strToFormat, @"<[^>]+>|&nbsp;", "").Trim();
        }

        #endregion
    }
}
