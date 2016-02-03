using System.Collections.Generic;

namespace XFAForms.XFAObject.XFAElements
{

    public partial class Filter : XFABaseElement, IXFAElement
    {

        // <!--An element that contains the criteria for filtering signing certificates used to generate XML digital signatures.-->

        private string _name = "filter";
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

        public Filter()
        {
            // string
            this._properties.Add("addRevocationInfo",
                new XFAProperty()
                {
                    Name = "addRevocationInfo",
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

            // NCName
            this._properties.Add("name",
                new XFAProperty()
                {
                    Name = "name",
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

            // string
            this._properties.Add("version",
                new XFAProperty()
                {
                    Name = "version",
                    Type = EnumXFAPropertyType.Property
                }
            );

            this._properties.Add("appearanceFilter",
                new XFAProperty()
                {
                    Name = "appearanceFilter",
                    Type = EnumXFAPropertyType.StructuredProperty,
                    Values = new List<IXFAPropertyValue>()
                }
            );
            this._properties.Add("certificates",
                new XFAProperty()
                {
                    Name = "certificates",
                    Type = EnumXFAPropertyType.StructuredProperty,
                    Values = new List<IXFAPropertyValue>()
                }
            );
            this._properties.Add("digestMethods",
                new XFAProperty()
                {
                    Name = "digestMethods",
                    Type = EnumXFAPropertyType.StructuredProperty,
                    Values = new List<IXFAPropertyValue>()
                }
            );
            this._properties.Add("encodings",
                new XFAProperty()
                {
                    Name = "encodings",
                    Type = EnumXFAPropertyType.StructuredProperty,
                    Values = new List<IXFAPropertyValue>()
                }
            );
            this._properties.Add("encryptionMethods",
                new XFAProperty()
                {
                    Name = "encryptionMethods",
                    Type = EnumXFAPropertyType.StructuredProperty,
                    Values = new List<IXFAPropertyValue>()
                }
            );
            this._properties.Add("handler",
                new XFAProperty()
                {
                    Name = "handler",
                    Type = EnumXFAPropertyType.StructuredProperty,
                    Values = new List<IXFAPropertyValue>()
                }
            );
            this._properties.Add("lockDocument",
                new XFAProperty()
                {
                    Name = "lockDocument",
                    Type = EnumXFAPropertyType.StructuredProperty,
                    Values = new List<IXFAPropertyValue>()
                }
            );
            this._properties.Add("mdp",
                new XFAProperty()
                {
                    Name = "mdp",
                    Type = EnumXFAPropertyType.StructuredProperty,
                    Values = new List<IXFAPropertyValue>()
                }
            );
            this._properties.Add("reasons",
                new XFAProperty()
                {
                    Name = "reasons",
                    Type = EnumXFAPropertyType.StructuredProperty,
                    Values = new List<IXFAPropertyValue>()
                }
            );
            this._properties.Add("timeStamp",
                new XFAProperty()
                {
                    Name = "timeStamp",
                    Type = EnumXFAPropertyType.StructuredProperty,
                    Values = new List<IXFAPropertyValue>()
                }
            );
        }
    }
}
