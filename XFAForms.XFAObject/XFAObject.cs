using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XFAForms.XFAObject.Interfaces;
using XFAForms.XFAObject.Interfaces.DataTypes;

namespace XFAForms.XFAObject
{
    public class XFAObject : IXFAObject
    {

        public DynamicDataXml record { get; set; }

        public DynamicTemplateXml template { get; set; }

    }
}
