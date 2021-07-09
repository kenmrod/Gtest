using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace Core.Sys
{
    public interface ITestRun
    {
        DateTime StartTime { get; set; }
        DateTime EndTime { get; set; }
        TimeSpan Elapsed { get; set; }
        int Test_Total { get; set; }
        int Test_Passed { get; set; }
        int Test_Failed { get; set; }
        int Test_CurrentRunNumber { get; set; }
        Dictionary<int, ITestScript> TestManifest { get; set; }
        Logger SessionLogger { get; set; }

        //Mailer Emailer { get;}
        string Name { get;}
        string Environment { get; set; }

        int PassRate { get; }

        int Run();

        int Run(object[] Arguments);

        int Run(string HostName);
        int Run(string HostName, string Port);

        void SetUp();

        void ExecuteTests();

        void ExecuteTests(object[] Arguments);

        void TearDown();

        //string CreateEmailBody(string summaryFile);

        void CacheAndDisplayLogs(string Msg);
    }
}
