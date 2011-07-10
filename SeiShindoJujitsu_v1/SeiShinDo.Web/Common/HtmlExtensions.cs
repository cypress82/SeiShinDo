using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Text;

namespace SeiShinDo.Web.Common
{
    public static class HtmlExtensions
    {
        public static MvcHtmlString Nl2Br(string text)
        {
            StringBuilder builder = new StringBuilder();
            string[] lines = text.Split('\n');
            for (int i = 0; i < lines.Length; i++)
            {
                if (i > 0)
                    builder.Append("<br/>");
                builder.Append(HttpUtility.HtmlEncode(lines[i]));
            }
            return new MvcHtmlString(builder.ToString());
        }
    }
}