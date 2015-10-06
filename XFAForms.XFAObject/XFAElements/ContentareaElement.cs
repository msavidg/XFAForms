using System.Collections.Generic;

namespace XFAForms.XFAObject.XFAElements
{

    public partial class Contentarea : XFABaseElement
    {

        // <!--An element that describes a region within a page area eligible for receiving content.-->

        private string _name = "contentArea";
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

        public Contentarea()
        {
            // measurementDataType
            this._properties.Add("h",
                new XFAProperty()
                {
                    Name = "h",
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
            this._properties.Add("relevant",
                new XFAProperty()
                {
                    Name = "relevant",
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

            // measurementDataType
            this._properties.Add("w",
                new XFAProperty()
                {
                    Name = "w",
                    Type = EnumXFAPropertyType.Property
                }
            );

            // measurementDataType
            this._properties.Add("x",
                new XFAProperty()
                {
                    Name = "x",
                    Type = EnumXFAPropertyType.Property
                }
            );

            // measurementDataType
            this._properties.Add("y",
                new XFAProperty()
                {
                    Name = "y",
                    Type = EnumXFAPropertyType.Property
                }
            );

            this._properties.Add("desc",
                new XFAProperty()
                {
                    Name = "desc",
                    Type = EnumXFAPropertyType.StructuredProperty,
                    Values = new List<IXFAPropertyValue>()
                }
            );
            this._properties.Add("extras",
                new XFAProperty()
                {
                    Name = "extras",
                    Type = EnumXFAPropertyType.StructuredProperty,
                    Values = new List<IXFAPropertyValue>()
                }
            );
        }
    }
}
