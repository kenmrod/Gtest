using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Sys
{
    public interface IDriver
    {
        Logger SessionLogger { get; set; }
        void StartSession();
        void CloseSession();
        void CaptureScreenshot(string FileName);

    }
}
