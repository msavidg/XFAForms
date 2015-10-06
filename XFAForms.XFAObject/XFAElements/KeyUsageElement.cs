using System.Collections.Generic;

namespace XFAForms.XFAObject.XFAElements
{

    public partial class Keyusage : XFABaseElement
    {

        // <!--An element that specifies the key usage settings required in the signing certificate.-->

        private string _name = "keyUsage";
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

        public Keyusage()
        {
            // string
            this._properties.Add("crlSign",
                new XFAProperty()
                {
                    Name = "crlSign",
                    Type = EnumXFAPropertyType.Property
                }
            );

            // string
            this._properties.Add("dataEncipherment",
                new XFAProperty()
                {
                    Name = "dataEncipherment",
                    Type = EnumXFAPropertyType.Property
                }
            );

            // string
            this._properties.Add("decipherOnly",
                new XFAProperty()
                {
                    Name = "decipherOnly",
                    Type = EnumXFAPropertyType.Property
                }
            );

            // string
            this._properties.Add("digitalSignature",
                new XFAProperty()
                {
                    Name = "digitalSignature",
                    Type = EnumXFAPropertyType.Property
                }
            );

            // string
            this._properties.Add("encipherOnly",
                new XFAProperty()
                {
                    Name = "encipherOnly",
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

            // string
            this._properties.Add("keyAgreement",
                new XFAProperty()
                {
                    Name = "keyAgreement",
                    Type = EnumXFAPropertyType.Property
                }
            );

            // string
            this._properties.Add("keyCertSign",
                new XFAProperty()
                {
                    Name = "keyCertSign",
                    Type = EnumXFAPropertyType.Property
                }
            );

            // string
            this._properties.Add("keyEncipherment",
                new XFAProperty()
                {
                    Name = "keyEncipherment",
                    Type = EnumXFAPropertyType.Property
                }
            );

            // string
            this._properties.Add("nonRepudiation",
                new XFAProperty()
                {
                    Name = "nonRepudiation",
                    Type = EnumXFAPropertyType.Property
                }
            );

            this._properties.Add("type",
                new XFAProperty()
                {
                    Name = "type",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"optional" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"required" }
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
