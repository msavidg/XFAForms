using System.Collections.Generic;

namespace XFAForms.XFAObject.XFAElements
{

    public partial class Corner : XFABaseElement
    {

        // <!--A formatting element that describes the appearance of a vertex between two edges-->

        private string _name = "corner";
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

        public Corner()
        {
            // NCName
            this._properties.Add("id",
                new XFAProperty()
                {
                    Name = "id",
                    Type = EnumXFAPropertyType.Property
                }
            );

            this._properties.Add("inverted",
                new XFAProperty()
                {
                    Name = "inverted",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"1" }
                    }
                }
            );

            this._properties.Add("join",
                new XFAProperty()
                {
                    Name = "join",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"round" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"square" }
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
            this._properties.Add("radius",
                new XFAProperty()
                {
                    Name = "radius",
                    Type = EnumXFAPropertyType.Property
                }
            );

            this._properties.Add("stroke",
                new XFAProperty()
                {
                    Name = "stroke",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"dashDot" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"dashDotDot" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"dashed" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"dotted" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"embossed" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"etched" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"lowered" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"raised" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"solid" }
                    }
                }
            );

            // measurementDataType
            this._properties.Add("thickness",
                new XFAProperty()
                {
                    Name = "thickness",
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

            this._properties.Add("color",
                new XFAProperty()
                {
                    Name = "color",
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
        }
    }
}
