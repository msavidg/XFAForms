using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Xml.Linq;

namespace XFAForms.XFAObject.Interfaces.DataTypes
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

            // Since template DOM is sparse we need to create a list for each element
            // If we have it in the XML, return the value of the attribute
            // If we don't have it in the XML, create it, add it to Attributes collection
            var attr = _elements[0].Attribute(XName.Get(binder.Name));

            if (attr != null)
            {

                result = attr;
                return true;

            }
            else
            {

                var items = _elements[0].Elements().Where(e => e.HasAttributes && e.Attribute("name").Value.Equals(binder.Name));

                if (items == null || items.Count() == 0)
                {
                    return false;
                }

                result = new DynamicTemplateXml(items);

                return true;
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
            // Since template DOM is sparse we need to create a list for each element
            foreach (var element in _elements.Elements().Where(e => e.HasAttributes && e.Attribute("name") != null))
                yield return element.Attribute("name").Value;
        }

    }
}
