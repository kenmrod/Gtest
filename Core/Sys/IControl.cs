using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Sys
{
    public interface IControl
    {
        String mControlName { get; set; }
        String mSearchType { get; set; }
        String[] mSearchValues { get; set; }
        void FindElement();
    }
}
