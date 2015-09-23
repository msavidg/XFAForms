using System.IO;
using System.Xml.Linq;
using Castle.Core.Logging;
using XFAForms.XFADataDOM.Interfaces;
using XFAForms.XFAObject.DynamicObjects;
using XFAForms.XFAObject.Interfaces;

namespace XFAForms.XFADataDOM
{
    public class XFADataDOM : BaseDOM.BaseDOM, IXFADataDOM
    {
        private readonly ILogger _logger;

        private XDocument _formData;

        public XFADataDOM(ILogger logger) : base(logger)
        {

            _logger = logger;

        }

        public void Initialize(IXFAObject xfaObject, XDocument formData)
        {

            _formData = formData;

            xfaObject.record = new DynamicDataXml(formData.ToString());

        }
    }
}
