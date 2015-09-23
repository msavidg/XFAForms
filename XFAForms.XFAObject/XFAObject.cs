using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XFAForms.XFAObject.DynamicObjects;
using XFAForms.XFAObject.Interfaces;

namespace XFAForms.XFAObject
{
    public class XFAObject : IXFAObject
    {

        public DynamicObject record { get; set; }

        public DynamicObject template { get; set; }

    }
}
