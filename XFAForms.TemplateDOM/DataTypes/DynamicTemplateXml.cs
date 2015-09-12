using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace XFAForms.TemplateDOM.DataTypes
{
    public sealed class DynamicTemplateXml : DynamicObject, IEnumerable
    {

        private readonly List<XElement> _elements;

        public DynamicTemplateXml(string text)
        {
            var doc = XDocument.Parse(text);
            _elements = new List<XElement> { doc.Root };
        }

        public DynamicTemplateXml(XElement element)
        {
            _elements = new List<XElement> { element };
        }

        public DynamicTemplateXml(IEnumerable<XElement> elements)
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

                result = new DynamicTemplateNodes(_elements.Elements().Select(e => new DynamicTemplateXml(e)).ToList());
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

                    result = new DynamicTemplateXml(items);
                    return true;

                }
            }
        }

        public override bool TryGetIndex(GetIndexBinder binder, object[] indexes, out object result)
        {
            int ndx = (int)indexes[0];
            result = new DynamicTemplateXml(_elements[ndx]);

            return true;
        }

        public IEnumerator GetEnumerator()
        {
            foreach (var element in _elements)
                yield return new DynamicTemplateXml(element);
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
