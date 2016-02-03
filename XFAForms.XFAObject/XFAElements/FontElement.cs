using System.Collections.Generic;

namespace XFAForms.XFAObject.XFAElements
{

    public partial class Font : XFABaseElement, IXFAElement
    {

        // <!--A formatting element that describes a font.-->

        private string _name = "font";
        private Dictionary<string, IXFAProperty> _properties = new Dictionary<string, IXFAProperty>();
        private EnumXFAElementType _type = EnumXFAElementType.Content;
        
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public Dictionary<string, IXFAProperty> Properties
        {
            get { return _properties; }
            set { _properties = value; }
        }

        public EnumXFAElementType Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public Font()
        {
            // measurementDataType
            this._properties.Add("baselineShift",
                new XFAProperty()
                {
                    Name = "baselineShift",
                    Type = EnumXFAPropertyType.Property
                }
            );

            // string
            this._properties.Add("fontHorizontalScale",
                new XFAProperty()
                {
                    Name = "fontHorizontalScale",
                    Type = EnumXFAPropertyType.Property
                }
            );

            // string
            this._properties.Add("fontVerticalScale",
                new XFAProperty()
                {
                    Name = "fontVerticalScale",
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

            this._properties.Add("kerningMode",
                new XFAProperty()
                {
                    Name = "kerningMode",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"none" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"pair" }
                    }
                }
            );

            // string
            this._properties.Add("letterSpacing",
                new XFAProperty()
                {
                    Name = "letterSpacing",
                    Type = EnumXFAPropertyType.Property
                }
            );

            this._properties.Add("lineThrough",
                new XFAProperty()
                {
                    Name = "lineThrough",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"1" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"2" }
                    }
                }
            );

            this._properties.Add("lineThroughPeriod",
                new XFAProperty()
                {
                    Name = "lineThroughPeriod",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"all" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"word" }
                    }
                }
            );

            this._properties.Add("overline",
                new XFAProperty()
                {
                    Name = "overline",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"1" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"2" }
                    }
                }
            );

            this._properties.Add("overlinePeriod",
                new XFAProperty()
                {
                    Name = "overlinePeriod",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"all" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"word" }
                    }
                }
            );

            this._properties.Add("posture",
                new XFAProperty()
                {
                    Name = "posture",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"italic" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"normal" }
                    }
                }
            );

            // measurementDataType
            this._properties.Add("size",
                new XFAProperty()
                {
                    Name = "size",
                    Type = EnumXFAPropertyType.Property
                }
            );

            // string
            this._properties.Add("typeface",
                new XFAProperty()
                {
                    Name = "typeface",
                    Type = EnumXFAPropertyType.Property
                }
            );

            this._properties.Add("underline",
                new XFAProperty()
                {
                    Name = "underline",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"1" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"2" }
                    }
                }
            );

            this._properties.Add("underlinePeriod",
                new XFAProperty()
                {
                    Name = "underlinePeriod",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"all" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"word" }
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

            this._properties.Add("weight",
                new XFAProperty()
                {
                    Name = "weight",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"bold" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"normal" }
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
            this._properties.Add("fill",
                new XFAProperty()
                {
                    Name = "fill",
                    Type = EnumXFAPropertyType.StructuredProperty,
                    Values = new List<IXFAPropertyValue>()
                }
            );
        }
    }
}
