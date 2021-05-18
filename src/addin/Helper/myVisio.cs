using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Visio_Multi_Page_Layer_Selector.Helper
{
    class MyVisio
    {
        public static Microsoft.Office.Interop.Visio.Application App => Globals.ThisAddIn.Application;
    }
}
