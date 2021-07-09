using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Core.Sys.Appium;

namespace AppiumPIM
{
    public static class MyEnvironments
    {
        private static readonly string GATE_PATH = Directory.GetParent(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)).FullName;
        public static AppEnvironment[] Environments = new AppEnvironment[]
            {
                new AppEnvironment
                {
                    UniqueName = "DEFAULT",
                    AppID = "com.unionsquaresoftware.mobile",
                    PackagePath = Path.Combine(GATE_PATH, @"APK\PIM_Mobile_App.apk"),
                    AppUrl = "http://127.0.0.1:4723/wd/hub",
                    Username = "Automation",
                    Password = "Account123",
                    Database = "core2017",
                    PIN = ""
                }
                /* Copy and uncomment below to add new env. Do not delete this block, just copy */
                //,new AppEnvironment
                //{
                //    UniqueName = "NEW",
                //    AppID = "",
                //    PackagePath = "",
                //    AppUrl = "",
                //    Username = "",
                //    Password = "",
                //    Database = "",
                //    PIN = ""
                //}
            };

        public static bool Add(AppEnvironment AppEnvToAdd)
        {
            if (Environments.Any(x => x.UniqueName == AppEnvToAdd.UniqueName))
            {
                return false;
            }
            var temp = new List<AppEnvironment>(Environments);
            temp.Add(AppEnvToAdd);
            Environments = temp.ToArray();
            return true;
        }

        public static AppEnvironment Get(string Name)
        {
            return Environments.FirstOrDefault(x => x.UniqueName == Name);
        }
    }
}
