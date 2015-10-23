using System.Collections.Generic;

namespace XFAForms.XFAObject.XFAElements
{

    public partial class Occur : XFABaseElement, IXFAElement
    {

        // <!--An element that describes the constraints over the number of allowable instances for its enclosing container.-->

        private string _name = "occur";
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

        public Occur()
        {
            // NCName
            this._properties.Add("id",
                new XFAProperty()
                {
                    Name = "id",
                    Type = EnumXFAPropertyType.Property
                }
            );

            // integerDataType
            this._properties.Add("initial",
                new XFAProperty()
                {
                    Name = "initial",
                    Type = EnumXFAPropertyType.Property
                }
            );

            // integerDataType
            this._properties.Add("max",
                new XFAProperty()
                {
                    Name = "max",
                    Type = EnumXFAPropertyType.Property
                }
            );

            // integerDataType
            this._properties.Add("min",
                new XFAProperty()
                {
                    Name = "min",
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
        }
    }
}
