using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XFAForms.XFAObject.XFAElements
{
    class XFAProperty : IXFAProperty
    {
        private string _name;
        private EnumXFAPropertyType _type;
        private List<IXFAPropertyValue> _values;
        private int? _minOccurrence = 0;
        private int? _maxOccurrence = 1;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public EnumXFAPropertyType Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public List<IXFAPropertyValue> Values
        {
            get { return _values; }
            set { _values = value; }
        }

        public int? MinOccurrence
        {
            get { return _minOccurrence; }
            set { _minOccurrence = value; }
        }

        public int? MaxOccurrence
        {
            get { return _maxOccurrence; }
            set { _maxOccurrence = value; }
        }
    }
}
