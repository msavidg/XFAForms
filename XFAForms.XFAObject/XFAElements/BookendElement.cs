using System.Collections.Generic;

namespace XFAForms.XFAObject.XFAElements
{

    public partial class Bookend : XFABaseElement, IXFAElement
    {

        // <!--An element controlling content that is inserted to "bookend" the contents of the parent object.-->

        private string _name = "bookend";
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

        public Bookend()
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
            this._properties.Add("leader",
                new XFAProperty()
                {
                    Name = "leader",
                    Type = EnumXFAPropertyType.Property
                }
            );

            // string
            this._properties.Add("trailer",
                new XFAProperty()
                {
                    Name = "trailer",
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
