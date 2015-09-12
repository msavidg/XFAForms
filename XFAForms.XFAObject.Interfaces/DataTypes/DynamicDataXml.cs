using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Xml.Linq;

namespace XFAForms.XFAObject.Interfaces.DataTypes
{
    public sealed class DynamicDataXml : DynamicObject, IEnumerable
    {

        private readonly List<XElement> _elements;

        public DynamicDataXml(string text)
        {
            var doc = XDocument.Parse(text);
            _elements = new List<XElement> { doc.Root };
        }

        public DynamicDataXml(XElement element)
        {
            _elements = new List<XElement> { element };
        }

        public DynamicDataXml(IEnumerable<XElement> elements)
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

                result = new DynamicDataNodes(_elements.Elements().Select(e => new DynamicDataXml(e)).ToList());
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

                    result = new DynamicDataXml(items);
                    return true;

                }
            }
        }

        public override bool TryGetIndex(GetIndexBinder binder, object[] indexes, out object result)
        {
            int ndx = (int)indexes[0];
            result = new DynamicDataXml(_elements[ndx]);

            return true;
        }

        public IEnumerator GetEnumerator()
        {
            foreach (var element in _elements)
                yield return new DynamicDataXml(element);
        }

        public override IEnumerable<string> GetDynamicMemberNames()
        {
            foreach (var element in _elements.Elements())
                yield return element.Name.LocalName;

            yield return "value";
            yield return "nodes";

        }

    }
}
