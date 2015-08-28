using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XFAForms.Common
{
    public static class XFAUtilities
    {

        public static string hrefSplitter(string href)
        {

            string[] tokens = href.Split("#".ToCharArray());

            return tokens[0];

        }

    }
}
