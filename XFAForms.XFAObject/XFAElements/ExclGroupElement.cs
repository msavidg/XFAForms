using System.Collections.Generic;

namespace XFAForms.XFAObject.XFAElements
{

    public partial class Exclgroup : XFABaseElement
    {

        // <!--A container element that describes a mutual exclusion relationship between a set of containers.-->

        private string _name = "exclGroup";
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

        public Exclgroup()
        {
            this._properties.Add("access",
                new XFAProperty()
                {
                    Name = "access",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"nonInteractive" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"open" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"protected" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"readOnly" }
                    }
                }
            );

            // string
            this._properties.Add("accessKey",
                new XFAProperty()
                {
                    Name = "accessKey",
                    Type = EnumXFAPropertyType.Property
                }
            );

            this._properties.Add("anchorType",
                new XFAProperty()
                {
                    Name = "anchorType",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"bottomCenter" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"bottomLeft" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"bottomRight" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"middleCenter" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"middleLeft" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"middleRight" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"topCenter" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"topLeft" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"topRight" }
                    }
                }
            );

            // integerDataType
            this._properties.Add("colSpan",
                new XFAProperty()
                {
                    Name = "colSpan",
                    Type = EnumXFAPropertyType.Property
                }
            );

            // measurementDataType
            this._properties.Add("h",
                new XFAProperty()
                {
                    Name = "h",
                    Type = EnumXFAPropertyType.Property
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

            this._properties.Add("layout",
                new XFAProperty()
                {
                    Name = "layout",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"lr-tb" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"position" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"rl-row" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"rl-tb" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"row" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"table" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"tb" }
                    }
                }
            );

            // measurementDataType
            this._properties.Add("maxH",
                new XFAProperty()
                {
                    Name = "maxH",
                    Type = EnumXFAPropertyType.Property
                }
            );

            // measurementDataType
            this._properties.Add("maxW",
                new XFAProperty()
                {
                    Name = "maxW",
                    Type = EnumXFAPropertyType.Property
                }
            );

            // measurementDataType
            this._properties.Add("minH",
                new XFAProperty()
                {
                    Name = "minH",
                    Type = EnumXFAPropertyType.Property
                }
            );

            // measurementDataType
            this._properties.Add("minW",
                new XFAProperty()
                {
                    Name = "minW",
                    Type = EnumXFAPropertyType.Property
                }
            );

            // NCName
            this._properties.Add("name",
                new XFAProperty()
                {
                    Name = "name",
                    Type = EnumXFAPropertyType.Property
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

            // string
            this._properties.Add("relevant",
                new XFAProperty()
                {
                    Name = "relevant",
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

            // measurementDataType
            this._properties.Add("w",
                new XFAProperty()
                {
                    Name = "w",
                    Type = EnumXFAPropertyType.Property
                }
            );

            // measurementDataType
            this._properties.Add("x",
                new XFAProperty()
                {
                    Name = "x",
                    Type = EnumXFAPropertyType.Property
                }
            );

            // measurementDataType
            this._properties.Add("y",
                new XFAProperty()
                {
                    Name = "y",
                    Type = EnumXFAPropertyType.Property
                }
            );

            this._properties.Add("assist",
                new XFAProperty()
                {
                    Name = "assist",
                    Type = EnumXFAPropertyType.StructuredProperty,
                    Values = new List<IXFAPropertyValue>()
                }
            );
            this._properties.Add("bind",
                new XFAProperty()
                {
                    Name = "bind",
                    Type = EnumXFAPropertyType.StructuredProperty,
                    Values = new List<IXFAPropertyValue>()
                }
            );
            this._properties.Add("border",
                new XFAProperty()
                {
                    Name = "border",
                    Type = EnumXFAPropertyType.StructuredProperty,
                    Values = new List<IXFAPropertyValue>()
                }
            );
            this._properties.Add("calculate",
                new XFAProperty()
                {
                    Name = "calculate",
                    Type = EnumXFAPropertyType.StructuredProperty,
                    Values = new List<IXFAPropertyValue>()
                }
            );
            this._properties.Add("caption",
                new XFAProperty()
                {
                    Name = "caption",
                    Type = EnumXFAPropertyType.StructuredProperty,
                    Values = new List<IXFAPropertyValue>()
                }
            );
            this._properties.Add("desc",
                new XFAProperty()
                {
                    Name = "desc",
                    Type = EnumXFAPropertyType.StructuredProperty,
                    Values = new List<IXFAPropertyValue>()
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
            this._properties.Add("traversal",
                new XFAProperty()
                {
                    Name = "traversal",
                    Type = EnumXFAPropertyType.StructuredProperty,
                    Values = new List<IXFAPropertyValue>()
                }
            );
            this._properties.Add("validate",
                new XFAProperty()
                {
                    Name = "validate",
                    Type = EnumXFAPropertyType.StructuredProperty,
                    Values = new List<IXFAPropertyValue>()
                }
            );
            this._properties.Add("connect",
                new XFAProperty()
                {
                    Name = "connect",
                    Type = EnumXFAPropertyType.StructuredProperty,
                    Values = new List<IXFAPropertyValue>()
                }
            );
            this._properties.Add("event",
                new XFAProperty()
                {
                    Name = "event",
                    Type = EnumXFAPropertyType.StructuredProperty,
                    Values = new List<IXFAPropertyValue>()
                }
            );
            this._properties.Add("field",
                new XFAProperty()
                {
                    Name = "field",
                    Type = EnumXFAPropertyType.StructuredProperty,
                    Values = new List<IXFAPropertyValue>()
                }
            );
            this._properties.Add("setProperty",
                new XFAProperty()
                {
                    Name = "setProperty",
                    Type = EnumXFAPropertyType.StructuredProperty,
                    Values = new List<IXFAPropertyValue>()
                }
            );
        }
    }
}
