using System.Collections.Generic;

namespace XFAForms.XFAObject.XFAElements
{

    public partial class Medium : XFABaseElement, IXFAElement
    {

        // <!--An element that describes a physical medium upon which to render. Some hybrid paper/glass media, such as PDF, may require both paper and glass properties.-->

        private string _name = "medium";
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

        public Medium()
        {
            // NCName
            this._properties.Add("id",
                new XFAProperty()
                {
                    Name = "id",
                    Type = EnumXFAPropertyType.Property
                }
            );

            // string
            this._properties.Add("imagingBBox",
                new XFAProperty()
                {
                    Name = "imagingBBox",
                    Type = EnumXFAPropertyType.Property
                }
            );

            // measurementDataType
            this._properties.Add("long",
                new XFAProperty()
                {
                    Name = "long",
                    Type = EnumXFAPropertyType.Property
                }
            );

            this._properties.Add("orientation",
                new XFAProperty()
                {
                    Name = "orientation",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"landscape" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"portrait" }
                    }
                }
            );

            // measurementDataType
            this._properties.Add("short",
                new XFAProperty()
                {
                    Name = "short",
                    Type = EnumXFAPropertyType.Property
                }
            );

            // string
            this._properties.Add("stock",
                new XFAProperty()
                {
                    Name = "stock",
                    Type = EnumXFAPropertyType.Property
                }
            );

            this._properties.Add("trayIn",
                new XFAProperty()
                {
                    Name = "trayIn",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"auto" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"delegate" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"pageFront" }
                    }
                }
            );

            this._properties.Add("trayOut",
                new XFAProperty()
                {
                    Name = "trayOut",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"auto" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"delegate" }
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

        }
    }
}
