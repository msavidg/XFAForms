using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using Castle.Core.Logging;
using Microsoft.CSharp;
using XFAForms.XMLDataDom.Interfaces;

namespace XFAForms.XMLDataDOM
{
    public class XMLDataDOM : BaseDOM.BaseDOM, IXMLDataDOM
    {
        private readonly ILogger _logger;

        private XDocument _formData;

        public XMLDataDOM(ILogger logger)
            : base(logger)
        {
            _logger = logger;
        }

        public override void Initialize(XDocument formData)
        {

            _logger.Debug("XMLDataDOM Initialize!");

            _formData = formData;

        }
    }
}
