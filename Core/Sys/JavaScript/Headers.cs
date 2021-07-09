using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Core.Sys.JavaScript
{
    public static class Headers
    {
        public static string HEADER_COMMON = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Sys\JavaScript\common.js");
    }
}
