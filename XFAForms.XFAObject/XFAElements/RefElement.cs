using System.Collections.Generic;

namespace XFAForms.XFAObject.XFAElements
{

    public partial class Ref : XFABaseElement, IXFAElement
    {

        // <!--An element holding an XFA-SOM expression that identifies a node to be included in an XML digital signature.-->

        private string _name = "ref";
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

        public Ref()
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
