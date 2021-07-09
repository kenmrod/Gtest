using Core.Sys.Selenium;
using Core.Sys.Appium;
using Core.Sys.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Core.Sys
{
    public static class TestEnvironment
    {
        public static List<SeleniumEnvironment> SeleniumEnvironments = new List<SeleniumEnvironment>();
        public static List<AppEnvironment> AppiummEnvironments = new List<AppEnvironment>();
        public static List<APIEnvironment> APIEnvironments = new List<APIEnvironment>();
        public static Dictionary<String, DataTable> EnvironmentData = new Dictionary<String, DataTable>();

        public static void LoadEnvironmentDataToList(String AssemblyName)
        {
            DataTable dt = EnvironmentData.Where(x => x.Key.ToLower().Equals(AssemblyName.ToLower())).First().Value;
            switch (AssemblyName.ToLower())
            {
                case "selcp":
                    SeleniumEnvironments.Clear();
                    SeleniumEnvironments.AddRange(ExtractDataToSeleniumList(dt));
                    break;
                case "apppim":
                    AppiummEnvironments.Clear();
                    AppiummEnvironments.AddRange(ExtractDataToAppiumList(dt));
                    break;
                case "":
                    APIEnvironments.Clear();
                    APIEnvironments.AddRange(ExtractDataToAPIList(dt));
                    break;
                default:
                    throw new Exception("Current product is not yet supported.");
            }
        }

        private static List<SeleniumEnvironment> ExtractDataToSeleniumList(DataTable dataTable)
        {
            List<SeleniumEnvironment> ls = new List<SeleniumEnvironment>();
            foreach (DataRow row in dataTable.Rows)
            {
                SeleniumEnvironment env = new SeleniumEnvironment();
                env.Id = row["Id"].ToString();
                env.Url = row["Url"].ToString();
                env.UserName = row["UserName"].ToString();
                env.Password = row["Password"].ToString();
                env.Database = row["Database"].ToString();
                env.UserInterface = row["UserInterface"].ToString();

                ls.Add(env);
            }
            return ls;
        }

        private static List<AppEnvironment> ExtractDataToAppiumList(DataTable dataTable)
        {
            List<AppEnvironment> ls = new List<AppEnvironment>();
            foreach (DataRow row in dataTable.Rows)
            {
                AppEnvironment env = new AppEnvironment();
                env.UniqueName = row["UniqueName"].ToString();
                env.AppID = row["AppID"].ToString();
                env.PackagePath = row["PackagePath"].ToString();
                env.Password = row["Password"].ToString();
                env.Database = row["Database"].ToString();
                env.AppUrl = row["AppUrl"].ToString();
                env.PIN = row["PIN"].ToString();
                ls.Add(env);
            }
            return ls;
        }

        private static List<APIEnvironment> ExtractDataToAPIList(DataTable dataTable)
        {
            List<APIEnvironment> ls = new List<APIEnvironment>();
            foreach (DataRow row in dataTable.Rows)
            {
                APIEnvironment env = new APIEnvironment();
                env.UniqueName = row["UniqueName"].ToString();
                env.Url = row["Url"].ToString();
                env.LoginAPI = row["LoginAPI"].ToString();
                env.APIKey = row["APIKey"].ToString();

                ls.Add(env);
            }
            return ls;
        }
    }
}
