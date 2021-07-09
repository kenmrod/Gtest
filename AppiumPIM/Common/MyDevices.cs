using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Sys.Appium;

namespace AppiumPIM
{
    public static class MyDevices
    {
        public static Device[] Devices = new Device[]
        {
            new Device
            {
                Name = "emulator-5554",
                DType = Device.DeviceType.VIRTUAL,
                Version = "8.1.0",
                Height = 0,
                Width = 0,
                StatusBarHeight = 20
            }
            
            /* Copy and uncomment below to add new device. Do not delete this block, just copy */
            //,new Device
            //{
            //    Name = "ANDROID_EMULATOR",
            //    DType = Device.DeviceType.VIRTUAL,
            //    Version = "1",
            //    Height = 0,
            //    Width = 0,
            //    StatusBarHeight = 20
            //}
        };

        public static bool Add(Device DeviceToAdd)
        {
            if (Devices.Any(x => x.Name== DeviceToAdd.Name))
            {
                return false;
            }
            var temp = new List<Device>(Devices);
            temp.Add(DeviceToAdd);
            Devices = temp.ToArray();
            return true;
        }

        public static Device Get(string Name)
        {
            return Devices.FirstOrDefault(x => x.Name == Name);
        }
    }
}
