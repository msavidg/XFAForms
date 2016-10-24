using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.Core.Logging;
using XFAForms.ConnectionSetDataDOM.Interfaces;

namespace XFAForms.ConnectionSetDataDOM
{

    /*
     * This DOM is a temporary buffer holding data going to or coming from a WSDL service, or data going to an
     * HTTP server for a POST operation.
     * When used with WSDL this DOM is loaded from and/or written to XML documents, but those documents
     * are transient messages exchanged with the web service.
     * 
     * This DOM is never loaded from or written out to an XDP or other persistent document.
     * 
     */

    public class ConnectionSetDataDOM : BaseDOM.BaseDOM, IConnectionSetDataDOM
    {
        private readonly ILogger _logger;

        public ConnectionSetDataDOM(ILogger logger)
            : base(logger)
        {
            _logger = logger;
        }
    }
}
