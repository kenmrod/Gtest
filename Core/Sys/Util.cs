using System;
using System.Diagnostics;
using System.Collections.Generic;
using Microsoft.VisualBasic.FileIO;
using System.Data;
using OfficeOpenXml;
using System.IO;
using System.Linq;

namespace Core.Sys
{
    public static class Util
    {
        public static bool IsProcessRunning(string ProcessName)
        {
            Boolean bIsRunning = false;
            Process[] processes = Process.GetProcesses();

            foreach (Process process in processes)
            {
                if (process.ProcessName.ToLower().Contains(ProcessName.ToLower()))
                {
                    bIsRunning = true;
                    break;
                }
            }
            return bIsRunning;
        }

        /// <summary>
        /// Runs a process. Use a timeout of 0 seconds to skip timeout logic
        /// </summary>
        /// <param name="Filename"></param>
        /// <param name="Arguments"></param>
        /// <param name="WorkingDir"></param>
        /// <param name="bHideWin"></param>
        /// <param name="iTimeoutSec"></param>
        public static void RunProcess(String Filename, String Arguments, String WorkingDir, Boolean bHideWin, int iTimeoutSec)
        {
            Process p = new Process();
            p.StartInfo.FileName = Filename;
            p.StartInfo.Arguments = Arguments;
            p.StartInfo.WorkingDirectory = WorkingDir;
            p.StartInfo.UseShellExecute = true;
            if (bHideWin)
            {
                p.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            }
            p.Start();
            if (iTimeoutSec > 0)
            {
                p.WaitForExit(iTimeoutSec * 1000);
                if (!p.HasExited)
                {
                    p.Kill();
                }
            }
        }

        // Runs a process. Modified to either wait or kill process after specific time.
        public static Process RunProcess(String Filename, String Arguments, String WorkingDir, Boolean bHideWin, Boolean bWait)
        {
            Process p = new Process();
            p.StartInfo.FileName = Filename;
            p.StartInfo.Arguments = Arguments;
            p.StartInfo.WorkingDirectory = WorkingDir;
            p.StartInfo.UseShellExecute = true;
            if (bHideWin)
            {
                p.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            }
            p.Start();

            if (bWait)
            {
                p.WaitForExit();
            }

            return p;
        }

        /// <summary>
        /// kills named processes
        /// </summary>
        /// <param name="ProccessesToKill">exact names of process to kill</param>
        public static void KillProcesses(String[] ProccessesToKill)
        {
            foreach (string ProcName in ProccessesToKill)
            {
                KillProcessesByName(ProcName);
            }
        }

        /// <summary>
        /// kills a single process using the exact name of the process
        /// </summary>
        /// <param name="ProcessName"></param>
        public static void KillProcessesByName(string ProcessName)
        {
            try
            {
                List<Process> processes = new List<Process>(Process.GetProcesses());
                foreach (Process process in processes.FindAll(x => x.ProcessName == ProcessName))
                {
                    process.Kill();
                }
            }
            catch
            {
                //swallow
            }
        }

        public static string GetDateTimeString(DateTime inputString)
        {
            return string.Format("{0:yyyyMMddHHmmss}", inputString);
        }

        public static DataTable CSVParse(string path)
        {
            long lineNumber = 0;
            DataTable dt = new DataTable();
            string[] fields = null;
            using (TextFieldParser parser = new TextFieldParser(path))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.Delimiters = new string[] { "," };
                parser.HasFieldsEnclosedInQuotes = true; // for commas inside fields
                while (!parser.EndOfData)
                {
                    try
                    {
                        lineNumber = parser.LineNumber;
                        fields = parser.ReadFields();
                        if (lineNumber > 1) // if data field
                        {
                            dt.Rows.Add(fields);
                        }
                        else if (lineNumber == 1) // if first line (header)
                        {
                            foreach (string header in fields)
                            {
                                dt.Columns.Add(header);
                            }
                        }
                    }
                    catch (MalformedLineException) /* for unescaped/trailing double quotes (only happens when user erases escape-string intended double-quotes outside of Test Runner, which breaks CSV standards) */
                    {
                        //string error = "There is a problem parsing the CSV file on line " + lineNumber.ToString() + ".\n\nPlease ensure that double-quotes inside data fields are preceded by another double-quote.\n\nRe-exporting the data using Test Editor can also fix this.";
                        parser.Close();
                        parser.Dispose();
                        throw new Exception("Problem parsing the CSV file on line " + lineNumber.ToString());
                    }
                    catch // other exceptions handled by main function
                    {
                        parser.Close();
                        parser.Dispose();
                        throw;
                    }
                }
                parser.Close();
                parser.Dispose();
                return dt;
            }
        }

        public static DataTable ExceltoDataTable(string path, bool hasHeader = true)
        {
            DataTable dt = new DataTable();
            using(ExcelPackage pkg = new ExcelPackage())
            {
                using(var stream = File.OpenRead(path))
                {
                    pkg.Load(stream);
                }
                ExcelWorksheet ws = pkg.Workbook.Worksheets.First();
                foreach (var firstRowCell in ws.Cells[1, 1, 1, ws.Dimension.End.Column])
                {
                    dt.Columns.Add(hasHeader ? firstRowCell.Text : string.Format("Column {0}", firstRowCell.Start.Column));
                }
                var startRow = hasHeader ? 2 : 1;
                for (int rowNum = startRow; rowNum <= ws.Dimension.End.Row; rowNum++)
                {
                    var wsRow = ws.Cells[rowNum, 1, rowNum, ws.Dimension.End.Column];
                    DataRow row = dt.Rows.Add();
                    foreach (var cell in wsRow)
                    {
                        row[cell.Start.Column - 1] = cell.Text;
                    }
                }
            }
            return dt;
        }
    }
}
