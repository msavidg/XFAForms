using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.Core.Logging;
using XFAForms.XMLDataDOM.Interfaces;

namespace XFAForms.XMLDataDOM
{
    public class XMLDataDOM : BaseDOM.BaseDOM, IXMLDataDOM
    {
        private readonly ILogger _logger;

        public XMLDataDOM(ILogger logger)
            : base(logger)
        {
            _logger = logger;
        }
    }
}
