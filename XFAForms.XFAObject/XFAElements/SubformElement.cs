using System.Collections.Generic;

namespace XFAForms.XFAObject.XFAElements
{

    public partial class Subform : XFABaseElement
    {

        // <!--A container element that describes a single subform capable of enclosing other containers.-->

        private string _name = "subform";
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

        public Subform()
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

            this._properties.Add("allowMacro",
                new XFAProperty()
                {
                    Name = "allowMacro",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"1" }
                    }
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

            // string
            this._properties.Add("columnWidths",
                new XFAProperty()
                {
                    Name = "columnWidths",
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

            // string
            this._properties.Add("locale",
                new XFAProperty()
                {
                    Name = "locale",
                    Type = EnumXFAPropertyType.Property
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

            this._properties.Add("mergeMode",
                new XFAProperty()
                {
                    Name = "mergeMode",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"consumeData" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"matchTemplate" }
                    }
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

            this._properties.Add("restoreState",
                new XFAProperty()
                {
                    Name = "restoreState",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"auto" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"manual" }
                    }
                }
            );

            this._properties.Add("scope",
                new XFAProperty()
                {
                    Name = "scope",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"name" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"none" }
                    }
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
            this._properties.Add("bookend",
                new XFAProperty()
                {
                    Name = "bookend",
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
            this._properties.Add("break",
                new XFAProperty()
                {
                    Name = "break",
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
            this._properties.Add("keep",
                new XFAProperty()
                {
                    Name = "keep",
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
            this._properties.Add("occur",
                new XFAProperty()
                {
                    Name = "occur",
                    Type = EnumXFAPropertyType.StructuredProperty,
                    Values = new List<IXFAPropertyValue>()
                }
            );
            this._properties.Add("overflow",
                new XFAProperty()
                {
                    Name = "overflow",
                    Type = EnumXFAPropertyType.StructuredProperty,
                    Values = new List<IXFAPropertyValue>()
                }
            );
            this._properties.Add("pageSet",
                new XFAProperty()
                {
                    Name = "pageSet",
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
            this._properties.Add("variables",
                new XFAProperty()
                {
                    Name = "variables",
                    Type = EnumXFAPropertyType.StructuredProperty,
                    Values = new List<IXFAPropertyValue>()
                }
            );
            this._properties.Add("area",
                new XFAProperty()
                {
                    Name = "area",
                    Type = EnumXFAPropertyType.StructuredProperty,
                    Values = new List<IXFAPropertyValue>()
                }
            );
            this._properties.Add("breakAfter",
                new XFAProperty()
                {
                    Name = "breakAfter",
                    Type = EnumXFAPropertyType.StructuredProperty,
                    Values = new List<IXFAPropertyValue>()
                }
            );
            this._properties.Add("breakBefore",
                new XFAProperty()
                {
                    Name = "breakBefore",
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
            this._properties.Add("draw",
                new XFAProperty()
                {
                    Name = "draw",
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
            this._properties.Add("exclGroup",
                new XFAProperty()
                {
                    Name = "exclGroup",
                    Type = EnumXFAPropertyType.StructuredProperty,
                    Values = new List<IXFAPropertyValue>()
                }
            );
            this._properties.Add("exObject",
                new XFAProperty()
                {
                    Name = "exObject",
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
            this._properties.Add("proto",
                new XFAProperty()
                {
                    Name = "proto",
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
            this._properties.Add("subform",
                new XFAProperty()
                {
                    Name = "subform",
                    Type = EnumXFAPropertyType.StructuredProperty,
                    Values = new List<IXFAPropertyValue>()
                }
            );
            this._properties.Add("subformSet",
                new XFAProperty()
                {
                    Name = "subformSet",
                    Type = EnumXFAPropertyType.StructuredProperty,
                    Values = new List<IXFAPropertyValue>()
                }
            );
        }
    }
}
