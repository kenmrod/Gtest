using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Sys;
using Core.Sys.Appium;
using AppiumPIM.Tests;

namespace AppiumPIM.TestRuns
{
    public class SampleRun1 : AppiumTestRun
    {
        public SampleRun1(Logger SessionLogger) : base(SessionLogger) { }
        public override void ExecuteTests()
        {
            new SampleTest1().Run(this,
                AppiumDriver.Platform.ANDROID_APP,
                MyEnvironments.Get("DEFAULT"),
                MyDevices.Get("emulator-5554"),
                "com.unionsquaresoftware.mobile.MainActivity"
                );
        }
    }
}
