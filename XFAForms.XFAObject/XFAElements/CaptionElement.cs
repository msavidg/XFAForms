using System.Collections.Generic;

namespace XFAForms.XFAObject.XFAElements
{

    public partial class Caption : XFABaseElement
    {

        // <!--A box model element that describes a descriptive label associated with an object.-->

        private string _name = "caption";
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

        public Caption()
        {
            // NCName
            this._properties.Add("id",
                new XFAProperty()
                {
                    Name = "id",
                    Type = EnumXFAPropertyType.Property
                }
            );

            this._properties.Add("placement",
                new XFAProperty()
                {
                    Name = "placement",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"bottom" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"inline" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"left" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"right" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"top" }
                    }
                }
            );

            this._properties.Add("presence",
                new XFAProperty()
                {
                    Name = "presence",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"hidden" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"inactive" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"invisible" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"visible" }
                    }
                }
            );

            // measurementDataType
            this._properties.Add("reserve",
                new XFAProperty()
                {
                    Name = "reserve",
                    Type = EnumXFAPropertyType.Property
                }
            );

            // string
            this._properties.Add("use",
                new XFAProperty()
                {
                    Name = "use",
                    Type = EnumXFAPropertyType.Property
                }
            );

            // string
            this._properties.Add("usehref",
                new XFAProperty()
                {
                    Name = "usehref",
                    Type = EnumXFAPropertyType.Property
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
            this._properties.Add("font",
                new XFAProperty()
                {
                    Name = "font",
                    Type = EnumXFAPropertyType.StructuredProperty,
                    Values = new List<IXFAPropertyValue>()
                }
            );
            this._properties.Add("margin",
                new XFAProperty()
                {
                    Name = "margin",
                    Type = EnumXFAPropertyType.StructuredProperty,
                    Values = new List<IXFAPropertyValue>()
                }
            );
            this._properties.Add("para",
                new XFAProperty()
                {
                    Name = "para",
                    Type = EnumXFAPropertyType.StructuredProperty,
                    Values = new List<IXFAPropertyValue>()
                }
            );
            this._properties.Add("value",
                new XFAProperty()
                {
                    Name = "value",
                    Type = EnumXFAPropertyType.StructuredProperty,
                    Values = new List<IXFAPropertyValue>()
                }
            );
        }
    }
}
