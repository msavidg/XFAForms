using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.Core.Logging;
using XFAForms.ConnectionDataDOM.Interfaces;

namespace XFAForms.ConnectionDataDOM
{
    public class ConnectionDataDOM : BaseDOM.BaseDOM, IConnectionDataDOM
    {
        private readonly ILogger _logger;

        public ConnectionDataDOM(ILogger logger)
            : base(logger)
        {
            _logger = logger;
        }
    }
}
