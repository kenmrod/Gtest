using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Sys.Appium
{
    public class AppEnvironment
    {
        public string UniqueName { get; set; }
        public string AppID { get; set; }
        public string PackagePath { get; set; }
        public string AppUrl { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Database { get; set; }
        public string PIN { get; set; }
    }
}
