using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.ClearScript;
using Microsoft.ClearScript.V8;
using XFAForms.Console.DataTypes;

namespace XFAForms.Console
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var engine = new V8ScriptEngine())
            {

                string xml = File.ReadAllText(@"C:\Dev\FormsLibrary\ECP\DataSchemas\Account.xml");

                engine.Script.account = new DynamicXml(xml);

                var a1 = engine.Evaluate("account.CurrentRisk.Options.nodes.length");
                var a2 = engine.Evaluate("account.CurrentRisk.Options.nodes.item(0)");
                var a3 = engine.Evaluate("account.CurrentRisk.Options.nodes.item(0).OptionId.value");
                var a4 = engine.Evaluate("account.CurrentRisk.Options.nodes.item(0).OptionDetailECP.OptionDetailECPId.value");

            }
        }

    }

    #region DynamicXml

    //http://www.captechconsulting.com/blogs/fluent-xml-parsing-using-cs-dynamic-type-part-1
    //http://blogs.msdn.com/b/csharpfaq/archive/2009/10/19/dynamic-in-c-4-0-creating-wrappers-with-dynamicobject.aspx

    public sealed class DynamicNodes : DynamicObject, IEnumerable
    {

        private readonly List<DynamicXml> _nodes;

        public DynamicNodes(List<DynamicXml> nodes)
        {
            _nodes = nodes;
        }

        public int length
        {
            get { return _nodes.Count; }
        }

        public DynamicXml item(int index)
        {
            return _nodes[index];
        }

        public IEnumerator GetEnumerator()
        {

            return _nodes.GetEnumerator();

        }

    }

    public sealed class DynamicXml : DynamicObject, IEnumerable
    {

        private readonly List<XElement> _elements;

        public DynamicXml(string text)
        {
            var doc = XDocument.Parse(text);
            _elements = new List<XElement> { doc.Root };
        }

        public DynamicXml(XElement element)
        {
            _elements = new List<XElement> { element };
        }

        public DynamicXml(IEnumerable<XElement> elements)
        {
            _elements = new List<XElement>(elements);
        }

        public override bool TryGetMember(GetMemberBinder binder, out object result)
        {

            result = null;

            if (binder.Name == "value")
            {

                result = _elements[0].Value;
                return true;

            }
            else if (binder.Name == "nodes")
            {

                result = new DynamicNodes(_elements.Elements().Select(e => new DynamicXml(e)).ToList());
                return true;

            }
            else
            {

                var attr = _elements[0].Attribute(XName.Get(binder.Name));

                if (attr != null)
                {

                    result = attr;
                    return true;

                }
                else
                {

                    var items = _elements.Elements(XName.Get(binder.Name));

                    if (items == null || items.Count() == 0)
                    {
                        return false;
                    }

                    result = new DynamicXml(items);
                    return true;

                }
            }
        }

        public override bool TryGetIndex(GetIndexBinder binder, object[] indexes, out object result)
        {
            int ndx = (int)indexes[0];
            result = new DynamicXml(_elements[ndx]);

            return true;
        }

        public IEnumerator GetEnumerator()
        {
            foreach (var element in _elements)
                yield return new DynamicXml(element);
        }

        public override IEnumerable<string> GetDynamicMemberNames()
        {
            foreach (var element in _elements.Elements())
                yield return element.Name.LocalName;

            yield return "value";
            yield return "nodes";

        }

    }

    #endregion

}
