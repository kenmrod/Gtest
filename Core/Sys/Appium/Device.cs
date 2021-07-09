using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Sys.Appium
{
    public class Device
    {
        public enum DeviceType
        {
            ACTUAL,
            VIRTUAL
        }

        public DeviceType DType { get; set; }
        public string Name { get; set; }
        public string Version { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public int StatusBarHeight { get; set; }
    }
}
