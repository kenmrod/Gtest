using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Sys.Selenium
{
    public class GridHub
    {
        public Hub Value { get; set; }
    }

    public class Hub
    {
        public bool Ready { get; set; }
        public string Message { get; set; }
        public List<Node> Nodes { get; set; }
    }
}
