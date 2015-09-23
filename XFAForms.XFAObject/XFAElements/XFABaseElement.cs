using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;

namespace XFAForms.XFAObject.XFAElements
{
    public class XFABaseElement : DynamicObject, IXFAElement
    {
        public string Name { get; set; }
        public Dictionary<string, IXFAProperty> Properties { get; set; }
        public EnumXFAElementType Type { get; set; }
        public List<string> Children { get; set; }
    }
}
