using System.Collections.Generic;

namespace XFAForms.XFAObject.XFAElements
{

    public partial class Fill : XFABaseElement
    {

        // <!--A formatting element that applies a color and optional rendered designs to the region enclosed by an object.-->

        private string _name = "fill";
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

        public Fill()
        {
            // NCName
            this._properties.Add("id",
                new XFAProperty()
                {
                    Name = "id",
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
