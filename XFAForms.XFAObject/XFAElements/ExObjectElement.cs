using System.Collections.Generic;

namespace XFAForms.XFAObject.XFAElements
{

    public partial class Exobject : XFABaseElement, IXFAElement
    {

        // <!--An element that describes a single program or implementation-dependent foreign object.-->

        private string _name = "exObject";
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

        public Exobject()
        {
            // string
            this._properties.Add("archive",
                new XFAProperty()
                {
                    Name = "archive",
                    Type = EnumXFAPropertyType.Property
                }
            );

            // string
            this._properties.Add("classId",
                new XFAProperty()
                {
                    Name = "classId",
                    Type = EnumXFAPropertyType.Property
                }
            );

            // string
            this._properties.Add("codeBase",
                new XFAProperty()
                {
                    Name = "codeBase",
                    Type = EnumXFAPropertyType.Property
                }
            );

            // string
            this._properties.Add("codeType",
                new XFAProperty()
                {
                    Name = "codeType",
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

            this._properties.Add("extras",
                new XFAProperty()
                {
                    Name = "extras",
                    Type = EnumXFAPropertyType.StructuredProperty,
                    Values = new List<IXFAPropertyValue>()
                }
            );
            this._properties.Add("boolean",
                new XFAProperty()
                {
                    Name = "boolean",
                    Type = EnumXFAPropertyType.StructuredProperty,
                    Values = new List<IXFAPropertyValue>()
                }
            );
            this._properties.Add("date",
                new XFAProperty()
                {
                    Name = "date",
                    Type = EnumXFAPropertyType.StructuredProperty,
                    Values = new List<IXFAPropertyValue>()
                }
            );
            this._properties.Add("dateTime",
                new XFAProperty()
                {
                    Name = "dateTime",
                    Type = EnumXFAPropertyType.StructuredProperty,
                    Values = new List<IXFAPropertyValue>()
                }
            );
            this._properties.Add("decimal",
                new XFAProperty()
                {
                    Name = "decimal",
                    Type = EnumXFAPropertyType.StructuredProperty,
                    Values = new List<IXFAPropertyValue>()
                }
            );
            this._properties.Add("exData",
                new XFAProperty()
                {
                    Name = "exData",
                    Type = EnumXFAPropertyType.StructuredProperty,
                    Values = new List<IXFAPropertyValue>()
                }
            );
            this._properties.Add("exObject",
                new XFAProperty()
                {
                    Name = "exObject",
                    Type = EnumXFAPropertyType.StructuredProperty,
                    Values = new List<IXFAPropertyValue>()
                }
            );
            this._properties.Add("float",
                new XFAProperty()
                {
                    Name = "float",
                    Type = EnumXFAPropertyType.StructuredProperty,
                    Values = new List<IXFAPropertyValue>()
                }
            );
            this._properties.Add("image",
                new XFAProperty()
                {
                    Name = "image",
                    Type = EnumXFAPropertyType.StructuredProperty,
                    Values = new List<IXFAPropertyValue>()
                }
            );
            this._properties.Add("integer",
                new XFAProperty()
                {
                    Name = "integer",
                    Type = EnumXFAPropertyType.StructuredProperty,
                    Values = new List<IXFAPropertyValue>()
                }
            );
            this._properties.Add("text",
                new XFAProperty()
                {
                    Name = "text",
                    Type = EnumXFAPropertyType.StructuredProperty,
                    Values = new List<IXFAPropertyValue>()
                }
            );
            this._properties.Add("time",
                new XFAProperty()
                {
                    Name = "time",
                    Type = EnumXFAPropertyType.StructuredProperty,
                    Values = new List<IXFAPropertyValue>()
                }
            );
        }
    }
}
