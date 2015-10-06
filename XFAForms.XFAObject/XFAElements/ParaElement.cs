using System.Collections.Generic;

namespace XFAForms.XFAObject.XFAElements
{

    public partial class Para : XFABaseElement
    {

        // <!--A formatting element that specifies default paragraph and alignment properties to be applied to the content of an enclosing container.-->

        private string _name = "para";
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

        public Para()
        {
            this._properties.Add("hAlign",
                new XFAProperty()
                {
                    Name = "hAlign",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"center" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"justify" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"justifyAll" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"left" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"radix" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"right" }
                    }
                }
            );

            // NCName
            this._properties.Add("id",
                new XFAProperty()
                {
                    Name = "id",
                    Type = EnumXFAPropertyType.Property
                }
            );

            // measurementDataType
            this._properties.Add("lineHeight",
                new XFAProperty()
                {
                    Name = "lineHeight",
                    Type = EnumXFAPropertyType.Property
                }
            );

            // measurementDataType
            this._properties.Add("marginLeft",
                new XFAProperty()
                {
                    Name = "marginLeft",
                    Type = EnumXFAPropertyType.Property
                }
            );

            // measurementDataType
            this._properties.Add("marginRight",
                new XFAProperty()
                {
                    Name = "marginRight",
                    Type = EnumXFAPropertyType.Property
                }
            );

            // integerDataType
            this._properties.Add("orphans",
                new XFAProperty()
                {
                    Name = "orphans",
                    Type = EnumXFAPropertyType.Property
                }
            );

            // string
            this._properties.Add("preserve",
                new XFAProperty()
                {
                    Name = "preserve",
                    Type = EnumXFAPropertyType.Property
                }
            );

            // measurementDataType
            this._properties.Add("radixOffset",
                new XFAProperty()
                {
                    Name = "radixOffset",
                    Type = EnumXFAPropertyType.Property
                }
            );

            // measurementDataType
            this._properties.Add("spaceAbove",
                new XFAProperty()
                {
                    Name = "spaceAbove",
                    Type = EnumXFAPropertyType.Property
                }
            );

            // measurementDataType
            this._properties.Add("spaceBelow",
                new XFAProperty()
                {
                    Name = "spaceBelow",
                    Type = EnumXFAPropertyType.Property
                }
            );

            // string
            this._properties.Add("tabDefault",
                new XFAProperty()
                {
                    Name = "tabDefault",
                    Type = EnumXFAPropertyType.Property
                }
            );

            // string
            this._properties.Add("tabStops",
                new XFAProperty()
                {
                    Name = "tabStops",
                    Type = EnumXFAPropertyType.Property
                }
            );

            // measurementDataType
            this._properties.Add("textIndent",
                new XFAProperty()
                {
                    Name = "textIndent",
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

            this._properties.Add("vAlign",
                new XFAProperty()
                {
                    Name = "vAlign",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"bottom" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"middle" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"top" }
                    }
                }
            );

            // integerDataType
            this._properties.Add("widows",
                new XFAProperty()
                {
                    Name = "widows",
                    Type = EnumXFAPropertyType.Property
                }
            );

            this._properties.Add("hyphenation",
                new XFAProperty()
                {
                    Name = "hyphenation",
                    Type = EnumXFAPropertyType.StructuredProperty,
                    Values = new List<IXFAPropertyValue>()
                }
            );
        }
    }
}
