using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XFAForms.XFAObject.XFAElements
{
    public class XFAPropertyValue : IXFAPropertyValue, IXFAMeasurement
    {
        private EnumXFAPropertyValueType _type = EnumXFAPropertyValueType.String;
        private string _value = String.Empty;
        private bool _isDefault = false;
        private EnumXFAUnit _unit = EnumXFAUnit.UnitNone;

        public EnumXFAPropertyValueType Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public string Value
        {
            get { return _value; }
            set { _value = value; }
        }

        public bool IsDefault
        {
            get { return _isDefault; }
            set { _isDefault = value; }
        }

        public EnumXFAUnit Unit
        {
            get { return _unit; }
            set { _unit = value; }
        }

        public string ToCentimeters()
        {
            throw new NotImplementedException();
        }

        public string ToInches()
        {
            throw new NotImplementedException();
        }

        public string ToMillimeters()
        {
            throw new NotImplementedException();
        }

        public string ToPoints()
        {
            throw new NotImplementedException();
        }
    }
}
