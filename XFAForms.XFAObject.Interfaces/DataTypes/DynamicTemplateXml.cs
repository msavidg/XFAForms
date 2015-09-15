using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Xml.Linq;
using Castle.Components.DictionaryAdapter;

namespace XFAForms.XFAObject.Interfaces.DataTypes

{

    #region Stuff

    public sealed class AttributeValue
    {

        public string Value { get; set; }

        public Boolean Default { get; set; }

    }

    public sealed class Attribute
    {
        public Attribute()
        {
            this.Values = new List<AttributeValue>();
        }

        public string Name { get; set; }

        public List<AttributeValue> Values { get; set; }

    }

    public sealed class Element
    {
        public Element()
        {
            Attributes = new List<Attribute>();
        }

        public string Name { get; set; }

        public List<Attribute> Attributes { get; set; }

    }

    #endregion

    public sealed class DynamicTemplateXml : DynamicObject, IEnumerable
    {

        private Dictionary<string, Element> attributes = new Dictionary<string, Element>();

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
            attributes.Add("subform", new Element()
            {
                Name = "subform",
                Attributes = new List<Attribute>()
                {
                    new Attribute()
                    {
                        Name = "anchorType", Values = new List<AttributeValue>()
                        {
                            new AttributeValue(){Default = true, Value = "topLeft"},
                            new AttributeValue(){Default = false, Value = "topCenter"},
                            new AttributeValue(){Default = false, Value = "topRight"},
                            new AttributeValue(){Default = false, Value = "middleLeft"},
                            new AttributeValue(){Default = false, Value = "middleCenter"},
                            new AttributeValue(){Default = false, Value = "middleRight"},
                            new AttributeValue(){Default = false, Value = "bottomLeft"},
                            new AttributeValue(){Default = false, Value = "bottomCenter"},
                            new AttributeValue(){Default = false, Value = "bottomRight"}
                        }
                    },
                    new Attribute(){Name = "h", Values = new List<AttributeValue>(){new AttributeValue() {Default = true,Value="0in"}}},
                    new Attribute(){Name = "id", Values = new List<AttributeValue>(){new AttributeValue() {Default = true, Value=String.Empty}}},
                    new Attribute(){Name = "maxH", Values = new List<AttributeValue>(){new AttributeValue() {Default = true, Value= "0in" } }},
                    new Attribute(){Name = "maxW", Values = new List<AttributeValue>(){new AttributeValue() {Default = true, Value= "0in" } }},
                    new Attribute(){Name = "minH", Values = new List<AttributeValue>(){new AttributeValue() {Default = true, Value= "0in" } }},
                    new Attribute(){Name = "minW", Values = new List<AttributeValue>(){new AttributeValue() {Default = true, Value= "0in" } }},
                    new Attribute(){Name = "name", Values = new List<AttributeValue>(){new AttributeValue() {Default = true, Value=String.Empty}}},
                    new Attribute(){Name = "presence", Values = new List<AttributeValue>()
                    {
                        new AttributeValue() {Default = true,Value="visible"},
                        new AttributeValue() {Default = false,Value="invisible"},
                        new AttributeValue() {Default = false,Value="hidden"}
                    }},
                    new Attribute(){Name = "rotate", Values = new List<AttributeValue>(){new AttributeValue() {Default = true, Value="0"}}},
                    new Attribute(){Name = "use", Values = new List<AttributeValue>(){new AttributeValue() {Default = true, Value="cdata"}}},
                    new Attribute(){Name = "w", Values = new List<AttributeValue>(){new AttributeValue() {Default = true, Value= "0in" } }},
                    new Attribute(){Name = "x", Values = new List<AttributeValue>(){new AttributeValue() {Default = true, Value= "0in" } }},
                    new Attribute(){Name = "y", Values = new List<AttributeValue>(){new AttributeValue() {Default = true, Value= "0in" } }}
                }
            });
        }

        public override bool TryGetMember(GetMemberBinder binder, out object result)
        {

            result = null;

            // Since template DOM is sparse we need to create a list for each element
            // If we have it in the XML, return the value of the attribute
            // If we don't have it in the XML, create it, add it to Attributes collection
            //var attr = _elements[0].Attribute(XName.Get(binder.Name));

            Element element;

            if (_elements[0].HasAttributes && _elements[0].Attribute(binder.Name) != null)
            {

                result = _elements[0].Attribute(binder.Name).Value;

            }
            else if (attributes.TryGetValue(_elements[0].Name.LocalName, out element))
            {

                Attribute attribute = element.Attributes.FirstOrDefault(a => a.Name.Equals(binder.Name));

                if (attribute != null)
                {

                    var a = new XAttribute(attribute.Name, attribute.Values.First(v => v.Default == true).Value);

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

            foreach (var s in attributes[_elements[0].Name.LocalName].Attributes)
                yield return s.Name;
        }

    }
}
