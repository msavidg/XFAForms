using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using XFAForms.RelaxNG.Extensions;

namespace XFAForms.RelaxNG
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            List<RNGElement> rngElements = new List<RNGElement>();

            XDocument xDocument = XDocument.Load(@"c:\users\msavidg\Google Drive\Adobe Specs\Schemas\xfa_3.3\template.rng");
            XNamespace rng = "http://relaxng.org/ns/structure/1.0";

            foreach (XElement rngDefineElement in xDocument.Descendants(rng + "define").Where(e => e.Descendants(rng + "element").Any()))
            {

                RNGElement e = new RNGElement();

                var rngElement = rngDefineElement.Element(rng + "element");
                if (rngElement != null)
                {

                    //Console.WriteLine("element=" + rngDefineElement.Attribute("name").Value);
                    e.Name = rngDefineElement.Attribute("name").Value.Replace("Element", String.Empty);

                    var rngComment = rngElement.DescendantNodes().FirstOrDefault(x => x.NodeType == XmlNodeType.Comment);
                    if (rngComment != null)
                    {
                        //Console.WriteLine("comment=" + rngComment);
                        e.Comment = rngComment.ToString();
                    }

                    var rngRef = rngElement.Element(rng + "ref");
                    if (rngRef != null)
                    {

                        var rngRefName = rngRef.Attribute("name").Value;

                        var rngDefineContent = xDocument.Descendants(rng + "define").First(d => d.Attribute("name").Value == rngRefName);

                        ProcessDefineContent(e, rngDefineContent, rng);

                    }
                }

                //Console.WriteLine();
                rngElements.Add(e);
            }

            CreateCode(rngElements);

            foreach (var r in rngElements)
            {
                Console.WriteLine("xfaElements.Add(\"" + r.Name + "\", new " + r.Name.FirstCharToUpper() + "Element());");
            }

        }

        private static void ProcessDefineContent(RNGElement e, XElement rngDefine, XNamespace rng)
        {

            foreach (var rngOptional in rngDefine.Elements(rng + "optional"))
            {

                RNGAttribute a = new RNGAttribute();

                var attribute = rngOptional.Element(rng + "attribute");

                var attributeName = attribute.Attribute("name").Value;

                //Console.WriteLine("define.optional.attribute=" + attributeName);
                a.Name = attributeName.Replace("Element", String.Empty);

                // rng:choice
                var rngChoice = attribute.Element(rng + "choice");
                if (rngChoice != null)
                {
                    foreach (var rngValue in rngChoice.Elements(rng + "value"))
                    {
                        //Console.WriteLine("define.optional.attribute.choice=" + rngValue.Value);
                        a.Choices.Add(rngValue.Value);
                    }
                }

                // rng:data
                var rngData = attribute.Element(rng + "data");
                if (rngData != null)
                {
                    //Console.WriteLine("define.optional.attribute.data=" + rngData.Attribute("type").Value);
                    a.DataType = rngData.Attribute("type").Value;
                }

                //rng:ref
                var rngRef = attribute.Element(rng + "ref");
                if (rngRef != null)
                {
                    //Console.WriteLine("define.optional.attribute.ref=" + rngRef.Attribute("name").Value);
                    a.DataType = rngRef.Attribute("name").Value.Replace("Element", String.Empty);
                }

                e.Attributes.Add(a);

            }

            foreach (var rngInterleave in rngDefine.Elements(rng + "interleave"))
            {

                foreach (var rngOptional in rngInterleave.Elements(rng + "optional"))
                {
                    //rng:choice
                    var rngChoice = rngOptional.Element(rng + "choice");
                    if (rngChoice != null)
                    {
                        foreach (var rngValue in rngChoice.Elements(rng + "value"))
                        {
                            //Console.WriteLine("define.interleave.optional.choice=" + rngValue.Value);
                            e.Children.Add(new RNGChild() { Name = rngValue.Value });
                        }
                    }
                    //rng:ref
                    var rngRef = rngOptional.Element(rng + "ref");
                    if (rngRef != null)
                    {
                        //Console.WriteLine("define.interleave.optional.ref=" + rngRef.Attribute("name").Value);
                        e.Children.Add(new RNGChild() { Name = rngRef.Attribute("name").Value.Replace("Element", String.Empty) });
                    }
                }

                foreach (var rngZeroOrMore in rngInterleave.Elements(rng + "zeroOrMore"))
                {
                    //rng:ref
                    var rngRef = rngZeroOrMore.Element(rng + "ref");
                    if (rngRef != null)
                    {
                        //Console.WriteLine("define.interleave.zeroOrMore.ref=" + rngRef.Attribute("name").Value);
                        e.Children.Add(new RNGChild() { Name = rngRef.Attribute("name").Value.Replace("Element", String.Empty) });
                    }
                }
            }
        }

        private static void CreateCode(List<RNGElement> rngElements)
        {

            StringBuilder sb = new StringBuilder();

            foreach (var re in rngElements)
            {
                sb.AppendLine("using System.Collections.Generic;");
                sb.AppendLine("");
                sb.AppendLine("namespace XFAForms.XFAObject.XFAElements");
                sb.AppendLine("{");
                sb.AppendLine("");
                sb.AppendLine("    public partial class " + re.Name.FirstCharToUpper() + " : XFABaseElement, IXFAElement");
                sb.AppendLine("    {");
                sb.AppendLine("");
                sb.AppendLine($"        // {re.Comment}");
                sb.AppendLine("");
                sb.AppendLine("        private string _name = \"" + re.Name + "\";");
                sb.AppendLine("        private Dictionary<string, IXFAProperty> _properties = new Dictionary<string, IXFAProperty>();");
                sb.AppendLine("        private EnumXFAElementType _type = EnumXFAElementType.Content;");
                sb.AppendLine("        ");
                sb.AppendLine("        public string Name");
                sb.AppendLine("        {");
                sb.AppendLine("            get { return _name; }");
                sb.AppendLine("            set { _name = value; }");
                sb.AppendLine("        }");
                sb.AppendLine("");
                sb.AppendLine("        public Dictionary<string, IXFAProperty> Properties");
                sb.AppendLine("        {");
                sb.AppendLine("            get { return _properties; }");
                sb.AppendLine("            set { _properties = value; }");
                sb.AppendLine("        }");
                sb.AppendLine("");
                sb.AppendLine("        public EnumXFAElementType Type");
                sb.AppendLine("        {");
                sb.AppendLine("            get { return _type; }");
                sb.AppendLine("            set { _type = value; }");
                sb.AppendLine("        }");
                sb.AppendLine("");
                sb.AppendLine("        public " + re.Name.FirstCharToUpper() + "()");
                sb.AppendLine("        {");
                foreach (var a in re.Attributes)
                {
                    if (!String.IsNullOrEmpty(a.DataType))
                        sb.AppendLine($"            // { a.DataType}");
                    sb.AppendLine("            this._properties.Add(\"" + a.Name + "\",");
                    sb.AppendLine("                new XFAProperty()");
                    sb.AppendLine("                {");
                    sb.AppendLine("                    Name = \"" + a.Name + "\",");
                    if (a.Choices.Count == 0)
                    {
                        sb.AppendLine("                    Type = EnumXFAPropertyType.Property");
                    }
                    else
                    {
                        sb.AppendLine("                    Type = EnumXFAPropertyType.Property,");
                        sb.AppendLine("                    Values = new List<IXFAPropertyValue>()");
                        sb.AppendLine("                    {");

                        int i = a.Choices.Count - 1;

                        foreach (var c in a.Choices)
                        {

                            sb.Append("                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @\"" + c + "\" }");

                            if (i == 0)
                            {
                                sb.AppendLine("");
                            }
                            else
                            {
                                sb.AppendLine(",");
                            }

                            i -= 1;

                        }
                        sb.AppendLine("                    }");
                    }
                    sb.AppendLine("                }");
                    sb.AppendLine("            );");
                    sb.AppendLine("");
                }

                foreach (var c in re.Children)
                {
                    sb.AppendLine("            this._properties.Add(\"" + c.Name + "\",");
                    sb.AppendLine("                new XFAProperty()");
                    sb.AppendLine("                {");
                    sb.AppendLine("                    Name = \"" + c.Name + "\",");
                    sb.AppendLine("                    Type = EnumXFAPropertyType.StructuredProperty,");
                    sb.AppendLine("                    Values = new List<IXFAPropertyValue>()");
                    sb.AppendLine("                }");
                    sb.AppendLine("            );");
                }

                sb.AppendLine("        }");
                sb.AppendLine("    }");
                sb.AppendLine("}");

                File.WriteAllText($@"C:\Dev\XFAForms\XFAForms.XFAObject\XFAElements\{re.Name.FirstCharToUpper()}Element.cs", sb.ToString());

                sb.Length = 0;

            }
        }
    }
}


public class RNGElement
{
    public string Name { get; set; }
    public string Comment { get; set; }
    public List<RNGAttribute> Attributes;
    public List<RNGChild> Children;

    public RNGElement()
    {
        Attributes = new List<RNGAttribute>();
        Children = new List<RNGChild>();
    }
}

public class RNGAttribute
{
    public string Name { get; set; }
    public string DataType { get; set; }
    public List<string> Choices;

    public RNGAttribute()
    {
        Choices = new List<string>();
    }
}

public class RNGChild
{
    public string Name { get; set; }

}

