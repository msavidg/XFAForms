using System;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace XFAForms.RelaxNG
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            StringBuilder sb = new StringBuilder();

            XDocument xDocument = XDocument.Load(@"c:\users\msavidg\Google Drive\Adobe Specs\Schemas\xfa_3.3\template.rng");
            XNamespace rng = "http://relaxng.org/ns/structure/1.0";

            foreach (XElement xElement in xDocument.Descendants(rng + "define").Where(e => e.Descendants(rng + "element").Any()))
            {

                var element = xElement.Element(rng + "element");

                if (element != null)
                {

                    sb.Length = 0;

                    foreach (var comment in element.DescendantNodes().Where(x => x.NodeType == XmlNodeType.Comment))
                    {

                        Console.WriteLine("\t" + comment.ToString());

                    }

                }

                Console.WriteLine(xElement.Attribute("name").Value);

            }
        }
    }
}