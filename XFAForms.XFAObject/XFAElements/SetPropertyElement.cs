using System.Collections.Generic;

namespace XFAForms.XFAObject.XFAElements
{

    public partial class Setproperty : XFABaseElement
    {

        // <!--An element that causes a property of the container to be copied from a value in the XFA Data DOM or from data returned by a web service.-->

        private string _name = "setProperty";
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

        public Setproperty()
        {
            // string
            this._properties.Add("connection",
                new XFAProperty()
                {
                    Name = "connection",
                    Type = EnumXFAPropertyType.Property
                }
            );

            // string
            this._properties.Add("ref",
                new XFAProperty()
                {
                    Name = "ref",
                    Type = EnumXFAPropertyType.Property
                }
            );

            // string
            this._properties.Add("target",
                new XFAProperty()
                {
                    Name = "target",
                    Type = EnumXFAPropertyType.Property
                }
            );

        }
    }
}
