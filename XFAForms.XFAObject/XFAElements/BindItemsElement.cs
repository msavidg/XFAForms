using System.Collections.Generic;

namespace XFAForms.XFAObject.XFAElements
{

    public partial class Binditems : XFABaseElement
    {

        // <!--An element that extracts data into an item list.-->

        private string _name = "bindItems";
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

        public Binditems()
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
            this._properties.Add("labelRef",
                new XFAProperty()
                {
                    Name = "labelRef",
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
            this._properties.Add("valueRef",
                new XFAProperty()
                {
                    Name = "valueRef",
                    Type = EnumXFAPropertyType.Property
                }
            );

        }
    }
}
