using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.Core.Logging;
using XFAForms.ConnectionSetDOM.Interfaces;

namespace XFAForms.ConnectionSetDOM
{
    public class ConnectionSetDOM : BaseDOM.BaseDOM, IConnectionSetDOM
    {
        private readonly ILogger _logger;

        public ConnectionSetDOM(ILogger logger)
            : base(logger)
        {
            _logger = logger;
        }
    }
}
