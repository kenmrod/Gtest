using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Sys.API
{
    public class APIEnvironment
    {
        public String UniqueName { get; set; }
        public String Url { get; set; }
        public String LoginAPI { get; set; }
        public String APIKey { get; set; }
        public List<Dictionary<string, string>> Credentials {get;set;}
    }
}
