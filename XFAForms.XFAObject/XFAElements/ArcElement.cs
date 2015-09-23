using System.Collections.Generic;

namespace XFAForms.XFAObject.XFAElements
{
    public class ArcElement : XFABaseElement
    {
        private string _name = "arc";
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

        public ArcElement()
        {
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );

            this._properties.Add("hand",
                new XFAProperty()
                {
                    Name = "hand",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.String, Value = "even" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.String, Value = "left" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.String, Value = "right" }
                    }
                }
            );

            this._properties.Add("id",
                new XFAProperty()
                {
                    Name = "id",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                }
            );

            this._properties.Add("name",
                new XFAProperty()
                {
                    Name = "name",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                }
            );

            this._properties.Add("startAngle",
                new XFAProperty()
                {
                    Name = "startAngle",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() {IsDefault = true,Type = EnumXFAPropertyValueType.Numeric, Value = "0"},
                    }
                }
            );

            this._properties.Add("sweepAngle",
                new XFAProperty()
                {
                    Name = "sweepAngle",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() {IsDefault = true,Type = EnumXFAPropertyValueType.Numeric, Value = "360"},
                    }
                }
            );

            this._properties.Add("use",
                new XFAProperty()
                {
                    Name = "use",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                }
            );

            this._properties.Add("edge",
                new XFAProperty()
                {
                    Name = "edge",
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
