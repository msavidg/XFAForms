using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Xml.Linq;
using XFAForms.XFAObject.XFAElements;
using Attribute = System.Attribute;

namespace XFAForms.XFAObject.DynamicObjects

{


    public sealed class DynamicTemplateXml : DynamicObject, IEnumerable
    {

        private readonly Dictionary<string, IXFAElement> xfaElements = new Dictionary<string, IXFAElement>();

        private readonly List<XElement> _elements;

        public DynamicTemplateXml(string text)
        {

            var doc = XDocument.Parse(text);

            _elements = new List<XElement> { doc.Root };

            Initialize();
        }

        public DynamicTemplateXml(XElement element)
        {

            _elements = new List<XElement> { element };

            Initialize();

        }

        public DynamicTemplateXml(IEnumerable<XElement> elements)
        {

            _elements = new List<XElement>(elements);

            Initialize();

        }

        private void Initialize()
        {
        }

        public override bool TryGetMember(GetMemberBinder binder, out object result)
        {
            result = null;

            // Since template DOM is sparse we need to create a list for each element
            // If we have it in the XML, return the value of the attribute
            // If we don't have it in the XML, create it, add it to Attributes collection
            //var attr = _elements[0].Attribute(XName.Get(binder.Name));

            IXFAElement xfaElement = xfaElements[_elements[0].Name.LocalName];

            IXFAProperty property;

            if (_elements[0].HasAttributes && _elements[0].Attribute(binder.Name) != null)
            {
                result = _elements[0].Attribute(binder.Name).Value;
            }
            else if (xfaElement.Properties.TryGetValue(_elements[0].Name.LocalName, out property))
            {

                if (property.Type == EnumXFAPropertyType.Property)
                {

                    var a = new XAttribute(property.Name, property.Values.First(v => v.IsDefault == true).Value);

                    _elements[0].Add(a);

                    result = a.Value;
                }
            }

            if (result != null)
            {
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
            //foreach (var element in _elements.Elements().Where(e => e.HasAttributes && e.Attribute("name") != null))
            //    yield return element.Attribute("name").Value;
            foreach (var element in _elements.Elements().Where(e => e.HasAttributes && e.Attribute("name") != null))
                yield return element.Attribute("name").Value;

            foreach (var s in _elements[0].Attributes())
                yield return s.Name.LocalName;

            foreach (var s in xfaElements[_elements[0].Name.LocalName].Properties)
                yield return s.Key;
        }
    }
}