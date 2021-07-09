using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Xml.Linq;
using Core.Sys.Selenium;

namespace Core.Sys
{
    public class ReportBuilder
    {
        private const string STR_HTML_STYLE_TITLE = "border:1px dotted black;border-collapse:collapse; font-style: bold; display: inline";
        private const string STR_HTML_STYLE_TABLE = "border:1px dotted black;border-collapse:collapse; font-size:13";
        private const string STR_HTML_STYLE_CANCELLED_TEXT = "color:red; padding:5px";
        private const string STR_HTML_STYLE_SUMMARY_HEADER = "border:1px dotted black; text-align:left";
        private const string STR_HTML_STYLE_SUMMARY_CELL = "border:1px dotted black; text-align:right";
        private const string STR_HTML_STYLE_DETAILS_HEADER = "border:1px dotted black";
        private const string STR_HTML_STYLE_DETAILS_STATUS_PASS = "border:1px dotted black; text-align:center; color:green; padding:5px";
        private const string STR_HTML_STYLE_DETAILS_STATUS_FAIL = "border:1px dotted black; text-align:center; color:red; padding:5px";
        private const string STR_HTML_STYLE_DETAILS_STATUS_NOTRUN = "border:1px dotted black; text-align:center; color:orange; padding:5px";
        private const string STR_HTML_STYLE_DETAILS_LEFT = "border:1px dotted black; text-align:left; padding:5px";
        private const string STR_HTML_STYLE_DETAILS_LEFT_NO_BORDER = "text-align:left; padding:5px";
        private const string STR_HTML_STYLE_DETAILS_RIGHT = "border:1px dotted black; text-align:right; padding:5px";
        private const string STR_HTML_STYLE_DETAILS_CENTER = "border:1px dotted black; text-align:center; padding:5px";
        private const string STR_HTML_STYLE_DETAILS_CENTER_NO_BORDER = "text-align:center; padding:5px";


        private const string STR_HTML_TITLE = "Results Summary";
        private const string STR_HTML_TOTAL_TEST_SCRIPTS = "Total Test Scripts";
        private const string STR_HTML_PASSED_TEST_SCRIPTS = "Passed Test Scripts";
        private const string STR_HTML_FAILED_TEST_SCRIPTS = "Failed Test Scripts";
        private const string STR_HTML_NOTRUN_TEST_SCRIPTS = "Not Run Test Scripts";

        private const string STR_HTML_RUN_NUMBER = "Run #";
        private const string STR_HTML_SUCCESS_RATE = "Success Rate";
        private const string STR_HTML_EXECUTION_TIME_FORMAT = "Execution Time (hh:mm:ss.ms)";

        private const string STR_HTML_TESTRUN = "Test Run";
        private const string STR_HTML_PASSED_TESTS = "Passed Tests";
        private const string STR_HTML_FAILED_TESTS = "Failed Tests";
        private const string STR_HTML_TOTAL_TESTS = "Total Tests";
        private const string STR_HTML_ELAPSED = "Elapsed (hh:mm:ss)";


        private const string STR_HTML_TEST_RESULT = "Result";
        private const string STR_HTML_FILE_PATH = "Filename";
        private const string STR_HTML_TEST = "Test";
        private const string STR_HTML_INSTANCE = "Instance";
        private const string STR_HTML_PLATFORM = "Platform";
        private const string STR_HTML_ENVIRONMENT = "Environment";
        private const string STR_HTML_MACHINE = "Machine";
        private const string STR_HTML_EXECUTED_STEPS = "Executed steps";
        private const string STR_HTML_ERROR_MESSAGE = "Error Message";
        private const string STR_HTML_ERROR_IMG = "Link to Error Image";
        private const string STR_HTML_EXECUTION_TIME = "Execution Time";

        private static string LOGS_PATH = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Logs");


