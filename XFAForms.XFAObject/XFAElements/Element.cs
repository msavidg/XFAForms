using System.Collections.Generic;

namespace XFAForms.XFAObject.XFAElements
{

    public partial class  : XFABaseElement, IXFAElement
    {

        // 

        private string _name = "";
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

        public ()
        {
        }
    }
}
