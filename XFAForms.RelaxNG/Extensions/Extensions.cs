using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XFAForms.RelaxNG.Extensions
{
    public static class Extensions
    {
        public static string FirstCharToUpper(this string str)
        {
            return (str == null) ? (null) : CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str.ToLower());
        }
    }
}
