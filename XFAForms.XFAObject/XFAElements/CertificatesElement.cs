using System.Collections.Generic;

namespace XFAForms.XFAObject.XFAElements
{

    public partial class Certificates : XFABaseElement
    {

        // <!--An element that holds a collection of certificate filters used to identify the signer.-->

        private string _name = "certificates";
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

        public Certificates()
        {
            this._properties.Add("credentialServerPolicy",
                new XFAProperty()
                {
                    Name = "credentialServerPolicy",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"optional" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"required" }
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

            // string
            this._properties.Add("url",
                new XFAProperty()
                {
                    Name = "url",
                    Type = EnumXFAPropertyType.Property
                }
            );

            // string
            this._properties.Add("urlPolicy",
                new XFAProperty()
                {
                    Name = "urlPolicy",
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

            this._properties.Add("encryption",
                new XFAProperty()
                {
                    Name = "encryption",
                    Type = EnumXFAPropertyType.StructuredProperty,
                    Values = new List<IXFAPropertyValue>()
                }
            );
            this._properties.Add("issuers",
                new XFAProperty()
                {
                    Name = "issuers",
                    Type = EnumXFAPropertyType.StructuredProperty,
                    Values = new List<IXFAPropertyValue>()
                }
            );
            this._properties.Add("keyUsage",
                new XFAProperty()
                {
                    Name = "keyUsage",
                    Type = EnumXFAPropertyType.StructuredProperty,
                    Values = new List<IXFAPropertyValue>()
                }
            );
            this._properties.Add("oids",
                new XFAProperty()
                {
                    Name = "oids",
                    Type = EnumXFAPropertyType.StructuredProperty,
                    Values = new List<IXFAPropertyValue>()
                }
            );
            this._properties.Add("signing",
                new XFAProperty()
                {
                    Name = "signing",
                    Type = EnumXFAPropertyType.StructuredProperty,
                    Values = new List<IXFAPropertyValue>()
                }
            );
            this._properties.Add("subjectDNs",
                new XFAProperty()
                {
                    Name = "subjectDNs",
                    Type = EnumXFAPropertyType.StructuredProperty,
                    Values = new List<IXFAPropertyValue>()
                }
            );
        }
    }
}
