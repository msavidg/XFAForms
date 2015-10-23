using System.Collections.Generic;

namespace XFAForms.XFAObject.XFAElements
{

    public partial class Exdata : XFABaseElement, IXFAElement
    {

        // <!--A content element that describes a single unit of data of a foreign datatype.-->

        private string _name = "exData";
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

        public Exdata()
        {
            // string
            this._properties.Add("contentType",
                new XFAProperty()
                {
                    Name = "contentType",
                    Type = EnumXFAPropertyType.Property
                }
            );

            // string
            this._properties.Add("href",
                new XFAProperty()
                {
                    Name = "href",
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

            // integerDataType
            this._properties.Add("maxLength",
                new XFAProperty()
                {
                    Name = "maxLength",
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

            // string
            this._properties.Add("rid",
                new XFAProperty()
                {
                    Name = "rid",
                    Type = EnumXFAPropertyType.Property
                }
            );

            this._properties.Add("transferEncoding",
                new XFAProperty()
                {
                    Name = "transferEncoding",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"base64" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"none" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"package" }
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