        public string CreateHTMLReportBody(ITestRun Run, string FileName)
        {
            string ret = "";
            try
            {
                XElement title = new XElement("h3", new XAttribute("style", STR_HTML_STYLE_TITLE), STR_HTML_TITLE);
                //XElement suitename = GetSuiteName(inputXML);
                //XElement suiteNameTable = GetTestRunTable(Run.Name);
                //XElement summaryTable = GetSummaryTable(inputXML);
                XElement suiteInfoTable = GetRunDetailsTable(Run);
                XElement blankHeader = new XElement("br");
                XElement detailsTable = GetDetailsTable(Run);
                //XElement cancelledTable = GetCancelledTable(isCancelled);
                XElement body = new XElement("body", title, blankHeader, suiteInfoTable, blankHeader, blankHeader, detailsTable);

                // create html node
                XElement root = new XElement("html", body);
                XDocument output = new XDocument(root);

                ret = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), FileName);
                output.Save(ret);
            }
            catch
            {
                // do nothing
            }
            return ret;
        }

        private static XElement GetDetailsTable(ITestRun run)
        {
            // create table header row
            XElement header = new XElement("tr",
                new XElement("th", new XAttribute("style", STR_HTML_STYLE_DETAILS_HEADER), "#"),
                //new XElement("th", new XAttribute("style", STR_HTML_STYLE_DETAILS_HEADER), STR_HTML_FILE_PATH),
                new XElement("th", new XAttribute("style", STR_HTML_STYLE_DETAILS_HEADER), STR_HTML_TEST),
                new XElement("th", new XAttribute("style", STR_HTML_STYLE_DETAILS_HEADER), STR_HTML_INSTANCE),
                new XElement("th", new XAttribute("style", STR_HTML_STYLE_DETAILS_HEADER), STR_HTML_MACHINE),
                new XElement("th", new XAttribute("style", STR_HTML_STYLE_DETAILS_HEADER), STR_HTML_PLATFORM),
                //new XElement("th", new XAttribute("style", STR_HTML_STYLE_DETAILS_HEADER), STR_HTML_ENVIRONMENT),
                //new XElement("th", new XAttribute("style", STR_HTML_STYLE_DETAILS_HEADER), STR_HTML_EXECUTED_STEPS),
                new XElement("th", new XAttribute("style", STR_HTML_STYLE_DETAILS_HEADER), STR_HTML_EXECUTION_TIME),
                new XElement("th", new XAttribute("style", STR_HTML_STYLE_DETAILS_HEADER), STR_HTML_TEST_RESULT),
                new XElement("th", new XAttribute("style", STR_HTML_STYLE_DETAILS_HEADER), STR_HTML_ERROR_MESSAGE),
            new XElement("th", new XAttribute("style", STR_HTML_STYLE_DETAILS_HEADER), STR_HTML_ERROR_IMG));

            List<XElement> rows = new List<XElement>();
            int count = 0;

            foreach (KeyValuePair<int, ITestScript> kvp in run.TestManifest)
            {
                string statusStyle = STR_HTML_STYLE_DETAILS_STATUS_NOTRUN;
                string result = string.Empty;
                if (kvp.Value.Result)
                {
                    statusStyle = STR_HTML_STYLE_DETAILS_STATUS_PASS;
                    result = "passed";
                }
                else
                {
                    statusStyle = STR_HTML_STYLE_DETAILS_STATUS_FAIL;
                    result = "failed";
                }
                string strElapsed = kvp.Value.Elapsed.ToString().Contains(".") ? kvp.Value.Elapsed.ToString().Substring(0, kvp.Value.Elapsed.ToString().LastIndexOf('.')) : kvp.Value.Elapsed.ToString();

                XElement row = new XElement("tr",
                    new XElement("td", new XAttribute("style", STR_HTML_STYLE_DETAILS_CENTER), ++count),
                    //new XElement("td", new XAttribute("style", STR_HTML_STYLE_DETAILS_LEFT), Path.GetFileName(data.file)),
                    new XElement("td", new XAttribute("style", STR_HTML_STYLE_DETAILS_LEFT), kvp.Value.Name),
                    new XElement("td", new XAttribute("style", STR_HTML_STYLE_DETAILS_CENTER), kvp.Value.Instance),
                    new XElement("td", new XAttribute("style", STR_HTML_STYLE_DETAILS_CENTER), kvp.Value.Machine),
                    new XElement("td", new XAttribute("style", STR_HTML_STYLE_DETAILS_CENTER), kvp.Value.Platform),
                    //new XElement("td", new XAttribute("style", STR_HTML_STYLE_DETAILS_CENTER), data.environment),
                    //new XElement("td", new XAttribute("style", STR_HTML_STYLE_DETAILS_CENTER), data.executed),
                    new XElement("td", new XAttribute("style", STR_HTML_STYLE_DETAILS_RIGHT), strElapsed),
                    new XElement("td", new XAttribute("style", statusStyle), result),
                    new XElement("td", new XAttribute("style", STR_HTML_STYLE_DETAILS_LEFT),
                        //new XElement("div", new XAttribute("style", STR_HTML_STYLE_DETAILS_LEFT_NO_BORDER), data.stepdesc),
                        //new XElement("div", new XAttribute("style", STR_HTML_STYLE_DETAILS_LEFT_NO_BORDER), data.stepinfo),
                        new XElement("div", new XAttribute("style", kvp.Value.Error == "-" ? STR_HTML_STYLE_DETAILS_CENTER_NO_BORDER : STR_HTML_STYLE_DETAILS_LEFT_NO_BORDER), kvp.Value.Error)),
                //new XElement("div", new XAttribute("style", data.outputfile == "-" ? STR_HTML_STYLE_DETAILS_CENTER_NO_BORDER : STR_HTML_STYLE_DETAILS_LEFT_NO_BORDER), GetLinkOutputFile(data.outputfile))),
                new XElement("td", new XAttribute("style", kvp.Value.ErrorScreenshot == "-" ? STR_HTML_STYLE_DETAILS_CENTER : STR_HTML_STYLE_DETAILS_LEFT), GetLinkImage(kvp.Value.ErrorScreenshot)));
                rows.Add(row);
            }

            XElement table = new XElement("table", new XAttribute("style", STR_HTML_STYLE_TABLE), header, rows);
            return table;
        }

        private static XElement GetRunDetailsTable(ITestRun run)
        {
            // Run Name
            XElement runname = new XElement("tr",
                new XElement("th", new XAttribute("style", STR_HTML_STYLE_SUMMARY_HEADER), STR_HTML_TESTRUN),
                new XElement("td", new XAttribute("style", STR_HTML_STYLE_SUMMARY_CELL), run.Name));

            // Passed
            XElement passedtests = new XElement("tr",
                new XElement("th", new XAttribute("style", STR_HTML_STYLE_SUMMARY_HEADER), STR_HTML_PASSED_TESTS),
                new XElement("td", new XAttribute("style", STR_HTML_STYLE_SUMMARY_CELL), run.Test_Passed.ToString()));

            // Failed
            XElement failedtests = new XElement("tr",
                new XElement("th", new XAttribute("style", STR_HTML_STYLE_SUMMARY_HEADER), STR_HTML_FAILED_TESTS),
                new XElement("td", new XAttribute("style", STR_HTML_STYLE_SUMMARY_CELL), run.Test_Failed.ToString()));


            // Total
            XElement total = new XElement("tr",
                new XElement("th", new XAttribute("style", STR_HTML_STYLE_SUMMARY_HEADER), STR_HTML_TOTAL_TESTS),
                new XElement("td", new XAttribute("style", STR_HTML_STYLE_SUMMARY_CELL), run.Test_Total.ToString()));

            // success rate
            double rate = run.Test_Total == 0 ? 0d : run.Test_Passed * 100 / run.Test_Total;
            XElement successRate = new XElement("tr",
                new XElement("th", new XAttribute("style", STR_HTML_STYLE_SUMMARY_HEADER), STR_HTML_SUCCESS_RATE),
                new XElement("td", new XAttribute("style", STR_HTML_STYLE_SUMMARY_CELL), rate.ToString() + "%"));

            // Elapsed
            string strElapsed = run.Elapsed.ToString().Substring(0, run.Elapsed.ToString().LastIndexOf('.'));
            XElement elapsed = new XElement("tr",
                new XElement("th", new XAttribute("style", STR_HTML_STYLE_SUMMARY_HEADER), STR_HTML_ELAPSED),
                new XElement("td", new XAttribute("style", STR_HTML_STYLE_SUMMARY_CELL), strElapsed));

            // Table
            XElement table = new XElement("table", new XAttribute("style", STR_HTML_STYLE_TABLE),
                runname, passedtests, failedtests, total, successRate, elapsed);

            if (!String.IsNullOrEmpty(run.Environment))
            {
                // Environment
                XElement environment = new XElement("tr",
                    new XElement("th", new XAttribute("style", STR_HTML_STYLE_SUMMARY_HEADER), STR_HTML_ENVIRONMENT),
                    new XElement("td", new XAttribute("style", STR_HTML_STYLE_SUMMARY_CELL), run.Environment));

                // Overwrite Table
                table = new XElement("table", new XAttribute("style", STR_HTML_STYLE_TABLE),
                    runname, environment, passedtests, failedtests, total, successRate, elapsed);
            }

            return table;
        }

        /// <summary>
        ///  Returns an XML Element representing the screenshot/image
        /// </summary>
        /// <param name="imageText">complete location of the screenshot/image</param>
        /// <returns></returns>
        private static XElement GetLinkImage(String imageText)
        {
            XElement linkImage;
            if (!imageText.Equals("-"))
            {
                linkImage = new XElement("a", new XAttribute("href", TransformLinkImage(imageText)), "Link");
            }
            else
            {
                linkImage = new XElement("p", imageText);
            }

            return linkImage;
        }

        /// <summary>
        /// Transform image location to link
        /// </summary>
        /// <param name="imageText">complete location of the screenshot/image</param>
        /// <returns></returns>
        private static String TransformLinkImage(String imageText)
        {
            if (!imageText.Equals("-"))
            {
                int substr = 1 + LOGS_PATH.Length;
                imageText = imageText.Substring(substr, imageText.Length - substr);
                imageText = "file:///\\" + Environment.MachineName + "\\GATE" + @"\" + imageText;
            }
            return imageText;
        }
    }
}
