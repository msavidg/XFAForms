using System.Collections.Generic;

namespace XFAForms.XFAObject.XFAElements
{

    public partial class Template : XFABaseElement
    {

        // <!--An element that describes a template. One such element exists for each template and all other elements described in this specification are descendants of the template element.-->

        private string _name = "template";
        private Dictionary<string, IXFAProperty> _properties = new Dictionary<string, IXFAProperty>();
        private EnumXFAElementType _type = EnumXFAElementType.Content;
        
        public new string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public new Dictionary<string, IXFAProperty> Properties
        {
            get { return _properties; }
            set { _properties = value; }
        }

        public new EnumXFAElementType Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public Template()
        {
            this._properties.Add("baseProfile",
                new XFAProperty()
                {
                    Name = "baseProfile",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"full" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"interactiveForms" }
                    }
                }
            );

            this._properties.Add("extras",
                new XFAProperty()
                {
                    Name = "extras",
                    Type = EnumXFAPropertyType.StructuredProperty,
                    Values = new List<IXFAPropertyValue>()
                }
            );
            this._properties.Add("subform",
                new XFAProperty()
                {
                    Name = "subform",
                    Type = EnumXFAPropertyType.StructuredProperty,
                    Values = new List<IXFAPropertyValue>()
                }
            );
        }
    }
}
