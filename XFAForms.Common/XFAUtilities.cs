using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace XFAForms.Common
{
    public static class XFAUtilities
    {

        public static string HrefSplitter(string href)
        {

            string[] tokens = href.Split("#".ToCharArray());

            return tokens[0];

        }

        public static string GetHrefSubFormName(string href)
        {

            string[] tokens = href.Split("#().".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            return tokens[tokens.Length - 1];

        }

        public static string FullPathFromRelativeFilename(string containerFilePath, string releativeFilePath)
        {
            string s = String.Empty;

            s = Path.GetDirectoryName(containerFilePath) + Path.DirectorySeparatorChar + releativeFilePath;

            return s;
        }

    }
}
