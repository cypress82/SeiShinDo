using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.IO;

namespace SeiShinDo.Web.Common
{
    public class UIHelper
    {
        //Constructor
        public UIHelper() { }

        public string HtmlOutput(string inputText)
        {
            return HttpUtility.HtmlDecode(inputText);
        }

        
    }
}
