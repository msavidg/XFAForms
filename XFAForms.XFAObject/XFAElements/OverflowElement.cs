using System.Collections.Generic;

namespace XFAForms.XFAObject.XFAElements
{

    public partial class Overflow : XFABaseElement
    {

        // <!--An element that controls what happens when the parent subform or subform set overflows the current layout container.-->

        private string _name = "overflow";
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

        public Overflow()
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
            this._properties.Add("target",
                new XFAProperty()
                {
                    Name = "target",
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
