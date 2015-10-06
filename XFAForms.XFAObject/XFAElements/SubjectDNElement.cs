using System.Collections.Generic;

namespace XFAForms.XFAObject.XFAElements
{

    public partial class Subjectdn : XFABaseElement
    {

        // <!--An element that contains a key-value pair used to specify the Subject Distinguished Name (DN) that must be present within the certificate for it to be acceptable for signing.-->

        private string _name = "subjectDN";
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

        public Subjectdn()
        {
            // string
            this._properties.Add("delimiter",
                new XFAProperty()
                {
                    Name = "delimiter",
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

        }
    }
}
