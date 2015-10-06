using System.Collections.Generic;

namespace XFAForms.XFAObject.XFAElements
{

    public partial class Area : XFABaseElement
    {

        // <!--A container representing a geographical grouping of other containers.-->

        private string _name = "area";
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

        public Area()
        {
            // integerDataType
            this._properties.Add("colSpan",
                new XFAProperty()
                {
                    Name = "colSpan",
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
            this._properties.Add("area",
                new XFAProperty()
                {
                    Name = "area",
                    Type = EnumXFAPropertyType.StructuredProperty,
                    Values = new List<IXFAPropertyValue>()
                }
            );
            this._properties.Add("draw",
                new XFAProperty()
                {
                    Name = "draw",
                    Type = EnumXFAPropertyType.StructuredProperty,
                    Values = new List<IXFAPropertyValue>()
                }
            );
            this._properties.Add("exclGroup",
                new XFAProperty()
                {
                    Name = "exclGroup",
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
            this._properties.Add("field",
                new XFAProperty()
                {
                    Name = "field",
                    Type = EnumXFAPropertyType.StructuredProperty,
                    Values = new List<IXFAPropertyValue>()
                }
            );
            this._properties.Add("subform",
                new XFAProperty()
                {
                    Name = "subform",
                    Type = EnumXFAPropertyType.StructuredProperty,
                    Values = new List<IXFAPropertyValue>()
                }
            );
            this._properties.Add("subformSet",
                new XFAProperty()
                {
                    Name = "subformSet",
                    Type = EnumXFAPropertyType.StructuredProperty,
                    Values = new List<IXFAPropertyValue>()
                }
            );
        }
    }
}
