using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;

namespace Core.Sys
{
    public interface ITestScript
    {
        bool Result { get; set; }
        string Error { get; }
        string Name { get; }
        string Platform { get; }
        string Machine { get; }
        string ErrorScreenshot { get; set; }
        int Instance { get; set; }
        DateTime StartTime { get; set; }
        DateTime EndTime { get; set; }
        TimeSpan Elapsed { get; set; }
        Logger ScriptLogger { get; set; }

        bool Run(ITestRun Owner, params object[] Arguments);
        //bool Run(string TestEnvironment = "", bool IncludeInResults = true);
        bool TestSetup(out string ErrorMessage);
        //bool TestExecute(out string ErrorMessage);
        bool TestExecute(out string ErrorMessage, IDriver Driver);
        bool TestExecute(out string ErrorMessage, string TestEnvironment, IDriver Driver);
        bool TestTearDown(string ErrorMessage);
    }
}
